using System;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Utils.MVVM.Services;

namespace DevExpress.DevAV.ViewModels {
    public class PrintableControlPreviewViewModel : IDocumentContent, ISupportParameter {
        public virtual IPreviewModelWrapper<IPrintingSystem> PrintModel { get; protected set; }
        public void Close() {
            if(DocumentOwner != null) {
                DocumentOwner.Close(this);
            }
        }

        protected IDocumentOwner DocumentOwner { get; private set; }

        #region IDocumentContent

        void IDocumentContent.OnClose(CancelEventArgs e) {
        }

        void IDocumentContent.OnDestroy() {
        }

        IDocumentOwner IDocumentContent.DocumentOwner {
            get { return DocumentOwner; }
            set { DocumentOwner = value; }
        }

        object IDocumentContent.Title {
            get { return null; }
        }

        #endregion

        public object Parameter {
            get { throw new NotImplementedException(); }
            set { PrintModel = (IPreviewModelWrapper<IPrintingSystem>)value; }
        }
    }
}
