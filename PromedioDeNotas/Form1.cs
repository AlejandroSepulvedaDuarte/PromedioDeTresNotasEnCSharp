using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
           if (txtnum1.Text == "" || txtnum2.Text == "" ||txtnum3.Text =="") {
                MessageBox.Show("Todos los campos deben estar diligenciados", "Mensaje de validación",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double num1, num2, num3, suma, resultado;
                num1 = double.Parse(txtnum1.Text);
                num2 = double.Parse(txtnum2.Text);
                num3 = double.Parse(txtnum3.Text);
                suma = num1 + num2 + num3;
                resultado = suma / 3;
                if(resultado< 3)
                {
                    lblresultado.Text = Convert.ToString(resultado + " (Reprobaste; Debes ver nuevamente la guía.)");
                    lblresultado.Visible = true;
                    label5.Visible = true;
                }else if(resultado>=3 && resultado <= 5)
                {
                    lblresultado.Text = Convert.ToString(resultado + " (Felicitaciones haz Aprobado)");
                    lblresultado.Visible = true;
                    label5.Visible = true;

                }

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnum1.Text = String.Empty;
            txtnum2.Text = String.Empty;
            txtnum3.Text = String.Empty;
            lblresultado.Visible = false;
            label5.Visible = false;
            txtnum1.Focus();
        }
    }
}
