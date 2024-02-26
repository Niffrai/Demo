namespace WinFormsApp1
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(494, 260);
            dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(21, 373);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(494, 260);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 355);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 14;
            label5.Text = "Статус и смены";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 25);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 15;
            label6.Text = "Заказы";
            // 
            // button1
            // 
            button1.Location = new Point(571, 145);
            button1.Name = "button1";
            button1.Size = new Size(187, 44);
            button1.TabIndex = 16;
            button1.Text = "Регистрация пользователя";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(398, 323);
            button2.Name = "button2";
            button2.Size = new Size(103, 30);
            button2.TabIndex = 17;
            button2.Text = "Заполнить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(398, 651);
            button3.Name = "button3";
            button3.Size = new Size(103, 30);
            button3.TabIndex = 18;
            button3.Text = "Заполнить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(718, 508);
            button4.Name = "button4";
            button4.Size = new Size(79, 30);
            button4.TabIndex = 19;
            button4.Text = "Обновить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(571, 479);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(571, 541);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 23);
            textBox2.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(571, 461);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 22;
            label1.Text = "1 Смена";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(571, 523);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 23;
            label2.Text = "2 Смена";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 689);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}