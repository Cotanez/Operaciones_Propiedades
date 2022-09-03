using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace División__Propiedades_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instancia de la clase cldivisión.
            cldivisión odivision = new cldivisión();
            // Se le asigna a la propiedad N1 el valor dado en la textBox1.
            odivision.N1 = double.Parse(textBox1.Text);
            // Se le asigna a la propiedad N2 el valor dado en la textBox2.
            odivision.N2 = double.Parse(textBox2.Text);
            // Se le asigna a la textBox3 el resultado que se le aplica al objeto odivision con el metodo Dividir y se pasa a tipo string.
            textBox3.Text = odivision.Dividir().ToString();
        }
    }
}
