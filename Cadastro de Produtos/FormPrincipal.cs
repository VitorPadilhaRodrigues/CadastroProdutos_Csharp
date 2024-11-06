namespace Cadastro_de_Produtos
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;
    public partial class FormPrincipal : Form
    {
        Database db = new Database();
        public FormPrincipal()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            db.OpenConnection();
            string query = "SELECT * FROM Produto";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvProdutos.DataSource = table;
            db.CloseConnection();
        }

        // Botão Adcionar Produto
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            if (formCadastro.ShowDialog() == DialogResult.OK)
            {
                LoadData(); // Recarrega os dados após adicionar
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["Id"].Value);
                string nome = dgvProdutos.SelectedRows[0].Cells["Nome"].Value.ToString();
                decimal preco = Convert.ToDecimal(dgvProdutos.SelectedRows[0].Cells["Preco"].Value);

                FormCadastro formCadastro = new FormCadastro(id, nome, preco);
                if (formCadastro.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); // Recarrega os dados após atualizar
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para editar.");
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["Id"].Value);
                db.OpenConnection();
                string query = "DELETE FROM Produto WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                LoadData(); // Recarrega os dados após excluir
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.");
            }
        }
    }
}

