Namespace DevExpress.XtraMap.Demos

    Partial Class ShapeImage

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
            Me.mapControlField = New DevExpress.XtraMap.MapControl()
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.AzureMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.mapItemStorage = New DevExpress.XtraMap.MapItemStorage()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControlField), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.MaxItemId = 10
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.IEBehavior = True
            Me.ribbonControl1.Size = New System.Drawing.Size(843, 141)
            ' 
            ' mapControl
            ' 
            Me.mapControlField.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControlField.CenterPoint = New DevExpress.XtraMap.GeoPoint(40.78R, -73.9675R)
            Me.mapControlField.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControlField.Layers.Add(Me.imageLayer1)
            Me.mapControlField.Layers.Add(Me.vectorItemsLayer1)
            Me.mapControlField.Location = New System.Drawing.Point(0, 141)
            Me.mapControlField.MaxZoomLevel = 17R
            Me.mapControlField.MinZoomLevel = 10R
            Me.mapControlField.Name = "mapControl"
            Me.mapControlField.NavigationPanelOptions.XCoordinatePattern = "{CP}{D}°{M:2}'"
            Me.mapControlField.NavigationPanelOptions.YCoordinatePattern = "{CP}{D}°{M:2}'"
            Me.mapControlField.Size = New System.Drawing.Size(843, 446)
            Me.mapControlField.TabIndex = 1
            Me.mapControlField.ZoomLevel = 14R
            Me.imageLayer1.DataProvider = Me.AzureMapDataProvider
            AddHandler Me.imageLayer1.ViewportChanged, New DevExpress.XtraMap.ViewportChangedEventHandler(AddressOf Me.ImageLayer1_ViewportChanged)
            Me.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad
            Me.vectorItemsLayer1.Data = Me.mapItemStorage
            ' 
            ' ShapeImage
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.panelControl1.Controls.Add(Me.mapControlField)
            Me.Name = "ShapeImage"
            Me.Size = New System.Drawing.Size(843, 587)
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.panelControl1.Controls.SetChildIndex(Me.mapControlField, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControlField), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControlField As DevExpress.XtraMap.MapControl

        Private vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer

        Private mapItemStorage As DevExpress.XtraMap.MapItemStorage

        Private imageLayer1 As DevExpress.XtraMap.ImageLayer

        Private AzureMapDataProvider As DevExpress.XtraMap.AzureMapDataProvider
    End Class
End Namespace
