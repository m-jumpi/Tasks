using System;
namespace ECenter
{
    public class Managers : Persons, IEmployee
    {
        public string Faculty { get; set; }
        public string Position { get; set; }

        public DateTime HiredDate { get; set; }

        public decimal Wage { get; set; }
        public decimal Bonus { get; set; }
        public bool Disciplinary { get; set; }

        public Managers(string firstname, string secondname, DateTime dbirth, string faculty,
                        string position, decimal wage = 50000m, decimal bonus = 0.2m) : base(firstname, secondname, dbirth)
        {
            Faculty = faculty;
            Position = position;
        }

        public decimal GetSalary()
        {
            if (!Disciplinary)
            {
                return Wage * (1 - IEmployee.Tax + Bonus);
            }
            else
            {
                return Wage * (1 - IEmployee.Tax);
            }
        }
    }
}