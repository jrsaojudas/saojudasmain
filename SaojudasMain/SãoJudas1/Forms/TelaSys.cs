using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SãoJudas1.Forms
{
    public partial class TelaSys : Form
    {        
        public TelaSys()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todos os arquivos|*.*";            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(openFileDialog1.FileName);
            }
        }

        private void logísticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logistica logistica = new Logistica();
            logistica.Show();            
        }

        private void cadastroUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.Show();

        }

        private void procurarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaCliente frmPesquisaCliente = new frmPesquisaCliente();   
            frmPesquisaCliente.Show();
        }
    }
}
