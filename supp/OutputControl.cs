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

        public OutputControl(xwcs.core.controls.VisualControlInfo vci) : base(vci)
		{
            InitializeComponent();            
            SEventProxy.getInstance().addEventHandler<OutputMessageEvent>(EventType.OutputMessageEvent, HandleOutputMessageEvent);

			Disposed += (s, e) =>
			{
				SEventProxy.getInstance().removeEventHandler<OutputMessageEvent>(EventType.OutputMessageEvent, HandleOutputMessageEvent);
			};
        }		

        private void HandleOutputMessageEvent(object sender, OutputMessageEvent e)
        {
            if(!IsDisposed && !richTextBox1.IsDisposed) {
				richTextBox1.AppendText(e.Message + Environment.NewLine);
				richTextBox1.SelectionStart = richTextBox1.Text.Length;
				// scroll it automatically
				try
				{
					richTextBox1.ScrollToCaret();
				}
				catch (Exception) { }
				
			}			
		}
    }
}
