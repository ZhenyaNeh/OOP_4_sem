using SuperCat.Paterns;
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
    /// Interaction logic for ViewItemPage.xaml
    /// </summary>
    public partial class ViewItemPage : Page
    {
        private MyUnitOfWork _unitOfWork = new MyUnitOfWork(new Context());
        public ViewItemPage()
        {
            InitializeComponent();
        }

        public int CurrentItem {  get; set; }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            /*ProductShowcase productShowcase = new ProductShowcase();
            productShowcase.CreatorItemsProduct("", "");
            NavigationService.Navigate(productShowcase);*/
        }

        private void Trach_Button_Click(object sender, RoutedEventArgs e)
        {
            // double price = CreatorItems.list_PC[CurrentItem].Price;
            _unitOfWork.Repository.Del(CurrentItem);
            if (MessageBox.Show("You agree", "Answer", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                return;
            _unitOfWork.Save();
            // CreatorItems.list_PC.RemoveAt(CurrentItem);


            ProductShowcase productShowcase = new ProductShowcase();
            productShowcase.CreatorItemsProduct("", "");
            NavigationService.Navigate(productShowcase);
        }
    }
}
