Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class frmStyleConditions

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
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.sbRemove = New DevExpress.XtraEditors.SimpleButton()
            Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
            Me.sbAdd = New DevExpress.XtraEditors.SimpleButton()
            Me.FormatItemList = New DevExpress.XtraEditors.ListBoxControl()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.conditionItem1 = New DevExpress.XtraPivotGrid.Demos.ConditionItem()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.panelControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.FormatItemList), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.sbRemove)
            Me.panelControl1.Controls.Add(Me.panelControl3)
            Me.panelControl1.Controls.Add(Me.sbAdd)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(4, 4)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.panelControl1.Size = New System.Drawing.Size(503, 28)
            Me.panelControl1.TabIndex = 3
            ' 
            ' sbRemove
            ' 
            Me.sbRemove.Dock = System.Windows.Forms.DockStyle.Left
            Me.sbRemove.Enabled = False
            Me.sbRemove.Location = New System.Drawing.Point(164, 0)
            Me.sbRemove.Name = "sbRemove"
            Me.sbRemove.Size = New System.Drawing.Size(116, 24)
            Me.sbRemove.TabIndex = 1
            Me.sbRemove.Text = "Remove"
            AddHandler Me.sbRemove.Click, New System.EventHandler(AddressOf Me.sbRemove_Click)
            ' 
            ' panelControl3
            ' 
            Me.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.panelControl3.Appearance.Options.UseBackColor = True
            Me.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Left
            Me.panelControl3.Location = New System.Drawing.Point(156, 0)
            Me.panelControl3.Name = "panelControl3"
            Me.panelControl3.Size = New System.Drawing.Size(8, 24)
            Me.panelControl3.TabIndex = 2
            ' 
            ' sbAdd
            ' 
            Me.sbAdd.Dock = System.Windows.Forms.DockStyle.Left
            Me.sbAdd.Location = New System.Drawing.Point(0, 0)
            Me.sbAdd.Name = "sbAdd"
            Me.sbAdd.Size = New System.Drawing.Size(156, 24)
            Me.sbAdd.TabIndex = 0
            Me.sbAdd.Text = "Add New Style Condition"
            AddHandler Me.sbAdd.Click, New System.EventHandler(AddressOf Me.sbAdd_Click)
            ' 
            ' FormatItemList
            ' 
            Me.FormatItemList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.FormatItemList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FormatItemList.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
            Me.FormatItemList.ItemHeight = 16
            Me.FormatItemList.Location = New System.Drawing.Point(0, 0)
            Me.FormatItemList.Name = "FormatItemList"
            Me.FormatItemList.Size = New System.Drawing.Size(158, 332)
            Me.FormatItemList.TabIndex = 4
            AddHandler Me.FormatItemList.SelectedIndexChanged, New System.EventHandler(AddressOf Me.FormatItemList_SelectedIndexChanged)
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(4, 32)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.FormatItemList)
            Me.splitContainerControl1.Panel1.Text = "splitContainerControl1_Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.conditionItem1)
            Me.splitContainerControl1.Panel2.Text = "splitContainerControl1_Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(503, 332)
            Me.splitContainerControl1.SplitterPosition = 158
            Me.splitContainerControl1.TabIndex = 5
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' conditionItem1
            ' 
            Me.conditionItem1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.conditionItem1.Location = New System.Drawing.Point(0, 0)
            Me.conditionItem1.Name = "conditionItem1"
            Me.conditionItem1.Size = New System.Drawing.Size(339, 332)
            Me.conditionItem1.TabIndex = 0
            AddHandler Me.conditionItem1.RefreshValues, New System.EventHandler(AddressOf Me.conditionItem1_RefreshValues)
            ' 
            ' frmStyleConditions
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(511, 368)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.KeyPreview = True
            Me.Name = "frmStyleConditions"
            Me.Padding = New System.Windows.Forms.Padding(4)
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Style Conditions Editor"
            AddHandler Me.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.frmStyleConditions_KeyDown)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.panelControl3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.FormatItemList), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private sbRemove As DevExpress.XtraEditors.SimpleButton

        Private panelControl3 As DevExpress.XtraEditors.PanelControl

        Private sbAdd As DevExpress.XtraEditors.SimpleButton

        Private FormatItemList As DevExpress.XtraEditors.ListBoxControl

        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl

        Private components As System.ComponentModel.Container = Nothing
    End Class
End Namespace
