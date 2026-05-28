using System;
using System.Linq;

namespace DevExpress.MVVM.Demos.Common.DataModel.EntityFramework {
    class DbUnitOfWorkFactory<TUnitOfWork> : IUnitOfWorkFactory<TUnitOfWork> where TUnitOfWork : IUnitOfWork {
        Func<TUnitOfWork> createUnitOfWork;

        public DbUnitOfWorkFactory(Func<TUnitOfWork> createUnitOfWork) {
            this.createUnitOfWork = createUnitOfWork;
        }

        TUnitOfWork IUnitOfWorkFactory<TUnitOfWork>.CreateUnitOfWork() {
            return createUnitOfWork();
        }

        IInstantFeedbackSource<TProjection> IUnitOfWorkFactory<TUnitOfWork>.CreateInstantFeedbackSource<TEntity, TProjection, TPrimaryKey>(
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection) {
            throw new NotImplementedException();
        }
    }
}
