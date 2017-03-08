using System;
using System.Windows.Forms;

namespace Taller
{
    public partial class Form1 : Form
    {
        private double resultado;
        private double b=0;
        private double a=0;
        private double c=0;
        private double d=0;
        private int operacion;
        private int tipoConversion;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero2Calculadora_MouseLeave(object sender, EventArgs e)
        {
            Calcular();
           
        }

        private void Operacion(ref double x, ref int operacion, ref double y, ref double z)
        {
         switch(operacion)
            {
                case 0:
                    z = x + y;
                    break;

                case 1:
                    z = x - y;
                    break;

                case 2:
                    z = x * y;
                    break;

                case 3:
                    z = x / y;
                    break;

            }
        }
        private void txtNumero1Calculadora_MouseLeave(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            if (txtNumero1Calculadora.Text == "")
            {
                txtNumero1Calculadora.Text = "0";
            }
            else
            {
                a = Convert.ToDouble(txtNumero1Calculadora.Text);
            }
            if (txtNumero2Calculadora.Text == "")
            {
                txtNumero2Calculadora.Text = "0";
            }
            else
            {
                b = Convert.ToDouble(txtNumero2Calculadora.Text);
            }

            resultado = 0;
            operacion = comboOperacionCalculadora.SelectedIndex;
            Operacion(ref a, ref operacion, ref b, ref resultado);
            labelResultadoCalculadora.Text = Convert.ToString(resultado);

        }

        private void comboOperacionCalculadora_DropDownClosed(object sender, EventArgs e)
        {
            Calcular();
        }

        private void txtNumero1Calculadora_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void txtNumero2Calculadora_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Convertir()
        {
            c = Convert.ToDouble(txtNumeroConversor.Text);

            switch(tipoConversion)
            {
                case 0:
                    
                    break;
            }
        }
    }
}
