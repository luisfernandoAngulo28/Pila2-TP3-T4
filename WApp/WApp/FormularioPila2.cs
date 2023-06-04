using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CApp;


namespace WApp
{
    public partial class FormularioPila2 : Form
    {
        public FormularioPila2()
        {
            InitializeComponent();
        }
        //instanciamos la clase
        clsPila2 p = new clsPila2();
        private void button1_Click(object sender, EventArgs e)
        {
            int s = 1;
            int x = int.Parse(textBox1.Text);
            p.Add(s, x);
            textBox3.Text = p.Mostrar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = 1;
            p.Delete(s);
            if (p.Vacia(s)==true)
            {
                MessageBox.Show("Pila S1 Vacia");
            }
            else
            {
                textBox3.Text = p.Mostrar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s = 2;
            int x = int.Parse(textBox2.Text);
            p.Add(s, x);
            textBox3.Text = p.Mostrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s = 2;
            p.Delete(s);
            if (p.Vacia(s) == true)
            {
                MessageBox.Show("Pila S1 Vacia");
            }
            else
            {
                textBox3.Text = p.Mostrar();
            }
        }
    }
}
