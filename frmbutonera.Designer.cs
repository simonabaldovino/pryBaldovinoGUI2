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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmButonera));
            lblDatos = new Label();
            btnSiguiente = new Button();
            btnAtras = new Button();
            cboNombre = new ComboBox();
            lblNombres = new Label();
            btnUltimo = new Button();
            btnPrimero = new Button();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.BorderStyle = BorderStyle.Fixed3D;
            lblDatos.Location = new Point(179, 81);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(2, 22);
            lblDatos.TabIndex = 0;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(216, 165);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(86, 31);
            btnSiguiente.TabIndex = 5;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(123, 165);
            btnAtras.Margin = new Padding(3, 4, 3, 4);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(86, 31);
            btnAtras.TabIndex = 6;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // cboNombre
            // 
            cboNombre.FormattingEnabled = true;
            cboNombre.Items.AddRange(new object[] { "Luka", "Josefina", "Pablo " });
            cboNombre.Location = new Point(158, 337);
            cboNombre.Margin = new Padding(3, 4, 3, 4);
            cboNombre.Name = "cboNombre";
            cboNombre.Size = new Size(157, 28);
            cboNombre.TabIndex = 9;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(37, 341);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(70, 20);
            lblNombres.TabIndex = 10;
            lblNombres.Text = "Nombres";
            // 
            // btnUltimo
            // 
            btnUltimo.Location = new Point(309, 165);
            btnUltimo.Margin = new Padding(3, 4, 3, 4);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(86, 31);
            btnUltimo.TabIndex = 11;
            btnUltimo.Text = "Último";
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Location = new Point(31, 165);
            btnPrimero.Margin = new Padding(3, 4, 3, 4);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(86, 31);
            btnPrimero.TabIndex = 12;
            btnPrimero.Text = "Primero";
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // frmButonera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 399);
            Controls.Add(btnPrimero);
            Controls.Add(btnUltimo);
            Controls.Add(lblNombres);
            Controls.Add(cboNombre);
            Controls.Add(btnAtras);
            Controls.Add(btnSiguiente);
            Controls.Add(lblDatos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmButonera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmbutonera";
            Load += frmButonera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatos;
        private Button btnSiguiente;
        private Button btnAtras;
        private ComboBox cboNombre;
        private Label lblNombres;
        private Button btnUltimo;
        private Button btnPrimero;
    }
}