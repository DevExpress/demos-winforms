Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Native
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading.Tasks

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class SendAppointmentByMailForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            lciMessage.Visibility = XtraLayout.Utils.LayoutVisibility.Never
            ControlBox = False
            lciBtnOk.Visibility = XtraLayout.Utils.LayoutVisibility.Never
            emptySpaceItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Never
            emptySpaceItem1.Visibility = XtraLayout.Utils.LayoutVisibility.Never
            emptySpaceItem3.Visibility = XtraLayout.Utils.LayoutVisibility.Never
        End Sub

        Public Sub New(ByVal fileName As String, ByVal filePaths As String())
            Me.New()
            Me.FileName = Me.FileName
            Me.FilePaths = filePaths
        End Sub

        Private Property FileName As String

        Private Property FilePaths As String()

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If FilePaths Is Nothing Then Return
            Dim task As Task = DoActionTask()
            task.ContinueWith(Sub(x)
                If Not IsDisposed Then BeginInvoke(CType(AddressOf ShowError, Action))
            End Sub, TaskContinuationOptions.OnlyOnFaulted)
            task.ContinueWith(Sub(x)
                If Not IsDisposed Then BeginInvoke(CType(AddressOf Done, Action))
            End Sub, TaskContinuationOptions.OnlyOnRanToCompletion)
        End Sub

        Private Function DoActionTask() As Task
            Dim task As Task = New Task(AddressOf SendMail, TaskCreationOptions.LongRunning)
            task.Start()
            Return task
        End Function

        Private Sub SendMail()
            Dim recipients As RecipientCollection = New RecipientCollection()
            recipients.Add(New Recipient())
            MAPI.SendMail(IntPtr.Zero, FilePaths, FileName, "", recipients)
        End Sub

        Private Sub ShowError()
            ControlBox = True
            lciBtnOk.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            emptySpaceItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            emptySpaceItem1.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            emptySpaceItem3.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            lciProgressPanel.Visibility = XtraLayout.Utils.LayoutVisibility.Never
            lciMessage.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            lblMessage.Text = "Can't open default mail client!"
        End Sub

        Private Sub Done()
            Close()
        End Sub
    End Class
End Namespace
