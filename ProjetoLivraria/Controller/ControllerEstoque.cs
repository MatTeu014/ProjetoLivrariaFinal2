using Microsoft.IdentityModel.Tokens;
using ProjetoLivraria.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Controller
{
    internal class ControllerEstoque
    {
        public void InserirEstoque()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_EstoqueCadastrar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                
                cmd.Parameters.AddWithValue("@qtdEst", Estoques.QtdEst);
                cmd.Parameters.AddWithValue("@codigoLivFK", Estoques.CodigoLivFK);               
                cmd.Parameters.AddWithValue("@tipoSituacao", Estoques.TipoSituacao);
                cmd.Parameters.AddWithValue("@qtdSituacao", Estoques.QtdSituacao);
                cmd.Parameters.AddWithValue("@dataSituacao", Estoques.DataSituacao);
                cmd.Parameters.AddWithValue("@codigoFunFK", Estoques.CodigoFunFK);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Livro Inserido no Estoque com Sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeletarEstoque()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_EstoqueDeletar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoEst", Estoques.CodigoEst);
                cmd.Parameters.AddWithValue("@codigoLiv", Livros.CodigoLiv);
                cmd.Parameters.AddWithValue("@codigoLivFK", Estoques.CodigoLivFK);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Livro Deletado do Estoque com Sucesso !");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AlterarEstoque()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_EstoqueAlterar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoEst", Estoques.CodigoEst);
                cmd.Parameters.AddWithValue("@codigoLivFK", Estoques.CodigoLivFK);
                cmd.Parameters.AddWithValue("@qtdEst", Estoques.QtdEst);
                cmd.Parameters.AddWithValue("@tipoSituacao", Estoques.TipoSituacao);
                cmd.Parameters.AddWithValue("@qtdSituacao", Estoques.QtdSituacao);
                cmd.Parameters.AddWithValue("@dataSituacao", Estoques.DataSituacao);
                cmd.Parameters.AddWithValue("@codigoFunFK", Estoques.CodigoFunFK);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Livro Alterado do Estoque com Sucesso !");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void VisualizarCodigoEstoque()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_EstoqueVisualizarPorCodigo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoLivFK", Estoques.CodigoLivFK);
                cn.Open();
                cmd.ExecuteNonQuery();
                

                var sl = cmd.ExecuteReader();
                if (sl.Read())
                {
                    Estoques.CodigoEst = Convert.ToInt32(sl["codigoEst"]);
                    Estoques.CodigoLivFK = Convert.ToInt32(sl["codigoLivFK"]);                   
                    Estoques.TipoSituacao = Convert.ToInt32(sl["tipoSituacao"]);
                    Estoques.QtdEst = Convert.ToInt32(sl["qtdEst"]);
                    Estoques.DataSituacao = Convert.ToDateTime(sl["dataSituacao"]);
                    Estoques.CodigoFunFK = Convert.ToInt32(sl["codigoFunFK"]);
                }
                else
                {
                    Livros.NomeLiv = "";
                    Estoques.CodigoEst = 0;
                    Estoques.CodigoLivFK = 0;
                    Estoques.QtdEst = 0;
                    Estoques.TipoSituacao = 0;
                    Estoques.QtdSituacao = 0;
                    Estoques.DataSituacao = DateTime.Now;
                    Estoques.CodigoFunFK = 0;
                    MessageBox.Show("Código não encontrado.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void VisualizarDataEstoque()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_EstoqueVisualizarPorData", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@dataSituacao", Estoques.DataSituacao);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Livro Deletado do Estoque com Sucesso !");

                var sl = cmd.ExecuteReader();
                if (sl.Read())
                {
                    Estoques.CodigoEst = Convert.ToInt32(sl["codigoEst"]);
                    Estoques.CodigoLivFK = Convert.ToInt32(sl["codigoLivFK"]);
                    Estoques.QtdEst = Convert.ToInt32(sl["qtdEst"]);
                    Estoques.TipoSituacao = Convert.ToInt32(sl["tipoSituacao"]);
                    Estoques.QtdSituacao = Convert.ToInt32(sl["qtdSituacao"]);
                    Estoques.DataSituacao = Convert.ToDateTime(sl["dataSituacao"]);
                    Estoques.CodigoFunFK = Convert.ToInt32(sl["codigoFunFK"]);
                }
                else
                {
                    Estoques.CodigoEst = 0;
                    Estoques.CodigoLivFK = 0;
                    Estoques.QtdEst = 0;
                    Estoques.TipoSituacao = 0;
                    Estoques.QtdSituacao = 0;
                    Estoques.DataSituacao = DateTime.Now;
                    Estoques.CodigoFunFK = 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static BindingSource VisualizarNomeEstoque()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_EstoqueVisualizarPorLivro2", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@nomeLiv", Livros.NomeLiv);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
    }
}
