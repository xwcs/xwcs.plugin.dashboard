using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xwcs.core.plgs;
using xwcs.core.evt;
using xwcs.core.ui.controls;

namespace xwcs.plugin.dashboard
{
    
    public class Dashboard : VisualPluginBase
    {
        public Dashboard()
        {
            createPluginInfo("Dashboard", "1.0.0", pluginType.PLGT_visual);
            Info.addAbility(pluginAbility.PLGABLT_usercontrol);
            Info.addControl(new xwcs.core.controls.VisualControlInfo("Dashboard Panel", typeof(DashboardControl)));
            Info.addControl(new xwcs.core.controls.VisualControlInfo("OutputControl", typeof(supp.OutputControl)));
            Info.addControl(new xwcs.core.controls.VisualControlInfo("TestControl", typeof(supp.TestControl)));
        }      
       

        public override void afterInit()
        {
            MenuAddRequest[] menuadd = new MenuAddRequest[3];

            xwcs.core.controls.VisualControlInfo vic = Info.getVisualControlInfoByGuid(Guid.Parse(DashboardControl.GUID));
            XwBarButtonItem barButtonItem1 = new XwBarButtonItem(vic.Name, 1);
            barButtonItem1.ItemClick += buttonClick1;
            menuadd[0] = new MenuAddRequest { destination = MenuDestination.MENU_file_open, content = barButtonItem1 };

            vic = Info.getVisualControlInfoByGuid(Guid.Parse(supp.OutputControl.GUID));
            XwBarButtonItem barButtonItem2 = new XwBarButtonItem(vic.Name, 2);
            barButtonItem2.ItemClick += buttonClick2;
            menuadd[1] = new MenuAddRequest { destination = MenuDestination.MENU_ViewOtherWindows, content = barButtonItem2 };

            vic = Info.getVisualControlInfoByGuid(Guid.Parse(supp.TestControl.GUID));
            XwBarButtonItem barButtonItem3 = new XwBarButtonItem(vic.Name, 3);
            barButtonItem3.ItemClick += buttonClick3;
            menuadd[2] = new MenuAddRequest { destination = MenuDestination.MENU_ViewOtherWindows, content = barButtonItem3 };

            EventProxy.fireEvent(new AddToolBarRequestEvent(this, new AddToolBarRequest(menuadd)));
        }


        private void buttonClick1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenPanelRequest panelRequest = new OpenPanelRequest { Vci = Info.getVisualControlInfoByGuid(Guid.Parse(DashboardControl.GUID)) };
            OpenPanelRequestEvent openPanelEvent = new OpenPanelRequestEvent(this, panelRequest);
            EventProxy.fireEvent(openPanelEvent);
        }

        private void buttonClick2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenPanelRequest panelRequest = new OpenPanelRequest { Vci = Info.getVisualControlInfoByGuid(Guid.Parse(supp.OutputControl.GUID)) };
            OpenPanelRequestEvent openPanelEvent = new OpenPanelRequestEvent(this, panelRequest);
            EventProxy.fireEvent(openPanelEvent);
        }

        private void buttonClick3(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenPanelRequest panelRequest = new OpenPanelRequest { Vci = Info.getVisualControlInfoByGuid(Guid.Parse(supp.TestControl.GUID)) };
            OpenPanelRequestEvent openPanelEvent = new OpenPanelRequestEvent(this, panelRequest);
            EventProxy.fireEvent(openPanelEvent);
        }

    }
}
