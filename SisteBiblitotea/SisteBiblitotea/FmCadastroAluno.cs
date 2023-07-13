using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisteBiblitotea
{
    public partial class FmCadastroAluno : Form
        
    {
        public string conexaostring;
        private SqlConnection conexaoDB;
        public FmCadastroAluno()
        {
            InitializeComponent();
            //steing de conexão
            conexaostring = "Data Source=MAR0625651W10-1;Initial Catalog=BIBLIOTECA;Integrated Security=True";
            //iniciazando a conexão com o banco de dados
            conexaoDB = new SqlConnection(conexaostring);

        }


        private void FmCadasrroAluno_Load(object sender, EventArgs e)
        {
            carregarDadosAluno();
            
        }
        private void carregarDadosAluno() 
        {
            try
            {
                conexaoDB.Open();
                string SqL = "SELECT * FROM Aluno";
                SqlDataAdapter adapter = new SqlDataAdapter(SqL, conexaoDB);
                DataTable  dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvalunos.DataSource= dataTable;

                conexaoDB.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao carregar os dados:" + ex);

            }

        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            try
            {
                String SqL = "INSERT INTO  Aluno(nome,cpf,email,telefone,celular,data_nascimento) VALUES(@nome,@cpf,@email,@telefone,@celular,@data_nascimento)";
                conexaoDB.Open();
                SqlCommand sqLCmd = new SqlCommand(SqL, conexaoDB);




                sqLCmd.Parameters.AddWithValue("@nome", txtnome.Text);

                sqLCmd.Parameters.AddWithValue("@cpf", txtcpf.Text);

                sqLCmd.Parameters.AddWithValue("@email", txtemail.Text);
                sqLCmd.Parameters.AddWithValue("@telefone", txttelefone.Text);
                sqLCmd.Parameters.AddWithValue("@celular", txtcelular.Text);
                DateTime datanascimento;

                DateTime.TryParse(txtdatanascimento.Text, out datanascimento);
                sqLCmd.Parameters.AddWithValue("@data_nascimento", datanascimento);
                sqLCmd.ExecuteNonQuery();

                MessageBox.Show("CADASTRO BEM SUCEDIDO");


                conexaoDB.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Inser os Dados :" + ex);
            }
        }
    }
}
