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
using CrudAluno.Forms;
using CrudAluno.Classes.Entidade;

namespace CrudAluno.Aluno.Cadastro
{
    public partial class CadastroAluno : Form
    {
        ConSQL consql = new ConSQL();
        Nota notaaluno = new Nota();
        MySqlConnection conexao;
        MySqlCommand comando;

        public CadastroAluno()
        {
            InitializeComponent();
            desabilitado();
            DesabilitadoConclusao();
            DesabilitadoTempo();
        }

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                               botoes                                                  //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region Botoes
        private void button1_Click(object sender, EventArgs e)
        {
            notaaluno.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            DadosAlunos();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passouotempo();
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
        //                                              Adicionar                                                //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region Adicionar
        void DadosAlunos()
        {
            data();

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=Alunos;User Id=root;");

                consql.StringAdicionar();

                comando = new MySqlCommand(consql.StringAdicionar(), conexao);

                parametros();

                comando.Parameters.AddWithValue("@DataInicio", dateTimePicker2.Value.AddDays(1));
                comando.Parameters.AddWithValue("@DataFim", dateTimePicker1.Value.AddDays(61));

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
        //                                                 Editar                                                //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region editar
        private void editar()
        {
            DesabilitadoTempo();
            Conclusao();
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=Alunos;User Id=root;");

                consql.StringEditar();

                comando = new MySqlCommand(consql.StringEditar(), conexao);

                parametros();

                comando.Parameters.AddWithValue("@DataInicio", dateTimePicker2.Value.AddDays(1));
                comando.Parameters.AddWithValue("@DataFim", dateTimePicker1.Value.AddDays(61));

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

        #region tempo
        void passouotempo()
        {
            DesabilitadoConclusao();
            ConclusaoTempo();
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=Alunos;User Id=root;");

                consql.StringTempo();

                comando = new MySqlCommand(consql.StringTempo(), conexao);

                parametros();

                comando.Parameters.AddWithValue("@DataInicio", dateTimePicker2.Value.AddDays(1));
                comando.Parameters.AddWithValue("@DataFim", dateTimePicker1.Value.AddDays(62));

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

        #region data
        void data()
        {
            MessageBox.Show("Seu curso começará amanha dia" + dateTimePicker2.Value.AddDays(1) + "e acabará dia" + dateTimePicker1.Value.AddDays(61));
        }
        #endregion

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                             Paramentros                                               //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region ParametrosSQL
        private void parametros()
        {
            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@email", txtEmail.Text);
            comando.Parameters.AddWithValue("@curso1", comboBoxCurso2.SelectedItem);
            comando.Parameters.AddWithValue("@curso2", comboBoxCurso1.SelectedItem);
            comando.Parameters.AddWithValue("@curso3", comboBoxCurso3.SelectedItem);
            comando.Parameters.AddWithValue("@curso4", comboBoxCurso4.SelectedItem);
            comando.Parameters.AddWithValue("@FinalCurso", txtConclusao.Text);
            comando.Parameters.AddWithValue("@TempoExtra", txtTempoExtra.Text);
        }

        #endregion

        #region LabelVisivel

        void desabilitado()
        {
            dateTimePicker2.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        void DesabilitadoConclusao()
        {
            label4.Visible = false;
            txtConclusao.Visible = false;
        }

        void Conclusao()
        {
            label4.Visible = true;
            txtConclusao.Visible = true;
        }

        void DesabilitadoTempo()
        {
            label6.Visible = false;
            txtTempoExtra.Visible = false;
        }

        void ConclusaoTempo()
        {
            label6.Visible = true;
            txtTempoExtra.Visible = true;
        }
        #endregion
    }
}
