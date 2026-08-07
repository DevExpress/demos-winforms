using System;
using DevExpress.DevAV.ViewModels;
using DevExpress.Utils.MVVM.UI;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.DevAV.Views {
    [ViewType(DevAVDbViewModel.EmployeeMailMergeViewDocumentType)]
    public partial class EmployeeMailMergeView : BaseViewWithWinUIButtons {
        public EmployeeMailMergeView() {
            InitializeComponent();
            
            
        }

        private void InitBinding() {
            var fluentAPI = mvvmContext.OfType<EmployeeMailMergeViewModel>();
            fluentAPI.SetObjectDataSourceBinding(employeeBindingSource, x => x.Entities);
            fluentAPI.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(advBandedGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity, args => args.Row as Employee,
                (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            
            fluentAPI.SetTrigger(x => x.SelectedTemplate, template => { UpdateTemplate(template); });
            fluentAPI.SetItemsSourceBinding(cbMailTemplate.Properties,
                prop => prop.Items, x => x.Templates,
                (item, template) => object.Equals(item.Value, template),
                template => new ImageComboBoxItem(template.Name, template));
            fluentAPI.SetBinding(cbMailTemplate, cb => cb.EditValue, x => x.SelectedTemplate);
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[0]).ImageUri = ToolbarExtension.GetImageUri("ZoomIn");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[0]).Click += (s, e) => Zoom(true);
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[1]).ImageUri = ToolbarExtension.GetImageUri("ZoomOut");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[1]).Click += (s, e) => Zoom(false);
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[3]).ImageUri = ToolbarExtension.GetImageUri("Print");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[3]).Click += (s, e) => Print();
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[5], x => x.Close(), "Cancel");
            UpdateTemplate(fluentAPI.ViewModel.SelectedTemplate);
        }

        
        
        
        private void Zoom(bool zoomIn) {
            
            
        }

        private void Print() {
            
        }

        private void UpdateTemplate(TemplateViewModel template) {
            
            
            
        }

        private void EmployeeMailMergeView_Load(object sender, EventArgs e) {
            if(!mvvmContext.IsDesignMode) {
                InitBinding();
            }
        }

        private void snapControl_ZoomChanged(object sender, EventArgs e) {
            
            
        }
    }
}
