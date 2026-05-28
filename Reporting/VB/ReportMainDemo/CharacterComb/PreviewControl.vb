Imports System.Collections.Generic
Imports System.Drawing
Imports System.Reflection
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraPrinting.Localization
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.CharacterComb

    Public Class PreviewControl
        Inherits ReportModule

        Shared Sub New()
            Call EditingFieldExtensionsWin.Instance.RegisterMaskEditor("Name", "Name", "Custom", MaskType.RegEx, "[A-Z -.]+")
            Call EditingFieldExtensionsWin.Instance.RegisterMaskEditor("UppercaseLatinLetters", "Uppercase Latin letters", "Custom", MaskType.RegEx, "[A-Z]+")
            Call EditingFieldExtensionsWin.Instance.RegisterMaskEditor("NumbersAndUppercaseLatinLetters", "Numbers and Uppercase Latin letters", "Custom", MaskType.RegEx, "[A-Z0-9]+")
            Call EditingFieldExtensionsWin.Instance.RegisterMaskEditor("UppercaseText", "Uppercase Text", "Custom", MaskType.RegEx, "[A-Z0-9 ,-/]+")
            Call EditingFieldExtensionsWin.Instance.RegisterMaskEditor("Day", "Day", PreviewStringId.EditingFieldEditorCategories_DateTime.GetString(), MaskType.DateTime, "dd")
            Call EditingFieldExtensionsWin.Instance.RegisterMaskEditor("Month", "Month", PreviewStringId.EditingFieldEditorCategories_DateTime.GetString(), MaskType.DateTime, "MM")
            Call EditingFieldExtensionsWin.Instance.RegisterMaskEditor("Year", "Year", PreviewStringId.EditingFieldEditorCategories_DateTime.GetString(), MaskType.DateTime, "yyyy")
            Dim asm As Assembly = Assembly.GetExecutingAssembly()
            Dim images As Dictionary(Of String, Image) = New Dictionary(Of String, Image)()
            Dim names As String() = New String() {"United_States_of_America", "United_Kingdom", "Germany", "France", "Italy", "Russia", "India", "Australia", "Japan", "China"}
            For Each name As String In names
                Dim image As Image = ResourceImageHelperCore.CreateImageFromResources(String.Format("XtraReportsDemos.Resources.Flags.{0}.png", name), asm)
                images.Add(name.Replace("_", " "), image)
            Next

            EditingFieldExtensionsWin.Instance.RegisterImageCollectionEditor("Nationality", "Nationality", images, True, False)
        End Sub

        Protected Overrides Sub OnAfterReportPrint()
            If Viewer IsNot Nothing Then Viewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields, New Object() {True})
        End Sub

        Protected Overrides Function CreateReport() As XtraReport
            Return New Report()
        End Function
    End Class
End Namespace
