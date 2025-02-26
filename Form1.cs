using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace función_IF
{
    public partial class Form1 : Form
    {
        private object txtEdad;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Obligar al usuario a que ingrese una edad válida
            if (int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("su edad es" + textEdad.Text + "  años");
            }
            else
            {
                MessageBox.Show("por favor, ingresa una edad válida.");
            }
        }
    }
}
