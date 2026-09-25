using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwapGrupp9
{
    public class Controller
    {
            private List<Annons> annonser = new List<Annons>(); 
            private List<Affar> affarer = new List<Affar> (); 

                public void läggtillannons(Annons annons)
            {
                annonser.Add(annons); 
            }

        public string ReserveraAnnons(int annonsId, Student köpare)
        {
            Annons annons = VisaAnnons (annonsId);
            if (annons == null)
                return "Annonsen finns inte";

            if (!annons.KontrolleraStatus())
                return "Annonsen är inte till salu";

            if (annons.Säljare == köpare)
                return "Du kan inte reservera din egen annons.";
        }

            Affar affar = new Affar(köpare, annons);
            affarer.Add(affar);

            annons.UppdateraStatus(AnnonsStatus.Reserverad);

            return $"Reservationsbekräftelse: affär #{affar.affarsId}, " +
                   $"\"{annons.Titel}\" reserverad av {köpare}. " +
                   $"Kontakta säljaren {annons.Säljare} ({annons.Säljare.Epostadress}).";
        }


    }
}
    

