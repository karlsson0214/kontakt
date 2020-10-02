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
            Kontakt kontakt = new Kontakt("Ada", "11");
            bok.AddKontakt(kontakt);

            Kontakt kontakt1 = new Kontakt("Babbage", "1101");
            bok.AddKontakt(kontakt1);

            bok.AddKontakt("Beda", "45");

            bok.Print();
        }
    }
}
