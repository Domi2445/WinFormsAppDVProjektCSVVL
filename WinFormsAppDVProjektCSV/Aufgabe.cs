using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppDVProjektCSV
{


    public class Aufgabe
    {
        

        public int Id { get; }
        public string Titel { get; }
        public string Beschreibung { get; set; }
        public Mitarbeiter Bearbeiter { get; set; }
        public AufgabenStatus Status { get; set; }

        // Konstruktor für Aufgaben beim Laden (Id wird vorgegeben)
        public Aufgabe(int id, string titel, string beschreibung, Mitarbeiter bearbeiter, AufgabenStatus status)
        {
            Id = id;
            Titel = titel;
            Beschreibung = beschreibung;
            Bearbeiter = bearbeiter;
            Status = status;
        }

        // Konstruktor für neue Aufgaben (Id automatisch)
        public Aufgabe(string titel, string beschreibung, Mitarbeiter bearbeiter, AufgabenStatus status)
        {
           
            Titel = titel;
            Beschreibung = beschreibung;
            Bearbeiter = bearbeiter;
            Status = status;
        }

        // weitere Variante mit Standardstatus
        public Aufgabe(int id, string titel, string beschreibung, Mitarbeiter bearbeiter)
        {
            Id = id;
           
            Titel = titel;
            Beschreibung = beschreibung;
            Bearbeiter = bearbeiter;
            Status = AufgabenStatus.Offen;
        }

        
       

        override public string ToString()
        {
            return $"{Titel} - {Status} - {(Bearbeiter?.Name ?? "kein Bearbeiter")}";
        }
    }
}
