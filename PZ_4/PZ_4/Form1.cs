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
                case "Январь": 
                case "Март":
                case "Май":
                case "Июль":
                case "Август":
                case "Октябрь":
                case "Декабрь": this.textBox1.Text = "31 день"; break;
                case "Апрель":
                case "Июнь":
                case "Сентябрь":
                case "Ноябрь": this.textBox1.Text = "30 дней"; break;
                case "Февраль":
                    DateTime dat = new DateTime();
                    int year = dat.Year;
                    if (year%4==0 || year%100==0 && year % 400==0) { this.textBox1.Text = "В этом году в феврале 29 дней";}
                    else { this.textBox1.Text = "В этом году в феврале 28 дней"; }
                    break;
                default:
                    MessageBox.Show("ОШИБКА! ВВЕДЕНО НЕВЕРНОЕ ЗНАЧЕНИЕ ИЛИ НЕ ВВЕДЕНО ВОВСЕ!", "ОШИБКА!");
                    break;
            }
        }
    }
}