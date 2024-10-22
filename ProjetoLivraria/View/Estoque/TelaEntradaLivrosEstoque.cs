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

namespace ProjetoLivraria.View.Estoque
{
    public partial class TelaEntradaLivrosEstoque : Form
    {
        public TelaEntradaLivrosEstoque()
        {
            InitializeComponent();
        }

        private void botao_pesquisarcodigofun_Click(object sender, EventArgs e)
        {
            if (texto_codigofuncionario.Text == "")
            {
                MessageBox.Show("Digite o código do funcionário.");
            }
            else
            {
                Funcionarios.CodigoFun = Convert.ToInt16(texto_codigofuncionario.Text);

                ControllerFuncionarios controllerFuncionarios = new ControllerFuncionarios();
                controllerFuncionarios.VisualizarCodigoFuncionario();

                texto_funcionario.Text = Funcionarios.NomeFun;
                texto_codigofuncionario2.Text = Funcionarios.CodigoFun.ToString();
            }
        }

        private void botao_pesquisarcodigolivro_Click(object sender, EventArgs e)
        {
            if (texto_codigolivro.Text == "")
            {
                MessageBox.Show("Digite o código do livro.");
            }
            else
            {
                Livros.CodigoLiv = Convert.ToInt16(texto_codigolivro.Text);

                ControllerLivros controllerLivros = new ControllerLivros();
                controllerLivros.VisualizarCodigoLivros();

                texto_livro.Text = Livros.NomeLiv;
                combo_categoria.Text = Livros.CategoriaLiv;
                texto_autor.Text = Livros.AutorLiv;
                texto_valor.Text = Livros.ValorLiv.ToString();
                texto_codigolivro2.Text = Livros.CodigoLiv.ToString();
            }
            
        }

        private void botao_gravarentrada_Click(object sender, EventArgs e)
        {
            if (texto_quantidade.Text == "")
            {
                MessageBox.Show("Digite a quantidade de livros.");
            }
            else
            {
                Estoques.CodigoLivFK = Convert.ToInt16(texto_codigolivro2.Text);
                Estoques.CodigoFunFK = Convert.ToInt16(texto_codigofuncionario2.Text);
                Estoques.QtdSituacao = Convert.ToInt16(texto_quantidade.Text);
                Estoques.TipoSituacao = 1;
                Estoques.DataSituacao = data.Value;


                ControllerEstoque controllerEstoque = new ControllerEstoque();
                controllerEstoque.InserirEstoque();
            }

        }
    }
}
