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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static List<PC> PC_list_Sort = new List<PC>();

        static private string path = "..\\..\\..\\..\\SaveSortData.json";

        public void VerifyComboBoxMain()
        {
            if (comboBox1.Text != "")
            {
                comboBox1.BackColor = Color.White;
                return;
            }

            comboBox1.BackColor = Color.PaleVioletRed;
        }

        public void VerifyComboBoxChield()
        {
            if (comboBox2.Text != "" && comboBox2.Text.Contains(comboBox1.Text))
            {
                comboBox2.BackColor = Color.White;
                return;
            }

            comboBox2.BackColor = Color.PaleVioletRed;
        }

        private void GetElement()
        {
            PC_list_Sort.Clear();

            foreach (PC pc in Form1.PC_list)
            {
                if (pc.CPU.CPU_Manufacturer.Contains(comboBox1.Text) && pc.CPU.CPU_Series.Contains(comboBox2.Text))
                {
                    PC_list_Sort.Add(pc);
                }
            }
        }

        private void ViewPCSort()
        {
            if (PC_list_Sort.Count != 0)
            {

                PC_list_Sort = PC_list_Sort.OrderBy(x => Double.Parse(x.CPU.CPU_Frequency.Take(3).ToArray())).ThenBy(x => x.Memory.RAM_Size).ToList();

                double resPrice = 0;
                string listPCInLaboratory = string.Empty;

                for (int i = 0; i < PC_list_Sort.Count; i++)
                {
                    listPCInLaboratory += $"{i + 1}-st PC " + Calculating.Price(PC_list_Sort[i]).ToString() + "$\n";
                }

                listPCInLaboratory += "\n";

                foreach (var list in PC_list_Sort)
                {
                    resPrice += Calculating.Price(list);
                }

                listPCInLaboratory += "Result Price Lab " + resPrice + "$";

                richTextBox1.Text = listPCInLaboratory;

                return;
            }

            richTextBox1.Text = "There are no such computers...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerifyComboBoxMain();
            VerifyComboBoxChield();

            if (comboBox1.BackColor == Color.White &&
               comboBox2.BackColor == Color.White)
            {
                GetElement();
                ViewPCSort();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyComboBoxMain();
            VerifyComboBoxChield();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyComboBoxChield();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerifyComboBoxMain();
            VerifyComboBoxChield();

            if (comboBox1.BackColor == Color.White &&
               comboBox2.BackColor == Color.White)
            {
                int i = 1;
                double resPrice = 0;
                string labSetUp = "";

                foreach (var pc in PC_list_Sort)
                {
                    labSetUp += $"====={i++}-st PC=====\n";
                    labSetUp += pc.ToString() + "Price: " + Calculating.Price(pc) + "$\n\n";
                }

                foreach (var pc in PC_list_Sort)
                {
                    resPrice += Calculating.Price(pc);
                }

                richTextBox1.Text = labSetUp + "\nResult Price Lab " + resPrice + "$";
            }
        }

        private void button3_VisibleChanged(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains("1-st PC"))
            {
                button3.Visible = false;
                return;
            }

            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerifyComboBoxMain();
            VerifyComboBoxChield();

            if (comboBox1.BackColor == Color.White &&
               comboBox2.BackColor == Color.White)
            {
                if (PC_list_Sort.Count != 0)
                {
                    WorkWithFille.Serialize(PC_list_Sort, path);
                    richTextBox1.Text = "Saving completed successfully!";
                    return;
                }

                richTextBox1.Text = "There are no such computers...";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PC_list_Sort.Clear();
            PC_list_Sort = WorkWithFille.DeSerialize(path);

            comboBox1.Text = PC_list_Sort[0].CPU.CPU_Manufacturer;
            comboBox2.Text = PC_list_Sort[0].CPU.CPU_Series;

            VerifyComboBoxMain();
            VerifyComboBoxChield();

            ViewPCSort();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
    }
}
