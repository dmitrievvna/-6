namespace Лаба14
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tabPage2 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(11, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(623, 404);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Azure;
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(615, 371);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Location = new Point(434, 315);
            button2.Name = "button2";
            button2.Size = new Size(145, 29);
            button2.TabIndex = 28;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Location = new Point(163, 315);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 27;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.GradientInactiveCaption;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(139, 149);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(455, 28);
            comboBox2.TabIndex = 26;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.GradientInactiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(139, 255);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(455, 28);
            comboBox1.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.GradientInactiveCaption;
            textBox3.Location = new Point(139, 40);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(455, 27);
            textBox3.TabIndex = 24;
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GradientInactiveCaption;
            textBox2.Location = new Point(139, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(455, 27);
            textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientInactiveCaption;
            textBox1.Location = new Point(139, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(455, 27);
            textBox1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Location = new Point(277, 13);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 16;
            label1.Text = "Оформление заказа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 40);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 17;
            label2.Text = "Название товара";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 97);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 18;
            label3.Text = "Сумма";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 149);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 19;
            label4.Text = "Количество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 203);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 20;
            label5.Text = "Адрес доставки";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 258);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 21;
            label6.Text = "Способ оплаты";
            label6.Click += label6_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Azure;
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(615, 371);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.InactiveCaption;
            button4.Location = new Point(375, 227);
            button4.Name = "button4";
            button4.Size = new Size(161, 48);
            button4.TabIndex = 3;
            button4.Text = "Возврат";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InactiveCaption;
            button3.Location = new Point(375, 85);
            button3.Name = "button3";
            button3.Size = new Size(161, 49);
            button3.TabIndex = 2;
            button3.Text = "Повтор заказа";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.GradientInactiveCaption;
            textBox4.Location = new Point(33, 55);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(278, 271);
            textBox4.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.InactiveCaption;
            label7.Location = new Point(261, 15);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 0;
            label7.Text = "Список заказа";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(635, 417);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button button1;
        private Label label7;
        private Button button4;
        private Button button3;
        private TextBox textBox4;
    }
}
