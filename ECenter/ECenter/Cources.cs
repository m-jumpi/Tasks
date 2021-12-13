using System;
namespace ECenter
{
    public class Cources
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public int MaxStudents { get; set; }
        protected Teachers Teacher { get; set; }
        private List<Students> StudentsList = new List<Students>();

        public Cources(string name, int duration, int maxStudents = 1, Teachers teacher = null)
        {
            Name = name;
            Duration = duration;
            Teacher = teacher;
            MaxStudents = maxStudents;
        }

        public void AssignTeacher(Teachers teacher)
        {
            if (Teacher == null)
            {
                Teacher = teacher;
            }
            else
            {
                throw new ArgumentException("Teacher has been already assigned");
            }
        }

        public void AddStudent(Students student)
        {
            if (MaxStudents > 0)
            {
                StudentsList.Add(student);
                MaxStudents -= 1;
            }
            else
            {
                throw new ArgumentException("Cource reached maximum number of students");
            }
        }

        public string GetAllStudents()
        {
            var result = $"\n{this.Name}:\n\t";
            if (StudentsList.Count != 0)
            {
                foreach (var student in StudentsList)
                {
                    result += $"{student.FirstName} {student.SecondName}\n";
                }
            }
            else
            {
                result += $"No students applied for the cource";
            }
            return result;
        }

        public string Info()
        {
            if (Teacher != null)
            {
                return $"\t{Name}\n\tTeacher: {Teacher.FirstName} {Teacher.SecondName}\n\t{Duration} hours\n";
            }
            else
            {
                return $"\t{Name}\n\tTeacher: has not been assigned yet\n\t{Duration} hours\n";
            }
        }
    }
}