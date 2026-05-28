Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class DataCaching
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
            Me.gclDataCachingMain = New DevExpress.XtraGrid.GridControl
            Me.gvlDataCaching = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.sbChangeAnyEmployee = New DevExpress.XtraEditors.SimpleButton
            Me.lbSelectCount = New DevExpress.XtraEditors.LabelControl
            Me.sbOrders = New DevExpress.XtraEditors.SimpleButton
            Me.sbEmployees = New DevExpress.XtraEditors.SimpleButton
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
            CType(Me.gclDataCachingMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gvlDataCaching, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gclDataCachingMain
            '
            Me.gclDataCachingMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclDataCachingMain.Location = New System.Drawing.Point(0, 48)
            Me.gclDataCachingMain.MainView = Me.gvlDataCaching
            Me.gclDataCachingMain.Name = "gclDataCachingMain"
            Me.gclDataCachingMain.Size = New System.Drawing.Size(784, 476)
            Me.gclDataCachingMain.TabIndex = 2
            Me.gclDataCachingMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvlDataCaching})
            '
            'gvlDataCaching
            '
            Me.gvlDataCaching.GridControl = Me.gclDataCachingMain
            Me.gvlDataCaching.Name = "gvlDataCaching"
            Me.gvlDataCaching.OptionsBehavior.Editable = False
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.sbChangeAnyEmployee)
            Me.panelControl1.Controls.Add(Me.lbSelectCount)
            Me.panelControl1.Controls.Add(Me.sbOrders)
            Me.panelControl1.Controls.Add(Me.sbEmployees)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(784, 48)
            Me.panelControl1.TabIndex = 3
            '
            'sbChangeAnyEmployee
            '
            Me.sbChangeAnyEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.sbChangeAnyEmployee.Location = New System.Drawing.Point(353, 12)
            Me.sbChangeAnyEmployee.Name = "sbChangeAnyEmployee"
            Me.sbChangeAnyEmployee.Size = New System.Drawing.Size(136, 21)
            Me.sbChangeAnyEmployee.TabIndex = 9
            Me.sbChangeAnyEmployee.Text = "Change Employee Data"
            '
            'lbSelectCount
            '
            Me.lbSelectCount.Location = New System.Drawing.Point(186, 17)
            Me.lbSelectCount.Name = "lbSelectCount"
            Me.lbSelectCount.Size = New System.Drawing.Size(6, 13)
            Me.lbSelectCount.TabIndex = 8
            Me.lbSelectCount.Text = "0"
            '
            'sbOrders
            '
            Me.sbOrders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.sbOrders.Location = New System.Drawing.Point(650, 12)
            Me.sbOrders.Name = "sbOrders"
            Me.sbOrders.Size = New System.Drawing.Size(120, 21)
            Me.sbOrders.TabIndex = 7
            Me.sbOrders.Text = "Load Orders"
            '
            'sbEmployees
            '
            Me.sbEmployees.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.sbEmployees.Location = New System.Drawing.Point(524, 12)
            Me.sbEmployees.Name = "sbEmployees"
            Me.sbEmployees.Size = New System.Drawing.Size(120, 21)
            Me.sbEmployees.TabIndex = 6
            Me.sbEmployees.Text = "Load Employees"
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(19, 17)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(161, 13)
            Me.labelControl1.TabIndex = 4
            Me.labelControl1.Text = "Requests passed to a data store:"
            '
            'DataCaching
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gclDataCachingMain)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "DataCaching"
            Me.Size = New System.Drawing.Size(784, 524)
            CType(Me.gclDataCachingMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gvlDataCaching, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gclDataCachingMain As DevExpress.XtraGrid.GridControl
        Private gvlDataCaching As DevExpress.XtraGrid.Views.Grid.GridView
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents sbEmployees As DevExpress.XtraEditors.SimpleButton
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents sbOrders As DevExpress.XtraEditors.SimpleButton
        Private lbSelectCount As DevExpress.XtraEditors.LabelControl
        Private WithEvents sbChangeAnyEmployee As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
