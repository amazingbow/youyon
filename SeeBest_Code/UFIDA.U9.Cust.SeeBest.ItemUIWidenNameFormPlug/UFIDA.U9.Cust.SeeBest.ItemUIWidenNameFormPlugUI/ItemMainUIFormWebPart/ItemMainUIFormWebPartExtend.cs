

namespace UFIDA.U9.Cust.SeeBest.ItemUIWidenNameFormPlugUI
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
    using UFSoft.UBF.UI.Engine.Builder;
    
    
    public partial class ItemMainUIFormWebPart
    {
        
            #region 字段与属性                                       
                                                                     
            private ItemUIModel.ItemMainUIFormWebPart _strongPart;                           
                                                                     
            #endregion                                               

        
        private void Do_AfterInit(UFSoft.UBF.UI.IView.IPart part, EventArgs args)
        {
            #region 获取相关强类型数据                               
                                                                     
            _strongPart = part as ItemUIModel.ItemMainUIFormWebPart;                         
            if (_strongPart == null)                                  
                return;

            IUFLabel labelSPECS = (IUFLabel)_strongPart.GetUFControlByName(_strongPart.TopLevelContainer, "Label51000");
            if (labelSPECS != null)
            {
                labelSPECS.Visible = false;
            }
            IUFFldTextBox txtSPECS = (IUFFldTextBox)_strongPart.GetUFControlByName(_strongPart.TopLevelContainer, "CombineName71");
            if (txtSPECS != null)
            {
                txtSPECS.Visible = false;
            }
            //IUFFldFlexFieldPicker txtName = (IUFFldFlexFieldPicker)_strongPart.GetUFControlByName(_strongPart.TopLevelContainer, "FlexFieldPicker1");
            //if (txtName != null)
            //{
            //    txtName.Width = new Unit(380.0);
            //}
            IUFCard card = (IUFCard)_strongPart.GetUFControlByName(_strongPart.TopLevelContainer, "Card23");
            if (card != null)
            {
                UIControlBuilder.BuildContainerGridLayout(card, 5, new GridColumnDef[] { new GridColumnDef(0x41, bool.Parse("True")), new GridColumnDef(5, bool.Parse("True")), new GridColumnDef(100, bool.Parse("True")), new GridColumnDef(10, bool.Parse("True")), new GridColumnDef(60, bool.Parse("True")), new GridColumnDef(5, bool.Parse("True")), new GridColumnDef(190, bool.Parse("True")), new GridColumnDef(10, bool.Parse("True")), new GridColumnDef(60, bool.Parse("True")), new GridColumnDef(5, bool.Parse("True")), new GridColumnDef(410, bool.Parse("True")), new GridColumnDef(10, bool.Parse("True")), new GridColumnDef(30, bool.Parse("True")), new GridColumnDef(5, bool.Parse("True")), new GridColumnDef(10, bool.Parse("False")) }, new GridRowDef[] { new GridRowDef(20, bool.Parse("True")) });
            }
                                                                     
            #endregion                                               

        }
    }
}
