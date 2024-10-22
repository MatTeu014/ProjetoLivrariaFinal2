namespace ProjetoLivraria.View.Book
{
    partial class TelaCadastrarLivro
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
            texto_valor = new TextBox();
            botao_cadastrar = new Button();
            texto_autor = new TextBox();
            texto_nome = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            combo_categoria = new ComboBox();
            SuspendLayout();
            // 
            // texto_valor
            // 
            texto_valor.Location = new Point(393, 409);
            texto_valor.Margin = new Padding(3, 4, 3, 4);
            texto_valor.Name = "texto_valor";
            texto_valor.Size = new Size(205, 27);
            texto_valor.TabIndex = 19;
            // 
            // botao_cadastrar
            // 
            botao_cadastrar.Location = new Point(679, 503);
            botao_cadastrar.Margin = new Padding(3, 4, 3, 4);
            botao_cadastrar.Name = "botao_cadastrar";
            botao_cadastrar.Size = new Size(129, 57);
            botao_cadastrar.TabIndex = 18;
            botao_cadastrar.Text = "Cadastrar";
            botao_cadastrar.UseVisualStyleBackColor = true;
            botao_cadastrar.Click += botao_cadastrar_Click;
            // 
            // texto_autor
            // 
            texto_autor.Location = new Point(393, 347);
            texto_autor.Margin = new Padding(3, 4, 3, 4);
            texto_autor.Name = "texto_autor";
            texto_autor.Size = new Size(205, 27);
            texto_autor.TabIndex = 17;
            // 
            // texto_nome
            // 
            texto_nome.Location = new Point(393, 205);
            texto_nome.Margin = new Padding(3, 4, 3, 4);
            texto_nome.Name = "texto_nome";
            texto_nome.Size = new Size(205, 27);
            texto_nome.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(239, 407);
            label5.Name = "label5";
            label5.Size = new Size(61, 28);
            label5.TabIndex = 14;
            label5.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(239, 344);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 13;
            label4.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(239, 272);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 12;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(239, 203);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 11;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.Location = new Point(239, 45);
            label1.Name = "label1";
            label1.Size = new Size(407, 60);
            label1.TabIndex = 10;
            label1.Text = "Cadastro de Livros";
            // 
            // combo_categoria
            // 
            combo_categoria.FormattingEnabled = true;
            combo_categoria.Items.AddRange(new object[] { "Programação", "Comédia", "Ação", "Ficção" });
            combo_categoria.Location = new Point(393, 276);
            combo_categoria.Name = "combo_categoria";
            combo_categoria.Size = new Size(205, 28);
            combo_categoria.TabIndex = 20;
            // 
            // TelaCadastrarLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(914, 600);
            Controls.Add(combo_categoria);
            Controls.Add(texto_valor);
            Controls.Add(botao_cadastrar);
            Controls.Add(texto_autor);
            Controls.Add(texto_nome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaCadastrarLivro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Livros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox texto_valor;
        private Button botao_cadastrar;
        private TextBox texto_autor;
        private TextBox texto_nome;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox combo_categoria;
    }
}