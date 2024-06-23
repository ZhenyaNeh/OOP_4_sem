using System.Windows.Forms;

namespace laba_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainText = new Label();
            genderText = new Label();
            wigthText = new Label();
            wightBox = new TextBox();
            hightBox = new TextBox();
            hightText = new Label();
            ageBox = new TextBox();
            ageText = new Label();
            activityText = new Label();
            activityCombo = new ComboBox();
            ansverButton = new Button();
            firePicture = new PictureBox();
            menRadio = new RadioButton();
            womenRadio = new RadioButton();
            genderGroup = new GroupBox();
            ansverNumberText = new Label();
            ansverText = new Label();
            fone = new Panel();
            ((System.ComponentModel.ISupportInitialize)firePicture).BeginInit();
            SuspendLayout();
            // 
            // mainText
            // 
            mainText.AutoSize = true;
            mainText.BackColor = Color.Tan;
            mainText.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            mainText.Location = new Point(40, 36);
            mainText.Name = "mainText";
            mainText.Size = new Size(359, 60);
            mainText.TabIndex = 0;
            mainText.Text = "Calorie calculator";
            // 
            // genderText
            // 
            genderText.AutoSize = true;
            genderText.Location = new Point(69, 133);
            genderText.Name = "genderText";
            genderText.Size = new Size(73, 25);
            genderText.TabIndex = 1;
            genderText.Text = "Gender:";
            // 
            // wigthText
            // 
            wigthText.AutoSize = true;
            wigthText.Location = new Point(69, 178);
            wigthText.Name = "wigthText";
            wigthText.Size = new Size(107, 25);
            wigthText.TabIndex = 6;
            wigthText.Text = "Weight (kg):";
            // 
            // wightBox
            // 
            wightBox.Location = new Point(182, 178);
            wightBox.Name = "wightBox";
            wightBox.Size = new Size(217, 31);
            wightBox.TabIndex = 7;
            wightBox.TextChanged += textBox1_TextChanged;
            // 
            // hightBox
            // 
            hightBox.Location = new Point(182, 223);
            hightBox.Name = "hightBox";
            hightBox.Size = new Size(217, 31);
            hightBox.TabIndex = 9;
            hightBox.TextChanged += textBox2_TextChanged;
            // 
            // hightText
            // 
            hightText.AutoSize = true;
            hightText.Location = new Point(69, 223);
            hightText.Name = "hightText";
            hightText.Size = new Size(108, 25);
            hightText.TabIndex = 8;
            hightText.Text = "Height (sm):";
            // 
            // ageBox
            // 
            ageBox.Location = new Point(182, 268);
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(217, 31);
            ageBox.TabIndex = 11;
            ageBox.TextChanged += textBox3_TextChanged;
            // 
            // ageText
            // 
            ageText.AutoSize = true;
            ageText.Location = new Point(69, 268);
            ageText.Name = "ageText";
            ageText.Size = new Size(48, 25);
            ageText.TabIndex = 10;
            ageText.Text = "Age:";
            // 
            // activityText
            // 
            activityText.AutoSize = true;
            activityText.Location = new Point(69, 312);
            activityText.Name = "activityText";
            activityText.Size = new Size(103, 25);
            activityText.TabIndex = 12;
            activityText.Text = "Life activity:";
            // 
            // activityCombo
            // 
            activityCombo.FormattingEnabled = true;
            activityCombo.Items.AddRange(new object[] { "Отсутствие нагрузок", "Минимальные кардио", "Занятия спортом", "Полноценные трен.", "Профессиональные" });
            activityCombo.Location = new Point(182, 312);
            activityCombo.Name = "activityCombo";
            activityCombo.Size = new Size(217, 33);
            activityCombo.TabIndex = 13;
            activityCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ansverButton
            // 
            ansverButton.Location = new Point(287, 374);
            ansverButton.Name = "ansverButton";
            ansverButton.Size = new Size(112, 34);
            ansverButton.TabIndex = 14;
            ansverButton.Text = "Сalculation";
            ansverButton.UseVisualStyleBackColor = true;
            ansverButton.Click += button1_Click;
            // 
            // firePicture
            // 
            firePicture.Image = Properties.Resources.cal2;
            firePicture.InitialImage = null;
            firePicture.Location = new Point(459, 97);
            firePicture.Name = "firePicture";
            firePicture.Size = new Size(329, 292);
            firePicture.SizeMode = PictureBoxSizeMode.Zoom;
            firePicture.TabIndex = 15;
            firePicture.TabStop = false;
            // 
            // menRadio
            // 
            menRadio.AutoSize = true;
            menRadio.Location = new Point(219, 133);
            menRadio.Name = "menRadio";
            menRadio.Size = new Size(72, 29);
            menRadio.TabIndex = 16;
            menRadio.TabStop = true;
            menRadio.Text = "Men";
            menRadio.UseVisualStyleBackColor = true;
            menRadio.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // womenRadio
            // 
            womenRadio.AutoSize = true;
            womenRadio.Location = new Point(300, 133);
            womenRadio.Name = "womenRadio";
            womenRadio.Size = new Size(99, 29);
            womenRadio.TabIndex = 17;
            womenRadio.TabStop = true;
            womenRadio.Text = "Women";
            womenRadio.UseVisualStyleBackColor = true;
            womenRadio.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // genderGroup
            // 
            genderGroup.Location = new Point(202, 99);
            genderGroup.Name = "genderGroup";
            genderGroup.Size = new Size(197, 71);
            genderGroup.TabIndex = 18;
            genderGroup.TabStop = false;
            genderGroup.Text = "groupBox1";
            genderGroup.Visible = false;
            // 
            // ansverNumberText
            // 
            ansverNumberText.AutoSize = true;
            ansverNumberText.BackColor = Color.Transparent;
            ansverNumberText.Font = new Font("Swis721 BlkCn BT", 22F, FontStyle.Regular, GraphicsUnit.Point);
            ansverNumberText.ForeColor = Color.FromArgb(90, 47, 37);
            ansverNumberText.Location = new Point(571, 204);
            ansverNumberText.Name = "ansverNumberText";
            ansverNumberText.Size = new Size(0, 52);
            ansverNumberText.TabIndex = 19;
            // 
            // ansverText
            // 
            ansverText.AutoSize = true;
            ansverText.BackColor = Color.Transparent;
            ansverText.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ansverText.ForeColor = Color.FromArgb(90, 47, 37);
            ansverText.Location = new Point(459, 374);
            ansverText.MaximumSize = new Size(300, 0);
            ansverText.Name = "ansverText";
            ansverText.Size = new Size(0, 32);
            ansverText.TabIndex = 20;
            ansverText.TextAlign = ContentAlignment.TopCenter;
            // 
            // fone
            // 
            fone.BackColor = Color.Tan;
            fone.Dock = DockStyle.Fill;
            fone.Location = new Point(0, 0);
            fone.Name = "fone";
            fone.Size = new Size(800, 458);
            fone.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(800, 458);
            Controls.Add(ansverText);
            Controls.Add(ansverNumberText);
            Controls.Add(womenRadio);
            Controls.Add(menRadio);
            Controls.Add(firePicture);
            Controls.Add(ansverButton);
            Controls.Add(activityCombo);
            Controls.Add(activityText);
            Controls.Add(ageBox);
            Controls.Add(ageText);
            Controls.Add(hightBox);
            Controls.Add(hightText);
            Controls.Add(wightBox);
            Controls.Add(wigthText);
            Controls.Add(genderText);
            Controls.Add(mainText);
            Controls.Add(genderGroup);
            Controls.Add(fone);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calorie calculator";
            ((System.ComponentModel.ISupportInitialize)firePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainText;
        private Label genderText;
        private Label wigthText;
        private Label hightText;
        private Label ageText;
        private Label activityText;
        private TextBox wightBox;
        private TextBox hightBox;
        private TextBox ageBox;
        private ComboBox activityCombo;
        private PictureBox firePicture;
        private Button ansverButton;
        private RadioButton menRadio;
        private RadioButton womenRadio;
        private GroupBox genderGroup;
        private Label ansverNumberText;
        private Label label8;
        private Label ansverText;
        private Panel fone;
    }
}