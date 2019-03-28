namespace WinformDock
{
    partial class NavFrm
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
            this.subMenuTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // subMenuTree
            // 
            this.subMenuTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subMenuTree.Location = new System.Drawing.Point(0, 0);
            this.subMenuTree.Name = "subMenuTree";
            this.subMenuTree.Size = new System.Drawing.Size(180, 450);
            this.subMenuTree.TabIndex = 0;
            this.subMenuTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.subMenuTree_NodeMouseDoubleClick);
            // 
            // NavFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 450);
            this.Controls.Add(this.subMenuTree);
            this.Name = "NavFrm";
            this.TabText = "NavFrm";
            this.Text = "NavFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView subMenuTree;
    }
}