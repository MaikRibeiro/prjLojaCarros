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

namespace prjLojaCarros
{
    public partial class frmTipo : Form
    {
        int registroAtual = 0;
        int totalRegistros = 0;
        DataTable dtLoja = new DataTable();
        String connectionString = @"Server=prometheus.mssql.somee.com ;Database=prometheus;User Id=Maik_Ribeiro_SQLLogin_1;Password=4fqncedyef;";
        public frmTipo()
        {
            InitializeComponent();
        }
        private void navegar()
        {
            txtCodTipo.Text = dtLoja.Rows[registroAtual][0].ToString();
            txtTipo.Text = dtLoja.Rows[registroAtual][1].ToString();
        }

        private void carregar()
        {
            dtLoja = new DataTable();
            string sql = "SELECT * FROM cad_tipo";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                using (reader = cmd.ExecuteReader())
                {
                    dtLoja.Load(reader);
                    totalRegistros = dtLoja.Rows.Count;
                    registroAtual = 0;
                    navegar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void frmTipo_Load(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            txtCodTipo.Enabled = false;
            txtTipo.Enabled = false;
            string sql = "SELECT * FROM cad_tipo";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                using (reader = cmd.ExecuteReader())
                {
                    dtLoja.Load(reader);
                    totalRegistros = dtLoja.Rows.Count;
                    registroAtual = 0;
                    navegar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            txtCodTipo.Enabled = false;
            txtTipo.Enabled = true;
            txtTipo.Text = "";
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnPrimeiro.Enabled = false;
            btnUltimo.Enabled = false;
            btnCancelar.Enabled = true;
            btnCancelar.Visible = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO cad_tipo (ctip_descricao) " +
                         "VALUES " +
                         "('" + txtTipo.Text + "')";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Tipo cadastrado com sucesso");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar tipo: " + ex);

            }
            finally
            {
                conn.Close();
            }

            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            txtCodTipo.Enabled = false;
            txtTipo.Enabled = false;
            btnCancelar.Enabled = false;
            btnCancelar.Visible = false;
            btnAtualizar.Enabled = false;
            btnAtualizar.Visible = false;
            btnPrimeiro.Enabled = true;
            btnUltimo.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            carregar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            txtCodTipo.Enabled = false;
            txtTipo.Enabled = true;
            btnAtualizar.Enabled = true;
            btnAtualizar.Visible = true;
            btnCancelar.Enabled = true;
            btnCancelar.Visible = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnPrimeiro.Enabled = false;
            btnUltimo.Enabled = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE cad_tipo SET ctip_descricao = ('" + txtTipo.Text + "') WHERE ctip_id = " + txtCodTipo.Text;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Tipo atualizado com sucesso");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao atualizar tipo: " + ex);

            }
            finally
            {
                conn.Close();
            }

            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            txtCodTipo.Enabled = false;
            txtTipo.Enabled = false;
            btnCancelar.Enabled = false;
            btnCancelar.Visible = false;
            btnAtualizar.Enabled = false;
            btnAtualizar.Visible = false;
            btnPrimeiro.Enabled = true;
            btnUltimo.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            carregar();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (registroAtual < totalRegistros - 1)
            {
                registroAtual++;
                navegar();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (registroAtual > 0)
            {
                registroAtual--;
                navegar();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (registroAtual < totalRegistros - 1)
            {
                registroAtual = totalRegistros - 1;
                navegar();
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            if (registroAtual > 0)
            {
                registroAtual = 0;
                navegar();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Deseja excluir essa tipo?", "Excluir Tipo?", MessageBoxButtons.YesNo);
            if (confirma == DialogResult.Yes)
            {
                string sql = "DELETE FROM cad_tipo WHERE ctip_id = " + txtCodTipo.Text;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Tipo deletado com sucesso");
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao deletar tipo: " + ex);

                }
                finally
                {
                    conn.Close();
                }
                carregar();
            }
            else
            {
                carregar();
            }


            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            txtCodTipo.Enabled = false;
            txtTipo.Enabled = false;
            btnAtualizar.Enabled = false;
            btnAtualizar.Visible = false;
            carregar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            txtCodTipo.Enabled = false;
            txtTipo.Enabled = false;
            btnAtualizar.Enabled = false;
            btnAtualizar.Visible = false;
            btnCancelar.Enabled = false;
            btnCancelar.Visible = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnPrimeiro.Enabled = true;
            btnUltimo.Enabled = true;
        }
    }
}
