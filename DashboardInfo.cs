using xwcs.core.plgs;

namespace xwcs.plugin.dashboard
{

    public class Info : IPluginInfo
    {
        string[] arr1 = new string[] { "xwcs.plugin.dashboard.Dashboard" };

        public string[] Plugins
        {
            get
            {
                return arr1;
            }
        }
    }
}
