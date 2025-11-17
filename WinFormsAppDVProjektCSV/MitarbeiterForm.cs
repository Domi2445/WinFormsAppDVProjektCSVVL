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
    public partial class MitarbeiterForm : Form
    {
        Projekt projekt;

        public MitarbeiterForm(Projekt projekt)
        {
            InitializeComponent();
            this.projekt = projekt; // store reference to the passed project

        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            // Do not create a new Projekt here — use the one passed in
            var name = txtName.Text;
            var abteilung = textBoxAbteilung.Text;
            Mitarbeiter mitarbeiter = new Mitarbeiter(name, abteilung);
            projekt.MitarbeiterHInzufuegen(mitarbeiter);
            Close();
        }
    }
}
