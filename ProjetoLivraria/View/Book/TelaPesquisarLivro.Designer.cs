namespace ProjetoLivraria.View.Book
{
    partial class TelaPesquisarLivro
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
            label7 = new Label();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            texto_valor = new TextBox();
            label4 = new Label();
            texto_autor = new TextBox();
            label5 = new Label();
            texto_categoria = new TextBox();
            botao_pesquisarnome = new Button();
            texto_pesquisarnome = new TextBox();
            tabPage2 = new TabPage();
            label6 = new Label();
            texto_nome = new TextBox();
            botao_pesquisarcodigo = new Button();
            texto_pesquisarcodigo = new TextBox();
            groupBox1 = new GroupBox();
            tabPage1 = new TabPage();
            label2 = new Label();
            tabControl1 = new TabControl();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(128, 20);
            label7.Name = "label7";
            label7.Size = new Size(175, 21);
            label7.TabIndex = 14;
            label7.Text = "Digite o Nome do Livro:";
            // 
            // Column4
            // 
            Column4.HeaderText = "Autor";
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoria";
            Column3.Name = "Column3";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(42, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(592, 191);
            dataGridView1.TabIndex = 0;
            // 
            // Column5
            // 
            Column5.HeaderText = "Valor";
            Column5.Name = "Column5";
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
            // botao_pesquisarnome
            // 
            botao_pesquisarnome.Location = new Point(544, 19);
            botao_pesquisarnome.Name = "botao_pesquisarnome";
            botao_pesquisarnome.Size = new Size(75, 23);
            botao_pesquisarnome.TabIndex = 16;
            botao_pesquisarnome.Text = "Pesquisar";
            botao_pesquisarnome.UseVisualStyleBackColor = true;
            botao_pesquisarnome.Click += botao_pesquisarnome_Click;
            // 
            // texto_pesquisarnome
            // 
            texto_pesquisarnome.Location = new Point(318, 19);
            texto_pesquisarnome.Name = "texto_pesquisarnome";
            texto_pesquisarnome.Size = new Size(195, 23);
            texto_pesquisarnome.TabIndex = 15;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(botao_pesquisarnome);
            tabPage2.Controls.Add(texto_pesquisarnome);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(679, 263);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Por Nome";
            tabPage2.UseVisualStyleBackColor = true;
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
            botao_pesquisarcodigo.Location = new Point(559, 21);
            botao_pesquisarcodigo.Name = "botao_pesquisarcodigo";
            botao_pesquisarcodigo.Size = new Size(75, 23);
            botao_pesquisarcodigo.TabIndex = 17;
            botao_pesquisarcodigo.Text = "Pesquisar";
            botao_pesquisarcodigo.UseVisualStyleBackColor = true;
            botao_pesquisarcodigo.Click += botao_pesquisarcodigo_Click;
            // 
            // texto_pesquisarcodigo
            // 
            texto_pesquisarcodigo.Location = new Point(325, 21);
            texto_pesquisarcodigo.Name = "texto_pesquisarcodigo";
            texto_pesquisarcodigo.Size = new Size(195, 23);
            texto_pesquisarcodigo.TabIndex = 13;
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
            groupBox1.Location = new Point(44, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 197);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Livro";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(botao_pesquisarcodigo);
            tabPage1.Controls.Add(texto_pesquisarcodigo);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(679, 263);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Por Código";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(116, 22);
            label2.Name = "label2";
            label2.Size = new Size(182, 21);
            label2.TabIndex = 12;
            label2.Text = "Digite o Código do Livro:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(57, 115);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(687, 291);
            tabControl1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.Location = new Point(251, 45);
            label1.Name = "label1";
            label1.Size = new Size(283, 47);
            label1.TabIndex = 2;
            label1.Text = "Pesquisar Livros";
            // 
            // TelaPesquisarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "TelaPesquisarLivro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisar Livros";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column5;
        private Label label3;
        private TextBox texto_valor;
        private Label label4;
        private TextBox texto_autor;
        private Label label5;
        private TextBox texto_categoria;
        private Button botao_pesquisarnome;
        private TextBox texto_pesquisarnome;
        private TabPage tabPage2;
        private Label label6;
        private TextBox texto_nome;
        private Button botao_pesquisarcodigo;
        private TextBox texto_pesquisarcodigo;
        private GroupBox groupBox1;
        private TabPage tabPage1;
        private Label label2;
        private TabControl tabControl1;
        private Label label1;
    }
}