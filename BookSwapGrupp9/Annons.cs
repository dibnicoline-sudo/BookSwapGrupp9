using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwapGrupp9
{
    public class Annons
    {
        public int AnnonsId { get; private set;  }
        public string Titel {get; private set; }
        public decimal Pris {get; private set; }
        private DateTime Publiceringsdatum { get; set; }
        public AnnonsStatus StatusAnnons { get; private set; }
        public AnnonsSkick Skick { get; private set; }
        public Student Säljare { get; }
        
        public Annons (int annonsId, string titel,  decimal pris, AnnonsSkick skick, AnnonsStatus status, DateTime publiceringsdatum, Student säljare)
        {
            AnnonsId = annonsId;
            Titel = titel;
            Pris = pris;
            StatusAnnons = status;
            Skick = skick;
            Publiceringsdatum = publiceringsdatum;
            Säljare = säljare;
        }
        public bool KontrolleraStatus()
        {
            return StatusAnnons == AnnonsStatus.TillSalu;
        }
        public void UppdateraAnnonsStatus (AnnonsStatus nyAnnonsStatus)
        {
            StatusAnnons = nyAnnonsStatus;
        }
        public override string ToString() =>
        $"[{AnnonsId}] {Titel} - {Pris} kr, {Skick}, {StatusAnnons}";        
    }
}
