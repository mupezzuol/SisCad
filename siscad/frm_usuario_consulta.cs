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
    public partial class frm_usuario_consulta : Form
    {
        public frm_usuario_consulta()
        {
            InitializeComponent();
        }

        private void txt_funcionario_TextChanged(object sender, EventArgs e)
        {
            if (txt_funcionario.Text.Length > 2)
            {
                Funcionario objFunc = new Funcionario(); // criar o objeto

                lb_funcionario.DataSource = objFunc.buscaPorTexto(txt_funcionario.Text); //chamar a funcao que retornara os objetos
                lb_funcionario.ValueMember = "id";
                lb_funcionario.DisplayMember = "nome"; //setar o atributo do objeto que sera mostrado para o usuario
                lb_funcionario.Visible = true;
            }
            else {
                lb_funcionario.Visible = false;
            }
        }

        private void lb_funcionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_funcionario.Text = lb_funcionario.Text;

            ///vair buscar os dados
            int idFunc = Convert.ToInt32(lb_funcionario.SelectedValue.ToString());

            Funcionario objFunc = new Funcionario();
            objFunc.id = idFunc;

            Usuario objUsuario = new Usuario();

            objUsuario = objUsuario.FuncBuscar(objFunc);

            txt_usuario.Text = objUsuario.usuario;
            txt_senha.Text = objUsuario.senha;
            txt_nva.Text = objUsuario.nva.ToString();

            lb_funcionario.Visible = false;
        }

        private void frm_usuario_consulta_Load(object sender, EventArgs e)
        {
            lb_funcionario.Visible = false;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_funcionario.Text = "";
            txt_usuario.Text = "";
            txt_senha.Text = "";
            txt_nva.Text = "";
        }
    }
}
