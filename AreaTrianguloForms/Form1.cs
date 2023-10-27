using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //variáveis
                double a, b;

                //Obter números
                a = double.Parse(txtAltura.Text);
                b = double.Parse(txtBase.Text);

                //calcular e mostrar a área do triangulo
                txtResultado.Text = (a * b / 2).ToString();
            }
            catch
            {
                MessageBox.Show("Dados informados inválidos! ");
                //limpar os txts
                txtAltura.Clear();
                txtBase.Clear();
                txtResultado.Clear();
            }
        }
    }
}
