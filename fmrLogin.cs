using static System.Net.Mime.MediaTypeNames;

namespace ArbolesBinarios
{
    public partial class fmrLogin : Form
    {
        private string pass="123";
        //Form1
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(this.pass==txtPass.Text)
            {
                fmrEscenario obj = new fmrEscenario("Bienvenid@ " + txtUser.Text);
                //this.Hide();
                obj.Show();
                txtUser.Text = "";
                txtPass.Text = "";
            }
            else
            {
                MessageBox.Show("ERROR... CONTRASEÑA INCORRECTA");
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkRemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("La contraseña por defecto es 123");
        }
    }
}