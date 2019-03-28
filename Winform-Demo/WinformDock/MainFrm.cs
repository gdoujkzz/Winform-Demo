using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WinformDock.Base;
using WinformDock.Outbound;
using WinformDock.Report;
using WinformDock.Util;

namespace WinformDock
{
    public partial class MainFrm : DockContent
    {
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private NavFrm _navFrm;
        public MainFrm()
        {
            InitializeComponent();
            try
            {
                this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
                // 
                // skinEngine1
                // 
                this.skinEngine1.@__DrawButtonFocusRectangle = true;
                this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
                this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
                this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
                this.skinEngine1.SerialNumber = "";
                this.skinEngine1.SkinFile = null;
            }
            catch (System.Exception ex)
            {
                //throw;
            }
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_Load(object sender, EventArgs e)
        {
            GenerateMenuHeader();
            BindSkinList();
            SetNavFrm();
            //窗体加载的时候
            DockContent form = new Welcome();
            form.Name = "WelcomeForm";
            form.TabText = "Welcome";
            form.Show(dockPanel);
        }

        /// <summary>
        /// 生成菜单头
        /// </summary>
        private void GenerateMenuHeader()
        {
            MenuDatas.MenuList.Where(d=>d.ParentId==0).OrderBy(d=>d.SortOrder).ToList().ForEach(d =>
            {
                var menu = new MenuData() { Id = d.Id, ParentId = d.ParentId, Name = d.Name, SortOrder = d.SortOrder };
                mainMenu.Items.Add(new System.Windows.Forms.ToolStripMenuItem()
                {
                    Text = menu.Name,
                    Tag = menu,
                });
            });
        }
        
        private void SetNavFrm()
        {
            _navFrm = new NavFrm(dockPanel);
            _navFrm.CloseButton = false;
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                _navFrm.MdiParent = this;
                _navFrm.Show(dockPanel, DockState.DockLeft);
            }
            else
            {
                _navFrm.Show(dockPanel, DockState.DockLeft);
            }
        }

        private void BindSkinList()
        {
            dpnSkin.DropDownItems.Clear();
            var image = Image.FromFile("menu.png");
            DirectoryInfo TheFolder = new DirectoryInfo(Application.StartupPath + string.Format("//Skins"));
            
            //遍历文件
            foreach (FileInfo file in TheFolder.GetFiles())
            {
                dpnSkin.DropDownItems.Add(new ToolStripMenuItem(file.Name, image, dpnSkin_Click, file.Name));
            }

            //dpnSkin.DropDownItems.Add(new ToolStripMenuItem("皮肤Calmness", image, dpnSkin_Click, "Calmness"));
            //dpnSkin.DropDownItems.Add(new ToolStripMenuItem("皮肤Midsummer", image, dpnSkin_Click, "Midsummer"));
            //dpnSkin.DropDownItems.Add(new ToolStripMenuItem("皮肤mp10pink", image, dpnSkin_Click, "mp10pink"));
            //dpnSkin.DropDownItems.Add(new ToolStripMenuItem("皮肤OneGreen", image, dpnSkin_Click, "OneGreen"));
            //dpnSkin.DropDownItems.Add(new ToolStripMenuItem("皮肤Warm", image, dpnSkin_Click, "Warm"));
        }


        private void dpnSkin_Click(object sender, EventArgs e)
        {
            try
            {
                var tsDropDownItem = sender as ToolStripDropDownItem;
                if (tsDropDownItem == null)
                {
                    return;
                }
                string skinName = tsDropDownItem.Name;

                this.skinEngine1.SkinFile = Application.StartupPath + string.Format("//Skins//{0}", skinName);
                //var se = new Sunisoft.IrisSkin.SkinEngine();

            }
            catch (Exception ex)
            {

                //MessageBoxUtils.Show(ex.Message);
                return;
            }

        }


        //private void printLabelToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ShowDocument(typeof(PrintLabel), "PrintLabel",dockPanel);
        //}

        //private void deliveryListToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ShowDocument(typeof(DeliveryList), "DeliveryList");
        //}

        //private void daReportToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ShowDocument(typeof(DaReport), "DaReport");
        //}

        //private void userManagerToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ShowDocument(typeof(UserManager), "UserManager");
        //}

        //当别人点击菜单头的时候，想办法带出子菜单来。
        private void mainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var menuData = e.ClickedItem.Tag as MenuData;
            if (menuData != null)
            {
                _navFrm.Text = menuData.Name;
                _navFrm.TabText = menuData.Name;
                _navFrm.LoadMenu(menuData.Id);
            }
        }
    }
}
