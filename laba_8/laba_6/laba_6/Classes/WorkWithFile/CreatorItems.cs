using laba_6.Classes.UserAndAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba_6
{
    class CreatorItems
    {
        public static List<PC> list_PC = new List<PC>();
        public static List<User> list_User = new List<User>();
        public static List<Admin> list_Admin = new List<Admin>();

        public static bool CurrentUser { get; set; } = true;
        public static string? CurrentUserName { get; set; } = null;

        //public CreatorItems() { }

        public CreatorItems()
        {
        }

        public static void Add(PC pc)
        {
            if(pc != null)
                list_PC.Add(pc);
        }

        public static void Add(User user)
        {
            if (user != null)
                list_User.Add(user);
        }

        public static void Add(Admin admin)
        {
            if (admin != null)
                list_Admin.Add(admin);
        }

        public static void CreateItems()
        {
            ProductShowcase productShowcase = new ProductShowcase();

            foreach (PC item in list_PC)
            {
                Grid grid = new Grid();
                grid.Height = 250;
                grid.Background = new SolidColorBrush(Colors.Gray);
                grid.Margin = new Thickness(10);

                Image image = new Image();
                image.Source = new BitmapImage(new Uri(item.Image));
                image.Width = 100;

                Rectangle rectangle = new Rectangle();
                rectangle.Width = image.Width;
                rectangle.Height = image.Height;
                rectangle.RadiusX = 10;
                rectangle.RadiusY = 10;
                rectangle.Fill = new ImageBrush(image.Source);

                TextBlock textBlock = new TextBlock();
                textBlock.Text = item.Price.ToString();
                textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                textBlock.VerticalAlignment = VerticalAlignment.Bottom;

                grid.Children.Add(rectangle);
                grid.Children.Add(textBlock);

                productShowcase.MainItemShowcase.Children.Add(grid);
            }
        }
    }
}
