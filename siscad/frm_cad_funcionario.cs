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

    public partial class frm_cad_funcionario : Form
    {

        internal Login objlogin;
        public frm_cad_funcionario()
        {
            InitializeComponent();
        }


        private void frm_cad_funcionario_Load(object sender, EventArgs e)
        {
            //processo para encher a comboBox
            List<Cargo> arrestados = new List<Cargo>();
            Cargo objCargo = new Cargo();
            arrestados = objCargo.listar();
            cb_cargo.DataSource = arrestados;
            cb_cargo.DisplayMember = "cargo";
            cb_cargo.ValueMember = "codCargo";

            //alterar os botoes de acesso
            //if (objlogin.nva == 2)
            //{
            //    btn_consultar.Enabled = false;
            //}
            //else if (objlogin.nva == 3)
            //{
            //    btn_consultar.Enabled = false;
            //}

        }

        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            // Atributos + campos da interface
            string nome = txt_nome.Text;
            string cpf = txt_cpf.Text;
            string telefone = txt_telefone.Text;
            string email = txt_email.Text;

            // Variavel 'codCargo' receberá o valor convertido do ID do cargo selecionado na interface
            int codCargo = Convert.ToInt32(cb_cargo.SelectedValue);

            // Estancio obj com parametros, somento com ID
            Cargo objCargo = new Cargo(codCargo, "");

            // Estancio obj com pametros dos valores da interface
            Funcionario objFuncCadastro = new Funcionario(nome, cpf, telefone, email, objCargo);

            //chamar o metodo inserir da classe Funcionario
            if (objFuncCadastro.inserirFunc(objFuncCadastro)==true)
            {

                MessageBox.Show("Cadastro efetuado com Sucesso!");
            }
            else {

                MessageBox.Show("Ops!, ocorreu um erro!");
            }
        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_nome.BackColor = Color.LightGreen;
        }

        private void txt_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_cpf.BackColor = Color.LightGreen;
        }

        private void txt_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_telefone.BackColor = Color.LightGreen;
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_email.BackColor = Color.LightGreen;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            // Limpa os campos
            txt_nome.Text = "";
            txt_cpf.Text = "";
            txt_telefone.Text = "";
            txt_email.Text = "";
            cb_cargo.Text = "";

            // Volta cor padrão
            txt_nome.BackColor = Color.White;
            txt_cpf.BackColor = Color.White;
            txt_telefone.BackColor = Color.White;
            txt_email.BackColor = Color.White;
            cb_cargo.BackColor = Color.White;
        }

        private void cb_cargo_Click(object sender, EventArgs e)
        {
            cb_cargo.BackColor = Color.LightGreen;
        }

        private void cb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_cargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            cb_cargo.BackColor = Color.LightGreen;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            frm_func_consulta objFuncConsulta = new frm_func_consulta();
            objFuncConsulta.Show();
        }
    }
}
