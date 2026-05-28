Namespace DevExpress.DevAV.Modules

    Partial Class OrdersPrint

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
        Private Overloads Sub InitializeComponent()
            Me.previewControl = New DevExpress.DevAV.ReportPreviewControl()
            Me.printSettingsControl = New DevExpress.DevAV.ReportPrintControl()
            Me.SuspendLayout()
            Me.previewControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.previewControl.Location = New System.Drawing.Point(310, 0)
            Me.previewControl.Name = "previewControl"
            Me.previewControl.Size = New System.Drawing.Size(714, 600)
            Me.previewControl.TabIndex = 0
            Me.previewControl.Visible = False
            Me.printSettingsControl.Dock = System.Windows.Forms.DockStyle.Left
            Me.printSettingsControl.Location = New System.Drawing.Point(0, 0)
            Me.printSettingsControl.Name = "printSettingsControl"
            Me.printSettingsControl.SelectedPrinterName = ""
            Me.printSettingsControl.Size = New System.Drawing.Size(310, 600)
            Me.printSettingsControl.TabIndex = 1
            AddHandler Me.printSettingsControl.PrintClick, New System.EventHandler(AddressOf Me.settingsControl_PrintClick)
            AddHandler Me.printSettingsControl.PrintOptionsClick, New System.EventHandler(AddressOf Me.settingsControl_PrintOptionsClick)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.previewControl)
            Me.Controls.Add(Me.printSettingsControl)
            Me.Name = "OrdersPrint"
            Me.Size = New System.Drawing.Size(1024, 600)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private previewControl As DevExpress.DevAV.ReportPreviewControl

        Private printSettingsControl As DevExpress.DevAV.ReportPrintControl
    End Class
End Namespace
