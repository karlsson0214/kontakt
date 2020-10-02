using System;
using System.Collections.Generic;

namespace kontakt
{
    class Kontaktbok
    {
        // objektvariabel
        private List<Kontakt> kontakter = new List<Kontakt>();

        // metoder
        public void AddKontakt(Kontakt nyKontakt)
        {
            kontakter.Add(nyKontakt);
        
        }
        public void AddKontakt(String namn, String nr)
        {
            Kontakt minKontakt = new Kontakt();
            minKontakt.namn = namn;
            minKontakt.telefonnummer = nr;
            kontakter.Add(minKontakt);
        }

        public void Print()
        {
            Console.WriteLine();
            foreach(Kontakt enKontakt in kontakter)
            {
                Console.WriteLine(enKontakt.namn + " har tel nr: " + enKontakt.telefonnummer);
            }
            Console.WriteLine();
        }
        
    }
}