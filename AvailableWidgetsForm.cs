using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xwcs.core.manager;
using xwcs.core.plgs;

namespace xwcs.plugin.dashboard
{
    public partial class AvailableWidgetsForm : Form
    {
        public AvailableWidgetsForm()
        {
            InitializeComponent();
            showAvailableWidgets();
        }

        private void showAvailableWidgets()
        {
            checkedListBoxControl1.DataSource = SWidgetManager.getInstance().Widgets;
            checkedListBoxControl1.DisplayMember = "WidgetName";
            checkedListBoxControl1.CheckMember = "Visible";
        }

        private void AvailableWidgetsForm_Deactivate(object sender, EventArgs e)
        {
        }
    }
}
