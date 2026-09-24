using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwapGrupp9
{
    public class Annons
    {
        private int AnnonsId { get; set;  }
        private string Titel {get; set; }
        private decimal Pris {get; set; }
        public AnnonsStatus StatusAnnons { get; private set; }
        public AnnonsSkick Skick { get; private set; }
        public student Säljare { get; }
        
        public Annons (int annonsId, string titel,  decimal pris, AnnonsSkick skick, AnnonsStatus status, student säljare)
        {
            AnnonsId = annonsId;
            Titel = titel;
            StatusAnnons = status;
            Skick = skick;
            Säljare = säljare; 
        }
        public bool KontrolleraStatus()
        {
            return StatusAnnons == AnnonsStatus.TillSalu;
        }
        public void UppdateraStatus (AnnonsStatus nyStatus)
        {
            StatusAnnons = nyStatus;
        }
        public override string ToString() =>
        $"[{AnnonsId}] {Titel} - {Pris} kr, {Skick}, {StatusAnnons}";
               
    }
}
