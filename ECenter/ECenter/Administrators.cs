using System;
namespace ECenter
{
    public class Administrators : Persons, IEmployee
    {
        public string Laboratory { get; set; }
        public DateTime HiredDate { get; set; }
        public decimal Wage { get; set; }
        public decimal Bonus { get; set; }
        public bool Disciplinary { get; set; }

        public Administrators(string firstname, string secondname, DateTime dbirth, string lab,
                                decimal wage = 50000m, decimal bonus = 0.0m) : base(firstname, secondname, dbirth)
        {
            Laboratory = lab;
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