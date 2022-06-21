using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica interna para Registo.xaml
    /// </summary>
    public partial class Registo : Window
    {
        public Registo()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login lg = new Login();
            this.Close();
            lg.ShowDialog();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            int valida = 0;
            string erros = "";

            //Testar se todas as TextBox têm conteudo para não inserir Dados em branco na base de dados
            if (tbNome.Text == "")
            {
                erros += "Preencher o nome \n";
                valida += 1;
            }
            if (tbPassword.Password.ToString() == "")
            {
                erros += "Insira uma Password \n";
                valida += 1;
            }
            if (tbEmail.Text == "")
            {
                erros += "Insira um Email \n";
                valida += 1;
            }
            if (!Regex.IsMatch(tbEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                erros += "Insira um Email com formato válido (exemplo: teste@outlook.pt) \n";
                valida += 1;
            }
            if (DBC.Get_Emails(tbEmail.Text))
            {
                erros += "O email inserido já está em uso \n";
                valida += 1;
            }
            if (tbMorada.Text == "")
            {
                erros += "Insira uma Morada \n";
                valida += 1;
            }
            if (tbTelefone.Text == "")
            {
                erros += "Insira um Numero de Telefone \n";
                valida += 1;
            }

            //Caso nenhuma TextBox passe texto nulo, Pode começar a construir a query
            if (valida == 0)
            {
                
                // Hash Password para mais segurança
                var password = PasswordHashCheck.Hash(tbPassword.Password.ToString());

                //Construir a query para inserir os dados na base de dados
                string query = "INSERT INTO `users`(`nome`, `Email`,`Morada`,`Telefone`,`Password`) VALUES ('" + tbNome.Text + "','" + tbEmail.Text + "','" + tbMorada.Text + "','" + tbTelefone.Text + "','" + password + "')";

                //Metodo que faz a conexão e inserção dos dados
                DBC.OpenAndExecute(query);
            }
            else
            {
                LoggedUser.Erro("Campos Inválidos", erros);
            }
        }

        private void tbTelefone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
