using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwapGrupp9
{
    public class student
    {
        private int StudentId { get; set; }
        private string Fornamn { get; set; }
        private string Efternamn { get; set; }
        private string Epostadress { get; set; }
        private string Telefonnummer { get; set; }

        public student (int studentId, string fornamn, string efternamn)
        {
            StudentId = studentId;
            Fornamn  = fornamn;
            Efternamn = efternamn;
        }

    }
}
