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
    public partial class frm_cli_alt : Form
    {
        public int idcliente;
        public frm_cli_alt()
        {
            InitializeComponent();
        }

        private void frm_cli_alt_Load(object sender, EventArgs e)
        {
            alterar();
        }
        private void alterar()
        {
            Cliente objCliAlt = new Cliente(); //faço estanciamento do obj
            objCliAlt.id = Convert.ToInt32(idcliente);

            //consulta func para retornar os valores
            objCliAlt.consultar();

            //retorno os valores do metedo consultar
            txt_nome.Text = objCliAlt.nome;
            txt_cpf.Text = objCliAlt.cpf;
            txt_telefone.Text = objCliAlt.telefone;
            txt_email.Text = objCliAlt.email;


        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Cliente objClicAlt = new Cliente(); //faço estanciamento do obj

            objClicAlt.id = Convert.ToInt32(idcliente);
            objClicAlt.nome = txt_nome.Text;
            objClicAlt.cpf = txt_cpf.Text;
            objClicAlt.telefone = txt_telefone.Text;
            objClicAlt.email = txt_email.Text;


            if (objClicAlt.alterar())
            {
                MessageBox.Show("Registro Alterado com Sucesso!");
            }
            else
            {
                MessageBox.Show("Ops. Algo de Errado aconteceu!");
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Cliente objCliExcluir = new Cliente(); //faço estanciamento do obj

            objCliExcluir.id = Convert.ToInt32(idcliente);
            objCliExcluir.nome = txt_nome.Text;
            objCliExcluir.cpf = txt_cpf.Text;
            objCliExcluir.telefone = txt_telefone.Text;
            objCliExcluir.email = txt_email.Text;


            if (objCliExcluir.excluir())
            {
                MessageBox.Show("Registro excluido com Sucesso!");
            }
            else
            {
                MessageBox.Show("Ops. Algo de Errado aconteceu!");
            }
        }
    }
}
