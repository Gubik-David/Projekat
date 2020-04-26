namespace projekat2
{
    abstract class Mobilni
    {
        protected string CPU { get; set; }
        protected string GPU { get; set; }
        protected int RAM { get; set; }
        protected int Memorija { get; set; }
        protected double VelicinaEkrana { get; set; }
        public virtual string Proizvodjac() { return "Nedefinisano"; }
    }
}