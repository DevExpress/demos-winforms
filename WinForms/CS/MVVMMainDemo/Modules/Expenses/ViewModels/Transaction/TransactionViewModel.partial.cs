namespace DevExpress.MVVM.Demos.ViewModels {
    using System.Linq;
    using DevExpress.Mvvm;
    using DevExpress.MVVM.Demos.Model;

    public partial class TransactionViewModel {
        decimal prevAmount;
        long prevAccount, prevCategory;
        protected override void OnBeforeEntitySaved(long key, Transaction entity, bool isNewEntity) {
            base.OnBeforeEntitySaved(key, entity, isNewEntity);
            if(!isNewEntity) {
                var t = UnitOfWorkFactory.CreateUnitOfWork().Transactions.Find(PrimaryKey);
                prevAmount = t.Amount;
                prevAccount = t.AccountID;
                prevCategory = t.CategoryID;
            }
        }
        protected override void OnEntitySaved(long key, Transaction entity, bool isNewEntity) {
            base.OnEntitySaved(key, entity, isNewEntity);
            var category = entity.Category ?? LookUpCategories.Entities.FirstOrDefault(c => c.ID == entity.CategoryID);
            if(isNewEntity)
                Messenger.Default.Send<AmountMessage>(new AmountIncreasedMessage(entity, category));
            else {
                if(prevAccount == entity.AccountID && prevCategory == entity.CategoryID)
                    Messenger.Default.Send<AmountMessage>(new AmountChangedMessage(entity, category, prevAmount));
                else {
                    var uow = UnitOfWorkFactory.CreateUnitOfWork();
                    var oldCategory = uow.Categories.Find(prevCategory);
                    Messenger.Default.Send<AmountMessage>(new AmountDecreasedMessage(entity, oldCategory) { ID = prevAccount });
                    Messenger.Default.Send<AmountMessage>(new AmountIncreasedMessage(entity, category));
                }
            }
        }
        protected override void OnEntityDeleted(long primaryKey, Transaction entity) {
            base.OnEntityDeleted(primaryKey, entity);
            var category = entity.Category ?? LookUpCategories.Entities.FirstOrDefault(c => c.ID == entity.CategoryID);
            Messenger.Default.Send<AmountMessage>(new AmountDecreasedMessage(entity, category));
        }
    }
}
