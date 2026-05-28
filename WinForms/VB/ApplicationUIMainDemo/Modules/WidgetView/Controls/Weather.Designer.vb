Namespace DevExpress.ApplicationUI.Demos

    Partial Class Weather

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.ApplicationUI.Demos.Weather))
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.weatherItem1 = New DevExpress.ApplicationUI.Demos.WeatherItem()
            Me.weatherItem2 = New DevExpress.ApplicationUI.Demos.WeatherItem()
            Me.weatherItem3 = New DevExpress.ApplicationUI.Demos.WeatherItem()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 3
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.tableLayoutPanel1.Controls.Add(Me.weatherItem1, 1, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.weatherItem2, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.weatherItem3, 2, 0)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 1
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(340, 256)
            Me.tableLayoutPanel1.TabIndex = 0
            ' 
            ' weatherItem1
            ' 
            Me.weatherItem1.BackColor = System.Drawing.Color.Transparent
            Me.weatherItem1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.weatherItem1.Image = CType((resources.GetObject("weatherItem1.Image")), System.Drawing.Image)
            Me.weatherItem1.Location = New System.Drawing.Point(116, 3)
            Me.weatherItem1.Name = "weatherItem1"
            Me.weatherItem1.RelativeHumidity = "94%"
            Me.weatherItem1.Sity = "Moscow"
            Me.weatherItem1.Size = New System.Drawing.Size(107, 250)
            Me.weatherItem1.SkyConditions = "Cloudy"
            Me.weatherItem1.TabIndex = 2
            Me.weatherItem1.Temperature = "23F (-5C)"
            ' 
            ' weatherItem2
            ' 
            Me.weatherItem2.BackColor = System.Drawing.Color.Transparent
            Me.weatherItem2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.weatherItem2.Image = CType((resources.GetObject("weatherItem2.Image")), System.Drawing.Image)
            Me.weatherItem2.Location = New System.Drawing.Point(3, 3)
            Me.weatherItem2.Name = "weatherItem2"
            Me.weatherItem2.RelativeHumidity = "86%"
            Me.weatherItem2.Sity = "London"
            Me.weatherItem2.Size = New System.Drawing.Size(107, 250)
            Me.weatherItem2.SkyConditions = "Showers"
            Me.weatherItem2.TabIndex = 2
            Me.weatherItem2.Temperature = "37F (3C)"
            ' 
            ' weatherItem3
            ' 
            Me.weatherItem3.BackColor = System.Drawing.Color.Transparent
            Me.weatherItem3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.weatherItem3.Image = CType((resources.GetObject("weatherItem3.Image")), System.Drawing.Image)
            Me.weatherItem3.Location = New System.Drawing.Point(229, 3)
            Me.weatherItem3.Name = "weatherItem3"
            Me.weatherItem3.RelativeHumidity = "81%"
            Me.weatherItem3.Sity = "New York"
            Me.weatherItem3.Size = New System.Drawing.Size(108, 250)
            Me.weatherItem3.SkyConditions = "Clear"
            Me.weatherItem3.TabIndex = 3
            Me.weatherItem3.Temperature = "25F (-3C)"
            ' 
            ' Weather
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Name = "Weather"
            Me.Size = New System.Drawing.Size(340, 256)
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

        Private weatherItem1 As DevExpress.ApplicationUI.Demos.WeatherItem

        Private weatherItem2 As DevExpress.ApplicationUI.Demos.WeatherItem

        Private weatherItem3 As DevExpress.ApplicationUI.Demos.WeatherItem
    End Class
End Namespace
