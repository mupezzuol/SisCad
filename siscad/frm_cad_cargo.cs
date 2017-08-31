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
    public partial class frm_cad_cargo : Form
    {
        public frm_cad_cargo()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            // Atributos + campos da interface
            string cargo = txt_cargo.Text;

            // Estancio obj com parametros, somento com ID
           

        // Estancio obj com pametros dos valores da interface
        Cargo objCargoCadastro = new Cargo(cargo);

            //chamar o metodo inserir da classe Funcionario
            if (objCargoCadastro.inserirCargo(objCargoCadastro) == true)
            {

                MessageBox.Show("Cadastro efetuado com Sucesso!");
            }
            else {

                MessageBox.Show("Ops!, ocorreu um erro!");
            }
        }

        private void txt_cargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_cargo.BackColor = Color.LightGreen;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_cargo.Text = "";
            txt_cargo.BackColor = Color.White;
        }
    }
}
