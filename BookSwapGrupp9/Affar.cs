using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwapGrupp9
{
    public class Affar
    { 
        public int AffarsId { get; private set; }
        public DateTime Reserveringsdatum {  get; private set; }
        public AffarStatus AffarStatus { get; private set; }
        
        public Student Köpare { get; }
        public Student Säljare { get; }
        public Annons Annons { get; }
        
        public Affar (int affarsId, Student köpare, Annons annons)
        {
            AffarsId = affarsId;
            Köpare = köpare;
            Säljare = annons.Säljare;
            Reserveringsdatum = DateTime.Now;
            Annons = annons; 
        }    
        public void UppdateraAffarStatus (AffarStatus nyAffarStatus)
        {
            AffarStatus = nyAffarStatus;

        }
    }
}

