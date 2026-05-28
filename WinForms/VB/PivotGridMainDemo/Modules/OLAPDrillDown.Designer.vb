Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class OLAPDrillDown

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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.panelError = New DevExpress.XtraEditors.PanelControl()
            Me.hyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
            Me.controlPanel = New DevExpress.XtraEditors.PanelControl()
            Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelError), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelError.SuspendLayout()
            CType((Me.hyperLinkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainPanel.SuspendLayout()
            CType((Me.controlPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.controlPanel.SuspendLayout()
            CType((Me.paddingPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl
            ' 
            Me.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.OptionsCustomization.CustomizationFormSearchBoxVisible = True
            Me.pivotGridControl.Size = New System.Drawing.Size(710, 350)
            Me.pivotGridControl.TabIndex = 1
            AddHandler Me.pivotGridControl.CellDoubleClick, New DevExpress.XtraPivotGrid.PivotCellEventHandler(AddressOf Me.pivotGridControl_CellDoubleClick)
            ' 
            ' panelError
            ' 
            Me.panelError.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelError.Controls.Add(Me.hyperLinkEdit1)
            Me.panelError.Controls.Add(Me.labelControl2)
            Me.panelError.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelError.Location = New System.Drawing.Point(2, 2)
            Me.panelError.Name = "panelError"
            Me.panelError.Size = New System.Drawing.Size(706, 48)
            Me.panelError.TabIndex = 6
            ' 
            ' hyperLinkEdit1
            ' 
            Me.hyperLinkEdit1.EditValue = "http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB"
            Me.hyperLinkEdit1.Location = New System.Drawing.Point(454, 20)
            Me.hyperLinkEdit1.Name = "hyperLinkEdit1"
            Me.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.hyperLinkEdit1.Properties.Caption = "www.microsoft.com"
            Me.hyperLinkEdit1.Size = New System.Drawing.Size(100, 18)
            Me.hyperLinkEdit1.TabIndex = 1
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.labelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red
            Me.labelControl2.Appearance.Options.UseFont = True
            Me.labelControl2.Appearance.Options.UseForeColor = True
            Me.labelControl2.AutoEllipsis = True
            Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl2.Location = New System.Drawing.Point(12, 8)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(683, 28)
            Me.labelControl2.TabIndex = 0
            Me.labelControl2.Text = "To run this demo, you should have Microsoft SQL Server Analysis Services OLE DB 8" & ".0 (or later) " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "installed on your system. You can get the latest version of this" & " provider here:"
            ' 
            ' mainPanel
            ' 
            Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mainPanel.Controls.Add(Me.pivotGridControl)
            Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainPanel.Location = New System.Drawing.Point(0, 60)
            Me.mainPanel.Name = "mainPanel"
            Me.mainPanel.Size = New System.Drawing.Size(710, 350)
            Me.mainPanel.TabIndex = 11
            ' 
            ' controlPanel
            ' 
            Me.controlPanel.AutoSize = True
            Me.controlPanel.Controls.Add(Me.panelError)
            Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.controlPanel.Location = New System.Drawing.Point(0, 0)
            Me.controlPanel.Name = "controlPanel"
            Me.controlPanel.Size = New System.Drawing.Size(710, 52)
            Me.controlPanel.TabIndex = 10
            ' 
            ' paddingPanel
            ' 
            Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.paddingPanel.Location = New System.Drawing.Point(0, 52)
            Me.paddingPanel.Name = "paddingPanel"
            Me.paddingPanel.Size = New System.Drawing.Size(710, 8)
            Me.paddingPanel.TabIndex = 12
            ' 
            ' OLAPDrillDown
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mainPanel)
            Me.Controls.Add(Me.paddingPanel)
            Me.Controls.Add(Me.controlPanel)
            Me.Name = "OLAPDrillDown"
            Me.Size = New System.Drawing.Size(710, 410)
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelError), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelError.ResumeLayout(False)
            CType((Me.hyperLinkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainPanel.ResumeLayout(False)
            CType((Me.controlPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.controlPanel.ResumeLayout(False)
            CType((Me.paddingPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl

        Private panelError As DevExpress.XtraEditors.PanelControl

        Private hyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private mainPanel As DevExpress.XtraEditors.PanelControl

        Private controlPanel As DevExpress.XtraEditors.PanelControl

        Private paddingPanel As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
