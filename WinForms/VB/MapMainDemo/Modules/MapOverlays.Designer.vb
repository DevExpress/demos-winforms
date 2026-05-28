Imports System.Drawing

Namespace DevExpress.XtraMap.Demos

    Partial Class MapOverlays

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

            Me.OnDispose()
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim keyColorColorizer1 As DevExpress.XtraMap.KeyColorColorizer = New DevExpress.XtraMap.KeyColorColorizer()
            Dim attributeItemKeyProvider1 As DevExpress.XtraMap.AttributeItemKeyProvider = New DevExpress.XtraMap.AttributeItemKeyProvider()
            Dim colorizerKeyItem1 As DevExpress.XtraMap.ColorizerKeyItem = New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem2 As DevExpress.XtraMap.ColorizerKeyItem = New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem3 As DevExpress.XtraMap.ColorizerKeyItem = New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem4 As DevExpress.XtraMap.ColorizerKeyItem = New DevExpress.XtraMap.ColorizerKeyItem()
            Dim geoMapCoordinateSystem1 As DevExpress.XtraMap.GeoMapCoordinateSystem = New DevExpress.XtraMap.GeoMapCoordinateSystem()
            Dim millerProjection1 As DevExpress.XtraMap.MillerProjection = New DevExpress.XtraMap.MillerProjection()
            Me.FileLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.ShapefileDataAdapter = New DevExpress.XtraMap.ShapefileDataAdapter()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' FileLayer
            ' 
            attributeItemKeyProvider1.AttributeName = "Answer"
            keyColorColorizer1.ItemKeyProvider = attributeItemKeyProvider1
            colorizerKeyItem1.Key = "Wrong"
            colorizerKeyItem1.Name = "Wrong"
            colorizerKeyItem2.Key = "None"
            colorizerKeyItem2.Name = "None"
            colorizerKeyItem3.Key = "Try"
            colorizerKeyItem3.Name = "Try"
            colorizerKeyItem4.Key = "Right"
            colorizerKeyItem4.Name = "Right"
            keyColorColorizer1.Keys.Add(colorizerKeyItem1)
            keyColorColorizer1.Keys.Add(colorizerKeyItem2)
            keyColorColorizer1.Keys.Add(colorizerKeyItem3)
            keyColorColorizer1.Keys.Add(colorizerKeyItem4)
            keyColorColorizer1.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Palette
            Me.FileLayer.Colorizer = keyColorColorizer1
            Me.FileLayer.Data = Me.ShapefileDataAdapter
            Me.FileLayer.Name = "FileLayer"
            AddHandler Me.FileLayer.DataLoaded, New DevExpress.XtraMap.DataLoadedEventHandler(AddressOf Me.LayerDataLoaded)
            ' 
            ' ShapefileDataAdapter
            ' 
            AddHandler Me.ShapefileDataAdapter.ItemsLoaded, New DevExpress.XtraMap.ItemsLoadedEventHandler(AddressOf Me.ShapeItemsLoaded)
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BackColor = System.Drawing.Color.LightBlue
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(33R, 0R)
            geoMapCoordinateSystem1.Projection = millerProjection1
            Me.mapControl1.CoordinateSystem = geoMapCoordinateSystem1
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.FileLayer)
            Me.mapControl1.Location = New System.Drawing.Point(0, 139)
            Me.mapControl1.MaxZoomLevel = 8R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.[Single]
            Me.mapControl1.Size = New System.Drawing.Size(500, 361)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ZoomLevel = 2R
            AddHandler Me.mapControl1.OverlaysArranged, New DevExpress.XtraMap.OverlaysArrangedEventHandler(AddressOf Me.OnMapControlOverlaysArranged)
            AddHandler Me.mapControl1.MouseUp, New System.Windows.Forms.MouseEventHandler(AddressOf Me.OnMapControlMouseUp)
            ' 
            ' FlagsGame
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "FlagsGame"
            Me.Controls.SetChildIndex(Me.mapControl1, 0)
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private FileLayer As DevExpress.XtraMap.VectorItemsLayer

        Private ShapefileDataAdapter As DevExpress.XtraMap.ShapefileDataAdapter
    End Class
End Namespace
