
namespace Estudio
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.mkCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // mkCPF
            // 
            this.mkCPF.Location = new System.Drawing.Point(95, 28);
            this.mkCPF.Mask = "999,999,999-99";
            this.mkCPF.Name = "mkCPF";
            this.mkCPF.Size = new System.Drawing.Size(100, 20);
            this.mkCPF.TabIndex = 1;
            this.mkCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkCPF_MaskInputRejected);
            this.mkCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mkCPF_KeyPress);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mkCPF);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Excluir Aluno";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mkCPF;
    }
}