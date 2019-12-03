using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Maja", "Majic", Student.StudentTip.Izvanredni);
            Student s2 = new Student("Nela", "Nelic", Student.StudentTip.Redovni);
            Student s3 = new Student("Mijo", "Likic", Student.StudentTip.Izvanredni);

            List<Student> students = new List<Student> { s1, s2, s3 };
            students.ForEach(Console.WriteLine);

            students.Sort();
            students.ForEach(Console.WriteLine);
            students.Sort(new StudentPoPrezimenu());
            students.ForEach(Console.WriteLine);


            Kolegij k = new Kolegij("456", "OOP", 25);
            Console.WriteLine(k);

            Predavac ass = new Predavac("Daniel", "Bele", k);
            Predavac prof = new Predavac("Ivo", "Ivic", k);
            Console.WriteLine(ass);
            Console.WriteLine(prof);

            Dekan d = new Dekan("Pero", "Peric", "dr.sc");
            Console.WriteLine(d);

            List<Osoba> o = new List<Osoba> { ass, prof, d };
            o.ForEach(Console.WriteLine);

            Dokument doc = new Dokument("Molba", "Molba za skolarinu");
            Console.WriteLine(doc);
            Console.WriteLine("---------------------------");
            List<IPotpis> potpis = new List<IPotpis> { k, doc };
            foreach (var item in potpis)
            {
                d.DajPotpis(item);
            }

            potpis.ForEach(Console.WriteLine);

        }
    }
}
