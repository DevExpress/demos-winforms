Namespace DevExpress.MailClient.Win.Controls
    Partial Public Class ucCalendar
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ucCalendar))
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
            Me.treeResources = New DevExpress.XtraTreeList.TreeList()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            DirectCast(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateNavigator1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.treeResources, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dateNavigator1
            ' 
            Me.dateNavigator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.dateNavigator1.CalendarIndent = 0
            Me.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("dateNavigator1.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.dateNavigator1.CellPadding = New System.Windows.Forms.Padding(-2, -1, -2, -2)
            Me.dateNavigator1.DateTime = New Date(2011, 12, 29, 0, 0, 0, 0)
            resources.ApplyResources(Me.dateNavigator1, "dateNavigator1")
            Me.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Monday
            Me.dateNavigator1.Name = "dateNavigator1"
            ' 
            ' treeResources
            ' 
            Me.treeResources.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.treeResources.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1})
            resources.ApplyResources(Me.treeResources, "treeResources")
            Me.treeResources.Name = "treeResources"
            Me.treeResources.OptionsBehavior.Editable = False
            Me.treeResources.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None
            Me.treeResources.OptionsView.ShowCheckBoxes = True
            Me.treeResources.OptionsView.ShowColumns = False
            Me.treeResources.OptionsView.ShowHorzLines = False
            Me.treeResources.OptionsView.ShowIndicator = False
            Me.treeResources.OptionsView.ShowVertLines = False
            ' 
            ' treeListColumn1
            ' 
            Me.treeListColumn1.FieldName = "Name"
            resources.ApplyResources(Me.treeListColumn1, "treeListColumn1")
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.OptionsColumn.AllowFocus = False
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' ucCalendar
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dateNavigator1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.treeResources)
            Me.Name = "ucCalendar"
            DirectCast(Me.dateNavigator1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.treeResources, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
        Private WithEvents treeResources As DevExpress.XtraTreeList.TreeList
        Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
