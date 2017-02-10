﻿
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE
{
	/// <summary>
	/// 合兴关系对照表 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBEData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class HxRelationshipBEData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public HxRelationshipBEData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     							RefType= 0; 			     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     							U9EntityId= 0; 			     			


			//设置组合的集合属性为List<>对象. -目前直接在属性上处理.
			
			//调用默认值初始化服务进行配置方式初始化
			UFSoft.UBF.Service.DTOService.InitConfigDefault(this);
		}		
		[System.Runtime.Serialization.OnDeserializing]
        internal void OnDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
			 initData();
        }
        
		#region System Fields
		///<summary>
		/// 实体类型. 
		/// </summary>
		[DataMember(IsRequired=false)]
		public override string SysEntityType
		{
			get { return "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 关照类型
		/// 合兴关系对照表.Misc.关照类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_refType;
		public System.Int32 RefType
		{
			get	
			{	
				return m_refType ;
			}
			set	
			{	
				m_refType = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 合兴关系对照表.Key.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_iD ;
		public System.Int64 ID
		{
			get	
			{	
				return m_iD  ;
			}
			set	
			{	
				m_iD = value ;	
			}
		}
		

				/// <summary>
		/// 创建时间
		/// 合兴关系对照表.Sys.创建时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_createdOn ;
		public System.DateTime CreatedOn
		{
			get	
			{	
				return m_createdOn  ;
			}
			set	
			{	
				m_createdOn = value ;	
			}
		}
		

				/// <summary>
		/// 创建人
		/// 合兴关系对照表.Sys.创建人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_createdBy ;
		public System.String CreatedBy
		{
			get	
			{	
				return m_createdBy  ;
			}
			set	
			{	
				m_createdBy = value ;	
			}
		}
		

				/// <summary>
		/// 修改时间
		/// 合兴关系对照表.Sys.修改时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_modifiedOn ;
		public System.DateTime ModifiedOn
		{
			get	
			{	
				return m_modifiedOn  ;
			}
			set	
			{	
				m_modifiedOn = value ;	
			}
		}
		

				/// <summary>
		/// 修改人
		/// 合兴关系对照表.Sys.修改人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_modifiedBy ;
		public System.String ModifiedBy
		{
			get	
			{	
				return m_modifiedBy  ;
			}
			set	
			{	
				m_modifiedBy = value ;	
			}
		}
		

				/// <summary>
		/// 事务版本
		/// 合兴关系对照表.Sys.事务版本
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_sysVersion ;
		public System.Int64 SysVersion
		{
			get	
			{	
				return m_sysVersion  ;
			}
			set	
			{	
				m_sysVersion = value ;	
			}
		}
		

				/// <summary>
		/// SAP编码
		/// 合兴关系对照表.Misc.SAP编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sapCode ;
		public System.String SapCode
		{
			get	
			{	
				return m_sapCode  ;
			}
			set	
			{	
				m_sapCode = value ;	
			}
		}
		

				/// <summary>
		/// SAP名称
		/// 合兴关系对照表.Misc.SAP名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sapName ;
		public System.String SapName
		{
			get	
			{	
				return m_sapName  ;
			}
			set	
			{	
				m_sapName = value ;	
			}
		}
		

				/// <summary>
		/// SAP公司代码
		/// 合兴关系对照表.Misc.SAP公司代码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sapCompCode ;
		public System.String SapCompCode
		{
			get	
			{	
				return m_sapCompCode  ;
			}
			set	
			{	
				m_sapCompCode = value ;	
			}
		}
		

				/// <summary>
		/// SAP公司名称
		/// 合兴关系对照表.Misc.SAP公司名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sapCompName ;
		public System.String SapCompName
		{
			get	
			{	
				return m_sapCompName  ;
			}
			set	
			{	
				m_sapCompName = value ;	
			}
		}
		

				/// <summary>
		/// 物料组编码
		/// 合兴关系对照表.Misc.物料组编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sapMasterCode ;
		public System.String SapMasterCode
		{
			get	
			{	
				return m_sapMasterCode  ;
			}
			set	
			{	
				m_sapMasterCode = value ;	
			}
		}
		

				/// <summary>
		/// 物料组名称
		/// 合兴关系对照表.Misc.物料组名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sapMasterName ;
		public System.String SapMasterName
		{
			get	
			{	
				return m_sapMasterName  ;
			}
			set	
			{	
				m_sapMasterName = value ;	
			}
		}
		

				/// <summary>
		/// 资产编码
		/// 合兴关系对照表.Misc.资产编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sapAssetsCode ;
		public System.String SapAssetsCode
		{
			get	
			{	
				return m_sapAssetsCode  ;
			}
			set	
			{	
				m_sapAssetsCode = value ;	
			}
		}
		

				/// <summary>
		/// 资产名称
		/// 合兴关系对照表.Misc.资产名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sapAssetsName ;
		public System.String SapAssetsName
		{
			get	
			{	
				return m_sapAssetsName  ;
			}
			set	
			{	
				m_sapAssetsName = value ;	
			}
		}
		

				/// <summary>
		/// 费用编码
		/// 合兴关系对照表.Misc.费用编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sapFeeCode ;
		public System.String SapFeeCode
		{
			get	
			{	
				return m_sapFeeCode  ;
			}
			set	
			{	
				m_sapFeeCode = value ;	
			}
		}
		

				/// <summary>
		/// 费用名称
		/// 合兴关系对照表.Misc.费用名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sapFeeName ;
		public System.String SapFeeName
		{
			get	
			{	
				return m_sapFeeName  ;
			}
			set	
			{	
				m_sapFeeName = value ;	
			}
		}
		

				/// <summary>
		/// U9编码
		/// 合兴关系对照表.Misc.U9编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_u9Code ;
		public System.String U9Code
		{
			get	
			{	
				return m_u9Code  ;
			}
			set	
			{	
				m_u9Code = value ;	
			}
		}
		

				/// <summary>
		/// U9名称
		/// 合兴关系对照表.Misc.U9名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_u9Name ;
		public System.String U9Name
		{
			get	
			{	
				return m_u9Name  ;
			}
			set	
			{	
				m_u9Name = value ;	
			}
		}
		

				/// <summary>
		/// U9实体ID
		/// 合兴关系对照表.Misc.U9实体ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_u9EntityId ;
		public System.Int64 U9EntityId
		{
			get	
			{	
				return m_u9EntityId  ;
			}
			set	
			{	
				m_u9EntityId = value ;	
			}
		}
		

				/// <summary>
		/// 备注
		/// 合兴关系对照表.Misc.备注
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_memo ;
		public System.String Memo
		{
			get	
			{	
				return m_memo  ;
			}
			set	
			{	
				m_memo = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
																					
		#endregion 		
	}	

}
