Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmCompanyAddMovie
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
			Me.lciMovie = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lueMovie = New DevExpress.XtraEditors.GridLookUpEdit()
			Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.lciDescription = New DevExpress.XtraLayout.LayoutControlItem()
			Me.teDescription = New DevExpress.XtraEditors.MemoEdit()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciMovie, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lueMovie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciDescription, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
			Me.lcMain.Controls.Add(Me.teDescription)
			Me.lcMain.Controls.Add(Me.lueMovie)
			Me.lcMain.Size = New System.Drawing.Size(368, 186)
			' 
			' lcgMain
			' 
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciMovie, Me.lciDescription})
			Me.lcgMain.Size = New System.Drawing.Size(368, 186)
			' 
			' lciMovie
			' 
			Me.lciMovie.Control = Me.lueMovie
			Me.lciMovie.CustomizationFormText = "lciMovie"
			Me.lciMovie.Location = New System.Drawing.Point(0, 0)
			Me.lciMovie.Name = "lciMovie"
			Me.lciMovie.Size = New System.Drawing.Size(368, 24)
			Me.lciMovie.Text = "Movie:"
			Me.lciMovie.TextSize = New System.Drawing.Size(57, 13)
			' 
			' lueMovie
			' 
			Me.lueMovie.Location = New System.Drawing.Point(63, 2)
			Me.lueMovie.Name = "lueMovie"
			Me.lueMovie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lueMovie.Properties.NullText = " "
			Me.lueMovie.Properties.View = Me.gridLookUpEdit1View
			Me.lueMovie.Size = New System.Drawing.Size(303, 20)
			Me.lueMovie.StyleController = Me.lcMain
			Me.lueMovie.TabIndex = 4
			' 
			' gridLookUpEdit1View
			' 
			Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
			Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
			Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
			' 
			' lciDescription
			' 
			Me.lciDescription.AppearanceItemCaption.Options.UseTextOptions = True
			Me.lciDescription.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.lciDescription.Control = Me.teDescription
			Me.lciDescription.CustomizationFormText = "Description:"
			Me.lciDescription.Location = New System.Drawing.Point(0, 24)
			Me.lciDescription.Name = "lciDescription"
			Me.lciDescription.Size = New System.Drawing.Size(368, 154)
			Me.lciDescription.Text = "Description:"
			Me.lciDescription.TextSize = New System.Drawing.Size(57, 13)
			' 
			' teDescription
			' 
			Me.teDescription.Location = New System.Drawing.Point(63, 26)
			Me.teDescription.Name = "teDescription"
			Me.teDescription.Size = New System.Drawing.Size(303, 150)
			Me.teDescription.StyleController = Me.lcMain
			Me.teDescription.TabIndex = 6
			Me.teDescription.TabStop = False
			' 
			' frmCompanyAddMovie
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(392, 232)
			Me.Name = "frmCompanyAddMovie"
			Me.ShowIcon = False
			Me.Text = "frmCompanyAddMovie"
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciMovie, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lueMovie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciDescription, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lciMovie As DevExpress.XtraLayout.LayoutControlItem
		Private lciDescription As DevExpress.XtraLayout.LayoutControlItem
		Private teDescription As DevExpress.XtraEditors.MemoEdit
		Private lueMovie As DevExpress.XtraEditors.GridLookUpEdit
		Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
	End Class
End Namespace
