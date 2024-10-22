using Microsoft.Win32;
using ProjetoLivraria.View.Cliente;
using ProjetoLivraria.View.Estoque;
using ProjetoLivraria.View.Funcionario;
using ProjetoLivraria.View.Book;
using ProjetoLivraria.View.Pedido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.View
{
    public partial class HomeAdm : Form
    {
        public HomeAdm()
        {
            InitializeComponent();
        }


       

        

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            TelaCadastrarCliente telacadastrarclientes = new TelaCadastrarCliente();
            telacadastrarclientes.Show();
        }

        private void gerenciarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TelaGerenciarCliente telagerenciarlientes = new TelaGerenciarCliente();
            telagerenciarlientes.Show();
        }

        private void pesquisrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisarCliente telapesquisarclientes = new TelaPesquisarCliente();
            telapesquisarclientes.Show();
        }

        private void gerenciarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            TelaCadastrarPedido telaCadastrarPedido = new TelaCadastrarPedido();
            telaCadastrarPedido.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisarPedido telapesquisarpedidos = new TelaPesquisarPedido();
            telapesquisarpedidos.Show();
        }

        private void cadastrarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            TelaCadastrarFuncionario telacadastrarfuncionarios = new TelaCadastrarFuncionario();
            telacadastrarfuncionarios.Show();
        }

        private void gerenciarToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            TelaGerenciarFuncionario telagerenciarfuncionarios = new TelaGerenciarFuncionario();
            telagerenciarfuncionarios.Show();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaPesquisarFuncionario telapesquisarfuncionarios = new TelaPesquisarFuncionario();
            telapesquisarfuncionarios.Show();
        }

        private void cadastrarToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            TelaCadastrarLivro telacadastrarlivros = new TelaCadastrarLivro();
            telacadastrarlivros.Show();
        }

        private void gerenciarToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            TelaGerenciarLivro telagerenciarlivros = new TelaGerenciarLivro();
            telagerenciarlivros.Show();
        }

        private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaPesquisarLivro telapesquisarlivros = new TelaPesquisarLivro();
            telapesquisarlivros.Show();
        }

        private void entradaDeLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaEntradaLivrosEstoque telaentradalivrosestoques = new TelaEntradaLivrosEstoque();
            telaentradalivrosestoques.Show();
        }


        private void pesquisarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TelaPesquisarEstoque telapesquisarestoques = new TelaPesquisarEstoque();
            telapesquisarestoques.Show();
        }
    }
}
