using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores_coladera
{
    public partial class Form1 : Form
    {
        Coladera coladera = new Coladera();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = mostrar();
        }

        public string mostrar()
        {
            string mostrar = "";
            coladera.llenar();
            coladera.eliminar();
            for(int i = 1; i <1000 - 1; i++)
            {
                if (coladera.Vector[i] != 0)
                    mostrar += coladera.Vector[i] + ", ";
            }
            return mostrar;
        }
    }
}
