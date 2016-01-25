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
using xwcs.core.evt;

namespace xwcs.plugin.dashboard.supp
{
    public partial class OutputControl : VisualControl
    {
        /* static control description */
        public const string GUID = "b14cd054-534d-4f6a-9ca8-53b753e5a1de";
        public const string VERSION = "1.0";
        public const xwcs.core.controls.ControlDockStyle DOCK_STYLE = xwcs.core.controls.ControlDockStyle.PLGT_status;

        //private string _name = "Output Control";
        public OutputControl()
        {
            InitializeComponent();
            SEventProxy.getInstance().addEventHandler(EventType.OutputMessageEvent, HandleOutputMessageEvent);
        }

        private void HandleOutputMessageEvent(Event e)
        {

            richTextBox1.Text += ((OutputMessageEvent)e).Message;
            richTextBox1.Text += "\n";
        }
    }
}
