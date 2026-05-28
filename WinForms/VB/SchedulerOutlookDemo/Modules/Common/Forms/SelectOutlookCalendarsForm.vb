Imports System
Imports System.Linq
Imports System.Threading.Tasks
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler.Outlook
Imports System.Threading
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class SelectOutlookCalendarsForm
        Inherits XtraForm

        Private loadCalendarPathsTask As Task(Of String()) = Nothing

        Private tokenSource As CancellationTokenSource

        Private token As CancellationToken

        Public Sub New()
            InitializeComponent()
            tokenSource = New CancellationTokenSource()
            token = tokenSource.Token
            lciEditor.Visibility = XtraLayout.Utils.LayoutVisibility.Never
            lciErrorMessage.Visibility = XtraLayout.Utils.LayoutVisibility.Never
            btnOk.Enabled = False
            AddHandler Load, AddressOf OnFormLoad
        End Sub

        Public ReadOnly Property CalendarName As String
            Get
                Return TryCast(cbCalendars.EditValue, String)
            End Get
        End Property

        Protected Overrides Sub OnFormClosed(ByVal e As FormClosedEventArgs)
            MyBase.OnFormClosed(e)
            If DialogResult = DialogResult.OK Then Return
            tokenSource.Cancel()
        End Sub

        Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs)
            loadCalendarPathsTask = LoadCalendars()
            loadCalendarPathsTask.ContinueWith(Function(x) BeginInvoke(CType(AddressOf ShowError, Action)), TaskContinuationOptions.OnlyOnFaulted)
            loadCalendarPathsTask.ContinueWith(Function(x) BeginInvoke(CType(AddressOf ShowEditors, Action(Of String())), New Object() {x.Result}), TaskContinuationOptions.OnlyOnRanToCompletion)
            FormBorderStyle = FormBorderStyle.FixedDialog
        End Sub

        Private Function LoadCalendars() As Task(Of String())
            Dim task As Task(Of String()) = New Task(Of String())(Function()
                If token.IsCancellationRequested Then token.ThrowIfCancellationRequested()
                Dim result As String() = OutlookExchangeHelper.GetOutlookCalendarPaths()
                If tokenSource.Token.IsCancellationRequested Then tokenSource.Token.ThrowIfCancellationRequested()
                Return result
            End Function, token, TaskCreationOptions.LongRunning)
            task.Start()
            Return task
        End Function

        Private Sub ShowError()
            lblErrorMessage.Text = "Cannot connect to oulook. Install or close outlook instance."
            lciErrorMessage.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            lciProgress.Visibility = XtraLayout.Utils.LayoutVisibility.Never
        End Sub

        Private Sub ShowEditors(ByVal calendarPaths As String())
            lciProgress.Visibility = XtraLayout.Utils.LayoutVisibility.Never
            lciEditor.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            cbCalendars.Properties.Items.AddRange(calendarPaths)
            If calendarPaths.Count() > 0 Then cbCalendars.SelectedIndex = 0
            btnOk.Enabled = True
        End Sub
    End Class
End Namespace
