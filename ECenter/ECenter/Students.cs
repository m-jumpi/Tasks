using System;
namespace ECenter
{
    public class Students : Persons
    {
        public string Faculty { get; set; }
        public int Group { get; set; }
        private List<Cources> ListCources = new List<Cources>();

        public Students(string firstname, string secondname, DateTime dbirth, string faculty, int group) : base(firstname, secondname, dbirth)
        {
            Faculty = faculty;
            Group = group;
        }

        public void AttendCource(Cources cource)
        {
            try
            {
                cource.AddStudent(this);
                ListCources.Add(cource);

            }
            catch (ArgumentException ex)
            {
            }
        }

        public string AttendingCources()
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
                result = $"\tNo cources assigned";
            }
            return result;
        }
    }
}