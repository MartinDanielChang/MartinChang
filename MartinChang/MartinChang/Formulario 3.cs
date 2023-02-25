using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartinChang
{
    public partial class Formulario_3 : Form
    {
        public Formulario_3()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Contar();
        }

        private string Contar()
        {
            int numeros = 0;
            while (numeros <= 99)
            {
                numeros++;
                if (numeros % 3 == 0 & numeros % 5 == 0)
                    lbNumeros.Items.Add("Martin Chang");
                else if(numeros % 3 == 0)
                    lbNumeros.Items.Add("Martin");
                else if(numeros% 5 == 0)
                    lbNumeros.Items.Add("Chang");
                else
                lbNumeros.Items.Add(numeros);
            }
            return Convert.ToString(numeros);
        }
    }
}
