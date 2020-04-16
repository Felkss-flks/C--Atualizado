using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConsultasDesk
{
    public partial class FrmCad : Form
    {
        SqlCommand cmd = new SqlCommand();

        Class.Conexao con = new Class.Conexao();
        public FrmCad()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtLog.Text = "";
            txtPass.Text = "";
            txtConfirmPass.Text = "";
            txtFunc.Text = "";
            txtUnid.Text = "";
            txtParc.Text = "";
        }
            

        private void btnCad_Click(object sender, EventArgs e)
        {
            con = new Class.Conexao();

            cmd = new SqlCommand("Ins_Upd_TBL_Usuario", con.conectar());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@LOGIN", SqlDbType.VarChar).Value = txtLog.Text.Trim();
            cmd.Parameters.AddWithValue("@SENHA", SqlDbType.VarChar).Value = txtPass.Text.Trim();
            cmd.Parameters.AddWithValue("@COD_UNID_MEDICA", SqlDbType.Int).Value = txtUnid.Text.Trim();
            cmd.Parameters.AddWithValue("@COD_PARCEIRO", SqlDbType.Int).Value = txtParc.Text.Trim();
            cmd.Parameters.AddWithValue("@COD_FUNCAO", SqlDbType.Int).Value = txtFunc.Text.Trim();
            cmd.Parameters.AddWithValue("@COD_USUARIO", SqlDbType.Int).Value = 0;

            //se os campos estiverem vazios

            if (txtPass.Text == string.Empty || txtLog.Text == string.Empty ||
                 txtConfirmPass.Text == string.Empty || txtFunc.Text == string.Empty ||
                 txtParc.Text == string.Empty || txtUnid.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os Campos", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                //confirmação das senhas
                if (txtPass.Text == txtConfirmPass.Text)
                {
                    cmd.ExecuteNonQuery();
                    clear();
                    MessageBox.Show("Cadastro Realizado Com Sucesso!", "Sucesso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Senhas Diferentes", "Erro", MessageBoxButtons.OK);
                }
                con.desconectar();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmLogin Login = new FrmLogin();
            Login.Visible = true;
            this.Close();
        }
    }
}
