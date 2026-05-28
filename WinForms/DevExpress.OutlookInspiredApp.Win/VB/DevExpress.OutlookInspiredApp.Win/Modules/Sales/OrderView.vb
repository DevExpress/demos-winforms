Imports System
Imports DevExpress.DevAV
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraBars
Imports DevExpress.XtraRichEdit.API.Native
Imports System.ComponentModel
Imports DevExpress.DevAV.Common.Utils

Namespace DevExpress.DevAV.Modules

    Public Partial Class OrderView
        Inherits BaseModuleControl

        Public Sub New()
            MyBase.New(GetType(SynchronizedOrderViewModel))
            InitializeComponent()
            TitleLabel.Appearance.ForeColor = DisabledTextColor
            ItemForTitleLabel.AppearanceItemCaption.ForeColor = DisabledTextColor
            ItemForTitleLabel.AppearanceItemCaption.Options.UseForeColor = True
            modueLayout.Visible = False
            richEditControl.BackColor = GetControlColor(LookAndFeel)
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            AddHandler richEditControl.ZoomChanged, AddressOf richEditControl_ZoomChanged
            AddHandler richEditControl.CalculateDocumentVariable, AddressOf documentServer_CalculateDocumentVariable
            SwapFluentIcons(Me)
        End Sub

        Protected Overrides Sub OnMVVMContextReleasing()
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
        End Sub

        Protected Overrides Sub OnDisposing()
            RemoveHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            RemoveHandler richEditControl.ZoomChanged, AddressOf richEditControl_ZoomChanged
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As OrderViewModel
            Get
                Return GetViewModel(Of OrderViewModel)()
            End Get
        End Property

        Private Sub BindCommands()
            Dim fluentAPI = mvvmContext.OfType(Of OrderViewModel)()
            fluentAPI.SetBinding(paidBBI, Function(x) x.Caption, Function(x) x.MarkPaidToolTip)
            fluentAPI.SetBinding(refundBBI, Function(x) x.Caption, Function(x) x.IssueFullRefundToolTip)
            editBBI.BindCommand(Sub() ViewModel.Edit(), ViewModel)
            deleteBBI.BindCommand(Sub() ViewModel.Delete(), ViewModel)
            emailBBI.BindCommand(Sub() ViewModel.MailTo(), ViewModel)
            printBBI.BindCommand(Sub() ViewModel.Print(), ViewModel)
            paidBBI.BindCommand(Sub() ViewModel.MarkPaid(), ViewModel)
            refundBBI.BindCommand(Sub() ViewModel.IssueFullRefund(), ViewModel)
        End Sub

        Private Sub ViewModel_EntityChanged(ByVal sender As Object, ByVal e As EventArgs)
            QueueUIUpdate()
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl.BackColor = GetControlColor(LookAndFeel)
        End Sub

        Protected Overrides Function GetUIUpdateDelay() As Integer
            Return 500
        End Function

        Protected Overrides Sub OnDelayedUIUpdate()
            MyBase.OnDelayedUIUpdate()
            UpdateUI(ViewModel.Entity)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            BindCommands()
            LoadOrderTemplate()
            UpdateUI(ViewModel.Entity)
        End Sub

        Private Sub LoadOrderTemplate()
            If Not richEditControl.Document.IsEmpty Then Return
            Using stream = GetTemplateStream("Order.docx")
                richEditControl.LoadDocumentTemplate(stream, DocumentFormat.OpenXml)
            End Using

            AddHandler richEditControl.DocumentLayout.DocumentFormatted, AddressOf Me.DocumentLayout_DocumentFormatted
            richEditControl.Options.MailMerge.DataSource = bindingSource
            richEditControl.Options.MailMerge.ViewMergedData = True
            richEditControl.ActiveView.ZoomFactor -= richEditControl.ActiveView.ZoomFactor / 4F
        End Sub

        Private Sub documentServer_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            Dim order As Order = TryCast(bindingSource.DataSource, Order)
            If order Is Nothing Then Return
            Select Case e.VariableName
                Case "OrderItems"
                    Dim targetDocumentServer = richEditControl.CreateDocumentServer()
                    Using sourceDocumentServer = richEditControl.CreateDocumentServer()
                        Using stream = GetTemplateStream("OrderItemsTemplate.docx")
                            sourceDocumentServer.LoadDocumentTemplate(stream, DocumentFormat.OpenXml)
                        End Using

                        sourceDocumentServer.Options.MailMerge.DataSource = order.OrderItems
                        Dim options As MailMergeOptions = sourceDocumentServer.Document.CreateMailMergeOptions()
                        options.MergeMode = MergeMode.JoinTables
                        sourceDocumentServer.MailMerge(options, targetDocumentServer.Document)
                    End Using

                    e.PreserveInsertedContentFormatting = True
                    e.KeepLastParagraph = False
                    e.Value = targetDocumentServer
                    e.Handled = True
                Case "Total"
                    e.Value = order.OrderItems.CustomSum(Function(x) x.Total)
                    e.Handled = True
                Case "TotalDue"
                    e.Value = order.OrderItems.CustomSum(Function(x) x.Total) + order.ShippingAmount
                    e.Handled = True
            End Select
        End Sub

        Private Sub DocumentLayout_DocumentFormatted(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As PrintLayoutView = TryCast(richEditControl.ActiveView, PrintLayoutView)
            If view IsNot Nothing Then richEditControl.BeginInvoke(New Action(AddressOf view.FitToPage))
        End Sub

        Private Sub richEditControl_ZoomChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseZoomLevelChanged()
        End Sub

        Private Sub UpdateUI(ByVal order As Order)
            If order IsNot Nothing Then
                If Not Equals(bindingSource.DataSource, order) Then
                    bindingSource.DataSource = order
                Else
                    bindingSource.ResetBindings(False)
                End If

                richEditControl.Document.Fields.Update()
            End If

            modueLayout.Visible = order IsNot Nothing
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property ZoomLevel As Integer
            Get
                Return CInt(Math.Ceiling(richEditControl.ActiveView.ZoomFactor * 100.0F))
            End Get

            Set(ByVal value As Integer)
                If ZoomLevel = value Then Return
                richEditControl.ActiveView.ZoomFactor =(CSng(value)) / 100.0F
            End Set
        End Property

        Public ReadOnly Property MovePrevButton As BarButtonItem
            Get
                Return previousBBI
            End Get
        End Property

        Public ReadOnly Property MoveNextButton As BarButtonItem
            Get
                Return nextBBI
            End Get
        End Property

        Public Event ZoomLevelChanged As EventHandler

        Private Sub RaiseZoomLevelChanged()
            Dim handler As EventHandler = ZoomLevelChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub
    End Class
End Namespace
