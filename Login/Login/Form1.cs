using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace Login
{
    public partial class Form1 : Form
    {
        string ConexaBanco = "server=localhost;database=login;uid=root;pwd:;";

        public Form1()
        {
            InitializeComponent();
        }




        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = string.Empty;
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.FromArgb(174, 174, 175);
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = string.Empty;
                txtSenha.ForeColor = Color.Black;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == string.Empty)
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.FromArgb(174, 174, 175);
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Remove o foco de qualquer controle
            ActiveControl = null;
        }
    }
}
