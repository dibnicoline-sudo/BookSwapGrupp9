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
            SuspendLayout();
            // 
            // lstAnnonser
            // 
            lstAnnonser.FormattingEnabled = true;
            lstAnnonser.Location = new Point(33, 35);
            lstAnnonser.Name = "lstAnnonser";
            lstAnnonser.Size = new Size(501, 284);
            lstAnnonser.TabIndex = 0;
            // 
            // btnTaBortAnnonser
            // 
            btnTaBortAnnonser.Location = new Point(33, 344);
            btnTaBortAnnonser.Name = "btnTaBortAnnonser";
            btnTaBortAnnonser.Size = new Size(207, 41);
            btnTaBortAnnonser.TabIndex = 1;
            btnTaBortAnnonser.Text = "Ta bort annons";
            btnTaBortAnnonser.UseVisualStyleBackColor = true;
            btnTaBortAnnonser.Click += btnTaBortAnnonser_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTaBortAnnonser);
            Controls.Add(lstAnnonser);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstAnnonser;
        private Button btnTaBortAnnonser;
    }
}