using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CommandBinding customCommandBinding = new CommandBinding(CustomCommands.CustomCommand, ExecuteCustomCommand, CanExecuteCustomCommand);
            this.CommandBindings.Add(customCommandBinding);
        }

        private void ExecuteCustomCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show($"CustomTextBox1 Text: {customTextBox1.Text}, CustomTextBox2 Text: {customTextBox2.Text}");
        }

        private void CanExecuteCustomCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true; 
        }



        private void customTextBox1_CustomTextChanged(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("CustomTextBox1 Text Changed (Bubbling)");
        }

        private void customTextBox2_CustomValueChanged(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("CustomTextBox2 Value Changed (Direct)");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"CustomTextBox1 Text: {customTextBox1.Text}, CustomTextBox2 Text: {customTextBox2.Text}");
        }
    }
}