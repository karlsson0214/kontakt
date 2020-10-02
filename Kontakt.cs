using System;

namespace kontakt
{
    class Kontakt
    {
        // objektvariabler
        private string namn;
        private string telefonnummer;

        public Kontakt(string namnet, string telNr)
        {
            namn = namnet;
            telefonnummer = telNr;
        }

        public string GetNamn()
        {
            return namn;
        }
        public string GetTelefonnummer()
        {
            return telefonnummer;
        }
        
    }
}