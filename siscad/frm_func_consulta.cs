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
    public partial class frm_func_consulta : Form
    {
        public frm_func_consulta()
        {
            InitializeComponent();
        }



        private void frm_func_consulta_Load(object sender, EventArgs e)
        {
            listar();
        }

        public void listar()
        {

            Funcionario objFuncListar = new Funcionario();

            dgv_func.AutoGenerateColumns = false;

            string texto = txt_pesquisa.Text;
            texto = "%" + texto + "%";
            texto = texto.Replace(" ", "%");

            var lista = new BindingList<Funcionario>(objFuncListar.listar(texto));
            dgv_func.DataSource = lista;

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            frm_func_alt objFrmFuncAlt = new frm_func_alt();
           
            objFrmFuncAlt.idfuncionario = Convert.ToInt32(dgv_func.CurrentRow.Cells[0].Value);
            objFrmFuncAlt.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void dgv_func_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
