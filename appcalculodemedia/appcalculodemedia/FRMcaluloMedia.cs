using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appcalculodemedia
{
    public partial class frmmedia : Form
    {
        public frmmedia()
        {
            InitializeComponent();
        }


        private void BtnCalular_Click(object sender, EventArgs e)
        {
           if(TxtNota1.Text == "" || TxtNota2.Text == ""|| TxtNota3.Text == "" || TxtNota4.Text == "")
            {
                MessageBox.Show("Por fovor , preencha todas as notas","Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            double nota1 = Convert.ToDouble(TxtNota1.Text);
            double nota2 = Convert.ToDouble(TxtNota2.Text);
            double nota3 = Convert.ToDouble(TxtNota3.Text);
            double nota4 = Convert.ToDouble(TxtNota4.Text);
            double resultdo = (nota1 + nota2 + nota3 + nota4 ) / 4;
            LblResultadoMedia.Text=resultdo.ToString();
            if( resultdo >= 7 ) {
                lblSituacao.Text = "aprovado";
                lblSituacao.ForeColor = Color.Red;
            }
            else {
                lblSituacao.Text = "reaprovado";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmmedia_Load(object sender, EventArgs e)
        {

        }
    }
}
