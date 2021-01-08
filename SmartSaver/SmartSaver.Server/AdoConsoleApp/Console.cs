using System;
using System.Data.SqlClient;
using System.Data;
namespace AdoConsoleApp
{
    public class Console
    {
        public static void Main(string[] args)
        {

            System.Console.WriteLine("Connected to database");
            System.Console.WriteLine("Navigate using keyboard inputs");
            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();
            System.Console.WriteLine("\n");
            var menuInput = '0';
            PrintMenu();
            while (menuInput != '9')
            {
                menuInput = System.Console.ReadKey().KeyChar;
                System.Console.WriteLine("\n");

                switch (menuInput)
                {
                    case '1':
                        Commands.SelectData();
                        continue;

                    case '2':
                        System.Console.WriteLine("Enter table name: ");
                        string tname = System.Console.ReadLine();
                        System.Console.WriteLine("Enter column name: ");
                        string cname = System.Console.ReadLine();
                        System.Console.WriteLine("Enter value: ");
                        string val = System.Console.ReadLine();
                        Commands.deleteRow(tname, cname, val);
                        continue;

                    case '3':
                        System.Console.WriteLine("Enter email:");
                        string email = System.Console.ReadLine();
                        System.Console.WriteLine("Enter cash balance:");
                        float cash = float.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Enter card balance:");
                        float card = float.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Enter full name:");
                        string fname = System.Console.ReadLine();
                        Commands.insertRow(email, cash, card, fname);
                        continue;

                    case '4':
                        System.Console.WriteLine("Enter the full name of the user:");
                        string fullname = System.Console.ReadLine();
                        System.Console.WriteLine("Change email:");
                        string gmail = System.Console.ReadLine();
                        System.Console.WriteLine("Change cash balance:");
                        float _cash = float.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Change card balance:");
                        float _card = float.Parse(System.Console.ReadLine());
                        Commands.updateRow(gmail, _cash, _card, fullname);
                        continue;

                    case '9':
                        break;
                }
            }
        }

        private static void PrintMenu()
        {
            System.Console.WriteLine("1. View database contents");
            System.Console.WriteLine("2. Delete specified data");
            System.Console.WriteLine("3. Insert new user");
            System.Console.WriteLine("4. Update existing user");
            System.Console.WriteLine("9. Exit");
        }
    }
}
