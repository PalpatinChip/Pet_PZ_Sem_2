namespace PZ_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            int numb;
            int[] numbers;
            int k = 1;
            try
            {
                numb = Convert.ToInt32(this.textBox1.Text);

                numbers = new int[numb];

                for (int i = 0; i < numb; i++)
                {
                    numbers[i] = k;
                    k += 2;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ÎØÈÁÊÀ! ÂÂÅÄÅÍÎ ÎØÈÁÎ×ÍÎÅ ÇÍÀ×ÅÍÈÅ ÈËÈ ÎÍÎ ÍÅ ÂÂÅÄÅÍÎ ÂÎÂÑÅ!", "ÎØÈÁÊÀ!");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("ÎØÈÁÊÀ! ÍÅÄÎÏÓÑÒÈÌÎÅ ÇÍÀ×ÅÍÈÅ ÐÀÇÌÅÐÀ ÌÀÑÑÈÂÀ!", "ÎØÈÁÊÀ!");
                return;
            }
            
            for (int j = 0; j < numbers.Length; j++)
            {
                this.listBox1.Items.Add(numbers[j]);
            }

        }
    }
}