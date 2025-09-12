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
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.BorderStyle = BorderStyle.Fixed3D;
            lblDatos.Location = new Point(105, 56);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(2, 17);
            lblDatos.TabIndex = 0;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(186, 124);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 5;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(92, 124);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 6;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(32, 56);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado";
            // 
            // frmButonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 200);
            Controls.Add(lblResultado);
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
        private Label lblResultado;
    }
}