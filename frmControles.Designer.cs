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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControles));
            btnAbrir = new Button();
            SuspendLayout();
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(40, 36);
            btnAbrir.Margin = new Padding(3, 4, 3, 4);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(139, 39);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Abrir butonera";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // frmControles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 615);
            Controls.Add(btnAbrir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmControles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmControles";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbrir;
    }
}