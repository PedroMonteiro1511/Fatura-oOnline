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

        /// <summary>
        /// 
        /// Guarda os dados do utilizador que faz login na aplicação
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="morada"></param>
        /// <param name="telefone"></param>
        /// <param name="Email"></param>
        public static void LoggedDetails(string nome, string morada, string telefone, string Email)
        { 
            App.Current.Properties["Nome"] = nome;
            App.Current.Properties["Morada"] = morada;
            App.Current.Properties["Telefone"] = telefone;
            App.Current.Properties["Email"] = Email;

            Logged = true;
        }


        /// <summary>
        /// 
        /// Destroi os dados do utilizador que faz logout da aplicação
        /// 
        /// </summary>
        public static void DetailsLogout()
        {
            App.Current.Properties["Nome"] = "";
            App.Current.Properties["Morada"] = "";
            App.Current.Properties["Telefone"] = "";
            App.Current.Properties["Email"] = "";

            Logged = false;
        }


        /// <summary>
        /// 
        ///  Verifica se existe algum utilizador com o login efetuado
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool IsLogged()
        {
            return Logged;
        }


        /// <summary>
        /// 
        /// Abre a janela de erros e manipula as mensagens de erro.
        /// 
        /// </summary>
        /// <param name="erro"></param>
        /// <param name="suberro"></param>
        public static void Erro(string erro, string suberro)
        {

            ErroMensagem em = new ErroMensagem();
            em.lblErro.Content = erro;
            em.lblSubErro.Content = suberro;
            em.ShowDialog();
        }
    }
}
