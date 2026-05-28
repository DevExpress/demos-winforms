Namespace DevExpress.DevAV.Modules

    Partial Class TasksFilterPane

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
        Private Overloads Sub InitializeComponent()
            Me.btnNewTask = New DevExpress.XtraEditors.SimpleButton()
            Me.moduleLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.btnNewTaskLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.accordionControl = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.accordionLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.btnNewTaskLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.accordionControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.accordionLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.btnNewTask.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnNewTask.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewTasks.svg?Size=16x16"
            Me.btnNewTask.Location = New System.Drawing.Point(14, 14)
            Me.btnNewTask.MaximumSize = New System.Drawing.Size(150, 0)
            Me.btnNewTask.MinimumSize = New System.Drawing.Size(150, 0)
            Me.btnNewTask.Name = "btnNewTask"
            Me.btnNewTask.Size = New System.Drawing.Size(150, 22)
            Me.btnNewTask.StyleController = Me.moduleLayout
            Me.btnNewTask.TabIndex = 0
            Me.btnNewTask.Text = "New Task"
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.accordionControl)
            Me.moduleLayout.Controls.Add(Me.btnNewTask)
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.Root = Me.Root
            Me.moduleLayout.Size = New System.Drawing.Size(200, 603)
            Me.moduleLayout.TabIndex = 2
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.btnNewTaskLayoutControlItem, Me.accordionLayoutControlItem})
            Me.Root.Name = "Root"
            Me.Root.OptionsItemText.TextToControlDistance = 6
            Me.Root.Size = New System.Drawing.Size(200, 603)
            Me.btnNewTaskLayoutControlItem.Control = Me.btnNewTask
            Me.btnNewTaskLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNewTaskLayoutControlItem.CustomizationFormText = "btnNewTaskLayoutControlItem"
            Me.btnNewTaskLayoutControlItem.Location = New System.Drawing.Point(0, 0)
            Me.btnNewTaskLayoutControlItem.Name = "btnNewTaskLayoutControlItem"
            Me.btnNewTaskLayoutControlItem.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 16)
            Me.btnNewTaskLayoutControlItem.Size = New System.Drawing.Size(180, 42)
            Me.btnNewTaskLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.btnNewTaskLayoutControlItem.TextVisible = False
            Me.btnNewTaskLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.accordionControl.AllowItemSelection = True
            Me.accordionControl.ExpandGroupOnHeaderClick = False
            Me.accordionControl.Location = New System.Drawing.Point(16, 64)
            Me.accordionControl.Name = "accordionControl"
            Me.accordionControl.Size = New System.Drawing.Size(168, 523)
            Me.accordionControl.StyleController = Me.moduleLayout
            Me.accordionControl.TabIndex = 4
            Me.accordionLayoutControlItem.Control = Me.accordionControl
            Me.accordionLayoutControlItem.Location = New System.Drawing.Point(0, 48)
            Me.accordionLayoutControlItem.Name = "accordionLayoutControlItem"
            Me.accordionLayoutControlItem.Size = New System.Drawing.Size(174, 529)
            Me.accordionLayoutControlItem.TextVisible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Name = "TasksFilterPane"
            Me.Size = New System.Drawing.Size(200, 603)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.btnNewTaskLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.accordionControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.accordionLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private btnNewTask As DevExpress.XtraEditors.SimpleButton

        Private moduleLayout As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private btnNewTaskLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private accordionControl As DevExpress.XtraBars.Navigation.AccordionControl

        Private accordionLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
