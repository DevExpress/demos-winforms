using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;

namespace DevExpress.DevAV.Common.ViewModel {
    partial class CollectionViewModel<TEntity, TPrimaryKey, TUnitOfWork> : ISupportParameter, IDocumentContent
        where TEntity : class
        where TUnitOfWork : IUnitOfWork {
        protected override void OnInitializeInRuntime() {
            base.OnInitializeInRuntime();
            Messenger.Default.Register<SelectedItemSynchronizationMessage<TEntity>>(this, x => OnSelectedItemSynchronizationMessage(x));
            Messenger.Default.Register<EntityMessage<TEntity, TPrimaryKey>>(this, x => OnEntityMessage(x));
        }
        void OnEntityMessage(EntityMessage<TEntity, TPrimaryKey> m) {
            if(m.MessageType == EntityMessageType.Changed) {
                TEntity entity = ((EntitiesChangeTracker<TPrimaryKey>)ChangeTracker).FindLocalProjectionByKey(m.PrimaryKey);
                if(entity != null)
                    OnEntityChanged(entity);
                RaiseEntityChanged(m.PrimaryKey);
            }
            else RaiseEntitiesCountChanged(Entities.Count);
        }
        protected virtual void OnEntityChanged(TEntity entity) { }
        protected override void OnIsLoadingChanged() {
            base.OnIsLoadingChanged();
            if(!IsLoading)
                RaiseEntitiesCountChanged(Entities.Count);
        }
        public event EventHandler<EntitiesCountEventArgs> EntitiesCountChanged;
        public event EventHandler<EntityEventArgs<TPrimaryKey>> EntityChanged;
        void RaiseEntityChanged(TPrimaryKey key) {
            EventHandler<EntityEventArgs<TPrimaryKey>> handler = EntityChanged;
            if(handler != null)
                handler(this, new EntityEventArgs<TPrimaryKey>(key));
        }
        void RaiseEntitiesCountChanged(int count) {
            EventHandler<EntitiesCountEventArgs> handler = EntitiesCountChanged;
            if(handler != null)
                handler(this, new EntitiesCountEventArgs(count));
        }
        public override void OnLoaded() {
            
            base.OnLoaded();
        }
        public event EventHandler SelectedEntityChanged; 
        protected override void OnSelectedEntityChanged() {
            
            base.OnSelectedEntityChanged();
            Messenger.Default.Send(new SelectedItemSynchronizationMessage<TEntity>(SelectedEntity));
            if(SelectedEntityChanged != null)
                SelectedEntityChanged(this, EventArgs.Empty);
        }
        void OnSelectedItemSynchronizationMessage(SelectedItemSynchronizationMessage<TEntity> message) {
            
        }
        public event EventHandler ParameterChanged;
        protected virtual object GetTitle() {
            return null;
        }
        #region ISupportParameter
        object parameterCore;
        protected object Parameter {
            get { return parameterCore; }
            private set {
                parameterCore = value;
                EventHandler handler = ParameterChanged;
                if(handler != null)
                    handler(this, EventArgs.Empty);
            }
        }
        object ISupportParameter.Parameter {
            get { return Parameter; }
            set { Parameter = value; }
        }
        #endregion
        protected IDocument FindDocument<TViewModel>() {
            if(DocumentManagerService == null) return null;
            return DocumentManagerService.Documents.FirstOrDefault(d => d.Content is TViewModel);
        }
        protected IDocument FindDocument<TViewModel>(TPrimaryKey key) {
            if(DocumentManagerService == null) return null;
            foreach(IDocument document in DocumentManagerService.Documents) {
                ISingleObjectViewModel<TEntity, TPrimaryKey> entityViewModel = document.Content as ISingleObjectViewModel<TEntity, TPrimaryKey>;
                if(entityViewModel != null && entityViewModel is TViewModel && object.Equals(entityViewModel.PrimaryKey, key))
                    return document;
            }
            return null;
        }
        public TPrimaryKey SelectedEntityKey {
            get { return (SelectedEntity != null) ? CreateRepository().GetPrimaryKey(SelectedEntity) : default(TPrimaryKey); }
        }
        public virtual IQueryable<TEntity> GetEntities(Expression<Func<TEntity, bool>> filter = null) {
            try {
                var entities = getRepositoryFunc(CreateUnitOfWork());
                return entities.GetFilteredEntities(filter);
            }
            catch(Exception e) { throw new NotSupportedException("Error in Expression:" + filter.ToString(), e); }
        }
        public virtual int GetEntitiesCount(Expression<Func<TEntity, bool>> filter = null) {
            try {
                var entities = getRepositoryFunc(CreateUnitOfWork());
                return entities.GetFilteredEntities(filter).Count();
            }
            catch(Exception e) { throw new NotSupportedException("Error in Expression:" + filter.ToString(), e); }
        }
        public Data.Filtering.CriteriaOperator GetInOperator(IEnumerable<TEntity> entities) {
            string keyName = ((MemberExpression)CreateRepository().GetPrimaryKeyExpression.Body).Member.Name;
            return new Data.Filtering.InOperator(keyName, entities.Select(e => CreateRepository().GetPrimaryKey(e)));
        }
    }
}
