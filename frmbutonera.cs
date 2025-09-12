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

        private void frmButonera_Load(object sender, EventArgs e)
        {
            vecNombres[0] = "Luka";
            vecNombres[1] = "Josefina";
            vecNombres[2] = "Pablo";
            vecNombres[3] = "Analia"; 
        }
    }
}
