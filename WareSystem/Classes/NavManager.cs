using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WareSystem.Classes
{
    public static class NavManager
    {
        public static Frame MainFrame { get; set; }

        public static void NavigateTo(string page)
        {
            MainFrame.Navigate(new Uri(page, UriKind.Relative));
        }

        public static void Back()
        {
            MainFrame.GoBack();
        }
    }
}
