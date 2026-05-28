namespace DevExpress.XtraGrid.Demos {
    using System;
    using DevExpress.Data.Filtering;
    using DevExpress.Data.Summary;

    // Integer
    public class IsBlackFridayDiscountFunction : ICustomFunctionDisplayAttributes {
        public const string FunctionName = "IsBlackFridayDiscount";
        static readonly IsBlackFridayDiscountFunction Instance = new IsBlackFridayDiscountFunction();
        IsBlackFridayDiscountFunction() { }
        //
        public static void Register() {
            CriteriaOperator.RegisterCustomFunction(Instance);
        }
        public static bool Unregister() {
            return CriteriaOperator.UnregisterCustomFunction(Instance);
        }
        #region ICustomFunctionOperatorBrowsable Members
        public FunctionCategory Category {
            get { return FunctionCategory.Math; }
        }
        public string Description {
            get { return "The discount amount is 15% or more."; }
        }
        public bool IsValidOperandCount(int count) {
            return count == 1;
        }
        public bool IsValidOperandType(int operandIndex, int operandCount, Type type) {
            return SummaryItemTypeHelper.IsNumericalType(type);
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
            get { return "Is Black Friday Discount"; }
        }
        public object Image {
            get { return Properties.Resources.isBlackFridayDiscount; }
        }
        #endregion
        #region ICustomFunctionOperator Members
        public object Evaluate(params object[] operands) {
            double discount = Convert.ToDouble(operands[0]);
            return discount >= 0.15;
        }
        public string Name {
            get { return FunctionName; }
        }
        public Type ResultType(params Type[] operands) {
            return typeof(bool);
        }
        #endregion
    }
    // DateTime & Mixed
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
            get { return "Determines if a day falls on a weekend."; }
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
    public class DaysBeforeOrAfterTodayFunction : ICustomFunctionDisplayAttributesEx {
        public const string FunctionName = "DaysBeforeOrAfterToday";
        static readonly DaysBeforeOrAfterTodayFunction Instance = new DaysBeforeOrAfterTodayFunction();
        DaysBeforeOrAfterTodayFunction() { }
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
            get { return "Shows items that within X days before or after today."; }
        }
        public bool IsValidOperandCount(int count) {
            return count == 2;
        }
        public bool IsValidOperandType(int operandIndex, int operandCount, Type type) {
            return
                (operandIndex == 0 && type == typeof(DateTime)) ||
                (operandIndex == 1 && type == typeof(int));
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
            get { return "Days before or after today"; }
        }
        public object Image {
            get { return "SwitchTimeScalesTo;Size16x16;Colored"; }
        }
        #endregion
        #region ICustomFunctionOperator Members
        public object Evaluate(params object[] operands) {
            DateTime dt = Convert.ToDateTime(operands[0]);
            int days = Convert.ToInt32(operands[1]);
            DateTime start = DateTime.Today.AddDays(-days);
            DateTime end = DateTime.Today.AddDays(days);
            return (dt >= start) && (dt <= end);
        }
        public string Name {
            get { return FunctionName; }
        }
        public Type ResultType(params Type[] operands) {
            return typeof(bool);
        }
        public string GetOperandDisplayValue(object value, string displayText) {
            if(value is int)
                return string.Format("{0} days", value);
            return value?.ToString();
        }
        #endregion
    }
    // String
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
                string str1 = operands[0].ToString(); string str2 = operands[1].ToString();
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
