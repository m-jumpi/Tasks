using System;
namespace ECenter
{
    public class Teachers : Persons, IEmployee
    {
        public string Faculty { get; set; }
        public string Position { get; set; }
        public DateTime HiredDate { get; set; }
        public decimal Wage { get; set; }
        public decimal Bonus { get; set; }
        public bool Disciplinary { get; set; }
        private List<Cources> ListCources = new List<Cources>();

        public Teachers(string firstname, string secondname, DateTime dbirth, string faculty,
                        string position, decimal wage = 100000m, decimal bonus = 0.05m) : base(firstname, secondname, dbirth)
        {
            Faculty = faculty;
            Position = position;
            Wage = wage;
            Bonus = bonus;
        }

        public void AssignCource(Cources course)
        {
            try
            {
                course.AssignTeacher(this);
                ListCources.Add(course);
            }
            catch (ArgumentException ex)
            {
            }
        }

        public string TeachingCources()
        {
            var result = "";
            if (ListCources.Count != 0)
            {
                foreach (var cource in ListCources)
                {
                    result += cource.Info();
                }
            }
            else
            {
                result = $"\tNo cources assigned\n";
            }
            return result;
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

        public string GetInfo()
        {
            return $"\n{this.GetType().Name}:\n\t{FirstName} {SecondName}\n\tAge: {GetAge()}\n\tSalary: {GetSalary()}\nTeaching Cources:\n{TeachingCources()}";
        }
    }
}