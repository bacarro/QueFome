using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QueFome
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String User = "admin";
            String Passaword = "admin";

            if (txtUsuario.Text == "" & txtSenha.Text == "")
            {
                epValidar.SetError(txtUsuario, "Favor informar o usúario!");
                epValidar.SetError(txtSenha, "Favor informar a senha!");
                MessageBox.Show("Campo usúario e senha está em branco!");
            }
            else if (txtUsuario.Text == "")
            {
                epValidar.SetError(txtUsuario, "Favor informar o usúario!");
                MessageBox.Show("Campo usúario está em branco!");
            }
            else if (txtSenha.Text == "")
            {
                epValidar.SetError(txtSenha, "Favor informar a Senha!");
                MessageBox.Show("Campo Senha está em branco!");
            }
            else if (txtUsuario.Text != User)
            {
                MessageBox.Show("Usúario incorreto!");
                epValidar.SetError(txtUsuario, "Usúario incorreto!");
            }
            else if (txtSenha.Text != Passaword)
            {
                MessageBox.Show("Senha incorreto!");
                epValidar.SetError(txtSenha, "Senha incorreto!");
            }
            else
            {
                MessageBox.Show("Logado");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void lblEsqueci_MouseEnter(object sender, EventArgs e)
        {
            lblEsqueci.ForeColor = Color.Red;
        }
        private void lblEsqueci_MouseLeave(object sender, EventArgs e)
        {
            lblEsqueci.ForeColor = Color.Gray;
        }

    }
}
