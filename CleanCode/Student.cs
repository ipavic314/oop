using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    class Student : Osoba, IComparable<Student>
    {
        private int id;
        private static int idGenerator;

        public Student(string ime, string prezime, StudentTip tip) : base(ime, prezime)
        {
            id = ++idGenerator;
            Tip = tip;
        }

        public StudentTip Tip { get; set; }
        public enum StudentTip
        {
            Izvanredni, 
            Redovni

        }

        public override string ToString() => $"Id: {id}, {base.ToString()} ";

        public override bool Equals(object obj) => obj is Student other ? id == other.id : false;

        public override int GetHashCode() => id.GetHashCode();

        public int CompareTo(Student other) => -id.CompareTo(other.id);
      
    }
}
