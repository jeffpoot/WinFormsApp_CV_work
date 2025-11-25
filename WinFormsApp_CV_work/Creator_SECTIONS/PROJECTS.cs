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
using WinFormsApp_CV_work.Creator_SECTIONS.Project_SubUserControls;

namespace WinFormsApp_CV_work.Creator_SECTIONS
{
    public partial class PROJECTS : UserControl
    {
        public PROJECTS()
        {
            InitializeComponent();
        }

        private void PROJECTS_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.HorizontalScroll.Visible = false;
            flowLayoutPanel1.HorizontalScroll.Maximum = 0;
        }

        private void SkillsAdd_btt_Click(object sender, EventArgs e)
        {
            Project_ContentControls project_ContentControls= new Project_ContentControls();
            flowLayoutPanel1.Controls.Add(project_ContentControls);
        }
    }
}
