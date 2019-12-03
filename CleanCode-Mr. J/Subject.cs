namespace PripremaZaIspit
{
    public class Subject : ISignable
    {
        public string Code { get; set; }

        private int ects;

        public string  Name { get; set; }

        public Subject(string code, int ects, string name)
        {
            Code = code;
            this.Ects = ects;
            this.Name = name;
        }

        public int Ects
        {
            get => ects;
            set
            {
                if (ects < 20 || ects > 30)
                {
                    throw new System.Exception("Ects invalid format! Kaze Milica");
                }
                else
                {
                    ects = value;
                }
            }
        }

        public bool Signed { get; set; }

        public override string ToString() => $"Sifra: {Code}, Naziv: {Name}, Bodovi: {ects.FormatEcts()}, Potvrđen: {(Signed ? "Da" : "Ne")}";

        public void Sign() => this.Signed = true;
    }
}