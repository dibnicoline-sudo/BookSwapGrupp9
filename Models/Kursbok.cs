using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kursbok : Annons
    {
        public string ISBN { get; private set; }
        public string Författare { get; private set; }

        public Kursbok(int annonsId, string titel, decimal pris,
            AnnonsSkick skick, AnnonsStatus status,
            DateTime publiceringsdatum, Student säljare,
            string isbn, string författare)
            : base(annonsId, titel, pris, skick, status,
                   publiceringsdatum, säljare)
        {
            ISBN = isbn;
            Författare = författare;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {Författare}, ISBN: {ISBN}";
        }
    }
}
