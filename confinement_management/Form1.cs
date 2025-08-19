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
    public partial class Form1 : Form
    {
        public Form1()
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
            Form2 fomr = new Form2();
            fomr.ShowDialog();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string senha = textBox2.Text;

            namespace CadastroCliente
    {
        public partial class LoginForm : Form
        {
            public LoginForm()
            {
                InitializeComponent();
            }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                string connectionString = "Server=localhost;Database=SEU_BANCO;User Id=aluno;Password=aluno;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string query = @"SELECT id_usuario, nome 
                                     FROM cadu
                                     WHERE email = @usuario AND senha = @senha";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@usuario", usuario.Text);
                        cmd.Parameters.AddWithValue("@senha", senha.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read()) // encontrou usuário
                        {
                            string nome = reader["nome"].ToString();
                            MessageBox.Show($"Bem-vindo, {nome}!");

                            // Aqui você pode abrir a tela principal do sistema
                            this.Hide();
                            Form1 frm = new Form1(); // exemplo
                            frm.Show();
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
    }
}
