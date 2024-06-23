using laba_6.Classes.PC_SetUp;
using laba_6.Classes.UserAndAdmin;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ICommand SearchCommandEvent { get; }

        static private string path_Prod = "..\\..\\..\\..\\SaveProductsData.json";
        static private string path_Admin = "..\\..\\..\\..\\SaveAdminData.json";
        static private string path_User = "..\\..\\..\\..\\SaveUserData.json";
        static bool checkLanguageActivity = false;

        public MainWindow()
        {
            InitializeComponent();
            //Cursor = CreateCursorFromImage("D:\\University\\OOP\\laba_6\\laba_6\\Resources\\img\\pointer.cur");
            App.LanguageChanged += LanguageChanged;
            ProductShowcase.CreatorItemsChanged += ChangeItomVisibiliti;
            SearchCommandEvent = new SearchCommand();
            CultureInfo currLang = App.Language;
        }
        private Cursor CreateCursorFromImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                try
                {
                    return new Cursor(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to create custom cursor: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Image file not found: " + imagePath);
            }

            return Cursors.Arrow; // Возвращаем стандартный курсор в случае ошибки
        }

        private void ChangeItomVisibiliti(Object sender, EventArgs e)
        {
           /* if (CreatorItems.CurrentUserName != null)
                RegistrationButton.Content = CreatorItems.CurrentUserName;

            if (CreatorItems.CurrentUser == true)
                AddNewItem.Visibility = Visibility.Hidden;
            else
                AddNewItem.Visibility = Visibility.Visible;*/
        }

        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;
        }

        private void LinkToVK_MouseDown(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://vk.com/evgeshanex") { UseShellExecute = true });
        }

        private void VisibleLenguageSetting()
        {
            checkLanguageActivity = true;
            AboutAutor.Margin = new Thickness(0, 10, 0, 0);
            ru_Language.Visibility = Visibility.Visible;
            en_Language.Visibility = Visibility.Visible;
            LanguageID.Text = LanguageID.Text.Replace('▾', '▴');
        }

        private void HideLenguageSetting()
        {
            checkLanguageActivity = false;
            AboutAutor.Margin = new Thickness(0, -10, 0, 0);
            ru_Language.Visibility = Visibility.Hidden;
            en_Language.Visibility = Visibility.Hidden;
            LanguageID.Text = LanguageID.Text.Replace('▴', '▾');
        }

        private void LanguageSettings_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!checkLanguageActivity)
            {
                VisibleLenguageSetting();
                return;
            }

            HideLenguageSetting();
            return;
        }

        private void ru_Language_MouseDown(object sender, MouseButtonEventArgs e)
        {
            App.Language = new CultureInfo("ru-RU");

            Language.Margin = new Thickness(20, 15, 0, 0);
            LanguageID.Margin = new Thickness(0, 15, 20, 0);
            LanguageChoise.Width = 140;

            ru_Language.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C83B1D"));
            en_Language.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));

            LanguageID.Text = "(RU)▾";

            HideLenguageSetting();
        }

        private void en_Language_MouseDown(object sender, MouseButtonEventArgs e)
        {
            App.Language = new CultureInfo("en-US");

            Language.Margin = new Thickness(0, 15, 0, 0);
            LanguageID.Margin = new Thickness(0, 15, 0, 0);
            LanguageChoise.Width = 120;

            ru_Language.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
            en_Language.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C83B1D"));

            LanguageID.Text = "(EN)▾";

            HideLenguageSetting();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            Catalog.SelectedIndex = -1;
            Search.Text = "";
            MainFrame.Content = new RegistrationPage();
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AddItemPage();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            WorkWithFille.Serialize(CreatorItems.list_PC, path_Prod);
            WorkWithFille.Serialize(CreatorItems.list_Admin, path_Admin);
            WorkWithFille.Serialize(CreatorItems.list_User, path_User);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //CreatorItems.list_PC = WorkWithFille.DeSerialize<PC>(path_Prod);
            CreatorItems.list_Admin = WorkWithFille.DeSerialize<Admin>(path_Admin);
            CreatorItems.list_User = WorkWithFille.DeSerialize<User>(path_User);

            using (var context = new Context())
            {
                CreatorItems.list_con = context.Configurators.ToList();    
            }

            ProductShowcase productShowcase = new ProductShowcase();
            productShowcase.CreatorItemsProduct("", "");
            MainFrame.Content = productShowcase;
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            //SearchCommandEvent.Execute(sender);
            string search = Search.Text;
            string catalog = Catalog.Text;

            ProductShowcase productShowcase = new ProductShowcase();
            productShowcase.CreatorItemsProduct(search, catalog);
            MainFrame.Content = productShowcase;
        }

        private void Catalog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string search = Search.Text;

            var catalogItem = (TextBlock)Catalog.SelectedItem;
            string filter = "";

            if(catalogItem != null)
            {
                filter = catalogItem.Text;
            }

            ProductShowcase productShowcase = new ProductShowcase();
            productShowcase.CreatorItemsProduct(search, filter);
            MainFrame.Content = productShowcase;
        }

        private void Theme_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary day = new ResourceDictionary();
            ResourceDictionary night = new ResourceDictionary();

            day.Source = new Uri("Resources/resource/StyleDayTheme.xaml", UriKind.Relative);
            night.Source = new Uri("Resources/resource/StyleNightTheme.xaml", UriKind.Relative);

            ResourceDictionary oldDict = (from d in Application.Current.Resources.MergedDictionaries
                                          where d.Source != null && d.Source.OriginalString.StartsWith("Resources/resource/Style")
                                          select d).First();

            if (Theme.IsChecked == true)
            {
                int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDict);
                Application.Current.Resources.MergedDictionaries.Remove(oldDict);
                Application.Current.Resources.MergedDictionaries.Insert(ind, night);
            }
            else
            {
                int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDict);
                Application.Current.Resources.MergedDictionaries.Remove(oldDict);
                Application.Current.Resources.MergedDictionaries.Insert(ind, day);
            }


            if(MainFrame.Content is ProductShowcase)
            { 
                ProductShowcase productShowcase = new ProductShowcase();
                productShowcase.CreatorItemsProduct("", "");
                MainFrame.Content = productShowcase;
            }
        }
    }
}
            /*DoubleAnimation doubleAnimation = new DoubleAnimation();

            doubleAnimation.By = 50;
            doubleAnimation.Duration = TimeSpan.FromSeconds(1);

            //smoove
            EasingFunctionBase easingFunction = new QuadraticEase();
            ((QuadraticEase)easingFunction).EasingMode = EasingMode.EaseOut;
            doubleAnimation.EasingFunction = easingFunction;

            productShowcase.MainItemShowcase.BeginAnimation(Page.HeightProperty, doubleAnimation);*/