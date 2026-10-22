namespace GUI
{
    partial class StudentForm
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
            lblValkommen = new Label();
            btnVisaAnnonser = new Button();
            btnMinaAnnonser = new Button();
            lblMeny = new Label();
            btnLoggaUt = new Button();
            btnMinaAffarer = new Button();
            SuspendLayout();
            // 
            // lblValkommen
            // 
            lblValkommen.AutoSize = true;
            lblValkommen.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValkommen.Location = new Point(37, 31);
            lblValkommen.Name = "lblValkommen";
            lblValkommen.Size = new Size(372, 38);
            lblValkommen.TabIndex = 0;
            lblValkommen.Text = "Välkommen till BookSwap!";
            // 
            // btnVisaAnnonser
            // 
            btnVisaAnnonser.Location = new Point(52, 150);
            btnVisaAnnonser.Name = "btnVisaAnnonser";
            btnVisaAnnonser.Size = new Size(192, 29);
            btnVisaAnnonser.TabIndex = 1;
            btnVisaAnnonser.Text = "Visa tillängliga annonser";
            btnVisaAnnonser.UseVisualStyleBackColor = true;
            btnVisaAnnonser.Click += btnVisaAnnonser_Click;
            // 
            // btnMinaAnnonser
            // 
            btnMinaAnnonser.Location = new Point(52, 207);
            btnMinaAnnonser.Name = "btnMinaAnnonser";
            btnMinaAnnonser.Size = new Size(192, 29);
            btnMinaAnnonser.TabIndex = 2;
            btnMinaAnnonser.Text = "Mina annonser";
            btnMinaAnnonser.UseVisualStyleBackColor = true;
            btnMinaAnnonser.Click += btnMinaAnnonser_Click;
            // 
            // lblMeny
            // 
            lblMeny.AutoSize = true;
            lblMeny.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMeny.Location = new Point(52, 100);
            lblMeny.Name = "lblMeny";
            lblMeny.Size = new Size(63, 28);
            lblMeny.TabIndex = 3;
            lblMeny.Text = "Meny";
            // 
            // btnLoggaUt
            // 
            btnLoggaUt.Location = new Point(563, 323);
            btnLoggaUt.Name = "btnLoggaUt";
            btnLoggaUt.Size = new Size(192, 29);
            btnLoggaUt.TabIndex = 4;
            btnLoggaUt.Text = "Logga ut";
            btnLoggaUt.UseVisualStyleBackColor = true;
            btnLoggaUt.Click += btnLoggaUt_Click;
            // 
            // btnMinaAffarer
            // 
            btnMinaAffarer.Location = new Point(52, 269);
            btnMinaAffarer.Name = "btnMinaAffarer";
            btnMinaAffarer.Size = new Size(192, 29);
            btnMinaAffarer.TabIndex = 5;
            btnMinaAffarer.Text = "Mina affärer";
            btnMinaAffarer.UseVisualStyleBackColor = true;
            btnMinaAffarer.Click += btnMinaAffarer_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMinaAffarer);
            Controls.Add(btnLoggaUt);
            Controls.Add(lblMeny);
            Controls.Add(btnMinaAnnonser);
            Controls.Add(btnVisaAnnonser);
            Controls.Add(lblValkommen);
            Name = "StudentForm";
            Text = "StudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValkommen;
        private Button btnVisaAnnonser;
        private Button btnMinaAnnonser;
        private Label lblMeny;
        private Button btnLoggaUt;
        private Button btnMinaAffarer;
    }
}