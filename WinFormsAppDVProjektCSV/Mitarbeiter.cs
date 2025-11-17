using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppDVProjektCSV
{
    public class Mitarbeiter
    {
        private static int naechsteId = 1;
        public int Id { get; }
        public string Name { get;  }
        public string Abteilung { get; set; }

        public Mitarbeiter(string name, string abteilung)
        {
            Id = naechsteId++;
            Name = name;
            Abteilung = abteilung;
        }

        public Mitarbeiter(int id, string name, string abteilung)
        {
            Id = id;
            Name = name;
            Abteilung = abteilung;
        }

        override public string ToString()
        {
            return $"{Name} ({Abteilung})";
        }
    }
}
