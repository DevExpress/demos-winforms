Imports System
Imports System.Collections.Generic
Imports DevExpress.Data.Filtering
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class ExcelFiltering
        Inherits TutorialControl

        Public Overrides ReadOnly Property ExportView As BaseView
            Get
                Return bandedGridView1
            End Get
        End Property

        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            VehiclesData.InitOrdersData(dataFileName, gridControl1, 10000, 400)
            VehiclesData.InitColumnViewEditors(bandedGridView1)
        End Sub

        Public Overrides ReadOnly Property ShowViewOptions As Boolean
            Get
                Return True
            End Get
        End Property

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            InitVehiclesData()
            SetToolTipController(Me, gridControl1)
            bandedGridView1.HtmlImages = DemoHelper.GetTransmissionGlyphs()
            If Not MainFormHelper.TakeScreens Then
                bandedGridView1.ActiveFilterString = "InRange([ModelPrice], 25000, 80000) And (IsOutlookIntervalToday([SalesDate]) Or IsOutlookIntervalYesterday([SalesDate]))"
                bandedGridView1.MRUFiltersInfo.Add(New ViewFilter(bandedGridView1, CriteriaOperator.Parse("InRange([ModelPrice], 50000, 150000)")))
                bandedGridView1.MRUFiltersInfo.Add(New ViewFilter(bandedGridView1, CriteriaOperator.Parse("IsOutlookIntervalToday([SalesDate]) Or IsOutlookIntervalYesterday([SalesDate])")))
                bandedGridView1.MRUFiltersInfo.Add(New ViewFilter(bandedGridView1, CriteriaOperator.Parse("[SalesDate] > AddDays(LocalDateTimeToday(),-25)")))
            Else
                bandedGridView1.ActiveFilterString = "([ModelPrice] >= 25000 And [ModelPrice] <= 80000)"
            End If
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ExcelFiltering"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "ExcelFiltering"
            End Get
        End Property

        ' Addding custom Filters and Data Items customization
        '<gridControl1>
        Private Sub gridView_FilterPopupExcelData(ByVal sender As Object, ByVal e As FilterPopupExcelDataEventArgs)
            Dim fieldName As String = e.Column.FieldName
            If e.Column Is bcModification Then
                ' Filter Items
                e.AddFilter("<image=A><nbsp>Automatic Transmission (6-speed)", "Contains([" & fieldName & "], '6A')", True)
                e.AddFilter("<image=A><nbsp>Automatic Transmission (8-speed)", "Contains([" & fieldName & "], '8A')", True)
                e.AddFilter("<image=M><nbsp>Manual Transmission (6-speed)", "Contains([" & fieldName & "], '6M')", True)
                e.AddFilter("<image=M><nbsp>Manual Transmission (7-speed)", "Contains([" & fieldName & "], '7M')", True)
                e.AddFilter("<image=V><nbsp>Variomatic Transmission", "Contains([" & fieldName & "], 'VA')", True)
                e.AddFilter("<b>Limited Edition</b>", "Contains([" & fieldName & "], 'Limited')", True)
                ' Data Items
                For Each item In e.DataItems
                    If item.Text.Contains("V6") Then item.HtmlText = item.Text.Replace("V6", "<b>V6</b>")
                    If item.Text.Contains("V8") Then item.HtmlText = item.Text.Replace("V8", "<b>V8</b>")
                    If item.Text.Contains("Limited") Then item.HtmlText = "<image=Ltd><nbsp>" & item.Text
                Next
            End If

            If e.Column Is bcMPGCity Then ' 12-28
                e.AddFilter("Fuel Economy (<color=@Information>High</color>)", "[" & fieldName & "]>25", True)
                e.AddFilter("Fuel Economy (<color=@Warning>Medium</color>)", "[" & fieldName & "]>=15 AND [" & fieldName & "]<=25", True)
                e.AddFilter("Fuel Economy (<color=@Critical>Low</color>)", "[" & fieldName & "]<15", True)
            End If

            If e.Column Is bcMPGHighway Then ' 15-36
                e.AddFilter("Fuel Economy (<color=@Information>High</color>)", "[" & fieldName & "]>20", True)
                e.AddFilter("Fuel Economy (<color=@Warning>Medium</color>)", "[" & fieldName & "]>=20 AND [" & fieldName & "]<=30", True)
                e.AddFilter("Fuel Economy (<color=@Critical>Low</color>)", "[" & fieldName & "]>20", True)
            End If

            ' sales from newer to older by years
            If e.Column Is bcSalesDate Then
                ' using low-level API for inplace values and texts reordering
                Array.Sort(e.Values, e.DisplayTexts, YearsFromNewerToOlder.Comparer)
            End If
        End Sub

        '</gridControl1>
#Region "GenerateReport"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

#End Region
        Private NotInheritable Class YearsFromNewerToOlder
            Implements IComparer(Of Object)

            Public Shared Comparer As IComparer(Of Object) = New YearsFromNewerToOlder()

            Private Sub New()
            End Sub

            '
            Private Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer(Of Object).Compare
                Dim dateX = CDate(x)
                Dim dateY = CDate(y)
                Dim yearsResultFromNewerToOlder = dateY.Year.CompareTo(dateX.Year)
                If yearsResultFromNewerToOlder = 0 Then Return dateX.CompareTo(dateY)
                Return yearsResultFromNewerToOlder
            End Function
        End Class
    End Class
End Namespace
