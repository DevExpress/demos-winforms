Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmArtistAddMovie
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
			Me.lciArtist = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lueMovie = New DevExpress.XtraEditors.GridLookUpEdit()
			Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.lciLine = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lueLine = New DevExpress.XtraEditors.LookUpEdit()
			Me.meDescription = New DevExpress.XtraEditors.MemoEdit()
			Me.lciDescription = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciArtist, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lueMovie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciLine, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lueLine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.meDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciDescription, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
			Me.lcMain.Controls.Add(Me.meDescription)
			Me.lcMain.Controls.Add(Me.lueLine)
			Me.lcMain.Controls.Add(Me.lueMovie)
			Me.lcMain.Size = New System.Drawing.Size(392, 232)
			' 
			' lcgMain
			' 
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciArtist, Me.lciLine, Me.lciDescription})
			Me.lcgMain.Size = New System.Drawing.Size(392, 232)
			' 
			' lciArtist
			' 
			Me.lciArtist.Control = Me.lueMovie
			Me.lciArtist.CustomizationFormText = "Artist"
			Me.lciArtist.Location = New System.Drawing.Point(0, 0)
			Me.lciArtist.Name = "lciArtist"
			Me.lciArtist.Size = New System.Drawing.Size(392, 24)
			Me.lciArtist.Text = "Movie:"
			Me.lciArtist.TextSize = New System.Drawing.Size(57, 13)
			' 
			' lueMovie
			' 
			Me.lueMovie.AllowDrop = True
			Me.lueMovie.Location = New System.Drawing.Point(63, 2)
			Me.lueMovie.Name = "lueMovie"
			Me.lueMovie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lueMovie.Properties.NullText = ""
			Me.lueMovie.Properties.PopupSizeable = False
			Me.lueMovie.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			Me.lueMovie.Properties.View = Me.gridLookUpEdit1View
			Me.lueMovie.Size = New System.Drawing.Size(327, 20)
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
			' lciLine
			' 
			Me.lciLine.Control = Me.lueLine
			Me.lciLine.CustomizationFormText = "Credits"
			Me.lciLine.Location = New System.Drawing.Point(0, 24)
			Me.lciLine.Name = "lciLine"
			Me.lciLine.Size = New System.Drawing.Size(392, 24)
			Me.lciLine.Text = "Credits:"
			Me.lciLine.TextSize = New System.Drawing.Size(57, 13)
			' 
			' lueLine
			' 
			Me.lueLine.Location = New System.Drawing.Point(63, 26)
			Me.lueLine.Name = "lueLine"
			Me.lueLine.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lueLine.Properties.NullText = ""
			Me.lueLine.Properties.PopupSizeable = False
			Me.lueLine.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			Me.lueLine.Size = New System.Drawing.Size(327, 20)
			Me.lueLine.StyleController = Me.lcMain
			Me.lueLine.TabIndex = 5
			' 
			' meDescription
			' 
			Me.meDescription.Location = New System.Drawing.Point(63, 50)
			Me.meDescription.Name = "meDescription"
			Me.meDescription.Size = New System.Drawing.Size(327, 172)
			Me.meDescription.StyleController = Me.lcMain
			Me.meDescription.TabIndex = 6
			' 
			' lciDescription
			' 
			Me.lciDescription.AppearanceItemCaption.Options.UseTextOptions = True
			Me.lciDescription.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.lciDescription.Control = Me.meDescription
			Me.lciDescription.CustomizationFormText = "Description"
			Me.lciDescription.Location = New System.Drawing.Point(0, 48)
			Me.lciDescription.Name = "lciDescription"
			Me.lciDescription.Size = New System.Drawing.Size(392, 176)
			Me.lciDescription.Text = "Description:"
			Me.lciDescription.TextSize = New System.Drawing.Size(57, 13)
			' 
			' frmArtistAddMovie
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(416, 278)
			Me.Name = "frmArtistAddMovie"
			Me.ShowIcon = False
			Me.Text = "Add Movie Artist"
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciArtist, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lueMovie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciLine, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lueLine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.meDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciDescription, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lciArtist As DevExpress.XtraLayout.LayoutControlItem
		Private meDescription As DevExpress.XtraEditors.MemoEdit
		Private lciLine As DevExpress.XtraLayout.LayoutControlItem
		Private lciDescription As DevExpress.XtraLayout.LayoutControlItem
		Private lueLine As DevExpress.XtraEditors.LookUpEdit
		Private lueMovie As DevExpress.XtraEditors.GridLookUpEdit
		Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
	End Class
End Namespace
