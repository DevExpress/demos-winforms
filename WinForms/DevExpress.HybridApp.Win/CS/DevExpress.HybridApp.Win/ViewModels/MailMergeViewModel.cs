using DevExpress.DevAV.Common.DataModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DevExpress.DevAV.ViewModels {
    public class MailMergeViewModel<TEntity, TLinks> : IDocumentContent
        where TEntity: class
        where TLinks: class {
        protected MailMergeViewModel(IEnumerable<TEntity> entities, TEntity selectedEntity, string selectedTemplateName, TLinks linksViewModel) {
            Templates = MailMergeTemplatesHelper.GetAllTemplates();
            SelectedTemplate = Templates.FirstOrDefault(t => t.Name == selectedTemplateName);
            IsAdditionParametersVisible = SelectedTemplate == null;
            SelectedTemplate = SelectedTemplate ?? Templates.FirstOrDefault();
            LinksViewModel = linksViewModel;
            Entities = entities;
            SelectedEntity = selectedEntity;
        }

        public virtual TEntity SelectedEntity { get; set; }
        protected void OnSelectedEntityChanged() {
            SelectedEntityIndex = Entities.Select((x, i) => new { item = x, index = i
            }).FirstOrDefault(x => x.item == SelectedEntity).index;
        }

        public virtual int SelectedEntityIndex { get; protected set; }
        public virtual IEnumerable<TEntity> Entities { get; set; }
        public virtual List<TemplateViewModel> Templates { get; set; }
        public virtual TemplateViewModel SelectedTemplate { get; set; }
        public virtual bool IsAdditionParametersVisible { get; set; }
        public virtual TLinks LinksViewModel { get; protected set; }
        public void Close() {
            if (DocumentOwner != null) {
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
            get { return "DevAV - Mail Merge"; }
        }

        #endregion

    }
}
