using SãoJudas1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SãoJudas1
{
    public partial class LoginTela : Form
    {
        public LoginTela()
        {
            InitializeComponent();
        }

        private void botaosair_Click(object sender, EventArgs e)
        {           
            System.Windows.Forms.Application.Exit();
        }

        private void botaologin_Click(object sender, EventArgs e)
        {
            if(usuariologin.Text =="jonathan" && senhalogin.Text == "1234")
            {
                MessageBox.Show("Bem vindo ao sistema");
                TelaSys telaSys = new TelaSys();
                telaSys.Show();
                if (LembrarUser.Checked == true)
                {
                    Properties.Settings.Default.usuario = usuariologin.Text;
                    Properties.Settings.Default.senha = senhalogin.Text;
                    Properties.Settings.Default.Save();
                }
                if (LembrarUser.Checked == false)
                {
                    Properties.Settings.Default.usuario = "";
                    Properties.Settings.Default.senha = "";
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                MessageBox.Show("Login ou Senha invalidos");
            }
        }
        private void LoginTela_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.usuario != String.Empty)
            {
                usuariologin.Text = Properties.Settings.Default.usuario;                

            }
        }
    }
}
