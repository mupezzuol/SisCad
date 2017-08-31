using aula7;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siscad
{
    class Usuario
    {
        // Atributos
        public string usuario { get; set; }
        public string senha { get; set; }
        public int nva { get; set; }
        public Funcionario codFunc { get; set; }

        public Usuario() { } // Construtor simples

        //Construtor com parametros
        public Usuario(string usuario, string senha, int nva, Funcionario codFunc)
        {
            this.usuario = usuario;
            this.senha = senha;
            this.nva = nva;
            this.codFunc = codFunc;
        }

        // Método inserir
        public bool inserirUsuario(Usuario objCadUsuario)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao objConexao = new Conexao();
                pgsqlConnection = objConexao.getConexao();
                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql

                sql = "INSERT INTO tbl_usuario(usuario, senha, nva, codfunc) VALUES('" + objCadUsuario.usuario + "','" + objCadUsuario.senha + "','" + objCadUsuario.nva + "','" + objCadUsuario.codFunc.id+ "')";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                cmd.ExecuteNonQuery();//executa comando no banco de dados

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                pgsqlConnection.Close(); // Fecha conexão
            }
        }

        public Usuario FuncBuscar(Funcionario objFunc)
        {

            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao objConexao = new Conexao();
                pgsqlConnection = objConexao.getConexao();
                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = " SELECT usuario,senha,nva FROM tbl_usuario WHERE codfunc= '" + objFunc.id + "'";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                Usuario objFuncaux = new Usuario();
                objFuncaux.usuario = dr["usuario"].ToString();
                objFuncaux.senha = dr["senha"].ToString();
                objFuncaux.nva = Convert.ToInt32(dr["nva"].ToString());

                return objFuncaux;

            }
            catch (Exception ex)
            {
                Usuario objFuncaux = new Usuario();
                return objFuncaux;
            }
            finally
            {
                pgsqlConnection.Close(); // Fecha conexão
            }
        }



    }
}
