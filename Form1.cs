using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace tcc
{
    public partial class Login : Form
    {
        OleDbConnection conexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Usuario\Lucas Dropbox\tcc\banco_administrador.mdb");
        public Login()
        {
            InitializeComponent();
            //txtlogin.Select();
        }

        //botão entrar
        private void btnentrar_Click(object sender, EventArgs e)
        {
            conexao.Open(); //abrir a conexão
            string query = "SELECT * FROM banco_administrador WHERE Nome = '" + txtlogin.Text + "' AND Senha = '" + txtsenha.Text + "'";
            OleDbDataAdapter salvar = new OleDbDataAdapter(query, conexao);
            DataTable dt = new DataTable();
            salvar.Fill(dt);

            conexao.Close();
            if (dt.Rows.Count == 1)
            {
                Cadastro_Falecido cadastro_Falecido = new Cadastro_Falecido();
                this.Hide();
                cadastro_Falecido.Show();

               conexao.Close();
            }
            //conexao.Close();
            else
            {
                MessageBox.Show("Login ou Senha incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogin.Text = "";//Limpar as textbox depois de serem verificados de texto
                txtsenha.Text = "";
                //txtlogin.Select();
            }
            conexao.Close();
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            Cadastro_usuario novaform = new Cadastro_usuario();
            novaform.Show();
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            consulta_falecido novaform = new consulta_falecido();
            novaform.Show();
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
