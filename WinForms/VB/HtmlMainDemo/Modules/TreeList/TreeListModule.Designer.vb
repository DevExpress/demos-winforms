Namespace DevExpress.HTML.Demos

    Partial Class TreeListModule

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

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.TreeListModule))
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.treeListTemplateCodeViewer1 = New DevExpress.HTML.Demos.TreeListTemplateCodeViewer()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.dateColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.isMyCommentColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.editingTextColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.hasLikesColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.editingCommentTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.replyingCommentTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.commentTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.typingBox = New DevExpress.XtraEditors.HtmlContentControl()
            Me.messageEdit = New DevExpress.XtraEditors.MemoEdit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commentTextEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.typingBox), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.typingBox.SuspendLayout()
            CType((Me.messageEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.treeListTemplateCodeViewer1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(513, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(468, 432)
            Me.sidePanel1.TabIndex = 1
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' treeListTemplateCodeViewer1
            ' 
            Me.treeListTemplateCodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeListTemplateCodeViewer1.Location = New System.Drawing.Point(1, 0)
            Me.treeListTemplateCodeViewer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.treeListTemplateCodeViewer1.Name = "treeListTemplateCodeViewer1"
            Me.treeListTemplateCodeViewer1.Size = New System.Drawing.Size(467, 432)
            Me.treeListTemplateCodeViewer1.TabIndex = 0
            ' 
            ' treeList1
            ' 
            Me.treeList1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
            Me.treeList1.Appearance.Empty.Options.UseBackColor = True
            Me.treeList1.Appearance.TreeLine.BackColor = System.Drawing.Color.Silver
            Me.treeList1.Appearance.TreeLine.Options.UseBackColor = True
            Me.treeList1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.treeList1.ChildListFieldName = "Replies"
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.dateColumn, Me.isMyCommentColumn, Me.editingTextColumn, Me.hasLikesColumn})
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.EnableDynamicLoading = False
            Me.treeList1.HtmlImages = Me.svgImageCollection1
            Me.treeList1.HtmlTemplates.AddRange(New DevExpress.Utils.Html.HtmlTemplate() {Me.editingCommentTemplate, Me.replyingCommentTemplate})
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.NodeHtmlTemplate.Styles = resources.GetString("treeList1.NodeHtmlTemplate.Styles")
            Me.treeList1.NodeHtmlTemplate.Tag = "Node Template"
            Me.treeList1.NodeHtmlTemplate.Template = resources.GetString("treeList1.NodeHtmlTemplate.Template")
            Me.treeList1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList1.OptionsView.ShowButtons = False
            Me.treeList1.OptionsView.ShowRoot = False
            Me.treeList1.OptionsView.ShowTreeLines = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.commentTextEdit})
            Me.treeList1.Size = New System.Drawing.Size(513, 389)
            Me.treeList1.TabIndex = 0
            Me.treeList1.TreeLevelWidth = 24
            AddHandler Me.treeList1.QueryNodeTemplate, New DevExpress.XtraTreeList.QueryNodeHtmlTemplateEventHandler(AddressOf Me.treeList1_QueryNodeTemplate)
            AddHandler Me.treeList1.CustomUnboundColumnData, New DevExpress.XtraTreeList.CustomColumnDataEventHandler(AddressOf Me.treeList1_CustomUnboundColumnData)
            ' 
            ' dateColumn
            ' 
            Me.dateColumn.Caption = "Date"
            Me.dateColumn.FieldName = "Date"
            Me.dateColumn.Name = "dateColumn"
            Me.dateColumn.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
            Me.dateColumn.SortOrder = System.Windows.Forms.SortOrder.Ascending
            Me.dateColumn.Visible = True
            Me.dateColumn.VisibleIndex = 0
            ' 
            ' isMyCommentColumn
            ' 
            Me.isMyCommentColumn.FieldName = "IsMyComment"
            Me.isMyCommentColumn.Name = "isMyCommentColumn"
            Me.isMyCommentColumn.UnboundDataType = GetType(Boolean)
            ' 
            ' editingTextColumn
            ' 
            Me.editingTextColumn.FieldName = "EditingText"
            Me.editingTextColumn.Name = "editingTextColumn"
            Me.editingTextColumn.UnboundDataType = GetType(String)
            ' 
            ' hasLikesColumn
            ' 
            Me.hasLikesColumn.FieldName = "HasLikes"
            Me.hasLikesColumn.MinWidth = 16
            Me.hasLikesColumn.Name = "hasLikesColumn"
            Me.hasLikesColumn.UnboundDataType = GetType(Boolean)
            Me.hasLikesColumn.Visible = True
            Me.hasLikesColumn.VisibleIndex = 1
            Me.hasLikesColumn.Width = 50
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("likeIcon", "image://svgimages/icon builder/shopping_favorites.svg")
            Me.svgImageCollection1.Add("replyIcon", "image://svgimages/icon builder/actions_arrow5downright.svg")
            Me.svgImageCollection1.Add("editIcon", "image://svgimages/icon builder/actions_edit.svg")
            Me.svgImageCollection1.Add("applyIcon", "image://svgimages/icon builder/actions_check.svg")
            Me.svgImageCollection1.Add("cancelIcon", "image://svgimages/diagramicons/del.svg")
            Me.svgImageCollection1.Add("reply2Icon", "image://svgimages/dashboards/drilldown.svg")
            Me.svgImageCollection1.Add("sendIcon", "image://svgimages/icon builder/actions_arrow4right.svg")
            Me.svgImageCollection1.Add("rightIcon", CType((resources.GetObject("svgImageCollection1.rightIcon")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("downIcon", CType((resources.GetObject("svgImageCollection1.downIcon")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' editingCommentTemplate
            ' 
            Me.editingCommentTemplate.Name = "editingCommentTemplate"
            Me.editingCommentTemplate.Styles = resources.GetString("editingCommentTemplate.Styles")
            Me.editingCommentTemplate.Tag = "Editing State Template"
            Me.editingCommentTemplate.Template = resources.GetString("editingCommentTemplate.Template")
            ' 
            ' replyingCommentTemplate
            ' 
            Me.replyingCommentTemplate.Name = "replyingCommentTemplate"
            Me.replyingCommentTemplate.Styles = resources.GetString("replyingCommentTemplate.Styles")
            Me.replyingCommentTemplate.Tag = "Replying State Template"
            Me.replyingCommentTemplate.Template = resources.GetString("replyingCommentTemplate.Template")
            ' 
            ' commentTextEdit
            ' 
            Me.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.commentTextEdit.Name = "commentTextEdit"
            Me.commentTextEdit.NullText = "Type a new message"
            ' 
            ' typingBox
            ' 
            Me.typingBox.AutoScroll = False
            Me.typingBox.Controls.Add(Me.messageEdit)
            Me.typingBox.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.typingBox.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.typingBox.HtmlImages = Me.svgImageCollection1
            Me.typingBox.HtmlTemplate.Styles = resources.GetString("typingBox.HtmlTemplate.Styles")
            Me.typingBox.HtmlTemplate.Template = "<div class='typingbox'>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "    <input name=""messageEdit"" class=""message"" />" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "    <d" & "iv class='separator'></div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "    <img id=""btnSend"" src='sendIcon' class='button'" & " onclick=""SendClick"" />" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div>"
            Me.typingBox.Location = New System.Drawing.Point(0, 389)
            Me.typingBox.Name = "typingBox"
            Me.typingBox.Size = New System.Drawing.Size(513, 43)
            Me.typingBox.TabIndex = 2
            ' 
            ' messageEdit
            ' 
            Me.messageEdit.Location = New System.Drawing.Point(12, 15)
            Me.messageEdit.Name = "messageEdit"
            Me.messageEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.messageEdit.Properties.NullValuePrompt = "Type your message here..."
            Me.messageEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.messageEdit.Size = New System.Drawing.Size(441, 14)
            Me.messageEdit.TabIndex = 1
            ' 
            ' TreeListModule
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.typingBox)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "TreeListModule"
            Me.Size = New System.Drawing.Size(981, 432)
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commentTextEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.typingBox), System.ComponentModel.ISupportInitialize).EndInit()
            Me.typingBox.ResumeLayout(False)
            CType((Me.messageEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeListTemplateCodeViewer1 As DevExpress.HTML.Demos.TreeListTemplateCodeViewer

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private isMyCommentColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private dateColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private editingTextColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private editingCommentTemplate As DevExpress.Utils.Html.HtmlTemplate

        Private commentTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        Private replyingCommentTemplate As DevExpress.Utils.Html.HtmlTemplate

        Private hasLikesColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private typingBox As DevExpress.XtraEditors.HtmlContentControl

        Private messageEdit As DevExpress.XtraEditors.MemoEdit
    End Class
End Namespace
