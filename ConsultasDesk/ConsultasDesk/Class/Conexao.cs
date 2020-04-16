using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsultasDesk.Class
{
    class Conexao
    {


        public String Mensagem = "Erro";
        SqlConnection conexao = new SqlConnection();

        public SqlConnection conectar()
        {
            try
            {
                String strConexao = "Data Source=DESKTOP-BEE3K4T;Initial Catalog=ProjetoTCC;User ID=sa;Password=20010731Felix@";
                conexao.ConnectionString = strConexao;
                conexao.Open();
                return conexao;

            }
            catch (Exception)
            {
                desconectar();
                return null;
                throw;
            }

        }

        public void desconectar()
        {
            try
            {
                if ((conexao.State == ConnectionState.Open))
                {
                    conexao.Close();
                    conexao.Dispose();
                    conexao = null;
                }
            }
            catch (Exception) { }
        }

        public DataSet executa_sql(String comando_sql)
        {
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conectar());
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
            finally
            {
                desconectar();
            }
        }

    }
}
