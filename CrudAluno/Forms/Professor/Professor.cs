using System;
using System.Collections.Generic;
using CrudAluno.Professor;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudAluno.Aluno.Cadastro;
using MySql.Data.MySqlClient;
using CrudAluno.Classes.Entidade;

namespace CrudAluno.Professor
{
    public partial class frmProfessor : Form
    {
        ConSQL consql = new ConSQL();
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader Dr;
        string stringSQL;

        public frmProfessor()
        {
            InitializeComponent();
            dateTimePicker2.Enabled = false;
        }

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                               botoes                                                  //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region botoes
        private void btnNota_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultarID();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exibir();
        }
        #endregion

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                               Metodo                                                  //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                                 Editar                                                //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region Editar
        private void editar()
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=Server=localhost;Database=Alunos;User Id=root;User Id=root;");

                consql.StringProfessorEditar();

                comando = new MySqlCommand(consql.StringProfessorEditar(), conexao);

                parametros();

                conexao.Open();

                comando.ExecuteNonQuery();

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
        #endregion

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                                Exibir                                                 //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region Exibir
        private void exibir()
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=Server=localhost;Database=Alunos;User Id=root;User Id=root;");

                consql.StringProfessorExibir();

                MySqlCommand comando = new MySqlCommand(consql.StringProfessorExibir(), conexao);

                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(comando);

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                conexao.Open();
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
        #endregion

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                              Consulta                                                 //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region Consulta
        void ConsultarID()
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=Server=localhost;Database=Alunos;User Id=root;User Id=root;");

                consql.StringProfessorConsulta();

                comando = new MySqlCommand(consql.StringProfessorConsulta(), conexao);

                comando.Parameters.AddWithValue("@nome", txtNomeAluno.Text);

                conexao.Open();

                Dr = comando.ExecuteReader();

                while (Dr.Read())
                {
                    txtEmail.Text = (string)Dr["email"];

                    dateTimePicker2.Value = Convert.ToDateTime(Dr["DataInicio"]);
                    dateTimePicker1.Value = Convert.ToDateTime(Dr["DataFim"]);

                    comboBoxCurso2.Text = (Convert.ToString(Dr["curso1"]));
                    comboBoxCurso1.Text = (Convert.ToString(Dr["curso2"]));
                    comboBoxCurso3.Text = (Convert.ToString(Dr["curso3"]));
                    comboBoxCurso4.Text = (Convert.ToString(Dr["curso4"]));
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
        #endregion

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                             Paramentros                                               //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region Parametros
        private void parametros()
        {
            comando.Parameters.AddWithValue("@nome", txtNomeAluno.Text);
            comando.Parameters.AddWithValue("@email", txtEmail.Text);
            comando.Parameters.AddWithValue("@curso1", comboBoxCurso2.SelectedItem);
            comando.Parameters.AddWithValue("@curso2", comboBoxCurso1.SelectedItem);
            comando.Parameters.AddWithValue("@curso3", comboBoxCurso3.SelectedItem);
            comando.Parameters.AddWithValue("@curso4", comboBoxCurso4.SelectedItem);
            comando.Parameters.AddWithValue("@DataInicio", dateTimePicker2.Value.AddDays(1));
            comando.Parameters.AddWithValue("@DataFim", dateTimePicker1.Value);
            comando.Parameters.AddWithValue("@notaAdobe", numUDAdobe.Value);
            comando.Parameters.AddWithValue("@notaCisco", numUDCisco.Value);
            comando.Parameters.AddWithValue("@notaLinux", numUDLinux.Value);
            comando.Parameters.AddWithValue("@notaMicrosoft", numUDMicrosoft.Value);
        }
        #endregion
    }
}
