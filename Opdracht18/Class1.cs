using System;
using System.Collections.Generic;

namespace Opdracht18
{
    class Klant
    {
        private int id;
        private string naam;
        private int telefoonnummer;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public int Telefoonnummer
        {
            get { return telefoonnummer; }
            set { telefoonnummer = value; }
        }

        public Klant(int id, string naam, int telefoonnummer)
        {
            this.id = id;
            this.naam = naam;
            this.telefoonnummer = telefoonnummer;
        }

        public static List<Klant> Initialiseer()
        {
            List<Klant> lijst = new List<Klant>();

            lijst.Add(new Klant(1, "Marijke", 0612345678));
            lijst.Add(new Klant(2, "Jan", 0612345677));
            lijst.Add(new Klant(3, "Tim", 0612345666));
            lijst.Add(new Klant(4, "Matt", 0612345555));
            lijst.Add(new Klant(5, "Jeff", 0612344444));

            return lijst;
        }
    }
}