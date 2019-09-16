using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CrudAlunoFade
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
           
            
        }
       

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarAluno cadastrar = new CadastrarAluno();
            this.Hide();
            cadastrar.ShowDialog();
            this.Close();
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarAluno cadastrar = new CadastrarAluno();
            this.Hide();
            cadastrar.ShowDialog();
            this.Close();
        }
    }
}
