
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
            this.leftMainMenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.leftSecondMenuTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.libraryPanel = new System.Windows.Forms.Panel();
            this.library = new System.Windows.Forms.PictureBox();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settings = new WindowsFormTest.OvalPictureBox();
            this.userProfilePanel = new System.Windows.Forms.Panel();
            this.userProfilePicture = new WindowsFormTest.OvalPictureBox();
            this.downloadPanel = new System.Windows.Forms.Panel();
            this.download = new System.Windows.Forms.PictureBox();
            this.fillMenuPanel = new System.Windows.Forms.Panel();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.about = new System.Windows.Forms.PictureBox();
            this.topMenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.staffChoiceLabel = new System.Windows.Forms.Label();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.bestRankLabel = new System.Windows.Forms.Label();
            this.forYouLabel = new System.Windows.Forms.Label();
            this.mainTableLayout.SuspendLayout();
            this.leftMainMenuPanel.SuspendLayout();
            this.leftSecondMenuTableLayout.SuspendLayout();
            this.libraryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.library)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.userProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePicture)).BeginInit();
            this.downloadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.download)).BeginInit();
            this.fillMenuPanel.SuspendLayout();
            this.aboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.about)).BeginInit();
            this.topMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTableLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.leftMainMenuPanel, 0, 0);
            this.mainTableLayout.Controls.Add(this.topMenuPanel, 1, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 1;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayout.Size = new System.Drawing.Size(1284, 611);
            this.mainTableLayout.TabIndex = 1;
            // 
            // leftMainMenuPanel
            // 
            this.leftMainMenuPanel.ColumnCount = 1;
            this.leftMainMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftMainMenuPanel.Controls.Add(this.leftSecondMenuTableLayout, 0, 0);
            this.leftMainMenuPanel.Controls.Add(this.fillMenuPanel, 0, 1);
            this.leftMainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftMainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.leftMainMenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftMainMenuPanel.Name = "leftMainMenuPanel";
            this.leftMainMenuPanel.RowCount = 2;
            this.leftMainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.leftMainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.leftMainMenuPanel.Size = new System.Drawing.Size(50, 611);
            this.leftMainMenuPanel.TabIndex = 0;
            // 
            // leftSecondMenuTableLayout
            // 
            this.leftSecondMenuTableLayout.BackColor = System.Drawing.Color.DimGray;
            this.leftSecondMenuTableLayout.ColumnCount = 1;
            this.leftSecondMenuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftSecondMenuTableLayout.Controls.Add(this.libraryPanel, 0, 3);
            this.leftSecondMenuTableLayout.Controls.Add(this.settingsPanel, 0, 1);
            this.leftSecondMenuTableLayout.Controls.Add(this.userProfilePanel, 0, 0);
            this.leftSecondMenuTableLayout.Controls.Add(this.downloadPanel, 0, 2);
            this.leftSecondMenuTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftSecondMenuTableLayout.Location = new System.Drawing.Point(0, 0);
            this.leftSecondMenuTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.leftSecondMenuTableLayout.MinimumSize = new System.Drawing.Size(50, 200);
            this.leftSecondMenuTableLayout.Name = "leftSecondMenuTableLayout";
            this.leftSecondMenuTableLayout.RowCount = 4;
            this.leftSecondMenuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.leftSecondMenuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.leftSecondMenuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.leftSecondMenuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.leftSecondMenuTableLayout.Size = new System.Drawing.Size(50, 200);
            this.leftSecondMenuTableLayout.TabIndex = 1;
            // 
            // libraryPanel
            // 
            this.libraryPanel.BackColor = System.Drawing.Color.DimGray;
            this.libraryPanel.Controls.Add(this.library);
            this.libraryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryPanel.Location = new System.Drawing.Point(0, 150);
            this.libraryPanel.Margin = new System.Windows.Forms.Padding(0);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.libraryPanel.Size = new System.Drawing.Size(50, 50);
            this.libraryPanel.TabIndex = 4;
            this.libraryPanel.MouseEnter += new System.EventHandler(this.onMouseEnterBackgroundAnimation);
            this.libraryPanel.MouseLeave += new System.EventHandler(this.onMouseLeaveBackgroundAnimation);
            // 
            // library
            // 
            this.library.Dock = System.Windows.Forms.DockStyle.Fill;
            this.library.Image = global::WindowsFormTest.Properties.Resources.labrary;
            this.library.InitialImage = null;
            this.library.Location = new System.Drawing.Point(10, 7);
            this.library.Name = "library";
            this.library.Size = new System.Drawing.Size(30, 36);
            this.library.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.library.TabIndex = 0;
            this.library.TabStop = false;
            this.library.MouseEnter += new System.EventHandler(this.onMouseEnterBackgroundAnimation);
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
            this.settingsPanel.MouseEnter += new System.EventHandler(this.onMouseEnterBackgroundAnimation);
            this.settingsPanel.MouseLeave += new System.EventHandler(this.onMouseLeaveBackgroundAnimation);
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
            // 
            // userProfilePanel
            // 
            this.userProfilePanel.BackColor = System.Drawing.Color.DimGray;
            this.userProfilePanel.Controls.Add(this.userProfilePicture);
            this.userProfilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.userProfilePanel.Margin = new System.Windows.Forms.Padding(0);
            this.userProfilePanel.Name = "userProfilePanel";
            this.userProfilePanel.Padding = new System.Windows.Forms.Padding(10);
            this.userProfilePanel.Size = new System.Drawing.Size(50, 50);
            this.userProfilePanel.TabIndex = 2;
            this.userProfilePanel.MouseEnter += new System.EventHandler(this.onMouseEnterBackgroundAnimation);
            this.userProfilePanel.MouseLeave += new System.EventHandler(this.onMouseLeaveBackgroundAnimation);
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
            this.userProfilePicture.MouseEnter += new System.EventHandler(this.onMouseEnterBackgroundAnimation);
            // 
            // downloadPanel
            // 
            this.downloadPanel.BackColor = System.Drawing.Color.DimGray;
            this.downloadPanel.Controls.Add(this.download);
            this.downloadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadPanel.Location = new System.Drawing.Point(0, 100);
            this.downloadPanel.Margin = new System.Windows.Forms.Padding(0);
            this.downloadPanel.Name = "downloadPanel";
            this.downloadPanel.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.downloadPanel.Size = new System.Drawing.Size(50, 50);
            this.downloadPanel.TabIndex = 3;
            this.downloadPanel.MouseEnter += new System.EventHandler(this.onMouseEnterBackgroundAnimation);
            this.downloadPanel.MouseLeave += new System.EventHandler(this.onMouseLeaveBackgroundAnimation);
            // 
            // download
            // 
            this.download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.download.Image = global::WindowsFormTest.Properties.Resources.download;
            this.download.InitialImage = null;
            this.download.Location = new System.Drawing.Point(10, 12);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(30, 26);
            this.download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.download.TabIndex = 0;
            this.download.TabStop = false;
            this.download.MouseEnter += new System.EventHandler(this.onMouseEnterBackgroundAnimation);
            // 
            // fillMenuPanel
            // 
            this.fillMenuPanel.BackColor = System.Drawing.Color.DimGray;
            this.fillMenuPanel.Controls.Add(this.aboutPanel);
            this.fillMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillMenuPanel.Location = new System.Drawing.Point(0, 200);
            this.fillMenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.fillMenuPanel.Name = "fillMenuPanel";
            this.fillMenuPanel.Size = new System.Drawing.Size(50, 411);
            this.fillMenuPanel.TabIndex = 2;
            // 
            // aboutPanel
            // 
            this.aboutPanel.Controls.Add(this.about);
            this.aboutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutPanel.Location = new System.Drawing.Point(0, 361);
            this.aboutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.aboutPanel.MinimumSize = new System.Drawing.Size(50, 50);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Padding = new System.Windows.Forms.Padding(8);
            this.aboutPanel.Size = new System.Drawing.Size(50, 50);
            this.aboutPanel.TabIndex = 0;
            this.aboutPanel.MouseEnter += new System.EventHandler(this.onMouseEnterBackgroundAnimation);
            this.aboutPanel.MouseLeave += new System.EventHandler(this.onMouseLeaveBackgroundAnimation);
            // 
            // about
            // 
            this.about.Dock = System.Windows.Forms.DockStyle.Fill;
            this.about.Image = global::WindowsFormTest.Properties.Resources.about;
            this.about.Location = new System.Drawing.Point(8, 8);
            this.about.Margin = new System.Windows.Forms.Padding(0);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(34, 34);
            this.about.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.about.TabIndex = 0;
            this.about.TabStop = false;
            this.about.MouseEnter += new System.EventHandler(this.onMouseEnterBackgroundAnimation);
            // 
            // topMenuPanel
            // 
            this.topMenuPanel.BackColor = System.Drawing.Color.DimGray;
            this.topMenuPanel.ColumnCount = 5;
            this.topMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.topMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.topMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.topMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.topMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.topMenuPanel.Controls.Add(this.staffChoiceLabel, 3, 0);
            this.topMenuPanel.Controls.Add(this.categoriesLabel, 2, 0);
            this.topMenuPanel.Controls.Add(this.bestRankLabel, 1, 0);
            this.topMenuPanel.Controls.Add(this.forYouLabel, 0, 0);
            this.topMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenuPanel.Location = new System.Drawing.Point(70, 20);
            this.topMenuPanel.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.topMenuPanel.Name = "topMenuPanel";
            this.topMenuPanel.RowCount = 1;
            this.topMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.topMenuPanel.Size = new System.Drawing.Size(1194, 60);
            this.topMenuPanel.TabIndex = 1;
            // 
            // staffChoiceLabel
            // 
            this.staffChoiceLabel.AutoSize = true;
            this.staffChoiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.staffChoiceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffChoiceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staffChoiceLabel.ForeColor = System.Drawing.Color.LightGray;
            this.staffChoiceLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.staffChoiceLabel.Location = new System.Drawing.Point(391, 0);
            this.staffChoiceLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.staffChoiceLabel.Name = "staffChoiceLabel";
            this.staffChoiceLabel.Size = new System.Drawing.Size(129, 60);
            this.staffChoiceLabel.TabIndex = 3;
            this.staffChoiceLabel.Text = "Choix de l\'équipe";
            this.staffChoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.BackColor = System.Drawing.Color.Transparent;
            this.categoriesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoriesLabel.ForeColor = System.Drawing.Color.LightGray;
            this.categoriesLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.categoriesLabel.Location = new System.Drawing.Point(287, 0);
            this.categoriesLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(84, 60);
            this.categoriesLabel.TabIndex = 2;
            this.categoriesLabel.Text = "Catégories";
            this.categoriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bestRankLabel
            // 
            this.bestRankLabel.AutoSize = true;
            this.bestRankLabel.BackColor = System.Drawing.Color.Transparent;
            this.bestRankLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bestRankLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bestRankLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.bestRankLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bestRankLabel.Location = new System.Drawing.Point(109, 0);
            this.bestRankLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.bestRankLabel.Name = "bestRankLabel";
            this.bestRankLabel.Size = new System.Drawing.Size(158, 60);
            this.bestRankLabel.TabIndex = 1;
            this.bestRankLabel.Text = "Meilleurs Classement";
            this.bestRankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forYouLabel
            // 
            this.forYouLabel.AutoSize = true;
            this.forYouLabel.BackColor = System.Drawing.Color.Transparent;
            this.forYouLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forYouLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forYouLabel.ForeColor = System.Drawing.Color.White;
            this.forYouLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.forYouLabel.Location = new System.Drawing.Point(10, 0);
            this.forYouLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.forYouLabel.Name = "forYouLabel";
            this.forYouLabel.Size = new System.Drawing.Size(79, 60);
            this.forYouLabel.TabIndex = 0;
            this.forYouLabel.Text = "Pour vous";
            this.forYouLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.mainTableLayout);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 650);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainTableLayout.ResumeLayout(false);
            this.leftMainMenuPanel.ResumeLayout(false);
            this.leftSecondMenuTableLayout.ResumeLayout(false);
            this.libraryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.library)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            this.userProfilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePicture)).EndInit();
            this.downloadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.download)).EndInit();
            this.fillMenuPanel.ResumeLayout(false);
            this.aboutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.about)).EndInit();
            this.topMenuPanel.ResumeLayout(false);
            this.topMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.TableLayoutPanel leftMainMenuPanel;
        private System.Windows.Forms.TableLayoutPanel leftSecondMenuTableLayout;
        private System.Windows.Forms.Panel libraryPanel;
        private System.Windows.Forms.PictureBox library;
        private System.Windows.Forms.Panel settingsPanel;
        private OvalPictureBox settings;
        private System.Windows.Forms.Panel userProfilePanel;
        private OvalPictureBox userProfilePicture;
        private System.Windows.Forms.Panel downloadPanel;
        private System.Windows.Forms.PictureBox download;
        private System.Windows.Forms.Panel fillMenuPanel;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.PictureBox about;
        private System.Windows.Forms.TableLayoutPanel topMenuPanel;
        private System.Windows.Forms.Label staffChoiceLabel;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.Label bestRankLabel;
        private System.Windows.Forms.Label forYouLabel;
    }
}