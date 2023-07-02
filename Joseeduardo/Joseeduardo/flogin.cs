using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joseeduardo
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtcontraseña.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Jose" && txtcontraseña.Text == "lopez")
            {
                finicio finicio = new finicio();
                this.Hide();
                finicio.Show();



            }
            else
            {
                MessageBox.Show("DATOS INCORRECTOS");

            }
        }
    }
}
