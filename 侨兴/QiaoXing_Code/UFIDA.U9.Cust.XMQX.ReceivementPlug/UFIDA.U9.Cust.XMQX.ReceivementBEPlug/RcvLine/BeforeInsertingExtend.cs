

namespace UFIDA.U9.Cust.XMQX.ReceivementBEPlug
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
            UFIDA.U9.PM.Rcv.RcvLine holder = key.GetEntity() as UFIDA.U9.PM.Rcv.RcvLine;                                      
            if (holder == null)                                                                   
                return;
            if (holder.DescFlexSegments.PrivateDescSeg1 == "3362")
            {
                if (holder.Wh.Code != "218" && holder.Wh.Code != "309" && holder.Wh.Code != "310")
                {
                    throw new Exception("存储地点：请选择客制自制半成品仓，客制保税原材料仓，客制非保税原材料仓其中一种！");
                }
            }                               
            #endregion                                                                            

        }
    }
}
