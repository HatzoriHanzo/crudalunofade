namespace CrudAlunoFade
{
    partial class CadastrarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarAluno));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_alunoNome = new System.Windows.Forms.TextBox();
            this.txt_alunoEndereco = new System.Windows.Forms.TextBox();
            this.txt_alunoCpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_alunoCadastrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.txt_pesquisaNome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pesquisacpf = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_alunoNota3 = new System.Windows.Forms.MaskedTextBox();
            this.txt_alunoNota2 = new System.Windows.Forms.MaskedTextBox();
            this.txt_alunoNota1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(37, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(22, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(16, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 1 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(138, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota 2 :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(258, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nota 3 :";
            // 
            // txt_alunoNome
            // 
            this.txt_alunoNome.Location = new System.Drawing.Point(82, 46);
            this.txt_alunoNome.Name = "txt_alunoNome";
            this.txt_alunoNome.Size = new System.Drawing.Size(216, 21);
            this.txt_alunoNome.TabIndex = 6;
            // 
            // txt_alunoEndereco
            // 
            this.txt_alunoEndereco.Location = new System.Drawing.Point(94, 137);
            this.txt_alunoEndereco.Name = "txt_alunoEndereco";
            this.txt_alunoEndereco.Size = new System.Drawing.Size(257, 21);
            this.txt_alunoEndereco.TabIndex = 8;
            // 
            // txt_alunoCpf
            // 
            this.txt_alunoCpf.Location = new System.Drawing.Point(79, 94);
            this.txt_alunoCpf.Mask = "000.000.000-00";
            this.txt_alunoCpf.Name = "txt_alunoCpf";
            this.txt_alunoCpf.Size = new System.Drawing.Size(96, 21);
            this.txt_alunoCpf.TabIndex = 12;
            // 
            // btn_alunoCadastrar
            // 
            this.btn_alunoCadastrar.Location = new System.Drawing.Point(28, 238);
            this.btn_alunoCadastrar.Name = "btn_alunoCadastrar";
            this.btn_alunoCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_alunoCadastrar.TabIndex = 13;
            this.btn_alunoCadastrar.Text = "Cadastrar";
            this.btn_alunoCadastrar.UseVisualStyleBackColor = true;
            this.btn_alunoCadastrar.Click += new System.EventHandler(this.btn_alunoCadastrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(475, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(304, 168);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.Color.Silver;
            this.btn_Consultar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar.Location = new System.Drawing.Point(92, 79);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(113, 44);
            this.btn_Consultar.TabIndex = 15;
            this.btn_Consultar.Text = "Exibir Alunos";
            this.btn_Consultar.UseVisualStyleBackColor = false;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_alunoConsultar);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(161, 238);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Atualizar.TabIndex = 16;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_alunoAtualizar);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.Red;
            this.btn_Deletar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Deletar.Location = new System.Drawing.Point(293, 238);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_Deletar.TabIndex = 17;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_alunoDeletar);
            // 
            // txt_pesquisaNome
            // 
            this.txt_pesquisaNome.Location = new System.Drawing.Point(171, 14);
            this.txt_pesquisaNome.Name = "txt_pesquisaNome";
            this.txt_pesquisaNome.Size = new System.Drawing.Size(128, 22);
            this.txt_pesquisaNome.TabIndex = 18;
            this.txt_pesquisaNome.TextChanged += new System.EventHandler(this.txt_pesquisaNome_TextChanged);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Silver;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(-2, 14);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(176, 16);
            this.lbl_nome.TabIndex = 19;
            this.lbl_nome.Text = "Filtrar pesquisa por Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Filtrar pesquisa por CPF:";
            // 
            // txt_pesquisacpf
            // 
            this.txt_pesquisacpf.Location = new System.Drawing.Point(172, 45);
            this.txt_pesquisacpf.Mask = "000.000.000-00";
            this.txt_pesquisacpf.Name = "txt_pesquisacpf";
            this.txt_pesquisacpf.Size = new System.Drawing.Size(106, 22);
            this.txt_pesquisacpf.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_nome);
            this.panel1.Controls.Add(this.txt_pesquisacpf);
            this.panel1.Controls.Add(this.btn_Consultar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_pesquisaNome);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(475, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 129);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_alunoNota3);
            this.panel2.Controls.Add(this.txt_alunoNota2);
            this.panel2.Controls.Add(this.txt_alunoNota1);
            this.panel2.Controls.Add(this.txt_alunoCpf);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_Deletar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_Atualizar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_alunoCadastrar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_alunoNome);
            this.panel2.Controls.Add(this.txt_alunoEndereco);
            this.panel2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 303);
            this.panel2.TabIndex = 25;
            // 
            // txt_alunoNota3
            // 
            this.txt_alunoNota3.Location = new System.Drawing.Point(309, 197);
            this.txt_alunoNota3.Mask = "00.00";
            this.txt_alunoNota3.Name = "txt_alunoNota3";
            this.txt_alunoNota3.Size = new System.Drawing.Size(39, 21);
            this.txt_alunoNota3.TabIndex = 27;
            this.txt_alunoNota3.ValidatingType = typeof(int);
            this.txt_alunoNota3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_alunoNota3_MaskInputRejected);
            // 
            // txt_alunoNota2
            // 
            this.txt_alunoNota2.Location = new System.Drawing.Point(189, 197);
            this.txt_alunoNota2.Mask = "00.00";
            this.txt_alunoNota2.Name = "txt_alunoNota2";
            this.txt_alunoNota2.Size = new System.Drawing.Size(36, 21);
            this.txt_alunoNota2.TabIndex = 26;
            this.txt_alunoNota2.ValidatingType = typeof(int);
            // 
            // txt_alunoNota1
            // 
            this.txt_alunoNota1.Location = new System.Drawing.Point(70, 198);
            this.txt_alunoNota1.Mask = "00.00";
            this.txt_alunoNota1.Name = "txt_alunoNota1";
            this.txt_alunoNota1.Size = new System.Drawing.Size(36, 21);
            this.txt_alunoNota1.TabIndex = 26;
            this.txt_alunoNota1.ValidatingType = typeof(int);
            // 
            // CadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CadastrarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarAluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_alunoNome;
        private System.Windows.Forms.TextBox txt_alunoEndereco;
        private System.Windows.Forms.MaskedTextBox txt_alunoCpf;
        private System.Windows.Forms.Button btn_alunoCadastrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.TextBox txt_pesquisaNome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_pesquisacpf;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox txt_alunoNota3;
        private System.Windows.Forms.MaskedTextBox txt_alunoNota2;
        private System.Windows.Forms.MaskedTextBox txt_alunoNota1;
    }
}