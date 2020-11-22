using CrudAluno.Aluno.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudAluno.Professor;

namespace CrudAluno
{
    public partial class Form1 : Form
    {
        CadastroAluno Cad = new CadastroAluno();
        frmProfessor prof = new frmProfessor();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prof.Show();
        }
    }
}
