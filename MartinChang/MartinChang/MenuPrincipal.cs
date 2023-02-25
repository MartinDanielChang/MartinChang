﻿using System;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnFormulario1_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Formulario1();
            formulario1.Show();
        }
        
        private void btnFormulario2_Click(object sender, EventArgs e)
        {
            Form formulario2 = new Formulario_2();
            formulario2.Show();
        }

        private void btnFormulario3_Click(object sender, EventArgs e)
        {
            Form formulario3 = new Formulario_3();
            formulario3.Show();
        }
    }
}
