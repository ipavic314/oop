using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj06z2
{
    class Knjiga : IComparable<Knjiga>
    {
        private int id;
        private static int idGenerator;
        private long isbn;

        public Knjiga(string naslov, string autor, long isbn)
        {
            id = ++idGenerator;
            Naslov = naslov;
            Autor = autor;
            Isbn = isbn;
        }

        public string Naslov { get; set; }
        public string Autor { get; set; }

        public long Isbn
        {
            get => isbn;
            set
            {
                if (value.ToString().Length != 13 || !value.ToString().All(char.IsDigit))
                {
                    throw new Exception("Greska");

                }
                isbn = value;
            }

        }
        public int CompareTo(Knjiga other) => -Isbn.CompareTo(other.Isbn);
        public override string ToString() => $"Book: {id}\t{Isbn}\t{Naslov}\t{Autor}";

    }
    }
