using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PZ_8
{
    public partial class Form1 : Form
    {
        public int razmM, razmN;
        int[,] matr;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.matrix.Rows.Clear();
            this.txtBoxResult.Clear();

            try
            {
                this.razmM = Convert.ToInt32(this.txtBoxM.Text);
                this.razmN = Convert.ToInt32(this.txtBoxN.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("ньхайю! ббедемн ньханвмне гмювемхе хкх нмн ме ббедемн бнбяе!", "ньхайю!");
                return;
            }

            try
            {
                this.matrix.RowCount = this.razmN;
                this.matrix.CurrentCell = null;
                this.matrix.ColumnCount = this.razmM;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("медносярхлне йнкхвеярбн ярпнй хкх ярнкажнб люрпхжш!", "ньхайю!");
                return;
            }
            this.matr = new int[this.razmN, this.razmM];
            Random rand = new Random();
            for (int i = 0; i < this.razmN; i++)
            {
                for (int j = 0; j < this.razmM; j++)
                {
                    this.matr[i, j] = rand.Next(-50, 51);
                    this.matrix.Rows[i].Cells[j].Value = this.matr[i, j];
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtBoxM.Clear();
            this.txtBoxN.Clear();
            this.matrix.Rows.Clear();
            this.txtBoxResult.Clear();

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            this.txtBoxResult.Clear();
            int max = -100;
            int sum = 0;

            for (int i = 0; i < this.razmN; i++)
            {
                for (int j = 0; j < this.razmM; j++)
                {
                    if (this.matr[i, j] > max)
                    {
                        max = this.matr[i, j];
                    }

                }
                sum += max;
                max = -100;
            }
            this.txtBoxResult.Text = sum.ToString();
        }
    }
}