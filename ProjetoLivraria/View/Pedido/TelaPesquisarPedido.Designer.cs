namespace ProjetoLivraria.View.Pedido
{
    partial class TelaPesquisarPedido
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
            label1 = new Label();
            button1 = new Button();
            texto_codigo = new TextBox();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            texto_cliente = new TextBox();
            texto_funcionario = new TextBox();
            texto_total = new TextBox();
            data = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 131);
            label1.Name = "label1";
            label1.Size = new Size(191, 20);
            label1.TabIndex = 0;
            label1.Text = "Digite o Código do Pedido:";
            // 
            // button1
            // 
            button1.Location = new Point(639, 118);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 46);
            button1.TabIndex = 1;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // texto_codigo
            // 
            texto_codigo.Location = new Point(359, 127);
            texto_codigo.Margin = new Padding(3, 4, 3, 4);
            texto_codigo.Name = "texto_codigo";
            texto_codigo.Size = new Size(219, 27);
            texto_codigo.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label7.Location = new Point(251, 28);
            label7.Name = "label7";
            label7.Size = new Size(442, 60);
            label7.TabIndex = 4;
            label7.Text = "Pesquisa de Pedidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 269);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 5;
            label2.Text = "Código do Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 381);
            label3.Name = "label3";
            label3.Size = new Size(164, 20);
            label3.TabIndex = 6;
            label3.Text = "Código do Funcionário:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(504, 269);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 7;
            label4.Text = "Valor Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 379);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 8;
            label5.Text = "Data:";
            // 
            // texto_cliente
            // 
            texto_cliente.Location = new Point(238, 266);
            texto_cliente.Name = "texto_cliente";
            texto_cliente.Size = new Size(183, 27);
            texto_cliente.TabIndex = 10;
            // 
            // texto_funcionario
            // 
            texto_funcionario.Location = new Point(269, 378);
            texto_funcionario.Name = "texto_funcionario";
            texto_funcionario.Size = new Size(183, 27);
            texto_funcionario.TabIndex = 11;
            // 
            // texto_total
            // 
            texto_total.Location = new Point(593, 266);
            texto_total.Name = "texto_total";
            texto_total.Size = new Size(183, 27);
            texto_total.TabIndex = 12;
            // 
            // data
            // 
            data.Location = new Point(570, 374);
            data.Name = "data";
            data.Size = new Size(299, 27);
            data.TabIndex = 13;
            // 
            // TelaPesquisarPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(914, 600);
            Controls.Add(data);
            Controls.Add(texto_total);
            Controls.Add(texto_funcionario);
            Controls.Add(texto_cliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(texto_codigo);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaPesquisarPedido";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisar Pedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox texto_codigo;
        private Label label7;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox texto_cliente;
        private TextBox texto_funcionario;
        private TextBox texto_total;
        private DateTimePicker data;
    }
}