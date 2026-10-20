using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kompendium : Annons
    {
        public string Kurskod { get; private set; }
        public int AntalSidor { get; private set; }

        public Kompendium(int annonsId, string titel, decimal pris,
            AnnonsSkick skick, AnnonsStatus status,
            DateTime publiceringsdatum, Student säljare,
            string kurskod, int antalSidor)
            : base(annonsId, titel, pris, skick, status,
                   publiceringsdatum, säljare)
        {
            Kurskod = kurskod;
            AntalSidor = antalSidor;
        }
    }
}
