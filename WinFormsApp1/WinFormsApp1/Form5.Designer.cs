namespace WinFormsApp1
{
    partial class Form5
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
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button4 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 72);
            label4.Name = "label4";
            label4.Size = new Size(215, 30);
            label4.TabIndex = 21;
            label4.Text = "Новый пользователь";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 138);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 20;
            label3.Text = "Роль";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(128, 23);
            textBox3.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 201);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 18;
            label2.Text = "Пароль ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 138);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 17;
            label1.Text = "Логин";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 15;
            // 
            // button4
            // 
            button4.Location = new Point(99, 286);
            button4.Name = "button4";
            button4.Size = new Size(102, 23);
            button4.TabIndex = 14;
            button4.Text = "Регистрация";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 201);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 23;
            label5.Text = "ФИ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(128, 23);
            textBox4.TabIndex = 22;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 341);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button4;
        private Label label5;
        private TextBox textBox4;
    }
}