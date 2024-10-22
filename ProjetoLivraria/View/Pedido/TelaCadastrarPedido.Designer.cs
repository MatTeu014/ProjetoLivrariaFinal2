namespace ProjetoLivraria.View.Pedido
{
    partial class TelaCadastrarPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            texto_codigolivro = new TextBox();
            numerico_quantidade = new NumericUpDown();
            label3 = new Label();
            texto_total = new TextBox();
            botao_finalizar = new Button();
            botao_limpar = new Button();
            label4 = new Label();
            label5 = new Label();
            texto_codigocliente = new TextBox();
            texto_funcionario = new TextBox();
            label6 = new Label();
            botao_registrar = new Button();
            data = new DateTimePicker();
            botao_pedido = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            texto_codigopedido = new TextBox();
            botao_calcular = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numerico_quantidade).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(33, 268);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(842, 336);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Valor Unitário";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantidade";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Total";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 218);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 1;
            label1.Text = "Digite o Código do Livro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 218);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = "Quantidade:";
            // 
            // texto_codigolivro
            // 
            texto_codigolivro.Location = new Point(247, 215);
            texto_codigolivro.Margin = new Padding(3, 4, 3, 4);
            texto_codigolivro.Name = "texto_codigolivro";
            texto_codigolivro.Size = new Size(142, 27);
            texto_codigolivro.TabIndex = 3;
            // 
            // numerico_quantidade
            // 
            numerico_quantidade.Location = new Point(555, 216);
            numerico_quantidade.Margin = new Padding(3, 4, 3, 4);
            numerico_quantidade.Name = "numerico_quantidade";
            numerico_quantidade.Size = new Size(157, 27);
            numerico_quantidade.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(681, 616);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 6;
            label3.Text = "Valor Total:";
            // 
            // texto_total
            // 
            texto_total.Location = new Point(761, 612);
            texto_total.Margin = new Padding(3, 4, 3, 4);
            texto_total.Name = "texto_total";
            texto_total.Size = new Size(114, 27);
            texto_total.TabIndex = 7;
            // 
            // botao_finalizar
            // 
            botao_finalizar.Location = new Point(724, 651);
            botao_finalizar.Margin = new Padding(3, 4, 3, 4);
            botao_finalizar.Name = "botao_finalizar";
            botao_finalizar.Size = new Size(151, 48);
            botao_finalizar.TabIndex = 8;
            botao_finalizar.Text = "Finalizar Compra";
            botao_finalizar.UseVisualStyleBackColor = true;
            botao_finalizar.Click += botao_finalizar_Click;
            // 
            // botao_limpar
            // 
            botao_limpar.Location = new Point(33, 651);
            botao_limpar.Margin = new Padding(3, 4, 3, 4);
            botao_limpar.Name = "botao_limpar";
            botao_limpar.Size = new Size(106, 48);
            botao_limpar.TabIndex = 9;
            botao_limpar.Text = "Limpar";
            botao_limpar.UseVisualStyleBackColor = true;
            botao_limpar.Click += botao_limpar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 75);
            label4.Name = "label4";
            label4.Size = new Size(191, 20);
            label4.TabIndex = 10;
            label4.Text = "Digite o Código do Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(383, 71);
            label5.Name = "label5";
            label5.Size = new Size(222, 20);
            label5.TabIndex = 11;
            label5.Text = "Digite o Código do Funcionário:";
            // 
            // texto_codigocliente
            // 
            texto_codigocliente.Location = new Point(230, 72);
            texto_codigocliente.Margin = new Padding(3, 4, 3, 4);
            texto_codigocliente.Name = "texto_codigocliente";
            texto_codigocliente.Size = new Size(130, 27);
            texto_codigocliente.TabIndex = 12;
            // 
            // texto_funcionario
            // 
            texto_funcionario.Location = new Point(611, 68);
            texto_funcionario.Margin = new Padding(3, 4, 3, 4);
            texto_funcionario.Name = "texto_funcionario";
            texto_funcionario.Size = new Size(130, 27);
            texto_funcionario.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 123);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 15;
            label6.Text = "Data do Pedido:";
            // 
            // botao_registrar
            // 
            botao_registrar.Location = new Point(765, 204);
            botao_registrar.Name = "botao_registrar";
            botao_registrar.Size = new Size(114, 48);
            botao_registrar.TabIndex = 16;
            botao_registrar.Text = "Registrar Itens";
            botao_registrar.UseVisualStyleBackColor = true;
            botao_registrar.Click += botao_registrar_Click;
            // 
            // data
            // 
            data.Location = new Point(230, 118);
            data.Name = "data";
            data.Size = new Size(250, 27);
            data.TabIndex = 17;
            // 
            // botao_pedido
            // 
            botao_pedido.Location = new Point(761, 75);
            botao_pedido.Name = "botao_pedido";
            botao_pedido.Size = new Size(114, 48);
            botao_pedido.TabIndex = 18;
            botao_pedido.Text = "Criar Pedido";
            botao_pedido.UseVisualStyleBackColor = true;
            botao_pedido.Click += botao_pedido_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.Location = new Point(395, 9);
            label7.Name = "label7";
            label7.Size = new Size(102, 35);
            label7.TabIndex = 19;
            label7.Text = "Pedido:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.Location = new Point(395, 166);
            label8.Name = "label8";
            label8.Size = new Size(123, 35);
            label8.TabIndex = 20;
            label8.Text = "Carrinho:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(670, 21);
            label9.Name = "label9";
            label9.Size = new Size(133, 20);
            label9.TabIndex = 21;
            label9.Text = "Código do Pedido:";
            // 
            // texto_codigopedido
            // 
            texto_codigopedido.Location = new Point(809, 17);
            texto_codigopedido.Name = "texto_codigopedido";
            texto_codigopedido.ReadOnly = true;
            texto_codigopedido.Size = new Size(70, 27);
            texto_codigopedido.TabIndex = 22;
            // 
            // botao_calcular
            // 
            botao_calcular.Location = new Point(581, 612);
            botao_calcular.Name = "botao_calcular";
            botao_calcular.Size = new Size(94, 29);
            botao_calcular.TabIndex = 23;
            botao_calcular.Text = "Calcular";
            botao_calcular.UseVisualStyleBackColor = true;
            botao_calcular.Click += botao_calcular_Click;
            // 
            // TelaCadastrarPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(914, 711);
            Controls.Add(botao_calcular);
            Controls.Add(texto_codigopedido);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(botao_pedido);
            Controls.Add(data);
            Controls.Add(botao_registrar);
            Controls.Add(label6);
            Controls.Add(texto_funcionario);
            Controls.Add(texto_codigocliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(botao_limpar);
            Controls.Add(botao_finalizar);
            Controls.Add(texto_total);
            Controls.Add(label3);
            Controls.Add(numerico_quantidade);
            Controls.Add(texto_codigolivro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaCadastrarPedido";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Pedidos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numerico_quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox texto_codigolivro;
        private NumericUpDown numerico_quantidade;
        private Label label3;
        private TextBox texto_total;
        private Button botao_finalizar;
        private Button botao_limpar;
        private Label label4;
        private Label label5;
        private TextBox texto_codigocliente;
        private TextBox texto_funcionario;
        private Label label6;
        private Button botao_registrar;
        private DateTimePicker data;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button botao_pedido;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox texto_codigopedido;
        private Button botao_calcular;
    }
}