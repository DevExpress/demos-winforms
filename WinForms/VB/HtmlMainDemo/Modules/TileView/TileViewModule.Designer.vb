Namespace DevExpress.HTML.Demos

    Partial Class TileViewModule

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.TileViewModule))
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tileViewTemplateCodeViewer1 = New DevExpress.HTML.Demos.TileViewTemplateCodeViewer()
            Me.colDate = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colSubjectDisplayText = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colFrom = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colRead = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colPlainText = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colPriority = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colSubject = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colInitials = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colFlag = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.tileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.colIsUnread = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colHasPhoto = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colIsImportant = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.popupReply = New DevExpress.XtraEditors.HtmlContentPopup(Me.components)
            Me.popupDelete = New DevExpress.XtraEditors.HtmlContentPopup(Me.components)
            Me.sidePanel1.SuspendLayout()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tileView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupReply), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupDelete), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tileViewTemplateCodeViewer1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(407, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(468, 432)
            Me.sidePanel1.TabIndex = 1
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tileViewTemplateCodeViewer1
            ' 
            Me.tileViewTemplateCodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tileViewTemplateCodeViewer1.Location = New System.Drawing.Point(1, 0)
            Me.tileViewTemplateCodeViewer1.Name = "tileViewTemplateCodeViewer1"
            Me.tileViewTemplateCodeViewer1.Size = New System.Drawing.Size(467, 432)
            Me.tileViewTemplateCodeViewer1.TabIndex = 0
            ' 
            ' colDate
            ' 
            Me.colDate.Caption = "colDate"
            Me.colDate.FieldName = "Date"
            Me.colDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            Me.colDate.Name = "colDate"
            Me.colDate.Visible = True
            Me.colDate.VisibleIndex = 0
            ' 
            ' colSubjectDisplayText
            ' 
            Me.colSubjectDisplayText.Caption = "colSubjectDisplayText"
            Me.colSubjectDisplayText.FieldName = "SubjectDisplayText"
            Me.colSubjectDisplayText.Name = "colSubjectDisplayText"
            Me.colSubjectDisplayText.Visible = True
            Me.colSubjectDisplayText.VisibleIndex = 4
            ' 
            ' colFrom
            ' 
            Me.colFrom.Caption = "colFrom"
            Me.colFrom.FieldName = "From"
            Me.colFrom.Name = "colFrom"
            Me.colFrom.Visible = True
            Me.colFrom.VisibleIndex = 1
            ' 
            ' colRead
            ' 
            Me.colRead.Caption = "colRead"
            Me.colRead.FieldName = "Read"
            Me.colRead.Name = "colRead"
            Me.colRead.Visible = True
            Me.colRead.VisibleIndex = 5
            ' 
            ' colPlainText
            ' 
            Me.colPlainText.Caption = "colPlainText"
            Me.colPlainText.FieldName = "PlainText"
            Me.colPlainText.Name = "colPlainText"
            Me.colPlainText.Visible = True
            Me.colPlainText.VisibleIndex = 3
            ' 
            ' colPriority
            ' 
            Me.colPriority.Caption = "colPriority"
            Me.colPriority.FieldName = "Priority"
            Me.colPriority.Name = "colPriority"
            Me.colPriority.Visible = True
            Me.colPriority.VisibleIndex = 6
            ' 
            ' colSubject
            ' 
            Me.colSubject.Caption = "colSubject"
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            Me.colSubject.Visible = True
            Me.colSubject.VisibleIndex = 2
            ' 
            ' colPhoto
            ' 
            Me.colPhoto.Caption = "colPhoto"
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.Visible = True
            Me.colPhoto.VisibleIndex = 7
            ' 
            ' colInitials
            ' 
            Me.colInitials.Caption = "colInitials"
            Me.colInitials.FieldName = "FromInitials"
            Me.colInitials.Name = "colInitials"
            Me.colInitials.Visible = True
            Me.colInitials.VisibleIndex = 8
            ' 
            ' colFlag
            ' 
            Me.colFlag.Caption = "colFlag"
            Me.colFlag.FieldName = "Flagged"
            Me.colFlag.Name = "colFlag"
            Me.colFlag.Visible = True
            Me.colFlag.VisibleIndex = 9
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.tileView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(407, 432)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tileView1})
            ' 
            ' tileView1
            ' 
            Me.tileView1.Appearance.Group.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.tileView1.Appearance.Group.Options.UseFont = True
            Me.tileView1.Appearance.ItemNormal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.tileView1.Appearance.ItemNormal.Options.UseFont = True
            Me.tileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDate, Me.colFrom, Me.colSubject, Me.colPlainText, Me.colSubjectDisplayText, Me.colRead, Me.colPriority, Me.colPhoto, Me.colInitials, Me.colFlag, Me.colIsUnread, Me.colHasPhoto, Me.colIsImportant})
            Me.tileView1.ColumnSet.GroupColumn = Me.colDate
            Me.tileView1.FocusBorderColor = System.Drawing.Color.Transparent
            Me.tileView1.GridControl = Me.gridControl1
            Me.tileView1.HtmlImages = Me.svgImageCollection1
            Me.tileView1.Name = "tileView1"
            Me.tileView1.OptionsBehavior.AllowSmoothScrolling = True
            Me.tileView1.OptionsTiles.AllowPressAnimation = False
            Me.tileView1.OptionsTiles.GroupTextPadding = New System.Windows.Forms.Padding(30, 10, 0, 10)
            Me.tileView1.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None
            Me.tileView1.OptionsTiles.IndentBetweenGroups = 0
            Me.tileView1.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(0, 8, 12, 8)
            Me.tileView1.OptionsTiles.ItemSize = New System.Drawing.Size(560, 84)
            Me.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
            Me.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.tileView1.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
            Me.tileView1.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.TouchScrollBar
            Me.tileView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDate, DevExpress.Data.ColumnSortOrder.Ascending)})
            Me.tileView1.TileHtmlTemplate.Styles = resources.GetString("tileView1.TileHtmlTemplate.Styles")
            Me.tileView1.TileHtmlTemplate.Tag = "Tile Template"
            Me.tileView1.TileHtmlTemplate.Template = resources.GetString("tileView1.TileHtmlTemplate.Template")
            ' 
            ' colIsUnread
            ' 
            Me.colIsUnread.Caption = "IsUnread"
            Me.colIsUnread.FieldName = "IsUnread"
            Me.colIsUnread.Name = "colIsUnread"
            Me.colIsUnread.Visible = True
            Me.colIsUnread.VisibleIndex = 10
            ' 
            ' colHasPhoto
            ' 
            Me.colHasPhoto.Caption = "HasPhoto"
            Me.colHasPhoto.FieldName = "HasPhoto"
            Me.colHasPhoto.Name = "colHasPhoto"
            Me.colHasPhoto.Visible = True
            Me.colHasPhoto.VisibleIndex = 11
            ' 
            ' colIsImportant
            ' 
            Me.colIsImportant.Caption = "IsImportant"
            Me.colIsImportant.FieldName = "IsImportant"
            Me.colIsImportant.Name = "colIsImportant"
            Me.colIsImportant.Visible = True
            Me.colIsImportant.VisibleIndex = 12
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("important", CType((resources.GetObject("svgImageCollection1.important")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("flag", CType((resources.GetObject("svgImageCollection1.flag")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("delete", CType((resources.GetObject("svgImageCollection1.delete")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("reply", CType((resources.GetObject("svgImageCollection1.reply")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' popupReply
            ' 
            Me.popupReply.HtmlTemplate.Styles = resources.GetString("popupReply.HtmlTemplate.Styles")
            Me.popupReply.HtmlTemplate.Template = "<div class=""container"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "    <div class=""shadow"">$Reply to message from {From}</d" & "iv>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div>"
            ' 
            ' popupDelete
            ' 
            Me.popupDelete.HtmlTemplate.Styles = resources.GetString("popupDelete.HtmlTemplate.Styles")
            Me.popupDelete.HtmlTemplate.Template = "<div class=""container"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "    <div class=""shadow"">$Delete message from {From}</div" & ">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div>"
            ' 
            ' TileViewModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "TileViewModule"
            Me.Size = New System.Drawing.Size(875, 432)
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tileView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupReply), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupDelete), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tileViewTemplateCodeViewer1 As DevExpress.HTML.Demos.TileViewTemplateCodeViewer

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private tileView1 As DevExpress.XtraGrid.Views.Tile.TileView

        Private colDate As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colFrom As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colSubject As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colPlainText As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colSubjectDisplayText As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colRead As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colPriority As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colPhoto As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colInitials As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colFlag As DevExpress.XtraGrid.Columns.TileViewColumn

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private popupReply As DevExpress.XtraEditors.HtmlContentPopup

        Private popupDelete As DevExpress.XtraEditors.HtmlContentPopup

        Private colIsUnread As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colHasPhoto As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colIsImportant As DevExpress.XtraGrid.Columns.TileViewColumn
    End Class
End Namespace
