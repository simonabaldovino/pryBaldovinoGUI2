namespace pryBaldovinoGUI
{
    partial class frmButonera
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
            lblDatos = new Label();
            btnSiguiente = new Button();
            btnAtras = new Button();
            lblPrimero = new Button();
            lblUltimo = new Button();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.BorderStyle = BorderStyle.Fixed3D;
            lblDatos.Location = new Point(178, 55);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(2, 17);
            lblDatos.TabIndex = 0;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(186, 147);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 5;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += lblSiguiente_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(105, 147);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 6;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblPrimero
            // 
            lblPrimero.Location = new Point(24, 147);
            lblPrimero.Name = "lblPrimero";
            lblPrimero.Size = new Size(75, 23);
            lblPrimero.TabIndex = 7;
            lblPrimero.Text = "Primero";
            lblPrimero.UseVisualStyleBackColor = true;
            lblPrimero.Click += lblPrimero_Click;
            // 
            // lblUltimo
            // 
            lblUltimo.Location = new Point(267, 147);
            lblUltimo.Name = "lblUltimo";
            lblUltimo.Size = new Size(75, 23);
            lblUltimo.TabIndex = 8;
            lblUltimo.Text = "Último";
            lblUltimo.UseVisualStyleBackColor = true;
            // 
            // frmButonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 204);
            Controls.Add(lblUltimo);
            Controls.Add(lblPrimero);
            Controls.Add(btnAtras);
            Controls.Add(btnSiguiente);
            Controls.Add(lblDatos);
            Name = "frmButonera";
            Text = "frmbutonera";
            Load += frmButonera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatos;
        private Button btnSiguiente;
        private Button btnAtras;
        private Button lblPrimero;
        private Button lblUltimo;
    }
}