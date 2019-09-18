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
    public partial class CadastrarAluno : Form
    {
        public CadastrarAluno()
        {
            InitializeComponent();



        }


        MySqlConnection databaseConnection = null;
        private string strCon = "datasource=127.0.0.1;port=3306;username=root;password=;database=fadealunocrud";
        private string strSql = string.Empty;
        private string strSql2 = string.Empty;
        DataTable dtb;


        private void label5_Click(object sender, EventArgs e)

        {

        }

        private void btn_alunoCadastrar_Click(object sender, EventArgs e)
        {
            if (txt_alunoNome.Text.Equals(""))
            {
                MessageBox.Show("Você não digitou um Nome para cadastro!");
            }
            else if (txt_alunoCpf.MaskCompleted == false)
            {
                MessageBox.Show("Você não digitou um CPF para cadastro!");
            }

            else if (txt_alunoEndereco.Text.Equals(""))
            {
                MessageBox.Show("Você não digitou um endereço para cadastro!");
            }
            else if (txt_alunoNota1.MaskCompleted == false || txt_alunoNota2.MaskCompleted == false || txt_alunoNota3.MaskCompleted == false)
            {
                MessageBox.Show("Insira notas para finalizar o cadastro!");
            }

            else if (Double.Parse(txt_alunoNota1.Text) > 10 || Double.Parse(txt_alunoNota2.Text) > 10 || Double.Parse(txt_alunoNota3.Text) > 10)
            {
                MessageBox.Show("Insira uma nota até 10 para cadastro!");
            }
            else
            {
                try
                {
                    strSql = "insert into Aluno(Nome,CPF,Endereco) values(@Nome,@CPF,@Endereco); insert into Notas(Notas1,Notas2,Notas3,CPF,Situacao,Media) values(@Nota1,@Nota2,@Nota3,@CPF,@Situacao,@Media)";


                    databaseConnection = new MySqlConnection(strCon);

                    MySqlCommand comando = new MySqlCommand(strSql, databaseConnection);
                    comando.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = txt_alunoNome.Text;
                    comando.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = txt_alunoCpf.Text;
                    comando.Parameters.Add("@Endereco", MySqlDbType.VarChar).Value = txt_alunoEndereco.Text;
                    comando.Parameters.Add("@Nota1", MySqlDbType.Float).Value = txt_alunoNota1.Text;
                    comando.Parameters.Add("@Nota2", MySqlDbType.Float).Value = txt_alunoNota2.Text;
                    comando.Parameters.Add("@Nota3", MySqlDbType.Float).Value = txt_alunoNota3.Text;

                    Double Notaa1 = Double.Parse(txt_alunoNota1.Text);
                    Double Notaa2 = Double.Parse(txt_alunoNota2.Text);
                    Double Notaa3 = Double.Parse(txt_alunoNota3.Text);

                    Double media = (Notaa1 + Notaa2 + Notaa3) / 3;
                    if (media >= 6)
                    {
                        comando.Parameters.Add("@Media", MySqlDbType.Double).Value = media;
                        comando.Parameters.Add("@Situacao", MySqlDbType.VarChar).Value = "Aprovado!";
                    }
                    else
                    {
                        comando.Parameters.Add("@Media", MySqlDbType.Double).Value = media;
                        comando.Parameters.Add("@Situacao", MySqlDbType.VarChar).Value = "Reprovado!";
                    }



                    databaseConnection.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Efetuado!");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    databaseConnection.Close();
                };

                txt_alunoNome.Clear();
                txt_alunoCpf.Clear();
                txt_alunoEndereco.Clear();
                txt_alunoNota1.Clear();
                txt_alunoNota2.Clear();
                txt_alunoNota3.Clear();
            }

        }

        private void btn_alunoAtualizar(object sender, EventArgs e)
        {
            if (txt_alunoNome.Text.Equals(""))
            {
                MessageBox.Show("Informe o nome do aluno , ou um novo nome para atualizar.");
            }
            else if (txt_alunoCpf.MaskCompleted == false)
            {
                MessageBox.Show("Você não digitou um CPF para Atualizar!");
            }

            else if (txt_alunoEndereco.Text.Equals(""))
            {
                MessageBox.Show("Você não digitou um endereço para Atualizar!");
            }
            else if (Double.Parse(txt_alunoNota1.Text) > 10 || Double.Parse(txt_alunoNota2.Text) > 10 || Double.Parse(txt_alunoNota3.Text) > 10)
            {
                MessageBox.Show("Insira uma nota até 10 para Atualizar!");
            }
            else
            {
                try
                {
                    String aprovado = "";
                    Double Notaa1 = Double.Parse(txt_alunoNota1.Text);
                    Double Notaa2 = Double.Parse(txt_alunoNota2.Text);
                    Double Notaa3 = Double.Parse(txt_alunoNota3.Text);

                    Double media = (Notaa1 + Notaa2 + Notaa3) / 3;
                    if (media >= 6)
                    {
                        aprovado = "Aprovado!";
                    }
                    else
                    {
                        aprovado = "Reprovado!";
                    }



                    strSql = "UPDATE aluno SET aluno.Nome = " + "'" + txt_alunoNome.Text + "'" + ", aluno.Endereco = " + "'" + txt_alunoEndereco.Text + "'" + " WHERE aluno.CPF = " + "'" + txt_alunoCpf.Text + "'" + "; UPDATE notas SET notas.Notas1 = " + Double.Parse(txt_alunoNota1.Text) + " , notas.Notas2 = " + Double.Parse(txt_alunoNota2.Text) + " , notas.Notas3 = " + Double.Parse(txt_alunoNota3.Text) + ", notas.Situacao = " + "'" + aprovado + "'" + " , notas.Media = " + media + "  WHERE notas.CPF = " + "'" + txt_alunoCpf.Text + "'" + ";";

                    databaseConnection = new MySqlConnection(strCon);

                    MySqlCommand comando = new MySqlCommand(strSql, databaseConnection);


                    databaseConnection.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dados Atualizados com Sucesso!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    databaseConnection.Close();
                };
            }
        }

        private void btn_alunoConsultar(object sender, EventArgs e)
        {
            try
            {
                dtb = new DataTable();
                strSql = "select aluno.nome as 'Nome :' , aluno.CPF as 'CPF :', notas.Situacao as 'Situacao :', notas.Media as 'Media :' from aluno join notas on aluno.CPF = notas.CPF where aluno.CPF is not null ";

                if (txt_pesquisacpf.MaskCompleted == false)
                {
                    strSql += " AND  Aluno.Nome LIKE '%" + txt_pesquisaNome.Text + "%';";
                }


                else if (txt_pesquisaNome.Text.Trim().Equals(""))
                {

                    strSql += " AND  aluno.CPF = " + "'" + txt_pesquisacpf.Text + "'" + ";";
                }

                else if (txt_pesquisaNome.Text.Trim().Equals("") == false && txt_pesquisacpf.MaskCompleted == true)
                {
                    strSql += "AND  Aluno.Nome LIKE '%" + txt_pesquisaNome.Text + "%' AND aluno.CPF = " + "'" + txt_pesquisacpf.Text + "'" + ";";
                }

                databaseConnection = new MySqlConnection(strCon);

                MySqlCommand comando = new MySqlCommand(strSql, databaseConnection);
                MySqlDataAdapter sqlDAP = new MySqlDataAdapter(strSql, databaseConnection);


                sqlDAP.Fill(dtb);
                databaseConnection.Open();
                comando.ExecuteNonQuery();
                dataGridView1.DataSource = dtb;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                databaseConnection.Close();
            };

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_alunoNota3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

      
        private void txt_pesquisaNome_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_alunoDeletar(object sender, EventArgs e)
        {
            if (txt_alunoCpf.MaskCompleted == false)
            {
                MessageBox.Show("Voce não digitou um CPF !.");
            }

            else
            {
                try
                {

                    strSql = "DELETE FROM aluno WHERE aluno.CPF =" + "'" + txt_alunoCpf.Text + "'" + " ;";

                    databaseConnection = new MySqlConnection(strCon);

                    MySqlCommand comando = new MySqlCommand(strSql, databaseConnection);


                    databaseConnection.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dados Deletados com Sucesso!");



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    databaseConnection.Close();
                };
            }
        }
    }
}
