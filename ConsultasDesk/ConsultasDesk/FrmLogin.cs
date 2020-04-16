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
    public partial class FrmLogin : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        
        Class.Conexao con = new Class.Conexao();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLog_Click_1(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            con = new Class.Conexao();
            cmd = new SqlCommand("Select_Usuario", con.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@LOGIN", SqlDbType.VarChar).Value = txtLog.Text.Trim();
            cmd.Parameters.AddWithValue("@SENHA", SqlDbType.VarChar).Value = txtPass.Text.Trim();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)//se tiver linhas ele loga
            {
                Menu.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos!", "Erro", MessageBoxButtons.OK);
            }
            con.desconectar();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            FrmCad Cad = new FrmCad();
            Cad.Show();
            this.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
