﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WareSystem.Classes;

namespace WareSystem.Pages.Logon
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            NavManager.NavigateTo("/Pages/CatalogPage.xaml");
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            NavManager.NavigateTo("/Pages/Logon/RegisterPage.xaml");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavManager.Back();
        }
    }
}
