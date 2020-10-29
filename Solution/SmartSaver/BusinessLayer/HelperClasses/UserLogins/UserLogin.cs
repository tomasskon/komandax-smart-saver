using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreKit.Cryptography.PBKDF2;
using SmartSaver.Domain.Repositories;

namespace SmartSaver.Logic.HelperClasses.UserLogins
{
    public class UserLogin
    {
        private readonly UserLoginsRepository _userLoginsRepository;

        public UserLogin(UserLoginsRepository userLoginsRepository)
        {
            _userLoginsRepository = userLoginsRepository;
        }

        public async Task<bool> AttemptLogin(Guid userId, string password)
        {
            var existingCompositeKey = await _userLoginsRepository.GetUserLogin(userId);
            if (existingCompositeKey == null)
                return false;

            return await CompareHash(password, existingCompositeKey);
        }

        public async Task CreateLogin(Guid userId, string password)
        {
            var compositeKey = await HashAndBuildNewCompositeKey(password);
            await _userLoginsRepository.CreateUserLogin(userId, compositeKey);
        }

        #region Hashed Password statics

        private const int HashIterations = 100000;
        private const int HashSaltBytesLength = 34;

        private static PBKDF2Kit Kit => new PBKDF2Kit(new PBKDF2KitConfiguration
        {
            HashIterations = HashIterations,
            SaltSize = HashSaltBytesLength
        });

        private static string BuildSalt()
        {
            return Kit.Salt;
        }

        private static async Task<byte[]> HashAndBuildNewCompositeKey(string password)
        {
            var salt = BuildSalt();
            var hash = await Hash(password, salt);
            return BuildCompositeKey(hash, salt);
        }

        private static async Task<byte[]> Hash(string password, string salt)
        {
            var hashBase64 = await Task.Run(() => Kit.GenerateHash(password, salt));
            return Convert.FromBase64String(hashBase64);
        }

        private static async Task<bool> CompareHash(string password, byte[] existingCompositeKey)
        {
            var (existingHash, salt) = DeconstructCompositeKey(existingCompositeKey);
            var testHash = await Hash(password, salt);

            return Kit.Compare(Convert.ToBase64String(testHash), Convert.ToBase64String(existingHash));
        }

        private static (byte[] hash, string salt) DeconstructCompositeKey(byte[] compositeKey)
        {
            var saltLength = compositeKey.First();
            var saltBytes = compositeKey.Skip(1).Take(saltLength).ToArray();
            var hashBytes = compositeKey.Skip(saltLength + 1).ToArray();

            var saltString = Encoding.UTF8.GetString(saltBytes);
            return (hashBytes, saltString);
        }

        private static byte[] BuildCompositeKey(byte[] hash, string salt)
        {
            var saltBytes = Encoding.UTF8.GetBytes(salt);
            return new[] { (byte)saltBytes.Length }
                .Concat(saltBytes)
                .Concat(hash).ToArray();
        }

        #endregion
    }
}
