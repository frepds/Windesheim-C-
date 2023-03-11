namespace Oefentoets1
{
    public enum Banken
    {
        Rabobank,  // RABO
        Regiobank, // RBRB
        SNS,       // SNSB
        ING,       // INGB
        Onbekend
    }
    
    public abstract class Rechtspersoon
    {
        public Banken Bank { get; }
        public string IBAN { get; set; }
        public abstract string Informatie();
    }
}

