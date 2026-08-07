using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.DevAV.Common.DataModel;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.ViewModels {
    public class EmployeeMailMergeViewModel : MailMergeViewModel<Employee, object> {
        protected EmployeeMailMergeViewModel(IEnumerable<Employee> entities = null, Employee selectedEntity = null, string selectedTemplateName = null, object linksViewModel = null)
            : base(entities, selectedEntity, selectedTemplateName, linksViewModel) {
        }

        public static EmployeeMailMergeViewModel Create<TUnitOfWork, TPrimaryKey>(IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory, Func<TUnitOfWork, IRepository<Employee, TPrimaryKey>> getRepositoryFunc, TPrimaryKey? key, string selectedTemplateName = null, object linksViewModel = null)
            where TUnitOfWork : IUnitOfWork
            where TPrimaryKey : struct {
            var repository = getRepositoryFunc(unitOfWorkFactory.CreateUnitOfWork());
            var entities = repository.ToArray();
            var selectedEntity = key != null ? repository.Find(key.Value) : null;
            return ViewModelSource.Create(() => new EmployeeMailMergeViewModel(entities, selectedEntity, selectedTemplateName, linksViewModel));
        }
    }
}
