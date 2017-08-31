using aula7;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siscad
{
    class Cargo
    {
        // Atributos 
        public int codCargo { get; set; }
        public string cargo { get; set; } 

        // Construtor com 2 pametros, ID e Cargo
        public Cargo(int codCargo, string cargo)
        {
            this.codCargo = codCargo;
            this.cargo = cargo;
        }

        public Cargo(string cargo)
        {
            this.cargo = cargo;
        }
        
        public Cargo(){ }// Construtor simples
        public bool inserirCargo(Cargo objCargoCadastro)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao objConexao = new Conexao();
                pgsqlConnection = objConexao.getConexao();
                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql

                sql = "INSERT INTO tbl_cargo(cargo) VALUES('" + objCargoCadastro.cargo + "')";

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

        public List<Cargo> listar()
        {
            List<Cargo> lstCargo = new List<Cargo>();

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from tbl_cargo order by cargo;";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    Cargo objCargo = new Cargo();
                    objCargo.cargo = dr["cargo"].ToString();
                    objCargo.codCargo = Convert.ToInt32(dr["id"].ToString());  
                    lstCargo.Add(objCargo);
                }

            }
            catch (Exception ex)
            {
                // se der erro
            }
            finally
            {
                pgsqlConnection.Close(); // termina fecha conexão
            }
            return lstCargo; // retorna a lista
        }

    }
}
