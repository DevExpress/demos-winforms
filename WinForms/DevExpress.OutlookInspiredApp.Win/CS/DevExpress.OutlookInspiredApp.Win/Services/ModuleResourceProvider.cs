using DevExpress.DevAV.Common.Utils;

namespace DevExpress.DevAV.Services {
    public interface IModuleResourceProvider {
        string GetCaption(ModuleType moduleType);
        string GetModuleImageUri(ModuleType moduleType, bool smallImage = false);
    }
    
    public class ModuleResourceProvider : IModuleResourceProvider {
        public string GetCaption(ModuleType moduleType) {
            switch(moduleType) {
                case ModuleType.Unknown:
                    return null;
                case ModuleType.EmployeesPeek:
                case ModuleType.EmployeesFilterPane:
                    return "Employees";
                case ModuleType.CustomersPeek:
                case ModuleType.CustomersFilterPane:
                    return "Customers";
                case ModuleType.ProductsPeek:
                case ModuleType.ProductsFilterPane:
                    return "Products";
                case ModuleType.Orders:
                case ModuleType.OrdersFilterPane:
                    return "Sales";
                case ModuleType.Quotes:
                case ModuleType.QuotesFilterPane:
                    return "Opportunities";
                case ModuleType.Tasks:
                case ModuleType.TasksFilterPane:
                    return "Tasks";
                default:
                    return moduleType.ToString();
            }
        }
        public virtual string GetModuleImageUri(ModuleType moduleType, bool smallImage = false) {
            switch(moduleType) {
                case ModuleType.Employees:
                case ModuleType.EmployeesFilterPane:
                    return smallImage ?
                        FluentIconHelper.GetFluentIconName("business%20objects/bo_position;Size16x16") :
                        FluentIconHelper.GetFluentIconName("business%20objects/bo_position");
                case ModuleType.Customers:
                case ModuleType.CustomersFilterPane:
                    return smallImage ?
                       FluentIconHelper.GetFluentIconName("business%20objects/bo_customer;Size16x16") :
                       FluentIconHelper.GetFluentIconName("business%20objects/bo_customer");
                case ModuleType.Products:
                case ModuleType.ProductsFilterPane:
                    return smallImage ?
                        FluentIconHelper.GetFluentIconName("business%20objects/bo_product;Size16x16") :
                        FluentIconHelper.GetFluentIconName("business%20objects/bo_product");
                case ModuleType.Orders:
                case ModuleType.OrdersFilterPane:
                    return smallImage ?
                        FluentIconHelper.GetFluentIconName("business%20objects/bo_sale;Size16x16") :
                       FluentIconHelper.GetFluentIconName("business%20objects/bo_sale");
                case ModuleType.Quotes:
                case ModuleType.QuotesFilterPane:
                    return smallImage ?
                       FluentIconHelper.GetFluentIconName("business%20objects/bo_opportunity;Size16x16") :
                        FluentIconHelper.GetFluentIconName("business%20objects/bo_opportunity");
                case ModuleType.Tasks:
                case ModuleType.TasksFilterPane:
                    return smallImage ?
                        FluentIconHelper.GetFluentIconName("resource://DevExpress.DevAV.Resources.Modules.Tasks.svg?Size=16x16") :
                        FluentIconHelper.GetFluentIconName("resource://DevExpress.DevAV.Resources.Modules.Tasks.svg");
                case ModuleType.Unknown:
                    return null;
                default:
                    return null;
            }
        }
    }
}
