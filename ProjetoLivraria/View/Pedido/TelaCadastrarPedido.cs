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
    public partial class TelaCadastrarPedido : Form
    {
        public TelaCadastrarPedido()
        {
            InitializeComponent();
        }

        private void botao_pedido_Click(object sender, EventArgs e)
        {
            if (texto_codigocliente.Text == "" || texto_funcionario.Text == "")
            {
                MessageBox.Show("Digite o código do funcionário ou do cliente");
            }
            else
            {
                Pedidos.CodigoCliFK = Convert.ToInt16(texto_codigocliente.Text);
                Pedidos.CodigoFunFK = Convert.ToInt16(texto_funcionario.Text);
                Pedidos.DataPed = data.Value;

                ControllerPedidos controllerPedidos = new ControllerPedidos();
                controllerPedidos.CadastrarPedidos();


                ControllerPedidos controllerPedidos1 = new ControllerPedidos();
                controllerPedidos1.VisualizarCodigoPedido();
                texto_codigopedido.Text = Pedidos.CodigoPed.ToString();
            }
        }

        private void botao_registrar_Click(object sender, EventArgs e)
        {
            if (texto_codigolivro.Text == "")
            {
                MessageBox.Show("Digite o código do livro");
            }
            else
            {

                if (texto_codigocliente.Text == "" || texto_funcionario.Text == "")
                {
                    MessageBox.Show("Crie o pedido primeiro");
                }
                else
                {
                    int codigolivro = Convert.ToInt16(texto_codigolivro.Text);
                    int codigoFuncionario = Convert.ToInt16(texto_funcionario.Text);
                    int codigoCliente = Convert.ToInt16(texto_codigocliente.Text);

                    if (codigolivro > 0 && codigoFuncionario > 0 && codigoCliente > 0)
                    {
                        ItensPedidos.CodigoPedFK = Convert.ToInt16(texto_codigopedido.Text);
                        ItensPedidos.CodigoLivFK = Convert.ToInt16(texto_codigolivro.Text);
                        ItensPedidos.QtdItensPed = Convert.ToInt16(numerico_quantidade.Value);


                        ControllerItensPedidos controlleritenspedidos = new ControllerItensPedidos();
                        controlleritenspedidos.CadastrarItensPedidos();

                    }
                    else
                    {
                        MessageBox.Show("Falta digitar um dos códigos do Livro, do Cliente ou do Funcionário.");
                    }
                    dataGridView1.DataSource = ControllerItensPedidos.VisualizarItens();
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].Visible = false;

                    dataGridView1.Columns[4].Visible = true;
                    dataGridView1.Columns[5].Visible = true;
                    dataGridView1.Columns[6].Visible = true;
                    dataGridView1.Columns[7].Visible = true;
                }
            }
        }

        private void botao_limpar_Click(object sender, EventArgs e)
        {
            Pedidos.CodigoPed = Convert.ToInt16(texto_codigopedido.Text);
            ControllerItensPedidos controllerItensPedidos = new ControllerItensPedidos();
            controllerItensPedidos.DeletarItensPedidos();

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }



        private void botao_finalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra Finalizada.");
            texto_codigocliente.Text = "";
            texto_funcionario.Text = "";
            data.Value = DateTime.Now;
            texto_codigolivro.Text = "";
            numerico_quantidade.Value = 0;
            texto_total.Text = "";
            texto_codigopedido.Text = "";

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botao_calcular_Click(object sender, EventArgs e)
        {
            ControllerPedidos controllerPedidos = new ControllerPedidos();
            controllerPedidos.CalcularValor();
            controllerPedidos.VisualizarCodigoPedido();
            texto_total.Text = Pedidos.ValorTotalPed.ToString();
            Pedidos.CodigoPed = Convert.ToInt16(texto_codigopedido.Text);
        }
    }
}
