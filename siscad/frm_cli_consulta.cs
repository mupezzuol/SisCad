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
    public partial class frm_cli_consulta : Form
    {
        public frm_cli_consulta()
        {
            InitializeComponent();
        }
        public void listar()
        {

            Cliente objCliListar = new Cliente();

            dgv_cli.AutoGenerateColumns = false;

            string texto = txt_pesquisa.Text;
            texto = "%" + texto + "%";
            texto = texto.Replace(" ", "%");

            var lista = new BindingList<Cliente>(objCliListar.listar(texto));
            dgv_cli.DataSource = lista;

        }
        private void frm_cli_consulta_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void dgv_cli_MouseClick(object sender, MouseEventArgs e)
        {
            frm_cli_alt objFrmCliAlt = new frm_cli_alt();

            objFrmCliAlt.idcliente = Convert.ToInt32(dgv_cli.CurrentRow.Cells[0].Value);
            objFrmCliAlt.ShowDialog();
        }
    }
}
