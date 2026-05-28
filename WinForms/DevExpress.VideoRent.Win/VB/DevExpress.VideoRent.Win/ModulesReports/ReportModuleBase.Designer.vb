Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.ModulesReports
	Partial Public Class ReportModuleBase
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
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
			Me.printControl = New DevExpress.XtraPrinting.Control.PrintControl()
			Me.SuspendLayout()
			' 
			' printControl
			' 
			Me.printControl.BackColor = System.Drawing.Color.Empty
			Me.printControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.printControl.ForeColor = System.Drawing.Color.Empty
			Me.printControl.IsMetric = True
			Me.printControl.Location = New System.Drawing.Point(6, 0)
			Me.printControl.Name = "printControl"
			Me.printControl.Size = New System.Drawing.Size(794, 500)
			Me.printControl.TabIndex = 0
			Me.printControl.TooltipFont = New System.Drawing.Font("Tahoma", 8.25F)
			' 
			' ReportModuleBase
			' 
			Me.Controls.Add(Me.printControl)
			Me.Name = "ReportModuleBase"
			Me.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
			Me.Size = New System.Drawing.Size(800, 500)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private printControl As DevExpress.XtraPrinting.Control.PrintControl
	End Class
End Namespace
