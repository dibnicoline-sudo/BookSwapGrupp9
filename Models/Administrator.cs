using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Administrator : Anvandare
    {
       
        public Administrator(string fornamn, string efternamn, string epostadress, string telefonnummer, string losenord)
            : base(fornamn, efternamn, epostadress, telefonnummer, losenord)
        {
           
        }
    }
}
