using ProjetoLivraria.Controller;
using ProjetoLivraria.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.View.Funcionario
{
    public partial class TelaGerenciarFuncionario : Form
    {
        public TelaGerenciarFuncionario()
        {
            InitializeComponent();
        }

        private void botao_alterar_Click(object sender, EventArgs e)
        {
            if (texto_pesquisarcodigo.Text == "")
            {
                MessageBox.Show("Digite o Código do Funcionário");
            }
            else
            {

                var resposta = MessageBox.Show("Deseja Alterar os Dados do Funcionário: " + texto_nome.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Funcionarios.NomeFun = texto_nome.Text;
                    Funcionarios.EmailFun = texto_email.Text;
                    Funcionarios.CpfFun = texto_cpf.Text;
                    Funcionarios.CargoFun = combo_cargo.Text;


                    ControllerFuncionarios controllerFuncionarios = new ControllerFuncionarios();
                    controllerFuncionarios.AlterarporCodigoFun();
                }
                else
                {
                    texto_nome.Text = "";
                    texto_email.Text = "";
                    texto_cpf.Text = "";

                }
            }
        }

        private void botao_excluir_Click(object sender, EventArgs e)
        {
            if (texto_pesquisarcodigo.Text == "")
            {
                MessageBox.Show("Digite o Código do Funcionário");
            }
            else
            {

                var resposta = MessageBox.Show("Deseja Excluir os Dados do Funcionário: " + texto_nome.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Funcionarios.NomeFun = texto_nome.Text;
                    Funcionarios.EmailFun = texto_email.Text;
                    Funcionarios.CpfFun = texto_cpf.Text;
                    Funcionarios.CargoFun = combo_cargo.Text;


                    ControllerFuncionarios controllerFuncionarios = new ControllerFuncionarios();
                    controllerFuncionarios.DeletarFuncionario();
                }
                else
                {
                    texto_nome.Text = "";
                    texto_email.Text = "";
                    texto_cpf.Text = "";

                }
            }
        }

        private void botao_pesquisarcodigo_Click(object sender, EventArgs e)
        {
            if (texto_pesquisarcodigo.Text == "")
            {
                MessageBox.Show("Digite um código");
            }
            else
            {
                Funcionarios.CodigoFun = Convert.ToInt16(texto_pesquisarcodigo.Text);

                ControllerFuncionarios controllerFuncionarios = new ControllerFuncionarios();
                controllerFuncionarios.VisualizarCodigoFuncionario();

                texto_nome.Text = Funcionarios.NomeFun;
                texto_email.Text = Funcionarios.EmailFun;
                texto_cpf.Text = Funcionarios.CpfFun;
                combo_cargo.Text = Funcionarios.CargoFun;
            }
        }
    }
}
