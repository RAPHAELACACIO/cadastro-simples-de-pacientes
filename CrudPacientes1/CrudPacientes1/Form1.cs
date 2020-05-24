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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                BarraDeProgresso.Value = BarraDeProgresso.Value + 2;
            }
            catch
            {
                timer1.Enabled = false;

                this.Visible = false;

               frmOpcoes frm = new frmOpcoes();

                frm.ShowDialog();

            }
        }
            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrodeClientes_Click(object sender, EventArgs e)
        {
            frmCadPacientes frm = new frmCadPacientes();
            this.Visible = false;
            frm.ShowDialog();
        }
    }
}
