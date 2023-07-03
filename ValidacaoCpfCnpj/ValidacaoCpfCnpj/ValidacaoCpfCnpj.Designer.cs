namespace ValidacaoCpfCnpj
{
    partial class ValidacaoCpfCnpj
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
            this.txtvalidacao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbcpf = new System.Windows.Forms.RadioButton();
            this.rbcnpj = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtvalidacao
            // 
            this.txtvalidacao.Location = new System.Drawing.Point(130, 113);
            this.txtvalidacao.Name = "txtvalidacao";
            this.txtvalidacao.Size = new System.Drawing.Size(175, 20);
            this.txtvalidacao.TabIndex = 3;
            this.txtvalidacao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtvalidacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(121, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "o";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(224, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "c";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbcpf
            // 
            this.rbcpf.AutoSize = true;
            this.rbcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcpf.Location = new System.Drawing.Point(121, 22);
            this.rbcpf.Name = "rbcpf";
            this.rbcpf.Size = new System.Drawing.Size(65, 28);
            this.rbcpf.TabIndex = 6;
            this.rbcpf.TabStop = true;
            this.rbcpf.Text = "CPF";
            this.rbcpf.UseVisualStyleBackColor = true;
            // 
            // rbcnpj
            // 
            this.rbcnpj.AutoSize = true;
            this.rbcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcnpj.Location = new System.Drawing.Point(265, 22);
            this.rbcnpj.Name = "rbcnpj";
            this.rbcnpj.Size = new System.Drawing.Size(64, 28);
            this.rbcnpj.TabIndex = 7;
            this.rbcnpj.TabStop = true;
            this.rbcnpj.Text = "cnpj";
            this.rbcnpj.UseVisualStyleBackColor = true;
            // 
            // ValidacaoCpfCnpj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 284);
            this.Controls.Add(this.rbcnpj);
            this.Controls.Add(this.rbcpf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtvalidacao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValidacaoCpfCnpj";
            this.Text = "nome de app";
            this.Load += new System.EventHandler(this.ValidacaoCpfCnpj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtvalidacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbcpf;
        private System.Windows.Forms.RadioButton rbcnpj;
    }
}

