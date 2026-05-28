Imports System
Imports System.Drawing
Imports System.Threading
Imports System.Diagnostics
Imports DevExpress.Data
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors.Controls
Imports System.ComponentModel
Imports DevExpress.LookAndFeel

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class RealTimeSourceDemo
        Inherits TutorialControl

        Private chtr As ChangeThread

        Private tr As Thread

        '<gridControl1>
        Private realTimeSource As RealTimeSource

        '</gridControl1>
        Private chartingTimer As Windows.Forms.Timer

        Private isHide As Boolean = True

        Public Sub New()
            InitializeComponent()
            AddHandler Disposed, AddressOf RealTimeSourceDemo_Disposed
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"RealTimeSource"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "RealTimeSource"
            End Get
        End Property

        Private Sub RealTimeSourceDemo_Disposed(ByVal sender As Object, ByVal e As EventArgs)
            DoHide()
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            isHide = False
            chtr = New ChangeThread(SynchronizationContext.Current)
            trackBar1.Value = 16
            PatchInterval()
            realTimeSource = New RealTimeSource() With {.DataSource = chtr.List}
            gridControl1.DataSource = realTimeSource
            chartControl1.Series("UPSDiagram").Points.Clear()
            chartControl1.Series("UPSDiagram").Label.TextPattern = "{V:n0}"
            chartingTimer = New Windows.Forms.Timer() With {.Interval = 100}
            AddHandler chartingTimer.Tick, AddressOf DoCharting
            chartingTimer.Start()
            tr = New Thread(AddressOf chtr.Do) With {.IsBackground = True}
            tr.Start()
        End Sub

        Protected Overrides Sub DoHide()
            isHide = True
            If chartingTimer IsNot Nothing Then
                chartingTimer.Dispose()
                chartingTimer = Nothing
            End If

            If chtr IsNot Nothing Then
                chtr.Stop()
                If tr IsNot Nothing Then
                    tr.Join()
                    tr = Nothing
                End If

                chtr = Nothing
            End If

            gridControl1.DataSource = Nothing
            If realTimeSource IsNot Nothing Then
                realTimeSource.Dispose()
                realTimeSource = Nothing
            End If

            MyBase.DoHide()
        End Sub

        Private ReadOnly chartingWatchPacer As Stopwatch = Stopwatch.StartNew()

        Private ReadOnly chartingTimeAxis As Stopwatch = Stopwatch.StartNew()

        Private Sub DoCharting(ByVal sender As Object, ByVal e As EventArgs)
            If isHide OrElse chtr Is Nothing Then Return
            Dim updateMilliseconds = If(TimeSpan.TicksPerSecond / 10 >= Volatile.Read(chtr.InterEventDelay), 500, 1000)
            If chartingWatchPacer.ElapsedMilliseconds < updateMilliseconds Then Return
            Dim rate = chtr.GetRate()
            If Not rate.HasValue Then Return
            chartingWatchPacer.Restart()
            While chartControl1.Series("UPSDiagram").Points.Count >= 20
                chartControl1.Series("UPSDiagram").Points.RemoveAt(0)
            End While

            chartControl1.Series("UPSDiagram").Points.Add(New SeriesPoint(chartingTimeAxis.Elapsed.TotalSeconds, rate.Value))
        End Sub

        Private Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As EventArgs)
            PatchInterval()
        End Sub

        Private Sub PatchInterval()
            If chtr Is Nothing Then Return
            Dim pos As Integer = trackBar1.Properties.Maximum - trackBar1.Value - 1
            Call Volatile.Write(chtr.InterEventDelay, If(pos < 0, 0, CInt(10 * Math.Pow(1.5, pos))))
        End Sub

        Private Sub gridView1_RowCellStyle(ByVal sender As Object, ByVal e As Views.Grid.RowCellStyleEventArgs)
            Dim val As Double = Convert.ToDouble(gridView1.GetRowCellValue(e.RowHandle, "ChgPercent"))
            If val < 0 Then e.Appearance.ForeColor = DXSkinColors.ForeColors.Critical
        End Sub
    End Class
End Namespace
