namespace WinFormsApp1
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Блюдо";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 61);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Статус";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Оплачен", "Не оплачен" });
            comboBox2.Location = new Point(229, 79);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(130, 23);
            comboBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(140, 230);
            button1.Name = "button1";
            button1.Size = new Size(104, 49);
            button1.TabIndex = 4;
            button1.Text = "Оформить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(122, 297);
            button2.Name = "button2";
            button2.Size = new Size(141, 33);
            button2.TabIndex = 5;
            button2.Text = "Сформировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(229, 190);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 114);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "Человек";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 172);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 9;
            label4.Text = "Столик";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Паста карбонар", "Пиво 0.5", "Картошка по деревенски", "Смузи", "Котлетки" });
            checkedListBox1.Location = new Point(30, 66);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(163, 148);
            checkedListBox1.TabIndex = 10;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 342);
            Controls.Add(checkedListBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private CheckedListBox checkedListBox1;
    }
}