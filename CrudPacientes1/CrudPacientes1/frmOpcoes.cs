using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudPacientes1
{
    public partial class frmOpcoes : Form
    {
        public frmOpcoes()
        {
            InitializeComponent();
        }

        private void btnCadastrodeClientes_Click(object sender, EventArgs e)
        {
            frmCadPacientes frm = new frmCadPacientes();
            this.Visible = false;
            frm.ShowDialog();
        }
    }
}
