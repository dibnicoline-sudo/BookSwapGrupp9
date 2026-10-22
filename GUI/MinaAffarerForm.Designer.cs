namespace GUI
{
    partial class MinaAffarerForm
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
            lstAffarer = new ListBox();
            btnBekraftaKop = new Button();
            btnTillbaka = new Button();
            SuspendLayout();
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRubrik.Location = new Point(53, 34);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(360, 38);
            lblRubrik.TabIndex = 0;
            lblRubrik.Text = "Mina affärer - försäljningar";
            // 
            // lstAffarer
            // 
            lstAffarer.FormattingEnabled = true;
            lstAffarer.Location = new Point(62, 87);
            lstAffarer.Name = "lstAffarer";
            lstAffarer.Size = new Size(602, 204);
            lstAffarer.TabIndex = 1;
            // 
            // btnBekraftaKop
            // 
            btnBekraftaKop.Location = new Point(62, 334);
            btnBekraftaKop.Name = "btnBekraftaKop";
            btnBekraftaKop.Size = new Size(169, 36);
            btnBekraftaKop.TabIndex = 2;
            btnBekraftaKop.Text = "Bekräfta köp";
            btnBekraftaKop.UseVisualStyleBackColor = true;
            btnBekraftaKop.Click += btnBekraftaKop_Click;
            // 
            // btnTillbaka
            // 
            btnTillbaka.Location = new Point(589, 334);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(169, 36);
            btnTillbaka.TabIndex = 3;
            btnTillbaka.Text = "Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            btnTillbaka.Click += btnTillbaka_Click;
            // 
            // MinaAffarerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTillbaka);
            Controls.Add(btnBekraftaKop);
            Controls.Add(lstAffarer);
            Controls.Add(lblRubrik);
            Name = "MinaAffarerForm";
            Text = "MinaAffarerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRubrik;
        private ListBox lstAffarer;
        private Button btnBekraftaKop;
        private Button btnTillbaka;
    }
}