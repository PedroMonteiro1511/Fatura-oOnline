using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Fat_online_WpF
{
    public static class DBC
    {

        public static void OpenAndExecute(string query)
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


        /// <summary>
        /// 
        /// Verifica se não existe na base de dados um email igual ao email inserido no registo
        /// E emite um erro no caso de existir.
        /// 
        /// </summary>
        /// <param name="EmailInput"></param>
        /// <returns></returns>
        public static bool Get_Emails(string EmailInput)
        {
                string server = "localhost";
                string database = "fatonline";
                string username = "root";
                string password = "";
                int sucesso = 0;
                bool retorno = true;
                MySqlConnection con = new MySqlConnection("Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";");
                MySqlCommand cmd;
                MySqlDataReader Reader;
                con.Close();
                con.Open();
                cmd = new MySqlCommand("SELECT Email FROM users", con);
                Reader = cmd.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        if (EmailInput == Reader.GetString(0))
                        {
                            sucesso = 1;
                        }
                    }

                    if (sucesso == 0)
                    {
                        retorno = false;
                    }
                }

            return retorno;
        }
    }
}
