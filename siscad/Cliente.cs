using aula7;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siscad
{
    class Cliente
    {
        // Atributos 
        //método get e set
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }

        public Cliente(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }


        public Cliente() { } // Construtor simples

        //Construtor com parametros
        public Cliente(string nome, string cpf, string telefone, string email)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.email = email;
        }

        // Método inserir
        public bool inserirCli(Cliente objCliCadastro)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao objConexao = new Conexao();
                pgsqlConnection = objConexao.getConexao();
                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql

                sql = "INSERT INTO tbl_cliente(nome, cpf, telefone, email) VALUES( '" + objCliCadastro.nome + "' ,'" + objCliCadastro.cpf + "','" + objCliCadastro.telefone + "','" + objCliCadastro.email + "')";

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

        public List<Cliente> listar()
        {
            List<Cliente> lstCliente = new List<Cliente>();

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from tbl_cliente order by nome;";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    Cliente objCliente = new Cliente();
                    objCliente.nome = dr["nome"].ToString();
                    objCliente.id = Convert.ToInt32(dr["id"].ToString());
                    lstCliente.Add(objCliente);
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
            return lstCliente; // retorna a lista
        }

        public List<Cliente> buscaPorTexto(string parte)
        {
            List<Cliente> lb_cliente = new List<Cliente>();

            //esses dados virão do banco de dados

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from tbl_cliente where tbl_cliente.nome ilike ('" + parte + "%') order by nome;";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {

                    Cliente objCliente = new Cliente();
                    objCliente.id = Convert.ToInt32(dr["id"]);
                    objCliente.nome = dr["nome"].ToString();
                    lb_cliente.Add(objCliente);
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                pgsqlConnection.Close();
            }
            return lb_cliente;
        }

        public List<Cliente> listar(String pesquisa)
        {
            List<Cliente> lstfuncaos = new List<Cliente>();

            //esses dados virão do banco de dados

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from tbl_cliente where (nome ilike ('" + pesquisa + "') or cpf ilike ('" + pesquisa + "'));";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    //Meu obj recebe os valores do banco que foi consultado
                    Cliente objCliConsulta = new Cliente();
                    objCliConsulta.id = Convert.ToInt32(dr["id"]);
                    objCliConsulta.nome = dr["nome"].ToString();
                    objCliConsulta.cpf = dr["cpf"].ToString();
                    objCliConsulta.telefone = dr["telefone"].ToString();
                    objCliConsulta.email = dr["email"].ToString();
                    lstfuncaos.Add(objCliConsulta);

                }

            }
            catch (Exception ex)
            {

                //

            }
            finally
            {

                pgsqlConnection.Close();

            }


            return lstfuncaos;

        }

        public void consultar()
        {

            //esses dados virão do banco de dados

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select id,nome,cpf,telefone,email from tbl_cliente where id=" + this.id + ";";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();


                dr.Read(); //sabemos que somente irá trazer um unico registro


                this.id = Convert.ToInt32(dr["id"]);
                this.nome = dr["nome"].ToString();
                this.cpf = dr["cpf"].ToString();
                this.telefone = dr["telefone"].ToString();
                this.email = dr["email"].ToString();

            }
            catch (Exception ex)
            {

                //

            }
            finally
            {

                pgsqlConnection.Close();

            }
        }


        public bool alterar()
        {

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "UPDATE tbl_cliente set nome='" + this.nome + "', cpf='" + this.cpf + "', telefone='" + this.telefone + "', email='" + this.email + "' where id=" + this.id + ";";

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

                pgsqlConnection.Close();

            }
        }
        public bool excluir()
        {

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "DELETE FROM tbl_cliente WHERE id= '" + this.id + "' ";

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

                pgsqlConnection.Close();

            }


        }

    }
}
