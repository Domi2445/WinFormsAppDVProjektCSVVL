using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDVProjektCSV
{
    public partial class ProjektForm : Form
    {
        Projekt projekt;
        Aufgabe aufgabe;
        MitarbeiterForm mitarbeiterForm;

        public ProjektForm()
        {
            InitializeComponent();
            projekt = new Projekt("Website aktualisieren", DateTime.Now);
            projekt.Laden();
            listBoxAufgaben.DataSource = projekt.Aufgaben;
            comboBoxMitarbeiter.DataSource = projekt.Mitarbeiterauswahl;
            labelProjektname.Text = projekt.Name;
            dateTimePickerStart.Text = DateTime.Now.ToString();
            

        }

        private void btnNeueAufgabe_Click(object sender, EventArgs e)
        {
            aufgabe = new Aufgabe(projekt.AufgabenAnzahl + 1,textBoxAufgabeTitel.Text, textBoxBeschreibung.Text,
                (Mitarbeiter)comboBoxMitarbeiter.SelectedItem, AufgabenStatus.Offen);
            projekt.AufgabeHinzufuegen(aufgabe);
            aktualisieren();

        }

        private void aktualisieren()
        {
            listBoxAufgaben.DataSource = null;
            listBoxAufgaben.DataSource = projekt.Aufgaben;

        }

        private void listBoxAufgaben_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ausgewählt = listBoxAufgaben.SelectedItem;
            if (ausgewählt is Aufgabe ausgewählteAufgabe)
            {
                switch (ausgewählteAufgabe.Status)
                {
                    case AufgabenStatus.Offen:
                        labelStatus.Text = "Offen";
                        labelStatus.ForeColor = Color.Red;
                        break;
                    case AufgabenStatus.InBearbeitung:
                        labelStatus.Text = "In Bearbeitung";
                        labelStatus.ForeColor = Color.Orange;
                        break;
                    case AufgabenStatus.Erledigt:
                        labelStatus.Text = "Abgeschlossen";
                        labelStatus.ForeColor = Color.Green;
                        break;
                    default:
                        labelStatus.Text = "Unbekannter Status";
                        break;
                }
            }
        }

        private void btnNeuerMitarbeiter_Click(object sender, EventArgs e)
        {
           mitarbeiterForm = new MitarbeiterForm(projekt);
            mitarbeiterForm.ShowDialog();
            comboBoxMitarbeiter.DataSource = null;
            comboBoxMitarbeiter.DataSource = projekt.Mitarbeiterauswahl;
        }
    }
}
