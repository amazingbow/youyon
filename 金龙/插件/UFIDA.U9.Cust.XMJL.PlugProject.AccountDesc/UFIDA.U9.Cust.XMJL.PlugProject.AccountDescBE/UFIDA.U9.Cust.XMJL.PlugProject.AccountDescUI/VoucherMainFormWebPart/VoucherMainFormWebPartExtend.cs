

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


    public partial class VoucherMainFormWebPart
    {

        #region 字段与属性

        private UFIDA.U9.FI.GL.Voucher.VoucherUIModel.VoucherMainFormWebPart _strongPart;

        #endregion


        private void Do_AfterLoad(UFSoft.UBF.UI.IView.IPart part, EventArgs args)
        {
            #region 获取相关强类型数据

            _strongPart = part as UFIDA.U9.FI.GL.Voucher.VoucherUIModel.VoucherMainFormWebPart;
            if (_strongPart == null)
                return;
            
            #endregion

        }
        public override void AfterEventProcess(IPart Part, string eventName, object sender, EventArgs args)
        {
            base.AfterEventProcess(Part, eventName, sender, args);
            IUFButton btn = sender as IUFButton;
            if (btn != null)
            {
                switch (btn.Action)
                {
                    case "OnSave":
                        //写自己代码
                        //_strongPart.Model.Voucher_Entries.FocusedRecord.Account 
                        if (_strongPart.Model.Voucher.FocusedRecord == null) return;
                        string[] ArraySureAcc = { "1231", "1471", "1603", "1811", "223314", "2901", "6701", "6711", "6111", "6101", "6301", "6801" };
                        foreach (var SureAcc in ArraySureAcc)
                        {
                            foreach (var record in _strongPart.Model.Voucher_Entries.Records)
                            {
                                if (record["Account_Code"].ToString().StartsWith(SureAcc))
                                {
                                    _strongPart.Model.Voucher.FocusedRecord.DescFlexField_PrivateDescSeg1 = "True";
                                }
                            }

                        }

                        break;
                }
            }
        }
    }
}
