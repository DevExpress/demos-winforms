Imports System
Imports System.Drawing
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.DevAV.Modules

    Public Partial Class EmployeeMailMerge
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(EmployeeMailMergeViewModel))
            InitializeComponent()
            BindCommands()
            BindEditors()
            UpdateSelectTemplateUI()
            Dim tmp_ZoomLevelManager = New ZoomLevelManager(beZoomLevel, bbiZoomDialog, New RichEditZoomingModel(richEditControl))
            AddHandler ViewModel.MailTemplateChanged, AddressOf ViewModel_MailTemplateChanged
            AddHandler ViewModel.MailTemplateSelectedChanged, AddressOf ViewModel_MailTemplateSelectedChanged
            AddHandler ViewModel.Save, AddressOf ViewModel_Save
            AddHandler richEditControl.ModifiedChanged, AddressOf richEditControl_ModifiedChanged
        End Sub

        Protected Overrides Sub OnMVVMContextReleasing()
            RemoveHandler ViewModel.Save, AddressOf ViewModel_Save
            RemoveHandler ViewModel.MailTemplateChanged, AddressOf ViewModel_MailTemplateChanged
            RemoveHandler ViewModel.MailTemplateSelectedChanged, AddressOf ViewModel_MailTemplateSelectedChanged
        End Sub

        Protected Overrides Sub OnDisposing()
            RemoveHandler richEditControl.ModifiedChanged, AddressOf richEditControl_ModifiedChanged
            MyBase.OnDisposing()
        End Sub

        Private Sub ViewModel_Save(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl.SaveDocumentAs()
        End Sub

        Private Sub ViewModel_MailTemplateSelectedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateSelectTemplateUI()
        End Sub

        Private Sub ViewModel_MailTemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateEditor(ViewModel.MailTemplate.GetValueOrDefault())
        End Sub

        Private Sub UpdateEditor(ByVal mailTemplate As EmployeeMailTemplate)
            ViewModel.Modified = richEditControl.Modified
            cbMailTemplate.EditValue = mailTemplate
            LoadTemplate(mailTemplate)
            SynchronizeCurrentRecordWithRichEdit()
        End Sub

        Private Sub LoadTemplate(ByVal mailTemplate As EmployeeMailTemplate)
            Dim template As String =(mailTemplate.ToFileName() & ".docx")
            Using stream = GetTemplateStream(template)
                richEditControl.LoadDocumentTemplate(stream, XtraRichEdit.DocumentFormat.Rtf)
            End Using

            ribbonControl.ApplicationDocumentCaption = XtraEditors.EnumDisplayTextHelper.GetDisplayText(mailTemplate)
        End Sub

        Private Sub UpdateSelectTemplateUI()
            roundedSkinPanel2.Visible = Not ViewModel.IsMailTemplateSelected
            mailMergeRibbonPage1.Visible = Not ViewModel.IsMailTemplateSelected
        End Sub

        Public ReadOnly Property ViewModel As EmployeeMailMergeViewModel
            Get
                Return GetViewModel(Of EmployeeMailMergeViewModel)()
            End Get
        End Property

        Public ReadOnly Property CollectionViewModel As EmployeeCollectionViewModel
            Get
                Return GetParentViewModel(Of EmployeeCollectionViewModel)()
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal ea As EventArgs)
            MyBase.OnLoad(ea)
            CollectionViewModel.GetEntities()
            bindingSource.DataSource = CollectionViewModel.GetEntities()
            employeesList.DataSource = bindingSource.DataSource
            gridView.FocusedRowHandle = gridView.LocateByValue("Id", CollectionViewModel.SelectedEntity.Id)
            If richEditControl.Document.IsEmpty Then LoadTemplate(ViewModel.MailTemplate.GetValueOrDefault())
            richEditControl.Options.MailMerge.DataSource = bindingSource
            richEditControl.Options.MailMerge.ViewMergedData = True
            SynchronizeCurrentRecordWithRichEdit()
            ViewModel.Modified = richEditControl.Modified
        End Sub

        Private Sub BindCommands()
            biClose.BindCommand(Sub() ViewModel.Close(), ViewModel)
        End Sub

        Private Sub BindEditors()
            AddHandler employeesList.Load, Sub(s, e) SetFindControlImages(employeesList)
            AddHandler gridView.FocusedRowObjectChanged, AddressOf gridView_FocusedRowObjectChanged
            cbMailTemplate.Properties.Items.AddEnum(Of EmployeeMailTemplate)()
            cbMailTemplate.Properties.SmallImages = CreateSvgImageCollection()
            For Each item As XtraEditors.Controls.ImageComboBoxItem In cbMailTemplate.Properties.Items
                item.ImageIndex = CInt(CType(item.Value, EmployeeMailTemplate))
            Next

            cbMailTemplate.EditValue = ViewModel.MailTemplate.GetValueOrDefault()
            AddHandler cbMailTemplate.EditValueChanged, AddressOf cbMailTemplate_EditValueChanged
        End Sub

        Private Shared Function CreateSvgImageCollection() As SvgImageCollection
            Dim ret As SvgImageCollection = New SvgImageCollection()
            ret.ImageSize = New Size(16, 16)
            ret.Add(SvgImage.FromResources(GetFluentIconName("icon_employee_quick_award_16"), GetType(MainForm).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("icon_employee_quick_probation_notice_16"), GetType(MainForm).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("icon_employee_quick_excellence_16"), GetType(MainForm).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("icon_employee_quick_thank_16"), GetType(MainForm).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("icon_employee_quick_welcome_16"), GetType(MainForm).Assembly))
            Return ret
        End Function

        Private Shared Function CreateImageCollection() As ImageCollection
            Dim ret As ImageCollection = New ImageCollection()
            ret.ImageSize = New Size(16, 16)
            ret.AddImage(Properties.Resources.icon_employee_quick_thank_16)
            ret.AddImage(Properties.Resources.icon_employee_quick_probation_notice_16)
            ret.AddImage(Properties.Resources.icon_employee_quick_excellence_16)
            ret.AddImage(Properties.Resources.icon_employee_quick_award_16)
            ret.AddImage(Properties.Resources.icon_employee_quick_welcome_16)
            Return ret
        End Function

        Private Sub gridView_FocusedRowObjectChanged(ByVal sender As Object, ByVal e As FocusedRowObjectChangedEventArgs)
            SynchronizeCurrentRecordWithRichEdit()
        End Sub

        Private Sub SynchronizeCurrentRecordWithRichEdit()
            bindingSource.Position = gridView.GetDataSourceRowIndex(gridView.FocusedRowHandle)
        End Sub

        Private Sub cbMailTemplate_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ViewModel.MailTemplate = CType(cbMailTemplate.EditValue, EmployeeMailTemplate)
        End Sub

        Private Sub richEditControl_ModifiedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ViewModel.Modified = richEditControl.Modified
        End Sub

#Region ""
        Private ReadOnly Property Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property

#End Region
#Region "IZoomViewModel Members"
        Private Class RichEditZoomingModel
            Implements IZoomViewModel, ISupportZoom

            Private ReadOnly Property ZoomModule As Object Implements IZoomViewModel.ZoomModule
                Get
                    Return Me
                End Get
            End Property

            Private Custom Event ZoomModuleChanged As EventHandler Implements IZoomViewModel.ZoomModuleChanged
                AddHandler(ByVal value As EventHandler)
                End AddHandler

                RemoveHandler(ByVal value As EventHandler)
                End RemoveHandler

                RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
                End RaiseEvent
            End Event

            Private richEditControl As XtraRichEdit.RichEditControl

            Public Sub New(ByVal richEditControl As XtraRichEdit.RichEditControl)
                Me.richEditControl = richEditControl
                If richEditControl IsNot Nothing Then AddHandler richEditControl.ZoomChanged, AddressOf richEditControl_ZoomChanged
            End Sub

            Private Sub richEditControl_ZoomChanged(ByVal sender As Object, ByVal e As EventArgs)
                RaiseZoomChanged()
            End Sub

            Private Property ZoomLevel As Integer Implements ISupportZoom.ZoomLevel
                Get
                    Return CInt(Math.Ceiling(richEditControl.ActiveView.ZoomFactor * 100.0F))
                End Get

                Set(ByVal value As Integer)
                    richEditControl.ActiveView.ZoomFactor =(CSng(value)) / 100.0F
                End Set
            End Property

            Public Event ZoomChanged As EventHandler Implements ISupportZoom.ZoomChanged

            Private Sub RaiseZoomChanged()
                Dim handler As EventHandler = ZoomChangedEvent
                If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
            End Sub
        End Class
#End Region
    End Class
End Namespace
