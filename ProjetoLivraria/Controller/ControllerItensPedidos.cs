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
    internal class ControllerItensPedidos
    {
        public void CadastrarItensPedidos()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ItensPedidoCadastrar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                
                cmd.Parameters.AddWithValue("@codigoPedFK", ItensPedidos.CodigoPedFK);
                cmd.Parameters.AddWithValue("@valorLiv", Livros.ValorLiv);
                cmd.Parameters.AddWithValue("@codigoItensPed", ItensPedidos.CodigoItensPed);
                cmd.Parameters.AddWithValue("@codigoLivFK", ItensPedidos.CodigoLivFK);
                cmd.Parameters.AddWithValue("@qtdItensPed", ItensPedidos.QtdItensPed);
                cmd.Parameters.AddWithValue("@totalItensPed", ItensPedidos.TotalItensPed);
                
                
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Inseridos com Sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AlterarItensPedidos()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ItensPedidosAlterar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoItensPed", ItensPedidos.CodigoItensPed);
                cmd.Parameters.AddWithValue("@codigoLivFK", ItensPedidos.CodigoLivFK);
                cmd.Parameters.AddWithValue("@qtdItensPed", ItensPedidos.QtdItensPed);
                cmd.Parameters.AddWithValue("@totalItensPed", ItensPedidos.TotalItensPed);
                cmd.Parameters.AddWithValue("@codigoPedFK", ItensPedidos.CodigoPedFK);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Alterados com Sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeletarItensPedidos()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ItensPedidosDeletar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoItensPed", ItensPedidos.CodigoItensPed);
                cmd.Parameters.AddWithValue("@codigoLivFK", ItensPedidos.CodigoLivFK);
                cmd.Parameters.AddWithValue("@qtdItensPed", ItensPedidos.QtdItensPed);
                cmd.Parameters.AddWithValue("@totalItensPed", ItensPedidos.TotalItensPed);
                cmd.Parameters.AddWithValue("@codigoPedFK", ItensPedidos.CodigoPedFK);
                cmd.Parameters.AddWithValue("@codigoPed", Pedidos.CodigoPed);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Deletado com Sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static BindingSource VisualizarItens()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ItensPedidosLivrosVisualizar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            
            cmd.Parameters.AddWithValue("@codigoLivFK", ItensPedidos.CodigoLivFK);
            cmd.Parameters.AddWithValue("@qtdItensPed", ItensPedidos.QtdItensPed);
            cmd.Parameters.AddWithValue("@totalItensPed", ItensPedidos.TotalItensPed);
            cmd.Parameters.AddWithValue("@codigoLiv", Livros.CodigoLiv);
            cmd.Parameters.AddWithValue("@valorLiv", Livros.ValorLiv);
            cmd.Parameters.AddWithValue("@codigoPedFK", ItensPedidos.CodigoPedFK);

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
