Imports System
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit

Namespace DevExpress.DevAV.Modules

    Public Partial Class OrderMailMerge
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(OrderMailMergeViewModel))
            InitializeComponent()
            BindCommands()
            UpdateUI()
            AddHandler ViewModel.MailTemplateChanged, AddressOf ViewModel_MailTemplateChanged
            AddHandler ViewModel.MailTemplateSelectedChanged, AddressOf ViewModel_MailTemplateSelectedChanged
            AddHandler ViewModel.PeriodChanged, AddressOf ViewModel_PeriodChanged
            AddHandler ViewModel.Save, AddressOf ViewModel_Save
            ViewModel.Modified = richEditControl.Modified
            AddHandler richEditControl.ModifiedChanged, AddressOf richEditControl_ModifiedChanged
            AddHandler richEditControl.CalculateDocumentVariable, AddressOf documentServer_CalculateDocumentVariable
        End Sub

        Private Sub documentServer_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            If Equals(e.VariableName, "OrderDetail") Then
                Dim targetDocumentServer = richEditControl.CreateDocumentServer()
                Using sourceDocumentServer = richEditControl.CreateDocumentServer()
                    sourceDocumentServer.Options.MailMerge.DataSource = CollectionViewModel.SelectedEntity.OrderItems
                    Dim bulletedList As NumberingList = CreateNumberingList(sourceDocumentServer)
                    Dim filed As Field = sourceDocumentServer.Document.Fields.Create(sourceDocumentServer.Document.CreatePosition(0), "MERGEFIELD Product.Name")
                    sourceDocumentServer.Document.Paragraphs.AddParagraphsToList(filed.Range, bulletedList, 0)
                    sourceDocumentServer.MailMerge(targetDocumentServer.Document)
                End Using

                e.KeepLastParagraph = True
                e.Value = targetDocumentServer
                e.Handled = True
            End If
        End Sub

        Private Function CreateNumberingList(ByVal sourceDocumentServer As IRichEditDocumentServer) As NumberingList
            Dim list As AbstractNumberingList = sourceDocumentServer.Document.AbstractNumberingLists.Add()
            list.NumberingType = NumberingType.Bullet
            Dim level As ListLevel = list.Levels(0)
            level.ParagraphProperties.LeftIndent = 150
            level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
            level.ParagraphProperties.FirstLineIndent = 75
            level.CharacterProperties.FontName = "Symbol"
            level.DisplayFormatString = New String("·"c, 1)
            Return sourceDocumentServer.Document.NumberingLists.Add(0)
        End Function

        Protected Overrides Sub OnMVVMContextReleasing()
            RemoveHandler ViewModel.Save, AddressOf ViewModel_Save
            RemoveHandler ViewModel.PeriodChanged, AddressOf ViewModel_PeriodChanged
            RemoveHandler ViewModel.MailTemplateChanged, AddressOf ViewModel_MailTemplateChanged
            RemoveHandler ViewModel.MailTemplateSelectedChanged, AddressOf ViewModel_MailTemplateSelectedChanged
        End Sub

        Protected Overrides Sub OnDisposing()
            RemoveHandler richEditControl.ModifiedChanged, AddressOf richEditControl_ModifiedChanged
            MyBase.OnDisposing()
        End Sub

        Private Sub ViewModel_MailTemplateSelectedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateUI()
        End Sub

        Private Sub ViewModel_MailTemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateUI()
            ShowReport()
        End Sub

        Private Sub ViewModel_PeriodChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ViewModel.MailTemplate.GetValueOrDefault() = SalesReportType.SalesReport Then GenerateReport()
        End Sub

        Private Sub LoadTemplate(ByVal document As Document, ByVal mailTemplate As SalesReportType)
            Dim template As String =(mailTemplate.ToFileName() & ".docx")
            Using stream = GetTemplateStream(template)
                document.LoadDocument(stream, DocumentFormat.OpenXml)
            End Using

            ribbonControl.ApplicationDocumentCaption = XtraEditors.EnumDisplayTextHelper.GetDisplayText(mailTemplate)
            ViewModel.Modified = richEditControl.Modified
            richEditControl.Options.MailMerge.DataSource = bindingSource
            richEditControl.Options.MailMerge.ViewMergedData = True
        End Sub

        Private Sub UpdateUI()
            mailMergeRibbonPage1.Visible = Not ViewModel.IsMailTemplateSelected
            rpbReportRange.Visible = ViewModel.IsMailTemplateSelected AndAlso ViewModel.MailTemplate.GetValueOrDefault() = SalesReportType.SalesReport
        End Sub

        Public ReadOnly Property ViewModel As OrderMailMergeViewModel
            Get
                Return GetViewModel(Of OrderMailMergeViewModel)()
            End Get
        End Property

        Public ReadOnly Property CollectionViewModel As OrderCollectionViewModel
            Get
                Return GetParentViewModel(Of OrderCollectionViewModel)()
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal ea As EventArgs)
            MyBase.OnLoad(ea)
            bindingSource.DataSource = CollectionViewModel.SelectedEntity
            If richEditControl.Document.IsEmpty Then ShowReport()
        End Sub

        Private Sub ShowReport()
            bindingSource.DataSource = CollectionViewModel.SelectedEntity
            Select Case ViewModel.MailTemplate.GetValueOrDefault()
                Case SalesReportType.SalesReport
                    richEditControl.Options.MailMerge.DataSource = CollectionViewModel.GetOrderItems()
                    GenerateReport()
                Case SalesReportType.SalesByStore
                    richEditControl.Options.MailMerge.DataSource = CollectionViewModel.GetOrderItems(CollectionViewModel.SelectedEntity.StoreId)
                    GenerateReport()
                Case SalesReportType.Invoice, SalesReportType.OrderFollowUp
                    LoadTemplate(richEditControl.Document, ViewModel.MailTemplate.GetValueOrDefault())
                    richEditControl.Options.MailMerge.DataSource = bindingSource
            End Select
        End Sub

        Private Sub GenerateReport()
            richEditControl.BeginUpdate()
            LoadTemplate(richEditControl.Document, ViewModel.MailTemplate.GetValueOrDefault())
            richEditControl.EndUpdate()
            ViewModel.Modified = richEditControl.Modified
        End Sub

        Private Sub BindCommands()
            biClose.BindCommand(Sub() ViewModel.Close(), ViewModel)
            bbiThisMonth.BindCommand(Sub() ViewModel.SetThisMonthPeriod(), ViewModel)
            bbiPrevMonth.BindCommand(Sub() ViewModel.SetLastMonthPeriod(), ViewModel)
        End Sub

        Private Sub richEditControl_ModifiedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ViewModel.Modified = richEditControl.Modified
        End Sub

        Private Sub ViewModel_Save(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl.SaveDocumentAs()
        End Sub

#Region ""
        Private ReadOnly Property Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
#End Region
    End Class
End Namespace
