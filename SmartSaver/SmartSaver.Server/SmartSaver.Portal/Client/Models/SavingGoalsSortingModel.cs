namespace SmartSaver.Portal.Client.Models
{
    public class SavingGoalsSortingModel
    {
        public SavingGoalsSortingEnum SortingColumn { get; set; } = SavingGoalsSortingEnum.StartDate;

        public bool IsAscending { get; set; } = true;
    }
}
