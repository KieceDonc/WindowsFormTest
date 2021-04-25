using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void onMouseEnterBackgroundAnimation(object sender, EventArgs e) {
            OvalPictureBox pictureBox = sender as OvalPictureBox;
            if(pictureBox != null) {
                Panel pictureBoxPanel = pictureBox.Parent as Panel;
                if(pictureBoxPanel != null) {
                    pictureBoxPanel.BackColor = Color.Gray;
                }
            }
        }

        private void onMouseLeaveBackgroundAnimation(object sender, EventArgs e) {
            OvalPictureBox pictureBox = sender as OvalPictureBox;
            if(pictureBox != null) {
                Panel pictureBoxPanel = pictureBox.Parent as Panel;
                if(pictureBoxPanel != null) {
                    pictureBoxPanel.BackColor = Color.DimGray;
                }
            }
        }

        private void menuTableLayout_Paint(object sender, PaintEventArgs e) {

        }
    }
}
