using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraPrinting.Localization;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.CharacterComb {
    public class PreviewControl : ReportModule {
        static PreviewControl() {
            EditingFieldExtensionsWin.Instance.RegisterMaskEditor("Name", "Name", "Custom", MaskType.RegEx, @"[A-Z -.]+");
            EditingFieldExtensionsWin.Instance.RegisterMaskEditor("UppercaseLatinLetters", "Uppercase Latin letters", "Custom", MaskType.RegEx, @"[A-Z]+");
            EditingFieldExtensionsWin.Instance.RegisterMaskEditor("NumbersAndUppercaseLatinLetters", "Numbers and Uppercase Latin letters", "Custom", MaskType.RegEx, @"[A-Z0-9]+");
            EditingFieldExtensionsWin.Instance.RegisterMaskEditor("UppercaseText", "Uppercase Text", "Custom", MaskType.RegEx, @"[A-Z0-9 ,-/]+");
            EditingFieldExtensionsWin.Instance.RegisterMaskEditor("Day", "Day", PreviewStringId.EditingFieldEditorCategories_DateTime.GetString(), MaskType.DateTime, @"dd");
            EditingFieldExtensionsWin.Instance.RegisterMaskEditor("Month", "Month", PreviewStringId.EditingFieldEditorCategories_DateTime.GetString(), MaskType.DateTime, @"MM");
            EditingFieldExtensionsWin.Instance.RegisterMaskEditor("Year", "Year", PreviewStringId.EditingFieldEditorCategories_DateTime.GetString(), MaskType.DateTime, @"yyyy");

            Assembly asm = Assembly.GetExecutingAssembly();
            Dictionary<string, Image> images = new Dictionary<string, Image>();
            string[] names = new string[] { "United_States_of_America", "United_Kingdom", "Germany", "France", "Italy", "Russia", "India", "Australia", "Japan", "China" };
            foreach(string name in names) {
                Image image = ResourceImageHelper.CreateImageFromResources(string.Format("XtraReportsDemos.Resources.Flags.{0}.png", name), asm);
                images.Add(name.Replace("_", " "), image);
            }
            EditingFieldExtensionsWin.Instance.RegisterImageCollectionEditor("Nationality", "Nationality", images, true, false);
        }
        protected override void OnAfterReportPrint() {
            if(Viewer != null)
                Viewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields, new object[] { true });
        }
        protected override XtraReport CreateReport() {
            return new Report();
        }
    }
}
