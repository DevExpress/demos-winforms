Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
	Partial Public Class About
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
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
			Me.SuspendLayout()
			' 
			' About
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.Name = "About"
			Me.Size = New System.Drawing.Size(157, 141)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
