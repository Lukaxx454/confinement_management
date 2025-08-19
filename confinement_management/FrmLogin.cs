using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace confinement_management
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            FrmUsuario fomr = new FrmUsuario();
            fomr.ShowDialog();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            string email = TxbEmail.Text;
            string senha = TxbSenha.Text;
            {
                string connectionString = "Server=sqlexpress;Database=CJ3027791PR2;User Id=aluno;Password=aluno;";


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string query = @"SELECT EMAIL, SENHA 
                                     FROM cadu
                                     WHERE EMAIL = @email AND SENHA = @senha";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", senha);

                       SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows) // encontrou usuário
                        {

                            // Aqui você pode abrir a tela principal do sistema
                            this.Visible = false;
                            FrmInicial frm = new FrmInicial(); // exem
                            frm.ShowDialog();
                            this.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }
    }
}

