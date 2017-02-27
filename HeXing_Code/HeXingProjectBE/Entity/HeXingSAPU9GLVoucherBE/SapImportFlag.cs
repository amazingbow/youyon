﻿using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE
{
    /// <summary>
    /// 可扩展枚举: SAP导入凭证标志 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class SapImportFlag
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.SapImportFlag");
        #region ctor & cctor 
        static SapImportFlag()
        {
            InitData();
        }
        private SapImportFlag(int eValue)
        {
            this.currentValue = eValue;
        }
        private SapImportFlag(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,SapImportFlag>();
            successful = new SapImportFlag(1,"Successful") ;
            innerEnums.Add(1,successful) ;
            failed = new SapImportFlag(2,"Failed") ;
            innerEnums.Add(2,failed) ;
            empty = new SapImportFlag(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static SapImportFlag empty;
        public static SapImportFlag Empty
        {
            get
            {
                return empty;
            }
        }
        #endregion 

        #region Intstance Propertites 
        private int currentValue;
        public System.Int32 Value
        {
            get
            {
				return currentValue ;         
            }
        }
        private string  name ;
        public string  Name 
        {
            get
            {
                return name;
            }
        }
        [System.Obsolete("已经废弃,请用EnumRes.GetResource(name)方式来获取显示名称. ")]
        public string Res_Name
        {
        	get 
        	{
        		switch ( this.Name )
        		{
        			case "Successful":
        				return this.Res_Successful; 
        			case "Failed":
        				return this.Res_Failed; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static SapImportFlag successful ;
        /// <summary>
        /// 枚举值: 成功  Value:1  
        /// SAP导入凭证标志.Misc.成功
        /// </summary>
        public static SapImportFlag Successful
        {
            get
            {
                return  successful ;
            }
        }
        private static SapImportFlag failed ;
        /// <summary>
        /// 枚举值: 失败  Value:2  
        /// SAP导入凭证标志.Misc.失败
        /// </summary>
        public static SapImportFlag Failed
        {
            get
            {
                return  failed ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, SapImportFlag> innerEnums;
        /// <summary>
        /// Get SapImportFlag's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<SapImportFlag> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get SapImportFlag By Value 
        /// </summary>
        public static SapImportFlag GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						SapImportFlag newValue = new SapImportFlag(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get SapImportFlag By Value 
        /// </summary>
        public static SapImportFlag GetFromValue(object value)
        {
			if (value == null)
				return SapImportFlag.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get SapImportFlag By Name 
        /// </summary>
        public static SapImportFlag GetFromName(string name)
        {
            foreach (SapImportFlag obj in innerEnums.Values)
            {
                if (obj.Name == name)
                    return obj;
            }
            //don't need modify to return a Default Value .
            return null;
        }
        #endregion 


		#region ModelResource
		/// <summary>
		/// SAP导入凭证标志的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// SAP导入凭证标志的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.SapImportFlag")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Successful　{ get {return EnumRes.GetResource("Successful");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Failed　{ get {return EnumRes.GetResource("Failed");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.SapImportFlag";　}　}

			/// <summary>
			///  获取资源接口,直接传了枚举对象.Name 就可.
			/// </summary>
			public static string GetResource(String attrName)
			{
				if (attrName== Enum_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEnumResource(Enum_FullName);
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEnumResource(Enum_FullName, attrName);
			}
			/// <summary>
			///  获取资源接口,直接传了枚举对象.Value 或Int32值 就可.
			/// </summary>
			public static string GetResourceByValue(Int32 value)
			{
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetNameForEnumValue(Enum_FullName, value);
			}
		}
		#endregion 
    }
}