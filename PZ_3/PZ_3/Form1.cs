namespace PZ_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            try
            {
                a = Convert.ToInt32(this.textBox1.Text);
                b = Convert.ToInt32(this.textBox2.Text);
                c = Convert.ToInt32(this.textBox3.Text);
            } catch(FormatException)
            {
                MessageBox.Show("ОШИБКА! ВВЕДЕНЫ ИЛИ НЕПРАВИЛЬНЫЕ ЗНАЧЕНИЯ ИЛИ ЗНАЧЕНИЯ НЕ ВВЕДЕНЫ ВОВСЕ!", "ОШИБКА!");
                return;
            }
            int a_to_b = Math.Abs(a - b);
            int a_to_c = Math.Abs(a - c);
            if (a == b && b == c) { this.textBox4.Text = $"Точки A, В и С совпадают между собой!"; }
            else if (b == c) { this.textBox4.Text = $"Точки В и С совпадают между собой!"; }
            else if (a == b) { this.textBox4.Text = $"Точки A и B совпадают между собой!"; }
            else if (a == c) { this.textBox4.Text = $"Точки A и C совпадают между собой!"; }
            else if (a_to_b < a_to_c) { this.textBox4.Text = $"Ближайшая к А точка - B, расстояние: {a_to_b}"; }
            else if (a_to_b > a_to_c) { this.textBox4.Text = $"Ближайшая к А точка - C, расстояние: {a_to_c}"; }  
            else if (a_to_b == a_to_c) { this.textBox4.Text = $"Расстояние между точками В и С одинаково и равно {a_to_b}"; }
        }
    }
}