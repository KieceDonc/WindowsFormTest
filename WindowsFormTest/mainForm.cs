using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormTest{

    public partial class mainForm : Form{

        private Label[] navigationLabels;
        private Label currentNavigationLabel;

        public mainForm() {
            InitializeComponent();
            currentNavigationLabel = forYouLabel;
            navigationLabels = new Label[] { forYouLabel, bestRankLabel, categoriesLabel, staffChoiceLabel };
        }

        private void mainForm_Shown(object sender, EventArgs e) {
            drawLineUnderCurrentLabel();
        }

        private void onMouseEnterBackgroundAnimation(object sender, EventArgs e) {
            Control control;
            if(sender as PictureBox != null) {
                // onMouseEnterBackgroundAnimation trigger by a pictureBox
                // ( you do what because onMouseLeaveBackgroundAnimation has been trigger so you need to change again backColor of parent panel )
                control = (sender as PictureBox).Parent;
            } else {
                // onMouseEnterBackgroundAnimation trigger by a panel
                control = sender as Control;
            }
            if(control != null) {
                control.BackColor = Color.Gray;
            }
        }

        private void onMouseLeaveBackgroundAnimation(object sender, EventArgs e) {
            Panel currentPanel = sender as Panel;
            if(currentPanel != null) {
                currentPanel.BackColor = Color.DimGray;
            }
        }

        private void onNavigationLabelClick(object sender, MouseEventArgs e) {
            Label clickedLabel = sender as Label;

            Color colorForCurrentLabel = currentNavigationLabel.ForeColor;
            Color colorForNoCurrentLabel;

            if(navigationLabels[0].Equals(currentNavigationLabel)) {
                colorForNoCurrentLabel = navigationLabels[1].ForeColor;
            } else {
                colorForNoCurrentLabel = navigationLabels[0].ForeColor;
            }

            for(int x = 0; x < navigationLabels.Length; x++) {
                if(navigationLabels[x].Equals(clickedLabel)) {
                    currentNavigationLabel = clickedLabel;
                    currentNavigationLabel.ForeColor = colorForCurrentLabel;
                } else {
                    navigationLabels[x].ForeColor = colorForNoCurrentLabel;
                }
            }

            drawLineUnderCurrentLabel();
        }

        private void drawLineUnderCurrentLabel() {
            Point currentNavigationLabelPoint = currentNavigationLabel.FindForm().PointToClient(currentNavigationLabel.Parent.PointToScreen(currentNavigationLabel.Location));
            menuUnderLine.Location = new Point(currentNavigationLabelPoint.X, currentNavigationLabelPoint.Y+currentNavigationLabel.Height-10);
            menuUnderLine.Height = 5;
            menuUnderLine.Width = currentNavigationLabel.Width;
        }
    }
}
