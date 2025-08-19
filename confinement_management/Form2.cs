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
    public partial class Form2 : Form
    {
        public Form2()
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

            string mensagem = $"Cadastro realizado com sucesso!\n\n" +
            $"Nome: {nome}\n" + $"CPF: {cpf}\n" + $"RG: {rg}\n" + $"Data de nascimento: {nascimento}\n" + $"E-mail: {email}\n" + $"Endereço: {ddd}\n" + $"Fazenda: {fazenda}\n" +
            $"Cidade: {senha}\n" + $"Telefone: {tell}\n";

            MessageBox.Show(mensagem);

            Form1 fomr = new Form1();
            fomr.ShowDialog();


        }

        private void Form2_Load(object sender, EventArgs e)


        {

        }
    }
}
