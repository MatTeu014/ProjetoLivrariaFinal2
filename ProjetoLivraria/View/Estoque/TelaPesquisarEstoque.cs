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
    public partial class TelaPesquisarEstoque : Form
    {
        public TelaPesquisarEstoque()
        {
            InitializeComponent();
        }

        private void botao_pesquisarcodigo_Click(object sender, EventArgs e)
        {
            if (texto_pesquisarcodigo.Text == "")
            {
                MessageBox.Show("Digite o código do Livro");
            }
            else
            {

                Livros.CodigoLiv = Convert.ToInt16(texto_pesquisarcodigo.Text);

                ControllerLivros controllerLivros = new ControllerLivros();
                controllerLivros.VisualizarCodigoLivros();

                texto_nomelivro.Text = Livros.NomeLiv;

                Estoques.CodigoLivFK = Convert.ToInt16(texto_pesquisarcodigo.Text);

                ControllerEstoque controllerEstoque = new ControllerEstoque();
                controllerEstoque.VisualizarCodigoEstoque();

                texto_quantidade.Text = Estoques.QtdEst.ToString();
            }
        }

        private void botao_pesquisarnome_Click(object sender, EventArgs e)
        {
            if (texto_pesquisarnome.Text == "")
            {
                MessageBox.Show("Digite o nome do Livro");
            }
            else
            {
                Livros.NomeLiv = texto_pesquisarnome.Text;
                dataGridView1.DataSource = ControllerEstoque.VisualizarNomeEstoque();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
              

            }
        }
    }
}
