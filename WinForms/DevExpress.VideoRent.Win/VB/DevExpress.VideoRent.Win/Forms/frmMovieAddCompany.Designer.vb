Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmMovieAddCompany
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
			Me.lueCompany = New DevExpress.XtraEditors.LookUpEdit()
			Me.lciCompany = New DevExpress.XtraLayout.LayoutControlItem()
			Me.meDescription = New DevExpress.XtraEditors.MemoEdit()
			Me.lciDescription = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lueCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciCompany, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.meDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciDescription, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
			Me.lcMain.Controls.Add(Me.meDescription)
			Me.lcMain.Controls.Add(Me.lueCompany)
			Me.lcMain.Size = New System.Drawing.Size(375, 226)
			' 
			' lcgMain
			' 
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciCompany, Me.lciDescription})
			Me.lcgMain.Size = New System.Drawing.Size(375, 226)
			' 
			' lueCompany
			' 
			Me.lueCompany.Location = New System.Drawing.Point(63, 2)
			Me.lueCompany.Name = "lueCompany"
			Me.lueCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lueCompany.Properties.NullText = " "
			Me.lueCompany.Size = New System.Drawing.Size(310, 20)
			Me.lueCompany.StyleController = Me.lcMain
			Me.lueCompany.TabIndex = 4
			' 
			' lciCompany
			' 
			Me.lciCompany.Control = Me.lueCompany
			Me.lciCompany.CustomizationFormText = "Company"
			Me.lciCompany.Location = New System.Drawing.Point(0, 0)
			Me.lciCompany.Name = "lciCompany"
			Me.lciCompany.Size = New System.Drawing.Size(375, 24)
			Me.lciCompany.Text = "Company:"
			Me.lciCompany.TextSize = New System.Drawing.Size(57, 13)
			' 
			' meDescription
			' 
			Me.meDescription.Location = New System.Drawing.Point(63, 26)
			Me.meDescription.Name = "meDescription"
			Me.meDescription.Size = New System.Drawing.Size(310, 190)
			Me.meDescription.StyleController = Me.lcMain
			Me.meDescription.TabIndex = 6
			' 
			' lciDescription
			' 
			Me.lciDescription.AppearanceItemCaption.Options.UseTextOptions = True
			Me.lciDescription.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.lciDescription.Control = Me.meDescription
			Me.lciDescription.CustomizationFormText = "Description"
			Me.lciDescription.Location = New System.Drawing.Point(0, 24)
			Me.lciDescription.Name = "lciDescription"
			Me.lciDescription.Size = New System.Drawing.Size(375, 194)
			Me.lciDescription.Text = "Description:"
			Me.lciDescription.TextSize = New System.Drawing.Size(57, 13)
			' 
			' frmMovieAddCompany
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(399, 272)
			Me.Name = "frmMovieAddCompany"
			Me.ShowIcon = False
			Me.Text = "MovieAddCompany"
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lueCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciCompany, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.meDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciDescription, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lueCompany As DevExpress.XtraEditors.LookUpEdit
		Private lciCompany As DevExpress.XtraLayout.LayoutControlItem
		Private meDescription As DevExpress.XtraEditors.MemoEdit
		Private lciDescription As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace
