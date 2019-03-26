using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace WinformDock
{
    public partial class MainFrm : DockContent
    {
        private System.Windows.Forms.ContextMenuStrip contextMenuTabPage;
        public MainFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_Load(object sender, EventArgs e)
        {
            //窗体加载的时候
            DockContent form = new Welcome();
            form.Name = "WelcomeForm";
            form.TabText = "Welcome";
            form.Show(dockPanel);
        }


        public void ShowDocument(Type formType, string tabText, params object[] args)
        {
            IDockContent docForm = FindDocument(formType.Name);
            if (docForm == null)
            {
                try
                {
                    DockContent form = (DockContent)Activator.CreateInstance(formType, args);
                    form.Name = formType.Name;
                    form.TabText = tabText;
                    if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                    {
                        form.MdiParent = this;
                        form.Show(dockPanel);
                    }
                    else
                    {
                        form.Show(dockPanel);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                docForm.DockHandler.Activate();
            }
        }




        private IDockContent FindDocument(string text)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    if (form.Text == text)
                        return form as IDockContent;

                return null;
            }
            else
            {
                foreach (IDockContent content in dockPanel.Documents)
                    if (content.DockHandler.TabText == text)
                        return content;

                return null;
            }
        }

        private void printLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDocument(typeof(DummyDoc), "DummyDoc",dockPanel);
        }
    }
}
