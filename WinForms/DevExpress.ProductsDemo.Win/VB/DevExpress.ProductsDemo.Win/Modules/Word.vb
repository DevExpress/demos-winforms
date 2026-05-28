Imports DevExpress.Internal
Imports DevExpress.MailClient.Win
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraRichEdit

Namespace DevExpress.ProductsDemo.Win.Modules
    Partial Public Class WordModule
        Inherits BaseModule
        Private Const fileName As String = "MailMerge.docx"
        Public Sub New()
            InitializeComponent()
            Dim path As String = DataDirectoryHelper.GetDataFile(fileName)
            If String.IsNullOrEmpty(path) Then
                Return
            End If

            Dim data = DataHelper.Contacts
            Me.richEditControl.Options.MailMerge.DataSource = data
            Me.richEditControl.Options.MailMerge.ViewMergedData = True
            richEditControl.LoadDocument(path, DocumentFormat.OpenXml)
            Call (New RichEditDemoExceptionsHandler(richEditControl)).Install()
            gridControl1.DataSource = data
            view_FocusedRowChanged(Nothing, Nothing)
        End Sub
        Protected Overrides Property AutoMergeRibbon() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.AutoMergeRibbon = value
            End Set
        End Property
        Private Sub view_FocusedRowChanged(ByVal sender As Object, ByVal e As XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles view.FocusedRowChanged
            richEditControl.Options.MailMerge.ActiveRecord = view.ViewRowHandleToDataSourceIndex(view.FocusedRowHandle)
        End Sub
        Private Sub richEditControl_StartHeaderFooterEditing(ByVal sender As Object, ByVal e As XtraRichEdit.HeaderFooterEditingEventArgs) Handles richEditControl.StartHeaderFooterEditing
            headerFooterToolsRibbonPageCategory1.Visible = True
            ribbonControl1.SelectedPage = headerFooterToolsDesignRibbonPage1
        End Sub
        Private Sub richEditControl_FinishHeaderFooterEditing(ByVal sender As Object, ByVal e As XtraRichEdit.HeaderFooterEditingEventArgs) Handles richEditControl.FinishHeaderFooterEditing
            headerFooterToolsRibbonPageCategory1.Visible = False
        End Sub
        Private Sub richEditControl_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.SelectionChanged
            tableToolsRibbonPageCategory1.Visible = richEditControl.IsSelectionInTable()
            floatingPictureToolsRibbonPageCategory1.Visible = richEditControl.IsFloatingObjectSelected
        End Sub
        Public Overrides ReadOnly Property PrintableComponent() As IPrintable
            Get
                Return Me.richEditControl
            End Get
        End Property
        Public Overrides ReadOnly Property ExportComponent() As IPrintable
            Get
                Return Me.richEditControl
            End Get
        End Property
        Public Overrides ReadOnly Property AllowRtfTitle() As Boolean
            Get
                Return False
            End Get
        End Property
        Friend Overrides Sub ShowModule(ByVal firstShow As Boolean)
            MyBase.ShowModule(firstShow)
            MainRibbon.SelectedPage = MainRibbon.MergedPages.GetPageByName(homeRibbonPage1.Name)
        End Sub
    End Class
End Namespace
