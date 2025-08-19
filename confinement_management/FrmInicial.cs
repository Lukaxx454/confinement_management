using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace confinement_management
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void TsmUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario CadastroU = new FrmUsuario();  
            CadastroU.ShowDialog();
        }
    }
}
