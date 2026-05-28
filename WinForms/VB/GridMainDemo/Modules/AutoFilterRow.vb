Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for AutoFilterRow.
    ''' </summary>
    Public Partial Class AutoFilterRow
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
        ' TODO: Add any initialization after the InitForm call
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"AutoFilterRow"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "AutoFilterRow"
            End Get
        End Property

        Private Sub AutoFilterRow_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitIssueListData(dsIssueList1)
            InitCheckEditors()
            gridView1.FocusedRowHandle = GridControl.AutoFilterRowHandle
        End Sub

        Private initEditors As Boolean = False

        Private Sub InitCheckEditors()
            initEditors = True
            ceAutoFilterRow.Checked = gridView1.OptionsView.ShowAutoFilterRow
            ceAutoFilterRowMenuItem.Checked = gridView1.OptionsMenu.ShowAutoFilterRowItem
            ceAllowAutoFilterConditionChange.Checked = gridView1.OptionsFilter.AllowAutoFilterConditionChange <> DefaultBoolean.False
            initEditors = False
        End Sub

        '<ceAutoFilterRow>
        Private Sub ceAutoFilterRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initEditors Then Return
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            gridView1.OptionsView.ShowAutoFilterRow = ce.Checked
        End Sub

        '</ceAutoFilterRow>
        '<ceAutoFilterRowMenuItem>
        Private Sub ceAutoFilterRowMenuItem_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initEditors Then Return
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            gridView1.OptionsMenu.ShowAutoFilterRowItem = ce.Checked
        End Sub

        '</ceAutoFilterRowMenuItem>
        Private Sub gridView1_GridMenuItemClick(ByVal sender As Object, ByVal e As Views.Grid.GridMenuItemClickEventArgs)
            BeginInvoke(New MethodInvoker(AddressOf InitCheckEditors))
        End Sub

        Private Sub ceAllowAutoFilterConditionChange_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initEditors Then Return
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            gridView1.OptionsFilter.AllowAutoFilterConditionChange = If(ce.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub
    End Class
End Namespace
