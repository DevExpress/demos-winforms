Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Threading

Namespace DevExpress.XtraGrid.Demos

    Public Class ChangeThread

        Private ReadOnly collection As BindingList(Of MarketData) = New BindingList(Of MarketData)()

        Public ReadOnly Property List As IList
            Get
                Return collection
            End Get
        End Property

        Public InterEventDelay As Integer = 1024000

        Private needStop As Boolean

        Private ReadOnly context As SynchronizationContext

        Private ReadOnly changesWatch As Stopwatch = Stopwatch.StartNew()

        Private changes As Integer

        Public Function GetRate() As Double?
            Dim interval = changesWatch.Elapsed
            If interval = TimeSpan.Zero Then Return Nothing
            changesWatch.Restart()
            Dim currentChanges = CDbl(Interlocked.Exchange(changes, 0))
            Try
                Dim resultRate = currentChanges / interval.TotalSeconds
                If resultRate >= 0.0 AndAlso resultRate < Single.MaxValue Then Return resultRate
            Catch
            End Try

            Return Nothing
        End Function

        Public Sub New(ByVal context As SynchronizationContext)
            Dim data As String() = New String() {"ANR", "FE", "GT", "PRGO", "APD", "PPL", "AES", "AVB", "IBM", "GAS", "EFX", "GPC", "ICE", "IVZ", "KO", "CCE", "SO", "STI", "BWA", "HRL", "WFM", "LM", "TROW", "K", "EXPE", "PCAR", "TRIP", "WHR", "WMT", "NU", "HST", "CVH", "LMT", "MAR", "CVC", "RF", "VMC", "PHM", "MU", "IRM", "AMT", "BXP", "STT", "PBCT", "FISV", "BLL", "MTB", "DIS", "LH", "AKAM", "CPB", "MYL", "LIFE", "LEG", "SCG", "CNX", "COL", "MCHP", "GR", "DUK", "BAC", "NUE", "UNM", "DLTR", "ABC", "TEG", "RRD", "EQR", "EXC", "BA", "CME", "NTRS", "VTR", "FITB", "PG", "KR", "M", "SNI", "ETN", "CLF", "PH", "KEY", "SHW", "HD", "AFL", "TSS", "CMI", "HBAN", "AEP", "BIG", "LTD", "ESRX", "GLW", "WPI", "MON", "AAPL", "DF", "T", "CMA", "THC", "LUV", "TXN", "TIE", "PX"}
            Me.context = context
            For Each name As String In data
                collection.Add(New MarketData(name))
            Next
        End Sub

        Public Sub [Do]()
            Dim rndRow = Data.Utils.NonCryptographicRandom.Default
            Do
                Dim delayPerRow = Volatile.Read(InterEventDelay)
                If delayPerRow = 0 Then
                    Dim i As Integer = 0
                    While i < 1024
                        UpdateRandomRow()
                        Interlocked.Increment(i)
                    End While
                Else
                    Dim rows As Integer = CInt(Math.Min(Math.Max(TimeSpan.TicksPerSecond / delayPerRow / 25, 1), 4096))
                    Dim i As Integer = 0
                    While i < rows
                        UpdateRandomRow()
                        Interlocked.Increment(i)
                    End While

                    Dim totalDelay = TimeSpan.FromTicks(rows * CLng(delayPerRow))
                    Dim watch As Stopwatch = Stopwatch.StartNew()
                    While True
                        Dim elapsed = watch.Elapsed
                        If elapsed >= totalDelay Then Exit While
                        Dim diffTicks =(totalDelay - elapsed).Ticks
                        If diffTicks > TimeSpan.TicksPerMillisecond / 100 Then Call Thread.Sleep(CInt(diffTicks / TimeSpan.TicksPerMillisecond))
                    End While

                    watch.Stop()
                End If
            Loop While Not Volatile.Read(needStop)
        End Sub

        Private Sub UpdateRandomRow()
            Dim rnd = Data.Utils.NonCryptographicRandom.Default
            Dim row = rnd.Next(0, collection.Count)
            collection(row).Update()
            collection.ResetItem(row)
            Interlocked.Increment(changes)
        End Sub

        Public Sub [Stop]()
            Volatile.Write(needStop, True)
        End Sub
    End Class

    Public Class MarketData

        Private _Ticker As String, _Last As Double, _ChgPercent As Double, _Chg As Double, _Open As Double, _High As Double, _Low As Double

        Const MAX As Double = 950

        Const MIN As Double = 350

        Public Property Ticker As String
            Get
                Return _Ticker
            End Get

            Private Set(ByVal value As String)
                _Ticker = value
            End Set
        End Property

        Public Property Last As Double
            Get
                Return _Last
            End Get

            Private Set(ByVal value As Double)
                _Last = value
            End Set
        End Property

        Public Property ChgPercent As Double
            Get
                Return _ChgPercent
            End Get

            Private Set(ByVal value As Double)
                _ChgPercent = value
            End Set
        End Property

        Public Property Chg As Double
            Get
                Return _Chg
            End Get

            Private Set(ByVal value As Double)
                _Chg = value
            End Set
        End Property

        Public Property Open As Double
            Get
                Return _Open
            End Get

            Private Set(ByVal value As Double)
                _Open = value
            End Set
        End Property

        Public Property High As Double
            Get
                Return _High
            End Get

            Private Set(ByVal value As Double)
                _High = value
            End Set
        End Property

        Public Property Low As Double
            Get
                Return _Low
            End Get

            Private Set(ByVal value As Double)
                _Low = value
            End Set
        End Property

        Private dayValCore As Double

        Public Property DayVal As Double
            Get
                Return Math.Round(dayValCore, 1)
            End Get

            Private Set(ByVal value As Double)
                dayValCore = value
            End Set
        End Property

        Public Sub New(ByVal name As String)
            Ticker = name
            Open = Math.Round((NextRnd() * (MAX - MIN)) + MIN, 1)
            DayVal = Open
            UpdateInternal(Open)
        End Sub

        Public Sub Update()
            Dim value As Double = Math.Round(DayVal - (MAX - MIN) * 0.05 + NextRnd() * (MAX - MIN) * 0.1, 1)
            If value <= MIN Then value = MIN
            If value >= MAX Then value = MAX
            UpdateInternal(value)
        End Sub

        Private Sub UpdateInternal(ByVal dayVal As Double)
            Last = Me.DayVal
            Me.DayVal = dayVal
            Chg = Me.DayVal - Last
            ChgPercent = Math.Round(Chg / Me.DayVal * 100, 2)
            High = Math.Max(Open, Math.Max(Me.DayVal, Last))
            Low = Math.Min(Open, Math.Min(Me.DayVal, Last))
        End Sub

        Private Function NextRnd() As Double
            Dim rnd = Data.Utils.NonCryptographicRandom.Default
            Return(rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble()) / 5
        End Function
    End Class
End Namespace
