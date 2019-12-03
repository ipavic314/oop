using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspit
{
    enum StudentType
    { 
        FullTime,
        PartTime    
    }
    class Student : Person, IComparable<Student>
    {
        private static int id;
        public int Id { get; }
        public StudentType Type { get; set; }

        public Student(string name, string surname, StudentType type) : base(name, surname)
        {
            Id = ++id;
            Type = type;
        }

        public int CompareTo(Student other) => -this.Id.CompareTo(other.Id); //minus smo stavili jer hocemo da padajuce sortira.

        public override string ToString() => $"{Id} - {base.ToString()} - {Type}";

        public override bool Equals(object obj) => this.Id == (obj as Student).Id;

        public override int GetHashCode() => Id * (Name.Length + Surname.Length);
    }
}
