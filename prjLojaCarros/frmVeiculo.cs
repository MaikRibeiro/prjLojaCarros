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
    public partial class frmVeiculo : Form
    {
        public frmVeiculo()
        {
            InitializeComponent();
        }

        int registroAtual = 0;
        int totalRegistros = 0;
        bool novo;
        DataTable dtVeiculo = new DataTable();
        DataTable dtMarca = new DataTable();
        DataTable dtTipo = new DataTable();
        String connectionString = @"Server=Web-API-PW3.mssql.somee.com;Database=Web-API-PW3;User Id=GabrielGassner_SQLLogin_1;Password=312q5qzab9;";

        private void frmVeiculo_Load(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            txtCodVeiculo.Enabled = false;
            txtVeiculo.Enabled = false;
            txtAnoVeiculo.Enabled = false;
            cbbTipo.Enabled = false;
            cbbMarca.Enabled = false;
            string sql = "SELECT * FROM cad_veiculo";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                using (reader = cmd.ExecuteReader())
                {
                    dtVeiculo.Load(reader);
                    totalRegistros = dtVeiculo.Rows.Count;
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
        private void navegar()
        {
            carregaComboTipo();
            carregaComboMarca();
            txtCodVeiculo.Text = dtVeiculo.Rows[registroAtual][0].ToString();
            txtAnoVeiculo.Text = dtVeiculo.Rows[registroAtual][1].ToString();
            txtVeiculo.Text = dtVeiculo.Rows[registroAtual][2].ToString();
            cbbTipo.Text = dtVeiculo.Rows[registroAtual][3].ToString();
            cbbMarca.Text = dtVeiculo.Rows[registroAtual][4].ToString();
        }

        private void carregaTudoMarca()
        {
            dtMarca = new DataTable();
            string sql = "SELECT * from cad_marca";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                using (reader = cmd.ExecuteReader())
                {
                    dtMarca.Load(reader);
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
            cbbMarca.DataSource = dtMarca;
            cbbMarca.DisplayMember = "cmar_descricao";
            cbbMarca.ValueMember = "cmar_id";
        }

        private void carregaComboMarca()
        {
            dtMarca = new DataTable();
            string sql = "SELECT * from cad_marca WHERE cmar_id=" + dtVeiculo.Rows[registroAtual][4].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                using (reader = cmd.ExecuteReader())
                {
                    dtMarca.Load(reader);
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
            cbbMarca.DataSource = dtMarca;
            cbbMarca.DisplayMember = "cmar_descricao";
            cbbMarca.ValueMember = "cmar_id";

        } private void carregaTudoTipo()
        {
            dtTipo = new DataTable();
            string sql = "SELECT * from cad_tipo";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                using (reader = cmd.ExecuteReader())
                {
                    dtTipo.Load(reader);
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
            cbbTipo.DataSource = dtTipo;
            cbbTipo.DisplayMember = "ctip_descricao";
            cbbTipo.ValueMember = "ctip_id";
        }

        private void carregaComboTipo()
        {
            dtTipo = new DataTable();
            string sql = "SELECT * from cad_tipo WHERE ctip_id=" + dtVeiculo.Rows[registroAtual][3].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                using (reader = cmd.ExecuteReader())
                {
                    dtTipo.Load(reader);
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
            cbbTipo.DataSource = dtTipo;
            cbbTipo.DisplayMember = "ctip_descricao";
            cbbTipo.ValueMember = "ctip_id";
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            if (registroAtual > 0)
            {
                registroAtual = 0;
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

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (registroAtual < totalRegistros - 1)
            {
                registroAtual++;
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novo = true;
            txtCodVeiculo.Enabled = false;
            txtCodVeiculo.Clear();
            txtVeiculo.Enabled = true;
            txtVeiculo.Clear();
            txtAnoVeiculo.Enabled = true;
            txtAnoVeiculo.Clear();
            cbbTipo.Enabled = true;
            cbbTipo.SelectedIndex = -1;
            cbbMarca.Enabled = true;
            cbbMarca.SelectedIndex = -1;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnPrimeiro.Enabled = false;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnUltimo.Enabled = false;
            txtVeiculo.Focus();
            carregaTudoTipo();
            carregaTudoMarca();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            novo = false;
            txtVeiculo.Enabled = true;
            txtAnoVeiculo.Enabled = true;
            cbbTipo.Enabled = true;
            cbbMarca.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnAnterior.Enabled = false;
            btnPrimeiro.Enabled = false;
            btnProximo.Enabled = false;
            btnUltimo.Enabled = false;
            carregaTudoTipo();
            carregaTudoMarca();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                string sql = "INSERT INTO cad_veiculo (cvei_modelo, cvei_ano, cvei_cmar_id, cvei_ctip_id) VALUES('" + txtVeiculo.Text + "'," + txtAnoVeiculo.Text + ", " + cbbMarca.SelectedValue.ToString() + ", '" 
                   + cbbTipo.SelectedValue.ToString() + "')";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Veiculo cadastrado com sucesso!");
                        this.frmVeiculo_Load(this, e);
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
                txtVeiculo.Enabled = false;
                txtAnoVeiculo.Enabled = false;
                cbbTipo.Enabled = false;
                cbbMarca.Enabled = false;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnPrimeiro.Enabled = true;
                btnAnterior.Enabled = true;
                btnProximo.Enabled = true;
                btnUltimo.Enabled = true;
                dtVeiculo = new DataTable();
                frmVeiculo_Load(this, e);
            }
            else
            {
                string sql = "UPDATE cad_veiculo SET cvei_modelo='" +
                    txtVeiculo.Text + "', cvei_ano=" + txtAnoVeiculo.Text +
                    ", cvei_cmar_id=" + cbbMarca.SelectedValue.ToString() +
                    ", cvei_ctip_id='" + cbbTipo.SelectedValue.ToString() +
                    "' WHERE cvei_id=" +
                    txtCodVeiculo.Text;

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Veiculo alterado com sucesso!");
                        this.frmVeiculo_Load(this, e);
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
                txtVeiculo.Enabled = false;
                txtAnoVeiculo.Enabled = false;
                cbbTipo.Enabled = false;
                cbbMarca.Enabled = false;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnPrimeiro.Enabled = true;
                btnAnterior.Enabled = true;
                btnProximo.Enabled = true;
                btnUltimo.Enabled = true;
                dtVeiculo = new DataTable();
                frmVeiculo_Load(this, e);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Deseja excluir esse veiculo?", "Excluir Veiculo?", MessageBoxButtons.YesNo);
            if (confirma == DialogResult.Yes)
            {
                string sql = "DELETE FROM cad_veiculo WHERE cvei_id=" + txtCodVeiculo.Text;
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Veiculo deletado com sucesso!");
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
                cbbTipo.DataSource = dtTipo;
                cbbTipo.DisplayMember = "ctip_descricao";
                cbbTipo.ValueMember = "ctip_id";
                cbbMarca.DataSource = dtMarca;
                cbbMarca.DisplayMember = "cmar_descricao";
                cbbMarca.ValueMember = "cmar_id";

                btnSalvar.Enabled = false;
                txtVeiculo.Enabled = false;
                txtCodVeiculo.Enabled = false;
                txtAnoVeiculo.Enabled = false;
                cbbTipo.Enabled = false;
                cbbMarca.Enabled = true;
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
                btnPrimeiro.Enabled = true;
                btnAnterior.Enabled = true;
                btnProximo.Enabled = true;
                btnUltimo.Enabled = true;

                dtVeiculo = new DataTable();
                this.frmVeiculo_Load(this, e);
            }
        }

        private void carregar()
        {
            btnSalvar.Enabled = false;
            txtCodVeiculo.Enabled = false;
            txtVeiculo.Enabled = false;
            txtAnoVeiculo.Enabled = false;
            cbbTipo.Enabled = false;
            cbbMarca.Enabled = false;
            string sql = "SELECT * FROM cad_veiculo";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                using (reader = cmd.ExecuteReader())
                {
                    dtVeiculo.Load(reader);
                    totalRegistros = dtVeiculo.Rows.Count;
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
            dtVeiculo = new DataTable();
        }
    }
}
