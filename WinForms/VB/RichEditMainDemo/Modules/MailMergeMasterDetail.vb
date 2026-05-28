Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraRichEdit.API.Layout
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Demos.Modules.CustomDraw
Imports DevExpress.XtraRichEdit.Demos.Modules.MailMerge

Namespace DevExpress.XtraRichEdit.Demos

    Public Partial Class MailMergeMasterDetailModule
        Inherits MailMergeModuleBase

        Public Property HighlightRegions As Boolean

        Public Overrides ReadOnly Property RichEdit As RichEditControl
            Get
                Return templateRichEditControl
            End Get
        End Property

        Protected Overrides ReadOnly Property TopLevelRecordSelector As GridView
            Get
                Return recordSelectorCustomerView
            End Get
        End Property

        Private Property HighlightingEnabled As Boolean
            Get
                Return highlightingEnabledField
            End Get

            Set(ByVal value As Boolean)
                If highlightingEnabledField <> value Then
                    highlightingEnabledField = value
                    templateRichEditControl.Refresh()
                End If
            End Set
        End Property

        Private Shared ReadOnly regionHighlightType As CustomDrawHighlightType = CustomDrawHighlightType.Fill

        Private rootRegionInfo As MailMergeRegionInfo

        Private mailMergeOptions As MailMergeOptions

        Private regionHighlights As List(Of CustomDrawHighlightInfo) = New List(Of CustomDrawHighlightInfo)()

        Private highlightingEnabledField As Boolean

        Private hasValidResult As Boolean

        Private resultRichEditExceptionHandler As RichEditDemoExceptionsHandler

        Public Sub New()
            InitializeComponent()
            resultRichEditExceptionHandler = New RichEditDemoExceptionsHandler(templateRichEditControl)
            resultRichEditExceptionHandler.Install()
            templateRichEditControl.Options.MailMerge.ViewMergedData = False
            resultRichEditControl.Options.Fields.HighlightMode = FieldsHighlightMode.Never
            ribbonControl1.SelectedPage = ribbonControl1.Pages("Mail Merge")
            LoadDocument("MailMergeMasterDetail.docx")
            mailMergeOptions = templateRichEditControl.Document.CreateMailMergeOptions()
            AddHandler tabControl.SelectedPageChanging, AddressOf TabControl_SelectedPageChanging
            AddHandler tabControl.SelectedPageChanged, AddressOf TabControl_SelectedPageChanged
            AddHandler templateRichEditControl.Document.ContentChanged, AddressOf TemplateDocument_ContentChanged
            AddHandler recordSelectorCustomerView.SelectionChanged, AddressOf RecordSelectorCustomerView_SelectionChanged
            UpdateRegionHierarchy()
        End Sub

        Protected Overrides Sub FillDataSource(ByVal connection As OleDbConnection)
            LoadDb(connection)
            templateRichEditControl.Options.MailMerge.DataSource = nwindDataSetInstance
            templateRichEditControl.Options.MailMerge.DataMember = nwindDataSetInstance.Customers.TableName
            recordSelectorGridControl.DataSource = nwindDataSetInstance
            recordSelectorGridControl.DataMember = nwindDataSetInstance.Customers.TableName
        End Sub

        Private Sub LoadDb(ByVal connection As OleDbConnection)
            customersTableAdapter.Connection = connection
            customersTableAdapter.Fill(nwindDataSetInstance.Customers)
            ordersTableAdapter.Connection = connection
            ordersTableAdapter.Fill(nwindDataSetInstance.Orders)
            order_DetailsTableAdapter.Connection = connection
            order_DetailsTableAdapter.Fill(nwindDataSetInstance.Order_Details)
            productsTableAdapter.Connection = connection
            productsTableAdapter.Fill(nwindDataSetInstance.Products)
            Dim orderDetailsTable = nwindDataSetInstance.Order_Details
            Dim productNameCol = orderDetailsTable.Columns.Add(nwindDataSetInstance.Products.ProductNameColumn.ColumnName)
            For Each row As nwindDataSet.Order_DetailsRow In orderDetailsTable.Rows
                row(productNameCol) = nwindDataSetInstance.Products.FindByProductID(row.ProductID).ProductName
            Next
        End Sub

        Private Function RunMailMerge() As Boolean
            If hasValidResult Then Return True
            UpdateMailMergeOptions(Forms.MergeRecords.Selected, mailMergeOptions)
            Try
                templateRichEditControl.Document.MailMerge(mailMergeOptions, resultRichEditControl.Document)
                hasValidResult = True
                Return True
            Catch ex As Exception
                tabControl.SelectedTabPage = templateTabPage
                hasValidResult = False
                XtraMessageBox.Show($"Mail Merge failed:{Environment.NewLine} {ex.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Private Sub RecordSelectorCustomerView_SelectionChanged(ByVal sender As Object, ByVal e As Data.SelectionChangedEventArgs)
            hasValidResult = False
            If resultRichEditControl.Visible AndAlso Not RunMailMerge() Then tabControl.SelectedTabPage = templateTabPage
        End Sub

        Private Sub TemplateDocument_ContentChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateRegionHierarchy()
            hasValidResult = False
        End Sub

        Private Sub UpdateRegionHierarchy()
            Try
                rootRegionInfo = RichEdit.Document.GetRegionHierarchy(mailMergeOptions.RegionStartTag, mailMergeOptions.RegionEndTag)
            Catch
                rootRegionInfo = Nothing
            End Try

            regionHighlights.Clear()
            AddRegionHighlights(rootRegionInfo)
        End Sub

        Private Sub AddRegionHighlights(ByVal mailMergeRegionInfo As MailMergeRegionInfo)
            If mailMergeRegionInfo Is Nothing Then Return
            If mailMergeRegionInfo.ParentRegion IsNot Nothing Then
                Dim regionRange As FixedRange = GetRegionRange(mailMergeRegionInfo)
                Dim highlightColor As Color = GetHighlightColor(mailMergeRegionInfo)
                regionHighlights.Add(New CustomDrawHighlightInfo(regionRange, regionHighlightType, highlightColor))
            End If

            For Each childRegion In mailMergeRegionInfo.Regions
                AddRegionHighlights(childRegion)
            Next
        End Sub

        Private Function GetRegionRange(ByVal mailMergeRegionInfo As MailMergeRegionInfo) As FixedRange
            Dim regionStartFieldRange As DocumentRange = mailMergeRegionInfo.StartField.Range.GetAsFrozen()
            Dim regionEndFieldRange As DocumentRange = mailMergeRegionInfo.EndField.Range.GetAsFrozen()
            Dim regionLength As Integer = regionEndFieldRange.End.ToInt() - regionStartFieldRange.Start.ToInt()
            Return New FixedRange(regionStartFieldRange.Start.ToInt(), regionLength)
        End Function

        Private Shared Function GetHighlightColor(ByVal region As MailMergeRegionInfo) As Color
            If region.ParentRegion Is Nothing Then Return Color.Transparent
            Select Case region.Name
                Case "Orders"
                    Return Color.FromArgb(CByte(0.4 * 255), 129, 212, 250)
                Case "Order Details"
                    Return Color.FromArgb(CByte(1 * 255), 255, 106, 0)
                Case Else
                    Return Color.Brown
            End Select
        End Function

        Private Sub templateRichEditControl_BeforePagePaint(ByVal sender As Object, ByVal e As BeforePagePaintEventArgs)
            If Not HighlightingEnabled OrElse e.CanvasOwnerType = CanvasOwnerType.Printer OrElse regionHighlights.Count = 0 Then Return
            Dim visibleRegionHighlights = regionHighlights.Where(Function(rh) e.Page.IsRangeVisible(rh.HighlightRange)).ToList()
            Dim highlightPainter = New CustomDrawPagePainter(resultRichEditControl) With {.LayoutRowHighlights = visibleRegionHighlights}
            e.Painter = highlightPainter
        End Sub

        Private Sub highlightingEnabledBarItem_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim barItem = TryCast(sender, BarCheckItem)
            HighlightingEnabled = barItem.Checked
            If HighlightingEnabled AndAlso rootRegionInfo Is Nothing Then
                Try
                    rootRegionInfo = templateRichEditControl.Document.GetRegionHierarchy(mailMergeOptions.RegionStartTag, mailMergeOptions.RegionEndTag)
                Catch ex As Exception
                    HighlightingEnabled = False
                    barItem.Checked = False
                    XtraMessageBox.Show($"Regions are invalid:{Environment.NewLine} {ex.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub

        Private Sub TabControl_SelectedPageChanging(ByVal sender As Object, ByVal e As XtraTab.TabPageChangingEventArgs)
            If e.Page Is resultTabPage AndAlso Not RunMailMerge() Then
                e.Cancel = True
            End If
        End Sub

        Private Sub TabControl_SelectedPageChanged(ByVal sender As Object, ByVal e As XtraTab.TabPageChangedEventArgs)
            If e.Page Is templateTabPage Then
                richEditBarController1.RichEditControl = templateRichEditControl
                highlightRegionsBarItem.Enabled = True
            ElseIf e.Page Is resultTabPage Then
                richEditBarController1.RichEditControl = resultRichEditControl
                highlightRegionsBarItem.Enabled = False
            End If
        End Sub

        Private Sub mergeToNewDocumentItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            MergeToNewDocumentClick(sender, e)
        End Sub
    End Class
End Namespace
