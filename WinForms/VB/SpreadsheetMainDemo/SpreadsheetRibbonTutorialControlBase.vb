Imports System
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class SpreadsheetRibbonTutorialControlBase
        Inherits SpreadSheetTutorialControlBase

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.Options.View.Charts.Antialiasing = DocumentCapability.Enabled
            spreadsheetControl1.Options.View.Charts.TextAntialiasing = DocumentCapability.Enabled
        End Sub

        Protected Friend Overridable ReadOnly Property SelectedRibbonPage As RibbonPage
            Get
                Return homeRibbonPage1
            End Get
        End Property

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            spreadsheetControl1.Focus()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Dim selectedPage As RibbonPage = SelectedRibbonPage
            If selectedPage IsNot Nothing Then ribbonControl1.SelectedPage = selectedPage
        End Sub
    End Class
End Namespace
