using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        void ViewRichBox()
        {
            double resPrice = 0;
            string listPCInLaboratory = string.Empty;

            for (int i = 0; i < Form1.PC_list.Count; i++)
            {
                listPCInLaboratory += $"{i + 1}-st PC " + Calculating.Price(Form1.PC_list[i]).ToString() + "$\n";
            }

            listPCInLaboratory += "\n";

            foreach (var list in Form1.PC_list)
            {
                resPrice += Calculating.Price(list);
            }

            listPCInLaboratory += "Result Price Lab " + resPrice + "$";

            richTextBox1.Text = listPCInLaboratory;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            bool textBox1IsDigital = int.TryParse(textBox1.Text, out number);

            if (textBox1.Text != "" && textBox1IsDigital && number > 0 && number <= Form1.PC_list.Count)
            {
                textBox1.BackColor = Color.White;
                Form1.PC_list.RemoveAt(number - 1);
                ViewRichBox();
            }
            else
            {
                textBox1.BackColor = Color.PaleVioletRed;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ViewRichBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool textBox1IsDigital = int.TryParse(textBox1.Text, out number);

            if (textBox1.Text != "" && textBox1IsDigital && number > 0 && number <= Form1.PC_list.Count)
                textBox1.BackColor = Color.White;
            else
                textBox1.BackColor = Color.PaleVioletRed;
        }
    }
}
