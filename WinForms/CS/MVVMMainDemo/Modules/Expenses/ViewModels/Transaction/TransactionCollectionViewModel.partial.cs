namespace DevExpress.MVVM.Demos.ViewModels {
    using System;
    using DevExpress.Mvvm;
    using DevExpress.MVVM.Demos.Model;

    partial class TransactionCollectionViewModel {
        static void NewEntityInitializer(Transaction t) {
            t.CategoryID = 1;
            t.AccountID = 1;
            t.Date = DateTime.Now;
        }
        protected override void OnEntityDeleted(long primaryKey, Transaction entity) {
            base.OnEntityDeleted(primaryKey, entity);
            var category = CreateUnitOfWork().Categories.Find(entity.CategoryID);
            Messenger.Default.Send<AmountMessage>(new AmountDecreasedMessage(entity, category));
        }
        protected override void OnInitializeInRuntime() {
            base.OnInitializeInRuntime();
            DevExpress.Mvvm.Messenger.Default.Register<AddNewMessage>(this, this, false, m => New());
        }
    }
}
