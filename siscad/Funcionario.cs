using aula7;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siscad
{
    class Funcionario
    {
        // Atributos
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public Cargo cargo { get; set; } // variavel cargo DEVE ser do tipo classe 'Cargo'

        // Construtor com 2 pametros, ID e Cargo
        public Funcionario(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }


        public Funcionario(){} // Construtor simples

        //Construtor com parametros
        public Funcionario(string nome, string cpf, string telefone, string email, Cargo cargo) {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo;
        }

        // Método inserir
        public bool inserirFunc(Funcionario objFuncCadastro)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao objConexao = new Conexao();
                pgsqlConnection = objConexao.getConexao();
                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql

                sql = "INSERT INTO tbl_funcionario(nome, cpf, telefone, email, idcargo) VALUES( '" + objFuncCadastro.nome + "' ,'" + objFuncCadastro.cpf + "','" + objFuncCadastro.telefone + "','" + objFuncCadastro.email + "' , '" + objFuncCadastro.cargo.codCargo +"')";

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


        public List<Funcionario> listar()
        {
            List<Funcionario> lstFuncionario = new List<Funcionario>();

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from tbl_funcionario order by nome;";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    Funcionario objFuncionario = new Funcionario();
                    objFuncionario.nome = dr["nome"].ToString();
                    objFuncionario.id = Convert.ToInt32(dr["id"].ToString());
                    lstFuncionario.Add(objFuncionario);
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
            return lstFuncionario; // retorna a lista
        }


        public List<Funcionario> buscaPorTexto(string parte)
        {
            List<Funcionario> lb_funcionario = new List<Funcionario>();

            //esses dados virão do banco de dados

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from tbl_funcionario where tbl_funcionario.nome ilike ('" + parte + "%') order by nome;";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {

                    Funcionario objFuncionario = new Funcionario();
                    objFuncionario.id = Convert.ToInt32(dr["id"]);
                    objFuncionario.nome = dr["nome"].ToString();
                    lb_funcionario.Add(objFuncionario);
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
            return lb_funcionario;
        }


        public List<Funcionario> listar(String pesquisa)
        {
            List<Funcionario> lstfuncaos = new List<Funcionario>();

            //esses dados virão do banco de dados

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from tbl_funcionario where (nome ilike ('" + pesquisa + "') or cpf ilike ('" + pesquisa + "'));";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    //Meu obj recebe os valores do banco que foi consultado
                    Funcionario objFuncConsulta = new Funcionario();
                    objFuncConsulta.id = Convert.ToInt32(dr["id"]);
                    objFuncConsulta.nome = dr["nome"].ToString();
                    objFuncConsulta.cpf = dr["cpf"].ToString();
                    objFuncConsulta.telefone = dr["telefone"].ToString();
                    objFuncConsulta.email = dr["email"].ToString();
                    lstfuncaos.Add(objFuncConsulta);

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
                sql = "select id,nome,cpf,telefone,email,idcargo from tbl_funcionario where id=" + this.id + ";";

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
                this.cargo = new Cargo(Convert.ToInt32(dr["idcargo"].ToString()), "");

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
                sql = "UPDATE tbl_funcionario set nome='" + this.nome + "', cpf='" + this.cpf + "', telefone='" + this.telefone + "', email='" + this.email + "', idcargo='" + this.cargo.codCargo + "' where id=" + this.id + ";";

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
                sql = "DELETE FROM tbl_funcionario WHERE id= '" + this.id + "' and idcargo='" + this.cargo.codCargo + "' ";

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



