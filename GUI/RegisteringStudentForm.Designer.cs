namespace GUI
{
    partial class RegisteringStudentForm
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
            lblFornamn = new Label();
            txtFornamn = new TextBox();
            lblEfternamn = new Label();
            txtEfternamn = new TextBox();
            lblEpost = new Label();
            txtEpost = new TextBox();
            lblTelefonnummer = new Label();
            txtTelefonnummer = new TextBox();
            lblLosenord = new Label();
            txtLosenord = new TextBox();
            btnRegistrera = new Button();
            lblRubrik = new Label();
            SuspendLayout();
            // 
            // lblFornamn
            // 
            lblFornamn.AutoSize = true;
            lblFornamn.Location = new Point(34, 90);
            lblFornamn.Name = "lblFornamn";
            lblFornamn.Size = new Size(67, 20);
            lblFornamn.TabIndex = 0;
            lblFornamn.Text = "Förnamn";
            lblFornamn.Click += label1_Click;
            // 
            // txtFornamn
            // 
            txtFornamn.Location = new Point(34, 122);
            txtFornamn.Name = "txtFornamn";
            txtFornamn.Size = new Size(125, 27);
            txtFornamn.TabIndex = 1;
            // 
            // lblEfternamn
            // 
            lblEfternamn.AutoSize = true;
            lblEfternamn.Location = new Point(34, 167);
            lblEfternamn.Name = "lblEfternamn";
            lblEfternamn.Size = new Size(77, 20);
            lblEfternamn.TabIndex = 2;
            lblEfternamn.Text = "Efternamn";
            // 
            // txtEfternamn
            // 
            txtEfternamn.Location = new Point(34, 201);
            txtEfternamn.Name = "txtEfternamn";
            txtEfternamn.Size = new Size(125, 27);
            txtEfternamn.TabIndex = 3;
            // 
            // lblEpost
            // 
            lblEpost.AutoSize = true;
            lblEpost.Location = new Point(34, 259);
            lblEpost.Name = "lblEpost";
            lblEpost.Size = new Size(94, 20);
            lblEpost.TabIndex = 4;
            lblEpost.Text = "E-postadress";
            // 
            // txtEpost
            // 
            txtEpost.Location = new Point(34, 291);
            txtEpost.Name = "txtEpost";
            txtEpost.Size = new Size(125, 27);
            txtEpost.TabIndex = 5;
            // 
            // lblTelefonnummer
            // 
            lblTelefonnummer.AutoSize = true;
            lblTelefonnummer.Location = new Point(34, 348);
            lblTelefonnummer.Name = "lblTelefonnummer";
            lblTelefonnummer.Size = new Size(113, 20);
            lblTelefonnummer.TabIndex = 7;
            lblTelefonnummer.Text = "Telefonnummer";
            // 
            // txtTelefonnummer
            // 
            txtTelefonnummer.Location = new Point(34, 381);
            txtTelefonnummer.Name = "txtTelefonnummer";
            txtTelefonnummer.Size = new Size(125, 27);
            txtTelefonnummer.TabIndex = 8;
            // 
            // lblLosenord
            // 
            lblLosenord.AutoSize = true;
            lblLosenord.Location = new Point(34, 437);
            lblLosenord.Name = "lblLosenord";
            lblLosenord.Size = new Size(70, 20);
            lblLosenord.TabIndex = 9;
            lblLosenord.Text = "Lösenord";
            // 
            // txtLosenord
            // 
            txtLosenord.Location = new Point(34, 460);
            txtLosenord.Name = "txtLosenord";
            txtLosenord.Size = new Size(125, 27);
            txtLosenord.TabIndex = 10;
            txtLosenord.UseSystemPasswordChar = true;
            // 
            // btnRegistrera
            // 
            btnRegistrera.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrera.Location = new Point(34, 529);
            btnRegistrera.Name = "btnRegistrera";
            btnRegistrera.Size = new Size(166, 49);
            btnRegistrera.TabIndex = 11;
            btnRegistrera.Text = "Registrera";
            btnRegistrera.UseVisualStyleBackColor = true;
            btnRegistrera.Click += button1_Click;
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRubrik.Location = new Point(37, 26);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(414, 41);
            lblRubrik.TabIndex = 12;
            lblRubrik.Text = "Skapa ditt BookSwap-konto";
            // 
            // RegisteringStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 716);
            Controls.Add(lblRubrik);
            Controls.Add(btnRegistrera);
            Controls.Add(txtLosenord);
            Controls.Add(lblLosenord);
            Controls.Add(txtTelefonnummer);
            Controls.Add(lblTelefonnummer);
            Controls.Add(txtEpost);
            Controls.Add(lblEpost);
            Controls.Add(txtEfternamn);
            Controls.Add(lblEfternamn);
            Controls.Add(txtFornamn);
            Controls.Add(lblFornamn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisteringStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookSwap - Registrera konto";
            Load += RegisteringStudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFornamn;
        private TextBox txtFornamn;
        private Label lblEfternamn;
        private TextBox txtEfternamn;
        private Label lblEpost;
        private TextBox txtEpost;
        private Label lblSkapaKonto;
        private Label lblTelefonnummer;
        private TextBox txtTelefonnummer;
        private Label lblLosenord;
        private TextBox txtLosenord;
        private Button btnRegistrera;
        private Label lblRubrik;
    }
}