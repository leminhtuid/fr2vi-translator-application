using System;
using System.Windows.Forms;

namespace Fr2ViTranslator
{
    public partial class Translator : Form
    {
        public Translator()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            txtVietnamese.Text = String.Empty;

            string input = txtFrench.Text.ToLower();

            if (input == String.Empty)
            {
                MessageBox.Show("Please input a word to translate",
                    "Empty input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                Fr2EnTranslatorService.Fr2EnTranslatorService fr2enService
                    = new Fr2EnTranslatorService.Fr2EnTranslatorService();
                En2ViTranslatorService.En2ViTranslatorService en2viService
                    = new En2ViTranslatorService.En2ViTranslatorService();

                try
                {
                    string output = en2viService.TransEn2Vi(fr2enService.TransFr2En(input));

                    if (output == null)
                    {
                        lblWarning.Text = "* This word is not in dictionary";
                    }
                    else
                    {
                        txtVietnamese.Text = output;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtFrench_TextChanged(object sender, EventArgs e)
        {
            lblWarning.Text = String.Empty;
        }
    }
}
