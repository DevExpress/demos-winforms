Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class ObjectLayerServices
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gclObjectLayerServicesMain = New DevExpress.XtraGrid.GridControl
            Me.gvlObjectLayerServices = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.sbStartService = New DevExpress.XtraEditors.SimpleButton
            Me.sbEmployees = New DevExpress.XtraEditors.SimpleButton
            CType(Me.gclObjectLayerServicesMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gvlObjectLayerServices, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gclObjectLayerServicesMain
            '
            Me.gclObjectLayerServicesMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclObjectLayerServicesMain.Location = New System.Drawing.Point(0, 48)
            Me.gclObjectLayerServicesMain.MainView = Me.gvlObjectLayerServices
            Me.gclObjectLayerServicesMain.Name = "gclObjectLayerServicesMain"
            Me.gclObjectLayerServicesMain.Size = New System.Drawing.Size(784, 476)
            Me.gclObjectLayerServicesMain.TabIndex = 2
            Me.gclObjectLayerServicesMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvlObjectLayerServices})
            '
            'gvlObjectLayerServices
            '
            Me.gvlObjectLayerServices.GridControl = Me.gclObjectLayerServicesMain
            Me.gvlObjectLayerServices.Name = "gvlObjectLayerServices"
            Me.gvlObjectLayerServices.OptionsBehavior.Editable = False
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.sbStartService)
            Me.panelControl1.Controls.Add(Me.sbEmployees)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(784, 48)
            Me.panelControl1.TabIndex = 3
            '
            'sbStartService
            '
            Me.sbStartService.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.sbStartService.Location = New System.Drawing.Point(584, 12)
            Me.sbStartService.Name = "sbStartService"
            Me.sbStartService.Size = New System.Drawing.Size(184, 21)
            Me.sbStartService.TabIndex = 7
            Me.sbStartService.Text = "Start Service and Create Client"
            '
            'sbEmployees
            '
            Me.sbEmployees.Enabled = False
            Me.sbEmployees.Location = New System.Drawing.Point(17, 12)
            Me.sbEmployees.Name = "sbEmployees"
            Me.sbEmployees.Size = New System.Drawing.Size(225, 21)
            Me.sbEmployees.TabIndex = 6
            Me.sbEmployees.Text = "Load Employees via WCF Service"
            '
            'ObjectLayerServices
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gclObjectLayerServicesMain)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "ObjectLayerServices"
            Me.Size = New System.Drawing.Size(784, 524)
            CType(Me.gclObjectLayerServicesMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gvlObjectLayerServices, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gclObjectLayerServicesMain As DevExpress.XtraGrid.GridControl
        Private gvlObjectLayerServices As DevExpress.XtraGrid.Views.Grid.GridView
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents sbEmployees As DevExpress.XtraEditors.SimpleButton
        Private WithEvents sbStartService As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
