namespace ProjetoLivraria.View.Funcionario
{
    partial class TelaCadastrarFuncionario
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
            combo_cargo = new ComboBox();
            botao_cadastrar = new Button();
            texto_email = new TextBox();
            texto_cpf = new TextBox();
            texto_nome = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // combo_cargo
            // 
            combo_cargo.FormattingEnabled = true;
            combo_cargo.Items.AddRange(new object[] { "Atendente", "Gerente", "Estoquista" });
            combo_cargo.Location = new Point(296, 287);
            combo_cargo.Name = "combo_cargo";
            combo_cargo.Size = new Size(203, 23);
            combo_cargo.TabIndex = 20;
            // 
            // botao_cadastrar
            // 
            botao_cadastrar.Location = new Point(561, 374);
            botao_cadastrar.Name = "botao_cadastrar";
            botao_cadastrar.Size = new Size(98, 38);
            botao_cadastrar.TabIndex = 19;
            botao_cadastrar.Text = "Cadastrar";
            botao_cadastrar.UseVisualStyleBackColor = true;
            botao_cadastrar.Click += botao_cadastrar_Click;
            // 
            // texto_email
            // 
            texto_email.Location = new Point(296, 238);
            texto_email.Name = "texto_email";
            texto_email.Size = new Size(203, 23);
            texto_email.TabIndex = 18;
            // 
            // texto_cpf
            // 
            texto_cpf.Location = new Point(296, 194);
            texto_cpf.Name = "texto_cpf";
            texto_cpf.Size = new Size(203, 23);
            texto_cpf.TabIndex = 17;
            // 
            // texto_nome
            // 
            texto_nome.Location = new Point(296, 145);
            texto_nome.Name = "texto_nome";
            texto_nome.Size = new Size(203, 23);
            texto_nome.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(207, 285);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 15;
            label5.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(206, 236);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 14;
            label4.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(206, 192);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 13;
            label3.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(206, 143);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 12;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 39);
            label1.Name = "label1";
            label1.Size = new Size(396, 47);
            label1.TabIndex = 11;
            label1.Text = "Cadastrar Funcionários";
            // 
            // TelaCadastrarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(combo_cargo);
            Controls.Add(botao_cadastrar);
            Controls.Add(texto_email);
            Controls.Add(texto_cpf);
            Controls.Add(texto_nome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCadastrarFuncionario";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Funcionarios";
            Load += TelaCadastrarFuncionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combo_cargo;
        private Button botao_cadastrar;
        private TextBox texto_email;
        private TextBox texto_cpf;
        private TextBox texto_nome;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}