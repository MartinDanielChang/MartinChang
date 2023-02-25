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
            for (int fila = 0; fila < 12; fila++, ++num )
                {
                
                
                double interesFinal = InteresMensual(num);
                lbMes.Items.Add(vectorMes[fila]  + ":  " + "    " + interesFinal);
                    
            }
        }

        //Funcion
        private double InteresMensual(int n1)
        {
            double interes = .015 * 200000 * n1 ;

            return interes;
        }

    }
}
