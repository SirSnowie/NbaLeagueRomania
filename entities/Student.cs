using System;
using System.Collections.Generic;
using System.Text;

namespace NbaLeagueRomania.entities
{
    class Student : Entity<long>
    {
        public string Nume { get; set; }
        public string Scoala { get; set; }

        public Student(string nume, string scoala)
        {
            Nume = nume;
            Scoala = scoala;
        }
    }

}
