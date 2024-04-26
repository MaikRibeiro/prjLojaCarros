using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjLojaCarros
{
    public partial class frmLogin : Form
    {
        public bool LoginSuccessful { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
            LoginSuccessful = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            efetuarLogin();
        }

        private void efetuarLogin()
        {
            string usuario = txtUser.Text;
            string senha = txtPass.Text;

            string connectionString = @"Server=prometheus.mssql.somee.com ;Database=prometheus;User Id=Maik_Ribeiro_SQLLogin_1;Password=4fqncedyef;";
            string query = "SELECT COUNT(1) FROM tab_usuarios WHERE tusu_user = @Usuario AND tusu_pass = @Senha";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    conexao.Open();

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        LoginSuccessful = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos.");
                        txtUser.Clear();
                        txtPass.Clear();
                        txtUser.Focus();
                    }
                }
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                efetuarLogin();
                e.SuppressKeyPress = true;
            }
        }
    }
}
