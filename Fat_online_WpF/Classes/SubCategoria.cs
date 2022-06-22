using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fat_online_WpF
{
    public class SubCategoria
    {
        public string Id { get; set; }
        public string idCategoria { get; set; }

        public string Nome { get; set; }


        public static string get_CategoriaMae(int id)
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            string Nome = "";

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT A.Nome FROM categorias A INNER JOIN subcategorias B ON A.id = B.id_categoria WHERE B.id =" + id;
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();

            while (Reader1.Read())
            {
                Nome = Reader1.GetString(0);
            }

            return Nome;
        }


        public static List<SubCategoria> getSubCategoriasWithCategoryID(int id)
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT A.* FROM subcategorias A INNER JOIN categorias B ON A.id_categoria = B.id WHERE B.id =" + id;
            // SELECIONAR TUDO DO A(subcategorias) , B(categorias) ONDE O A.id(id das subcategorias) É IGUAL AO B.id (id das categorias) ONDE O B.id = NUMERO INSERIDO
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();
            List<SubCategoria> subcat = new List<SubCategoria>();
            while (Reader1.Read())
            {
                SubCategoria subCategoria = new SubCategoria();
                subCategoria.Id = Reader1.GetInt32(0).ToString();
                subCategoria.idCategoria = Reader1.GetInt32(1).ToString();
                subCategoria.Nome = Reader1.GetString(2);

                subcat.Add(subCategoria);
            }

            return subcat;
        }



        public static string get_Subcategory_ID_With_Name(string name)
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            string ID = "";

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT id FROM subcategorias WHERE nome='" + name +"'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();
            if (Reader1.HasRows)
            {
                while (Reader1.Read())
                {
                    ID = Reader1.GetInt32(0).ToString();
                }
            }
            else
            {
                LoggedUser.Erro("ID Inválido", "O id da categoria é inválido");
                return null;
            }
            

            return ID;
        }

    }
}
