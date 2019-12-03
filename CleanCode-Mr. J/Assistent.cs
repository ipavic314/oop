using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspit
{
    class Assistent : Person
    {
        public Subject Subject  { get; set; }
        public Assistent(string name, string surname, Subject subject) : base(name, surname)
        {
            Subject = subject;
        }
    }
}
