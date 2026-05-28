
namespace DevExpress.HTML.Demos
{
    partial class GanttControlModule
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GanttControlModule));
            this.ganttControl1 = new DevExpress.XtraGantt.GanttControl();
            this.taskNameColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.startDateColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.finishDateColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.columnPhoto = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.columnEmployee = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.columnColor = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.resourceColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TaskTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.TaskProgressTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.TaskTextLabelTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.codeViewerPanel = new DevExpress.XtraEditors.SidePanel();
            this.templateViewer = new DevExpress.HTML.Demos.GanttTemplateCodeViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).BeginInit();
            this.codeViewerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ganttControl1
            // 
            this.ganttControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ganttControl1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.taskNameColumn,
            this.startDateColumn,
            this.finishDateColumn,
            this.columnPhoto,
            this.columnEmployee,
            this.columnColor,
            this.resourceColumn});
            this.ganttControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ganttControl1.HtmlTemplates.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.TaskTemplate,
            this.TaskProgressTemplate,
            this.TaskTextLabelTemplate});
            this.ganttControl1.Location = new System.Drawing.Point(0, 0);
            this.ganttControl1.Name = "ganttControl1";
            this.ganttControl1.OptionsCustomization.AllowModifyDependencies = DevExpress.Utils.DefaultBoolean.True;
            this.ganttControl1.OptionsCustomization.AllowModifyProgress = DevExpress.Utils.DefaultBoolean.True;
            this.ganttControl1.OptionsCustomization.AllowModifyTasks = DevExpress.Utils.DefaultBoolean.True;
            this.ganttControl1.OptionsSplitter.PanelVisibility = DevExpress.XtraGantt.GanttPanelVisibility.Chart;
            this.ganttControl1.RowHeight = 76;
            this.ganttControl1.Size = new System.Drawing.Size(491, 501);
            this.ganttControl1.SplitterPosition = 330;
            this.ganttControl1.TabIndex = 0;
            // 
            // taskNameColumn
            // 
            this.taskNameColumn.Caption = "Task Name";
            this.taskNameColumn.FieldName = "Name";
            this.taskNameColumn.Name = "taskNameColumn";
            this.taskNameColumn.Visible = true;
            this.taskNameColumn.VisibleIndex = 0;
            this.taskNameColumn.Width = 194;
            // 
            // startDateColumn
            // 
            this.startDateColumn.Caption = "Start Date";
            this.startDateColumn.FieldName = "StartDate";
            this.startDateColumn.Name = "startDateColumn";
            this.startDateColumn.Visible = true;
            this.startDateColumn.VisibleIndex = 1;
            this.startDateColumn.Width = 68;
            // 
            // finishDateColumn
            // 
            this.finishDateColumn.Caption = "Finish Date";
            this.finishDateColumn.FieldName = "FinishDate";
            this.finishDateColumn.Name = "finishDateColumn";
            this.finishDateColumn.Visible = true;
            this.finishDateColumn.VisibleIndex = 2;
            this.finishDateColumn.Width = 68;
            // 
            // columnPhoto
            // 
            this.columnPhoto.Caption = "Photo";
            this.columnPhoto.FieldName = "Photo";
            this.columnPhoto.Name = "columnPhoto";
            // 
            // columnEmployee
            // 
            this.columnEmployee.Caption = "Employee";
            this.columnEmployee.FieldName = "Employee";
            this.columnEmployee.Name = "columnEmployee";
            // 
            // columnColor
            // 
            this.columnColor.Caption = "Color";
            this.columnColor.FieldName = "Color";
            this.columnColor.Name = "columnColor";
            // 
            // resourceColumn
            // 
            this.resourceColumn.Caption = "Resource";
            this.resourceColumn.FieldName = "Resource";
            this.resourceColumn.Name = "resourceColumn";
            // 
            // TaskTemplate
            // 
            this.TaskTemplate.Name = "TaskTemplate";
            this.TaskTemplate.Styles = resources.GetString("TaskTemplate.Styles");
            this.TaskTemplate.Tag = "Task Template";
            this.TaskTemplate.Template = resources.GetString("TaskTemplate.Template");
            // 
            // TaskProgressTemplate
            // 
            this.TaskProgressTemplate.Name = "TaskProgressTemplate";
            this.TaskProgressTemplate.Styles = resources.GetString("TaskProgressTemplate.Styles");
            this.TaskProgressTemplate.Tag = "Task Progress Template";
            this.TaskProgressTemplate.Template = "<div class=\"task-progress-container\">\r\n\t<div class=\"task-progress\"></div>\r\n</div>" +
    "";
            // 
            // TaskTextLabelTemplate
            // 
            this.TaskTextLabelTemplate.Name = "TaskTextLabelTemplate";
            this.TaskTextLabelTemplate.Styles = resources.GetString("TaskTextLabelTemplate.Styles");
            this.TaskTextLabelTemplate.Tag = "Task Text Label Template";
            this.TaskTextLabelTemplate.Template = "<div id =\"label\" class=\"task-text-label\" dx-class=\"{ColorName}\">\r\n\t<div class=\"ta" +
    "sk-text-label-text\">${Resource}</div>\r\n</div>";
            // 
            // codeViewerPanel
            // 
            this.codeViewerPanel.Controls.Add(this.templateViewer);
            this.codeViewerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.codeViewerPanel.Location = new System.Drawing.Point(491, 0);
            this.codeViewerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.codeViewerPanel.Name = "codeViewerPanel";
            this.codeViewerPanel.Size = new System.Drawing.Size(410, 501);
            this.codeViewerPanel.TabIndex = 1;
            this.codeViewerPanel.Text = "sidePanel1";
            // 
            // templateViewer
            // 
            this.templateViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateViewer.Location = new System.Drawing.Point(1, 0);
            this.templateViewer.Name = "templateViewer";
            this.templateViewer.Size = new System.Drawing.Size(409, 501);
            this.templateViewer.TabIndex = 0;
            // 
            // GanttControlModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ganttControl1);
            this.Controls.Add(this.codeViewerPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GanttControlModule";
            this.Size = new System.Drawing.Size(901, 501);
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).EndInit();
            this.codeViewerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraGantt.GanttControl ganttControl1;
        private XtraTreeList.Columns.TreeListColumn taskNameColumn;
        private XtraTreeList.Columns.TreeListColumn startDateColumn;
        private XtraTreeList.Columns.TreeListColumn finishDateColumn;
        private XtraTreeList.Columns.TreeListColumn columnPhoto;
        private XtraTreeList.Columns.TreeListColumn columnEmployee;
        private XtraTreeList.Columns.TreeListColumn columnColor;
        private Utils.Html.HtmlTemplate TaskTemplate;
        private Utils.Html.HtmlTemplate TaskProgressTemplate;
        private Utils.Html.HtmlTemplate TaskTextLabelTemplate;
        private XtraTreeList.Columns.TreeListColumn resourceColumn;
        private XtraEditors.SidePanel codeViewerPanel;
        private GanttTemplateCodeViewer templateViewer;
    }
}
