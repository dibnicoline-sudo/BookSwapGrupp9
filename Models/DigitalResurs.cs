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
        public double FilstorlekMB { get; private set; }

        public DigitalResurs(int annonsId, string titel, decimal pris,
            AnnonsSkick skick, AnnonsStatus status,
            DateTime publiceringsdatum, Student säljare,
            string filformat, double filstorlekMB, Kurs kurs)
            : base(annonsId, titel, pris, skick, status,
                   publiceringsdatum, säljare, kurs)
        {
            Filformat = filformat;
            FilstorlekMB = filstorlekMB;
        }
        public override string ToString()
        {
            return base.ToString() +
                $" - Filformat: {Filformat}, Filstorlek: {FilstorlekMB} MB";
        }
    }
}
