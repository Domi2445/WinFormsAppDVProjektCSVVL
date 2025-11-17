namespace WinFormsAppDVProjektCSV
{
    partial class MitarbeiterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSpeichern;

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
            txtName = new TextBox();
            lblName = new Label();
            btnSpeichern = new Button();
            label1 = new Label();
            textBoxAbteilung = new TextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 28);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(284, 31);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(29, 33);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // btnSpeichern
            // 
            btnSpeichern.Location = new Point(122, 124);
            btnSpeichern.Margin = new Padding(4, 5, 4, 5);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(171, 38);
            btnSpeichern.TabIndex = 2;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 3;
            label1.Text = "Abteilung";
            // 
            // textBoxAbteilung
            // 
            textBoxAbteilung.Location = new Point(122, 76);
            textBoxAbteilung.Margin = new Padding(4, 5, 4, 5);
            textBoxAbteilung.Name = "textBoxAbteilung";
            textBoxAbteilung.Size = new Size(284, 31);
            textBoxAbteilung.TabIndex = 4;
            // 
            // MitarbeiterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 183);
            Controls.Add(label1);
            Controls.Add(textBoxAbteilung);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(btnSpeichern);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MitarbeiterForm";
            Text = "Neuer Mitarbeiter";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox textBoxAbteilung;
    }
}