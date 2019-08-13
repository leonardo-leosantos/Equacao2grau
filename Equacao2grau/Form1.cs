using System;
using System.Windows.Forms;

namespace Equacao2grau
{
    //Classe (propriedades e métodos)
    public partial class Form1 : Form
    {
        //Construtor
        public Form1()
        {
            InitializeComponent();
        }

        //Método: evento do botão
        private void Calcular_Click(object sender, EventArgs e)
        {
            //Criaçao e definicao dos valores das variaveis
            double delta = 0;
            double x1 = 0, x2 = 0;                       

            //Calculo do Delta
            //Converte Delta de string em double e seleciona a propriedade que está trabalhando(text) 
            delta = (Convert.ToDouble(txtBoxB.Text) * Convert.ToDouble(txtBoxB.Text)) - 4 * (Convert.ToDouble(txtBoxA.Text) * Convert.ToDouble(txtBoxC.Text));
            
            //Exibir valor de delta na tela, convertendo em string
            lblDelta.Text = "Delta = " + (Convert.ToString(delta));

            //Calculo das raízes (comando Math.Sqrt: calcula raíz quadrada)
            x1 = (-(Convert.ToDouble(txtBoxB.Text)) + Math.Sqrt(delta)) / (2 * Convert.ToDouble(txtBoxA.Text));
            x2 = (-(Convert.ToDouble(txtBoxB.Text)) - Math.Sqrt(delta)) / (2 * Convert.ToDouble(txtBoxA.Text));

            //Exibir valor das raízes na tela
            lblX1.Text = "x1= " + (Convert.ToString(x1));
            lblX2.Text = "x2= " + (Convert.ToString(x2));
        }
    }
}