Namespace DevExpress.XtraGrid.Demos

    Partial Class LookUpInstantFeedbackUI

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.LookUpInstantFeedbackUI))
            Dim styleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Me.colHasAttachment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.xpAsyncServerModeSource1 = New DevExpress.Xpo.XPInstantFeedbackSource(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.pnlControl = New DevExpress.XtraEditors.PanelControl()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
            Me.searchLookUpEdit1 = New DevExpress.XtraGrid.Demos.SearchLookUpEditWithGlyph()
            Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFrom = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSent = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSize = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.sbShowSQLConnection = New DevExpress.XtraEditors.SimpleButton()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.icbAnimation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciWaitAnimationOptions = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.pnlControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.searchLookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridLookUpEdit1View), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.icbAnimation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciWaitAnimationOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colHasAttachment
            ' 
            resources.ApplyResources(Me.colHasAttachment, "colHasAttachment")
            Me.colHasAttachment.FieldName = "HasAttachment"
            Me.colHasAttachment.ImageOptions.ImageIndex =(CInt((resources.GetObject("colHasAttachment.ImageOptions.ImageIndex"))))
            Me.colHasAttachment.ImageOptions.SvgImage = CType((resources.GetObject("colHasAttachment.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.colHasAttachment.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.colHasAttachment.Name = "colHasAttachment"
            ' 
            ' xpAsyncServerModeSource1
            ' 
            Me.xpAsyncServerModeSource1.ObjectType = GetType(DevExpress.XtraGrid.Demos.ServerSideGridTest)
            AddHandler Me.xpAsyncServerModeSource1.ResolveSession, New System.EventHandler(Of DevExpress.Xpo.ResolveSessionEventArgs)(AddressOf Me.xpAsyncServerModeSource1_ResolveSession)
            AddHandler Me.xpAsyncServerModeSource1.DismissSession, New System.EventHandler(Of DevExpress.Xpo.ResolveSessionEventArgs)(AddressOf Me.xpAsyncServerModeSource1_DismissSession)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.pnlControl)
            Me.layoutControl1.Controls.Add(Me.groupControl1)
            Me.layoutControl1.Controls.Add(Me.sbShowSQLConnection)
            Me.layoutControl1.Controls.Add(Me.panelControl1)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5})
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' pnlControl
            ' 
            Me.pnlControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            resources.ApplyResources(Me.pnlControl, "pnlControl")
            Me.pnlControl.Name = "pnlControl"
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl1.Appearance.Options.UseBackColor = True
            Me.groupControl1.Controls.Add(Me.dataNavigator1)
            Me.groupControl1.Controls.Add(Me.searchLookUpEdit1)
            resources.ApplyResources(Me.groupControl1, "groupControl1")
            Me.groupControl1.Name = "groupControl1"
            ' 
            ' dataNavigator1
            ' 
            Me.dataNavigator1.Buttons.Append.Visible = False
            Me.dataNavigator1.Buttons.CancelEdit.Visible = False
            Me.dataNavigator1.Buttons.EndEdit.Visible = False
            Me.dataNavigator1.Buttons.NextPage.Visible = False
            Me.dataNavigator1.Buttons.PrevPage.Visible = False
            Me.dataNavigator1.Buttons.Remove.Visible = False
            resources.ApplyResources(Me.dataNavigator1, "dataNavigator1")
            Me.dataNavigator1.Name = "dataNavigator1"
            ' 
            ' searchLookUpEdit1
            ' 
            Me.searchLookUpEdit1.AllowDrop = True
            resources.ApplyResources(Me.searchLookUpEdit1, "searchLookUpEdit1")
            Me.searchLookUpEdit1.Name = "searchLookUpEdit1"
            Me.searchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("searchLookUpEdit1.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.searchLookUpEdit1.Properties.DataSource = Me.xpAsyncServerModeSource1
            Me.searchLookUpEdit1.Properties.DisplayMember = "Subject"
            Me.searchLookUpEdit1.Properties.PopupFormSize = New System.Drawing.Size(700, 0)
            Me.searchLookUpEdit1.Properties.PopupView = Me.gridLookUpEdit1View
            Me.searchLookUpEdit1.Properties.ValueMember = "Oid"
            ' 
            ' gridLookUpEdit1View
            ' 
            Me.gridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colSubject, Me.colFrom, Me.colSent, Me.colSize, Me.colHasAttachment})
            Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            styleFormatCondition1.Appearance.Font = CType((resources.GetObject("resource.Font")), System.Drawing.Font)
            styleFormatCondition1.Appearance.Options.UseFont = True
            styleFormatCondition1.ApplyToRow = True
            styleFormatCondition1.Column = Me.colHasAttachment
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            styleFormatCondition1.Value1 = True
            Me.gridLookUpEdit1View.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {styleFormatCondition1})
            Me.gridLookUpEdit1View.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridLookUpEdit1View.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("gridLookUpEdit1View.GroupSummary1"), CType((resources.GetObject("gridLookUpEdit1View.GroupSummary2")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridLookUpEdit1View.GroupSummary3"))})
            Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
            Me.gridLookUpEdit1View.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridLookUpEdit1View.OptionsView.ShowFooter = True
            Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            ' 
            ' colOid
            ' 
            resources.ApplyResources(Me.colOid, "colOid")
            Me.colOid.FieldName = "Oid"
            Me.colOid.Name = "colOid"
            Me.colOid.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colOid.Summary")), DevExpress.Data.SummaryItemType))})
            ' 
            ' colSubject
            ' 
            resources.ApplyResources(Me.colSubject, "colSubject")
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            Me.colSubject.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colSubject.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colSubject.Summary1"), resources.GetString("colSubject.Summary2"))})
            ' 
            ' colFrom
            ' 
            resources.ApplyResources(Me.colFrom, "colFrom")
            Me.colFrom.FieldName = "From"
            Me.colFrom.Name = "colFrom"
            ' 
            ' colSent
            ' 
            resources.ApplyResources(Me.colSent, "colSent")
            Me.colSent.FieldName = "Sent"
            Me.colSent.Name = "colSent"
            ' 
            ' colSize
            ' 
            resources.ApplyResources(Me.colSize, "colSize")
            Me.colSize.DisplayFormat.FormatString = "{0:n0} KB"
            Me.colSize.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSize.FieldName = "Size"
            Me.colSize.Name = "colSize"
            ' 
            ' sbShowSQLConnection
            ' 
            resources.ApplyResources(Me.sbShowSQLConnection, "sbShowSQLConnection")
            Me.sbShowSQLConnection.Name = "sbShowSQLConnection"
            Me.sbShowSQLConnection.StyleController = Me.layoutControl1
            AddHandler Me.sbShowSQLConnection.Click, New System.EventHandler(AddressOf Me.sbShowSQLConnection_Click)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.icbAnimation)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' labelControl1
            ' 
            resources.ApplyResources(Me.labelControl1, "labelControl1")
            Me.labelControl1.Name = "labelControl1"
            ' 
            ' icbAnimation
            ' 
            resources.ApplyResources(Me.icbAnimation, "icbAnimation")
            Me.icbAnimation.Name = "icbAnimation"
            Me.icbAnimation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbAnimation.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            AddHandler Me.icbAnimation.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbAnimation_SelectedIndexChanged)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.sbShowSQLConnection
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 436)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem5.Size = New System.Drawing.Size(119, 33)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciWaitAnimationOptions, Me.emptySpaceItem2, Me.layoutControlItem2, Me.emptySpaceItem1, Me.emptySpaceItem3, Me.layoutControlItem1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(935, 577)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' lciWaitAnimationOptions
            ' 
            Me.lciWaitAnimationOptions.Control = Me.panelControl1
            resources.ApplyResources(Me.lciWaitAnimationOptions, "lciWaitAnimationOptions")
            Me.lciWaitAnimationOptions.Location = New System.Drawing.Point(0, 0)
            Me.lciWaitAnimationOptions.MaxSize = New System.Drawing.Size(0, 42)
            Me.lciWaitAnimationOptions.MinSize = New System.Drawing.Size(100, 42)
            Me.lciWaitAnimationOptions.Name = "lciWaitAnimationOptions"
            Me.lciWaitAnimationOptions.Size = New System.Drawing.Size(342, 42)
            Me.lciWaitAnimationOptions.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciWaitAnimationOptions.TextSize = New System.Drawing.Size(0, 0)
            Me.lciWaitAnimationOptions.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem2, "emptySpaceItem2")
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 269)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(605, 308)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.pnlControl
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Location = New System.Drawing.Point(605, 0)
            Me.layoutControlItem2.MaxSize = New System.Drawing.Size(330, 0)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(330, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(330, 577)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem1, "emptySpaceItem1")
            Me.emptySpaceItem1.Location = New System.Drawing.Point(342, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(263, 269)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem3, "emptySpaceItem3")
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 42)
            Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(342, 10)
            Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.groupControl1
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 52)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(342, 217)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(342, 217)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(342, 217)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' LookUpInstantFeedbackUI
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "LookUpInstantFeedbackUI"
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.pnlControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType((Me.searchLookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridLookUpEdit1View), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType((Me.icbAnimation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciWaitAnimationOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private sbShowSQLConnection As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private xpAsyncServerModeSource1 As DevExpress.Xpo.XPInstantFeedbackSource

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private lciWaitAnimationOptions As DevExpress.XtraLayout.LayoutControlItem

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private icbAnimation As DevExpress.XtraEditors.ImageComboBoxEdit

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator

        Private searchLookUpEdit1 As DevExpress.XtraGrid.Demos.SearchLookUpEditWithGlyph

        Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private colOid As DevExpress.XtraGrid.Columns.GridColumn

        Private colSubject As DevExpress.XtraGrid.Columns.GridColumn

        Private colFrom As DevExpress.XtraGrid.Columns.GridColumn

        Private colSent As DevExpress.XtraGrid.Columns.GridColumn

        Private colSize As DevExpress.XtraGrid.Columns.GridColumn

        Private colHasAttachment As DevExpress.XtraGrid.Columns.GridColumn

        Private pnlControl As DevExpress.XtraEditors.PanelControl

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
