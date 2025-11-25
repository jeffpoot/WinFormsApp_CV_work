using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp_CV_work.Creator_SECTIONS
{

    public partial class PERSONAL : UserControl
    {

        

        string dialcode = "";
        string localNumber = "";

        public PERSONAL()
        {
            InitializeComponent();

        }
        private void PERSONAL_Load(object sender, EventArgs e)
        {
            Personal_pb.Image = Properties.Resources.person_110935;
        }

        private void Contact_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Contact_ComboBox.SelectedItem != null)
            {
                dialcode = Contact_ComboBox.SelectedItem.ToString();
                localNumber = Contact_txb.Content ?? "";


                foreach (var item in Contact_ComboBox.Items)
                {
                    string code = item.ToString();
                    if (localNumber.StartsWith(code))
                    {
                        localNumber = localNumber.Substring(code.Length);
                        break;
                    }

                }


                Contact_txb.PlaceholderText = dialcode;
                Contact_txb.Content = dialcode + localNumber;
            }


        }

        private void Contact_txb_ContentChanged(object sender, EventArgs e)
        {

            bool MisplacedCode = false;
            bool ContainsNonDigit = false;

            string currentContent = Contact_txb.Content ?? "";

            if (!string.IsNullOrEmpty(dialcode))
            {
                if (currentContent.Contains(dialcode) && !currentContent.StartsWith(dialcode))
                {
                    MisplacedCode = true;
                    MisplacedFix_img.Visible = true;
                }

                else
                {
                    localNumber = currentContent;
                    MisplacedFix_img.Visible = false;
                    
                }
            }


        }


        //Handles the misplaced dial code order by clicking the wrench icon
        private void MisplacedFix_img_Click(object sender, EventArgs e)
        {
            bool MisplacedCode = false;
            string currentContent = Contact_txb.Content ?? "";

            if (!string.IsNullOrEmpty(dialcode))
            {
                if (currentContent.Contains(dialcode) && !currentContent.StartsWith(dialcode))
                {
                    MisplacedCode = true;
                }

                localNumber = currentContent.Replace(dialcode, "");

                Contact_txb.Content = dialcode + localNumber;
            }
            else
            {
                localNumber = currentContent;
            }
        }


        //Handles the keypressed (Stops user from typing letters instead of numbers)
        private void Contact_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void Country_ComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact_ComboBox.SelectedIndex = Country_ComboBx.SelectedIndex;

        }

        private void PersonUP_bttn_Click(object sender, EventArgs e)
        {
            Prj_openFileDialog.Title = "Select an image";
            Prj_openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (Prj_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Personal_pb.Image = Image.FromFile(Prj_openFileDialog.FileName);
            }

        }

        private void PersonRMV_bttn_Click(object sender, EventArgs e)
        {
            if (Personal_pb.Image != null)
            {
                Personal_pb.Image.Dispose();
                Personal_pb.Image = null;
                Personal_pb.Image = Properties.Resources.person_110935;
            }
            
        }
    }
}
