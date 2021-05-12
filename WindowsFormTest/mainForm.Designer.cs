
namespace WindowsFormTest
{
    partial class mainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userProfilePanel = new System.Windows.Forms.Panel();
            this.ovalPictureBox1 = new WindowsFormTest.OvalPictureBox();
            this.downloadPanel = new System.Windows.Forms.Panel();
            this.download = new System.Windows.Forms.PictureBox();
            this.fillMenuPanel = new System.Windows.Forms.Panel();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.about = new System.Windows.Forms.PictureBox();
            this.fillTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.menuTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.searchTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchPicture = new System.Windows.Forms.PictureBox();
            this.staffChoiceLabel = new System.Windows.Forms.Label();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.bestRankLabel = new System.Windows.Forms.Label();
            this.forYouLabel = new System.Windows.Forms.Label();
            this.menuUnderLine = new System.Windows.Forms.Panel();
            this.mainTableLayout.SuspendLayout();
            this.leftMainMenuPanel.SuspendLayout();
            this.leftSecondMenuTableLayout.SuspendLayout();
            this.libraryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.library)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.userProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.downloadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.download)).BeginInit();
            this.fillMenuPanel.SuspendLayout();
            this.aboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.about)).BeginInit();
            this.fillTableLayout.SuspendLayout();
            this.menuTableLayout.SuspendLayout();
            this.searchTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPicture)).BeginInit();
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
            this.mainTableLayout.Controls.Add(this.fillTableLayout, 1, 0);
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
            this.library.Image = global::WindowsFormTest.Properties.Resources.library;
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
            this.settingsPanel.Controls.Add(this.pictureBox1);
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormTest.Properties.Resources.settings;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.onMouseEnterBackgroundAnimation);
            // 
            // userProfilePanel
            // 
            this.userProfilePanel.BackColor = System.Drawing.Color.DimGray;
            this.userProfilePanel.Controls.Add(this.ovalPictureBox1);
            this.userProfilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.userProfilePanel.Margin = new System.Windows.Forms.Padding(0);
            this.userProfilePanel.Name = "userProfilePanel";
            this.userProfilePanel.Padding = new System.Windows.Forms.Padding(5);
            this.userProfilePanel.Size = new System.Drawing.Size(50, 50);
            this.userProfilePanel.TabIndex = 2;
            this.userProfilePanel.MouseEnter += new System.EventHandler(this.onMouseEnterBackgroundAnimation);
            this.userProfilePanel.MouseLeave += new System.EventHandler(this.onMouseLeaveBackgroundAnimation);
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ovalPictureBox1.Image = global::WindowsFormTest.Properties.Resources.Capture;
            this.ovalPictureBox1.Location = new System.Drawing.Point(5, 5);
            this.ovalPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox1.TabIndex = 0;
            this.ovalPictureBox1.TabStop = false;
            this.ovalPictureBox1.MouseEnter += new System.EventHandler(this.onMouseEnterBackgroundAnimation);
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
            // fillTableLayout
            // 
            this.fillTableLayout.ColumnCount = 1;
            this.fillTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.fillTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fillTableLayout.Controls.Add(this.menuTableLayout, 0, 0);
            this.fillTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillTableLayout.Location = new System.Drawing.Point(53, 3);
            this.fillTableLayout.Name = "fillTableLayout";
            this.fillTableLayout.RowCount = 2;
            this.fillTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.fillTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fillTableLayout.Size = new System.Drawing.Size(1228, 605);
            this.fillTableLayout.TabIndex = 1;
            // 
            // menuTableLayout
            // 
            this.menuTableLayout.BackColor = System.Drawing.Color.DimGray;
            this.menuTableLayout.ColumnCount = 5;
            this.menuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.menuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.menuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.menuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.menuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.menuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.menuTableLayout.Controls.Add(this.searchTableLayout, 4, 0);
            this.menuTableLayout.Controls.Add(this.staffChoiceLabel, 3, 0);
            this.menuTableLayout.Controls.Add(this.categoriesLabel, 2, 0);
            this.menuTableLayout.Controls.Add(this.bestRankLabel, 1, 0);
            this.menuTableLayout.Controls.Add(this.forYouLabel, 0, 0);
            this.menuTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTableLayout.Location = new System.Drawing.Point(10, 10);
            this.menuTableLayout.Margin = new System.Windows.Forms.Padding(10);
            this.menuTableLayout.Name = "menuTableLayout";
            this.menuTableLayout.RowCount = 1;
            this.menuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.menuTableLayout.Size = new System.Drawing.Size(1208, 60);
            this.menuTableLayout.TabIndex = 1;
            // 
            // searchTableLayout
            // 
            this.searchTableLayout.ColumnCount = 2;
            this.searchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.searchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.searchTableLayout.Controls.Add(this.searchBox, 0, 0);
            this.searchTableLayout.Controls.Add(this.searchPicture, 1, 0);
            this.searchTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTableLayout.Location = new System.Drawing.Point(530, 0);
            this.searchTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.searchTableLayout.Name = "searchTableLayout";
            this.searchTableLayout.RowCount = 1;
            this.searchTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.searchTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.searchTableLayout.Size = new System.Drawing.Size(678, 60);
            this.searchTableLayout.TabIndex = 5;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(515, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 23);
            this.searchBox.TabIndex = 2;
            // 
            // searchPicture
            // 
            this.searchPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchPicture.Image = global::WindowsFormTest.Properties.Resources.search;
            this.searchPicture.Location = new System.Drawing.Point(633, 15);
            this.searchPicture.Margin = new System.Windows.Forms.Padding(0);
            this.searchPicture.Name = "searchPicture";
            this.searchPicture.Size = new System.Drawing.Size(30, 30);
            this.searchPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchPicture.TabIndex = 0;
            this.searchPicture.TabStop = false;
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
            this.staffChoiceLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onNavigationLabelClick);
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
            this.categoriesLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onNavigationLabelClick);
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
            this.bestRankLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onNavigationLabelClick);
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
            this.forYouLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onNavigationLabelClick);
            // 
            // menuUnderLine
            // 
            this.menuUnderLine.BackColor = System.Drawing.Color.DarkTurquoise;
            this.menuUnderLine.Location = new System.Drawing.Point(0, 0);
            this.menuUnderLine.Name = "menuUnderLine";
            this.menuUnderLine.Size = new System.Drawing.Size(283, 5);
            this.menuUnderLine.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.menuUnderLine);
            this.Controls.Add(this.mainTableLayout);
            this.MinimumSize = new System.Drawing.Size(1300, 650);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            this.mainTableLayout.ResumeLayout(false);
            this.leftMainMenuPanel.ResumeLayout(false);
            this.leftSecondMenuTableLayout.ResumeLayout(false);
            this.libraryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.library)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.userProfilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.downloadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.download)).EndInit();
            this.fillMenuPanel.ResumeLayout(false);
            this.aboutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.about)).EndInit();
            this.fillTableLayout.ResumeLayout(false);
            this.menuTableLayout.ResumeLayout(false);
            this.menuTableLayout.PerformLayout();
            this.searchTableLayout.ResumeLayout(false);
            this.searchTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPicture)).EndInit();
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
        private System.Windows.Forms.Panel menuUnderLine;
        private System.Windows.Forms.TableLayoutPanel fillTableLayout;
        private System.Windows.Forms.TableLayoutPanel menuTableLayout;
        private System.Windows.Forms.Label staffChoiceLabel;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.Label bestRankLabel;
        private System.Windows.Forms.Label forYouLabel;
        private System.Windows.Forms.TableLayoutPanel searchTableLayout;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.PictureBox searchPicture;
        private OvalPictureBox ovalPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}