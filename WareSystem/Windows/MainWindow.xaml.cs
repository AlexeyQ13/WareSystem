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
using WareSystem.Classes;

namespace WareSystem.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            if (Session.UserID == -1)
            {
                NavManager.NavigateTo("/Pages/Logon/AuthPage.xaml");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame = MainFrame;
        }
    }
}
