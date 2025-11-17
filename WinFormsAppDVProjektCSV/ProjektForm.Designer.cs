namespace WinFormsAppDVProjektCSV
{

        partial class ProjektForm
        {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.TextBox textBoxAufgabeTitel;
            private System.Windows.Forms.ComboBox comboBoxMitarbeiter;
            private System.Windows.Forms.Button btnNeueAufgabe;
            private System.Windows.Forms.Button btnNeuerMitarbeiter;
            private System.Windows.Forms.ListBox listBoxAufgaben;
            private System.Windows.Forms.Label lblAufgabeTitel;
            private System.Windows.Forms.Label lblMitarbeiter;
            private System.Windows.Forms.Label lblAufgaben;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

        private void InitializeComponent()
        {
            textBoxAufgabeTitel = new TextBox();
            comboBoxMitarbeiter = new ComboBox();
            btnNeueAufgabe = new Button();
            btnNeuerMitarbeiter = new Button();
            listBoxAufgaben = new ListBox();
            lblAufgabeTitel = new Label();
            lblMitarbeiter = new Label();
            lblAufgaben = new Label();
            labelProjektname = new Label();
            dateTimePickerStart = new DateTimePicker();
            label1 = new Label();
            textBoxBeschreibung = new TextBox();
            l = new HelpProvider();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // textBoxAufgabeTitel
            // 
            textBoxAufgabeTitel.Location = new Point(307, 135);
            textBoxAufgabeTitel.Margin = new Padding(4, 5, 4, 5);
            textBoxAufgabeTitel.Name = "textBoxAufgabeTitel";
            textBoxAufgabeTitel.Size = new Size(341, 31);
            textBoxAufgabeTitel.TabIndex = 1;
            // 
            // comboBoxMitarbeiter
            // 
            comboBoxMitarbeiter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMitarbeiter.Location = new Point(307, 251);
            comboBoxMitarbeiter.Margin = new Padding(4, 5, 4, 5);
            comboBoxMitarbeiter.Name = "comboBoxMitarbeiter";
            comboBoxMitarbeiter.Size = new Size(341, 33);
            comboBoxMitarbeiter.TabIndex = 3;
            // 
            // btnNeueAufgabe
            // 
            btnNeueAufgabe.Location = new Point(477, 311);
            btnNeueAufgabe.Margin = new Padding(4, 5, 4, 5);
            btnNeueAufgabe.Name = "btnNeueAufgabe";
            btnNeueAufgabe.Size = new Size(171, 38);
            btnNeueAufgabe.TabIndex = 5;
            btnNeueAufgabe.Text = "Neue Aufgabe";
            btnNeueAufgabe.Click += btnNeueAufgabe_Click;
            // 
            // btnNeuerMitarbeiter
            // 
            btnNeuerMitarbeiter.Location = new Point(35, 674);
            btnNeuerMitarbeiter.Margin = new Padding(4, 5, 4, 5);
            btnNeuerMitarbeiter.Name = "btnNeuerMitarbeiter";
            btnNeuerMitarbeiter.Size = new Size(308, 38);
            btnNeuerMitarbeiter.TabIndex = 4;
            btnNeuerMitarbeiter.Text = "Neuer Mitarbeiter anlegen";
            btnNeuerMitarbeiter.Click += btnNeuerMitarbeiter_Click;
            // 
            // listBoxAufgaben
            // 
            listBoxAufgaben.FormattingEnabled = true;
            listBoxAufgaben.ItemHeight = 25;
            listBoxAufgaben.Location = new Point(35, 372);
            listBoxAufgaben.Margin = new Padding(4, 5, 4, 5);
            listBoxAufgaben.Name = "listBoxAufgaben";
            listBoxAufgaben.Size = new Size(613, 229);
            listBoxAufgaben.TabIndex = 7;
            listBoxAufgaben.SelectedIndexChanged += listBoxAufgaben_SelectedIndexChanged;
            // 
            // lblAufgabeTitel
            // 
            lblAufgabeTitel.AutoSize = true;
            lblAufgabeTitel.Location = new Point(29, 138);
            lblAufgabeTitel.Margin = new Padding(4, 0, 4, 0);
            lblAufgabeTitel.Name = "lblAufgabeTitel";
            lblAufgabeTitel.Size = new Size(123, 25);
            lblAufgabeTitel.TabIndex = 0;
            lblAufgabeTitel.Text = "Aufgabentitel:";
            // 
            // lblMitarbeiter
            // 
            lblMitarbeiter.AutoSize = true;
            lblMitarbeiter.Location = new Point(35, 251);
            lblMitarbeiter.Margin = new Padding(4, 0, 4, 0);
            lblMitarbeiter.Name = "lblMitarbeiter";
            lblMitarbeiter.Size = new Size(199, 25);
            lblMitarbeiter.TabIndex = 2;
            lblMitarbeiter.Text = "zuständiger Mitarbeiter:";
            // 
            // lblAufgaben
            // 
            lblAufgaben.AutoSize = true;
            lblAufgaben.Location = new Point(35, 339);
            lblAufgaben.Margin = new Padding(4, 0, 4, 0);
            lblAufgaben.Name = "lblAufgaben";
            lblAufgaben.Size = new Size(94, 25);
            lblAufgaben.TabIndex = 6;
            lblAufgaben.Text = "Aufgaben:";
            // 
            // labelProjektname
            // 
            labelProjektname.AutoSize = true;
            labelProjektname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProjektname.Location = new Point(29, 27);
            labelProjektname.Name = "labelProjektname";
            labelProjektname.Size = new Size(159, 32);
            labelProjektname.TabIndex = 8;
            labelProjektname.Text = "Projektname";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(35, 80);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(300, 31);
            dateTimePickerStart.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 191);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 25);
            label1.TabIndex = 10;
            label1.Text = "Aufgabentitelbeschreibung";
            // 
            // textBoxBeschreibung
            // 
            textBoxBeschreibung.Location = new Point(307, 188);
            textBoxBeschreibung.Margin = new Padding(4, 5, 4, 5);
            textBoxBeschreibung.Name = "textBoxBeschreibung";
            textBoxBeschreibung.ScrollBars = ScrollBars.Horizontal;
            textBoxBeschreibung.Size = new Size(341, 31);
            textBoxBeschreibung.TabIndex = 11;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(692, 379);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(59, 25);
            labelStatus.TabIndex = 12;
            labelStatus.Text = "label2";
            // 
            // ProjektForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 729);
            Controls.Add(labelStatus);
            Controls.Add(label1);
            Controls.Add(textBoxBeschreibung);
            Controls.Add(dateTimePickerStart);
            Controls.Add(labelProjektname);
            Controls.Add(lblAufgabeTitel);
            Controls.Add(textBoxAufgabeTitel);
            Controls.Add(lblMitarbeiter);
            Controls.Add(comboBoxMitarbeiter);
            Controls.Add(btnNeuerMitarbeiter);
            Controls.Add(btnNeueAufgabe);
            Controls.Add(lblAufgaben);
            Controls.Add(listBoxAufgaben);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ProjektForm";
            Text = "Projekt und Aufgaben";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelProjektname;
        private DateTimePicker dateTimePickerStart;
        private Label label1;
        private TextBox textBoxBeschreibung;
        private HelpProvider l;
        private Label labelStatus;
    }
    }
