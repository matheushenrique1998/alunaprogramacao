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

namespace RegistroDosPedidos
{
    public partial class Form1 : Form
    {
        public string conexaostring;
        private SqlConnection conexaoDB;
        DataGridViewRow regidtroSelecionado;
        public Form1()
        {

            InitializeComponent();

            conexaostring = "Data Source=MAR0625651W10-1;Initial Catalog=Biblioteca;Integrated Security=True";
            conexaoDB = new SqlConnection(conexaostring);
        
    }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            btnAtualizar.Enabled = false;
           btnAdicionar.TabIndex = 1;
            btnAtualizar.TabIndex = 2;
            btnExcluir.TabIndex = 3;
            txtCodProduto.TabIndex = 4;
            btnPesquisar.TabIndex = 5;
            dgvPedidos.TabIndex = 6;
        }

       

        private void btnadicionar_Click(object sender, EventArgs e)
        {

        }
    }
}
