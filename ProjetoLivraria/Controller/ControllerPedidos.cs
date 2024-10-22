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
    internal class ControllerPedidos
    {
        public void CadastrarPedidos()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_PedidosCadastrar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
     
                cmd.Parameters.AddWithValue("@dataPed", Pedidos.DataPed);
                cmd.Parameters.AddWithValue("@valorTotalPed", Pedidos.ValorTotalPed);
                cmd.Parameters.AddWithValue("@codigoCliFK", Pedidos.CodigoCliFK);
                cmd.Parameters.AddWithValue("@codigoFunFK", Pedidos.CodigoFunFK);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros inseridos com sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AlterarPedidos()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_PedidosAlterar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@dataPed", Pedidos.DataPed);
                cmd.Parameters.AddWithValue("@valorTotalPed", Pedidos.ValorTotalPed);
                cmd.Parameters.AddWithValue("@codigoCliFK", Pedidos.CodigoCliFK);
                cmd.Parameters.AddWithValue("@codigoFunFK", Pedidos.CodigoFunFK);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros alterados com sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void VisualizarCodigoPedido()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_PedidosVisualizarCodigo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoPed", Pedidos.CodigoPed);
                cmd.Parameters.AddWithValue("@dataPed", Pedidos.DataPed);
                cmd.Parameters.AddWithValue("@valorTotalPed", Pedidos.ValorTotalPed);
                cmd.Parameters.AddWithValue("@codigoCliFK", Pedidos.CodigoCliFK);
                cmd.Parameters.AddWithValue("@codigoFunFK", Pedidos.CodigoFunFK);
                cn.Open();
                cmd.ExecuteNonQuery();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Pedidos.CodigoPed = Convert.ToInt32(dr["codigoPed"]);
                    Pedidos.ValorTotalPed = Convert.ToInt32(dr["valorTotalPed"]);

                }
                else
                {
                    Pedidos.CodigoPed = 0;   
                    Pedidos.ValorTotalPed = 0;    
                    MessageBox.Show("Código não encontrado.");
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static BindingSource VisualizarPedidosNome()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_PedidoPesquisar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigoPed", Pedidos.CodigoPed);
            cmd.Parameters.AddWithValue("@dataPed", Pedidos.DataPed);
            cmd.Parameters.AddWithValue("@valorTotalPed", Pedidos.ValorTotalPed);
            cmd.Parameters.AddWithValue("@codigoCliFK", Pedidos.CodigoCliFK);
            cmd.Parameters.AddWithValue("@codigoFunFK", Pedidos.CodigoFunFK);

            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }

        public void CalcularValor()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_PedidoValor", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoPed", Pedidos.CodigoPed);
                cmd.Parameters.AddWithValue("@codigoPedFK", ItensPedidos.CodigoPedFK);
                cmd.Parameters.AddWithValue("@TotalItensPed", ItensPedidos.TotalItensPed);
                cmd.Parameters.AddWithValue("@ValorTotalPed", Pedidos.ValorTotalPed);
                cn.Open();
                cmd.ExecuteNonQuery();
                
                

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void PesquisarCodigoPedido()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_PedidoPesquisar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoPed", Pedidos.CodigoPed);
                /*cmd.Parameters.AddWithValue("@dataPed", Pedidos.DataPed);*/
                cmd.Parameters.AddWithValue("@valorTotalPed", Pedidos.ValorTotalPed);
                cmd.Parameters.AddWithValue("@codigoCliFK", Pedidos.CodigoCliFK);
                cmd.Parameters.AddWithValue("@codigoFunFK", Pedidos.CodigoFunFK);

                cn.Open();
                cmd.ExecuteNonQuery();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Pedidos.CodigoPed = Convert.ToInt32(dr["codigoPed"]);
                    /*Pedidos.DataPed = Convert.ToDateTime(dr["data"]);*/
                    Pedidos.ValorTotalPed = Convert.ToInt32(dr["valorTotalPed"]);
                    Pedidos.CodigoCliFK = Convert.ToInt32(dr["codigoCliFK"]);
                    Pedidos.CodigoFunFK = Convert.ToInt32(dr["codigoFunFK"]);

                }
                else
                {
                    Pedidos.CodigoPed = 0;
                    Pedidos.DataPed = DateTime.Now;
                    Pedidos.ValorTotalPed = 0;
                    Pedidos.CodigoCliFK = 0;
                    Pedidos.CodigoFunFK = 0;
                    MessageBox.Show("Código não encontrado.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
