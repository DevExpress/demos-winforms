Namespace DevExpress.HTML.Demos

    Partial Class GanttControlModule

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.GanttControlModule))
            Me.ganttControl1 = New DevExpress.XtraGantt.GanttControl()
            Me.taskNameColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.startDateColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.finishDateColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.columnPhoto = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.columnEmployee = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.columnColor = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.resourceColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.TaskTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.TaskProgressTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.TaskTextLabelTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.codeViewerPanel = New DevExpress.XtraEditors.SidePanel()
            Me.templateViewer = New DevExpress.HTML.Demos.GanttTemplateCodeViewer()
            CType((Me.ganttControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.codeViewerPanel.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' ganttControl1
            ' 
            Me.ganttControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.ganttControl1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.taskNameColumn, Me.startDateColumn, Me.finishDateColumn, Me.columnPhoto, Me.columnEmployee, Me.columnColor, Me.resourceColumn})
            Me.ganttControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ganttControl1.HtmlTemplates.AddRange(New DevExpress.Utils.Html.HtmlTemplate() {Me.TaskTemplate, Me.TaskProgressTemplate, Me.TaskTextLabelTemplate})
            Me.ganttControl1.Location = New System.Drawing.Point(0, 0)
            Me.ganttControl1.Name = "ganttControl1"
            Me.ganttControl1.OptionsCustomization.AllowModifyDependencies = DevExpress.Utils.DefaultBoolean.[True]
            Me.ganttControl1.OptionsCustomization.AllowModifyProgress = DevExpress.Utils.DefaultBoolean.[True]
            Me.ganttControl1.OptionsCustomization.AllowModifyTasks = DevExpress.Utils.DefaultBoolean.[True]
            Me.ganttControl1.OptionsSplitter.PanelVisibility = DevExpress.XtraGantt.GanttPanelVisibility.Chart
            Me.ganttControl1.RowHeight = 76
            Me.ganttControl1.Size = New System.Drawing.Size(491, 501)
            Me.ganttControl1.SplitterPosition = 330
            Me.ganttControl1.TabIndex = 0
            ' 
            ' taskNameColumn
            ' 
            Me.taskNameColumn.Caption = "Task Name"
            Me.taskNameColumn.FieldName = "Name"
            Me.taskNameColumn.Name = "taskNameColumn"
            Me.taskNameColumn.Visible = True
            Me.taskNameColumn.VisibleIndex = 0
            Me.taskNameColumn.Width = 194
            ' 
            ' startDateColumn
            ' 
            Me.startDateColumn.Caption = "Start Date"
            Me.startDateColumn.FieldName = "StartDate"
            Me.startDateColumn.Name = "startDateColumn"
            Me.startDateColumn.Visible = True
            Me.startDateColumn.VisibleIndex = 1
            Me.startDateColumn.Width = 68
            ' 
            ' finishDateColumn
            ' 
            Me.finishDateColumn.Caption = "Finish Date"
            Me.finishDateColumn.FieldName = "FinishDate"
            Me.finishDateColumn.Name = "finishDateColumn"
            Me.finishDateColumn.Visible = True
            Me.finishDateColumn.VisibleIndex = 2
            Me.finishDateColumn.Width = 68
            ' 
            ' columnPhoto
            ' 
            Me.columnPhoto.Caption = "Photo"
            Me.columnPhoto.FieldName = "Photo"
            Me.columnPhoto.Name = "columnPhoto"
            ' 
            ' columnEmployee
            ' 
            Me.columnEmployee.Caption = "Employee"
            Me.columnEmployee.FieldName = "Employee"
            Me.columnEmployee.Name = "columnEmployee"
            ' 
            ' columnColor
            ' 
            Me.columnColor.Caption = "Color"
            Me.columnColor.FieldName = "Color"
            Me.columnColor.Name = "columnColor"
            ' 
            ' resourceColumn
            ' 
            Me.resourceColumn.Caption = "Resource"
            Me.resourceColumn.FieldName = "Resource"
            Me.resourceColumn.Name = "resourceColumn"
            ' 
            ' TaskTemplate
            ' 
            Me.TaskTemplate.Name = "TaskTemplate"
            Me.TaskTemplate.Styles = resources.GetString("TaskTemplate.Styles")
            Me.TaskTemplate.Tag = "Task Template"
            Me.TaskTemplate.Template = resources.GetString("TaskTemplate.Template")
            ' 
            ' TaskProgressTemplate
            ' 
            Me.TaskProgressTemplate.Name = "TaskProgressTemplate"
            Me.TaskProgressTemplate.Styles = resources.GetString("TaskProgressTemplate.Styles")
            Me.TaskProgressTemplate.Tag = "Task Progress Template"
            Me.TaskProgressTemplate.Template = "<div class=""task-progress-container"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "<div class=""task-progress""></div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div>" & ""
            ' 
            ' TaskTextLabelTemplate
            ' 
            Me.TaskTextLabelTemplate.Name = "TaskTextLabelTemplate"
            Me.TaskTextLabelTemplate.Styles = resources.GetString("TaskTextLabelTemplate.Styles")
            Me.TaskTextLabelTemplate.Tag = "Task Text Label Template"
            Me.TaskTextLabelTemplate.Template = "<div id =""label"" class=""task-text-label"" dx-class=""{ColorName}"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "<div class=""ta" & "sk-text-label-text"">${Resource}</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div>"
            ' 
            ' codeViewerPanel
            ' 
            Me.codeViewerPanel.Controls.Add(Me.templateViewer)
            Me.codeViewerPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.codeViewerPanel.Location = New System.Drawing.Point(491, 0)
            Me.codeViewerPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.codeViewerPanel.Name = "codeViewerPanel"
            Me.codeViewerPanel.Size = New System.Drawing.Size(410, 501)
            Me.codeViewerPanel.TabIndex = 1
            Me.codeViewerPanel.Text = "sidePanel1"
            ' 
            ' templateViewer
            ' 
            Me.templateViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.templateViewer.Location = New System.Drawing.Point(1, 0)
            Me.templateViewer.Name = "templateViewer"
            Me.templateViewer.Size = New System.Drawing.Size(409, 501)
            Me.templateViewer.TabIndex = 0
            ' 
            ' GanttControlModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ganttControl1)
            Me.Controls.Add(Me.codeViewerPanel)
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "GanttControlModule"
            Me.Size = New System.Drawing.Size(901, 501)
            CType((Me.ganttControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.codeViewerPanel.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private ganttControl1 As DevExpress.XtraGantt.GanttControl

        Private taskNameColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private startDateColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private finishDateColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private columnPhoto As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private columnEmployee As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private columnColor As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private TaskTemplate As DevExpress.Utils.Html.HtmlTemplate

        Private TaskProgressTemplate As DevExpress.Utils.Html.HtmlTemplate

        Private TaskTextLabelTemplate As DevExpress.Utils.Html.HtmlTemplate

        Private resourceColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private codeViewerPanel As DevExpress.XtraEditors.SidePanel

        Private templateViewer As DevExpress.HTML.Demos.GanttTemplateCodeViewer
    End Class
End Namespace
