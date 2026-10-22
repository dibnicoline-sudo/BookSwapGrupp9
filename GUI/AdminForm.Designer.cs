namespace GUI
{
    partial class AdminForm
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
            lstAnnonser = new ListBox();
            btnTaBortAnnonser = new Button();
            btnHanteraKurser = new Button();
            lblAllaAnnonser = new Label();
            btnHanteraAnvandare = new Button();
            btnLoggaUt = new Button();
            SuspendLayout();
            // 
            // lstAnnonser
            // 
            lstAnnonser.FormattingEnabled = true;
            lstAnnonser.Location = new Point(33, 97);
            lstAnnonser.Name = "lstAnnonser";
            lstAnnonser.Size = new Size(673, 284);
            lstAnnonser.TabIndex = 0;
            // 
            // btnTaBortAnnonser
            // 
            btnTaBortAnnonser.Location = new Point(33, 411);
            btnTaBortAnnonser.Name = "btnTaBortAnnonser";
            btnTaBortAnnonser.Size = new Size(207, 41);
            btnTaBortAnnonser.TabIndex = 1;
            btnTaBortAnnonser.Text = "Ta bort annons";
            btnTaBortAnnonser.UseVisualStyleBackColor = true;
            btnTaBortAnnonser.Click += btnTaBortAnnonser_Click;
            // 
            // btnHanteraKurser
            // 
            btnHanteraKurser.Location = new Point(268, 412);
            btnHanteraKurser.Name = "btnHanteraKurser";
            btnHanteraKurser.Size = new Size(189, 38);
            btnHanteraKurser.TabIndex = 2;
            btnHanteraKurser.Text = "Hantera kurser";
            btnHanteraKurser.UseVisualStyleBackColor = true;
            btnHanteraKurser.Click += btnHanteraKurser_Click;
            // 
            // lblAllaAnnonser
            // 
            lblAllaAnnonser.AutoSize = true;
            lblAllaAnnonser.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAllaAnnonser.Location = new Point(33, 37);
            lblAllaAnnonser.Name = "lblAllaAnnonser";
            lblAllaAnnonser.Size = new Size(190, 38);
            lblAllaAnnonser.TabIndex = 3;
            lblAllaAnnonser.Text = "Alla annonser";
            // 
            // btnHanteraAnvandare
            // 
            btnHanteraAnvandare.Location = new Point(485, 414);
            btnHanteraAnvandare.Name = "btnHanteraAnvandare";
            btnHanteraAnvandare.Size = new Size(189, 38);
            btnHanteraAnvandare.TabIndex = 4;
            btnHanteraAnvandare.Text = "Hantera användare";
            btnHanteraAnvandare.UseVisualStyleBackColor = true;
            btnHanteraAnvandare.Click += btnHanteraAnvandare_Click;
            // 
            // btnLoggaUt
            // 
            btnLoggaUt.Location = new Point(635, 483);
            btnLoggaUt.Name = "btnLoggaUt";
            btnLoggaUt.Size = new Size(133, 36);
            btnLoggaUt.TabIndex = 5;
            btnLoggaUt.Text = "Logga ut";
            btnLoggaUt.UseVisualStyleBackColor = true;
            btnLoggaUt.Click += btnLoggaUt_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 531);
            Controls.Add(btnLoggaUt);
            Controls.Add(btnHanteraAnvandare);
            Controls.Add(lblAllaAnnonser);
            Controls.Add(btnHanteraKurser);
            Controls.Add(btnTaBortAnnonser);
            Controls.Add(lstAnnonser);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstAnnonser;
        private Button btnTaBortAnnonser;
        private Button btnHanteraKurser;
        private Label lblAllaAnnonser;
        private Button btnHanteraAnvandare;
        private Button btnLoggaUt;
    }
}