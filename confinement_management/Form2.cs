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

  

        string mensagem = $"Cadastro realizado com sucesso!\n\n" +
            $"Nome: {nome}\n" + $"CPF: {cpf}\n" + $"RG: {rg}\n" + $"Data de nascimento: {nascimento}\n" + $"E-mail: {email}\n" + $"Endereço: {ddd}\n" + $"Fazenda: {fazenda}\n" +
            $"Cidade: {senha}\n" + $"Telefone: {tell}\n";

            MessageBox.Show(mensagem);


                }

        private void Form2_Load(object sender, EventArgs e)


        {

        }
    }
}
