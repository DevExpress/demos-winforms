using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.DevAV.ViewModels;
using DevExpress.XtraBars.Docking2010;
using DevExpress.Utils.MVVM.UI;

namespace DevExpress.DevAV.Views {
    [ViewType(DevAVDbViewModel.OrderViewDocumentType)]
    public partial class OrderView : BaseViewWithWinUIButtons {
        public OrderView() {
            InitializeComponent();
            dataLayoutControl.SetupLayoutControl();
            viewItems.SetupCollectionGrid();
            if (!mvvmContext.IsDesignMode) {
                
                InitBindings();
            }
        }
        void InitBindings() {
            var fluentAPI = mvvmContext.OfType<OrderViewModel>();
            fluentAPI.SetObjectDataSourceBinding(orderBindingSource, x => x.Entity, x => x.Update());
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[0], x => x.Close(), "Cancel");
            fluentAPI.BindCommand(backWindowsUIButtonPanel.Buttons[0] as WindowsUIButton, x => x.Close());
            
            fluentAPI.SetBinding(invoiceNumberSimpleLabelItem, l => l.Text, x => x.Entity.InvoiceNumber, v => string.Format("#{0}", v));
            
            
            
            
            
            
            
            
            
            
            
        }
        
            
        
    }
}
