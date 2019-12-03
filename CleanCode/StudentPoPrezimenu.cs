using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    class StudentPoPrezimenu : IComparer<Student>
    {
        public int Compare(Student x, Student y) => x.Prezime.CompareTo(y.Prezime);
       
    }
}
