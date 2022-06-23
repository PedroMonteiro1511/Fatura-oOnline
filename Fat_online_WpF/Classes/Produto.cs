using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fat_online_WpF
{
    public class Produto
    {

        public string Id { get; set; }
        public string Nome { get; set; }

        public string Referencia { get; set; }

        public string Descricao { get; set; }

        public string Marca { get; set; }

        public string Categoria { get; set; }

        public string SubCategoria { get; set; }

        public string Preco { get; set; }


        public static List<Produto> GetProdutos()
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            List<Produto> listaproduto = new List<Produto>();

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT * FROM `produtos`";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();

            while (Reader1.Read())
            {
                Produto produto = new Produto();
                produto.Id = Reader1.GetInt32(0).ToString();
                produto.Nome = Reader1.GetString(1);
                produto.Referencia = Reader1.GetString(2);
                produto.Descricao = Reader1.GetString(3);
                produto.Marca = Reader1.GetString(4);
                produto.Categoria = Reader1.GetString(5);
                produto.SubCategoria = Reader1.GetString(6);
                produto.Preco = Reader1.GetString(7);

                listaproduto.Add(produto);
            }

            return listaproduto;
        }

        public static List<Produto> GetProdutosByCategoria(int idCategoria)
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            List<Produto> listaproduto = new List<Produto>();

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT * FROM `produtos` WHERE categoria=" + idCategoria;
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();

            while (Reader1.Read())
            {
                Produto produto = new Produto();
                produto.Id = Reader1.GetInt32(0).ToString();
                produto.Nome = Reader1.GetString(1);
                produto.Referencia = Reader1.GetString(2);
                produto.Descricao = Reader1.GetString(3);
                produto.Marca = Reader1.GetString(4);
                produto.Categoria = Reader1.GetString(5);
                produto.SubCategoria = Reader1.GetString(6);
                produto.Preco = Reader1.GetString(7);

                listaproduto.Add(produto);
            }

            return listaproduto;
        }

        public static List<Produto> GetProdutosByCategoriaAndSubCategoria(int categoria, int subcategoria)
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            List<Produto> listaproduto = new List<Produto>();

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT * FROM `produtos` WHERE categoria=" + categoria + " AND subcategoria =" + subcategoria;
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();

            while (Reader1.Read())
            {
                Produto produto = new Produto();
                produto.Id = Reader1.GetInt32(0).ToString();
                produto.Nome = Reader1.GetString(1);
                produto.Referencia = Reader1.GetString(2);
                produto.Descricao = Reader1.GetString(3);
                produto.Marca = Reader1.GetString(4);
                produto.Categoria = Reader1.GetString(5);
                produto.SubCategoria = Reader1.GetString(6);
                produto.Preco = Reader1.GetString(7);

                listaproduto.Add(produto);
            }

            return listaproduto;
        }

        public static int getProdutosThirtyDays()
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            int quantidade = 0;

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT * FROM produtos where created_at <= CURRENT_TIMESTAMP -30;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();

            while (Reader1.Read())
            {
                quantidade += 1;
            }
            con.Close();
            return quantidade;

            
        }

    }
}
