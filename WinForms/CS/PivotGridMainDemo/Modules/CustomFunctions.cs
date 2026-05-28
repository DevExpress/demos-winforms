using System;
using DevExpress.Data.Filtering;

namespace DevExpress.XtraPivotGrid.Demos {
    public class IsBlackFridayFunction : ICustomFunctionDisplayAttributes {
        public const string FunctionName = "IsBlackFriday";
        static readonly IsBlackFridayFunction Instance = new IsBlackFridayFunction();
        IsBlackFridayFunction() { }
        //
        public static void Register() {
            CriteriaOperator.RegisterCustomFunction(Instance);
        }
        public static bool Unregister() {
            return CriteriaOperator.UnregisterCustomFunction(Instance);
        }
        #region ICustomFunctionOperatorBrowsable Members
        public FunctionCategory Category {
            get { return FunctionCategory.DateTime; }
        }
        public string Description {
            get { return "Is the day after Thanksgiving Day"; }
        }
        public bool IsValidOperandCount(int count) {
            return count == 1;
        }
        public bool IsValidOperandType(int operandIndex, int operandCount, Type type) {
            return type == typeof(DateTime) || type == typeof(DateTime?);
        }
        public int MaxOperandCount {
            get { return 1; }
        }
        public int MinOperandCount {
            get { return 1; }
        }
        #endregion
        #region ICustomFunctionDisplayAttributes
        public string DisplayName {
            get { return "Is Black Friday"; }
        }
        public object Image {
            get { return Properties.Resources.isBlackFridayDiscount; }
        }
        #endregion
        #region ICustomFunctionOperator Members
        public object Evaluate(params object[] operands) {
            DateTime date = Convert.ToDateTime(operands[0]);
            return (date.Month == 11) && (date.Day >= 23 && date.Day <= 29) && (date.DayOfWeek == DayOfWeek.Friday);
        }
        public string Name {
            get { return FunctionName; }
        }
        public Type ResultType(params Type[] operands) {
            return typeof(bool);
        }
        #endregion
    }
    public class IsWeekendFunction : ICustomFunctionDisplayAttributes {
        public const string FunctionName = "IsWeekend";
        static readonly IsWeekendFunction Instance = new IsWeekendFunction();
        IsWeekendFunction() { }
        //
        public static void Register() {
            CriteriaOperator.RegisterCustomFunction(Instance);
        }
        public static bool Unregister() {
            return CriteriaOperator.UnregisterCustomFunction(Instance);
        }
        #region ICustomFunctionOperatorBrowsable Members
        public FunctionCategory Category {
            get { return FunctionCategory.DateTime; }
        }
        public string Description {
            get { return "Is Saturday or Sunday."; }
        }
        public bool IsValidOperandCount(int count) {
            return count == 1;
        }
        public bool IsValidOperandType(int operandIndex, int operandCount, Type type) {
            return type == typeof(DateTime) || type == typeof(DateTime?);
        }
        public int MaxOperandCount {
            get { return 1; }
        }
        public int MinOperandCount {
            get { return 1; }
        }
        #endregion
        #region ICustomFunctionDisplayAttributes
        public string DisplayName {
            get { return "Is Weekend"; }
        }
        public object Image {
            get { return Properties.Resources.Actions_Calendar; }
        }
        #endregion
        #region ICustomFunctionOperator Members
        public object Evaluate(params object[] operands) {
            DateTime date = Convert.ToDateTime(operands[0]);
            return date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday;
        }
        public string Name {
            get { return FunctionName; }
        }
        public Type ResultType(params Type[] operands) {
            return typeof(bool);
        }
        #endregion
    }
    public class NotBeginsWithFunction : ICustomFunctionDisplayAttributes {
        public const string FunctionName = "NotBeginsWith";
        static readonly NotBeginsWithFunction Instance = new NotBeginsWithFunction();
        NotBeginsWithFunction() { }
        //
        public static void Register() {
            CriteriaOperator.RegisterCustomFunction(Instance);
        }
        public static bool Unregister() {
            return CriteriaOperator.UnregisterCustomFunction(Instance);
        }
        #region ICustomFunctionOperatorBrowsable Members
        public FunctionCategory Category {
            get { return FunctionCategory.Text; }
        }
        public string Description {
            get { return "Selects items that do not start with the specified string."; }
        }
        public bool IsValidOperandCount(int count) {
            return count == 2;
        }
        public bool IsValidOperandType(int operandIndex, int operandCount, Type type) {
            return type == typeof(string);
        }
        public int MaxOperandCount {
            get { return 2; }
        }
        public int MinOperandCount {
            get { return 2; }
        }
        #endregion
        #region ICustomFunctionDisplayAttributes
        public string DisplayName {
            get { return "Not Begins With"; }
        }
        public object Image {
            get { return null; }
        }
        #endregion
        #region ICustomFunctionOperator Members
        public object Evaluate(params object[] operands) {
            if(operands[0] != null && operands[1] != null) {
                string str1 = operands[0].ToString();
                string str2 = operands[1].ToString();
                return !str1.StartsWith(str2, StringComparison.InvariantCultureIgnoreCase);
            }
            return false;
        }
        public string Name {
            get { return FunctionName; }
        }
        public Type ResultType(params Type[] operands) {
            return typeof(bool);
        }
        #endregion
    }
}
