namespace pryBaldovinoGUI
{
    partial class frmControles
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
            btnAbrir = new Button();
            SuspendLayout();
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(35, 27);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(122, 29);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Abrir butonera";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // frmControles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(btnAbrir);
            Name = "frmControles";
            Text = "frmControles";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbrir;
    }
}