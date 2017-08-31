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
    public partial class frm_principal : Form
    {
        internal Login objlogin;
        
        public frm_principal()
        {
            InitializeComponent();
        }

        private void mnu_func_cadastrar_Click(object sender, EventArgs e)
        {
            frm_cad_funcionario objCadFunc = new frm_cad_funcionario();
            objCadFunc.Show();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            lbl_log.Text = objlogin.usuario;
            //alterar os menus
            if (objlogin.nva == 2)
            {
                mnu_usuario.Visible = false;
               
            }
            else if (objlogin.nva == 3)
            {
                mnu_usuario.Visible = false;
                mnu_cargo_cadastrar.Visible = false;
                mnu_func_cadastrar.Visible = false;
                mnu_cliente.Visible = false;
            }
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mnu_cargo_cadastrar_Click(object sender, EventArgs e)
        {
            frm_cad_cargo objCadCargo = new frm_cad_cargo();
            objCadCargo.Show();
        }

        private void mnu_usu_cadastrar_Click(object sender, EventArgs e)
        {
            frm_cad_usuario objFrmCadUsuario = new frm_cad_usuario();
            objFrmCadUsuario.Show();
        }

        private void mnu_opcao_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnu_opcao_usuario_Click(object sender, EventArgs e)
        {
            frm_login objFrmLogin = new frm_login();
            objFrmLogin.Show();
            this.Hide();
        }

        private void mnu_cli_cadastrar_Click(object sender, EventArgs e)
        {
            frm_cad_cliente objCliente = new frm_cad_cliente();
            objCliente.Show();
            this.Hide();
        }

        private void mnu_usu_consultar_Click(object sender, EventArgs e)
        {
            frm_usuario_consulta objUsuarioConsulta = new frm_usuario_consulta();
            objUsuarioConsulta.Show();
        }

        private void mnu_principal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
