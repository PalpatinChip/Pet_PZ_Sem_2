namespace PZ_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (this.comboBox1.Text)
            {
                case "������": 
                case "����":
                case "���":
                case "����":
                case "������":
                case "�������":
                case "�������": this.textBox1.Text = "31 ����"; break;
                case "������":
                case "����":
                case "��������":
                case "������": this.textBox1.Text = "30 ����"; break;
                case "�������":
                    DateTime dat = new DateTime();
                    int year = dat.Year;
                    if (year%4==0 || year%100==0 && year % 400==0) { this.textBox1.Text = "� ���� ���� � ������� 29 ����";}
                    else { this.textBox1.Text = "� ���� ���� � ������� 28 ����"; }
                    break;
                default:
                    MessageBox.Show("������! ������� �������� �������� ��� �� ������� �����!", "������!");
                    break;
            }
        }
    }
}