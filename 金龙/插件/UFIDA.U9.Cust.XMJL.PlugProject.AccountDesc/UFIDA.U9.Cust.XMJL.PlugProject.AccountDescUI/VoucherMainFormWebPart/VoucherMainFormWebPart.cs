

namespace UFIDA.U9.Cust.XMJL.PlugProject.AccountDescUI
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Collections.Specialized;
    using UFSoft.UBF.UI.ControlModel;
    using UFSoft.UBF.UI.WebControlAdapter;
    using UFSoft.UBF.UI.WebControls.ClientCallBack;
    using UFSoft.UBF.UI.WebControls.Association;
    using System.Web.UI.WebControls.WebParts;
    using UFSoft.UBF.UI.IView;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using UFSoft.UBF.UI.Controls;
    using UFSoft.UBF.UI.WebControls;
    
    
    public partial class VoucherMainFormWebPart : UFSoft.UBF.UI.Custom.ExtendedPartBase
    {
        public override void AfterLoad(IPart Part, EventArgs args)
        {
            this.Do_AfterLoad(Part, args);
        }
    }
}
