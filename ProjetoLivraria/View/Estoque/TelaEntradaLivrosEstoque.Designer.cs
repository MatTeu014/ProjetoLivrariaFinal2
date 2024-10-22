namespace ProjetoLivraria.View.Estoque
{
    partial class TelaEntradaLivrosEstoque
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
            botao_gravarentrada = new Button();
            label13 = new Label();
            data = new DateTimePicker();
            texto_codigofuncionario2 = new TextBox();
            texto_quantidade = new TextBox();
            texto_codigolivro2 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            combo_categoria = new ComboBox();
            botao_pesquisarcodigolivro = new Button();
            texto_valor = new TextBox();
            texto_autor = new TextBox();
            texto_livro = new TextBox();
            texto_codigolivro = new TextBox();
            groupBox3 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            botao_pesquisarcodigofun = new Button();
            texto_funcionario = new TextBox();
            texto_codigofuncionario = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // botao_gravarentrada
            // 
            botao_gravarentrada.Location = new Point(224, 526);
            botao_gravarentrada.Name = "botao_gravarentrada";
            botao_gravarentrada.Size = new Size(384, 51);
            botao_gravarentrada.TabIndex = 11;
            botao_gravarentrada.Text = "Gravar Entrada";
            botao_gravarentrada.UseVisualStyleBackColor = true;
            botao_gravarentrada.Click += botao_gravarentrada_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(310, 77);
            label13.Name = "label13";
            label13.Size = new Size(34, 15);
            label13.TabIndex = 7;
            label13.Text = "Data:";
            // 
            // data
            // 
            data.Location = new Point(363, 71);
            data.Name = "data";
            data.Size = new Size(193, 23);
            data.TabIndex = 6;
            // 
            // texto_codigofuncionario2
            // 
            texto_codigofuncionario2.Location = new Point(456, 31);
            texto_codigofuncionario2.Name = "texto_codigofuncionario2";
            texto_codigofuncionario2.Size = new Size(100, 23);
            texto_codigofuncionario2.TabIndex = 5;
            // 
            // texto_quantidade
            // 
            texto_quantidade.Location = new Point(170, 74);
            texto_quantidade.Name = "texto_quantidade";
            texto_quantidade.Size = new Size(100, 23);
            texto_quantidade.TabIndex = 4;
            // 
            // texto_codigolivro2
            // 
            texto_codigolivro2.Location = new Point(170, 31);
            texto_codigolivro2.Name = "texto_codigolivro2";
            texto_codigolivro2.Size = new Size(100, 23);
            texto_codigolivro2.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(310, 34);
            label12.Name = "label12";
            label12.Size = new Size(115, 15);
            label12.TabIndex = 2;
            label12.Text = "Código Funcionário:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(58, 77);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 1;
            label11.Text = "Quantidade:";
            // 
            // combo_categoria
            // 
            combo_categoria.FormattingEnabled = true;
            combo_categoria.Items.AddRange(new object[] { "Ação", "Comédia", "Terror", "Tecnologia da Informação" });
            combo_categoria.Location = new Point(229, 145);
            combo_categoria.Name = "combo_categoria";
            combo_categoria.Size = new Size(137, 23);
            combo_categoria.TabIndex = 11;
            // 
            // botao_pesquisarcodigolivro
            // 
            botao_pesquisarcodigolivro.Location = new Point(418, 31);
            botao_pesquisarcodigolivro.Name = "botao_pesquisarcodigolivro";
            botao_pesquisarcodigolivro.Size = new Size(75, 23);
            botao_pesquisarcodigolivro.TabIndex = 6;
            botao_pesquisarcodigolivro.Text = "Pesquisar";
            botao_pesquisarcodigolivro.UseVisualStyleBackColor = true;
            botao_pesquisarcodigolivro.Click += botao_pesquisarcodigolivro_Click;
            // 
            // texto_valor
            // 
            texto_valor.Location = new Point(456, 145);
            texto_valor.Name = "texto_valor";
            texto_valor.Size = new Size(100, 23);
            texto_valor.TabIndex = 10;
            // 
            // texto_autor
            // 
            texto_autor.Location = new Point(229, 106);
            texto_autor.Name = "texto_autor";
            texto_autor.Size = new Size(137, 23);
            texto_autor.TabIndex = 8;
            // 
            // texto_livro
            // 
            texto_livro.Location = new Point(229, 69);
            texto_livro.Name = "texto_livro";
            texto_livro.Size = new Size(137, 23);
            texto_livro.TabIndex = 7;
            // 
            // texto_codigolivro
            // 
            texto_codigolivro.Location = new Point(229, 31);
            texto_codigolivro.Name = "texto_codigolivro";
            texto_codigolivro.Size = new Size(137, 23);
            texto_codigolivro.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(data);
            groupBox3.Controls.Add(texto_codigofuncionario2);
            groupBox3.Controls.Add(texto_quantidade);
            groupBox3.Controls.Add(texto_codigolivro2);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(102, 400);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(579, 120);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informações da Entrada";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 34);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 0;
            label10.Text = "Código Livro:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 72);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 5;
            label9.Text = "Livro:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 148);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 3;
            label7.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 109);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 2;
            label6.Text = "Autor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 61);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 34);
            label4.Name = "label4";
            label4.Size = new Size(139, 15);
            label4.TabIndex = 0;
            label4.Text = "Digite o Código do Livro:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(combo_categoria);
            groupBox2.Controls.Add(botao_pesquisarcodigolivro);
            groupBox2.Controls.Add(texto_valor);
            groupBox2.Controls.Add(texto_autor);
            groupBox2.Controls.Add(texto_livro);
            groupBox2.Controls.Add(texto_codigolivro);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(102, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(579, 183);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações do Livro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(403, 148);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 4;
            label8.Text = "Valor:";
            // 
            // botao_pesquisarcodigofun
            // 
            botao_pesquisarcodigofun.Location = new Point(456, 33);
            botao_pesquisarcodigofun.Name = "botao_pesquisarcodigofun";
            botao_pesquisarcodigofun.Size = new Size(75, 23);
            botao_pesquisarcodigofun.TabIndex = 5;
            botao_pesquisarcodigofun.Text = "Pesquisar";
            botao_pesquisarcodigofun.UseVisualStyleBackColor = true;
            botao_pesquisarcodigofun.Click += botao_pesquisarcodigofun_Click;
            // 
            // texto_funcionario
            // 
            texto_funcionario.Location = new Point(266, 73);
            texto_funcionario.Name = "texto_funcionario";
            texto_funcionario.Size = new Size(159, 23);
            texto_funcionario.TabIndex = 4;
            // 
            // texto_codigofuncionario
            // 
            texto_codigofuncionario.Location = new Point(266, 33);
            texto_codigofuncionario.Name = "texto_codigofuncionario";
            texto_codigofuncionario.Size = new Size(159, 23);
            texto_codigofuncionario.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(botao_pesquisarcodigofun);
            groupBox1.Controls.Add(texto_funcionario);
            groupBox1.Controls.Add(texto_codigofuncionario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(102, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 122);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Funcionário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 36);
            label2.Name = "label2";
            label2.Size = new Size(176, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite o Código do Funcionário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 76);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Funcionário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.Location = new Point(161, 12);
            label1.Name = "label1";
            label1.Size = new Size(499, 47);
            label1.TabIndex = 7;
            label1.Text = "Entrada de Livros no Estoque";
            // 
            // TelaEntradaLivrosEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 603);
            Controls.Add(botao_gravarentrada);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "TelaEntradaLivrosEstoque";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada de Livros no Estoque";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao_gravarentrada;
        private Label label13;
        private DateTimePicker data;
        private TextBox texto_codigofuncionario2;
        private TextBox texto_quantidade;
        private TextBox texto_codigolivro2;
        private Label label12;
        private Label label11;
        private ComboBox combo_categoria;
        private Button botao_pesquisarcodigolivro;
        private TextBox texto_valor;
        private TextBox texto_autor;
        private TextBox texto_livro;
        private TextBox texto_codigolivro;
        private GroupBox groupBox3;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private Label label8;
        private Button botao_pesquisarcodigofun;
        private TextBox texto_funcionario;
        private TextBox texto_codigofuncionario;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}