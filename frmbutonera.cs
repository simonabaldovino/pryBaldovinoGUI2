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
            indice++;

            if (vecNombres.Length > indice)
            {
                lblDatos.Text = vecNombres[indice];

                if ((indice + 1) == vecNombres.Length)
                {
                    btnSiguiente.Enabled = false;
                }

                if (indice > 0)
                {
                    btnAtras.Enabled = true;
                }
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;

                lblDatos.Text = vecNombres[indice];

                if (indice == 0)
                {
                    btnAtras.Enabled = false;
                }

                btnSiguiente.Enabled = true;
            }



        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            lblDatos.Text = vecNombres[0];
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            lblDatos.Text = vecNombres[vecNombres.Length - 1];
        }
    }
}
