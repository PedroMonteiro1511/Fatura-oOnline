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
    /// Interação lógica para ListaMarcas.xam
    /// </summary>
    public partial class ListaMarcas : Page
    {
        public ListaMarcas()
        {
            InitializeComponent();
            LoadData();
        }


        /// <summary>
        /// 
        /// Método para preencher a tabela com todas as marcas 
        /// inseridas na base de dados.
        /// 
        /// </summary>
        public void LoadData()
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT * FROM marcas";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader = cmd.ExecuteReader();



            List<Marca> lista = new List<Marca>();

            while (Reader.Read())
            {

                Marca marca = new Marca();
                marca.ID = Reader.GetInt32(0).ToString();
                marca.Name = Reader.GetString(1);
                
                lista.Add(marca);
            }
            dataMarcas.Items.Clear();
            dataMarcas.ItemsSource = lista;
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
        private void dataMarcas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object item = dataMarcas.SelectedItem;
                string Nome = (dataMarcas.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                
                tbNome.Text = Nome;
        }
    }
}
