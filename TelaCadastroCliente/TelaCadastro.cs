using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaCadastroCliente
{
    public partial class TelaCadastro: Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        SqlConnection SqlCon = null;
        private string StrCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TelaDeCadastro;Data Source=LAPTOP-PTQMNG2B\\MSSQLSERVER01";
        string StrSql = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            text_procurar.Enabled = true;
            masked_cnpj.Enabled = true;
            text_razao.Enabled = true;
            text_fantasia.Enabled = true;
            text_inscricao.Enabled = true;
            text_endereco.Enabled = true;
            text_bairro.Enabled = true;
            masked_cep.Enabled = true;
            text_cidade.Enabled = true;
            text_uf.Enabled = true;
            text_pais.Enabled = true;
            text_email.Enabled = true;
            masked_telefone.Enabled = true;
            masked_celular.Enabled = true;

            text_procurar.Clear();
            masked_cnpj.Clear();
            text_razao.Clear();
            text_fantasia.Clear();
            text_inscricao.Clear();
            text_endereco.Clear();
            text_bairro.Clear();
            masked_cep.Clear();
            text_cidade.Clear();
            text_uf.Clear();
            text_pais.Clear();
            text_email.Clear();
            masked_telefone.Clear();
            masked_celular.Clear();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            string StrSql = "insert into dbo.Clientes(CNPJ, RazaoSocial, NomeFantasia, InscricaoEstadual, Endereco, Bairro, CEP, Cidade, UF, Pais, Email, Telefone, Celular) values(@CNPJ, @RazaoSocial, @NomeFantasia, @InscricaoEstadual, @Endereco, @Bairro, @CEP, @Cidade, @UF, @Pais, @Email, @Telefone, @Celular)";
            SqlCon = new SqlConnection(StrCon);
            SqlCommand comando = new SqlCommand(StrSql, SqlCon);

            comando.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = masked_cnpj.Text;
            comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = text_razao.Text;
            comando.Parameters.Add("@NomeFantasia", SqlDbType.VarChar).Value = text_fantasia.Text;
            comando.Parameters.Add("@InscricaoEstadual", SqlDbType.VarChar).Value = text_inscricao.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = text_endereco.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = text_bairro.Text;
            comando.Parameters.Add("@CEP", SqlDbType.VarChar).Value = masked_cep.Text;
            comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = text_cidade.Text;
            comando.Parameters.Add("@UF", SqlDbType.VarChar).Value = text_uf.Text;
            comando.Parameters.Add("@Pais", SqlDbType.VarChar).Value = text_pais.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = text_email.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = masked_telefone.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = masked_celular.Text;

            try
            {
                SqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar " + ex.Message);
            }
            finally
            {
                if(SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            StrSql = "SELECT * FROM  Clientes WHERE RazaoSocial = @Pesquisar OR Email = @Pesquisar OR CNPJ = @Pesquisar";
            SqlCon = new SqlConnection(StrCon);
            SqlCommand comando = new SqlCommand(StrSql, SqlCon);
            comando.Parameters.Add("@Pesquisar", SqlDbType.VarChar).Value = text_procurar.Text;
            try
            {
                if (string.IsNullOrEmpty(text_procurar.Text))
                {
                    MessageBox.Show("Cadastro não encontrado");
                    return;
                }
                SqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Cadastro não encontrado");
                }
                else
                {
                    dr.Read();
                    masked_cnpj.Text = Convert.ToString(dr["CNPJ"]);
                    masked_cnpj.ReadOnly = true;
                    text_razao.Text = Convert.ToString(dr["RazaoSocial"]);
                    text_fantasia.Text = Convert.ToString(dr["NomeFantasia"]);
                    text_inscricao.Text = Convert.ToString(dr["InscricaoEstadual"]);
                    text_endereco.Text = Convert.ToString(dr["Endereco"]);
                    text_bairro.Text = Convert.ToString(dr["Bairro"]);
                    masked_cep.Text = Convert.ToString(dr["CEP"]);
                    text_cidade.Text = Convert.ToString(dr["Cidade"]);
                    text_uf.Text = Convert.ToString(dr["UF"]);
                    text_pais.Text = Convert.ToString(dr["Pais"]);
                    text_email.Text = Convert.ToString(dr["Email"]);
                    masked_telefone.Text = Convert.ToString(dr["Telefone"]);
                    masked_celular.Text = Convert.ToString(dr["Celular"]);
                }
                dr.Close();
            }
           catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            StrSql = "UPDATE Clientes SET RazaoSocial=@RazaoSocial, NomeFantasia=@NomeFantasia, InscricaoEstadual=@InscricaoEstadual, Endereco=@Endereco, Bairro=@Bairro, CEP=@CEP, Cidade=@Cidade, UF=@UF," +
                "Pais=@Pais, Email=@Email, Telefone=@Telefone, Celular=@Celular";
            SqlCon = new SqlConnection(StrCon);
            SqlCommand comando = new SqlCommand(StrSql, SqlCon);

            comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = text_razao.Text;
            comando.Parameters.Add("@NomeFantasia", SqlDbType.VarChar).Value = text_fantasia.Text;
            comando.Parameters.Add("@InscricaoEstadual", SqlDbType.VarChar).Value = text_inscricao.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = text_endereco.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = text_bairro.Text;
            comando.Parameters.Add("@CEP", SqlDbType.VarChar).Value = masked_cep.Text;
            comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = text_cidade.Text;
            comando.Parameters.Add("@UF", SqlDbType.VarChar).Value = text_uf.Text;
            comando.Parameters.Add("@Pais", SqlDbType.VarChar).Value = text_pais.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = text_email.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = masked_telefone.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = masked_celular.Text;

            try
            {
                SqlCon.Open();
                int rowsAffected = comando.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    MessageBox.Show("Cadastro atualizado");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao atualizar cadastro" + ex.Message);
            }
            finally
            {
                if(SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            StrSql = "DELETE FROM Clientes WHERE CNPJ=@CNPJ OR RazaoSocial=@RazaoSocial";
            SqlCon = new SqlConnection(StrCon);
            SqlCommand comando = new SqlCommand(StrSql, SqlCon);
            comando.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = masked_cnpj.Text;
            comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = text_razao.Text;

            try
            {
                SqlCon.Open();
                int rowsAffected = comando.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    MessageBox.Show("Cadastro excluido");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            finally
            {
                if(SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }
    }
}
