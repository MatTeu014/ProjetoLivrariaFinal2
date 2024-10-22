namespace ProjetoLivraria.View.Cliente
{
    partial class TelaGerenciarCliente
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
            label5 = new Label();
            texto_codigo = new TextBox();
            botao_pesquisarcodigo = new Button();
            botao_excluir = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            texto_cpf = new TextBox();
            texto_email = new TextBox();
            texto_nome = new TextBox();
            botao_alterar = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(68, 92);
            label5.Name = "label5";
            label5.Size = new Size(195, 21);
            label5.TabIndex = 28;
            label5.Text = "Digite o Código do Cliente:";
            // 
            // texto_codigo
            // 
            texto_codigo.Location = new Point(269, 94);
            texto_codigo.Name = "texto_codigo";
            texto_codigo.Size = new Size(274, 23);
            texto_codigo.TabIndex = 27;
            // 
            // botao_pesquisarcodigo
            // 
            botao_pesquisarcodigo.Location = new Point(588, 94);
            botao_pesquisarcodigo.Name = "botao_pesquisarcodigo";
            botao_pesquisarcodigo.Size = new Size(90, 23);
            botao_pesquisarcodigo.TabIndex = 26;
            botao_pesquisarcodigo.Text = "Pesquisar";
            botao_pesquisarcodigo.UseVisualStyleBackColor = true;
            botao_pesquisarcodigo.Click += botao_pesquisarcodigo_Click;
            // 
            // botao_excluir
            // 
            botao_excluir.Location = new Point(80, 381);
            botao_excluir.Name = "botao_excluir";
            botao_excluir.Size = new Size(102, 42);
            botao_excluir.TabIndex = 25;
            botao_excluir.Text = "Excluir";
            botao_excluir.UseVisualStyleBackColor = true;
            botao_excluir.Click += botao_excluir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(texto_cpf);
            groupBox1.Controls.Add(texto_email);
            groupBox1.Controls.Add(texto_nome);
            groupBox1.Location = new Point(80, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 229);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(129, 161);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 17;
            label4.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(129, 98);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 16;
            label3.Text = "E-mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(130, 41);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 15;
            label2.Text = "Nome:";
            // 
            // texto_cpf
            // 
            texto_cpf.Location = new Point(242, 163);
            texto_cpf.Name = "texto_cpf";
            texto_cpf.Size = new Size(187, 23);
            texto_cpf.TabIndex = 14;
            // 
            // texto_email
            // 
            texto_email.Location = new Point(242, 100);
            texto_email.Name = "texto_email";
            texto_email.Size = new Size(187, 23);
            texto_email.TabIndex = 13;
            // 
            // texto_nome
            // 
            texto_nome.Location = new Point(242, 43);
            texto_nome.Name = "texto_nome";
            texto_nome.Size = new Size(187, 23);
            texto_nome.TabIndex = 12;
            // 
            // botao_alterar
            // 
            botao_alterar.Location = new Point(631, 381);
            botao_alterar.Name = "botao_alterar";
            botao_alterar.Size = new Size(102, 42);
            botao_alterar.TabIndex = 23;
            botao_alterar.Text = "Alterar";
            botao_alterar.UseVisualStyleBackColor = true;
            botao_alterar.Click += botao_alterar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 27);
            label1.Name = "label1";
            label1.Size = new Size(412, 47);
            label1.TabIndex = 22;
            label1.Text = "Gerenciador de Clientes";
            // 
            // TelaGerenciarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(texto_codigo);
            Controls.Add(botao_pesquisarcodigo);
            Controls.Add(botao_excluir);
            Controls.Add(groupBox1);
            Controls.Add(botao_alterar);
            Controls.Add(label1);
            Name = "TelaGerenciarCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar Clientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox texto_codigo;
        private Button botao_pesquisarcodigo;
        private Button botao_excluir;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox texto_cpf;
        private TextBox texto_email;
        private TextBox texto_nome;
        private Button botao_alterar;
        private Label label1;
    }
}