﻿using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE
{
	
	/// <summary>
	/// 实体: SAP与U9凭证对接中间表行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class HeXingSAPU9GLVoucherLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public HeXingSAPU9GLVoucherLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static HeXingSAPU9GLVoucherLine Create(UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead parentEntity) {
			HeXingSAPU9GLVoucherLine entity = (HeXingSAPU9GLVoucherLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.HeXingSAPU9GLVoucherHead = parentEntity ;
			parentEntity.HeXingSAPU9GLVoucherLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected HeXingSAPU9GLVoucherLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			:base(info,context)
		{
		}
		protected override bool IsMainEntity
		{
			get { return false ;}
		}
		#endregion

		#region Create Default 
	    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
        [Obsolete("仅用于开发的测试用例时期.正式版返回NULL.不可使用.")]
		public  static HeXingSAPU9GLVoucherLine CreateDefault(UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead parentEntity) {
		#if Test		
			return CreateDefault_Extend(parentEntity);
		#else 
		    return null;
		#endif
		}
	
		#endregion

		#region ClassKey
		protected override string ClassKey_FullName
        {
            get { return "UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class HeXingSAPU9GLVoucherLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new HeXingSAPU9GLVoucherLine GetEntity()
			{
				return (HeXingSAPU9GLVoucherLine)base.GetEntity();
			}
			public static bool operator ==(EntityKey obja, EntityKey objb)
			{
				if (object.ReferenceEquals(obja, null))
				{
					if (object.ReferenceEquals(objb, null))
						return true;
					return false;
				}
				return obja.Equals(objb);
			}
			public static bool operator !=(EntityKey obja, EntityKey objb)
			{
				return !(obja == objb);
			}
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}
			public override bool Equals(object obj)
			{
				return base.Equals(obj);
			}
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityKey CreateEntityKey()
		{
			return new EntityKey(this.ID);
		}
		/// <summary>
		/// Strong Class EntityKey Property
		/// </summary>
		public new EntityKey Key
		{
			get
			{
				return base.Key as EntityKey;
			}
		}
		#endregion

		#region Finder
		/// <summary>
		/// Strong Class EntityFinder
		/// </summary>
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<HeXingSAPU9GLVoucherLine> 
		{
		    public EntityFinder():base(CurrentClassKey)
			{
			}
			public new EntityList FindAll(string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(opath, oqlParameters));                
			}
			public new EntityList FindAll(UFSoft.UBF.PL.ObjectQueryOptions options, string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(options,opath, oqlParameters));                
			}









						
		}

		//private static EntityFinder _finder  ;

		/// <summary>
		/// Finder
		/// </summary>
		public static EntityFinder Finder {
			get {
				//if (_finder == null)
				//	_finder =  new EntityFinder() ;
				return new EntityFinder() ;
			}
		}
		#endregion
			
		#region List

		/// <summary>
		/// EntityList
		/// </summary>
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<HeXingSAPU9GLVoucherLine>{
		    #region constructor 
		    /// <summary>
		    /// EntityList 无参的构造方法,用于其它特殊情况
		    /// </summary>
		    public EntityList()
		    {
		    }

		    /// <summary>
		    /// EntityList Constructor With Collection .主要用于查询返回实体集时使用.
		    /// </summary>
		    public EntityList(IList list) : base(list)
		    { 
		    }
		    
		    /// <summary>
		    ///  EntityList Constructor , used by  peresidence
		    /// </summary>
		    /// <param name="childAttrName">this EntityList's child Attribute Name</param>
		    /// <param name="parentEntity">this EntityList's Parent Entity </param>
		    /// <param name="parentAttrName">Parent Entity's Attribute Name with this EntityList's </param>
		    /// <param name="list">list </param>
		    public EntityList(string childAttrName,UFSoft.UBF.Business.BusinessEntity parentEntity, string parentAttrName, IList list)
			    :base(childAttrName,parentEntity,parentAttrName,list) 
		    { 
			
		    }

		    #endregion 
		    //用于一对多关联.	
		    internal IList InnerList
		    {
		    	//get { return this.innerList; }
		    	set {
		    		if (value != null)
		    		    this.innerList = value; 
		    	}
		    }
		    protected override bool IsMainEntity
		    {
			    get { return false ;}
		    }
		}
		#endregion
		
		#region Typeed OriginalData
		/// <summary>
		/// 当前实体对象的旧数据对象(为上次更新后的数据)
		/// </summary>
		public new EntityOriginal OriginalData
		{
			get {
				return (EntityOriginal)base.OriginalData;
			}
            protected set
            {
				base.OriginalData = value ;
            }
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityOriginal CreateOriginalData()
		{
			return new EntityOriginal(this);
		}
		
		public new partial class EntityOriginal: UFSoft.UBF.Business.Entity.EntityOriginal
		{
		    //private HeXingSAPU9GLVoucherLine ContainerEntity ;
		    public  new HeXingSAPU9GLVoucherLine ContainerEntity 
		    {
				get { return  (HeXingSAPU9GLVoucherLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(HeXingSAPU9GLVoucherLine container)
		    {
				if (container == null )
					throw new ArgumentNullException("container") ;
				ContainerEntity = container ;
				base.innerData = container.OldValues ;
				InitInnerData();
		    }
	




			#region member					
			
			/// <summary>
			///  OrginalData属性。只可读。
			/// ID (该属性不可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Key.ID
			/// </summary>
			/// <value></value>
			public  System.Int64 ID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("ID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建时间 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Sys.创建时间
			/// </summary>
			/// <value></value>
			public  System.DateTime CreatedOn
			{
				get
				{
					object obj = base.GetValue("CreatedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建人 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Sys.创建人
			/// </summary>
			/// <value></value>
			public  System.String CreatedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CreatedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改时间 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Sys.修改时间
			/// </summary>
			/// <value></value>
			public  System.DateTime ModifiedOn
			{
				get
				{
					object obj = base.GetValue("ModifiedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改人 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Sys.修改人
			/// </summary>
			/// <value></value>
			public  System.String ModifiedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ModifiedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 事务版本 (该属性可为空,但有默认值)
			/// SAP与U9凭证对接中间表行.Sys.事务版本
			/// </summary>
			/// <value></value>
			public  System.Int64 SysVersion
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// SAP与U9凭证对接中间表头 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.SAP与U9凭证对接中间表头
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead HeXingSAPU9GLVoucherHead
			{
				get
				{
					if (HeXingSAPU9GLVoucherHeadKey == null)
						return null ;
					UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead value =  (UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead)HeXingSAPU9GLVoucherHeadKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead.EntityKey m_HeXingSAPU9GLVoucherHeadKey ;
		/// <summary>
		/// EntityKey 属性
		/// SAP与U9凭证对接中间表头 的Key (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.SAP与U9凭证对接中间表头
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead.EntityKey HeXingSAPU9GLVoucherHeadKey
		{
			get 
			{
				object obj = base.GetValue("HeXingSAPU9GLVoucherHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_HeXingSAPU9GLVoucherHeadKey==null || m_HeXingSAPU9GLVoucherHeadKey.ID != key )
					m_HeXingSAPU9GLVoucherHeadKey = new UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead.EntityKey(key); 
				return m_HeXingSAPU9GLVoucherHeadKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 行号 (该属性可为空,但有默认值)
			/// SAP与U9凭证对接中间表行.Misc.行号
			/// </summary>
			/// <value></value>
			public  System.Int64 SerialNo
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SerialNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 科目编码 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.科目编码
			/// </summary>
			/// <value></value>
			public  System.String AccountCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("AccountCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 科目描述 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.科目描述
			/// </summary>
			/// <value></value>
			public  System.String AccountDescription
			{
				get
				{
					System.String value  = (System.String)base.GetValue("AccountDescription");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 摘要 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.摘要
			/// </summary>
			/// <value></value>
			public  System.String Abstracts
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Abstracts");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 借方金额（本币） (该属性可为空,但有默认值)
			/// SAP与U9凭证对接中间表行.Misc.借方金额（本币）
			/// </summary>
			/// <value></value>
			public  System.Decimal AccountedDr
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("AccountedDr");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 贷方金额（本币） (该属性可为空,但有默认值)
			/// SAP与U9凭证对接中间表行.Misc.贷方金额（本币）
			/// </summary>
			/// <value></value>
			public  System.Decimal AccountedCr
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("AccountedCr");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 借方金额（原币） (该属性可为空,但有默认值)
			/// SAP与U9凭证对接中间表行.Misc.借方金额（原币）
			/// </summary>
			/// <value></value>
			public  System.Decimal EnteredDr
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("EnteredDr");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 贷方金额（原币） (该属性可为空,但有默认值)
			/// SAP与U9凭证对接中间表行.Misc.贷方金额（原币）
			/// </summary>
			/// <value></value>
			public  System.Decimal EnteredCr
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("EnteredCr");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 现金流量项目编码 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.现金流量项目编码
			/// </summary>
			/// <value></value>
			public  System.String CashFlowCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CashFlowCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 现金流量项目描述 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.现金流量项目描述
			/// </summary>
			/// <value></value>
			public  System.String CashFlowDescription
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CashFlowDescription");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 费用类型编码 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.费用类型编码
			/// </summary>
			/// <value></value>
			public  System.String FeeTypeEnumCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("FeeTypeEnumCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 费用类型描述 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.费用类型描述
			/// </summary>
			/// <value></value>
			public  System.String FeeTypeEnumDescription
			{
				get
				{
					System.String value  = (System.String)base.GetValue("FeeTypeEnumDescription");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 开户行 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.开户行
			/// </summary>
			/// <value></value>
			public  System.String Banks
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Banks");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 银行账号 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.银行账号
			/// </summary>
			/// <value></value>
			public  System.String BankAccount
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BankAccount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户编码 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.客户编码
			/// </summary>
			/// <value></value>
			public  System.String CustomerCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustomerCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户名称 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.客户名称
			/// </summary>
			/// <value></value>
			public  System.String CustomerDescription
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustomerDescription");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 供应商编码 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.供应商编码
			/// </summary>
			/// <value></value>
			public  System.String SupplierCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SupplierCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 供应商名称 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.供应商名称
			/// </summary>
			/// <value></value>
			public  System.String SupplierDescription
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SupplierDescription");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 部门编码 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.部门编码
			/// </summary>
			/// <value></value>
			public  System.String DepartmentCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("DepartmentCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 部门名称 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.部门名称
			/// </summary>
			/// <value></value>
			public  System.String DepartmentName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("DepartmentName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 员工编码 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.员工编码
			/// </summary>
			/// <value></value>
			public  System.String EmployeeCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("EmployeeCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 员工名称 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.员工名称
			/// </summary>
			/// <value></value>
			public  System.String EmployeeName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("EmployeeName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 物料组编码 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.物料组编码
			/// </summary>
			/// <value></value>
			public  System.String MaterialGroupCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("MaterialGroupCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 物料组描述 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.物料组描述
			/// </summary>
			/// <value></value>
			public  System.String MaterialGroupDescription
			{
				get
				{
					System.String value  = (System.String)base.GetValue("MaterialGroupDescription");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 资产编号 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.资产编号
			/// </summary>
			/// <value></value>
			public  System.String AssetsCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("AssetsCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 资产描述 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.资产描述
			/// </summary>
			/// <value></value>
			public  System.String AssetsDescription
			{
				get
				{
					System.String value  = (System.String)base.GetValue("AssetsDescription");
					return value;
						}
			}
		



				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_DescFlexField ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实体扩展字段 (该属性可为空,且无默认值)
			/// SAP与U9凭证对接中间表行.Misc.实体扩展字段
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal DescFlexField
			{
				get
				{
					if (m_DescFlexField == null )
						m_DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal(this.ContainerEntity.OriginalData, "DescFlexField");
					return m_DescFlexField;
				}
			}
		



		

			#endregion

			#region List member						
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Key.ID
		/// </summary>
		/// <value></value>
	 
		public new System.Int64 ID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("ID");
				return value;
				}
				set
			{
				
								base.SetValue("ID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建时间 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Sys.创建时间
		/// </summary>
		/// <value></value>
			public  System.DateTime CreatedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("CreatedOn");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建人 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Sys.创建人
		/// </summary>
		/// <value></value>
			public  System.String CreatedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CreatedBy");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改时间 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Sys.修改时间
		/// </summary>
		/// <value></value>
			public  System.DateTime ModifiedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ModifiedOn");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改人 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Sys.修改人
		/// </summary>
		/// <value></value>
			public  System.String ModifiedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ModifiedBy");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 事务版本 (该属性可为空,但有默认值)
		/// SAP与U9凭证对接中间表行.Sys.事务版本
		/// </summary>
		/// <value></value>
			public  System.Int64 SysVersion
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
				return value;
				}
				set
			{
				
								base.SetValue("SysVersion", value);
						 
			}
		}
	



		
			/// <summary>
		/// SAP与U9凭证对接中间表头 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.SAP与U9凭证对接中间表头
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead HeXingSAPU9GLVoucherHead
		{
			get
			{
				object  obj = this.GetRelation("HeXingSAPU9GLVoucherHead");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead value  = (UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("HeXingSAPU9GLVoucherHead", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead.EntityKey m_HeXingSAPU9GLVoucherHeadKey ;
		/// <summary>
		/// SAP与U9凭证对接中间表头 的Key (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.SAP与U9凭证对接中间表头
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead.EntityKey HeXingSAPU9GLVoucherHeadKey
		{
			get 
			{
				object obj = base.GetValue("HeXingSAPU9GLVoucherHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_HeXingSAPU9GLVoucherHeadKey==null || m_HeXingSAPU9GLVoucherHeadKey.ID != key )
					m_HeXingSAPU9GLVoucherHeadKey = new UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead.EntityKey(key); 
				return m_HeXingSAPU9GLVoucherHeadKey ;
			}
			set
			{	
				if (HeXingSAPU9GLVoucherHeadKey==value)
					return ;
				this.SetRelation("HeXingSAPU9GLVoucherHead", null);
				m_HeXingSAPU9GLVoucherHeadKey = value ;
				if (value != null) 
				{
					base.SetValue("HeXingSAPU9GLVoucherHead",value.ID);
				}
				else
					base.SetValue("HeXingSAPU9GLVoucherHead",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// SAP与U9凭证对接中间表行.Misc.行号
		/// </summary>
		/// <value></value>
			public  System.Int64 SerialNo
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SerialNo");
				return value;
				}
				set
			{
				
								base.SetValue("SerialNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 科目编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.科目编码
		/// </summary>
		/// <value></value>
			public  System.String AccountCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("AccountCode");
				return value;
				}
				set
			{
				
								base.SetValue("AccountCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 科目描述 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.科目描述
		/// </summary>
		/// <value></value>
			public  System.String AccountDescription
		{
			get
			{
				System.String value  = (System.String)base.GetValue("AccountDescription");
				return value;
				}
				set
			{
				
								base.SetValue("AccountDescription", value);
						 
			}
		}
	



		
			/// <summary>
		/// 摘要 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.摘要
		/// </summary>
		/// <value></value>
			public  System.String Abstracts
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Abstracts");
				return value;
				}
				set
			{
				
								base.SetValue("Abstracts", value);
						 
			}
		}
	



		
			/// <summary>
		/// 借方金额（本币） (该属性可为空,但有默认值)
		/// SAP与U9凭证对接中间表行.Misc.借方金额（本币）
		/// </summary>
		/// <value></value>
			public  System.Decimal AccountedDr
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("AccountedDr");
				return value;
				}
				set
			{
				
								base.SetValue("AccountedDr", value);
						 
			}
		}
	



		
			/// <summary>
		/// 贷方金额（本币） (该属性可为空,但有默认值)
		/// SAP与U9凭证对接中间表行.Misc.贷方金额（本币）
		/// </summary>
		/// <value></value>
			public  System.Decimal AccountedCr
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("AccountedCr");
				return value;
				}
				set
			{
				
								base.SetValue("AccountedCr", value);
						 
			}
		}
	



		
			/// <summary>
		/// 借方金额（原币） (该属性可为空,但有默认值)
		/// SAP与U9凭证对接中间表行.Misc.借方金额（原币）
		/// </summary>
		/// <value></value>
			public  System.Decimal EnteredDr
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("EnteredDr");
				return value;
				}
				set
			{
				
								base.SetValue("EnteredDr", value);
						 
			}
		}
	



		
			/// <summary>
		/// 贷方金额（原币） (该属性可为空,但有默认值)
		/// SAP与U9凭证对接中间表行.Misc.贷方金额（原币）
		/// </summary>
		/// <value></value>
			public  System.Decimal EnteredCr
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("EnteredCr");
				return value;
				}
				set
			{
				
								base.SetValue("EnteredCr", value);
						 
			}
		}
	



		
			/// <summary>
		/// 现金流量项目编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.现金流量项目编码
		/// </summary>
		/// <value></value>
			public  System.String CashFlowCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CashFlowCode");
				return value;
				}
				set
			{
				
								base.SetValue("CashFlowCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 现金流量项目描述 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.现金流量项目描述
		/// </summary>
		/// <value></value>
			public  System.String CashFlowDescription
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CashFlowDescription");
				return value;
				}
				set
			{
				
								base.SetValue("CashFlowDescription", value);
						 
			}
		}
	



		
			/// <summary>
		/// 费用类型编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.费用类型编码
		/// </summary>
		/// <value></value>
			public  System.String FeeTypeEnumCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("FeeTypeEnumCode");
				return value;
				}
				set
			{
				
								base.SetValue("FeeTypeEnumCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 费用类型描述 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.费用类型描述
		/// </summary>
		/// <value></value>
			public  System.String FeeTypeEnumDescription
		{
			get
			{
				System.String value  = (System.String)base.GetValue("FeeTypeEnumDescription");
				return value;
				}
				set
			{
				
								base.SetValue("FeeTypeEnumDescription", value);
						 
			}
		}
	



		
			/// <summary>
		/// 开户行 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.开户行
		/// </summary>
		/// <value></value>
			public  System.String Banks
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Banks");
				return value;
				}
				set
			{
				
								base.SetValue("Banks", value);
						 
			}
		}
	



		
			/// <summary>
		/// 银行账号 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.银行账号
		/// </summary>
		/// <value></value>
			public  System.String BankAccount
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BankAccount");
				return value;
				}
				set
			{
				
								base.SetValue("BankAccount", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.客户编码
		/// </summary>
		/// <value></value>
			public  System.String CustomerCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustomerCode");
				return value;
				}
				set
			{
				
								base.SetValue("CustomerCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户名称 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.客户名称
		/// </summary>
		/// <value></value>
			public  System.String CustomerDescription
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustomerDescription");
				return value;
				}
				set
			{
				
								base.SetValue("CustomerDescription", value);
						 
			}
		}
	



		
			/// <summary>
		/// 供应商编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.供应商编码
		/// </summary>
		/// <value></value>
			public  System.String SupplierCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SupplierCode");
				return value;
				}
				set
			{
				
								base.SetValue("SupplierCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 供应商名称 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.供应商名称
		/// </summary>
		/// <value></value>
			public  System.String SupplierDescription
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SupplierDescription");
				return value;
				}
				set
			{
				
								base.SetValue("SupplierDescription", value);
						 
			}
		}
	



		
			/// <summary>
		/// 部门编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.部门编码
		/// </summary>
		/// <value></value>
			public  System.String DepartmentCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("DepartmentCode");
				return value;
				}
				set
			{
				
								base.SetValue("DepartmentCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 部门名称 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.部门名称
		/// </summary>
		/// <value></value>
			public  System.String DepartmentName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("DepartmentName");
				return value;
				}
				set
			{
				
								base.SetValue("DepartmentName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 员工编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.员工编码
		/// </summary>
		/// <value></value>
			public  System.String EmployeeCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("EmployeeCode");
				return value;
				}
				set
			{
				
								base.SetValue("EmployeeCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 员工名称 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.员工名称
		/// </summary>
		/// <value></value>
			public  System.String EmployeeName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("EmployeeName");
				return value;
				}
				set
			{
				
								base.SetValue("EmployeeName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 物料组编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.物料组编码
		/// </summary>
		/// <value></value>
			public  System.String MaterialGroupCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("MaterialGroupCode");
				return value;
				}
				set
			{
				
								base.SetValue("MaterialGroupCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 物料组描述 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.物料组描述
		/// </summary>
		/// <value></value>
			public  System.String MaterialGroupDescription
		{
			get
			{
				System.String value  = (System.String)base.GetValue("MaterialGroupDescription");
				return value;
				}
				set
			{
				
								base.SetValue("MaterialGroupDescription", value);
						 
			}
		}
	



		
			/// <summary>
		/// 资产编号 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.资产编号
		/// </summary>
		/// <value></value>
			public  System.String AssetsCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("AssetsCode");
				return value;
				}
				set
			{
				
								base.SetValue("AssetsCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 资产描述 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.资产描述
		/// </summary>
		/// <value></value>
			public  System.String AssetsDescription
		{
			get
			{
				System.String value  = (System.String)base.GetValue("AssetsDescription");
				return value;
				}
				set
			{
				
								base.SetValue("AssetsDescription", value);
						 
			}
		}
	



		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_DescFlexField ;
			/// <summary>
		/// 实体扩展字段 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行.Misc.实体扩展字段
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments DescFlexField
		{
			get
			{
				if (m_DescFlexField == null )
					m_DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this, "DescFlexField");
				return m_DescFlexField;
			}
				set
			{
				
				if (value == null)
					return ;
				if (this.m_DescFlexField == null)
					this.m_DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this,"DescFlexField");
								this.m_DescFlexField.PubDescSeg1 = value.PubDescSeg1 ;
												this.m_DescFlexField.PubDescSeg2 = value.PubDescSeg2 ;
												this.m_DescFlexField.PubDescSeg3 = value.PubDescSeg3 ;
												this.m_DescFlexField.PubDescSeg4 = value.PubDescSeg4 ;
												this.m_DescFlexField.PubDescSeg5 = value.PubDescSeg5 ;
												this.m_DescFlexField.PubDescSeg6 = value.PubDescSeg6 ;
												this.m_DescFlexField.PubDescSeg7 = value.PubDescSeg7 ;
												this.m_DescFlexField.PubDescSeg8 = value.PubDescSeg8 ;
												this.m_DescFlexField.PubDescSeg9 = value.PubDescSeg9 ;
												this.m_DescFlexField.PubDescSeg10 = value.PubDescSeg10 ;
												this.m_DescFlexField.PubDescSeg11 = value.PubDescSeg11 ;
												this.m_DescFlexField.PubDescSeg12 = value.PubDescSeg12 ;
												this.m_DescFlexField.PubDescSeg13 = value.PubDescSeg13 ;
												this.m_DescFlexField.PubDescSeg14 = value.PubDescSeg14 ;
												this.m_DescFlexField.PubDescSeg15 = value.PubDescSeg15 ;
												this.m_DescFlexField.PubDescSeg16 = value.PubDescSeg16 ;
												this.m_DescFlexField.PubDescSeg17 = value.PubDescSeg17 ;
												this.m_DescFlexField.PubDescSeg18 = value.PubDescSeg18 ;
												this.m_DescFlexField.PubDescSeg19 = value.PubDescSeg19 ;
												this.m_DescFlexField.PubDescSeg20 = value.PubDescSeg20 ;
												this.m_DescFlexField.PubDescSeg21 = value.PubDescSeg21 ;
												this.m_DescFlexField.PubDescSeg22 = value.PubDescSeg22 ;
												this.m_DescFlexField.PubDescSeg23 = value.PubDescSeg23 ;
												this.m_DescFlexField.PubDescSeg24 = value.PubDescSeg24 ;
												this.m_DescFlexField.PubDescSeg25 = value.PubDescSeg25 ;
												this.m_DescFlexField.PubDescSeg26 = value.PubDescSeg26 ;
												this.m_DescFlexField.PubDescSeg27 = value.PubDescSeg27 ;
												this.m_DescFlexField.PubDescSeg28 = value.PubDescSeg28 ;
												this.m_DescFlexField.PubDescSeg29 = value.PubDescSeg29 ;
												this.m_DescFlexField.PubDescSeg30 = value.PubDescSeg30 ;
												this.m_DescFlexField.PubDescSeg31 = value.PubDescSeg31 ;
												this.m_DescFlexField.PubDescSeg32 = value.PubDescSeg32 ;
												this.m_DescFlexField.PubDescSeg33 = value.PubDescSeg33 ;
												this.m_DescFlexField.PubDescSeg34 = value.PubDescSeg34 ;
												this.m_DescFlexField.PubDescSeg35 = value.PubDescSeg35 ;
												this.m_DescFlexField.PubDescSeg36 = value.PubDescSeg36 ;
												this.m_DescFlexField.PubDescSeg37 = value.PubDescSeg37 ;
												this.m_DescFlexField.PubDescSeg38 = value.PubDescSeg38 ;
												this.m_DescFlexField.PubDescSeg39 = value.PubDescSeg39 ;
												this.m_DescFlexField.PubDescSeg40 = value.PubDescSeg40 ;
												this.m_DescFlexField.PubDescSeg41 = value.PubDescSeg41 ;
												this.m_DescFlexField.PubDescSeg42 = value.PubDescSeg42 ;
												this.m_DescFlexField.PubDescSeg43 = value.PubDescSeg43 ;
												this.m_DescFlexField.PubDescSeg44 = value.PubDescSeg44 ;
												this.m_DescFlexField.PubDescSeg45 = value.PubDescSeg45 ;
												this.m_DescFlexField.PubDescSeg46 = value.PubDescSeg46 ;
												this.m_DescFlexField.PubDescSeg47 = value.PubDescSeg47 ;
												this.m_DescFlexField.PubDescSeg48 = value.PubDescSeg48 ;
												this.m_DescFlexField.PubDescSeg49 = value.PubDescSeg49 ;
												this.m_DescFlexField.PubDescSeg50 = value.PubDescSeg50 ;
												this.m_DescFlexField.ContextValue = value.ContextValue ;
												this.m_DescFlexField.PrivateDescSeg1 = value.PrivateDescSeg1 ;
												this.m_DescFlexField.PrivateDescSeg2 = value.PrivateDescSeg2 ;
												this.m_DescFlexField.PrivateDescSeg3 = value.PrivateDescSeg3 ;
												this.m_DescFlexField.PrivateDescSeg4 = value.PrivateDescSeg4 ;
												this.m_DescFlexField.PrivateDescSeg5 = value.PrivateDescSeg5 ;
												this.m_DescFlexField.PrivateDescSeg6 = value.PrivateDescSeg6 ;
												this.m_DescFlexField.PrivateDescSeg7 = value.PrivateDescSeg7 ;
												this.m_DescFlexField.PrivateDescSeg8 = value.PrivateDescSeg8 ;
												this.m_DescFlexField.PrivateDescSeg9 = value.PrivateDescSeg9 ;
												this.m_DescFlexField.PrivateDescSeg10 = value.PrivateDescSeg10 ;
												this.m_DescFlexField.PrivateDescSeg11 = value.PrivateDescSeg11 ;
												this.m_DescFlexField.PrivateDescSeg12 = value.PrivateDescSeg12 ;
												this.m_DescFlexField.PrivateDescSeg13 = value.PrivateDescSeg13 ;
												this.m_DescFlexField.PrivateDescSeg14 = value.PrivateDescSeg14 ;
												this.m_DescFlexField.PrivateDescSeg15 = value.PrivateDescSeg15 ;
												this.m_DescFlexField.PrivateDescSeg16 = value.PrivateDescSeg16 ;
												this.m_DescFlexField.PrivateDescSeg17 = value.PrivateDescSeg17 ;
												this.m_DescFlexField.PrivateDescSeg18 = value.PrivateDescSeg18 ;
												this.m_DescFlexField.PrivateDescSeg19 = value.PrivateDescSeg19 ;
												this.m_DescFlexField.PrivateDescSeg20 = value.PrivateDescSeg20 ;
												this.m_DescFlexField.PrivateDescSeg21 = value.PrivateDescSeg21 ;
												this.m_DescFlexField.PrivateDescSeg22 = value.PrivateDescSeg22 ;
												this.m_DescFlexField.PrivateDescSeg23 = value.PrivateDescSeg23 ;
												this.m_DescFlexField.PrivateDescSeg24 = value.PrivateDescSeg24 ;
												this.m_DescFlexField.PrivateDescSeg25 = value.PrivateDescSeg25 ;
												this.m_DescFlexField.PrivateDescSeg26 = value.PrivateDescSeg26 ;
												this.m_DescFlexField.PrivateDescSeg27 = value.PrivateDescSeg27 ;
												this.m_DescFlexField.PrivateDescSeg28 = value.PrivateDescSeg28 ;
												this.m_DescFlexField.PrivateDescSeg29 = value.PrivateDescSeg29 ;
												this.m_DescFlexField.PrivateDescSeg30 = value.PrivateDescSeg30 ;
												this.m_DescFlexField.CombineName = value.CombineName ;
				
					 
			}
		}
	



	

		#endregion

		#region List member						
		#endregion

		#region Be List member						
		#endregion
		
		#region ModelResource 其余去除，保留EntityName
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  string Res_EntityName {	get {return Res_EntityNameS ;}	}
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherLine")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ID　{ get { return EntityRes.GetResource("ID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedOn　{ get { return EntityRes.GetResource("CreatedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedBy　{ get { return EntityRes.GetResource("CreatedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedOn　{ get { return EntityRes.GetResource("ModifiedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedBy　{ get { return EntityRes.GetResource("ModifiedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SysVersion")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SysVersion　{ get { return EntityRes.GetResource("SysVersion");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("HeXingSAPU9GLVoucherHead")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_HeXingSAPU9GLVoucherHead　{ get { return EntityRes.GetResource("HeXingSAPU9GLVoucherHead");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SerialNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SerialNo　{ get { return EntityRes.GetResource("SerialNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AccountCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AccountCode　{ get { return EntityRes.GetResource("AccountCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AccountDescription")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AccountDescription　{ get { return EntityRes.GetResource("AccountDescription");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Abstracts")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Abstracts　{ get { return EntityRes.GetResource("Abstracts");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AccountedDr")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AccountedDr　{ get { return EntityRes.GetResource("AccountedDr");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AccountedCr")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AccountedCr　{ get { return EntityRes.GetResource("AccountedCr");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("EnteredDr")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_EnteredDr　{ get { return EntityRes.GetResource("EnteredDr");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("EnteredCr")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_EnteredCr　{ get { return EntityRes.GetResource("EnteredCr");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CashFlowCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CashFlowCode　{ get { return EntityRes.GetResource("CashFlowCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CashFlowDescription")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CashFlowDescription　{ get { return EntityRes.GetResource("CashFlowDescription");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("FeeTypeEnumCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_FeeTypeEnumCode　{ get { return EntityRes.GetResource("FeeTypeEnumCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("FeeTypeEnumDescription")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_FeeTypeEnumDescription　{ get { return EntityRes.GetResource("FeeTypeEnumDescription");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Banks")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Banks　{ get { return EntityRes.GetResource("Banks");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BankAccount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BankAccount　{ get { return EntityRes.GetResource("BankAccount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomerCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomerCode　{ get { return EntityRes.GetResource("CustomerCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomerDescription")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomerDescription　{ get { return EntityRes.GetResource("CustomerDescription");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SupplierCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SupplierCode　{ get { return EntityRes.GetResource("SupplierCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SupplierDescription")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SupplierDescription　{ get { return EntityRes.GetResource("SupplierDescription");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DepartmentCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DepartmentCode　{ get { return EntityRes.GetResource("DepartmentCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DepartmentName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DepartmentName　{ get { return EntityRes.GetResource("DepartmentName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("EmployeeCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_EmployeeCode　{ get { return EntityRes.GetResource("EmployeeCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("EmployeeName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_EmployeeName　{ get { return EntityRes.GetResource("EmployeeName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("MaterialGroupCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_MaterialGroupCode　{ get { return EntityRes.GetResource("MaterialGroupCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("MaterialGroupDescription")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_MaterialGroupDescription　{ get { return EntityRes.GetResource("MaterialGroupDescription");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AssetsCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AssetsCode　{ get { return EntityRes.GetResource("AssetsCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AssetsDescription")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AssetsDescription　{ get { return EntityRes.GetResource("AssetsDescription");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DescFlexField")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DescFlexField　{ get { return EntityRes.GetResource("DescFlexField");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "HeXingSAPU9GLVoucherLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherLine";　}　}
		
			/// <summary>
			/// 属性: ID 的名称
			/// </summary>
			public static string ID　{ get { return "ID";　}　}
				
			/// <summary>
			/// 属性: 创建时间 的名称
			/// </summary>
			public static string CreatedOn　{ get { return "CreatedOn";　}　}
				
			/// <summary>
			/// 属性: 创建人 的名称
			/// </summary>
			public static string CreatedBy　{ get { return "CreatedBy";　}　}
				
			/// <summary>
			/// 属性: 修改时间 的名称
			/// </summary>
			public static string ModifiedOn　{ get { return "ModifiedOn";　}　}
				
			/// <summary>
			/// 属性: 修改人 的名称
			/// </summary>
			public static string ModifiedBy　{ get { return "ModifiedBy";　}　}
				
			/// <summary>
			/// 属性: 事务版本 的名称
			/// </summary>
			public static string SysVersion　{ get { return "SysVersion";　}　}
				
			/// <summary>
			/// 属性: SAP与U9凭证对接中间表头 的名称
			/// </summary>
			public static string HeXingSAPU9GLVoucherHead　{ get { return "HeXingSAPU9GLVoucherHead";　}　}
				
			/// <summary>
			/// 属性: 行号 的名称
			/// </summary>
			public static string SerialNo　{ get { return "SerialNo";　}　}
				
			/// <summary>
			/// 属性: 科目编码 的名称
			/// </summary>
			public static string AccountCode　{ get { return "AccountCode";　}　}
				
			/// <summary>
			/// 属性: 科目描述 的名称
			/// </summary>
			public static string AccountDescription　{ get { return "AccountDescription";　}　}
				
			/// <summary>
			/// 属性: 摘要 的名称
			/// </summary>
			public static string Abstracts　{ get { return "Abstracts";　}　}
				
			/// <summary>
			/// 属性: 借方金额（本币） 的名称
			/// </summary>
			public static string AccountedDr　{ get { return "AccountedDr";　}　}
				
			/// <summary>
			/// 属性: 贷方金额（本币） 的名称
			/// </summary>
			public static string AccountedCr　{ get { return "AccountedCr";　}　}
				
			/// <summary>
			/// 属性: 借方金额（原币） 的名称
			/// </summary>
			public static string EnteredDr　{ get { return "EnteredDr";　}　}
				
			/// <summary>
			/// 属性: 贷方金额（原币） 的名称
			/// </summary>
			public static string EnteredCr　{ get { return "EnteredCr";　}　}
				
			/// <summary>
			/// 属性: 现金流量项目编码 的名称
			/// </summary>
			public static string CashFlowCode　{ get { return "CashFlowCode";　}　}
				
			/// <summary>
			/// 属性: 现金流量项目描述 的名称
			/// </summary>
			public static string CashFlowDescription　{ get { return "CashFlowDescription";　}　}
				
			/// <summary>
			/// 属性: 费用类型编码 的名称
			/// </summary>
			public static string FeeTypeEnumCode　{ get { return "FeeTypeEnumCode";　}　}
				
			/// <summary>
			/// 属性: 费用类型描述 的名称
			/// </summary>
			public static string FeeTypeEnumDescription　{ get { return "FeeTypeEnumDescription";　}　}
				
			/// <summary>
			/// 属性: 开户行 的名称
			/// </summary>
			public static string Banks　{ get { return "Banks";　}　}
				
			/// <summary>
			/// 属性: 银行账号 的名称
			/// </summary>
			public static string BankAccount　{ get { return "BankAccount";　}　}
				
			/// <summary>
			/// 属性: 客户编码 的名称
			/// </summary>
			public static string CustomerCode　{ get { return "CustomerCode";　}　}
				
			/// <summary>
			/// 属性: 客户名称 的名称
			/// </summary>
			public static string CustomerDescription　{ get { return "CustomerDescription";　}　}
				
			/// <summary>
			/// 属性: 供应商编码 的名称
			/// </summary>
			public static string SupplierCode　{ get { return "SupplierCode";　}　}
				
			/// <summary>
			/// 属性: 供应商名称 的名称
			/// </summary>
			public static string SupplierDescription　{ get { return "SupplierDescription";　}　}
				
			/// <summary>
			/// 属性: 部门编码 的名称
			/// </summary>
			public static string DepartmentCode　{ get { return "DepartmentCode";　}　}
				
			/// <summary>
			/// 属性: 部门名称 的名称
			/// </summary>
			public static string DepartmentName　{ get { return "DepartmentName";　}　}
				
			/// <summary>
			/// 属性: 员工编码 的名称
			/// </summary>
			public static string EmployeeCode　{ get { return "EmployeeCode";　}　}
				
			/// <summary>
			/// 属性: 员工名称 的名称
			/// </summary>
			public static string EmployeeName　{ get { return "EmployeeName";　}　}
				
			/// <summary>
			/// 属性: 物料组编码 的名称
			/// </summary>
			public static string MaterialGroupCode　{ get { return "MaterialGroupCode";　}　}
				
			/// <summary>
			/// 属性: 物料组描述 的名称
			/// </summary>
			public static string MaterialGroupDescription　{ get { return "MaterialGroupDescription";　}　}
				
			/// <summary>
			/// 属性: 资产编号 的名称
			/// </summary>
			public static string AssetsCode　{ get { return "AssetsCode";　}　}
				
			/// <summary>
			/// 属性: 资产描述 的名称
			/// </summary>
			public static string AssetsDescription　{ get { return "AssetsDescription";　}　}
				
			/// <summary>
			/// 属性类型属性: DescFlexField 的名称
			/// </summary>
			public static string DescFlexField { get { return "DescFlexField";　}　}
			/// <summary>
			/// 属性类型属性: DescFlexField 的类型全名
			/// </summary>
			public static string DescFlexField_TypeFullName { get { return "UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg1的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg1 { get { return "DescFlexField.PubDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg2的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg2 { get { return "DescFlexField.PubDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg3的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg3 { get { return "DescFlexField.PubDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg4的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg4 { get { return "DescFlexField.PubDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg5的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg5 { get { return "DescFlexField.PubDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg6的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg6 { get { return "DescFlexField.PubDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg7的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg7 { get { return "DescFlexField.PubDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg8的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg8 { get { return "DescFlexField.PubDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg9的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg9 { get { return "DescFlexField.PubDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg10的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg10 { get { return "DescFlexField.PubDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg11的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg11 { get { return "DescFlexField.PubDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg12的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg12 { get { return "DescFlexField.PubDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg13的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg13 { get { return "DescFlexField.PubDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg14的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg14 { get { return "DescFlexField.PubDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg15的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg15 { get { return "DescFlexField.PubDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg16的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg16 { get { return "DescFlexField.PubDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg17的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg17 { get { return "DescFlexField.PubDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg18的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg18 { get { return "DescFlexField.PubDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg19的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg19 { get { return "DescFlexField.PubDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg20的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg20 { get { return "DescFlexField.PubDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg21的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg21 { get { return "DescFlexField.PubDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg22的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg22 { get { return "DescFlexField.PubDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg23的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg23 { get { return "DescFlexField.PubDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg24的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg24 { get { return "DescFlexField.PubDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg25的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg25 { get { return "DescFlexField.PubDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg26的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg26 { get { return "DescFlexField.PubDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg27的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg27 { get { return "DescFlexField.PubDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg28的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg28 { get { return "DescFlexField.PubDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg29的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg29 { get { return "DescFlexField.PubDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg30的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg30 { get { return "DescFlexField.PubDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg31的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg31 { get { return "DescFlexField.PubDescSeg31";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg32的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg32 { get { return "DescFlexField.PubDescSeg32";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg33的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg33 { get { return "DescFlexField.PubDescSeg33";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg34的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg34 { get { return "DescFlexField.PubDescSeg34";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg35的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg35 { get { return "DescFlexField.PubDescSeg35";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg36的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg36 { get { return "DescFlexField.PubDescSeg36";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg37的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg37 { get { return "DescFlexField.PubDescSeg37";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg38的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg38 { get { return "DescFlexField.PubDescSeg38";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg39的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg39 { get { return "DescFlexField.PubDescSeg39";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg40的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg40 { get { return "DescFlexField.PubDescSeg40";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg41的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg41 { get { return "DescFlexField.PubDescSeg41";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg42的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg42 { get { return "DescFlexField.PubDescSeg42";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg43的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg43 { get { return "DescFlexField.PubDescSeg43";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg44的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg44 { get { return "DescFlexField.PubDescSeg44";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg45的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg45 { get { return "DescFlexField.PubDescSeg45";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg46的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg46 { get { return "DescFlexField.PubDescSeg46";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg47的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg47 { get { return "DescFlexField.PubDescSeg47";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg48的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg48 { get { return "DescFlexField.PubDescSeg48";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg49的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg49 { get { return "DescFlexField.PubDescSeg49";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg50的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg50 { get { return "DescFlexField.PubDescSeg50";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.ContextValue的名称
			/// </summary>
			public static string DescFlexField_ContextValue { get { return "DescFlexField.ContextValue";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg1的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg1 { get { return "DescFlexField.PrivateDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg2的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg2 { get { return "DescFlexField.PrivateDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg3的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg3 { get { return "DescFlexField.PrivateDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg4的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg4 { get { return "DescFlexField.PrivateDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg5的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg5 { get { return "DescFlexField.PrivateDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg6的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg6 { get { return "DescFlexField.PrivateDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg7的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg7 { get { return "DescFlexField.PrivateDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg8的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg8 { get { return "DescFlexField.PrivateDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg9的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg9 { get { return "DescFlexField.PrivateDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg10的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg10 { get { return "DescFlexField.PrivateDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg11的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg11 { get { return "DescFlexField.PrivateDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg12的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg12 { get { return "DescFlexField.PrivateDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg13的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg13 { get { return "DescFlexField.PrivateDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg14的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg14 { get { return "DescFlexField.PrivateDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg15的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg15 { get { return "DescFlexField.PrivateDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg16的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg16 { get { return "DescFlexField.PrivateDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg17的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg17 { get { return "DescFlexField.PrivateDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg18的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg18 { get { return "DescFlexField.PrivateDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg19的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg19 { get { return "DescFlexField.PrivateDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg20的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg20 { get { return "DescFlexField.PrivateDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg21的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg21 { get { return "DescFlexField.PrivateDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg22的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg22 { get { return "DescFlexField.PrivateDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg23的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg23 { get { return "DescFlexField.PrivateDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg24的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg24 { get { return "DescFlexField.PrivateDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg25的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg25 { get { return "DescFlexField.PrivateDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg26的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg26 { get { return "DescFlexField.PrivateDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg27的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg27 { get { return "DescFlexField.PrivateDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg28的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg28 { get { return "DescFlexField.PrivateDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg29的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg29 { get { return "DescFlexField.PrivateDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg30的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg30 { get { return "DescFlexField.PrivateDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.CombineName的名称
			/// </summary>
			public static string DescFlexField_CombineName { get { return "DescFlexField.CombineName";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																																																																				
				if (attrName.StartsWith("DescFlexField."))
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetPropertyResource(DescFlexField_TypeFullName, attrName);
		
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetAttrResource(BE_FullName, attrName);
			}

		}
		#endregion 


		#region EntityObjectBuilder 持久化性能优化
        private Dictionary<string, string> multiLangAttrs = null;
        private Dictionary<string, string> exdMultiLangAttrs = null;
        private string col_ID_Name = string.Empty;

        public override  Dictionary<string, string> MultiLangAttrs
        {
			get
			{
				return multiLangAttrs;
			}
        }
        public override  Dictionary<string, string> ExdMultiLangAttrs
        {
			get
			{
				return exdMultiLangAttrs;
			}
        }
        public override string Col_ID_Name
        {
			get
			{
				return col_ID_Name;
			}
        }  
        public override void IniData()
        {
			this.multiLangAttrs = new Dictionary<string, string>();
			this.exdMultiLangAttrs = new Dictionary<string, string>();
	
			this.col_ID_Name ="ID";
			this.exdMultiLangAttrs.Add("ID","ID");
			this.exdMultiLangAttrs.Add("CreatedOn","CreatedOn");
			this.exdMultiLangAttrs.Add("CreatedBy","CreatedBy");
			this.exdMultiLangAttrs.Add("ModifiedOn","ModifiedOn");
			this.exdMultiLangAttrs.Add("ModifiedBy","ModifiedBy");
			this.exdMultiLangAttrs.Add("SysVersion","SysVersion");
			this.exdMultiLangAttrs.Add("HeXingSAPU9GLVoucherHead","HeXingSAPU9GLVoucherHead");
			this.exdMultiLangAttrs.Add("SerialNo","SerialNo");
			this.exdMultiLangAttrs.Add("AccountCode","AccountCode");
			this.exdMultiLangAttrs.Add("AccountDescription","AccountDescription");
			this.exdMultiLangAttrs.Add("Abstracts","Abstracts");
			this.exdMultiLangAttrs.Add("AccountedDr","AccountedDr");
			this.exdMultiLangAttrs.Add("AccountedCr","AccountedCr");
			this.exdMultiLangAttrs.Add("EnteredDr","EnteredDr");
			this.exdMultiLangAttrs.Add("EnteredCr","EnteredCr");
			this.exdMultiLangAttrs.Add("CashFlowCode","CashFlowCode");
			this.exdMultiLangAttrs.Add("CashFlowDescription","CashFlowDescription");
			this.exdMultiLangAttrs.Add("FeeTypeEnumCode","FeeTypeEnumCode");
			this.exdMultiLangAttrs.Add("FeeTypeEnumDescription","FeeTypeEnumDescription");
			this.exdMultiLangAttrs.Add("Banks","Banks");
			this.exdMultiLangAttrs.Add("BankAccount","BankAccount");
			this.exdMultiLangAttrs.Add("CustomerCode","CustomerCode");
			this.exdMultiLangAttrs.Add("CustomerDescription","CustomerDescription");
			this.exdMultiLangAttrs.Add("SupplierCode","SupplierCode");
			this.exdMultiLangAttrs.Add("SupplierDescription","SupplierDescription");
			this.exdMultiLangAttrs.Add("DepartmentCode","DepartmentCode");
			this.exdMultiLangAttrs.Add("DepartmentName","DepartmentName");
			this.exdMultiLangAttrs.Add("EmployeeCode","EmployeeCode");
			this.exdMultiLangAttrs.Add("EmployeeName","EmployeeName");
			this.exdMultiLangAttrs.Add("MaterialGroupCode","MaterialGroupCode");
			this.exdMultiLangAttrs.Add("MaterialGroupDescription","MaterialGroupDescription");
			this.exdMultiLangAttrs.Add("AssetsCode","AssetsCode");
			this.exdMultiLangAttrs.Add("AssetsDescription","AssetsDescription");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg1","DescFlexField_PubDescSeg1");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg2","DescFlexField_PubDescSeg2");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg3","DescFlexField_PubDescSeg3");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg4","DescFlexField_PubDescSeg4");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg5","DescFlexField_PubDescSeg5");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg6","DescFlexField_PubDescSeg6");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg7","DescFlexField_PubDescSeg7");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg8","DescFlexField_PubDescSeg8");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg9","DescFlexField_PubDescSeg9");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg10","DescFlexField_PubDescSeg10");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg11","DescFlexField_PubDescSeg11");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg12","DescFlexField_PubDescSeg12");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg13","DescFlexField_PubDescSeg13");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg14","DescFlexField_PubDescSeg14");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg15","DescFlexField_PubDescSeg15");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg16","DescFlexField_PubDescSeg16");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg17","DescFlexField_PubDescSeg17");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg18","DescFlexField_PubDescSeg18");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg19","DescFlexField_PubDescSeg19");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg20","DescFlexField_PubDescSeg20");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg21","DescFlexField_PubDescSeg21");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg22","DescFlexField_PubDescSeg22");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg23","DescFlexField_PubDescSeg23");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg24","DescFlexField_PubDescSeg24");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg25","DescFlexField_PubDescSeg25");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg26","DescFlexField_PubDescSeg26");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg27","DescFlexField_PubDescSeg27");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg28","DescFlexField_PubDescSeg28");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg29","DescFlexField_PubDescSeg29");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg30","DescFlexField_PubDescSeg30");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg31","DescFlexField_PubDescSeg31");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg32","DescFlexField_PubDescSeg32");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg33","DescFlexField_PubDescSeg33");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg34","DescFlexField_PubDescSeg34");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg35","DescFlexField_PubDescSeg35");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg36","DescFlexField_PubDescSeg36");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg37","DescFlexField_PubDescSeg37");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg38","DescFlexField_PubDescSeg38");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg39","DescFlexField_PubDescSeg39");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg40","DescFlexField_PubDescSeg40");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg41","DescFlexField_PubDescSeg41");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg42","DescFlexField_PubDescSeg42");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg43","DescFlexField_PubDescSeg43");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg44","DescFlexField_PubDescSeg44");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg45","DescFlexField_PubDescSeg45");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg46","DescFlexField_PubDescSeg46");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg47","DescFlexField_PubDescSeg47");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg48","DescFlexField_PubDescSeg48");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg49","DescFlexField_PubDescSeg49");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg50","DescFlexField_PubDescSeg50");
			this.exdMultiLangAttrs.Add("DescFlexField.ContextValue","DescFlexField_ContextValue");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg1","DescFlexField_PrivateDescSeg1");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg2","DescFlexField_PrivateDescSeg2");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg3","DescFlexField_PrivateDescSeg3");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg4","DescFlexField_PrivateDescSeg4");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg5","DescFlexField_PrivateDescSeg5");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg6","DescFlexField_PrivateDescSeg6");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg7","DescFlexField_PrivateDescSeg7");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg8","DescFlexField_PrivateDescSeg8");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg9","DescFlexField_PrivateDescSeg9");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg10","DescFlexField_PrivateDescSeg10");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg11","DescFlexField_PrivateDescSeg11");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg12","DescFlexField_PrivateDescSeg12");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg13","DescFlexField_PrivateDescSeg13");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg14","DescFlexField_PrivateDescSeg14");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg15","DescFlexField_PrivateDescSeg15");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg16","DescFlexField_PrivateDescSeg16");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg17","DescFlexField_PrivateDescSeg17");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg18","DescFlexField_PrivateDescSeg18");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg19","DescFlexField_PrivateDescSeg19");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg20","DescFlexField_PrivateDescSeg20");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg21","DescFlexField_PrivateDescSeg21");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg22","DescFlexField_PrivateDescSeg22");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg23","DescFlexField_PrivateDescSeg23");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg24","DescFlexField_PrivateDescSeg24");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg25","DescFlexField_PrivateDescSeg25");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg26","DescFlexField_PrivateDescSeg26");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg27","DescFlexField_PrivateDescSeg27");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg28","DescFlexField_PrivateDescSeg28");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg29","DescFlexField_PrivateDescSeg29");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg30","DescFlexField_PrivateDescSeg30");
			this.multiLangAttrs.Add("DescFlexField.CombineName","DescFlexField_CombineName");
        }
	#endregion 




		
		
		#region override SetTypeValue method(Use By UICommonCRUD OR Weakly Type Operation)
		public override void SetTypeValue(object propName, object value)
		{
			
			string propstr = propName.ToString();
			switch(propstr)
			{
			
																																																																																																											
																																																																																																																																																																																																																																																						



				default:
					//调用基类的实现，最终Entity基类为SetValue()
					base.SetTypeValue(propName,value);
					return;
			}
		}
		#endregion


	


		#region EntityData exchange
		
		#region  DeSerializeKey -ForEntityPorpertyType
		//反序化Key到Data的ID中 --由FromEntityData自动调用一次。实际可以分离,由跨组织服务去调用.
		private void DeSerializeKey(HeXingSAPU9GLVoucherLineData data)
		{
		
			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			HeXingSAPU9GLVoucherLineData data = dto as HeXingSAPU9GLVoucherLineData ;
			if (data == null)
				return ;
            this.FromEntityData(data) ;
        }

        public override UFSoft.UBF.Business.DataTransObjectBase ToEntityDataBase()
        {
            return this.ToEntityData();
        }
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(HeXingSAPU9GLVoucherLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(HeXingSAPU9GLVoucherLineData data,IDictionary dict)
		{
			if (data == null)
				return;
			bool m_isNeedPersistable = this.NeedPersistable ;
			this.NeedPersistable = false ;
			
			//this.innerData.ChangeEventEnabled = false;
			//this.innerRelation.RelationEventEnabled = false;
				
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			this.SysState = data.SysState ;
			DeSerializeKey(data);
			#region 组件外属性
		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

								this.SetTypeValue("SysVersion",data.SysVersion);
		
								this.SetTypeValue("SerialNo",data.SerialNo);
		
								this.SetTypeValue("AccountCode",data.AccountCode);
		
								this.SetTypeValue("AccountDescription",data.AccountDescription);
		
								this.SetTypeValue("Abstracts",data.Abstracts);
		
								this.SetTypeValue("AccountedDr",data.AccountedDr);
		
								this.SetTypeValue("AccountedCr",data.AccountedCr);
		
								this.SetTypeValue("EnteredDr",data.EnteredDr);
		
								this.SetTypeValue("EnteredCr",data.EnteredCr);
		
								this.SetTypeValue("CashFlowCode",data.CashFlowCode);
		
								this.SetTypeValue("CashFlowDescription",data.CashFlowDescription);
		
								this.SetTypeValue("FeeTypeEnumCode",data.FeeTypeEnumCode);
		
								this.SetTypeValue("FeeTypeEnumDescription",data.FeeTypeEnumDescription);
		
								this.SetTypeValue("Banks",data.Banks);
		
								this.SetTypeValue("BankAccount",data.BankAccount);
		
								this.SetTypeValue("CustomerCode",data.CustomerCode);
		
								this.SetTypeValue("CustomerDescription",data.CustomerDescription);
		
								this.SetTypeValue("SupplierCode",data.SupplierCode);
		
								this.SetTypeValue("SupplierDescription",data.SupplierDescription);
		
								this.SetTypeValue("DepartmentCode",data.DepartmentCode);
		
								this.SetTypeValue("DepartmentName",data.DepartmentName);
		
								this.SetTypeValue("EmployeeCode",data.EmployeeCode);
		
								this.SetTypeValue("EmployeeName",data.EmployeeName);
		
								this.SetTypeValue("MaterialGroupCode",data.MaterialGroupCode);
		
								this.SetTypeValue("MaterialGroupDescription",data.MaterialGroupDescription);
		
								this.SetTypeValue("AssetsCode",data.AssetsCode);
		
								this.SetTypeValue("AssetsDescription",data.AssetsDescription);
		
								this.DescFlexField.FromEntityData(data.DescFlexField);
		
			#endregion 

			#region 组件内属性
	
					if (data.HeXingSAPU9GLVoucherHead!=null)
			{
				UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead child = dict[data.HeXingSAPU9GLVoucherHead] as UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead ;
				if (child == null)
				{
					if (data.HeXingSAPU9GLVoucherHead.ID>0)
					{
						if (data.HeXingSAPU9GLVoucherHead.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.HeXingSAPU9GLVoucherHead.ID,data.HeXingSAPU9GLVoucherHead.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.HeXingSAPU9GLVoucherHead.SysEntityType,null,data.HeXingSAPU9GLVoucherHead.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.HeXingSAPU9GLVoucherHead.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.HeXingSAPU9GLVoucherHead,dict);
				}
				this.HeXingSAPU9GLVoucherHead = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public HeXingSAPU9GLVoucherLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public HeXingSAPU9GLVoucherLineData ToEntityData(HeXingSAPU9GLVoucherLineData data, IDictionary dict){
			if (data == null)
				data = new HeXingSAPU9GLVoucherLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherLine"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("ID");
				if (obj != null)
					data.ID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedOn");
				if (obj != null)
					data.CreatedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedBy");
				if (obj != null)
					data.CreatedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedOn");
				if (obj != null)
					data.ModifiedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedBy");
				if (obj != null)
					data.ModifiedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SysVersion");
				if (obj != null)
					data.SysVersion=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SerialNo");
				if (obj != null)
					data.SerialNo=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AccountCode");
				if (obj != null)
					data.AccountCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AccountDescription");
				if (obj != null)
					data.AccountDescription=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Abstracts");
				if (obj != null)
					data.Abstracts=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AccountedDr");
				if (obj != null)
					data.AccountedDr=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AccountedCr");
				if (obj != null)
					data.AccountedCr=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("EnteredDr");
				if (obj != null)
					data.EnteredDr=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("EnteredCr");
				if (obj != null)
					data.EnteredCr=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CashFlowCode");
				if (obj != null)
					data.CashFlowCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CashFlowDescription");
				if (obj != null)
					data.CashFlowDescription=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("FeeTypeEnumCode");
				if (obj != null)
					data.FeeTypeEnumCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("FeeTypeEnumDescription");
				if (obj != null)
					data.FeeTypeEnumDescription=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Banks");
				if (obj != null)
					data.Banks=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BankAccount");
				if (obj != null)
					data.BankAccount=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomerCode");
				if (obj != null)
					data.CustomerCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomerDescription");
				if (obj != null)
					data.CustomerDescription=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SupplierCode");
				if (obj != null)
					data.SupplierCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SupplierDescription");
				if (obj != null)
					data.SupplierDescription=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DepartmentCode");
				if (obj != null)
					data.DepartmentCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DepartmentName");
				if (obj != null)
					data.DepartmentName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("EmployeeCode");
				if (obj != null)
					data.EmployeeCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("EmployeeName");
				if (obj != null)
					data.EmployeeName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("MaterialGroupCode");
				if (obj != null)
					data.MaterialGroupCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("MaterialGroupDescription");
				if (obj != null)
					data.MaterialGroupDescription=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AssetsCode");
				if (obj != null)
					data.AssetsCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AssetsDescription");
				if (obj != null)
					data.AssetsDescription=(System.String)obj;
			}
	     
	    
			if (this.DescFlexField != null)
			{
				data.DescFlexField=this.DescFlexField.ToEntityData();
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("HeXingSAPU9GLVoucherHead");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHeadData _HeXingSAPU9GLVoucherHead = dict["UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead"+oID.ToString()] as UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHeadData;			
					data.HeXingSAPU9GLVoucherHead = (_HeXingSAPU9GLVoucherHead != null) ? _HeXingSAPU9GLVoucherHead : (this.HeXingSAPU9GLVoucherHead==null?null:this.HeXingSAPU9GLVoucherHead.ToEntityData(null,dict));
				}
			}
	

			#endregion 
			return data ;
		}

		#endregion
	



	
        #region EntityValidator 
	//实体检验： 含自身检验器检验，内嵌属性类型的检验以及属性类型上的校验器的检验。
        private bool SelfEntityValidator()
        {
        

































			
			//调用UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments属性类型的内置校验方法.
			this.DescFlexField.OnValidate() ;
	
			//调用实体自身校验器代码.
            return true; 
        }
		//校验属性是否为空的检验。主要是关联对象的效验
		public override void SelfNullableVlidator()
		{
			base.SelfNullableVlidator();
		
			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}