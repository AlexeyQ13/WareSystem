using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WareSystem.Classes;

namespace WareSystem.Pages
{
    /// <summary>
    /// Логика взаимодействия для CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        public CatalogPage()
        {
            InitializeComponent();
            DataContext = this;
            ProductList = new ObservableCollection<Product>
            {
                new Product { Id = 1, Title = "Товар 1", Description = "херня", Price = 780},
                new Product { Id = 2, Title = "Товар 2", Description = "херня", Price = 780},
                new Product { Id = 3, Title = "Товар 3", Description = "херня", Price = 780},
                new Product { Id = 4, Title = "Товар 4", Description = "херня", Price = 780},
                new Product { Id = 1, Title = "Товар 1", Description = "херня", Price = 780},
                new Product { Id = 2, Title = "Товар 2", Description = "херня", Price = 780},
                new Product { Id = 3, Title = "Товар 3", Description = "херня", Price = 780},
                new Product { Id = 4, Title = "Товар 4", Description = "херня", Price = 780},
                new Product { Id = 1, Title = "Товар 1", Description = "херня", Price = 780},
                new Product { Id = 2, Title = "Товар 2", Description = "херня", Price = 780},
                new Product { Id = 3, Title = "Товар 3", Description = "херня", Price = 780},
                new Product { Id = 4, Title = "Товар 4", Description = "херня", Price = 780}
            };
        }

        public ObservableCollection<Product> ProductList { get; set; }
    }
}
