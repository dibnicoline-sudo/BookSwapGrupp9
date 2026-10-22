namespace GUI
{
    partial class UppdateraAnnonsForm
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
            lblRubrik = new Label();
            lblTitel = new Label();
            txtTitel = new TextBox();
            lblPris = new Label();
            txtPris = new TextBox();
            lblSkick = new Label();
            cmbSkick = new ComboBox();
            btnSparaÄndringar = new Button();
            btnAvbryt = new Button();
            SuspendLayout();
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRubrik.Location = new Point(57, 41);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(253, 38);
            lblRubrik.TabIndex = 0;
            lblRubrik.Text = "Uppdatera annons";
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(57, 112);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(38, 20);
            lblTitel.TabIndex = 1;
            lblTitel.Text = "Titel";
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(57, 149);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(278, 27);
            txtTitel.TabIndex = 2;
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(57, 210);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(32, 20);
            lblPris.TabIndex = 3;
            lblPris.Text = "Pris";
            // 
            // txtPris
            // 
            txtPris.Location = new Point(57, 242);
            txtPris.Name = "txtPris";
            txtPris.Size = new Size(278, 27);
            txtPris.TabIndex = 4;
            // 
            // lblSkick
            // 
            lblSkick.AutoSize = true;
            lblSkick.Location = new Point(57, 301);
            lblSkick.Name = "lblSkick";
            lblSkick.Size = new Size(42, 20);
            lblSkick.TabIndex = 5;
            lblSkick.Text = "Skick";
            // 
            // cmbSkick
            // 
            cmbSkick.FormattingEnabled = true;
            cmbSkick.Items.AddRange(new object[] { "Nyskick", "BraSkick", "Slitet" });
            cmbSkick.Location = new Point(57, 337);
            cmbSkick.Name = "cmbSkick";
            cmbSkick.Size = new Size(278, 28);
            cmbSkick.TabIndex = 6;
            // 
            // btnSparaÄndringar
            // 
            btnSparaÄndringar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSparaÄndringar.Location = new Point(57, 400);
            btnSparaÄndringar.Name = "btnSparaÄndringar";
            btnSparaÄndringar.Size = new Size(197, 40);
            btnSparaÄndringar.TabIndex = 7;
            btnSparaÄndringar.Text = "Spara ändringar";
            btnSparaÄndringar.UseVisualStyleBackColor = true;
            btnSparaÄndringar.Click += btnSparaÄndringar_Click;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(584, 400);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(123, 40);
            btnAvbryt.TabIndex = 8;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // UppdateraAnnonsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 558);
            Controls.Add(btnAvbryt);
            Controls.Add(btnSparaÄndringar);
            Controls.Add(cmbSkick);
            Controls.Add(lblSkick);
            Controls.Add(txtPris);
            Controls.Add(lblPris);
            Controls.Add(txtTitel);
            Controls.Add(lblTitel);
            Controls.Add(lblRubrik);
            Name = "UppdateraAnnonsForm";
            Text = "UppdateraAnnonsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRubrik;
        private Label lblTitel;
        private TextBox txtTitel;
        private Label lblPris;
        private TextBox txtPris;
        private Label lblSkick;
        private ComboBox cmbSkick;
        private Button btnSparaÄndringar;
        private Button btnAvbryt;
    }
}