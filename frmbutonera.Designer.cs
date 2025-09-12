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
            lblSiguiente = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            lblNombre = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.BorderStyle = BorderStyle.Fixed3D;
            lblDatos.Location = new Point(104, 154);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(2, 17);
            lblDatos.TabIndex = 0;
            // 
            // lblSiguiente
            // 
            lblSiguiente.Location = new Point(185, 222);
            lblSiguiente.Name = "lblSiguiente";
            lblSiguiente.Size = new Size(75, 23);
            lblSiguiente.TabIndex = 5;
            lblSiguiente.Text = "Siguiente";
            lblSiguiente.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(91, 222);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(31, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(31, 154);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado";
            // 
            // frmButonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 375);
            Controls.Add(lblResultado);
            Controls.Add(lblNombre);
            Controls.Add(button1);
            Controls.Add(lblSiguiente);
            Controls.Add(textBox1);
            Controls.Add(lblDatos);
            Name = "frmButonera";
            Text = "frmbutonera";
            Load += frmButonera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatos;
        private Button lblSiguiente;
        private TextBox textBox1;
        private Button button1;
        private Label lblNombre;
        private Label lblResultado;
    }
}