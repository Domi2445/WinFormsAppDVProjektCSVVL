using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsAppDVProjektCSV
{
    public class Projekt
    {
        public string Name { get; }
        public DateTime Startdatum { get; }
        private List<Aufgabe> aufgaben;

        public List<Mitarbeiter> Mitarbeiterauswahl { get => mitarbeiterauswahl;private set => mitarbeiterauswahl = value; }

        private List<Mitarbeiter> mitarbeiterauswahl;
        public int AufgabenAnzahl => Aufgaben.Count;

        public List<Aufgabe> Aufgaben { get => aufgaben; set => aufgaben = value; }

        public Projekt(string name, DateTime startdatum)
        {
            Name = name;
            Startdatum = startdatum;
            aufgaben = new List<Aufgabe>();

        }
        public Projekt()
        {
            aufgaben = new List<Aufgabe>();
            Laden();
        }

        public void Laden()
        {
            using var reader = new StreamReader("Mitarbeiter.csv");
            Mitarbeiterauswahl = new List<Mitarbeiter>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');
                var mitarbeiter = new Mitarbeiter(int.Parse(values[0]), values[1], values[2]);
                Mitarbeiterauswahl.Add(mitarbeiter);
            }

            using var readerAufgaben = new StreamReader("Aufgaben.csv");
         
            while (!readerAufgaben.EndOfStream)
            {
                var line = readerAufgaben.ReadLine();
                var values = line.Split(';');
                var bearbeiterId = int.Parse(values[3]);
                var bearbeiter = Mitarbeiterauswahl.FirstOrDefault(m => m.Id == bearbeiterId);
                var status = (AufgabenStatus)Enum.Parse(typeof(AufgabenStatus), values[4]);
                var aufgabe = new Aufgabe(int.Parse(values[0]), values[1], values[2], bearbeiter, status);
                aufgaben.Add(aufgabe);
            }

        }

        public void AufgabeHinzufuegen(Aufgabe aufgabe)
        {
            aufgaben.Add(aufgabe);
            // rewrite entire Aufgaben.csv from current list to avoid newline/append issues
            using var writer = new StreamWriter("Aufgaben.csv", true, Encoding.UTF8);
writer.WriteLine($"{aufgabe.Id};{aufgabe.Titel};{aufgabe.Beschreibung};{(aufgabe.Bearbeiter?.Id ?? 0)};{aufgabe.Status}");
        }

        public void MitarbeiterHInzufuegen(Mitarbeiter mitarbeiter)
        {
            mitarbeiterauswahl.Add(mitarbeiter);
        }


    }
}
