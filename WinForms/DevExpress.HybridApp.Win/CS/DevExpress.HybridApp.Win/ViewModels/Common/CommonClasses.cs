using System;
using DevExpress.Data.Filtering;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.ViewModels {
    public struct DateRange {
        public DateRange(DateTime min, DateTime max)
            : this() {
            Minimum = min;
            Maximum = max;
        }
        public DateTime Minimum { get; set; }
        public DateTime Maximum { get; set; }
    }

    public static class ConverterExtensions {
        public static CriteriaOperator ConvertEditRangeToFilterCriteria(DateRange range, string parameter) {
            return CriteriaOperator.And(
                    new BinaryOperator(parameter, range.Minimum, BinaryOperatorType.GreaterOrEqual),
                    new BinaryOperator(parameter, range.Maximum, BinaryOperatorType.LessOrEqual));
        }
    }

    public static class PrintExtensions {
        public static void Print<TParent>(this object viewModel, string documentType)
        where TParent : class {
            var printModel = viewModel.GetRequiredService<IPrintableControlPreviewService>().GetPreview();
            viewModel.GetParentViewModel<TParent>().GetRequiredService<IDocumentManagerService>().CreateDocument(documentType, printModel, viewModel).Show();
        }
    }
}
