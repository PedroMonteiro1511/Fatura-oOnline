using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fat_online_WpF
{
    public class LoggedUser
    {
        public static bool Logged;

        public static void LoggedDetails(string nome, string morada, string telefone, string Email)
        {
            App.Current.Properties["Nome"] = nome;
            App.Current.Properties["Morada"] = morada;
            App.Current.Properties["Telefone"] = telefone;
            App.Current.Properties["Email"] = Email;

            Logged = true;
        }



        public static void DetailsLogout()
        {
            App.Current.Properties["Nome"] = "";
            App.Current.Properties["Morada"] = "";
            App.Current.Properties["Telefone"] = "";
            App.Current.Properties["Email"] = "";

            Logged = false;
        }

        public static bool IsLogged()
        {
            return Logged;
        }


    }
}
