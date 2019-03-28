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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.StatusLabelCopyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.dpnSkin = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 8;
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainMenu_ItemClicked);
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel.Location = new System.Drawing.Point(0, 24);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(800, 426);
            this.dockPanel.TabIndex = 10;
            // 
            // StatusLabelCopyright
            // 
            this.StatusLabelCopyright.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabelCopyright.Name = "StatusLabelCopyright";
            this.StatusLabelCopyright.Size = new System.Drawing.Size(174, 21);
            this.StatusLabelCopyright.Text = "Copyright © gdoujkzz 2019";
            // 
            // StatusLabelVersion
            // 
            this.StatusLabelVersion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabelVersion.Name = "StatusLabelVersion";
            this.StatusLabelVersion.Size = new System.Drawing.Size(97, 21);
            this.StatusLabelVersion.Text = "Version 1.0.0.1";
            // 
            // StatusLabelUserName
            // 
            this.StatusLabelUserName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabelUserName.Name = "StatusLabelUserName";
            this.StatusLabelUserName.Size = new System.Drawing.Size(65, 21);
            this.StatusLabelUserName.Text = "gdoujkzz";
            // 
            // dpnSkin
            // 
            this.dpnSkin.Name = "dpnSkin";
            this.dpnSkin.Size = new System.Drawing.Size(93, 24);
            this.dpnSkin.Text = "Change Skin";
            this.dpnSkin.ToolTipText = "Change Skin";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelCopyright,
            this.StatusLabelVersion,
            this.StatusLabelUserName,
            this.dpnSkin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
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
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.Name = "MainFrm";
            this.TabText = "SimpleSystem";
            this.Text = "SimpleSystem";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelCopyright;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelVersion;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelUserName;
        private System.Windows.Forms.ToolStripDropDownButton dpnSkin;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

