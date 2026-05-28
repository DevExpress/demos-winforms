using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.ClientServer;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Xpo;

namespace DevExpress.DentalClinic {
    public interface ISecuredObjectSpaceService {
        SecuredObjectSpaceProvider Provider { get; }
        SecurityStrategyComplex Security { get; }
        UnitOfWork CreateSession();
    }
    public class SecuredObjectSpaceService : ISecuredObjectSpaceService {
        
        public SecuredObjectSpaceService(SecurityStrategyComplex security, SecuredObjectSpaceProvider provider) {
            providerCore = provider;
            securityCore = security;
        }
        SecuredObjectSpaceProvider providerCore;
        public SecuredObjectSpaceProvider Provider { get { return providerCore; } }
        SecurityStrategyComplex securityCore;
        public SecurityStrategyComplex Security { get { return securityCore; } }
        
        public UnitOfWork CreateSession() {
            return (providerCore.CreateObjectSpace() as XPObjectSpace).Session as UnitOfWork;
        }
    }
}
