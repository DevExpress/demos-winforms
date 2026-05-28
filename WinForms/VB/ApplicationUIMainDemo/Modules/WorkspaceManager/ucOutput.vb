Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class ucOutput
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            comboBox.SelectedIndex = 0
            textBox.ContextMenuStrip = New ContextMenuStrip()
        End Sub

        Private Sub comboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If comboBox.SelectedIndex = 0 Then
                textBox.Text = " ------ Build started: Project: DockingDemo, Configuration: Debug .NET ------" & Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf & " Preparing resources..." & Microsoft.VisualBasic.Constants.vbCrLf & " Updating references..." & Microsoft.VisualBasic.Constants.vbCrLf & " Performing main compilation..." & Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf & " Build complete -- 0 errors, 0 warnings" & Microsoft.VisualBasic.Constants.vbCrLf & " Building satellite assemblies..." & Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf & " ---------------------- Done ----------------------" & Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf & "     Build: 1 succeeded, 0 failed, 0 skipped"
            Else
                textBox.Text = " 'DefaultDomain': Loaded 'd:\winnt\microsoft.net\framework\v1.0.3705\mscorlib.dll', No symbols loaded." & Microsoft.VisualBasic.Constants.vbCrLf & " 'DockingDemo': Loaded 'C:\BarDemos\CS\DockingDemo\bin\Debug\DockingDemo.exe', Symbols loaded."
            End If
        End Sub

        Private Sub textBox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            e.Handled = True
        End Sub
    End Class
End Namespace
