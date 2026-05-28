Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DevExpress.AIIntegration.WinForms
Imports DevExpress.Data.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraLayout

Namespace DevExpress.AI.Demos

    Public Partial Class SmartPasteAIModule
        Inherits AITutorialControl

        Private Const LayoutCopyText As String = "Payment: Amount - $123.00
Statement Date: 10/15/2024
Account Number: 133244556
Name: John Smith
Contact: (123) 456-7890
Email: john@myemail.com
Address:
- 123 Elm St Apt 4B
- New York, NY 10001"

        Private Const GridCopyText As String = "Transactions 
- Hanari Carnes - Invoice amount due: $123.00, due by 10/30/2024. Status: Processed ✅
- Que Delicia - Amount: $231.00 | Due date: 10/29/2024 | Not processed yet 
- Romero y tomillo - $369.00 required by 10/28/2024, Processed ✅ 
- Mere Paillard - Payment: $158.00, due: 10/31/2024, unprocessed 
- Eastern Delights has an outstanding balance of $97.00, which was due on 10/27/2024. Status: Processed ✅ "

        Private Const SchedulerCopyText As String = "Weekly Meeting with Mike F. from the Marketing Department
Date & Time: Tomorrow at 3:30 PM (New York time)
Duration: 45 minutes
Location: Conference room, 33rd floor, HQ office
Topic: Finalizing the marketing budget for the new promo campaign

Agenda: 

- Share what was completed
- Discuss issues
- Review incomplete tasks/requirements 

Reminder: 1 hour before the meeting."

        Private colCompany As GridColumn

        Private colID As GridColumn

        Private colDate As GridColumn

        Private colPayment As GridColumn

        Private colProcessed As GridColumn

        Public Sub New()
            InitializeComponent()
            InitLayoutControl()
            tabPane1_SelectedPageIndexChanged(tabPane1, EventArgs.Empty)
            UpdatePaddings()
            schedulerDataStorage1.Resources.Add(1, "Meeting Room ""Falcon""")
            schedulerDataStorage1.Resources.Add(2, "Conference room")
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            gridControl1.ForceInitialize()
            InitGridControl()
        End Sub

        Protected Overrides Sub DoHide()
            behaviorManager1.GetBehavior(Of SmartPasteBehavior)(layoutControl1)?.CloseOverlayForm()
            behaviorManager1.GetBehavior(Of SmartPasteBehavior)(gridView1)?.CloseOverlayForm()
            behaviorManager1.GetBehavior(Of SmartPasteSchedulerBehavior)(schedulerControl1)?.CloseOverlayForm()
            MyBase.DoHide()
        End Sub

        Protected Overrides Sub UpdatePaddings()
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset)
        End Sub

        Private Sub InitLayoutControl()
            Dim lci As LayoutControlItem = Nothing, control As TextEdit = Nothing
            For Each item As BaseLayoutItem In layoutControl1.Items
                If CSharpImpl.__Assign(lci, TryCast(item, LayoutControlItem)) IsNot Nothing AndAlso CSharpImpl.__Assign(control, TryCast(lci.Control, TextEdit)) IsNot Nothing Then AddHandler control.KeyDown, AddressOf Me.LayoutControlProcessKeyDown
            Next

            '
            Dim itemsDescriptions = New List(Of AIItemDescription)() From {New AIItemDescription(layoutControlItem1, "The primary address line, which usually includes the street number and name (e.g., 123 Main St). Can include alphabetic and numeric characters."), New AIItemDescription(layoutControlItem2, "The secondary address line, which can include apartment or suite number (e.g., Apt 4B). This field is optional. Can include alphabetic and numeric characters."), New AIItemDescription(layoutControlItem3, "The city name. Only alphabetic characters are expected."), New AIItemDescription(layoutControlItem4, "The state, province, or region name or abbreviation. Only alphabetic characters are expected."), New AIItemDescription(layoutControlItem5, "The ZIP or postal code. Numeric characters and sometimes alphabetic characters (e.g., for Canadian postal codes) are expected."), New AIItemDescription(layoutControlItem6, "The first name of the recipient. Only alphabetic characters are expected."), New AIItemDescription(layoutControlItem7, "The last name of the recipient. Only alphabetic characters are expected."), New AIItemDescription(layoutControlItem8, "The phone number of the recipient in the format of (XXX) XXX-XXXX or similar. Only numeric characters and standard phone number formatting characters (e.g., parentheses, dashes, spaces) are expected."), New AIItemDescription(layoutControlItem10, "The email of the recipient.")}
            '
            Dim smartPasteBehavior = behaviorManager1.GetBehavior(Of SmartPasteBehavior)(layoutControl1)
            smartPasteBehavior.Properties.ItemDescriptions.AddRange(itemsDescriptions)
            layoutControl1.AllowCustomization = False
        End Sub

        Private Sub InitGridControl()
            gridControl1.DataSource = SmartPasteDataHelper.GetData(10)
            ' Obtain created columns.
            colCompany = gridView1.Columns("CompanyName")
            colCompany.Caption = "Company Name"
            colID = gridView1.Columns("ID")
            colDate = gridView1.Columns("DueDate")
            colDate.Caption = "Due Date"
            colPayment = gridView1.Columns("Amount")
            colPayment.Caption = "Amount"
            colProcessed = gridView1.Columns("Processed")
            colProcessed.Caption = "Processed"
            ' The Company column uses a ComboBox in-place editor that shows a list of available companies.
            Dim riComboBox As RepositoryItemComboBox = New RepositoryItemComboBox()
            riComboBox.Items.AddRange(SmartPasteDataHelper.companies)
            gridControl1.RepositoryItems.Add(riComboBox)
            colCompany.ColumnEdit = riComboBox
            ' Hide a column.
            colID.Visible = False
            AddHandler gridControl1.MainView.InvalidValueException, AddressOf ViewInvalidValueException
            AddHandler gridControl1.ProcessGridKey, AddressOf GridControlProcessKeyDown
            TryCast(gridControl1.MainView, GridView).FocusedRowHandle = 0
            Dim itemsDescriptions = New List(Of AIItemDescription)() From {New AIItemDescription(colPayment, "The total monetary value of the order, typically in USD."), New AIItemDescription(colDate, "The date by which the company expects the order to be fulfilled."), New AIItemDescription(colProcessed, "A Boolean value indicating whether the order has been processed.")}
            Dim smartPasteBehavior = behaviorManager1.GetBehavior(Of SmartPasteBehavior)(gridControl1.MainView)
            smartPasteBehavior.Properties.ItemDescriptions.AddRange(itemsDescriptions)
        End Sub

        Private Sub ViewInvalidValueException(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
            e.ExceptionMode = XtraEditors.Controls.ExceptionMode.Ignore
        End Sub

        Private Async Sub GridControlProcessKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyData = (Keys.Control Or Keys.Shift Or Keys.V) Then
                e.Handled = True
                Dim smartPasteBehavior = behaviorManager1.GetBehavior(Of SmartPasteBehavior)(gridControl1.MainView)
                Await smartPasteBehavior.SmartPasteAsync()
            End If
        End Sub

        Private Async Sub LayoutControlProcessKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyData = (Keys.Control Or Keys.Shift Or Keys.V) Then
                e.Handled = True
                Dim smartPasteBehavior = behaviorManager1.GetBehavior(Of SmartPasteBehavior)(layoutControl1)
                Await smartPasteBehavior.SmartPasteAsync()
            End If
        End Sub

        Private Sub simpleButtonCopy_Click(ByVal sender As Object, ByVal e As EventArgs)
            SafeClipboardWin.Instance.SetText(memoEdit1.Text)
        End Sub

        Private Async Sub simpleButtonPaste_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim smartPasteBehavior = behaviorManager1.GetBehavior(Of SmartPasteBehavior)(layoutControl1)
            Await smartPasteBehavior.SmartPasteAsync()
        End Sub

        Private Sub tabPane1_SelectedPageIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If tabPane1.SelectedPage Is layoutTabNavigationPage Then
                memoEdit1.Text = LayoutCopyText
            ElseIf tabPane1.SelectedPage Is gridTabNavigationPage Then
                memoEdit1.Text = GridCopyText
            Else
                memoEdit1.Text = SchedulerCopyText
            End If
        End Sub

        Private Class CSharpImpl

            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class

    Public Class Record
        Implements INotifyPropertyChanged

        Public Sub New()
        End Sub

        Private idField As Integer

        Public Property ID As Integer
            Get
                Return idField
            End Get

            Set(ByVal value As Integer)
                If idField <> value Then
                    idField = value
                    OnPropertyChanged()
                End If
            End Set
        End Property

        Private text As String

        <DisplayName("Company")>
        Public Property CompanyName As String
            Get
                Return text
            End Get

            Set(ByVal value As String)
                If Not Equals(text, value) Then
                    If String.IsNullOrEmpty(value) Then Throw New Exception()
                    text = value
                    OnPropertyChanged()
                End If
            End Set
        End Property

        Private val As Decimal?

        <DataType(System.ComponentModel.DataAnnotations.DataType.Currency)>
        <DisplayName("Payment")>
        Public Property Amount As Decimal?
            Get
                Return val
            End Get

            Set(ByVal value As Decimal?)
                If val <> value Then
                    val = value
                    OnPropertyChanged()
                End If
            End Set
        End Property

        Private dt As Date

        <DisplayFormat(DataFormatString:="d")>
        Public Property DueDate As Date
            Get
                Return dt
            End Get

            Set(ByVal value As Date)
                If dt <> value Then
                    dt = value
                    OnPropertyChanged()
                End If
            End Set
        End Property

        Private state As Boolean

        Public Property Processed As Boolean
            Get
                Return state
            End Get

            Set(ByVal value As Boolean)
                If state <> value Then
                    state = value
                    OnPropertyChanged()
                End If
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return String.Format("ID = {0}, Text = {1}", ID, CompanyName)
        End Function

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Sub OnPropertyChanged(<CallerMemberName> ByVal Optional propertyName As String = "")
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class

    Public Class SmartPasteDataHelper

        Public Shared companies As String() = New String() {"Hanari Carnes", "Que Delicia", "Romero y tomillo", "Mere Paillarde", "Comércio Mineiro", "Reggiani Caseifici", "Maison Dewey", "Eastern Delights"}

        Public Shared items As String() = New String() {"Office Chairs", "Laptops", "Printer Ink", "Tables", "Paper"}

        Public Shared Function GetData(ByVal count As Integer) As BindingList(Of Record)
            Dim records As BindingList(Of Record) = New BindingList(Of Record)()
            Dim rnd = NonCryptographicRandom.Default
            For i As Integer = 0 To count - 1
                Dim n As Integer = rnd.Next(10)
                Dim record = New Record() With {.ID = i + 100, .CompanyName = companies(i Mod companies.Length), .DueDate = Date.Today.AddDays(n - 5), .Amount = If(i Mod 2 = 0, (i + 1) * 123, i * 231), .Processed = i Mod 2 = 0}
                records.Add(record)
            Next

            Return records
        End Function
    End Class
End Namespace
