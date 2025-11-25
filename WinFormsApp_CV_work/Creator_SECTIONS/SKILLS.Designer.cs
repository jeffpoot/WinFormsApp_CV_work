namespace WinFormsApp_CV_work.Creator_SECTIONS
{
    partial class SKILLS
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SkillsAdd_btt = new CuoreUI.Controls.cuiButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // SkillsAdd_btt
            // 
            SkillsAdd_btt.CheckButton = false;
            SkillsAdd_btt.Checked = false;
            SkillsAdd_btt.CheckedBackground = Color.FromArgb(255, 106, 0);
            SkillsAdd_btt.CheckedForeColor = Color.White;
            SkillsAdd_btt.CheckedImageTint = Color.White;
            SkillsAdd_btt.CheckedOutline = Color.FromArgb(255, 106, 0);
            SkillsAdd_btt.Content = "+";
            SkillsAdd_btt.DialogResult = DialogResult.None;
            SkillsAdd_btt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SkillsAdd_btt.ForeColor = Color.White;
            SkillsAdd_btt.HoverBackground = Color.White;
            SkillsAdd_btt.HoverForeColor = Color.Black;
            SkillsAdd_btt.HoverImageTint = Color.White;
            SkillsAdd_btt.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            SkillsAdd_btt.Image = null;
            SkillsAdd_btt.ImageAutoCenter = true;
            SkillsAdd_btt.ImageExpand = new Point(0, 0);
            SkillsAdd_btt.ImageOffset = new Point(0, 0);
            SkillsAdd_btt.Location = new Point(520, 8);
            SkillsAdd_btt.Margin = new Padding(3, 2, 3, 2);
            SkillsAdd_btt.Name = "SkillsAdd_btt";
            SkillsAdd_btt.NormalBackground = Color.FromArgb(136, 116, 249);
            SkillsAdd_btt.NormalForeColor = Color.White;
            SkillsAdd_btt.NormalImageTint = Color.White;
            SkillsAdd_btt.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            SkillsAdd_btt.OutlineThickness = 1F;
            SkillsAdd_btt.PressedBackground = Color.WhiteSmoke;
            SkillsAdd_btt.PressedForeColor = Color.FromArgb(32, 32, 32);
            SkillsAdd_btt.PressedImageTint = Color.White;
            SkillsAdd_btt.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            SkillsAdd_btt.Rounding = new Padding(20);
            SkillsAdd_btt.Size = new Size(40, 40);
            SkillsAdd_btt.TabIndex = 1;
            SkillsAdd_btt.TextAlignment = StringAlignment.Center;
            SkillsAdd_btt.TextOffset = new Point(0, 0);
            SkillsAdd_btt.Click += SkillsAdd_btt_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoScrollMinSize = new Size(557, 2000);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 56);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(576, 512);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // SKILLS
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 246, 255);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SkillsAdd_btt);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SKILLS";
            Size = new Size(576, 568);
            Load += SKILLS_Load;
            ResumeLayout(false);
        }

        #endregion
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton SkillsAdd_btt;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
