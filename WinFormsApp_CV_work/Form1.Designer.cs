namespace WinFormsApp_CV_work
{
    partial class CV_Creator_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CV_Creator_Form));
            Appname_lb = new Label();
            Logo_Box = new PictureBox();
            Templatename_label = new Label();
            SubForm_panel = new CuoreUI.Controls.cuiPanel();
            Mainform_panel = new CuoreUI.Controls.cuiPanel();
            highlightPanel = new CuoreUI.Controls.cuiPanel();
            Personal_bttn = new CuoreUI.Controls.cuiButton();
            Preview_panel = new CuoreUI.Controls.cuiPanel();
            Sidepanel = new CuoreUI.Controls.cuiPanel();
            Summary_bttn = new CuoreUI.Controls.cuiButton();
            Projects_bttn = new CuoreUI.Controls.cuiButton();
            Skills_bttn = new CuoreUI.Controls.cuiButton();
            Experience_bttn = new CuoreUI.Controls.cuiButton();
            Education_bttn = new CuoreUI.Controls.cuiButton();
            Tips_lb = new Label();
            Section_lbl = new Label();
            Preview_lbl = new Label();
            NextButton = new CuoreUI.Controls.cuiButton();
            RandomTimer = new System.Windows.Forms.Timer(components);
            SummaryMain_pl = new Panel();
            ((System.ComponentModel.ISupportInitialize)Logo_Box).BeginInit();
            SubForm_panel.SuspendLayout();
            Sidepanel.SuspendLayout();
            SuspendLayout();
            // 
            // Appname_lb
            // 
            Appname_lb.AutoSize = true;
            Appname_lb.BackColor = Color.Transparent;
            Appname_lb.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Appname_lb.ForeColor = Color.FromArgb(30, 41, 57);
            Appname_lb.Location = new Point(31, 638);
            Appname_lb.Name = "Appname_lb";
            Appname_lb.Size = new Size(133, 25);
            Appname_lb.TabIndex = 3;
            Appname_lb.Text = "Flora Works CV";
            // 
            // Logo_Box
            // 
            Logo_Box.BackgroundImage = Properties.Resources._577112673_841970961753201_6380076590770753465_n;
            Logo_Box.BackgroundImageLayout = ImageLayout.Zoom;
            Logo_Box.Location = new Point(0, 638);
            Logo_Box.Margin = new Padding(3, 2, 3, 2);
            Logo_Box.Name = "Logo_Box";
            Logo_Box.Size = new Size(31, 26);
            Logo_Box.TabIndex = 2;
            Logo_Box.TabStop = false;
            // 
            // Templatename_label
            // 
            Templatename_label.AutoSize = true;
            Templatename_label.BackColor = Color.Transparent;
            Templatename_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Templatename_label.ForeColor = Color.FromArgb(30, 41, 57);
            Templatename_label.Location = new Point(58, 38);
            Templatename_label.Name = "Templatename_label";
            Templatename_label.Size = new Size(159, 25);
            Templatename_label.TabIndex = 0;
            Templatename_label.Text = "TEMPLATE NAME\r\n";
            Templatename_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubForm_panel
            // 
            SubForm_panel.BackColor = Color.Transparent;
            SubForm_panel.Controls.Add(Mainform_panel);
            SubForm_panel.Location = new Point(306, 56);
            SubForm_panel.Margin = new Padding(3, 2, 3, 2);
            SubForm_panel.Name = "SubForm_panel";
            SubForm_panel.OutlineThickness = 1F;
            SubForm_panel.PanelColor = Color.FromArgb(245, 246, 255);
            SubForm_panel.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            SubForm_panel.Rounding = new Padding(25);
            SubForm_panel.Size = new Size(591, 581);
            SubForm_panel.TabIndex = 1;
            // 
            // Mainform_panel
            // 
            Mainform_panel.BackColor = Color.Transparent;
            Mainform_panel.Location = new Point(8, 8);
            Mainform_panel.Margin = new Padding(3, 2, 3, 2);
            Mainform_panel.Name = "Mainform_panel";
            Mainform_panel.OutlineThickness = 1F;
            Mainform_panel.PanelColor = Color.FromArgb(245, 246, 255);
            Mainform_panel.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            Mainform_panel.Rounding = new Padding(25);
            Mainform_panel.Size = new Size(576, 568);
            Mainform_panel.TabIndex = 2;
            // 
            // highlightPanel
            // 
            highlightPanel.BackColor = Color.Transparent;
            highlightPanel.Location = new Point(6, 88);
            highlightPanel.Margin = new Padding(3, 2, 3, 2);
            highlightPanel.Name = "highlightPanel";
            highlightPanel.OutlineThickness = 1F;
            highlightPanel.PanelColor = Color.FromArgb(136, 116, 249);
            highlightPanel.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            highlightPanel.Rounding = new Padding(25);
            highlightPanel.Size = new Size(272, 56);
            highlightPanel.TabIndex = 2;
            // 
            // Personal_bttn
            // 
            Personal_bttn.BackColor = Color.Transparent;
            Personal_bttn.CheckButton = false;
            Personal_bttn.Checked = false;
            Personal_bttn.CheckedBackground = Color.Transparent;
            Personal_bttn.CheckedForeColor = Color.White;
            Personal_bttn.CheckedImageTint = Color.White;
            Personal_bttn.CheckedOutline = Color.FromArgb(255, 106, 0);
            Personal_bttn.Content = "Personal";
            Personal_bttn.DialogResult = DialogResult.None;
            Personal_bttn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Personal_bttn.ForeColor = Color.FromArgb(30, 41, 57);
            Personal_bttn.HoverBackground = Color.Transparent;
            Personal_bttn.HoverForeColor = Color.Black;
            Personal_bttn.HoverImageTint = Color.Transparent;
            Personal_bttn.HoverOutline = Color.FromArgb(136, 116, 249);
            Personal_bttn.Image = null;
            Personal_bttn.ImageAutoCenter = true;
            Personal_bttn.ImageExpand = new Point(0, 0);
            Personal_bttn.ImageOffset = new Point(0, 0);
            Personal_bttn.Location = new Point(15, 96);
            Personal_bttn.Margin = new Padding(3, 2, 3, 14);
            Personal_bttn.Name = "Personal_bttn";
            Personal_bttn.NormalBackground = Color.Transparent;
            Personal_bttn.NormalForeColor = Color.FromArgb(30, 41, 57);
            Personal_bttn.NormalImageTint = Color.White;
            Personal_bttn.NormalOutline = Color.Transparent;
            Personal_bttn.OutlineThickness = 1F;
            Personal_bttn.Padding = new Padding(100, 0, 0, 0);
            Personal_bttn.PressedBackground = Color.Transparent;
            Personal_bttn.PressedForeColor = Color.FromArgb(32, 32, 32);
            Personal_bttn.PressedImageTint = Color.White;
            Personal_bttn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            Personal_bttn.Rounding = new Padding(8);
            Personal_bttn.Size = new Size(254, 40);
            Personal_bttn.TabIndex = 0;
            Personal_bttn.TextAlignment = StringAlignment.Near;
            Personal_bttn.TextOffset = new Point(25, 0);
            Personal_bttn.Click += Personal_bttn_Click;
            // 
            // Preview_panel
            // 
            Preview_panel.BackColor = Color.Transparent;
            Preview_panel.Location = new Point(919, 56);
            Preview_panel.Margin = new Padding(3, 2, 3, 2);
            Preview_panel.Name = "Preview_panel";
            Preview_panel.OutlineThickness = 1F;
            Preview_panel.PanelColor = Color.FromArgb(245, 246, 255);
            Preview_panel.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            Preview_panel.Rounding = new Padding(25);
            Preview_panel.Size = new Size(459, 578);
            Preview_panel.TabIndex = 2;
            // 
            // Sidepanel
            // 
            Sidepanel.Controls.Add(Summary_bttn);
            Sidepanel.Controls.Add(Personal_bttn);
            Sidepanel.Controls.Add(Projects_bttn);
            Sidepanel.Controls.Add(Skills_bttn);
            Sidepanel.Controls.Add(Experience_bttn);
            Sidepanel.Controls.Add(Education_bttn);
            Sidepanel.Controls.Add(Appname_lb);
            Sidepanel.Controls.Add(Templatename_label);
            Sidepanel.Controls.Add(Logo_Box);
            Sidepanel.Controls.Add(highlightPanel);
            Sidepanel.Dock = DockStyle.Left;
            Sidepanel.Location = new Point(0, 0);
            Sidepanel.Margin = new Padding(3, 2, 3, 2);
            Sidepanel.Name = "Sidepanel";
            Sidepanel.OutlineThickness = 1F;
            Sidepanel.PanelColor = Color.FromArgb(245, 246, 255);
            Sidepanel.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            Sidepanel.Rounding = new Padding(8);
            Sidepanel.Size = new Size(284, 677);
            Sidepanel.TabIndex = 4;
            // 
            // Summary_bttn
            // 
            Summary_bttn.BackColor = Color.Transparent;
            Summary_bttn.CheckButton = false;
            Summary_bttn.Checked = false;
            Summary_bttn.CheckedBackground = Color.Transparent;
            Summary_bttn.CheckedForeColor = Color.White;
            Summary_bttn.CheckedImageTint = Color.White;
            Summary_bttn.CheckedOutline = Color.FromArgb(255, 106, 0);
            Summary_bttn.Content = "Summary";
            Summary_bttn.DialogResult = DialogResult.None;
            Summary_bttn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Summary_bttn.ForeColor = Color.FromArgb(30, 41, 57);
            Summary_bttn.HoverBackground = Color.Transparent;
            Summary_bttn.HoverForeColor = Color.Black;
            Summary_bttn.HoverImageTint = Color.Transparent;
            Summary_bttn.HoverOutline = Color.FromArgb(136, 116, 249);
            Summary_bttn.Image = null;
            Summary_bttn.ImageAutoCenter = true;
            Summary_bttn.ImageExpand = new Point(0, 0);
            Summary_bttn.ImageOffset = new Point(0, 0);
            Summary_bttn.Location = new Point(15, 376);
            Summary_bttn.Margin = new Padding(3, 2, 3, 14);
            Summary_bttn.Name = "Summary_bttn";
            Summary_bttn.NormalBackground = Color.Transparent;
            Summary_bttn.NormalForeColor = Color.FromArgb(30, 41, 57);
            Summary_bttn.NormalImageTint = Color.White;
            Summary_bttn.NormalOutline = Color.Transparent;
            Summary_bttn.OutlineThickness = 1F;
            Summary_bttn.Padding = new Padding(100, 0, 0, 0);
            Summary_bttn.PressedBackground = Color.Transparent;
            Summary_bttn.PressedForeColor = Color.FromArgb(32, 32, 32);
            Summary_bttn.PressedImageTint = Color.White;
            Summary_bttn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            Summary_bttn.Rounding = new Padding(8);
            Summary_bttn.Size = new Size(254, 40);
            Summary_bttn.TabIndex = 8;
            Summary_bttn.TextAlignment = StringAlignment.Near;
            Summary_bttn.TextOffset = new Point(25, 0);
            Summary_bttn.Click += Summary_bttn_Click;
            // 
            // Projects_bttn
            // 
            Projects_bttn.BackColor = Color.Transparent;
            Projects_bttn.CheckButton = false;
            Projects_bttn.Checked = false;
            Projects_bttn.CheckedBackground = Color.Transparent;
            Projects_bttn.CheckedForeColor = Color.White;
            Projects_bttn.CheckedImageTint = Color.White;
            Projects_bttn.CheckedOutline = Color.FromArgb(255, 106, 0);
            Projects_bttn.Content = "Projects";
            Projects_bttn.DialogResult = DialogResult.None;
            Projects_bttn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Projects_bttn.ForeColor = Color.FromArgb(30, 41, 57);
            Projects_bttn.HoverBackground = Color.Transparent;
            Projects_bttn.HoverForeColor = Color.Black;
            Projects_bttn.HoverImageTint = Color.Transparent;
            Projects_bttn.HoverOutline = Color.FromArgb(136, 116, 249);
            Projects_bttn.Image = null;
            Projects_bttn.ImageAutoCenter = true;
            Projects_bttn.ImageExpand = new Point(0, 0);
            Projects_bttn.ImageOffset = new Point(0, 0);
            Projects_bttn.Location = new Point(15, 320);
            Projects_bttn.Margin = new Padding(3, 2, 3, 14);
            Projects_bttn.Name = "Projects_bttn";
            Projects_bttn.NormalBackground = Color.Transparent;
            Projects_bttn.NormalForeColor = Color.FromArgb(30, 41, 57);
            Projects_bttn.NormalImageTint = Color.White;
            Projects_bttn.NormalOutline = Color.Transparent;
            Projects_bttn.OutlineThickness = 1F;
            Projects_bttn.Padding = new Padding(100, 0, 0, 0);
            Projects_bttn.PressedBackground = Color.Transparent;
            Projects_bttn.PressedForeColor = Color.FromArgb(32, 32, 32);
            Projects_bttn.PressedImageTint = Color.White;
            Projects_bttn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            Projects_bttn.Rounding = new Padding(8);
            Projects_bttn.Size = new Size(254, 40);
            Projects_bttn.TabIndex = 7;
            Projects_bttn.TextAlignment = StringAlignment.Near;
            Projects_bttn.TextOffset = new Point(25, 0);
            Projects_bttn.Click += Projects_bttn_Click;
            // 
            // Skills_bttn
            // 
            Skills_bttn.BackColor = Color.Transparent;
            Skills_bttn.CheckButton = false;
            Skills_bttn.Checked = false;
            Skills_bttn.CheckedBackground = Color.Transparent;
            Skills_bttn.CheckedForeColor = Color.White;
            Skills_bttn.CheckedImageTint = Color.White;
            Skills_bttn.CheckedOutline = Color.FromArgb(255, 106, 0);
            Skills_bttn.Content = "Skills";
            Skills_bttn.DialogResult = DialogResult.None;
            Skills_bttn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Skills_bttn.ForeColor = Color.FromArgb(30, 41, 57);
            Skills_bttn.HoverBackground = Color.Transparent;
            Skills_bttn.HoverForeColor = Color.Black;
            Skills_bttn.HoverImageTint = Color.Transparent;
            Skills_bttn.HoverOutline = Color.FromArgb(136, 116, 249);
            Skills_bttn.Image = null;
            Skills_bttn.ImageAutoCenter = true;
            Skills_bttn.ImageExpand = new Point(0, 0);
            Skills_bttn.ImageOffset = new Point(0, 0);
            Skills_bttn.Location = new Point(15, 264);
            Skills_bttn.Margin = new Padding(3, 2, 3, 14);
            Skills_bttn.Name = "Skills_bttn";
            Skills_bttn.NormalBackground = Color.Transparent;
            Skills_bttn.NormalForeColor = Color.FromArgb(30, 41, 57);
            Skills_bttn.NormalImageTint = Color.White;
            Skills_bttn.NormalOutline = Color.Transparent;
            Skills_bttn.OutlineThickness = 1F;
            Skills_bttn.Padding = new Padding(100, 0, 0, 0);
            Skills_bttn.PressedBackground = Color.Transparent;
            Skills_bttn.PressedForeColor = Color.FromArgb(32, 32, 32);
            Skills_bttn.PressedImageTint = Color.White;
            Skills_bttn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            Skills_bttn.Rounding = new Padding(8);
            Skills_bttn.Size = new Size(254, 40);
            Skills_bttn.TabIndex = 6;
            Skills_bttn.TextAlignment = StringAlignment.Near;
            Skills_bttn.TextOffset = new Point(25, 0);
            Skills_bttn.Click += Skills_bttn_Click;
            // 
            // Experience_bttn
            // 
            Experience_bttn.BackColor = Color.Transparent;
            Experience_bttn.CheckButton = false;
            Experience_bttn.Checked = false;
            Experience_bttn.CheckedBackground = Color.Transparent;
            Experience_bttn.CheckedForeColor = Color.White;
            Experience_bttn.CheckedImageTint = Color.White;
            Experience_bttn.CheckedOutline = Color.FromArgb(255, 106, 0);
            Experience_bttn.Content = "Experience";
            Experience_bttn.DialogResult = DialogResult.None;
            Experience_bttn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Experience_bttn.ForeColor = Color.FromArgb(30, 41, 57);
            Experience_bttn.HoverBackground = Color.Transparent;
            Experience_bttn.HoverForeColor = Color.Black;
            Experience_bttn.HoverImageTint = Color.Transparent;
            Experience_bttn.HoverOutline = Color.FromArgb(136, 116, 249);
            Experience_bttn.Image = null;
            Experience_bttn.ImageAutoCenter = true;
            Experience_bttn.ImageExpand = new Point(0, 0);
            Experience_bttn.ImageOffset = new Point(0, 0);
            Experience_bttn.Location = new Point(15, 208);
            Experience_bttn.Margin = new Padding(3, 2, 3, 14);
            Experience_bttn.Name = "Experience_bttn";
            Experience_bttn.NormalBackground = Color.Transparent;
            Experience_bttn.NormalForeColor = Color.FromArgb(30, 41, 57);
            Experience_bttn.NormalImageTint = Color.White;
            Experience_bttn.NormalOutline = Color.Transparent;
            Experience_bttn.OutlineThickness = 1F;
            Experience_bttn.Padding = new Padding(100, 0, 0, 0);
            Experience_bttn.PressedBackground = Color.Transparent;
            Experience_bttn.PressedForeColor = Color.FromArgb(32, 32, 32);
            Experience_bttn.PressedImageTint = Color.White;
            Experience_bttn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            Experience_bttn.Rounding = new Padding(8);
            Experience_bttn.Size = new Size(254, 40);
            Experience_bttn.TabIndex = 5;
            Experience_bttn.TextAlignment = StringAlignment.Near;
            Experience_bttn.TextOffset = new Point(25, 0);
            Experience_bttn.Click += Experience_bttn_Click;
            // 
            // Education_bttn
            // 
            Education_bttn.BackColor = Color.Transparent;
            Education_bttn.CheckButton = false;
            Education_bttn.Checked = false;
            Education_bttn.CheckedBackground = Color.Transparent;
            Education_bttn.CheckedForeColor = Color.White;
            Education_bttn.CheckedImageTint = Color.White;
            Education_bttn.CheckedOutline = Color.FromArgb(255, 106, 0);
            Education_bttn.Content = "Education";
            Education_bttn.DialogResult = DialogResult.None;
            Education_bttn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Education_bttn.ForeColor = Color.FromArgb(30, 41, 57);
            Education_bttn.HoverBackground = Color.Transparent;
            Education_bttn.HoverForeColor = Color.Black;
            Education_bttn.HoverImageTint = Color.Transparent;
            Education_bttn.HoverOutline = Color.FromArgb(136, 116, 249);
            Education_bttn.Image = null;
            Education_bttn.ImageAutoCenter = true;
            Education_bttn.ImageExpand = new Point(0, 0);
            Education_bttn.ImageOffset = new Point(0, 0);
            Education_bttn.Location = new Point(15, 152);
            Education_bttn.Margin = new Padding(3, 2, 3, 14);
            Education_bttn.Name = "Education_bttn";
            Education_bttn.NormalBackground = Color.Transparent;
            Education_bttn.NormalForeColor = Color.FromArgb(30, 41, 57);
            Education_bttn.NormalImageTint = Color.White;
            Education_bttn.NormalOutline = Color.Transparent;
            Education_bttn.OutlineThickness = 1F;
            Education_bttn.Padding = new Padding(100, 0, 0, 0);
            Education_bttn.PressedBackground = Color.Transparent;
            Education_bttn.PressedForeColor = Color.FromArgb(32, 32, 32);
            Education_bttn.PressedImageTint = Color.White;
            Education_bttn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            Education_bttn.Rounding = new Padding(8);
            Education_bttn.Size = new Size(254, 40);
            Education_bttn.TabIndex = 4;
            Education_bttn.TextAlignment = StringAlignment.Near;
            Education_bttn.TextOffset = new Point(25, 0);
            Education_bttn.Click += Education_bttn_Click;
            // 
            // Tips_lb
            // 
            Tips_lb.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Tips_lb.AutoSize = true;
            Tips_lb.BackColor = Color.Transparent;
            Tips_lb.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tips_lb.ForeColor = Color.FromArgb(74, 169, 89);
            Tips_lb.Location = new Point(928, 640);
            Tips_lb.Name = "Tips_lb";
            Tips_lb.Size = new Size(441, 17);
            Tips_lb.TabIndex = 5;
            Tips_lb.Text = "Tip: Use action verbs like “Developed” or “Led” in your experience section.";
            Tips_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Section_lbl
            // 
            Section_lbl.AutoSize = true;
            Section_lbl.BackColor = Color.Transparent;
            Section_lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Section_lbl.ForeColor = Color.FromArgb(30, 41, 57);
            Section_lbl.Location = new Point(306, 19);
            Section_lbl.Name = "Section_lbl";
            Section_lbl.Size = new Size(94, 30);
            Section_lbl.TabIndex = 6;
            Section_lbl.Text = "Personal";
            Section_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Preview_lbl
            // 
            Preview_lbl.AutoSize = true;
            Preview_lbl.BackColor = Color.Transparent;
            Preview_lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Preview_lbl.ForeColor = Color.FromArgb(30, 41, 57);
            Preview_lbl.Location = new Point(1094, 19);
            Preview_lbl.Name = "Preview_lbl";
            Preview_lbl.Size = new Size(89, 30);
            Preview_lbl.TabIndex = 7;
            Preview_lbl.Text = "Preview";
            Preview_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NextButton
            // 
            NextButton.CheckButton = false;
            NextButton.Checked = false;
            NextButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            NextButton.CheckedForeColor = Color.White;
            NextButton.CheckedImageTint = Color.White;
            NextButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            NextButton.Content = "Next";
            NextButton.DialogResult = DialogResult.None;
            NextButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            NextButton.ForeColor = Color.White;
            NextButton.HoverBackground = Color.FromArgb(125, 100, 200);
            NextButton.HoverForeColor = Color.White;
            NextButton.HoverImageTint = Color.White;
            NextButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            NextButton.Image = null;
            NextButton.ImageAutoCenter = true;
            NextButton.ImageExpand = new Point(0, 0);
            NextButton.ImageOffset = new Point(0, 0);
            NextButton.Location = new Point(744, 638);
            NextButton.Margin = new Padding(3, 2, 3, 2);
            NextButton.Name = "NextButton";
            NextButton.NormalBackground = Color.FromArgb(136, 116, 249);
            NextButton.NormalForeColor = Color.White;
            NextButton.NormalImageTint = Color.White;
            NextButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            NextButton.OutlineThickness = 1F;
            NextButton.PressedBackground = Color.WhiteSmoke;
            NextButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            NextButton.PressedImageTint = Color.White;
            NextButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            NextButton.Rounding = new Padding(8);
            NextButton.Size = new Size(155, 30);
            NextButton.TabIndex = 9;
            NextButton.TextAlignment = StringAlignment.Center;
            NextButton.TextOffset = new Point(0, 0);
            NextButton.Click += NextButton_Click;
            // 
            // RandomTimer
            // 
            RandomTimer.Interval = 20000;
            RandomTimer.Tick += RandomTimer_Tick;
            // 
            // SummaryMain_pl
            // 
            SummaryMain_pl.Enabled = false;
            SummaryMain_pl.Location = new Point(284, 0);
            SummaryMain_pl.Margin = new Padding(3, 2, 3, 2);
            SummaryMain_pl.Name = "SummaryMain_pl";
            SummaryMain_pl.Size = new Size(1094, 675);
            SummaryMain_pl.TabIndex = 10;
            SummaryMain_pl.Visible = false;
            // 
            // CV_Creator_Form
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Personal;
            ClientSize = new Size(1384, 677);
            Controls.Add(SummaryMain_pl);
            Controls.Add(NextButton);
            Controls.Add(Preview_lbl);
            Controls.Add(Section_lbl);
            Controls.Add(Tips_lb);
            Controls.Add(Sidepanel);
            Controls.Add(Preview_panel);
            Controls.Add(SubForm_panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CV_Creator_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CV Creator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Logo_Box).EndInit();
            SubForm_panel.ResumeLayout(false);
            Sidepanel.ResumeLayout(false);
            Sidepanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Templatename_label;
        private CuoreUI.Controls.cuiPanel SubForm_panel;
        private CuoreUI.Controls.cuiPanel Preview_panel;
        private Label Appname_lb;
        private PictureBox Logo_Box;
        private CuoreUI.Controls.cuiPanel Sidepanel;
        private Label Tips_lb;
        private Label Section_lbl;
        private Label Preview_lbl;
        private CuoreUI.Controls.cuiButton NextButton;
        private CuoreUI.Controls.cuiPanel highlightPanel;
        private CuoreUI.Controls.cuiButton Personal_bttn;
        private CuoreUI.Controls.cuiButton Projects_bttn;
        private CuoreUI.Controls.cuiButton Skills_bttn;
        private CuoreUI.Controls.cuiButton Experience_bttn;
        private CuoreUI.Controls.cuiButton Education_bttn;
        private CuoreUI.Controls.cuiButton Summary_bttn;
        private System.Windows.Forms.Timer RandomTimer;
        private CuoreUI.Controls.cuiPanel Mainform_panel;
        private Panel SummaryMain_pl;
    }
}
