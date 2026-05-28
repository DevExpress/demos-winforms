Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading
Imports DevExpress.Data
Imports System.Diagnostics
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class DataUpdateRules
        Inherits TutorialControl

        Private chtr As ChangeThread

        Private tr As Thread

        Private realTimeSource As RealTimeSource

        Private chartingTimer As Windows.Forms.Timer

        Private isHide As Boolean = True

        Public Sub New()
            InitializeComponent()
            AddHandler Disposed, AddressOf DataUpdateRules_Disposed
            ceShowConditionalFormattingItem.Checked = gridView1.OptionsMenu.ShowConditionalFormattingItem
        End Sub

        'protected override string[] WhatsThisCodeFileNames {
        '    get { return new string[] { "DataUpdateRules" }; }
        '}
        'protected override string WhatsThisXMLFileName {
        '    get { return "DataUpdateRules"; }
        '}
        Private Sub DataUpdateRules_Disposed(ByVal sender As Object, ByVal e As EventArgs)
            DoHide()
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            isHide = False
            chtr = New ChangeThread(SynchronizationContext.Current)
            trackBarControl1.Value = 5
            PatchInterval()
            realTimeSource = New RealTimeSource() With {.DataSource = chtr.List}
            gridControl1.DataSource = realTimeSource
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
        End Sub

        Private Sub PatchInterval()
            If chtr Is Nothing Then Return
            Dim pos As Integer = 20 + trackBarControl1.Properties.Maximum - trackBarControl1.Value
            Call Volatile.Write(chtr.InterEventDelay, If(pos < 0, 0, CInt(10 * Math.Pow(1.5, pos))))
        End Sub

        Private Sub trackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            PatchInterval()
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            If edit Is Nothing Then Return
            gridView1.OptionsMenu.ShowConditionalFormattingItem = edit.Checked
        End Sub

        Private Sub gridView1_FormatRuleDataUpdateCustomTrigger(ByVal sender As Object, ByVal e As Views.Grid.FormatRuleGridDataUpdateTriggerEventArgs)
            If CDbl(e.NewValue) - CDbl(e.OldValue) > 12 Then e.Trigger = True
        End Sub
    End Class
End Namespace
