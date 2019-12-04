using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            saveFileDialog.Filter = "Word File(*.doc)|*.doc|Publisher File(*.pub)|*.pub|All files(*.*)|*.*";
        }

        private void btnChooseDirWord_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sFilePath = saveFileDialog.FileName;
                tbxDirWord.Text = sFilePath;
            }
            else return;
        }
    }
}
