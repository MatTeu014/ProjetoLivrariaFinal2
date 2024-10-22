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
    public partial class TelaCadastrarLivro : Form
    {
        public TelaCadastrarLivro()
        {
            InitializeComponent();
        }

        private void botao_cadastrar_Click(object sender, EventArgs e)
        {
            Livros.NomeLiv = texto_nome.Text;
            Livros.CategoriaLiv = combo_categoria.Text;
            Livros.AutorLiv = texto_autor.Text;
            Livros.ValorLiv = Convert.ToDecimal(texto_valor.Text);
            
            ControllerLivros controllerLivros = new ControllerLivros();
            controllerLivros.CadastrarLivros();
            
            texto_nome.Text = "";
            combo_categoria.Text = "";
            texto_autor.Text = "";
            texto_valor.Text = "";

        }
    }
}
