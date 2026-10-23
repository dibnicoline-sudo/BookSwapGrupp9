using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kompendium : Annons
    {
        public int Utgivningsår { get; private set; }
        public int AntalSidor { get; private set; }

        public Kompendium(int annonsId, string titel, decimal pris,
            AnnonsSkick skick, AnnonsStatus status,
            DateTime publiceringsdatum, Student säljare,
            int utgivningsår, int antalSidor, Kurs kurs)
            : base(annonsId, titel, pris, skick, status,
                   publiceringsdatum, säljare, kurs)
        {
            Utgivningsår = utgivningsår;
            AntalSidor = antalSidor;
        }
        public override string ToString()
        {
            return base.ToString() +
                $" - Utgivningsår: {Utgivningsår}, Antal sidor: {AntalSidor}";
        }
    }
}
