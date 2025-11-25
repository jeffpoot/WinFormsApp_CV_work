using CuoreUI.Controls;
using WinFormsApp_CV_work.Creator_SECTIONS;

namespace WinFormsApp_CV_work
{
    public partial class CV_Creator_Form : Form
    {

        Creator_SECTIONS.PERSONAL personal_Sec = new Creator_SECTIONS.PERSONAL();
        Creator_SECTIONS.EDUCATION education_Sec = new Creator_SECTIONS.EDUCATION();
        Creator_SECTIONS.EXPERIENCE experience_Sec = new Creator_SECTIONS.EXPERIENCE();
        Creator_SECTIONS.SKILLS skills_Sec = new Creator_SECTIONS.SKILLS();
        Creator_SECTIONS.PROJECTS project_Sec = new Creator_SECTIONS.PROJECTS();
        Creator_SECTIONS.SUMMARY summary_Sec = new Creator_SECTIONS.SUMMARY();

        private Random random = new Random();

        


        public CV_Creator_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Section_lbl.Text = "Personal";

            Mainform_panel.Controls.Clear();
            Mainform_panel.Controls.Add(personal_Sec);
            personal_Sec.Dock = DockStyle.Fill;

            HighlightButton(Personal_bttn);

            RandomTimer.Start();


            summary_Sec.EditClicked += Summary_EditClicked;
        }

        private void Summary_Sec_EditClicked(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (Mainform_panel.Controls.Contains(personal_Sec))
            {
                HighlightButton(Education_bttn);


                Section_lbl.Text = "Education";
                Mainform_panel.Controls.Clear();
                Mainform_panel.Controls.Add(education_Sec);
                education_Sec.Dock = DockStyle.Fill;
                NextButton.Content = "Next";
            }
            else if (Mainform_panel.Controls.Contains(education_Sec))
            {
                HighlightButton(Experience_bttn);

                Section_lbl.Text = "Experience";
                Mainform_panel.Controls.Clear();
                Mainform_panel.Controls.Add(experience_Sec);
                experience_Sec.Dock = DockStyle.Fill;
                NextButton.Content = "Next";
            }
            else if (Mainform_panel.Controls.Contains(experience_Sec))
            {
                HighlightButton(Skills_bttn);

                Section_lbl.Text = "Skills";
                Mainform_panel.Controls.Clear();
                Mainform_panel.Controls.Add(skills_Sec);
                skills_Sec.Dock = DockStyle.Fill;
                NextButton.Content = "Next";
            }
            else if (Mainform_panel.Controls.Contains(skills_Sec))
            {
                HighlightButton(Projects_bttn);

                Section_lbl.Text = "Project";
                Mainform_panel.Controls.Clear();
                Mainform_panel.Controls.Add(project_Sec);
                project_Sec.Dock = DockStyle.Fill;
                NextButton.Content = "Finish";
            }
            else if (Mainform_panel.Controls.Contains(project_Sec))
            {
                HighlightButton(Summary_bttn);
                SummaryMain_pl.Visible = true;
                SummaryMain_pl.Enabled = true;
                SubForm_panel.Visible = false;
                SummaryMain_pl.Controls.Clear();
                SummaryMain_pl.Controls.Add(summary_Sec);
                summary_Sec.Dock = DockStyle.Fill;
                Mainform_panel.Visible = false;
                Mainform_panel.Enabled = false;
                Section_lbl.Visible = false;
                Preview_lbl.Visible = false;
                Preview_panel.Enabled = false;
                Preview_panel.Visible = false;
                Tips_lb.Visible = false;  
            }
            else
            {
                SummaryMain_pl.Visible = false;
                SummaryMain_pl.Enabled = false;
                SubForm_panel.Visible = true;
                Mainform_panel.Visible = true;
                Mainform_panel.Enabled = true;
                Section_lbl.Visible = true;
                Preview_lbl.Visible = true;
                Preview_panel.Enabled = true;
                Preview_panel.Visible = true;
                Tips_lb.Visible = true;
            }

        }

        private void Personal_bttn_Click(object sender, EventArgs e)
        {
            HighlightButton(Personal_bttn);

            Section_lbl.Text = "Personal";
            Mainform_panel.Controls.Clear();
            Mainform_panel.Controls.Add(personal_Sec);
            personal_Sec.Dock = DockStyle.Fill;

        }

        private void Education_bttn_Click(object sender, EventArgs e)
        {
            HighlightButton(Education_bttn);

            Section_lbl.Text = "Education";
            Mainform_panel.Controls.Clear();
            Mainform_panel.Controls.Add(education_Sec);
            education_Sec.Dock = DockStyle.Fill;



        }

        private void Experience_bttn_Click(object sender, EventArgs e)
        {
            HighlightButton(Experience_bttn);

            Section_lbl.Text = "Experience";
            Mainform_panel.Controls.Clear();
            Mainform_panel.Controls.Add(experience_Sec);
            experience_Sec.Dock = DockStyle.Fill;

        }

        private void Skills_bttn_Click(object sender, EventArgs e)
        {
            HighlightButton(Skills_bttn);

            Section_lbl.Text = "Skills";
            Mainform_panel.Controls.Clear();
            Mainform_panel.Controls.Add(skills_Sec);
            skills_Sec.Dock = DockStyle.Fill;

        }

        private void Projects_bttn_Click(object sender, EventArgs e)
        {
            HighlightButton(Projects_bttn);

            Section_lbl.Text = "Projects";
            Mainform_panel.Controls.Clear();
            Mainform_panel.Controls.Add(project_Sec);
            project_Sec.Dock = DockStyle.Fill;

            NextButton.Content = "Next";

        }

        private void Summary_bttn_Click(object sender, EventArgs e)
        {
            HighlightButton(Summary_bttn);
            SummaryMain_pl.Visible = true;
            SummaryMain_pl.Enabled = true;
            SubForm_panel.Visible = false;
            SummaryMain_pl.Controls.Clear();
            SummaryMain_pl.Controls.Add(summary_Sec);
            summary_Sec.Dock = DockStyle.Fill;
            Mainform_panel.Visible = false;
            Mainform_panel.Enabled = false;
            Section_lbl.Visible = false;
            Preview_lbl.Visible = false;
            Preview_panel.Enabled = false;
            Preview_panel.Visible = false;
            Tips_lb.Visible = false;
        }

        private void Summary_EditClicked(object sender, EventArgs e)
        {
            HighlightButton(Personal_bttn);
            Section_lbl.Text = "Personal";

            SummaryMain_pl.Visible = false;
            SummaryMain_pl.Enabled = false;

            SubForm_panel.Visible = true;
            Mainform_panel.Visible = true;
            Mainform_panel.Enabled = true;

            Preview_lbl.Visible = true;
            Preview_panel.Enabled = true;
            Preview_panel.Visible = true;
            Section_lbl.Visible = true;
            NextButton.Visible = true;
            Tips_lb.Visible = true;

            NextButton.Content = "Next";

            Mainform_panel.Controls.Clear();
            Mainform_panel.Controls.Add(personal_Sec);
            personal_Sec.Dock = DockStyle.Fill;
        }



        private void ResetSidebarButtons()
        {
            cuiButton[] buttons =
            {
                Personal_bttn,
                Education_bttn,
                Experience_bttn,
                Skills_bttn,
                Projects_bttn,
                Summary_bttn
            };

            foreach (cuiButton btn in buttons)
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.Black;
                btn.HoverForeColor = Color.Black;
                btn.TextOffset = new Point(25, 0);
            }
        }

        private void HighlightButton(cuiButton btn)
        {


            ResetSidebarButtons();

            highlightPanel.Top = btn.Top + (btn.Height - highlightPanel.Height) / 2;

            btn.BackColor = Color.FromArgb(136, 116, 249);
            btn.ForeColor = Color.White;
            btn.HoverForeColor = Color.White;
            btn.TextOffset = new Point(84, 0);
        }

        private void RandomTimer_Tick(object sender, EventArgs e)
        {
            List<string> Tip_Messages = new List<string>()
        {
            "Tip: Make sure your full name is accurate and matches your official documents.",
            "Tip: Use a professional email address for contact info.",
            "Tip: Provide a valid phone number that can be reached easily.",
            "Tip: Include your current city and country for location reference.",
            "Tip: Enter your age if required, but keep it realistic.",
            "Tip: Select the correct gender option if applicable.",
            "Tip: Upload a clear and professional profile photo (1x1 inch, JPG/PNG).",
            "Tip: Make sure your address is complete for potential employers.",
            "Tip: Use proper capitalization for names, cities, and job titles.",
            "Tip: Double-check your contact info before proceeding.",
            "Tip: Keep personal info concise and accurate.",
            "Tip: Ensure the uploaded photo shows only your head and shoulders.",
            "Tip: Avoid leaving any required fields blank.",
            "Tip: Check that country and contact number are correctly paired.",
            "Tip: Update your information if anything has changed recently.",
            "Tip: Use action verbs like “Developed” or “Led” in your experience section."
        };

            int index = random.Next(Tip_Messages.Count);
            Tips_lb.Text = Tip_Messages[index];
        }
    }
}
