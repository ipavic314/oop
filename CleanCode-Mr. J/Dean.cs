using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspit
{
    class Dean : Person
    {
        public string Title { get; set; }
        public Dean(string name, string surname, string title) : base(name, surname)
        {
            Title = title;
        }

        public void SignSignable(ISignable signable) => signable.Sign();
    }
}
