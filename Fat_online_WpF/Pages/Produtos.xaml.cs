﻿using MySql.Data.MySqlClient;
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
using System.Text.RegularExpressions;

namespace Fat_online_WpF.Pages
{
    /// <summary>
    /// Interação lógica para Produtos.xam
    /// </summary>
    public partial class Produtos : Page
    {


        public Produtos()
        {
            InitializeComponent();
            LoadMarcas();
        }

        public void LoadMarcas()
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

            while (Reader.Read())
            {
                cbMarca.Items.Add(Reader.GetString(1));
            }
            Reader.Close();
            con.Close();
        }

        public void dbquery(string query)
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            MySqlCommand cm = new MySqlCommand(query, con);
            int value = cm.ExecuteNonQuery();
            if (value == 1)
            {
                MessageBox.Show("Sucesso");
            }
            con.Close();
        }

        

        private void inserirProduto_Click(object sender, RoutedEventArgs e)
        {
            int valida = 0;

            if (tbNome.Text == "")
            {
                valida += 1;
            }
            else if (tbReferencia.Text == "")
            {
                valida += 1;
            }
            else if (tbDesc.Text == "")
            {
                valida += 1;
            }
            else if (cbMarca.Text == "")
            {
                valida += 1;
            }
            else if (cbCategoria.Text == "")
            {
                valida += 1;
            }
            else if (cbSubCategoria.Text == "")
            {
                valida += 1;
            }
            else if (tbPreco.Text == "")
            {
                valida += 1;
            }

            if (valida == 0)
            {
                string query = "INSERT INTO `produtos`(`nome`, `referencia`, `descricao`, `marca`, `categoria`, `subcategoria`, `preco`) VALUES ('" + tbNome.Text + "','" + tbReferencia.Text + "','" + tbDesc.Text + "','" + cbMarca.Text + "','" + cbCategoria.Text + "','" + cbSubCategoria.Text + "', " + int.Parse(tbPreco.Text) + ")";
                dbquery(query);
            }
        }

        private void tbPreco_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
