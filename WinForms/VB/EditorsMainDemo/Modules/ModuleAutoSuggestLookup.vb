Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization
Imports DevExpress.Data
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleAutoSuggestLookup
        Inherits TutorialControl

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleAutoSuggestLookup"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "autosuggestlookup"
            End Get
        End Property

        Protected Overrides Sub CalcContentCore()
            If tablePanel1 IsNot Nothing Then tablePanel1.Height = dataLayoutControl1.Root.MinSize.Height + dataLayoutControl1.Margin.Vertical
            CalcTablePanelBounds(tablePanel1)
        End Sub

        Public Sub New()
            InitializeComponent()
            contactInformationBindingSource.DataSource = New ContactInformation With {.FirstName = "Margaret", .LastName = "Boxter", .Email = "margaretb@dx-email.com", .Phone = "7145550827"}
            orderInfoBindingSource.DataSource = New List(Of OrderInfo) From {New OrderInfo With {.ProductName = "DX-H6000 27"" 4K MONITOR", .Quantity = 3, .Price = 425}, New OrderInfo With {.ProductName = "DX-H5000 24"" 4K MONITOR", .Quantity = 2, .Price = 327}}
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            DeliveryAddressLookup.Focus()
        End Sub

        ' <DeliveryAddressLookup>
        Private Sub OnAutoSuggest(ByVal sender As Object, ByVal e As LookUpEditAutoSuggestEventArgs)
            ' Set delay (if needed)
            e.SetMinimumAnimationDuration(TimeSpan.FromMilliseconds(1000))
            ' Set Custom Highlight Strategy
            e.SetHighlightRanges(HighlightTags(e.Text))
            ' Create a Task that return suggestions
            e.QuerySuggestions = QueryAsync(e.Text, e.CancellationToken)
        End Sub

        ' </DeliveryAddressLookup>
        Private Sub OnCustomDrawCell(ByVal sender As Object, ByVal e As LookUpCustomDrawCellArgs)
            e.DrawHtmlText(GetHtmlText(e.Row))
            e.Handled = True
        End Sub

        Private Sub OnEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim selectedEntry = CType(sender, LookUpEditBase).EditValue
            entryBindingSource.DataSource = If(selectedEntry, GetType(Entry))
            If selectedEntry IsNot Nothing Then
                validationHint1.Properties.State = Nothing
            Else
                validationHint1.Properties.State = Utils.VisualEffects.ValidationHintState.Invalid
            End If
        End Sub

        Private total As Decimal

        Private Sub OnCustomSummaryCalculate(ByVal sender As Object, ByVal e As CustomSummaryEventArgs)
            Select Case e.SummaryProcess
                Case CustomSummaryProcess.Start
                    total = 0
                Case CustomSummaryProcess.Calculate
                    Dim orderInfo = TryCast(e.Row, OrderInfo)
                    total += orderInfo.Quantity * orderInfo.Price
                Case CustomSummaryProcess.Finalize
                    e.TotalValue = total
            End Select
        End Sub

        Private Shared Function HighlightTags(ByVal pattern As String) As Func(Of String, String, DisplayTextHighlightRange())
            Dim indexOf = IgnoreCaseComparisonFunctions.GetIndexOf(CultureInfo.CurrentCulture.CompareInfo, CompareOptions.IgnoreCase)
            Dim parts = pattern.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
            Return Function(displayText, fieldName)
                Dim tags = displayText.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)
                Dim ranges = New List(Of DisplayTextHighlightRange)()
                For i As Integer = 1 To tags.Length - 1
                    Dim tagStart As Integer = displayText.IndexOf(tags(i))
                    For j As Integer = 0 To parts.Length - 1
                        Dim index As Integer = indexOf(tags(i), parts(j))
                        If index <> -1 Then ranges.Add(New DisplayTextHighlightRange(tagStart + index, parts(j).Length))
                    Next
                Next

                Return ranges.ToArray()
            End Function
        End Function
    End Class

    '
    Public Class ContactInformation

        <EmailAddress, DataType(DataType.EmailAddress)>
        Public Property Email As String

        <Required, MinLength(3)>
        Public Property FirstName As String

        <Required, MinLength(3)>
        Public Property LastName As String

        Public Property DeliveryAddress As String

        <Phone, DataType(DataType.PhoneNumber)>
        Public Property Phone As String
    End Class

    Public Class OrderInfo

        Public Property ProductName As String

        Public Property Quantity As Integer

        <DataType(DataType.Currency)>
        Public Property Price As Decimal
    End Class
End Namespace
