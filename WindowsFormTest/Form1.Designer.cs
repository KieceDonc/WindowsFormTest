
namespace WindowsFormTest
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.menuTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.userProfilePicture = new WindowsFormTest.OvalPictureBox();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settings = new WindowsFormTest.OvalPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainTableLayout.SuspendLayout();
            this.menuTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePicture)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.menuTableLayout, 0, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 1;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayout.Size = new System.Drawing.Size(800, 450);
            this.mainTableLayout.TabIndex = 1;
            this.mainTableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // menuTableLayout
            // 
            this.menuTableLayout.BackColor = System.Drawing.Color.DimGray;
            this.menuTableLayout.ColumnCount = 1;
            this.menuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuTableLayout.Controls.Add(this.settingsPanel, 0, 1);
            this.menuTableLayout.Controls.Add(this.panel1, 0, 0);
            this.menuTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTableLayout.Location = new System.Drawing.Point(0, 0);
            this.menuTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.menuTableLayout.Name = "menuTableLayout";
            this.menuTableLayout.RowCount = 4;
            this.menuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuTableLayout.Size = new System.Drawing.Size(50, 200);
            this.menuTableLayout.TabIndex = 0;
            this.menuTableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.menuTableLayout_Paint);
            // 
            // userProfilePicture
            // 
            this.userProfilePicture.BackColor = System.Drawing.Color.DarkGray;
            this.userProfilePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userProfilePicture.Image = global::WindowsFormTest.Properties.Resources.Capture;
            this.userProfilePicture.Location = new System.Drawing.Point(10, 10);
            this.userProfilePicture.Margin = new System.Windows.Forms.Padding(10);
            this.userProfilePicture.Name = "userProfilePicture";
            this.userProfilePicture.Size = new System.Drawing.Size(30, 30);
            this.userProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userProfilePicture.TabIndex = 0;
            this.userProfilePicture.TabStop = false;
            this.userProfilePicture.Click += new System.EventHandler(this.Form1_Load);
            this.userProfilePicture.MouseEnter += new System.EventHandler(this.onMouseEnterBackgroundAnimation);
            this.userProfilePicture.MouseLeave += new System.EventHandler(this.onMouseLeaveBackgroundAnimation);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.settingsPanel.Controls.Add(this.settings);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 50);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.settingsPanel.Size = new System.Drawing.Size(50, 50);
            this.settingsPanel.TabIndex = 1;
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Transparent;
            this.settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings.Image = global::WindowsFormTest.Properties.Resources.settings;
            this.settings.Location = new System.Drawing.Point(10, 10);
            this.settings.Margin = new System.Windows.Forms.Padding(10);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(30, 30);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settings.TabIndex = 1;
            this.settings.TabStop = false;
            this.settings.MouseEnter += new System.EventHandler(this.onMouseEnterBackgroundAnimation);
            this.settings.MouseLeave += new System.EventHandler(this.onMouseLeaveBackgroundAnimation);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userProfilePicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTableLayout.ResumeLayout(false);
            this.menuTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePicture)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.TableLayoutPanel menuTableLayout;
        private OvalPictureBox userProfilePicture;
        private OvalPictureBox settings;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Panel panel1;
    }
}