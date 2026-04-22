using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace Login
{
    public partial class F_Cadastro : Form
    {

		string ConexaBanco = "server=localhost;database=login;uid=root;pwd:;";

		public F_Cadastro()
        {
            InitializeComponent();
        }


    }
}
