Namespace DevExpress.XtraMap.Demos

    Partial Class WebMapService

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
            Me.WmsLayer = New DevExpress.XtraMap.ImageLayer()
            Me.Provider = New DevExpress.XtraMap.WmsDataProvider()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.editWebMapSevice = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemButtonEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' WmsLayer
            ' 
            Me.WmsLayer.DataProvider = Me.Provider
            Me.WmsLayer.Name = "WmsLayer"
            ' 
            ' Provider
            ' 
            Me.Provider.ServerUri = "http://ows.mundialis.de/services/service"
            AddHandler Me.Provider.ResponseCapabilities, New DevExpress.XtraMap.CapabilitiesRespondedEventHandler(AddressOf Me.OnResponseCapabilities)
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BackColor = System.Drawing.Color.LightBlue
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(34.5R, -91.5R)
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.EnableRotation = False
            Me.mapControl1.Layers.Add(Me.WmsLayer)
            Me.mapControl1.Location = New System.Drawing.Point(0, 139)
            Me.mapControl1.MaxZoomLevel = 8R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.Size = New System.Drawing.Size(500, 361)
            Me.mapControl1.TabIndex = 1
            Me.mapControl1.ZoomLevel = 4R
            AddHandler Me.mapControl1.OverlaysArranged, New DevExpress.XtraMap.OverlaysArrangedEventHandler(AddressOf Me.OnOverlaysArranged)
            AddHandler Me.mapControl1.MouseUp, New System.Windows.Forms.MouseEventHandler(AddressOf Me.OnMapControlMouseUp)
            ' 
            ' editWebMapSevice
            ' 
            Me.editWebMapSevice.Edit = Me.repositoryItemComboBox1
            Me.editWebMapSevice.EditWidth = 120
            Me.editWebMapSevice.Id = 1
            Me.editWebMapSevice.Name = "editWebMapSevice"
            AddHandler Me.editWebMapSevice.EditValueChanged, New System.EventHandler(AddressOf Me.editWebMapSevice_EditValueChanged)
            ' 
            ' repositoryItemComboBox1
            ' 
            Me.repositoryItemComboBox1.AutoHeight = False
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Options"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.editWebMapSevice)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Web Map Service"
            ' 
            ' repositoryItemButtonEdit1
            ' 
            Me.repositoryItemButtonEdit1.AutoHeight = False
            Me.repositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
            ' 
            ' WebMapService
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.panelControl1.Controls.Add(Me.mapControl1)
            Me.Name = "WebMapService"
            Me.panelControl1.Controls.SetChildIndex(Me.mapControl1, 0)
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemButtonEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private WmsLayer As DevExpress.XtraMap.ImageLayer

        Private Provider As DevExpress.XtraMap.WmsDataProvider

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private editWebMapSevice As DevExpress.XtraBars.BarEditItem

        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    End Class
End Namespace
