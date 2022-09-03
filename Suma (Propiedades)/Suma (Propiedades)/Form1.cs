using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma__Propiedades_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instancia de la clase clsuma.
            clsuma osuma = new clsuma();
            // Se le asigna a la propiedad N1 el valor dado en la textBox1.
            osuma.N1 = int.Parse(textBox1.Text);
            // Se le asigna a la propiedad N2 el valor dado en la textBox2.
            osuma.N2 = int.Parse(textBox2.Text);
            // Se le asigna a la textBox3 el resultado que se le aplica al objeto osuma con el metodo Suma y se pasa a tipo string.
            textBox3.Text = osuma.Suma().ToString();
        }
    }
}
