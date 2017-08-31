using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siscad
{
    public partial class frm_cad_cliente : Form
    {
        public frm_cad_cliente()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            // Atributos + campos da interface
            string nome = txt_nome.Text;
            string cpf = txt_cpf.Text;
            string telefone = txt_telefone.Text;
            string email = txt_email.Text;


            // Estancio obj com pametros dos valores da interface
            Cliente objCliCadastro = new Cliente(nome, cpf, telefone, email);

            //chamar o metodo inserir da classe Funcionario
            if (objCliCadastro.inserirCli(objCliCadastro) == true)
            {

                MessageBox.Show("Cadastro efetuado com Sucesso!");
            }
            else {

                MessageBox.Show("Ops!, ocorreu um erro!");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            frm_cli_consulta objCliConsulta = new frm_cli_consulta();
            objCliConsulta.Show();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            txt_cpf.Text = "";
            txt_email.Text = "";
            txt_telefone.Text = "";
        }
    }
  }

