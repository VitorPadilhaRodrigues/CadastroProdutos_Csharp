using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Cadastro_de_Produtos
{
    public partial class FormCadastro : Form
    {

        private int? productId = null;
        Database db = new Database();
        public FormCadastro()
        {
            InitializeComponent();
        }

        public FormCadastro(int id, string nome, decimal preco)
        {
            InitializeComponent();
            productId = id;
            txtNome.Text = nome;
            txtPreco.Text = preco.ToString();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal preco = Convert.ToDecimal(txtPreco.Text);

            db.OpenConnection();
            string query;

            if (productId == null) // Inserção
            {
                query = "INSERT INTO Produto (Nome, Preco) VALUES (@nome, @preco)";
            }
            else // Atualização
            {
                query = "UPDATE Produto SET Nome = @nome, Preco = @preco WHERE Id = @id";
            }

            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@preco", preco);

            if (productId != null)
            {
                cmd.Parameters.AddWithValue("@id", productId);
            }

            cmd.ExecuteNonQuery();
            db.CloseConnection();
            DialogResult = DialogResult.OK; // Fecha o formulário
        }
    }
}
