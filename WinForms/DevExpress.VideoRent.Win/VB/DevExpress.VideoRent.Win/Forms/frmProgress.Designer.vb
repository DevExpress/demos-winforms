Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmProgress
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
			Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' progressBarControl1
			' 
			Me.progressBarControl1.Location = New System.Drawing.Point(24, 31)
			Me.progressBarControl1.Name = "progressBarControl1"
			Me.progressBarControl1.Properties.ShowTitle = True
			Me.progressBarControl1.Size = New System.Drawing.Size(429, 17)
			Me.progressBarControl1.TabIndex = 0
			' 
			' labelControl1
			' 
			Me.labelControl1.AllowHtmlString = True
			Me.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black
			Me.labelControl1.Location = New System.Drawing.Point(24, 12)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(129, 14)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Changing <b>Look and Feel</b>:"
			' 
			' frmProgress
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(476, 64)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.progressBarControl1)
			Me.Name = "frmProgress"
			Me.Text = "frmProgress"
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
