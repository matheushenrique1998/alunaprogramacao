using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        private List<Usuario> usuarios;

        public Form1()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();


            usuarios.Add(new Usuario("vitor@gmail.com", "246810"));
            usuarios.Add(new Usuario("lucas@gmail.com", "150804"));
            usuarios.Add(new Usuario("bruno@gmail.com", "98765"));
            usuarios.Add(new Usuario("matheus@gmail.com", "147258"));
            usuarios.Add(new Usuario("thiago@gmail.com", "789456"));
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string email = TxtCampoEmail.Text;
            string senha = TxtCampoSenha.Text;

            if (ValidarCredenciais(email, senha))
            {
                MessageBox.Show("Login bem-sucedido!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("email ou senha incorretos!");
            }
        }

        private bool ValidarCredenciais(string email, string senha)
        {
            return usuarios.Any(u => u.email == email && u.Senha == senha);
        }

        private void LimparCampos()
        {
            TxtCampoEmail.Text = string.Empty;
            TxtCampoSenha.Text = string.Empty;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConfirmar_Click_1(object sender, EventArgs e)
        {

        }
    }

    public class Usuario
    {
        public string email { get; set; }
        public string Senha { get; set; }

        public Usuario(string Email, string senha)
        {
            email = Email;
            Senha = senha;
        }
    }
}