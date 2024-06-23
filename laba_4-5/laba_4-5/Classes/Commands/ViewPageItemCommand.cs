using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace laba_4_5
{
    internal class ViewPageItemCommand : BaseCommand
    {
        public override void Execute(object? sender, NavigationService? navigation)
        {
            string buttonName = ((Button)sender).Name;

            int buttonID = Int32.Parse(buttonName.Replace("ProductItem_", ""));

            ViewItemPage page = new ViewItemPage();

            page.CurrentItem = buttonID;

            PC item = CreatorItems.list_PC.ElementAt(buttonID);

            page.AddImageItem.Source = new BitmapImage(new Uri(item.Image));
            page.Price_TextBox.Text = item.Price.ToString() + " $";
            page.CPU.Text = item.CPU;
            page.GPU.Text = item.GPU;

            CultureInfo currLang = App.Language;
            CultureInfo culture = new CultureInfo("en-US");


            if (currLang.Equals(culture))
            {
                page.descriptionFiel.Text = item.Description_En;
            }
            else
            {
                page.descriptionFiel.Text = item.Description_Ru;
            }

            if (CreatorItems.CurrentUser == true)
                page.Remove_Button.Visibility = Visibility.Hidden;
            else
                page.Remove_Button.Visibility = Visibility.Visible;

            navigation.Navigate(page);

        }

        public override void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public override void Execute(string? searcch, string? filter, UniformGrid? prod, RoutedEventHandler? itemButtonClickHandler)
        {
            throw new NotImplementedException();
        }
    }
}
