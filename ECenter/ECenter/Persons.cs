using System;
namespace ECenter
{
    abstract public class Persons
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDay { get; set; }

        protected Persons(string firstname, string secondname, DateTime dbirth)
        {
            FirstName = firstname;
            SecondName = secondname;
            BirthDay = dbirth;
        }

        public virtual int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - this.BirthDay.Year;
            if (this.BirthDay.Date > today.AddYears(-age)) age--;

            return age;
        }

        public override string ToString()
        {
            return $"\n{this.GetType().Name}:\n\tFirst Name: {FirstName}\n\tSecond Name: {SecondName}\n\tAge: {GetAge()}";
        }
    }
}