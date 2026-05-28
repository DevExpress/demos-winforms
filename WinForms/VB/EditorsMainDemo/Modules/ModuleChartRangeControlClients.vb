Imports System
Imports System.Data
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleChartRangeControlClients
        Inherits TutorialControl

        Const seriesCount As Integer = 3

        Const pointCount As Integer = 50

        Const valueLevelThreshold As Double = 100

        Const argumentColumn As String = "Argument"

        Const valueColumn As String = "Value"

        Const seriesColumn As String = "Series"

        Private ReadOnly numericDataSource As DataTable

        Private ReadOnly dateTimeDataSource As DataTable

        Private ReadOnly timeSpanDataSource As DataTable

        Private ReadOnly baseDate As Date

        Public Sub New()
            InitializeComponent()
            CalcControlsBestSize()
            TutorialInfo.AboutFile = Nothing
            TutorialInfo.Description = ""
            TutorialInfo.TutorialName = "Chart Range Control Clients Tutorial"
            numericDataSource = New DataTable()
            dateTimeDataSource = New DataTable()
            timeSpanDataSource = New DataTable()
            baseDate = TutorialConstants.Now
            SetClientDateSource(dateTimeClient, dateTimeDataSource, GetType(Date))
            SetClientDateSource(timeSpanClient, timeSpanDataSource, GetType(TimeSpan))
            SetClientDateSource(numericClient, numericDataSource, GetType(Double))
            radioGroupView.SelectedIndex = 1
            InitPalettes()
            checkEditNumericAuto.Checked = True
            checkEditDateTimeAuto.Checked = True
            checkEditTimeSpanAuto.Checked = True
            FillDateTimeComboBox(comboBoxDateTimeGridAlignment)
            FillDateTimeComboBox(comboBoxDateTimeSnapAlignment)
            FillTimeSpanComboBox(comboBoxTimeSpanGridAlignment)
            FillTimeSpanComboBox(comboBoxTimeSpanSnapAlignment)
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleChartRangeControlClients"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "chartRangeControlClients"
            End Get
        End Property

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            CalcControlsBestSize()
        End Sub

        Private Sub CalcControlsBestSize()
            layoutControl1.BeginUpdate()
            Try
                CalcTrackBarBestSize(trackBarDateTimeGridSpacing)
                CalcTrackBarBestSize(trackBarDateTimeSnapSpacing)
                CalcTrackBarBestSize(trackBarNumericGridSpacing)
                CalcTrackBarBestSize(trackBarNumericSnapSpacing)
                CalcTrackBarBestSize(trackBarTimeSpanGridSpacing)
                CalcTrackBarBestSize(trackBarTimeSpanSnapSpacing)
            Finally
                layoutControl1.EndUpdate()
            End Try
        End Sub

        Private Sub FillDateTimeComboBox(ByVal comboBox As ComboBoxEdit)
            comboBox.Properties.Items.Add(RangeControlDateTimeGridAlignment.Day)
            comboBox.Properties.Items.Add(RangeControlDateTimeGridAlignment.Week)
            comboBox.Properties.Items.Add(RangeControlDateTimeGridAlignment.Month)
        End Sub

        Private Sub FillTimeSpanComboBox(ByVal comboBox As ComboBoxEdit)
            comboBox.Properties.Items.Add(RangeControlTimeSpanGridAlignment.Minute)
            comboBox.Properties.Items.Add(RangeControlTimeSpanGridAlignment.Hour)
        End Sub

        Private Function GetArgumentByIndex(ByVal argumentType As Type, ByVal index As Integer) As Object
            If argumentType Is GetType(Date) Then Return baseDate.AddDays(index * 7)
            If argumentType Is GetType(TimeSpan) Then Return TimeSpan.FromMinutes(index * 30)
            Return CDbl(index * 10000)
        End Function

        Private Sub SetClientDateSource(ByVal client As ChartRangeControlClientBase, ByVal dataSource As DataTable, ByVal argumentType As Type)
            dataSource.Columns.Add(seriesColumn, GetType(String))
            dataSource.Columns.Add(argumentColumn, argumentType)
            dataSource.Columns.Add(valueColumn, GetType(Double))
            Dim rand = If(MainFormHelper.TakeScreens, TutorialConstants.Random, DevExpress.Data.Utils.NonCryptographicRandom.System)
            Dim valueLevel As Double = valueLevelThreshold * seriesCount
            For seriesIndex As Integer = 0 To seriesCount - 1
                For pointIndex As Integer = 0 To pointCount - 1
                    dataSource.Rows.Add("Series " & seriesIndex.ToString(), GetArgumentByIndex(argumentType, pointIndex), rand.NextDouble() * valueLevelThreshold + valueLevel)
                Next

                valueLevel -= valueLevelThreshold
            Next

            client.DataProvider.SeriesDataMember = seriesColumn
            client.DataProvider.ArgumentDataMember = argumentColumn
            client.DataProvider.ValueDataMember = valueColumn
            client.DataProvider.DataSource = dataSource
        End Sub

        Private Sub InitPalettes()
            For Each paletteName As String In ChartRangeControlClientBase.PredefinedPalettes
                comboBoxPalette.Properties.Items.Add(paletteName)
            Next

            comboBoxPalette.SelectedItem = numericClient.PaletteName
        End Sub

        Private Sub SetTrackBarRange(ByVal trackBar As TrackBarControl, ByVal min As Integer, ByVal max As Integer)
            trackBar.Properties.BeginUpdate()
            trackBar.Properties.Minimum = 0
            trackBar.Properties.Maximum = Integer.MaxValue
            trackBar.Value = min
            trackBar.Properties.Minimum = min
            trackBar.Properties.Maximum = max
            trackBar.Properties.EndUpdate()
        End Sub

        Private Sub SetSpacingDateTimeTrackBarRange(ByVal trackBar As TrackBarControl, ByVal alignment As RangeControlDateTimeGridAlignment)
            Select Case alignment
                Case RangeControlDateTimeGridAlignment.Day
                    SetTrackBarRange(trackBar, 40, 60)
                Case RangeControlDateTimeGridAlignment.Week
                    SetTrackBarRange(trackBar, 6, 12)
                Case Else
                    SetTrackBarRange(trackBar, 2, 6)
            End Select
        End Sub

        Private Sub SetSpacingTimeSpanTrackBarRange(ByVal trackBar As TrackBarControl, ByVal alignment As RangeControlTimeSpanGridAlignment)
            Select Case alignment
                Case RangeControlTimeSpanGridAlignment.Minute
                    SetTrackBarRange(trackBar, 30, 120)
                Case Else
                    SetTrackBarRange(trackBar, 1, 12)
            End Select
        End Sub

        ' <radioGroupView>
        Private Sub radioGroupView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim viewType As Integer = CInt(radioGroupView.SelectedIndex)
            Dim clientView As ChartRangeControlClientView = Nothing
            Select Case viewType
                Case 0
                    clientView = New LineChartRangeControlClientView()
                Case Else
                    clientView = New AreaChartRangeControlClientView()
            End Select

            dateTimeClient.DataProvider.TemplateView = clientView
            numericClient.DataProvider.TemplateView = clientView
            timeSpanClient.DataProvider.TemplateView = clientView
        End Sub

        ' </radioGroupView>
        ' <comboBoxPalette>
        Private Sub comboBoxPalette_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim paletteName As String = CStr(comboBoxPalette.SelectedItem)
            numericClient.PaletteName = paletteName
            dateTimeClient.PaletteName = paletteName
            timeSpanClient.PaletteName = paletteName
        End Sub

        ' </comboBoxPalette>
        ' <checkEditNumericAuto>
        Private Sub checkEditNumericAuto_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim gridOptions As NumericChartRangeControlClientGridOptions = numericClient.GridOptions
            gridOptions.Auto = checkEditNumericAuto.Checked
            trackBarNumericGridSpacing.Enabled = Not gridOptions.Auto
            trackBarNumericSnapSpacing.Enabled = Not gridOptions.Auto
            If Not gridOptions.Auto Then
                trackBarNumericGridSpacing.Value = CInt(gridOptions.GridSpacing)
                trackBarNumericSnapSpacing.Value = CInt(gridOptions.SnapSpacing)
            End If
        End Sub

        ' </checkEditNumericAuto>
        ' <checkEditDateTimeAuto>
        Private Sub checkEditDateTimeAuto_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim gridOptions As DateTimeChartRangeControlClientGridOptions = dateTimeClient.GridOptions
            gridOptions.Auto = checkEditDateTimeAuto.Checked
            trackBarDateTimeGridSpacing.Enabled = Not gridOptions.Auto
            trackBarDateTimeSnapSpacing.Enabled = Not gridOptions.Auto
            comboBoxDateTimeGridAlignment.Enabled = Not gridOptions.Auto
            comboBoxDateTimeSnapAlignment.Enabled = Not gridOptions.Auto
            If Not gridOptions.Auto Then
                comboBoxDateTimeGridAlignment.SelectedItem = gridOptions.GridAlignment
                comboBoxDateTimeSnapAlignment.SelectedItem = gridOptions.SnapAlignment
                trackBarDateTimeSnapSpacing.Value = CInt(gridOptions.SnapSpacing)
                trackBarDateTimeGridSpacing.Value = CInt(gridOptions.GridSpacing)
            End If
        End Sub

        ' </checkEditDateTimeAuto>
        ' <checkEditTimeSpanAuto>
        Private Sub checkEditTimeSpanAuto_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim gridOptions As TimeSpanChartRangeControlClientGridOptions = timeSpanClient.GridOptions
            gridOptions.Auto = checkEditTimeSpanAuto.Checked
            trackBarTimeSpanGridSpacing.Enabled = Not gridOptions.Auto
            trackBarTimeSpanSnapSpacing.Enabled = Not gridOptions.Auto
            comboBoxTimeSpanGridAlignment.Enabled = Not gridOptions.Auto
            comboBoxTimeSpanSnapAlignment.Enabled = Not gridOptions.Auto
            If Not gridOptions.Auto Then
                comboBoxTimeSpanGridAlignment.SelectedItem = gridOptions.GridAlignment
                comboBoxTimeSpanSnapAlignment.SelectedItem = gridOptions.SnapAlignment
                trackBarTimeSpanSnapSpacing.Value = CInt(gridOptions.SnapSpacing)
                trackBarTimeSpanGridSpacing.Value = CInt(gridOptions.GridSpacing)
            End If
        End Sub

        ' </checkEditTimeSpanAuto>
        ' <trackBarNumericGridSpacing>
        Private Sub trackBarNumericGridSpacing_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            numericClient.GridOptions.GridSpacing = CDbl(trackBarNumericGridSpacing.Value)
        End Sub

        ' </trackBarNumericGridSpacing>
        ' <trackBarNumericSnapSpacing>
        Private Sub trackBarNumericSnapSpacing_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            numericClient.GridOptions.SnapSpacing = CDbl(trackBarNumericSnapSpacing.Value)
        End Sub

        ' </trackBarNumericSnapSpacing>
        ' <trackBarDateTimeGridSpacing>
        Private Sub trackBarDateTimeGridSpacing_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            dateTimeClient.GridOptions.GridSpacing = CDbl(trackBarDateTimeGridSpacing.Value)
        End Sub

        ' </trackBarDateTimeGridSpacing>
        ' <trackBarDateTimeSnapSpacing>
        Private Sub trackBarDateTimeSnapSpacing_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            dateTimeClient.GridOptions.SnapSpacing = CDbl(trackBarDateTimeSnapSpacing.Value)
        End Sub

        ' </trackBarDateTimeSnapSpacing>
        ' <comboBoxDateTimeGridAlignment>
        Private Sub comboBoxDateTimeGridAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim alignment As RangeControlDateTimeGridAlignment = CType(comboBoxDateTimeGridAlignment.SelectedItem, RangeControlDateTimeGridAlignment)
            dateTimeClient.GridOptions.GridAlignment = alignment
            SetSpacingDateTimeTrackBarRange(trackBarDateTimeGridSpacing, alignment)
        End Sub

        ' </comboBoxDateTimeGridAlignment>
        ' <comboBoxDateTimeSnapAlignment>
        Private Sub comboBoxDateTimeSnapAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim alignment As RangeControlDateTimeGridAlignment = CType(comboBoxDateTimeSnapAlignment.SelectedItem, RangeControlDateTimeGridAlignment)
            dateTimeClient.GridOptions.SnapAlignment = alignment
            SetSpacingDateTimeTrackBarRange(trackBarDateTimeSnapSpacing, alignment)
        End Sub

        ' </comboBoxDateTimeSnapAlignment>
        ' <trackBarTimeSpanGridSpacing>
        Private Sub trackBarTimeSpanGridSpacing_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            timeSpanClient.GridOptions.GridSpacing = CDbl(trackBarTimeSpanGridSpacing.Value)
        End Sub

        ' </trackBarTimeSpanGridSpacing>
        ' <trackBarTimeSpanSnapSpacing>
        Private Sub trackBarTimeSpanSnapSpacing_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            timeSpanClient.GridOptions.SnapSpacing = CDbl(trackBarTimeSpanSnapSpacing.Value)
        End Sub

        ' </trackBarTimeSpanSnapSpacing>
        ' <comboBoxTimeSpanGridAlignment>
        Private Sub comboBoxTimeSpanGridAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim alignment As RangeControlTimeSpanGridAlignment = CType(comboBoxTimeSpanGridAlignment.SelectedItem, RangeControlTimeSpanGridAlignment)
            timeSpanClient.GridOptions.GridAlignment = alignment
            SetSpacingTimeSpanTrackBarRange(trackBarTimeSpanGridSpacing, alignment)
        End Sub

        ' </comboBoxTimeSpanGridAlignment>
        ' <comboBoxTimeSpanSnapAlignment>
        Private Sub comboBoxTimeSpanSnapAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim alignment As RangeControlTimeSpanGridAlignment = CType(comboBoxTimeSpanSnapAlignment.SelectedItem, RangeControlTimeSpanGridAlignment)
            timeSpanClient.GridOptions.SnapAlignment = alignment
            SetSpacingTimeSpanTrackBarRange(trackBarTimeSpanSnapSpacing, alignment)
        End Sub

        ' </comboBoxTimeSpanSnapAlignment>
        Private Sub trackBarNumeric_EditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs)
            e.NewValue = Math.Round(Convert.ToDouble(e.NewValue) / 10000.0) * 10000.0
        End Sub
    End Class
End Namespace
