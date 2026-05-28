Namespace DevExpress.DevAV

    Partial Class YearsControl

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
            Me.checkedComboBoxEdit1 = New DevExpress.XtraEditors.CheckedComboBoxEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.settingsLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsLayout.SuspendLayout()
            CType((Me.checkedComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsLayout.AllowCustomization = False
            Me.settingsLayout.Controls.Add(Me.checkedComboBoxEdit1)
            Me.settingsLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.settingsLayout.Location = New System.Drawing.Point(0, 0)
            Me.settingsLayout.Name = "settingsLayout"
            Me.settingsLayout.Root = Me.Root
            Me.settingsLayout.Size = New System.Drawing.Size(238, 232)
            Me.settingsLayout.TabIndex = 3
            Me.checkedComboBoxEdit1.EditValue = ""
            Me.checkedComboBoxEdit1.Location = New System.Drawing.Point(0, 0)
            Me.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1"
            Me.checkedComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.checkedComboBoxEdit1.Size = New System.Drawing.Size(238, 20)
            Me.checkedComboBoxEdit1.StyleController = Me.settingsLayout
            Me.checkedComboBoxEdit1.TabIndex = 4
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(238, 232)
            Me.Root.Text = "Root"
            Me.layoutControlItem1.Control = Me.checkedComboBoxEdit1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(238, 232)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.settingsLayout)
            Me.Name = "YearsControl"
            Me.Size = New System.Drawing.Size(238, 232)
            CType((Me.settingsLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsLayout.ResumeLayout(False)
            CType((Me.checkedComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private settingsLayout As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private checkedComboBoxEdit1 As DevExpress.XtraEditors.CheckedComboBoxEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
