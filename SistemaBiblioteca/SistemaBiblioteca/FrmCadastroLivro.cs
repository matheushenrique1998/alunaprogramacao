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

namespace SistemaBiblioteca
{
    public partial class FrmCadastroLivro : Form
    {
       
        
        public string conexaoString;
        private SqlConnection conexaoDB;
        DataGridViewRow registroSelecionado;
        public FrmCadastroLivro()


        {
            InitializeComponent();

            //String de conexão
            conexaoString = "Data Source=MAR0625651W10-1;Initial Catalog=Biblioteca;Integrated Security=True";

            //Inicializando a conexão com o Banco de dados
            conexaoDB = new SqlConnection(conexaoString);
        }



        private void FrmCadastroLIVRO_Load(object sender, EventArgs e)
        {

            btnExcluir.Enabled = false;
            btnAtualizar.Enabled = false;

            txtISBN.TabIndex = 0;
            txtAnoPublicacao.TabIndex = 1;
            txtTitulo.TabIndex = 2;
            txtAutor.TabIndex = 3;
            txtPreco.TabIndex = 4;
            txtNumeroPagina.TabIndex = 5;
            btnAdicionar.TabIndex = 6;
            btnAtualizar.TabIndex = 7;
            btnExcluir.TabIndex = 8;
            txtPesquisar.TabIndex = 9;
            btnPesquisar.TabIndex = 10;
            dgvLivro.TabIndex = 11;
            carregarDadosLivro();

        }
        private void carregarDadosLivro(int id = 0)
        {
            try
            {
                conexaoDB.Open();
                string sql;
                if (id == 0)
                {

                    sql = "SELECT * FROM livros";
                }
                else
                {
                    sql = "SELECT * FROM livros WHERE id=" + id;

                }




                SqlDataAdapter adpater = new SqlDataAdapter(sql, conexaoDB);
                DataTable dataTable = new DataTable();
                adpater.Fill(dataTable);

                dataTable.Columns["id"].ColumnName = "ID";
                dataTable.Columns["titulo"].ColumnName = "Titulo";
                dataTable.Columns["numeropagina"].ColumnName = "NumeroPagina";
                dataTable.Columns["preco"].ColumnName = "Preco";
                dataTable.Columns["anopublicacao"].ColumnName = "AnoPublicacao";
                dataTable.Columns["isbn"].ColumnName = "ISBN";
                dataTable.Columns["autor"].ColumnName = "Autor";


                dgvLivro.DataSource = dataTable;


                conexaoDB.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO livros (titulo,numeroPagina,Preco,anopublicacao,isbn) VALUES (@Titulo,@NumeroPagina,@preco,@AnoPublicacao,@ISBN)";

                conexaoDB.Open();

                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                sqlCmd.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                sqlCmd.Parameters.AddWithValue("@NumeroPagina",Convert.ToInt32( txtNumeroPagina.Text));
                sqlCmd.Parameters.AddWithValue("@Preco", Convert.ToInt32(txtPreco.Text));
                sqlCmd.Parameters.AddWithValue("@AnoPublicacao", Convert.ToInt32(txtAnoPublicacao.Text));
                sqlCmd.Parameters.AddWithValue("@ISBN", Convert.ToInt32(txtISBN.Text));
                sqlCmd.Parameters.AddWithValue("@Autor", txtAutor.Text);




                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro Realizado com Sucesso!!!");

                conexaoDB.Close();

                carregarDadosLivro();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Inserir os Dados: " + ex);
            }


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO  livros (titulo,numeropagina,preco,anopublicacao,isbn) VALUES (@Titulo,@NumeroPagina,@Preco,@AnoPublicacao,@ISBN)";

                conexaoDB.Open();

                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                sqlCmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                sqlCmd.Parameters.AddWithValue("@NumeroPagina", txtNumeroPagina.Text);
                sqlCmd.Parameters.AddWithValue("@Preco", txtPreco.Text);
                sqlCmd.Parameters.AddWithValue("@AnoPublicacao", txtAnoPublicacao.Text);
                sqlCmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);



                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro Realizado com Sucesso!!!");

                conexaoDB.Close();

                carregarDadosLivro();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Inserir os Dados: " + ex);
            }


        }

       

    }
}
