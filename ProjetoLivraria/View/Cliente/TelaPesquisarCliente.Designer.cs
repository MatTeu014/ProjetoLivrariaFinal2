namespace ProjetoLivraria.View.Cliente
{
    partial class TelaPesquisarCliente
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
            label6 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            texto_cpf = new TextBox();
            texto_email = new TextBox();
            texto_nome = new TextBox();
            label1 = new Label();
            texto_pesquisacodigo = new TextBox();
            botao_pesquisacodigo = new Button();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            texto_pesquisanome = new TextBox();
            botao_pesquisanome = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(229, 44);
            label6.Name = "label6";
            label6.Size = new Size(316, 47);
            label6.TabIndex = 3;
            label6.Text = "Pesquisar Clientes";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(73, 103);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(654, 304);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(texto_pesquisacodigo);
            tabPage1.Controls.Add(botao_pesquisacodigo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(646, 276);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Por Código";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(texto_cpf);
            groupBox1.Controls.Add(texto_email);
            groupBox1.Controls.Add(texto_nome);
            groupBox1.Location = new Point(59, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 206);
            groupBox1.TabIndex = 17;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(195, 21);
            label1.TabIndex = 24;
            label1.Text = "Digite o Código do Cliente:";
            // 
            // texto_pesquisacodigo
            // 
            texto_pesquisacodigo.Location = new Point(225, 24);
            texto_pesquisacodigo.Name = "texto_pesquisacodigo";
            texto_pesquisacodigo.Size = new Size(274, 23);
            texto_pesquisacodigo.TabIndex = 23;
            // 
            // botao_pesquisacodigo
            // 
            botao_pesquisacodigo.Location = new Point(533, 23);
            botao_pesquisacodigo.Name = "botao_pesquisacodigo";
            botao_pesquisacodigo.Size = new Size(90, 23);
            botao_pesquisacodigo.TabIndex = 22;
            botao_pesquisacodigo.Text = "Pesquisar";
            botao_pesquisacodigo.UseVisualStyleBackColor = true;
            botao_pesquisacodigo.Click += botao_pesquisacodigo_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(texto_pesquisanome);
            tabPage2.Controls.Add(botao_pesquisanome);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(646, 276);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Por Nome";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column2 });
            dataGridView1.Location = new Point(18, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(612, 181);
            dataGridView1.TabIndex = 25;
            // 
            // Column3
            // 
            Column3.HeaderText = "Código";
            Column3.Name = "Column3";
            // 
            // Column1
            // 
            Column1.HeaderText = "Nome";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "E-mail";
            Column2.Name = "Column2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(33, 29);
            label5.Name = "label5";
            label5.Size = new Size(188, 21);
            label5.TabIndex = 24;
            label5.Text = "Digite o Nome do Cliente:";
            // 
            // texto_pesquisanome
            // 
            texto_pesquisanome.ImeMode = ImeMode.Disable;
            texto_pesquisanome.Location = new Point(224, 28);
            texto_pesquisanome.Name = "texto_pesquisanome";
            texto_pesquisanome.Size = new Size(274, 23);
            texto_pesquisanome.TabIndex = 23;
            // 
            // botao_pesquisanome
            // 
            botao_pesquisanome.Location = new Point(526, 28);
            botao_pesquisanome.Name = "botao_pesquisanome";
            botao_pesquisanome.Size = new Size(90, 23);
            botao_pesquisanome.TabIndex = 22;
            botao_pesquisanome.Text = "Pesquisar";
            botao_pesquisanome.UseVisualStyleBackColor = true;
            botao_pesquisanome.Click += botao_pesquisanome_Click;
            // 
            // TelaPesquisarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(tabControl1);
            Name = "TelaPesquisarCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisar Clientes";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox texto_cpf;
        private TextBox texto_email;
        private TextBox texto_nome;
        private Label label1;
        private TextBox texto_pesquisacodigo;
        private Button botao_pesquisacodigo;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label5;
        private TextBox texto_pesquisanome;
        private Button botao_pesquisanome;
    }
}