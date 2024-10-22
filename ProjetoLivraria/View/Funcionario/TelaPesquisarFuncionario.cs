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

namespace ProjetoLivraria.View.Funcionario
{
    public partial class TelaPesquisarFuncionario : Form
    {
        public TelaPesquisarFuncionario()
        {
            InitializeComponent();
        }

        private void botao_pesquisarcodigo_Click(object sender, EventArgs e)
        {
            if(texto_pesquisarcodigo.Text == "")
            {
                MessageBox.Show("Digite um código.");
            }
            else {
                Funcionarios.CodigoFun = Convert.ToInt16(texto_pesquisarcodigo.Text);

                ControllerFuncionarios controllerFuncionarios = new ControllerFuncionarios();
                controllerFuncionarios.VisualizarCodigoFuncionario();

                texto_nome.Text = Funcionarios.NomeFun;
                texto_email.Text = Funcionarios.EmailFun;
                texto_cpf.Text = Funcionarios.CpfFun;
                combo_cargo.Text = Funcionarios.CargoFun;
            }
        }

        private void botao_pesquisarnome_Click(object sender, EventArgs e)
        {
            if (texto_pesquisarnome.Text == "")
            {
                MessageBox.Show("Digite um Nome");
            }
            else
            {
                Funcionarios.NomeFun = texto_pesquisarnome.Text;
                dataGridView1.DataSource = ControllerFuncionarios.VisualizarNomeFuncionario();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;


                dataGridView1.Columns[4].HeaderCell.Value = "Código";
                dataGridView1.Columns[5].HeaderCell.Value = "Nome";
                dataGridView1.Columns[6].HeaderCell.Value = "E-mail";
                dataGridView1.Columns[7].HeaderCell.Value = "Cargo";
                dataGridView1.Columns[8].Visible = false;
            }
            
        }
    }
}
