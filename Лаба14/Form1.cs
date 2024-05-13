namespace Лаба14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text; // Название товара
            string Kv = comboBox2.Text; // Кол-во
            string Sum = textBox2.Text; // Сумма
            string Pay = comboBox1.Text; // Способ оплаты
            
            int kol = int.Parse(comboBox2.Text); // Пример : количество

            string orderInfo = $"Название товара : {name}" +
                               $"Cумма : {Sum}" +
                               $"Способ оплаты : {Pay}" +
                               $"Кол-во: {Kv}";

            listBox1.Items.Add(orderInfo);

            tabControl1.SelectedIndex = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
