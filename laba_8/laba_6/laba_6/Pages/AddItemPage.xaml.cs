using MaterialDesignThemes.Wpf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace laba_6
{
    /// <summary>
    /// Interaction logic for AddItemPage.xaml
    /// </summary>
    public partial class AddItemPage : Page
    {
        public AddItemPage()
        {
            InitializeComponent();

            // Подписываемся на событие нажатия комбинации клавиш Ctrl+Z для выполнения Undo
            CommandBinding undoBinding = new CommandBinding(ApplicationCommands.Undo);
            undoBinding.Executed += UndoCommand_Executed;
            this.CommandBindings.Add(undoBinding);

            // Подписываемся на событие нажатия комбинации клавиш Ctrl+Y для выполнения Redo
            CommandBinding redoBinding = new CommandBinding(ApplicationCommands.Redo);
            redoBinding.Executed += RedoCommand_Executed;
            this.CommandBindings.Add(redoBinding);
        }

        private Stack<string> undoStack = new Stack<string>();
        private Stack<string> redoStack = new Stack<string>();

        private string img;

        private void AddImageItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var filePicker = new OpenFileDialog();

            filePicker.DefaultExt = ".jpg";
            filePicker.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png";

            bool? result = filePicker.ShowDialog();

            if (result == true)
            {
                // Open document 
                string filePath = filePicker.FileName;

                string[] parts = filePath.Split('\\');

                string fileName = parts[parts.Length - 1];
                img = fileName;

                var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

                try
                {
                    File.Copy(filePath, projectPath + "/Resources/img/" + fileName, true);
                }
                catch { }

                var source = new BitmapImage(new Uri(projectPath + "/Resources/img/" + fileName));
                ImageBrush imgBrush = new ImageBrush(source);

                AddImageItem.Source = source;

                //image.Fill = imgBrush;
                //image.Stroke = Brushes.Transparent;
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ProductShowcase productShowcase = new ProductShowcase();
            productShowcase.CreatorItemsProduct("", "");
            NavigationService.Navigate(productShowcase);
            
        }

        private void Validate_String(TextBox text, int textLength)
        {
            if (text.Text != string.Empty && text.Text.Length > textLength)
            {
                text.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
                text.SetValue(HintAssist.ForegroundProperty, new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000")));
                return;
            }

            text.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C83B1D"));
            text.SetValue(HintAssist.ForegroundProperty, new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C83B1D")));
        }

        private void Price_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Validate_String(Price_TextBox, 3);

            double price;
            bool IsNum = Double.TryParse(Price_TextBox.Text, out price);

            if (IsNum && price > 1000 && price < 10_000)
            {
                Price_TextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
                Price_TextBox.SetValue(HintAssist.ForegroundProperty, new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000")));
            }
            else
            {
                Price_TextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C83B1D"));
                SetValue(HintAssist.ForegroundProperty, new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C83B1D")));
            }
        }

        private void CPU_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Validate_String(CPU_TextBox, 5);
        }

        private void GPU_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Validate_String(GPU_TextBox, 5);
        }

        private void descriptionFieldRus_TextChanged(object sender, TextChangedEventArgs e)
        {
            undoStack.Push(descriptionFieldRus.Text);
            redoStack.Clear();

            Validate_String(descriptionFieldRus, 10);
        }

        private void descriptionFieldEng_TextChanged(object sender, TextChangedEventArgs e)
        {
            undoStack.Push(descriptionFieldEng.Text);
            redoStack.Clear();

            Validate_String(descriptionFieldEng, 10);
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            if (Price_TextBox.Text != string.Empty && Price_TextBox.Text.Length < 5)
            {
                Price_TextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
                Price_TextBox.SetValue(HintAssist.ForegroundProperty, new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000")));
            }
            else
            {
                Price_TextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C83B1D"));
                Price_TextBox.SetValue(HintAssist.ForegroundProperty, new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C83B1D")));
            }

            Validate_String(CPU_TextBox, 5);
            Validate_String(GPU_TextBox, 5);
            Validate_String(descriptionFieldRus, 10);
            Validate_String(descriptionFieldEng, 10);

            Color validationColor = Colors.Black;
            SolidColorBrush priceColor = (SolidColorBrush)Price_TextBox.GetValue(HintAssist.ForegroundProperty);
            SolidColorBrush CPU_Color = (SolidColorBrush)CPU_TextBox.GetValue(HintAssist.ForegroundProperty);
            SolidColorBrush GPU_Color = (SolidColorBrush)GPU_TextBox.GetValue(HintAssist.ForegroundProperty);
            SolidColorBrush desRU_Color = (SolidColorBrush)descriptionFieldRus.GetValue(HintAssist.ForegroundProperty);
            SolidColorBrush desEN_Color = (SolidColorBrush)descriptionFieldEng.GetValue(HintAssist.ForegroundProperty);

            string source = AddImageItem.Source.ToString();
            bool fastTest = priceColor.Color.Equals(validationColor);

            if (priceColor.Color.Equals(validationColor) &&
                CPU_Color.Color.Equals(validationColor) &&
                GPU_Color.Color.Equals(validationColor) &&
                desRU_Color.Color.Equals(validationColor) &&
                desEN_Color.Color.Equals(validationColor) &&
                !AddImageItem.Source.ToString().Contains("addPhoto")
                )
            {
                double price;
                bool IsNum = Double.TryParse(Price_TextBox.Text, out price);

                source = AddImageItem.Source.ToString();
                string CPU = CPU_TextBox.Text;
                string GPU = GPU_TextBox.Text;
                string description_RU = descriptionFieldRus.Text;
                string description_EN = descriptionFieldEng.Text;

                PC pc =new PC(source, price, CPU, GPU, description_EN, description_RU);

                CreatorItems.Add(pc);
                Configurator.AddItem(source, price, CPU, GPU, description_EN, description_RU);

                ProductShowcase productShowcase = new ProductShowcase();
                productShowcase.CreatorItemsProduct("", "");
                NavigationService.Navigate(productShowcase);
            }
        }

        private void UndoCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (undoStack.Count > 1)
            {
                redoStack.Push(undoStack.Pop());
                descriptionFieldEng.Text = undoStack.Peek();
                descriptionFieldRus.Text = undoStack.Peek();
            }
        }

        private void RedoCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(redoStack.Pop());
                descriptionFieldEng.Text = undoStack.Peek();
                descriptionFieldRus.Text = undoStack.Peek();
            }
        }
    }
}
