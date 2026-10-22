using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Affar
    {
        public int AffarsId { get; private set; }
        public DateTime Reserveringsdatum { get; private set; }
        public AffarStatus AffarStatus { get; private set; }

        public Student Köpare { get; }
        public Student Säljare { get; }
        public Annons Annons { get; }

        public Affar(int affarsId, Student köpare, Annons annons)
        {
            AffarsId = affarsId;
            Köpare = köpare;
            Säljare = annons.Säljare;
            Reserveringsdatum = DateTime.Now;
            Annons = annons;
            AffarStatus = AffarStatus.Reserverad;
        }
        public void UppdateraAffarStatus(AffarStatus nyAffarStatus)
        {
            AffarStatus = nyAffarStatus;

        }
        public override string ToString()
        {
            string status = AffarStatus == AffarStatus.Genomford
            ? "Genomförd" 
            : AffarStatus.ToString();
            return $"{Annons.Titel} - Köpare: {Köpare.Fornamn} {Köpare.Efternamn} - {status}";
        }
    }
    
}


