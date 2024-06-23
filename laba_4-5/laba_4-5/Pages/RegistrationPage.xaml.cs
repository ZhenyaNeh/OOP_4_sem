using laba_4_5.Classes.UserAndAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
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

namespace laba_4_5
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LogInPage());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ProductShowcase productShowcase = new ProductShowcase();
            productShowcase.CreatorItemsProduct("", "");
            NavigationService.Navigate(productShowcase);
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            ErrorMessage.Text = string.Empty;
            ErrorBorder.Visibility = Visibility.Hidden;

            string name = RegName.Text;
            string password = RegPassword.Text;
            string rePassword = RegRepitPassword.Text;
            string email = RegEmail.Text;

            User addUser = new User(name, password, email);

            var list = CreatorItems.list_User;

            foreach (var item in list)
            {
                if (item.Name_User.Contains(name))
                {
                    ErrorMessage.Text = "Пользователь с таким именем уже зарегистрирован\n";
                    ErrorBorder.Visibility = Visibility.Visible;
                    return;
                }
            }

            if (rePassword != password)
            {
                ErrorMessage.Text = "Пароли не совпадают\n";
                ErrorBorder.Visibility = Visibility.Visible;
                return;
            }

            var validResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            bool isvalid = Validator.TryValidateObject(addUser, new ValidationContext(addUser),validResults, true);

            if (isvalid)
            {
                CreatorItems.Add(addUser);
                ProductShowcase productShowcase = new ProductShowcase();
                productShowcase.CreatorItemsProduct("", "");
                NavigationService.Navigate(productShowcase);
            }
            else
            {
                foreach (var validationResult in validResults)
                {
                    ErrorMessage.Text += validationResult.ErrorMessage + "\n";
                    ErrorBorder.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
