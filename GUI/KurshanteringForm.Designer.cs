namespace GUI
{
    partial class KurshanteringForm
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
            lblKurshantering = new Label();
            lstKurser = new ListBox();
            lblKurskod = new Label();
            txtKurskod = new TextBox();
            lblKursnman = new Label();
            txtKursnamn = new TextBox();
            btnLaggTillKurs = new Button();
            btnUppdateraKurs = new Button();
            btnTaBortKurs = new Button();
            btnTillbaka = new Button();
            lblKurser = new Label();
            SuspendLayout();
            // 
            // lblKurshantering
            // 
            lblKurshantering.AutoSize = true;
            lblKurshantering.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKurshantering.Location = new Point(48, 9);
            lblKurshantering.Name = "lblKurshantering";
            lblKurshantering.Size = new Size(194, 38);
            lblKurshantering.TabIndex = 0;
            lblKurshantering.Text = "Kurshantering";
            // 
            // lstKurser
            // 
            lstKurser.FormattingEnabled = true;
            lstKurser.Location = new Point(48, 94);
            lstKurser.Name = "lstKurser";
            lstKurser.Size = new Size(393, 184);
            lstKurser.TabIndex = 1;
            lstKurser.SelectedIndexChanged += lstKurser_SelectedIndexChanged;
            // 
            // lblKurskod
            // 
            lblKurskod.AutoSize = true;
            lblKurskod.Location = new Point(48, 300);
            lblKurskod.Name = "lblKurskod";
            lblKurskod.Size = new Size(62, 20);
            lblKurskod.TabIndex = 2;
            lblKurskod.Text = "Kurskod";
            // 
            // txtKurskod
            // 
            txtKurskod.Location = new Point(48, 323);
            txtKurskod.Name = "txtKurskod";
            txtKurskod.Size = new Size(261, 27);
            txtKurskod.TabIndex = 3;
            // 
            // lblKursnman
            // 
            lblKursnman.AutoSize = true;
            lblKursnman.Location = new Point(48, 389);
            lblKursnman.Name = "lblKursnman";
            lblKursnman.Size = new Size(74, 20);
            lblKursnman.TabIndex = 4;
            lblKursnman.Text = "Kursnamn";
            // 
            // txtKursnamn
            // 
            txtKursnamn.Location = new Point(48, 412);
            txtKursnamn.Name = "txtKursnamn";
            txtKursnamn.Size = new Size(261, 27);
            txtKursnamn.TabIndex = 5;
            // 
            // btnLaggTillKurs
            // 
            btnLaggTillKurs.Location = new Point(48, 480);
            btnLaggTillKurs.Name = "btnLaggTillKurs";
            btnLaggTillKurs.Size = new Size(131, 29);
            btnLaggTillKurs.TabIndex = 6;
            btnLaggTillKurs.Text = "Lägg till kurs";
            btnLaggTillKurs.UseVisualStyleBackColor = true;
            btnLaggTillKurs.Click += btnLaggTillKurs_Click;
            // 
            // btnUppdateraKurs
            // 
            btnUppdateraKurs.Location = new Point(235, 480);
            btnUppdateraKurs.Name = "btnUppdateraKurs";
            btnUppdateraKurs.Size = new Size(137, 29);
            btnUppdateraKurs.TabIndex = 7;
            btnUppdateraKurs.Text = "Uppdatera kurs";
            btnUppdateraKurs.UseVisualStyleBackColor = true;
            btnUppdateraKurs.Click += btnUppdateraKurs_Click;
            // 
            // btnTaBortKurs
            // 
            btnTaBortKurs.Location = new Point(444, 480);
            btnTaBortKurs.Name = "btnTaBortKurs";
            btnTaBortKurs.Size = new Size(133, 29);
            btnTaBortKurs.TabIndex = 8;
            btnTaBortKurs.Text = "Ta bort kurs";
            btnTaBortKurs.UseVisualStyleBackColor = true;
            btnTaBortKurs.Click += btnTaBortKurs_Click;
            // 
            // btnTillbaka
            // 
            btnTillbaka.Location = new Point(633, 522);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(121, 38);
            btnTillbaka.TabIndex = 9;
            btnTillbaka.Text = "Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            btnTillbaka.Click += btnTillbaka_Click;
            // 
            // lblKurser
            // 
            lblKurser.AutoSize = true;
            lblKurser.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKurser.Location = new Point(48, 60);
            lblKurser.Name = "lblKurser";
            lblKurser.Size = new Size(81, 31);
            lblKurser.TabIndex = 10;
            lblKurser.Text = "Kurser";
            // 
            // KurshanteringForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 588);
            Controls.Add(lblKurser);
            Controls.Add(btnTillbaka);
            Controls.Add(btnTaBortKurs);
            Controls.Add(btnUppdateraKurs);
            Controls.Add(btnLaggTillKurs);
            Controls.Add(txtKursnamn);
            Controls.Add(lblKursnman);
            Controls.Add(txtKurskod);
            Controls.Add(lblKurskod);
            Controls.Add(lstKurser);
            Controls.Add(lblKurshantering);
            Name = "KurshanteringForm";
            Text = "KurshanteringForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKurshantering;
        private ListBox lstKurser;
        private Label lblKurskod;
        private TextBox txtKurskod;
        private Label lblKursnman;
        private TextBox txtKursnamn;
        private Button btnLaggTillKurs;
        private Button btnUppdateraKurs;
        private Button btnTaBortKurs;
        private Button btnTillbaka;
        private Label lblKurser;
    }
}