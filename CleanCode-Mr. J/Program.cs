using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspit
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Student Job
            Student luka = new Student("Luka", "Brx", StudentType.FullTime);
            Student pavic = new Student("Ivan", "Pax", StudentType.PartTime);
            Student joka = new Student("Josip", "Jox", StudentType.FullTime);

            List<Student> students = new List<Student>() { luka, pavic, joka };
            students.ForEach(Console.WriteLine);
            Console.WriteLine("================================");

            students.Sort();
            students.ForEach(Console.WriteLine);
            Console.WriteLine("================================");

            students.Sort((s1, s2) => -s1.Surname.CompareTo(s2.Surname));
            students.ForEach(Console.WriteLine);
            Console.WriteLine("================================");
            #endregion Student Job

            Subject subject = new Subject("S1234", 25, "OOP");
            Console.WriteLine(subject.ToString());
            Console.WriteLine("-------------------------------");

            Professor professor = new Professor("daniel", "kucak", subject);
            Console.WriteLine(professor.ToString());
            Assistent assistent = new Assistent("daniel", "bele", subject);
            Console.WriteLine(assistent.ToString());
            Console.WriteLine("-------------------------------");

        }
    }
}
