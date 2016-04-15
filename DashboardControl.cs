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
    public partial class DashboardControl : xwcs.core.ui.controls.VisualControl// : xwcs.core.ui.controls.VisualControlDashboard
    {
        /* static control description */
        public const string GUID = "2f89825d-b971-4620-b3d1-d7def30bfe0f";
        public const string VERSION = "1.0";
        public const xwcs.core.controls.ControlDockStyle DOCK_STYLE = xwcs.core.controls.ControlDockStyle.PLGT_document;


        private string _name = "DashboardControl";
        StackGroup group1, group2;
        //WidgetView view;

        public DashboardControl(xwcs.core.controls.VisualControlInfo vci) : base(vci)
		{
            InitializeComponent();

            Text = _name;
            UpdateDocumentManager();
            showWidgets();
            //Adding Documents to group1 is not necessary, since all newly created Documents are automatically placed in the first StackGroup.
            //group1.Items.AddRange(new Document[] { view.Documents[0] as Document, view.Documents[1] as Document });
            //view.Controller.Dock(view.Documents[2] as Document, group2);

        }

        void UpdateDocumentManager()
        {
            //DocumentManager dM = new DocumentManager();
            //view = new WidgetView();
            //dM.View = view;

            widgetView1.AllowDocumentStateChangeAnimation = DevExpress.Utils.DefaultBoolean.True;

            //widgetView1.LayoutMode = LayoutMode.FlowLayout;
            //view.

            
            group1 = new StackGroup();
            group2 = new StackGroup();

            group1.Length.UnitType = LengthUnitType.Star;
            group1.Length.UnitValue = 2;


            widgetView1.StackGroups.AddRange(new StackGroup[] { group1, group2 });            

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
