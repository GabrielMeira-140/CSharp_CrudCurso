using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudAluno.Classes.Entidade;
using MySql.Data.MySqlClient;

namespace CrudAluno.Forms
{
    public partial class Nota : Form
    {
        ConSQL consql = new ConSQL();
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader Dr;

        public Nota()
        {
            InitializeComponent();
            desabilitado();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultarID();
        }

        void ConsultarID()
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=Server=localhost;Database=Alunos;User Id=root;User Id=root;");

                consql.StringNota();

                comando = new MySqlCommand(consql.StringNota(), conexao);

                comando.Parameters.AddWithValue("@nome", txtNomeAluno.Text);

                conexao.Open();

                Dr = comando.ExecuteReader();

                while (Dr.Read())
                {
                    numUDAdobe.Value = Convert.ToInt32(Dr["notaAdobe"]);
                    numUDCisco.Value = Convert.ToInt32(Dr["notaCisco"]);
                    numUDLinux.Value = Convert.ToInt32(Dr["notaLinux"]);
                    numUDMicrosoft.Value = Convert.ToInt32(Dr["notaMicrosoft"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Clone();
                conexao = null;
                comando = null;
            }
        }

        void desabilitado()
        {
            numUDAdobe.Enabled = false;
            numUDCisco.Enabled = false;
            numUDLinux.Enabled = false;
            numUDMicrosoft.Enabled = false;
        }
    }
}
