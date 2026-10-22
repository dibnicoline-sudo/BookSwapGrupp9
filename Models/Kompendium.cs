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
            string kurskod, int antalSidor, Kurs kurs)
            : base(annonsId, titel, pris, skick, status,
                   publiceringsdatum, säljare, kurs)
        {
            Kurskod = kurskod;
            AntalSidor = antalSidor;
        }
        public override string ToString()
        {
            return base.ToString() +
                $" - Kurskod: {Kurskod}, Antal sidor: {AntalSidor}";
        }
    }
}
