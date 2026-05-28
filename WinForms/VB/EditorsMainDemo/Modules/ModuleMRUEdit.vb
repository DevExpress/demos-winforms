Imports System
Imports System.ComponentModel
Imports System.Drawing
' </mruEditSample>
' <ceShowCustomButtons>
Imports DevExpress.XtraEditors.Controls
' </ceShowCustomButtons>
Imports System.Windows.Forms
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleMRUEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleMRUEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "mruedit"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private updateValues As Boolean = False

        Private Sub ModuleMRUEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(mruEditSample)
            InitValues()
        End Sub

        Private Sub InitValues()
            updateValues = True
            seMaxItemCount.Value = mruEditSample.Properties.MaxItemCount
            ceAllowRemoveItems.Checked = mruEditSample.Properties.AllowRemoveMRUItems
            ShowCustomButtons(ceShowCustomButtons.Checked)
            updateValues = False
        End Sub

        ' <seMaxItemCount>
        Private Sub seMaxItemCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            mruEditSample.Properties.MaxItemCount = Convert.ToInt32(seMaxItemCount.Value)
        End Sub

        ' </seMaxItemCount>
        ' <mruEditSample>
        Private Sub mruEditSample_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            Dim edit As MRUEdit = TryCast(sender, MRUEdit)
            If edit.Properties.Buttons.IndexOf(e.Button) <> edit.Properties.ActionButtonIndex Then
                Dim dlg As OpenFileDialog = New OpenFileDialog()
                dlg.Filter = "All Files(*.*)|*.*"
                If dlg.ShowDialog() = DialogResult.OK Then
                    edit.EditValue = New IO.FileInfo(dlg.FileName).Name
                    edit.Properties.Items.Add(edit.Text)
                End If
            End If
        End Sub

        ' </mruEditSample>
        ' <ceAllowAdding>
        Private Sub mruEditSample_AddingMRUItem(ByVal sender As Object, ByVal e As XtraEditors.Controls.AddingMRUItemEventArgs)
            e.Cancel = Not ceAllowAdding.Checked
        End Sub

        ' </ceAllowAdding>
        ' <ceShowCustomButtons>
        Private Sub ShowCustomButtons(ByVal show As Boolean)
            For Each button As EditorButton In mruEditSample.Properties.Buttons
                If button.Tag IsNot Nothing Then button.Visible = show
            Next
        End Sub

        Private Sub ceShowCustomButtons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ShowCustomButtons(ceShowCustomButtons.Checked)
        End Sub

        ' </ceShowCustomButtons>
        Private Sub ceAllowRemoveItems_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            mruEditSample.Properties.AllowRemoveMRUItems = ceAllowRemoveItems.Checked
        End Sub
    End Class
End Namespace
