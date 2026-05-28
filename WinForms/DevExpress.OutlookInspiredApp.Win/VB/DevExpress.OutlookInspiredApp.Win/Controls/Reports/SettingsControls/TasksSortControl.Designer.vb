Namespace DevExpress.DevAV

    Partial Class TasksSortControl

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
            Me.settingsLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.btnDueDate = New DevExpress.XtraEditors.CheckButton()
            Me.btnStartDate = New DevExpress.XtraEditors.CheckButton()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.settingsLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsLayout.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsLayout.AllowCustomization = False
            Me.settingsLayout.Controls.Add(Me.btnDueDate)
            Me.settingsLayout.Controls.Add(Me.btnStartDate)
            Me.settingsLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.settingsLayout.Location = New System.Drawing.Point(0, 0)
            Me.settingsLayout.Name = "settingsLayout"
            Me.settingsLayout.Root = Me.Root
            Me.settingsLayout.Size = New System.Drawing.Size(238, 232)
            Me.settingsLayout.TabIndex = 3
            Me.btnDueDate.Checked = True
            Me.btnDueDate.GroupIndex = 1
            Me.btnDueDate.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnDueDate.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ShowDueDate.svg"
            Me.btnDueDate.Location = New System.Drawing.Point(0, 0)
            Me.btnDueDate.MaximumSize = New System.Drawing.Size(0, 40)
            Me.btnDueDate.MinimumSize = New System.Drawing.Size(0, 40)
            Me.btnDueDate.Name = "btnDueDate"
            Me.btnDueDate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnDueDate.Size = New System.Drawing.Size(238, 40)
            Me.btnDueDate.StyleController = Me.settingsLayout
            Me.btnDueDate.TabIndex = 2
            Me.btnDueDate.Text = "Sort by Due Date"
            AddHandler Me.btnDueDate.CheckedChanged, New System.EventHandler(AddressOf Me.btnDueDate_CheckedChanged)
            Me.btnStartDate.GroupIndex = 1
            Me.btnStartDate.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnStartDate.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ShowStartDate.svg"
            Me.btnStartDate.Location = New System.Drawing.Point(0, 40)
            Me.btnStartDate.MaximumSize = New System.Drawing.Size(0, 40)
            Me.btnStartDate.MinimumSize = New System.Drawing.Size(0, 40)
            Me.btnStartDate.Name = "btnStartDate"
            Me.btnStartDate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnStartDate.Size = New System.Drawing.Size(238, 40)
            Me.btnStartDate.StyleController = Me.settingsLayout
            Me.btnStartDate.TabIndex = 2
            Me.btnStartDate.TabStop = False
            Me.btnStartDate.Text = "Sort by Start Date"
            AddHandler Me.btnStartDate.CheckedChanged, New System.EventHandler(AddressOf Me.btnStartDate_CheckedChanged)
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(238, 232)
            Me.layoutControlItem1.Control = Me.btnDueDate
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(238, 40)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem2.Control = Me.btnStartDate
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(238, 192)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.settingsLayout)
            Me.Name = "TasksSortControl"
            Me.Size = New System.Drawing.Size(238, 232)
            CType((Me.settingsLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsLayout.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private settingsLayout As DevExpress.XtraLayout.LayoutControl

        Private btnDueDate As DevExpress.XtraEditors.CheckButton

        Private btnStartDate As DevExpress.XtraEditors.CheckButton

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
