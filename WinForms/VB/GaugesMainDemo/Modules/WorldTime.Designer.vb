Namespace DevExpress.XtraGauges.Demos

    Partial Class WorldTime

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                Me.lockTimerCounter += 1
                If Me.timer IsNot Nothing Then
                    Me.timer.[Stop]()
                    Me.timer.Dispose()
                    Me.timer = Nothing
                End If
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
            Dim scaleLabel1 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleLabel2 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleLabel3 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleIndicatorState1 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState2 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState3 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleLabel4 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleLabel5 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleLabel6 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleIndicatorState4 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState5 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState6 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleLabel7 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleLabel8 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleLabel9 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleIndicatorState7 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState8 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState9 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleLabel10 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleLabel11 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleLabel12 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleIndicatorState10 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState11 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState12 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleLabel13 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleLabel14 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleLabel15 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleIndicatorState13 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState14 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState15 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleLabel16 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleLabel17 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleLabel18 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleIndicatorState16 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState17 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Rome = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge6 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleStateIndicatorComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent17 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent18 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleNeedleComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleNeedleComponent17 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent17 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent18 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent18 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.Madrid = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge5 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent13 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleStateIndicatorComponent13 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleNeedleComponent13 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleNeedleComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.Paris = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge4 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleStateIndicatorComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleNeedleComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleNeedleComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.Tokyo = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge3 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleStateIndicatorComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent9 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleNeedleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleNeedleComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent9 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent9 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.London = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge2 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleStateIndicatorComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleNeedleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleNeedleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.Washington = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleStateIndicatorComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.timer = New System.Windows.Forms.Timer(Me.components)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.circularGauge6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleStateIndicatorComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.Rome)
            Me.layoutControl1.Controls.Add(Me.Madrid)
            Me.layoutControl1.Controls.Add(Me.Paris)
            Me.layoutControl1.Controls.Add(Me.Tokyo)
            Me.layoutControl1.Controls.Add(Me.London)
            Me.layoutControl1.Controls.Add(Me.Washington)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(687, 593)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' Rome
            ' 
            Me.Rome.BackColor = System.Drawing.Color.Transparent
            Me.Rome.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.Rome.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge6})
            Me.Rome.Location = New System.Drawing.Point(459, 297)
            Me.Rome.Name = "Rome"
            Me.Rome.Size = New System.Drawing.Size(220, 288)
            Me.Rome.TabIndex = 8
            ' 
            ' circularGauge6
            ' 
            Me.circularGauge6.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent6})
            Me.circularGauge6.Bounds = New System.Drawing.Rectangle(6, 6, 208, 276)
            Me.circularGauge6.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent6})
            Me.circularGauge6.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.arcScaleStateIndicatorComponent16, Me.arcScaleStateIndicatorComponent17, Me.arcScaleStateIndicatorComponent18})
            Me.circularGauge6.Name = "circularGauge6"
            Me.circularGauge6.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent16, Me.arcScaleNeedleComponent17, Me.arcScaleNeedleComponent18})
            Me.circularGauge6.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent16, Me.arcScaleComponent17, Me.arcScaleComponent18})
            Me.circularGauge6.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent6})
            ' 
            ' arcScaleBackgroundLayerComponent6
            ' 
            Me.arcScaleBackgroundLayerComponent6.ArcScale = Me.arcScaleComponent16
            Me.arcScaleBackgroundLayerComponent6.Name = "arcScaleBackgroundLayerComponent6"
            Me.arcScaleBackgroundLayerComponent6.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504F, 0.436F)
            Me.arcScaleBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
            Me.arcScaleBackgroundLayerComponent6.Size = New System.Drawing.SizeF(216F, 250F)
            Me.arcScaleBackgroundLayerComponent6.ZOrder = 1000
            ' 
            ' arcScaleComponent16
            ' 
            Me.arcScaleComponent16.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent16.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent16.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent16.EndAngle = 270F
            scaleLabel1.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            scaleLabel1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            scaleLabel1.FormatString = "{0}"
            scaleLabel1.Name = "Label0"
            scaleLabel1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F)
            scaleLabel1.Size = New System.Drawing.SizeF(70F, 20F)
            scaleLabel1.Text = "Rome"
            scaleLabel2.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            scaleLabel2.FormatString = "{0}"
            scaleLabel2.Name = "Label1"
            scaleLabel2.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 238F)
            scaleLabel2.Size = New System.Drawing.SizeF(50F, 15F)
            scaleLabel2.Text = "Italy"
            scaleLabel3.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            scaleLabel3.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            scaleLabel3.FormatString = "{0:F4}"
            scaleLabel3.Name = "Label2"
            scaleLabel3.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(160F, 225F)
            scaleLabel3.Size = New System.Drawing.SizeF(70F, 20F)
            scaleLabel3.Text = "73.142"
            Me.arcScaleComponent16.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {scaleLabel1, scaleLabel2, scaleLabel3})
            Me.arcScaleComponent16.MajorTickCount = 13
            Me.arcScaleComponent16.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent16.MajorTickmark.ShapeOffset = -9.5F
            Me.arcScaleComponent16.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent16.MajorTickmark.ShowFirst = False
            Me.arcScaleComponent16.MajorTickmark.TextOffset = -18F
            Me.arcScaleComponent16.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent16.MaxValue = 12F
            Me.arcScaleComponent16.MinorTickCount = 4
            Me.arcScaleComponent16.MinorTickmark.ShapeOffset = -1.5F
            Me.arcScaleComponent16.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent16.Name = "arcScaleComponent16"
            Me.arcScaleComponent16.RadiusX = 74F
            Me.arcScaleComponent16.RadiusY = 74F
            Me.arcScaleComponent16.StartAngle = -90F
            ' 
            ' arcScaleEffectLayerComponent6
            ' 
            Me.arcScaleEffectLayerComponent6.ArcScale = Me.arcScaleComponent16
            Me.arcScaleEffectLayerComponent6.Name = "arcScaleEffectLayerComponent6"
            Me.arcScaleEffectLayerComponent6.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1F)
            Me.arcScaleEffectLayerComponent6.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
            Me.arcScaleEffectLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
            Me.arcScaleEffectLayerComponent6.Size = New System.Drawing.SizeF(170F, 85F)
            Me.arcScaleEffectLayerComponent6.ZOrder = -1000
            ' 
            ' arcScaleStateIndicatorComponent16
            ' 
            Me.arcScaleStateIndicatorComponent16.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 218F)
            Me.arcScaleStateIndicatorComponent16.IndicatorScale = Me.arcScaleComponent16
            Me.arcScaleStateIndicatorComponent16.Name = "arcScaleStateIndicatorComponent16"
            Me.arcScaleStateIndicatorComponent16.Size = New System.Drawing.SizeF(40F, 21F)
            scaleIndicatorState1.IntervalLength = 12F
            scaleIndicatorState1.Name = "Default"
            scaleIndicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagItaly
            Me.arcScaleStateIndicatorComponent16.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState1})
            Me.arcScaleStateIndicatorComponent16.ZOrder = -100
            ' 
            ' arcScaleStateIndicatorComponent17
            ' 
            Me.arcScaleStateIndicatorComponent17.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(118F, 223F)
            Me.arcScaleStateIndicatorComponent17.IndicatorScale = Me.arcScaleComponent16
            Me.arcScaleStateIndicatorComponent17.Name = "arcScaleStateIndicatorComponent17"
            Me.arcScaleStateIndicatorComponent17.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
            Me.arcScaleStateIndicatorComponent17.Size = New System.Drawing.SizeF(20F, 20F)
            scaleIndicatorState2.IntervalLength = 12F
            scaleIndicatorState2.Name = "Default"
            scaleIndicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyEUR
            Me.arcScaleStateIndicatorComponent17.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState2})
            Me.arcScaleStateIndicatorComponent17.ZOrder = -100
            ' 
            ' arcScaleStateIndicatorComponent18
            ' 
            Me.arcScaleStateIndicatorComponent18.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(195F, 223F)
            Me.arcScaleStateIndicatorComponent18.IndicatorScale = Me.arcScaleComponent16
            Me.arcScaleStateIndicatorComponent18.Name = "arcScaleStateIndicatorComponent18"
            Me.arcScaleStateIndicatorComponent18.Size = New System.Drawing.SizeF(15F, 15F)
            scaleIndicatorState3.IntervalLength = 12F
            scaleIndicatorState3.Name = "Default"
            scaleIndicatorState3.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow1
            Me.arcScaleStateIndicatorComponent18.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState3})
            Me.arcScaleStateIndicatorComponent18.ZOrder = -100
            ' 
            ' arcScaleNeedleComponent16
            ' 
            Me.arcScaleNeedleComponent16.ArcScale = Me.arcScaleComponent16
            Me.arcScaleNeedleComponent16.EndOffset = 10F
            Me.arcScaleNeedleComponent16.Name = "arcScaleNeedleComponent16"
            Me.arcScaleNeedleComponent16.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
            Me.arcScaleNeedleComponent16.ZOrder = -50
            ' 
            ' arcScaleNeedleComponent17
            ' 
            Me.arcScaleNeedleComponent17.ArcScale = Me.arcScaleComponent17
            Me.arcScaleNeedleComponent17.EndOffset = -5F
            Me.arcScaleNeedleComponent17.Name = "arcScaleNeedleComponent17"
            Me.arcScaleNeedleComponent17.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
            Me.arcScaleNeedleComponent17.ZOrder = -51
            ' 
            ' arcScaleComponent17
            ' 
            Me.arcScaleComponent17.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent17.EndAngle = 270F
            Me.arcScaleComponent17.MajorTickCount = 2
            Me.arcScaleComponent17.MajorTickmark.ShowText = False
            Me.arcScaleComponent17.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent17.MaxValue = 12F
            Me.arcScaleComponent17.MinorTickCount = 0
            Me.arcScaleComponent17.Name = "arcScaleComponent17"
            Me.arcScaleComponent17.RadiusX = 74F
            Me.arcScaleComponent17.RadiusY = 74F
            Me.arcScaleComponent17.StartAngle = -90F
            Me.arcScaleComponent17.Value = 3F
            ' 
            ' arcScaleNeedleComponent18
            ' 
            Me.arcScaleNeedleComponent18.ArcScale = Me.arcScaleComponent18
            Me.arcScaleNeedleComponent18.EndOffset = -10F
            Me.arcScaleNeedleComponent18.Name = "arcScaleNeedleComponent18"
            Me.arcScaleNeedleComponent18.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
            Me.arcScaleNeedleComponent18.ZOrder = -52
            ' 
            ' arcScaleComponent18
            ' 
            Me.arcScaleComponent18.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent18.EndAngle = 270F
            Me.arcScaleComponent18.MajorTickCount = 2
            Me.arcScaleComponent18.MajorTickmark.ShowText = False
            Me.arcScaleComponent18.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent18.MaxValue = 12F
            Me.arcScaleComponent18.MinorTickCount = 0
            Me.arcScaleComponent18.Name = "arcScaleComponent18"
            Me.arcScaleComponent18.RadiusX = 74F
            Me.arcScaleComponent18.RadiusY = 74F
            Me.arcScaleComponent18.StartAngle = -90F
            Me.arcScaleComponent18.Value = 1.5F
            ' 
            ' arcScaleSpindleCapComponent6
            ' 
            Me.arcScaleSpindleCapComponent6.ArcScale = Me.arcScaleComponent16
            Me.arcScaleSpindleCapComponent6.Name = "arcScaleSpindleCapComponent6"
            Me.arcScaleSpindleCapComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
            Me.arcScaleSpindleCapComponent6.Size = New System.Drawing.SizeF(12F, 12F)
            Me.arcScaleSpindleCapComponent6.ZOrder = -100
            ' 
            ' Madrid
            ' 
            Me.Madrid.BackColor = System.Drawing.Color.Transparent
            Me.Madrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.Madrid.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge5})
            Me.Madrid.Location = New System.Drawing.Point(459, 8)
            Me.Madrid.Name = "Madrid"
            Me.Madrid.Size = New System.Drawing.Size(220, 289)
            Me.Madrid.TabIndex = 8
            ' 
            ' circularGauge5
            ' 
            Me.circularGauge5.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent5})
            Me.circularGauge5.Bounds = New System.Drawing.Rectangle(6, 6, 208, 277)
            Me.circularGauge5.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent5})
            Me.circularGauge5.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.arcScaleStateIndicatorComponent13, Me.arcScaleStateIndicatorComponent14, Me.arcScaleStateIndicatorComponent15})
            Me.circularGauge5.Name = "circularGauge5"
            Me.circularGauge5.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent13, Me.arcScaleNeedleComponent14, Me.arcScaleNeedleComponent15})
            Me.circularGauge5.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent13, Me.arcScaleComponent14, Me.arcScaleComponent15})
            Me.circularGauge5.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent5})
            ' 
            ' arcScaleBackgroundLayerComponent5
            ' 
            Me.arcScaleBackgroundLayerComponent5.ArcScale = Me.arcScaleComponent13
            Me.arcScaleBackgroundLayerComponent5.Name = "arcScaleBackgroundLayerComponent5"
            Me.arcScaleBackgroundLayerComponent5.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504F, 0.436F)
            Me.arcScaleBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
            Me.arcScaleBackgroundLayerComponent5.Size = New System.Drawing.SizeF(216F, 250F)
            Me.arcScaleBackgroundLayerComponent5.ZOrder = 1000
            ' 
            ' arcScaleComponent13
            ' 
            Me.arcScaleComponent13.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent13.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent13.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent13.EndAngle = 270F
            scaleLabel4.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            scaleLabel4.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            scaleLabel4.FormatString = "{0}"
            scaleLabel4.Name = "Label0"
            scaleLabel4.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F)
            scaleLabel4.Size = New System.Drawing.SizeF(70F, 20F)
            scaleLabel4.Text = "Madrid"
            scaleLabel5.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            scaleLabel5.FormatString = "{0}"
            scaleLabel5.Name = "Label1"
            scaleLabel5.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 238F)
            scaleLabel5.Size = New System.Drawing.SizeF(50F, 15F)
            scaleLabel5.Text = "Spain"
            scaleLabel6.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            scaleLabel6.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            scaleLabel6.FormatString = "{0:F4}"
            scaleLabel6.Name = "Label2"
            scaleLabel6.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(165F, 225F)
            scaleLabel6.Size = New System.Drawing.SizeF(70F, 20F)
            scaleLabel6.Text = "73.142"
            Me.arcScaleComponent13.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {scaleLabel4, scaleLabel5, scaleLabel6})
            Me.arcScaleComponent13.MajorTickCount = 13
            Me.arcScaleComponent13.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent13.MajorTickmark.ShapeOffset = -9.5F
            Me.arcScaleComponent13.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent13.MajorTickmark.ShowFirst = False
            Me.arcScaleComponent13.MajorTickmark.TextOffset = -18F
            Me.arcScaleComponent13.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent13.MaxValue = 12F
            Me.arcScaleComponent13.MinorTickCount = 4
            Me.arcScaleComponent13.MinorTickmark.ShapeOffset = -1.5F
            Me.arcScaleComponent13.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent13.Name = "arcScaleComponent13"
            Me.arcScaleComponent13.RadiusX = 74F
            Me.arcScaleComponent13.RadiusY = 74F
            Me.arcScaleComponent13.StartAngle = -90F
            ' 
            ' arcScaleEffectLayerComponent5
            ' 
            Me.arcScaleEffectLayerComponent5.ArcScale = Me.arcScaleComponent13
            Me.arcScaleEffectLayerComponent5.Name = "arcScaleEffectLayerComponent5"
            Me.arcScaleEffectLayerComponent5.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1F)
            Me.arcScaleEffectLayerComponent5.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
            Me.arcScaleEffectLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
            Me.arcScaleEffectLayerComponent5.Size = New System.Drawing.SizeF(170F, 85F)
            Me.arcScaleEffectLayerComponent5.ZOrder = -1000
            ' 
            ' arcScaleStateIndicatorComponent13
            ' 
            Me.arcScaleStateIndicatorComponent13.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 218F)
            Me.arcScaleStateIndicatorComponent13.IndicatorScale = Me.arcScaleComponent13
            Me.arcScaleStateIndicatorComponent13.Name = "arcScaleStateIndicatorComponent13"
            Me.arcScaleStateIndicatorComponent13.Size = New System.Drawing.SizeF(40F, 21F)
            scaleIndicatorState4.IntervalLength = 12F
            scaleIndicatorState4.Name = "Default"
            scaleIndicatorState4.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagSpain
            Me.arcScaleStateIndicatorComponent13.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState4})
            Me.arcScaleStateIndicatorComponent13.ZOrder = -100
            ' 
            ' arcScaleStateIndicatorComponent14
            ' 
            Me.arcScaleStateIndicatorComponent14.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(118F, 223F)
            Me.arcScaleStateIndicatorComponent14.IndicatorScale = Me.arcScaleComponent13
            Me.arcScaleStateIndicatorComponent14.Name = "arcScaleStateIndicatorComponent14"
            Me.arcScaleStateIndicatorComponent14.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
            Me.arcScaleStateIndicatorComponent14.Size = New System.Drawing.SizeF(20F, 20F)
            scaleIndicatorState5.IntervalLength = 12F
            scaleIndicatorState5.Name = "Default"
            scaleIndicatorState5.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyEUR
            Me.arcScaleStateIndicatorComponent14.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState5})
            Me.arcScaleStateIndicatorComponent14.ZOrder = -100
            ' 
            ' arcScaleStateIndicatorComponent15
            ' 
            Me.arcScaleStateIndicatorComponent15.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(205F, 223F)
            Me.arcScaleStateIndicatorComponent15.IndicatorScale = Me.arcScaleComponent13
            Me.arcScaleStateIndicatorComponent15.Name = "arcScaleStateIndicatorComponent15"
            Me.arcScaleStateIndicatorComponent15.Size = New System.Drawing.SizeF(15F, 15F)
            scaleIndicatorState6.IntervalLength = 12F
            scaleIndicatorState6.Name = "Default"
            scaleIndicatorState6.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow2
            Me.arcScaleStateIndicatorComponent15.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState6})
            Me.arcScaleStateIndicatorComponent15.ZOrder = -100
            ' 
            ' arcScaleNeedleComponent13
            ' 
            Me.arcScaleNeedleComponent13.ArcScale = Me.arcScaleComponent13
            Me.arcScaleNeedleComponent13.EndOffset = 10F
            Me.arcScaleNeedleComponent13.Name = "arcScaleNeedleComponent13"
            Me.arcScaleNeedleComponent13.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
            Me.arcScaleNeedleComponent13.ZOrder = -50
            ' 
            ' arcScaleNeedleComponent14
            ' 
            Me.arcScaleNeedleComponent14.ArcScale = Me.arcScaleComponent14
            Me.arcScaleNeedleComponent14.EndOffset = -5F
            Me.arcScaleNeedleComponent14.Name = "arcScaleNeedleComponent14"
            Me.arcScaleNeedleComponent14.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
            Me.arcScaleNeedleComponent14.ZOrder = -51
            ' 
            ' arcScaleComponent14
            ' 
            Me.arcScaleComponent14.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent14.EndAngle = 270F
            Me.arcScaleComponent14.MajorTickCount = 2
            Me.arcScaleComponent14.MajorTickmark.ShowText = False
            Me.arcScaleComponent14.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent14.MaxValue = 12F
            Me.arcScaleComponent14.MinorTickCount = 0
            Me.arcScaleComponent14.Name = "arcScaleComponent14"
            Me.arcScaleComponent14.RadiusX = 74F
            Me.arcScaleComponent14.RadiusY = 74F
            Me.arcScaleComponent14.StartAngle = -90F
            Me.arcScaleComponent14.Value = 3F
            ' 
            ' arcScaleNeedleComponent15
            ' 
            Me.arcScaleNeedleComponent15.ArcScale = Me.arcScaleComponent15
            Me.arcScaleNeedleComponent15.EndOffset = -10F
            Me.arcScaleNeedleComponent15.Name = "arcScaleNeedleComponent15"
            Me.arcScaleNeedleComponent15.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
            Me.arcScaleNeedleComponent15.ZOrder = -52
            ' 
            ' arcScaleComponent15
            ' 
            Me.arcScaleComponent15.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent15.EndAngle = 270F
            Me.arcScaleComponent15.MajorTickCount = 2
            Me.arcScaleComponent15.MajorTickmark.ShowText = False
            Me.arcScaleComponent15.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent15.MaxValue = 12F
            Me.arcScaleComponent15.MinorTickCount = 0
            Me.arcScaleComponent15.Name = "arcScaleComponent15"
            Me.arcScaleComponent15.RadiusX = 74F
            Me.arcScaleComponent15.RadiusY = 74F
            Me.arcScaleComponent15.StartAngle = -90F
            Me.arcScaleComponent15.Value = 1.5F
            ' 
            ' arcScaleSpindleCapComponent5
            ' 
            Me.arcScaleSpindleCapComponent5.ArcScale = Me.arcScaleComponent13
            Me.arcScaleSpindleCapComponent5.Name = "arcScaleSpindleCapComponent5"
            Me.arcScaleSpindleCapComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
            Me.arcScaleSpindleCapComponent5.Size = New System.Drawing.SizeF(12F, 12F)
            Me.arcScaleSpindleCapComponent5.ZOrder = -100
            ' 
            ' Paris
            ' 
            Me.Paris.BackColor = System.Drawing.Color.Transparent
            Me.Paris.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.Paris.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge4})
            Me.Paris.Location = New System.Drawing.Point(230, 8)
            Me.Paris.Name = "Paris"
            Me.Paris.Size = New System.Drawing.Size(228, 289)
            Me.Paris.TabIndex = 7
            ' 
            ' circularGauge4
            ' 
            Me.circularGauge4.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent4})
            Me.circularGauge4.Bounds = New System.Drawing.Rectangle(6, 6, 216, 277)
            Me.circularGauge4.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent4})
            Me.circularGauge4.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.arcScaleStateIndicatorComponent10, Me.arcScaleStateIndicatorComponent11, Me.arcScaleStateIndicatorComponent12})
            Me.circularGauge4.Name = "circularGauge4"
            Me.circularGauge4.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent10, Me.arcScaleNeedleComponent11, Me.arcScaleNeedleComponent12})
            Me.circularGauge4.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent10, Me.arcScaleComponent11, Me.arcScaleComponent12})
            Me.circularGauge4.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent4})
            ' 
            ' arcScaleBackgroundLayerComponent4
            ' 
            Me.arcScaleBackgroundLayerComponent4.ArcScale = Me.arcScaleComponent10
            Me.arcScaleBackgroundLayerComponent4.Name = "arcScaleBackgroundLayerComponent4"
            Me.arcScaleBackgroundLayerComponent4.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504F, 0.436F)
            Me.arcScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
            Me.arcScaleBackgroundLayerComponent4.Size = New System.Drawing.SizeF(216F, 250F)
            Me.arcScaleBackgroundLayerComponent4.ZOrder = 1000
            ' 
            ' arcScaleComponent10
            ' 
            Me.arcScaleComponent10.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent10.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent10.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent10.EndAngle = 270F
            scaleLabel7.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            scaleLabel7.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            scaleLabel7.FormatString = "{0}"
            scaleLabel7.Name = "Label0"
            scaleLabel7.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F)
            scaleLabel7.Size = New System.Drawing.SizeF(70F, 20F)
            scaleLabel7.Text = "Paris"
            scaleLabel8.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            scaleLabel8.FormatString = "{0}"
            scaleLabel8.Name = "Label1"
            scaleLabel8.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 238F)
            scaleLabel8.Size = New System.Drawing.SizeF(50F, 15F)
            scaleLabel8.Text = "France"
            scaleLabel9.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            scaleLabel9.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            scaleLabel9.FormatString = "{0:F4}"
            scaleLabel9.Name = "Label2"
            scaleLabel9.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(160F, 225F)
            scaleLabel9.Size = New System.Drawing.SizeF(70F, 20F)
            scaleLabel9.Text = "73.142"
            Me.arcScaleComponent10.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {scaleLabel7, scaleLabel8, scaleLabel9})
            Me.arcScaleComponent10.MajorTickCount = 13
            Me.arcScaleComponent10.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent10.MajorTickmark.ShapeOffset = -9.5F
            Me.arcScaleComponent10.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent10.MajorTickmark.ShowFirst = False
            Me.arcScaleComponent10.MajorTickmark.TextOffset = -18F
            Me.arcScaleComponent10.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent10.MaxValue = 12F
            Me.arcScaleComponent10.MinorTickCount = 4
            Me.arcScaleComponent10.MinorTickmark.ShapeOffset = -1.5F
            Me.arcScaleComponent10.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent10.Name = "arcScaleComponent10"
            Me.arcScaleComponent10.RadiusX = 74F
            Me.arcScaleComponent10.RadiusY = 74F
            Me.arcScaleComponent10.StartAngle = -90F
            ' 
            ' arcScaleEffectLayerComponent4
            ' 
            Me.arcScaleEffectLayerComponent4.ArcScale = Me.arcScaleComponent10
            Me.arcScaleEffectLayerComponent4.Name = "arcScaleEffectLayerComponent4"
            Me.arcScaleEffectLayerComponent4.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1F)
            Me.arcScaleEffectLayerComponent4.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
            Me.arcScaleEffectLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
            Me.arcScaleEffectLayerComponent4.Size = New System.Drawing.SizeF(170F, 85F)
            Me.arcScaleEffectLayerComponent4.ZOrder = -1000
            ' 
            ' arcScaleStateIndicatorComponent10
            ' 
            Me.arcScaleStateIndicatorComponent10.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 218F)
            Me.arcScaleStateIndicatorComponent10.IndicatorScale = Me.arcScaleComponent10
            Me.arcScaleStateIndicatorComponent10.Name = "arcScaleStateIndicatorComponent10"
            Me.arcScaleStateIndicatorComponent10.Size = New System.Drawing.SizeF(40F, 21F)
            scaleIndicatorState7.IntervalLength = 12F
            scaleIndicatorState7.Name = "Default"
            scaleIndicatorState7.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagFrance
            Me.arcScaleStateIndicatorComponent10.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState7})
            Me.arcScaleStateIndicatorComponent10.ZOrder = -100
            ' 
            ' arcScaleStateIndicatorComponent11
            ' 
            Me.arcScaleStateIndicatorComponent11.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(118F, 223F)
            Me.arcScaleStateIndicatorComponent11.IndicatorScale = Me.arcScaleComponent10
            Me.arcScaleStateIndicatorComponent11.Name = "arcScaleStateIndicatorComponent11"
            Me.arcScaleStateIndicatorComponent11.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
            Me.arcScaleStateIndicatorComponent11.Size = New System.Drawing.SizeF(20F, 20F)
            scaleIndicatorState8.IntervalLength = 12F
            scaleIndicatorState8.Name = "Default"
            scaleIndicatorState8.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyEUR
            Me.arcScaleStateIndicatorComponent11.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState8})
            Me.arcScaleStateIndicatorComponent11.ZOrder = -100
            ' 
            ' arcScaleStateIndicatorComponent12
            ' 
            Me.arcScaleStateIndicatorComponent12.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(195F, 223F)
            Me.arcScaleStateIndicatorComponent12.IndicatorScale = Me.arcScaleComponent10
            Me.arcScaleStateIndicatorComponent12.Name = "arcScaleStateIndicatorComponent12"
            Me.arcScaleStateIndicatorComponent12.Size = New System.Drawing.SizeF(15F, 15F)
            scaleIndicatorState9.IntervalLength = 12F
            scaleIndicatorState9.Name = "Default"
            scaleIndicatorState9.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow1
            Me.arcScaleStateIndicatorComponent12.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState9})
            Me.arcScaleStateIndicatorComponent12.ZOrder = -100
            ' 
            ' arcScaleNeedleComponent10
            ' 
            Me.arcScaleNeedleComponent10.ArcScale = Me.arcScaleComponent10
            Me.arcScaleNeedleComponent10.EndOffset = 10F
            Me.arcScaleNeedleComponent10.Name = "arcScaleNeedleComponent10"
            Me.arcScaleNeedleComponent10.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
            Me.arcScaleNeedleComponent10.ZOrder = -50
            ' 
            ' arcScaleNeedleComponent11
            ' 
            Me.arcScaleNeedleComponent11.ArcScale = Me.arcScaleComponent11
            Me.arcScaleNeedleComponent11.EndOffset = -5F
            Me.arcScaleNeedleComponent11.Name = "arcScaleNeedleComponent11"
            Me.arcScaleNeedleComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
            Me.arcScaleNeedleComponent11.ZOrder = -51
            ' 
            ' arcScaleComponent11
            ' 
            Me.arcScaleComponent11.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent11.EndAngle = 270F
            Me.arcScaleComponent11.MajorTickCount = 2
            Me.arcScaleComponent11.MajorTickmark.ShowText = False
            Me.arcScaleComponent11.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent11.MaxValue = 12F
            Me.arcScaleComponent11.MinorTickCount = 0
            Me.arcScaleComponent11.Name = "arcScaleComponent11"
            Me.arcScaleComponent11.RadiusX = 74F
            Me.arcScaleComponent11.RadiusY = 74F
            Me.arcScaleComponent11.StartAngle = -90F
            Me.arcScaleComponent11.Value = 3F
            ' 
            ' arcScaleNeedleComponent12
            ' 
            Me.arcScaleNeedleComponent12.ArcScale = Me.arcScaleComponent12
            Me.arcScaleNeedleComponent12.EndOffset = -10F
            Me.arcScaleNeedleComponent12.Name = "arcScaleNeedleComponent12"
            Me.arcScaleNeedleComponent12.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
            Me.arcScaleNeedleComponent12.ZOrder = -52
            ' 
            ' arcScaleComponent12
            ' 
            Me.arcScaleComponent12.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent12.EndAngle = 270F
            Me.arcScaleComponent12.MajorTickCount = 2
            Me.arcScaleComponent12.MajorTickmark.ShowText = False
            Me.arcScaleComponent12.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent12.MaxValue = 12F
            Me.arcScaleComponent12.MinorTickCount = 0
            Me.arcScaleComponent12.Name = "arcScaleComponent12"
            Me.arcScaleComponent12.RadiusX = 74F
            Me.arcScaleComponent12.RadiusY = 74F
            Me.arcScaleComponent12.StartAngle = -90F
            Me.arcScaleComponent12.Value = 1.5F
            ' 
            ' arcScaleSpindleCapComponent4
            ' 
            Me.arcScaleSpindleCapComponent4.ArcScale = Me.arcScaleComponent10
            Me.arcScaleSpindleCapComponent4.Name = "arcScaleSpindleCapComponent4"
            Me.arcScaleSpindleCapComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
            Me.arcScaleSpindleCapComponent4.Size = New System.Drawing.SizeF(12F, 12F)
            Me.arcScaleSpindleCapComponent4.ZOrder = -100
            ' 
            ' Tokyo
            ' 
            Me.Tokyo.BackColor = System.Drawing.Color.Transparent
            Me.Tokyo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.Tokyo.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge3})
            Me.Tokyo.Location = New System.Drawing.Point(230, 297)
            Me.Tokyo.Name = "Tokyo"
            Me.Tokyo.Size = New System.Drawing.Size(228, 288)
            Me.Tokyo.TabIndex = 6
            ' 
            ' circularGauge3
            ' 
            Me.circularGauge3.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent3})
            Me.circularGauge3.Bounds = New System.Drawing.Rectangle(6, 6, 216, 276)
            Me.circularGauge3.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent3})
            Me.circularGauge3.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.arcScaleStateIndicatorComponent7, Me.arcScaleStateIndicatorComponent8, Me.arcScaleStateIndicatorComponent9})
            Me.circularGauge3.Name = "circularGauge3"
            Me.circularGauge3.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent7, Me.arcScaleNeedleComponent8, Me.arcScaleNeedleComponent9})
            Me.circularGauge3.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent7, Me.arcScaleComponent8, Me.arcScaleComponent9})
            Me.circularGauge3.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent3})
            ' 
            ' arcScaleBackgroundLayerComponent3
            ' 
            Me.arcScaleBackgroundLayerComponent3.ArcScale = Me.arcScaleComponent7
            Me.arcScaleBackgroundLayerComponent3.Name = "arcScaleBackgroundLayerComponent3"
            Me.arcScaleBackgroundLayerComponent3.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504F, 0.436F)
            Me.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
            Me.arcScaleBackgroundLayerComponent3.Size = New System.Drawing.SizeF(216F, 250F)
            Me.arcScaleBackgroundLayerComponent3.ZOrder = 1000
            ' 
            ' arcScaleComponent7
            ' 
            Me.arcScaleComponent7.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent7.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent7.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent7.EndAngle = 270F
            scaleLabel10.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            scaleLabel10.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            scaleLabel10.FormatString = "{0}"
            scaleLabel10.Name = "Label0"
            scaleLabel10.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F)
            scaleLabel10.Size = New System.Drawing.SizeF(70F, 20F)
            scaleLabel10.Text = "Tokyo"
            scaleLabel11.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            scaleLabel11.FormatString = "{0}"
            scaleLabel11.Name = "Label1"
            scaleLabel11.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 238F)
            scaleLabel11.Size = New System.Drawing.SizeF(50F, 15F)
            scaleLabel11.Text = "Japan"
            scaleLabel12.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            scaleLabel12.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            scaleLabel12.FormatString = "{0:F4}"
            scaleLabel12.Name = "Label2"
            scaleLabel12.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(168F, 225F)
            scaleLabel12.Size = New System.Drawing.SizeF(90F, 20F)
            scaleLabel12.Text = "10 058.33"
            Me.arcScaleComponent7.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {scaleLabel10, scaleLabel11, scaleLabel12})
            Me.arcScaleComponent7.MajorTickCount = 13
            Me.arcScaleComponent7.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent7.MajorTickmark.ShapeOffset = -9.5F
            Me.arcScaleComponent7.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent7.MajorTickmark.ShowFirst = False
            Me.arcScaleComponent7.MajorTickmark.TextOffset = -18F
            Me.arcScaleComponent7.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent7.MaxValue = 12F
            Me.arcScaleComponent7.MinorTickCount = 4
            Me.arcScaleComponent7.MinorTickmark.ShapeOffset = -1.5F
            Me.arcScaleComponent7.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent7.Name = "arcScaleComponent7"
            Me.arcScaleComponent7.RadiusX = 74F
            Me.arcScaleComponent7.RadiusY = 74F
            Me.arcScaleComponent7.StartAngle = -90F
            ' 
            ' arcScaleEffectLayerComponent3
            ' 
            Me.arcScaleEffectLayerComponent3.ArcScale = Me.arcScaleComponent7
            Me.arcScaleEffectLayerComponent3.Name = "arcScaleEffectLayerComponent3"
            Me.arcScaleEffectLayerComponent3.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1F)
            Me.arcScaleEffectLayerComponent3.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
            Me.arcScaleEffectLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
            Me.arcScaleEffectLayerComponent3.Size = New System.Drawing.SizeF(170F, 85F)
            Me.arcScaleEffectLayerComponent3.ZOrder = -1000
            ' 
            ' arcScaleStateIndicatorComponent7
            ' 
            Me.arcScaleStateIndicatorComponent7.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 218F)
            Me.arcScaleStateIndicatorComponent7.IndicatorScale = Me.arcScaleComponent7
            Me.arcScaleStateIndicatorComponent7.Name = "arcScaleStateIndicatorComponent7"
            Me.arcScaleStateIndicatorComponent7.Size = New System.Drawing.SizeF(40F, 21F)
            scaleIndicatorState10.IntervalLength = 12F
            scaleIndicatorState10.Name = "Default"
            scaleIndicatorState10.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagJapan
            Me.arcScaleStateIndicatorComponent7.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState10})
            Me.arcScaleStateIndicatorComponent7.ZOrder = -100
            ' 
            ' arcScaleStateIndicatorComponent8
            ' 
            Me.arcScaleStateIndicatorComponent8.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(118F, 223F)
            Me.arcScaleStateIndicatorComponent8.IndicatorScale = Me.arcScaleComponent7
            Me.arcScaleStateIndicatorComponent8.Name = "arcScaleStateIndicatorComponent8"
            Me.arcScaleStateIndicatorComponent8.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
            Me.arcScaleStateIndicatorComponent8.Size = New System.Drawing.SizeF(20F, 20F)
            scaleIndicatorState11.IntervalLength = 12F
            scaleIndicatorState11.Name = "Default"
            scaleIndicatorState11.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyJPY
            Me.arcScaleStateIndicatorComponent8.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState11})
            Me.arcScaleStateIndicatorComponent8.ZOrder = -100
            ' 
            ' arcScaleStateIndicatorComponent9
            ' 
            Me.arcScaleStateIndicatorComponent9.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(213F, 223F)
            Me.arcScaleStateIndicatorComponent9.IndicatorScale = Me.arcScaleComponent7
            Me.arcScaleStateIndicatorComponent9.Name = "arcScaleStateIndicatorComponent9"
            Me.arcScaleStateIndicatorComponent9.Size = New System.Drawing.SizeF(15F, 15F)
            scaleIndicatorState12.IntervalLength = 12F
            scaleIndicatorState12.Name = "Default"
            scaleIndicatorState12.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow10
            Me.arcScaleStateIndicatorComponent9.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState12})
            Me.arcScaleStateIndicatorComponent9.ZOrder = -100
            ' 
            ' arcScaleNeedleComponent7
            ' 
            Me.arcScaleNeedleComponent7.ArcScale = Me.arcScaleComponent7
            Me.arcScaleNeedleComponent7.EndOffset = 10F
            Me.arcScaleNeedleComponent7.Name = "arcScaleNeedleComponent7"
            Me.arcScaleNeedleComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
            Me.arcScaleNeedleComponent7.ZOrder = -50
            ' 
            ' arcScaleNeedleComponent8
            ' 
            Me.arcScaleNeedleComponent8.ArcScale = Me.arcScaleComponent8
            Me.arcScaleNeedleComponent8.EndOffset = -5F
            Me.arcScaleNeedleComponent8.Name = "arcScaleNeedleComponent8"
            Me.arcScaleNeedleComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
            Me.arcScaleNeedleComponent8.ZOrder = -51
            ' 
            ' arcScaleComponent8
            ' 
            Me.arcScaleComponent8.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent8.EndAngle = 270F
            Me.arcScaleComponent8.MajorTickCount = 2
            Me.arcScaleComponent8.MajorTickmark.ShowText = False
            Me.arcScaleComponent8.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent8.MaxValue = 12F
            Me.arcScaleComponent8.MinorTickCount = 0
            Me.arcScaleComponent8.Name = "arcScaleComponent8"
            Me.arcScaleComponent8.RadiusX = 74F
            Me.arcScaleComponent8.RadiusY = 74F
            Me.arcScaleComponent8.StartAngle = -90F
            Me.arcScaleComponent8.Value = 3F
            ' 
            ' arcScaleNeedleComponent9
            ' 
            Me.arcScaleNeedleComponent9.ArcScale = Me.arcScaleComponent9
            Me.arcScaleNeedleComponent9.EndOffset = -10F
            Me.arcScaleNeedleComponent9.Name = "arcScaleNeedleComponent9"
            Me.arcScaleNeedleComponent9.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
            Me.arcScaleNeedleComponent9.ZOrder = -52
            ' 
            ' arcScaleComponent9
            ' 
            Me.arcScaleComponent9.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent9.EndAngle = 270F
            Me.arcScaleComponent9.MajorTickCount = 2
            Me.arcScaleComponent9.MajorTickmark.ShowText = False
            Me.arcScaleComponent9.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent9.MaxValue = 12F
            Me.arcScaleComponent9.MinorTickCount = 0
            Me.arcScaleComponent9.Name = "arcScaleComponent9"
            Me.arcScaleComponent9.RadiusX = 74F
            Me.arcScaleComponent9.RadiusY = 74F
            Me.arcScaleComponent9.StartAngle = -90F
            Me.arcScaleComponent9.Value = 1.5F
            ' 
            ' arcScaleSpindleCapComponent3
            ' 
            Me.arcScaleSpindleCapComponent3.ArcScale = Me.arcScaleComponent7
            Me.arcScaleSpindleCapComponent3.Name = "arcScaleSpindleCapComponent3"
            Me.arcScaleSpindleCapComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
            Me.arcScaleSpindleCapComponent3.Size = New System.Drawing.SizeF(12F, 12F)
            Me.arcScaleSpindleCapComponent3.ZOrder = -100
            ' 
            ' London
            ' 
            Me.London.BackColor = System.Drawing.Color.Transparent
            Me.London.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.London.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge2})
            Me.London.Location = New System.Drawing.Point(8, 297)
            Me.London.Name = "London"
            Me.London.Size = New System.Drawing.Size(221, 288)
            Me.London.TabIndex = 5
            ' 
            ' circularGauge2
            ' 
            Me.circularGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent2})
            Me.circularGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 209, 276)
            Me.circularGauge2.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent2})
            Me.circularGauge2.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.arcScaleStateIndicatorComponent4, Me.arcScaleStateIndicatorComponent5, Me.arcScaleStateIndicatorComponent6})
            Me.circularGauge2.Name = "circularGauge2"
            Me.circularGauge2.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent4, Me.arcScaleNeedleComponent5, Me.arcScaleNeedleComponent6})
            Me.circularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent4, Me.arcScaleComponent5, Me.arcScaleComponent6})
            Me.circularGauge2.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent2})
            ' 
            ' arcScaleBackgroundLayerComponent2
            ' 
            Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent4
            Me.arcScaleBackgroundLayerComponent2.Name = "arcScaleBackgroundLayerComponent2"
            Me.arcScaleBackgroundLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504F, 0.436F)
            Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
            Me.arcScaleBackgroundLayerComponent2.Size = New System.Drawing.SizeF(216F, 250F)
            Me.arcScaleBackgroundLayerComponent2.ZOrder = 1000
            ' 
            ' arcScaleComponent4
            ' 
            Me.arcScaleComponent4.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent4.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent4.EndAngle = 270F
            scaleLabel13.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            scaleLabel13.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            scaleLabel13.FormatString = "{0}"
            scaleLabel13.Name = "Label0"
            scaleLabel13.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F)
            scaleLabel13.Size = New System.Drawing.SizeF(70F, 20F)
            scaleLabel13.Text = "London"
            scaleLabel14.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            scaleLabel14.FormatString = "{0}"
            scaleLabel14.Name = "Label1"
            scaleLabel14.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 238F)
            scaleLabel14.Size = New System.Drawing.SizeF(90F, 15F)
            scaleLabel14.Text = "United Kingdom"
            scaleLabel15.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            scaleLabel15.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            scaleLabel15.FormatString = "{0:F4}"
            scaleLabel15.Name = "Label2"
            scaleLabel15.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(168F, 225F)
            scaleLabel15.Size = New System.Drawing.SizeF(70F, 20F)
            scaleLabel15.Text = "57.750"
            Me.arcScaleComponent4.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {scaleLabel13, scaleLabel14, scaleLabel15})
            Me.arcScaleComponent4.MajorTickCount = 13
            Me.arcScaleComponent4.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent4.MajorTickmark.ShapeOffset = -9.5F
            Me.arcScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent4.MajorTickmark.ShowFirst = False
            Me.arcScaleComponent4.MajorTickmark.TextOffset = -18F
            Me.arcScaleComponent4.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent4.MaxValue = 12F
            Me.arcScaleComponent4.MinorTickCount = 4
            Me.arcScaleComponent4.MinorTickmark.ShapeOffset = -1.5F
            Me.arcScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent4.Name = "arcScaleComponent4"
            Me.arcScaleComponent4.RadiusX = 74F
            Me.arcScaleComponent4.RadiusY = 74F
            Me.arcScaleComponent4.StartAngle = -90F
            ' 
            ' arcScaleEffectLayerComponent2
            ' 
            Me.arcScaleEffectLayerComponent2.ArcScale = Me.arcScaleComponent4
            Me.arcScaleEffectLayerComponent2.Name = "arcScaleEffectLayerComponent2"
            Me.arcScaleEffectLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1F)
            Me.arcScaleEffectLayerComponent2.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
            Me.arcScaleEffectLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
            Me.arcScaleEffectLayerComponent2.Size = New System.Drawing.SizeF(170F, 85F)
            Me.arcScaleEffectLayerComponent2.ZOrder = -1000
            ' 
            ' arcScaleStateIndicatorComponent4
            ' 
            Me.arcScaleStateIndicatorComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 218F)
            Me.arcScaleStateIndicatorComponent4.IndicatorScale = Me.arcScaleComponent4
            Me.arcScaleStateIndicatorComponent4.Name = "arcScaleStateIndicatorComponent4"
            Me.arcScaleStateIndicatorComponent4.Size = New System.Drawing.SizeF(40F, 21F)
            scaleIndicatorState13.IntervalLength = 12F
            scaleIndicatorState13.Name = "Default"
            scaleIndicatorState13.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagUK
            Me.arcScaleStateIndicatorComponent4.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState13})
            Me.arcScaleStateIndicatorComponent4.ZOrder = -100
            ' 
            ' arcScaleStateIndicatorComponent5
            ' 
            Me.arcScaleStateIndicatorComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(130F, 223F)
            Me.arcScaleStateIndicatorComponent5.IndicatorScale = Me.arcScaleComponent4
            Me.arcScaleStateIndicatorComponent5.Name = "arcScaleStateIndicatorComponent5"
            Me.arcScaleStateIndicatorComponent5.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
            Me.arcScaleStateIndicatorComponent5.Size = New System.Drawing.SizeF(20F, 20F)
            scaleIndicatorState14.IntervalLength = 12F
            scaleIndicatorState14.Name = "Default"
            scaleIndicatorState14.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyGBP
            Me.arcScaleStateIndicatorComponent5.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState14})
            Me.arcScaleStateIndicatorComponent5.ZOrder = -100
            ' 
            ' arcScaleStateIndicatorComponent6
            ' 
            Me.arcScaleStateIndicatorComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(203F, 223F)
            Me.arcScaleStateIndicatorComponent6.IndicatorScale = Me.arcScaleComponent4
            Me.arcScaleStateIndicatorComponent6.Name = "arcScaleStateIndicatorComponent6"
            Me.arcScaleStateIndicatorComponent6.Size = New System.Drawing.SizeF(15F, 15F)
            scaleIndicatorState15.IntervalLength = 12F
            scaleIndicatorState15.Name = "Default"
            scaleIndicatorState15.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow9
            Me.arcScaleStateIndicatorComponent6.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState15})
            Me.arcScaleStateIndicatorComponent6.ZOrder = -100
            ' 
            ' arcScaleNeedleComponent4
            ' 
            Me.arcScaleNeedleComponent4.ArcScale = Me.arcScaleComponent4
            Me.arcScaleNeedleComponent4.EndOffset = 10F
            Me.arcScaleNeedleComponent4.Name = "arcScaleNeedleComponent4"
            Me.arcScaleNeedleComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
            Me.arcScaleNeedleComponent4.ZOrder = -50
            ' 
            ' arcScaleNeedleComponent5
            ' 
            Me.arcScaleNeedleComponent5.ArcScale = Me.arcScaleComponent5
            Me.arcScaleNeedleComponent5.EndOffset = -5F
            Me.arcScaleNeedleComponent5.Name = "arcScaleNeedleComponent5"
            Me.arcScaleNeedleComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
            Me.arcScaleNeedleComponent5.ZOrder = -51
            ' 
            ' arcScaleComponent5
            ' 
            Me.arcScaleComponent5.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent5.EndAngle = 270F
            Me.arcScaleComponent5.MajorTickCount = 2
            Me.arcScaleComponent5.MajorTickmark.ShowText = False
            Me.arcScaleComponent5.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent5.MaxValue = 12F
            Me.arcScaleComponent5.MinorTickCount = 0
            Me.arcScaleComponent5.Name = "arcScaleComponent5"
            Me.arcScaleComponent5.RadiusX = 74F
            Me.arcScaleComponent5.RadiusY = 74F
            Me.arcScaleComponent5.StartAngle = -90F
            Me.arcScaleComponent5.Value = 3F
            ' 
            ' arcScaleNeedleComponent6
            ' 
            Me.arcScaleNeedleComponent6.ArcScale = Me.arcScaleComponent6
            Me.arcScaleNeedleComponent6.EndOffset = -10F
            Me.arcScaleNeedleComponent6.Name = "arcScaleNeedleComponent6"
            Me.arcScaleNeedleComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
            Me.arcScaleNeedleComponent6.ZOrder = -52
            ' 
            ' arcScaleComponent6
            ' 
            Me.arcScaleComponent6.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent6.EndAngle = 270F
            Me.arcScaleComponent6.MajorTickCount = 2
            Me.arcScaleComponent6.MajorTickmark.ShowText = False
            Me.arcScaleComponent6.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent6.MaxValue = 12F
            Me.arcScaleComponent6.MinorTickCount = 0
            Me.arcScaleComponent6.Name = "arcScaleComponent6"
            Me.arcScaleComponent6.RadiusX = 74F
            Me.arcScaleComponent6.RadiusY = 74F
            Me.arcScaleComponent6.StartAngle = -90F
            Me.arcScaleComponent6.Value = 1.5F
            ' 
            ' arcScaleSpindleCapComponent2
            ' 
            Me.arcScaleSpindleCapComponent2.ArcScale = Me.arcScaleComponent4
            Me.arcScaleSpindleCapComponent2.Name = "arcScaleSpindleCapComponent2"
            Me.arcScaleSpindleCapComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
            Me.arcScaleSpindleCapComponent2.Size = New System.Drawing.SizeF(12F, 12F)
            Me.arcScaleSpindleCapComponent2.ZOrder = -100
            ' 
            ' Washington
            ' 
            Me.Washington.BackColor = System.Drawing.Color.Transparent
            Me.Washington.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.Washington.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
            Me.Washington.Location = New System.Drawing.Point(8, 8)
            Me.Washington.Name = "Washington"
            Me.Washington.Size = New System.Drawing.Size(221, 289)
            Me.Washington.TabIndex = 4
            ' 
            ' circularGauge1
            ' 
            Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent1})
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 209, 277)
            Me.circularGauge1.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent1})
            Me.circularGauge1.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.arcScaleStateIndicatorComponent1, Me.arcScaleStateIndicatorComponent2})
            Me.circularGauge1.Name = "circularGauge1"
            Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent1, Me.arcScaleNeedleComponent2, Me.arcScaleNeedleComponent3})
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1, Me.arcScaleComponent2, Me.arcScaleComponent3})
            Me.circularGauge1.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent1})
            ' 
            ' arcScaleBackgroundLayerComponent1
            ' 
            Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleBackgroundLayerComponent1.Name = "arcScaleBackgroundLayerComponent1"
            Me.arcScaleBackgroundLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504F, 0.436F)
            Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
            Me.arcScaleBackgroundLayerComponent1.Size = New System.Drawing.SizeF(216F, 250F)
            Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
            ' 
            ' arcScaleComponent1
            ' 
            Me.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent1.EndAngle = 270F
            scaleLabel16.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            scaleLabel16.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            scaleLabel16.FormatString = "{0}"
            scaleLabel16.Name = "Label0"
            scaleLabel16.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F)
            scaleLabel16.Size = New System.Drawing.SizeF(70F, 20F)
            scaleLabel16.Text = "Washington"
            scaleLabel17.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            scaleLabel17.FormatString = "{0}"
            scaleLabel17.Name = "Label1"
            scaleLabel17.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 238F)
            scaleLabel17.Size = New System.Drawing.SizeF(50F, 15F)
            scaleLabel17.Text = "U.S.A."
            scaleLabel18.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            scaleLabel18.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            scaleLabel18.FormatString = "{0}"
            scaleLabel18.Name = "Label2"
            scaleLabel18.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(160F, 225F)
            scaleLabel18.Size = New System.Drawing.SizeF(70F, 20F)
            scaleLabel18.Text = "100.00"
            Me.arcScaleComponent1.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {scaleLabel16, scaleLabel17, scaleLabel18})
            Me.arcScaleComponent1.MajorTickCount = 13
            Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -9.5F
            Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent1.MajorTickmark.ShowFirst = False
            Me.arcScaleComponent1.MajorTickmark.TextOffset = -18F
            Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent1.MaxValue = 12F
            Me.arcScaleComponent1.MinorTickCount = 4
            Me.arcScaleComponent1.MinorTickmark.ShapeOffset = -1.5F
            Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent1.Name = "arcScaleComponent1"
            Me.arcScaleComponent1.RadiusX = 74F
            Me.arcScaleComponent1.RadiusY = 74F
            Me.arcScaleComponent1.StartAngle = -90F
            ' 
            ' arcScaleEffectLayerComponent1
            ' 
            Me.arcScaleEffectLayerComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleEffectLayerComponent1.Name = "arcScaleEffectLayerComponent1"
            Me.arcScaleEffectLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1F)
            Me.arcScaleEffectLayerComponent1.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
            Me.arcScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
            Me.arcScaleEffectLayerComponent1.Size = New System.Drawing.SizeF(170F, 85F)
            Me.arcScaleEffectLayerComponent1.ZOrder = -1000
            ' 
            ' arcScaleStateIndicatorComponent1
            ' 
            Me.arcScaleStateIndicatorComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 218F)
            Me.arcScaleStateIndicatorComponent1.IndicatorScale = Me.arcScaleComponent1
            Me.arcScaleStateIndicatorComponent1.Name = "arcScaleStateIndicatorComponent1"
            Me.arcScaleStateIndicatorComponent1.Size = New System.Drawing.SizeF(40F, 21F)
            scaleIndicatorState16.IntervalLength = 12F
            scaleIndicatorState16.Name = "Default"
            scaleIndicatorState16.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagUSA
            Me.arcScaleStateIndicatorComponent1.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState16})
            Me.arcScaleStateIndicatorComponent1.ZOrder = -100
            ' 
            ' arcScaleStateIndicatorComponent2
            ' 
            Me.arcScaleStateIndicatorComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(123F, 223F)
            Me.arcScaleStateIndicatorComponent2.IndicatorScale = Me.arcScaleComponent1
            Me.arcScaleStateIndicatorComponent2.Name = "arcScaleStateIndicatorComponent2"
            Me.arcScaleStateIndicatorComponent2.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
            Me.arcScaleStateIndicatorComponent2.Size = New System.Drawing.SizeF(20F, 20F)
            scaleIndicatorState17.IntervalLength = 12F
            scaleIndicatorState17.Name = "Default"
            scaleIndicatorState17.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyUSD
            Me.arcScaleStateIndicatorComponent2.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState17})
            Me.arcScaleStateIndicatorComponent2.ZOrder = -100
            ' 
            ' arcScaleNeedleComponent1
            ' 
            Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleNeedleComponent1.EndOffset = 10F
            Me.arcScaleNeedleComponent1.Name = "arcScaleNeedleComponent1"
            Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
            Me.arcScaleNeedleComponent1.ZOrder = -50
            ' 
            ' arcScaleNeedleComponent2
            ' 
            Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleNeedleComponent2.EndOffset = -5F
            Me.arcScaleNeedleComponent2.Name = "arcScaleNeedleComponent2"
            Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
            Me.arcScaleNeedleComponent2.ZOrder = -51
            ' 
            ' arcScaleComponent2
            ' 
            Me.arcScaleComponent2.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent2.EndAngle = 270F
            Me.arcScaleComponent2.MajorTickCount = 2
            Me.arcScaleComponent2.MajorTickmark.ShowText = False
            Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent2.MaxValue = 12F
            Me.arcScaleComponent2.MinorTickCount = 0
            Me.arcScaleComponent2.Name = "arcScaleComponent2"
            Me.arcScaleComponent2.RadiusX = 74F
            Me.arcScaleComponent2.RadiusY = 74F
            Me.arcScaleComponent2.StartAngle = -90F
            Me.arcScaleComponent2.Value = 3F
            ' 
            ' arcScaleNeedleComponent3
            ' 
            Me.arcScaleNeedleComponent3.ArcScale = Me.arcScaleComponent3
            Me.arcScaleNeedleComponent3.EndOffset = -10F
            Me.arcScaleNeedleComponent3.Name = "arcScaleNeedleComponent3"
            Me.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
            Me.arcScaleNeedleComponent3.ZOrder = -52
            ' 
            ' arcScaleComponent3
            ' 
            Me.arcScaleComponent3.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F)
            Me.arcScaleComponent3.EndAngle = 270F
            Me.arcScaleComponent3.MajorTickCount = 2
            Me.arcScaleComponent3.MajorTickmark.ShowText = False
            Me.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent3.MaxValue = 12F
            Me.arcScaleComponent3.MinorTickCount = 0
            Me.arcScaleComponent3.Name = "arcScaleComponent3"
            Me.arcScaleComponent3.RadiusX = 74F
            Me.arcScaleComponent3.RadiusY = 74F
            Me.arcScaleComponent3.StartAngle = -90F
            Me.arcScaleComponent3.Value = 1.5F
            ' 
            ' arcScaleSpindleCapComponent1
            ' 
            Me.arcScaleSpindleCapComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleSpindleCapComponent1.Name = "arcScaleSpindleCapComponent1"
            Me.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
            Me.arcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(12F, 12F)
            Me.arcScaleSpindleCapComponent1.ZOrder = -100
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem4, Me.layoutControlItem3, Me.layoutControlItem2, Me.layoutControlItem5, Me.layoutControlItem6})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(687, 593)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.Washington
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 0, 8, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 297)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.Paris
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(229, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 8, 0)
            Me.layoutControlItem4.Size = New System.Drawing.Size(230, 297)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.Tokyo
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(229, 297)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 0, 8)
            Me.layoutControlItem3.Size = New System.Drawing.Size(230, 296)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.London
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 297)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 0, 0, 8)
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 296)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.Madrid
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(459, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 8, 8, 0)
            Me.layoutControlItem5.Size = New System.Drawing.Size(228, 297)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.Rome
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(459, 297)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 8, 0, 8)
            Me.layoutControlItem6.Size = New System.Drawing.Size(228, 296)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' timer
            ' 
            Me.timer.Interval = 1000
            AddHandler Me.timer.Tick, New System.EventHandler(AddressOf Me.OnTimerTick)
            ' 
            ' WorldTime
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "WorldTime"
            Me.Size = New System.Drawing.Size(687, 593)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.circularGauge6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleStateIndicatorComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Washington As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private timer As System.Windows.Forms.Timer

        Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleStateIndicatorComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleStateIndicatorComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private London As DevExpress.XtraGauges.Win.GaugeControl

        Private circularGauge2 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleStateIndicatorComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleStateIndicatorComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleStateIndicatorComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleNeedleComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleNeedleComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private Paris As DevExpress.XtraGauges.Win.GaugeControl

        Private circularGauge4 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleStateIndicatorComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleStateIndicatorComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleStateIndicatorComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleNeedleComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleNeedleComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private Tokyo As DevExpress.XtraGauges.Win.GaugeControl

        Private circularGauge3 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleStateIndicatorComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleStateIndicatorComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleStateIndicatorComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleNeedleComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleNeedleComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private Rome As DevExpress.XtraGauges.Win.GaugeControl

        Private circularGauge6 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleStateIndicatorComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleStateIndicatorComponent17 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleStateIndicatorComponent18 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleNeedleComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleNeedleComponent17 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent17 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent18 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent18 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private Madrid As DevExpress.XtraGauges.Win.GaugeControl

        Private circularGauge5 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleStateIndicatorComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleStateIndicatorComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleStateIndicatorComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent

        Private arcScaleNeedleComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleNeedleComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
