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
    public partial class TelaPesquisarLivro : Form
    {
        public TelaPesquisarLivro()
        {
            InitializeComponent();
        }

        private void botao_pesquisarcodigo_Click(object sender, EventArgs e)
        {
            if (texto_pesquisarcodigo.Text == "")
            {
                MessageBox.Show("Digite um código");
            }
            else
            {
                Livros.CodigoLiv = Convert.ToInt16(texto_pesquisarcodigo.Text);

                ControllerLivros controllerLivros = new ControllerLivros();
                controllerLivros.VisualizarCodigoLivros();

                texto_nome.Text = Livros.NomeLiv;
                texto_categoria.Text = Livros.CategoriaLiv;
                texto_autor.Text = Livros.AutorLiv;
                texto_valor.Text = Livros.ValorLiv.ToString();
            }
            
        }

        private void botao_pesquisarnome_Click(object sender, EventArgs e)
        {
            if(texto_pesquisarnome.Text == "")
            {
                MessageBox.Show("Digite um Nome");
            }
            else
            {
                Livros.NomeLiv = texto_pesquisarnome.Text;
                dataGridView1.DataSource = ControllerLivros.VisualizarLivroNome();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;


                dataGridView1.Columns[5].HeaderCell.Value = "Código";
                dataGridView1.Columns[6].HeaderCell.Value = "Nome";
                dataGridView1.Columns[7].HeaderCell.Value = "Categoria";
                dataGridView1.Columns[8].HeaderCell.Value = "Autor";
                dataGridView1.Columns[9].HeaderCell.Value = "Valor";
                
            }
            
        }
    }
}
