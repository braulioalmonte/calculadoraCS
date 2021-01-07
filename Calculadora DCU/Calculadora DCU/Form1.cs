using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_DCU
{
    public partial class Form1 : Form
    {
        Double resultado = 0;
        String operacion = "";
        bool operacionEnProceso = false;
        Double NameUsedForResultValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (Resultado.Text != "0")
            {
                Resultado.Text = Resultado.Text + button.Text;
            }

            else
            {
                Resultado.Text = button.Text;
            }

            operacionEnProceso = false;

        }

        private void button_click_C(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            Resultado.Text = "0";
            Operacion.Text = "";
            resultado = 0;
            
        }

        private void button_click_CE(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string s = Resultado.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }

            else
            {
                s = "0";
            }

            Resultado.Text = s;
        }

        private void operacion_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultado != 0)
            {
                button18.PerformClick();
                resultado /= 2;
                operacion = button.Text;
                Operacion.Text = resultado + " " + operacion;
                Resultado.Clear();
                operacionEnProceso = true;
            }

            else
            {
                
                operacion = button.Text;
                resultado = Double.Parse(Resultado.Text);
                Operacion.Text = resultado + " " + operacion;
                Resultado.Clear();
                operacionEnProceso = true;
            }
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "+":
                    Resultado.Text = (resultado + Double.Parse(Resultado.Text)).ToString();
                    break;
                case "-":
                    Resultado.Text = (resultado - Double.Parse(Resultado.Text)).ToString();
                    break;
                case "*":
                    Resultado.Text = (resultado * Double.Parse(Resultado.Text)).ToString();
                    break;
                case "/":
                    Resultado.Text = (resultado / Double.Parse(Resultado.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultado = Double.Parse(Resultado.Text);
            Operacion.Text = "";
            NameUsedForResultValue = 0;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new Form2();
            newform.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new Form3();
            newform.Show();
        }
    }
}
