Imports DevExpress.Data.PivotGrid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Linq

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class AutomaticTotals
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            CreateWaitDialog()
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        Private Sub AutomaticTotals_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            fieldYear.FilterValues.FilterType = PivotFilterType.Included
            fieldYear.FilterValues.Add(2015)
            fieldCategoryName.FilterValues.FilterType = PivotFilterType.Included
            fieldCategoryName.FilterValues.Add("Beverages")
            fieldCategoryName.FilterValues.Add("Condiments")
            InitComboBoxes()
            AddOptions()
            pivotGridControl1.ValueImages = CategoryImageList
            UpdateListBoxColor(clbOptions)
            AddHandler CType(RibbonMenuManager, PivotGridRibbonMenuManager).ViewOptionsChanged, AddressOf OnRibbonViewOptionsChanged
        End Sub

        Protected Overrides Sub OnStyleChanged()
            MyBase.OnStyleChanged()
            UpdateListBoxColor(clbOptions)
        End Sub

        Private Sub InitComboBoxes()
            icbSummaryType.Properties.Items.AddEnum(GetType(PivotSummaryType))
            For Each field As PivotGridField In pivotGridControl1.Fields
                If field.Area = PivotArea.DataArea AndAlso field.Visible Then
                    icbField.Properties.Items.Add(New ImageComboBoxItem(field.Caption.ToString(), field, -1))
                End If
            Next

            icbField.SelectedIndex = 0
        End Sub

        '<clbOptions>
        Private Sub AddOptions()
            Dim excludedOptions As List(Of String) = New List(Of String)(New String() {"ShowCustomTotalsForSingleValues"})
            Dim arr As ArrayList = New ArrayList()
            Dim pds As PropertyDescriptorCollection = TypeDescriptor.GetProperties(pivotGridControl1.OptionsView)
            For Each pd As PropertyDescriptor In pds
                If pd.PropertyType.Equals(GetType(Boolean)) AndAlso pd.Name.IndexOf("Total") > -1 AndAlso Not excludedOptions.Contains(pd.Name) Then
                    arr.Add(New CheckedListBoxElement(pd))
                End If
            Next

            arr.Sort()
            clbOptions.DataSource = arr
            For i As Integer = 0 To clbOptions.ItemCount - 1
                clbOptions.SetItemChecked(i, SetOptions.OptionValueByString(TryCast(clbOptions.GetItem(i), CheckedListBoxElement).PropertyName, pivotGridControl1.OptionsView))
            Next
        End Sub

        Private Sub OnRibbonViewOptionsChanged(ByVal s As Object, ByVal arg As ViewOptionsChangedEventArgs)
            If CType(RibbonMenuManager, PivotGridRibbonMenuManager).CurrentPivotGrid IsNot pivotGridControl1 Then Return
            For i As Integer = 0 To clbOptions.ItemCount - 1
                If Equals(TryCast(clbOptions.GetItem(i), CheckedListBoxElement).PropertyName, arg.Name) Then
                    clbOptions.SetItemChecked(i, arg.Value)
                    Return
                End If
            Next
        End Sub

        Private Sub clbOptions_ItemCheck(ByVal sender As Object, ByVal e As XtraEditors.Controls.ItemCheckEventArgs)
            Call SetOptions.SetOptionValueByString(TryCast(clbOptions.GetItem(e.Index), CheckedListBoxElement).PropertyName, pivotGridControl1.OptionsView, e.State = CheckState.Checked)
            CType(RibbonMenuManager, PivotGridRibbonMenuManager).RefreshOptionsMenu(pivotGridControl1)
        End Sub

        '</clbOptions>
        '<icbField>
        Private Sub icbField_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim field As PivotGridField = TryCast(icbField.EditValue, PivotGridField)
            If field Is Nothing Then Return
            icbSummaryType.EditValue = field.SummaryType
            SetFieldFont(field)
            field.Appearance.ValueTotal.BackColor = Color.LightSkyBlue
        End Sub

        Private Sub SetFieldFont(ByVal field As PivotGridField)
            For Each fld As PivotGridField In pivotGridControl1.Fields
                If fld IsNot field Then
                    If fld.Appearance.Header.FontStyleDelta = FontStyle.Bold Then
                        fld.Appearance.Header.FontStyleDelta = FontStyle.Regular
                    End If
                Else
                    fld.Appearance.Header.FontStyleDelta = FontStyle.Bold
                End If
            Next
        End Sub

        '</icbField>
        '<icbSummaryType>
        Private Sub icbSummaryType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim field As PivotGridField = TryCast(icbField.EditValue, PivotGridField)
            If field Is Nothing Then Return
            field.SummaryType = CType(icbSummaryType.EditValue, PivotSummaryType)
            CorrectCellFormat(field)
        End Sub

        Private Sub CorrectCellFormat(ByVal field As PivotGridField)
            Select Case field.SummaryType
                Case PivotSummaryType.Average, PivotSummaryType.Max, PivotSummaryType.Min, PivotSummaryType.Sum, PivotSummaryType.Custom, PivotSummaryType.StdDev, PivotSummaryType.StdDevp
                    If field Is fieldDiscount Then
                        field.CellFormat.FormatString = "p"
                    ElseIf field Is fieldQuantity Then
                        field.CellFormat.FormatString = "n0"
                    Else
                        field.CellFormat.FormatString = "c2"
                    End If

                Case PivotSummaryType.Count, PivotSummaryType.Var, PivotSummaryType.Varp
                    field.CellFormat.FormatString = "n0"
                Case Else
                    Throw New ArgumentException("Incorrect SummaryType")
            End Select
        End Sub

        '</icbSummaryType>
        Private Sub pivotGridControl1_CustomDrawFieldHeader(ByVal sender As Object, ByVal e As PivotCustomDrawFieldHeaderEventArgs)
            If e.Field.Area = PivotArea.DataArea Then e.Appearance.ForeColor = Blue
            If Equals(e.Field.Caption, "Data") Then e.Appearance.ForeColor = Red
        End Sub

        Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As PivotFieldImageIndexEventArgs)
            If e.Field Is fieldCategoryName AndAlso Equals(e.ValueType, PivotGridValueType.Value) Then e.ImageIndex = GetCategoryIndexByName(e.Value)
        End Sub

        'Custom total - percent of max value in sum
        Private Sub pivotGridControl1_CustomSummary(ByVal sender As Object, ByVal e As PivotGridCustomSummaryEventArgs)
            Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
            Dim max As Decimal = 0, sum As Decimal = 0
            For Each row As PivotDrillDownDataRow In ds
                Dim value As Decimal = Convert.ToDecimal(row(e.DataField))
                max = If(max < value, value, max)
                sum += value
            Next

            If sum <> 0 Then
                e.CustomValue = max / sum * 100
            Else
                e.CustomValue = ""
            End If
        End Sub
    End Class

    Public Class CheckedListBoxElement
        Implements IComparable

        Public Property PropertyName As String

        Public Property DisplayName As String

        Public Sub New(ByVal descriptor As PropertyDescriptor)
            PropertyName = descriptor.Name
            DisplayName = String.Concat(CType(Enumerable.Select(Of Char, Global.System.[String])(descriptor.Name.Replace(CStr("Show"), CStr("")), CType(Function(x) CStr(If(Char.IsUpper(CChar(x)), " " & x, x.ToString())), Func(Of Char, String))), IEnumerable(Of String))).TrimStart(" "c)
        End Sub

        Public Overrides Function ToString() As String
            Return DisplayName
        End Function

        Public Function CompareTo(ByVal obj As Object) As Integer Implements IComparable.CompareTo
            Return PropertyName.CompareTo(CType(obj, CheckedListBoxElement).PropertyName)
        End Function
    End Class
End Namespace
