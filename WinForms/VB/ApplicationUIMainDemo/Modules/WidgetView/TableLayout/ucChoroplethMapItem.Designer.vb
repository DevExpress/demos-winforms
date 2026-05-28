Namespace DevExpress.ApplicationUI.Demos

    Partial Class ucChoroplethMapItem

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
        ''' 
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.totalSalesItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.totalSalesItemBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(38R, -95R)
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.ShowCoordinates = False
            Me.mapControl1.NavigationPanelOptions.ShowKilometersScale = False
            Me.mapControl1.NavigationPanelOptions.ShowMilesScale = False
            Me.mapControl1.NavigationPanelOptions.ShowScrollButtons = False
            Me.mapControl1.NavigationPanelOptions.ShowZoomTrackbar = False
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.Size = New System.Drawing.Size(694, 365)
            Me.mapControl1.TabIndex = 1
            Me.mapControl1.ToolTipController = Me.toolTipController1
            Me.mapControl1.ZoomLevel = 3R
            AddHandler Me.mapControl1.MapItemClick, New DevExpress.XtraMap.MapItemClickEventHandler(AddressOf Me.OnMapItemClick)
            ' 
            ' ucChoroplethMapItem
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "ucChoroplethMapItem"
            Me.Size = New System.Drawing.Size(694, 365)
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.totalSalesItemBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private totalSalesItemBindingSource As System.Windows.Forms.BindingSource
    End Class
End Namespace
