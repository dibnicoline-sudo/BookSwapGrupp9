using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Student : Anvandare
    {
        public int StudentId { get; private set; }
        private List<Annons> minaAnnonser = new List<Annons>();
        
        public Student(int studentId, string fornamn, string efternamn,
        string epostadress, string telefonnummer, string losenord)
        : base(fornamn, efternamn, epostadress, telefonnummer,losenord)
        {
            StudentId = studentId;
            
        }
        
        public void LäggTillAnnons(Annons annons)
        {
            minaAnnonser.Add(annons);
        }

        public void TaBortAnnons(Annons annons)
        {
            minaAnnonser.Remove(annons);
        }

        public List<Annons> HämtaMinaAnnonser()
        {
            return minaAnnonser;
        }

        public override string ToString()
        {
            return $"[{StudentId}] {Fornamn} {Efternamn} - {Epostadress}";
        }
    }
}

