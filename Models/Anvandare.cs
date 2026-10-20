using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Anvandare
    {
        public string Fornamn { get; private set; }
        public string Efternamn { get; private set; }
        public string Epostadress { get; private set; }
        public string Telefonnummer { get; private set; }

        public Anvandare(string fornamn, string efternamn, string epostadress, string telefonnummer)
        {
            Fornamn = fornamn;
            Efternamn = efternamn;
            Epostadress = epostadress;
            Telefonnummer = telefonnummer;
        }
        public void UppdateraKontaktuppgifter(string nyEpostadress, string nyttTelefonnummer)
        {
            Epostadress = nyEpostadress;
            Telefonnummer = nyttTelefonnummer;
        }
    }
    
}
