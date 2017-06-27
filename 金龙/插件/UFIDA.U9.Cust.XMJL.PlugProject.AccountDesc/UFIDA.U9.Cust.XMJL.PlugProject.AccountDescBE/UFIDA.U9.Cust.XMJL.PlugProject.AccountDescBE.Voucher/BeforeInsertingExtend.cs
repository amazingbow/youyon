

namespace UFIDA.U9.Cust.XMJL.PlugProject.AccountDescBE
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base;
    using UFSoft.UBF.Business;
    
    
    public partial class BeforeInserting
    {
        
        private void Do_Notify(object[] args)
        {
            #region 从事件参数中取得当前业务实体													 
                                                                                                  
            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;                                                                           
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;  
            if (key == null)                                                                      
                return;                                                                           
            UFIDA.U9.GL.Voucher.Voucher holder = key.GetEntity() as UFIDA.U9.GL.Voucher.Voucher;                                      
            if (holder == null)                                                                   
                return;
            string[] ArraySureAcc = { "1231", "1471", "1603", "1811", "223314", "2901", "6701", "6711", "6111", "6101", "6301", "6801" };
            foreach (var entry in holder.Entries)
            {
                foreach (var SureAcc in ArraySureAcc)
                {
                    if (entry.Account.Code.StartsWith(SureAcc))
                    {
                        holder.DescFlexField.PrivateDescSeg1 = "True";
                    }
                }
            }           
                                                                                                  
            #endregion                                                                            

        }
    }
}
