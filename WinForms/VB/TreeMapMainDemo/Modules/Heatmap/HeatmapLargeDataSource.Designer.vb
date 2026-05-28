Namespace DevExpress.XtraTreeMap.Demos

    Partial Class HeatmapLargeDataSource

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
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim heatmapObjectColorProvider1 As DevExpress.XtraCharts.Heatmap.HeatmapObjectColorProvider = New DevExpress.XtraCharts.Heatmap.HeatmapObjectColorProvider()
            Me.heatmapControl1 = New DevExpress.XtraCharts.Heatmap.HeatmapControl()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.SuspendLayout()
            ' 
            ' heatmapControl1
            ' 
            Me.heatmapControl1.ColorProvider = heatmapObjectColorProvider1
            Me.heatmapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.heatmapControl1.Location = New System.Drawing.Point(0, 0)
            Me.heatmapControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.heatmapControl1.Name = "heatmapControl1"
            Me.heatmapControl1.Padding = New System.Windows.Forms.Padding(5)
            Me.heatmapControl1.Size = New System.Drawing.Size(500, 500)
            Me.heatmapControl1.TabIndex = 0
            Me.heatmapControl1.Text = "heatmapControl1"
            ' 
            ' timer1
            ' 
            AddHandler Me.timer1.Tick, New System.EventHandler(AddressOf Me.OnTimerTick)
            ' 
            ' HeatmapLargeDataSource
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.heatmapControl1)
            Me.Name = "HeatmapLargeDataSource"
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private heatmapControl1 As DevExpress.XtraCharts.Heatmap.HeatmapControl

        Private timer1 As System.Windows.Forms.Timer
    End Class
End Namespace
