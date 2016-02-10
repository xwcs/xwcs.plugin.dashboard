using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xwcs.core.ui.controls;

namespace xwcs.plugin.dashboard.supp
{
    public partial class TestControl : VisualControl
    {
        /* static control description */
        public const string GUID = "7f17f42a-082d-49a1-9783-0c5fda45b9b6";
        public const string VERSION = "1.0";
        public const xwcs.core.controls.ControlDockStyle DOCK_STYLE = xwcs.core.controls.ControlDockStyle.PLGT_status;


        public TestControl()
        {
            InitializeComponent();
        }
    }
}
