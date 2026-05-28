Imports System.Windows.Forms
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraEditors

Namespace DevExpress.DevAV.Modules

    Public Partial Class EmployeeEditView
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(EmployeeViewModel))
            InitializeComponent()
            GalleryItemAppearances.Apply(galleryQuickLetters)
            BindCommands()
            BindEditors()
            gvEvaluations.OptionsView.ShowPreview = False
            gvTasks.OptionsView.ShowPreview = False
            SwapFluentIcons(Me)
        End Sub

        Public ReadOnly Property ViewModel As EmployeeViewModel
            Get
                Return GetViewModel(Of EmployeeViewModel)()
            End Get
        End Property

        Public ReadOnly Property CollectionViewModel As EmployeeCollectionViewModel
            Get
                Return GetParentViewModel(Of EmployeeCollectionViewModel)()
            End Get
        End Property

        Protected Overrides Sub OnParentViewModelAttached()
            BindCollectionViewCommands()
        End Sub

        Private Sub BindCommands()
            Dim fluent = mvvmContext.OfType(Of EmployeeViewModel)()
            fluent.BindCommand(biSave, Sub(x) x.Save())
            fluent.BindCommand(biClose, Sub(x) x.Close())
            fluent.BindCommand(biSaveAndClose, Sub(x) x.SaveAndClose())
            fluent.BindCommand(biDelete, Sub(x) x.Delete())
            fluent.BindCommand(biRefresh, Sub(x) x.Reset())
        End Sub

        Private Sub BindCollectionViewCommands()
            Dim fluent = mvvmContext.OfType(Of EmployeeViewModel)()
            fluent.BindCommand(biShowMap, Sub(x) x.ShowMap())
            fluent.BindCommand(bmiPrintProfile, Sub(x) x.Print(EmployeeReportType.None), Function(x) EmployeeReportType.Profile)
            fluent.BindCommand(bmiPrintSummary, Sub(x) x.Print(EmployeeReportType.None), Function(x) EmployeeReportType.Summary)
            fluent.BindCommand(bmiPrintDirectory, Sub(x) x.Print(EmployeeReportType.None), Function(x) EmployeeReportType.Directory)
            fluent.BindCommand(bmiPrintTaskList, Sub(x) x.Print(EmployeeReportType.None), Function(x) EmployeeReportType.TaskList)
            fluent.BindCommand(biMailMerge, Sub(x) x.MailMerge())
            fluent.BindCommand(GalleryQuickLetterItem(0), Sub(x) x.QuickLetter(Nothing), Function(x) EmployeeMailTemplate.ThankYouNote)
            fluent.BindCommand(GalleryQuickLetterItem(1), Sub(x) x.QuickLetter(Nothing), Function(x) EmployeeMailTemplate.EmployeeOfTheMonth)
            fluent.BindCommand(GalleryQuickLetterItem(2), Sub(x) x.QuickLetter(Nothing), Function(x) EmployeeMailTemplate.ServiceExcellence)
            fluent.BindCommand(GalleryQuickLetterItem(3), Sub(x) x.QuickLetter(Nothing), Function(x) EmployeeMailTemplate.ProbationNotice)
            fluent.BindCommand(GalleryQuickLetterItem(4), Sub(x) x.QuickLetter(Nothing), Function(x) EmployeeMailTemplate.WelcomeToDevAV)
            fluent.BindCommand(biMeeting, Sub(x) x.ShowMeeting())
            fluent.BindCommand(biTask, Sub(x) x.ShowTask())
        End Sub

        Private Function GalleryQuickLetterItem(ByVal index As Integer) As XtraBars.Ribbon.GalleryItem
            Return galleryQuickLetters.Gallery.Groups(0).Items(index)
        End Function

        Private Sub BindEditors()
            StatusImageComboBoxEdit.Properties.Items.AddEnum(Of EmployeeStatus)()
            Call EditorHelpers.CreatePersonPrefixImageComboBox(PrefixImageComboBoxEdit.Properties, Nothing)
            colPriority.ColumnEdit = EditorHelpers.CreateTaskPriorityImageComboBox(Nothing, gridControlTasks.RepositoryItems)
            DepartmentImageComboBoxEdit.Properties.Items.AddEnum(Of EmployeeDepartment)()
            StateImageComboBoxEdit.Properties.Items.AddEnum(Of StateEnum)()
            ZipCodeTextEdit.DataBindings.Add(New Binding("EditValue", bindingSource, "Address.ZipCode", True, DataSourceUpdateMode.OnPropertyChanged))
            StateImageComboBoxEdit.DataBindings.Add(New Binding("EditValue", bindingSource, "Address.State", True, DataSourceUpdateMode.OnPropertyChanged))
            CityTextEdit.DataBindings.Add(New Binding("EditValue", bindingSource, "Address.City", True, DataSourceUpdateMode.OnPropertyChanged))
            AddressTextEdit.DataBindings.Add(New Binding("EditValue", bindingSource, "Address.Line", True, DataSourceUpdateMode.OnPropertyChanged))
            Dim fluent = mvvmContext.OfType(Of EmployeeViewModel)()
            fluent.BindCommand(ContactButton(MobilePhoneTextEdit), Sub(x) x.Contacts.MobileCall())
            fluent.BindCommand(ContactButton(HomePhoneTextEdit), Sub(x) x.Contacts.HomeCall())
            fluent.BindCommand(ContactButton(EmailTextEdit), Sub(x) x.Contacts.MailTo())
            fluent.BindCommand(ContactButton(SkypeTextEdit), Sub(x) x.Contacts.VideoCall())
            fluent.SetBinding(ribbonControl, Function(r) r.ApplicationDocumentCaption, Function(x) x.Title)
            fluent.SetObjectDataSourceBinding(bindingSource, Function(x) x.Entity, Sub(x) x.Update())
            For Each control As Control In moduleDataLayout.Controls
                Dim edit As BaseEdit = TryCast(control, BaseEdit)
                If edit Is Nothing OrElse edit.DataBindings.Count = 0 Then Continue For
                Call EditorHelpers.ApplyBindingSettings(Of Employee)(edit, moduleDataLayout)
            Next

            AddHandler FirstNameTextEdit.EditValueChanged, Sub(s, e) QueueFullNameUpdate()
            AddHandler LastNameTextEdit.EditValueChanged, Sub(s, e) QueueFullNameUpdate()
            AddHandler FullNameTextEdit.EditValueChanged, Sub(s, e) QueueFullNameUpdate()
        End Sub

        Private Function ContactButton(ByVal edit As ButtonEdit, ByVal Optional index As Integer = 0) As XtraEditors.Controls.EditorButton
            Return edit.Properties.Buttons(index)
        End Function

        Private fullNameUpdateQueued As Integer = 0

        Private Sub QueueFullNameUpdate()
            If 0 = fullNameUpdateQueued Then
                fullNameUpdateQueued += 1
                BeginInvoke(New MethodInvoker(AddressOf UpdateFullNameEditValue))
            Else
                fullNameUpdateQueued += 1
            End If
        End Sub

        Private Sub UpdateFullNameEditValue()
            FullNameTextEdit.DataBindings("EditValue").ReadValue()
            fullNameUpdateQueued = 0
        End Sub

#Region ""
        Private ReadOnly Property Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property

#End Region
        Private Sub gvEvaluations_RowCellStyle(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.RowCellStyleEventArgs)
            Dim evaluation As Evaluation = TryCast(gvEvaluations.GetRow(e.RowHandle), Evaluation)
            If evaluation Is Nothing Then Return
            If evaluation.Rating = EvaluationRating.Good Then e.Appearance.ForeColor = InformationColor
            If evaluation.Rating = EvaluationRating.Poor Then e.Appearance.ForeColor = CriticalColor
        End Sub
    End Class
End Namespace
