using Microsoft.Extensions.Logging;
using Petshop.Models;
using System.Collections.Generic;
using System.Linq;

namespace Petshop.Catalogs
{
    public class AnimalCatalog
    {
        private string hundBeskrivelse = "Rex, en livlig Golden Retriever, elsker at lege udendørs og fange bolden. Han nyder at spise kylling og æbler, men hader badetid. Trods dette er han stadig en kærlig og trofast ven for sin familie.";

        private string katBeskrivelse = "Sunko er en elegant sort kat, der elsker at lege med bolde og kæle med sine mennesker. Han foretrækker laks og kylling som mad, men er også nysgerrig og elsker at observere verden fra vindueskarmen.";

        private string zebraBeskrivelse = "Suzi er en stribet zebra, der lever frit på de afrikanske sletter. Hun elsker at græsse på det saftige græs og løbe med sin flok. Hendes striber hjælper hende med at skjule sig for rovdyr, mens hendes hurtighed gør hende til en mester i at undslippe fare";

        private string kaninBeskrivelse = "Mikey er en nuttet kanin med blødt, hvidt og sort pels. Han elsker at hoppe rundt i haven og gnave i friske grøntsager, specielt persille. Hans lange ører vipper, når han er glad, og han elsker at grave små huller i jorden for at udforske.";

        private string marsvinBeskrivelse = "Fattington er et sødt marsvin med blødt, brunt pels. Han elsker at snuse rundt i sit bur og gnave på hø. Når han er glad, laver han små lyde, der får alle omkring ham til at smile.";

        private Dictionary<int, Animal> animals;

        public AnimalCatalog()
        {
            animals = new Dictionary<int, Animal>();

            animals.Add(1, new Dog() { Navn  = "Rex", Type = "Hund", Alder = 2, Køn = "Han", Beskrivelse = hundBeskrivelse, Pris = 1999, BilledeNavn = "hund.jpg" });
            animals.Add(2, new Cat() { Navn = "Sunko", Type = "Kat", Alder = 9, Køn = "Han", Beskrivelse = katBeskrivelse, Pris = 899, BilledeNavn = "kat.jpeg" });
            animals.Add(3, new Zebra() { Navn = "Suzi", Type = "Zebra", Alder = 2, Køn = "Hun", Beskrivelse = zebraBeskrivelse, Pris = 59999, BilledeNavn = "zebra.jpg" });
            animals.Add(4, new Rabbit() { Navn = "Mikey", Type = "Kanin", Alder = 2, Køn = "Han", Beskrivelse = kaninBeskrivelse, Pris = 3999, BilledeNavn = "kanin.png" });
            animals.Add(5, new Guineapig() { Navn = "Fattington", Type = "Marsvin", Alder = 2, Køn = "Han", Beskrivelse = marsvinBeskrivelse, Pris = 599, BilledeNavn = "marsvin.jpg" });
        }
        public Dictionary<int, Animal> AllAnimals()
        {
            // not implemented yet , We return an empty dictionary to avoid compile error
            return animals;
        }
    }
}
