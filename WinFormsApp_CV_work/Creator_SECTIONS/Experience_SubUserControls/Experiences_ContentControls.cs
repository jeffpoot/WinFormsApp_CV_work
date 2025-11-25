using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_CV_work.Creator_SECTIONS.Experience_SubUserControls
{
    public partial class Experiences_ContentControls : UserControl
    {
        public Experiences_ContentControls()
        {
            InitializeComponent();
        }

        private void ExpAddress_tbx_ContentChanged(object sender, EventArgs e)
        {

        }

        private void ExpRMV_tbx_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }
    }
}
