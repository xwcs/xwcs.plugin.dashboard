using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xwcs.core.plgs;
using xwcs.core.evt;

namespace xwcs.plugin.dashboard
{
    
    public class DashboardEventType
    {
        public static readonly object UserManagementToolBarEvent = new object();
    }

    public class DashboardToolBarEvent : Event
    {
        public DashboardToolBarEvent(object sender, object data) : base(sender, DashboardEventType.UserManagementToolBarEvent, data)
        {
        }
    }
    

    public class Dashboard : IVisualPlugin
    {
        private IPluginHost _host;
        private PluginInfo _pluginInfo;

        public Dashboard()
        {
            _pluginInfo = new PluginInfo("Dashboard", "1.0.0", pluginType.PLGT_visual);
            _pluginInfo.addAbility(pluginAbility.PLGABLT_usercontrol);
            _pluginInfo.addControl("Dashboard Panel", Guid.Parse(DashboardControl.GUID));
        }

        public PluginInfo pluginInfo
        {
            get { return _pluginInfo; }
        }

        public DevExpress.XtraEditors.XtraUserControl getControlByGuid(Guid guid)
        {
            if (guid.ToString() == DashboardControl.GUID) return new DashboardControl();

            return null;
        }

        private void createStartButton()
        {
            /*
            DevExpress.XtraBars.BarSubItem button1 = new DevExpress.XtraBars.BarSubItem();
            XwBarButtonItem barButtonItem1 = new XwBarButtonItem(pluginInfo.name);
            XwBarButtonItem barButtonItem2 = new XwBarButtonItem(pluginInfo.name);
            button1.AddItem(barButtonItem1);
            button1.AddItem(barButtonItem2);
            barButtonItem1.ItemClick += buttonClick;
            MenuAddRequest[] menuadd = new MenuAddRequest[1];
            menuadd[0] = new MenuAddRequest { destination = MenuDestination.MENU_file_open, content=button1 }; 
            _host.eventProxy.fireEvent(new AddToolBarRequestEvent(this, new AddToolBarRequest(menuadd)));
            */
            XwBarButtonItem barButtonItem = new XwBarButtonItem(pluginInfo.name);
            barButtonItem.ItemClick += buttonClick;

            MenuAddRequest[] menuadd = new MenuAddRequest[1];
            menuadd[0] = new MenuAddRequest { destination = MenuDestination.MENU_file_open, content = barButtonItem };
            _host.eventProxy.fireEvent(new AddToolBarRequestEvent(this, new AddToolBarRequest(menuadd)));

        }

        private void buttonClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _host.eventProxy.fireEvent(new DashboardToolBarEvent(this, "toolbar button clicked"));
        }

        public void init(IPluginHost h)
        {
            _host = h;
            _host.eventProxy.addEventHandler(DashboardEventType.UserManagementToolBarEvent, HandlePlugin1ToolBarEvent);
            createStartButton();
        }

        private void HandlePlugin1ToolBarEvent(Event e)
        {
            Guid guid = pluginInfo.getGuidControlByName("Dashboard Panel");
            OpenPanelRequest panelRequest = new OpenPanelRequest(DevExpress.XtraBars.Docking.DockingStyle.Bottom, new DashboardControl(), guid);
            OpenPanelRequestEvent openPanelEvent = new OpenPanelRequestEvent(this, panelRequest);

            _host.eventProxy.fireEvent(openPanelEvent);
        }
    }
}
