using System;

namespace kontakt
{
    class Test
    {
        // objektvariabler
        Kontaktbok bok = new Kontaktbok();

        // metoder
        public void Run()
        {
            Kontakt kontakt = new Kontakt();
            kontakt.namn = "Ada";
            kontakt.telefonnummer = "11";
            bok.AddKontakt(kontakt);

            Kontakt kontakt1 = new Kontakt();
            kontakt1.namn = "Babbage";
            kontakt1.telefonnummer = "1101";
            bok.AddKontakt(kontakt1);

            bok.AddKontakt("Beda", "45");

            bok.Print();
        }
    }
}
