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
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string[] vectorMes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto",
                "Septiembre", "Octubre", "Noviembre", "Diciembre"  };



            int num = 1;
            int capital = 200000;
            for (int fila = 0; fila < 12; fila++, ++num )
                {
                double interesFinal = InteresMensual(num, capital);
                lbMes.Items.Add(vectorMes[fila]  + ":  " + "    " + interesFinal);
                capital = capital + Convert.ToInt32(interesFinal);
            }
        }

        //Funcion
        private double InteresMensual(int n1, int n2)
        {
            
            double interes = .015 * n2 * n1 ;

            return interes;
        }

    }
}
