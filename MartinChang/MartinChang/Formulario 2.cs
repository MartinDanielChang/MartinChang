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
    public partial class Formulario_2 : Form
    {
        public Formulario_2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvFactura);

            fila.Cells[0].Value = txtNombreProducto.Text;
            fila.Cells[1].Value = txtCodigo.Text;
            fila.Cells[2].Value = txtCantidad.Text;
            fila.Cells[3].Value = txtPrecio.Text;
            fila.Cells[4].Value = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecio.Text);

            dgvFactura.Rows.Add(fila);

            txtNombreProducto.Text = txtCodigo.Text = txtCantidad.Text = txtCantidad.Text = txtPrecio.Text = "";
        }


        private async Task<double> DescuentoAsync (double n1)
        {
            

            double resultado = await Task.Run(() =>
            {
                return n1 * 0.15 ;

            });

            return resultado;
        }

        private double SumaAsync()
        {
            double costoTotal = 0;
            int contador = 0;

            contador = dgvFactura.RowCount;

            for (int i = 0; i < contador; i++)
            {
                costoTotal += float.Parse(dgvFactura.Rows[i].Cells[4].Value.ToString());
            }

            return costoTotal;


        }

        private async Task<double> PagoTotal(double n1, double n2)
        {


            double restaInteres = await Task.Run(() =>
            {
                return n1 - n2;

            });

            return restaInteres;
        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
             

            double calculodescuento = await DescuentoAsync(SumaAsync());
            double pagoDescuento = await PagoTotal(SumaAsync(), calculodescuento);

            MessageBox.Show("El descuento es de :" + calculodescuento + " y el total a pagar es:  " + pagoDescuento);
        }
    }
}
