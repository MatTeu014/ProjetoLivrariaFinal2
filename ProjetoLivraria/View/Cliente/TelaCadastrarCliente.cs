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
    public partial class TelaCadastrarCliente : Form
    {
        public TelaCadastrarCliente()
        {
            InitializeComponent();
        }

        private void botao_cadastrar_Click(object sender, EventArgs e)
        {
            Clientes.NomeCli = texto_nome.Text;
            Clientes.CpfCli = texto_cpf.Text;
            Clientes.EmailCli = texto_email.Text;

            CotrollerClientes cotrollerclientes = new CotrollerClientes();
            cotrollerclientes.CadastrarClientes();

            texto_nome.Text = "";
            texto_cpf.Text = "";
            texto_email.Text = "";
        }
    }
}
