using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PZ_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            int razm = 0;
            char c1, c2;
            string newString = "";
            try
            {
                razm = Convert.ToInt32(this.txtBoxInput.Text);
                c1 = Convert.ToChar(this.txtBoxC1.Text);
                c2 = Convert.ToChar(this.txtBoxC2.Text);
                if (razm % 2 != 0 ) { throw new FormatException(); }
            }
            catch (FormatException)
            {
                MessageBox.Show("ньхайю! ббедемн ньханвмне гмювемхе хкх нмн ме ббедемн бнбяе!", "ньхайю!");
                return;
            }
            for (int i = 0; i< razm; i++) { newString += (Convert.ToString(c1) + Convert.ToString(c2)); }
            this.txtBoxOutput.Text = newString;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtBoxInput.Clear();
            this.txtBoxOutput.Clear();
        }
    }
}