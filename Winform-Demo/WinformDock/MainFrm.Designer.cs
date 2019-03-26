namespace WinformDock
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabPageContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.inBoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabelCopyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelWarehluse = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelTimeZone = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttsUrl = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttsAutoExitTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.dpnWareHouseCode = new System.Windows.Forms.ToolStripDropDownButton();
            this.dpnSkin = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbtnCheckNetWork = new System.Windows.Forms.ToolStripSplitButton();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.inBoundToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 25);
            this.mainMenu.TabIndex = 8;
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem4});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(61, 21);
            this.menuItemFile.Text = "&System";
            // 
            // menuItem4
            // 
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(57, 6);
            // 
            // inBoundToolStripMenuItem
            // 
            this.inBoundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printLabelToolStripMenuItem});
            this.inBoundToolStripMenuItem.Name = "inBoundToolStripMenuItem";
            this.inBoundToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.inBoundToolStripMenuItem.Text = "InBound";
            // 
            // printLabelToolStripMenuItem
            // 
            this.printLabelToolStripMenuItem.Name = "printLabelToolStripMenuItem";
            this.printLabelToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.printLabelToolStripMenuItem.Text = "PrintLabel";
            this.printLabelToolStripMenuItem.Click += new System.EventHandler(this.printLabelToolStripMenuItem_Click);
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel.Location = new System.Drawing.Point(0, 25);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(800, 425);
            this.dockPanel.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelCopyright,
            this.StatusLabelVersion,
            this.StatusLabelUserName,
            this.StatusLabelWarehluse,
            this.StatusLabelDate,
            this.StatusLabelTimeZone,
            this.ttsUrl,
            this.ttsAutoExitTime,
            this.dpnWareHouseCode,
            this.dpnSkin,
            this.tsbtnCheckNetWork});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabelCopyright
            // 
            this.StatusLabelCopyright.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabelCopyright.Name = "StatusLabelCopyright";
            this.StatusLabelCopyright.Size = new System.Drawing.Size(142, 21);
            this.StatusLabelCopyright.Text = "Copyright © BFE 2014";
            // 
            // StatusLabelVersion
            // 
            this.StatusLabelVersion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabelVersion.Name = "StatusLabelVersion";
            this.StatusLabelVersion.Size = new System.Drawing.Size(56, 21);
            this.StatusLabelVersion.Text = "Version";
            // 
            // StatusLabelUserName
            // 
            this.StatusLabelUserName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabelUserName.Name = "StatusLabelUserName";
            this.StatusLabelUserName.Size = new System.Drawing.Size(36, 21);
            this.StatusLabelUserName.Text = "用户";
            // 
            // StatusLabelWarehluse
            // 
            this.StatusLabelWarehluse.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabelWarehluse.Name = "StatusLabelWarehluse";
            this.StatusLabelWarehluse.Size = new System.Drawing.Size(36, 21);
            this.StatusLabelWarehluse.Text = "仓库";
            // 
            // StatusLabelDate
            // 
            this.StatusLabelDate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabelDate.Name = "StatusLabelDate";
            this.StatusLabelDate.Size = new System.Drawing.Size(36, 21);
            this.StatusLabelDate.Text = "日期";
            // 
            // StatusLabelTimeZone
            // 
            this.StatusLabelTimeZone.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabelTimeZone.Name = "StatusLabelTimeZone";
            this.StatusLabelTimeZone.Size = new System.Drawing.Size(36, 21);
            this.StatusLabelTimeZone.Text = "时区";
            // 
            // ttsUrl
            // 
            this.ttsUrl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ttsUrl.Name = "ttsUrl";
            this.ttsUrl.Size = new System.Drawing.Size(36, 21);
            this.ttsUrl.Text = "配置";
            // 
            // ttsAutoExitTime
            // 
            this.ttsAutoExitTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ttsAutoExitTime.Name = "ttsAutoExitTime";
            this.ttsAutoExitTime.Size = new System.Drawing.Size(60, 21);
            this.ttsAutoExitTime.Text = "自动退出";
            // 
            // dpnWareHouseCode
            // 
            this.dpnWareHouseCode.Name = "dpnWareHouseCode";
            this.dpnWareHouseCode.Size = new System.Drawing.Size(93, 24);
            this.dpnWareHouseCode.Text = "选择切换仓库";
            // 
            // dpnSkin
            // 
            this.dpnSkin.Name = "dpnSkin";
            this.dpnSkin.Size = new System.Drawing.Size(69, 24);
            this.dpnSkin.Text = "选择皮肤";
            this.dpnSkin.ToolTipText = "选择皮肤";
            // 
            // tsbtnCheckNetWork
            // 
            this.tsbtnCheckNetWork.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCheckNetWork.Image")));
            this.tsbtnCheckNetWork.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCheckNetWork.Name = "tsbtnCheckNetWork";
            this.tsbtnCheckNetWork.Size = new System.Drawing.Size(88, 24);
            this.tsbtnCheckNetWork.Text = "检测网络";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainFrm";
            this.TabText = "MiniWMS";
            this.Text = "MiniWMS";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripSeparator menuItem4;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripMenuItem inBoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printLabelToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelCopyright;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelVersion;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelUserName;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelWarehluse;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelDate;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelTimeZone;
        private System.Windows.Forms.ToolStripStatusLabel ttsUrl;
        private System.Windows.Forms.ToolStripStatusLabel ttsAutoExitTime;
        private System.Windows.Forms.ToolStripDropDownButton dpnWareHouseCode;
        private System.Windows.Forms.ToolStripDropDownButton dpnSkin;
        private System.Windows.Forms.ToolStripSplitButton tsbtnCheckNetWork;
    }
}

