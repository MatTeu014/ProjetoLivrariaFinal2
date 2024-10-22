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
    public partial class TelaGerenciarCliente : Form
    {
        public TelaGerenciarCliente()
        {
            InitializeComponent();
        }

        private void botao_alterar_Click(object sender, EventArgs e)
        {
            if(texto_codigo.Text == "")
            {
                MessageBox.Show("Digite o Código do Cliente");
            }
            else
            {

                var resposta = MessageBox.Show("Deseja Alterar os Dados do Cliente: " + texto_nome.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)    
                {
                    Clientes.NomeCli = texto_nome.Text;
                    Clientes.EmailCli = texto_email.Text;
                    Clientes.CpfCli = (texto_cpf.Text);
                    

                    CotrollerClientes cotrollerClientes= new CotrollerClientes();
                    cotrollerClientes.AlterarCliente();
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
            if (texto_codigo.Text == "")
            {
                MessageBox.Show("Digite o Código do Cliente");
            }
            else
            {

                var resposta = MessageBox.Show("Deseja Excluir os Dados do Cliente: " + texto_nome.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Clientes.NomeCli = texto_nome.Text;
                    Clientes.EmailCli = texto_email.Text;
                    Clientes.CpfCli = (texto_cpf.Text);


                    CotrollerClientes cotrollerClientes = new CotrollerClientes();
                    cotrollerClientes.DeletarCliente();
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
            if (texto_codigo.Text == "")
            {
                MessageBox.Show("Digite um código");
            }
            else
            {
                Clientes.CodigoCli = Convert.ToInt16(texto_codigo.Text);

                CotrollerClientes cotrollerClientes = new CotrollerClientes();
                cotrollerClientes.VisualizarClienteCodigo();

                texto_nome.Text = Clientes.NomeCli;
                texto_email.Text = Clientes.EmailCli;
                texto_cpf.Text = Clientes.CpfCli;
            }
        }
    }
}
