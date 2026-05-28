using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DevExpress.MVVM.Demos.ViewModels {
    public partial class ExpensesDbContextViewModel {
        public override void OnLoaded(ExpensesDbContextModuleDescription module) {
            Messenger.Default.Register<AmountMessage>(this, OnAmountMessage);
            base.OnLoaded(module);
        }
        void OnAmountMessage(AmountMessage message) {
            var uow = CreateUnitOfWork();
            var account = uow.Accounts.Find(message.ID);
            if(account != null)
                account.Amount += message.Change;
            uow.SaveChanges();
        }
        public bool AllowDefaultModule = true;
        public override ExpensesDbContextModuleDescription DefaultModule {
            get { return AllowDefaultModule ? base.DefaultModule : null; }
        }
        protected override void OnActiveModuleChanged(ExpensesDbContextModuleDescription oldModule) {
            base.OnActiveModuleChanged(oldModule);
            this.RaiseCanExecuteChanged(x => x.AddNew());
        }
        public void AddNew() {
            var document = DocumentManagerService.FindDocumentById(ActiveModule.DocumentType);
            if(document != null && document.Content != null)
                Messenger.Default.Send(AddNewMessage.Instance, document.Content);
        }
        public bool CanAddNew() {
            return (DocumentManagerService != null) && (ActiveModule != null) &&
                DocumentManagerService.FindDocumentById(ActiveModule.DocumentType) != null;
        }
    }
}
