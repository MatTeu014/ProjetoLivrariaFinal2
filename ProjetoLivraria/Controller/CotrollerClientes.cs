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
    internal class CotrollerClientes
    {
        public void CadastrarClientes()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ClienteCadastrar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeCli", Clientes.NomeCli);
                cmd.Parameters.AddWithValue("@emailCli", Clientes.EmailCli);
                cmd.Parameters.AddWithValue("@cpfCli", Clientes.CpfCli);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Cadastrado");

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeletarCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ClienteDeletar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoCli", Clientes.CodigoCli);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Excluido");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AlterarCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ClienteAlterar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoCli", Clientes.CodigoCli);
                cmd.Parameters.AddWithValue("@nomeCli", Clientes.NomeCli);
                cmd.Parameters.AddWithValue("@emailCli", Clientes.EmailCli);
                cmd.Parameters.AddWithValue("@cpfCli", Clientes.CpfCli);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void VisualizarClienteCodigo()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ClienteVisualizarCodigo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoCli", Clientes.CodigoCli);
                cn.Open();
                cmd.ExecuteNonQuery();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Clientes.CodigoCli = Convert.ToInt16(dr["codigoCli"]);
                    Clientes.NomeCli = dr["nomeCli"].ToString();
                    Clientes.EmailCli = dr["emailCli"].ToString();
                    Clientes.CpfCli = dr["cpfCli"].ToString();

                }
                else
                {
                    Clientes.CodigoCli = 0;
                    Clientes.NomeCli = "";
                    Clientes.EmailCli = "";
                    Clientes.CpfCli = "";
                    MessageBox.Show("Código não encontrado.");
                }
            }
            catch
            {
                throw;
            }
        }

        public static BindingSource VisualizarNomeCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ClienteVisualizarNome", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nomeCli", Clientes.NomeCli);
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
