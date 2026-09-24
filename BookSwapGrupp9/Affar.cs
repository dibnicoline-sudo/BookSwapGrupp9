using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwapGrupp9
{
    public class Affar
    {
        private int AffarsId { get; set; }
        private DateTime datum {  get; set; }
        public AffarStatus AffarStatus { get; set; }
        public student Köpare { get; }
        public student Säljare { get; }
        public Annons Annons { get; }
        
        public Affar (int affarsId, student köpare, student säljare, Annons annons)
        {
            AffarsId = affarsId;
            Köpare = köpare;
            Säljare = säljare;
            Annons = annons;
        }
    }
}
