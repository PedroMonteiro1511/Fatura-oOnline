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
    /// Lógica interna para NovaVenda.xaml
    /// </summary>
    public partial class NovaVenda : Window
    {
        public NovaVenda()
        {
            InitializeComponent();

            Categorias[] cat = Categorias.getAllCategorias().ToArray();
            Categoria.ItemsSource = cat;
            Categoria.DisplayMemberPath = "Name";


            Produto[] products = Produto.GetProdutos().ToArray();

                foreach (Produto produto in products)
                {
                    ListViewProducts.Items.Add(produto);
                }
            
               
            
            Utilizador[] nome = Utilizador.getUsers().ToArray();
            cbUsers.ItemsSource = nome;
            cbUsers.DisplayMemberPath = "Name";
        }



        private void cbUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var user = new Utilizador() ;
            detalhesUtilizador.Visibility = Visibility.Visible;
            user = (cbUsers.SelectedItem as Utilizador);
            tbNome.Text = user.Name;
            tbMorada.Text = user.Morada;
            tbTelefone.Text = user.Telefone;
            tbEmail.Text = user.Email;
        }

        private void btnLista_Click(object sender, RoutedEventArgs e)
        {
            var boundData = (Produto)((Button)sender).DataContext;

            LoggedUser.Erro(boundData.Nome, boundData.Preco);
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MaxBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                if (WindowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                }
            }
        }

        private void ListViewProducts_Loaded(object sender, RoutedEventArgs e)
        {
            Size x = new Size(double.PositiveInfinity, double.PositiveInfinity);
            ListViewProducts.Measure(x);
        }

        private void Categoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            var categoria = new Categorias();
            categoria = (Categoria.SelectedItem as Categorias);

            if (Categoria.SelectedItem.ToString() != "")
            {
                cbSubCategoria.IsReadOnly = false;
                var Novacategoria = new Categorias();
                Novacategoria = (Categoria.SelectedItem as Categorias);
                SubCategoria[] subcat = SubCategoria.getSubCategoriasWithCategoryID(Convert.ToInt32(Novacategoria.ID)).ToArray();
                cbSubCategoria.ItemsSource = subcat;
                cbSubCategoria.DisplayMemberPath = "Nome";
            }

            cbSubCategoria.SelectedIndex = -1;

            Produto[] produtos = Produto.GetProdutosByCategoria(Convert.ToInt32(categoria.ID)).ToArray();
            ListViewProducts.Items.Clear();
            foreach (Produto produto in produtos)
            {
                ListViewProducts.Items.Add(produto);
            }

            
        }

        private void cbSubCategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbSubCategoria.SelectedIndex != -1)
            {
                var categoria = new Categorias();
                var subcategoria = new SubCategoria();
                categoria = (Categoria.SelectedItem as Categorias);
                subcategoria = (cbSubCategoria.SelectedItem as SubCategoria);


                Produto[] produtos = Produto.GetProdutosByCategoriaAndSubCategoria(Convert.ToInt32(categoria.ID), Convert.ToInt32(subcategoria.Id)).ToArray();
                ListViewProducts.Items.Clear();
                foreach (Produto produto in produtos)
                {
                    ListViewProducts.Items.Add(produto);
                }
            }
        }
    }
}
