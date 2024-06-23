using System.ComponentModel;
using System.Drawing.Text;

namespace laba_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<PC> PC_list = new List<PC>();

        public PC CreateObject()
        {
            int countCores = 0;
            int bitSizer = 0;

            if (radioButton1.Checked)
                countCores = 4;
            else if (radioButton2.Checked)
                countCores = 8;
            else if (radioButton3.Checked)
                countCores = 16;

            if (radioButton4.Checked)
                bitSizer = 32;
            else if (radioButton5.Checked)
                bitSizer = 64;

            CPU cpu = new CPU(comboBox2.Text, comboBox4.Text, comboBox6.Text, countCores, comboBox10.Text, bitSizer);

            GPU gpu = new GPU(comboBox3.Text, comboBox5.Text, comboBox7.Text, comboBox11.Text, checkBox1.Checked, comboBox12.Text);

            Memory memory = new Memory(comboBox8.Text, trackBar1.Value, comboBox9.Text, trackBar2.Value);

            PC pc = new PC(comboBox1.Text, cpu, gpu, memory, dateTimePicker1.Text, maskedTextBox1.Text);

            return pc;
        }

        void VerifyManufacturer(ComboBox mainCombo, ComboBox combo, string textFirstManufac, string textSecondManufac)
        {
            if (combo.Text == "")
            {
                VerifyComboBox(combo);
                return;
            }
            else if (mainCombo.Text.Contains(textFirstManufac))
            {
                if (combo.Text.Contains(textFirstManufac))
                {
                    combo.BackColor = Color.White;
                    return;
                }
                combo.BackColor = Color.PaleVioletRed;
                return;
            }
            else if (mainCombo.Text.Contains(textSecondManufac))
            {
                if (combo.Text.Contains(textSecondManufac))
                {
                    combo.BackColor = Color.White;
                    return;
                }
                combo.BackColor = Color.PaleVioletRed;
                return;
            }

            combo.BackColor = Color.PaleVioletRed;
            return;
        }

        void VerifyComboBox(ComboBox combo)
        {
            if (combo.Text != "")
            {
                combo.BackColor = Color.White;
                return;
            }

            combo.BackColor = Color.PaleVioletRed;
        }

        void VerifyPanel1()
        {
            if (!radioButton4.Checked && !radioButton5.Checked)
            {
                panel1.BackColor = Color.PaleVioletRed;
                return;
            }

            panel1.BackColor = Color.Transparent;
        }

        void VerifyPanel2()
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                panel2.BackColor = Color.PaleVioletRed;
                return;
            }

            panel2.BackColor = Color.Transparent;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value % 4 == 0)
            {
                label25.BackColor = Color.Transparent;
            }
            else
            {
                label25.BackColor = Color.PaleVioletRed;
            }

            label25.Text = trackBar1.Value.ToString() + "Gb";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label26.Text = trackBar2.Value.ToString() + "Gb";

            if (trackBar2.Value % 128 == 0)
            {
                label26.BackColor = Color.Transparent;
            }
            else
            {
                label26.BackColor = Color.PaleVioletRed;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyComboBox(comboBox1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyComboBox(comboBox2);
            VerifyManufacturer(comboBox2, comboBox4, "Intel", "Ryzen");
            VerifyManufacturer(comboBox2, comboBox6, "Intel", "Ryzen");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyManufacturer(comboBox2, comboBox4, "Intel", "Ryzen");
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyManufacturer(comboBox2, comboBox6, "Intel", "Ryzen");
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyComboBox(comboBox10);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyComboBox(comboBox3);
            VerifyManufacturer(comboBox3, comboBox5, "Nvidia", "AMD");
            VerifyManufacturer(comboBox3, comboBox7, "Nvidia", "AMD");
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyComboBox(comboBox11);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyManufacturer(comboBox3, comboBox5, "Nvidia", "AMD");
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyManufacturer(comboBox3, comboBox7, "Nvidia", "AMD");
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyComboBox(comboBox12);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyComboBox(comboBox8);
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyComboBox(comboBox9);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerifyComboBox(comboBox1);
            VerifyComboBox(comboBox2);
            VerifyComboBox(comboBox3);
            VerifyManufacturer(comboBox2, comboBox4, "Intel", "Ryzen");
            VerifyManufacturer(comboBox3, comboBox5, "Nvidia", "AMD");
            VerifyManufacturer(comboBox2, comboBox6, "Intel", "Ryzen");
            VerifyManufacturer(comboBox3, comboBox7, "Nvidia", "AMD");
            VerifyComboBox(comboBox8);
            VerifyComboBox(comboBox9);
            VerifyComboBox(comboBox10);
            VerifyComboBox(comboBox11);
            VerifyComboBox(comboBox12);

            VerifyPanel1();
            VerifyPanel2();

            if (comboBox1.BackColor == Color.White &&
                comboBox2.BackColor == Color.White &&
                comboBox3.BackColor == Color.White &&
                comboBox4.BackColor == Color.White &&
                comboBox5.BackColor == Color.White &&
                comboBox6.BackColor == Color.White &&
                comboBox7.BackColor == Color.White &&
                comboBox8.BackColor == Color.White &&
                comboBox9.BackColor == Color.White &&
                comboBox10.BackColor == Color.White &&
                comboBox11.BackColor == Color.White &&
                comboBox12.BackColor == Color.White &&
                panel1.BackColor == Color.Transparent &&
                panel2.BackColor == Color.Transparent &&
                maskedTextBox1.BackColor == Color.White)
            {
                PC pc = CreateObject();
                double resPrice = 0;
                string listPCInLaboratory = string.Empty;

                for (int i = 0; i < PC_list.Count; i++)
                {
                    listPCInLaboratory += $"{i + 1}-st " + Calculating.Price(PC_list[i]).ToString() + "\n";
                }

                listPCInLaboratory += "\n";

                listPCInLaboratory += "Constucted PC " + Calculating.Price(pc);

                listPCInLaboratory += "\n";

                foreach (var list in PC_list)
                {
                    resPrice += Calculating.Price(list);
                }

                listPCInLaboratory += "Result Price Lab " + (resPrice + Calculating.Price(pc));

                richTextBox1.Text = listPCInLaboratory;
            }
            else
            {
                richTextBox1.Text = "Veryfy is not a valid";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Transparent;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Transparent;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Transparent;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.Text.Length != 14)
            {
                maskedTextBox1.BackColor = Color.PaleVioletRed;
                return;
            }

            maskedTextBox1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.BackColor == Color.White &&
                comboBox2.BackColor == Color.White &&
                comboBox3.BackColor == Color.White &&
                comboBox4.BackColor == Color.White &&
                comboBox5.BackColor == Color.White &&
                comboBox6.BackColor == Color.White &&
                comboBox7.BackColor == Color.White &&
                comboBox8.BackColor == Color.White &&
                comboBox9.BackColor == Color.White &&
                comboBox10.BackColor == Color.White &&
                comboBox11.BackColor == Color.White &&
                comboBox12.BackColor == Color.White &&
                panel1.BackColor == Color.Transparent &&
                panel2.BackColor == Color.Transparent &&
                maskedTextBox1.BackColor == Color.White)
            {
                PC pc = CreateObject();

                PC_list.Add(pc);
                pc = new PC();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PC_list = WorkWithFille.DeSerialize();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WorkWithFille.Serialize(PC_list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(PC_list != null)
            {
                double resPrice = 0;
                string listPCInLaboratory = string.Empty;

                for (int i = 0; i < PC_list.Count; i++)
                {
                    listPCInLaboratory += $"{i + 1}-st " + Calculating.Price(PC_list[i]).ToString() + "\n";
                }

                listPCInLaboratory += "\n";

                foreach (var list in PC_list)
                {
                    resPrice += Calculating.Price(list);
                }

                listPCInLaboratory += "Result Pricen " + resPrice;

                richTextBox1.Text = listPCInLaboratory;
            }
            else
            {
                richTextBox1.Text = "We don't have save elements";
            }
        }
    }
}