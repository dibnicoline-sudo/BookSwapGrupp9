namespace GUI
{
    partial class VisaAnnonserForm
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
            lstAnnonser = new ListBox();
            btnTillbaka = new Button();
            btnReserveraAnnons = new Button();
            lblSok = new Label();
            btnSok = new Button();
            txtSok = new TextBox();
            SuspendLayout();
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRubrik.Location = new Point(46, 20);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(289, 38);
            lblRubrik.TabIndex = 0;
            lblRubrik.Text = "Tillgängliga annonser";
            // 
            // lstAnnonser
            // 
            lstAnnonser.FormattingEnabled = true;
            lstAnnonser.Location = new Point(46, 152);
            lstAnnonser.Name = "lstAnnonser";
            lstAnnonser.Size = new Size(662, 264);
            lstAnnonser.TabIndex = 1;
            // 
            // btnTillbaka
            // 
            btnTillbaka.Location = new Point(715, 480);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(94, 29);
            btnTillbaka.TabIndex = 2;
            btnTillbaka.Text = "Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            btnTillbaka.Click += btnTillbaka_Click;
            // 
            // btnReserveraAnnons
            // 
            btnReserveraAnnons.Location = new Point(46, 460);
            btnReserveraAnnons.Name = "btnReserveraAnnons";
            btnReserveraAnnons.Size = new Size(185, 29);
            btnReserveraAnnons.TabIndex = 3;
            btnReserveraAnnons.Text = "Reservera annons";
            btnReserveraAnnons.UseVisualStyleBackColor = true;
            btnReserveraAnnons.Click += btnReserveraAnnons_Click;
            // 
            // lblSok
            // 
            lblSok.AutoSize = true;
            lblSok.Location = new Point(46, 77);
            lblSok.Name = "lblSok";
            lblSok.Size = new Size(119, 20);
            lblSok.TabIndex = 4;
            lblSok.Text = "Sök efter annons";
            // 
            // btnSok
            // 
            btnSok.Location = new Point(263, 100);
            btnSok.Name = "btnSok";
            btnSok.Size = new Size(94, 29);
            btnSok.TabIndex = 5;
            btnSok.Text = "Sök";
            btnSok.UseVisualStyleBackColor = true;
            btnSok.Click += btnSok_Click;
            // 
            // txtSok
            // 
            txtSok.Location = new Point(46, 100);
            txtSok.Name = "txtSok";
            txtSok.Size = new Size(161, 27);
            txtSok.TabIndex = 6;
            // 
            // VisaAnnonserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 534);
            Controls.Add(txtSok);
            Controls.Add(btnSok);
            Controls.Add(lblSok);
            Controls.Add(btnReserveraAnnons);
            Controls.Add(btnTillbaka);
            Controls.Add(lstAnnonser);
            Controls.Add(lblRubrik);
            Name = "VisaAnnonserForm";
            Text = "VisaAnnonserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRubrik;
        private ListBox lstAnnonser;
        private Button btnTillbaka;
        private Button btnReserveraAnnons;
        private Label lblSok;
        private Button btnSok;
        private TextBox txtSok;
    }
}