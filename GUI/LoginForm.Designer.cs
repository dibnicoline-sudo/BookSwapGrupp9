namespace GUI
{
    partial class LoginForm
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
            lblEpost = new Label();
            txtEpost = new TextBox();
            lblLosenord = new Label();
            txtLosenord = new TextBox();
            btnLoggaIn = new Button();
            label1 = new Label();
            lblIngetKonto = new Label();
            btnRegistreraDig = new Button();
            SuspendLayout();
            // 
            // lblEpost
            // 
            lblEpost.AutoSize = true;
            lblEpost.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEpost.Location = new Point(35, 73);
            lblEpost.Name = "lblEpost";
            lblEpost.Size = new Size(113, 24);
            lblEpost.TabIndex = 0;
            lblEpost.Text = "E-postadress";
            // 
            // txtEpost
            // 
            txtEpost.Location = new Point(35, 100);
            txtEpost.Name = "txtEpost";
            txtEpost.Size = new Size(182, 27);
            txtEpost.TabIndex = 1;
            txtEpost.TextChanged += textBox1_TextChanged;
            // 
            // lblLosenord
            // 
            lblLosenord.AutoSize = true;
            lblLosenord.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLosenord.Location = new Point(35, 154);
            lblLosenord.Name = "lblLosenord";
            lblLosenord.Size = new Size(84, 24);
            lblLosenord.TabIndex = 2;
            lblLosenord.Text = "Lösenord";
            // 
            // txtLosenord
            // 
            txtLosenord.Location = new Point(35, 177);
            txtLosenord.Name = "txtLosenord";
            txtLosenord.Size = new Size(178, 27);
            txtLosenord.TabIndex = 3;
            txtLosenord.UseSystemPasswordChar = true;
            // 
            // btnLoggaIn
            // 
            btnLoggaIn.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoggaIn.Location = new Point(35, 240);
            btnLoggaIn.Name = "btnLoggaIn";
            btnLoggaIn.Size = new Size(178, 47);
            btnLoggaIn.TabIndex = 4;
            btnLoggaIn.Text = "Logga in";
            btnLoggaIn.UseVisualStyleBackColor = true;
            btnLoggaIn.Click += btnLoggaIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 23);
            label1.Name = "label1";
            label1.Size = new Size(253, 35);
            label1.TabIndex = 5;
            label1.Text = "BookSwap - Logga in";
            // 
            // lblIngetKonto
            // 
            lblIngetKonto.AutoSize = true;
            lblIngetKonto.Location = new Point(35, 337);
            lblIngetKonto.Name = "lblIngetKonto";
            lblIngetKonto.Size = new Size(230, 20);
            lblIngetKonto.TabIndex = 6;
            lblIngetKonto.Text = "Är du ny? Registera ett nytt konto";
            // 
            // btnRegistreraDig
            // 
            btnRegistreraDig.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistreraDig.Location = new Point(35, 372);
            btnRegistreraDig.Name = "btnRegistreraDig";
            btnRegistreraDig.Size = new Size(156, 40);
            btnRegistreraDig.TabIndex = 7;
            btnRegistreraDig.Text = "Registrera dig";
            btnRegistreraDig.UseVisualStyleBackColor = true;
            btnRegistreraDig.Click += btnRegistreraDig_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 484);
            Controls.Add(btnRegistreraDig);
            Controls.Add(lblIngetKonto);
            Controls.Add(label1);
            Controls.Add(btnLoggaIn);
            Controls.Add(txtLosenord);
            Controls.Add(lblLosenord);
            Controls.Add(txtEpost);
            Controls.Add(lblEpost);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEpost;
        private TextBox txtEpost;
        private Label lblLosenord;
        private TextBox txtLosenord;
        private Button btnLoggaIn;
        private Label label1;
        private Label lblIngetKonto;
        private Button btnRegistreraDig;
    }
}