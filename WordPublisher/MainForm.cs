using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                sFilePath = openFileDialog1.FileName;
                tbxDirWord.Text = sFilePath;

                var wordApp = new Word.Application();
                wordApp.Visible = true;

                var wordDocument = wordApp.Documents.Open(sFilePath);
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
