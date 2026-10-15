namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBekraftaKop = new Button();
            lstAffarer = new ListBox();
            SuspendLayout();
            // 
            // btnBekraftaKop
            // 
            btnBekraftaKop.Location = new Point(12, 190);
            btnBekraftaKop.Name = "btnBekraftaKop";
            btnBekraftaKop.Size = new Size(160, 29);
            btnBekraftaKop.TabIndex = 0;
            btnBekraftaKop.Text = "Bekräfta köp";
            btnBekraftaKop.UseVisualStyleBackColor = true;
            btnBekraftaKop.Click += btnBekraftaKop_Click;
            // 
            // lstAffarer
            // 
            lstAffarer.FormattingEnabled = true;
            lstAffarer.Location = new Point(12, 45);
            lstAffarer.Name = "lstAffarer";
            lstAffarer.Size = new Size(400, 104);
            lstAffarer.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstAffarer);
            Controls.Add(btnBekraftaKop);
            Name = "Form1";
            Text = "BookSwap";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBekraftaKop;
        private ListBox lstAffarer;
    }
}
