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

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
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
                    }
                }
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
