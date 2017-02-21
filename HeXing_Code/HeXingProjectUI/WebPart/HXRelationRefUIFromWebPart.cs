﻿


using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.WebControls.InterActionComponenet;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Context;

//using MagicAjax.UI.Controls;
using UFSoft.UBF.Report.UI.ReportView.Web;
using UFSoft.UBF.UI.WebControlAdapter;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.Engine.Builder;
using UFSoft.UBF.UI.Engine.Authorization;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using System.Web.UI;
using UFSoft.UBF.UI.UIFormPersonalization;
using System.Collections.Specialized;


/***********************************************************************************************
 * Form ID:27891913-4675-447f-b75e-edb4ef82b85c 
 * Form Name:HXRelationRefUIFrom
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.HeXingProjectUI.HXRelationRefUIModel
{
	[FormRegister("UFIDA.U9.Cust.HeXingProjectUI","UFIDA.U9.Cust.HeXingProjectUI.HXRelationRefUIModel.HXRelationRefUIFromWebPart", "UFIDA.U9.Cust.HeXingProjectUI.WebPart", "27891913-4675-447f-b75e-edb4ef82b85c","WebPart", "False", 632, 376)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.HeXingProjectUI', 'UFIDA.U9.Cust.HeXingProjectUI.HXRelationRefUIModel.HXRelationRefUIFromWebPart', 'UFIDA.U9.Cust.HeXingProjectUI.WebPart', '27891913-4675-447f-b75e-edb4ef82b85c')
	///<siteMapNode url="~/erp/simple.aspx?lnk=27891913-4675-447f-b75e-edb4ef82b85c" title="HXRelationRefUIFrom"/>
    public partial class HXRelationRefUIFromWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(HXRelationRefUIFromWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new HXRelationRefUIModelAction Action
		{
			get { return (HXRelationRefUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		HXRelationRefUIModelModel _uimodel=null;
		public new HXRelationRefUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new HXRelationRefUIModelModel();
			     }
			     return _uimodel; 
			}
			set { _uimodel = value; }
		}
        protected override IUIModel UIModel{
            get{
                return this.Model;
            }
            set{
                this.Model = value as HXRelationRefUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFCard Card0;
        IUFLabel lblID62;
        IUFFldNumberControl ID62;
        IUFLabel lblSysVersion62;
        IUFFldNumberControl SysVersion62;
        IUFLabel lblOrg161;
        IUFFldReference Org161;
        IUFLabel lblRelType89;
        IUFFldDropDownList RelType89;
        IUFButton BtnFind;
        IUFDataGrid DataGrid0;
        IUFLabel lblRelColumn152;
        IUFFldDropDownList RelColumn152;
        IUFLabel lblRelText82;
        IUFFldTextBox RelText82;
        IUFCard Card1;
        IUFButton BtnClose;
        IUFButton BtnOk;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public HXRelationRefUIFromWebPart()
        {
            FormID = "27891913-4675-447f-b75e-edb4ef82b85c";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnFind.Click += new EventHandler(BtnFind_Click);		
						
				//Button控件事件
			this.BtnClose.Click += new EventHandler(BtnClose_Click);		
						
				//Button控件事件
			this.BtnOk.Click += new EventHandler(BtnOk_Click);		
						

		
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid0).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid0_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid0).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid0_GridCustomFilterHandler);

            AfterEventBind();
        }
        #endregion            
        
		#region override method
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad2(e);
		}
		protected override void OnLoadDataDo(EventArgs e)
		{
		    adjust.ProcessAdjustBeforeOnLoad(this);
			if (UIEngineHelper.IsDataBind(PageStatus, this))
			{
				if(this.Model==null){				        
					this.Model = new HXRelationRefUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (HXRelationRefUIModelModel)this.CurrentState[this.TaskId.ToString()];
			}
			adjust.ProcessAdjustAfterOnLoadData(this);
		            AfterOnLoad();
            
            adjust.ProcessAdjustAfterOnLoad(this);
		}
		protected override void OnPreRender(EventArgs e)
		{
			base.OnPreRender2(e);
		}
        protected override void OnPreRenderDo(EventArgs e)
        {
            adjust.ProcessAdjustBeforeOnPreRender(this);
			base.OnPreRender(e);
			this.CurrentState[this.TaskId.ToString()] = this.Model;
			RegisterClearWebPartPadding();
            UFIDA.U9.UI.PDHelper.FormAuthorityHelper.SetWebPartAuthorization(this);
            
			if (IsDataBinding) //2006-9-7 可由开发人员控制
			{
				BeforeUIModelBinding();
				//BtnFind对应隐藏域的数据传递。:True
				UFIDA.U9.UI.PDHelper.CommonReferenceHelper.BindingBtnFindParam(this);
								if(!Page.IsPostBack)
				{
					EnumTypeBinding.BindEnumControls(this);
				}
				UFIDA.U9.UI.Commands.CommandHelper.BindFlexData(this);
				adjust.ProcessAdjustBeforeDataBinding(this);
				if (this.IsOnlyDataBinding)
				{
					this.DataBinding();
				}
				adjust.ProcessAdjustAfterDataBinding(this);

				AfterUIModelBinding();
			}
			adjust.ProcessAdjustAfterOnPreRender(this);
        }
		protected override void OnInit(EventArgs e)
		{
			base.OnInit2(e);
		}
		protected override void OnInitDo(EventArgs e)
		{			 
			this.Page.InitComplete += new EventHandler(Page_InitComplete);
			WebPartBuilder.InitWebPart(this);
            this.Action = new HXRelationRefUIModelAction(this);
            adjust = new FormAdjust();
		    CreateFormChildControls();
		}
        void Page_InitComplete(object sender, EventArgs e)
        {

            adjust.ProcessInit(this);
        }
        #endregion

      
        
        #endregion

	
		/// <summary>
        /// WebPart View
        /// </summary>
        #region view Create Contorls
        private void CreateFormChildControls()
        {
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"HXRelationRefUIFrom",true,632,376);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 2, 0, 10, 10, 10, 10, 10);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(610,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(320,bool.Parse("True")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "1");		


	
			_BuilderControl_Card1(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card1, "2");		



		
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"none", true, true, "1","5ae7bb4e-b5d4-41f7-a19b-0f1f9b277ee6","6fe242e9-fea8-48fa-a7d1-e7e234d0a856");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 610, 320, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 11, 13, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.HXRelationRefFindView, "HXRelationRefFindView", "", null, 1, "HXRelationRefFindView");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(90,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(90,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(90,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(90,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(90,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(89,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID62 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID62", "", "False", "True", "Right", 90, 20, 0, 0, 1, 1, "100","5ae7bb4e-b5d4-41f7-a19b-0f1f9b277ee6","2c4b3197-93cd-4074-b0c9-6f647487342f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID62, "0");		


				this.ID62 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID62", "False", "False", "True", "Left", 7, 60, 0, 90, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID62","","5ae7bb4e-b5d4-41f7-a19b-0f1f9b277ee6","75026691-9e4e-46fe-9062-60c70bb3b408",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID62, "False", "ID", this.Model.HXRelationRefFindView, this.Model.HXRelationRefFindView.FieldID, "HXRelationRefFindView");
	
		
			UIControlBuilder.BuilderUFControl(this.ID62, "1");		
		 

				this.lblSysVersion62 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion62", "", "False", "True", "Right", 90, 20, 0, 0, 1, 1, "100","472df927-6c01-4b2f-bf73-b367bb6d8b1a","fb9a01b6-0710-481a-9607-67fc2646e635");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion62, "2");		


				this.SysVersion62 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion62", "False", "False", "True", "Left", 7, 60, 0, 90, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion62","","472df927-6c01-4b2f-bf73-b367bb6d8b1a","84f5b261-fada-436f-b719-45feaf1fba76",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion62, "False", "SysVersion", this.Model.HXRelationRefFindView, this.Model.HXRelationRefFindView.FieldSysVersion, "HXRelationRefFindView");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion62, "3");		
		 

				this.lblOrg161 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblOrg161", "", "True", "True", "Right", 90, 20, 0, 0, 1, 1, "100","9e3add61-7c7f-430a-9345-cb03b1c8a99d","e7fcf702-af8b-4e7e-bbf5-fdb1c0a3098c");


								

		
			UIControlBuilder.BuilderUFControl(this.lblOrg161, "4");		


				this.Org161 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Org161",true,true, true,90, 20, 2, 0, 1, 1, "100","5",false,false,true,"lblOrg161","9e3add61-7c7f-430a-9345-cb03b1c8a99d","7228e39e-9e79-4d44-90e5-048433afa67c");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Org161, "False", "Org", this.Model.HXRelationRefFindView, this.Model.HXRelationRefFindView.FieldOrg, "HXRelationRefFindView");
			UIControlBuilder.SetReferenceControlRefInfo(this.Org161,"19b6ef3c-a0a9-4851-9566-a16e9a5578a7", 580,408, "Name","Code","ID", this.Model.HXRelationRefFindView.FieldOrg_Code,this.Model.HXRelationRefFindView.FieldOrg_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Org161,"Org161",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Org161, "5");		
		 

				this.lblRelType89 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblRelType89", "", "True", "True", "Right", 90, 20, 0, 1, 1, 1, "100","77608aa2-3049-46f8-8b44-c923c66aee6d","5e326dcf-6092-4b55-9bdd-2d4cb8672899");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRelType89, "6");		


		        this.RelType89 = UIControlBuilder.BuilderDropDownList(_UFCard, "RelType89", "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum", true,  true, true, "Left", 2, 60, 0, 90, 20, 2, 1, 1, 1, "100",true,false,"lblRelType89","77608aa2-3049-46f8-8b44-c923c66aee6d","c20ac936-0309-4074-a3de-c9e40ac348c3");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.RelType89, "False", "RelType", this.Model.HXRelationRefFindView, this.Model.HXRelationRefFindView.FieldRelType, "HXRelationRefFindView");
			EnumTypeList.Add("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum");
			EnumControlsMap.Add(this.RelType89, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.RelType89, "7");		
		 

				this.BtnFind = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnFind", true, true, 90, 20, 8, 2, 1, 1, "100","", this.Model.ElementID,"",false,"fa9a892b-cefe-4846-893c-11caee88d965","","fa9a892b-cefe-4846-893c-11caee88d965");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnFind, "15");		


	
			_BuilderControl_DataGrid0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid0, "16");		


				this.lblRelColumn152 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblRelColumn152", "", "True", "True", "Right", 90, 20, 0, 2, 1, 1, "100","3ed12cd2-090a-4caa-b5e1-fb0e72cd695d","fcd37657-876a-4f58-9f27-a7ff436d9bb0");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRelColumn152, "17");		


		        this.RelColumn152 = UIControlBuilder.BuilderDropDownList(_UFCard, "RelColumn152", "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.ColumnEmun", true,  true, true, "Left", 2, 60, 0, 90, 20, 2, 2, 1, 1, "100",true,false,"lblRelColumn152","3ed12cd2-090a-4caa-b5e1-fb0e72cd695d","27572714-7e6e-4db5-896a-bd2de73fc0c1");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.RelColumn152, "False", "RelColumn", this.Model.HXRelationRefFindView, this.Model.HXRelationRefFindView.FieldRelColumn, "HXRelationRefFindView");
			EnumTypeList.Add("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.ColumnEmun");
			EnumControlsMap.Add(this.RelColumn152, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.RelColumn152, "18");		
		 

				this.lblRelText82 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblRelText82", "", "False", "True", "Right", 90, 20, 0, 0, 1, 1, "100","1bd6c4f9-a315-4fc3-90b7-c65d581f8718","2d74b996-47d9-4db0-938a-c7475e033771");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRelText82, "19");		


				this.RelText82 = UIControlBuilder.BuilderTextBox(_UFCard, "RelText82", "True", "True", "True", "False", "Left", 0, 60, 0, 90, 20, 4, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblRelText82","","50","1bd6c4f9-a315-4fc3-90b7-c65d581f8718","aba92063-6490-4f18-8b7b-d3bd13ea2bf4");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.RelText82, "False", "RelText", this.Model.HXRelationRefFindView, this.Model.HXRelationRefFindView.FieldRelText, "HXRelationRefFindView");


		
			UIControlBuilder.BuilderUFControl(this.RelText82, "20");		
		 


						
			this.Org161.IsMultiOrg  = true ;
			this.lblOrg161.SetMultiOrgInfo(this.Org161,true);
			
								

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				





       
        private void _BuilderControl_DataGrid0(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid0", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,true,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "16");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 594, 245, 0, 3, 11, 10, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.HXRelationRefShowView, "HXRelationRefShowView", "", null, 20, "HXRelationRefShowView");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid0 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID63","NumberColumnModel", "", 0,this.Model.HXRelationRefShowView.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","951078fe-480a-4533-ab30-92f3901e42a0","951078fe-480a-4533-ab30-92f3901e42a0","5deab13b-81e0-48e4-a840-2bca96510a15");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion63","NumberColumnModel", "", 0,this.Model.HXRelationRefShowView.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, false, 7, 100, "",true, false,"","1378b0b0-1fc8-45be-a3ce-fd250b148b80","1378b0b0-1fc8-45be-a3ce-fd250b148b80","06c55086-3d3f-4fb5-9aa2-a51d2037fb06");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RefCode0","TextBoxColumnModel", "", 0,this.Model.HXRelationRefShowView.Fields["RefCode"]/*RefCode*/,"RefCode", false, true, true, false, false, true, 0, 100, "50",true, false,"","672ec275-b9dd-495e-a5a7-57c258977cbf","672ec275-b9dd-495e-a5a7-57c258977cbf","b6724882-4166-4f6b-839f-5158035b91d4");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RefName0","TextBoxColumnModel", "", 0,this.Model.HXRelationRefShowView.Fields["RefName"]/*RefName*/,"RefName", false, true, true, false, false, true, 0, 100, "50",true, false,"","35332702-30aa-4a7c-9f06-c2c5afd06282","35332702-30aa-4a7c-9f06-c2c5afd06282","a853515c-1c51-4f24-bb3d-f85129b59bcc");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 
        }

	                   
        private IUFCard _BuilderControl_Card1(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card1",false,"FunctionBar", true, true, "2","","afb42c4f-3b16-47b7-9739-7e960096cf7b");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 610, 25, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 11, 1, 0, 0, 0, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(30,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card1 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, true, 80, 20, 10, 0, 1, 1, "100","", this.Model.ElementID,"",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","aa0025d8-5391-4a5e-b84f-12b3e4913896");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClose, "6");		


				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnOk", true, true, 80, 20, 8, 0, 1, 1, "100","", this.Model.ElementID,"",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","9161aca8-af21-4cbf-83a5-9073366787b3");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "5");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}