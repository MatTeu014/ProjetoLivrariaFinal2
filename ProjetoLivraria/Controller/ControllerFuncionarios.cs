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
    internal class ControllerFuncionarios
    {
        public void CadastrarFuncionario()
        {
                SqlConnection cn = new SqlConnection(Conexao.Conectar());
                SqlCommand cmd = new SqlCommand("P_FunCadastrar", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    cmd.Parameters.AddWithValue("@NomeFun", Funcionarios.NomeFun);
                    cmd.Parameters.AddWithValue("@CpfFun", Funcionarios.CpfFun);
                    cmd.Parameters.AddWithValue("@EmailFun", Funcionarios.EmailFun);
                if(Funcionarios.CargoFun == "Atendente")
                {
                    Funcionarios.CargoFun = "1";
                }
                else if (Funcionarios.CargoFun == "Gerente")
                {
                    Funcionarios.CargoFun = "2";
                }
                else if (Funcionarios.CargoFun == "Estoquista")
                {
                    Funcionarios.CargoFun = "3";
                }
                    cmd.Parameters.AddWithValue("@CargoFun", Funcionarios.CargoFun);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionario cadastrado com Sucesso!");
                }
                catch (Exception)
                {
                    throw;
                }
        }        

        public void DeletarFuncionario()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_FunDeletar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoFun", Funcionarios.CodigoFun);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario Excluido");
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void AlterarporCodigoFun()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_FunAlterarCodigo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codigoFun", Funcionarios.CodigoFun);
                cmd.Parameters.AddWithValue("@nomeFun", Funcionarios.NomeFun);
                cmd.Parameters.AddWithValue("@cpfFun", Funcionarios.CpfFun);
                cmd.Parameters.AddWithValue("@emailFun", Funcionarios.EmailFun);
                cmd.Parameters.AddWithValue("@cargoFun", Funcionarios.CargoFun);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Alterados com Sucesso.");
            }
            catch
            {
                throw;
            }
        }

        public static BindingSource VisualizarNomeFuncionario()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_FunVisualizarPorNome", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@nomeFun", Funcionarios.NomeFun);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }

        public void VisualizarCodigoFuncionario()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_FunVisualizarPorCodigo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoFun", Funcionarios.CodigoFun);
                cn.Open();
                cmd.ExecuteNonQuery();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Funcionarios.CodigoFun = Convert.ToInt16(dr["codigoFun"]);
                    Funcionarios.NomeFun = (string)dr["nomeFun"];
                    Funcionarios.CpfFun = (string)dr["cpfFun"];
                    Funcionarios.EmailFun = (string)dr["emailFun"];
                    Funcionarios.CargoFun = (string)dr["cargoFun"];

                }
                else
                {
                    Funcionarios.CodigoFun = 0;
                    Funcionarios.NomeFun = "";
                    Funcionarios.CpfFun = "";
                    Funcionarios.EmailFun = "";
                    Funcionarios.CargoFun = "";
                    MessageBox.Show("Código não localizado.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
