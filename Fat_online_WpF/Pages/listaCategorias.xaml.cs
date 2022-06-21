using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    /// Interação lógica para listaCategorias.xam
    /// </summary>
    public partial class listaCategorias : Page
    {
        public listaCategorias()
        {
            InitializeComponent();
            LoadData();
        }


        /// <summary>
        /// 
        /// Método para preencher os dados da tabela com todas as Categorias inseridas 
        /// Na base de dados
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
            string sql = "SELECT * FROM categorias";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader = cmd.ExecuteReader();



            List<Categorias> lista = new List<Categorias>();
            
            while (Reader.Read())
            {

                Categorias categorias = new Categorias();
                categorias.ID = Reader.GetInt32(0).ToString();
                categorias.Name = Reader.GetString(1);
                lista.Add(categorias);
            }
            dataCategorias.Items.Clear();
            dataCategorias.ItemsSource = lista;
            Reader.Close();
            con.Close();
        }


        /// <summary>
        /// 
        /// Ao alterar a seleção do item da dataGrid, os dados da categoria selecionada
        /// São enviados para as textboxes para poder alterar os dados das categorias.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataCategorias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                object item = dataCategorias.SelectedItem; //probably you find this object
                string ID = (dataCategorias.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                string Nome = (dataCategorias.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                
                tbNome.Text = Nome;
             
        }
    }
}
