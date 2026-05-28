using DevExpress.DentalClinic.Model;
using DevExpress.DentalClinic.View;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpo;
using System;

namespace DevExpress.DentalClinic.ViewModel {
    public class UserCollectionViewModel: IDisposable {
        UnitOfWork sessionCore;
        public UserCollectionViewModel() {
            Users = new XPCollection<Employee>(Session);
            Messenger.Default.Register<ReloadDataMessage>(this, OnReloadData);
        }
        public void Dispose() {
            Users?.Dispose();
            sessionCore?.Dispose();
        }
        void OnReloadData(ReloadDataMessage message) {
            if(SessionProvider == null) return;
            sessionCore = null;
            Users = new XPCollection<Employee>(Session);
        }
        public virtual XPCollection<Employee> Users { get; set; }
        public UnitOfWork Session {
            get {
                if(sessionCore == null)
                    sessionCore = SessionProvider.CreateSession();
                return sessionCore;
            }
        }
        public virtual Employee SelectedEntity {
            get;
            set;
        }
        public void Edit() {
            if(SelectedEntity != null)
                NavigationService.Navigate(nameof(EmployeeView), SelectedEntity.Oid);
        }
        INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
        ISecuredObjectSpaceService SessionProvider { get { return this.GetService<ISecuredObjectSpaceService>(); } }
    }
}
