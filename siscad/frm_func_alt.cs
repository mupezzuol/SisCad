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
    public partial class frm_func_alt : Form
    {

        public int idfuncionario; //uso essa variavel para mandar pros forms

        public frm_func_alt()
        {
            InitializeComponent();
        }

        private void alterar()
        {
            Funcionario objFuncAlt = new Funcionario(); //faço estanciamento do obj
            objFuncAlt.id = Convert.ToInt32(idfuncionario);

            //consulta func para retornar os valores
            objFuncAlt.consultar();

            //retorno os valores do metedo consultar
            txt_nome.Text = objFuncAlt.nome;
            txt_cpf.Text = objFuncAlt.cpf;
            txt_telefone.Text = objFuncAlt.telefone;
            txt_email.Text = objFuncAlt.email;

            //encho minha comboBox
            List<Cargo> arrestados = new List<Cargo>(); //estancio obj de um array
            Cargo objCargo = new Cargo();//estancio obj
            arrestados = objCargo.listar(); //variavel array recebe tudo do objcargo
            cb_cargo.DataSource = arrestados; //propriedade do cb recebe valores etc..
            cb_cargo.DisplayMember = "cargo";
            cb_cargo.ValueMember = "codCargo";

            //pega valor selecionado
            cb_cargo.SelectedValue = objFuncAlt.cargo.codCargo; 

        }



        private void frm_func_alt_Load(object sender, EventArgs e)
        {
            // chama alterar para executar todo processo de consulta
            alterar();
        }


        private void btn_voltar_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Funcionario objFuncAlt = new Funcionario(); //faço estanciamento do obj

            objFuncAlt.id = Convert.ToInt32(idfuncionario);
            objFuncAlt.nome = txt_nome.Text;
            objFuncAlt.cpf = txt_cpf.Text;
            objFuncAlt.telefone = txt_telefone.Text;
            objFuncAlt.email = txt_email.Text;

            objFuncAlt.cargo = new Cargo(Convert.ToInt32(cb_cargo.SelectedValue), "");

            if (objFuncAlt.excluir())
            {
                MessageBox.Show("Registro excluido com Sucesso!");
            }
            else
            {
                MessageBox.Show("Ops. Algo de Errado aconteceu!");
            }
        }

        private void btn_alterar_Click_1(object sender, EventArgs e)
        {
            Funcionario objFuncAlt = new Funcionario(); //faço estanciamento do obj

            objFuncAlt.id = Convert.ToInt32(idfuncionario);
            objFuncAlt.nome = txt_nome.Text;
            objFuncAlt.cpf = txt_cpf.Text;
            objFuncAlt.telefone = txt_telefone.Text;
            objFuncAlt.email = txt_email.Text;

            objFuncAlt.cargo = new Cargo(Convert.ToInt32(cb_cargo.SelectedValue), "");

            if (objFuncAlt.alterar())
            {
                MessageBox.Show("Registro Alterado com Sucesso!");
            }
            else
            {
                MessageBox.Show("Ops. Algo de Errado aconteceu!");
            }
        }
    }
}
