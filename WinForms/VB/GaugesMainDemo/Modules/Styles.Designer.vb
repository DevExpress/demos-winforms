Namespace DevExpress.XtraGauges.Demos

    Partial Class GaugesStyles

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
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
            Me.xtraTabControl1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.xtraTabPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl6 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleLevelComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.linearScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.gaugeControl5 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge2 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl4 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge3 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl3 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge4 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.xtraTabPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl7 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.linearScaleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleLevelComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.linearScaleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.gaugeControl8 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge5 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl9 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge6 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent34 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl10 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge7 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl11 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge2 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.gaugeControl12 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge8 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent33 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.xtraTabPage3 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl3 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl13 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge3 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.linearScaleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleLevelComponent3 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.linearScaleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.gaugeControl14 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge9 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent9 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent9 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent9 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent35 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent9 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl15 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge10 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent37 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl16 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge11 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent38 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl17 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge3 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.gaugeControl18 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge12 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleBackgroundLayerComponent33 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleNeedleComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent36 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.xtraTabPage4 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl4 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl19 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.linearScaleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleLevelComponent4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.linearScaleComponent8 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.gaugeControl20 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge13 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent13 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent13 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent13 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent39 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl21 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge14 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent41 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl22 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge15 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent42 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl23 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge4 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.gaugeControl24 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge16 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleBackgroundLayerComponent34 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleNeedleComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent40 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.xtraTabPage5 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl5 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl25 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayerComponent5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.linearScaleComponent9 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleEffectLayerComponent()
            Me.linearScaleLevelComponent5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.linearScaleComponent10 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.gaugeControl26 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge17 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent17 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent17 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent17 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent43 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent13 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl27 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge18 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent18 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent18 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent18 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl28 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge19 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent19 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent19 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent19 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent45 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl29 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge5 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent5 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.gaugeControl30 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge20 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent20 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent20 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent20 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent44 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.xtraTabPage6 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl6 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl31 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.linearScaleComponent11 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleLevelComponent6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.linearScaleComponent12 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.gaugeControl32 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge21 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent21 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent21 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent21 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.gaugeControl33 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge22 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent22 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent22 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent22 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.gaugeControl34 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge23 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent23 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent23 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent23 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.gaugeControl35 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge6 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.gaugeControl36 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge24 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent24 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent24 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent24 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.xtraTabPage7 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl7 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl37 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge7 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayerComponent7 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.linearScaleComponent13 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleLevelComponent7 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.linearScaleComponent14 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.gaugeControl38 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge25 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent25 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent25 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent9 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent25 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent17 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl39 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge26 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent26 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent26 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent26 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent19 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl40 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge27 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent27 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent27 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent27 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent46 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent20 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl41 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge7 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent7 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.gaugeControl42 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge28 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent28 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent28 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent28 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent18 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.layoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.xtraTabPage8 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl8 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl43 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge8 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayerComponent8 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.linearScaleComponent15 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleLevelComponent8 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.linearScaleComponent16 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.gaugeControl44 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge29 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent29 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent29 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent13 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent29 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent21 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl45 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge30 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent30 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent30 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent30 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent23 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl46 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge31 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent31 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent31 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent31 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent24 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl47 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge8 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent8 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.gaugeControl48 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge32 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent32 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent32 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent32 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent22 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.layoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.xtraTabPage9 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl10 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl55 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge10 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayerComponent10 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.linearScaleComponent19 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleLevelComponent10 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.linearScaleComponent20 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.gaugeControl56 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge37 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent39 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent51 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent37 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent59 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl57 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge38 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent40 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent52 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent38 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent61 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl58 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge39 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent41 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent53 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent39 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent62 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl59 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge10 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent10 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.gaugeControl60 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge40 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent42 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent54 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent40 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent60 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.layoutControlGroup10 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem55 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem57 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem58 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem59 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem60 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.xtraTabPage10 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl11 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl61 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge11 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayerComponent11 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.linearScaleComponent21 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleLevelComponent11 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.linearScaleComponent22 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.gaugeControl62 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge41 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent43 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent55 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent41 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent64 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl63 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge42 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent44 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent56 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent42 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent63 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl64 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge43 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent45 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent57 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent43 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent66 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl65 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge11 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent11 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.gaugeControl66 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge44 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent46 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent58 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent44 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent65 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.layoutControlGroup11 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem61 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem62 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem63 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem64 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem65 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem66 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControl9 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl49 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge9 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayerComponent9 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.linearScaleComponent17 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleLevelComponent9 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.linearScaleComponent18 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.gaugeControl50 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge33 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent35 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent47 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent17 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent33 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent25 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl51 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge34 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent36 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent48 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent18 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent34 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent26 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl52 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge35 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent37 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent49 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent19 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent35 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent27 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.gaugeControl53 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge9 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent9 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.gaugeControl54 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge36 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent38 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent50 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent20 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent36 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent28 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.layoutControlGroup9 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem50 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem51 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem53 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem54 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.linearGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleLevelComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage2.SuspendLayout()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.linearGauge2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleBackgroundLayerComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleLevelComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent34), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent33), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage3.SuspendLayout()
            CType((Me.layoutControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl3.SuspendLayout()
            CType((Me.linearGauge3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleBackgroundLayerComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleLevelComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent35), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent37), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent38), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent33), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent36), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem18), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage4.SuspendLayout()
            CType((Me.layoutControl4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl4.SuspendLayout()
            CType((Me.linearGauge4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleBackgroundLayerComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleLevelComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent39), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent41), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent42), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent34), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent40), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem22), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem23), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem24), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage5.SuspendLayout()
            CType((Me.layoutControl5), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl5.SuspendLayout()
            CType((Me.linearGauge5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleBackgroundLayerComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleEffectLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleLevelComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent43), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent45), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent44), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem25), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem26), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem27), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem28), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem29), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem30), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage6.SuspendLayout()
            CType((Me.layoutControl6), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl6.SuspendLayout()
            CType((Me.linearGauge6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleBackgroundLayerComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleLevelComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge22), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent22), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent22), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent22), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge23), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent23), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent23), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent23), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge24), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent24), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent24), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent24), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem31), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem32), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem33), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem34), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem35), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem36), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage7.SuspendLayout()
            CType((Me.layoutControl7), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl7.SuspendLayout()
            CType((Me.linearGauge7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleBackgroundLayerComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleLevelComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge25), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent25), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent25), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent25), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge26), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent26), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent26), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent26), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge27), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent27), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent27), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent27), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent46), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge28), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent28), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent28), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent28), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem37), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem38), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem39), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem40), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem41), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem42), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage8.SuspendLayout()
            CType((Me.layoutControl8), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl8.SuspendLayout()
            CType((Me.linearGauge8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleBackgroundLayerComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleLevelComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge29), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent29), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent29), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent29), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge30), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent30), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent30), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent30), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent23), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge31), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent31), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent31), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent31), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent24), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge32), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent32), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent32), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent32), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent22), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem43), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem44), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem45), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem46), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem47), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem48), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage9.SuspendLayout()
            CType((Me.layoutControl10), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl10.SuspendLayout()
            CType((Me.linearGauge10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleBackgroundLayerComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleLevelComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge37), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent39), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent51), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent37), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent59), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge38), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent40), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent52), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent38), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent61), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge39), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent41), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent53), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent39), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent62), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge40), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent42), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent54), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent40), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent60), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem55), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem56), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem57), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem58), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem59), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem60), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage10.SuspendLayout()
            CType((Me.layoutControl11), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl11.SuspendLayout()
            CType((Me.linearGauge11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleBackgroundLayerComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleLevelComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent22), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge41), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent43), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent55), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent41), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent64), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge42), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent44), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent56), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent42), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent63), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge43), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent45), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent57), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent43), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent66), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge44), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent46), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent58), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent44), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent65), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem61), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem62), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem63), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem64), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem65), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem66), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl9), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl9.SuspendLayout()
            CType((Me.linearGauge9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleBackgroundLayerComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleLevelComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge33), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent35), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent47), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent33), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent25), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge34), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent36), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent48), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent34), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent26), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge35), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent37), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent49), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent35), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent27), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge36), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent38), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent50), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent36), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent28), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem49), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem50), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem51), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem52), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem53), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem54), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Controls.Add(Me.xtraTabPage1)
            Me.xtraTabControl1.Controls.Add(Me.xtraTabPage2)
            Me.xtraTabControl1.Controls.Add(Me.xtraTabPage3)
            Me.xtraTabControl1.Controls.Add(Me.xtraTabPage4)
            Me.xtraTabControl1.Controls.Add(Me.xtraTabPage5)
            Me.xtraTabControl1.Controls.Add(Me.xtraTabPage6)
            Me.xtraTabControl1.Controls.Add(Me.xtraTabPage7)
            Me.xtraTabControl1.Controls.Add(Me.xtraTabPage8)
            Me.xtraTabControl1.Controls.Add(Me.xtraTabPage9)
            Me.xtraTabControl1.Controls.Add(Me.xtraTabPage10)
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.Padding = New System.Windows.Forms.Padding(3)
            Me.xtraTabControl1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.xtraTabPage1, Me.xtraTabPage2, Me.xtraTabPage3, Me.xtraTabPage4, Me.xtraTabPage5, Me.xtraTabPage6, Me.xtraTabPage7, Me.xtraTabPage8, Me.xtraTabPage9, Me.xtraTabPage10})
            Me.xtraTabControl1.RegularSize = New System.Drawing.Size(728, 513)
            Me.xtraTabControl1.SelectedPage = Me.xtraTabPage1
            Me.xtraTabControl1.Size = New System.Drawing.Size(728, 513)
            Me.xtraTabControl1.TabIndex = 0
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Caption = "Dark Night"
            Me.xtraTabPage1.Controls.Add(Me.layoutControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.xtraTabPage1.Size = New System.Drawing.Size(728, 480)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.gaugeControl6)
            Me.layoutControl1.Controls.Add(Me.gaugeControl5)
            Me.layoutControl1.Controls.Add(Me.gaugeControl4)
            Me.layoutControl1.Controls.Add(Me.gaugeControl3)
            Me.layoutControl1.Controls.Add(Me.gaugeControl2)
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(3, 3)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(722, 474)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' gaugeControl6
            ' 
            Me.gaugeControl6.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge1})
            Me.gaugeControl6.Location = New System.Drawing.Point(497, 225)
            Me.gaugeControl6.Name = "gaugeControl6"
            Me.gaugeControl6.Size = New System.Drawing.Size(223, 247)
            Me.gaugeControl6.TabIndex = 9
            ' 
            ' linearGauge1
            ' 
            Me.linearGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent1})
            Me.linearGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 211, 235)
            Me.linearGauge1.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent1})
            Me.linearGauge1.Name = "linearGauge1"
            Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent1, Me.linearScaleComponent2})
            ' 
            ' linearScaleBackgroundLayerComponent1
            ' 
            Me.linearScaleBackgroundLayerComponent1.LinearScale = Me.linearScaleComponent1
            Me.linearScaleBackgroundLayerComponent1.Name = "bg1"
            Me.linearScaleBackgroundLayerComponent1.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.12F)
            Me.linearScaleBackgroundLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.855F)
            Me.linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style2
            Me.linearScaleBackgroundLayerComponent1.ZOrder = 1000
            ' 
            ' linearScaleComponent1
            ' 
            Me.linearScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Arial Narrow", 10F)
            Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C0C0FF")
            Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 31F)
            Me.linearScaleComponent1.MajorTickCount = 6
            Me.linearScaleComponent1.MajorTickmark.AllowTickOverlap = True
            Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent1.MajorTickmark.ShapeOffset = 16.5F
            Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style2_2
            Me.linearScaleComponent1.MajorTickmark.TextOffset = 36F
            Me.linearScaleComponent1.MaxValue = 500F
            Me.linearScaleComponent1.MinorTickCount = 4
            Me.linearScaleComponent1.MinorTickmark.ShapeOffset = 8.5F
            Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style2_2
            Me.linearScaleComponent1.Name = "scale1"
            Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F)
            Me.linearScaleComponent1.Value = 250F
            ' 
            ' linearScaleLevelComponent1
            ' 
            Me.linearScaleLevelComponent1.LinearScale = Me.linearScaleComponent1
            Me.linearScaleLevelComponent1.Name = "level1"
            Me.linearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style2
            Me.linearScaleLevelComponent1.ZOrder = -50
            ' 
            ' linearScaleComponent2
            ' 
            Me.linearScaleComponent2.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75F)
            Me.linearScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C0C0FF")
            Me.linearScaleComponent2.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 31F)
            Me.linearScaleComponent2.MajorTickCount = 6
            Me.linearScaleComponent2.MajorTickmark.AllowTickOverlap = True
            Me.linearScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent2.MajorTickmark.ShapeOffset = -22F
            Me.linearScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style2_1
            Me.linearScaleComponent2.MajorTickmark.TextOffset = -35F
            Me.linearScaleComponent2.MaxValue = 50F
            Me.linearScaleComponent2.MinorTickCount = 4
            Me.linearScaleComponent2.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style2_1
            Me.linearScaleComponent2.Name = "scale2"
            Me.linearScaleComponent2.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F)
            ' 
            ' gaugeControl5
            ' 
            Me.gaugeControl5.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge2})
            Me.gaugeControl5.Location = New System.Drawing.Point(271, 2)
            Me.gaugeControl5.Name = "gaugeControl5"
            Me.gaugeControl5.Size = New System.Drawing.Size(222, 219)
            Me.gaugeControl5.TabIndex = 8
            ' 
            ' circularGauge2
            ' 
            Me.circularGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent2})
            Me.circularGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 210, 207)
            Me.circularGauge2.Name = "circularGauge2"
            Me.circularGauge2.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent2})
            Me.circularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent2})
            Me.circularGauge2.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent2})
            ' 
            ' arcScaleBackgroundLayerComponent2
            ' 
            Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleBackgroundLayerComponent2.Name = "arcScaleBackgroundLayerComponent2"
            Me.arcScaleBackgroundLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.72F)
            Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style2
            Me.arcScaleBackgroundLayerComponent2.Size = New System.Drawing.SizeF(244F, 170F)
            Me.arcScaleBackgroundLayerComponent2.ZOrder = 1000
            ' 
            ' arcScaleComponent2
            ' 
            Me.arcScaleComponent2.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Arial Narrow", 11F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C0C0FF")
            Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent2.EndAngle = 0F
            Me.arcScaleComponent2.MajorTickCount = 7
            Me.arcScaleComponent2.MajorTickmark.AllowTickOverlap = True
            Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent2.MajorTickmark.ShapeOffset = -9F
            Me.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style2_2
            Me.arcScaleComponent2.MajorTickmark.TextOffset = -22F
            Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent2.MaxValue = 100F
            Me.arcScaleComponent2.MinorTickCount = 4
            Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style2_1
            Me.arcScaleComponent2.MinValue = 40F
            Me.arcScaleComponent2.Name = "arcScaleComponent2"
            Me.arcScaleComponent2.RadiusX = 91F
            Me.arcScaleComponent2.RadiusY = 91F
            Me.arcScaleComponent2.StartAngle = -180F
            Me.arcScaleComponent2.Value = 40F
            ' 
            ' arcScaleNeedleComponent2
            ' 
            Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleNeedleComponent2.EndOffset = -6F
            Me.arcScaleNeedleComponent2.Name = "arcScaleNeedleComponent2"
            Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style2
            Me.arcScaleNeedleComponent2.StartOffset = 9F
            Me.arcScaleNeedleComponent2.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent2
            ' 
            Me.arcScaleSpindleCapComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleSpindleCapComponent2.Name = "arcScaleSpindleCapComponent2"
            Me.arcScaleSpindleCapComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style2
            Me.arcScaleSpindleCapComponent2.Size = New System.Drawing.SizeF(24F, 24F)
            Me.arcScaleSpindleCapComponent2.ZOrder = -100
            ' 
            ' gaugeControl4
            ' 
            Me.gaugeControl4.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge3})
            Me.gaugeControl4.Location = New System.Drawing.Point(2, 225)
            Me.gaugeControl4.Name = "gaugeControl4"
            Me.gaugeControl4.Size = New System.Drawing.Size(265, 247)
            Me.gaugeControl4.TabIndex = 7
            ' 
            ' circularGauge3
            ' 
            Me.circularGauge3.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent3})
            Me.circularGauge3.Bounds = New System.Drawing.Rectangle(6, 6, 253, 235)
            Me.circularGauge3.Name = "circularGauge3"
            Me.circularGauge3.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent3})
            Me.circularGauge3.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent3})
            Me.circularGauge3.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent3})
            ' 
            ' arcScaleBackgroundLayerComponent3
            ' 
            Me.arcScaleBackgroundLayerComponent3.ArcScale = Me.arcScaleComponent3
            Me.arcScaleBackgroundLayerComponent3.Name = "arcScaleBackgroundLayerComponent3"
            Me.arcScaleBackgroundLayerComponent3.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.78F, 0.78F)
            Me.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style2Left
            Me.arcScaleBackgroundLayerComponent3.ZOrder = 1000
            ' 
            ' arcScaleComponent3
            ' 
            Me.arcScaleComponent3.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Arial Narrow", 16F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent3.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C0C0FF")
            Me.arcScaleComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(195F, 195F)
            Me.arcScaleComponent3.EndAngle = -90F
            Me.arcScaleComponent3.MajorTickCount = 4
            Me.arcScaleComponent3.MajorTickmark.AllowTickOverlap = True
            Me.arcScaleComponent3.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent3.MajorTickmark.ShapeOffset = -13F
            Me.arcScaleComponent3.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style2_2
            Me.arcScaleComponent3.MajorTickmark.TextOffset = -30F
            Me.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent3.MaxValue = 70F
            Me.arcScaleComponent3.MinorTickCount = 4
            Me.arcScaleComponent3.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style2_1
            Me.arcScaleComponent3.MinValue = 40F
            Me.arcScaleComponent3.Name = "arcScaleComponent3"
            Me.arcScaleComponent3.RadiusX = 144F
            Me.arcScaleComponent3.RadiusY = 144F
            Me.arcScaleComponent3.StartAngle = -180F
            Me.arcScaleComponent3.Value = 50F
            ' 
            ' arcScaleNeedleComponent3
            ' 
            Me.arcScaleNeedleComponent3.ArcScale = Me.arcScaleComponent3
            Me.arcScaleNeedleComponent3.EndOffset = -6F
            Me.arcScaleNeedleComponent3.Name = "arcScaleNeedleComponent3"
            Me.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style2
            Me.arcScaleNeedleComponent3.StartOffset = 9F
            Me.arcScaleNeedleComponent3.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent3
            ' 
            Me.arcScaleSpindleCapComponent3.ArcScale = Me.arcScaleComponent3
            Me.arcScaleSpindleCapComponent3.Name = "arcScaleSpindleCapComponent3"
            Me.arcScaleSpindleCapComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style2
            Me.arcScaleSpindleCapComponent3.ZOrder = -100
            ' 
            ' gaugeControl3
            ' 
            Me.gaugeControl3.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge4})
            Me.gaugeControl3.Location = New System.Drawing.Point(271, 225)
            Me.gaugeControl3.Name = "gaugeControl3"
            Me.gaugeControl3.Size = New System.Drawing.Size(222, 247)
            Me.gaugeControl3.TabIndex = 6
            ' 
            ' circularGauge4
            ' 
            Me.circularGauge4.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent4})
            Me.circularGauge4.Bounds = New System.Drawing.Rectangle(6, 6, 210, 235)
            Me.circularGauge4.Name = "circularGauge4"
            Me.circularGauge4.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent4})
            Me.circularGauge4.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent4})
            Me.circularGauge4.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent4})
            ' 
            ' arcScaleBackgroundLayerComponent4
            ' 
            Me.arcScaleBackgroundLayerComponent4.ArcScale = Me.arcScaleComponent4
            Me.arcScaleBackgroundLayerComponent4.Name = "arcScaleBackgroundLayerComponent4"
            Me.arcScaleBackgroundLayerComponent4.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.6F)
            Me.arcScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style2
            Me.arcScaleBackgroundLayerComponent4.Size = New System.Drawing.SizeF(250F, 207F)
            Me.arcScaleBackgroundLayerComponent4.ZOrder = 1000
            ' 
            ' arcScaleComponent4
            ' 
            Me.arcScaleComponent4.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Arial Narrow", 11F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent4.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C0C0FF")
            Me.arcScaleComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent4.EndAngle = 30F
            Me.arcScaleComponent4.MajorTickCount = 7
            Me.arcScaleComponent4.MajorTickmark.AllowTickOverlap = True
            Me.arcScaleComponent4.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent4.MajorTickmark.ShapeOffset = -9F
            Me.arcScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style2_2
            Me.arcScaleComponent4.MajorTickmark.TextOffset = -22F
            Me.arcScaleComponent4.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent4.MaxValue = 180F
            Me.arcScaleComponent4.MinorTickCount = 4
            Me.arcScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style2_1
            Me.arcScaleComponent4.Name = "arcScaleComponent4"
            Me.arcScaleComponent4.RadiusX = 91F
            Me.arcScaleComponent4.RadiusY = 91F
            Me.arcScaleComponent4.StartAngle = -210F
            Me.arcScaleComponent4.Value = 40F
            ' 
            ' arcScaleNeedleComponent4
            ' 
            Me.arcScaleNeedleComponent4.ArcScale = Me.arcScaleComponent4
            Me.arcScaleNeedleComponent4.EndOffset = -6F
            Me.arcScaleNeedleComponent4.Name = "arcScaleNeedleComponent4"
            Me.arcScaleNeedleComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style2
            Me.arcScaleNeedleComponent4.StartOffset = 9F
            Me.arcScaleNeedleComponent4.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent4
            ' 
            Me.arcScaleSpindleCapComponent4.ArcScale = Me.arcScaleComponent4
            Me.arcScaleSpindleCapComponent4.Name = "arcScaleSpindleCapComponent4"
            Me.arcScaleSpindleCapComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style2
            Me.arcScaleSpindleCapComponent4.Size = New System.Drawing.SizeF(24F, 24F)
            Me.arcScaleSpindleCapComponent4.ZOrder = -100
            ' 
            ' gaugeControl2
            ' 
            Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge1})
            Me.gaugeControl2.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl2.Name = "gaugeControl2"
            Me.gaugeControl2.Size = New System.Drawing.Size(265, 219)
            Me.gaugeControl2.TabIndex = 5
            ' 
            ' digitalGauge1
            ' 
            Me.digitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FD4F2FF")
            Me.digitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#D4F2FF")
            Me.digitalGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent1})
            Me.digitalGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 253, 207)
            Me.digitalGauge1.DigitCount = 5
            Me.digitalGauge1.Name = "digitalGauge1"
            Me.digitalGauge1.Text = "00,000"
            ' 
            ' digitalBackgroundLayerComponent1
            ' 
            Me.digitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125F, 99.9625F)
            Me.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1"
            Me.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style2
            Me.digitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
            Me.digitalBackgroundLayerComponent1.ZOrder = 1000
            ' 
            ' gaugeControl1
            ' 
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(497, 2)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(223, 219)
            Me.gaugeControl1.TabIndex = 4
            ' 
            ' circularGauge1
            ' 
            Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent1})
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 211, 207)
            Me.circularGauge1.Name = "circularGauge1"
            Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent1})
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1})
            Me.circularGauge1.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent1})
            ' 
            ' arcScaleBackgroundLayerComponent1
            ' 
            Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleBackgroundLayerComponent1.Name = "arcScaleBackgroundLayerComponent1"
            Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style2
            Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
            ' 
            ' arcScaleComponent1
            ' 
            Me.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Arial Narrow", 11F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C0C0FF")
            Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent1.EndAngle = 30F
            Me.arcScaleComponent1.MajorTickCount = 10
            Me.arcScaleComponent1.MajorTickmark.AllowTickOverlap = True
            Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -9F
            Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style2_2
            Me.arcScaleComponent1.MajorTickmark.TextOffset = -22F
            Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent1.MaxValue = 180F
            Me.arcScaleComponent1.MinorTickCount = 4
            Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style2_1
            Me.arcScaleComponent1.Name = "arcScaleComponent1"
            Me.arcScaleComponent1.RadiusX = 91F
            Me.arcScaleComponent1.RadiusY = 91F
            Me.arcScaleComponent1.StartAngle = -240F
            ' 
            ' arcScaleNeedleComponent1
            ' 
            Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleNeedleComponent1.EndOffset = -6F
            Me.arcScaleNeedleComponent1.Name = "arcScaleNeedleComponent1"
            Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style2
            Me.arcScaleNeedleComponent1.StartOffset = 9F
            Me.arcScaleNeedleComponent1.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent1
            ' 
            Me.arcScaleSpindleCapComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleSpindleCapComponent1.Name = "arcScaleSpindleCapComponent1"
            Me.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style2
            Me.arcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(32F, 32F)
            Me.arcScaleSpindleCapComponent1.ZOrder = -100
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem4, Me.layoutControlItem3, Me.layoutControlItem6, Me.layoutControlItem1, Me.layoutControlItem5})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(722, 474)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.gaugeControl2
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(269, 223)
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.gaugeControl4
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 223)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(269, 251)
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.gaugeControl3
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(269, 223)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(226, 251)
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.gaugeControl6
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(495, 223)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(227, 251)
            Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gaugeControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(495, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(227, 223)
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.gaugeControl5
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(269, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(226, 223)
            Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' xtraTabPage2
            ' 
            Me.xtraTabPage2.Caption = "Deep Fire"
            Me.xtraTabPage2.Controls.Add(Me.layoutControl2)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            Me.xtraTabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.xtraTabPage2.Size = New System.Drawing.Size(719, 482)
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.Controls.Add(Me.gaugeControl7)
            Me.layoutControl2.Controls.Add(Me.gaugeControl8)
            Me.layoutControl2.Controls.Add(Me.gaugeControl9)
            Me.layoutControl2.Controls.Add(Me.gaugeControl10)
            Me.layoutControl2.Controls.Add(Me.gaugeControl11)
            Me.layoutControl2.Controls.Add(Me.gaugeControl12)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.Location = New System.Drawing.Point(3, 3)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.Root = Me.layoutControlGroup2
            Me.layoutControl2.Size = New System.Drawing.Size(713, 476)
            Me.layoutControl2.TabIndex = 4
            Me.layoutControl2.Text = "layoutControl2"
            ' 
            ' gaugeControl7
            ' 
            Me.gaugeControl7.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge2})
            Me.gaugeControl7.Location = New System.Drawing.Point(491, 226)
            Me.gaugeControl7.Name = "gaugeControl7"
            Me.gaugeControl7.Size = New System.Drawing.Size(220, 248)
            Me.gaugeControl7.TabIndex = 9
            ' 
            ' linearGauge2
            ' 
            Me.linearGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent2})
            Me.linearGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 208, 236)
            Me.linearGauge2.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent2})
            Me.linearGauge2.Name = "linearGauge2"
            Me.linearGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent3, Me.linearScaleComponent4})
            ' 
            ' linearScaleBackgroundLayerComponent2
            ' 
            Me.linearScaleBackgroundLayerComponent2.LinearScale = Me.linearScaleComponent3
            Me.linearScaleBackgroundLayerComponent2.Name = "linearScaleBackgroundLayerComponent1"
            Me.linearScaleBackgroundLayerComponent2.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.495F, 0.15F)
            Me.linearScaleBackgroundLayerComponent2.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.495F, 0.845F)
            Me.linearScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style3
            Me.linearScaleBackgroundLayerComponent2.ZOrder = 1000
            ' 
            ' linearScaleComponent3
            ' 
            Me.linearScaleComponent3.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent3.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent3.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent3.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent3.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.linearScaleComponent3.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C04000")
            Me.linearScaleComponent3.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 37F)
            Me.linearScaleComponent3.MajorTickCount = 6
            Me.linearScaleComponent3.MajorTickmark.AllowTickOverlap = True
            Me.linearScaleComponent3.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent3.MajorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_2
            Me.linearScaleComponent3.MajorTickmark.TextOffset = 27F
            Me.linearScaleComponent3.MaxValue = 500F
            Me.linearScaleComponent3.MinorTickCount = 4
            Me.linearScaleComponent3.MinorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_1
            Me.linearScaleComponent3.Name = "linearScaleComponent1"
            Me.linearScaleComponent3.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 213F)
            Me.linearScaleComponent3.Value = 250F
            ' 
            ' linearScaleLevelComponent2
            ' 
            Me.linearScaleLevelComponent2.LinearScale = Me.linearScaleComponent3
            Me.linearScaleLevelComponent2.Name = "linearScaleLevelComponent1"
            Me.linearScaleLevelComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style3
            Me.linearScaleLevelComponent2.ZOrder = -50
            ' 
            ' linearScaleComponent4
            ' 
            Me.linearScaleComponent4.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent4.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent4.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent4.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent4.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 9F)
            Me.linearScaleComponent4.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C04000")
            Me.linearScaleComponent4.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 37F)
            Me.linearScaleComponent4.MajorTickCount = 6
            Me.linearScaleComponent4.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent4.MajorTickmark.ShapeOffset = -13F
            Me.linearScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style3_1
            Me.linearScaleComponent4.MaxValue = 50F
            Me.linearScaleComponent4.MinorTickCount = 4
            Me.linearScaleComponent4.MinorTickmark.ShapeOffset = -9F
            Me.linearScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style3_2
            Me.linearScaleComponent4.Name = "linearScaleComponent10"
            Me.linearScaleComponent4.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 213F)
            ' 
            ' gaugeControl8
            ' 
            Me.gaugeControl8.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge5})
            Me.gaugeControl8.Location = New System.Drawing.Point(268, 2)
            Me.gaugeControl8.Name = "gaugeControl8"
            Me.gaugeControl8.Size = New System.Drawing.Size(219, 220)
            Me.gaugeControl8.TabIndex = 8
            ' 
            ' circularGauge5
            ' 
            Me.circularGauge5.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent5})
            Me.circularGauge5.Bounds = New System.Drawing.Rectangle(6, 6, 207, 208)
            Me.circularGauge5.Name = "circularGauge5"
            Me.circularGauge5.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent5})
            Me.circularGauge5.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent5})
            Me.circularGauge5.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent5})
            ' 
            ' arcScaleBackgroundLayerComponent5
            ' 
            Me.arcScaleBackgroundLayerComponent5.ArcScale = Me.arcScaleComponent5
            Me.arcScaleBackgroundLayerComponent5.Name = "arcScaleBackgroundLayerComponent5"
            Me.arcScaleBackgroundLayerComponent5.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.815F)
            Me.arcScaleBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style3
            Me.arcScaleBackgroundLayerComponent5.Size = New System.Drawing.SizeF(244F, 152F)
            Me.arcScaleBackgroundLayerComponent5.ZOrder = 1000
            ' 
            ' arcScaleComponent5
            ' 
            Me.arcScaleComponent5.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent5.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF8000")
            Me.arcScaleComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent5.EndAngle = 0F
            Me.arcScaleComponent5.MajorTickCount = 7
            Me.arcScaleComponent5.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent5.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_4
            Me.arcScaleComponent5.MajorTickmark.TextOffset = -18F
            Me.arcScaleComponent5.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent5.MaxValue = 80F
            Me.arcScaleComponent5.MinorTickCount = 4
            Me.arcScaleComponent5.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_3
            Me.arcScaleComponent5.MinValue = 20F
            Me.arcScaleComponent5.Name = "arcScaleComponent5"
            Me.arcScaleComponent5.RadiusX = 104F
            Me.arcScaleComponent5.RadiusY = 104F
            Me.arcScaleComponent5.StartAngle = -180F
            Me.arcScaleComponent5.Value = 20F
            ' 
            ' arcScaleNeedleComponent5
            ' 
            Me.arcScaleNeedleComponent5.ArcScale = Me.arcScaleComponent5
            Me.arcScaleNeedleComponent5.EndOffset = -8F
            Me.arcScaleNeedleComponent5.Name = "arcScaleNeedleComponent5"
            Me.arcScaleNeedleComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style3
            Me.arcScaleNeedleComponent5.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent5
            ' 
            Me.arcScaleSpindleCapComponent5.ArcScale = Me.arcScaleComponent5
            Me.arcScaleSpindleCapComponent5.Name = "arcScaleSpindleCapComponent5"
            Me.arcScaleSpindleCapComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style3
            Me.arcScaleSpindleCapComponent5.ZOrder = -100
            ' 
            ' gaugeControl9
            ' 
            Me.gaugeControl9.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge6})
            Me.gaugeControl9.Location = New System.Drawing.Point(2, 226)
            Me.gaugeControl9.Name = "gaugeControl9"
            Me.gaugeControl9.Size = New System.Drawing.Size(262, 248)
            Me.gaugeControl9.TabIndex = 7
            ' 
            ' circularGauge6
            ' 
            Me.circularGauge6.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent6})
            Me.circularGauge6.Bounds = New System.Drawing.Rectangle(6, 6, 250, 236)
            Me.circularGauge6.Name = "circularGauge6"
            Me.circularGauge6.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent6})
            Me.circularGauge6.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent6, Me.arcScaleComponent34})
            Me.circularGauge6.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent6})
            ' 
            ' arcScaleBackgroundLayerComponent6
            ' 
            Me.arcScaleBackgroundLayerComponent6.ArcScale = Me.arcScaleComponent6
            Me.arcScaleBackgroundLayerComponent6.Name = "arcScaleBackgroundLayerComponent6"
            Me.arcScaleBackgroundLayerComponent6.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.82F, 0.82F)
            Me.arcScaleBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style3Left
            Me.arcScaleBackgroundLayerComponent6.ZOrder = 1000
            ' 
            ' arcScaleComponent6
            ' 
            Me.arcScaleComponent6.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 24F)
            Me.arcScaleComponent6.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF8000")
            Me.arcScaleComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(205F, 205F)
            Me.arcScaleComponent6.EndAngle = -90F
            Me.arcScaleComponent6.MajorTickCount = 4
            Me.arcScaleComponent6.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent6.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.5F, 1.5F)
            Me.arcScaleComponent6.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_4
            Me.arcScaleComponent6.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent6.MaxValue = 50F
            Me.arcScaleComponent6.MinorTickCount = 4
            Me.arcScaleComponent6.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_3
            Me.arcScaleComponent6.MinValue = 20F
            Me.arcScaleComponent6.Name = "arcScaleComponent6"
            Me.arcScaleComponent6.RadiusX = 175F
            Me.arcScaleComponent6.RadiusY = 175F
            Me.arcScaleComponent6.StartAngle = -180F
            Me.arcScaleComponent6.Value = 30F
            ' 
            ' arcScaleNeedleComponent6
            ' 
            Me.arcScaleNeedleComponent6.ArcScale = Me.arcScaleComponent6
            Me.arcScaleNeedleComponent6.EndOffset = -8F
            Me.arcScaleNeedleComponent6.Name = "arcScaleNeedleComponent6"
            Me.arcScaleNeedleComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style3
            Me.arcScaleNeedleComponent6.ZOrder = -50
            ' 
            ' arcScaleComponent34
            ' 
            Me.arcScaleComponent34.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent34.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent34.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent34.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent34.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 12F)
            Me.arcScaleComponent34.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C04000")
            Me.arcScaleComponent34.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(205F, 205F)
            Me.arcScaleComponent34.EndAngle = -90F
            Me.arcScaleComponent34.MajorTickCount = 4
            Me.arcScaleComponent34.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent34.MajorTickmark.ShapeOffset = -4F
            Me.arcScaleComponent34.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_2
            Me.arcScaleComponent34.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent34.MaxValue = 500F
            Me.arcScaleComponent34.MinorTickCount = 4
            Me.arcScaleComponent34.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_1
            Me.arcScaleComponent34.MinValue = 200F
            Me.arcScaleComponent34.Name = "arcScaleComponent34"
            Me.arcScaleComponent34.StartAngle = -180F
            Me.arcScaleComponent34.Value = 200F
            ' 
            ' arcScaleSpindleCapComponent6
            ' 
            Me.arcScaleSpindleCapComponent6.ArcScale = Me.arcScaleComponent6
            Me.arcScaleSpindleCapComponent6.Name = "arcScaleSpindleCapComponent6"
            Me.arcScaleSpindleCapComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style3
            Me.arcScaleSpindleCapComponent6.Size = New System.Drawing.SizeF(60F, 60F)
            Me.arcScaleSpindleCapComponent6.ZOrder = -100
            ' 
            ' gaugeControl10
            ' 
            Me.gaugeControl10.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge7})
            Me.gaugeControl10.Location = New System.Drawing.Point(268, 226)
            Me.gaugeControl10.Name = "gaugeControl10"
            Me.gaugeControl10.Size = New System.Drawing.Size(219, 248)
            Me.gaugeControl10.TabIndex = 6
            ' 
            ' circularGauge7
            ' 
            Me.circularGauge7.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent7})
            Me.circularGauge7.Bounds = New System.Drawing.Rectangle(6, 6, 207, 236)
            Me.circularGauge7.Name = "circularGauge7"
            Me.circularGauge7.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent7})
            Me.circularGauge7.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent7})
            Me.circularGauge7.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent7})
            ' 
            ' arcScaleBackgroundLayerComponent7
            ' 
            Me.arcScaleBackgroundLayerComponent7.ArcScale = Me.arcScaleComponent7
            Me.arcScaleBackgroundLayerComponent7.Name = "arcScaleBackgroundLayerComponent7"
            Me.arcScaleBackgroundLayerComponent7.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.615F)
            Me.arcScaleBackgroundLayerComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style3
            Me.arcScaleBackgroundLayerComponent7.Size = New System.Drawing.SizeF(250F, 204F)
            Me.arcScaleBackgroundLayerComponent7.ZOrder = 1000
            ' 
            ' arcScaleComponent7
            ' 
            Me.arcScaleComponent7.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent7.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF8000")
            Me.arcScaleComponent7.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent7.EndAngle = 30F
            Me.arcScaleComponent7.MajorTickCount = 9
            Me.arcScaleComponent7.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent7.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_4
            Me.arcScaleComponent7.MajorTickmark.TextOffset = -18F
            Me.arcScaleComponent7.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent7.MaxValue = 240F
            Me.arcScaleComponent7.MinorTickCount = 4
            Me.arcScaleComponent7.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_3
            Me.arcScaleComponent7.Name = "arcScaleComponent7"
            Me.arcScaleComponent7.RadiusX = 106F
            Me.arcScaleComponent7.RadiusY = 106F
            Me.arcScaleComponent7.StartAngle = -210F
            Me.arcScaleComponent7.Value = 20F
            ' 
            ' arcScaleNeedleComponent7
            ' 
            Me.arcScaleNeedleComponent7.ArcScale = Me.arcScaleComponent7
            Me.arcScaleNeedleComponent7.EndOffset = -8F
            Me.arcScaleNeedleComponent7.Name = "arcScaleNeedleComponent7"
            Me.arcScaleNeedleComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style3
            Me.arcScaleNeedleComponent7.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent7
            ' 
            Me.arcScaleSpindleCapComponent7.ArcScale = Me.arcScaleComponent7
            Me.arcScaleSpindleCapComponent7.Name = "arcScaleSpindleCapComponent7"
            Me.arcScaleSpindleCapComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style3
            Me.arcScaleSpindleCapComponent7.ZOrder = -100
            ' 
            ' gaugeControl11
            ' 
            Me.gaugeControl11.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge2})
            Me.gaugeControl11.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl11.Name = "gaugeControl11"
            Me.gaugeControl11.Size = New System.Drawing.Size(262, 220)
            Me.gaugeControl11.TabIndex = 5
            ' 
            ' digitalGauge2
            ' 
            Me.digitalGauge2.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FFF5000")
            Me.digitalGauge2.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF5000")
            Me.digitalGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent2})
            Me.digitalGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 250, 208)
            Me.digitalGauge2.DigitCount = 5
            Me.digitalGauge2.Name = "digitalGauge2"
            Me.digitalGauge2.Text = "00,000"
            ' 
            ' digitalBackgroundLayerComponent2
            ' 
            Me.digitalBackgroundLayerComponent2.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125F, 99.9625F)
            Me.digitalBackgroundLayerComponent2.Name = "digitalBackgroundLayerComponent2"
            Me.digitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style3
            Me.digitalBackgroundLayerComponent2.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
            Me.digitalBackgroundLayerComponent2.ZOrder = 1000
            ' 
            ' gaugeControl12
            ' 
            Me.gaugeControl12.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge8})
            Me.gaugeControl12.Location = New System.Drawing.Point(491, 2)
            Me.gaugeControl12.Name = "gaugeControl12"
            Me.gaugeControl12.Size = New System.Drawing.Size(220, 220)
            Me.gaugeControl12.TabIndex = 4
            ' 
            ' circularGauge8
            ' 
            Me.circularGauge8.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent8})
            Me.circularGauge8.Bounds = New System.Drawing.Rectangle(6, 6, 208, 208)
            Me.circularGauge8.Name = "circularGauge8"
            Me.circularGauge8.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent8})
            Me.circularGauge8.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent8, Me.arcScaleComponent33})
            Me.circularGauge8.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent8})
            ' 
            ' arcScaleBackgroundLayerComponent8
            ' 
            Me.arcScaleBackgroundLayerComponent8.ArcScale = Me.arcScaleComponent8
            Me.arcScaleBackgroundLayerComponent8.Name = "arcScaleBackgroundLayerComponent8"
            Me.arcScaleBackgroundLayerComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style3
            Me.arcScaleBackgroundLayerComponent8.ZOrder = 1000
            ' 
            ' arcScaleComponent8
            ' 
            Me.arcScaleComponent8.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent8.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF8000")
            Me.arcScaleComponent8.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent8.EndAngle = 60F
            Me.arcScaleComponent8.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent8.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_4
            Me.arcScaleComponent8.MajorTickmark.TextOffset = -18F
            Me.arcScaleComponent8.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent8.MaxValue = 100F
            Me.arcScaleComponent8.MinorTickCount = 4
            Me.arcScaleComponent8.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_3
            Me.arcScaleComponent8.Name = "arcScaleComponent8"
            Me.arcScaleComponent8.RadiusX = 106F
            Me.arcScaleComponent8.RadiusY = 106F
            Me.arcScaleComponent8.StartAngle = -240F
            ' 
            ' arcScaleNeedleComponent8
            ' 
            Me.arcScaleNeedleComponent8.ArcScale = Me.arcScaleComponent8
            Me.arcScaleNeedleComponent8.EndOffset = -8F
            Me.arcScaleNeedleComponent8.Name = "arcScaleNeedleComponent8"
            Me.arcScaleNeedleComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style3
            Me.arcScaleNeedleComponent8.ZOrder = -50
            ' 
            ' arcScaleComponent33
            ' 
            Me.arcScaleComponent33.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent33.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent33.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent33.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent33.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            Me.arcScaleComponent33.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF8000")
            Me.arcScaleComponent33.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent33.EndAngle = -30F
            Me.arcScaleComponent33.MajorTickCount = 8
            Me.arcScaleComponent33.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent33.MajorTickmark.ShapeOffset = -4F
            Me.arcScaleComponent33.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_2
            Me.arcScaleComponent33.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent33.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent33.MaxValue = 700F
            Me.arcScaleComponent33.MinorTickCount = 4
            Me.arcScaleComponent33.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style3_1
            Me.arcScaleComponent33.Name = "arcScaleComponent33"
            Me.arcScaleComponent33.RadiusX = 60F
            Me.arcScaleComponent33.RadiusY = 60F
            Me.arcScaleComponent33.StartAngle = -240F
            ' 
            ' arcScaleSpindleCapComponent8
            ' 
            Me.arcScaleSpindleCapComponent8.ArcScale = Me.arcScaleComponent8
            Me.arcScaleSpindleCapComponent8.Name = "arcScaleSpindleCapComponent8"
            Me.arcScaleSpindleCapComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style3
            Me.arcScaleSpindleCapComponent8.ZOrder = -100
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.AllowDrawBackground = False
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9, Me.layoutControlItem10, Me.layoutControlItem11, Me.layoutControlItem12})
            Me.layoutControlGroup2.Name = "layoutControlGroup1"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(713, 476)
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.gaugeControl11
            Me.layoutControlItem7.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "layoutControlItem2"
            Me.layoutControlItem7.Size = New System.Drawing.Size(266, 224)
            Me.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.gaugeControl9
            Me.layoutControlItem8.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 224)
            Me.layoutControlItem8.Name = "layoutControlItem4"
            Me.layoutControlItem8.Size = New System.Drawing.Size(266, 252)
            Me.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.gaugeControl10
            Me.layoutControlItem9.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem9.Location = New System.Drawing.Point(266, 224)
            Me.layoutControlItem9.Name = "layoutControlItem3"
            Me.layoutControlItem9.Size = New System.Drawing.Size(223, 252)
            Me.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.gaugeControl7
            Me.layoutControlItem10.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem10.Location = New System.Drawing.Point(489, 224)
            Me.layoutControlItem10.Name = "layoutControlItem6"
            Me.layoutControlItem10.Size = New System.Drawing.Size(224, 252)
            Me.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.gaugeControl12
            Me.layoutControlItem11.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem11.Location = New System.Drawing.Point(489, 0)
            Me.layoutControlItem11.Name = "layoutControlItem1"
            Me.layoutControlItem11.Size = New System.Drawing.Size(224, 224)
            Me.layoutControlItem11.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.gaugeControl8
            Me.layoutControlItem12.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem12.Location = New System.Drawing.Point(266, 0)
            Me.layoutControlItem12.Name = "layoutControlItem5"
            Me.layoutControlItem12.Size = New System.Drawing.Size(223, 224)
            Me.layoutControlItem12.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem12.TextVisible = False
            ' 
            ' xtraTabPage3
            ' 
            Me.xtraTabPage3.Caption = "Ice-Cold Zone"
            Me.xtraTabPage3.Controls.Add(Me.layoutControl3)
            Me.xtraTabPage3.Name = "xtraTabPage3"
            Me.xtraTabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.xtraTabPage3.Size = New System.Drawing.Size(719, 482)
            ' 
            ' layoutControl3
            ' 
            Me.layoutControl3.Controls.Add(Me.gaugeControl13)
            Me.layoutControl3.Controls.Add(Me.gaugeControl14)
            Me.layoutControl3.Controls.Add(Me.gaugeControl15)
            Me.layoutControl3.Controls.Add(Me.gaugeControl16)
            Me.layoutControl3.Controls.Add(Me.gaugeControl17)
            Me.layoutControl3.Controls.Add(Me.gaugeControl18)
            Me.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl3.Location = New System.Drawing.Point(3, 3)
            Me.layoutControl3.Name = "layoutControl3"
            Me.layoutControl3.Root = Me.layoutControlGroup3
            Me.layoutControl3.Size = New System.Drawing.Size(713, 476)
            Me.layoutControl3.TabIndex = 3
            Me.layoutControl3.Text = "layoutControl3"
            ' 
            ' gaugeControl13
            ' 
            Me.gaugeControl13.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge3})
            Me.gaugeControl13.Location = New System.Drawing.Point(491, 226)
            Me.gaugeControl13.Name = "gaugeControl13"
            Me.gaugeControl13.Size = New System.Drawing.Size(220, 248)
            Me.gaugeControl13.TabIndex = 9
            ' 
            ' linearGauge3
            ' 
            Me.linearGauge3.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent3})
            Me.linearGauge3.Bounds = New System.Drawing.Rectangle(6, 6, 208, 236)
            Me.linearGauge3.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent3})
            Me.linearGauge3.Name = "linearGauge3"
            Me.linearGauge3.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent5, Me.linearScaleComponent6})
            ' 
            ' linearScaleBackgroundLayerComponent3
            ' 
            Me.linearScaleBackgroundLayerComponent3.LinearScale = Me.linearScaleComponent5
            Me.linearScaleBackgroundLayerComponent3.Name = "linearScaleBackgroundLayerComponent3"
            Me.linearScaleBackgroundLayerComponent3.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.15F)
            Me.linearScaleBackgroundLayerComponent3.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F)
            Me.linearScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style4
            Me.linearScaleBackgroundLayerComponent3.ZOrder = 1000
            ' 
            ' linearScaleComponent5
            ' 
            Me.linearScaleComponent5.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent5.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent5.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent5.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent5.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.linearScaleComponent5.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent5.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 37F)
            Me.linearScaleComponent5.MajorTickCount = 6
            Me.linearScaleComponent5.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent5.MajorTickmark.ShapeOffset = 5F
            Me.linearScaleComponent5.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style4_2
            Me.linearScaleComponent5.MajorTickmark.TextOffset = 31F
            Me.linearScaleComponent5.MaxValue = 500F
            Me.linearScaleComponent5.MinorTickCount = 4
            Me.linearScaleComponent5.MinorTickmark.ShapeOffset = 5F
            Me.linearScaleComponent5.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style4_1
            Me.linearScaleComponent5.Name = "linearScaleComponent3"
            Me.linearScaleComponent5.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 213F)
            Me.linearScaleComponent5.Value = 250F
            ' 
            ' linearScaleLevelComponent3
            ' 
            Me.linearScaleLevelComponent3.LinearScale = Me.linearScaleComponent5
            Me.linearScaleLevelComponent3.Name = "linearScaleLevelComponent3"
            Me.linearScaleLevelComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style4
            Me.linearScaleLevelComponent3.ZOrder = -50
            ' 
            ' linearScaleComponent6
            ' 
            Me.linearScaleComponent6.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent6.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent6.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent6.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent6.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent6.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 37F)
            Me.linearScaleComponent6.MajorTickCount = 6
            Me.linearScaleComponent6.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent6.MajorTickmark.ShapeOffset = -17F
            Me.linearScaleComponent6.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style4_2
            Me.linearScaleComponent6.MajorTickmark.TextOffset = -30F
            Me.linearScaleComponent6.MaxValue = 50F
            Me.linearScaleComponent6.MinorTickCount = 4
            Me.linearScaleComponent6.MinorTickmark.ShapeOffset = -11F
            Me.linearScaleComponent6.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style4_1
            Me.linearScaleComponent6.Name = "linearScaleComponent11"
            Me.linearScaleComponent6.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 213F)
            ' 
            ' gaugeControl14
            ' 
            Me.gaugeControl14.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge9})
            Me.gaugeControl14.Location = New System.Drawing.Point(268, 2)
            Me.gaugeControl14.Name = "gaugeControl14"
            Me.gaugeControl14.Size = New System.Drawing.Size(219, 220)
            Me.gaugeControl14.TabIndex = 8
            ' 
            ' circularGauge9
            ' 
            Me.circularGauge9.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent9})
            Me.circularGauge9.Bounds = New System.Drawing.Rectangle(6, 6, 207, 208)
            Me.circularGauge9.Name = "circularGauge9"
            Me.circularGauge9.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent9})
            Me.circularGauge9.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent9, Me.arcScaleComponent35})
            Me.circularGauge9.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent9})
            ' 
            ' arcScaleBackgroundLayerComponent9
            ' 
            Me.arcScaleBackgroundLayerComponent9.ArcScale = Me.arcScaleComponent9
            Me.arcScaleBackgroundLayerComponent9.Name = "arcScaleBackgroundLayerComponent9"
            Me.arcScaleBackgroundLayerComponent9.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.71F)
            Me.arcScaleBackgroundLayerComponent9.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style4
            Me.arcScaleBackgroundLayerComponent9.Size = New System.Drawing.SizeF(250F, 176F)
            Me.arcScaleBackgroundLayerComponent9.ZOrder = 1000
            ' 
            ' arcScaleComponent9
            ' 
            Me.arcScaleComponent9.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent9.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent9.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent9.EndAngle = 0F
            Me.arcScaleComponent9.MajorTickCount = 7
            Me.arcScaleComponent9.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent9.MajorTickmark.ShapeOffset = -14F
            Me.arcScaleComponent9.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F)
            Me.arcScaleComponent9.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_2
            Me.arcScaleComponent9.MajorTickmark.TextOffset = -27F
            Me.arcScaleComponent9.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent9.MaxValue = 80F
            Me.arcScaleComponent9.MinorTickCount = 4
            Me.arcScaleComponent9.MinorTickmark.ShapeOffset = -7F
            Me.arcScaleComponent9.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F)
            Me.arcScaleComponent9.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_1
            Me.arcScaleComponent9.MinValue = 20F
            Me.arcScaleComponent9.Name = "arcScaleComponent9"
            Me.arcScaleComponent9.RadiusX = 123F
            Me.arcScaleComponent9.RadiusY = 123F
            Me.arcScaleComponent9.StartAngle = -180F
            Me.arcScaleComponent9.Value = 20F
            ' 
            ' arcScaleNeedleComponent9
            ' 
            Me.arcScaleNeedleComponent9.ArcScale = Me.arcScaleComponent9
            Me.arcScaleNeedleComponent9.EndOffset = 5F
            Me.arcScaleNeedleComponent9.Name = "arcScaleNeedleComponent9"
            Me.arcScaleNeedleComponent9.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style4
            Me.arcScaleNeedleComponent9.StartOffset = -21F
            Me.arcScaleNeedleComponent9.ZOrder = -50
            ' 
            ' arcScaleComponent35
            ' 
            Me.arcScaleComponent35.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent35.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent35.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent35.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent35.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent35.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:LightBlue")
            Me.arcScaleComponent35.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent35.EndAngle = -30F
            Me.arcScaleComponent35.MajorTickCount = 6
            Me.arcScaleComponent35.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent35.MajorTickmark.ShapeOffset = -6F
            Me.arcScaleComponent35.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_3
            Me.arcScaleComponent35.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent35.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent35.MaxValue = 700F
            Me.arcScaleComponent35.MinorTickCount = 4
            Me.arcScaleComponent35.MinorTickmark.ShapeOffset = -1.5F
            Me.arcScaleComponent35.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_4
            Me.arcScaleComponent35.MinValue = 200F
            Me.arcScaleComponent35.Name = "arcScaleComponent35"
            Me.arcScaleComponent35.RadiusX = 70F
            Me.arcScaleComponent35.RadiusY = 70F
            Me.arcScaleComponent35.StartAngle = -180F
            Me.arcScaleComponent35.Value = 200F
            ' 
            ' arcScaleSpindleCapComponent9
            ' 
            Me.arcScaleSpindleCapComponent9.ArcScale = Me.arcScaleComponent9
            Me.arcScaleSpindleCapComponent9.Name = "arcScaleSpindleCapComponent9"
            Me.arcScaleSpindleCapComponent9.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style4
            Me.arcScaleSpindleCapComponent9.Size = New System.Drawing.SizeF(16F, 16F)
            Me.arcScaleSpindleCapComponent9.ZOrder = -100
            ' 
            ' gaugeControl15
            ' 
            Me.gaugeControl15.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge10})
            Me.gaugeControl15.Location = New System.Drawing.Point(2, 226)
            Me.gaugeControl15.Name = "gaugeControl15"
            Me.gaugeControl15.Size = New System.Drawing.Size(262, 248)
            Me.gaugeControl15.TabIndex = 7
            ' 
            ' circularGauge10
            ' 
            Me.circularGauge10.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent10})
            Me.circularGauge10.Bounds = New System.Drawing.Rectangle(6, 6, 250, 236)
            Me.circularGauge10.Name = "circularGauge10"
            Me.circularGauge10.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent10})
            Me.circularGauge10.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent10, Me.arcScaleComponent37})
            Me.circularGauge10.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent10})
            ' 
            ' arcScaleBackgroundLayerComponent10
            ' 
            Me.arcScaleBackgroundLayerComponent10.ArcScale = Me.arcScaleComponent10
            Me.arcScaleBackgroundLayerComponent10.Name = "arcScaleBackgroundLayerComponent10"
            Me.arcScaleBackgroundLayerComponent10.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.8F, 0.8F)
            Me.arcScaleBackgroundLayerComponent10.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style4Left
            Me.arcScaleBackgroundLayerComponent10.ZOrder = 1000
            ' 
            ' arcScaleComponent10
            ' 
            Me.arcScaleComponent10.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 20F)
            Me.arcScaleComponent10.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent10.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(200F, 200F)
            Me.arcScaleComponent10.EndAngle = -90F
            Me.arcScaleComponent10.MajorTickCount = 4
            Me.arcScaleComponent10.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent10.MajorTickmark.ShapeOffset = -23F
            Me.arcScaleComponent10.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.1F, 1.6F)
            Me.arcScaleComponent10.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_2
            Me.arcScaleComponent10.MajorTickmark.TextOffset = -42F
            Me.arcScaleComponent10.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent10.MaxValue = 50F
            Me.arcScaleComponent10.MinorTickCount = 4
            Me.arcScaleComponent10.MinorTickmark.ShapeOffset = -9F
            Me.arcScaleComponent10.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_1
            Me.arcScaleComponent10.MinValue = 20F
            Me.arcScaleComponent10.Name = "arcScaleComponent10"
            Me.arcScaleComponent10.RadiusX = 195F
            Me.arcScaleComponent10.RadiusY = 195F
            Me.arcScaleComponent10.StartAngle = -180F
            Me.arcScaleComponent10.Value = 30F
            ' 
            ' arcScaleNeedleComponent10
            ' 
            Me.arcScaleNeedleComponent10.ArcScale = Me.arcScaleComponent10
            Me.arcScaleNeedleComponent10.EndOffset = 5F
            Me.arcScaleNeedleComponent10.Name = "arcScaleNeedleComponent10"
            Me.arcScaleNeedleComponent10.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style4
            Me.arcScaleNeedleComponent10.StartOffset = -34F
            Me.arcScaleNeedleComponent10.ZOrder = -50
            ' 
            ' arcScaleComponent37
            ' 
            Me.arcScaleComponent37.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent37.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent37.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent37.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent37.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 10F)
            Me.arcScaleComponent37.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:LightBlue")
            Me.arcScaleComponent37.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(200F, 200F)
            Me.arcScaleComponent37.EndAngle = -90F
            Me.arcScaleComponent37.MajorTickCount = 4
            Me.arcScaleComponent37.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent37.MajorTickmark.ShapeOffset = -7F
            Me.arcScaleComponent37.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(2F, 2F)
            Me.arcScaleComponent37.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_3
            Me.arcScaleComponent37.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent37.MaxValue = 500F
            Me.arcScaleComponent37.MinorTickCount = 4
            Me.arcScaleComponent37.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(2F, 2F)
            Me.arcScaleComponent37.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_4
            Me.arcScaleComponent37.MinValue = 200F
            Me.arcScaleComponent37.Name = "arcScaleComponent37"
            Me.arcScaleComponent37.StartAngle = -180F
            Me.arcScaleComponent37.Value = 200F
            ' 
            ' arcScaleSpindleCapComponent10
            ' 
            Me.arcScaleSpindleCapComponent10.ArcScale = Me.arcScaleComponent10
            Me.arcScaleSpindleCapComponent10.Name = "arcScaleSpindleCapComponent10"
            Me.arcScaleSpindleCapComponent10.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style4
            Me.arcScaleSpindleCapComponent10.Size = New System.Drawing.SizeF(32F, 32F)
            Me.arcScaleSpindleCapComponent10.ZOrder = -100
            ' 
            ' gaugeControl16
            ' 
            Me.gaugeControl16.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge11})
            Me.gaugeControl16.Location = New System.Drawing.Point(268, 226)
            Me.gaugeControl16.Name = "gaugeControl16"
            Me.gaugeControl16.Size = New System.Drawing.Size(219, 248)
            Me.gaugeControl16.TabIndex = 6
            ' 
            ' circularGauge11
            ' 
            Me.circularGauge11.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent11})
            Me.circularGauge11.Bounds = New System.Drawing.Rectangle(6, 6, 207, 236)
            Me.circularGauge11.Name = "circularGauge11"
            Me.circularGauge11.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent11})
            Me.circularGauge11.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent11, Me.arcScaleComponent38})
            Me.circularGauge11.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent11})
            ' 
            ' arcScaleBackgroundLayerComponent11
            ' 
            Me.arcScaleBackgroundLayerComponent11.ArcScale = Me.arcScaleComponent11
            Me.arcScaleBackgroundLayerComponent11.Name = "arcScaleBackgroundLayerComponent11"
            Me.arcScaleBackgroundLayerComponent11.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.575F)
            Me.arcScaleBackgroundLayerComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style4
            Me.arcScaleBackgroundLayerComponent11.Size = New System.Drawing.SizeF(250F, 218F)
            Me.arcScaleBackgroundLayerComponent11.ZOrder = 1000
            ' 
            ' arcScaleComponent11
            ' 
            Me.arcScaleComponent11.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent11.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent11.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent11.EndAngle = 30F
            Me.arcScaleComponent11.MajorTickCount = 9
            Me.arcScaleComponent11.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent11.MajorTickmark.ShapeOffset = -14F
            Me.arcScaleComponent11.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F)
            Me.arcScaleComponent11.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_2
            Me.arcScaleComponent11.MajorTickmark.TextOffset = -27F
            Me.arcScaleComponent11.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent11.MaxValue = 200F
            Me.arcScaleComponent11.MinorTickCount = 4
            Me.arcScaleComponent11.MinorTickmark.ShapeOffset = -7F
            Me.arcScaleComponent11.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F)
            Me.arcScaleComponent11.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_1
            Me.arcScaleComponent11.Name = "arcScaleComponent11"
            Me.arcScaleComponent11.RadiusX = 123.5F
            Me.arcScaleComponent11.RadiusY = 123.5F
            Me.arcScaleComponent11.StartAngle = -210F
            Me.arcScaleComponent11.Value = 20F
            ' 
            ' arcScaleNeedleComponent11
            ' 
            Me.arcScaleNeedleComponent11.ArcScale = Me.arcScaleComponent11
            Me.arcScaleNeedleComponent11.EndOffset = 5F
            Me.arcScaleNeedleComponent11.Name = "arcScaleNeedleComponent11"
            Me.arcScaleNeedleComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style4
            Me.arcScaleNeedleComponent11.StartOffset = -21F
            Me.arcScaleNeedleComponent11.ZOrder = -50
            ' 
            ' arcScaleComponent38
            ' 
            Me.arcScaleComponent38.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent38.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent38.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent38.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent38.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent38.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:LightBlue")
            Me.arcScaleComponent38.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent38.EndAngle = -30F
            Me.arcScaleComponent38.MajorTickCount = 6
            Me.arcScaleComponent38.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent38.MajorTickmark.ShapeOffset = -6F
            Me.arcScaleComponent38.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_3
            Me.arcScaleComponent38.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent38.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent38.MaxValue = 700F
            Me.arcScaleComponent38.MinorTickCount = 4
            Me.arcScaleComponent38.MinorTickmark.ShapeOffset = -1.5F
            Me.arcScaleComponent38.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_4
            Me.arcScaleComponent38.MinValue = 200F
            Me.arcScaleComponent38.Name = "arcScaleComponent38"
            Me.arcScaleComponent38.RadiusX = 70F
            Me.arcScaleComponent38.RadiusY = 70F
            Me.arcScaleComponent38.StartAngle = -210F
            Me.arcScaleComponent38.Value = 200F
            ' 
            ' arcScaleSpindleCapComponent11
            ' 
            Me.arcScaleSpindleCapComponent11.ArcScale = Me.arcScaleComponent11
            Me.arcScaleSpindleCapComponent11.Name = "arcScaleSpindleCapComponent11"
            Me.arcScaleSpindleCapComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style4
            Me.arcScaleSpindleCapComponent11.Size = New System.Drawing.SizeF(16F, 16F)
            Me.arcScaleSpindleCapComponent11.ZOrder = -100
            ' 
            ' gaugeControl17
            ' 
            Me.gaugeControl17.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge3})
            Me.gaugeControl17.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl17.Name = "gaugeControl17"
            Me.gaugeControl17.Size = New System.Drawing.Size(262, 220)
            Me.gaugeControl17.TabIndex = 5
            ' 
            ' digitalGauge3
            ' 
            Me.digitalGauge3.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#34000000")
            Me.digitalGauge3.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.digitalGauge3.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent3})
            Me.digitalGauge3.Bounds = New System.Drawing.Rectangle(6, 6, 250, 208)
            Me.digitalGauge3.DigitCount = 5
            Me.digitalGauge3.Name = "digitalGauge3"
            Me.digitalGauge3.Text = "00,000"
            ' 
            ' digitalBackgroundLayerComponent3
            ' 
            Me.digitalBackgroundLayerComponent3.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125F, 99.9625F)
            Me.digitalBackgroundLayerComponent3.Name = "digitalBackgroundLayerComponent3"
            Me.digitalBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style4
            Me.digitalBackgroundLayerComponent3.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
            Me.digitalBackgroundLayerComponent3.ZOrder = 1000
            ' 
            ' gaugeControl18
            ' 
            Me.gaugeControl18.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge12})
            Me.gaugeControl18.Location = New System.Drawing.Point(491, 2)
            Me.gaugeControl18.Name = "gaugeControl18"
            Me.gaugeControl18.Size = New System.Drawing.Size(220, 220)
            Me.gaugeControl18.TabIndex = 4
            ' 
            ' circularGauge12
            ' 
            Me.circularGauge12.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent12, Me.arcScaleBackgroundLayerComponent33})
            Me.circularGauge12.Bounds = New System.Drawing.Rectangle(6, 6, 208, 208)
            Me.circularGauge12.Name = "circularGauge12"
            Me.circularGauge12.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent12})
            Me.circularGauge12.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent12, Me.arcScaleComponent36})
            Me.circularGauge12.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent12})
            ' 
            ' arcScaleBackgroundLayerComponent12
            ' 
            Me.arcScaleBackgroundLayerComponent12.ArcScale = Me.arcScaleComponent12
            Me.arcScaleBackgroundLayerComponent12.Name = "arcScaleBackgroundLayerComponent12"
            Me.arcScaleBackgroundLayerComponent12.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style4
            Me.arcScaleBackgroundLayerComponent12.ZOrder = 1000
            ' 
            ' arcScaleComponent12
            ' 
            Me.arcScaleComponent12.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent12.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent12.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent12.EndAngle = 60F
            Me.arcScaleComponent12.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent12.MajorTickmark.ShapeOffset = -12F
            Me.arcScaleComponent12.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F)
            Me.arcScaleComponent12.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_2
            Me.arcScaleComponent12.MajorTickmark.TextOffset = -27F
            Me.arcScaleComponent12.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent12.MaxValue = 100F
            Me.arcScaleComponent12.MinorTickCount = 4
            Me.arcScaleComponent12.MinorTickmark.ShapeOffset = -5F
            Me.arcScaleComponent12.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F)
            Me.arcScaleComponent12.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_1
            Me.arcScaleComponent12.Name = "arcScaleComponent12"
            Me.arcScaleComponent12.RadiusX = 122F
            Me.arcScaleComponent12.RadiusY = 122F
            Me.arcScaleComponent12.StartAngle = -240F
            ' 
            ' arcScaleBackgroundLayerComponent33
            ' 
            Me.arcScaleBackgroundLayerComponent33.ArcScale = Me.arcScaleComponent12
            Me.arcScaleBackgroundLayerComponent33.Name = "arcScaleBackgroundLayerComponent33"
            Me.arcScaleBackgroundLayerComponent33.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style4_1
            Me.arcScaleBackgroundLayerComponent33.Size = New System.Drawing.SizeF(150F, 150F)
            Me.arcScaleBackgroundLayerComponent33.ZOrder = 999
            ' 
            ' arcScaleNeedleComponent12
            ' 
            Me.arcScaleNeedleComponent12.ArcScale = Me.arcScaleComponent12
            Me.arcScaleNeedleComponent12.EndOffset = 5F
            Me.arcScaleNeedleComponent12.Name = "arcScaleNeedleComponent12"
            Me.arcScaleNeedleComponent12.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style4
            Me.arcScaleNeedleComponent12.StartOffset = -21F
            Me.arcScaleNeedleComponent12.ZOrder = -50
            ' 
            ' arcScaleComponent36
            ' 
            Me.arcScaleComponent36.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent36.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent36.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent36.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent36.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent36.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:LightBlue")
            Me.arcScaleComponent36.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent36.EndAngle = -30F
            Me.arcScaleComponent36.MajorTickCount = 8
            Me.arcScaleComponent36.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent36.MajorTickmark.ShapeOffset = -6F
            Me.arcScaleComponent36.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_3
            Me.arcScaleComponent36.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent36.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent36.MaxValue = 700F
            Me.arcScaleComponent36.MinorTickCount = 4
            Me.arcScaleComponent36.MinorTickmark.ShapeOffset = -1.5F
            Me.arcScaleComponent36.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style4_4
            Me.arcScaleComponent36.Name = "arcScaleComponent36"
            Me.arcScaleComponent36.RadiusX = 70F
            Me.arcScaleComponent36.RadiusY = 70F
            Me.arcScaleComponent36.StartAngle = -240F
            ' 
            ' arcScaleSpindleCapComponent12
            ' 
            Me.arcScaleSpindleCapComponent12.ArcScale = Me.arcScaleComponent12
            Me.arcScaleSpindleCapComponent12.Name = "arcScaleSpindleCapComponent12"
            Me.arcScaleSpindleCapComponent12.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style4
            Me.arcScaleSpindleCapComponent12.Size = New System.Drawing.SizeF(16F, 16F)
            Me.arcScaleSpindleCapComponent12.ZOrder = -100
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.AllowDrawBackground = False
            Me.layoutControlGroup3.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem13, Me.layoutControlItem14, Me.layoutControlItem15, Me.layoutControlItem16, Me.layoutControlItem17, Me.layoutControlItem18})
            Me.layoutControlGroup3.Name = "layoutControlGroup1"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(713, 476)
            Me.layoutControlGroup3.TextVisible = False
            ' 
            ' layoutControlItem13
            ' 
            Me.layoutControlItem13.Control = Me.gaugeControl17
            Me.layoutControlItem13.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem13.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem13.Name = "layoutControlItem2"
            Me.layoutControlItem13.Size = New System.Drawing.Size(266, 224)
            Me.layoutControlItem13.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem13.TextVisible = False
            ' 
            ' layoutControlItem14
            ' 
            Me.layoutControlItem14.Control = Me.gaugeControl15
            Me.layoutControlItem14.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem14.Location = New System.Drawing.Point(0, 224)
            Me.layoutControlItem14.Name = "layoutControlItem4"
            Me.layoutControlItem14.Size = New System.Drawing.Size(266, 252)
            Me.layoutControlItem14.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem14.TextVisible = False
            ' 
            ' layoutControlItem15
            ' 
            Me.layoutControlItem15.Control = Me.gaugeControl16
            Me.layoutControlItem15.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem15.Location = New System.Drawing.Point(266, 224)
            Me.layoutControlItem15.Name = "layoutControlItem3"
            Me.layoutControlItem15.Size = New System.Drawing.Size(223, 252)
            Me.layoutControlItem15.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem15.TextVisible = False
            ' 
            ' layoutControlItem16
            ' 
            Me.layoutControlItem16.Control = Me.gaugeControl13
            Me.layoutControlItem16.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem16.Location = New System.Drawing.Point(489, 224)
            Me.layoutControlItem16.Name = "layoutControlItem6"
            Me.layoutControlItem16.Size = New System.Drawing.Size(224, 252)
            Me.layoutControlItem16.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem16.TextVisible = False
            ' 
            ' layoutControlItem17
            ' 
            Me.layoutControlItem17.Control = Me.gaugeControl18
            Me.layoutControlItem17.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem17.Location = New System.Drawing.Point(489, 0)
            Me.layoutControlItem17.Name = "layoutControlItem1"
            Me.layoutControlItem17.Size = New System.Drawing.Size(224, 224)
            Me.layoutControlItem17.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem17.TextVisible = False
            ' 
            ' layoutControlItem18
            ' 
            Me.layoutControlItem18.Control = Me.gaugeControl14
            Me.layoutControlItem18.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem18.Location = New System.Drawing.Point(266, 0)
            Me.layoutControlItem18.Name = "layoutControlItem5"
            Me.layoutControlItem18.Size = New System.Drawing.Size(223, 224)
            Me.layoutControlItem18.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem18.TextVisible = False
            ' 
            ' xtraTabPage4
            ' 
            Me.xtraTabPage4.Caption = "Gothic Mat"
            Me.xtraTabPage4.Controls.Add(Me.layoutControl4)
            Me.xtraTabPage4.Name = "xtraTabPage4"
            Me.xtraTabPage4.Padding = New System.Windows.Forms.Padding(3)
            Me.xtraTabPage4.Size = New System.Drawing.Size(719, 482)
            ' 
            ' layoutControl4
            ' 
            Me.layoutControl4.Controls.Add(Me.gaugeControl19)
            Me.layoutControl4.Controls.Add(Me.gaugeControl20)
            Me.layoutControl4.Controls.Add(Me.gaugeControl21)
            Me.layoutControl4.Controls.Add(Me.gaugeControl22)
            Me.layoutControl4.Controls.Add(Me.gaugeControl23)
            Me.layoutControl4.Controls.Add(Me.gaugeControl24)
            Me.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl4.Location = New System.Drawing.Point(3, 3)
            Me.layoutControl4.Name = "layoutControl4"
            Me.layoutControl4.Root = Me.layoutControlGroup4
            Me.layoutControl4.Size = New System.Drawing.Size(713, 476)
            Me.layoutControl4.TabIndex = 3
            Me.layoutControl4.Text = "layoutControl4"
            ' 
            ' gaugeControl19
            ' 
            Me.gaugeControl19.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge4})
            Me.gaugeControl19.Location = New System.Drawing.Point(492, 226)
            Me.gaugeControl19.Name = "gaugeControl19"
            Me.gaugeControl19.Size = New System.Drawing.Size(219, 248)
            Me.gaugeControl19.TabIndex = 9
            ' 
            ' linearGauge4
            ' 
            Me.linearGauge4.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent4})
            Me.linearGauge4.Bounds = New System.Drawing.Rectangle(6, 6, 207, 236)
            Me.linearGauge4.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent4})
            Me.linearGauge4.Name = "linearGauge4"
            Me.linearGauge4.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent7, Me.linearScaleComponent8})
            ' 
            ' linearScaleBackgroundLayerComponent4
            ' 
            Me.linearScaleBackgroundLayerComponent4.LinearScale = Me.linearScaleComponent7
            Me.linearScaleBackgroundLayerComponent4.Name = "linearScaleBackgroundLayerComponent4"
            Me.linearScaleBackgroundLayerComponent4.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.14F)
            Me.linearScaleBackgroundLayerComponent4.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.86F)
            Me.linearScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style5
            Me.linearScaleBackgroundLayerComponent4.ZOrder = 1000
            ' 
            ' linearScaleComponent7
            ' 
            Me.linearScaleComponent7.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent7.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent7.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent7.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent7.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            Me.linearScaleComponent7.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.linearScaleComponent7.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 35F)
            Me.linearScaleComponent7.MajorTickCount = 6
            Me.linearScaleComponent7.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent7.MajorTickmark.ShapeOffset = 5F
            Me.linearScaleComponent7.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.8F, 0.8F)
            Me.linearScaleComponent7.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style5_3
            Me.linearScaleComponent7.MajorTickmark.TextOffset = 37F
            Me.linearScaleComponent7.MaxValue = 500F
            Me.linearScaleComponent7.MinorTickCount = 4
            Me.linearScaleComponent7.MinorTickmark.ShapeOffset = 5F
            Me.linearScaleComponent7.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style5_1
            Me.linearScaleComponent7.Name = "linearScaleComponent4"
            Me.linearScaleComponent7.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F)
            Me.linearScaleComponent7.Value = 250F
            ' 
            ' linearScaleLevelComponent4
            ' 
            Me.linearScaleLevelComponent4.LinearScale = Me.linearScaleComponent7
            Me.linearScaleLevelComponent4.Name = "linearScaleLevelComponent4"
            Me.linearScaleLevelComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style5
            Me.linearScaleLevelComponent4.ZOrder = -50
            ' 
            ' linearScaleComponent8
            ' 
            Me.linearScaleComponent8.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent8.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent8.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent8.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent8.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            Me.linearScaleComponent8.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.linearScaleComponent8.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 35F)
            Me.linearScaleComponent8.MajorTickCount = 6
            Me.linearScaleComponent8.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent8.MajorTickmark.ShapeOffset = -22.5F
            Me.linearScaleComponent8.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.8F, 0.8F)
            Me.linearScaleComponent8.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style5_3
            Me.linearScaleComponent8.MajorTickmark.TextOffset = -35F
            Me.linearScaleComponent8.MaxValue = 50F
            Me.linearScaleComponent8.MinorTickCount = 4
            Me.linearScaleComponent8.MinorTickmark.ShapeOffset = -11F
            Me.linearScaleComponent8.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style5_1
            Me.linearScaleComponent8.Name = "linearScaleComponent12"
            Me.linearScaleComponent8.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F)
            ' 
            ' gaugeControl20
            ' 
            Me.gaugeControl20.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge13})
            Me.gaugeControl20.Location = New System.Drawing.Point(268, 2)
            Me.gaugeControl20.Name = "gaugeControl20"
            Me.gaugeControl20.Size = New System.Drawing.Size(220, 220)
            Me.gaugeControl20.TabIndex = 8
            ' 
            ' circularGauge13
            ' 
            Me.circularGauge13.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent13})
            Me.circularGauge13.Bounds = New System.Drawing.Rectangle(6, 6, 208, 208)
            Me.circularGauge13.Name = "circularGauge13"
            Me.circularGauge13.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent13})
            Me.circularGauge13.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent13, Me.arcScaleComponent39})
            ' 
            ' arcScaleBackgroundLayerComponent13
            ' 
            Me.arcScaleBackgroundLayerComponent13.ArcScale = Me.arcScaleComponent13
            Me.arcScaleBackgroundLayerComponent13.Name = "arcScaleBackgroundLayerComponent13"
            Me.arcScaleBackgroundLayerComponent13.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.695F)
            Me.arcScaleBackgroundLayerComponent13.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style5
            Me.arcScaleBackgroundLayerComponent13.Size = New System.Drawing.SizeF(250F, 178F)
            Me.arcScaleBackgroundLayerComponent13.ZOrder = 1000
            ' 
            ' arcScaleComponent13
            ' 
            Me.arcScaleComponent13.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 14F)
            Me.arcScaleComponent13.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:LightGrey")
            Me.arcScaleComponent13.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent13.EndAngle = 0F
            Me.arcScaleComponent13.MajorTickCount = 7
            Me.arcScaleComponent13.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent13.MajorTickmark.ShapeOffset = -11F
            Me.arcScaleComponent13.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.5F, 1F)
            Me.arcScaleComponent13.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_1
            Me.arcScaleComponent13.MajorTickmark.TextOffset = -28F
            Me.arcScaleComponent13.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent13.MaxValue = 80F
            Me.arcScaleComponent13.MinorTickCount = 4
            Me.arcScaleComponent13.MinorTickmark.ShapeOffset = -5F
            Me.arcScaleComponent13.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.5F, 1F)
            Me.arcScaleComponent13.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent13.MinValue = 20F
            Me.arcScaleComponent13.Name = "arcScaleComponent13"
            Me.arcScaleComponent13.RadiusX = 122F
            Me.arcScaleComponent13.RadiusY = 122F
            Me.arcScaleComponent13.StartAngle = -180F
            Me.arcScaleComponent13.Value = 20F
            ' 
            ' arcScaleNeedleComponent13
            ' 
            Me.arcScaleNeedleComponent13.ArcScale = Me.arcScaleComponent13
            Me.arcScaleNeedleComponent13.Name = "arcScaleNeedleComponent13"
            Me.arcScaleNeedleComponent13.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style5
            Me.arcScaleNeedleComponent13.StartOffset = -23.5F
            Me.arcScaleNeedleComponent13.ZOrder = -50
            ' 
            ' arcScaleComponent39
            ' 
            Me.arcScaleComponent39.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent39.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent39.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent39.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent39.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent39.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent39.EndAngle = -30F
            Me.arcScaleComponent39.MajorTickCount = 6
            Me.arcScaleComponent39.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent39.MajorTickmark.ShapeOffset = -4F
            Me.arcScaleComponent39.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_4
            Me.arcScaleComponent39.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent39.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent39.MaxValue = 700F
            Me.arcScaleComponent39.MinorTickCount = 4
            Me.arcScaleComponent39.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent39.MinValue = 200F
            Me.arcScaleComponent39.Name = "arcScaleComponent39"
            Me.arcScaleComponent39.RadiusX = 65F
            Me.arcScaleComponent39.RadiusY = 65F
            Me.arcScaleComponent39.StartAngle = -180F
            Me.arcScaleComponent39.Value = 200F
            ' 
            ' gaugeControl21
            ' 
            Me.gaugeControl21.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge14})
            Me.gaugeControl21.Location = New System.Drawing.Point(2, 226)
            Me.gaugeControl21.Name = "gaugeControl21"
            Me.gaugeControl21.Size = New System.Drawing.Size(262, 248)
            Me.gaugeControl21.TabIndex = 7
            ' 
            ' circularGauge14
            ' 
            Me.circularGauge14.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent14})
            Me.circularGauge14.Bounds = New System.Drawing.Rectangle(6, 6, 250, 236)
            Me.circularGauge14.Name = "circularGauge14"
            Me.circularGauge14.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent14})
            Me.circularGauge14.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent14, Me.arcScaleComponent41})
            ' 
            ' arcScaleBackgroundLayerComponent14
            ' 
            Me.arcScaleBackgroundLayerComponent14.ArcScale = Me.arcScaleComponent14
            Me.arcScaleBackgroundLayerComponent14.Name = "arcScaleBackgroundLayerComponent14"
            Me.arcScaleBackgroundLayerComponent14.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.75F, 0.75F)
            Me.arcScaleBackgroundLayerComponent14.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style5Left
            Me.arcScaleBackgroundLayerComponent14.ZOrder = 1000
            ' 
            ' arcScaleComponent14
            ' 
            Me.arcScaleComponent14.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 20.25F)
            Me.arcScaleComponent14.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:LightGrey")
            Me.arcScaleComponent14.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(190F, 190F)
            Me.arcScaleComponent14.EndAngle = -90F
            Me.arcScaleComponent14.MajorTickCount = 4
            Me.arcScaleComponent14.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent14.MajorTickmark.ShapeOffset = -14F
            Me.arcScaleComponent14.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.2F, 1.2F)
            Me.arcScaleComponent14.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_1
            Me.arcScaleComponent14.MajorTickmark.TextOffset = -35F
            Me.arcScaleComponent14.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent14.MaxValue = 50F
            Me.arcScaleComponent14.MinorTickCount = 4
            Me.arcScaleComponent14.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.2F, 1.2F)
            Me.arcScaleComponent14.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent14.MinValue = 20F
            Me.arcScaleComponent14.Name = "arcScaleComponent14"
            Me.arcScaleComponent14.RadiusX = 172F
            Me.arcScaleComponent14.RadiusY = 172F
            Me.arcScaleComponent14.StartAngle = -180F
            Me.arcScaleComponent14.Value = 30F
            ' 
            ' arcScaleNeedleComponent14
            ' 
            Me.arcScaleNeedleComponent14.ArcScale = Me.arcScaleComponent14
            Me.arcScaleNeedleComponent14.Name = "arcScaleNeedleComponent14"
            Me.arcScaleNeedleComponent14.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style5
            Me.arcScaleNeedleComponent14.StartOffset = -32.5F
            Me.arcScaleNeedleComponent14.ZOrder = -50
            ' 
            ' arcScaleComponent41
            ' 
            Me.arcScaleComponent41.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent41.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent41.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent41.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent41.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 12F)
            Me.arcScaleComponent41.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent41.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(190F, 190F)
            Me.arcScaleComponent41.EndAngle = -90F
            Me.arcScaleComponent41.MajorTickCount = 4
            Me.arcScaleComponent41.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent41.MajorTickmark.ShapeOffset = -4F
            Me.arcScaleComponent41.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_4
            Me.arcScaleComponent41.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent41.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent41.MaxValue = 500F
            Me.arcScaleComponent41.MinorTickCount = 4
            Me.arcScaleComponent41.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent41.MinValue = 200F
            Me.arcScaleComponent41.Name = "arcScaleComponent41"
            Me.arcScaleComponent41.StartAngle = -180F
            Me.arcScaleComponent41.Value = 200F
            ' 
            ' gaugeControl22
            ' 
            Me.gaugeControl22.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge15})
            Me.gaugeControl22.Location = New System.Drawing.Point(268, 226)
            Me.gaugeControl22.Name = "gaugeControl22"
            Me.gaugeControl22.Size = New System.Drawing.Size(220, 248)
            Me.gaugeControl22.TabIndex = 6
            ' 
            ' circularGauge15
            ' 
            Me.circularGauge15.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent15})
            Me.circularGauge15.Bounds = New System.Drawing.Rectangle(6, 6, 208, 236)
            Me.circularGauge15.Name = "circularGauge15"
            Me.circularGauge15.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent15})
            Me.circularGauge15.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent15, Me.arcScaleComponent42})
            ' 
            ' arcScaleBackgroundLayerComponent15
            ' 
            Me.arcScaleBackgroundLayerComponent15.ArcScale = Me.arcScaleComponent15
            Me.arcScaleBackgroundLayerComponent15.Name = "arcScaleBackgroundLayerComponent15"
            Me.arcScaleBackgroundLayerComponent15.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.59F)
            Me.arcScaleBackgroundLayerComponent15.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style5
            Me.arcScaleBackgroundLayerComponent15.Size = New System.Drawing.SizeF(250F, 208F)
            Me.arcScaleBackgroundLayerComponent15.ZOrder = 1000
            ' 
            ' arcScaleComponent15
            ' 
            Me.arcScaleComponent15.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 14F)
            Me.arcScaleComponent15.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:LightGrey")
            Me.arcScaleComponent15.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent15.EndAngle = 30F
            Me.arcScaleComponent15.MajorTickCount = 9
            Me.arcScaleComponent15.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent15.MajorTickmark.ShapeOffset = -11F
            Me.arcScaleComponent15.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.5F, 1F)
            Me.arcScaleComponent15.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_1
            Me.arcScaleComponent15.MajorTickmark.TextOffset = -28F
            Me.arcScaleComponent15.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent15.MaxValue = 120F
            Me.arcScaleComponent15.MinorTickCount = 4
            Me.arcScaleComponent15.MinorTickmark.ShapeOffset = -5F
            Me.arcScaleComponent15.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.5F, 1F)
            Me.arcScaleComponent15.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent15.Name = "arcScaleComponent15"
            Me.arcScaleComponent15.RadiusX = 120F
            Me.arcScaleComponent15.RadiusY = 120F
            Me.arcScaleComponent15.StartAngle = -210F
            Me.arcScaleComponent15.Value = 20F
            ' 
            ' arcScaleNeedleComponent15
            ' 
            Me.arcScaleNeedleComponent15.ArcScale = Me.arcScaleComponent15
            Me.arcScaleNeedleComponent15.Name = "arcScaleNeedleComponent15"
            Me.arcScaleNeedleComponent15.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style5
            Me.arcScaleNeedleComponent15.StartOffset = -23.5F
            Me.arcScaleNeedleComponent15.ZOrder = -50
            ' 
            ' arcScaleComponent42
            ' 
            Me.arcScaleComponent42.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent42.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent42.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent42.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent42.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent42.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent42.EndAngle = -30F
            Me.arcScaleComponent42.MajorTickCount = 6
            Me.arcScaleComponent42.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent42.MajorTickmark.ShapeOffset = -4F
            Me.arcScaleComponent42.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_4
            Me.arcScaleComponent42.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent42.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent42.MaxValue = 700F
            Me.arcScaleComponent42.MinorTickCount = 4
            Me.arcScaleComponent42.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent42.MinValue = 200F
            Me.arcScaleComponent42.Name = "arcScaleComponent42"
            Me.arcScaleComponent42.RadiusX = 65F
            Me.arcScaleComponent42.RadiusY = 65F
            Me.arcScaleComponent42.StartAngle = -210F
            Me.arcScaleComponent42.Value = 200F
            ' 
            ' gaugeControl23
            ' 
            Me.gaugeControl23.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge4})
            Me.gaugeControl23.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl23.Name = "gaugeControl23"
            Me.gaugeControl23.Size = New System.Drawing.Size(262, 220)
            Me.gaugeControl23.TabIndex = 5
            ' 
            ' digitalGauge4
            ' 
            Me.digitalGauge4.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FC0C0C0")
            Me.digitalGauge4.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.digitalGauge4.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent4})
            Me.digitalGauge4.Bounds = New System.Drawing.Rectangle(6, 6, 250, 208)
            Me.digitalGauge4.DigitCount = 5
            Me.digitalGauge4.Name = "digitalGauge4"
            Me.digitalGauge4.Text = "00,000"
            ' 
            ' digitalBackgroundLayerComponent4
            ' 
            Me.digitalBackgroundLayerComponent4.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125F, 99.9625F)
            Me.digitalBackgroundLayerComponent4.Name = "digitalBackgroundLayerComponent4"
            Me.digitalBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style5
            Me.digitalBackgroundLayerComponent4.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
            Me.digitalBackgroundLayerComponent4.ZOrder = 1000
            ' 
            ' gaugeControl24
            ' 
            Me.gaugeControl24.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge16})
            Me.gaugeControl24.Location = New System.Drawing.Point(492, 2)
            Me.gaugeControl24.Name = "gaugeControl24"
            Me.gaugeControl24.Size = New System.Drawing.Size(219, 220)
            Me.gaugeControl24.TabIndex = 4
            ' 
            ' circularGauge16
            ' 
            Me.circularGauge16.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent16, Me.arcScaleBackgroundLayerComponent34})
            Me.circularGauge16.Bounds = New System.Drawing.Rectangle(6, 6, 207, 208)
            Me.circularGauge16.Name = "circularGauge16"
            Me.circularGauge16.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent16})
            Me.circularGauge16.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent16, Me.arcScaleComponent40})
            ' 
            ' arcScaleBackgroundLayerComponent16
            ' 
            Me.arcScaleBackgroundLayerComponent16.ArcScale = Me.arcScaleComponent16
            Me.arcScaleBackgroundLayerComponent16.Name = "arcScaleBackgroundLayerComponent16"
            Me.arcScaleBackgroundLayerComponent16.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style5
            Me.arcScaleBackgroundLayerComponent16.ZOrder = 1000
            ' 
            ' arcScaleComponent16
            ' 
            Me.arcScaleComponent16.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 14F)
            Me.arcScaleComponent16.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:LightGrey")
            Me.arcScaleComponent16.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent16.EndAngle = 60F
            Me.arcScaleComponent16.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent16.MajorTickmark.ShapeOffset = -11F
            Me.arcScaleComponent16.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.5F, 1F)
            Me.arcScaleComponent16.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_1
            Me.arcScaleComponent16.MajorTickmark.TextOffset = -28F
            Me.arcScaleComponent16.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent16.MaxValue = 100F
            Me.arcScaleComponent16.MinorTickCount = 4
            Me.arcScaleComponent16.MinorTickmark.ShapeOffset = -5F
            Me.arcScaleComponent16.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.5F, 1F)
            Me.arcScaleComponent16.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent16.Name = "arcScaleComponent16"
            Me.arcScaleComponent16.RadiusX = 122F
            Me.arcScaleComponent16.RadiusY = 122F
            Me.arcScaleComponent16.StartAngle = -240F
            ' 
            ' arcScaleBackgroundLayerComponent34
            ' 
            Me.arcScaleBackgroundLayerComponent34.ArcScale = Me.arcScaleComponent16
            Me.arcScaleBackgroundLayerComponent34.Name = "arcScaleBackgroundLayerComponent34"
            Me.arcScaleBackgroundLayerComponent34.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style5_1
            Me.arcScaleBackgroundLayerComponent34.Size = New System.Drawing.SizeF(216F, 216F)
            Me.arcScaleBackgroundLayerComponent34.ZOrder = 999
            ' 
            ' arcScaleNeedleComponent16
            ' 
            Me.arcScaleNeedleComponent16.ArcScale = Me.arcScaleComponent16
            Me.arcScaleNeedleComponent16.Name = "arcScaleNeedleComponent16"
            Me.arcScaleNeedleComponent16.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style5
            Me.arcScaleNeedleComponent16.StartOffset = -23.5F
            Me.arcScaleNeedleComponent16.ZOrder = -50
            ' 
            ' arcScaleComponent40
            ' 
            Me.arcScaleComponent40.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent40.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent40.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent40.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent40.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent40.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent40.EndAngle = -30F
            Me.arcScaleComponent40.MajorTickCount = 8
            Me.arcScaleComponent40.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent40.MajorTickmark.ShapeOffset = -4F
            Me.arcScaleComponent40.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_4
            Me.arcScaleComponent40.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent40.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent40.MaxValue = 700F
            Me.arcScaleComponent40.MinorTickCount = 4
            Me.arcScaleComponent40.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent40.Name = "arcScaleComponent40"
            Me.arcScaleComponent40.RadiusX = 65F
            Me.arcScaleComponent40.RadiusY = 65F
            Me.arcScaleComponent40.StartAngle = -240F
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.AllowDrawBackground = False
            Me.layoutControlGroup4.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup4.GroupBordersVisible = False
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem19, Me.layoutControlItem20, Me.layoutControlItem21, Me.layoutControlItem22, Me.layoutControlItem23, Me.layoutControlItem24})
            Me.layoutControlGroup4.Name = "layoutControlGroup1"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(713, 476)
            Me.layoutControlGroup4.TextVisible = False
            ' 
            ' layoutControlItem19
            ' 
            Me.layoutControlItem19.Control = Me.gaugeControl23
            Me.layoutControlItem19.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem19.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem19.Name = "layoutControlItem2"
            Me.layoutControlItem19.Size = New System.Drawing.Size(266, 224)
            Me.layoutControlItem19.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem19.TextVisible = False
            ' 
            ' layoutControlItem20
            ' 
            Me.layoutControlItem20.Control = Me.gaugeControl21
            Me.layoutControlItem20.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem20.Location = New System.Drawing.Point(0, 224)
            Me.layoutControlItem20.Name = "layoutControlItem4"
            Me.layoutControlItem20.Size = New System.Drawing.Size(266, 252)
            Me.layoutControlItem20.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem20.TextVisible = False
            ' 
            ' layoutControlItem21
            ' 
            Me.layoutControlItem21.Control = Me.gaugeControl22
            Me.layoutControlItem21.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem21.Location = New System.Drawing.Point(266, 224)
            Me.layoutControlItem21.Name = "layoutControlItem3"
            Me.layoutControlItem21.Size = New System.Drawing.Size(224, 252)
            Me.layoutControlItem21.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem21.TextVisible = False
            ' 
            ' layoutControlItem22
            ' 
            Me.layoutControlItem22.Control = Me.gaugeControl19
            Me.layoutControlItem22.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem22.Location = New System.Drawing.Point(490, 224)
            Me.layoutControlItem22.Name = "layoutControlItem6"
            Me.layoutControlItem22.Size = New System.Drawing.Size(223, 252)
            Me.layoutControlItem22.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem22.TextVisible = False
            ' 
            ' layoutControlItem23
            ' 
            Me.layoutControlItem23.Control = Me.gaugeControl24
            Me.layoutControlItem23.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem23.Location = New System.Drawing.Point(490, 0)
            Me.layoutControlItem23.Name = "layoutControlItem1"
            Me.layoutControlItem23.Size = New System.Drawing.Size(223, 224)
            Me.layoutControlItem23.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem23.TextVisible = False
            ' 
            ' layoutControlItem24
            ' 
            Me.layoutControlItem24.Control = Me.gaugeControl20
            Me.layoutControlItem24.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem24.Location = New System.Drawing.Point(266, 0)
            Me.layoutControlItem24.Name = "layoutControlItem5"
            Me.layoutControlItem24.Size = New System.Drawing.Size(224, 224)
            Me.layoutControlItem24.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem24.TextVisible = False
            ' 
            ' xtraTabPage5
            ' 
            Me.xtraTabPage5.Caption = "Shining Dark"
            Me.xtraTabPage5.Controls.Add(Me.layoutControl5)
            Me.xtraTabPage5.Name = "xtraTabPage5"
            Me.xtraTabPage5.Padding = New System.Windows.Forms.Padding(3)
            Me.xtraTabPage5.Size = New System.Drawing.Size(719, 482)
            ' 
            ' layoutControl5
            ' 
            Me.layoutControl5.Controls.Add(Me.gaugeControl25)
            Me.layoutControl5.Controls.Add(Me.gaugeControl26)
            Me.layoutControl5.Controls.Add(Me.gaugeControl27)
            Me.layoutControl5.Controls.Add(Me.gaugeControl28)
            Me.layoutControl5.Controls.Add(Me.gaugeControl29)
            Me.layoutControl5.Controls.Add(Me.gaugeControl30)
            Me.layoutControl5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl5.Location = New System.Drawing.Point(3, 3)
            Me.layoutControl5.Name = "layoutControl5"
            Me.layoutControl5.Root = Me.layoutControlGroup5
            Me.layoutControl5.Size = New System.Drawing.Size(713, 476)
            Me.layoutControl5.TabIndex = 3
            Me.layoutControl5.Text = "layoutControl5"
            ' 
            ' gaugeControl25
            ' 
            Me.gaugeControl25.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge5})
            Me.gaugeControl25.Location = New System.Drawing.Point(492, 226)
            Me.gaugeControl25.Name = "gaugeControl25"
            Me.gaugeControl25.Size = New System.Drawing.Size(219, 248)
            Me.gaugeControl25.TabIndex = 9
            ' 
            ' linearGauge5
            ' 
            Me.linearGauge5.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent5})
            Me.linearGauge5.Bounds = New System.Drawing.Rectangle(6, 6, 207, 236)
            Me.linearGauge5.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleEffectLayerComponent() {Me.linearScaleEffectLayerComponent1})
            Me.linearGauge5.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent5})
            Me.linearGauge5.Name = "linearGauge5"
            Me.linearGauge5.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent9, Me.linearScaleComponent10})
            ' 
            ' linearScaleBackgroundLayerComponent5
            ' 
            Me.linearScaleBackgroundLayerComponent5.LinearScale = Me.linearScaleComponent9
            Me.linearScaleBackgroundLayerComponent5.Name = "linearScaleBackgroundLayerComponent5"
            Me.linearScaleBackgroundLayerComponent5.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.125F)
            Me.linearScaleBackgroundLayerComponent5.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.875F)
            Me.linearScaleBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style6
            Me.linearScaleBackgroundLayerComponent5.ZOrder = 1000
            ' 
            ' linearScaleComponent9
            ' 
            Me.linearScaleComponent9.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent9.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent9.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent9.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent9.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.linearScaleComponent9.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.linearScaleComponent9.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 32F)
            Me.linearScaleComponent9.MajorTickCount = 6
            Me.linearScaleComponent9.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent9.MajorTickmark.ShapeOffset = 5F
            Me.linearScaleComponent9.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style6_3
            Me.linearScaleComponent9.MajorTickmark.TextOffset = 35F
            Me.linearScaleComponent9.MaxValue = 50F
            Me.linearScaleComponent9.MinorTickCount = 4
            Me.linearScaleComponent9.MinorTickmark.ShapeOffset = 5F
            Me.linearScaleComponent9.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style6_2
            Me.linearScaleComponent9.Name = "linearScaleComponent5"
            Me.linearScaleComponent9.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 218F)
            Me.linearScaleComponent9.Value = 20F
            ' 
            ' linearScaleEffectLayerComponent1
            ' 
            Me.linearScaleEffectLayerComponent1.LinearScale = Me.linearScaleComponent9
            Me.linearScaleEffectLayerComponent1.Name = "linearScaleEffectLayerComponent1"
            Me.linearScaleEffectLayerComponent1.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 2F)
            Me.linearScaleEffectLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.15F)
            Me.linearScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.Linear_Style6
            Me.linearScaleEffectLayerComponent1.ZOrder = -1000
            ' 
            ' linearScaleLevelComponent5
            ' 
            Me.linearScaleLevelComponent5.LinearScale = Me.linearScaleComponent9
            Me.linearScaleLevelComponent5.Name = "linearScaleLevelComponent5"
            Me.linearScaleLevelComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style6
            Me.linearScaleLevelComponent5.ZOrder = -50
            ' 
            ' linearScaleComponent10
            ' 
            Me.linearScaleComponent10.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent10.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent10.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent10.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent10.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.linearScaleComponent10.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 32F)
            Me.linearScaleComponent10.MajorTickCount = 6
            Me.linearScaleComponent10.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent10.MajorTickmark.ShapeOffset = -22F
            Me.linearScaleComponent10.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style6_3
            Me.linearScaleComponent10.MajorTickmark.TextOffset = -35F
            Me.linearScaleComponent10.MaxValue = 500F
            Me.linearScaleComponent10.MinorTickCount = 4
            Me.linearScaleComponent10.MinorTickmark.ShapeOffset = -11F
            Me.linearScaleComponent10.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style6_2
            Me.linearScaleComponent10.Name = "linearScaleComponent8"
            Me.linearScaleComponent10.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 218F)
            ' 
            ' gaugeControl26
            ' 
            Me.gaugeControl26.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge17})
            Me.gaugeControl26.Location = New System.Drawing.Point(268, 2)
            Me.gaugeControl26.Name = "gaugeControl26"
            Me.gaugeControl26.Size = New System.Drawing.Size(220, 220)
            Me.gaugeControl26.TabIndex = 8
            ' 
            ' circularGauge17
            ' 
            Me.circularGauge17.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent17})
            Me.circularGauge17.Bounds = New System.Drawing.Rectangle(6, 6, 208, 208)
            Me.circularGauge17.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent1})
            Me.circularGauge17.Name = "circularGauge17"
            Me.circularGauge17.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent17})
            Me.circularGauge17.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent17, Me.arcScaleComponent43})
            Me.circularGauge17.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent13})
            ' 
            ' arcScaleBackgroundLayerComponent17
            ' 
            Me.arcScaleBackgroundLayerComponent17.ArcScale = Me.arcScaleComponent17
            Me.arcScaleBackgroundLayerComponent17.Name = "arcScaleBackgroundLayerComponent17"
            Me.arcScaleBackgroundLayerComponent17.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.655F)
            Me.arcScaleBackgroundLayerComponent17.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style6
            Me.arcScaleBackgroundLayerComponent17.Size = New System.Drawing.SizeF(250F, 190F)
            Me.arcScaleBackgroundLayerComponent17.ZOrder = 1000
            ' 
            ' arcScaleComponent17
            ' 
            Me.arcScaleComponent17.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent17.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
            Me.arcScaleComponent17.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent17.EndAngle = 0F
            Me.arcScaleComponent17.MajorTickCount = 7
            Me.arcScaleComponent17.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent17.MajorTickmark.ShapeOffset = -7F
            Me.arcScaleComponent17.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_5
            Me.arcScaleComponent17.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent17.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent17.MaxValue = 80F
            Me.arcScaleComponent17.MinorTickCount = 4
            Me.arcScaleComponent17.MinorTickmark.ShapeOffset = -3F
            Me.arcScaleComponent17.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_4
            Me.arcScaleComponent17.MinValue = 20F
            Me.arcScaleComponent17.Name = "arcScaleComponent17"
            Me.arcScaleComponent17.RadiusX = 98F
            Me.arcScaleComponent17.RadiusY = 98F
            Me.arcScaleComponent17.StartAngle = -180F
            Me.arcScaleComponent17.Value = 20F
            ' 
            ' arcScaleEffectLayerComponent1
            ' 
            Me.arcScaleEffectLayerComponent1.ArcScale = Me.arcScaleComponent17
            Me.arcScaleEffectLayerComponent1.Name = "arcScaleEffectLayerComponent1"
            Me.arcScaleEffectLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.533F, 0.95F)
            Me.arcScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Style6
            Me.arcScaleEffectLayerComponent1.Size = New System.Drawing.SizeF(190F, 105F)
            Me.arcScaleEffectLayerComponent1.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent17
            ' 
            Me.arcScaleNeedleComponent17.ArcScale = Me.arcScaleComponent17
            Me.arcScaleNeedleComponent17.EndOffset = -7F
            Me.arcScaleNeedleComponent17.Name = "arcScaleNeedleComponent17"
            Me.arcScaleNeedleComponent17.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style6
            Me.arcScaleNeedleComponent17.StartOffset = -23F
            Me.arcScaleNeedleComponent17.ZOrder = -50
            ' 
            ' arcScaleComponent43
            ' 
            Me.arcScaleComponent43.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent43.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent43.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent43.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent43.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent43.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent43.EndAngle = -30F
            Me.arcScaleComponent43.MajorTickCount = 6
            Me.arcScaleComponent43.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent43.MajorTickmark.ShapeOffset = -8F
            Me.arcScaleComponent43.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_3
            Me.arcScaleComponent43.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent43.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent43.MaxValue = 700F
            Me.arcScaleComponent43.MinorTickCount = 4
            Me.arcScaleComponent43.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_1
            Me.arcScaleComponent43.MinValue = 200F
            Me.arcScaleComponent43.Name = "arcScaleComponent43"
            Me.arcScaleComponent43.RadiusX = 65F
            Me.arcScaleComponent43.RadiusY = 65F
            Me.arcScaleComponent43.StartAngle = -180F
            Me.arcScaleComponent43.Value = 200F
            ' 
            ' arcScaleSpindleCapComponent13
            ' 
            Me.arcScaleSpindleCapComponent13.ArcScale = Me.arcScaleComponent17
            Me.arcScaleSpindleCapComponent13.Name = "arcScaleSpindleCapComponent13"
            Me.arcScaleSpindleCapComponent13.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style6
            Me.arcScaleSpindleCapComponent13.ZOrder = -25
            ' 
            ' gaugeControl27
            ' 
            Me.gaugeControl27.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge18})
            Me.gaugeControl27.Location = New System.Drawing.Point(2, 226)
            Me.gaugeControl27.Name = "gaugeControl27"
            Me.gaugeControl27.Size = New System.Drawing.Size(262, 248)
            Me.gaugeControl27.TabIndex = 7
            ' 
            ' circularGauge18
            ' 
            Me.circularGauge18.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent18})
            Me.circularGauge18.Bounds = New System.Drawing.Rectangle(6, 6, 250, 236)
            Me.circularGauge18.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent3})
            Me.circularGauge18.Name = "circularGauge18"
            Me.circularGauge18.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent18})
            Me.circularGauge18.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent18})
            Me.circularGauge18.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent15})
            ' 
            ' arcScaleBackgroundLayerComponent18
            ' 
            Me.arcScaleBackgroundLayerComponent18.ArcScale = Me.arcScaleComponent18
            Me.arcScaleBackgroundLayerComponent18.Name = "arcScaleBackgroundLayerComponent18"
            Me.arcScaleBackgroundLayerComponent18.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.72F, 0.72F)
            Me.arcScaleBackgroundLayerComponent18.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style6Left
            Me.arcScaleBackgroundLayerComponent18.ZOrder = 1000
            ' 
            ' arcScaleComponent18
            ' 
            Me.arcScaleComponent18.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 14F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent18.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
            Me.arcScaleComponent18.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(180F, 180F)
            Me.arcScaleComponent18.EndAngle = -90F
            Me.arcScaleComponent18.MajorTickCount = 5
            Me.arcScaleComponent18.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent18.MajorTickmark.ShapeOffset = -8F
            Me.arcScaleComponent18.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_5
            Me.arcScaleComponent18.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent18.MaxValue = 60F
            Me.arcScaleComponent18.MinorTickCount = 4
            Me.arcScaleComponent18.MinorTickmark.ShapeOffset = -4F
            Me.arcScaleComponent18.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_4
            Me.arcScaleComponent18.MinValue = 20F
            Me.arcScaleComponent18.Name = "arcScaleComponent18"
            Me.arcScaleComponent18.RadiusX = 140F
            Me.arcScaleComponent18.RadiusY = 140F
            Me.arcScaleComponent18.StartAngle = -180F
            Me.arcScaleComponent18.Value = 30F
            ' 
            ' arcScaleEffectLayerComponent3
            ' 
            Me.arcScaleEffectLayerComponent3.ArcScale = Me.arcScaleComponent18
            Me.arcScaleEffectLayerComponent3.Name = "arcScaleEffectLayerComponent3"
            Me.arcScaleEffectLayerComponent3.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.757F, 0.905F)
            Me.arcScaleEffectLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularQuarter_Style6Left
            Me.arcScaleEffectLayerComponent3.Size = New System.Drawing.SizeF(186F, 157F)
            Me.arcScaleEffectLayerComponent3.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent18
            ' 
            Me.arcScaleNeedleComponent18.ArcScale = Me.arcScaleComponent18
            Me.arcScaleNeedleComponent18.Name = "arcScaleNeedleComponent18"
            Me.arcScaleNeedleComponent18.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style6
            Me.arcScaleNeedleComponent18.StartOffset = -30F
            Me.arcScaleNeedleComponent18.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent15
            ' 
            Me.arcScaleSpindleCapComponent15.ArcScale = Me.arcScaleComponent18
            Me.arcScaleSpindleCapComponent15.Name = "arcScaleSpindleCapComponent15"
            Me.arcScaleSpindleCapComponent15.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style6
            Me.arcScaleSpindleCapComponent15.Size = New System.Drawing.SizeF(50F, 50F)
            Me.arcScaleSpindleCapComponent15.ZOrder = -25
            ' 
            ' gaugeControl28
            ' 
            Me.gaugeControl28.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge19})
            Me.gaugeControl28.Location = New System.Drawing.Point(268, 226)
            Me.gaugeControl28.Name = "gaugeControl28"
            Me.gaugeControl28.Size = New System.Drawing.Size(220, 248)
            Me.gaugeControl28.TabIndex = 6
            ' 
            ' circularGauge19
            ' 
            Me.circularGauge19.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent19})
            Me.circularGauge19.Bounds = New System.Drawing.Rectangle(6, 6, 208, 236)
            Me.circularGauge19.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent4})
            Me.circularGauge19.Name = "circularGauge19"
            Me.circularGauge19.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent19})
            Me.circularGauge19.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent19, Me.arcScaleComponent45})
            Me.circularGauge19.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent16})
            ' 
            ' arcScaleBackgroundLayerComponent19
            ' 
            Me.arcScaleBackgroundLayerComponent19.ArcScale = Me.arcScaleComponent19
            Me.arcScaleBackgroundLayerComponent19.Name = "arcScaleBackgroundLayerComponent19"
            Me.arcScaleBackgroundLayerComponent19.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.575F)
            Me.arcScaleBackgroundLayerComponent19.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style6
            Me.arcScaleBackgroundLayerComponent19.Size = New System.Drawing.SizeF(250F, 215F)
            Me.arcScaleBackgroundLayerComponent19.ZOrder = 1000
            ' 
            ' arcScaleComponent19
            ' 
            Me.arcScaleComponent19.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent19.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent19.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent19.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent19.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent19.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
            Me.arcScaleComponent19.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent19.EndAngle = 30F
            Me.arcScaleComponent19.MajorTickCount = 9
            Me.arcScaleComponent19.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent19.MajorTickmark.ShapeOffset = -8F
            Me.arcScaleComponent19.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_5
            Me.arcScaleComponent19.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent19.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent19.MaxValue = 120F
            Me.arcScaleComponent19.MinorTickCount = 4
            Me.arcScaleComponent19.MinorTickmark.ShapeOffset = -4F
            Me.arcScaleComponent19.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_4
            Me.arcScaleComponent19.Name = "arcScaleComponent19"
            Me.arcScaleComponent19.RadiusX = 98F
            Me.arcScaleComponent19.RadiusY = 98F
            Me.arcScaleComponent19.StartAngle = -210F
            Me.arcScaleComponent19.Value = 20F
            ' 
            ' arcScaleEffectLayerComponent4
            ' 
            Me.arcScaleEffectLayerComponent4.ArcScale = Me.arcScaleComponent19
            Me.arcScaleEffectLayerComponent4.Name = "arcScaleEffectLayerComponent4"
            Me.arcScaleEffectLayerComponent4.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.533F, 0.95F)
            Me.arcScaleEffectLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularThreeFourth_Style6
            Me.arcScaleEffectLayerComponent4.Size = New System.Drawing.SizeF(190F, 105F)
            Me.arcScaleEffectLayerComponent4.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent19
            ' 
            Me.arcScaleNeedleComponent19.ArcScale = Me.arcScaleComponent19
            Me.arcScaleNeedleComponent19.EndOffset = -7F
            Me.arcScaleNeedleComponent19.Name = "arcScaleNeedleComponent19"
            Me.arcScaleNeedleComponent19.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style6
            Me.arcScaleNeedleComponent19.StartOffset = -23F
            Me.arcScaleNeedleComponent19.ZOrder = -50
            ' 
            ' arcScaleComponent45
            ' 
            Me.arcScaleComponent45.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent45.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent45.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent45.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent45.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent45.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent45.EndAngle = -30F
            Me.arcScaleComponent45.MajorTickCount = 6
            Me.arcScaleComponent45.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent45.MajorTickmark.ShapeOffset = -8F
            Me.arcScaleComponent45.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_3
            Me.arcScaleComponent45.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent45.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent45.MaxValue = 700F
            Me.arcScaleComponent45.MinorTickCount = 4
            Me.arcScaleComponent45.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_1
            Me.arcScaleComponent45.MinValue = 200F
            Me.arcScaleComponent45.Name = "arcScaleComponent45"
            Me.arcScaleComponent45.RadiusX = 65F
            Me.arcScaleComponent45.RadiusY = 65F
            Me.arcScaleComponent45.StartAngle = -210F
            Me.arcScaleComponent45.Value = 200F
            ' 
            ' arcScaleSpindleCapComponent16
            ' 
            Me.arcScaleSpindleCapComponent16.ArcScale = Me.arcScaleComponent19
            Me.arcScaleSpindleCapComponent16.Name = "arcScaleSpindleCapComponent16"
            Me.arcScaleSpindleCapComponent16.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style6
            Me.arcScaleSpindleCapComponent16.ZOrder = -25
            ' 
            ' gaugeControl29
            ' 
            Me.gaugeControl29.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge5})
            Me.gaugeControl29.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl29.Name = "gaugeControl29"
            Me.gaugeControl29.Size = New System.Drawing.Size(262, 220)
            Me.gaugeControl29.TabIndex = 5
            ' 
            ' digitalGauge5
            ' 
            Me.digitalGauge5.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
            Me.digitalGauge5.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
            Me.digitalGauge5.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent5})
            Me.digitalGauge5.Bounds = New System.Drawing.Rectangle(6, 6, 250, 208)
            Me.digitalGauge5.DigitCount = 5
            Me.digitalGauge5.Name = "digitalGauge5"
            Me.digitalGauge5.Text = "00,000"
            ' 
            ' digitalBackgroundLayerComponent5
            ' 
            Me.digitalBackgroundLayerComponent5.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125F, 99.9625F)
            Me.digitalBackgroundLayerComponent5.Name = "digitalBackgroundLayerComponent5"
            Me.digitalBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style6
            Me.digitalBackgroundLayerComponent5.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
            Me.digitalBackgroundLayerComponent5.ZOrder = 1000
            ' 
            ' gaugeControl30
            ' 
            Me.gaugeControl30.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge20})
            Me.gaugeControl30.Location = New System.Drawing.Point(492, 2)
            Me.gaugeControl30.Name = "gaugeControl30"
            Me.gaugeControl30.Size = New System.Drawing.Size(219, 220)
            Me.gaugeControl30.TabIndex = 4
            ' 
            ' circularGauge20
            ' 
            Me.circularGauge20.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent20})
            Me.circularGauge20.Bounds = New System.Drawing.Rectangle(6, 6, 207, 208)
            Me.circularGauge20.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent2})
            Me.circularGauge20.Name = "circularGauge20"
            Me.circularGauge20.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent20})
            Me.circularGauge20.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent20, Me.arcScaleComponent44})
            Me.circularGauge20.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent14})
            ' 
            ' arcScaleBackgroundLayerComponent20
            ' 
            Me.arcScaleBackgroundLayerComponent20.ArcScale = Me.arcScaleComponent20
            Me.arcScaleBackgroundLayerComponent20.Name = "arcScaleBackgroundLayerComponent20"
            Me.arcScaleBackgroundLayerComponent20.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style6
            Me.arcScaleBackgroundLayerComponent20.ZOrder = 1000
            ' 
            ' arcScaleComponent20
            ' 
            Me.arcScaleComponent20.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent20.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent20.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent20.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent20.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent20.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
            Me.arcScaleComponent20.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent20.EndAngle = 60F
            Me.arcScaleComponent20.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent20.MajorTickmark.ShapeOffset = -7.3F
            Me.arcScaleComponent20.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_5
            Me.arcScaleComponent20.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent20.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent20.MaxValue = 100F
            Me.arcScaleComponent20.MinorTickCount = 4
            Me.arcScaleComponent20.MinorTickmark.ShapeOffset = -3.3F
            Me.arcScaleComponent20.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_4
            Me.arcScaleComponent20.Name = "arcScaleComponent20"
            Me.arcScaleComponent20.RadiusX = 98F
            Me.arcScaleComponent20.RadiusY = 98F
            Me.arcScaleComponent20.StartAngle = -240F
            ' 
            ' arcScaleEffectLayerComponent2
            ' 
            Me.arcScaleEffectLayerComponent2.ArcScale = Me.arcScaleComponent20
            Me.arcScaleEffectLayerComponent2.Name = "arcScaleEffectLayerComponent2"
            Me.arcScaleEffectLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.533F, 0.95F)
            Me.arcScaleEffectLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Style6
            Me.arcScaleEffectLayerComponent2.Size = New System.Drawing.SizeF(190F, 105F)
            Me.arcScaleEffectLayerComponent2.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent20
            ' 
            Me.arcScaleNeedleComponent20.ArcScale = Me.arcScaleComponent20
            Me.arcScaleNeedleComponent20.EndOffset = -7F
            Me.arcScaleNeedleComponent20.Name = "arcScaleNeedleComponent20"
            Me.arcScaleNeedleComponent20.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style6
            Me.arcScaleNeedleComponent20.StartOffset = -23F
            Me.arcScaleNeedleComponent20.ZOrder = -50
            ' 
            ' arcScaleComponent44
            ' 
            Me.arcScaleComponent44.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent44.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent44.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent44.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent44.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent44.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent44.EndAngle = -30F
            Me.arcScaleComponent44.MajorTickCount = 8
            Me.arcScaleComponent44.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent44.MajorTickmark.ShapeOffset = -8F
            Me.arcScaleComponent44.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_3
            Me.arcScaleComponent44.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent44.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent44.MaxValue = 700F
            Me.arcScaleComponent44.MinorTickCount = 4
            Me.arcScaleComponent44.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_1
            Me.arcScaleComponent44.Name = "arcScaleComponent44"
            Me.arcScaleComponent44.RadiusX = 65F
            Me.arcScaleComponent44.RadiusY = 65F
            Me.arcScaleComponent44.StartAngle = -240F
            ' 
            ' arcScaleSpindleCapComponent14
            ' 
            Me.arcScaleSpindleCapComponent14.ArcScale = Me.arcScaleComponent20
            Me.arcScaleSpindleCapComponent14.Name = "arcScaleSpindleCapComponent14"
            Me.arcScaleSpindleCapComponent14.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style6
            Me.arcScaleSpindleCapComponent14.ZOrder = -25
            ' 
            ' layoutControlGroup5
            ' 
            Me.layoutControlGroup5.AllowDrawBackground = False
            Me.layoutControlGroup5.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup5.GroupBordersVisible = False
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem25, Me.layoutControlItem26, Me.layoutControlItem27, Me.layoutControlItem28, Me.layoutControlItem29, Me.layoutControlItem30})
            Me.layoutControlGroup5.Name = "layoutControlGroup1"
            Me.layoutControlGroup5.Size = New System.Drawing.Size(713, 476)
            Me.layoutControlGroup5.TextVisible = False
            ' 
            ' layoutControlItem25
            ' 
            Me.layoutControlItem25.Control = Me.gaugeControl29
            Me.layoutControlItem25.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem25.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem25.Name = "layoutControlItem2"
            Me.layoutControlItem25.Size = New System.Drawing.Size(266, 224)
            Me.layoutControlItem25.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem25.TextVisible = False
            ' 
            ' layoutControlItem26
            ' 
            Me.layoutControlItem26.Control = Me.gaugeControl27
            Me.layoutControlItem26.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem26.Location = New System.Drawing.Point(0, 224)
            Me.layoutControlItem26.Name = "layoutControlItem4"
            Me.layoutControlItem26.Size = New System.Drawing.Size(266, 252)
            Me.layoutControlItem26.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem26.TextVisible = False
            ' 
            ' layoutControlItem27
            ' 
            Me.layoutControlItem27.Control = Me.gaugeControl28
            Me.layoutControlItem27.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem27.Location = New System.Drawing.Point(266, 224)
            Me.layoutControlItem27.Name = "layoutControlItem3"
            Me.layoutControlItem27.Size = New System.Drawing.Size(224, 252)
            Me.layoutControlItem27.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem27.TextVisible = False
            ' 
            ' layoutControlItem28
            ' 
            Me.layoutControlItem28.Control = Me.gaugeControl25
            Me.layoutControlItem28.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem28.Location = New System.Drawing.Point(490, 224)
            Me.layoutControlItem28.Name = "layoutControlItem6"
            Me.layoutControlItem28.Size = New System.Drawing.Size(223, 252)
            Me.layoutControlItem28.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem28.TextVisible = False
            ' 
            ' layoutControlItem29
            ' 
            Me.layoutControlItem29.Control = Me.gaugeControl30
            Me.layoutControlItem29.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem29.Location = New System.Drawing.Point(490, 0)
            Me.layoutControlItem29.Name = "layoutControlItem1"
            Me.layoutControlItem29.Size = New System.Drawing.Size(223, 224)
            Me.layoutControlItem29.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem29.TextVisible = False
            ' 
            ' layoutControlItem30
            ' 
            Me.layoutControlItem30.Control = Me.gaugeControl26
            Me.layoutControlItem30.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem30.Location = New System.Drawing.Point(266, 0)
            Me.layoutControlItem30.Name = "layoutControlItem5"
            Me.layoutControlItem30.Size = New System.Drawing.Size(224, 224)
            Me.layoutControlItem30.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem30.TextVisible = False
            ' 
            ' xtraTabPage6
            ' 
            Me.xtraTabPage6.Caption = "Africa Sunset"
            Me.xtraTabPage6.Controls.Add(Me.layoutControl6)
            Me.xtraTabPage6.Name = "xtraTabPage6"
            Me.xtraTabPage6.Padding = New System.Windows.Forms.Padding(3)
            Me.xtraTabPage6.Size = New System.Drawing.Size(719, 482)
            ' 
            ' layoutControl6
            ' 
            Me.layoutControl6.Controls.Add(Me.gaugeControl31)
            Me.layoutControl6.Controls.Add(Me.gaugeControl32)
            Me.layoutControl6.Controls.Add(Me.gaugeControl33)
            Me.layoutControl6.Controls.Add(Me.gaugeControl34)
            Me.layoutControl6.Controls.Add(Me.gaugeControl35)
            Me.layoutControl6.Controls.Add(Me.gaugeControl36)
            Me.layoutControl6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl6.Location = New System.Drawing.Point(3, 3)
            Me.layoutControl6.Name = "layoutControl6"
            Me.layoutControl6.Root = Me.layoutControlGroup6
            Me.layoutControl6.Size = New System.Drawing.Size(713, 476)
            Me.layoutControl6.TabIndex = 3
            Me.layoutControl6.Text = "layoutControl6"
            ' 
            ' gaugeControl31
            ' 
            Me.gaugeControl31.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge6})
            Me.gaugeControl31.Location = New System.Drawing.Point(492, 226)
            Me.gaugeControl31.Name = "gaugeControl31"
            Me.gaugeControl31.Size = New System.Drawing.Size(219, 248)
            Me.gaugeControl31.TabIndex = 9
            ' 
            ' linearGauge6
            ' 
            Me.linearGauge6.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent6})
            Me.linearGauge6.Bounds = New System.Drawing.Rectangle(6, 6, 207, 236)
            Me.linearGauge6.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent6})
            Me.linearGauge6.Name = "linearGauge6"
            Me.linearGauge6.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent11, Me.linearScaleComponent12})
            ' 
            ' linearScaleBackgroundLayerComponent6
            ' 
            Me.linearScaleBackgroundLayerComponent6.LinearScale = Me.linearScaleComponent11
            Me.linearScaleBackgroundLayerComponent6.Name = "linearScaleBackgroundLayerComponent6"
            Me.linearScaleBackgroundLayerComponent6.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.135F)
            Me.linearScaleBackgroundLayerComponent6.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.865F)
            Me.linearScaleBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style7
            Me.linearScaleBackgroundLayerComponent6.ZOrder = 1000
            ' 
            ' linearScaleComponent11
            ' 
            Me.linearScaleComponent11.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent11.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent11.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent11.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent11.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.linearScaleComponent11.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent11.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 33F)
            Me.linearScaleComponent11.MajorTickCount = 6
            Me.linearScaleComponent11.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent11.MajorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent11.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style7_3
            Me.linearScaleComponent11.MajorTickmark.TextOffset = 35F
            Me.linearScaleComponent11.MaxValue = 50F
            Me.linearScaleComponent11.MinorTickCount = 4
            Me.linearScaleComponent11.MinorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent11.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style7_2
            Me.linearScaleComponent11.Name = "linearScaleComponent6"
            Me.linearScaleComponent11.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 217F)
            Me.linearScaleComponent11.Value = 20F
            ' 
            ' linearScaleLevelComponent6
            ' 
            Me.linearScaleLevelComponent6.LinearScale = Me.linearScaleComponent11
            Me.linearScaleLevelComponent6.Name = "linearScaleLevelComponent6"
            Me.linearScaleLevelComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style7
            Me.linearScaleLevelComponent6.ZOrder = -50
            ' 
            ' linearScaleComponent12
            ' 
            Me.linearScaleComponent12.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent12.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent12.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent12.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent12.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.linearScaleComponent12.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent12.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 33F)
            Me.linearScaleComponent12.MajorTickCount = 6
            Me.linearScaleComponent12.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent12.MajorTickmark.ShapeOffset = -22F
            Me.linearScaleComponent12.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style7_3
            Me.linearScaleComponent12.MajorTickmark.TextOffset = -40F
            Me.linearScaleComponent12.MaxValue = 500F
            Me.linearScaleComponent12.MinorTickCount = 4
            Me.linearScaleComponent12.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent12.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style7_2
            Me.linearScaleComponent12.Name = "linearScaleComponent13"
            Me.linearScaleComponent12.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 217F)
            ' 
            ' gaugeControl32
            ' 
            Me.gaugeControl32.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge21})
            Me.gaugeControl32.Location = New System.Drawing.Point(268, 2)
            Me.gaugeControl32.Name = "gaugeControl32"
            Me.gaugeControl32.Size = New System.Drawing.Size(220, 220)
            Me.gaugeControl32.TabIndex = 8
            ' 
            ' circularGauge21
            ' 
            Me.circularGauge21.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent21})
            Me.circularGauge21.Bounds = New System.Drawing.Rectangle(6, 6, 208, 208)
            Me.circularGauge21.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent5})
            Me.circularGauge21.Name = "circularGauge21"
            Me.circularGauge21.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent21})
            Me.circularGauge21.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent21})
            ' 
            ' arcScaleBackgroundLayerComponent21
            ' 
            Me.arcScaleBackgroundLayerComponent21.ArcScale = Me.arcScaleComponent21
            Me.arcScaleBackgroundLayerComponent21.Name = "arcScaleBackgroundLayerComponent21"
            Me.arcScaleBackgroundLayerComponent21.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.815F)
            Me.arcScaleBackgroundLayerComponent21.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style7
            Me.arcScaleBackgroundLayerComponent21.Size = New System.Drawing.SizeF(250F, 154F)
            Me.arcScaleBackgroundLayerComponent21.ZOrder = 1000
            ' 
            ' arcScaleComponent21
            ' 
            Me.arcScaleComponent21.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent21.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent21.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent21.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent21.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent21.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent21.EndAngle = 0F
            Me.arcScaleComponent21.MajorTickCount = 7
            Me.arcScaleComponent21.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent21.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_2
            Me.arcScaleComponent21.MajorTickmark.TextOffset = 22F
            Me.arcScaleComponent21.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent21.MaxValue = 80F
            Me.arcScaleComponent21.MinorTickCount = 4
            Me.arcScaleComponent21.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_1
            Me.arcScaleComponent21.MinValue = 20F
            Me.arcScaleComponent21.Name = "arcScaleComponent21"
            Me.arcScaleComponent21.RadiusX = 83F
            Me.arcScaleComponent21.RadiusY = 83F
            Me.arcScaleComponent21.StartAngle = -180F
            Me.arcScaleComponent21.Value = 20F
            ' 
            ' arcScaleEffectLayerComponent5
            ' 
            Me.arcScaleEffectLayerComponent5.ArcScale = Me.arcScaleComponent21
            Me.arcScaleEffectLayerComponent5.Name = "arcScaleEffectLayerComponent5"
            Me.arcScaleEffectLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Style7
            Me.arcScaleEffectLayerComponent5.Size = New System.Drawing.SizeF(230F, 110F)
            Me.arcScaleEffectLayerComponent5.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent21
            ' 
            Me.arcScaleNeedleComponent21.ArcScale = Me.arcScaleComponent21
            Me.arcScaleNeedleComponent21.EndOffset = -25F
            Me.arcScaleNeedleComponent21.Name = "arcScaleNeedleComponent21"
            Me.arcScaleNeedleComponent21.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style7
            Me.arcScaleNeedleComponent21.StartOffset = -21F
            Me.arcScaleNeedleComponent21.ZOrder = -50
            ' 
            ' gaugeControl33
            ' 
            Me.gaugeControl33.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge22})
            Me.gaugeControl33.Location = New System.Drawing.Point(2, 226)
            Me.gaugeControl33.Name = "gaugeControl33"
            Me.gaugeControl33.Size = New System.Drawing.Size(262, 248)
            Me.gaugeControl33.TabIndex = 7
            ' 
            ' circularGauge22
            ' 
            Me.circularGauge22.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent22})
            Me.circularGauge22.Bounds = New System.Drawing.Rectangle(6, 6, 250, 236)
            Me.circularGauge22.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent7})
            Me.circularGauge22.Name = "circularGauge22"
            Me.circularGauge22.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent22})
            Me.circularGauge22.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent22})
            ' 
            ' arcScaleBackgroundLayerComponent22
            ' 
            Me.arcScaleBackgroundLayerComponent22.ArcScale = Me.arcScaleComponent22
            Me.arcScaleBackgroundLayerComponent22.Name = "arcScaleBackgroundLayerComponent22"
            Me.arcScaleBackgroundLayerComponent22.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.77F, 0.77F)
            Me.arcScaleBackgroundLayerComponent22.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style7Left
            Me.arcScaleBackgroundLayerComponent22.ZOrder = 1000
            ' 
            ' arcScaleComponent22
            ' 
            Me.arcScaleComponent22.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent22.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent22.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent22.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent22.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 12F)
            Me.arcScaleComponent22.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent22.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(195F, 195F)
            Me.arcScaleComponent22.EndAngle = -90F
            Me.arcScaleComponent22.MajorTickCount = 5
            Me.arcScaleComponent22.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent22.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_2
            Me.arcScaleComponent22.MajorTickmark.TextOffset = 28F
            Me.arcScaleComponent22.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent22.MaxValue = 60F
            Me.arcScaleComponent22.MinorTickCount = 4
            Me.arcScaleComponent22.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_1
            Me.arcScaleComponent22.MinValue = 20F
            Me.arcScaleComponent22.Name = "arcScaleComponent22"
            Me.arcScaleComponent22.RadiusX = 127F
            Me.arcScaleComponent22.RadiusY = 127F
            Me.arcScaleComponent22.StartAngle = -180F
            Me.arcScaleComponent22.Value = 30F
            ' 
            ' arcScaleEffectLayerComponent7
            ' 
            Me.arcScaleEffectLayerComponent7.ArcScale = Me.arcScaleComponent22
            Me.arcScaleEffectLayerComponent7.Name = "arcScaleEffectLayerComponent7"
            Me.arcScaleEffectLayerComponent7.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.85F, 1.125F)
            Me.arcScaleEffectLayerComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularQuarter_Style7Left
            Me.arcScaleEffectLayerComponent7.Size = New System.Drawing.SizeF(210F, 160F)
            Me.arcScaleEffectLayerComponent7.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent22
            ' 
            Me.arcScaleNeedleComponent22.ArcScale = Me.arcScaleComponent22
            Me.arcScaleNeedleComponent22.EndOffset = -25F
            Me.arcScaleNeedleComponent22.Name = "arcScaleNeedleComponent22"
            Me.arcScaleNeedleComponent22.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style7
            Me.arcScaleNeedleComponent22.StartOffset = -29F
            Me.arcScaleNeedleComponent22.ZOrder = -50
            ' 
            ' gaugeControl34
            ' 
            Me.gaugeControl34.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge23})
            Me.gaugeControl34.Location = New System.Drawing.Point(268, 226)
            Me.gaugeControl34.Name = "gaugeControl34"
            Me.gaugeControl34.Size = New System.Drawing.Size(220, 248)
            Me.gaugeControl34.TabIndex = 6
            ' 
            ' circularGauge23
            ' 
            Me.circularGauge23.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent23})
            Me.circularGauge23.Bounds = New System.Drawing.Rectangle(6, 6, 208, 236)
            Me.circularGauge23.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent8})
            Me.circularGauge23.Name = "circularGauge23"
            Me.circularGauge23.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent23})
            Me.circularGauge23.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent23})
            ' 
            ' arcScaleBackgroundLayerComponent23
            ' 
            Me.arcScaleBackgroundLayerComponent23.ArcScale = Me.arcScaleComponent23
            Me.arcScaleBackgroundLayerComponent23.Name = "arcScaleBackgroundLayerComponent23"
            Me.arcScaleBackgroundLayerComponent23.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.61F)
            Me.arcScaleBackgroundLayerComponent23.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style7
            Me.arcScaleBackgroundLayerComponent23.Size = New System.Drawing.SizeF(250F, 205F)
            Me.arcScaleBackgroundLayerComponent23.ZOrder = 1000
            ' 
            ' arcScaleComponent23
            ' 
            Me.arcScaleComponent23.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent23.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent23.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent23.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent23.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent23.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent23.EndAngle = 30F
            Me.arcScaleComponent23.MajorTickCount = 9
            Me.arcScaleComponent23.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent23.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_2
            Me.arcScaleComponent23.MajorTickmark.TextOffset = 22F
            Me.arcScaleComponent23.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent23.MaxValue = 120F
            Me.arcScaleComponent23.MinorTickCount = 4
            Me.arcScaleComponent23.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_1
            Me.arcScaleComponent23.Name = "arcScaleComponent23"
            Me.arcScaleComponent23.RadiusX = 83F
            Me.arcScaleComponent23.RadiusY = 83F
            Me.arcScaleComponent23.StartAngle = -210F
            Me.arcScaleComponent23.Value = 20F
            ' 
            ' arcScaleEffectLayerComponent8
            ' 
            Me.arcScaleEffectLayerComponent8.ArcScale = Me.arcScaleComponent23
            Me.arcScaleEffectLayerComponent8.Name = "arcScaleEffectLayerComponent8"
            Me.arcScaleEffectLayerComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularThreeFourth_Style7
            Me.arcScaleEffectLayerComponent8.Size = New System.Drawing.SizeF(230F, 110F)
            Me.arcScaleEffectLayerComponent8.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent23
            ' 
            Me.arcScaleNeedleComponent23.ArcScale = Me.arcScaleComponent23
            Me.arcScaleNeedleComponent23.EndOffset = -25F
            Me.arcScaleNeedleComponent23.Name = "arcScaleNeedleComponent23"
            Me.arcScaleNeedleComponent23.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style7
            Me.arcScaleNeedleComponent23.StartOffset = -21F
            Me.arcScaleNeedleComponent23.ZOrder = -50
            ' 
            ' gaugeControl35
            ' 
            Me.gaugeControl35.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge6})
            Me.gaugeControl35.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl35.Name = "gaugeControl35"
            Me.gaugeControl35.Size = New System.Drawing.Size(262, 220)
            Me.gaugeControl35.TabIndex = 5
            ' 
            ' digitalGauge6
            ' 
            Me.digitalGauge6.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
            Me.digitalGauge6.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
            Me.digitalGauge6.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent6})
            Me.digitalGauge6.Bounds = New System.Drawing.Rectangle(6, 6, 250, 208)
            Me.digitalGauge6.DigitCount = 5
            Me.digitalGauge6.Name = "digitalGauge6"
            Me.digitalGauge6.Text = "00,000"
            ' 
            ' digitalBackgroundLayerComponent6
            ' 
            Me.digitalBackgroundLayerComponent6.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125F, 99.9625F)
            Me.digitalBackgroundLayerComponent6.Name = "digitalBackgroundLayerComponent6"
            Me.digitalBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
            Me.digitalBackgroundLayerComponent6.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
            Me.digitalBackgroundLayerComponent6.ZOrder = 1000
            ' 
            ' gaugeControl36
            ' 
            Me.gaugeControl36.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge24})
            Me.gaugeControl36.Location = New System.Drawing.Point(492, 2)
            Me.gaugeControl36.Name = "gaugeControl36"
            Me.gaugeControl36.Size = New System.Drawing.Size(219, 220)
            Me.gaugeControl36.TabIndex = 4
            ' 
            ' circularGauge24
            ' 
            Me.circularGauge24.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent24})
            Me.circularGauge24.Bounds = New System.Drawing.Rectangle(6, 6, 207, 208)
            Me.circularGauge24.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent6})
            Me.circularGauge24.Name = "circularGauge24"
            Me.circularGauge24.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent24})
            Me.circularGauge24.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent24})
            ' 
            ' arcScaleBackgroundLayerComponent24
            ' 
            Me.arcScaleBackgroundLayerComponent24.ArcScale = Me.arcScaleComponent24
            Me.arcScaleBackgroundLayerComponent24.Name = "arcScaleBackgroundLayerComponent24"
            Me.arcScaleBackgroundLayerComponent24.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style7
            Me.arcScaleBackgroundLayerComponent24.ZOrder = 1000
            ' 
            ' arcScaleComponent24
            ' 
            Me.arcScaleComponent24.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent24.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent24.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent24.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent24.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent24.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent24.EndAngle = 60F
            Me.arcScaleComponent24.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent24.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_2
            Me.arcScaleComponent24.MajorTickmark.TextOffset = 22F
            Me.arcScaleComponent24.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent24.MaxValue = 100F
            Me.arcScaleComponent24.MinorTickCount = 4
            Me.arcScaleComponent24.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_1
            Me.arcScaleComponent24.Name = "arcScaleComponent24"
            Me.arcScaleComponent24.RadiusX = 83F
            Me.arcScaleComponent24.RadiusY = 83F
            Me.arcScaleComponent24.StartAngle = -240F
            ' 
            ' arcScaleEffectLayerComponent6
            ' 
            Me.arcScaleEffectLayerComponent6.ArcScale = Me.arcScaleComponent24
            Me.arcScaleEffectLayerComponent6.Name = "arcScaleEffectLayerComponent6"
            Me.arcScaleEffectLayerComponent6.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1.06F)
            Me.arcScaleEffectLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Style7
            Me.arcScaleEffectLayerComponent6.Size = New System.Drawing.SizeF(235F, 110F)
            Me.arcScaleEffectLayerComponent6.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent24
            ' 
            Me.arcScaleNeedleComponent24.ArcScale = Me.arcScaleComponent24
            Me.arcScaleNeedleComponent24.EndOffset = -25F
            Me.arcScaleNeedleComponent24.Name = "arcScaleNeedleComponent24"
            Me.arcScaleNeedleComponent24.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style7
            Me.arcScaleNeedleComponent24.StartOffset = -21F
            Me.arcScaleNeedleComponent24.ZOrder = -50
            ' 
            ' layoutControlGroup6
            ' 
            Me.layoutControlGroup6.AllowDrawBackground = False
            Me.layoutControlGroup6.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup6.GroupBordersVisible = False
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem31, Me.layoutControlItem32, Me.layoutControlItem33, Me.layoutControlItem34, Me.layoutControlItem35, Me.layoutControlItem36})
            Me.layoutControlGroup6.Name = "layoutControlGroup1"
            Me.layoutControlGroup6.Size = New System.Drawing.Size(713, 476)
            Me.layoutControlGroup6.TextVisible = False
            ' 
            ' layoutControlItem31
            ' 
            Me.layoutControlItem31.Control = Me.gaugeControl35
            Me.layoutControlItem31.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem31.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem31.Name = "layoutControlItem2"
            Me.layoutControlItem31.Size = New System.Drawing.Size(266, 224)
            Me.layoutControlItem31.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem31.TextVisible = False
            ' 
            ' layoutControlItem32
            ' 
            Me.layoutControlItem32.Control = Me.gaugeControl33
            Me.layoutControlItem32.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem32.Location = New System.Drawing.Point(0, 224)
            Me.layoutControlItem32.Name = "layoutControlItem4"
            Me.layoutControlItem32.Size = New System.Drawing.Size(266, 252)
            Me.layoutControlItem32.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem32.TextVisible = False
            ' 
            ' layoutControlItem33
            ' 
            Me.layoutControlItem33.Control = Me.gaugeControl34
            Me.layoutControlItem33.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem33.Location = New System.Drawing.Point(266, 224)
            Me.layoutControlItem33.Name = "layoutControlItem3"
            Me.layoutControlItem33.Size = New System.Drawing.Size(224, 252)
            Me.layoutControlItem33.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem33.TextVisible = False
            ' 
            ' layoutControlItem34
            ' 
            Me.layoutControlItem34.Control = Me.gaugeControl31
            Me.layoutControlItem34.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem34.Location = New System.Drawing.Point(490, 224)
            Me.layoutControlItem34.Name = "layoutControlItem6"
            Me.layoutControlItem34.Size = New System.Drawing.Size(223, 252)
            Me.layoutControlItem34.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem34.TextVisible = False
            ' 
            ' layoutControlItem35
            ' 
            Me.layoutControlItem35.Control = Me.gaugeControl36
            Me.layoutControlItem35.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem35.Location = New System.Drawing.Point(490, 0)
            Me.layoutControlItem35.Name = "layoutControlItem1"
            Me.layoutControlItem35.Size = New System.Drawing.Size(223, 224)
            Me.layoutControlItem35.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem35.TextVisible = False
            ' 
            ' layoutControlItem36
            ' 
            Me.layoutControlItem36.Control = Me.gaugeControl32
            Me.layoutControlItem36.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem36.Location = New System.Drawing.Point(266, 0)
            Me.layoutControlItem36.Name = "layoutControlItem5"
            Me.layoutControlItem36.Size = New System.Drawing.Size(224, 224)
            Me.layoutControlItem36.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem36.TextVisible = False
            ' 
            ' xtraTabPage7
            ' 
            Me.xtraTabPage7.Caption = "Mechanical"
            Me.xtraTabPage7.Controls.Add(Me.layoutControl7)
            Me.xtraTabPage7.Name = "xtraTabPage7"
            Me.xtraTabPage7.Padding = New System.Windows.Forms.Padding(3)
            Me.xtraTabPage7.Size = New System.Drawing.Size(719, 482)
            ' 
            ' layoutControl7
            ' 
            Me.layoutControl7.Controls.Add(Me.gaugeControl37)
            Me.layoutControl7.Controls.Add(Me.gaugeControl38)
            Me.layoutControl7.Controls.Add(Me.gaugeControl39)
            Me.layoutControl7.Controls.Add(Me.gaugeControl40)
            Me.layoutControl7.Controls.Add(Me.gaugeControl41)
            Me.layoutControl7.Controls.Add(Me.gaugeControl42)
            Me.layoutControl7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl7.Location = New System.Drawing.Point(3, 3)
            Me.layoutControl7.Name = "layoutControl7"
            Me.layoutControl7.Root = Me.layoutControlGroup7
            Me.layoutControl7.Size = New System.Drawing.Size(713, 476)
            Me.layoutControl7.TabIndex = 3
            Me.layoutControl7.Text = "layoutControl7"
            ' 
            ' gaugeControl37
            ' 
            Me.gaugeControl37.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge7})
            Me.gaugeControl37.Location = New System.Drawing.Point(492, 226)
            Me.gaugeControl37.Name = "gaugeControl37"
            Me.gaugeControl37.Size = New System.Drawing.Size(219, 248)
            Me.gaugeControl37.TabIndex = 9
            ' 
            ' linearGauge7
            ' 
            Me.linearGauge7.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent7})
            Me.linearGauge7.Bounds = New System.Drawing.Rectangle(6, 6, 207, 236)
            Me.linearGauge7.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent7})
            Me.linearGauge7.Name = "linearGauge7"
            Me.linearGauge7.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent13, Me.linearScaleComponent14})
            ' 
            ' linearScaleBackgroundLayerComponent7
            ' 
            Me.linearScaleBackgroundLayerComponent7.LinearScale = Me.linearScaleComponent13
            Me.linearScaleBackgroundLayerComponent7.Name = "linearScaleBackgroundLayerComponent7"
            Me.linearScaleBackgroundLayerComponent7.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.14F)
            Me.linearScaleBackgroundLayerComponent7.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.86F)
            Me.linearScaleBackgroundLayerComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style8
            Me.linearScaleBackgroundLayerComponent7.ZOrder = 1000
            ' 
            ' linearScaleComponent13
            ' 
            Me.linearScaleComponent13.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent13.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent13.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent13.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent13.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 9F)
            Me.linearScaleComponent13.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.linearScaleComponent13.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 35F)
            Me.linearScaleComponent13.MajorTickCount = 6
            Me.linearScaleComponent13.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent13.MajorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent13.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style8_3
            Me.linearScaleComponent13.MajorTickmark.TextOffset = 35F
            Me.linearScaleComponent13.MaxValue = 50F
            Me.linearScaleComponent13.MinorTickCount = 4
            Me.linearScaleComponent13.MinorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent13.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style8_1
            Me.linearScaleComponent13.Name = "linearScaleComponent7"
            Me.linearScaleComponent13.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F)
            Me.linearScaleComponent13.Value = 25F
            ' 
            ' linearScaleLevelComponent7
            ' 
            Me.linearScaleLevelComponent7.LinearScale = Me.linearScaleComponent13
            Me.linearScaleLevelComponent7.Name = "linearScaleLevelComponent7"
            Me.linearScaleLevelComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style8
            Me.linearScaleLevelComponent7.ZOrder = -50
            ' 
            ' linearScaleComponent14
            ' 
            Me.linearScaleComponent14.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent14.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent14.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent14.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent14.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 9F)
            Me.linearScaleComponent14.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.linearScaleComponent14.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 35F)
            Me.linearScaleComponent14.MajorTickCount = 6
            Me.linearScaleComponent14.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent14.MajorTickmark.ShapeOffset = -22F
            Me.linearScaleComponent14.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style8_3
            Me.linearScaleComponent14.MajorTickmark.TextOffset = -35F
            Me.linearScaleComponent14.MaxValue = 500F
            Me.linearScaleComponent14.MinorTickCount = 4
            Me.linearScaleComponent14.MinorTickmark.ShapeOffset = -16F
            Me.linearScaleComponent14.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style8_1
            Me.linearScaleComponent14.Name = "linearScaleComponent14"
            Me.linearScaleComponent14.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F)
            ' 
            ' gaugeControl38
            ' 
            Me.gaugeControl38.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge25})
            Me.gaugeControl38.Location = New System.Drawing.Point(268, 2)
            Me.gaugeControl38.Name = "gaugeControl38"
            Me.gaugeControl38.Size = New System.Drawing.Size(220, 220)
            Me.gaugeControl38.TabIndex = 8
            ' 
            ' circularGauge25
            ' 
            Me.circularGauge25.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent25})
            Me.circularGauge25.Bounds = New System.Drawing.Rectangle(6, 6, 208, 208)
            Me.circularGauge25.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent9})
            Me.circularGauge25.Name = "circularGauge25"
            Me.circularGauge25.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent25})
            Me.circularGauge25.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent25})
            Me.circularGauge25.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent17})
            ' 
            ' arcScaleBackgroundLayerComponent25
            ' 
            Me.arcScaleBackgroundLayerComponent25.ArcScale = Me.arcScaleComponent25
            Me.arcScaleBackgroundLayerComponent25.Name = "arcScaleBackgroundLayerComponent25"
            Me.arcScaleBackgroundLayerComponent25.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.655F)
            Me.arcScaleBackgroundLayerComponent25.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style8
            Me.arcScaleBackgroundLayerComponent25.Size = New System.Drawing.SizeF(250F, 192F)
            Me.arcScaleBackgroundLayerComponent25.ZOrder = 1000
            ' 
            ' arcScaleComponent25
            ' 
            Me.arcScaleComponent25.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent25.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent25.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent25.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent25.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent25.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent25.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent25.EndAngle = -0.6F
            Me.arcScaleComponent25.MajorTickCount = 7
            Me.arcScaleComponent25.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent25.MajorTickmark.ShapeOffset = -9F
            Me.arcScaleComponent25.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style8_5
            Me.arcScaleComponent25.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent25.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent25.MaxValue = 80F
            Me.arcScaleComponent25.MinorTickCount = 4
            Me.arcScaleComponent25.MinorTickmark.ShapeOffset = -9F
            Me.arcScaleComponent25.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style8_4
            Me.arcScaleComponent25.MinValue = 20F
            Me.arcScaleComponent25.Name = "arcScaleComponent25"
            Me.arcScaleComponent25.RadiusX = 98F
            Me.arcScaleComponent25.RadiusY = 98F
            Me.arcScaleComponent25.StartAngle = -179.4F
            Me.arcScaleComponent25.Value = 20F
            ' 
            ' arcScaleEffectLayerComponent9
            ' 
            Me.arcScaleEffectLayerComponent9.ArcScale = Me.arcScaleComponent25
            Me.arcScaleEffectLayerComponent9.Name = "arcScaleEffectLayerComponent9"
            Me.arcScaleEffectLayerComponent9.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Style8
            Me.arcScaleEffectLayerComponent9.Size = New System.Drawing.SizeF(196F, 98F)
            Me.arcScaleEffectLayerComponent9.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent25
            ' 
            Me.arcScaleNeedleComponent25.ArcScale = Me.arcScaleComponent25
            Me.arcScaleNeedleComponent25.Name = "arcScaleNeedleComponent25"
            Me.arcScaleNeedleComponent25.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style8
            Me.arcScaleNeedleComponent25.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent17
            ' 
            Me.arcScaleSpindleCapComponent17.ArcScale = Me.arcScaleComponent25
            Me.arcScaleSpindleCapComponent17.Name = "arcScaleSpindleCapComponent17"
            Me.arcScaleSpindleCapComponent17.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style8
            Me.arcScaleSpindleCapComponent17.Size = New System.Drawing.SizeF(35F, 35F)
            Me.arcScaleSpindleCapComponent17.ZOrder = -100
            ' 
            ' gaugeControl39
            ' 
            Me.gaugeControl39.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge26})
            Me.gaugeControl39.Location = New System.Drawing.Point(2, 226)
            Me.gaugeControl39.Name = "gaugeControl39"
            Me.gaugeControl39.Size = New System.Drawing.Size(262, 248)
            Me.gaugeControl39.TabIndex = 7
            ' 
            ' circularGauge26
            ' 
            Me.circularGauge26.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent26})
            Me.circularGauge26.Bounds = New System.Drawing.Rectangle(6, 6, 250, 236)
            Me.circularGauge26.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent11})
            Me.circularGauge26.Name = "circularGauge26"
            Me.circularGauge26.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent26})
            Me.circularGauge26.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent26})
            Me.circularGauge26.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent19})
            ' 
            ' arcScaleBackgroundLayerComponent26
            ' 
            Me.arcScaleBackgroundLayerComponent26.ArcScale = Me.arcScaleComponent26
            Me.arcScaleBackgroundLayerComponent26.Name = "arcScaleBackgroundLayerComponent26"
            Me.arcScaleBackgroundLayerComponent26.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.718F, 0.718F)
            Me.arcScaleBackgroundLayerComponent26.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style8Left
            Me.arcScaleBackgroundLayerComponent26.ZOrder = 1000
            ' 
            ' arcScaleComponent26
            ' 
            Me.arcScaleComponent26.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent26.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent26.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent26.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent26.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent26.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent26.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(180F, 180F)
            Me.arcScaleComponent26.EndAngle = -90F
            Me.arcScaleComponent26.MajorTickCount = 5
            Me.arcScaleComponent26.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent26.MajorTickmark.ShapeOffset = -9.5F
            Me.arcScaleComponent26.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style8_5
            Me.arcScaleComponent26.MajorTickmark.TextOffset = -27F
            Me.arcScaleComponent26.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent26.MaxValue = 60F
            Me.arcScaleComponent26.MinorTickCount = 4
            Me.arcScaleComponent26.MinorTickmark.ShapeOffset = -9.5F
            Me.arcScaleComponent26.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style8_4
            Me.arcScaleComponent26.MinValue = 20F
            Me.arcScaleComponent26.Name = "arcScaleComponent26"
            Me.arcScaleComponent26.RadiusX = 142F
            Me.arcScaleComponent26.RadiusY = 142F
            Me.arcScaleComponent26.StartAngle = -180F
            Me.arcScaleComponent26.Value = 30F
            ' 
            ' arcScaleEffectLayerComponent11
            ' 
            Me.arcScaleEffectLayerComponent11.ArcScale = Me.arcScaleComponent26
            Me.arcScaleEffectLayerComponent11.Name = "arcScaleEffectLayerComponent11"
            Me.arcScaleEffectLayerComponent11.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.8F, 1.1F)
            Me.arcScaleEffectLayerComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularQuarter_Style8Left
            Me.arcScaleEffectLayerComponent11.Size = New System.Drawing.SizeF(200F, 145F)
            Me.arcScaleEffectLayerComponent11.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent26
            ' 
            Me.arcScaleNeedleComponent26.ArcScale = Me.arcScaleComponent26
            Me.arcScaleNeedleComponent26.Name = "arcScaleNeedleComponent26"
            Me.arcScaleNeedleComponent26.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style8
            Me.arcScaleNeedleComponent26.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent19
            ' 
            Me.arcScaleSpindleCapComponent19.ArcScale = Me.arcScaleComponent26
            Me.arcScaleSpindleCapComponent19.Name = "arcScaleSpindleCapComponent19"
            Me.arcScaleSpindleCapComponent19.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style8
            Me.arcScaleSpindleCapComponent19.Size = New System.Drawing.SizeF(45F, 45F)
            Me.arcScaleSpindleCapComponent19.ZOrder = -100
            ' 
            ' gaugeControl40
            ' 
            Me.gaugeControl40.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge27})
            Me.gaugeControl40.Location = New System.Drawing.Point(268, 226)
            Me.gaugeControl40.Name = "gaugeControl40"
            Me.gaugeControl40.Size = New System.Drawing.Size(220, 248)
            Me.gaugeControl40.TabIndex = 6
            ' 
            ' circularGauge27
            ' 
            Me.circularGauge27.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent27})
            Me.circularGauge27.Bounds = New System.Drawing.Rectangle(6, 6, 208, 236)
            Me.circularGauge27.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent12})
            Me.circularGauge27.Name = "circularGauge27"
            Me.circularGauge27.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent27})
            Me.circularGauge27.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent27, Me.arcScaleComponent46})
            Me.circularGauge27.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent20})
            ' 
            ' arcScaleBackgroundLayerComponent27
            ' 
            Me.arcScaleBackgroundLayerComponent27.ArcScale = Me.arcScaleComponent27
            Me.arcScaleBackgroundLayerComponent27.Name = "arcScaleBackgroundLayerComponent27"
            Me.arcScaleBackgroundLayerComponent27.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.61F)
            Me.arcScaleBackgroundLayerComponent27.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style8
            Me.arcScaleBackgroundLayerComponent27.Size = New System.Drawing.SizeF(250F, 203F)
            Me.arcScaleBackgroundLayerComponent27.ZOrder = 1000
            ' 
            ' arcScaleComponent27
            ' 
            Me.arcScaleComponent27.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent27.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent27.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent27.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent27.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent27.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent27.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent27.EndAngle = 30F
            Me.arcScaleComponent27.MajorTickCount = 9
            Me.arcScaleComponent27.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent27.MajorTickmark.ShapeOffset = -9.5F
            Me.arcScaleComponent27.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style8_5
            Me.arcScaleComponent27.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent27.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent27.MaxValue = 200F
            Me.arcScaleComponent27.MinorTickCount = 4
            Me.arcScaleComponent27.MinorTickmark.ShapeOffset = -9.5F
            Me.arcScaleComponent27.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style8_4
            Me.arcScaleComponent27.Name = "arcScaleComponent27"
            Me.arcScaleComponent27.RadiusX = 98F
            Me.arcScaleComponent27.RadiusY = 98F
            Me.arcScaleComponent27.StartAngle = -210F
            Me.arcScaleComponent27.Value = 20F
            ' 
            ' arcScaleEffectLayerComponent12
            ' 
            Me.arcScaleEffectLayerComponent12.ArcScale = Me.arcScaleComponent27
            Me.arcScaleEffectLayerComponent12.Name = "arcScaleEffectLayerComponent12"
            Me.arcScaleEffectLayerComponent12.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularThreeFourth_Style8
            Me.arcScaleEffectLayerComponent12.Size = New System.Drawing.SizeF(220F, 100F)
            Me.arcScaleEffectLayerComponent12.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent27
            ' 
            Me.arcScaleNeedleComponent27.ArcScale = Me.arcScaleComponent27
            Me.arcScaleNeedleComponent27.Name = "arcScaleNeedleComponent27"
            Me.arcScaleNeedleComponent27.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style8
            Me.arcScaleNeedleComponent27.ZOrder = -50
            ' 
            ' arcScaleComponent46
            ' 
            Me.arcScaleComponent46.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent46.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent46.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent46.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent46.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            Me.arcScaleComponent46.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent46.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent46.EndAngle = -30F
            Me.arcScaleComponent46.MajorTickCount = 7
            Me.arcScaleComponent46.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent46.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style8_2
            Me.arcScaleComponent46.MajorTickmark.TextOffset = -12F
            Me.arcScaleComponent46.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent46.MaxValue = 700F
            Me.arcScaleComponent46.MinorTickCount = 4
            Me.arcScaleComponent46.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style8_1
            Me.arcScaleComponent46.MinValue = 100F
            Me.arcScaleComponent46.Name = "arcScaleComponent46"
            Me.arcScaleComponent46.RadiusX = 50F
            Me.arcScaleComponent46.RadiusY = 50F
            Me.arcScaleComponent46.StartAngle = -210F
            Me.arcScaleComponent46.Value = 100F
            ' 
            ' arcScaleSpindleCapComponent20
            ' 
            Me.arcScaleSpindleCapComponent20.ArcScale = Me.arcScaleComponent27
            Me.arcScaleSpindleCapComponent20.Name = "arcScaleSpindleCapComponent20"
            Me.arcScaleSpindleCapComponent20.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style8
            Me.arcScaleSpindleCapComponent20.Size = New System.Drawing.SizeF(35F, 35F)
            Me.arcScaleSpindleCapComponent20.ZOrder = -100
            ' 
            ' gaugeControl41
            ' 
            Me.gaugeControl41.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge7})
            Me.gaugeControl41.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl41.Name = "gaugeControl41"
            Me.gaugeControl41.Size = New System.Drawing.Size(262, 220)
            Me.gaugeControl41.TabIndex = 5
            ' 
            ' digitalGauge7
            ' 
            Me.digitalGauge7.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
            Me.digitalGauge7.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
            Me.digitalGauge7.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent7})
            Me.digitalGauge7.Bounds = New System.Drawing.Rectangle(6, 6, 250, 208)
            Me.digitalGauge7.DigitCount = 5
            Me.digitalGauge7.Name = "digitalGauge7"
            Me.digitalGauge7.Text = "00,000"
            ' 
            ' digitalBackgroundLayerComponent7
            ' 
            Me.digitalBackgroundLayerComponent7.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125F, 99.9625F)
            Me.digitalBackgroundLayerComponent7.Name = "digitalBackgroundLayerComponent7"
            Me.digitalBackgroundLayerComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style8
            Me.digitalBackgroundLayerComponent7.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
            Me.digitalBackgroundLayerComponent7.ZOrder = 1000
            ' 
            ' gaugeControl42
            ' 
            Me.gaugeControl42.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge28})
            Me.gaugeControl42.Location = New System.Drawing.Point(492, 2)
            Me.gaugeControl42.Name = "gaugeControl42"
            Me.gaugeControl42.Size = New System.Drawing.Size(219, 220)
            Me.gaugeControl42.TabIndex = 4
            ' 
            ' circularGauge28
            ' 
            Me.circularGauge28.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent28})
            Me.circularGauge28.Bounds = New System.Drawing.Rectangle(6, 6, 207, 208)
            Me.circularGauge28.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent10})
            Me.circularGauge28.Name = "circularGauge28"
            Me.circularGauge28.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent28})
            Me.circularGauge28.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent28})
            Me.circularGauge28.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent18})
            ' 
            ' arcScaleBackgroundLayerComponent28
            ' 
            Me.arcScaleBackgroundLayerComponent28.ArcScale = Me.arcScaleComponent28
            Me.arcScaleBackgroundLayerComponent28.Name = "arcScaleBackgroundLayerComponent28"
            Me.arcScaleBackgroundLayerComponent28.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style8
            Me.arcScaleBackgroundLayerComponent28.ZOrder = 1000
            ' 
            ' arcScaleComponent28
            ' 
            Me.arcScaleComponent28.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent28.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent28.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent28.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent28.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent28.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent28.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent28.EndAngle = 60F
            Me.arcScaleComponent28.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent28.MajorTickmark.ShapeOffset = -9.5F
            Me.arcScaleComponent28.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.05F, 1F)
            Me.arcScaleComponent28.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style8_5
            Me.arcScaleComponent28.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent28.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent28.MaxValue = 100F
            Me.arcScaleComponent28.MinorTickCount = 4
            Me.arcScaleComponent28.MinorTickmark.ShapeOffset = -9.5F
            Me.arcScaleComponent28.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style8_4
            Me.arcScaleComponent28.Name = "arcScaleComponent28"
            Me.arcScaleComponent28.RadiusX = 98F
            Me.arcScaleComponent28.RadiusY = 98F
            Me.arcScaleComponent28.StartAngle = -240F
            ' 
            ' arcScaleEffectLayerComponent10
            ' 
            Me.arcScaleEffectLayerComponent10.ArcScale = Me.arcScaleComponent28
            Me.arcScaleEffectLayerComponent10.Name = "arcScaleEffectLayerComponent10"
            Me.arcScaleEffectLayerComponent10.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Style8
            Me.arcScaleEffectLayerComponent10.Size = New System.Drawing.SizeF(196F, 90F)
            Me.arcScaleEffectLayerComponent10.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent28
            ' 
            Me.arcScaleNeedleComponent28.ArcScale = Me.arcScaleComponent28
            Me.arcScaleNeedleComponent28.Name = "arcScaleNeedleComponent28"
            Me.arcScaleNeedleComponent28.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style8
            Me.arcScaleNeedleComponent28.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent18
            ' 
            Me.arcScaleSpindleCapComponent18.ArcScale = Me.arcScaleComponent28
            Me.arcScaleSpindleCapComponent18.Name = "arcScaleSpindleCapComponent18"
            Me.arcScaleSpindleCapComponent18.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style8
            Me.arcScaleSpindleCapComponent18.Size = New System.Drawing.SizeF(35F, 35F)
            Me.arcScaleSpindleCapComponent18.ZOrder = -100
            ' 
            ' layoutControlGroup7
            ' 
            Me.layoutControlGroup7.AllowDrawBackground = False
            Me.layoutControlGroup7.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup7.GroupBordersVisible = False
            Me.layoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem37, Me.layoutControlItem38, Me.layoutControlItem39, Me.layoutControlItem40, Me.layoutControlItem41, Me.layoutControlItem42})
            Me.layoutControlGroup7.Name = "layoutControlGroup1"
            Me.layoutControlGroup7.Size = New System.Drawing.Size(713, 476)
            Me.layoutControlGroup7.TextVisible = False
            ' 
            ' layoutControlItem37
            ' 
            Me.layoutControlItem37.Control = Me.gaugeControl41
            Me.layoutControlItem37.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem37.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem37.Name = "layoutControlItem2"
            Me.layoutControlItem37.Size = New System.Drawing.Size(266, 224)
            Me.layoutControlItem37.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem37.TextVisible = False
            ' 
            ' layoutControlItem38
            ' 
            Me.layoutControlItem38.Control = Me.gaugeControl39
            Me.layoutControlItem38.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem38.Location = New System.Drawing.Point(0, 224)
            Me.layoutControlItem38.Name = "layoutControlItem4"
            Me.layoutControlItem38.Size = New System.Drawing.Size(266, 252)
            Me.layoutControlItem38.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem38.TextVisible = False
            ' 
            ' layoutControlItem39
            ' 
            Me.layoutControlItem39.Control = Me.gaugeControl40
            Me.layoutControlItem39.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem39.Location = New System.Drawing.Point(266, 224)
            Me.layoutControlItem39.Name = "layoutControlItem3"
            Me.layoutControlItem39.Size = New System.Drawing.Size(224, 252)
            Me.layoutControlItem39.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem39.TextVisible = False
            ' 
            ' layoutControlItem40
            ' 
            Me.layoutControlItem40.Control = Me.gaugeControl37
            Me.layoutControlItem40.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem40.Location = New System.Drawing.Point(490, 224)
            Me.layoutControlItem40.Name = "layoutControlItem6"
            Me.layoutControlItem40.Size = New System.Drawing.Size(223, 252)
            Me.layoutControlItem40.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem40.TextVisible = False
            ' 
            ' layoutControlItem41
            ' 
            Me.layoutControlItem41.Control = Me.gaugeControl42
            Me.layoutControlItem41.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem41.Location = New System.Drawing.Point(490, 0)
            Me.layoutControlItem41.Name = "layoutControlItem1"
            Me.layoutControlItem41.Size = New System.Drawing.Size(223, 224)
            Me.layoutControlItem41.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem41.TextVisible = False
            ' 
            ' layoutControlItem42
            ' 
            Me.layoutControlItem42.Control = Me.gaugeControl38
            Me.layoutControlItem42.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem42.Location = New System.Drawing.Point(266, 0)
            Me.layoutControlItem42.Name = "layoutControlItem5"
            Me.layoutControlItem42.Size = New System.Drawing.Size(224, 224)
            Me.layoutControlItem42.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem42.TextVisible = False
            ' 
            ' xtraTabPage8
            ' 
            Me.xtraTabPage8.Caption = "Silver Blur"
            Me.xtraTabPage8.Controls.Add(Me.layoutControl8)
            Me.xtraTabPage8.Name = "xtraTabPage8"
            Me.xtraTabPage8.Padding = New System.Windows.Forms.Padding(3)
            Me.xtraTabPage8.Size = New System.Drawing.Size(719, 482)
            ' 
            ' layoutControl8
            ' 
            Me.layoutControl8.Controls.Add(Me.gaugeControl43)
            Me.layoutControl8.Controls.Add(Me.gaugeControl44)
            Me.layoutControl8.Controls.Add(Me.gaugeControl45)
            Me.layoutControl8.Controls.Add(Me.gaugeControl46)
            Me.layoutControl8.Controls.Add(Me.gaugeControl47)
            Me.layoutControl8.Controls.Add(Me.gaugeControl48)
            Me.layoutControl8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl8.Location = New System.Drawing.Point(3, 3)
            Me.layoutControl8.Name = "layoutControl8"
            Me.layoutControl8.Root = Me.layoutControlGroup8
            Me.layoutControl8.Size = New System.Drawing.Size(713, 476)
            Me.layoutControl8.TabIndex = 3
            Me.layoutControl8.Text = "layoutControl8"
            ' 
            ' gaugeControl43
            ' 
            Me.gaugeControl43.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge8})
            Me.gaugeControl43.Location = New System.Drawing.Point(492, 226)
            Me.gaugeControl43.Name = "gaugeControl43"
            Me.gaugeControl43.Size = New System.Drawing.Size(219, 248)
            Me.gaugeControl43.TabIndex = 9
            ' 
            ' linearGauge8
            ' 
            Me.linearGauge8.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent8})
            Me.linearGauge8.Bounds = New System.Drawing.Rectangle(6, 6, 207, 236)
            Me.linearGauge8.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent8})
            Me.linearGauge8.Name = "linearGauge8"
            Me.linearGauge8.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent15, Me.linearScaleComponent16})
            ' 
            ' linearScaleBackgroundLayerComponent8
            ' 
            Me.linearScaleBackgroundLayerComponent8.LinearScale = Me.linearScaleComponent15
            Me.linearScaleBackgroundLayerComponent8.Name = "bg1"
            Me.linearScaleBackgroundLayerComponent8.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.503F, 0.137F)
            Me.linearScaleBackgroundLayerComponent8.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.503F, 0.847F)
            Me.linearScaleBackgroundLayerComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style9
            Me.linearScaleBackgroundLayerComponent8.ZOrder = 1000
            ' 
            ' linearScaleComponent15
            ' 
            Me.linearScaleComponent15.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent15.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent15.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent15.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent15.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.linearScaleComponent15.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent15.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 35F)
            Me.linearScaleComponent15.MajorTickCount = 6
            Me.linearScaleComponent15.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent15.MajorTickmark.ShapeOffset = -22F
            Me.linearScaleComponent15.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.5F, 1.2F)
            Me.linearScaleComponent15.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style9_3
            Me.linearScaleComponent15.MajorTickmark.TextOffset = -35F
            Me.linearScaleComponent15.MaxValue = 500F
            Me.linearScaleComponent15.MinorTickCount = 4
            Me.linearScaleComponent15.MinorTickmark.ShapeOffset = -10F
            Me.linearScaleComponent15.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style9_1
            Me.linearScaleComponent15.Name = "scale1"
            Me.linearScaleComponent15.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F)
            Me.linearScaleComponent15.Value = 250F
            ' 
            ' linearScaleLevelComponent8
            ' 
            Me.linearScaleLevelComponent8.LinearScale = Me.linearScaleComponent15
            Me.linearScaleLevelComponent8.Name = "level1"
            Me.linearScaleLevelComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style9
            Me.linearScaleLevelComponent8.ZOrder = -50
            ' 
            ' linearScaleComponent16
            ' 
            Me.linearScaleComponent16.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent16.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent16.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent16.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent16.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.linearScaleComponent16.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent16.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 35F)
            Me.linearScaleComponent16.MajorTickCount = 6
            Me.linearScaleComponent16.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent16.MajorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent16.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.5F, 1.2F)
            Me.linearScaleComponent16.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style9_2
            Me.linearScaleComponent16.MajorTickmark.TextOffset = 35F
            Me.linearScaleComponent16.MaxValue = 50F
            Me.linearScaleComponent16.MinorTickCount = 4
            Me.linearScaleComponent16.MinorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent16.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style9_1
            Me.linearScaleComponent16.Name = "scale2"
            Me.linearScaleComponent16.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F)
            ' 
            ' gaugeControl44
            ' 
            Me.gaugeControl44.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge29})
            Me.gaugeControl44.Location = New System.Drawing.Point(268, 2)
            Me.gaugeControl44.Name = "gaugeControl44"
            Me.gaugeControl44.Size = New System.Drawing.Size(220, 220)
            Me.gaugeControl44.TabIndex = 8
            ' 
            ' circularGauge29
            ' 
            Me.circularGauge29.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent29})
            Me.circularGauge29.Bounds = New System.Drawing.Rectangle(6, 6, 208, 208)
            Me.circularGauge29.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent13})
            Me.circularGauge29.Name = "circularGauge29"
            Me.circularGauge29.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent29})
            Me.circularGauge29.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent29})
            Me.circularGauge29.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent21})
            ' 
            ' arcScaleBackgroundLayerComponent29
            ' 
            Me.arcScaleBackgroundLayerComponent29.ArcScale = Me.arcScaleComponent29
            Me.arcScaleBackgroundLayerComponent29.Name = "arcScaleBackgroundLayerComponent29"
            Me.arcScaleBackgroundLayerComponent29.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.723F)
            Me.arcScaleBackgroundLayerComponent29.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style9
            Me.arcScaleBackgroundLayerComponent29.Size = New System.Drawing.SizeF(250F, 170F)
            Me.arcScaleBackgroundLayerComponent29.ZOrder = 1000
            ' 
            ' arcScaleComponent29
            ' 
            Me.arcScaleComponent29.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent29.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent29.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent29.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent29.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            Me.arcScaleComponent29.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent29.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent29.EndAngle = -1F
            Me.arcScaleComponent29.MajorTickCount = 7
            Me.arcScaleComponent29.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent29.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_2
            Me.arcScaleComponent29.MajorTickmark.TextOffset = 20F
            Me.arcScaleComponent29.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent29.MaxValue = 80F
            Me.arcScaleComponent29.MinorTickCount = 4
            Me.arcScaleComponent29.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_1
            Me.arcScaleComponent29.MinValue = 20F
            Me.arcScaleComponent29.Name = "arcScaleComponent29"
            Me.arcScaleComponent29.RadiusX = 78F
            Me.arcScaleComponent29.RadiusY = 78F
            Me.arcScaleComponent29.StartAngle = -179F
            Me.arcScaleComponent29.Value = 20F
            ' 
            ' arcScaleEffectLayerComponent13
            ' 
            Me.arcScaleEffectLayerComponent13.ArcScale = Me.arcScaleComponent29
            Me.arcScaleEffectLayerComponent13.Name = "arcScaleEffectLayerComponent13"
            Me.arcScaleEffectLayerComponent13.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Style9
            Me.arcScaleEffectLayerComponent13.Size = New System.Drawing.SizeF(222F, 100F)
            Me.arcScaleEffectLayerComponent13.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent29
            ' 
            Me.arcScaleNeedleComponent29.ArcScale = Me.arcScaleComponent29
            Me.arcScaleNeedleComponent29.Name = "arcScaleNeedleComponent29"
            Me.arcScaleNeedleComponent29.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style9
            Me.arcScaleNeedleComponent29.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent21
            ' 
            Me.arcScaleSpindleCapComponent21.ArcScale = Me.arcScaleComponent29
            Me.arcScaleSpindleCapComponent21.Name = "arcScaleSpindleCapComponent21"
            Me.arcScaleSpindleCapComponent21.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style9
            Me.arcScaleSpindleCapComponent21.Size = New System.Drawing.SizeF(35F, 35F)
            Me.arcScaleSpindleCapComponent21.ZOrder = -100
            ' 
            ' gaugeControl45
            ' 
            Me.gaugeControl45.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge30})
            Me.gaugeControl45.Location = New System.Drawing.Point(2, 226)
            Me.gaugeControl45.Name = "gaugeControl45"
            Me.gaugeControl45.Size = New System.Drawing.Size(262, 248)
            Me.gaugeControl45.TabIndex = 7
            ' 
            ' circularGauge30
            ' 
            Me.circularGauge30.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent30})
            Me.circularGauge30.Bounds = New System.Drawing.Rectangle(6, 6, 250, 236)
            Me.circularGauge30.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent15})
            Me.circularGauge30.Name = "circularGauge30"
            Me.circularGauge30.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent30})
            Me.circularGauge30.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent30})
            Me.circularGauge30.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent23})
            ' 
            ' arcScaleBackgroundLayerComponent30
            ' 
            Me.arcScaleBackgroundLayerComponent30.ArcScale = Me.arcScaleComponent30
            Me.arcScaleBackgroundLayerComponent30.Name = "arcScaleBackgroundLayerComponent30"
            Me.arcScaleBackgroundLayerComponent30.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.723F, 0.72F)
            Me.arcScaleBackgroundLayerComponent30.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style9Left
            Me.arcScaleBackgroundLayerComponent30.Size = New System.Drawing.SizeF(249F, 249F)
            Me.arcScaleBackgroundLayerComponent30.ZOrder = 1000
            ' 
            ' arcScaleComponent30
            ' 
            Me.arcScaleComponent30.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent30.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent30.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent30.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent30.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent30.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent30.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(180F, 180F)
            Me.arcScaleComponent30.EndAngle = -90F
            Me.arcScaleComponent30.MajorTickCount = 5
            Me.arcScaleComponent30.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent30.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_2
            Me.arcScaleComponent30.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent30.MaxValue = 60F
            Me.arcScaleComponent30.MinorTickCount = 4
            Me.arcScaleComponent30.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_1
            Me.arcScaleComponent30.MinValue = 20F
            Me.arcScaleComponent30.Name = "arcScaleComponent30"
            Me.arcScaleComponent30.RadiusX = 114F
            Me.arcScaleComponent30.RadiusY = 114F
            Me.arcScaleComponent30.StartAngle = -180F
            Me.arcScaleComponent30.Value = 30F
            ' 
            ' arcScaleEffectLayerComponent15
            ' 
            Me.arcScaleEffectLayerComponent15.ArcScale = Me.arcScaleComponent30
            Me.arcScaleEffectLayerComponent15.Name = "arcScaleEffectLayerComponent15"
            Me.arcScaleEffectLayerComponent15.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.8F, 1.1F)
            Me.arcScaleEffectLayerComponent15.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularQuarter_Style9Left
            Me.arcScaleEffectLayerComponent15.Size = New System.Drawing.SizeF(200F, 145F)
            Me.arcScaleEffectLayerComponent15.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent30
            ' 
            Me.arcScaleNeedleComponent30.ArcScale = Me.arcScaleComponent30
            Me.arcScaleNeedleComponent30.Name = "arcScaleNeedleComponent30"
            Me.arcScaleNeedleComponent30.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style9
            Me.arcScaleNeedleComponent30.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent23
            ' 
            Me.arcScaleSpindleCapComponent23.ArcScale = Me.arcScaleComponent30
            Me.arcScaleSpindleCapComponent23.Name = "arcScaleSpindleCapComponent23"
            Me.arcScaleSpindleCapComponent23.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style9
            Me.arcScaleSpindleCapComponent23.Size = New System.Drawing.SizeF(45F, 45F)
            Me.arcScaleSpindleCapComponent23.ZOrder = -100
            ' 
            ' gaugeControl46
            ' 
            Me.gaugeControl46.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge31})
            Me.gaugeControl46.Location = New System.Drawing.Point(268, 226)
            Me.gaugeControl46.Name = "gaugeControl46"
            Me.gaugeControl46.Size = New System.Drawing.Size(220, 248)
            Me.gaugeControl46.TabIndex = 6
            ' 
            ' circularGauge31
            ' 
            Me.circularGauge31.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent31})
            Me.circularGauge31.Bounds = New System.Drawing.Rectangle(6, 6, 208, 236)
            Me.circularGauge31.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent16})
            Me.circularGauge31.Name = "circularGauge31"
            Me.circularGauge31.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent31})
            Me.circularGauge31.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent31})
            Me.circularGauge31.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent24})
            ' 
            ' arcScaleBackgroundLayerComponent31
            ' 
            Me.arcScaleBackgroundLayerComponent31.ArcScale = Me.arcScaleComponent31
            Me.arcScaleBackgroundLayerComponent31.Name = "arcScaleBackgroundLayerComponent31"
            Me.arcScaleBackgroundLayerComponent31.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.615F)
            Me.arcScaleBackgroundLayerComponent31.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style9
            Me.arcScaleBackgroundLayerComponent31.Size = New System.Drawing.SizeF(246F, 200F)
            Me.arcScaleBackgroundLayerComponent31.ZOrder = 1000
            ' 
            ' arcScaleComponent31
            ' 
            Me.arcScaleComponent31.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent31.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent31.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent31.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent31.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent31.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent31.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent31.EndAngle = 30.5F
            Me.arcScaleComponent31.MajorTickCount = 9
            Me.arcScaleComponent31.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent31.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_2
            Me.arcScaleComponent31.MajorTickmark.TextOffset = 18F
            Me.arcScaleComponent31.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent31.MaxValue = 80F
            Me.arcScaleComponent31.MinorTickCount = 4
            Me.arcScaleComponent31.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_1
            Me.arcScaleComponent31.Name = "arcScaleComponent31"
            Me.arcScaleComponent31.RadiusX = 77F
            Me.arcScaleComponent31.RadiusY = 77F
            Me.arcScaleComponent31.StartAngle = -210.5F
            Me.arcScaleComponent31.Value = 20F
            ' 
            ' arcScaleEffectLayerComponent16
            ' 
            Me.arcScaleEffectLayerComponent16.ArcScale = Me.arcScaleComponent31
            Me.arcScaleEffectLayerComponent16.Name = "arcScaleEffectLayerComponent16"
            Me.arcScaleEffectLayerComponent16.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularThreeFourth_Style9
            Me.arcScaleEffectLayerComponent16.Size = New System.Drawing.SizeF(222F, 100F)
            Me.arcScaleEffectLayerComponent16.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent31
            ' 
            Me.arcScaleNeedleComponent31.ArcScale = Me.arcScaleComponent31
            Me.arcScaleNeedleComponent31.Name = "arcScaleNeedleComponent31"
            Me.arcScaleNeedleComponent31.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style9
            Me.arcScaleNeedleComponent31.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent24
            ' 
            Me.arcScaleSpindleCapComponent24.ArcScale = Me.arcScaleComponent31
            Me.arcScaleSpindleCapComponent24.Name = "arcScaleSpindleCapComponent24"
            Me.arcScaleSpindleCapComponent24.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style9
            Me.arcScaleSpindleCapComponent24.Size = New System.Drawing.SizeF(35F, 35F)
            Me.arcScaleSpindleCapComponent24.ZOrder = -100
            ' 
            ' gaugeControl47
            ' 
            Me.gaugeControl47.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge8})
            Me.gaugeControl47.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl47.Name = "gaugeControl47"
            Me.gaugeControl47.Size = New System.Drawing.Size(262, 220)
            Me.gaugeControl47.TabIndex = 5
            ' 
            ' digitalGauge8
            ' 
            Me.digitalGauge8.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
            Me.digitalGauge8.AppearanceOn.BorderWidth = 2F
            Me.digitalGauge8.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:DimGray")
            Me.digitalGauge8.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent8})
            Me.digitalGauge8.Bounds = New System.Drawing.Rectangle(6, 6, 250, 208)
            Me.digitalGauge8.DigitCount = 5
            Me.digitalGauge8.Name = "digitalGauge8"
            Me.digitalGauge8.Text = "00,000"
            ' 
            ' digitalBackgroundLayerComponent8
            ' 
            Me.digitalBackgroundLayerComponent8.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125F, 99.9625F)
            Me.digitalBackgroundLayerComponent8.Name = "digitalBackgroundLayerComponent8"
            Me.digitalBackgroundLayerComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style9
            Me.digitalBackgroundLayerComponent8.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
            Me.digitalBackgroundLayerComponent8.ZOrder = 1000
            ' 
            ' gaugeControl48
            ' 
            Me.gaugeControl48.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge32})
            Me.gaugeControl48.Location = New System.Drawing.Point(492, 2)
            Me.gaugeControl48.Name = "gaugeControl48"
            Me.gaugeControl48.Size = New System.Drawing.Size(219, 220)
            Me.gaugeControl48.TabIndex = 4
            ' 
            ' circularGauge32
            ' 
            Me.circularGauge32.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent32})
            Me.circularGauge32.Bounds = New System.Drawing.Rectangle(6, 6, 207, 208)
            Me.circularGauge32.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent14})
            Me.circularGauge32.Name = "circularGauge32"
            Me.circularGauge32.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent32})
            Me.circularGauge32.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent32})
            Me.circularGauge32.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent22})
            ' 
            ' arcScaleBackgroundLayerComponent32
            ' 
            Me.arcScaleBackgroundLayerComponent32.ArcScale = Me.arcScaleComponent32
            Me.arcScaleBackgroundLayerComponent32.Name = "arcScaleBackgroundLayerComponent32"
            Me.arcScaleBackgroundLayerComponent32.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.495F)
            Me.arcScaleBackgroundLayerComponent32.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style9
            Me.arcScaleBackgroundLayerComponent32.ZOrder = 1000
            ' 
            ' arcScaleComponent32
            ' 
            Me.arcScaleComponent32.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent32.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent32.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent32.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent32.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            Me.arcScaleComponent32.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent32.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent32.EndAngle = 60.3F
            Me.arcScaleComponent32.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent32.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_2
            Me.arcScaleComponent32.MajorTickmark.TextOffset = 20F
            Me.arcScaleComponent32.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent32.MaxValue = 100F
            Me.arcScaleComponent32.MinorTickCount = 4
            Me.arcScaleComponent32.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_1
            Me.arcScaleComponent32.Name = "arcScaleComponent32"
            Me.arcScaleComponent32.RadiusX = 78F
            Me.arcScaleComponent32.RadiusY = 78F
            Me.arcScaleComponent32.StartAngle = -240.3F
            ' 
            ' arcScaleEffectLayerComponent14
            ' 
            Me.arcScaleEffectLayerComponent14.ArcScale = Me.arcScaleComponent32
            Me.arcScaleEffectLayerComponent14.Name = "arcScaleEffectLayerComponent14"
            Me.arcScaleEffectLayerComponent14.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.99F)
            Me.arcScaleEffectLayerComponent14.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Style9
            Me.arcScaleEffectLayerComponent14.Size = New System.Drawing.SizeF(220F, 110F)
            Me.arcScaleEffectLayerComponent14.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent32
            ' 
            Me.arcScaleNeedleComponent32.ArcScale = Me.arcScaleComponent32
            Me.arcScaleNeedleComponent32.Name = "arcScaleNeedleComponent32"
            Me.arcScaleNeedleComponent32.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style9
            Me.arcScaleNeedleComponent32.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent22
            ' 
            Me.arcScaleSpindleCapComponent22.ArcScale = Me.arcScaleComponent32
            Me.arcScaleSpindleCapComponent22.Name = "arcScaleSpindleCapComponent22"
            Me.arcScaleSpindleCapComponent22.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style9
            Me.arcScaleSpindleCapComponent22.Size = New System.Drawing.SizeF(35F, 35F)
            Me.arcScaleSpindleCapComponent22.ZOrder = -100
            ' 
            ' layoutControlGroup8
            ' 
            Me.layoutControlGroup8.AllowDrawBackground = False
            Me.layoutControlGroup8.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup8.GroupBordersVisible = False
            Me.layoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem43, Me.layoutControlItem44, Me.layoutControlItem45, Me.layoutControlItem46, Me.layoutControlItem47, Me.layoutControlItem48})
            Me.layoutControlGroup8.Name = "layoutControlGroup1"
            Me.layoutControlGroup8.Size = New System.Drawing.Size(713, 476)
            Me.layoutControlGroup8.TextVisible = False
            ' 
            ' layoutControlItem43
            ' 
            Me.layoutControlItem43.Control = Me.gaugeControl47
            Me.layoutControlItem43.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem43.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem43.Name = "layoutControlItem2"
            Me.layoutControlItem43.Size = New System.Drawing.Size(266, 224)
            Me.layoutControlItem43.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem43.TextVisible = False
            ' 
            ' layoutControlItem44
            ' 
            Me.layoutControlItem44.Control = Me.gaugeControl45
            Me.layoutControlItem44.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem44.Location = New System.Drawing.Point(0, 224)
            Me.layoutControlItem44.Name = "layoutControlItem4"
            Me.layoutControlItem44.Size = New System.Drawing.Size(266, 252)
            Me.layoutControlItem44.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem44.TextVisible = False
            ' 
            ' layoutControlItem45
            ' 
            Me.layoutControlItem45.Control = Me.gaugeControl46
            Me.layoutControlItem45.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem45.Location = New System.Drawing.Point(266, 224)
            Me.layoutControlItem45.Name = "layoutControlItem3"
            Me.layoutControlItem45.Size = New System.Drawing.Size(224, 252)
            Me.layoutControlItem45.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem45.TextVisible = False
            ' 
            ' layoutControlItem46
            ' 
            Me.layoutControlItem46.Control = Me.gaugeControl43
            Me.layoutControlItem46.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem46.Location = New System.Drawing.Point(490, 224)
            Me.layoutControlItem46.Name = "layoutControlItem6"
            Me.layoutControlItem46.Size = New System.Drawing.Size(223, 252)
            Me.layoutControlItem46.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem46.TextVisible = False
            ' 
            ' layoutControlItem47
            ' 
            Me.layoutControlItem47.Control = Me.gaugeControl48
            Me.layoutControlItem47.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem47.Location = New System.Drawing.Point(490, 0)
            Me.layoutControlItem47.Name = "layoutControlItem1"
            Me.layoutControlItem47.Size = New System.Drawing.Size(223, 224)
            Me.layoutControlItem47.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem47.TextVisible = False
            ' 
            ' layoutControlItem48
            ' 
            Me.layoutControlItem48.Control = Me.gaugeControl44
            Me.layoutControlItem48.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem48.Location = New System.Drawing.Point(266, 0)
            Me.layoutControlItem48.Name = "layoutControlItem5"
            Me.layoutControlItem48.Size = New System.Drawing.Size(224, 224)
            Me.layoutControlItem48.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem48.TextVisible = False
            ' 
            ' xtraTabPage9
            ' 
            Me.xtraTabPage9.Caption = "Pure Dark"
            Me.xtraTabPage9.Controls.Add(Me.layoutControl10)
            Me.xtraTabPage9.Name = "xtraTabPage9"
            Me.xtraTabPage9.Padding = New System.Windows.Forms.Padding(3)
            Me.xtraTabPage9.Size = New System.Drawing.Size(719, 482)
            ' 
            ' layoutControl10
            ' 
            Me.layoutControl10.Controls.Add(Me.gaugeControl55)
            Me.layoutControl10.Controls.Add(Me.gaugeControl56)
            Me.layoutControl10.Controls.Add(Me.gaugeControl57)
            Me.layoutControl10.Controls.Add(Me.gaugeControl58)
            Me.layoutControl10.Controls.Add(Me.gaugeControl59)
            Me.layoutControl10.Controls.Add(Me.gaugeControl60)
            Me.layoutControl10.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl10.Location = New System.Drawing.Point(3, 3)
            Me.layoutControl10.Name = "layoutControl10"
            Me.layoutControl10.Root = Me.layoutControlGroup10
            Me.layoutControl10.Size = New System.Drawing.Size(713, 476)
            Me.layoutControl10.TabIndex = 4
            Me.layoutControl10.Text = "layoutControl10"
            ' 
            ' gaugeControl55
            ' 
            Me.gaugeControl55.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge10})
            Me.gaugeControl55.Location = New System.Drawing.Point(492, 226)
            Me.gaugeControl55.Name = "gaugeControl55"
            Me.gaugeControl55.Size = New System.Drawing.Size(219, 248)
            Me.gaugeControl55.TabIndex = 9
            ' 
            ' linearGauge10
            ' 
            Me.linearGauge10.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent10})
            Me.linearGauge10.Bounds = New System.Drawing.Rectangle(6, 6, 207, 236)
            Me.linearGauge10.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent10})
            Me.linearGauge10.Name = "linearGauge10"
            Me.linearGauge10.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent19, Me.linearScaleComponent20})
            ' 
            ' linearScaleBackgroundLayerComponent10
            ' 
            Me.linearScaleBackgroundLayerComponent10.LinearScale = Me.linearScaleComponent19
            Me.linearScaleBackgroundLayerComponent10.Name = "linearScaleBackgroundLayerComponent9"
            Me.linearScaleBackgroundLayerComponent10.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.08F)
            Me.linearScaleBackgroundLayerComponent10.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.92F)
            Me.linearScaleBackgroundLayerComponent10.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style10
            Me.linearScaleBackgroundLayerComponent10.ZOrder = 1000
            ' 
            ' linearScaleComponent19
            ' 
            Me.linearScaleComponent19.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent19.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent19.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent19.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent19.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.linearScaleComponent19.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F)
            Me.linearScaleComponent19.MajorTickCount = 6
            Me.linearScaleComponent19.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent19.MajorTickmark.ShapeOffset = 7F
            Me.linearScaleComponent19.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style10_1
            Me.linearScaleComponent19.MajorTickmark.TextOffset = 35F
            Me.linearScaleComponent19.MaxValue = 500F
            Me.linearScaleComponent19.MinorTickCount = 4
            Me.linearScaleComponent19.MinorTickmark.ShapeOffset = 7F
            Me.linearScaleComponent19.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style10_2
            Me.linearScaleComponent19.Name = "linearScaleComponent17"
            Me.linearScaleComponent19.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F)
            Me.linearScaleComponent19.Value = 250F
            ' 
            ' linearScaleLevelComponent10
            ' 
            Me.linearScaleLevelComponent10.LinearScale = Me.linearScaleComponent19
            Me.linearScaleLevelComponent10.Name = "linearScaleLevelComponent9"
            Me.linearScaleLevelComponent10.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style10
            Me.linearScaleLevelComponent10.ZOrder = -50
            ' 
            ' linearScaleComponent20
            ' 
            Me.linearScaleComponent20.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent20.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent20.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent20.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent20.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.linearScaleComponent20.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F)
            Me.linearScaleComponent20.MajorTickCount = 6
            Me.linearScaleComponent20.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent20.MajorTickmark.ShapeOffset = -18F
            Me.linearScaleComponent20.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style10_3
            Me.linearScaleComponent20.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent20.MaxValue = 50F
            Me.linearScaleComponent20.MinorTickCount = 4
            Me.linearScaleComponent20.MinorTickmark.ShapeOffset = -12F
            Me.linearScaleComponent20.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style10_2
            Me.linearScaleComponent20.Name = "linearScaleComponent18"
            Me.linearScaleComponent20.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F)
            ' 
            ' gaugeControl56
            ' 
            Me.gaugeControl56.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge37})
            Me.gaugeControl56.Location = New System.Drawing.Point(268, 2)
            Me.gaugeControl56.Name = "gaugeControl56"
            Me.gaugeControl56.Size = New System.Drawing.Size(220, 220)
            Me.gaugeControl56.TabIndex = 8
            ' 
            ' circularGauge37
            ' 
            Me.circularGauge37.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent39})
            Me.circularGauge37.Bounds = New System.Drawing.Rectangle(6, 6, 208, 208)
            Me.circularGauge37.Name = "circularGauge37"
            Me.circularGauge37.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent37})
            Me.circularGauge37.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent51, Me.arcScaleComponent59})
            ' 
            ' arcScaleBackgroundLayerComponent39
            ' 
            Me.arcScaleBackgroundLayerComponent39.ArcScale = Me.arcScaleComponent51
            Me.arcScaleBackgroundLayerComponent39.Name = "arcScaleBackgroundLayerComponent39"
            Me.arcScaleBackgroundLayerComponent39.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.815F)
            Me.arcScaleBackgroundLayerComponent39.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style10
            Me.arcScaleBackgroundLayerComponent39.Size = New System.Drawing.SizeF(250F, 154F)
            Me.arcScaleBackgroundLayerComponent39.ZOrder = 1000
            ' 
            ' arcScaleComponent51
            ' 
            Me.arcScaleComponent51.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent51.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent51.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent51.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent51.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent51.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent51.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent51.EndAngle = 0F
            Me.arcScaleComponent51.MajorTickCount = 7
            Me.arcScaleComponent51.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent51.MajorTickmark.ShapeOffset = -2F
            Me.arcScaleComponent51.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F)
            Me.arcScaleComponent51.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4
            Me.arcScaleComponent51.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent51.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent51.MaxValue = 80F
            Me.arcScaleComponent51.MinorTickCount = 4
            Me.arcScaleComponent51.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F)
            Me.arcScaleComponent51.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3
            Me.arcScaleComponent51.MinValue = 20F
            Me.arcScaleComponent51.Name = "arcScaleComponent51"
            Me.arcScaleComponent51.RadiusX = 105F
            Me.arcScaleComponent51.RadiusY = 105F
            Me.arcScaleComponent51.StartAngle = -180F
            Me.arcScaleComponent51.Value = 20F
            ' 
            ' arcScaleNeedleComponent37
            ' 
            Me.arcScaleNeedleComponent37.ArcScale = Me.arcScaleComponent51
            Me.arcScaleNeedleComponent37.EndOffset = -5F
            Me.arcScaleNeedleComponent37.Name = "arcScaleNeedleComponent37"
            Me.arcScaleNeedleComponent37.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style10
            Me.arcScaleNeedleComponent37.StartOffset = -9F
            Me.arcScaleNeedleComponent37.ZOrder = -50
            ' 
            ' arcScaleComponent59
            ' 
            Me.arcScaleComponent59.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent59.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent59.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent59.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent59.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent59.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent59.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent59.EndAngle = -30F
            Me.arcScaleComponent59.MajorTickCount = 6
            Me.arcScaleComponent59.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent59.MajorTickmark.ShapeOffset = -6F
            Me.arcScaleComponent59.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_2
            Me.arcScaleComponent59.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent59.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent59.MaxValue = 700F
            Me.arcScaleComponent59.MinorTickCount = 4
            Me.arcScaleComponent59.MinorTickmark.ShapeOffset = -1.5F
            Me.arcScaleComponent59.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_1
            Me.arcScaleComponent59.MinValue = 200F
            Me.arcScaleComponent59.Name = "arcScaleComponent59"
            Me.arcScaleComponent59.RadiusX = 70F
            Me.arcScaleComponent59.RadiusY = 70F
            Me.arcScaleComponent59.StartAngle = -180F
            Me.arcScaleComponent59.Value = 200F
            ' 
            ' gaugeControl57
            ' 
            Me.gaugeControl57.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge38})
            Me.gaugeControl57.Location = New System.Drawing.Point(2, 226)
            Me.gaugeControl57.Name = "gaugeControl57"
            Me.gaugeControl57.Size = New System.Drawing.Size(262, 248)
            Me.gaugeControl57.TabIndex = 7
            ' 
            ' circularGauge38
            ' 
            Me.circularGauge38.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent40})
            Me.circularGauge38.Bounds = New System.Drawing.Rectangle(6, 6, 250, 236)
            Me.circularGauge38.Name = "circularGauge38"
            Me.circularGauge38.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent38})
            Me.circularGauge38.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent52, Me.arcScaleComponent61})
            ' 
            ' arcScaleBackgroundLayerComponent40
            ' 
            Me.arcScaleBackgroundLayerComponent40.ArcScale = Me.arcScaleComponent52
            Me.arcScaleBackgroundLayerComponent40.Name = "arcScaleBackgroundLayerComponent40"
            Me.arcScaleBackgroundLayerComponent40.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.78F, 0.78F)
            Me.arcScaleBackgroundLayerComponent40.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style10Left
            Me.arcScaleBackgroundLayerComponent40.ZOrder = 1000
            ' 
            ' arcScaleComponent52
            ' 
            Me.arcScaleComponent52.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent52.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent52.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent52.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent52.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 14F)
            Me.arcScaleComponent52.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent52.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(195F, 195F)
            Me.arcScaleComponent52.EndAngle = -90F
            Me.arcScaleComponent52.MajorTickCount = 4
            Me.arcScaleComponent52.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent52.MajorTickmark.ShapeOffset = -6F
            Me.arcScaleComponent52.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent52.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4
            Me.arcScaleComponent52.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent52.MaxValue = 70F
            Me.arcScaleComponent52.MinorTickCount = 4
            Me.arcScaleComponent52.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent52.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3
            Me.arcScaleComponent52.MinValue = 40F
            Me.arcScaleComponent52.Name = "arcScaleComponent52"
            Me.arcScaleComponent52.RadiusX = 144F
            Me.arcScaleComponent52.RadiusY = 144F
            Me.arcScaleComponent52.StartAngle = -180F
            Me.arcScaleComponent52.Value = 50F
            ' 
            ' arcScaleNeedleComponent38
            ' 
            Me.arcScaleNeedleComponent38.ArcScale = Me.arcScaleComponent52
            Me.arcScaleNeedleComponent38.EndOffset = -12F
            Me.arcScaleNeedleComponent38.Name = "arcScaleNeedleComponent38"
            Me.arcScaleNeedleComponent38.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style10
            Me.arcScaleNeedleComponent38.StartOffset = -14F
            Me.arcScaleNeedleComponent38.ZOrder = -50
            ' 
            ' arcScaleComponent61
            ' 
            Me.arcScaleComponent61.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent61.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent61.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent61.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent61.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent61.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(195F, 195F)
            Me.arcScaleComponent61.EndAngle = -90F
            Me.arcScaleComponent61.MajorTickCount = 4
            Me.arcScaleComponent61.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent61.MajorTickmark.ShapeOffset = -3F
            Me.arcScaleComponent61.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_2
            Me.arcScaleComponent61.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent61.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent61.MaxValue = 300F
            Me.arcScaleComponent61.MinorTickCount = 4
            Me.arcScaleComponent61.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_1
            Me.arcScaleComponent61.Name = "arcScaleComponent61"
            Me.arcScaleComponent61.RadiusX = 90F
            Me.arcScaleComponent61.RadiusY = 90F
            Me.arcScaleComponent61.StartAngle = -180F
            ' 
            ' gaugeControl58
            ' 
            Me.gaugeControl58.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge39})
            Me.gaugeControl58.Location = New System.Drawing.Point(268, 226)
            Me.gaugeControl58.Name = "gaugeControl58"
            Me.gaugeControl58.Size = New System.Drawing.Size(220, 248)
            Me.gaugeControl58.TabIndex = 6
            ' 
            ' circularGauge39
            ' 
            Me.circularGauge39.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent41})
            Me.circularGauge39.Bounds = New System.Drawing.Rectangle(6, 6, 208, 236)
            Me.circularGauge39.Name = "circularGauge39"
            Me.circularGauge39.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent39})
            Me.circularGauge39.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent53, Me.arcScaleComponent62})
            ' 
            ' arcScaleBackgroundLayerComponent41
            ' 
            Me.arcScaleBackgroundLayerComponent41.ArcScale = Me.arcScaleComponent53
            Me.arcScaleBackgroundLayerComponent41.Name = "arcScaleBackgroundLayerComponent41"
            Me.arcScaleBackgroundLayerComponent41.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.63F)
            Me.arcScaleBackgroundLayerComponent41.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style10
            Me.arcScaleBackgroundLayerComponent41.Size = New System.Drawing.SizeF(250F, 196F)
            Me.arcScaleBackgroundLayerComponent41.ZOrder = 1000
            ' 
            ' arcScaleComponent53
            ' 
            Me.arcScaleComponent53.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent53.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent53.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent53.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent53.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent53.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent53.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent53.EndAngle = 30F
            Me.arcScaleComponent53.MajorTickCount = 9
            Me.arcScaleComponent53.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent53.MajorTickmark.ShapeOffset = -2F
            Me.arcScaleComponent53.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F)
            Me.arcScaleComponent53.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4
            Me.arcScaleComponent53.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent53.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent53.MaxValue = 90F
            Me.arcScaleComponent53.MinorTickCount = 4
            Me.arcScaleComponent53.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F)
            Me.arcScaleComponent53.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3
            Me.arcScaleComponent53.MinValue = 10F
            Me.arcScaleComponent53.Name = "arcScaleComponent53"
            Me.arcScaleComponent53.RadiusX = 105F
            Me.arcScaleComponent53.RadiusY = 105F
            Me.arcScaleComponent53.StartAngle = -210F
            Me.arcScaleComponent53.Value = 20F
            ' 
            ' arcScaleNeedleComponent39
            ' 
            Me.arcScaleNeedleComponent39.ArcScale = Me.arcScaleComponent53
            Me.arcScaleNeedleComponent39.EndOffset = -5F
            Me.arcScaleNeedleComponent39.Name = "arcScaleNeedleComponent39"
            Me.arcScaleNeedleComponent39.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style10
            Me.arcScaleNeedleComponent39.StartOffset = -10F
            Me.arcScaleNeedleComponent39.ZOrder = -50
            ' 
            ' arcScaleComponent62
            ' 
            Me.arcScaleComponent62.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent62.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent62.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent62.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent62.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent62.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent62.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent62.EndAngle = -30F
            Me.arcScaleComponent62.MajorTickCount = 7
            Me.arcScaleComponent62.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent62.MajorTickmark.ShapeOffset = -6F
            Me.arcScaleComponent62.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_2
            Me.arcScaleComponent62.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent62.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent62.MaxValue = 700F
            Me.arcScaleComponent62.MinorTickCount = 4
            Me.arcScaleComponent62.MinorTickmark.ShapeOffset = -1.5F
            Me.arcScaleComponent62.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_1
            Me.arcScaleComponent62.MinValue = 100F
            Me.arcScaleComponent62.Name = "arcScaleComponent62"
            Me.arcScaleComponent62.RadiusX = 70F
            Me.arcScaleComponent62.RadiusY = 70F
            Me.arcScaleComponent62.StartAngle = -210F
            Me.arcScaleComponent62.Value = 100F
            ' 
            ' gaugeControl59
            ' 
            Me.gaugeControl59.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge10})
            Me.gaugeControl59.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl59.Name = "gaugeControl59"
            Me.gaugeControl59.Size = New System.Drawing.Size(262, 220)
            Me.gaugeControl59.TabIndex = 5
            ' 
            ' digitalGauge10
            ' 
            Me.digitalGauge10.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#404040")
            Me.digitalGauge10.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FFFFFA")
            Me.digitalGauge10.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent10})
            Me.digitalGauge10.Bounds = New System.Drawing.Rectangle(6, 6, 250, 208)
            Me.digitalGauge10.DigitCount = 5
            Me.digitalGauge10.Name = "digitalGauge10"
            Me.digitalGauge10.Text = "00,000"
            ' 
            ' digitalBackgroundLayerComponent10
            ' 
            Me.digitalBackgroundLayerComponent10.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125F, 99.9625F)
            Me.digitalBackgroundLayerComponent10.Name = "digitalBackgroundLayerComponent10"
            Me.digitalBackgroundLayerComponent10.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style10
            Me.digitalBackgroundLayerComponent10.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
            Me.digitalBackgroundLayerComponent10.ZOrder = 1000
            ' 
            ' gaugeControl60
            ' 
            Me.gaugeControl60.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge40})
            Me.gaugeControl60.Location = New System.Drawing.Point(492, 2)
            Me.gaugeControl60.Name = "gaugeControl60"
            Me.gaugeControl60.Size = New System.Drawing.Size(219, 220)
            Me.gaugeControl60.TabIndex = 4
            ' 
            ' circularGauge40
            ' 
            Me.circularGauge40.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent42})
            Me.circularGauge40.Bounds = New System.Drawing.Rectangle(6, 6, 207, 208)
            Me.circularGauge40.Name = "circularGauge40"
            Me.circularGauge40.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent40})
            Me.circularGauge40.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent54, Me.arcScaleComponent60})
            ' 
            ' arcScaleBackgroundLayerComponent42
            ' 
            Me.arcScaleBackgroundLayerComponent42.ArcScale = Me.arcScaleComponent54
            Me.arcScaleBackgroundLayerComponent42.Name = "arcScaleBackgroundLayerComponent42"
            Me.arcScaleBackgroundLayerComponent42.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style10
            Me.arcScaleBackgroundLayerComponent42.ZOrder = 1000
            ' 
            ' arcScaleComponent54
            ' 
            Me.arcScaleComponent54.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent54.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent54.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent54.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent54.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent54.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent54.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent54.EndAngle = 60F
            Me.arcScaleComponent54.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent54.MajorTickmark.ShapeOffset = -2F
            Me.arcScaleComponent54.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F)
            Me.arcScaleComponent54.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4
            Me.arcScaleComponent54.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent54.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent54.MaxValue = 100F
            Me.arcScaleComponent54.MinorTickCount = 4
            Me.arcScaleComponent54.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F)
            Me.arcScaleComponent54.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3
            Me.arcScaleComponent54.Name = "arcScaleComponent54"
            Me.arcScaleComponent54.RadiusX = 105F
            Me.arcScaleComponent54.RadiusY = 105F
            Me.arcScaleComponent54.StartAngle = -240F
            ' 
            ' arcScaleNeedleComponent40
            ' 
            Me.arcScaleNeedleComponent40.ArcScale = Me.arcScaleComponent54
            Me.arcScaleNeedleComponent40.EndOffset = -5F
            Me.arcScaleNeedleComponent40.Name = "arcScaleNeedleComponent40"
            Me.arcScaleNeedleComponent40.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style10
            Me.arcScaleNeedleComponent40.StartOffset = -9F
            Me.arcScaleNeedleComponent40.ZOrder = -50
            ' 
            ' arcScaleComponent60
            ' 
            Me.arcScaleComponent60.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent60.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent60.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent60.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent60.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent60.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent60.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent60.EndAngle = -30F
            Me.arcScaleComponent60.MajorTickCount = 8
            Me.arcScaleComponent60.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent60.MajorTickmark.ShapeOffset = -6F
            Me.arcScaleComponent60.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_2
            Me.arcScaleComponent60.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent60.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent60.MaxValue = 700F
            Me.arcScaleComponent60.MinorTickCount = 4
            Me.arcScaleComponent60.MinorTickmark.ShapeOffset = -1.5F
            Me.arcScaleComponent60.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_1
            Me.arcScaleComponent60.Name = "arcScaleComponent60"
            Me.arcScaleComponent60.RadiusX = 70F
            Me.arcScaleComponent60.RadiusY = 70F
            Me.arcScaleComponent60.StartAngle = -240F
            ' 
            ' layoutControlGroup10
            ' 
            Me.layoutControlGroup10.AllowDrawBackground = False
            Me.layoutControlGroup10.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup10.GroupBordersVisible = False
            Me.layoutControlGroup10.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem55, Me.layoutControlItem56, Me.layoutControlItem57, Me.layoutControlItem58, Me.layoutControlItem59, Me.layoutControlItem60})
            Me.layoutControlGroup10.Name = "layoutControlGroup1"
            Me.layoutControlGroup10.Size = New System.Drawing.Size(713, 476)
            Me.layoutControlGroup10.TextVisible = False
            ' 
            ' layoutControlItem55
            ' 
            Me.layoutControlItem55.Control = Me.gaugeControl59
            Me.layoutControlItem55.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem55.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem55.Name = "layoutControlItem2"
            Me.layoutControlItem55.Size = New System.Drawing.Size(266, 224)
            Me.layoutControlItem55.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem55.TextVisible = False
            ' 
            ' layoutControlItem56
            ' 
            Me.layoutControlItem56.Control = Me.gaugeControl57
            Me.layoutControlItem56.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem56.Location = New System.Drawing.Point(0, 224)
            Me.layoutControlItem56.Name = "layoutControlItem4"
            Me.layoutControlItem56.Size = New System.Drawing.Size(266, 252)
            Me.layoutControlItem56.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem56.TextVisible = False
            ' 
            ' layoutControlItem57
            ' 
            Me.layoutControlItem57.Control = Me.gaugeControl58
            Me.layoutControlItem57.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem57.Location = New System.Drawing.Point(266, 224)
            Me.layoutControlItem57.Name = "layoutControlItem3"
            Me.layoutControlItem57.Size = New System.Drawing.Size(224, 252)
            Me.layoutControlItem57.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem57.TextVisible = False
            ' 
            ' layoutControlItem58
            ' 
            Me.layoutControlItem58.Control = Me.gaugeControl55
            Me.layoutControlItem58.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem58.Location = New System.Drawing.Point(490, 224)
            Me.layoutControlItem58.Name = "layoutControlItem6"
            Me.layoutControlItem58.Size = New System.Drawing.Size(223, 252)
            Me.layoutControlItem58.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem58.TextVisible = False
            ' 
            ' layoutControlItem59
            ' 
            Me.layoutControlItem59.Control = Me.gaugeControl60
            Me.layoutControlItem59.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem59.Location = New System.Drawing.Point(490, 0)
            Me.layoutControlItem59.Name = "layoutControlItem1"
            Me.layoutControlItem59.Size = New System.Drawing.Size(223, 224)
            Me.layoutControlItem59.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem59.TextVisible = False
            ' 
            ' layoutControlItem60
            ' 
            Me.layoutControlItem60.Control = Me.gaugeControl56
            Me.layoutControlItem60.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem60.Location = New System.Drawing.Point(266, 0)
            Me.layoutControlItem60.Name = "layoutControlItem5"
            Me.layoutControlItem60.Size = New System.Drawing.Size(224, 224)
            Me.layoutControlItem60.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem60.TextVisible = False
            ' 
            ' xtraTabPage10
            ' 
            Me.xtraTabPage10.Caption = "Clean White"
            Me.xtraTabPage10.Controls.Add(Me.layoutControl11)
            Me.xtraTabPage10.Name = "xtraTabPage10"
            Me.xtraTabPage10.Padding = New System.Windows.Forms.Padding(3)
            Me.xtraTabPage10.Size = New System.Drawing.Size(719, 482)
            ' 
            ' layoutControl11
            ' 
            Me.layoutControl11.Controls.Add(Me.gaugeControl61)
            Me.layoutControl11.Controls.Add(Me.gaugeControl62)
            Me.layoutControl11.Controls.Add(Me.gaugeControl63)
            Me.layoutControl11.Controls.Add(Me.gaugeControl64)
            Me.layoutControl11.Controls.Add(Me.gaugeControl65)
            Me.layoutControl11.Controls.Add(Me.gaugeControl66)
            Me.layoutControl11.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl11.Location = New System.Drawing.Point(3, 3)
            Me.layoutControl11.Name = "layoutControl11"
            Me.layoutControl11.Root = Me.layoutControlGroup11
            Me.layoutControl11.Size = New System.Drawing.Size(713, 476)
            Me.layoutControl11.TabIndex = 4
            Me.layoutControl11.Text = "layoutControl11"
            ' 
            ' gaugeControl61
            ' 
            Me.gaugeControl61.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge11})
            Me.gaugeControl61.Location = New System.Drawing.Point(492, 226)
            Me.gaugeControl61.Name = "gaugeControl61"
            Me.gaugeControl61.Size = New System.Drawing.Size(219, 248)
            Me.gaugeControl61.TabIndex = 9
            ' 
            ' linearGauge11
            ' 
            Me.linearGauge11.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent11})
            Me.linearGauge11.Bounds = New System.Drawing.Rectangle(6, 6, 207, 236)
            Me.linearGauge11.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent11})
            Me.linearGauge11.Name = "linearGauge11"
            Me.linearGauge11.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent21, Me.linearScaleComponent22})
            ' 
            ' linearScaleBackgroundLayerComponent11
            ' 
            Me.linearScaleBackgroundLayerComponent11.LinearScale = Me.linearScaleComponent21
            Me.linearScaleBackgroundLayerComponent11.Name = "bg1"
            Me.linearScaleBackgroundLayerComponent11.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5075F, 0.08F)
            Me.linearScaleBackgroundLayerComponent11.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5075F, 0.92F)
            Me.linearScaleBackgroundLayerComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style11
            Me.linearScaleBackgroundLayerComponent11.ZOrder = 1000
            ' 
            ' linearScaleComponent21
            ' 
            Me.linearScaleComponent21.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent21.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent21.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent21.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent21.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent21.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F)
            Me.linearScaleComponent21.MajorTickCount = 6
            Me.linearScaleComponent21.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent21.MajorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent21.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_2
            Me.linearScaleComponent21.MajorTickmark.TextOffset = 35F
            Me.linearScaleComponent21.MaxValue = 500F
            Me.linearScaleComponent21.MinorTickCount = 4
            Me.linearScaleComponent21.MinorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent21.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_1
            Me.linearScaleComponent21.Name = "scale1"
            Me.linearScaleComponent21.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F)
            Me.linearScaleComponent21.Value = 250F
            ' 
            ' linearScaleLevelComponent11
            ' 
            Me.linearScaleLevelComponent11.LinearScale = Me.linearScaleComponent21
            Me.linearScaleLevelComponent11.Name = "level1"
            Me.linearScaleLevelComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style11
            Me.linearScaleLevelComponent11.ZOrder = -50
            ' 
            ' linearScaleComponent22
            ' 
            Me.linearScaleComponent22.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent22.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent22.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent22.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent22.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent22.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F)
            Me.linearScaleComponent22.MajorTickCount = 6
            Me.linearScaleComponent22.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent22.MajorTickmark.ShapeOffset = -18F
            Me.linearScaleComponent22.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_3
            Me.linearScaleComponent22.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent22.MaxValue = 50F
            Me.linearScaleComponent22.MinorTickCount = 4
            Me.linearScaleComponent22.MinorTickmark.ShapeOffset = -12F
            Me.linearScaleComponent22.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_4
            Me.linearScaleComponent22.Name = "scale2"
            Me.linearScaleComponent22.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F)
            ' 
            ' gaugeControl62
            ' 
            Me.gaugeControl62.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge41})
            Me.gaugeControl62.Location = New System.Drawing.Point(268, 2)
            Me.gaugeControl62.Name = "gaugeControl62"
            Me.gaugeControl62.Size = New System.Drawing.Size(220, 220)
            Me.gaugeControl62.TabIndex = 8
            ' 
            ' circularGauge41
            ' 
            Me.circularGauge41.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent43})
            Me.circularGauge41.Bounds = New System.Drawing.Rectangle(6, 6, 208, 208)
            Me.circularGauge41.Name = "circularGauge41"
            Me.circularGauge41.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent41})
            Me.circularGauge41.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent55, Me.arcScaleComponent64})
            ' 
            ' arcScaleBackgroundLayerComponent43
            ' 
            Me.arcScaleBackgroundLayerComponent43.ArcScale = Me.arcScaleComponent55
            Me.arcScaleBackgroundLayerComponent43.Name = "arcScaleBackgroundLayerComponent43"
            Me.arcScaleBackgroundLayerComponent43.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.815F)
            Me.arcScaleBackgroundLayerComponent43.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style11
            Me.arcScaleBackgroundLayerComponent43.Size = New System.Drawing.SizeF(250F, 154F)
            Me.arcScaleBackgroundLayerComponent43.ZOrder = 1000
            ' 
            ' arcScaleComponent55
            ' 
            Me.arcScaleComponent55.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent55.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent55.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent55.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent55.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent55.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent55.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent55.EndAngle = 0F
            Me.arcScaleComponent55.MajorTickCount = 7
            Me.arcScaleComponent55.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent55.MajorTickmark.ShapeOffset = -5F
            Me.arcScaleComponent55.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F)
            Me.arcScaleComponent55.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_4
            Me.arcScaleComponent55.MajorTickmark.TextOffset = -17F
            Me.arcScaleComponent55.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent55.MaxValue = 80F
            Me.arcScaleComponent55.MinorTickCount = 4
            Me.arcScaleComponent55.MinorTickmark.ShapeOffset = -2.5F
            Me.arcScaleComponent55.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F)
            Me.arcScaleComponent55.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_3
            Me.arcScaleComponent55.MinValue = 20F
            Me.arcScaleComponent55.Name = "arcScaleComponent55"
            Me.arcScaleComponent55.RadiusX = 107F
            Me.arcScaleComponent55.RadiusY = 107F
            Me.arcScaleComponent55.StartAngle = -180F
            Me.arcScaleComponent55.Value = 20F
            ' 
            ' arcScaleNeedleComponent41
            ' 
            Me.arcScaleNeedleComponent41.ArcScale = Me.arcScaleComponent55
            Me.arcScaleNeedleComponent41.EndOffset = 5F
            Me.arcScaleNeedleComponent41.Name = "arcScaleNeedleComponent41"
            Me.arcScaleNeedleComponent41.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style11
            Me.arcScaleNeedleComponent41.StartOffset = -9.5F
            Me.arcScaleNeedleComponent41.ZOrder = -50
            ' 
            ' arcScaleComponent64
            ' 
            Me.arcScaleComponent64.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent64.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent64.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent64.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent64.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent64.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent64.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent64.EndAngle = -30F
            Me.arcScaleComponent64.MajorTickCount = 6
            Me.arcScaleComponent64.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent64.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_2
            Me.arcScaleComponent64.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent64.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent64.MaxValue = 700F
            Me.arcScaleComponent64.MinorTickCount = 4
            Me.arcScaleComponent64.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_1
            Me.arcScaleComponent64.MinValue = 200F
            Me.arcScaleComponent64.Name = "arcScaleComponent64"
            Me.arcScaleComponent64.RadiusX = 70F
            Me.arcScaleComponent64.RadiusY = 70F
            Me.arcScaleComponent64.StartAngle = -180F
            Me.arcScaleComponent64.Value = 200F
            ' 
            ' gaugeControl63
            ' 
            Me.gaugeControl63.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge42})
            Me.gaugeControl63.Location = New System.Drawing.Point(2, 226)
            Me.gaugeControl63.Name = "gaugeControl63"
            Me.gaugeControl63.Size = New System.Drawing.Size(262, 248)
            Me.gaugeControl63.TabIndex = 7
            ' 
            ' circularGauge42
            ' 
            Me.circularGauge42.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent44})
            Me.circularGauge42.Bounds = New System.Drawing.Rectangle(6, 6, 250, 236)
            Me.circularGauge42.Name = "circularGauge42"
            Me.circularGauge42.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent42})
            Me.circularGauge42.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent56, Me.arcScaleComponent63})
            ' 
            ' arcScaleBackgroundLayerComponent44
            ' 
            Me.arcScaleBackgroundLayerComponent44.ArcScale = Me.arcScaleComponent56
            Me.arcScaleBackgroundLayerComponent44.Name = "arcScaleBackgroundLayerComponent44"
            Me.arcScaleBackgroundLayerComponent44.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.85F, 0.85F)
            Me.arcScaleBackgroundLayerComponent44.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style11Left
            Me.arcScaleBackgroundLayerComponent44.ZOrder = 1000
            ' 
            ' arcScaleComponent56
            ' 
            Me.arcScaleComponent56.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent56.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent56.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent56.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent56.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 14F)
            Me.arcScaleComponent56.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent56.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(212F, 212F)
            Me.arcScaleComponent56.EndAngle = -90F
            Me.arcScaleComponent56.MajorTickCount = 4
            Me.arcScaleComponent56.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent56.MajorTickmark.ShapeOffset = -6F
            Me.arcScaleComponent56.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent56.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_4
            Me.arcScaleComponent56.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent56.MaxValue = 50F
            Me.arcScaleComponent56.MinorTickCount = 4
            Me.arcScaleComponent56.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent56.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_3
            Me.arcScaleComponent56.MinValue = 20F
            Me.arcScaleComponent56.Name = "arcScaleComponent56"
            Me.arcScaleComponent56.RadiusX = 176F
            Me.arcScaleComponent56.RadiusY = 176F
            Me.arcScaleComponent56.StartAngle = -180F
            Me.arcScaleComponent56.Value = 30F
            ' 
            ' arcScaleNeedleComponent42
            ' 
            Me.arcScaleNeedleComponent42.ArcScale = Me.arcScaleComponent56
            Me.arcScaleNeedleComponent42.EndOffset = -12F
            Me.arcScaleNeedleComponent42.Name = "arcScaleNeedleComponent42"
            Me.arcScaleNeedleComponent42.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style11
            Me.arcScaleNeedleComponent42.StartOffset = -17.5F
            Me.arcScaleNeedleComponent42.ZOrder = -50
            ' 
            ' arcScaleComponent63
            ' 
            Me.arcScaleComponent63.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent63.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent63.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent63.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent63.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent63.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent63.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(212F, 212F)
            Me.arcScaleComponent63.EndAngle = -90F
            Me.arcScaleComponent63.MajorTickCount = 4
            Me.arcScaleComponent63.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent63.MajorTickmark.ShapeOffset = -3F
            Me.arcScaleComponent63.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_2
            Me.arcScaleComponent63.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent63.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent63.MaxValue = 500F
            Me.arcScaleComponent63.MinorTickCount = 4
            Me.arcScaleComponent63.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_1
            Me.arcScaleComponent63.MinValue = 200F
            Me.arcScaleComponent63.Name = "arcScaleComponent63"
            Me.arcScaleComponent63.RadiusX = 120F
            Me.arcScaleComponent63.RadiusY = 120F
            Me.arcScaleComponent63.StartAngle = -180F
            Me.arcScaleComponent63.Value = 200F
            ' 
            ' gaugeControl64
            ' 
            Me.gaugeControl64.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge43})
            Me.gaugeControl64.Location = New System.Drawing.Point(268, 226)
            Me.gaugeControl64.Name = "gaugeControl64"
            Me.gaugeControl64.Size = New System.Drawing.Size(220, 248)
            Me.gaugeControl64.TabIndex = 6
            ' 
            ' circularGauge43
            ' 
            Me.circularGauge43.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent45})
            Me.circularGauge43.Bounds = New System.Drawing.Rectangle(6, 6, 208, 236)
            Me.circularGauge43.Name = "circularGauge43"
            Me.circularGauge43.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent43})
            Me.circularGauge43.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent57, Me.arcScaleComponent66})
            ' 
            ' arcScaleBackgroundLayerComponent45
            ' 
            Me.arcScaleBackgroundLayerComponent45.ArcScale = Me.arcScaleComponent57
            Me.arcScaleBackgroundLayerComponent45.Name = "arcScaleBackgroundLayerComponent45"
            Me.arcScaleBackgroundLayerComponent45.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.64F)
            Me.arcScaleBackgroundLayerComponent45.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style11
            Me.arcScaleBackgroundLayerComponent45.Size = New System.Drawing.SizeF(250F, 194F)
            Me.arcScaleBackgroundLayerComponent45.ZOrder = 1000
            ' 
            ' arcScaleComponent57
            ' 
            Me.arcScaleComponent57.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent57.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent57.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent57.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent57.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent57.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent57.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent57.EndAngle = 30F
            Me.arcScaleComponent57.MajorTickCount = 9
            Me.arcScaleComponent57.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent57.MajorTickmark.ShapeOffset = -5F
            Me.arcScaleComponent57.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F)
            Me.arcScaleComponent57.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_4
            Me.arcScaleComponent57.MajorTickmark.TextOffset = -17F
            Me.arcScaleComponent57.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent57.MaxValue = 90F
            Me.arcScaleComponent57.MinorTickCount = 4
            Me.arcScaleComponent57.MinorTickmark.ShapeOffset = -2.5F
            Me.arcScaleComponent57.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F)
            Me.arcScaleComponent57.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_3
            Me.arcScaleComponent57.MinValue = 10F
            Me.arcScaleComponent57.Name = "arcScaleComponent57"
            Me.arcScaleComponent57.RadiusX = 107F
            Me.arcScaleComponent57.RadiusY = 107F
            Me.arcScaleComponent57.StartAngle = -210F
            Me.arcScaleComponent57.Value = 20F
            ' 
            ' arcScaleNeedleComponent43
            ' 
            Me.arcScaleNeedleComponent43.ArcScale = Me.arcScaleComponent57
            Me.arcScaleNeedleComponent43.EndOffset = 5F
            Me.arcScaleNeedleComponent43.Name = "arcScaleNeedleComponent43"
            Me.arcScaleNeedleComponent43.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style11
            Me.arcScaleNeedleComponent43.StartOffset = -9.5F
            Me.arcScaleNeedleComponent43.ZOrder = -50
            ' 
            ' arcScaleComponent66
            ' 
            Me.arcScaleComponent66.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent66.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent66.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent66.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent66.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent66.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent66.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent66.EndAngle = -30F
            Me.arcScaleComponent66.MajorTickCount = 7
            Me.arcScaleComponent66.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent66.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_2
            Me.arcScaleComponent66.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent66.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent66.MaxValue = 700F
            Me.arcScaleComponent66.MinorTickCount = 4
            Me.arcScaleComponent66.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_1
            Me.arcScaleComponent66.MinValue = 100F
            Me.arcScaleComponent66.Name = "arcScaleComponent66"
            Me.arcScaleComponent66.RadiusX = 70F
            Me.arcScaleComponent66.RadiusY = 70F
            Me.arcScaleComponent66.StartAngle = -210F
            Me.arcScaleComponent66.Value = 100F
            ' 
            ' gaugeControl65
            ' 
            Me.gaugeControl65.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge11})
            Me.gaugeControl65.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl65.Name = "gaugeControl65"
            Me.gaugeControl65.Size = New System.Drawing.Size(262, 220)
            Me.gaugeControl65.TabIndex = 5
            ' 
            ' digitalGauge11
            ' 
            Me.digitalGauge11.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C8C8C8")
            Me.digitalGauge11.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.digitalGauge11.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent11})
            Me.digitalGauge11.Bounds = New System.Drawing.Rectangle(6, 6, 250, 208)
            Me.digitalGauge11.DigitCount = 5
            Me.digitalGauge11.Name = "digitalGauge11"
            Me.digitalGauge11.Text = "00,000"
            ' 
            ' digitalBackgroundLayerComponent11
            ' 
            Me.digitalBackgroundLayerComponent11.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125F, 99.9625F)
            Me.digitalBackgroundLayerComponent11.Name = "digitalBackgroundLayerComponent11"
            Me.digitalBackgroundLayerComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style11
            Me.digitalBackgroundLayerComponent11.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
            Me.digitalBackgroundLayerComponent11.ZOrder = 1000
            ' 
            ' gaugeControl66
            ' 
            Me.gaugeControl66.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge44})
            Me.gaugeControl66.Location = New System.Drawing.Point(492, 2)
            Me.gaugeControl66.Name = "gaugeControl66"
            Me.gaugeControl66.Size = New System.Drawing.Size(219, 220)
            Me.gaugeControl66.TabIndex = 4
            ' 
            ' circularGauge44
            ' 
            Me.circularGauge44.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent46})
            Me.circularGauge44.Bounds = New System.Drawing.Rectangle(6, 6, 207, 208)
            Me.circularGauge44.Name = "circularGauge44"
            Me.circularGauge44.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent44})
            Me.circularGauge44.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent58, Me.arcScaleComponent65})
            ' 
            ' arcScaleBackgroundLayerComponent46
            ' 
            Me.arcScaleBackgroundLayerComponent46.ArcScale = Me.arcScaleComponent58
            Me.arcScaleBackgroundLayerComponent46.Name = "arcScaleBackgroundLayerComponent46"
            Me.arcScaleBackgroundLayerComponent46.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style11
            Me.arcScaleBackgroundLayerComponent46.ZOrder = 1000
            ' 
            ' arcScaleComponent58
            ' 
            Me.arcScaleComponent58.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent58.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent58.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent58.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent58.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent58.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent58.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent58.EndAngle = 60F
            Me.arcScaleComponent58.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent58.MajorTickmark.ShapeOffset = -5F
            Me.arcScaleComponent58.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F)
            Me.arcScaleComponent58.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_4
            Me.arcScaleComponent58.MajorTickmark.TextOffset = -17F
            Me.arcScaleComponent58.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent58.MaxValue = 100F
            Me.arcScaleComponent58.MinorTickCount = 4
            Me.arcScaleComponent58.MinorTickmark.ShapeOffset = -2.5F
            Me.arcScaleComponent58.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F)
            Me.arcScaleComponent58.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_3
            Me.arcScaleComponent58.Name = "arcScaleComponent58"
            Me.arcScaleComponent58.RadiusX = 107F
            Me.arcScaleComponent58.RadiusY = 107F
            Me.arcScaleComponent58.StartAngle = -240F
            ' 
            ' arcScaleNeedleComponent44
            ' 
            Me.arcScaleNeedleComponent44.ArcScale = Me.arcScaleComponent58
            Me.arcScaleNeedleComponent44.EndOffset = 5F
            Me.arcScaleNeedleComponent44.Name = "arcScaleNeedleComponent44"
            Me.arcScaleNeedleComponent44.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style11
            Me.arcScaleNeedleComponent44.StartOffset = -9.5F
            Me.arcScaleNeedleComponent44.ZOrder = -50
            ' 
            ' arcScaleComponent65
            ' 
            Me.arcScaleComponent65.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent65.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent65.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent65.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent65.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent65.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent65.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent65.EndAngle = -30F
            Me.arcScaleComponent65.MajorTickCount = 8
            Me.arcScaleComponent65.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent65.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_2
            Me.arcScaleComponent65.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent65.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent65.MaxValue = 700F
            Me.arcScaleComponent65.MinorTickCount = 4
            Me.arcScaleComponent65.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_1
            Me.arcScaleComponent65.Name = "arcScaleComponent65"
            Me.arcScaleComponent65.RadiusX = 70F
            Me.arcScaleComponent65.RadiusY = 70F
            Me.arcScaleComponent65.StartAngle = -240F
            ' 
            ' layoutControlGroup11
            ' 
            Me.layoutControlGroup11.AllowDrawBackground = False
            Me.layoutControlGroup11.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup11.GroupBordersVisible = False
            Me.layoutControlGroup11.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem61, Me.layoutControlItem62, Me.layoutControlItem63, Me.layoutControlItem64, Me.layoutControlItem65, Me.layoutControlItem66})
            Me.layoutControlGroup11.Name = "layoutControlGroup1"
            Me.layoutControlGroup11.Size = New System.Drawing.Size(713, 476)
            Me.layoutControlGroup11.TextVisible = False
            ' 
            ' layoutControlItem61
            ' 
            Me.layoutControlItem61.Control = Me.gaugeControl65
            Me.layoutControlItem61.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem61.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem61.Name = "layoutControlItem2"
            Me.layoutControlItem61.Size = New System.Drawing.Size(266, 224)
            Me.layoutControlItem61.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem61.TextVisible = False
            ' 
            ' layoutControlItem62
            ' 
            Me.layoutControlItem62.Control = Me.gaugeControl63
            Me.layoutControlItem62.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem62.Location = New System.Drawing.Point(0, 224)
            Me.layoutControlItem62.Name = "layoutControlItem4"
            Me.layoutControlItem62.Size = New System.Drawing.Size(266, 252)
            Me.layoutControlItem62.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem62.TextVisible = False
            ' 
            ' layoutControlItem63
            ' 
            Me.layoutControlItem63.Control = Me.gaugeControl64
            Me.layoutControlItem63.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem63.Location = New System.Drawing.Point(266, 224)
            Me.layoutControlItem63.Name = "layoutControlItem3"
            Me.layoutControlItem63.Size = New System.Drawing.Size(224, 252)
            Me.layoutControlItem63.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem63.TextVisible = False
            ' 
            ' layoutControlItem64
            ' 
            Me.layoutControlItem64.Control = Me.gaugeControl61
            Me.layoutControlItem64.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem64.Location = New System.Drawing.Point(490, 224)
            Me.layoutControlItem64.Name = "layoutControlItem6"
            Me.layoutControlItem64.Size = New System.Drawing.Size(223, 252)
            Me.layoutControlItem64.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem64.TextVisible = False
            ' 
            ' layoutControlItem65
            ' 
            Me.layoutControlItem65.Control = Me.gaugeControl66
            Me.layoutControlItem65.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem65.Location = New System.Drawing.Point(490, 0)
            Me.layoutControlItem65.Name = "layoutControlItem1"
            Me.layoutControlItem65.Size = New System.Drawing.Size(223, 224)
            Me.layoutControlItem65.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem65.TextVisible = False
            ' 
            ' layoutControlItem66
            ' 
            Me.layoutControlItem66.Control = Me.gaugeControl62
            Me.layoutControlItem66.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem66.Location = New System.Drawing.Point(266, 0)
            Me.layoutControlItem66.Name = "layoutControlItem5"
            Me.layoutControlItem66.Size = New System.Drawing.Size(224, 224)
            Me.layoutControlItem66.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem66.TextVisible = False
            ' 
            ' layoutControl9
            ' 
            Me.layoutControl9.Controls.Add(Me.gaugeControl49)
            Me.layoutControl9.Controls.Add(Me.gaugeControl50)
            Me.layoutControl9.Controls.Add(Me.gaugeControl51)
            Me.layoutControl9.Controls.Add(Me.gaugeControl52)
            Me.layoutControl9.Controls.Add(Me.gaugeControl53)
            Me.layoutControl9.Controls.Add(Me.gaugeControl54)
            Me.layoutControl9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl9.Location = New System.Drawing.Point(3, 3)
            Me.layoutControl9.Name = "layoutControl9"
            Me.layoutControl9.Root = Me.layoutControlGroup9
            Me.layoutControl9.Size = New System.Drawing.Size(713, 476)
            Me.layoutControl9.TabIndex = 3
            Me.layoutControl9.Text = "layoutControl8"
            ' 
            ' gaugeControl49
            ' 
            Me.gaugeControl49.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge9})
            Me.gaugeControl49.Location = New System.Drawing.Point(503, 243)
            Me.gaugeControl49.Name = "gaugeControl49"
            Me.gaugeControl49.Size = New System.Drawing.Size(208, 231)
            Me.gaugeControl49.TabIndex = 9
            ' 
            ' linearGauge9
            ' 
            Me.linearGauge9.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent9})
            Me.linearGauge9.Bounds = New System.Drawing.Rectangle(6, 6, 196, 219)
            Me.linearGauge9.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent9})
            Me.linearGauge9.Name = "linearGauge9"
            Me.linearGauge9.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent17, Me.linearScaleComponent18})
            ' 
            ' linearScaleBackgroundLayerComponent9
            ' 
            Me.linearScaleBackgroundLayerComponent9.LinearScale = Me.linearScaleComponent17
            Me.linearScaleBackgroundLayerComponent9.Name = "linearScaleBackgroundLayerComponent9"
            Me.linearScaleBackgroundLayerComponent9.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.505F, 0.85F)
            Me.linearScaleBackgroundLayerComponent9.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.505F, 0.15F)
            Me.linearScaleBackgroundLayerComponent9.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style9
            Me.linearScaleBackgroundLayerComponent9.ZOrder = 1000
            ' 
            ' linearScaleComponent17
            ' 
            Me.linearScaleComponent17.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent17.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent17.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent17.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent17.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 35F)
            Me.linearScaleComponent17.MajorTickCount = 6
            Me.linearScaleComponent17.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent17.MajorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent17.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.5F, 1.2F)
            Me.linearScaleComponent17.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style9_2
            Me.linearScaleComponent17.MajorTickmark.TextOffset = -40F
            Me.linearScaleComponent17.MaxValue = 500F
            Me.linearScaleComponent17.MinorTickCount = 4
            Me.linearScaleComponent17.MinorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent17.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style9_1
            Me.linearScaleComponent17.Name = "linearScaleComponent17"
            Me.linearScaleComponent17.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F)
            Me.linearScaleComponent17.Value = 1F
            ' 
            ' linearScaleLevelComponent9
            ' 
            Me.linearScaleLevelComponent9.LinearScale = Me.linearScaleComponent17
            Me.linearScaleLevelComponent9.Name = "linearScaleLevelComponent9"
            Me.linearScaleLevelComponent9.ZOrder = -50
            ' 
            ' linearScaleComponent18
            ' 
            Me.linearScaleComponent18.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent18.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent18.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent18.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent18.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 35F)
            Me.linearScaleComponent18.MajorTickCount = 6
            Me.linearScaleComponent18.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent18.MajorTickmark.ShapeOffset = -21F
            Me.linearScaleComponent18.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.5F, 1.2F)
            Me.linearScaleComponent18.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style9_3
            Me.linearScaleComponent18.MajorTickmark.TextOffset = 30F
            Me.linearScaleComponent18.MaxValue = 50F
            Me.linearScaleComponent18.MinorTickCount = 4
            Me.linearScaleComponent18.MinorTickmark.ShapeOffset = -10.5F
            Me.linearScaleComponent18.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style9_1
            Me.linearScaleComponent18.Name = "linearScaleComponent18"
            Me.linearScaleComponent18.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F)
            ' 
            ' gaugeControl50
            ' 
            Me.gaugeControl50.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge33})
            Me.gaugeControl50.Location = New System.Drawing.Point(274, 2)
            Me.gaugeControl50.Name = "gaugeControl50"
            Me.gaugeControl50.Size = New System.Drawing.Size(225, 237)
            Me.gaugeControl50.TabIndex = 8
            ' 
            ' circularGauge33
            ' 
            Me.circularGauge33.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent35})
            Me.circularGauge33.Bounds = New System.Drawing.Rectangle(6, 6, 213, 225)
            Me.circularGauge33.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent17})
            Me.circularGauge33.Name = "circularGauge33"
            Me.circularGauge33.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent33})
            Me.circularGauge33.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent47})
            Me.circularGauge33.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent25})
            ' 
            ' arcScaleBackgroundLayerComponent35
            ' 
            Me.arcScaleBackgroundLayerComponent35.ArcScale = Me.arcScaleComponent47
            Me.arcScaleBackgroundLayerComponent35.Name = "arcScaleBackgroundLayerComponent35"
            Me.arcScaleBackgroundLayerComponent35.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.723F)
            Me.arcScaleBackgroundLayerComponent35.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style9
            Me.arcScaleBackgroundLayerComponent35.Size = New System.Drawing.SizeF(250F, 170F)
            Me.arcScaleBackgroundLayerComponent35.ZOrder = 1000
            ' 
            ' arcScaleComponent47
            ' 
            Me.arcScaleComponent47.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent47.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent47.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent47.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent47.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            Me.arcScaleComponent47.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent47.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent47.EndAngle = 0F
            Me.arcScaleComponent47.MajorTickCount = 7
            Me.arcScaleComponent47.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent47.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_2
            Me.arcScaleComponent47.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent47.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent47.MaxValue = 80F
            Me.arcScaleComponent47.MinorTickCount = 4
            Me.arcScaleComponent47.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_1
            Me.arcScaleComponent47.MinValue = 20F
            Me.arcScaleComponent47.Name = "arcScaleComponent47"
            Me.arcScaleComponent47.RadiusX = 78F
            Me.arcScaleComponent47.RadiusY = 78F
            Me.arcScaleComponent47.StartAngle = -180F
            Me.arcScaleComponent47.Value = 20F
            ' 
            ' arcScaleEffectLayerComponent17
            ' 
            Me.arcScaleEffectLayerComponent17.ArcScale = Me.arcScaleComponent47
            Me.arcScaleEffectLayerComponent17.Name = "arcScaleEffectLayerComponent17"
            Me.arcScaleEffectLayerComponent17.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Style9
            Me.arcScaleEffectLayerComponent17.Size = New System.Drawing.SizeF(222F, 100F)
            Me.arcScaleEffectLayerComponent17.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent33
            ' 
            Me.arcScaleNeedleComponent33.ArcScale = Me.arcScaleComponent47
            Me.arcScaleNeedleComponent33.Name = "arcScaleNeedleComponent33"
            Me.arcScaleNeedleComponent33.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style9
            Me.arcScaleNeedleComponent33.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent25
            ' 
            Me.arcScaleSpindleCapComponent25.ArcScale = Me.arcScaleComponent47
            Me.arcScaleSpindleCapComponent25.Name = "arcScaleSpindleCapComponent25"
            Me.arcScaleSpindleCapComponent25.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style9
            Me.arcScaleSpindleCapComponent25.Size = New System.Drawing.SizeF(35F, 35F)
            Me.arcScaleSpindleCapComponent25.ZOrder = -100
            ' 
            ' gaugeControl51
            ' 
            Me.gaugeControl51.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge34})
            Me.gaugeControl51.Location = New System.Drawing.Point(2, 243)
            Me.gaugeControl51.Name = "gaugeControl51"
            Me.gaugeControl51.Size = New System.Drawing.Size(268, 231)
            Me.gaugeControl51.TabIndex = 7
            ' 
            ' circularGauge34
            ' 
            Me.circularGauge34.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent36})
            Me.circularGauge34.Bounds = New System.Drawing.Rectangle(6, 6, 256, 219)
            Me.circularGauge34.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent18})
            Me.circularGauge34.Name = "circularGauge34"
            Me.circularGauge34.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent34})
            Me.circularGauge34.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent48})
            Me.circularGauge34.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent26})
            ' 
            ' arcScaleBackgroundLayerComponent36
            ' 
            Me.arcScaleBackgroundLayerComponent36.ArcScale = Me.arcScaleComponent48
            Me.arcScaleBackgroundLayerComponent36.Name = "arcScaleBackgroundLayerComponent36"
            Me.arcScaleBackgroundLayerComponent36.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.723F, 0.723F)
            Me.arcScaleBackgroundLayerComponent36.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style9Left
            Me.arcScaleBackgroundLayerComponent36.Size = New System.Drawing.SizeF(249F, 249F)
            Me.arcScaleBackgroundLayerComponent36.ZOrder = 1000
            ' 
            ' arcScaleComponent48
            ' 
            Me.arcScaleComponent48.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent48.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent48.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent48.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent48.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent48.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent48.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(180F, 180F)
            Me.arcScaleComponent48.EndAngle = -90F
            Me.arcScaleComponent48.MajorTickCount = 5
            Me.arcScaleComponent48.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent48.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_2
            Me.arcScaleComponent48.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent48.MaxValue = 60F
            Me.arcScaleComponent48.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_1
            Me.arcScaleComponent48.MinValue = 20F
            Me.arcScaleComponent48.Name = "arcScaleComponent48"
            Me.arcScaleComponent48.RadiusX = 114F
            Me.arcScaleComponent48.RadiusY = 114F
            Me.arcScaleComponent48.StartAngle = -180F
            Me.arcScaleComponent48.Value = 20F
            ' 
            ' arcScaleEffectLayerComponent18
            ' 
            Me.arcScaleEffectLayerComponent18.ArcScale = Me.arcScaleComponent48
            Me.arcScaleEffectLayerComponent18.Name = "arcScaleEffectLayerComponent18"
            Me.arcScaleEffectLayerComponent18.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.8F, 1.1F)
            Me.arcScaleEffectLayerComponent18.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularQuarter_Style9Left
            Me.arcScaleEffectLayerComponent18.Size = New System.Drawing.SizeF(200F, 145F)
            Me.arcScaleEffectLayerComponent18.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent34
            ' 
            Me.arcScaleNeedleComponent34.ArcScale = Me.arcScaleComponent48
            Me.arcScaleNeedleComponent34.Name = "arcScaleNeedleComponent34"
            Me.arcScaleNeedleComponent34.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style9
            Me.arcScaleNeedleComponent34.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent26
            ' 
            Me.arcScaleSpindleCapComponent26.ArcScale = Me.arcScaleComponent48
            Me.arcScaleSpindleCapComponent26.Name = "arcScaleSpindleCapComponent26"
            Me.arcScaleSpindleCapComponent26.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style9
            Me.arcScaleSpindleCapComponent26.Size = New System.Drawing.SizeF(45F, 45F)
            Me.arcScaleSpindleCapComponent26.ZOrder = -100
            ' 
            ' gaugeControl52
            ' 
            Me.gaugeControl52.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge35})
            Me.gaugeControl52.Location = New System.Drawing.Point(274, 243)
            Me.gaugeControl52.Name = "gaugeControl52"
            Me.gaugeControl52.Size = New System.Drawing.Size(225, 231)
            Me.gaugeControl52.TabIndex = 6
            ' 
            ' circularGauge35
            ' 
            Me.circularGauge35.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent37})
            Me.circularGauge35.Bounds = New System.Drawing.Rectangle(6, 6, 213, 219)
            Me.circularGauge35.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent19})
            Me.circularGauge35.Name = "circularGauge35"
            Me.circularGauge35.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent35})
            Me.circularGauge35.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent49})
            Me.circularGauge35.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent27})
            ' 
            ' arcScaleBackgroundLayerComponent37
            ' 
            Me.arcScaleBackgroundLayerComponent37.ArcScale = Me.arcScaleComponent49
            Me.arcScaleBackgroundLayerComponent37.Name = "arcScaleBackgroundLayerComponent37"
            Me.arcScaleBackgroundLayerComponent37.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.615F)
            Me.arcScaleBackgroundLayerComponent37.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style9
            Me.arcScaleBackgroundLayerComponent37.Size = New System.Drawing.SizeF(246F, 200F)
            Me.arcScaleBackgroundLayerComponent37.ZOrder = 1000
            ' 
            ' arcScaleComponent49
            ' 
            Me.arcScaleComponent49.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent49.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent49.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent49.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent49.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent49.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent49.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent49.EndAngle = 30F
            Me.arcScaleComponent49.MajorTickCount = 9
            Me.arcScaleComponent49.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent49.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_2
            Me.arcScaleComponent49.MajorTickmark.TextOffset = -18F
            Me.arcScaleComponent49.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent49.MaxValue = 80F
            Me.arcScaleComponent49.MinorTickCount = 4
            Me.arcScaleComponent49.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_1
            Me.arcScaleComponent49.Name = "arcScaleComponent49"
            Me.arcScaleComponent49.RadiusX = 77F
            Me.arcScaleComponent49.RadiusY = 77F
            Me.arcScaleComponent49.StartAngle = -210F
            Me.arcScaleComponent49.Value = 1F
            ' 
            ' arcScaleEffectLayerComponent19
            ' 
            Me.arcScaleEffectLayerComponent19.ArcScale = Me.arcScaleComponent49
            Me.arcScaleEffectLayerComponent19.Name = "arcScaleEffectLayerComponent19"
            Me.arcScaleEffectLayerComponent19.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularThreeFourth_Style9
            Me.arcScaleEffectLayerComponent19.Size = New System.Drawing.SizeF(222F, 100F)
            Me.arcScaleEffectLayerComponent19.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent35
            ' 
            Me.arcScaleNeedleComponent35.ArcScale = Me.arcScaleComponent49
            Me.arcScaleNeedleComponent35.Name = "arcScaleNeedleComponent35"
            Me.arcScaleNeedleComponent35.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style9
            Me.arcScaleNeedleComponent35.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent27
            ' 
            Me.arcScaleSpindleCapComponent27.ArcScale = Me.arcScaleComponent49
            Me.arcScaleSpindleCapComponent27.Name = "arcScaleSpindleCapComponent27"
            Me.arcScaleSpindleCapComponent27.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style9
            Me.arcScaleSpindleCapComponent27.Size = New System.Drawing.SizeF(35F, 35F)
            Me.arcScaleSpindleCapComponent27.ZOrder = -100
            ' 
            ' gaugeControl53
            ' 
            Me.gaugeControl53.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge9})
            Me.gaugeControl53.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl53.Name = "gaugeControl53"
            Me.gaugeControl53.Size = New System.Drawing.Size(268, 237)
            Me.gaugeControl53.TabIndex = 5
            ' 
            ' digitalGauge9
            ' 
            Me.digitalGauge9.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
            Me.digitalGauge9.AppearanceOn.BorderWidth = 2F
            Me.digitalGauge9.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:DimGray")
            Me.digitalGauge9.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent9})
            Me.digitalGauge9.Bounds = New System.Drawing.Rectangle(6, 6, 256, 225)
            Me.digitalGauge9.DigitCount = 5
            Me.digitalGauge9.Name = "digitalGauge9"
            Me.digitalGauge9.Text = "00,000"
            ' 
            ' digitalBackgroundLayerComponent9
            ' 
            Me.digitalBackgroundLayerComponent9.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125F, 99.9625F)
            Me.digitalBackgroundLayerComponent9.Name = "digitalBackgroundLayerComponent9"
            Me.digitalBackgroundLayerComponent9.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style9
            Me.digitalBackgroundLayerComponent9.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
            Me.digitalBackgroundLayerComponent9.ZOrder = 1000
            ' 
            ' gaugeControl54
            ' 
            Me.gaugeControl54.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge36})
            Me.gaugeControl54.Location = New System.Drawing.Point(503, 2)
            Me.gaugeControl54.Name = "gaugeControl54"
            Me.gaugeControl54.Size = New System.Drawing.Size(208, 237)
            Me.gaugeControl54.TabIndex = 4
            ' 
            ' circularGauge36
            ' 
            Me.circularGauge36.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent38})
            Me.circularGauge36.Bounds = New System.Drawing.Rectangle(6, 6, 196, 225)
            Me.circularGauge36.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent20})
            Me.circularGauge36.Name = "circularGauge36"
            Me.circularGauge36.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent36})
            Me.circularGauge36.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent50})
            Me.circularGauge36.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent28})
            ' 
            ' arcScaleBackgroundLayerComponent38
            ' 
            Me.arcScaleBackgroundLayerComponent38.ArcScale = Me.arcScaleComponent50
            Me.arcScaleBackgroundLayerComponent38.Name = "arcScaleBackgroundLayerComponent38"
            Me.arcScaleBackgroundLayerComponent38.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style9
            Me.arcScaleBackgroundLayerComponent38.ZOrder = 1000
            ' 
            ' arcScaleComponent50
            ' 
            Me.arcScaleComponent50.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent50.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent50.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent50.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent50.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            Me.arcScaleComponent50.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent50.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent50.EndAngle = 60F
            Me.arcScaleComponent50.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent50.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_2
            Me.arcScaleComponent50.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent50.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent50.MaxValue = 100F
            Me.arcScaleComponent50.MinorTickCount = 4
            Me.arcScaleComponent50.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style9_1
            Me.arcScaleComponent50.Name = "arcScaleComponent50"
            Me.arcScaleComponent50.RadiusX = 78F
            Me.arcScaleComponent50.RadiusY = 78F
            Me.arcScaleComponent50.StartAngle = -240F
            ' 
            ' arcScaleEffectLayerComponent20
            ' 
            Me.arcScaleEffectLayerComponent20.ArcScale = Me.arcScaleComponent50
            Me.arcScaleEffectLayerComponent20.Name = "arcScaleEffectLayerComponent20"
            Me.arcScaleEffectLayerComponent20.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Style9
            Me.arcScaleEffectLayerComponent20.Size = New System.Drawing.SizeF(222F, 100F)
            Me.arcScaleEffectLayerComponent20.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent36
            ' 
            Me.arcScaleNeedleComponent36.ArcScale = Me.arcScaleComponent50
            Me.arcScaleNeedleComponent36.Name = "arcScaleNeedleComponent36"
            Me.arcScaleNeedleComponent36.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style9
            Me.arcScaleNeedleComponent36.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent28
            ' 
            Me.arcScaleSpindleCapComponent28.ArcScale = Me.arcScaleComponent50
            Me.arcScaleSpindleCapComponent28.Name = "arcScaleSpindleCapComponent28"
            Me.arcScaleSpindleCapComponent28.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style9
            Me.arcScaleSpindleCapComponent28.Size = New System.Drawing.SizeF(35F, 35F)
            Me.arcScaleSpindleCapComponent28.ZOrder = -100
            ' 
            ' layoutControlGroup9
            ' 
            Me.layoutControlGroup9.AllowDrawBackground = False
            Me.layoutControlGroup9.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup9.GroupBordersVisible = False
            Me.layoutControlGroup9.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem49, Me.layoutControlItem50, Me.layoutControlItem51, Me.layoutControlItem52, Me.layoutControlItem53, Me.layoutControlItem54})
            Me.layoutControlGroup9.Name = "layoutControlGroup1"
            Me.layoutControlGroup9.Size = New System.Drawing.Size(713, 476)
            Me.layoutControlGroup9.TextVisible = False
            ' 
            ' layoutControlItem49
            ' 
            Me.layoutControlItem49.Control = Me.gaugeControl53
            Me.layoutControlItem49.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem49.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem49.Name = "layoutControlItem2"
            Me.layoutControlItem49.Size = New System.Drawing.Size(272, 241)
            Me.layoutControlItem49.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem49.TextVisible = False
            ' 
            ' layoutControlItem50
            ' 
            Me.layoutControlItem50.Control = Me.gaugeControl51
            Me.layoutControlItem50.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem50.Location = New System.Drawing.Point(0, 241)
            Me.layoutControlItem50.Name = "layoutControlItem4"
            Me.layoutControlItem50.Size = New System.Drawing.Size(272, 235)
            Me.layoutControlItem50.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem50.TextVisible = False
            ' 
            ' layoutControlItem51
            ' 
            Me.layoutControlItem51.Control = Me.gaugeControl52
            Me.layoutControlItem51.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem51.Location = New System.Drawing.Point(272, 241)
            Me.layoutControlItem51.Name = "layoutControlItem3"
            Me.layoutControlItem51.Size = New System.Drawing.Size(229, 235)
            Me.layoutControlItem51.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem51.TextVisible = False
            ' 
            ' layoutControlItem52
            ' 
            Me.layoutControlItem52.Control = Me.gaugeControl49
            Me.layoutControlItem52.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem52.Location = New System.Drawing.Point(501, 241)
            Me.layoutControlItem52.Name = "layoutControlItem6"
            Me.layoutControlItem52.Size = New System.Drawing.Size(212, 235)
            Me.layoutControlItem52.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem52.TextVisible = False
            ' 
            ' layoutControlItem53
            ' 
            Me.layoutControlItem53.Control = Me.gaugeControl54
            Me.layoutControlItem53.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem53.Location = New System.Drawing.Point(501, 0)
            Me.layoutControlItem53.Name = "layoutControlItem1"
            Me.layoutControlItem53.Size = New System.Drawing.Size(212, 241)
            Me.layoutControlItem53.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem53.TextVisible = False
            ' 
            ' layoutControlItem54
            ' 
            Me.layoutControlItem54.Control = Me.gaugeControl50
            Me.layoutControlItem54.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem54.Location = New System.Drawing.Point(272, 0)
            Me.layoutControlItem54.Name = "layoutControlItem5"
            Me.layoutControlItem54.Size = New System.Drawing.Size(229, 241)
            Me.layoutControlItem54.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem54.TextVisible = False
            ' 
            ' GaugesStyles
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "GaugesStyles"
            Me.Size = New System.Drawing.Size(728, 513)
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.linearGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleLevelComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage2.ResumeLayout(False)
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.linearGauge2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleBackgroundLayerComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleLevelComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent34), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent33), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage3.ResumeLayout(False)
            CType((Me.layoutControl3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl3.ResumeLayout(False)
            CType((Me.linearGauge3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleBackgroundLayerComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleLevelComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent35), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent37), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent38), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent33), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent36), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem18), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage4.ResumeLayout(False)
            CType((Me.layoutControl4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl4.ResumeLayout(False)
            CType((Me.linearGauge4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleBackgroundLayerComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleLevelComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent39), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent41), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent42), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent34), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent40), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem22), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem23), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem24), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage5.ResumeLayout(False)
            CType((Me.layoutControl5), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl5.ResumeLayout(False)
            CType((Me.linearGauge5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleBackgroundLayerComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleEffectLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleLevelComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent43), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent45), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent44), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem25), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem26), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem27), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem28), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem29), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem30), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage6.ResumeLayout(False)
            CType((Me.layoutControl6), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl6.ResumeLayout(False)
            CType((Me.linearGauge6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleBackgroundLayerComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleLevelComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge22), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent22), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent22), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent22), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge23), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent23), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent23), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent23), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge24), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent24), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent24), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent24), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem31), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem32), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem33), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem34), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem35), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem36), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage7.ResumeLayout(False)
            CType((Me.layoutControl7), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl7.ResumeLayout(False)
            CType((Me.linearGauge7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleBackgroundLayerComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleLevelComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge25), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent25), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent25), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent25), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge26), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent26), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent26), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent26), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge27), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent27), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent27), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent27), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent46), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge28), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent28), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent28), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent28), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem37), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem38), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem39), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem40), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem41), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem42), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage8.ResumeLayout(False)
            CType((Me.layoutControl8), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl8.ResumeLayout(False)
            CType((Me.linearGauge8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleBackgroundLayerComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleLevelComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge29), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent29), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent29), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent29), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge30), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent30), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent30), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent30), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent23), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge31), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent31), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent31), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent31), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent24), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge32), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent32), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent32), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent32), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent22), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem43), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem44), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem45), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem46), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem47), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem48), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage9.ResumeLayout(False)
            CType((Me.layoutControl10), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl10.ResumeLayout(False)
            CType((Me.linearGauge10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleBackgroundLayerComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleLevelComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge37), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent39), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent51), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent37), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent59), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge38), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent40), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent52), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent38), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent61), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge39), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent41), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent53), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent39), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent62), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge40), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent42), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent54), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent40), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent60), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem55), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem56), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem57), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem58), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem59), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem60), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage10.ResumeLayout(False)
            CType((Me.layoutControl11), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl11.ResumeLayout(False)
            CType((Me.linearGauge11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleBackgroundLayerComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleLevelComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent22), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge41), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent43), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent55), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent41), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent64), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge42), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent44), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent56), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent42), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent63), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge43), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent45), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent57), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent43), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent66), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge44), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent46), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent58), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent44), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent65), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem61), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem62), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem63), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem64), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem65), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem66), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl9), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl9.ResumeLayout(False)
            CType((Me.linearGauge9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleBackgroundLayerComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleLevelComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge33), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent35), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent47), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent33), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent25), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge34), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent36), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent48), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent34), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent26), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge35), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent37), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent49), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent35), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent27), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge36), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent38), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent50), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent36), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent28), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem49), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem50), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem51), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem52), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem53), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem54), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private xtraTabControl1 As DevExpress.XtraBars.Navigation.TabPane

        Private xtraTabPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private gaugeControl4 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl3 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private xtraTabPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private xtraTabPage3 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private xtraTabPage4 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private xtraTabPage5 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private xtraTabPage6 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private xtraTabPage7 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private gaugeControl6 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl5 As DevExpress.XtraGauges.Win.GaugeControl

        Private digitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl3 As DevExpress.XtraLayout.LayoutControl

        Private gaugeControl13 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl14 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl15 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl16 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl17 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl18 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl4 As DevExpress.XtraLayout.LayoutControl

        Private gaugeControl19 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl20 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl21 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl22 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl23 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl24 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl5 As DevExpress.XtraLayout.LayoutControl

        Private gaugeControl25 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl26 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl27 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl28 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl29 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl30 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl6 As DevExpress.XtraLayout.LayoutControl

        Private gaugeControl31 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl32 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl33 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl34 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl35 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl36 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl7 As DevExpress.XtraLayout.LayoutControl

        Private gaugeControl37 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl38 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl39 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl40 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl41 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl42 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl8 As DevExpress.XtraLayout.LayoutControl

        Private gaugeControl43 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl44 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl45 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl46 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl47 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl48 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private gaugeControl7 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl8 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl9 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl10 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl11 As DevExpress.XtraGauges.Win.GaugeControl

        Private digitalGauge2 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private gaugeControl12 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private digitalGauge3 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private digitalGauge4 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private digitalGauge5 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent5 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private digitalGauge6 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent6 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private digitalGauge7 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent7 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private digitalGauge8 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent8 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private xtraTabPage9 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private xtraTabPage10 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl10 As DevExpress.XtraLayout.LayoutControl

        Private gaugeControl55 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl56 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl57 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl58 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl59 As DevExpress.XtraGauges.Win.GaugeControl

        Private digitalGauge10 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent10 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private gaugeControl60 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlGroup10 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem55 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem57 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem58 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem59 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem60 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl11 As DevExpress.XtraLayout.LayoutControl

        Private gaugeControl61 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl62 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl63 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl64 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl65 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl66 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlGroup11 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem61 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem62 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem63 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem64 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem65 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem66 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl9 As DevExpress.XtraLayout.LayoutControl

        Private gaugeControl49 As DevExpress.XtraGauges.Win.GaugeControl

        Private linearGauge9 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayerComponent9 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private linearScaleComponent17 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleLevelComponent9 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private linearScaleComponent18 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private gaugeControl50 As DevExpress.XtraGauges.Win.GaugeControl

        Private circularGauge33 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent35 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent47 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent17 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent33 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent25 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private gaugeControl51 As DevExpress.XtraGauges.Win.GaugeControl

        Private circularGauge34 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent36 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent48 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent18 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent34 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent26 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private gaugeControl52 As DevExpress.XtraGauges.Win.GaugeControl

        Private circularGauge35 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent37 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent49 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent19 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent35 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent27 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private gaugeControl53 As DevExpress.XtraGauges.Win.GaugeControl

        Private digitalGauge9 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent9 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private gaugeControl54 As DevExpress.XtraGauges.Win.GaugeControl

        Private circularGauge36 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent38 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent50 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent20 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent36 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent28 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private layoutControlGroup9 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem50 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem51 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem53 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem54 As DevExpress.XtraLayout.LayoutControlItem

        Private digitalGauge11 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent11 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private circularGauge2 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge3 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge4 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge5 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge6 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent34 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge7 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge8 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent33 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge9 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent35 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge10 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent37 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge11 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent38 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge12 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleBackgroundLayerComponent33 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleNeedleComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent36 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge13 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent39 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge14 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent41 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge15 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent42 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge16 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleBackgroundLayerComponent34 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleNeedleComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent40 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge17 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent17 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent17 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent17 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent43 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge18 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent18 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent18 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent18 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge19 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent19 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent19 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent19 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent45 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge20 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent20 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent20 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent20 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent44 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge21 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent21 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent21 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent21 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private circularGauge22 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent22 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent22 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent22 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private circularGauge23 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent23 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent23 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent23 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private circularGauge24 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent24 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent24 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent24 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private circularGauge25 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent25 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent25 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent25 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent17 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge26 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent26 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent26 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent26 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent19 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge27 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent27 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent27 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent27 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent46 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleSpindleCapComponent20 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge28 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent28 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent28 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent28 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent18 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge29 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent29 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent29 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent29 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent21 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge30 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent30 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent30 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent30 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent23 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge31 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent31 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent31 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent31 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent24 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge32 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent32 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent32 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleEffectLayerComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent32 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent22 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private circularGauge37 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent39 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent51 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent37 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent59 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge38 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent40 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent52 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent38 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent61 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge39 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent41 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent53 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent39 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent62 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge40 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent42 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent54 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent40 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent60 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge41 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent43 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent55 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent41 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent64 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge42 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent44 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent56 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent42 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent63 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge43 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent45 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent57 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent43 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent66 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge44 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent46 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent58 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent44 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent65 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private linearGauge2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private linearScaleComponent3 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleLevelComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private linearScaleComponent4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearGauge3 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private linearScaleComponent5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleLevelComponent3 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private linearScaleComponent6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearGauge4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private linearScaleComponent7 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleLevelComponent4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private linearScaleComponent8 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearGauge5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayerComponent5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private linearScaleComponent9 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleEffectLayerComponent

        Private linearScaleLevelComponent5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private linearScaleComponent10 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearGauge6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayerComponent6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private linearScaleComponent11 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleLevelComponent6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private linearScaleComponent12 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearGauge7 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayerComponent7 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private linearScaleComponent13 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleLevelComponent7 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private linearScaleComponent14 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearGauge10 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayerComponent10 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private linearScaleComponent19 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleLevelComponent10 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private linearScaleComponent20 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearGauge8 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayerComponent8 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private linearScaleComponent15 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleLevelComponent8 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private linearScaleComponent16 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearGauge11 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayerComponent11 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private linearScaleComponent21 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleLevelComponent11 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private linearScaleComponent22 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private linearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleLevelComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private linearScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private xtraTabPage8 As DevExpress.XtraBars.Navigation.TabNavigationPage
    End Class
End Namespace
