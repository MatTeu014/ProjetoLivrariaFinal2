namespace ProjetoLivraria.View.Book
{
    partial class TelaGerenciarLivro
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            texto_valor = new TextBox();
            label4 = new Label();
            texto_autor = new TextBox();
            label5 = new Label();
            texto_categoria = new TextBox();
            label6 = new Label();
            texto_nome = new TextBox();
            botao_pesquisarcodigo = new Button();
            botao_excluir = new Button();
            botao_alterar = new Button();
            texto_pesquisarcodigo = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(134, 90);
            label2.Name = "label2";
            label2.Size = new Size(182, 21);
            label2.TabIndex = 16;
            label2.Text = "Digite o Código do Livro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.Location = new Point(194, 20);
            label1.Name = "label1";
            label1.Size = new Size(379, 47);
            label1.TabIndex = 15;
            label1.Text = "Gerenciador de Livros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(157, 19);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // texto_valor
            // 
            texto_valor.Location = new Point(297, 159);
            texto_valor.Name = "texto_valor";
            texto_valor.Size = new Size(179, 23);
            texto_valor.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(157, 63);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 3;
            label4.Text = "Categoria:";
            // 
            // texto_autor
            // 
            texto_autor.Location = new Point(297, 115);
            texto_autor.Name = "texto_autor";
            texto_autor.Size = new Size(179, 23);
            texto_autor.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(157, 113);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 4;
            label5.Text = "Autor:";
            // 
            // texto_categoria
            // 
            texto_categoria.Location = new Point(297, 65);
            texto_categoria.Name = "texto_categoria";
            texto_categoria.Size = new Size(179, 23);
            texto_categoria.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(157, 157);
            label6.Name = "label6";
            label6.Size = new Size(49, 21);
            label6.TabIndex = 5;
            label6.Text = "Valor:";
            // 
            // texto_nome
            // 
            texto_nome.Location = new Point(297, 21);
            texto_nome.Name = "texto_nome";
            texto_nome.Size = new Size(179, 23);
            texto_nome.TabIndex = 6;
            // 
            // botao_pesquisarcodigo
            // 
            botao_pesquisarcodigo.Location = new Point(625, 92);
            botao_pesquisarcodigo.Name = "botao_pesquisarcodigo";
            botao_pesquisarcodigo.Size = new Size(75, 23);
            botao_pesquisarcodigo.TabIndex = 21;
            botao_pesquisarcodigo.Text = "Pesquisar";
            botao_pesquisarcodigo.UseVisualStyleBackColor = true;
            botao_pesquisarcodigo.Click += botao_pesquisarcodigo_Click;
            // 
            // botao_excluir
            // 
            botao_excluir.Location = new Point(73, 388);
            botao_excluir.Name = "botao_excluir";
            botao_excluir.Size = new Size(102, 42);
            botao_excluir.TabIndex = 20;
            botao_excluir.Text = "Excluir";
            botao_excluir.UseVisualStyleBackColor = true;
            botao_excluir.Click += botao_excluir_Click;
            // 
            // botao_alterar
            // 
            botao_alterar.Location = new Point(625, 388);
            botao_alterar.Name = "botao_alterar";
            botao_alterar.Size = new Size(102, 42);
            botao_alterar.TabIndex = 19;
            botao_alterar.Text = "Alterar";
            botao_alterar.UseVisualStyleBackColor = true;
            botao_alterar.Click += botao_alterar_Click;
            // 
            // texto_pesquisarcodigo
            // 
            texto_pesquisarcodigo.Location = new Point(354, 92);
            texto_pesquisarcodigo.Name = "texto_pesquisarcodigo";
            texto_pesquisarcodigo.Size = new Size(195, 23);
            texto_pesquisarcodigo.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(texto_valor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(texto_autor);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(texto_categoria);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(texto_nome);
            groupBox1.Location = new Point(73, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(654, 227);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Livro";
            // 
            // TelaGerenciarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botao_pesquisarcodigo);
            Controls.Add(botao_excluir);
            Controls.Add(botao_alterar);
            Controls.Add(texto_pesquisarcodigo);
            Controls.Add(groupBox1);
            Name = "TelaGerenciarLivro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar Livros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox texto_valor;
        private Label label4;
        private TextBox texto_autor;
        private Label label5;
        private TextBox texto_categoria;
        private Label label6;
        private TextBox texto_nome;
        private Button botao_pesquisarcodigo;
        private Button botao_excluir;
        private Button botao_alterar;
        private TextBox texto_pesquisarcodigo;
        private GroupBox groupBox1;
    }
}