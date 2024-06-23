using MaterialDesignColors;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba_6
{
    /// <summary>
    /// Interaction logic for LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void LogName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LogPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            string name = LogName.Text;
            string password = LogPassword.Text;

            foreach(var item in CreatorItems.list_User)
            {
                if(name == item.Name_User)
                {
                    LogName.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));

                    if (password == item.Password_User)
                    {
                        CreatorItems.CurrentUser = true;
                        CreatorItems.CurrentUserName = name;

                        ProductShowcase productShowcase = new ProductShowcase();
                        productShowcase.CreatorItemsProduct("", "");
                        NavigationService.Navigate(productShowcase);
                    }
                    else
                    {
                        LogPassword.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C83B1D"));
                    }
                }
                else
                {
                    LogName.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C83B1D"));
                }
            }

            foreach (var item in CreatorItems.list_Admin)
            {
                if (name == item.Name_Admin)
                {
                    LogName.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));

                    if (password == item.Password_Admin)
                    {
                        CreatorItems.CurrentUser = false;
                        CreatorItems.CurrentUserName = name;

                        ProductShowcase productShowcase = new ProductShowcase();
                        productShowcase.CreatorItemsProduct("", "");
                        NavigationService.Navigate(productShowcase);
                    }
                    else
                    {
                        LogPassword.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C83B1D"));
                    }
                }
                else
                {
                    LogName.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C83B1D"));
                }
            }

        }
    }
}
