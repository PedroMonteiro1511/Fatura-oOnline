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
using System.Windows.Shapes;

namespace Fat_online_WpF
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLoginVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader Reader = cmd.ExecuteReader();

            List<Utilizador> lista = new List<Utilizador>();



            while (Reader.Read())
            {
                Utilizador utilizador = new Utilizador();
                utilizador.Id = Reader.GetInt32(0).ToString();
                utilizador.Name = Reader.GetString(1);
                utilizador.Email = Reader.GetString(6);
                utilizador.Morada = Reader.GetString(2);
                utilizador.Telefone = Reader.GetString(3);
                utilizador.Password = Reader.GetString(4);
                MessageBox.Show("Id:" + utilizador.Id + " Email:" + utilizador.Email);
                lista.Add(utilizador);
            }
            
            Reader.Close();
            con.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string server = "localhost";
                string database = "fatonline";
                string username = "root";
                string password = "";
                MySqlConnection con = new MySqlConnection("Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";");
                MySqlCommand cmd;
                MySqlDataAdapter da;
                MySqlDataReader Reader;
                int tentativas = 3;
                int sucesso = 0;
                con.Close();
                con.Open();
                cmd = new MySqlCommand("SELECT * FROM users WHERE Email ='" + tbNome.Text + "'", con);
                Reader = cmd.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        LoggedUser.LoggedDetails(Reader.GetString(1),Reader.GetString(2),Reader.GetString(3),Reader.GetString(6));
                        string passwordHash = Reader.GetString(4);
                        if (PasswordHashCheck.Verify(tbPassword.Password.ToString(), passwordHash) == true)
                        {
                            sucesso += 1;
                        }
                    }

                    if (sucesso == 1)
                    {
                        MessageBox.Show("Bem Vindo");
                        MainWindow mw = new MainWindow();
                        this.Close();
                        mw.ShowDialog();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Login Inválido");
                    con.Close();
                    tentativas -= 1;
                    if (tentativas == 0)
                    {
                        MessageBox.Show("Excedeu o limite de tentativas, por favor tente mais tarde.");
                        this.Close();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Registo rgt = new Registo();
            this.Close();
            rgt.ShowDialog();
        }
    }
}
