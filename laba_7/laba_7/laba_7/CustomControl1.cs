using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace laba_7
{
    public class CustomTextBox1 : TextBox
    {
        public static readonly DependencyProperty MaxValueProperty =
            DependencyProperty.Register(
                "MaxValue",
                typeof(int),
                typeof(CustomTextBox1),
                new FrameworkPropertyMetadata(int.MaxValue, MaxValueChangedCallback, CoerceMaxValue), IsValidValue);

        public int MaxValue
        {
            get { return (int)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }


        private static bool IsValidValue(object value)
        {
            int val;
            return int.TryParse(value.ToString(), out val);
        }

        private static object CoerceMaxValue(DependencyObject d, object value)
        {
            int val = (int)value;
            CustomTextBox1 textBox = (CustomTextBox1)d;
            if (val > textBox.MaxValue)
            {
                return textBox.MaxValue;
            }
            return val;
        }

        private static void MaxValueChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomTextBox1 textBox = (CustomTextBox1)d;
            int newValue = (int)e.NewValue;
            if (newValue > textBox.MaxValue)
            {
                textBox.SetValue(MaxValueProperty, textBox.MaxValue);
            }
        }

        public CustomTextBox1()
        {
            this.TextChanged += CustomTextBox_TextChanged;
        }

        private void CustomTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int val;
            if (!int.TryParse(this.Text, out val) || val > MaxValue)
            {
                this.Text = MaxValue.ToString();
            }
        }

        public static readonly RoutedEvent TextChangedEvent =
            EventManager.RegisterRoutedEvent(
                "CustomTextChanged",
                RoutingStrategy.Bubble,
                typeof(RoutedEventHandler),
                typeof(CustomTextBox1));

        public event RoutedEventHandler CustomTextChanged
        {
            add { AddHandler(TextChangedEvent, value); }
            remove { RemoveHandler(TextChangedEvent, value); }
        }

        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            base.OnTextChanged(e);
            RoutedEventArgs args = new RoutedEventArgs(TextChangedEvent);
            RaiseEvent(args);
        }
    }
}
