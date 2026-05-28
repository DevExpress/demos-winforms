Imports DevExpress.AIIntegration.WinForms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors

Namespace DevExpress.AI.Demos

    Public Partial Class AITutorialControl
        Inherits TutorialControlBase

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdatePaddings()
        End Sub

        Protected Overrides Sub DoDpiChangeAfterParent()
            MyBase.DoDpiChangeAfterParent()
            UpdatePaddings()
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            UpdatePaddings()
        End Sub

        Protected Overridable Sub UpdatePaddings()
        End Sub

        Protected Sub UpdateBottomSpacings(ByVal layoutControlItem As XtraLayout.LayoutControlItem, ByVal roundedPanelOffset As Integer)
            layoutControlItem.Spacing = New XtraLayout.Utils.Padding(layoutControlItem.Spacing.Left, layoutControlItem.Spacing.Right, layoutControlItem.Spacing.Top, -roundedPanelOffset)
        End Sub

        Protected Sub UpdateTopSpacings(ByVal layoutControlItem As XtraLayout.LayoutControlItem, ByVal roundedPanelOffset As Integer)
            layoutControlItem.Spacing = New XtraLayout.Utils.Padding(layoutControlItem.Spacing.Left, layoutControlItem.Spacing.Right, -roundedPanelOffset, layoutControlItem.Spacing.Bottom)
        End Sub

        Protected Overrides ReadOnly Property UseRoundedPanel As Boolean?
            Get
                Return False
            End Get
        End Property

        Protected Sub OnOperationFailed(ByVal sender As Object, ByVal e As AIOperationFailedEventArgs)
            Dim options = New XtraMessageBoxArgs(Nothing, e.Exception.Message, "AI Service Error", New System.Windows.Forms.DialogResult() {System.Windows.Forms.DialogResult.OK}, Nothing, 0)
            AddHandler options.Showing, AddressOf Options_Showing
            options.Appearance.TextOptions.HAlignment = Utils.HorzAlignment.Center
            XtraMessageBox.Show(options)
        End Sub

        Private Sub Options_Showing(ByVal sender As Object, ByVal e As XtraMessageShowingArgs)
            e.MessageBoxForm.MaximumSize = New System.Drawing.Size(600, 600)
        End Sub
    End Class
End Namespace
