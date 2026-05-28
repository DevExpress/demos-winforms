Namespace DevExpress.DevAV

    Partial Class SortOrderControl

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
            Me.btnAscendingOrder = New DevExpress.XtraEditors.CheckButton()
            Me.btnDescendingOrder = New DevExpress.XtraEditors.CheckButton()
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
            Me.settingsLayout.Controls.Add(Me.btnAscendingOrder)
            Me.settingsLayout.Controls.Add(Me.btnDescendingOrder)
            Me.settingsLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.settingsLayout.Location = New System.Drawing.Point(0, 0)
            Me.settingsLayout.Name = "settingsLayout"
            Me.settingsLayout.Root = Me.Root
            Me.settingsLayout.Size = New System.Drawing.Size(238, 232)
            Me.settingsLayout.TabIndex = 3
            Me.btnAscendingOrder.Checked = True
            Me.btnAscendingOrder.GroupIndex = 1
            Me.btnAscendingOrder.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnAscendingOrder.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SortDesc.svg"
            Me.btnAscendingOrder.Location = New System.Drawing.Point(0, 0)
            Me.btnAscendingOrder.MaximumSize = New System.Drawing.Size(0, 40)
            Me.btnAscendingOrder.MinimumSize = New System.Drawing.Size(0, 40)
            Me.btnAscendingOrder.Name = "btnAscendingOrder"
            Me.btnAscendingOrder.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnAscendingOrder.Size = New System.Drawing.Size(238, 40)
            Me.btnAscendingOrder.StyleController = Me.settingsLayout
            Me.btnAscendingOrder.TabIndex = 2
            Me.btnAscendingOrder.Text = "Ascending Order"
            AddHandler Me.btnAscendingOrder.CheckedChanged, New System.EventHandler(AddressOf Me.btnAscendingOrder_CheckedChanged)
            Me.btnDescendingOrder.GroupIndex = 1
            Me.btnDescendingOrder.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnDescendingOrder.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SortAsc.svg"
            Me.btnDescendingOrder.Location = New System.Drawing.Point(0, 40)
            Me.btnDescendingOrder.MaximumSize = New System.Drawing.Size(0, 40)
            Me.btnDescendingOrder.MinimumSize = New System.Drawing.Size(0, 40)
            Me.btnDescendingOrder.Name = "btnDescendingOrder"
            Me.btnDescendingOrder.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnDescendingOrder.Size = New System.Drawing.Size(238, 40)
            Me.btnDescendingOrder.StyleController = Me.settingsLayout
            Me.btnDescendingOrder.TabIndex = 2
            Me.btnDescendingOrder.TabStop = False
            Me.btnDescendingOrder.Text = "Descending Order"
            AddHandler Me.btnDescendingOrder.CheckedChanged, New System.EventHandler(AddressOf Me.btnDescendingOrder_CheckedChanged)
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(238, 232)
            Me.layoutControlItem1.Control = Me.btnAscendingOrder
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(238, 40)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem2.Control = Me.btnDescendingOrder
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
            Me.Name = "SortOrderControl"
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

        Private btnAscendingOrder As DevExpress.XtraEditors.CheckButton

        Private btnDescendingOrder As DevExpress.XtraEditors.CheckButton

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
