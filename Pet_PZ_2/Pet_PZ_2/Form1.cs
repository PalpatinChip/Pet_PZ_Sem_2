

namespace Pet_PZ_2
{
    public partial class PZ_2 : Form
    {
        public PZ_2()
        {
            InitializeComponent();
        }

        private void PZ_2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = 0;
            int x2 = 0;
            try
            {
                x1 = Convert.ToInt32(this.textBox1.Text);
                x2 = Convert.ToInt32(this.textBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("ньхайю! ббедемн хкх мейнпейрмше гмювемхъ, хкх ме ббедемш бнбяе!");
                return;
            }
            int s = Math.Abs(x1 - x2);

            this.textBox3.Text = Convert.ToString(s);
            
        }
    }
}