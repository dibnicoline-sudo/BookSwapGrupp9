namespace GUI
{
    partial class MinaAnnonserForm
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
            lstMinaAnnonser = new ListBox();
            lblMinaAnnonser = new Label();
            btnLaggTillAnnons = new Button();
            btnUppdateraAnnons = new Button();
            btnTaBortAnnons = new Button();
            btnTillbaka = new Button();
            SuspendLayout();
            // 
            // lstMinaAnnonser
            // 
            lstMinaAnnonser.FormattingEnabled = true;
            lstMinaAnnonser.Location = new Point(45, 94);
            lstMinaAnnonser.Name = "lstMinaAnnonser";
            lstMinaAnnonser.Size = new Size(634, 204);
            lstMinaAnnonser.TabIndex = 0;
            // 
            // lblMinaAnnonser
            // 
            lblMinaAnnonser.AutoSize = true;
            lblMinaAnnonser.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinaAnnonser.Location = new Point(45, 9);
            lblMinaAnnonser.Name = "lblMinaAnnonser";
            lblMinaAnnonser.Size = new Size(206, 38);
            lblMinaAnnonser.TabIndex = 1;
            lblMinaAnnonser.Text = "Mina annonser";
            // 
            // btnLaggTillAnnons
            // 
            btnLaggTillAnnons.Location = new Point(45, 319);
            btnLaggTillAnnons.Name = "btnLaggTillAnnons";
            btnLaggTillAnnons.Size = new Size(166, 29);
            btnLaggTillAnnons.TabIndex = 2;
            btnLaggTillAnnons.Text = "Lägg till en annons";
            btnLaggTillAnnons.UseVisualStyleBackColor = true;
            btnLaggTillAnnons.Click += btnLaggTillAnnons_Click;
            // 
            // btnUppdateraAnnons
            // 
            btnUppdateraAnnons.Location = new Point(285, 319);
            btnUppdateraAnnons.Name = "btnUppdateraAnnons";
            btnUppdateraAnnons.Size = new Size(157, 29);
            btnUppdateraAnnons.TabIndex = 3;
            btnUppdateraAnnons.Text = "Uppdatera annons";
            btnUppdateraAnnons.UseVisualStyleBackColor = true;
            btnUppdateraAnnons.Click += btnUppdateraAnnons_Click;
            // 
            // btnTaBortAnnons
            // 
            btnTaBortAnnons.Location = new Point(547, 319);
            btnTaBortAnnons.Name = "btnTaBortAnnons";
            btnTaBortAnnons.Size = new Size(132, 29);
            btnTaBortAnnons.TabIndex = 4;
            btnTaBortAnnons.Text = "Ta bort annons";
            btnTaBortAnnons.UseVisualStyleBackColor = true;
            btnTaBortAnnons.Click += btnTaBortAnnons_Click;
            // 
            // btnTillbaka
            // 
            btnTillbaka.Location = new Point(45, 395);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(132, 29);
            btnTillbaka.TabIndex = 5;
            btnTillbaka.Text = "Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            btnTillbaka.Click += btnTillbaka_Click_1;
            // 
            // MinaAnnonserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTillbaka);
            Controls.Add(btnTaBortAnnons);
            Controls.Add(btnUppdateraAnnons);
            Controls.Add(btnLaggTillAnnons);
            Controls.Add(lblMinaAnnonser);
            Controls.Add(lstMinaAnnonser);
            Name = "MinaAnnonserForm";
            Text = "MinaAnnonserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMinaAnnonser;
        private Label lblMinaAnnonser;
        private Button btnLaggTillAnnons;
        private Button btnUppdateraAnnons;
        private Button btnTaBortAnnons;
        private Button btnTillbaka;
    }
}