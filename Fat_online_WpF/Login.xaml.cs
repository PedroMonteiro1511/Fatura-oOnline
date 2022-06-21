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
        int tentativas = 3;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLoginVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                // Ligar a COnexão a base de dados
                //Inicializar as variaveis com os dados
                string server = "localhost";
                string database = "fatonline";
                string username = "root";
                string password = "";
                // Fazer a conexão
                MySqlConnection con = new MySqlConnection("Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";");
                MySqlCommand cmd;
                MySqlDataReader Reader;

                //Variável sucesso é usada para testar os campos do login
                int sucesso = 0;
                

                //Abrir a ligação
                con.Close();
                con.Open();

                //Comando SQL a executar
                cmd = new MySqlCommand("SELECT * FROM users WHERE Email ='" + tbNome.Text + "'", con);
                Reader = cmd.ExecuteReader();

                //Se houver resultados então entra no if
                if (Reader.HasRows)
                {

                    //E começa um loop com todos os resultados, em principio deve haver somente 1 resultado
                    while (Reader.Read())
                    {

                        // String com passwordHash do utilizador
                        string passwordHash = Reader.GetString(4);

                        //Verificar se a password inserida corresponde á passwordHash
                        if (PasswordHashCheck.Verify(tbPassword.Password.ToString(), passwordHash) == true)
                        {

                            //Guarda os dados do utilizador que faz login.
                            LoggedUser.LoggedDetails(Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(6));

                            //Caso tudo esteja correto, sucesso fica com valor 1
                            sucesso += 1;
                        }
                    }


                    //Com sucesso a valor 1 , abre o novo formulário
                    if (sucesso == 1)
                    {
                        MainWindow mw = new MainWindow();
                        this.Close();
                        mw.ShowDialog();
                        
                    }
                }
                //Caso não haja resultados os dados estão incorretos ou o utilizador não existe
                else
                {
                    // Remover uma tentativa, o Utilizador tem 3
                    tentativas--;
                    //Abrir a janela de erro a informar as tentativas restantes
                    LoggedUser.Erro("Login Inválido", "Email ou Password incorretos, por favor tente novamente. \n \n \n Tentativas restantes: " + tentativas );
                    con.Close();
                    
                    //Se as tentativas chegarem ao fim , o formulário é fechado.
                    if (tentativas == 0)
                    {
                        LoggedUser.Erro("Segurança", "Excedeu o limite de tentativas \n  \n Por favor tente mais tarde.");
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
