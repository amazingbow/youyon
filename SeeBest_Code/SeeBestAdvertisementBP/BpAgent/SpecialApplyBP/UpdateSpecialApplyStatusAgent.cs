﻿








namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.SpecialApplyBP.Proxy
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.IO;
	using System.ServiceModel;
	using System.Runtime.Serialization;
	using UFSoft.UBF;
	using UFSoft.UBF.Exceptions;
	using UFSoft.UBF.Util.Context;
	using UFSoft.UBF.Service;
	using UFSoft.UBF.Service.Base ;

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.SeeBestAdvertisementBP.SpecialApplyBP.IUpdateSpecialApplyStatus")]
    public interface IUpdateSpecialApplyStatus
    {
		[ServiceKnownType(typeof(ApplicationContext))]
		[ServiceKnownType(typeof(PlatformContext))]
		[ServiceKnownType(typeof(ThreadContext))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.BusinessException))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.EntityNotExistException))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.AttributeInValidException))]
		[ServiceKnownType(typeof(UFSoft.UBF.Business.AttrsContainerException))]
		[ServiceKnownType(typeof(UFSoft.UBF.Exceptions.MessageBase))]
			[FaultContract(typeof(UFSoft.UBF.Service.ServiceLostException))]
		[FaultContract(typeof(UFSoft.UBF.Service.ServiceException))]
		[FaultContract(typeof(UFSoft.UBF.Service.ServiceExceptionDetail))]
		[FaultContract(typeof(ExceptionBase))]
		[FaultContract(typeof(Exception))]
		[OperationContract()]
		System.Boolean Do(IContext context, out IList<MessageBase> outMessages ,System.Int64 iD, System.Int64 sysVersion);
    }
	[Serializable]    
    public class UpdateSpecialApplyStatusProxy : OperationProxyBase//, UFIDA.U9.Cust.SeeBestAdvertisementBP.SpecialApplyBP.Proxy.IUpdateSpecialApplyStatus
    {
	#region Fields	
				private System.Int64 iD ;
						private System.Int64 sysVersion ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// 修改专柜申请单状态.Misc.ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ID
		{
			get	
			{	
				return this.iD;
			}

			set	
			{	
				this.iD = value;	
			}
		}		
						

		/// <summary>
		/// 事务版本 (该属性可为空,但有默认值)
		/// 修改专柜申请单状态.Misc.事务版本
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SysVersion
		{
			get	
			{	
				return this.sysVersion;
			}

			set	
			{	
				this.sysVersion = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public UpdateSpecialApplyStatusProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.Boolean Do()
        {
  			InitKeyList() ;
 			System.Boolean result = (System.Boolean)InvokeAgent<UFIDA.U9.Cust.SeeBestAdvertisementBP.SpecialApplyBP.Proxy.IUpdateSpecialApplyStatus>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IUpdateSpecialApplyStatus channel = oChannel as IUpdateSpecialApplyStatus;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, iD, sysVersion);
	    }
            return  false;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private System.Boolean GetRealResult(System.Boolean result)
		{

				return result ;
		}
		#region  Init KeyList 
		//初始化SKey集合--由于接口不一样.BP.SV都要处理
		private void InitKeyList()
		{
			System.Collections.Hashtable dict = new System.Collections.Hashtable() ;
										
		}
		#endregion 

    }
}


