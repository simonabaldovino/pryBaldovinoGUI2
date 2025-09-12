using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBaldovinoGUI
{
    public partial class frmButonera : Form
    {
        public frmButonera()
        {
            InitializeComponent();
        }

        string[] vecNombres = new string[3];
        int indice = 0;

        private void frmButonera_Load(object sender, EventArgs e)
        {

            vecNombres[0] = "Luka";
            vecNombres[1] = "Josefina";
            vecNombres[2] = "Pablo";

            lblDatos.Text = vecNombres[0];

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (vecNombres.Length <= 3)
            { 
                indice++;
                lblDatos.Text = vecNombres[indice];
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
          
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            indice--;
            if(vecNombres.Length >= 3)
            { 
                lblDatos.Text = vecNombres[indice];

            }
            else 
            {
                btnSiguiente.Enabled = false;
                MessageBox.Show("El botón ya no se puede usar mas.");
        }
            }
    }
}
