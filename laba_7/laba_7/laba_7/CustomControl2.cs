using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace laba_7
{
    public class CustomTextBox2 : TextBox
    {
        public static readonly DependencyProperty MinValueProperty =
            DependencyProperty.Register(
                "MinValue",
                typeof(int),
                typeof(CustomTextBox2),
                new FrameworkPropertyMetadata(int.MinValue, MinValueChangedCallback, CoerceMinValue), IsValidValue);

        public int MinValue
        {
            get { return (int)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }

        private static bool IsValidValue(object value)
        {
            int val;
            return int.TryParse(value.ToString(), out val);
        }

        private static object CoerceMinValue(DependencyObject d, object value)
        {
            int val = (int)value;
            CustomTextBox2 textBox = (CustomTextBox2)d;
            if (val < textBox.MinValue)
            {
                return textBox.MinValue;
            }
            return val;
        }

        private static void MinValueChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomTextBox2 textBox = (CustomTextBox2)d;
            int newValue = (int)e.NewValue;
            if (newValue < textBox.MinValue)
            {
                textBox.SetValue(MinValueProperty, textBox.MinValue);
            }
        }

        public CustomTextBox2()
        {
            this.TextChanged += CustomTextBox_TextChanged;
        }

        private void CustomTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int val;
            if (!int.TryParse(this.Text, out val) || val < MinValue)
            {
                this.Text = MinValue.ToString();
            }
        }

        public static readonly RoutedEvent ValueChangedEvent =
            EventManager.RegisterRoutedEvent(
                "CustomValueChanged",
                RoutingStrategy.Direct,
                typeof(RoutedEventHandler),
                typeof(CustomTextBox2));

        public event RoutedEventHandler CustomTextChanged
        {
            add { AddHandler(ValueChangedEvent, value); }
            remove { RemoveHandler(ValueChangedEvent, value); }
        }

        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            base.OnTextChanged(e);
            RoutedEventArgs args = new RoutedEventArgs(ValueChangedEvent);
            RaiseEvent(args);
        }
    }
}
