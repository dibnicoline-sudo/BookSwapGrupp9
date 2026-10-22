using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Student : Anvandare
    {
        public int StudentId { get; private set; }

        private string losenord;

        private List<Annons> minaAnnonser = new List<Annons>();
        
        public Student(int studentId, string fornamn, string efternamn,
        string epostadress, string telefonnummer, string losenord)
        : base(fornamn, efternamn, epostadress, telefonnummer)
        {
            StudentId = studentId;
            this.losenord = losenord;
        }
        public bool KontrolleraLosenord(string angivetLosenord)
        {
            return losenord == angivetLosenord;
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

        public bool ÄgerAnnons(Annons annons)
        {
            return minaAnnonser.Contains(annons);
        }

        public override string ToString()
        {
            return $"[{StudentId}] {Fornamn} {Efternamn} - {Epostadress}";
        }
    }
}

