using System.Windows.Forms.VisualStyles;

namespace PZ_7
{
    public partial class Form1 : Form
    {
        public int razm, countPol = 0, countOtr = 0;
        public int[] baseNumbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void createMassBtn_Click(object sender, EventArgs e)
        {
            this.baseMassList.Items.Clear();
            this.polList.Items.Clear();
            this.otrList.Items.Clear();
            Random rand = new Random();
            this.countPol = 0;
            this.countOtr = 0; 
            try
            {
                this.razm = Convert.ToInt32(this.massRazmInputBox.Text);

                this.baseNumbers = new int[this.razm];

                for (int i = 0; i < this.razm; i++)
                {
                    this.baseNumbers[i] = rand.Next(-10, 10);
                    if (this.baseNumbers[i] > 0) { this.countPol += 1; }
                    else if (this.baseNumbers[i] < 0) { this.countOtr += 1; }
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
            for (int i = 0; i < this.baseNumbers.Length; i++)
            {
                this.baseMassList.Items.Add(this.baseNumbers[i]);
            }
            this.proceedBtn.Enabled = true;
            this.proceedBtn.Visible = true;


        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.baseMassList.Items.Clear();
            this.polList.Items.Clear();
            this.otrList.Items.Clear();
            this.otrRazmBox.Clear();
            this.polRazmBox.Clear();
            this.proceedBtn.Enabled = false;
            this.proceedBtn.Visible = false;
            
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {

            this.polList.Items.Clear();
            this.otrList.Items.Clear();
            int[] allPol = new int[this.countPol];
            int[] allOtr = new int[this.countOtr];
            int cPol = 0, cOtr = 0;
            

            this.proceedBtn.Enabled = false;
            this.proceedBtn.Visible = false;

            for (int j = 0; j < this.baseNumbers.Length; j++)
            {
                if (this.baseNumbers[j] > 0) { allPol[cPol] = this.baseNumbers[j]; cPol++; }
                else if (this.baseNumbers[j] < 0) { allOtr[cOtr] = this.baseNumbers[j]; cOtr++; }
            }

            this.polRazmBox.Text = this.countPol.ToString();
            this.otrRazmBox.Text = this.countOtr.ToString();

            for (int i = 0; i < this.countPol; i++)
            {
                this.polList.Items.Add(allPol[i].ToString());
            }
            for (int i = 0; i < this.countOtr; i++)
            {
                this.otrList.Items.Add(allOtr[i]);
            }
            
            
        }
    }
}
