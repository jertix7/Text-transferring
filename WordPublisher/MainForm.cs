using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace WordPublisher
{
    public partial class MainForm : Form
    {

        public string sFilePath;

        public MainForm()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbxDirWord.ReadOnly = true;
            tbxDirPublisher.ReadOnly = true;
            saveFileDialog.Filter = "Word File(*.docx)|*.docx|Publisher File(*.pub)|*.pub|All files(*.*)|*.*";
            openFileDialog1.Filter = "Word File(*.docx)|*.docx|Publisher File(*.pub)|*.pub|All files(*.*)|*.*";
        }

        private void btnChooseDirWord_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                var wordApp = new Word.Application();
                wordApp.Visible = false;

                try
                {
                    sFilePath = openFileDialog1.FileName;
                    tbxDirWord.Text = sFilePath;

                    var wordDocument = wordApp.Documents.Open(sFilePath);

                    wordDocument.Close();
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка!", "Attention!", MessageBoxButtons.OK);
                }
                finally
                {
                    wordApp.Quit();
                }
            }
            else return;
        }

        private void lblChooseDirPub_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFilePath = openFileDialog1.FileName;
                tbxDirPublisher.Text = sFilePath;
            }
            else return;
        }

        private void btnTransText_Click(object sender, EventArgs e)
        {

        }
    }
}
