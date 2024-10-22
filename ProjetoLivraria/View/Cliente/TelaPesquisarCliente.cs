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

namespace ProjetoLivraria.View.Cliente
{
    public partial class TelaPesquisarCliente : Form
    {
        public TelaPesquisarCliente()
        {
            InitializeComponent();
        }

        private void botao_pesquisacodigo_Click(object sender, EventArgs e)
        {
            if (texto_pesquisacodigo.Text == "") 
            {
                MessageBox.Show("Digite um código");
            }
            else
            {

                Clientes.CodigoCli = Convert.ToInt16(texto_pesquisacodigo.Text);

                CotrollerClientes cotrollerClientes = new CotrollerClientes();
                cotrollerClientes.VisualizarClienteCodigo();

                texto_nome.Text = Clientes.NomeCli;
                texto_email.Text = Clientes.EmailCli;
                texto_cpf.Text = Clientes.CpfCli;
            }
        }

        private void botao_pesquisanome_Click(object sender, EventArgs e)
        {
            
            if (texto_pesquisanome.Text == "")
            {
                MessageBox.Show("Digite um Nome");
            }
            else
            {

                Clientes.NomeCli = texto_pesquisanome.Text;
                dataGridView1.DataSource = CotrollerClientes.VisualizarNomeCliente();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
            

                dataGridView1.Columns[3].HeaderCell.Value = "Código";
                dataGridView1.Columns[4].HeaderCell.Value = "Nome";
                dataGridView1.Columns[5].HeaderCell.Value = "E-mail";
                dataGridView1.Columns[6].Visible = false;

            }
            
        }
    }
}
