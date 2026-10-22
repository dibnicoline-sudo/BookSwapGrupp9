namespace GUI
{
    partial class AnvandarhanteringForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHanteraAnvandare = new Label();
            lstStudenter = new ListBox();
            lblRubrik = new Label();
            lblStudentUppg = new Label();
            lblFornamn = new Label();
            lblEfternamn = new Label();
            lblEpost = new Label();
            txtFornamn = new TextBox();
            txtEfternamn = new TextBox();
            txtEpost = new TextBox();
            txtTelefon = new TextBox();
            lblTelefon = new Label();
            txtLosenord = new TextBox();
            lblLosenord = new Label();
            btnLaggTill = new Button();
            btnUppdatera = new Button();
            btnTaBort = new Button();
            btnTillbaka = new Button();
            SuspendLayout();
            // 
            // lblHanteraAnvandare
            // 
            lblHanteraAnvandare.AutoSize = true;
            lblHanteraAnvandare.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHanteraAnvandare.Location = new Point(48, 19);
            lblHanteraAnvandare.Name = "lblHanteraAnvandare";
            lblHanteraAnvandare.Size = new Size(260, 38);
            lblHanteraAnvandare.TabIndex = 0;
            lblHanteraAnvandare.Text = "Hantera användare";
            // 
            // lstStudenter
            // 
            lstStudenter.FormattingEnabled = true;
            lstStudenter.Location = new Point(58, 118);
            lstStudenter.Name = "lstStudenter";
            lstStudenter.Size = new Size(250, 304);
            lstStudenter.TabIndex = 1;
            lstStudenter.SelectedIndexChanged += lstStudenter_SelectedIndexChanged_1;
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRubrik.Location = new Point(58, 87);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(219, 28);
            lblRubrik.TabIndex = 2;
            lblRubrik.Text = "Registrerade studenter";
            // 
            // lblStudentUppg
            // 
            lblStudentUppg.AutoSize = true;
            lblStudentUppg.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentUppg.Location = new Point(412, 87);
            lblStudentUppg.Name = "lblStudentUppg";
            lblStudentUppg.Size = new Size(168, 28);
            lblStudentUppg.TabIndex = 6;
            lblStudentUppg.Text = "Studentuppgifter";
            // 
            // lblFornamn
            // 
            lblFornamn.AutoSize = true;
            lblFornamn.Location = new Point(412, 131);
            lblFornamn.Name = "lblFornamn";
            lblFornamn.Size = new Size(67, 20);
            lblFornamn.TabIndex = 7;
            lblFornamn.Text = "Förnamn";
            // 
            // lblEfternamn
            // 
            lblEfternamn.AutoSize = true;
            lblEfternamn.Location = new Point(412, 199);
            lblEfternamn.Name = "lblEfternamn";
            lblEfternamn.Size = new Size(77, 20);
            lblEfternamn.TabIndex = 8;
            lblEfternamn.Text = "Efternamn";
            // 
            // lblEpost
            // 
            lblEpost.AutoSize = true;
            lblEpost.Location = new Point(412, 272);
            lblEpost.Name = "lblEpost";
            lblEpost.Size = new Size(94, 20);
            lblEpost.TabIndex = 9;
            lblEpost.Text = "E-postadress";
            // 
            // txtFornamn
            // 
            txtFornamn.Location = new Point(412, 154);
            txtFornamn.Name = "txtFornamn";
            txtFornamn.Size = new Size(233, 27);
            txtFornamn.TabIndex = 10;
            // 
            // txtEfternamn
            // 
            txtEfternamn.Location = new Point(412, 222);
            txtEfternamn.Name = "txtEfternamn";
            txtEfternamn.Size = new Size(233, 27);
            txtEfternamn.TabIndex = 11;
            // 
            // txtEpost
            // 
            txtEpost.Location = new Point(412, 295);
            txtEpost.Name = "txtEpost";
            txtEpost.Size = new Size(233, 27);
            txtEpost.TabIndex = 12;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(412, 365);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(233, 27);
            txtTelefon.TabIndex = 13;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(412, 342);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(113, 20);
            lblTelefon.TabIndex = 14;
            lblTelefon.Text = "Telefonnummer";
            // 
            // txtLosenord
            // 
            txtLosenord.Location = new Point(412, 441);
            txtLosenord.Name = "txtLosenord";
            txtLosenord.Size = new Size(233, 27);
            txtLosenord.TabIndex = 15;
            txtLosenord.UseSystemPasswordChar = true;
            // 
            // lblLosenord
            // 
            lblLosenord.AutoSize = true;
            lblLosenord.Location = new Point(412, 418);
            lblLosenord.Name = "lblLosenord";
            lblLosenord.Size = new Size(70, 20);
            lblLosenord.TabIndex = 16;
            lblLosenord.Text = "Lösenord";
            // 
            // btnLaggTill
            // 
            btnLaggTill.Location = new Point(58, 496);
            btnLaggTill.Name = "btnLaggTill";
            btnLaggTill.Size = new Size(167, 29);
            btnLaggTill.TabIndex = 17;
            btnLaggTill.Text = "Lägg till student";
            btnLaggTill.UseVisualStyleBackColor = true;
            btnLaggTill.Click += btnLaggTill_Click_1;
            // 
            // btnUppdatera
            // 
            btnUppdatera.Location = new Point(273, 496);
            btnUppdatera.Name = "btnUppdatera";
            btnUppdatera.Size = new Size(187, 29);
            btnUppdatera.TabIndex = 18;
            btnUppdatera.Text = "Uppdatera student";
            btnUppdatera.UseVisualStyleBackColor = true;
            btnUppdatera.Click += btnUppdatera_Click;
            // 
            // btnTaBort
            // 
            btnTaBort.Location = new Point(504, 496);
            btnTaBort.Name = "btnTaBort";
            btnTaBort.Size = new Size(175, 29);
            btnTaBort.TabIndex = 19;
            btnTaBort.Text = "Ta bort student";
            btnTaBort.UseVisualStyleBackColor = true;
            btnTaBort.Click += btnTaBort_Click;
            // 
            // btnTillbaka
            // 
            btnTillbaka.Location = new Point(609, 578);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(153, 29);
            btnTillbaka.TabIndex = 20;
            btnTillbaka.Text = "Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            btnTillbaka.Click += btnTillbaka_Click;
            // 
            // AnvandarhanteringForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 632);
            Controls.Add(btnTillbaka);
            Controls.Add(btnTaBort);
            Controls.Add(btnUppdatera);
            Controls.Add(btnLaggTill);
            Controls.Add(lblLosenord);
            Controls.Add(txtLosenord);
            Controls.Add(lblTelefon);
            Controls.Add(txtTelefon);
            Controls.Add(txtEpost);
            Controls.Add(txtEfternamn);
            Controls.Add(txtFornamn);
            Controls.Add(lblEpost);
            Controls.Add(lblEfternamn);
            Controls.Add(lblFornamn);
            Controls.Add(lblStudentUppg);
            Controls.Add(lblRubrik);
            Controls.Add(lstStudenter);
            Controls.Add(lblHanteraAnvandare);
            Name = "AnvandarhanteringForm";
            Text = "AnvandarhanteringForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHanteraAnvandare;
        private ListBox lstStudenter;
        private Label lblRubrik;
        private Label lblStudentUppg;
        private Label lblFornamn;
        private Label lblEfternamn;
        private Label lblEpost;
        private TextBox txtFornamn;
        private TextBox txtEfternamn;
        private TextBox txtEpost;
        private TextBox txtTelefon;
        private Label lblTelefon;
        private TextBox txtLosenord;
        private Label lblLosenord;
        private Button btnLaggTill;
        private Button btnUppdatera;
        private Button btnTaBort;
        private Button btnTillbaka;
    }
}