using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspit 
{
    class Dokument : ISignable
    {
        public Dokument(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public string Name { get; set; }
        public string Text { get; set; }
        public bool Signed { get; set; }

        public void Sign() => this.Signed = true;
    }
}
