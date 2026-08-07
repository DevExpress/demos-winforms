using DevExpress.DevAV.Common.ViewModel;
using DevExpress.Mvvm;

namespace DevExpress.DevAV.Views {
    public partial class FilterCollectionViewBase : BaseViewWithWinUIButtons {
        public FilterCollectionViewBase() {
            InitializeComponent();
            Messenger.Default.Register<DocumentShownMessage>(this, DocumentShownMessageReceived);
            ApplyPadding();
        }

        void ApplyPadding() {
            labelControl.Padding = new System.Windows.Forms.Padding(41, 8, 13, 8);
            splitContainerControl.Panel1.Padding = new System.Windows.Forms.Padding(40, 2, 0, 2);
        }

        protected virtual void DocumentShownMessageReceived(DocumentShownMessage msg) {
        }
    }
}
