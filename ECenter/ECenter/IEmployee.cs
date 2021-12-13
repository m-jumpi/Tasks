using System;
namespace ECenter
{
    public interface IEmployee
    {
        public DateTime HiredDate { get; set; }
        public decimal Wage { get; set; }
        const decimal Tax = 0.13m;
        public decimal Bonus { get; set; }
        public bool Disciplinary { get; set; }

        int GetExperiance()
        {
            var today = DateTime.Today;
            var experience = today.Year - this.HiredDate.Year;
            if (this.HiredDate.Date > today.AddYears(-experience)) experience--;

            return experience;
        }

        decimal GetSalary();
    }
}