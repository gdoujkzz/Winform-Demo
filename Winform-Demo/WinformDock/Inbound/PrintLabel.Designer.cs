namespace WinformDock
{
    partial class PrintLabel
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuTabPage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAllButThisOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuTabPage
            // 
            this.contextMenuTabPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem,
            this.CloseAllToolStripMenuItem,
            this.CloseAllButThisOneToolStripMenuItem});
            this.contextMenuTabPage.Name = "contextMenuTabPage";
            this.contextMenuTabPage.Size = new System.Drawing.Size(202, 70);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.CloseToolStripMenuItem.Text = "Close";
            // 
            // CloseAllToolStripMenuItem
            // 
            this.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem";
            this.CloseAllToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.CloseAllToolStripMenuItem.Text = "Close All";
            // 
            // CloseAllButThisOneToolStripMenuItem
            // 
            this.CloseAllButThisOneToolStripMenuItem.Name = "CloseAllButThisOneToolStripMenuItem";
            this.CloseAllButThisOneToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.CloseAllButThisOneToolStripMenuItem.Text = "Close All But this One";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(296, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "this is PrintLabel";
            // 
            // PrintLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Name = "PrintLabel";
            this.TabPageContextMenuStrip = this.contextMenuTabPage;
            this.TabText = "PrintLabel";
            this.Text = "PrintLabel";
            this.contextMenuTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuTabPage;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseAllButThisOneToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}