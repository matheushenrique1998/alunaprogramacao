namespace GERADORPCF
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
            System.Windows.Forms.TextBox textgeradocpf;
            this.llblditecpf = new System.Windows.Forms.Label();
            this.textcpf = new System.Windows.Forms.TextBox();
            this.btnvalidarcpf = new System.Windows.Forms.Button();
            this.lblgeradorcpf = new System.Windows.Forms.Label();
            this.btngeradorcpf = new System.Windows.Forms.Button();
            textgeradocpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // llblditecpf
            // 
            this.llblditecpf.AutoSize = true;
            this.llblditecpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblditecpf.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.llblditecpf.Location = new System.Drawing.Point(155, 20);
            this.llblditecpf.Name = "llblditecpf";
            this.llblditecpf.Size = new System.Drawing.Size(115, 24);
            this.llblditecpf.TabIndex = 0;
            this.llblditecpf.Text = "Digite o cpf";
            // 
            // textcpf
            // 
            this.textcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcpf.Location = new System.Drawing.Point(87, 65);
            this.textcpf.Name = "textcpf";
            this.textcpf.Size = new System.Drawing.Size(277, 31);
            this.textcpf.TabIndex = 1;
            // 
            // btnvalidarcpf
            // 
            this.btnvalidarcpf.Location = new System.Drawing.Point(144, 102);
            this.btnvalidarcpf.Name = "btnvalidarcpf";
            this.btnvalidarcpf.Size = new System.Drawing.Size(143, 41);
            this.btnvalidarcpf.TabIndex = 2;
            this.btnvalidarcpf.Text = "Validar CPF";
            this.btnvalidarcpf.UseVisualStyleBackColor = true;
            this.btnvalidarcpf.Click += new System.EventHandler(this.btnvalidarcpf_Click);
            // 
            // lblgeradorcpf
            // 
            this.lblgeradorcpf.AutoSize = true;
            this.lblgeradorcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgeradorcpf.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblgeradorcpf.Location = new System.Drawing.Point(140, 158);
            this.lblgeradorcpf.Name = "lblgeradorcpf";
            this.lblgeradorcpf.Size = new System.Drawing.Size(162, 24);
            this.lblgeradorcpf.TabIndex = 3;
            this.lblgeradorcpf.Text = "Gerador de CPF";
            // 
            // btngeradorcpf
            // 
            this.btngeradorcpf.Location = new System.Drawing.Point(144, 237);
            this.btngeradorcpf.Name = "btngeradorcpf";
            this.btngeradorcpf.Size = new System.Drawing.Size(155, 41);
            this.btngeradorcpf.TabIndex = 5;
            this.btngeradorcpf.Text = "Gerador CPF";
            this.btngeradorcpf.UseVisualStyleBackColor = true;
            this.btngeradorcpf.Click += new System.EventHandler(this.button1_Click);
            // 
            // textgeradocpf
            // 
            textgeradocpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textgeradocpf.Location = new System.Drawing.Point(87, 200);
            textgeradocpf.Name = "textgeradocpf";
            textgeradocpf.Size = new System.Drawing.Size(277, 31);
            textgeradocpf.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 362);
            this.Controls.Add(textgeradocpf);
            this.Controls.Add(this.btngeradorcpf);
            this.Controls.Add(this.lblgeradorcpf);
            this.Controls.Add(this.btnvalidarcpf);
            this.Controls.Add(this.textcpf);
            this.Controls.Add(this.llblditecpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llblditecpf;
        private System.Windows.Forms.TextBox textcpf;
        private System.Windows.Forms.Button btnvalidarcpf;
        private System.Windows.Forms.Label lblgeradorcpf;
        private System.Windows.Forms.Button btngeradorcpf;
    }
}

