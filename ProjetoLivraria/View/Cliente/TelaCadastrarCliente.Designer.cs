namespace ProjetoLivraria.View.Cliente
{
    partial class TelaCadastrarCliente
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            botao_cadastrar = new Button();
            texto_cpf = new TextBox();
            texto_email = new TextBox();
            texto_nome = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(216, 281);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 18;
            label4.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(216, 218);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 17;
            label3.Text = "E-mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(217, 161);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 16;
            label2.Text = "Nome:";
            // 
            // botao_cadastrar
            // 
            botao_cadastrar.Location = new Point(637, 373);
            botao_cadastrar.Name = "botao_cadastrar";
            botao_cadastrar.Size = new Size(102, 42);
            botao_cadastrar.TabIndex = 15;
            botao_cadastrar.Text = "Cadastrar";
            botao_cadastrar.UseVisualStyleBackColor = true;
            botao_cadastrar.Click += botao_cadastrar_Click;
            // 
            // texto_cpf
            // 
            texto_cpf.Location = new Point(324, 283);
            texto_cpf.Name = "texto_cpf";
            texto_cpf.Size = new Size(187, 23);
            texto_cpf.TabIndex = 14;
            // 
            // texto_email
            // 
            texto_email.Location = new Point(324, 220);
            texto_email.Name = "texto_email";
            texto_email.Size = new Size(187, 23);
            texto_email.TabIndex = 13;
            // 
            // texto_nome
            // 
            texto_nome.Location = new Point(324, 163);
            texto_nome.Name = "texto_nome";
            texto_nome.Size = new Size(187, 23);
            texto_nome.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 61);
            label1.Name = "label1";
            label1.Size = new Size(318, 47);
            label1.TabIndex = 11;
            label1.Text = "Cadastrar Clientes";
            // 
            // TelaCadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(botao_cadastrar);
            Controls.Add(texto_cpf);
            Controls.Add(texto_email);
            Controls.Add(texto_nome);
            Controls.Add(label1);
            Name = "TelaCadastrarCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Button botao_cadastrar;
        private TextBox texto_cpf;
        private TextBox texto_email;
        private TextBox texto_nome;
        private Label label1;
    }
}