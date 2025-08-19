namespace confinement_management
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif Hebrew", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Serif Hebrew", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxbEmail
            // 
            this.TxbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbEmail.Location = new System.Drawing.Point(132, 247);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(182, 26);
            this.TxbEmail.TabIndex = 3;
            // 
            // TxbSenha
            // 
            this.TxbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSenha.Location = new System.Drawing.Point(132, 297);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.PasswordChar = '*';
            this.TxbSenha.Size = new System.Drawing.Size(182, 26);
            this.TxbSenha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Noto Serif Hebrew", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(112, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "ENTRAR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Serif Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ainda não possui conta?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Noto Serif Hebrew", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(89, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "CADASTRE-SE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Serif Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Perdeu sua senha?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Serif Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Clique aqui!";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::confinement_management.Properties.Resources.confinement_management;
            this.ClientSize = new System.Drawing.Size(955, 605);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.TxbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.TextBox TxbSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

