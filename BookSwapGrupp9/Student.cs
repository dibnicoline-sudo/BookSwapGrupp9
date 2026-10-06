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
        private string Telefonnummer { get; set; }

        public Student (int studentId, string fornamn, string efternamn, string epostadress, string telefonnummer)
        {
            StudentId = studentId;
            Fornamn  = fornamn;
            Efternamn = efternamn;
            Epostadress = epostadress;
            Telefonnummer = telefonnummer;
        }
        
    }
}
