using System;
namespace ECenter
{
    class Program
    {
        public static void Main()
        {
            //Creating teachers
            Teachers teacher1 = new Teachers("TName1", "TSername1", new DateTime(1980, 1, 1), "Faculty", "Professor");
            Teachers teacher2 = new Teachers("TName2", "TSername2", new DateTime(1981, 2, 2), "Faculty", "Professor");

            //Creating students
            Students student1 = new Students("SName1", "SSername1", new DateTime(1999, 1, 2), "Faculty", 001);
            Students student2 = new Students("SName2", "SSername2", new DateTime(2000, 1, 2), "Faculty", 002);

            //Creating cources
            Cources cource1 = new Cources("Cource1", 36);
            Cources cource2 = new Cources("Cource2", 10);

            //Assigning teacher to the cources
            teacher1.AssignCource(cource1);

            //Applying student for the cources
            student1.AttendCource(cource1);


            //Displaying info
            Console.WriteLine(teacher1.GetInfo());
            Console.WriteLine(teacher2.GetInfo());


            Console.WriteLine(student1);
            Console.WriteLine(student1.AttendingCources());

            Console.WriteLine(student2);
            Console.WriteLine(student2.AttendingCources());


            Console.WriteLine(cource1.GetAllStudents());
            Console.WriteLine(cource2.GetAllStudents());
        }
    }
}