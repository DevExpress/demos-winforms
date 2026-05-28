Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucControlAbout
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.pnlLinks = New DevExpress.XtraEditors.PanelControl
            Me.peAbout = New DevExpress.XtraEditors.PictureEdit
            Me.lcName = New DevExpress.XtraEditors.LabelControl
            CType(Me.pnlLinks, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.peAbout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlLinks
            '
            Me.pnlLinks.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlLinks.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlLinks.Location = New System.Drawing.Point(0, 193)
            Me.pnlLinks.Name = "pnlLinks"
            Me.pnlLinks.Size = New System.Drawing.Size(309, 65)
            Me.pnlLinks.TabIndex = 5
            '
            'peAbout
            '
            Me.peAbout.Dock = System.Windows.Forms.DockStyle.Top
            Me.peAbout.Location = New System.Drawing.Point(0, 18)
            Me.peAbout.Name = "peAbout"
            Me.peAbout.Properties.AllowFocused = False
            Me.peAbout.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.peAbout.Properties.Appearance.Options.UseBackColor = True
            Me.peAbout.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.peAbout.Properties.ShowMenu = False
            Me.peAbout.Size = New System.Drawing.Size(309, 175)
            Me.peAbout.TabIndex = 4
            '
            'lcName
            '
            Me.lcName.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.lcName.Dock = System.Windows.Forms.DockStyle.Top
            Me.lcName.Location = New System.Drawing.Point(0, 0)
            Me.lcName.Name = "lcName"
            Me.lcName.Size = New System.Drawing.Size(89, 18)
            Me.lcName.TabIndex = 3
            Me.lcName.Text = "Control Name"
            '
            'ucControlAbout
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlLinks)
            Me.Controls.Add(Me.peAbout)
            Me.Controls.Add(Me.lcName)
            Me.Name = "ucControlAbout"
            Me.Size = New System.Drawing.Size(309, 258)
            CType(Me.pnlLinks, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.peAbout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private pnlLinks As DevExpress.XtraEditors.PanelControl
		Private peAbout As DevExpress.XtraEditors.PictureEdit
		Private lcName As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
