using MaterialDesignColors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;

namespace laba_6
{
    internal class SearchCommand : BaseCommand
    {
        public override void Execute(string? search, string? filter, ItemsControl? prod, RoutedEventHandler? itemButtonClickHandler)
        {
            //var list = CreatorItems.list_PC;
            using (var context = new Context())
            {
                var list = context.Configurators.ToList();

                if (filter == "CPU")
                {
                    list = list.OrderBy(x => x.CPU).ToList();
                }
                if (filter == "GPU")
                {
                    list = list.OrderBy(x => x.GPU).ToList();
                }


                int iteration = 0;

                string[] searchSplit = new string[2];

                if (search.Contains(','))
                {
                    searchSplit = search.Split(',');
                    searchSplit[0] = searchSplit[0].Trim().ToLower();
                    searchSplit[1] = searchSplit[1].Trim().ToLower();
                }
                else
                {
                    searchSplit[0] = search;
                    searchSplit[1] = "";
                }


                foreach (var item in list)
                {
                    if (item.CPU.ToLower().Contains(searchSplit[0]) && item.GPU.ToLower().Contains(searchSplit[1]))
                    {
                        Grid grid = new Grid();
                        grid.Height = 250;
                        grid.HorizontalAlignment = HorizontalAlignment.Center;
                        grid.VerticalAlignment = VerticalAlignment.Center;

                        Image image = new Image();
                        image.Source = new BitmapImage(new Uri(item.Image));

                        Rectangle rectangleImg = new Rectangle();
                        rectangleImg.Width = 170;
                        rectangleImg.Height = 190;
                        rectangleImg.RadiusX = 10;
                        rectangleImg.RadiusY = 10;
                        rectangleImg.VerticalAlignment = VerticalAlignment.Top;
                        rectangleImg.Margin = new Thickness(0, 10, 0, 0);
                        rectangleImg.Fill = new ImageBrush(image.Source);

                        Rectangle price = new Rectangle();
                        price.Width = rectangleImg.Width;
                        price.RadiusX = 10;
                        price.RadiusY = 10;
                        price.Height = 20;
                        price.VerticalAlignment = VerticalAlignment.Bottom;
                        price.Margin = new Thickness(0, 0, 0, 20);
                        price.Style = Application.Current.Resources["RectangleThemeStyle"] as Style;
                        //price.Fill = new SolidColorBrush(Colors.DarkGray);
                        //price.Style = 

                        TextBlock textBlock = new TextBlock();
                        textBlock.Text = item.Price.ToString() + " $";
                        textBlock.FontSize = 16;
                        textBlock.Foreground = new SolidColorBrush(Colors.White);
                        textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                        textBlock.VerticalAlignment = VerticalAlignment.Bottom;
                        textBlock.Margin = new Thickness(0, 0, 0, 20);

                       /* for (int i = 0; i < CreatorItems.list_PC.Count; i++)
                            if (item.Equals(CreatorItems.list_PC.ElementAt(i)))
                                iteration = i;*/

                        Button button = new Button();
                        button.Name = "ProductItem_" + item.Id;
                        button.Height = 250;
                        button.Width = 222;
                        button.Margin = new Thickness(0, 10, 0, 20);
                        button.Style = (Style)Application.Current.Resources["FlatButtonDesign_RegularStyle"];
                        button.Click += itemButtonClickHandler;

                        grid.Children.Add(rectangleImg);
                        grid.Children.Add(price);
                        grid.Children.Add(textBlock);

                        button.Content = grid;

                        prod.Items.Add(button);
                    }
                }
            }
        }

        public override void Execute(object? parameter, NavigationService? navigation)
        {
            throw new NotImplementedException();
        }

        public override void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
