using System;
using System.Windows.Forms;
using xwcs.core.manager;
using xwcs.core.plgs;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Widget;
using xwcs.core.ui.controls;
using DevExpress.XtraEditors;

namespace xwcs.plugin.dashboard
{
    public partial class DashboardControl : VisualControl// : xwcs.core.ui.controls.VisualControlDashboard
    {
        #region CONSTANTS
        public const string GUID = "2f89825d-b971-4620-b3d1-d7def30bfe0f";
        public const string VERSION = "1.0";
        public const xwcs.core.controls.ControlDockStyle DOCK_STYLE = xwcs.core.controls.ControlDockStyle.PLGT_document;
        #endregion

		public DashboardControl(xwcs.core.controls.VisualControlInfo vci) : base(vci)
		{
            InitializeComponent();

			Text = ControlName;
			UpdateDocumentManager();
            showWidgets();
			openWidgetsToolStripMenuItem.Click += openWidgetsToolStripMenuItem_Click;
		}

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

			openWidgetsToolStripMenuItem.Click -= openWidgetsToolStripMenuItem_Click;

			base.Dispose(disposing);
		}

		void UpdateDocumentManager()
        {
            widgetView1.AllowDocumentStateChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
			documentManager1.ContainerControl = this;
        }

        private void openWidgetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvailableWidgetsForm form = new AvailableWidgetsForm();
            form.ShowDialog();
            showWidgets();
        }

        private void showWidgets()
        {
            
            foreach (xwcs.core.controls.WidgetDescriptor wdsr in SWidgetManager.getInstance().Widgets)
            {
                if (wdsr.Visible)
                {
                    XtraUserControl controlNormal = SPluginsLoader.getInstance().getControlByGuid(wdsr.GuidNormalControl);
                    if (controlNormal != null)
                    {
                        Document document = widgetView1.AddDocument(controlNormal) as Document;

                        XtraUserControl controlMax = SPluginsLoader.getInstance().getControlByGuid(wdsr.GuidMaxControl);
                        if (controlMax != null)
                        {
                            document.MaximizedControl = controlMax;
                        }
                    }
                }
            }
        }
    }
}
