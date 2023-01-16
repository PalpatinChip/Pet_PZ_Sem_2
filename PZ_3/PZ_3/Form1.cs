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
                MessageBox.Show("������! ������� ��� ������������ �������� ��� �������� �� ������� �����!", "������!");
                return;
            }
            int a_to_b = Math.Abs(a - b);
            int a_to_c = Math.Abs(a - c);
            if (a == b && b == c) { this.textBox4.Text = $"����� A, � � � ��������� ����� �����!"; }
            else if (b == c) { this.textBox4.Text = $"����� � � � ��������� ����� �����!"; }
            else if (a == b) { this.textBox4.Text = $"����� A � B ��������� ����� �����!"; }
            else if (a == c) { this.textBox4.Text = $"����� A � C ��������� ����� �����!"; }
            else if (a_to_b < a_to_c) { this.textBox4.Text = $"��������� � � ����� - B, ����������: {a_to_b}"; }
            else if (a_to_b > a_to_c) { this.textBox4.Text = $"��������� � � ����� - C, ����������: {a_to_c}"; }  
            else if (a_to_b == a_to_c) { this.textBox4.Text = $"���������� ����� ������� � � � ��������� � ����� {a_to_b}"; }
        }
    }
}