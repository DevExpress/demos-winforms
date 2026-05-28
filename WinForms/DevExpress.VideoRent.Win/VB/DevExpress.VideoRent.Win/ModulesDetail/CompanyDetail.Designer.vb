Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class CompanyDetail
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
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.teName = New DevExpress.XtraEditors.TextEdit()
			Me.lueType = New DevExpress.XtraEditors.LookUpEdit()
			Me.lueCountry = New DevExpress.XtraEditors.LookUpEdit()
			Me.beWebSite = New DevExpress.XtraEditors.ButtonEdit()
			Me.ucGridEditBar = New DevExpress.VideoRent.Win.Controls.ucGridEditBar()
			Me.gcMovies = New DevExpress.XtraGrid.GridControl()
			Me.gvMovies = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colMovie = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.lciName = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciType = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciWebSite = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciCountry = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciMoviesGridBar = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciMovies = New DevExpress.XtraLayout.LayoutControlItem()
			Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.peFlag = New DevExpress.XtraEditors.PictureEdit()
			Me.lciFlag = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lueType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lueCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.beWebSite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gcMovies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gvMovies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciType, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciWebSite, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciCountry, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciMoviesGridBar, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciMovies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.peFlag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciFlag, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
			Me.lcMain.Controls.Add(Me.peFlag)
			Me.lcMain.Controls.Add(Me.teName)
			Me.lcMain.Controls.Add(Me.lueType)
			Me.lcMain.Controls.Add(Me.beWebSite)
			Me.lcMain.Controls.Add(Me.lueCountry)
			Me.lcMain.Controls.Add(Me.gcMovies)
			Me.lcMain.Controls.Add(Me.ucGridEditBar)
			Me.lcMain.Size = New System.Drawing.Size(466, 403)
			' 
			' lcgMain
			' 
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciName, Me.lciWebSite, Me.lciType, Me.lciCountry, Me.lciMoviesGridBar, Me.lciMovies, Me.simpleSeparator1, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.lciFlag})
			Me.lcgMain.Name = "Root"
			Me.lcgMain.Size = New System.Drawing.Size(466, 403)
			Me.lcgMain.Text = "Root"
			' 
			' teName
			' 
			Me.teName.Location = New System.Drawing.Point(82, 8)
			Me.teName.Name = "teName"
			Me.teName.Size = New System.Drawing.Size(223, 20)
			Me.teName.StyleController = Me.lcMain
			Me.teName.TabIndex = 4
			' 
			' lueType
			' 
			Me.lueType.Location = New System.Drawing.Point(82, 32)
			Me.lueType.Name = "lueType"
			Me.lueType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lueType.Properties.NullText = ""
			Me.lueType.Properties.PopupSizeable = False
			Me.lueType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			Me.lueType.Size = New System.Drawing.Size(223, 20)
			Me.lueType.StyleController = Me.lcMain
			Me.lueType.TabIndex = 5
			' 
			' lueCountry
			' 
			Me.lueCountry.Location = New System.Drawing.Point(82, 80)
			Me.lueCountry.Name = "lueCountry"
			Me.lueCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lueCountry.Properties.NullText = ""
			Me.lueCountry.Properties.PopupSizeable = False
			Me.lueCountry.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			Me.lueCountry.Size = New System.Drawing.Size(223, 20)
			Me.lueCountry.StyleController = Me.lcMain
			Me.lueCountry.TabIndex = 7
'			Me.lueCountry.EditValueChanged += New System.EventHandler(Me.lueCountry_EditValueChanged);
			' 
			' beWebSite
			' 
			Me.beWebSite.Location = New System.Drawing.Point(82, 56)
			Me.beWebSite.Name = "beWebSite"
			Me.beWebSite.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Go to Website", Nothing, Nothing, True)})
			Me.beWebSite.Size = New System.Drawing.Size(223, 20)
			Me.beWebSite.StyleController = Me.lcMain
			Me.beWebSite.TabIndex = 6
'			Me.beWebSite.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.beWebSite_ButtonClick);
			' 
			' ucGridEditBar
			' 
			Me.ucGridEditBar.Location = New System.Drawing.Point(8, 142)
			Me.ucGridEditBar.Name = "ucGridEditBar"
			Me.ucGridEditBar.Size = New System.Drawing.Size(450, 26)
			Me.ucGridEditBar.TabIndex = 5
'			Me.ucGridEditBar.DeleteRecord += New System.EventHandler(Me.ucGridEditBar_DeleteRecord);
'			Me.ucGridEditBar.AddRecord += New System.EventHandler(Me.ucGridEditBar_AddRecord);
			' 
			' gcMovies
			' 
			Me.gcMovies.Location = New System.Drawing.Point(8, 172)
			Me.gcMovies.MainView = Me.gvMovies
			Me.gcMovies.Name = "gcMovies"
			Me.gcMovies.ShowOnlyPredefinedDetails = True
			Me.gcMovies.Size = New System.Drawing.Size(450, 223)
			Me.gcMovies.TabIndex = 4
			Me.gcMovies.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvMovies})
			' 
			' gvMovies
			' 
			Me.gvMovies.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colMovie, Me.colDescription})
			Me.gvMovies.GridControl = Me.gcMovies
			Me.gvMovies.Name = "gvMovies"
			Me.gvMovies.OptionsView.ShowDetailButtons = False
			Me.gvMovies.OptionsView.ShowGroupPanel = False
			' 
			' colMovie
			' 
			Me.colMovie.Caption = "Movie"
			Me.colMovie.FieldName = "Movie!"
			Me.colMovie.Name = "colMovie"
			Me.colMovie.Visible = True
			Me.colMovie.VisibleIndex = 0
			Me.colMovie.Width = 280
			' 
			' colDescription
			' 
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.Visible = True
			Me.colDescription.VisibleIndex = 1
			Me.colDescription.Width = 148
			' 
			' lciName
			' 
			Me.lciName.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.lciName.AppearanceItemCaption.Options.UseFont = True
			Me.lciName.Control = Me.teName
			Me.lciName.CustomizationFormText = "Name:"
			Me.lciName.Location = New System.Drawing.Point(0, 0)
			Me.lciName.Name = "lciName"
			Me.lciName.Size = New System.Drawing.Size(301, 24)
			Me.lciName.Text = "Name:"
			Me.lciName.TextSize = New System.Drawing.Size(70, 13)
			' 
			' lciType
			' 
			Me.lciType.Control = Me.lueType
			Me.lciType.CustomizationFormText = "Type:"
			Me.lciType.Location = New System.Drawing.Point(0, 24)
			Me.lciType.Name = "lciType"
			Me.lciType.Size = New System.Drawing.Size(301, 24)
			Me.lciType.Text = "Type:"
			Me.lciType.TextSize = New System.Drawing.Size(70, 13)
			' 
			' lciWebSite
			' 
			Me.lciWebSite.Control = Me.beWebSite
			Me.lciWebSite.CustomizationFormText = "Web Site:"
			Me.lciWebSite.Location = New System.Drawing.Point(0, 48)
			Me.lciWebSite.Name = "lciWebSite"
			Me.lciWebSite.Size = New System.Drawing.Size(301, 24)
			Me.lciWebSite.Text = "Web Site:"
			Me.lciWebSite.TextSize = New System.Drawing.Size(70, 13)
			' 
			' lciCountry
			' 
			Me.lciCountry.Control = Me.lueCountry
			Me.lciCountry.CustomizationFormText = "Country:"
			Me.lciCountry.Location = New System.Drawing.Point(0, 72)
			Me.lciCountry.Name = "lciCountry"
			Me.lciCountry.Size = New System.Drawing.Size(301, 24)
			Me.lciCountry.Text = "Country:"
			Me.lciCountry.TextSize = New System.Drawing.Size(70, 13)
			' 
			' lciMoviesGridBar
			' 
			Me.lciMoviesGridBar.Control = Me.ucGridEditBar
			Me.lciMoviesGridBar.CustomizationFormText = "lciMoviesGridBar"
			Me.lciMoviesGridBar.Location = New System.Drawing.Point(0, 118)
			Me.lciMoviesGridBar.Name = "lciMoviesGridBar"
			Me.lciMoviesGridBar.Size = New System.Drawing.Size(454, 46)
			Me.lciMoviesGridBar.Text = "Linked Movies:"
			Me.lciMoviesGridBar.TextLocation = DevExpress.Utils.Locations.Top
			Me.lciMoviesGridBar.TextSize = New System.Drawing.Size(70, 13)
			' 
			' lciMovies
			' 
			Me.lciMovies.Control = Me.gcMovies
			Me.lciMovies.CustomizationFormText = "lciMovies"
			Me.lciMovies.Location = New System.Drawing.Point(0, 164)
			Me.lciMovies.Name = "lciMovies"
			Me.lciMovies.Size = New System.Drawing.Size(454, 227)
			Me.lciMovies.Text = "lciMovies"
			Me.lciMovies.TextSize = New System.Drawing.Size(0, 0)
			Me.lciMovies.TextToControlDistance = 0
			Me.lciMovies.TextVisible = False
			' 
			' simpleSeparator1
			' 
			Me.simpleSeparator1.CustomizationFormText = "simpleSeparator1"
			Me.simpleSeparator1.Location = New System.Drawing.Point(0, 106)
			Me.simpleSeparator1.Name = "simpleSeparator1"
			Me.simpleSeparator1.Size = New System.Drawing.Size(454, 2)
			Me.simpleSeparator1.Text = "simpleSeparator1"
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 108)
			Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(454, 10)
			Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 96)
			Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem2.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(454, 10)
			Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem2.Text = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' peFlag
			' 
			Me.peFlag.Location = New System.Drawing.Point(309, 8)
			Me.peFlag.Name = "peFlag"
			Me.peFlag.Properties.AllowFocused = False
			Me.peFlag.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.peFlag.Properties.Appearance.Options.UseBackColor = True
			Me.peFlag.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.peFlag.Properties.NullText = " "
			Me.peFlag.Properties.ShowMenu = False
			Me.peFlag.Size = New System.Drawing.Size(149, 92)
			Me.peFlag.StyleController = Me.lcMain
			Me.peFlag.TabIndex = 8
			' 
			' lciFlag
			' 
			Me.lciFlag.Control = Me.peFlag
			Me.lciFlag.CustomizationFormText = "lciFlag"
			Me.lciFlag.Location = New System.Drawing.Point(301, 0)
			Me.lciFlag.MaxSize = New System.Drawing.Size(153, 0)
			Me.lciFlag.MinSize = New System.Drawing.Size(153, 24)
			Me.lciFlag.Name = "lciFlag"
			Me.lciFlag.Size = New System.Drawing.Size(153, 96)
			Me.lciFlag.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciFlag.Text = "lciFlag"
			Me.lciFlag.TextSize = New System.Drawing.Size(0, 0)
			Me.lciFlag.TextToControlDistance = 0
			Me.lciFlag.TextVisible = False
			' 
			' CompanyDetail
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "CompanyDetail"
			Me.Size = New System.Drawing.Size(466, 403)
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lueType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lueCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.beWebSite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gcMovies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gvMovies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciType, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciWebSite, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciCountry, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciMoviesGridBar, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciMovies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.peFlag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciFlag, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private teName As DevExpress.XtraEditors.TextEdit
		Private WithEvents ucGridEditBar As DevExpress.VideoRent.Win.Controls.ucGridEditBar
		Private gcMovies As DevExpress.XtraGrid.GridControl
		Private gvMovies As DevExpress.XtraGrid.Views.Grid.GridView
		Private colMovie As DevExpress.XtraGrid.Columns.GridColumn
		Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
		Private lueType As DevExpress.XtraEditors.LookUpEdit
		Private WithEvents lueCountry As DevExpress.XtraEditors.LookUpEdit
		Private WithEvents beWebSite As DevExpress.XtraEditors.ButtonEdit
		Private lciName As DevExpress.XtraLayout.LayoutControlItem
		Private lciWebSite As DevExpress.XtraLayout.LayoutControlItem
		Private lciType As DevExpress.XtraLayout.LayoutControlItem
		Private lciCountry As DevExpress.XtraLayout.LayoutControlItem
		Private lciMoviesGridBar As DevExpress.XtraLayout.LayoutControlItem
		Private lciMovies As DevExpress.XtraLayout.LayoutControlItem
		Private simpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
		Private peFlag As DevExpress.XtraEditors.PictureEdit
		Private lciFlag As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace
