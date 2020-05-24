using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CrudPacientes1
{
    public partial class frmCadPacientes : Form
    {
        public frmCadPacientes()
        {
            InitializeComponent();
        }
        public void Cadastrar ()
        {
            try
            {    //inserir dados no banco de dados
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crudcad; ");
                objcon.Open();
                MySqlCommand objCmd = new MySqlCommand("insert into tb_paciente (id, nome, datanasc, cpf, rg, cns, mae, \n" +
                    " pai, tel1, tel2, email, cep, logadouro, num, bairro, cidade, \n" +
                    " uf, observacaoes) values( null, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", objcon);

                //parametros do comando sql
                objCmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
                objCmd.Parameters.Add("@datadenasc", MySqlDbType.VarChar, 17).Value = txtDataNasc.Text;
                objCmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 18).Value = txtCpf.Text;
                objCmd.Parameters.Add("@rg", MySqlDbType.VarChar, 18).Value = txtRg.Text;
                objCmd.Parameters.Add("@cns", MySqlDbType.VarChar, 18).Value = txtCns.Text;
                objCmd.Parameters.Add("@mae", MySqlDbType.VarChar, 400).Value = txtMae.Text;
                objCmd.Parameters.Add("@pai", MySqlDbType.VarChar, 40).Value = txtPai.Text;
                objCmd.Parameters.Add("@tel1", MySqlDbType.VarChar, 20).Value = txtTel1.Text;
                objCmd.Parameters.Add("@tel2", MySqlDbType.VarChar, 20).Value = txtTel2.Text;
                objCmd.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = txtEmail.Text;
                objCmd.Parameters.Add("@cep", MySqlDbType.VarChar, 14).Value = txtCep.Text;
                objCmd.Parameters.Add("@logadouro", MySqlDbType.VarChar, 100).Value = txtRua.Text;
                objCmd.Parameters.Add("@num", MySqlDbType.VarChar, 8).Value = txtNum.Text;
                objCmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 50).Value = txtBairro.Text;
                objCmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 50).Value = txtCidade.Text;
                objCmd.Parameters.Add("@uf", MySqlDbType.VarChar, 4).Value = txtUf.Text;
                objCmd.Parameters.Add("@obeservacaoes", MySqlDbType.VarChar, 200).Value = txtObservacao.Text;

                //para colocar os estados no combo box
                //cmbestado.itens.add("sp");

                //comando para executar query
                objCmd.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso!!!");

                //fecha o banco de dados
                objcon.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Cadastro NÃO Realizado!!!" + erro);
            }

        }

        public void LimparBox ()
        {
            txtNome.Text = (" ");
            txtDataNasc.Text = (" ");
            txtCpf.Text = (" ");
            txtRg.Text = (" ");
            txtCns.Text = (" ");
            txtMae.Text = (" ");
            txtPai.Text = (" ");
            txtTel1.Text = (" ");
            txtTel2.Text = (" ");
            txtEmail.Text = (" ");
            txtCep.Text = (" ");
            txtRua.Text = (" ");
            txtNum.Text = (" ");
            txtBairro.Text = (" ");
            txtCidade.Text = (" ");
            txtUf.Text = (" ");
            txtObservacao.Text = (" ");
            txtProntuario.Text = (" ");
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOpcoes frm = new frmOpcoes();
            this.Visible = false;
            frm.ShowDialog();
        }

        private void checkBoxIncluirCadastro_CheckedChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;

            LimparBox();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtProntuario_TextChanged(object sender, EventArgs e)
        {
            txtProntuario.ReadOnly = true;
        }
    }
}

