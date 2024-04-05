namespace Petshop.Models
{
    public class Animal
    {
        public int Id { get; set; }

        public string Type { get; set; }
        public string Navn { get; set; }
        public int Alder { get; set; }
        public string Køn { get; set; }
        public string Beskrivelse { get; set; }
        public decimal Pris { get; set; }
        public string BilledeNavn { get; set; }
    }
}
