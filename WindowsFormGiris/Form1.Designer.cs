namespace WindowsFormGiris
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            button4 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            button6 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            checkedListBox1 = new CheckedListBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(202, 238);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Tıkla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 242);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 2;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 16);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Göster";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 57);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.MouseEnter += button3_MouseEnter;
            button3.MouseLeave += button3_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 61);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // button4
            // 
            button4.Location = new Point(12, 90);
            button4.Name = "button4";
            button4.Size = new Size(75, 47);
            button4.TabIndex = 5;
            button4.Text = "Form Adını Değiştir ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            button4.MouseEnter += button3_MouseEnter;
            button4.MouseLeave += button3_MouseLeave;
            // 
            // button5
            // 
            button5.Location = new Point(12, 143);
            button5.Name = "button5";
            button5.Size = new Size(75, 48);
            button5.TabIndex = 7;
            button5.Text = "renk Değişen";
            button5.UseVisualStyleBackColor = true;
            button5.MouseEnter += button5_MouseEnter;
            button5.MouseLeave += button5_MouseLeave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(181, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 179);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Merhaba";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 49);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 3;
            label5.Text = "label5";
            // 
            // button6
            // 
            button6.Location = new Point(50, 49);
            button6.Name = "button6";
            button6.Size = new Size(100, 23);
            button6.TabIndex = 2;
            button6.Text = "Göster";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 16);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 16);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 0;
            label4.Text = "Ad";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(428, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(568, 28);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(58, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "futbol";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "muz", "kivi", "çilek", "ananas", "mango", "portakal" });
            checkedListBox1.Location = new Point(714, 25);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 112);
            checkedListBox1.TabIndex = 13;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(319, 216);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Evet";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(372, 216);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(53, 19);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hayır";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(568, 57);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 16;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(431, 218);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 17;
            label7.Text = "label7";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Umut", "Sena", "Oğuzhan", "Ahmet", "Meryem" });
            listBox1.Location = new Point(543, 172);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 109);
            listBox1.TabIndex = 18;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(669, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 283);
            Controls.Add(textBox3);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Label label3;
        private Button button4;
        private Button button5;
        private GroupBox groupBox1;
        private Label label5;
        private Button button6;
        private TextBox textBox2;
        private Label label4;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private CheckedListBox checkedListBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
        private Label label7;
        private ListBox listBox1;
        private TextBox textBox3;
    }
}
