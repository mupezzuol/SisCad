using aula7;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siscad
{
    public class Login
    {
        public String usuario { get; set; }
        public String senha { get; set; }

        public int nva { get; set; }

        public int codfunc { get; set; }

        public int logado { get; set; }

        public Login(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }


        public Login loginVerificar(Login objLogin)
        {

            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao objConexao = new Conexao();
                pgsqlConnection = objConexao.getConexao();
                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = " SELECT usuario, senha, nva, codfunc FROM tbl_usuario WHERE usuario= '"+ objLogin.usuario +"' AND senha= '"+ objLogin.senha +"' ";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();


                dr.Read();

                Login objloginaux = new Login();
                objloginaux.usuario = dr["usuario"].ToString();
                objloginaux.senha = dr["senha"].ToString();
                objloginaux.nva = Convert.ToInt32(dr["nva"].ToString());
                objloginaux.codfunc = Convert.ToInt32(dr["codfunc"].ToString());


                if ((objloginaux.usuario == objLogin.usuario) && (objloginaux.senha == objLogin.senha))
                {

                    objloginaux.logado = 1;
                    return objloginaux;

                } else
                {

                    objloginaux.logado = 0;
                    return objloginaux;
                }
              

                
            }
            catch (Exception ex)
            {
                Login objloginaux = new Login();
                return objloginaux;
            }
            finally
            {
                pgsqlConnection.Close(); // Fecha conexão
            }
        }

        public Login(){
            }
    }
}
