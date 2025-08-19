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
    public partial class FrmEditUsuario : Form
    {
        public FrmEditUsuario()
        {
            InitializeComponent();
        }

        private void FrmEditUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cJ3027791PR2DataSet.CADU'. Você pode movê-la ou removê-la conforme necessário.
            this.cADUTableAdapter.Fill(this.cJ3027791PR2DataSet.CADU);

        }
    }
}
