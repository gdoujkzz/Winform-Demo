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
using WinformDock.Util;

namespace WinformDock
{
    public partial class NavFrm : DockContent
    {
        private DockPanel dockPanel;
        public NavFrm(DockPanel dp)
        {
            dockPanel = dp;
            InitializeComponent();
        }

        public void LoadMenu(int parentId)
        {
            subMenuTree.Nodes.Clear();
            LoadChildMenu(subMenuTree.Nodes, parentId);
        }

        public void LoadChildMenu(TreeNodeCollection collection,int parentId)
        {
            //加载子菜单。
           var childMenus=MenuDatas.MenuList.Where(d => d.ParentId == parentId).ToList();
           collection.Clear();
           foreach(var menu in childMenus)
           {
                var treeNode = new TreeNode();
                treeNode.Text = menu.Name;
                treeNode.Tag = new MenuData()
                {
                    Id=menu.Id,
                    FormType=menu.FormType,
                    Name=menu.Name,
                    ParentId=menu.Id,
                    SortOrder=menu.SortOrder
                };
                collection.Add(treeNode);
           }
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

        private void subMenuTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MenuData menuData = e.Node.Tag as MenuData;
                if (menuData != null)
                {
                    var type111 = Type.GetType(menuData.FormType);
                    ShowDocument(Type.GetType(menuData.FormType) ,menuData.Name);
                }
            }
        }
    }
}
