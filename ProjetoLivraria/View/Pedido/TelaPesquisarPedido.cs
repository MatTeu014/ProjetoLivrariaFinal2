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

namespace ProjetoLivraria.View.Pedido
{
    public partial class TelaPesquisarPedido : Form
    {
        public TelaPesquisarPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Pedidos.CodigoPed = Convert.ToInt16(texto_codigo.Text);
            texto_cliente.Text = Pedidos.CodigoCliFK.ToString();
            texto_funcionario.Text = Pedidos.CodigoFunFK.ToString();
            texto_total.Text = Pedidos.ValorTotalPed.ToString();

            ControllerPedidos controllerPedidos = new ControllerPedidos();
            controllerPedidos.PesquisarCodigoPedido();

            
        }
    }
}
