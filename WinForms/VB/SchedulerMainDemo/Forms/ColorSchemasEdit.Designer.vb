Imports System
Imports System.Windows.Forms
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid

Namespace DevExpress.XtraScheduler.Demos

    Partial Class ColorSchemasEditForm

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.btnDefaults = New DevExpress.XtraEditors.SimpleButton()
            Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
            Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.lbTimeScales = New DevExpress.XtraEditors.ListBoxControl()
            Me.propertyGrid1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType((Me.lbTimeScales), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.propertyGrid1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' btnDefaults
            ' 
            Me.btnDefaults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnDefaults.ImageIndex = 2
            Me.btnDefaults.Location = New System.Drawing.Point(370, 288)
            Me.btnDefaults.Name = "btnDefaults"
            Me.btnDefaults.Size = New System.Drawing.Size(125, 24)
            Me.btnDefaults.TabIndex = 30
            Me.btnDefaults.Text = "Restore &Defaults"
            AddHandler Me.btnDefaults.Click, New System.EventHandler(AddressOf Me.btnDefaults_Click)
            ' 
            ' btnAdd
            ' 
            Me.btnAdd.ImageIndex = 2
            Me.btnAdd.Location = New System.Drawing.Point(12, 288)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(80, 24)
            Me.btnAdd.TabIndex = 29
            Me.btnAdd.Text = "&Add"
            AddHandler Me.btnAdd.Click, New System.EventHandler(AddressOf Me.btnAdd_Click)
            ' 
            ' btnRemove
            ' 
            Me.btnRemove.ImageIndex = 2
            Me.btnRemove.Location = New System.Drawing.Point(98, 288)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Size = New System.Drawing.Size(80, 24)
            Me.btnRemove.TabIndex = 28
            Me.btnRemove.Text = "&Remove"
            AddHandler Me.btnRemove.Click, New System.EventHandler(AddressOf Me.btnRemove_Click)
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.lbTimeScales)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.propertyGrid1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(507, 282)
            Me.splitContainerControl1.SplitterPosition = 179
            Me.splitContainerControl1.TabIndex = 29
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' lbTimeScales
            ' 
            Me.lbTimeScales.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbTimeScales.ItemHeight = 16
            Me.lbTimeScales.Location = New System.Drawing.Point(0, 0)
            Me.lbTimeScales.Name = "lbTimeScales"
            Me.lbTimeScales.Size = New System.Drawing.Size(175, 278)
            Me.lbTimeScales.TabIndex = 26
            AddHandler Me.lbTimeScales.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lbcAppearances_SelectedIndexChanged)
            ' 
            ' propertyGrid1
            ' 
            Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGrid1.Location = New System.Drawing.Point(0, 0)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.OptionsView.ShowRootCategories = False
            Me.propertyGrid1.ServiceProvider = Nothing
            Me.propertyGrid1.Size = New System.Drawing.Size(318, 278)
            Me.propertyGrid1.TabIndex = 25
            ' 
            ' ColorSchemasEditForm
            ' 
            Me.ClientSize = New System.Drawing.Size(507, 322)
            Me.Controls.Add(Me.btnDefaults)
            Me.Controls.Add(Me.btnAdd)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.btnRemove)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.Name = "ColorSchemasEditForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Color Schemas"
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType((Me.lbTimeScales), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.propertyGrid1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Private btnDefaults As DevExpress.XtraEditors.SimpleButton

        Private btnAdd As DevExpress.XtraEditors.SimpleButton

        Private btnRemove As DevExpress.XtraEditors.SimpleButton

        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl

        Private lbTimeScales As DevExpress.XtraEditors.ListBoxControl

        Private propertyGrid1 As DevExpress.XtraVerticalGrid.PropertyGridControl
    End Class
End Namespace
