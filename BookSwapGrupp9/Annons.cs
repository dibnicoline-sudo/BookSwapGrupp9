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

        
public class DigitalResurs : Annons
{
    public string Filformat { get; private set; }
    public double FilstorlekMB { get; private set; }

    public DigitalResurs(int annonsId, string titel, decimal pris,
        AnnonsSkick skick, AnnonsStatus status,
        DateTime publiceringsdatum, Student säljare,
        string filformat, double filstorlekMB)
        : base(annonsId, titel, pris, skick, status,
               publiceringsdatum, säljare)
    {
        Filformat = filformat;
        FilstorlekMB = filstorlekMB;
    }
}
    
    
    }
}
