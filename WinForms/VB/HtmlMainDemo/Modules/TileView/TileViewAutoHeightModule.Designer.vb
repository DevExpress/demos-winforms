Namespace DevExpress.HTML.Demos

    Partial Class TileViewAutoHeightModule

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.TileViewAutoHeightModule))
            Me.tileViewTemplateCodeViewer1 = New DevExpress.HTML.Demos.TileViewTemplateCodeViewer()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.tileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.colName = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colEmployee = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colStatus = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colDueDate = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colPriority = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colPriorityName = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.alertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tileView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tileViewTemplateCodeViewer1
            ' 
            Me.tileViewTemplateCodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tileViewTemplateCodeViewer1.Location = New System.Drawing.Point(1, 0)
            Me.tileViewTemplateCodeViewer1.Name = "tileViewTemplateCodeViewer1"
            Me.tileViewTemplateCodeViewer1.Size = New System.Drawing.Size(476, 432)
            Me.tileViewTemplateCodeViewer1.TabIndex = 0
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.tileView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(452, 432)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ToolTipController = Me.toolTipController1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tileView1})
            ' 
            ' tileView1
            ' 
            Me.tileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName, Me.colDescription, Me.colEmployee, Me.colStatus, Me.colDueDate, Me.colPriority, Me.colPriorityName})
            Me.tileView1.GridControl = Me.gridControl1
            Me.tileView1.Name = "tileView1"
            Me.tileView1.OptionsBehavior.AllowSmoothScrolling = True
            Me.tileView1.OptionsHtmlTemplate.ItemAutoHeight = True
            Me.tileView1.OptionsTiles.ColumnCount = 1
            Me.tileView1.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None
            Me.tileView1.OptionsTiles.IndentBetweenItems = 4
            Me.tileView1.OptionsTiles.ItemSize = New System.Drawing.Size(420, 120)
            Me.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.tileView1.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
            Me.tileView1.TileHtmlTemplate.Styles = resources.GetString("tileView1.TileHtmlTemplate.Styles")
            Me.tileView1.TileHtmlTemplate.Tag = "Tile Template"
            Me.tileView1.TileHtmlTemplate.Template = resources.GetString("tileView1.TileHtmlTemplate.Template")
            ' 
            ' colName
            ' 
            Me.colName.Caption = "Name"
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 0
            ' 
            ' colDescription
            ' 
            Me.colDescription.Caption = "Description"
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 1
            ' 
            ' colEmployee
            ' 
            Me.colEmployee.Caption = "Employee"
            Me.colEmployee.FieldName = "Employee"
            Me.colEmployee.Name = "colEmployee"
            Me.colEmployee.Visible = True
            Me.colEmployee.VisibleIndex = 2
            ' 
            ' colStatus
            ' 
            Me.colStatus.Caption = "Status"
            Me.colStatus.FieldName = "Status"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.Visible = True
            Me.colStatus.VisibleIndex = 3
            ' 
            ' colDueDate
            ' 
            Me.colDueDate.Caption = "DueDate"
            Me.colDueDate.FieldName = "DueDate"
            Me.colDueDate.Name = "colDueDate"
            Me.colDueDate.Visible = True
            Me.colDueDate.VisibleIndex = 4
            ' 
            ' colPriority
            ' 
            Me.colPriority.Caption = "Priority"
            Me.colPriority.FieldName = "Priority"
            Me.colPriority.Name = "colPriority"
            Me.colPriority.Visible = True
            Me.colPriority.VisibleIndex = 5
            ' 
            ' colPriorityName
            ' 
            Me.colPriorityName.Caption = "PriorityName"
            Me.colPriorityName.FieldName = "PriorityName"
            Me.colPriorityName.Name = "colPriorityName"
            Me.colPriorityName.Visible = True
            Me.colPriorityName.VisibleIndex = 6
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.HtmlTemplate.Styles = ".tip {" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "background-color: @Window;" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "color: @WindowText;" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "box-shadow: 0px 1px 3" & "px 0px @Black;" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "padding: 6px;" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "border-radius: 6px;" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "}" & Global.Microsoft.VisualBasic.Constants.vbCrLf & ".container {" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "padding:" & " 5px;" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "}"
            Me.toolTipController1.HtmlTemplate.Template = "<div class=""container"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "<div class=""tip"">${ToolTip}</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tileViewTemplateCodeViewer1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(452, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(477, 432)
            Me.sidePanel1.TabIndex = 2
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' alertControl1
            ' 
            Me.alertControl1.AutoFormDelay = 2000
            Me.alertControl1.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast
            Me.alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopLeft
            Me.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.Reveal
            Me.alertControl1.HtmlTemplate.Styles = resources.GetString("alertControl1.HtmlTemplate.Styles")
            Me.alertControl1.HtmlTemplate.Template = "<div class=""container"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "    <div class=""shadow"">${Text}</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div>"
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("copy", "image://svgimages/edit/copy.svg")
            ' 
            ' TileViewAutoHeightModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "TileViewAutoHeightModule"
            Me.Size = New System.Drawing.Size(929, 432)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tileView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tileViewTemplateCodeViewer1 As DevExpress.HTML.Demos.TileViewTemplateCodeViewer

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private tileView1 As DevExpress.XtraGrid.Views.Tile.TileView

        Private colName As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colDescription As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colEmployee As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colStatus As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colDueDate As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colPriority As DevExpress.XtraGrid.Columns.TileViewColumn

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private colPriorityName As DevExpress.XtraGrid.Columns.TileViewColumn

        Private alertControl1 As DevExpress.XtraBars.Alerter.AlertControl

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
