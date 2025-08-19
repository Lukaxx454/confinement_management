namespace confinement_management
{
    partial class FrmUsuario
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
            this.TXBNOME = new System.Windows.Forms.TextBox();
            this.TXBEMAIL = new System.Windows.Forms.TextBox();
            this.TXBCPF = new System.Windows.Forms.TextBox();
            this.TXBRG = new System.Windows.Forms.TextBox();
            this.TXBSENHA = new System.Windows.Forms.TextBox();
            this.TXBDDD = new System.Windows.Forms.TextBox();
            this.TXBFAZENDA = new System.Windows.Forms.TextBox();
            this.TXBTELL = new System.Windows.Forms.TextBox();
            this.DTPNASCIMENTO = new System.Windows.Forms.DateTimePicker();
            this.Cadastro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXBNOME
            // 
            this.TXBNOME.Location = new System.Drawing.Point(72, 196);
            this.TXBNOME.Name = "TXBNOME";
            this.TXBNOME.Size = new System.Drawing.Size(955, 20);
            this.TXBNOME.TabIndex = 0;
            // 
            // TXBEMAIL
            // 
            this.TXBEMAIL.Location = new System.Drawing.Point(72, 376);
            this.TXBEMAIL.Name = "TXBEMAIL";
            this.TXBEMAIL.Size = new System.Drawing.Size(955, 20);
            this.TXBEMAIL.TabIndex = 1;
            // 
            // TXBCPF
            // 
            this.TXBCPF.Location = new System.Drawing.Point(72, 286);
            this.TXBCPF.Name = "TXBCPF";
            this.TXBCPF.Size = new System.Drawing.Size(352, 20);
            this.TXBCPF.TabIndex = 2;
            // 
            // TXBRG
            // 
            this.TXBRG.Location = new System.Drawing.Point(450, 286);
            this.TXBRG.Name = "TXBRG";
            this.TXBRG.Size = new System.Drawing.Size(290, 20);
            this.TXBRG.TabIndex = 3;
            // 
            // TXBSENHA
            // 
            this.TXBSENHA.Location = new System.Drawing.Point(72, 465);
            this.TXBSENHA.Name = "TXBSENHA";
            this.TXBSENHA.Size = new System.Drawing.Size(536, 20);
            this.TXBSENHA.TabIndex = 5;
            // 
            // TXBDDD
            // 
            this.TXBDDD.Location = new System.Drawing.Point(625, 465);
            this.TXBDDD.Name = "TXBDDD";
            this.TXBDDD.Size = new System.Drawing.Size(402, 20);
            this.TXBDDD.TabIndex = 6;
            // 
            // TXBFAZENDA
            // 
            this.TXBFAZENDA.Location = new System.Drawing.Point(72, 555);
            this.TXBFAZENDA.Name = "TXBFAZENDA";
            this.TXBFAZENDA.Size = new System.Drawing.Size(298, 20);
            this.TXBFAZENDA.TabIndex = 7;
            // 
            // TXBTELL
            // 
            this.TXBTELL.Location = new System.Drawing.Point(394, 555);
            this.TXBTELL.Name = "TXBTELL";
            this.TXBTELL.Size = new System.Drawing.Size(238, 20);
            this.TXBTELL.TabIndex = 8;
            // 
            // DTPNASCIMENTO
            // 
            this.DTPNASCIMENTO.Location = new System.Drawing.Point(763, 286);
            this.DTPNASCIMENTO.Name = "DTPNASCIMENTO";
            this.DTPNASCIMENTO.Size = new System.Drawing.Size(264, 20);
            this.DTPNASCIMENTO.TabIndex = 9;
            // 
            // Cadastro
            // 
            this.Cadastro.AutoSize = true;
            this.Cadastro.Font = new System.Drawing.Font("Noto Serif Hebrew", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.Location = new System.Drawing.Point(799, 555);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(123, 25);
            this.Cadastro.TabIndex = 10;
            this.Cadastro.Text = "CADASTRAR";
            this.Cadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::confinement_management.Properties.Resources.Documento_A5_ficha_cadastral_de_clientes_simples1;
            this.ClientSize = new System.Drawing.Size(1106, 710);
            this.Controls.Add(this.Cadastro);
            this.Controls.Add(this.DTPNASCIMENTO);
            this.Controls.Add(this.TXBTELL);
            this.Controls.Add(this.TXBFAZENDA);
            this.Controls.Add(this.TXBDDD);
            this.Controls.Add(this.TXBSENHA);
            this.Controls.Add(this.TXBRG);
            this.Controls.Add(this.TXBCPF);
            this.Controls.Add(this.TXBEMAIL);
            this.Controls.Add(this.TXBNOME);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXBNOME;
        private System.Windows.Forms.TextBox TXBEMAIL;
        private System.Windows.Forms.TextBox TXBCPF;
        private System.Windows.Forms.TextBox TXBRG;
        private System.Windows.Forms.TextBox TXBSENHA;
        private System.Windows.Forms.TextBox TXBDDD;
        private System.Windows.Forms.TextBox TXBFAZENDA;
        private System.Windows.Forms.TextBox TXBTELL;
        private System.Windows.Forms.DateTimePicker DTPNASCIMENTO;
        private System.Windows.Forms.Label Cadastro;
    }
}