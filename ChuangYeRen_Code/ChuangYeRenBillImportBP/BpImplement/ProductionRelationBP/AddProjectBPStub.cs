﻿







namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ServiceModel;
	using System.Runtime.Serialization;
	using System.IO;
	using UFSoft.UBF.Util.Context;
	using UFSoft.UBF;
	using UFSoft.UBF.Exceptions;
	using UFSoft.UBF.Service.Base ;

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP.IAddProjectBP")]
    public interface IAddProjectBP
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
        PublicDataTransObj.PublicReturnDTOData Do(IContext context ,out IList<MessageBase> outMessages ,System.String code, System.DateTime startDate, System.DateTime endDate, System.Int64 fromOrg, System.Int64 toOrg);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class AddProjectBPStub : OperationStubBase, IAddProjectBP
    {
        #region IAddProjectBP Members

        //[OperationBehavior]
        public PublicDataTransObj.PublicReturnDTOData Do(IContext context ,out IList<MessageBase> outMessages, System.String code, System.DateTime startDate, System.DateTime endDate, System.Int64 fromOrg, System.Int64 toOrg)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, code, startDate, endDate, fromOrg, toOrg);
        }
        
        //[OperationBehavior]
        public PublicDataTransObj.PublicReturnDTOData DoEx(ICommonDataContract commonData, System.String code, System.DateTime startDate, System.DateTime endDate, System.Int64 fromOrg, System.Int64 toOrg)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP.AddProjectBP");                
                AddProjectBP objectRef = new AddProjectBP();
					
				objectRef.Code = code;
				objectRef.StartDate = startDate;
				objectRef.EndDate = endDate;
				objectRef.FromOrg = fromOrg;
				objectRef.ToOrg = toOrg;

				//处理返回类型.
				PublicDataTransObj.PublicReturnDTO result = objectRef.Do();

				if (result == null)
					return null ;
						PublicDataTransObj.PublicReturnDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP.AddProjectBP");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP.AddProjectBP");
            }
        }
	#endregion
    }
}