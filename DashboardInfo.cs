﻿using xwcs.core.plgs;

namespace xwcs.plugin.dashboard
{

    public class AssemblyInfo : IAssemblyInfo
    {
        string[] arr1 = new string[] { "xwcs.plugin.dashboard.DashboardPlugin" };

        public string[] Plugins
        {
            get
            {
                return arr1;
            }
        }
    }
}
