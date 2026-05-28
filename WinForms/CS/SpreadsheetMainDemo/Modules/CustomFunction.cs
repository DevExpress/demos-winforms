using System;
using System.Collections.Generic;
using System.Globalization;
using DevExpress.Docs.Text;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Functions;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class CustomFunctionModule : SpreadsheetRibbonTutorialControlBase {

        public CustomFunctionModule() {
            InitializeComponent();

            RegisterCustomFunction();
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("NumberInWords_template.xlsx"));
            spreadsheetControl1.Options.Behavior.Selection.MoveActiveCellMode = MoveActiveCellModeOnEnterPress.None;
            spreadsheetControl1.CellValueChanged += SpreadsheetControl1_CellValueChanged;
        }

        private void RegisterCustomFunction() {
            NumberInWordsFunction customFunction = new NumberInWordsFunction();
            if(!spreadsheetControl1.Document.GlobalCustomFunctions.Contains(((ICustomFunction)customFunction).Name))
                spreadsheetControl1.Document.GlobalCustomFunctions.Add(customFunction);
        }

        private void SpreadsheetControl1_CellValueChanged(object sender, SpreadsheetCellEventArgs e) {
            Worksheet sheet = spreadsheetControl1.Document.Worksheets[0];
            if(e.SheetName == sheet.Name && e.RowIndex == 3 && e.ColumnIndex == 2) {
                sheet.Columns[2].AutoFit();
                sheet.Columns[4].AutoFit();
            }
        }
    }

    public class NumberInWordsFunction : ICustomFunction {
        const string functionName = "SPELLNUMBER";
        readonly ParameterInfo[] functionParameters;
        static readonly List<CultureInfo> cultureInfoParamTable = CreateCultureInfoParamTable();

        public NumberInWordsFunction() {
            functionParameters = new ParameterInfo[] {
                new ParameterInfo(ParameterType.Value),
                new ParameterInfo(ParameterType.Value),
                new ParameterInfo(ParameterType.Value, ParameterAttributes.Optional)
            };
        }

        string IFunction.Name {
            get {
                return functionName;
            }
        }

        ParameterInfo[] IFunction.Parameters {
            get {
                return functionParameters;
            }
        }

        ParameterType IFunction.ReturnType {
            get {
                return ParameterType.Value;
            }
        }

        bool IFunction.Volatile {
            get {
                return true;
            }
        }

        ParameterValue IFunction.Evaluate(IList<ParameterValue> parameters, EvaluationContext context) {
            bool isOrdinal = false;
            ParameterValue numberValue = parameters[0];
            if(numberValue.IsError)
                return numberValue;

            ParameterValue cultureValue = parameters[1];
            if(cultureValue.IsError)
                return cultureValue;
            if(cultureValue.NumericValue < 1 || cultureValue.NumericValue > cultureInfoParamTable.Count)
                return ParameterValue.ErrorNumber;

            if(parameters.Count == 3) {
                ParameterValue ordinalValue = parameters[1];
                if(ordinalValue.IsError)
                    return ordinalValue;

                isOrdinal = ordinalValue.BooleanValue;
            }

            if(numberValue.IsText)
                return ParameterValue.ErrorInvalidValueInFunction;
            double number = numberValue.NumericValue;
            CultureInfo culture = cultureInfoParamTable[(int)cultureValue.NumericValue - 1];

            if(number < 0 || number > long.MaxValue)
                return ParameterValue.ErrorNumber;

            if(isOrdinal)
                return NumberInWords.Ordinal.ConvertToText((long)Math.Round(number), culture);
            else
                return NumberInWords.Cardinal.ConvertToText((long)Math.Round(number), culture);
        }
        string IFunction.GetName(CultureInfo culture) {
            return functionName;
        }

        static List<CultureInfo> CreateCultureInfoParamTable() {
            return new List<CultureInfo> {
                CultureInfo.GetCultureInfo("en-US"),
                CultureInfo.GetCultureInfo("en-GB"),
                CultureInfo.GetCultureInfo("fr-FR"),
                CultureInfo.GetCultureInfo("de-DE"),
                CultureInfo.GetCultureInfo("el-GR"),
                CultureInfo.GetCultureInfo("hi-IN"),
                CultureInfo.GetCultureInfo("it-IT"),
                CultureInfo.GetCultureInfo("pt-PT"),
                CultureInfo.GetCultureInfo("ru-RU"),
                CultureInfo.GetCultureInfo("es-ES"),
                CultureInfo.GetCultureInfo("sv-SE"),
                CultureInfo.GetCultureInfo("th-TH"),
                CultureInfo.GetCultureInfo("tr-TR"),
                CultureInfo.GetCultureInfo("uk-UA")
            };
        }
    }
}
