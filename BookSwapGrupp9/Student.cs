using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwapGrupp9
{
    public class Student
    {
        public int StudentId { get; private set; }
        public string Fornamn { get; private set; }
        public string Efternamn { get; private set; }

        public string Epostadress { get; private set; }
        public string Telefonnummer { get; private set; }

        private string losenord;

        private List<Annons> minaAnnonser = new List<Annons>();

        public Student(int studentId, string fornamn, string efternamn, string epostadress, string telefonnummer, string losenord)
        {
            StudentId = studentId;
            Fornamn = fornamn;
            Efternamn = efternamn;
            Epostadress = epostadress;
            Telefonnummer = telefonnummer;
            this.losenord = losenord;
        }

        public bool KontrolleraLosenord(string angivetLosenord)
        {
            return losenord == angivetLosenord;
        }

        public void UppdateraKontaktuppgifter(string nyEpostadress, string nyttTelefonnummer)
        {
            Epostadress = nyEpostadress;
            Telefonnummer = nyttTelefonnummer;
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

        public override string ToString() =>
            $"[{StudentId}] {Fornamn} {Efternamn} – {Epostadress}, {Telefonnummer}";
    }
}
