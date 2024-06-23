namespace laba_1
{
    public partial class Form1 : Form
    {
        Calculator Calculator { get; set; }
        public Form1()
        {
            Calculator = new Calculator();
            InitializeComponent();
        }

        private void RestartRadioButton()
        {
            menRadio.BackColor = Color.Tan;
            womenRadio.BackColor = Color.Tan;
            menRadio.ForeColor = Color.Black;
            womenRadio.ForeColor = Color.Black;
        }

        private void CheckedPlaces()
        {
            bool radioButton1IsTrue = menRadio.Checked;
            bool radioButton2IsTrue = womenRadio.Checked;

            if (!radioButton1IsTrue && !radioButton2IsTrue)
            {
                menRadio.BackColor = Color.PaleVioletRed;
                womenRadio.BackColor = Color.PaleVioletRed;
                menRadio.ForeColor = Color.White;
                womenRadio.ForeColor = Color.White;
            }

            string textBox1Text = wightBox.Text;
            double number;

            bool textBox1IsDigital = double.TryParse(textBox1Text, out number);

            if (textBox1Text == string.Empty && !textBox1IsDigital || number < 20 || number > 200)
            {
                wightBox.BackColor = Color.PaleVioletRed;
            }
            else
            {
                wightBox.BackColor = Color.LightGreen;
            }

            string textBox2Text = hightBox.Text;

            bool textBox2IsDigital = double.TryParse(textBox2Text, out number);

            if (textBox2Text == string.Empty && !textBox2IsDigital || number < 100 || number > 250)
            {
                hightBox.BackColor = Color.PaleVioletRed;
            }
            else
            {
                hightBox.BackColor = Color.LightGreen;
            }

            string textBox3Text = ageBox.Text;

            bool textBox3IsDigital = double.TryParse(textBox3Text, out number);

            if (textBox3Text == string.Empty && !textBox3IsDigital || number < 1 || number > 100)
            {
                ageBox.BackColor = Color.PaleVioletRed;
            }
            else
            {
                ageBox.BackColor = Color.LightGreen;
            }

            string comboBox1Text = activityCombo.Text;
            if (comboBox1Text != string.Empty)
            {
                activityCombo.BackColor = Color.LightGreen;
            }
            else
            {
                activityCombo.BackColor = Color.PaleVioletRed;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CheckedPlaces();

                if (menRadio.BackColor == Color.Tan &&
                    wightBox.BackColor == Color.LightGreen &&
                    hightBox.BackColor == Color.LightGreen &&
                    ageBox.BackColor == Color.LightGreen &&
                    activityCombo.BackColor == Color.LightGreen)
                {
                    string weightData = wightBox.Text;
                    string heightData = hightBox.Text;
                    string ageData = ageBox.Text;

                    double weight = double.Parse(weightData);
                    double height = double.Parse(heightData);
                    double age = double.Parse(ageData);

                    bool isAMen = menRadio.Checked;

                    string resultKcal = Calculator.CalculateKcal(isAMen, weight, height, age, activityCombo.Text);
                    string resultIndexBody = Calculator.CalculateIndex(weight, height);

                    ansverNumberText.ForeColor = Color.FromArgb(90, 47, 37);
                    ansverNumberText.Text = resultKcal;

                    ansverText.ForeColor = Color.FromArgb(90, 47, 37);
                    ansverText.Text = resultIndexBody;
                }
                else
                {
                    throw new Exception("Wrong Data");
                }
            }
            catch (Exception ex)
            {
                ansverNumberText.Text = ex.Message;
                ansverNumberText.ForeColor = Color.PaleVioletRed;

                ansverText.Text = ex.Message;
                ansverText.ForeColor = Color.PaleVioletRed;
            }
            finally
            {
                //label7.ForeColor = Color.PaleVioletRed;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string textBox1Weight = wightBox.Text;

            if (textBox1Weight != string.Empty)
            {
                double number;
                bool textBox1IsDigital = double.TryParse(textBox1Weight, out number);

                if (!textBox1IsDigital || number < 20 || number > 200)
                {
                    wightBox.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    wightBox.BackColor = Color.LightGreen;
                }
            }
            else
            {
                wightBox.BackColor = Color.PaleVioletRed;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string textBox2Height = hightBox.Text;

            if (textBox2Height != string.Empty)
            {
                double number;
                bool textBox2IsDigital = double.TryParse(textBox2Height, out number);

                if (!textBox2IsDigital || number < 100 || number > 250)
                {
                    hightBox.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    hightBox.BackColor = Color.LightGreen;
                }
            }
            else
            {
                hightBox.BackColor = Color.PaleVioletRed;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string textBox3Age = ageBox.Text;

            if (textBox3Age != string.Empty)
            {
                double number;
                bool textBox3IsDigital = double.TryParse(textBox3Age, out number);

                if (!textBox3IsDigital || number < 1 || number > 100)
                {
                    ageBox.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    ageBox.BackColor = Color.LightGreen;
                }
            }
            else
            {
                ageBox.BackColor = Color.PaleVioletRed;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboBox1Goal = activityCombo.Text;

            if (comboBox1Goal != string.Empty)
            {
                activityCombo.BackColor = Color.LightGreen;
            }
            else
            {
                activityCombo.BackColor = Color.PaleVioletRed;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bool radioButton1IsTrue = menRadio.Checked;

            if (radioButton1IsTrue)
            {
                RestartRadioButton();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bool radioButton2IsTrue = womenRadio.Checked;

            if (radioButton2IsTrue)
            {
                RestartRadioButton();
            }
        }
    }
}