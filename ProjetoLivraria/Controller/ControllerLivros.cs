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
    internal class ControllerLivros
    {
        public void AlterarLivros()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_LivroAlterar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoLiv", Livros.CodigoLiv);
                cmd.Parameters.AddWithValue("@nomeLiv", Livros.NomeLiv);
                cmd.Parameters.AddWithValue("@categoriaLiv", Livros.CategoriaLiv);
                cmd.Parameters.AddWithValue("@autorLiv", Livros.AutorLiv);
                cmd.Parameters.AddWithValue("@valorLiv", Livros.ValorLiv);
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro Alterado com sucesso.");

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void VisualizarCodigoLivros()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_LivroVisualizarPorCodigo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoLiv", Livros.CodigoLiv);
                cn.Open();
                cmd.ExecuteNonQuery();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Livros.CodigoLiv = Convert.ToInt32(dr["codigoLiv"]);
                    Livros.NomeLiv = dr["nomeLiv"].ToString();
                    Livros.AutorLiv = dr["autorLiv"].ToString();
                    Livros.CategoriaLiv = dr["categoriaLiv"].ToString();
                    Livros.ValorLiv = (decimal)dr["valorLiv"];
                }
                else
                {
                    Livros.CodigoLiv = 0;
                    Livros.NomeLiv = "";
                    Livros.AutorLiv = "";
                    Livros.CategoriaLiv = "";
                    Livros.ValorLiv = 0;
                    MessageBox.Show("Código não encontrado.");
                }
            }
            catch 
            {
                throw;
            }
        }

        public void CadastrarLivros()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_LivroCadastrar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                
                cmd.Parameters.AddWithValue("@nomeLiv", Livros.NomeLiv);
                cmd.Parameters.AddWithValue("@categoriaLiv", Livros.CategoriaLiv);
                cmd.Parameters.AddWithValue("@autorLiv", Livros.AutorLiv);
                cmd.Parameters.AddWithValue("@valorLiv", Livros.ValorLiv);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Parabéns! Livro Registrado Com Sucesso!");
            }
            catch (Exception)
            {

                throw;

            }
        }

        public void DeletarLivros()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_LivroDeletarPorCodigo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoLiv", Livros.CodigoLiv);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Livro Excluido.");
            }
            catch (Exception)
            {
                throw;

            }
        }

        public static BindingSource VisualizarLivroNome()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_LivroVisualizarPorNome", cn);
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
    

    

