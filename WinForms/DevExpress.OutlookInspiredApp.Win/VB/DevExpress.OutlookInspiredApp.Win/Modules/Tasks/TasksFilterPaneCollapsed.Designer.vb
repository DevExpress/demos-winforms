Namespace DevExpress.DevAV.Modules

    Partial Class TasksFilterPaneCollapsed

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
            Me.moduleLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.navigationBar = New DevExpress.XtraBars.Navigation.OfficeNavigationBar()
            Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.btnNewLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.filtersLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType((Me.navigationBar), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.btnNewLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.filtersLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.navigationBar)
            Me.moduleLayout.Controls.Add(Me.btnNew)
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.Root = Me.Root
            Me.moduleLayout.Size = New System.Drawing.Size(60, 600)
            Me.moduleLayout.TabIndex = 1
            Me.navigationBar.AnimateItemPressing = False
            Me.navigationBar.AutoSize = False
            Me.navigationBar.CustomizationButtonVisibility = DevExpress.XtraBars.Navigation.CustomizationButtonVisibility.Hidden
            Me.navigationBar.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.navigationBar.ItemSkinning = True
            Me.navigationBar.Location = New System.Drawing.Point(12, 38)
            Me.navigationBar.MaximumSize = New System.Drawing.Size(50, 0)
            Me.navigationBar.Name = "navigationBar"
            Me.navigationBar.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.navigationBar.ShowPeekFormOnItemHover = False
            Me.navigationBar.Size = New System.Drawing.Size(46, 550)
            Me.navigationBar.TabIndex = 2
            Me.btnNew.Image = Global.DevExpress.DevAV.Properties.Resources.icon_new_employee_16
            Me.btnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.btnNew.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnNew.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewEmploye.svg?Size=16x16"
            Me.btnNew.Location = New System.Drawing.Point(12, 12)
            Me.btnNew.Name = "btnNew"
            Me.btnNew.Size = New System.Drawing.Size(46, 22)
            Me.btnNew.StyleController = Me.moduleLayout
            Me.btnNew.TabIndex = 0
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.btnNewLayoutControlItem, Me.filtersLayoutControlItem})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 0, 10, 10)
            Me.Root.Size = New System.Drawing.Size(60, 600)
            Me.btnNewLayoutControlItem.Control = Me.btnNew
            Me.btnNewLayoutControlItem.CustomizationFormText = "New"
            Me.btnNewLayoutControlItem.Location = New System.Drawing.Point(0, 0)
            Me.btnNewLayoutControlItem.Name = "btnNewLayoutControlItem"
            Me.btnNewLayoutControlItem.Size = New System.Drawing.Size(50, 26)
            Me.btnNewLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.btnNewLayoutControlItem.TextVisible = False
            Me.btnNewLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.filtersLayoutControlItem.Control = Me.navigationBar
            Me.filtersLayoutControlItem.CustomizationFormText = "layoutControlItem2"
            Me.filtersLayoutControlItem.Location = New System.Drawing.Point(0, 26)
            Me.filtersLayoutControlItem.Name = "layoutControlItem2"
            Me.filtersLayoutControlItem.Size = New System.Drawing.Size(50, 554)
            Me.filtersLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.filtersLayoutControlItem.TextVisible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Name = "GanttFilterPaneCollapsed"
            Me.Size = New System.Drawing.Size(60, 600)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType((Me.navigationBar), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.btnNewLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.filtersLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private btnNew As DevExpress.XtraEditors.SimpleButton

        Private navigationBar As DevExpress.XtraBars.Navigation.OfficeNavigationBar

        Private moduleLayout As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private btnNewLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private filtersLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
