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

namespace DockingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2 f2 = new Form2();
            f2.Show(dockPanel, DockState.DockLeft);
            Form3 f3 = new Form3();
            f3.Show(dockPanel, DockState.DockRight);
            Form4 f4 = new Form4();
            f4.Show(dockPanel, DockState.Document);
        }

    }
}
