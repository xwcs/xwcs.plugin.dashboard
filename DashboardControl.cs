using System;
using System.Windows.Forms;

using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Widget;

namespace xwcs.plugin.dashboard
{
    public partial class DashboardControl : xwcs.core.ui.controls.VisualControl// : xwcs.core.ui.controls.VisualControlDashboard
    {
        private string _name = "DashboardControl";
        public const string GUID = "2f89825d-b971-4620-b3d1-d7def30bfe0f";
        StackGroup group1, group2;
        WidgetView view;

        public DashboardControl()
        {
            _controlInfo = new xwcs.core.ui.controls.ControlInfo { Name = _name, Version = "1.0", Type = xwcs.core.ui.controls.controlType.PLGT_document, GUID = new Guid(GUID) };
            InitializeComponent();

            Text = _name;
            UpdateDocumentManager();
            
            for (int i = 0; i < 3; i++)
            {
                AddDocuments();
            }
            
            //Adding Documents to group1 is not necessary, since all newly created Documents are automatically placed in the first StackGroup.
            group1.Items.AddRange(new Document[] { view.Documents[0] as Document, view.Documents[1] as Document });
            view.Controller.Dock(view.Documents[2] as Document, group2);
            
        }

        void UpdateDocumentManager()
        {
            DocumentManager dM = new DocumentManager();
            view = new WidgetView();
            dM.View = view;

            view.AllowDocumentStateChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
            group1 = new StackGroup();
            group2 = new StackGroup();
            group1.Length.UnitType = LengthUnitType.Star;
            group1.Length.UnitValue = 2;
            view.StackGroups.AddRange(new StackGroup[] { group1, group2 });
            dM.ContainerControl = this;
        }

        void AddDocuments()
        {
            Document document = view.AddDocument(new UserControl1()) as Document;
            document.MaximizedControl = new UserControl2();
        }        
    }
}
