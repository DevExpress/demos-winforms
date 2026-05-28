Imports System.Windows.Forms
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraEditors

Namespace DevExpress.DevAV.Modules

    Public Partial Class TaskEditView
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(TaskViewModel))
            InitializeComponent()
            GalleryItemAppearances.Apply(galleryQuickLetters)
            BindCommands()
            BindEditors()
            If Not mvvmContext.IsDesignMode Then
                InitBindings()
            End If
        End Sub

        Private Sub InitBindings()
            Dim fluentAPI = mvvmContext.OfType(Of TaskViewModel)()
            fluentAPI.SetObjectDataSourceBinding(taskBindingSource, Function(x) x.Entity, Sub(x) x.Update())
            fluentAPI.SetBinding(ownerLookUpEdit.Properties, Function(r) r.DataSource, Function(x) x.LookUpEmployees.Entities)
            fluentAPI.SetBinding(assignedToLookUpEdit.Properties, Function(r) r.DataSource, Function(x) x.LookUpEmployees.Entities)
            fluentAPI.SetBinding(linkedToLookUpEdit.Properties, Function(r) r.DataSource, Function(x) x.LookUpEmployees.Entities)
        End Sub

        Public ReadOnly Property ViewModel As TaskViewModel
            Get
                Return GetViewModel(Of TaskViewModel)()
            End Get
        End Property

        Public ReadOnly Property CollectionViewModel As TaskCollectionViewModel
            Get
                Return GetParentViewModel(Of TaskCollectionViewModel)()
            End Get
        End Property

        Protected Overrides Sub OnParentViewModelAttached()
        End Sub

        Private Sub BindCommands()
            Dim fluent = mvvmContext.OfType(Of TaskViewModel)()
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
            Dim fluent = mvvmContext.OfType(Of TaskViewModel)()
            fluent.SetBinding(ribbonControl, Function(r) r.ApplicationDocumentCaption, Function(x) x.Title)
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
            fullNameUpdateQueued = 0
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
