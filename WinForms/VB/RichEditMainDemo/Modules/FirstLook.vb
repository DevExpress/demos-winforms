Imports System
Imports System.Windows.Forms
Imports DevExpress.Office.Services
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit.API.Layout
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Demos.Forms
Imports DevExpress.XtraSpreadsheet.Services

Namespace DevExpress.XtraRichEdit.Demos

    Public Partial Class FirstLookModule
        Inherits TutorialControl

        Private _isZoomChanging As Boolean = False

        Private _pageCount As Integer = 1

        Private _currentPage As Integer = 1

        Private _includeTextBoxes As Boolean = False

        Private _documentEnd As Integer = -1

        Public Sub New()
            Call OfficeCharts.Instance.ActivateWinFormsCharts()
            InitializeComponent()
            Dim ribbonControl As RibbonControl = richEditControl.CreateRibbon()
            Controls.Add(ribbonControl)
            AppendCustomRibbonItems(ribbonControl)
        End Sub

        Public Overrides ReadOnly Property RichEdit As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property

        Private Property PageCount As Integer
            Get
                Return _pageCount
            End Get

            Set(ByVal value As Integer)
                If _pageCount = value Then Return
                _pageCount = value
                OnPagesInfoChanged()
            End Set
        End Property

        Private Property CurrentPage As Integer
            Get
                Return _currentPage
            End Get

            Set(ByVal value As Integer)
                If _currentPage = value Then Return
                _currentPage = value
                OnPagesInfoChanged()
            End Set
        End Property

        Private Property IncludeTextBoxes As Boolean
            Get
                Return _includeTextBoxes
            End Get

            Set(ByVal value As Boolean)
                If _includeTextBoxes = value Then Return
                _includeTextBoxes = value
                OnIncludeTextBoxesChanged()
            End Set
        End Property

#Region "AppendCustomRibbonItems"
        Private pagesBarItem As XtraBars.BarStaticItem

        Private zoomBarEditItem As XtraBars.BarEditItem

        Private documentStatisticsBarButtonItem As XtraBars.BarButtonItem

        Private repositoryItemZoomTrackBar1 As Repository.RepositoryItemZoomTrackBar

        Private Sub AppendCustomRibbonItems(ByVal ribbonControl1 As RibbonControl)
            pagesBarItem = New XtraBars.BarStaticItem()
            zoomBarEditItem = New XtraBars.BarEditItem()
            documentStatisticsBarButtonItem = New XtraBars.BarButtonItem()
            repositoryItemZoomTrackBar1 = New Repository.RepositoryItemZoomTrackBar()
            ribbonControl1.Items.AddRange(New XtraBars.BarItem() {pagesBarItem, zoomBarEditItem, documentStatisticsBarButtonItem})
            ribbonControl1.RepositoryItems.AddRange(New Repository.RepositoryItem() {repositoryItemZoomTrackBar1})
            ' 
            ' pagesBarItem
            ' 
            Dim superToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            pagesBarItem.Id = 246
            pagesBarItem.Name = "pagesBarItem"
            toolTipItem1.Text = "Page number in document."
            superToolTip1.Items.Add(toolTipItem1)
            pagesBarItem.SuperTip = superToolTip1
            ' 
            ' zoomBarEditItem
            ' 
            zoomBarEditItem.Alignment = XtraBars.BarItemLinkAlignment.Right
            zoomBarEditItem.Caption = "100%"
            zoomBarEditItem.Edit = repositoryItemZoomTrackBar1
            zoomBarEditItem.EditValue = 100
            zoomBarEditItem.EditWidth = 150
            zoomBarEditItem.Id = 245
            zoomBarEditItem.Name = "zoomBarEditItem"
            AddHandler zoomBarEditItem.EditValueChanged, New EventHandler(AddressOf zoomBarEditItem_EditValueChanged)
            ' 
            ' repositoryItemZoomTrackBar1
            ' 
            CType(repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            repositoryItemZoomTrackBar1.AllowUseMiddleValue = True
            repositoryItemZoomTrackBar1.LargeChange = 50
            repositoryItemZoomTrackBar1.Maximum = 500
            repositoryItemZoomTrackBar1.Middle = 100
            repositoryItemZoomTrackBar1.Minimum = 10
            repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1"
            repositoryItemZoomTrackBar1.SmallChange = 10
            repositoryItemZoomTrackBar1.SnapToMiddle = 2
            CType(repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
            ribbonStatusBar1.ItemLinks.Add(pagesBarItem)
            ribbonStatusBar1.ItemLinks.Add(zoomBarEditItem)
            ribbonStatusBar1.ItemLinks.Add(documentStatisticsBarButtonItem)
            ribbonStatusBar1.Ribbon = ribbonControl1
            ' 
            ' documentStatisticsBarButtonItem
            ' 
            Dim superToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            documentStatisticsBarButtonItem.Id = 247
            documentStatisticsBarButtonItem.Name = "documentStatisticsBarButtonItem"
            toolTipItem2.Text = "Number of words in document. Click to open the Document Statistics dialog box."
            superToolTip2.Items.Add(toolTipItem2)
            documentStatisticsBarButtonItem.SuperTip = superToolTip2
            AddHandler documentStatisticsBarButtonItem.ItemClick, New XtraBars.ItemClickEventHandler(AddressOf documentStatistics_ItemClick)
        End Sub

#End Region
        Private Sub FirstLookModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            AddHandler RichEdit.DocumentLayout.DocumentFormatted, AddressOf Me.DocumentLayout_DocumentFormatted
            RichEdit.HyphenationDictionaries.Add(New OpenOfficeHyphenationDictionary(DemoUtils.GetRelativePath("hyph_en_US.dic"), New Globalization.CultureInfo("en-US")))
            LoadDocument("FirstLook.docx")
        End Sub

        Private Sub DocumentLayout_DocumentFormatted(ByVal sender As Object, ByVal e As EventArgs)
            BeginInvoke(New Action(Sub()
                _documentEnd = RichEdit.Document.Range.End.ToInt()
                PageCount = RichEdit.DocumentLayout.GetPageCount()
            End Sub))
        End Sub

        Private Sub zoomBarEditItem_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _isZoomChanging Then Return
            Dim value As Integer = Convert.ToInt32(zoomBarEditItem.EditValue)
            _isZoomChanging = True
            Try
                RichEdit.ActiveView.ZoomFactor = value / 100F
                zoomBarEditItem.Caption = String.Format("{0}%", value)
            Finally
                _isZoomChanging = False
            End Try
        End Sub

        Private Sub richEditControl_ZoomChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _isZoomChanging Then Return
            Dim value As Integer = CInt(Math.Round(RichEdit.ActiveView.ZoomFactor * 100))
            _isZoomChanging = True
            Try
                zoomBarEditItem.EditValue = value
                zoomBarEditItem.Caption = String.Format("{0}%", value)
            Finally
                _isZoomChanging = False
            End Try
        End Sub

        Private Sub OnPagesInfoChanged()
            pagesBarItem.Caption = String.Format("PAGE {0} OF {1}", CurrentPage, PageCount)
        End Sub

        Private Sub OnIncludeTextBoxesChanged()
            CalculateDocumentStatistics()
        End Sub

        Private Sub richEditControl_VisiblePagesChanged(ByVal sender As Object, ByVal e As EventArgs)
            CurrentPage = RichEdit.ActiveView.GetVisiblePageLayoutInfos()(0).PageIndex + 1
        End Sub

        Private Sub richEditControl_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim isDocumentChanging As Boolean = _documentEnd <> RichEdit.Document.Range.End.ToInt()
            If isDocumentChanging Then Return
            Dim element As RangedLayoutElement = RichEdit.DocumentLayout.GetElement(Of RangedLayoutElement)(RichEdit.Document.CaretPosition)
            If element IsNot Nothing Then CurrentPage = RichEdit.DocumentLayout.GetPageIndex(element) + 1
        End Sub

        Private Sub documentStatistics_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            Using form As DocumentStatisticsForm = New DocumentStatisticsForm(RichEdit.Document, IncludeTextBoxes)
                form.LookAndFeel.ParentLookAndFeel = LookAndFeel
                form.ShowDialog()
                IncludeTextBoxes = form.IncludeTextboxes
            End Using
        End Sub

        Private Sub richEditControl_ContentChanged(ByVal sender As Object, ByVal e As EventArgs)
            documentStatisticsTimer.Start()
        End Sub

        Private Sub documentStatisticsTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            documentStatisticsTimer.Stop()
            BeginInvoke(New Action(AddressOf CalculateDocumentStatistics))
        End Sub

        Private Sub CalculateDocumentStatistics()
            Dim iterator As DocumentIterator = New DocumentIterator(RichEdit.Document, True)
            Dim visitor As StaticsticsVisitor = New StaticsticsVisitor(IncludeTextBoxes)
            While iterator.MoveNext()
                iterator.Current.Accept(visitor)
            End While

            documentStatisticsBarButtonItem.Caption = String.Format("{0} WORDS", visitor.WordCount)
        End Sub

        Private Sub richEditControl_InvalidFormatException(ByVal sender As Object, ByVal e As RichEditInvalidFormatExceptionEventArgs)
            XtraMessageBox.Show(String.Format("Cannot open the file '{0}' because the file format or file extension is not valid." & Microsoft.VisualBasic.Constants.vbLf & "Verify that file has not been corrupted and that the file extension matches the format of the file.", RichEdit.Options.DocumentSaveOptions.CurrentFileName), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub

        Private Sub richEditControl_DocumentClosing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            If RichEdit.Modified Then
                Dim currentFileName As String = RichEdit.Options.DocumentSaveOptions.CurrentFileName
                Dim message As String = If(Not String.IsNullOrEmpty(currentFileName), String.Format("Do you want to save the changes you made for '{0}'?", currentFileName), "Do you want to save the changes?")
                Dim result As DialogResult = XtraMessageBox.Show(message, "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    e.Cancel = Not RichEdit.SaveDocument()
                Else
                    e.Cancel = result = DialogResult.Cancel
                End If
            End If
        End Sub
    End Class
End Namespace
