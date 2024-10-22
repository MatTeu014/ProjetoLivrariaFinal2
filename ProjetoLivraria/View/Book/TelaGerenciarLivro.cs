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

namespace ProjetoLivraria.View.Book
{
    public partial class TelaGerenciarLivro : Form
    {
        public TelaGerenciarLivro()
        {
            InitializeComponent();
        }

        private void botao_pesquisarcodigo_Click(object sender, EventArgs e)
        {

            Livros.CodigoLiv = Convert.ToInt16(texto_pesquisarcodigo.Text);

            ControllerLivros controllerLivros = new ControllerLivros();
            controllerLivros.VisualizarCodigoLivros();

            texto_nome.Text = Livros.NomeLiv;
            texto_categoria.Text = Livros.CategoriaLiv;
            texto_autor.Text = Livros.AutorLiv;
            texto_valor.Text = Livros.ValorLiv.ToString();

            
        }

        private void botao_alterar_Click(object sender, EventArgs e)
        {
            if (texto_pesquisarcodigo.Text == "")
            {
                MessageBox.Show("Digite o Código do Livro");
            }
            else
            {

                var resposta = MessageBox.Show("Deseja Alterar os Dados do Livro: " + texto_nome.Text + "? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Livros.NomeLiv = texto_nome.Text;
                    Livros.CategoriaLiv = texto_categoria.Text;
                    Livros.AutorLiv = texto_autor.Text;
                    Livros.ValorLiv = Convert.ToDecimal(texto_valor.Text);

                    ControllerLivros controllerLivros = new ControllerLivros();
                    controllerLivros.AlterarLivros();

                }
                else
                {
                    texto_nome.Text = "";
                    texto_categoria.Text = "";
                    texto_autor.Text = "";
                    texto_valor.Text = 0.ToString();

                }

            }
        }

        private void botao_excluir_Click(object sender, EventArgs e)
        {
            if (texto_pesquisarcodigo.Text == "")
            {
                MessageBox.Show("Digite o Código do Livro");
            }
            else
            {

                var resposta = MessageBox.Show("Deseja Excluir os Dados do Livro: " + texto_nome.Text + "? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Livros.NomeLiv = texto_nome.Text;
                    Livros.CategoriaLiv = texto_categoria.Text;
                    Livros.AutorLiv = texto_autor.Text;
                    Livros.ValorLiv = Convert.ToDecimal(texto_valor.Text);

                    ControllerLivros controllerLivros = new ControllerLivros();
                    controllerLivros.DeletarLivros();

                    Estoques.CodigoLivFK = Convert.ToInt16(texto_pesquisarcodigo.Text);

                    ControllerEstoque controllerEstoque = new ControllerEstoque();
                    controllerEstoque.DeletarEstoque();
                }
                else
                {
                    texto_nome.Text = "";
                    texto_categoria.Text = "";
                    texto_autor.Text = "";
                    texto_valor.Text = 0.ToString();

                }

            }
        }
    }
}
