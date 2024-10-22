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
    public partial class TelaCadastrarFuncionario : Form
    {
        public TelaCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void botao_cadastrar_Click(object sender, EventArgs e)
        {
            Funcionarios.NomeFun = texto_nome.Text;
            Funcionarios.EmailFun = texto_email.Text;
            Funcionarios.CpfFun = texto_cpf.Text;
            Funcionarios.CargoFun = combo_cargo.Text;

            ControllerFuncionarios controllerFuncionarios = new ControllerFuncionarios();
            controllerFuncionarios.CadastrarFuncionario();

            texto_nome.Text = "";
            texto_email.Text = "";
            texto_cpf.Text = "";
            combo_cargo.Text = "";

        }

        private void TelaCadastrarFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
