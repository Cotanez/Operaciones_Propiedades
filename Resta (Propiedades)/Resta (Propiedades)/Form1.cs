﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resta__Propiedades_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instancia de la clase clresta.
            clresta oresta = new clresta();
            // Se le asigna a la propiedad N1 el valor dado en la textBox1.
            oresta.N1 = int.Parse(textBox1.Text);
            // Se le asigna a la propiedad N2 el valor dado en la textBox2.
            oresta.N2 = int.Parse(textBox2.Text);
            // Se le asigna a la textBox3 el resultado que se le aplica al objeto oresta con el metodo Resta y se pasa a tipo string.
            textBox3.Text = oresta.Resta().ToString();
        }
    }
}
