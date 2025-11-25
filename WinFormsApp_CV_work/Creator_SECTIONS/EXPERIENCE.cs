using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_CV_work.Creator_SECTIONS.Experience_SubUserControls;

namespace WinFormsApp_CV_work.Creator_SECTIONS
{
    public partial class EXPERIENCE : UserControl
    {
        public EXPERIENCE()
        {
            InitializeComponent();
        }

        private void EXPERIENCE_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.HorizontalScroll.Visible = false;
            flowLayoutPanel1.HorizontalScroll.Maximum = 0;
        }

        private void JobAdd_btt_Click(object sender, EventArgs e)
        {
            Experiences_ContentControls experiences_ContentControls = new Experiences_ContentControls();
            flowLayoutPanel1.Controls.Add(experiences_ContentControls);
        }
    }
}
