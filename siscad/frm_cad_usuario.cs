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
    public partial class frm_cad_usuario : Form
    {
        public frm_cad_usuario()
        {
            InitializeComponent();
        }

        private void frm_cad_usuario_Load(object sender, EventArgs e)
        {
            List<Funcionario> arrestados = new List<Funcionario>();

            Funcionario objFuncionario = new Funcionario();

            arrestados = objFuncionario.listar();

            cb_funcionario.DataSource = arrestados;

            cb_funcionario.DisplayMember = "nome";
            cb_funcionario.ValueMember = "id";
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            // Atributos + campos da interface
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;
            int nva = Convert.ToInt32(txt_nva.Text);

            // Variavel 'codFunc' receberá o valor convertido do ID do func selecionado na interface
            int codFunc = Convert.ToInt32(cb_funcionario.SelectedValue);

            // Estancio obj com parametros, somento com ID
            Funcionario objFunc = new Funcionario(codFunc, "");

            // Estancio obj com pametros dos valores da interface
            Usuario objCadUsuario = new Usuario(usuario, senha, nva, objFunc);

            //chamar o metodo inserir da classe Funcionario
            if (objCadUsuario.inserirUsuario(objCadUsuario) == true)
            {

                MessageBox.Show("Cadastro efetuado com Sucesso!");
            }
            else {

                MessageBox.Show("Ops!, ocorreu um erro!");
            }
        }

        private void cb_funcionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            cb_funcionario.BackColor = Color.LightGreen;
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_usuario.BackColor = Color.LightGreen;
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_senha.BackColor = Color.LightGreen;
        }

        private void txt_nva_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_nva.BackColor = Color.LightGreen;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            // Limpa os campos
            txt_usuario.Text = "";
            txt_senha.Text = "";
            txt_nva.Text = "";
            cb_funcionario.Text = "";

            // Volta cor padrão
            txt_usuario.BackColor = Color.White;
            txt_senha.BackColor = Color.White;
            txt_nva.BackColor = Color.White;
            cb_funcionario.BackColor = Color.White;
        }

        private void cb_funcionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_funcionario.BackColor = Color.LightGreen;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            frm_usuario_consulta objConsultaUsu = new frm_usuario_consulta();
            objConsultaUsu.Show();
        }
    }
}
