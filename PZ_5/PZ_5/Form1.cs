namespace PZ_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numb;
            try
            {
                numb = Convert.ToInt32(this.textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("������! ������� ��������� �������� ��� ��� �� ������� �����!", "������!");
                return;
            }
            this.listBox1.Items.Add(numb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int from_, to_;
            int sum = 0;
            try
            {
                from_ = Convert.ToInt32(this.textBox2.Text);
                to_ = Convert.ToInt32(this.textBox3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("������! ������� ��������� �������� ��� ��� �� ������� �����!", "������!");
                return;
            }
            if (from_ >= 0 && to_ >= 0)
            {
                try
                {
                    if (from_ < to_)
                    {
                        for (int i = from_; i <= to_; i++)
                        {
                            sum += Convert.ToInt32(this.listBox1.Items[i]);
                        }
                    }
                    else if (from_ > to_)
                    {
                        for (int i = from_; i >= to_; i--)
                        {
                            sum += Convert.ToInt32(this.listBox1.Items[i]);
                        }
                    }
                    else if (from_ == to_) { MessageBox.Show("����� ������� ����� ����� ������ ����������!", "��������!"); }
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("������! �� ����� �� ������� ��������� �����!", "������!");
                }

            }
            else
            {
                MessageBox.Show("������! ������� �������� ������ ����!", "������!");
            }

            this.textBox4.Text = $"{from_} �� {to_} ����� {sum}"; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
        }
    }
}