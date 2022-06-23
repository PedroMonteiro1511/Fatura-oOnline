using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fat_online_WpF
{
    public class Utilizador
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Morada { get; set; }
        public string Telefone { get; set; }

        public string Password { get; set; }

        public static List<Utilizador> getUsers()
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            List<Utilizador> utilizador = new List<Utilizador>();

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT * FROM `users`";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();

            while (Reader1.Read())
            {
                Utilizador user = new Utilizador();
                user.Id = Reader1.GetInt32(0).ToString();
                user.Name = Reader1.GetString(1);
                user.Email = Reader1.GetString(6);
                user.Morada = Reader1.GetString(2);
                user.Telefone = Reader1.GetString(3);
                utilizador.Add(user);
            }

            return utilizador;
        }

        public static int getUserThirtyDays()
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            int quantidade = 0;

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT * FROM users where created_at <= CURRENT_TIMESTAMP -30;";
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
