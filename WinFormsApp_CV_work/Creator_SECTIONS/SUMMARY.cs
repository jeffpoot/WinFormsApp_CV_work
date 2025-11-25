using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_CV_work.Creator_SECTIONS
{
    public partial class SUMMARY : UserControl
    {

        public event EventHandler EditClicked;


        public SUMMARY()
        {
            InitializeComponent();
        }

        private void summaryEdit_bttn_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
