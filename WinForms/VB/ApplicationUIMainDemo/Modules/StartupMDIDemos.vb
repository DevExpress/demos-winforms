Imports System
Imports System.Windows.Forms

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class StartupMDIDemos
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            Sample = Nothing
        End Sub

        Private fSample As Form = Nothing

        Private Property Sample As Form
            Get
                Return fSample
            End Get

            Set(ByVal value As Form)
                fSample = value
                sbStart.Enabled = fSample Is Nothing
                sbClose.Enabled = fSample IsNot Nothing
            End Set
        End Property

        Protected Overridable Function CreateSample() As Form
            Return Nothing
        End Function

        Private Sub sbStart_Click(ByVal sender As Object, ByVal e As EventArgs)
            Sample = CreateSample()
            If Sample Is Nothing Then Return
            AddHandler Sample.Closed, New EventHandler(AddressOf Sample_Close)
            Sample.Show()
        End Sub

        Private Sub Sample_Close(ByVal sender As Object, ByVal e As EventArgs)
            RemoveHandler Sample.Closed, New EventHandler(AddressOf Sample_Close)
            Sample.Dispose()
            Sample = Nothing
        End Sub

        Private Sub CloseSample()
            If Sample IsNot Nothing Then Sample.Close()
        End Sub

        Private Sub sbClose_Click(ByVal sender As Object, ByVal e As EventArgs)
            CloseSample()
        End Sub

        Protected Overrides Sub DoVisibleChanged(ByVal visible As Boolean)
            MyBase.DoVisibleChanged(visible)
            CloseSample()
        End Sub
    End Class

    Public Class TabbedMDIStart
        Inherits StartupMDIDemos

        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            UpdateCenteredControls(Me)
        End Sub

        Protected Overrides Function CreateSample() As Form
            Return New frmTabbedMDI()
        End Function

        Protected Overrides ReadOnly Property AllowBorderRounding As Boolean?
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
