using SmartSaver.Portal.Client.Pages.Transactions;

namespace SmartSaver.Portal.Client.Models
{
    public class TransactionsSortingModel
    {
        public TransactionsSortingEnum SortingColumn { get; set; } = TransactionsSortingEnum.CreatedAt;

        public bool IsAscending { get; set; } = true;
    }
}