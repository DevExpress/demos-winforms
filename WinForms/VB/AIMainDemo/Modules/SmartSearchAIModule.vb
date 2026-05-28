Imports DevExpress.AIIntegration.WinForms
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.AI.Demos

    Public Partial Class SmartSearchAIModule
        Inherits AITutorialControl

        Private richEditControl1 As XtraRichEdit.RichEditControl = New XtraRichEdit.RichEditControl()

        Private behavior As SmartSearchBehavior

        Public Sub New()
            InitializeComponent()
            AutoMergeRibbon = True
            pictureEdit1.BackColor = tablePanel1.BackColor
            Dim ribbonControl As RibbonControl = richEditControl1.CreateRibbon()
            Controls.Add(ribbonControl)
            AddHandler ribbonControl.Merge, AddressOf RibbonControl_Merge
            AddHandler ribbonControl.UnMerge, AddressOf RibbonControl_UnMerge
            behavior = SmartSearchBehavior.Create(GetType(SmartSearchRibbonBehaviorSource))
            AddHandler behavior.Properties.Events.OperationFailed, AddressOf OnOperationFailed
            behaviorManager1.SetBehaviors(ribbonControl, New Utils.Behaviors.Behavior() {behavior})
            UpdatePaddings()
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            pictureEdit1.BackColor = tablePanel1.BackColor
        End Sub

        Protected Overrides Sub UpdatePaddings()
            UpdateBottomSpacings(layoutControlItem2, ucDisclaimerPanel1.RoundedPanelOffset)
        End Sub

        Private Sub RibbonControl_UnMerge(ByVal sender As Object, ByVal e As RibbonMergeEventArgs)
            If behaviorManager1.GetBehavior(Of SmartSearchBehavior)(e.MergeOwner) IsNot Nothing Then behaviorManager1.Detach(Of SmartSearchBehavior)(e.MergeOwner)
            e.MergeOwner.OptionsSearchMenu.SearchItemPosition = SearchItemPosition.Default
            e.MergeOwner.RibbonCaptionAlignment = RibbonCaptionAlignment.Default
            RemoveHandler e.MergeOwner.CustomSearchItemPosition, AddressOf CustomSearchItemPosition
        End Sub

        Private Sub RibbonControl_Merge(ByVal sender As Object, ByVal e As RibbonMergeEventArgs)
            If behaviorManager1.GetBehavior(Of SmartSearchBehavior)(e.MergeOwner) Is Nothing Then behaviorManager1.SetBehaviors(e.MergeOwner, New Utils.Behaviors.Behavior() {behavior})
            e.MergeOwner.OptionsSearchMenu.SearchItemPosition = SearchItemPosition.Caption
            e.MergeOwner.RibbonCaptionAlignment = RibbonCaptionAlignment.Center
            AddHandler e.MergeOwner.CustomSearchItemPosition, AddressOf CustomSearchItemPosition
        End Sub

        Private Sub CustomSearchItemPosition(ByVal sender As Object, ByVal e As RibbonCustomSearchItemPositionArgs)
            If e.IsCollapsed Then Return
            Dim searchItemWidth As Integer = CInt(e.Bounds.Width * 0.3F)
            e.SearchItemBounds = e.SearchItemBounds.WithWidth(searchItemWidth).WithX(e.Bounds.Width - searchItemWidth)
        End Sub
    End Class
End Namespace
