namespace WinFormsApp_CV_work.Creator_SECTIONS
{
    partial class SUMMARY
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
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.Location = new Point(338, 25);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(20);
            cuiPanel1.Size = new Size(575, 750);
            cuiPanel1.TabIndex = 0;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Location = new Point(375, 800);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(10);
            cuiPanel2.Size = new Size(500, 80);
            cuiPanel2.TabIndex = 1;
            // 
            // cuiPanel3
            // 
            cuiPanel3.Location = new Point(25, 25);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.White;
            cuiPanel3.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel3.Rounding = new Padding(10);
            cuiPanel3.Size = new Size(300, 75);
            cuiPanel3.TabIndex = 2;
            // 
            // SUMMARY
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 255);
            Controls.Add(cuiPanel3);
            Controls.Add(cuiPanel2);
            Controls.Add(cuiPanel1);
            Name = "SUMMARY";
            Size = new Size(1250, 900);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
    }
}
