﻿








namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP.IAddProjectBE")]
    public interface IAddProjectBE
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
		PublicDataTransObj.PublicReturnDTOData Do(IContext context, out IList<MessageBase> outMessages ,System.String code, System.DateTime startDate, System.DateTime endDate, System.Int64 fromOrg, System.Int64 toOrg);
    }
	[Serializable]    
    public class AddProjectBEProxy : OperationProxyBase//, UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP.Proxy.IAddProjectBE
    {
	#region Fields	
				private System.String code ;
						private System.DateTime startDate ;
						private System.DateTime endDate ;
						private System.Int64 fromOrg ;
						private System.Int64 toOrg ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 项目号 (该属性可为空,且无默认值)
		/// 添加项目.Misc.项目号
		/// </summary>
		/// <value>System.String</value>
		public System.String Code
		{
			get	
			{	
				return this.code;
			}

			set	
			{	
				this.code = value;	
			}
		}		
						

		/// <summary>
		/// 开始时间 (该属性可为空,且无默认值)
		/// 添加项目.Misc.开始时间
		/// </summary>
		/// <value>System.Date</value>
		public System.DateTime StartDate
		{
			get	
			{	
				return this.startDate;
			}

			set	
			{	
				this.startDate = value;	
			}
		}		
						

		/// <summary>
		/// 结束时间 (该属性可为空,且无默认值)
		/// 添加项目.Misc.结束时间
		/// </summary>
		/// <value>System.Date</value>
		public System.DateTime EndDate
		{
			get	
			{	
				return this.endDate;
			}

			set	
			{	
				this.endDate = value;	
			}
		}		
						

		/// <summary>
		/// 组织 (该属性可为空,但有默认值)
		/// 添加项目.Misc.组织
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 FromOrg
		{
			get	
			{	
				return this.fromOrg;
			}

			set	
			{	
				this.fromOrg = value;	
			}
		}		
						

		/// <summary>
		/// 下发组织 (该属性可为空,但有默认值)
		/// 添加项目.Misc.下发组织
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ToOrg
		{
			get	
			{	
				return this.toOrg;
			}

			set	
			{	
				this.toOrg = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public AddProjectBEProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public PublicDataTransObj.PublicReturnDTOData Do()
        {
  			InitKeyList() ;
 			PublicDataTransObj.PublicReturnDTOData result = (PublicDataTransObj.PublicReturnDTOData)InvokeAgent<UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP.Proxy.IAddProjectBE>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IAddProjectBE channel = oChannel as IAddProjectBE;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, code, startDate, endDate, fromOrg, toOrg);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private PublicDataTransObj.PublicReturnDTOData GetRealResult(PublicDataTransObj.PublicReturnDTOData result)
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


