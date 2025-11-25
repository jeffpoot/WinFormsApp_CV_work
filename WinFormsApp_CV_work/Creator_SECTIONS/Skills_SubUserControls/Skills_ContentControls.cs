using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_CV_work.Creator_SECTIONS.Skills_SubUserControls
{
    public partial class Skills_ContentControls : UserControl
    {
        public Skills_ContentControls()
        {
            InitializeComponent();
        }

        private void SkillsRMV_tbx_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }
    }
}
