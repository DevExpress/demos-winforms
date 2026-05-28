using System;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.Extensions;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.TableReport {
    public class PreviewControl : ReportModule {
        class TableReportExtension : DemoReportExtension {
            public override Type[] GetEditableDataTypes() {
                return new Type[] { typeof(int) };
            }
            protected override RepositoryItem CreateRepositoryItem(Parameter parameter, Type dataType, XtraReport report) {
                if(parameter.Name == "OrderIdParameter") {
                    RepositoryItemSpinEdit item = new RepositoryItemSpinEdit();
                    item.IsFloatValue = false;
                    item.MinValue = 10248;
                    item.MaxValue = 11077;
                    return item;
                }
                if(parameter.Name == "MaxRowCountParameter") {
                    RepositoryItemSpinEdit item = new RepositoryItemSpinEdit();
                    item.IsFloatValue = false;
                    item.MinValue = 1;
                    item.MaxValue = Decimal.MaxValue;
                    return item;
                }
                return null;
            }
        }
        static PreviewControl() {
            ReportDesignExtension.RegisterExtension(new TableReportExtension(), ReportNames.TableReport);
        }
        protected override XtraReport CreateReport() {
            Report rep = new Report();
            ReportDesignExtension.AssociateReportWithExtension(rep, ReportNames.TableReport);
            return rep;
        }
    }
}

