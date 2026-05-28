Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class InTransactionMode
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

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gclInTransactionModeMain = New DevExpress.XtraGrid.GridControl
            Me.gvlInTransactionMode = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.ceInTransactionMode = New DevExpress.XtraEditors.CheckEdit
            Me.sbCommit = New DevExpress.XtraEditors.SimpleButton
            Me.sbChangeAnyEmployee = New DevExpress.XtraEditors.SimpleButton
            Me.sbEmployees = New DevExpress.XtraEditors.SimpleButton
            CType(Me.gclInTransactionModeMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gvlInTransactionMode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.ceInTransactionMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gclInTransactionModeMain
            '
            Me.gclInTransactionModeMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclInTransactionModeMain.Location = New System.Drawing.Point(0, 48)
            Me.gclInTransactionModeMain.MainView = Me.gvlInTransactionMode
            Me.gclInTransactionModeMain.Name = "gclInTransactionModeMain"
            Me.gclInTransactionModeMain.Size = New System.Drawing.Size(784, 476)
            Me.gclInTransactionModeMain.TabIndex = 2
            Me.gclInTransactionModeMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvlInTransactionMode})
            '
            'gvlInTransactionMode
            '
            Me.gvlInTransactionMode.GridControl = Me.gclInTransactionModeMain
            Me.gvlInTransactionMode.Name = "gvlInTransactionMode"
            Me.gvlInTransactionMode.OptionsBehavior.Editable = False
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.ceInTransactionMode)
            Me.panelControl1.Controls.Add(Me.sbCommit)
            Me.panelControl1.Controls.Add(Me.sbChangeAnyEmployee)
            Me.panelControl1.Controls.Add(Me.sbEmployees)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(784, 48)
            Me.panelControl1.TabIndex = 3
            '
            'ceInTransactionMode
            '
            Me.ceInTransactionMode.Location = New System.Drawing.Point(24, 14)
            Me.ceInTransactionMode.Name = "ceInTransactionMode"
            Me.ceInTransactionMode.Properties.Caption = "InTransaction mode"
            Me.ceInTransactionMode.Size = New System.Drawing.Size(123, 19)
            Me.ceInTransactionMode.TabIndex = 11
            '
            'sbCommit
            '
            Me.sbCommit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.sbCommit.Enabled = False
            Me.sbCommit.Location = New System.Drawing.Point(464, 12)
            Me.sbCommit.Name = "sbCommit"
            Me.sbCommit.Size = New System.Drawing.Size(120, 21)
            Me.sbCommit.TabIndex = 10
            Me.sbCommit.Text = "Commit Changes"
            '
            'sbChangeAnyEmployee
            '
            Me.sbChangeAnyEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.sbChangeAnyEmployee.Location = New System.Drawing.Point(323, 12)
            Me.sbChangeAnyEmployee.Name = "sbChangeAnyEmployee"
            Me.sbChangeAnyEmployee.Size = New System.Drawing.Size(135, 21)
            Me.sbChangeAnyEmployee.TabIndex = 9
            Me.sbChangeAnyEmployee.Text = "Change Employee Data"
            '
            'sbEmployees
            '
            Me.sbEmployees.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.sbEmployees.Location = New System.Drawing.Point(647, 12)
            Me.sbEmployees.Name = "sbEmployees"
            Me.sbEmployees.Size = New System.Drawing.Size(120, 21)
            Me.sbEmployees.TabIndex = 6
            Me.sbEmployees.Text = "Load Employees"
            '
            'InTransactionMode
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gclInTransactionModeMain)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "InTransactionMode"
            Me.Size = New System.Drawing.Size(784, 524)
            CType(Me.gclInTransactionModeMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gvlInTransactionMode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.ceInTransactionMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gclInTransactionModeMain As DevExpress.XtraGrid.GridControl
        Private gvlInTransactionMode As DevExpress.XtraGrid.Views.Grid.GridView
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents sbEmployees As DevExpress.XtraEditors.SimpleButton
        Private WithEvents sbChangeAnyEmployee As DevExpress.XtraEditors.SimpleButton
        Private WithEvents sbCommit As DevExpress.XtraEditors.SimpleButton
        Private WithEvents ceInTransactionMode As DevExpress.XtraEditors.CheckEdit
    End Class
End Namespace
