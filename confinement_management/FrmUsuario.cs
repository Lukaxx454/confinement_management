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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string nome = TXBNOME.Text;
            string cpf = TXBCPF.Text;
            string rg = TXBRG.Text;
            string nascimento = DTPNASCIMENTO.Value.ToString("dd/mm/aaaa");
            string email = TXBEMAIL.Text;
            string ddd = TXBEMAIL.Text;
            string fazenda = TXBFAZENDA.Text;
            string senha = TXBSENHA.Text;
            string tell = TXBEMAIL.Text;

            string connectionString = "Server=sqlexpress;Database=CJ3027791PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO cadU
                                    (NOME, CPF, RG, NASCIMENTO, FAZENDA, EMAIL, ENDEREÇO, SENHA, TELEFONE)
                                     VALUES (@nome, @cpf, @rg, @nascimento, @fazenda, @email, @endereco, @senha, @telefone)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Passando valores dos TextBox para os parâmetros
                    cmd.Parameters.AddWithValue("@nome", TXBNOME.Text);
                    cmd.Parameters.AddWithValue("@cpf", TXBCPF.Text);
                    cmd.Parameters.AddWithValue("@rg", TXBRG.Text);
                    cmd.Parameters.AddWithValue("@nascimento", DTPNASCIMENTO.Value);
                    cmd.Parameters.AddWithValue("@fazenda", TXBFAZENDA.Text);
                    cmd.Parameters.AddWithValue("@email", TXBEMAIL.Text);
                    cmd.Parameters.AddWithValue("@endereco", TXBDDD.Text);
                    cmd.Parameters.AddWithValue("@senha", TXBSENHA.Text);
                    cmd.Parameters.AddWithValue("@telefone", TXBTELL.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

            this.Close();


        }

        private void Form2_Load(object sender, EventArgs e)


        {

        }
    }
}
