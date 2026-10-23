namespace GUI
{
    partial class LaggTillAnnonsForm
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
            lblTitel = new Label();
            lblNyTitel = new Label();
            txtTitel = new TextBox();
            lblPris = new Label();
            txtPris = new TextBox();
            lblSkick = new Label();
            cmbSkick = new ComboBox();
            btnAvbryt = new Button();
            btnLaggTillAnnons = new Button();
            lblKurs = new Label();
            cmbKurser = new ComboBox();
            lblTyp = new Label();
            txtExtra1 = new TextBox();
            cmbTyp = new ComboBox();
            lblExtra1 = new Label();
            lblExtra2 = new Label();
            txtExtra2 = new TextBox();
            lblExtra3 = new Label();
            txtExtra3 = new TextBox();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitel.Location = new Point(59, 34);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(158, 31);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Skapa annons";
            // 
            // lblNyTitel
            // 
            lblNyTitel.AutoSize = true;
            lblNyTitel.Location = new Point(58, 98);
            lblNyTitel.Name = "lblNyTitel";
            lblNyTitel.Size = new Size(38, 20);
            lblNyTitel.TabIndex = 1;
            lblNyTitel.Text = "Titel";
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(58, 121);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(214, 27);
            txtTitel.TabIndex = 2;
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(60, 172);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(58, 20);
            lblPris.TabIndex = 3;
            lblPris.Text = "Pris (kr)";
            // 
            // txtPris
            // 
            txtPris.Location = new Point(58, 195);
            txtPris.Name = "txtPris";
            txtPris.Size = new Size(214, 27);
            txtPris.TabIndex = 4;
            // 
            // lblSkick
            // 
            lblSkick.AutoSize = true;
            lblSkick.Location = new Point(60, 251);
            lblSkick.Name = "lblSkick";
            lblSkick.Size = new Size(42, 20);
            lblSkick.TabIndex = 5;
            lblSkick.Text = "Skick";
            // 
            // cmbSkick
            // 
            cmbSkick.FormattingEnabled = true;
            cmbSkick.Items.AddRange(new object[] { "Nyskick", "BraSkick", "Slitet" });
            cmbSkick.Location = new Point(60, 274);
            cmbSkick.Name = "cmbSkick";
            cmbSkick.Size = new Size(212, 28);
            cmbSkick.TabIndex = 6;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(652, 473);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(94, 29);
            btnAvbryt.TabIndex = 7;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // btnLaggTillAnnons
            // 
            btnLaggTillAnnons.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLaggTillAnnons.Location = new Point(59, 438);
            btnLaggTillAnnons.Name = "btnLaggTillAnnons";
            btnLaggTillAnnons.Size = new Size(140, 48);
            btnLaggTillAnnons.TabIndex = 8;
            btnLaggTillAnnons.Text = "Skapa annons";
            btnLaggTillAnnons.UseVisualStyleBackColor = true;
            btnLaggTillAnnons.Click += btnSpara_Click;
            // 
            // lblKurs
            // 
            lblKurs.AutoSize = true;
            lblKurs.Location = new Point(426, 98);
            lblKurs.Name = "lblKurs";
            lblKurs.Size = new Size(37, 20);
            lblKurs.TabIndex = 9;
            lblKurs.Text = "Kurs";
            // 
            // cmbKurser
            // 
            cmbKurser.FormattingEnabled = true;
            cmbKurser.Location = new Point(426, 121);
            cmbKurser.Name = "cmbKurser";
            cmbKurser.Size = new Size(264, 28);
            cmbKurser.TabIndex = 10;
            // 
            // lblTyp
            // 
            lblTyp.AutoSize = true;
            lblTyp.Location = new Point(426, 172);
            lblTyp.Name = "lblTyp";
            lblTyp.Size = new Size(102, 20);
            lblTyp.TabIndex = 11;
            lblTyp.Text = "Typ av annons";
            // 
            // txtExtra1
            // 
            txtExtra1.Location = new Point(428, 265);
            txtExtra1.Name = "txtExtra1";
            txtExtra1.Size = new Size(262, 27);
            txtExtra1.TabIndex = 13;
            // 
            // cmbTyp
            // 
            cmbTyp.FormattingEnabled = true;
            cmbTyp.Location = new Point(426, 195);
            cmbTyp.Name = "cmbTyp";
            cmbTyp.Size = new Size(264, 28);
            cmbTyp.TabIndex = 14;
            cmbTyp.SelectedIndexChanged += cmbTyp_SelectedIndexChanged;
            // 
            // lblExtra1
            // 
            lblExtra1.AutoSize = true;
            lblExtra1.Location = new Point(428, 242);
            lblExtra1.Name = "lblExtra1";
            lblExtra1.Size = new Size(41, 20);
            lblExtra1.TabIndex = 15;
            lblExtra1.Text = "ISBN";
            // 
            // lblExtra2
            // 
            lblExtra2.AutoSize = true;
            lblExtra2.Location = new Point(428, 306);
            lblExtra2.Name = "lblExtra2";
            lblExtra2.Size = new Size(74, 20);
            lblExtra2.TabIndex = 16;
            lblExtra2.Text = "Författare";
            // 
            // txtExtra2
            // 
            txtExtra2.Location = new Point(427, 329);
            txtExtra2.Name = "txtExtra2";
            txtExtra2.Size = new Size(263, 27);
            txtExtra2.TabIndex = 17;
            // 
            // lblExtra3
            // 
            lblExtra3.AutoSize = true;
            lblExtra3.Location = new Point(428, 379);
            lblExtra3.Name = "lblExtra3";
            lblExtra3.Size = new Size(66, 20);
            lblExtra3.TabIndex = 18;
            lblExtra3.Text = "Upplaga";
            lblExtra3.Click += label1_Click;
            // 
            // txtExtra3
            // 
            txtExtra3.Location = new Point(426, 402);
            txtExtra3.Name = "txtExtra3";
            txtExtra3.Size = new Size(264, 27);
            txtExtra3.TabIndex = 19;
            // 
            // LaggTillAnnonsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 531);
            Controls.Add(txtExtra3);
            Controls.Add(lblExtra3);
            Controls.Add(txtExtra2);
            Controls.Add(lblExtra2);
            Controls.Add(lblExtra1);
            Controls.Add(cmbTyp);
            Controls.Add(txtExtra1);
            Controls.Add(lblTyp);
            Controls.Add(cmbKurser);
            Controls.Add(lblKurs);
            Controls.Add(btnLaggTillAnnons);
            Controls.Add(btnAvbryt);
            Controls.Add(cmbSkick);
            Controls.Add(lblSkick);
            Controls.Add(txtPris);
            Controls.Add(lblPris);
            Controls.Add(txtTitel);
            Controls.Add(lblNyTitel);
            Controls.Add(lblTitel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LaggTillAnnonsForm";
            Text = "LaggTillAnnonsForm";
            Load += LaggTillAnnonsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private Label lblNyTitel;
        private TextBox txtTitel;
        private Label lblPris;
        private TextBox txtPris;
        private Label lblSkick;
        private ComboBox cmbSkick;
        private Button btnAvbryt;
        private Button btnLaggTillAnnons;
        private Label lblKurs;
        private ComboBox cmbKurser;
        private Label lblTyp;
        private TextBox txtExtra3;
        private TextBox txtExtra1;
        private ComboBox cmbTyp;
        private Label lblExtra1;
        private Label lblExtra2;
        private TextBox txtExtra2;
        private Label lblExtra3;
    }
}