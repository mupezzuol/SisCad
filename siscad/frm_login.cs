using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siscad
{
    public partial class frm_login : Form
    {

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            frm_principal objFrmPrincipal = new frm_principal();
            frm_cad_funcionario objFrmFunc = new frm_cad_funcionario();
            string usuario;
            string senha;

            usuario = txt_usuario.Text;
            senha = txt_senha.Text;

            if (txt_usuario.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("Possui campo vaziu !");
            }
            else
            {
                Login objLogin = new Login(usuario, senha);

                objLogin = objLogin.loginVerificar(objLogin);


                if (objLogin.logado == 1)
                {
                    objFrmPrincipal.objlogin = objLogin;//mando objlogin do form receber o objlogin
                    objFrmFunc.objlogin = objLogin;//mando objlogin do form receber o objlogin

                    objFrmPrincipal.Show();//abro o form principal
                    this.Hide();//fecho form anterior
                }
                else {

                    MessageBox.Show("Usuário ou Senha inválido");
                }
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbl_data.Text = "Data: " + DateTime.Now.ToLongDateString() + " Hora: " + DateTime.Now.ToLongTimeString();
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_usuario.BackColor = Color.LightGreen;
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_senha.BackColor = Color.LightGreen;
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
