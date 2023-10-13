
namespace Estudio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.consultarAtualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.modalidadeToolStripMenuItem,
            this.turmaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunoToolStripMenuItem,
            this.cadastrarLoginToolStripMenuItem,
            this.excluirAlunoToolStripMenuItem,
            this.atualizarAlunoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            this.cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            this.cadastrarAlunoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cadastrarAlunoToolStripMenuItem.Text = "Cadastrar Aluno";
            this.cadastrarAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunoToolStripMenuItem_Click);
            // 
            // cadastrarLoginToolStripMenuItem
            // 
            this.cadastrarLoginToolStripMenuItem.Name = "cadastrarLoginToolStripMenuItem";
            this.cadastrarLoginToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cadastrarLoginToolStripMenuItem.Text = "Cadastrar Login";
            this.cadastrarLoginToolStripMenuItem.Click += new System.EventHandler(this.cadastrarLoginToolStripMenuItem_Click);
            // 
            // excluirAlunoToolStripMenuItem
            // 
            this.excluirAlunoToolStripMenuItem.Name = "excluirAlunoToolStripMenuItem";
            this.excluirAlunoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.excluirAlunoToolStripMenuItem.Text = "Excluir Aluno";
            this.excluirAlunoToolStripMenuItem.Click += new System.EventHandler(this.excluirAlunoToolStripMenuItem_Click);
            // 
            // atualizarAlunoToolStripMenuItem
            // 
            this.atualizarAlunoToolStripMenuItem.Name = "atualizarAlunoToolStripMenuItem";
            this.atualizarAlunoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.atualizarAlunoToolStripMenuItem.Text = "Atualizar Aluno";
            this.atualizarAlunoToolStripMenuItem.Click += new System.EventHandler(this.atualizarAlunoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 6);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // modalidadeToolStripMenuItem
            // 
            this.modalidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.atualizarToolStripMenuItem});
            this.modalidadeToolStripMenuItem.Name = "modalidadeToolStripMenuItem";
            this.modalidadeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.modalidadeToolStripMenuItem.Text = "Modalidade";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.excluirToolStripMenuItem1,
            this.consultarAtualizarToolStripMenuItem});
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.turmaToolStripMenuItem.Text = "Turma";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // excluirToolStripMenuItem1
            // 
            this.excluirToolStripMenuItem1.Name = "excluirToolStripMenuItem1";
            this.excluirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.excluirToolStripMenuItem1.Text = "Excluir";
            this.excluirToolStripMenuItem1.Click += new System.EventHandler(this.excluirToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(331, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validação";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "202236";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "davi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // consultarAtualizarToolStripMenuItem
            // 
            this.consultarAtualizarToolStripMenuItem.Name = "consultarAtualizarToolStripMenuItem";
            this.consultarAtualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarAtualizarToolStripMenuItem.Text = "Consultar/Atualizar";
            this.consultarAtualizarToolStripMenuItem.Click += new System.EventHandler(this.consultarAtualizarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Estudio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarAtualizarToolStripMenuItem;
    }
}

