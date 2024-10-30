using System;
using System.Windows.Forms;
using UrbanFarming.Desktop;

namespace UrbanFarmingDesktop.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string senha = textBox2.Text;

            if (!string.IsNullOrWhiteSpace(usuario) && !string.IsNullOrWhiteSpace(senha))
            {
                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Por favor, preencha os campos de usuário e senha.");
            }
        }
    }
}
