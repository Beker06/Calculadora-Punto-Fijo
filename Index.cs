using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MN_2._0
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();/*Codigo para cerrar el programa*/
        }

        private void btnInteracion_Click(object sender, EventArgs e)
        {
            /*Scipt que cierra el form actual y abre el form Iteracion */
            Form Itera = new Iteracion();
            Itera.Show();
            this.Hide();
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            /*Scipt que cierra el form actual y abre el fuorm Error */
            Form Err = new Error();
            Err.Show();
            this.Hide();
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }
    }
}
