Namespace DevExpress.XtraScheduler.Demos

    Partial Class SchedulerPrint

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
            Me.printSettingsControl = New DevExpress.XtraScheduler.Demos.ReportPrintControl()
            Me.reportPreviewControl1 = New DevExpress.XtraScheduler.Demos.ReportPreviewControl()
            Me.controlPrintAdapter1 = New DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter()
            CType((Me.controlPrintAdapter1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' printSettingsControl
            ' 
            Me.printSettingsControl.Dock = System.Windows.Forms.DockStyle.Left
            Me.printSettingsControl.Location = New System.Drawing.Point(0, 0)
            Me.printSettingsControl.Name = "printSettingsControl"
            Me.printSettingsControl.Size = New System.Drawing.Size(310, 531)
            Me.printSettingsControl.TabIndex = 0
            AddHandler Me.printSettingsControl.PrintClick, New System.EventHandler(AddressOf Me.OnSettingsControlPrintClick)
            AddHandler Me.printSettingsControl.PrintOptionsClick, New System.EventHandler(AddressOf Me.OnSettingsControlPrintOptionsClick)
            ' 
            ' reportPreviewControl1
            ' 
            Me.reportPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.reportPreviewControl1.Location = New System.Drawing.Point(310, 0)
            Me.reportPreviewControl1.Name = "reportPreviewControl1"
            Me.reportPreviewControl1.Size = New System.Drawing.Size(420, 531)
            Me.reportPreviewControl1.TabIndex = 1
            ' 
            ' SchedulerPrint
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.reportPreviewControl1)
            Me.Controls.Add(Me.printSettingsControl)
            Me.Name = "SchedulerPrint"
            Me.Size = New System.Drawing.Size(730, 531)
            CType((Me.controlPrintAdapter1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private printSettingsControl As DevExpress.XtraScheduler.Demos.ReportPrintControl

        Private reportPreviewControl1 As DevExpress.XtraScheduler.Demos.ReportPreviewControl

        Private controlPrintAdapter1 As DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter
    End Class
End Namespace
