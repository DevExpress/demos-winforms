









namespace DevExpress.DevAV.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>On probation </Name>
    <FilterCriteria>Not IsNull([ProbationReason])</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList EmployeesCustomFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["EmployeesCustomFilters"]));
            }
            set {
                this["EmployeesCustomFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>All</Name>
  </FilterInfo>
  <FilterInfo>
    <Name>Salaried</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,Salaried#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Commission</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,Commission#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Contract</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,Contract#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Terminated</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,Terminated#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>On Leave</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,OnLeave#</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList EmployeesStaticFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["EmployeesStaticFilters"]));
            }
            set {
                this["EmployeesStaticFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>All</Name>
  </FilterInfo>
  <FilterInfo>
    <Name>Urgent tasks</Name>
    <FilterCriteria>[Priority] = ##Enum#DevExpress.DevAV.EmployeeTaskPriority,Urgent#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>High priority</Name>
    <FilterCriteria>[Priority] = ##Enum#DevExpress.DevAV.EmployeeTaskPriority,High#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Low priority</Name>
    <FilterCriteria>[Priority] = ##Enum#DevExpress.DevAV.EmployeeTaskPriority,Low#</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList TasksStaticFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["TasksStaticFilters"]));
            }
            set {
                this["TasksStaticFilters"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>Active</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.CustomerStatus,Active#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Suspended</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.CustomerStatus,Suspended#</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList CustomersCustomFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["CustomersCustomFilters"]));
            }
            set {
                this["CustomersCustomFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>All</Name>
  </FilterInfo>
  <FilterInfo>
    <Name>Stores &gt; 10 Locations</Name>
    <FilterCriteria>[TotalStores] &gt; 10</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Revenues &gt; 100 Billion</Name>
    <FilterCriteria>[AnnualRevenue] &gt; 100000000000.0m</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Employees &gt; 10000</Name>
    <FilterCriteria>[TotalEmployees] &gt; 10000</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList CustomersStaticFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["CustomersStaticFilters"]));
            }
            set {
                this["CustomersStaticFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>Discontinued</Name>
    <FilterCriteria>[Available] = False</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Out of Stock</Name>
    <FilterCriteria>[CurrentInventory] = 0</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList ProductsCustomFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["ProductsCustomFilters"]));
            }
            set {
                this["ProductsCustomFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>All</Name>
  </FilterInfo>
  <FilterInfo>
    <Name>Video Players</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,VideoPlayers#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Automation</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,Automation#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Monitors</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,Monitors#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Projectors</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,Projectors#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Televisions</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,Televisions#</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList ProductsStaticFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["ProductsStaticFilters"]));
            }
            set {
                this["ProductsStaticFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>Sales &gt; $5000</Name>
    <FilterCriteria>[TotalAmount] &gt; 5000.0m</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Sales &lt; $5000</Name>
    <FilterCriteria>[TotalAmount] &lt; 5000.0m</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Sales by Jim Packard</Name>
    <FilterCriteria>[EmployeeId] = 41</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Sales by Harv Mudd</Name>
    <FilterCriteria>[EmployeeId] = 43</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Sales by Clark Morgan</Name>
    <FilterCriteria>[EmployeeId] = 44</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Sales by Todd Hoffman</Name>
    <FilterCriteria>[EmployeeId] = 45</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList OrdersCustomFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["OrdersCustomFilters"]));
            }
            set {
                this["OrdersCustomFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>All</Name>
  </FilterInfo>
  <FilterInfo>
    <Name>Today</Name>
    <FilterCriteria>IsOutlookIntervalToday([OrderDate])</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Yesterday</Name>
    <FilterCriteria>IsOutlookIntervalYesterday([OrderDate])</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>This Month</Name>
    <FilterCriteria>IsThisMonth([OrderDate])</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>This Year</Name>
    <FilterCriteria>IsOutlookIntervalEarlierThisYear([OrderDate])</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Unpaid Orders</Name>
    <FilterCriteria>[PaymentTotal] = 0.0m</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Redunds</Name>
    <FilterCriteria>[RefundTotal] = [TotalAmount]</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList OrdersStaticFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["OrdersStaticFilters"]));
            }
            set {
                this["OrdersStaticFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList QuotesCustomFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["QuotesCustomFilters"]));
            }
            set {
                this["QuotesCustomFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>All</Name>
  </FilterInfo>
  <FilterInfo>
    <Name>Today</Name>
    <FilterCriteria>IsOutlookIntervalToday([Date])</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Yesterday</Name>
    <FilterCriteria>IsOutlookIntervalYesterday([Date])</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>This Month</Name>
    <FilterCriteria>IsThisMonth([Date])</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>This Year</Name>
    <FilterCriteria>IsOutlookIntervalEarlierThisYear([Date])</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList QuotesStaticFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["QuotesStaticFilters"]));
            }
            set {
                this["QuotesStaticFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList EmployeesGroupFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["EmployeesGroupFilters"]));
            }
            set {
                this["EmployeesGroupFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList CustomersGroupFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["CustomersGroupFilters"]));
            }
            set {
                this["CustomersGroupFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList ProductsGroupFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["ProductsGroupFilters"]));
            }
            set {
                this["ProductsGroupFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>Barb Banks</Name>
    <FilterCriteria>[AssignedEmployee.FullName] = 'Barb Banks'</FilterCriteria>
  </FilterInfo> 
  <FilterInfo>
    <Name>Bart Arnaz</Name>
    <FilterCriteria>[AssignedEmployee.FullName] = 'Bart Arnaz'</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Ed Holmes</Name>
    <FilterCriteria>[AssignedEmployee.FullName] = 'Ed Holmes'</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>John Heart</Name>
    <FilterCriteria>[AssignedEmployee.FullName] = 'John Heart'</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Samantha Bright</Name>
    <FilterCriteria>[AssignedEmployee.FullName] = 'Samantha Bright'</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList TasksGroupFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["TasksGroupFilters"]));
            }
            set {
                this["TasksGroupFilters"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList OrdersGroupFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["OrdersGroupFilters"]));
            }
            set {
                this["OrdersGroupFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList QuotesGroupFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["QuotesGroupFilters"]));
            }
            set {
                this["QuotesGroupFilters"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
 <FilterInfo>
    <Name>Active</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeTaskStatus,InProgress#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Completed</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeTaskStatus,Completed#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Private</Name>
    <FilterCriteria>[Private] = True</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList TasksCustomFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["TasksCustomFilters"]));
            }
            set {
                this["TasksCustomFilters"] = value;
            }
        }

    }
}
