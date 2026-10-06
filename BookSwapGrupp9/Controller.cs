using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BookSwapGrupp9
{
    public class Controller
    {
        private Databas databas;

        public Controller (Databas databas)
        {
            this.databas = databas;
        }
        public void LäggTillAnnons(Annons annons)
        {
            databas.LäggTillAnnons(annons);
        }
        public Annons VisaAnnons(int annonsId)
        {
            return databas.HämtaAnnons(annonsId);
        }
        public void ListaAnnonser()
        {
            foreach (Annons annons in databas.HämtaAllaAnnonser())
            {
                if (annons.StatusAnnons == AnnonsStatus.TillSalu)
                {
                    Console.WriteLine(annons);
                }
               
            }
        }
        public string ReserveraAnnons(int annonsId, Student köpare)
        {
            Annons annons = VisaAnnons(annonsId);
            if (annons == null)
                    return "Annonsen finns inte. Försök igen.";

                if (!annons.KontrolleraStatus())
                    return "Annonsen är redan reserverad";

                if (annons.Säljare.StudentId == köpare.StudentId)
                    return "Du kan inte reservera din egen annons.";

            int affarsId = databas.HämtaAllaAffarer().Count + 1;
            Affar affar = new Affar(affarsId, köpare, annons);
            databas.LäggTillAffar(affar);

            annons.UppdateraAnnonsStatus(AnnonsStatus.Reserverad);

            return $"\nAnnonsen är reserverad!\n\n" +
            $"AnnonsID: {annons.AnnonsId}\n" +
            $"Köpare: {köpare.Fornamn} {köpare.Efternamn}\n" +
            $"Säljare: {annons.Säljare.Fornamn} {annons.Säljare.Efternamn}\n" +
            $"Annonsen titel: {annons.Titel}\n" +
            $"Pris: {annons.Pris} kr\n"+ 
            $"Reserveringsdatum: {affar.Reserveringsdatum}\n" +
            $"Affär: #{affar.AffarsId}";
        }
    }
}
   
