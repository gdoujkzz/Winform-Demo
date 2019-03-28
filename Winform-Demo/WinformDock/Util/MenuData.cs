using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformDock.Util
{
     public class MenuData
     {
         public int Id { get; set; }

         public string Name { get; set; }

         public int ParentId { get; set; }

         public string FormType { get; set; }
         
         public int SortOrder { get; set; }
     }

    public class MenuDatas {
        public static List<MenuData> MenuList => new List<MenuData>() {
            new MenuData() { Id=1,ParentId=0,Name="System",FormType="",SortOrder=1},
            new MenuData() { Id=2,ParentId=0,Name="Inbound",FormType="",SortOrder=2},
            new MenuData(){ Id=3,ParentId=0,Name="Outbound",FormType="",SortOrder=3},
            new MenuData(){ Id=4,ParentId=0,Name="Report",FormType="",SortOrder=4},
            new MenuData(){Id=11,ParentId=1,Name="UserManager",FormType="WinformDock.Base.UserManager,WinformDock",SortOrder=1},
            new MenuData(){Id=12,ParentId=1,Name="MenuManger",FormType="WinformDock.Base.MenuManager,WinformDock",SortOrder=2},
            new MenuData(){Id=21,ParentId=2,Name="PrintLabel",FormType="WinformDock.PrintLabel,WinformDock",SortOrder=1},
            new MenuData(){Id=31,ParentId=3,Name="DeliveryList",FormType="WinformDock.Outbound.DeliveryList,WinformDock",SortOrder=1},
            new MenuData(){Id=41,ParentId=4,Name="DaReport",FormType="WinformDock.Report.DaReport,WinformDock",SortOrder=1}
        };
    }

     


}
