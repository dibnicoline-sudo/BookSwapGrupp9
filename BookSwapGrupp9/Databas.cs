using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwapGrupp9
{
    public class Databas
    {
        private List<Annons> annonser = new List<Annons>();
        private List<Student> studenter = new List<Student>();
        private List<Affar> affarer = new List<Affar>();

        
        public void LäggTillAnnons(Annons annons)
        {
            annonser.Add(annons);
        }

        public Annons HämtaAnnons(int id)
        {
            return annonser.FirstOrDefault(a => a.AnnonsId == id);
        }

        public List<Annons> HämtaAllaAnnonser()
        {
            return annonser;
        }


        public void LäggTillStudent(Student student)
        {
            studenter.Add(student);
        }

        public Student HämtaStudent(int id)
        {
            return studenter.FirstOrDefault(s => s.StudentId == id);
        }

        public List<Student> HämtaAllaStudenter()
        {
            return studenter;
        }

        public void LäggTillAffar(Affar affar)
        {
            affarer.Add(affar);
        }
        public List<Affar> HämtaAllaAffarer()
        {
            return affarer;
        }
    }
}

    

