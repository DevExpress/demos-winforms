Imports System
Imports System.Drawing
Imports System.ComponentModel

Namespace DevExpress.XtraNavBar.Demos

    ''' <summary>
    ''' Summary description for AddGroups.
    ''' </summary>
    Public Partial Class AddGroups
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            For i As Integer = 0 To 3 - 1
                OnAddGroup()
            Next
        End Sub

        '<button2>
        Private ReadOnly Property LastGroup As NavBarGroup
            Get
                If navBarControl1.Groups.Count > 0 Then Return navBarControl1.Groups(navBarControl1.Groups.Count - 1)
                Return Nothing
            End Get
        End Property

        '</button2>
        '<button1>
        Private i As Integer = 0

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            OnAddGroup()
        End Sub

        '</button1>
        '<button2>
        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            OnRemoveGroup()
        End Sub

        '</button2>
        Private Sub ChangeGroups()
            button2.Enabled = LastGroup IsNot Nothing
        End Sub

        Private Sub OnAddGroup()
            Dim group As NavBarGroup = navBarControl1.Groups.Add()
            group.Caption = "Group " & Math.Min(Threading.Interlocked.Increment(i), i - 1).ToString()
            ChangeGroups()
        End Sub

        Private Sub OnRemoveGroup()
            If LastGroup IsNot Nothing Then LastGroup.Dispose()
            ChangeGroups()
        End Sub
    End Class
End Namespace
