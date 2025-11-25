namespace WinFormsApp_CV_work.Creator_SECTIONS
{
    partial class EXPERIENCE
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
            JobAdd_btt = new CuoreUI.Controls.cuiButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // JobAdd_btt
            // 
            JobAdd_btt.CheckButton = false;
            JobAdd_btt.Checked = false;
            JobAdd_btt.CheckedBackground = Color.FromArgb(255, 106, 0);
            JobAdd_btt.CheckedForeColor = Color.White;
            JobAdd_btt.CheckedImageTint = Color.White;
            JobAdd_btt.CheckedOutline = Color.FromArgb(255, 106, 0);
            JobAdd_btt.Content = "+";
            JobAdd_btt.DialogResult = DialogResult.None;
            JobAdd_btt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobAdd_btt.ForeColor = Color.White;
            JobAdd_btt.HoverBackground = Color.White;
            JobAdd_btt.HoverForeColor = Color.Black;
            JobAdd_btt.HoverImageTint = Color.White;
            JobAdd_btt.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            JobAdd_btt.Image = null;
            JobAdd_btt.ImageAutoCenter = true;
            JobAdd_btt.ImageExpand = new Point(0, 0);
            JobAdd_btt.ImageOffset = new Point(0, 0);
            JobAdd_btt.Location = new Point(520, 8);
            JobAdd_btt.Margin = new Padding(3, 2, 3, 2);
            JobAdd_btt.Name = "JobAdd_btt";
            JobAdd_btt.NormalBackground = Color.FromArgb(136, 116, 249);
            JobAdd_btt.NormalForeColor = Color.White;
            JobAdd_btt.NormalImageTint = Color.White;
            JobAdd_btt.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            JobAdd_btt.OutlineThickness = 1F;
            JobAdd_btt.PressedBackground = Color.WhiteSmoke;
            JobAdd_btt.PressedForeColor = Color.FromArgb(32, 32, 32);
            JobAdd_btt.PressedImageTint = Color.White;
            JobAdd_btt.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            JobAdd_btt.Rounding = new Padding(20);
            JobAdd_btt.Size = new Size(40, 40);
            JobAdd_btt.TabIndex = 1;
            JobAdd_btt.TextAlignment = StringAlignment.Center;
            JobAdd_btt.TextOffset = new Point(0, 0);
            JobAdd_btt.Click += JobAdd_btt_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoScrollMinSize = new Size(557, 2000);
            flowLayoutPanel1.Location = new Point(0, 56);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.MaximumSize = new Size(576, 512);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(576, 512);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // EXPERIENCE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 255);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(JobAdd_btt);
            ForeColor = Color.FromArgb(30, 41, 57);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EXPERIENCE";
            Size = new Size(576, 568);
            Load += EXPERIENCE_Load;
            ResumeLayout(false);
        }

        #endregion
        private CuoreUI.Controls.cuiTextBox ExpJob_tbx;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private CuoreUI.Controls.cuiButton JobAdd_btt;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
