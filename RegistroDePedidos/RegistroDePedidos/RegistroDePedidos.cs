using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDePedidos
{
    public partial class FrmRegistroDePedidos : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;
        DataGridViewRow registroSelecionado;


        public FrmRegistroDePedidos()
        {
            InitializeComponent();
            conexaoString = "Data Source=MAR0625651W10-1;Initial Catalog=Biblioteca;Integrated Security=True";

        }
        private void FrmRegistroDePedidosLoad(object sender, EventArgs e)
        {

            btnExcluir.Enabled = false;
            btnAtualizar.Enabled = false;

           
            btnAdicionar.TabIndex = 1;
            btnAtualizar.TabIndex = 2;
            btnExcluir.TabIndex = 3;
            dgvRegistroDePedidos.TabIndex = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvRegistroDePedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistroDePedidosLoad(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvRegistroDePedidos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
