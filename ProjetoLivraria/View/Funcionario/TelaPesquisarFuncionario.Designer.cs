namespace ProjetoLivraria.View.Funcionario
{
    partial class TelaPesquisarFuncionario
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
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            combo_cargo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            texto_email = new TextBox();
            texto_pesquisarnome = new TextBox();
            botao_pesquisarnome = new Button();
            tabPage2 = new TabPage();
            texto_nome = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            texto_cpf = new TextBox();
            texto_pesquisarcodigo = new TextBox();
            botao_pesquisarcodigo = new Button();
            label6 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(64, 34);
            label7.Name = "label7";
            label7.Size = new Size(222, 21);
            label7.TabIndex = 33;
            label7.Text = "Digite o Nome do Funcionário:";
            // 
            // Column3
            // 
            Column3.HeaderText = "E-mail";
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(34, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(621, 212);
            dataGridView1.TabIndex = 0;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cargo";
            Column4.Name = "Column4";
            // 
            // combo_cargo
            // 
            combo_cargo.FormattingEnabled = true;
            combo_cargo.Items.AddRange(new object[] { "Gerente", "Estoquista", "Atendente" });
            combo_cargo.Location = new Point(216, 171);
            combo_cargo.Name = "combo_cargo";
            combo_cargo.Size = new Size(206, 23);
            combo_cargo.TabIndex = 18;
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
            // texto_pesquisarnome
            // 
            texto_pesquisarnome.Location = new Point(296, 33);
            texto_pesquisarnome.Name = "texto_pesquisarnome";
            texto_pesquisarnome.Size = new Size(214, 23);
            texto_pesquisarnome.TabIndex = 35;
            // 
            // botao_pesquisarnome
            // 
            botao_pesquisarnome.Location = new Point(548, 32);
            botao_pesquisarnome.Name = "botao_pesquisarnome";
            botao_pesquisarnome.Size = new Size(75, 23);
            botao_pesquisarnome.TabIndex = 34;
            botao_pesquisarnome.Text = "Pesquisar";
            botao_pesquisarnome.UseVisualStyleBackColor = true;
            botao_pesquisarnome.Click += botao_pesquisarnome_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(texto_pesquisarnome);
            tabPage2.Controls.Add(botao_pesquisarnome);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(684, 317);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Por Nome";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // texto_nome
            // 
            texto_nome.Location = new Point(216, 29);
            texto_nome.Name = "texto_nome";
            texto_nome.Size = new Size(203, 23);
            texto_nome.TabIndex = 15;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(54, 81);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(692, 345);
            tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(texto_pesquisarcodigo);
            tabPage1.Controls.Add(botao_pesquisarcodigo);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(684, 317);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Por Código";
            tabPage1.UseVisualStyleBackColor = true;
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
            groupBox1.Location = new Point(38, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(626, 229);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Funcionário";
            // 
            // texto_cpf
            // 
            texto_cpf.Location = new Point(216, 78);
            texto_cpf.Name = "texto_cpf";
            texto_cpf.Size = new Size(203, 23);
            texto_cpf.TabIndex = 16;
            // 
            // texto_pesquisarcodigo
            // 
            texto_pesquisarcodigo.Location = new Point(277, 31);
            texto_pesquisarcodigo.Name = "texto_pesquisarcodigo";
            texto_pesquisarcodigo.Size = new Size(214, 23);
            texto_pesquisarcodigo.TabIndex = 32;
            // 
            // botao_pesquisarcodigo
            // 
            botao_pesquisarcodigo.Location = new Point(529, 30);
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
            label6.Location = new Point(45, 32);
            label6.Name = "label6";
            label6.Size = new Size(229, 21);
            label6.TabIndex = 30;
            label6.Text = "Digite o Código do Funcionário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.Location = new Point(195, 25);
            label1.Name = "label1";
            label1.Size = new Size(394, 47);
            label1.TabIndex = 34;
            label1.Text = "Pesquisar Funcionários";
            // 
            // TelaPesquisarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "TelaPesquisarFuncionario";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisar Funcionarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox combo_cargo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox texto_email;
        private TextBox texto_pesquisarnome;
        private Button botao_pesquisarnome;
        private TabPage tabPage2;
        private TextBox texto_nome;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TextBox texto_cpf;
        private TextBox texto_pesquisarcodigo;
        private Button botao_pesquisarcodigo;
        private Label label6;
        private Label label1;
    }
}