using System;

namespace SmartSaver.Presentation.Models
{
    public class SavingGoal
    {
        public string GoalName { get; set; }

        public string Description { get; set; }

        public double GoalAmount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public double Progress { get; set; }

        public double ProgressPercentageValue
        {
            get => (Progress / GoalAmount) * 100;
        }

        public Guid UserId { get; set; }

        

        public static SavingGoal[] GenerateMockData()
        {
            Guid guid = new Guid("6e33fa08-bc0f-438c-a21b-bcf4fc227661");
            SavingGoal[] goals = new SavingGoal[3];
            goals[0] = new SavingGoal
            {
                GoalName = "test1",
                Description = "testing",
                GoalAmount = 100.48,
                StartDate = DateTime.Now,
                FinishDate = DateTime.Today.AddDays(1),
                Progress = 0.48,
                UserId = guid
            };
            goals[1] = new SavingGoal
            {
                GoalName = "test2",
                Description = "testing",
                GoalAmount = 500,
                StartDate = DateTime.Now,
                FinishDate = DateTime.Today.AddDays(3),
                Progress = 120,
                UserId = guid
            };
            goals[2] = new SavingGoal
            {
                GoalName = "test3",
                Description = "testing",
                GoalAmount = 420,
                StartDate = DateTime.Now,
                FinishDate = DateTime.Today.AddDays(7),
                Progress = 300,
                UserId = guid
            };
            return goals;
        }
    }
}