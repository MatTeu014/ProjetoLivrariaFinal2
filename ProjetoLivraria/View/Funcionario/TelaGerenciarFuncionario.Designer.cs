namespace ProjetoLivraria.View.Funcionario
{
    partial class TelaGerenciarFuncionario
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
            botao_alterar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            texto_email = new TextBox();
            texto_nome = new TextBox();
            texto_cpf = new TextBox();
            groupBox1 = new GroupBox();
            combo_cargo = new ComboBox();
            botao_excluir = new Button();
            label1 = new Label();
            texto_pesquisarcodigo = new TextBox();
            botao_pesquisarcodigo = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // botao_alterar
            // 
            botao_alterar.Location = new Point(621, 380);
            botao_alterar.Name = "botao_alterar";
            botao_alterar.Size = new Size(98, 38);
            botao_alterar.TabIndex = 27;
            botao_alterar.Text = "Alterar";
            botao_alterar.UseVisualStyleBackColor = true;
            botao_alterar.Click += botao_alterar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(126, 27);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 11;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(126, 76);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 12;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(126, 120);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 13;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(127, 169);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 14;
            label5.Text = "Cargo:";
            // 
            // texto_email
            // 
            texto_email.Location = new Point(216, 122);
            texto_email.Name = "texto_email";
            texto_email.Size = new Size(203, 23);
            texto_email.TabIndex = 17;
            // 
            // texto_nome
            // 
            texto_nome.Location = new Point(216, 29);
            texto_nome.Name = "texto_nome";
            texto_nome.Size = new Size(203, 23);
            texto_nome.TabIndex = 15;
            // 
            // texto_cpf
            // 
            texto_cpf.Location = new Point(216, 78);
            texto_cpf.Name = "texto_cpf";
            texto_cpf.Size = new Size(203, 23);
            texto_cpf.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(combo_cargo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(texto_email);
            groupBox1.Controls.Add(texto_nome);
            groupBox1.Controls.Add(texto_cpf);
            groupBox1.Location = new Point(142, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 229);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Funcionário";
            // 
            // combo_cargo
            // 
            combo_cargo.FormattingEnabled = true;
            combo_cargo.Items.AddRange(new object[] { "Gerente", "Estoquista", "Atendente" });
            combo_cargo.Location = new Point(216, 171);
            combo_cargo.Name = "combo_cargo";
            combo_cargo.Size = new Size(203, 23);
            combo_cargo.TabIndex = 18;
            // 
            // botao_excluir
            // 
            botao_excluir.Location = new Point(82, 380);
            botao_excluir.Name = "botao_excluir";
            botao_excluir.Size = new Size(98, 38);
            botao_excluir.TabIndex = 28;
            botao_excluir.Text = "Excluir";
            botao_excluir.UseVisualStyleBackColor = true;
            botao_excluir.Click += botao_excluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 32);
            label1.Name = "label1";
            label1.Size = new Size(500, 47);
            label1.TabIndex = 26;
            label1.Text = "Gerenciador de  Funcionários";
            // 
            // texto_pesquisarcodigo
            // 
            texto_pesquisarcodigo.Location = new Point(347, 93);
            texto_pesquisarcodigo.Name = "texto_pesquisarcodigo";
            texto_pesquisarcodigo.Size = new Size(214, 23);
            texto_pesquisarcodigo.TabIndex = 32;
            // 
            // botao_pesquisarcodigo
            // 
            botao_pesquisarcodigo.Location = new Point(599, 92);
            botao_pesquisarcodigo.Name = "botao_pesquisarcodigo";
            botao_pesquisarcodigo.Size = new Size(75, 23);
            botao_pesquisarcodigo.TabIndex = 31;
            botao_pesquisarcodigo.Text = "Pesquisar";
            botao_pesquisarcodigo.UseVisualStyleBackColor = true;
            botao_pesquisarcodigo.Click += botao_pesquisarcodigo_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(112, 91);
            label6.Name = "label6";
            label6.Size = new Size(229, 21);
            label6.TabIndex = 30;
            label6.Text = "Digite o Código do Funcionário:";
            // 
            // TelaGerenciarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(botao_alterar);
            Controls.Add(groupBox1);
            Controls.Add(botao_excluir);
            Controls.Add(label1);
            Controls.Add(texto_pesquisarcodigo);
            Controls.Add(botao_pesquisarcodigo);
            Controls.Add(label6);
            Name = "TelaGerenciarFuncionario";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar Funcionarios";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao_alterar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox texto_email;
        private TextBox texto_nome;
        private TextBox texto_cpf;
        private GroupBox groupBox1;
        private ComboBox combo_cargo;
        private Button botao_excluir;
        private Label label1;
        private TextBox texto_pesquisarcodigo;
        private Button botao_pesquisarcodigo;
        private Label label6;
    }
}