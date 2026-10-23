using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DigitalResurs : Annons
    {
        public string Filformat { get; private set; }
        public string Leveranssätt { get; private set; }

        public DigitalResurs(int annonsId, string titel, decimal pris,
            AnnonsSkick skick, AnnonsStatus status,
            DateTime publiceringsdatum, Student säljare,
            string filformat, string leveranssätt, Kurs kurs)
            : base(annonsId, titel, pris, skick, status,
                   publiceringsdatum, säljare, kurs)
        {
            Filformat = filformat;
            Leveranssätt = leveranssätt;
        }
        public override string ToString()
        {
            return base.ToString() +
                $" - Filformat: {Filformat}, Leveranssätt: {Leveranssätt}";
        }
    }
}
