Imports DevExpress.XtraBars.Ribbon
Imports System
Imports System.Drawing

Namespace DevExpress.XtraMap.Demos

    Partial Class PixelMap

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim geoMapCoordinateSystem1 As DevExpress.XtraMap.GeoMapCoordinateSystem = New DevExpress.XtraMap.GeoMapCoordinateSystem()
            Dim epsG4326Projection1 As DevExpress.XtraMap.EPSG4326Projection = New DevExpress.XtraMap.EPSG4326Projection()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraMap.Demos.PixelMap))
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.mapItemStorage1 = New DevExpress.XtraMap.MapItemStorage()
            Me.vectorItemsLayer2 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
            Me.rpgPointsComplexity = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem2 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem3 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem4 = New DevExpress.XtraBars.BarCheckItem()
            Me.barEditItem2 = New DevExpress.XtraBars.BarEditItem()
            Me.barEditItem3 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemColorPickEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit()
            Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
            Me.barListItem1 = New DevExpress.XtraBars.BarListItem()
            Me.barListItem2 = New DevExpress.XtraBars.BarListItem()
            Me.barEditItem4 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.barStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.barCheckItem5 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem6 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem7 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem8 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem9 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem10 = New DevExpress.XtraBars.BarCheckItem()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemColorPickEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonItem2, Me.barCheckItem5, Me.barCheckItem6, Me.barCheckItem7, Me.barCheckItem8, Me.barCheckItem9, Me.barCheckItem10})
            Me.ribbonControl1.MaxItemId = 14
            ' 
            ' rpOptions
            ' 
            Me.rpOptions.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup3, Me.rpgPointsComplexity, Me.ribbonPageGroup2})
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((47)))))), (CInt(((CByte((173)))))), (CInt(((CByte((213)))))))
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(5R, 0R)
            geoMapCoordinateSystem1.Projection = epsG4326Projection1
            Me.mapControl1.CoordinateSystem = geoMapCoordinateSystem1
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.vectorItemsLayer1)
            Me.mapControl1.Layers.Add(Me.vectorItemsLayer2)
            Me.mapControl1.Location = New System.Drawing.Point(0, 141)
            Me.mapControl1.MinZoomLevel = 1.5R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.Size = New System.Drawing.Size(500, 359)
            Me.mapControl1.TabIndex = 1
            Me.mapControl1.ZoomLevel = 1.5R
            Me.vectorItemsLayer1.Data = Me.mapItemStorage1
            Me.vectorItemsLayer1.EnableHighlighting = False
            Me.vectorItemsLayer1.EnableSelection = False
            Me.vectorItemsLayer1.ItemStyle.Fill = System.Drawing.Color.FromArgb((CInt(((CByte((125)))))), (CInt(((CByte((211)))))), (CInt(((CByte((236)))))))
            Me.vectorItemsLayer1.ItemStyle.Stroke = System.Drawing.Color.FromArgb((CInt(((CByte((125)))))), (CInt(((CByte((211)))))), (CInt(((CByte((236)))))))
            ' 
            ' barEditItem1
            ' 
            Me.barEditItem1.Edit = Nothing
            Me.barEditItem1.EditHeight = 60
            Me.barEditItem1.EditValue = 32
            Me.barEditItem1.EditWidth = 120
            Me.barEditItem1.Id = -1
            Me.barEditItem1.Name = "barEditItem1"
            ' 
            ' rpgPointsComplexity
            ' 
            Me.rpgPointsComplexity.ItemLinks.Add(Me.barCheckItem1)
            Me.rpgPointsComplexity.ItemLinks.Add(Me.barCheckItem2)
            Me.rpgPointsComplexity.ItemLinks.Add(Me.barCheckItem3)
            Me.rpgPointsComplexity.ItemLinks.Add(Me.barCheckItem4)
            Me.rpgPointsComplexity.Name = "rpgPointsComplexity"
            Me.rpgPointsComplexity.Text = "Points Complexity"
            ' 
            ' barCheckItem1
            ' 
            Me.barCheckItem1.Caption = "3"
            Me.barCheckItem1.GroupIndex = 1
            Me.barCheckItem1.Id = 7
            Me.barCheckItem1.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.f3
            Me.barCheckItem1.Name = "barCheckItem1"
            Me.barCheckItem1.Tag = 3
            AddHandler Me.barCheckItem1.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnPointsComplexityChanged)
            ' 
            ' barCheckItem2
            ' 
            Me.barCheckItem2.BindableChecked = True
            Me.barCheckItem2.Caption = "4"
            Me.barCheckItem2.Checked = True
            Me.barCheckItem2.GroupIndex = 1
            Me.barCheckItem2.Id = 8
            Me.barCheckItem2.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.f4
            Me.barCheckItem2.Name = "barCheckItem2"
            Me.barCheckItem2.Tag = 4
            AddHandler Me.barCheckItem2.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnPointsComplexityChanged)
            ' 
            ' barCheckItem3
            ' 
            Me.barCheckItem3.Caption = "6"
            Me.barCheckItem3.GroupIndex = 1
            Me.barCheckItem3.Id = 9
            Me.barCheckItem3.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.f6
            Me.barCheckItem3.Name = "barCheckItem3"
            Me.barCheckItem3.Tag = 6
            AddHandler Me.barCheckItem3.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnPointsComplexityChanged)
            ' 
            ' barCheckItem4
            ' 
            Me.barCheckItem4.Caption = "8"
            Me.barCheckItem4.GroupIndex = 1
            Me.barCheckItem4.Id = 10
            Me.barCheckItem4.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.f8
            Me.barCheckItem4.Name = "barCheckItem4"
            Me.barCheckItem4.Tag = 8
            AddHandler Me.barCheckItem4.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnPointsComplexityChanged)
            ' 
            ' barEditItem2
            ' 
            Me.barEditItem2.Edit = Nothing
            Me.barEditItem2.EditHeight = 60
            Me.barEditItem2.EditValue = 4
            Me.barEditItem2.EditWidth = 120
            Me.barEditItem2.Id = 11
            Me.barEditItem2.Name = "barEditItem2"
            ' 
            ' barEditItem3
            ' 
            Me.barEditItem3.Edit = Me.repositoryItemColorPickEdit1
            Me.barEditItem3.EditHeight = 20
            Me.barEditItem3.EditValue = System.Drawing.Color.FromArgb((CInt(((CByte((200)))))), (CInt(((CByte((200)))))), (CInt(((CByte((200)))))))
            Me.barEditItem3.EditWidth = 120
            Me.barEditItem3.Id = 2
            Me.barEditItem3.ItemAppearance.Hovered.Options.UseBorderColor = True
            Me.barEditItem3.ItemInMenuAppearance.Hovered.Options.UseBorderColor = True
            Me.barEditItem3.Name = "barEditItem3"
            ' 
            ' repositoryItemColorPickEdit1
            ' 
            Me.repositoryItemColorPickEdit1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.repositoryItemColorPickEdit1.Appearance.Options.UseBackColor = True
            Me.repositoryItemColorPickEdit1.Appearance.Options.UseTextOptions = True
            Me.repositoryItemColorPickEdit1.AutomaticColor = System.Drawing.Color.Black
            Me.repositoryItemColorPickEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
            Me.repositoryItemColorPickEdit1.Name = "repositoryItemColorPickEdit1"
            ' 
            ' barStaticItem1
            ' 
            Me.barStaticItem1.Id = 6
            Me.barStaticItem1.Name = "barStaticItem1"
            ' 
            ' barListItem1
            ' 
            Me.barListItem1.Id = 4
            Me.barListItem1.Name = "barListItem1"
            ' 
            ' barListItem2
            ' 
            Me.barListItem2.Id = 5
            Me.barListItem2.Name = "barListItem2"
            ' 
            ' barEditItem4
            ' 
            Me.barEditItem4.Edit = Me.repositoryItemComboBox1
            Me.barEditItem4.EditValue = 32
            Me.barEditItem4.EditWidth = 100
            Me.barEditItem4.Id = 9
            Me.barEditItem4.ItemAppearance.Pressed.Options.UseBorderColor = True
            Me.barEditItem4.Name = "barEditItem4"
            ' 
            ' repositoryItemComboBox1
            ' 
            Me.repositoryItemComboBox1.AutoHeight = False
            Me.repositoryItemComboBox1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            Me.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            ' 
            ' barStaticItem2
            ' 
            Me.barStaticItem2.Id = 7
            Me.barStaticItem2.Name = "barStaticItem2"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Shapes color"
            Me.barButtonItem1.Id = 3
            Me.barButtonItem1.ImageOptions.Image = CType((resources.GetObject("barButtonItem1.ImageOptions.Image")), System.Drawing.Image)
            Me.barButtonItem1.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem1.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem1.LargeWidth = 90
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' ribbonPageGroup2
            ' 
            Me.ribbonPageGroup2.AllowTextClipping = False
            Me.ribbonPageGroup2.ItemLinks.Add(Me.barButtonItem2)
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.Text = "Shapes Color"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Id = 7
            Me.barButtonItem2.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Color
            Me.barButtonItem2.Name = "barButtonItem2"
            AddHandler Me.barButtonItem2.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnShapesColorItemClick)
            ' 
            ' ribbonPageGroup3
            ' 
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.ItemLinks.Add(Me.barCheckItem5)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.barCheckItem6)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.barCheckItem7)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.barCheckItem8)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.barCheckItem9)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.barCheckItem10)
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.Text = "Point Density"
            ' 
            ' barCheckItem5
            ' 
            Me.barCheckItem5.Caption = " 24"
            Me.barCheckItem5.GroupIndex = 2
            Me.barCheckItem5.Id = 8
            Me.barCheckItem5.ItemAppearance.Normal.Options.UseBorderColor = True
            Me.barCheckItem5.Name = "barCheckItem5"
            Me.barCheckItem5.Tag = 24
            AddHandler Me.barCheckItem5.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnPointDensityChanged)
            ' 
            ' barCheckItem6
            ' 
            Me.barCheckItem6.Caption = " 92 "
            Me.barCheckItem6.GroupIndex = 2
            Me.barCheckItem6.Id = 9
            Me.barCheckItem6.Name = "barCheckItem6"
            Me.barCheckItem6.Tag = 92
            AddHandler Me.barCheckItem6.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnPointDensityChanged)
            ' 
            ' barCheckItem7
            ' 
            Me.barCheckItem7.Caption = "192"
            Me.barCheckItem7.GroupIndex = 2
            Me.barCheckItem7.Id = 10
            Me.barCheckItem7.Name = "barCheckItem7"
            Me.barCheckItem7.Tag = 192
            AddHandler Me.barCheckItem7.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnPointDensityChanged)
            ' 
            ' barCheckItem8
            ' 
            Me.barCheckItem8.BindableChecked = True
            Me.barCheckItem8.Caption = " 56 "
            Me.barCheckItem8.Checked = True
            Me.barCheckItem8.GroupIndex = 2
            Me.barCheckItem8.Id = 11
            Me.barCheckItem8.Name = "barCheckItem8"
            Me.barCheckItem8.Tag = 56
            AddHandler Me.barCheckItem8.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnPointDensityChanged)
            ' 
            ' barCheckItem9
            ' 
            Me.barCheckItem9.Caption = "128"
            Me.barCheckItem9.GroupIndex = 2
            Me.barCheckItem9.Id = 12
            Me.barCheckItem9.Name = "barCheckItem9"
            Me.barCheckItem9.Tag = 128
            AddHandler Me.barCheckItem9.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnPointDensityChanged)
            ' 
            ' barCheckItem10
            ' 
            Me.barCheckItem10.Caption = "256"
            Me.barCheckItem10.GroupIndex = 2
            Me.barCheckItem10.Id = 13
            Me.barCheckItem10.Name = "barCheckItem10"
            Me.barCheckItem10.Tag = 256
            AddHandler Me.barCheckItem10.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnPointDensityChanged)
            ' 
            ' PixelMap
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "PixelMap"
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.Controls.SetChildIndex(Me.mapControl1, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemColorPickEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private rpgPointsComplexity As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private barEditItem1 As DevExpress.XtraBars.BarEditItem

        Private barEditItem2 As DevExpress.XtraBars.BarEditItem

        Private barEditItem3 As DevExpress.XtraBars.BarEditItem

        Private repositoryItemColorPickEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit

        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private barCheckItem1 As DevExpress.XtraBars.BarCheckItem

        Private barCheckItem2 As DevExpress.XtraBars.BarCheckItem

        Private barCheckItem3 As DevExpress.XtraBars.BarCheckItem

        Private barCheckItem4 As DevExpress.XtraBars.BarCheckItem

        Private barEditItem4 As DevExpress.XtraBars.BarEditItem

        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

        Private barListItem1 As DevExpress.XtraBars.BarListItem

        Private barListItem2 As DevExpress.XtraBars.BarListItem

        Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem

        Private barStaticItem2 As DevExpress.XtraBars.BarStaticItem

        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer

        Private mapItemStorage1 As DevExpress.XtraMap.MapItemStorage

        Private vectorItemsLayer2 As DevExpress.XtraMap.VectorItemsLayer

        Private barCheckItem5 As DevExpress.XtraBars.BarCheckItem

        Private barCheckItem6 As DevExpress.XtraBars.BarCheckItem

        Private barCheckItem7 As DevExpress.XtraBars.BarCheckItem

        Private barCheckItem8 As DevExpress.XtraBars.BarCheckItem

        Private barCheckItem9 As DevExpress.XtraBars.BarCheckItem

        Private barCheckItem10 As DevExpress.XtraBars.BarCheckItem

        Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    End Class
End Namespace
