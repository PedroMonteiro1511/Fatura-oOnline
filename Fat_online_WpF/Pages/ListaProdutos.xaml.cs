using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fat_online_WpF.Pages
{
    /// <summary>
    /// Interação lógica para ListaProdutos.xam
    /// </summary>
    public partial class ListaProdutos : Page
    {
        public ListaProdutos()
        {
            InitializeComponent();
            LoadData();
        }

        /// <summary>
        /// 
        /// Método para preencher a tabela com todos os produtos
        /// inseridos na base de dados.
        /// 
        /// </summary>
        private void LoadData()
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT * FROM produtos";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader = cmd.ExecuteReader();

            

            List<Produto> lista = new List<Produto>();

            while (Reader.Read())
            {

                Produto produto = new Produto();
                produto.Id = Reader.GetInt32(0).ToString();
                produto.Nome = Reader.GetString(1);
                produto.Referencia = Reader.GetString(2);
                produto.Descricao = Reader.GetString(3);
                produto.Marca = Reader.GetString(4);
                produto.Categoria = Reader.GetString(5);
                produto.SubCategoria = Reader.GetString(6);
                produto.Preco = Reader.GetInt32(7).ToString();
                lista.Add(produto);
            }
            dataProdutos.Items.Clear();
            dataProdutos.ItemsSource = lista;
            Reader.Close();
            con.Close();
        }


        /// <summary>
        /// 
        /// Ao alterar o item selecionado, os dados desse mesmo item são
        /// enviados para as textboxes para poderem ser alterados. 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataProdutos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
                object item = dataProdutos.SelectedItem; //probably you find this object
                string ID = (dataProdutos.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                string Nome = (dataProdutos.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                string Referencia = (dataProdutos.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                string Descricao = (dataProdutos.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                string Marca = (dataProdutos.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                string Categoria = (dataProdutos.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                string SubCategoria = (dataProdutos.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
                string Preco = (dataProdutos.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text;
                tbNome.Text = Nome;
                tbReferencia.Text = Referencia;
                tbDescricao.Text = Descricao;
                tbMarca.Text = Marca;
                tbCategoria.Text = Categoria;
                tbSubCategoria.Text = SubCategoria;
                tbPreco.Text = Preco;
            
        }
    }
}
