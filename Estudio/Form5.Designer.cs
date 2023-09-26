
namespace Estudio
{
    partial class Form5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblAula = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtAulas = new System.Windows.Forms.TextBox();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.lblAula);
            this.groupBox1.Controls.Add(this.lblAlunos);
            this.groupBox1.Controls.Add(this.lblPreco);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtAulas);
            this.groupBox1.Controls.Add(this.txtAluno);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Location = new System.Drawing.Point(72, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidades";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(34, 246);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(445, 36);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Location = new System.Drawing.Point(31, 171);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(62, 13);
            this.lblAula.TabIndex = 8;
            this.lblAula.Text = "Qtde Aulas:";
            this.lblAula.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAlunos
            // 
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.Location = new System.Drawing.Point(31, 130);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(68, 13);
            this.lblAlunos.TabIndex = 7;
            this.lblAlunos.Text = "Qtde Alunos:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(31, 94);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 6;
            this.lblPreco.Text = "Preço:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(31, 50);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(365, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtAulas
            // 
            this.txtAulas.Location = new System.Drawing.Point(112, 168);
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Size = new System.Drawing.Size(367, 20);
            this.txtAulas.TabIndex = 3;
            // 
            // txtAluno
            // 
            this.txtAluno.Location = new System.Drawing.Point(112, 127);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(367, 20);
            this.txtAluno.TabIndex = 2;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(112, 87);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(367, 20);
            this.txtPreco.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(34, 214);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Excluída";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Atualizar";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtAulas;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}