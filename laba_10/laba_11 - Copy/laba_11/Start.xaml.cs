using System.Windows;
using System.Windows.Controls;

namespace laba_11
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Start : Page
    {
        private CartViewModel _cartViewModel;

        public Start()
        {
            InitializeComponent();

            _cartViewModel = new CartViewModel();
            this.DataContext = _cartViewModel;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string name = string.Empty;
            int hourse = 0;
            string teacher = string.Empty;
            int lisenes = 0;

            if (Name.Text != string.Empty && NameTeacher.Text != string.Empty && 
                int.TryParse(QuantityLisens.Text, out int pr) &&
                int.TryParse(CountHourse.Text, out int qua))
            {
                name = Name.Text;
                hourse = qua;
                teacher = NameTeacher.Text;
                lisenes = pr;
            }
            else
            {
                MessageBox.Show("Uncorect Inform");
                return;
            }

            Name.Text = string.Empty;
            NameTeacher.Text = string.Empty;
            QuantityLisens.Text = string.Empty;
            CountHourse.Text = string.Empty;

            _cartViewModel.AddProductToCart(name, hourse, teacher, lisenes);
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            string name = string.Empty;
            int hourse = 0;
            string teacher = string.Empty;
            int lisenes = 0;

            if (Name.Text != string.Empty/* && NameTeacher.Text != string.Empty &&
                int.TryParse(QuantityLisens.Text, out int pr) &&
                int.TryParse(CountHourse.Text, out int qua)*/)
            {
                name = Name.Text;
                /*hourse = qua;
                teacher = NameTeacher.Text;
                lisenes = pr;*/
            }
            else
            {
                MessageBox.Show("Uncorect Inform");
                return;
            }

            //var selectedProduct = new Course(name, hourse, teacher, lisenes);

            Name.Text = string.Empty;
            NameTeacher.Text = string.Empty;
            QuantityLisens.Text = string.Empty;
            CountHourse.Text = string.Empty;

            _cartViewModel.RemoveProductFromCart(name);
        }
        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowPage(_cartViewModel));
        }
    }
}