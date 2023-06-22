using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolesBinarios
{
    public partial class fmrEscenario : Form
    {
        private string mensaje;
        public fmrEscenario(string mensaje)
        {
            this.mensaje = mensaje;
            InitializeComponent();
        }

        private void fmrEscenario_Load(object sender, EventArgs e)
        {
            txtWelcome.Text = mensaje;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //fmrLogin obj= new fmrLogin();
            //this.Hide();
            this.Close();
            //obj.Show();
        }

        private void btnCase1_Click(object sender, EventArgs e)
        {
            fmrCase1 obj= new fmrCase1();
            //this.Hide();
            obj.Show();
        }

        private void btnCase2_Click(object sender, EventArgs e)
        {
            fmrCase2 obj = new fmrCase2();
            //this.Hide();
            obj.Show();
        }
    }
}
