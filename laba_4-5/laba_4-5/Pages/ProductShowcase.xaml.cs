using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Threading;

namespace laba_4_5
{
    /// <summary>
    /// Interaction logic for ProductShowcase.xaml
    /// </summary>
    public partial class ProductShowcase : Page
    {
        public BaseCommand ViewPageCommand { get; }
        public BaseCommand ViewSearchCommand { get; }

        public static event EventHandler CreatorItemsChanged;

        public ProductShowcase()
        {
            InitializeComponent();
            ViewPageCommand = new ViewPageItemCommand();
            ViewSearchCommand = new SearchCommand();
            CreatorItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        public void CreatorItemsProduct(string search, string filter)
        {
           ViewSearchCommand.Execute(search, filter, MainItemShowcase, this.ItemButton_Click);
        }

        public void ItemButton_Click(object sender, RoutedEventArgs e)
        {
            ViewPageCommand.Execute(sender, this.NavigationService);
        }
    }
}
