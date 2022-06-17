using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interação lógica para NovoUser.xam
    /// </summary>
    public partial class NovoUser : Page
    {
        public NovoUser()
        {
            InitializeComponent();
        }

        private void inserirUser_Click(object sender, RoutedEventArgs e)
        {
            int valida = 0;

            //Testar se todas as TextBox têm conteudo para não inserir Dados em branco na base de dados
            if (tbNome.Text == "")
            {
                valida += 1;
            }
            if (tbEmail.Text == "")
            {
                valida += 1;
            }
            if (tbMorada.Text == "")
            {
                valida += 1;
            }
            if (tbTelefone.Text == "")
            {
                valida += 1;
            }

            //Caso nenhuma TextBox passe texto nulo, Pode começar a construir a query
            if (valida == 0)
            {

                // Hash Password para mais segurança
                var password = PasswordHashCheck.Hash(tbPassword.Text);
                
                //Construir a query para inserir os dados na base de dados
                string query = "INSERT INTO `users`(`nome`, `Email`,`Morada`,`Telefone`,`Password`) VALUES ('" + tbNome.Text + "','" + tbEmail.Text + "','" + tbMorada.Text + "','" + tbTelefone.Text + "','" + password + "')";

                //Metodo que faz a conexão e inserção dos dados
                DBC.OpenAndExecute(query);
            }
        }
    }
}
