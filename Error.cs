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
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            /*Scipt que cierra el form actual y regresa al form Index */
            Form Index = new Index();
            Index.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); /*Codigo para cerrar el programa*/
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(415, 489); /*Se indica el nuevo tamaño del form*/

            /*Se deja los textbox en blanco*/
            TbLim.Text = "";
            TbXi.Text = "";
            TbA.Text = "";
            TbB.Text = "";
            TbC.Text = "";

            /*Se limpia el DataGridView*/
            DgvResultado.Rows.Clear();
            /*Se desactiva el boton Calcular*/
            btnCalcular.Enabled = true;
            /*Los texbox ya no son solo de lectura*/
            TbLim.ReadOnly = false;
            TbXi.ReadOnly = false;
            TbA.ReadOnly = false;
            TbB.ReadOnly = false;
            TbC.ReadOnly = false;
        }

        private void Error_Load(object sender, EventArgs e)
        {
            /*Se indica el tamaño con el que debe iniciar el Form*/
            this.Size = new Size(415, 489);
        }

        private void TbLim_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Condicion  que hace que solo se permitan numeros en el texybox*/
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || e.KeyChar == 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TbXi_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Condicion  que hace que solo se permitan numeros en el texybox*/
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || e.KeyChar == 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TbA_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Condicion  que hace que solo se permitan numeros en el texybox*/
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || e.KeyChar == 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TbB_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Condicion  que hace que solo se permitan numeros en el texybox*/
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || e.KeyChar == 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TbC_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Condicion  que hace que solo se permitan numeros en el texybox*/
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) ||  e.KeyChar == 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*Se crean las variables que leen los textbox*/
            string Lims = TbLim.Text;
            string Xis = TbXi.Text;
            string As = TbA.Text;
            string Bs = TbB.Text;
            string Cs = TbC.Text;

            /*Condicion en caso de que alguno de los textbox esté vacio no se pueda avanzar*/
            if (Lims == "" || Xis == "" || As == "" || Bs == "" || Cs == "")
            {
                MessageBox.Show("Rellene todas las casillas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            /*Si todos los textbox tienen valores se puede realizar los calculos*/
            else
            {
                /*Se convierten las variables de string a double*/
                double Lim = Convert.ToDouble(TbLim.Text);/*Limite de iteracion*/
                double Xi = Convert.ToDouble(TbXi.Text);/*Valor inicial*/
                double A = Convert.ToDouble(TbA.Text);
                double B = Convert.ToDouble(TbB.Text);
                double C = Convert.ToDouble(TbC.Text);
                double f;
                double g;
                double X = Xi;
                double er = 100;
                double i = 0;

                /*Se configura el tamaño del form*/
                this.Size = new Size(1012, 489);

                /*Y se desactiva el boton Calcular*/
                btnCalcular.Enabled = false;
                /*Los textbox se hacen de solo lectura*/
                TbLim.ReadOnly = true;
                TbXi.ReadOnly = true;
                TbA.ReadOnly = true;
                TbB.ReadOnly = true;
                TbC.ReadOnly = true;

                do/*Ciclo donde se realizan los calculos y se insertan datos en el DataGridView*/
                {
                    i = i + 1;
                    int n = DgvResultado.Rows.Add();/*Se Añade una fila enumerada en n*/
                    f = (A * (Math.Pow(X, 2))) + (B * X) + C;/*Se calcula f(x)*/
                    g = ((A * Math.Pow(X, 2)) + C) / -B;/*g(x) es la derivada de f(x), se calcula el valor de g(x)*/

                    DgvResultado.Rows[n].Cells[0].Value = i;/*Se inserta el valor de i en la primera celda de la fila n*/
                    DgvResultado.Rows[n].Cells[1].Value = X;/*Se inserta el valor de X en la segunda celda de la fila n*/
                    DgvResultado.Rows[n].Cells[2].Value = g;/*Se inserta el valor de g en la tercera celda de la fila n*/
                    DgvResultado.Rows[n].Cells[3].Value = f;/*Se inserta el valor de f en la cuarta celda de la fila n*/

                    if (i >= 2)/*Cuando la iteracion sea igual o mayor que 2 se empieza a calcular el error*/
                    {
                        er = ((Math.Abs(X - Xi)) / Math.Abs(X)) * 100;/*Se calcula el error*/
                        DgvResultado.Rows[n].Cells[4].Value = er;/*Se inserta el valor de er en la quinta celda de la fila n*/
                        Xi = X;/*Xi se convirte en X*/

                    }
                    /*En caso de que la iteracion sea menor que 2*/
                    else
                    {
                        /* Se inserta -- en la quinta celda de la fila n*/
                        DgvResultado.Rows[n].Cells[4].Value = "--";
                    }

                    /*X se convierte en g*/
                    X = g;
                } while (er >= Lim);/*El ciclo se va a repetir mientras el error sea mayor que el porcentaje limite*/

            }
        }
    }
}
