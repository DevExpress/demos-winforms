Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmDetailBase
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
			Me.pcFormButtons = New DevExpress.XtraEditors.PanelControl()
			Me.sbOK = New DevExpress.XtraEditors.SimpleButton()
			Me.pcSeparator = New DevExpress.XtraEditors.PanelControl()
			Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.pcFormButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcFormButtons.SuspendLayout()
			CType(Me.pcSeparator, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pcFormButtons
			' 
			Me.pcFormButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcFormButtons.Controls.Add(Me.sbOK)
			Me.pcFormButtons.Controls.Add(Me.pcSeparator)
			Me.pcFormButtons.Controls.Add(Me.sbCancel)
			Me.pcFormButtons.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.pcFormButtons.Location = New System.Drawing.Point(8, 456)
			Me.pcFormButtons.Name = "pcFormButtons"
			Me.pcFormButtons.Size = New System.Drawing.Size(796, 22)
			Me.pcFormButtons.TabIndex = 1
			' 
			' sbOK
			' 
			Me.sbOK.Dock = System.Windows.Forms.DockStyle.Right
			Me.sbOK.Location = New System.Drawing.Point(622, 0)
			Me.sbOK.Name = "sbOK"
			Me.sbOK.Size = New System.Drawing.Size(83, 22)
			Me.sbOK.TabIndex = 0
			Me.sbOK.Text = "&OK"
'			Me.sbOK.Click += New System.EventHandler(Me.sbOK_Click);
			' 
			' pcSeparator
			' 
			Me.pcSeparator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcSeparator.Dock = System.Windows.Forms.DockStyle.Right
			Me.pcSeparator.Location = New System.Drawing.Point(705, 0)
			Me.pcSeparator.Name = "pcSeparator"
			Me.pcSeparator.Size = New System.Drawing.Size(8, 22)
			Me.pcSeparator.TabIndex = 2
			' 
			' sbCancel
			' 
			Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.sbCancel.Dock = System.Windows.Forms.DockStyle.Right
			Me.sbCancel.Location = New System.Drawing.Point(713, 0)
			Me.sbCancel.Name = "sbCancel"
			Me.sbCancel.Size = New System.Drawing.Size(83, 22)
			Me.sbCancel.TabIndex = 1
			Me.sbCancel.Text = "&Cancel"
			' 
			' frmDetailBase
			' 
			Me.AcceptButton = Me.sbOK
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.sbCancel
			Me.ClientSize = New System.Drawing.Size(812, 486)
			Me.Controls.Add(Me.pcFormButtons)
			Me.MinimizeBox = False
			Me.MinimumSize = New System.Drawing.Size(400, 300)
			Me.Name = "frmDetailBase"
			Me.Padding = New System.Windows.Forms.Padding(8)
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "frmDetailBase"
			CType(Me.pcFormButtons, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcFormButtons.ResumeLayout(False)
			CType(Me.pcSeparator, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pcFormButtons As DevExpress.XtraEditors.PanelControl
		Private pcSeparator As DevExpress.XtraEditors.PanelControl
		Private sbCancel As DevExpress.XtraEditors.SimpleButton
		Private WithEvents sbOK As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace
