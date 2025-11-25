using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_CV_work.Creator_SECTIONS.Project_SubUserControls
{
    public partial class Project_ContentControls : UserControl
    {
        public Project_ContentControls()
        {
            InitializeComponent();
        }

        private void ProjectRMV_tbx_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

        
    }
}
