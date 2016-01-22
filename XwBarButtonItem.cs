using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xwcs.plugin.dashboard
{
    class XwBarButtonItem : DevExpress.XtraBars.BarButtonItem
    {
        public const int ID = 12345;

        public XwBarButtonItem(string c)
        {
            Id = ID;
            Caption = c;
        }
    }
}
