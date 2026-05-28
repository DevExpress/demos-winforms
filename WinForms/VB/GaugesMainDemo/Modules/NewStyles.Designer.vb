Namespace DevExpress.XtraGauges.Demos

    Partial Class GaugesNewStyles

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
            Me.arcScaleComponent21 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl4 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge3 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent23 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl3 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge4 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent24 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge21 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent21 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent41 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleBackgroundLayerComponent22 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleNeedleComponent21 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent22 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
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
            Me.arcScaleComponent17 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl9 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge6 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent19 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl10 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge7 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent20 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl11 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge22 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent23 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent42 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleBackgroundLayerComponent24 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleNeedleComponent22 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent43 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl12 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge8 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent18 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
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
            Me.arcScaleComponent25 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl15 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge10 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent28 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl16 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge11 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent27 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl17 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge23 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent25 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent44 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleBackgroundLayerComponent26 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleNeedleComponent23 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent45 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl18 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge12 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent26 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
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
            Me.arcScaleComponent29 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl21 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge14 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent32 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl22 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge15 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent31 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl23 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge24 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent27 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent46 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleBackgroundLayerComponent28 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleNeedleComponent24 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.gaugeControl24 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge16 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent30 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
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
            Me.linearScaleLevelComponent5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.linearScaleComponent10 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.gaugeControl26 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge17 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent17 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent33 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent17 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent34 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl27 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge19 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent19 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent37 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent19 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent38 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl28 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge20 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent20 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent39 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent20 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent40 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.gaugeControl29 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge25 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent29 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent51 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent25 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.gaugeControl30 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge18 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent18 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent35 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent18 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent36 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
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
            CType((Me.arcScaleComponent21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent23), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent24), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent41), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent22), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent22), System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType((Me.arcScaleComponent17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge22), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent23), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent42), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent24), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent22), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent43), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent18), System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType((Me.arcScaleComponent25), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent28), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent27), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge23), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent25), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent44), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent26), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent23), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent45), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent26), System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType((Me.arcScaleComponent29), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent32), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent31), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge24), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent27), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent46), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent28), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent24), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent30), System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType((Me.linearScaleLevelComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent33), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent34), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent37), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent38), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent39), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent40), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge25), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent29), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent51), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent25), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent35), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent36), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem25), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem26), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem27), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem28), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem29), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem30), System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.Padding = New System.Windows.Forms.Padding(3)
            Me.xtraTabControl1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.xtraTabPage1, Me.xtraTabPage2, Me.xtraTabPage3, Me.xtraTabPage4, Me.xtraTabPage5})
            Me.xtraTabControl1.RegularSize = New System.Drawing.Size(728, 513)
            Me.xtraTabControl1.SelectedPage = Me.xtraTabPage1
            Me.xtraTabControl1.Size = New System.Drawing.Size(728, 513)
            Me.xtraTabControl1.TabIndex = 0
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Caption = "White"
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
            Me.linearScaleBackgroundLayerComponent1.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.08F)
            Me.linearScaleBackgroundLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.92F)
            Me.linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style1
            Me.linearScaleBackgroundLayerComponent1.ZOrder = 1000
            ' 
            ' linearScaleComponent1
            ' 
            Me.linearScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F)
            Me.linearScaleComponent1.MajorTickCount = 6
            Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent1.MajorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScaleComponent1.MajorTickmark.TextOffset = 35F
            Me.linearScaleComponent1.MaxValue = 500F
            Me.linearScaleComponent1.MinorTickCount = 4
            Me.linearScaleComponent1.MinorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScaleComponent1.Name = "scale1"
            Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F)
            Me.linearScaleComponent1.Value = 250F
            ' 
            ' linearScaleLevelComponent1
            ' 
            Me.linearScaleLevelComponent1.LinearScale = Me.linearScaleComponent1
            Me.linearScaleLevelComponent1.Name = "level1"
            Me.linearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style1
            Me.linearScaleLevelComponent1.ZOrder = -50
            ' 
            ' linearScaleComponent2
            ' 
            Me.linearScaleComponent2.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent2.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F)
            Me.linearScaleComponent2.MajorTickCount = 6
            Me.linearScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent2.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScaleComponent2.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent2.MaxValue = 50F
            Me.linearScaleComponent2.MinorTickCount = 4
            Me.linearScaleComponent2.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScaleComponent2.Name = "scale2"
            Me.linearScaleComponent2.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F)
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
            Me.circularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent2, Me.arcScaleComponent21})
            ' 
            ' arcScaleBackgroundLayerComponent2
            ' 
            Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleBackgroundLayerComponent2.Name = "bg"
            Me.arcScaleBackgroundLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.815F)
            Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style1
            Me.arcScaleBackgroundLayerComponent2.Size = New System.Drawing.SizeF(250F, 154F)
            Me.arcScaleBackgroundLayerComponent2.ZOrder = 1000
            ' 
            ' arcScaleComponent2
            ' 
            Me.arcScaleComponent2.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11F)
            Me.arcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent2.EndAngle = 0F
            Me.arcScaleComponent2.MajorTickCount = 7
            Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent2.MajorTickmark.ShapeOffset = -3.5F
            Me.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
            Me.arcScaleComponent2.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent2.MaxValue = 80F
            Me.arcScaleComponent2.MinorTickCount = 4
            Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
            Me.arcScaleComponent2.MinValue = 20F
            Me.arcScaleComponent2.Name = "scale1"
            Me.arcScaleComponent2.StartAngle = -180F
            Me.arcScaleComponent2.Value = 50F
            ' 
            ' arcScaleNeedleComponent2
            ' 
            Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleNeedleComponent2.Name = "needle"
            Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
            Me.arcScaleNeedleComponent2.StartOffset = -4.5F
            Me.arcScaleNeedleComponent2.ZOrder = -50
            ' 
            ' arcScaleComponent21
            ' 
            Me.arcScaleComponent21.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent21.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent21.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent21.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent21.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent21.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent21.EndAngle = -30F
            Me.arcScaleComponent21.MajorTickCount = 6
            Me.arcScaleComponent21.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent21.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_2
            Me.arcScaleComponent21.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent21.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent21.MaxValue = 700F
            Me.arcScaleComponent21.MinorTickCount = 4
            Me.arcScaleComponent21.MinorTickmark.ShapeOffset = 2F
            Me.arcScaleComponent21.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_1
            Me.arcScaleComponent21.MinValue = 200F
            Me.arcScaleComponent21.Name = "scale2"
            Me.arcScaleComponent21.RadiusX = 65F
            Me.arcScaleComponent21.RadiusY = 65F
            Me.arcScaleComponent21.StartAngle = -180F
            Me.arcScaleComponent21.Value = 300F
            Me.arcScaleComponent21.ZOrder = -1
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
            Me.circularGauge3.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent3, Me.arcScaleComponent23})
            ' 
            ' arcScaleBackgroundLayerComponent3
            ' 
            Me.arcScaleBackgroundLayerComponent3.ArcScale = Me.arcScaleComponent3
            Me.arcScaleBackgroundLayerComponent3.Name = "bg"
            Me.arcScaleBackgroundLayerComponent3.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.833F, 0.833F)
            Me.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style1Left
            Me.arcScaleBackgroundLayerComponent3.ZOrder = 1000
            ' 
            ' arcScaleComponent3
            ' 
            Me.arcScaleComponent3.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 16F)
            Me.arcScaleComponent3.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(210F, 210F)
            Me.arcScaleComponent3.EndAngle = -90F
            Me.arcScaleComponent3.MajorTickCount = 4
            Me.arcScaleComponent3.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent3.MajorTickmark.ShapeOffset = -3.5F
            Me.arcScaleComponent3.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
            Me.arcScaleComponent3.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent3.MaxValue = 50F
            Me.arcScaleComponent3.MinorTickCount = 4
            Me.arcScaleComponent3.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
            Me.arcScaleComponent3.MinValue = 20F
            Me.arcScaleComponent3.Name = "scale1"
            Me.arcScaleComponent3.RadiusX = 165F
            Me.arcScaleComponent3.RadiusY = 165F
            Me.arcScaleComponent3.StartAngle = -180F
            Me.arcScaleComponent3.Value = 30F
            ' 
            ' arcScaleNeedleComponent3
            ' 
            Me.arcScaleNeedleComponent3.ArcScale = Me.arcScaleComponent3
            Me.arcScaleNeedleComponent3.Name = "needle"
            Me.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
            Me.arcScaleNeedleComponent3.StartOffset = -4.5F
            Me.arcScaleNeedleComponent3.ZOrder = -50
            ' 
            ' arcScaleComponent23
            ' 
            Me.arcScaleComponent23.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent23.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent23.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent23.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent23.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11F)
            Me.arcScaleComponent23.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent23.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(210F, 210F)
            Me.arcScaleComponent23.EndAngle = -90F
            Me.arcScaleComponent23.MajorTickCount = 4
            Me.arcScaleComponent23.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent23.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent23.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_2
            Me.arcScaleComponent23.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent23.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent23.MaxValue = 500F
            Me.arcScaleComponent23.MinorTickCount = 4
            Me.arcScaleComponent23.MinorTickmark.ShapeOffset = 2F
            Me.arcScaleComponent23.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent23.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_1
            Me.arcScaleComponent23.MinValue = 200F
            Me.arcScaleComponent23.Name = "scale2"
            Me.arcScaleComponent23.StartAngle = -180F
            Me.arcScaleComponent23.Value = 300F
            Me.arcScaleComponent23.ZOrder = -1
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
            Me.circularGauge4.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent4, Me.arcScaleComponent24})
            ' 
            ' arcScaleBackgroundLayerComponent4
            ' 
            Me.arcScaleBackgroundLayerComponent4.ArcScale = Me.arcScaleComponent4
            Me.arcScaleBackgroundLayerComponent4.Name = "bg"
            Me.arcScaleBackgroundLayerComponent4.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.619F)
            Me.arcScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style1
            Me.arcScaleBackgroundLayerComponent4.Size = New System.Drawing.SizeF(250F, 202F)
            Me.arcScaleBackgroundLayerComponent4.ZOrder = 1000
            ' 
            ' arcScaleComponent4
            ' 
            Me.arcScaleComponent4.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11F)
            Me.arcScaleComponent4.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent4.EndAngle = 30F
            Me.arcScaleComponent4.MajorTickCount = 9
            Me.arcScaleComponent4.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent4.MajorTickmark.ShapeOffset = -3.5F
            Me.arcScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
            Me.arcScaleComponent4.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent4.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent4.MaxValue = 90F
            Me.arcScaleComponent4.MinorTickCount = 4
            Me.arcScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
            Me.arcScaleComponent4.MinValue = 10F
            Me.arcScaleComponent4.Name = "scale1"
            Me.arcScaleComponent4.StartAngle = -210F
            Me.arcScaleComponent4.Value = 80F
            ' 
            ' arcScaleNeedleComponent4
            ' 
            Me.arcScaleNeedleComponent4.ArcScale = Me.arcScaleComponent4
            Me.arcScaleNeedleComponent4.Name = "needle"
            Me.arcScaleNeedleComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
            Me.arcScaleNeedleComponent4.StartOffset = -4.5F
            Me.arcScaleNeedleComponent4.ZOrder = -50
            ' 
            ' arcScaleComponent24
            ' 
            Me.arcScaleComponent24.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent24.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent24.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent24.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent24.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent24.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent24.EndAngle = -30F
            Me.arcScaleComponent24.MajorTickCount = 7
            Me.arcScaleComponent24.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent24.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_2
            Me.arcScaleComponent24.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent24.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent24.MaxValue = 700F
            Me.arcScaleComponent24.MinorTickCount = 4
            Me.arcScaleComponent24.MinorTickmark.ShapeOffset = 2F
            Me.arcScaleComponent24.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_1
            Me.arcScaleComponent24.MinValue = 100F
            Me.arcScaleComponent24.Name = "scale2"
            Me.arcScaleComponent24.RadiusX = 65F
            Me.arcScaleComponent24.RadiusY = 65F
            Me.arcScaleComponent24.StartAngle = -210F
            Me.arcScaleComponent24.Value = 300F
            Me.arcScaleComponent24.ZOrder = -1
            ' 
            ' gaugeControl2
            ' 
            Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge21})
            Me.gaugeControl2.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl2.Name = "gaugeControl2"
            Me.gaugeControl2.Size = New System.Drawing.Size(265, 219)
            Me.gaugeControl2.TabIndex = 5
            ' 
            ' circularGauge21
            ' 
            Me.circularGauge21.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent21, Me.arcScaleBackgroundLayerComponent22})
            Me.circularGauge21.Bounds = New System.Drawing.Rectangle(6, 6, 253, 207)
            Me.circularGauge21.Name = "circularGauge21"
            Me.circularGauge21.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent21})
            Me.circularGauge21.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent41})
            ' 
            ' arcScaleBackgroundLayerComponent21
            ' 
            Me.arcScaleBackgroundLayerComponent21.ArcScale = Me.arcScaleComponent41
            Me.arcScaleBackgroundLayerComponent21.Name = "bg1"
            Me.arcScaleBackgroundLayerComponent21.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1.8F)
            Me.arcScaleBackgroundLayerComponent21.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style1_1
            Me.arcScaleBackgroundLayerComponent21.Size = New System.Drawing.SizeF(250F, 106F)
            Me.arcScaleBackgroundLayerComponent21.ZOrder = 1000
            ' 
            ' arcScaleComponent41
            ' 
            Me.arcScaleComponent41.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent41.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent41.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent41.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent41.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent41.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent41.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 255F)
            Me.arcScaleComponent41.EndAngle = -53F
            Me.arcScaleComponent41.MajorTickCount = 7
            Me.arcScaleComponent41.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent41.MajorTickmark.ShapeOffset = -8F
            Me.arcScaleComponent41.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
            Me.arcScaleComponent41.MajorTickmark.TextOffset = -22F
            Me.arcScaleComponent41.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent41.MaxValue = 80F
            Me.arcScaleComponent41.MinorTickCount = 4
            Me.arcScaleComponent41.MinorTickmark.ShapeOffset = -4F
            Me.arcScaleComponent41.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
            Me.arcScaleComponent41.MinValue = 20F
            Me.arcScaleComponent41.Name = "scale1"
            Me.arcScaleComponent41.RadiusX = 165F
            Me.arcScaleComponent41.RadiusY = 165F
            Me.arcScaleComponent41.StartAngle = -127F
            Me.arcScaleComponent41.Value = 50F
            ' 
            ' arcScaleBackgroundLayerComponent22
            ' 
            Me.arcScaleBackgroundLayerComponent22.ArcScale = Me.arcScaleComponent41
            Me.arcScaleBackgroundLayerComponent22.Name = "bg2"
            Me.arcScaleBackgroundLayerComponent22.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1.9F)
            Me.arcScaleBackgroundLayerComponent22.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style1
            Me.arcScaleBackgroundLayerComponent22.Size = New System.Drawing.SizeF(242F, 98F)
            Me.arcScaleBackgroundLayerComponent22.ZOrder = 500
            ' 
            ' arcScaleNeedleComponent21
            ' 
            Me.arcScaleNeedleComponent21.ArcScale = Me.arcScaleComponent41
            Me.arcScaleNeedleComponent21.Name = "needle1"
            Me.arcScaleNeedleComponent21.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularWide_Style1
            Me.arcScaleNeedleComponent21.StartOffset = 110F
            Me.arcScaleNeedleComponent21.ZOrder = -50
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
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1, Me.arcScaleComponent22})
            ' 
            ' arcScaleBackgroundLayerComponent1
            ' 
            Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleBackgroundLayerComponent1.Name = "bg"
            Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1
            Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
            ' 
            ' arcScaleComponent1
            ' 
            Me.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11F)
            Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent1.EndAngle = 60F
            Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -3.5F
            Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
            Me.arcScaleComponent1.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent1.MaxValue = 100F
            Me.arcScaleComponent1.MinorTickCount = 4
            Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
            Me.arcScaleComponent1.Name = "scale1"
            Me.arcScaleComponent1.StartAngle = -240F
            Me.arcScaleComponent1.Value = 80F
            ' 
            ' arcScaleNeedleComponent1
            ' 
            Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleNeedleComponent1.Name = "needle"
            Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
            Me.arcScaleNeedleComponent1.StartOffset = -4.5F
            Me.arcScaleNeedleComponent1.ZOrder = -50
            ' 
            ' arcScaleComponent22
            ' 
            Me.arcScaleComponent22.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent22.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent22.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent22.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent22.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent22.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent22.EndAngle = -30F
            Me.arcScaleComponent22.MajorTickCount = 8
            Me.arcScaleComponent22.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent22.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_2
            Me.arcScaleComponent22.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent22.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent22.MaxValue = 700F
            Me.arcScaleComponent22.MinorTickCount = 4
            Me.arcScaleComponent22.MinorTickmark.ShapeOffset = 2F
            Me.arcScaleComponent22.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_1
            Me.arcScaleComponent22.Name = "scale2"
            Me.arcScaleComponent22.RadiusX = 65F
            Me.arcScaleComponent22.RadiusY = 65F
            Me.arcScaleComponent22.StartAngle = -240F
            Me.arcScaleComponent22.Value = 300F
            Me.arcScaleComponent22.ZOrder = -1
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
            Me.xtraTabPage2.Caption = "Sport Car"
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
            Me.linearScaleBackgroundLayerComponent2.Name = "bg1"
            Me.linearScaleBackgroundLayerComponent2.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.08F)
            Me.linearScaleBackgroundLayerComponent2.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.92F)
            Me.linearScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style12
            Me.linearScaleBackgroundLayerComponent2.ZOrder = 1000
            ' 
            ' linearScaleComponent3
            ' 
            Me.linearScaleComponent3.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent3.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent3.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent3.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent3.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent3.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F)
            Me.linearScaleComponent3.MajorTickCount = 6
            Me.linearScaleComponent3.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent3.MajorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style12_2
            Me.linearScaleComponent3.MajorTickmark.TextOffset = 35F
            Me.linearScaleComponent3.MaxValue = 500F
            Me.linearScaleComponent3.MinorTickCount = 4
            Me.linearScaleComponent3.MinorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style12_1
            Me.linearScaleComponent3.Name = "scale1"
            Me.linearScaleComponent3.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F)
            Me.linearScaleComponent3.Value = 250F
            ' 
            ' linearScaleLevelComponent2
            ' 
            Me.linearScaleLevelComponent2.LinearScale = Me.linearScaleComponent3
            Me.linearScaleLevelComponent2.Name = "level1"
            Me.linearScaleLevelComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style12
            Me.linearScaleLevelComponent2.ZOrder = -50
            ' 
            ' linearScaleComponent4
            ' 
            Me.linearScaleComponent4.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent4.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent4.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent4.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent4.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent4.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F)
            Me.linearScaleComponent4.MajorTickCount = 6
            Me.linearScaleComponent4.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent4.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style12_2
            Me.linearScaleComponent4.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent4.MaxValue = 50F
            Me.linearScaleComponent4.MinorTickCount = 4
            Me.linearScaleComponent4.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style12_1
            Me.linearScaleComponent4.Name = "scale2"
            Me.linearScaleComponent4.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F)
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
            Me.circularGauge5.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent5, Me.arcScaleComponent17})
            ' 
            ' arcScaleBackgroundLayerComponent5
            ' 
            Me.arcScaleBackgroundLayerComponent5.ArcScale = Me.arcScaleComponent5
            Me.arcScaleBackgroundLayerComponent5.Name = "bg"
            Me.arcScaleBackgroundLayerComponent5.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.7F)
            Me.arcScaleBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style12
            Me.arcScaleBackgroundLayerComponent5.Size = New System.Drawing.SizeF(250F, 178F)
            Me.arcScaleBackgroundLayerComponent5.ZOrder = 1000
            ' 
            ' arcScaleComponent5
            ' 
            Me.arcScaleComponent5.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent5.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
            Me.arcScaleComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent5.EndAngle = 0F
            Me.arcScaleComponent5.MajorTickCount = 7
            Me.arcScaleComponent5.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent5.MajorTickmark.ShapeOffset = -15F
            Me.arcScaleComponent5.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_1
            Me.arcScaleComponent5.MajorTickmark.TextOffset = 7F
            Me.arcScaleComponent5.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent5.MaxValue = 80F
            Me.arcScaleComponent5.MinorTickCount = 4
            Me.arcScaleComponent5.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_2
            Me.arcScaleComponent5.MinValue = 20F
            Me.arcScaleComponent5.Name = "scale1"
            Me.arcScaleComponent5.RadiusX = 105F
            Me.arcScaleComponent5.RadiusY = 105F
            Me.arcScaleComponent5.StartAngle = -180F
            Me.arcScaleComponent5.Value = 50F
            ' 
            ' arcScaleNeedleComponent5
            ' 
            Me.arcScaleNeedleComponent5.ArcScale = Me.arcScaleComponent5
            Me.arcScaleNeedleComponent5.EndOffset = -7.5F
            Me.arcScaleNeedleComponent5.Name = "needle"
            Me.arcScaleNeedleComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style12
            Me.arcScaleNeedleComponent5.StartOffset = -5F
            Me.arcScaleNeedleComponent5.ZOrder = -50
            ' 
            ' arcScaleComponent17
            ' 
            Me.arcScaleComponent17.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent17.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent17.EndAngle = 0F
            Me.arcScaleComponent17.MajorTickCount = 7
            Me.arcScaleComponent17.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent17.MajorTickmark.ShapeOffset = -4F
            Me.arcScaleComponent17.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_3
            Me.arcScaleComponent17.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent17.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent17.MaxValue = 800F
            Me.arcScaleComponent17.MinorTickCount = 4
            Me.arcScaleComponent17.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_4
            Me.arcScaleComponent17.MinValue = 200F
            Me.arcScaleComponent17.Name = "scale2"
            Me.arcScaleComponent17.RadiusX = 65F
            Me.arcScaleComponent17.RadiusY = 65F
            Me.arcScaleComponent17.StartAngle = -180F
            Me.arcScaleComponent17.Value = 300F
            Me.arcScaleComponent17.ZOrder = -1
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
            Me.circularGauge6.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent6, Me.arcScaleComponent19})
            ' 
            ' arcScaleBackgroundLayerComponent6
            ' 
            Me.arcScaleBackgroundLayerComponent6.ArcScale = Me.arcScaleComponent6
            Me.arcScaleBackgroundLayerComponent6.Name = "bg"
            Me.arcScaleBackgroundLayerComponent6.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.822F, 0.822F)
            Me.arcScaleBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style12Left
            Me.arcScaleBackgroundLayerComponent6.ZOrder = 1000
            ' 
            ' arcScaleComponent6
            ' 
            Me.arcScaleComponent6.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 14F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent6.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
            Me.arcScaleComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(205F, 205F)
            Me.arcScaleComponent6.EndAngle = -90F
            Me.arcScaleComponent6.MajorTickCount = 4
            Me.arcScaleComponent6.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent6.MajorTickmark.ShapeOffset = -16F
            Me.arcScaleComponent6.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent6.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_1
            Me.arcScaleComponent6.MajorTickmark.TextOffset = 20F
            Me.arcScaleComponent6.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent6.MaxValue = 50F
            Me.arcScaleComponent6.MinorTickCount = 4
            Me.arcScaleComponent6.MinorTickmark.ShapeOffset = 12F
            Me.arcScaleComponent6.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent6.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_2
            Me.arcScaleComponent6.MinValue = 20F
            Me.arcScaleComponent6.Name = "scale1"
            Me.arcScaleComponent6.RadiusX = 165F
            Me.arcScaleComponent6.RadiusY = 165F
            Me.arcScaleComponent6.StartAngle = -180F
            Me.arcScaleComponent6.Value = 30F
            ' 
            ' arcScaleNeedleComponent6
            ' 
            Me.arcScaleNeedleComponent6.ArcScale = Me.arcScaleComponent6
            Me.arcScaleNeedleComponent6.EndOffset = -8F
            Me.arcScaleNeedleComponent6.Name = "needle"
            Me.arcScaleNeedleComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style12
            Me.arcScaleNeedleComponent6.StartOffset = -7.5F
            Me.arcScaleNeedleComponent6.ZOrder = -50
            ' 
            ' arcScaleComponent19
            ' 
            Me.arcScaleComponent19.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent19.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent19.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent19.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent19.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent19.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent19.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(205F, 205F)
            Me.arcScaleComponent19.EndAngle = -90F
            Me.arcScaleComponent19.MajorTickCount = 4
            Me.arcScaleComponent19.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent19.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.8F, 1.8F)
            Me.arcScaleComponent19.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_3
            Me.arcScaleComponent19.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent19.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent19.MaxValue = 500F
            Me.arcScaleComponent19.MinorTickCount = 4
            Me.arcScaleComponent19.MinorTickmark.ShapeOffset = 6F
            Me.arcScaleComponent19.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.8F, 1.8F)
            Me.arcScaleComponent19.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_4
            Me.arcScaleComponent19.MinValue = 200F
            Me.arcScaleComponent19.Name = "scale2"
            Me.arcScaleComponent19.StartAngle = -180F
            Me.arcScaleComponent19.Value = 300F
            Me.arcScaleComponent19.ZOrder = -1
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
            Me.circularGauge7.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent7, Me.arcScaleComponent20})
            ' 
            ' arcScaleBackgroundLayerComponent7
            ' 
            Me.arcScaleBackgroundLayerComponent7.ArcScale = Me.arcScaleComponent7
            Me.arcScaleBackgroundLayerComponent7.Name = "bg"
            Me.arcScaleBackgroundLayerComponent7.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.563F)
            Me.arcScaleBackgroundLayerComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style12
            Me.arcScaleBackgroundLayerComponent7.Size = New System.Drawing.SizeF(250F, 222F)
            Me.arcScaleBackgroundLayerComponent7.ZOrder = 1000
            ' 
            ' arcScaleComponent7
            ' 
            Me.arcScaleComponent7.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent7.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
            Me.arcScaleComponent7.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 130F)
            Me.arcScaleComponent7.EndAngle = 30F
            Me.arcScaleComponent7.MajorTickCount = 9
            Me.arcScaleComponent7.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent7.MajorTickmark.ShapeOffset = -15F
            Me.arcScaleComponent7.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_1
            Me.arcScaleComponent7.MajorTickmark.TextOffset = 8F
            Me.arcScaleComponent7.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent7.MaxValue = 90F
            Me.arcScaleComponent7.MinorTickCount = 4
            Me.arcScaleComponent7.MinorTickmark.ShapeOffset = 4F
            Me.arcScaleComponent7.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_2
            Me.arcScaleComponent7.MinValue = 10F
            Me.arcScaleComponent7.Name = "scale1"
            Me.arcScaleComponent7.RadiusX = 105F
            Me.arcScaleComponent7.RadiusY = 105F
            Me.arcScaleComponent7.StartAngle = -210F
            Me.arcScaleComponent7.Value = 50F
            ' 
            ' arcScaleNeedleComponent7
            ' 
            Me.arcScaleNeedleComponent7.ArcScale = Me.arcScaleComponent7
            Me.arcScaleNeedleComponent7.EndOffset = -7.5F
            Me.arcScaleNeedleComponent7.Name = "needle"
            Me.arcScaleNeedleComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style12
            Me.arcScaleNeedleComponent7.StartOffset = -5F
            Me.arcScaleNeedleComponent7.ZOrder = -50
            ' 
            ' arcScaleComponent20
            ' 
            Me.arcScaleComponent20.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent20.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent20.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent20.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent20.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent20.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 130F)
            Me.arcScaleComponent20.EndAngle = 30F
            Me.arcScaleComponent20.MajorTickCount = 9
            Me.arcScaleComponent20.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent20.MajorTickmark.ShapeOffset = -4F
            Me.arcScaleComponent20.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_3
            Me.arcScaleComponent20.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent20.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent20.MaxValue = 900F
            Me.arcScaleComponent20.MinorTickCount = 4
            Me.arcScaleComponent20.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_4
            Me.arcScaleComponent20.MinValue = 100F
            Me.arcScaleComponent20.Name = "scale2"
            Me.arcScaleComponent20.RadiusX = 65F
            Me.arcScaleComponent20.RadiusY = 65F
            Me.arcScaleComponent20.StartAngle = -210F
            Me.arcScaleComponent20.Value = 300F
            Me.arcScaleComponent20.ZOrder = -1
            ' 
            ' gaugeControl11
            ' 
            Me.gaugeControl11.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge22})
            Me.gaugeControl11.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl11.Name = "gaugeControl11"
            Me.gaugeControl11.Size = New System.Drawing.Size(262, 220)
            Me.gaugeControl11.TabIndex = 5
            ' 
            ' circularGauge22
            ' 
            Me.circularGauge22.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent23, Me.arcScaleBackgroundLayerComponent24})
            Me.circularGauge22.Bounds = New System.Drawing.Rectangle(6, 6, 250, 208)
            Me.circularGauge22.Name = "circularGauge22"
            Me.circularGauge22.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent22})
            Me.circularGauge22.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent42, Me.arcScaleComponent43})
            ' 
            ' arcScaleBackgroundLayerComponent23
            ' 
            Me.arcScaleBackgroundLayerComponent23.ArcScale = Me.arcScaleComponent42
            Me.arcScaleBackgroundLayerComponent23.Name = "bg1"
            Me.arcScaleBackgroundLayerComponent23.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1.9F)
            Me.arcScaleBackgroundLayerComponent23.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style12
            Me.arcScaleBackgroundLayerComponent23.Size = New System.Drawing.SizeF(250F, 104F)
            Me.arcScaleBackgroundLayerComponent23.ZOrder = 1000
            ' 
            ' arcScaleComponent42
            ' 
            Me.arcScaleComponent42.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent42.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent42.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent42.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent42.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent42.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
            Me.arcScaleComponent42.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 265F)
            Me.arcScaleComponent42.EndAngle = -65F
            Me.arcScaleComponent42.MajorTickCount = 7
            Me.arcScaleComponent42.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent42.MajorTickmark.ShapeOffset = -20F
            Me.arcScaleComponent42.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_1
            Me.arcScaleComponent42.MajorTickmark.TextOffset = 3F
            Me.arcScaleComponent42.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent42.MaxValue = 80F
            Me.arcScaleComponent42.MinorTickCount = 4
            Me.arcScaleComponent42.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_2
            Me.arcScaleComponent42.MinValue = 20F
            Me.arcScaleComponent42.Name = "scale1"
            Me.arcScaleComponent42.RadiusX = 250F
            Me.arcScaleComponent42.RadiusY = 180F
            Me.arcScaleComponent42.StartAngle = -115F
            Me.arcScaleComponent42.Value = 50F
            ' 
            ' arcScaleBackgroundLayerComponent24
            ' 
            Me.arcScaleBackgroundLayerComponent24.ArcScale = Me.arcScaleComponent42
            Me.arcScaleBackgroundLayerComponent24.Name = "bg2"
            Me.arcScaleBackgroundLayerComponent24.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 10.6F)
            Me.arcScaleBackgroundLayerComponent24.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style12_1
            Me.arcScaleBackgroundLayerComponent24.Size = New System.Drawing.SizeF(204F, 10F)
            Me.arcScaleBackgroundLayerComponent24.ZOrder = -100
            ' 
            ' arcScaleNeedleComponent22
            ' 
            Me.arcScaleNeedleComponent22.ArcScale = Me.arcScaleComponent42
            Me.arcScaleNeedleComponent22.Name = "needle1"
            Me.arcScaleNeedleComponent22.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularWide_Style12
            Me.arcScaleNeedleComponent22.StartOffset = 145F
            Me.arcScaleNeedleComponent22.ZOrder = -50
            ' 
            ' arcScaleComponent43
            ' 
            Me.arcScaleComponent43.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent43.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent43.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent43.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent43.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.arcScaleComponent43.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#404040")
            Me.arcScaleComponent43.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 265F)
            Me.arcScaleComponent43.EndAngle = -65F
            Me.arcScaleComponent43.MajorTickCount = 7
            Me.arcScaleComponent43.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent43.MajorTickmark.ShapeOffset = -4F
            Me.arcScaleComponent43.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_3
            Me.arcScaleComponent43.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent43.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent43.MaxValue = 600F
            Me.arcScaleComponent43.MinorTickCount = 9
            Me.arcScaleComponent43.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_4
            Me.arcScaleComponent43.Name = "scale2"
            Me.arcScaleComponent43.RadiusX = 200F
            Me.arcScaleComponent43.RadiusY = 145F
            Me.arcScaleComponent43.StartAngle = -115F
            Me.arcScaleComponent43.Value = 50F
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
            Me.circularGauge8.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent8, Me.arcScaleComponent18})
            ' 
            ' arcScaleBackgroundLayerComponent8
            ' 
            Me.arcScaleBackgroundLayerComponent8.ArcScale = Me.arcScaleComponent8
            Me.arcScaleBackgroundLayerComponent8.Name = "bg"
            Me.arcScaleBackgroundLayerComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style12
            Me.arcScaleBackgroundLayerComponent8.ZOrder = 1000
            ' 
            ' arcScaleComponent8
            ' 
            Me.arcScaleComponent8.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
            Me.arcScaleComponent8.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent8.EndAngle = 60F
            Me.arcScaleComponent8.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent8.MajorTickmark.ShapeOffset = -15F
            Me.arcScaleComponent8.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_1
            Me.arcScaleComponent8.MajorTickmark.TextOffset = 9F
            Me.arcScaleComponent8.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent8.MaxValue = 100F
            Me.arcScaleComponent8.MinorTickCount = 4
            Me.arcScaleComponent8.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_2
            Me.arcScaleComponent8.Name = "scale1"
            Me.arcScaleComponent8.RadiusX = 105F
            Me.arcScaleComponent8.RadiusY = 105F
            Me.arcScaleComponent8.StartAngle = -240F
            Me.arcScaleComponent8.Value = 80F
            ' 
            ' arcScaleNeedleComponent8
            ' 
            Me.arcScaleNeedleComponent8.ArcScale = Me.arcScaleComponent8
            Me.arcScaleNeedleComponent8.EndOffset = -7.5F
            Me.arcScaleNeedleComponent8.Name = "needle"
            Me.arcScaleNeedleComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style12
            Me.arcScaleNeedleComponent8.StartOffset = -5F
            Me.arcScaleNeedleComponent8.ZOrder = -50
            ' 
            ' arcScaleComponent18
            ' 
            Me.arcScaleComponent18.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent18.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent18.EndAngle = 60F
            Me.arcScaleComponent18.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent18.MajorTickmark.ShapeOffset = -4F
            Me.arcScaleComponent18.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_3
            Me.arcScaleComponent18.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent18.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent18.MaxValue = 1000F
            Me.arcScaleComponent18.MinorTickCount = 4
            Me.arcScaleComponent18.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style12_4
            Me.arcScaleComponent18.Name = "scale2"
            Me.arcScaleComponent18.RadiusX = 65F
            Me.arcScaleComponent18.RadiusY = 65F
            Me.arcScaleComponent18.StartAngle = -240F
            Me.arcScaleComponent18.Value = 300F
            Me.arcScaleComponent18.ZOrder = -1
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
            Me.xtraTabPage3.Caption = "Military"
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
            Me.linearScaleBackgroundLayerComponent3.Name = "bg1"
            Me.linearScaleBackgroundLayerComponent3.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.08F)
            Me.linearScaleBackgroundLayerComponent3.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.92F)
            Me.linearScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style13
            Me.linearScaleBackgroundLayerComponent3.ZOrder = 1000
            ' 
            ' linearScaleComponent5
            ' 
            Me.linearScaleComponent5.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent5.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent5.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent5.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent5.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.linearScaleComponent5.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent5.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F)
            Me.linearScaleComponent5.MajorTickCount = 6
            Me.linearScaleComponent5.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent5.MajorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent5.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style13_2
            Me.linearScaleComponent5.MajorTickmark.TextOffset = 35F
            Me.linearScaleComponent5.MaxValue = 500F
            Me.linearScaleComponent5.MinorTickCount = 4
            Me.linearScaleComponent5.MinorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent5.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style13_1
            Me.linearScaleComponent5.Name = "scale1"
            Me.linearScaleComponent5.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F)
            Me.linearScaleComponent5.Value = 250F
            ' 
            ' linearScaleLevelComponent3
            ' 
            Me.linearScaleLevelComponent3.LinearScale = Me.linearScaleComponent5
            Me.linearScaleLevelComponent3.Name = "level1"
            Me.linearScaleLevelComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style13
            Me.linearScaleLevelComponent3.ZOrder = -50
            ' 
            ' linearScaleComponent6
            ' 
            Me.linearScaleComponent6.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent6.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent6.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent6.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent6.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.linearScaleComponent6.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent6.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F)
            Me.linearScaleComponent6.MajorTickCount = 6
            Me.linearScaleComponent6.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent6.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent6.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style13_2
            Me.linearScaleComponent6.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent6.MaxValue = 50F
            Me.linearScaleComponent6.MinorTickCount = 4
            Me.linearScaleComponent6.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent6.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style13_1
            Me.linearScaleComponent6.Name = "scale2"
            Me.linearScaleComponent6.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F)
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
            Me.circularGauge9.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent9, Me.arcScaleComponent25})
            ' 
            ' arcScaleBackgroundLayerComponent9
            ' 
            Me.arcScaleBackgroundLayerComponent9.ArcScale = Me.arcScaleComponent9
            Me.arcScaleBackgroundLayerComponent9.Name = "bg"
            Me.arcScaleBackgroundLayerComponent9.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.822F)
            Me.arcScaleBackgroundLayerComponent9.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style13
            Me.arcScaleBackgroundLayerComponent9.Size = New System.Drawing.SizeF(250F, 152F)
            Me.arcScaleBackgroundLayerComponent9.ZOrder = 1000
            ' 
            ' arcScaleComponent9
            ' 
            Me.arcScaleComponent9.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent9.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent9.EndAngle = 0F
            Me.arcScaleComponent9.MajorTickCount = 7
            Me.arcScaleComponent9.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent9.MajorTickmark.ShapeOffset = -7F
            Me.arcScaleComponent9.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_5
            Me.arcScaleComponent9.MajorTickmark.TextOffset = 10F
            Me.arcScaleComponent9.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent9.MaxValue = 80F
            Me.arcScaleComponent9.MinorTickCount = 4
            Me.arcScaleComponent9.MinorTickmark.ShapeOffset = 4F
            Me.arcScaleComponent9.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_4
            Me.arcScaleComponent9.MinValue = 20F
            Me.arcScaleComponent9.Name = "scale1"
            Me.arcScaleComponent9.RadiusX = 105F
            Me.arcScaleComponent9.RadiusY = 105F
            Me.arcScaleComponent9.StartAngle = -180F
            Me.arcScaleComponent9.Value = 50F
            ' 
            ' arcScaleNeedleComponent9
            ' 
            Me.arcScaleNeedleComponent9.ArcScale = Me.arcScaleComponent9
            Me.arcScaleNeedleComponent9.EndOffset = -7.5F
            Me.arcScaleNeedleComponent9.Name = "needle"
            Me.arcScaleNeedleComponent9.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style13
            Me.arcScaleNeedleComponent9.StartOffset = -5F
            Me.arcScaleNeedleComponent9.ZOrder = -50
            ' 
            ' arcScaleComponent25
            ' 
            Me.arcScaleComponent25.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent25.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent25.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent25.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent25.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gainsboro")
            Me.arcScaleComponent25.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent25.EndAngle = 0F
            Me.arcScaleComponent25.MajorTickCount = 7
            Me.arcScaleComponent25.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent25.MajorTickmark.ShapeOffset = -2F
            Me.arcScaleComponent25.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_2
            Me.arcScaleComponent25.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent25.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent25.MaxValue = 800F
            Me.arcScaleComponent25.MinorTickCount = 4
            Me.arcScaleComponent25.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_1
            Me.arcScaleComponent25.MinValue = 200F
            Me.arcScaleComponent25.Name = "scale2"
            Me.arcScaleComponent25.RadiusX = 65F
            Me.arcScaleComponent25.RadiusY = 65F
            Me.arcScaleComponent25.StartAngle = -180F
            Me.arcScaleComponent25.Value = 300F
            Me.arcScaleComponent25.ZOrder = -1
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
            Me.circularGauge10.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent10, Me.arcScaleComponent28})
            ' 
            ' arcScaleBackgroundLayerComponent10
            ' 
            Me.arcScaleBackgroundLayerComponent10.ArcScale = Me.arcScaleComponent10
            Me.arcScaleBackgroundLayerComponent10.Name = "bg"
            Me.arcScaleBackgroundLayerComponent10.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.868F, 0.868F)
            Me.arcScaleBackgroundLayerComponent10.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style13Left
            Me.arcScaleBackgroundLayerComponent10.ZOrder = 1000
            ' 
            ' arcScaleComponent10
            ' 
            Me.arcScaleComponent10.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 14F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent10.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(215F, 215F)
            Me.arcScaleComponent10.EndAngle = -90F
            Me.arcScaleComponent10.MajorTickCount = 4
            Me.arcScaleComponent10.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent10.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent10.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_5
            Me.arcScaleComponent10.MajorTickmark.TextOffset = 25F
            Me.arcScaleComponent10.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent10.MaxValue = 50F
            Me.arcScaleComponent10.MinorTickCount = 4
            Me.arcScaleComponent10.MinorTickmark.ShapeOffset = 20F
            Me.arcScaleComponent10.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent10.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_4
            Me.arcScaleComponent10.MinValue = 20F
            Me.arcScaleComponent10.Name = "scale1"
            Me.arcScaleComponent10.RadiusX = 170F
            Me.arcScaleComponent10.RadiusY = 170F
            Me.arcScaleComponent10.StartAngle = -180F
            Me.arcScaleComponent10.Value = 30F
            ' 
            ' arcScaleNeedleComponent10
            ' 
            Me.arcScaleNeedleComponent10.ArcScale = Me.arcScaleComponent10
            Me.arcScaleNeedleComponent10.EndOffset = -8F
            Me.arcScaleNeedleComponent10.Name = "needle"
            Me.arcScaleNeedleComponent10.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style13
            Me.arcScaleNeedleComponent10.StartOffset = -7.5F
            Me.arcScaleNeedleComponent10.ZOrder = -50
            ' 
            ' arcScaleComponent28
            ' 
            Me.arcScaleComponent28.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent28.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent28.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent28.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent28.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent28.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gainsboro")
            Me.arcScaleComponent28.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(215F, 215F)
            Me.arcScaleComponent28.EndAngle = -90F
            Me.arcScaleComponent28.MajorTickCount = 4
            Me.arcScaleComponent28.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent28.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.8F, 1.8F)
            Me.arcScaleComponent28.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_2
            Me.arcScaleComponent28.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent28.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent28.MaxValue = 500F
            Me.arcScaleComponent28.MinorTickCount = 4
            Me.arcScaleComponent28.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.8F, 1.8F)
            Me.arcScaleComponent28.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_1
            Me.arcScaleComponent28.MinValue = 200F
            Me.arcScaleComponent28.Name = "scale2"
            Me.arcScaleComponent28.RadiusX = 115F
            Me.arcScaleComponent28.RadiusY = 115F
            Me.arcScaleComponent28.StartAngle = -180F
            Me.arcScaleComponent28.Value = 300F
            Me.arcScaleComponent28.ZOrder = -1
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
            Me.circularGauge11.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent11, Me.arcScaleComponent27})
            ' 
            ' arcScaleBackgroundLayerComponent11
            ' 
            Me.arcScaleBackgroundLayerComponent11.ArcScale = Me.arcScaleComponent11
            Me.arcScaleBackgroundLayerComponent11.Name = "bg"
            Me.arcScaleBackgroundLayerComponent11.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.595F)
            Me.arcScaleBackgroundLayerComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style13
            Me.arcScaleBackgroundLayerComponent11.Size = New System.Drawing.SizeF(250F, 210F)
            Me.arcScaleBackgroundLayerComponent11.ZOrder = 1000
            ' 
            ' arcScaleComponent11
            ' 
            Me.arcScaleComponent11.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent11.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F)
            Me.arcScaleComponent11.EndAngle = 30F
            Me.arcScaleComponent11.MajorTickCount = 9
            Me.arcScaleComponent11.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent11.MajorTickmark.ShapeOffset = -7F
            Me.arcScaleComponent11.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_5
            Me.arcScaleComponent11.MajorTickmark.TextOffset = 10F
            Me.arcScaleComponent11.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent11.MaxValue = 90F
            Me.arcScaleComponent11.MinorTickCount = 4
            Me.arcScaleComponent11.MinorTickmark.ShapeOffset = 4F
            Me.arcScaleComponent11.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_4
            Me.arcScaleComponent11.MinValue = 10F
            Me.arcScaleComponent11.Name = "scale1"
            Me.arcScaleComponent11.RadiusX = 105F
            Me.arcScaleComponent11.RadiusY = 105F
            Me.arcScaleComponent11.StartAngle = -210F
            Me.arcScaleComponent11.Value = 50F
            ' 
            ' arcScaleNeedleComponent11
            ' 
            Me.arcScaleNeedleComponent11.ArcScale = Me.arcScaleComponent11
            Me.arcScaleNeedleComponent11.EndOffset = -7.5F
            Me.arcScaleNeedleComponent11.Name = "needle"
            Me.arcScaleNeedleComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style13
            Me.arcScaleNeedleComponent11.StartOffset = -5F
            Me.arcScaleNeedleComponent11.ZOrder = -50
            ' 
            ' arcScaleComponent27
            ' 
            Me.arcScaleComponent27.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent27.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent27.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent27.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent27.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gainsboro")
            Me.arcScaleComponent27.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F)
            Me.arcScaleComponent27.EndAngle = 30F
            Me.arcScaleComponent27.MajorTickCount = 9
            Me.arcScaleComponent27.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent27.MajorTickmark.ShapeOffset = -2F
            Me.arcScaleComponent27.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_2
            Me.arcScaleComponent27.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent27.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent27.MaxValue = 900F
            Me.arcScaleComponent27.MinorTickCount = 4
            Me.arcScaleComponent27.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_1
            Me.arcScaleComponent27.MinValue = 100F
            Me.arcScaleComponent27.Name = "scale2"
            Me.arcScaleComponent27.RadiusX = 65F
            Me.arcScaleComponent27.RadiusY = 65F
            Me.arcScaleComponent27.StartAngle = -210F
            Me.arcScaleComponent27.Value = 300F
            Me.arcScaleComponent27.ZOrder = -1
            ' 
            ' gaugeControl17
            ' 
            Me.gaugeControl17.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge23})
            Me.gaugeControl17.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl17.Name = "gaugeControl17"
            Me.gaugeControl17.Size = New System.Drawing.Size(262, 220)
            Me.gaugeControl17.TabIndex = 5
            ' 
            ' circularGauge23
            ' 
            Me.circularGauge23.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent25, Me.arcScaleBackgroundLayerComponent26})
            Me.circularGauge23.Bounds = New System.Drawing.Rectangle(6, 6, 250, 208)
            Me.circularGauge23.Name = "circularGauge23"
            Me.circularGauge23.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent23})
            Me.circularGauge23.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent44, Me.arcScaleComponent45})
            ' 
            ' arcScaleBackgroundLayerComponent25
            ' 
            Me.arcScaleBackgroundLayerComponent25.ArcScale = Me.arcScaleComponent44
            Me.arcScaleBackgroundLayerComponent25.Name = "bg1"
            Me.arcScaleBackgroundLayerComponent25.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1.9F)
            Me.arcScaleBackgroundLayerComponent25.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style13
            Me.arcScaleBackgroundLayerComponent25.Size = New System.Drawing.SizeF(250F, 104F)
            Me.arcScaleBackgroundLayerComponent25.ZOrder = 1000
            ' 
            ' arcScaleComponent44
            ' 
            Me.arcScaleComponent44.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent44.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent44.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent44.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent44.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent44.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
            Me.arcScaleComponent44.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 263F)
            Me.arcScaleComponent44.EndAngle = -65F
            Me.arcScaleComponent44.MajorTickCount = 7
            Me.arcScaleComponent44.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent44.MajorTickmark.ShapeOffset = -10F
            Me.arcScaleComponent44.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_5
            Me.arcScaleComponent44.MajorTickmark.TextOffset = 3F
            Me.arcScaleComponent44.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent44.MaxValue = 80F
            Me.arcScaleComponent44.MinorTickCount = 4
            Me.arcScaleComponent44.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_4
            Me.arcScaleComponent44.MinValue = 20F
            Me.arcScaleComponent44.Name = "scale1"
            Me.arcScaleComponent44.RadiusX = 250F
            Me.arcScaleComponent44.RadiusY = 180F
            Me.arcScaleComponent44.StartAngle = -115F
            Me.arcScaleComponent44.Value = 80F
            ' 
            ' arcScaleBackgroundLayerComponent26
            ' 
            Me.arcScaleBackgroundLayerComponent26.ArcScale = Me.arcScaleComponent44
            Me.arcScaleBackgroundLayerComponent26.Name = "bg2"
            Me.arcScaleBackgroundLayerComponent26.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 10.6F)
            Me.arcScaleBackgroundLayerComponent26.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style13_1
            Me.arcScaleBackgroundLayerComponent26.Size = New System.Drawing.SizeF(204F, 10F)
            Me.arcScaleBackgroundLayerComponent26.ZOrder = -100
            ' 
            ' arcScaleNeedleComponent23
            ' 
            Me.arcScaleNeedleComponent23.ArcScale = Me.arcScaleComponent44
            Me.arcScaleNeedleComponent23.Name = "needle1"
            Me.arcScaleNeedleComponent23.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularWide_Style13
            Me.arcScaleNeedleComponent23.StartOffset = 150F
            Me.arcScaleNeedleComponent23.ZOrder = -50
            ' 
            ' arcScaleComponent45
            ' 
            Me.arcScaleComponent45.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent45.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent45.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent45.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent45.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.arcScaleComponent45.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
            Me.arcScaleComponent45.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 265F)
            Me.arcScaleComponent45.EndAngle = -65F
            Me.arcScaleComponent45.MajorTickCount = 7
            Me.arcScaleComponent45.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent45.MajorTickmark.ShapeOffset = -4F
            Me.arcScaleComponent45.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_2
            Me.arcScaleComponent45.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent45.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent45.MaxValue = 600F
            Me.arcScaleComponent45.MinorTickCount = 9
            Me.arcScaleComponent45.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_1
            Me.arcScaleComponent45.Name = "scale2"
            Me.arcScaleComponent45.RadiusX = 200F
            Me.arcScaleComponent45.RadiusY = 145F
            Me.arcScaleComponent45.StartAngle = -115F
            Me.arcScaleComponent45.Value = 50F
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
            Me.circularGauge12.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent12})
            Me.circularGauge12.Bounds = New System.Drawing.Rectangle(6, 6, 208, 208)
            Me.circularGauge12.Name = "circularGauge12"
            Me.circularGauge12.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent12})
            Me.circularGauge12.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent12, Me.arcScaleComponent26})
            ' 
            ' arcScaleBackgroundLayerComponent12
            ' 
            Me.arcScaleBackgroundLayerComponent12.ArcScale = Me.arcScaleComponent12
            Me.arcScaleBackgroundLayerComponent12.Name = "bg"
            Me.arcScaleBackgroundLayerComponent12.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style13
            Me.arcScaleBackgroundLayerComponent12.ZOrder = 1000
            ' 
            ' arcScaleComponent12
            ' 
            Me.arcScaleComponent12.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent12.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent12.EndAngle = 60F
            Me.arcScaleComponent12.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent12.MajorTickmark.ShapeOffset = -7F
            Me.arcScaleComponent12.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_5
            Me.arcScaleComponent12.MajorTickmark.TextOffset = 10F
            Me.arcScaleComponent12.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent12.MaxValue = 100F
            Me.arcScaleComponent12.MinorTickCount = 4
            Me.arcScaleComponent12.MinorTickmark.ShapeOffset = 4F
            Me.arcScaleComponent12.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_4
            Me.arcScaleComponent12.Name = "scale1"
            Me.arcScaleComponent12.RadiusX = 105F
            Me.arcScaleComponent12.RadiusY = 105F
            Me.arcScaleComponent12.StartAngle = -240F
            Me.arcScaleComponent12.Value = 80F
            ' 
            ' arcScaleNeedleComponent12
            ' 
            Me.arcScaleNeedleComponent12.ArcScale = Me.arcScaleComponent12
            Me.arcScaleNeedleComponent12.EndOffset = -7.5F
            Me.arcScaleNeedleComponent12.Name = "needle"
            Me.arcScaleNeedleComponent12.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style13
            Me.arcScaleNeedleComponent12.StartOffset = -5F
            Me.arcScaleNeedleComponent12.ZOrder = -50
            ' 
            ' arcScaleComponent26
            ' 
            Me.arcScaleComponent26.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent26.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent26.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent26.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent26.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gainsboro")
            Me.arcScaleComponent26.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent26.EndAngle = 60F
            Me.arcScaleComponent26.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent26.MajorTickmark.ShapeOffset = -2F
            Me.arcScaleComponent26.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_2
            Me.arcScaleComponent26.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent26.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent26.MaxValue = 1000F
            Me.arcScaleComponent26.MinorTickCount = 4
            Me.arcScaleComponent26.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style13_1
            Me.arcScaleComponent26.Name = "scale2"
            Me.arcScaleComponent26.RadiusX = 65F
            Me.arcScaleComponent26.RadiusY = 65F
            Me.arcScaleComponent26.StartAngle = -240F
            Me.arcScaleComponent26.Value = 300F
            Me.arcScaleComponent26.ZOrder = -1
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
            Me.xtraTabPage4.Caption = "Retro"
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
            Me.linearScaleBackgroundLayerComponent4.Name = "bg1"
            Me.linearScaleBackgroundLayerComponent4.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.505F, 0.14F)
            Me.linearScaleBackgroundLayerComponent4.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.505F, 0.847F)
            Me.linearScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style14
            Me.linearScaleBackgroundLayerComponent4.ZOrder = 1000
            ' 
            ' linearScaleComponent7
            ' 
            Me.linearScaleComponent7.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent7.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent7.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent7.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent7.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.linearScaleComponent7.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
            Me.linearScaleComponent7.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 35F)
            Me.linearScaleComponent7.MajorTickCount = 6
            Me.linearScaleComponent7.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent7.MajorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent7.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style14_2
            Me.linearScaleComponent7.MajorTickmark.TextOffset = 35F
            Me.linearScaleComponent7.MaxValue = 500F
            Me.linearScaleComponent7.MinorTickCount = 4
            Me.linearScaleComponent7.MinorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent7.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style14_1
            Me.linearScaleComponent7.Name = "scale1"
            Me.linearScaleComponent7.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F)
            Me.linearScaleComponent7.Value = 250F
            ' 
            ' linearScaleLevelComponent4
            ' 
            Me.linearScaleLevelComponent4.LinearScale = Me.linearScaleComponent7
            Me.linearScaleLevelComponent4.Name = "level1"
            Me.linearScaleLevelComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style14
            Me.linearScaleLevelComponent4.ZOrder = -50
            ' 
            ' linearScaleComponent8
            ' 
            Me.linearScaleComponent8.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent8.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent8.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent8.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent8.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.linearScaleComponent8.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
            Me.linearScaleComponent8.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 35F)
            Me.linearScaleComponent8.MajorTickCount = 6
            Me.linearScaleComponent8.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent8.MajorTickmark.ShapeOffset = -18F
            Me.linearScaleComponent8.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style14_2
            Me.linearScaleComponent8.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent8.MaxValue = 50F
            Me.linearScaleComponent8.MinorTickCount = 4
            Me.linearScaleComponent8.MinorTickmark.ShapeOffset = -12F
            Me.linearScaleComponent8.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style14_1
            Me.linearScaleComponent8.Name = "scale2"
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
            Me.circularGauge13.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent13, Me.arcScaleComponent29})
            ' 
            ' arcScaleBackgroundLayerComponent13
            ' 
            Me.arcScaleBackgroundLayerComponent13.ArcScale = Me.arcScaleComponent13
            Me.arcScaleBackgroundLayerComponent13.Name = "bg"
            Me.arcScaleBackgroundLayerComponent13.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.8F)
            Me.arcScaleBackgroundLayerComponent13.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style14
            Me.arcScaleBackgroundLayerComponent13.Size = New System.Drawing.SizeF(250F, 154F)
            Me.arcScaleBackgroundLayerComponent13.ZOrder = 1000
            ' 
            ' arcScaleComponent13
            ' 
            Me.arcScaleComponent13.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent13.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
            Me.arcScaleComponent13.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent13.EndAngle = 0F
            Me.arcScaleComponent13.MajorTickCount = 7
            Me.arcScaleComponent13.MajorTickmark.AllowTickOverlap = True
            Me.arcScaleComponent13.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent13.MajorTickmark.ShapeOffset = -12F
            Me.arcScaleComponent13.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_3
            Me.arcScaleComponent13.MajorTickmark.TextOffset = -22F
            Me.arcScaleComponent13.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent13.MaxValue = 80F
            Me.arcScaleComponent13.MinorTickCount = 4
            Me.arcScaleComponent13.MinorTickmark.ShapeOffset = 4F
            Me.arcScaleComponent13.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_4
            Me.arcScaleComponent13.MinValue = 20F
            Me.arcScaleComponent13.Name = "scale1"
            Me.arcScaleComponent13.RadiusX = 107F
            Me.arcScaleComponent13.RadiusY = 107F
            Me.arcScaleComponent13.StartAngle = -180F
            Me.arcScaleComponent13.Value = 80F
            ' 
            ' arcScaleNeedleComponent13
            ' 
            Me.arcScaleNeedleComponent13.ArcScale = Me.arcScaleComponent13
            Me.arcScaleNeedleComponent13.EndOffset = -7.5F
            Me.arcScaleNeedleComponent13.Name = "needle"
            Me.arcScaleNeedleComponent13.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style14
            Me.arcScaleNeedleComponent13.StartOffset = -5F
            Me.arcScaleNeedleComponent13.ZOrder = -50
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
            Me.arcScaleComponent29.EndAngle = 0F
            Me.arcScaleComponent29.MajorTickCount = 7
            Me.arcScaleComponent29.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent29.MajorTickmark.ShapeOffset = -3F
            Me.arcScaleComponent29.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_2
            Me.arcScaleComponent29.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent29.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent29.MaxValue = 800F
            Me.arcScaleComponent29.MinorTickCount = 4
            Me.arcScaleComponent29.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_1
            Me.arcScaleComponent29.MinValue = 200F
            Me.arcScaleComponent29.Name = "scale2"
            Me.arcScaleComponent29.RadiusX = 65F
            Me.arcScaleComponent29.RadiusY = 65F
            Me.arcScaleComponent29.StartAngle = -180F
            Me.arcScaleComponent29.Value = 300F
            Me.arcScaleComponent29.ZOrder = -1
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
            Me.circularGauge14.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent14, Me.arcScaleComponent32})
            ' 
            ' arcScaleBackgroundLayerComponent14
            ' 
            Me.arcScaleBackgroundLayerComponent14.ArcScale = Me.arcScaleComponent14
            Me.arcScaleBackgroundLayerComponent14.Name = "bg"
            Me.arcScaleBackgroundLayerComponent14.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.822F, 0.822F)
            Me.arcScaleBackgroundLayerComponent14.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style14Left
            Me.arcScaleBackgroundLayerComponent14.ZOrder = 1000
            ' 
            ' arcScaleComponent14
            ' 
            Me.arcScaleComponent14.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 16F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent14.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
            Me.arcScaleComponent14.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(205F, 205F)
            Me.arcScaleComponent14.EndAngle = -90F
            Me.arcScaleComponent14.MajorTickCount = 4
            Me.arcScaleComponent14.MajorTickmark.AllowTickOverlap = True
            Me.arcScaleComponent14.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent14.MajorTickmark.ShapeOffset = -15F
            Me.arcScaleComponent14.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent14.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_3
            Me.arcScaleComponent14.MajorTickmark.TextOffset = -32F
            Me.arcScaleComponent14.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent14.MaxValue = 50F
            Me.arcScaleComponent14.MinorTickCount = 4
            Me.arcScaleComponent14.MinorTickmark.ShapeOffset = 10F
            Me.arcScaleComponent14.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent14.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_4
            Me.arcScaleComponent14.MinValue = 20F
            Me.arcScaleComponent14.Name = "scale1"
            Me.arcScaleComponent14.RadiusX = 175F
            Me.arcScaleComponent14.RadiusY = 175F
            Me.arcScaleComponent14.StartAngle = -180F
            Me.arcScaleComponent14.Value = 30F
            ' 
            ' arcScaleNeedleComponent14
            ' 
            Me.arcScaleNeedleComponent14.ArcScale = Me.arcScaleComponent14
            Me.arcScaleNeedleComponent14.EndOffset = -8F
            Me.arcScaleNeedleComponent14.Name = "needle"
            Me.arcScaleNeedleComponent14.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style14
            Me.arcScaleNeedleComponent14.StartOffset = -8F
            Me.arcScaleNeedleComponent14.ZOrder = -50
            ' 
            ' arcScaleComponent32
            ' 
            Me.arcScaleComponent32.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent32.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent32.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent32.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent32.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            Me.arcScaleComponent32.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent32.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(205F, 205F)
            Me.arcScaleComponent32.EndAngle = -90F
            Me.arcScaleComponent32.MajorTickCount = 4
            Me.arcScaleComponent32.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent32.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.8F, 1.8F)
            Me.arcScaleComponent32.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_2
            Me.arcScaleComponent32.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent32.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent32.MaxValue = 500F
            Me.arcScaleComponent32.MinorTickCount = 4
            Me.arcScaleComponent32.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.8F, 1.8F)
            Me.arcScaleComponent32.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_1
            Me.arcScaleComponent32.MinValue = 200F
            Me.arcScaleComponent32.Name = "scale2"
            Me.arcScaleComponent32.StartAngle = -180F
            Me.arcScaleComponent32.Value = 300F
            Me.arcScaleComponent32.ZOrder = -1
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
            Me.circularGauge15.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent15, Me.arcScaleComponent31})
            ' 
            ' arcScaleBackgroundLayerComponent15
            ' 
            Me.arcScaleBackgroundLayerComponent15.ArcScale = Me.arcScaleComponent15
            Me.arcScaleBackgroundLayerComponent15.Name = "bg"
            Me.arcScaleBackgroundLayerComponent15.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.607F)
            Me.arcScaleBackgroundLayerComponent15.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style14
            Me.arcScaleBackgroundLayerComponent15.Size = New System.Drawing.SizeF(250F, 206F)
            Me.arcScaleBackgroundLayerComponent15.ZOrder = 1000
            ' 
            ' arcScaleComponent15
            ' 
            Me.arcScaleComponent15.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent15.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
            Me.arcScaleComponent15.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F)
            Me.arcScaleComponent15.EndAngle = 30F
            Me.arcScaleComponent15.MajorTickCount = 9
            Me.arcScaleComponent15.MajorTickmark.AllowTickOverlap = True
            Me.arcScaleComponent15.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent15.MajorTickmark.ShapeOffset = -12F
            Me.arcScaleComponent15.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_3
            Me.arcScaleComponent15.MajorTickmark.TextOffset = -22F
            Me.arcScaleComponent15.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent15.MaxValue = 90F
            Me.arcScaleComponent15.MinorTickCount = 4
            Me.arcScaleComponent15.MinorTickmark.ShapeOffset = 4F
            Me.arcScaleComponent15.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_4
            Me.arcScaleComponent15.MinValue = 10F
            Me.arcScaleComponent15.Name = "scale1"
            Me.arcScaleComponent15.RadiusX = 107F
            Me.arcScaleComponent15.RadiusY = 107F
            Me.arcScaleComponent15.StartAngle = -210F
            Me.arcScaleComponent15.Value = 50F
            ' 
            ' arcScaleNeedleComponent15
            ' 
            Me.arcScaleNeedleComponent15.ArcScale = Me.arcScaleComponent15
            Me.arcScaleNeedleComponent15.EndOffset = -7.5F
            Me.arcScaleNeedleComponent15.Name = "needle"
            Me.arcScaleNeedleComponent15.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style14
            Me.arcScaleNeedleComponent15.StartOffset = -5F
            Me.arcScaleNeedleComponent15.ZOrder = -50
            ' 
            ' arcScaleComponent31
            ' 
            Me.arcScaleComponent31.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent31.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent31.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent31.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent31.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            Me.arcScaleComponent31.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent31.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F)
            Me.arcScaleComponent31.EndAngle = 30F
            Me.arcScaleComponent31.MajorTickCount = 9
            Me.arcScaleComponent31.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent31.MajorTickmark.ShapeOffset = -3F
            Me.arcScaleComponent31.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_2
            Me.arcScaleComponent31.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent31.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent31.MaxValue = 900F
            Me.arcScaleComponent31.MinorTickCount = 4
            Me.arcScaleComponent31.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_1
            Me.arcScaleComponent31.MinValue = 100F
            Me.arcScaleComponent31.Name = "scale2"
            Me.arcScaleComponent31.RadiusX = 65F
            Me.arcScaleComponent31.RadiusY = 65F
            Me.arcScaleComponent31.StartAngle = -210F
            Me.arcScaleComponent31.Value = 300F
            Me.arcScaleComponent31.ZOrder = -1
            ' 
            ' gaugeControl23
            ' 
            Me.gaugeControl23.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge24})
            Me.gaugeControl23.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl23.Name = "gaugeControl23"
            Me.gaugeControl23.Size = New System.Drawing.Size(262, 220)
            Me.gaugeControl23.TabIndex = 5
            ' 
            ' circularGauge24
            ' 
            Me.circularGauge24.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent27, Me.arcScaleBackgroundLayerComponent28})
            Me.circularGauge24.Bounds = New System.Drawing.Rectangle(6, 6, 250, 208)
            Me.circularGauge24.Name = "circularGauge24"
            Me.circularGauge24.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent24})
            Me.circularGauge24.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent46})
            ' 
            ' arcScaleBackgroundLayerComponent27
            ' 
            Me.arcScaleBackgroundLayerComponent27.ArcScale = Me.arcScaleComponent46
            Me.arcScaleBackgroundLayerComponent27.Name = "bg1"
            Me.arcScaleBackgroundLayerComponent27.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 6.96F)
            Me.arcScaleBackgroundLayerComponent27.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style14
            Me.arcScaleBackgroundLayerComponent27.Size = New System.Drawing.SizeF(250F, 51F)
            Me.arcScaleBackgroundLayerComponent27.ZOrder = 1000
            ' 
            ' arcScaleComponent46
            ' 
            Me.arcScaleComponent46.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent46.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent46.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent46.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent46.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent46.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
            Me.arcScaleComponent46.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 445F)
            Me.arcScaleComponent46.EndAngle = -74.5F
            Me.arcScaleComponent46.MajorTickCount = 7
            Me.arcScaleComponent46.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent46.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_2
            Me.arcScaleComponent46.MajorTickmark.TextOffset = -12F
            Me.arcScaleComponent46.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.Tangent
            Me.arcScaleComponent46.MaxValue = 80F
            Me.arcScaleComponent46.MinorTickCount = 4
            Me.arcScaleComponent46.MinorTickmark.ShapeOffset = 2F
            Me.arcScaleComponent46.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_1
            Me.arcScaleComponent46.MinValue = 20F
            Me.arcScaleComponent46.Name = "scale1"
            Me.arcScaleComponent46.RadiusX = 360F
            Me.arcScaleComponent46.RadiusY = 345F
            Me.arcScaleComponent46.StartAngle = -105.5F
            Me.arcScaleComponent46.Value = 50F
            ' 
            ' arcScaleBackgroundLayerComponent28
            ' 
            Me.arcScaleBackgroundLayerComponent28.ArcScale = Me.arcScaleComponent46
            Me.arcScaleBackgroundLayerComponent28.Name = "bg2"
            Me.arcScaleBackgroundLayerComponent28.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.498F, 4.22F)
            Me.arcScaleBackgroundLayerComponent28.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style14_1
            Me.arcScaleBackgroundLayerComponent28.Size = New System.Drawing.SizeF(250F, 88F)
            Me.arcScaleBackgroundLayerComponent28.ZOrder = -100
            ' 
            ' arcScaleNeedleComponent24
            ' 
            Me.arcScaleNeedleComponent24.ArcScale = Me.arcScaleComponent46
            Me.arcScaleNeedleComponent24.EndOffset = -15F
            Me.arcScaleNeedleComponent24.Name = "needle1"
            Me.arcScaleNeedleComponent24.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularWide_Style12
            Me.arcScaleNeedleComponent24.StartOffset = 326F
            Me.arcScaleNeedleComponent24.ZOrder = -50
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
            Me.circularGauge16.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent16})
            Me.circularGauge16.Bounds = New System.Drawing.Rectangle(6, 6, 207, 208)
            Me.circularGauge16.Name = "circularGauge16"
            Me.circularGauge16.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent16})
            Me.circularGauge16.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent16, Me.arcScaleComponent30})
            ' 
            ' arcScaleBackgroundLayerComponent16
            ' 
            Me.arcScaleBackgroundLayerComponent16.ArcScale = Me.arcScaleComponent16
            Me.arcScaleBackgroundLayerComponent16.Name = "bg"
            Me.arcScaleBackgroundLayerComponent16.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style14
            Me.arcScaleBackgroundLayerComponent16.ZOrder = 1000
            ' 
            ' arcScaleComponent16
            ' 
            Me.arcScaleComponent16.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent16.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
            Me.arcScaleComponent16.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent16.EndAngle = 60F
            Me.arcScaleComponent16.MajorTickmark.AllowTickOverlap = True
            Me.arcScaleComponent16.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent16.MajorTickmark.ShapeOffset = -12F
            Me.arcScaleComponent16.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_3
            Me.arcScaleComponent16.MajorTickmark.TextOffset = -22F
            Me.arcScaleComponent16.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent16.MaxValue = 100F
            Me.arcScaleComponent16.MinorTickCount = 4
            Me.arcScaleComponent16.MinorTickmark.ShapeOffset = 4F
            Me.arcScaleComponent16.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_4
            Me.arcScaleComponent16.Name = "scale1"
            Me.arcScaleComponent16.RadiusX = 107F
            Me.arcScaleComponent16.RadiusY = 107F
            Me.arcScaleComponent16.StartAngle = -240F
            Me.arcScaleComponent16.Value = 80F
            ' 
            ' arcScaleNeedleComponent16
            ' 
            Me.arcScaleNeedleComponent16.ArcScale = Me.arcScaleComponent16
            Me.arcScaleNeedleComponent16.EndOffset = -7.5F
            Me.arcScaleNeedleComponent16.Name = "needle"
            Me.arcScaleNeedleComponent16.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style14
            Me.arcScaleNeedleComponent16.StartOffset = -5F
            Me.arcScaleNeedleComponent16.ZOrder = -50
            ' 
            ' arcScaleComponent30
            ' 
            Me.arcScaleComponent30.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent30.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent30.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent30.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent30.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            Me.arcScaleComponent30.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent30.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent30.EndAngle = 60F
            Me.arcScaleComponent30.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent30.MajorTickmark.ShapeOffset = -3F
            Me.arcScaleComponent30.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_2
            Me.arcScaleComponent30.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent30.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent30.MaxValue = 1000F
            Me.arcScaleComponent30.MinorTickCount = 4
            Me.arcScaleComponent30.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style14_1
            Me.arcScaleComponent30.Name = "scale2"
            Me.arcScaleComponent30.RadiusX = 65F
            Me.arcScaleComponent30.RadiusY = 65F
            Me.arcScaleComponent30.StartAngle = -240F
            Me.arcScaleComponent30.Value = 300F
            Me.arcScaleComponent30.ZOrder = -1
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
            Me.xtraTabPage5.Caption = "Disco"
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
            Me.linearGauge5.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent5})
            Me.linearGauge5.Name = "linearGauge5"
            Me.linearGauge5.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent9, Me.linearScaleComponent10})
            ' 
            ' linearScaleBackgroundLayerComponent5
            ' 
            Me.linearScaleBackgroundLayerComponent5.LinearScale = Me.linearScaleComponent9
            Me.linearScaleBackgroundLayerComponent5.Name = "bg1"
            Me.linearScaleBackgroundLayerComponent5.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.08F)
            Me.linearScaleBackgroundLayerComponent5.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.92F)
            Me.linearScaleBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style15
            Me.linearScaleBackgroundLayerComponent5.ZOrder = 1000
            ' 
            ' linearScaleComponent9
            ' 
            Me.linearScaleComponent9.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent9.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent9.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent9.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent9.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Script MT Bold", 12F)
            Me.linearScaleComponent9.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent9.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F)
            Me.linearScaleComponent9.MajorTickCount = 6
            Me.linearScaleComponent9.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent9.MajorTickmark.ShapeOffset = 8F
            Me.linearScaleComponent9.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style15_1
            Me.linearScaleComponent9.MajorTickmark.TextOffset = 35F
            Me.linearScaleComponent9.MaxValue = 500F
            Me.linearScaleComponent9.MinorTickCount = 4
            Me.linearScaleComponent9.MinorTickmark.ShapeOffset = 6F
            Me.linearScaleComponent9.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style15_2
            Me.linearScaleComponent9.Name = "scale1"
            Me.linearScaleComponent9.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F)
            Me.linearScaleComponent9.Value = 250F
            ' 
            ' linearScaleLevelComponent5
            ' 
            Me.linearScaleLevelComponent5.LinearScale = Me.linearScaleComponent9
            Me.linearScaleLevelComponent5.Name = "level1"
            Me.linearScaleLevelComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style15
            Me.linearScaleLevelComponent5.ZOrder = -50
            ' 
            ' linearScaleComponent10
            ' 
            Me.linearScaleComponent10.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent10.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent10.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent10.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent10.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Script MT Bold", 12F)
            Me.linearScaleComponent10.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent10.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F)
            Me.linearScaleComponent10.MajorTickCount = 6
            Me.linearScaleComponent10.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent10.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent10.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style15_1
            Me.linearScaleComponent10.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent10.MaxValue = 50F
            Me.linearScaleComponent10.MinorTickCount = 4
            Me.linearScaleComponent10.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent10.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style15_2
            Me.linearScaleComponent10.Name = "scale2"
            Me.linearScaleComponent10.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F)
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
            Me.circularGauge17.Name = "circularGauge17"
            Me.circularGauge17.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent17})
            Me.circularGauge17.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent33, Me.arcScaleComponent34})
            ' 
            ' arcScaleBackgroundLayerComponent17
            ' 
            Me.arcScaleBackgroundLayerComponent17.ArcScale = Me.arcScaleComponent33
            Me.arcScaleBackgroundLayerComponent17.Name = "bg"
            Me.arcScaleBackgroundLayerComponent17.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.781F)
            Me.arcScaleBackgroundLayerComponent17.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style15
            Me.arcScaleBackgroundLayerComponent17.Size = New System.Drawing.SizeF(250F, 160F)
            Me.arcScaleBackgroundLayerComponent17.ZOrder = 1000
            ' 
            ' arcScaleComponent33
            ' 
            Me.arcScaleComponent33.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent33.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent33.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent33.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent33.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Script MT Bold", 12F)
            Me.arcScaleComponent33.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent33.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent33.EndAngle = 0F
            Me.arcScaleComponent33.MajorTickCount = 7
            Me.arcScaleComponent33.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent33.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_1
            Me.arcScaleComponent33.MajorTickmark.TextOffset = -12F
            Me.arcScaleComponent33.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent33.MaxValue = 80F
            Me.arcScaleComponent33.MinorTickCount = 4
            Me.arcScaleComponent33.MinorTickmark.ShapeOffset = -30F
            Me.arcScaleComponent33.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_2
            Me.arcScaleComponent33.MinValue = 20F
            Me.arcScaleComponent33.Name = "scale1"
            Me.arcScaleComponent33.RadiusX = 107F
            Me.arcScaleComponent33.RadiusY = 107F
            Me.arcScaleComponent33.StartAngle = -180F
            Me.arcScaleComponent33.Value = 80F
            ' 
            ' arcScaleNeedleComponent17
            ' 
            Me.arcScaleNeedleComponent17.ArcScale = Me.arcScaleComponent33
            Me.arcScaleNeedleComponent17.EndOffset = -7.5F
            Me.arcScaleNeedleComponent17.Name = "needle"
            Me.arcScaleNeedleComponent17.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style15
            Me.arcScaleNeedleComponent17.StartOffset = -5F
            Me.arcScaleNeedleComponent17.ZOrder = -50
            ' 
            ' arcScaleComponent34
            ' 
            Me.arcScaleComponent34.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent34.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent34.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent34.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent34.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Script MT Bold", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent34.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent34.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
            Me.arcScaleComponent34.EndAngle = 0F
            Me.arcScaleComponent34.MajorTickCount = 7
            Me.arcScaleComponent34.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent34.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_3
            Me.arcScaleComponent34.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent34.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent34.MaxValue = 800F
            Me.arcScaleComponent34.MinorTickCount = 4
            Me.arcScaleComponent34.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.4F, 0.4F)
            Me.arcScaleComponent34.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_4
            Me.arcScaleComponent34.MinValue = 200F
            Me.arcScaleComponent34.Name = "scale2"
            Me.arcScaleComponent34.RadiusX = 65F
            Me.arcScaleComponent34.RadiusY = 65F
            Me.arcScaleComponent34.StartAngle = -180F
            Me.arcScaleComponent34.Value = 300F
            Me.arcScaleComponent34.ZOrder = -1
            ' 
            ' gaugeControl27
            ' 
            Me.gaugeControl27.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge19})
            Me.gaugeControl27.Location = New System.Drawing.Point(2, 226)
            Me.gaugeControl27.Name = "gaugeControl27"
            Me.gaugeControl27.Size = New System.Drawing.Size(262, 248)
            Me.gaugeControl27.TabIndex = 7
            ' 
            ' circularGauge19
            ' 
            Me.circularGauge19.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent19})
            Me.circularGauge19.Bounds = New System.Drawing.Rectangle(6, 6, 250, 236)
            Me.circularGauge19.Name = "circularGauge19"
            Me.circularGauge19.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent19})
            Me.circularGauge19.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent37, Me.arcScaleComponent38})
            ' 
            ' arcScaleBackgroundLayerComponent19
            ' 
            Me.arcScaleBackgroundLayerComponent19.ArcScale = Me.arcScaleComponent37
            Me.arcScaleBackgroundLayerComponent19.Name = "bg"
            Me.arcScaleBackgroundLayerComponent19.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.755F, 0.827F)
            Me.arcScaleBackgroundLayerComponent19.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style15Left
            Me.arcScaleBackgroundLayerComponent19.ZOrder = 1000
            ' 
            ' arcScaleComponent37
            ' 
            Me.arcScaleComponent37.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent37.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent37.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent37.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent37.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Script MT Bold", 16F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent37.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent37.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(189F, 206F)
            Me.arcScaleComponent37.EndAngle = -90F
            Me.arcScaleComponent37.MajorTickCount = 4
            Me.arcScaleComponent37.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent37.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent37.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_1
            Me.arcScaleComponent37.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent37.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent37.MaxValue = 50F
            Me.arcScaleComponent37.MinorTickCount = 4
            Me.arcScaleComponent37.MinorTickmark.ShapeOffset = -40F
            Me.arcScaleComponent37.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
            Me.arcScaleComponent37.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_2
            Me.arcScaleComponent37.MinValue = 20F
            Me.arcScaleComponent37.Name = "scale1"
            Me.arcScaleComponent37.RadiusX = 175F
            Me.arcScaleComponent37.RadiusY = 175F
            Me.arcScaleComponent37.StartAngle = -180F
            Me.arcScaleComponent37.Value = 30F
            ' 
            ' arcScaleNeedleComponent19
            ' 
            Me.arcScaleNeedleComponent19.ArcScale = Me.arcScaleComponent37
            Me.arcScaleNeedleComponent19.EndOffset = -8F
            Me.arcScaleNeedleComponent19.Name = "needle"
            Me.arcScaleNeedleComponent19.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style15
            Me.arcScaleNeedleComponent19.StartOffset = -8F
            Me.arcScaleNeedleComponent19.ZOrder = -50
            ' 
            ' arcScaleComponent38
            ' 
            Me.arcScaleComponent38.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent38.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent38.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent38.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent38.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Script MT Bold", 12F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent38.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent38.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(189F, 206F)
            Me.arcScaleComponent38.EndAngle = -90F
            Me.arcScaleComponent38.MajorTickCount = 4
            Me.arcScaleComponent38.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent38.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.8F, 1.8F)
            Me.arcScaleComponent38.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_3
            Me.arcScaleComponent38.MajorTickmark.TextOffset = -20F
            Me.arcScaleComponent38.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent38.MaxValue = 500F
            Me.arcScaleComponent38.MinorTickCount = 4
            Me.arcScaleComponent38.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_4
            Me.arcScaleComponent38.MinValue = 200F
            Me.arcScaleComponent38.Name = "scale2"
            Me.arcScaleComponent38.StartAngle = -180F
            Me.arcScaleComponent38.Value = 300F
            Me.arcScaleComponent38.ZOrder = -1
            ' 
            ' gaugeControl28
            ' 
            Me.gaugeControl28.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge20})
            Me.gaugeControl28.Location = New System.Drawing.Point(268, 226)
            Me.gaugeControl28.Name = "gaugeControl28"
            Me.gaugeControl28.Size = New System.Drawing.Size(220, 248)
            Me.gaugeControl28.TabIndex = 6
            ' 
            ' circularGauge20
            ' 
            Me.circularGauge20.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent20})
            Me.circularGauge20.Bounds = New System.Drawing.Rectangle(6, 6, 208, 236)
            Me.circularGauge20.Name = "circularGauge20"
            Me.circularGauge20.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent20})
            Me.circularGauge20.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent39, Me.arcScaleComponent40})
            ' 
            ' arcScaleBackgroundLayerComponent20
            ' 
            Me.arcScaleBackgroundLayerComponent20.ArcScale = Me.arcScaleComponent39
            Me.arcScaleBackgroundLayerComponent20.Name = "bg"
            Me.arcScaleBackgroundLayerComponent20.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style15
            Me.arcScaleBackgroundLayerComponent20.ZOrder = 1000
            ' 
            ' arcScaleComponent39
            ' 
            Me.arcScaleComponent39.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent39.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent39.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent39.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent39.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Script MT Bold", 12F)
            Me.arcScaleComponent39.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent39.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent39.EndAngle = 30F
            Me.arcScaleComponent39.MajorTickCount = 9
            Me.arcScaleComponent39.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent39.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_1
            Me.arcScaleComponent39.MajorTickmark.TextOffset = -12F
            Me.arcScaleComponent39.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent39.MaxValue = 90F
            Me.arcScaleComponent39.MinorTickCount = 4
            Me.arcScaleComponent39.MinorTickmark.ShapeOffset = -30F
            Me.arcScaleComponent39.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_2
            Me.arcScaleComponent39.MinValue = 10F
            Me.arcScaleComponent39.Name = "scale1"
            Me.arcScaleComponent39.RadiusX = 107F
            Me.arcScaleComponent39.RadiusY = 107F
            Me.arcScaleComponent39.StartAngle = -210F
            Me.arcScaleComponent39.Value = 50F
            ' 
            ' arcScaleNeedleComponent20
            ' 
            Me.arcScaleNeedleComponent20.ArcScale = Me.arcScaleComponent39
            Me.arcScaleNeedleComponent20.EndOffset = -7.5F
            Me.arcScaleNeedleComponent20.Name = "needle"
            Me.arcScaleNeedleComponent20.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style15
            Me.arcScaleNeedleComponent20.StartOffset = -5F
            Me.arcScaleNeedleComponent20.ZOrder = -50
            ' 
            ' arcScaleComponent40
            ' 
            Me.arcScaleComponent40.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent40.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent40.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent40.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent40.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Script MT Bold", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent40.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent40.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent40.EndAngle = 30F
            Me.arcScaleComponent40.MajorTickCount = 9
            Me.arcScaleComponent40.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent40.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_3
            Me.arcScaleComponent40.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent40.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent40.MaxValue = 900F
            Me.arcScaleComponent40.MinorTickCount = 4
            Me.arcScaleComponent40.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.4F, 0.4F)
            Me.arcScaleComponent40.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_4
            Me.arcScaleComponent40.MinValue = 100F
            Me.arcScaleComponent40.Name = "scale2"
            Me.arcScaleComponent40.RadiusX = 65F
            Me.arcScaleComponent40.RadiusY = 65F
            Me.arcScaleComponent40.StartAngle = -210F
            Me.arcScaleComponent40.Value = 300F
            Me.arcScaleComponent40.ZOrder = -1
            ' 
            ' gaugeControl29
            ' 
            Me.gaugeControl29.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge25})
            Me.gaugeControl29.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl29.Name = "gaugeControl29"
            Me.gaugeControl29.Size = New System.Drawing.Size(262, 220)
            Me.gaugeControl29.TabIndex = 5
            ' 
            ' circularGauge25
            ' 
            Me.circularGauge25.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent29})
            Me.circularGauge25.Bounds = New System.Drawing.Rectangle(6, 6, 250, 208)
            Me.circularGauge25.Name = "circularGauge25"
            Me.circularGauge25.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent25})
            Me.circularGauge25.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent51})
            ' 
            ' arcScaleBackgroundLayerComponent29
            ' 
            Me.arcScaleBackgroundLayerComponent29.ArcScale = Me.arcScaleComponent51
            Me.arcScaleBackgroundLayerComponent29.Name = "bg1"
            Me.arcScaleBackgroundLayerComponent29.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1.81F)
            Me.arcScaleBackgroundLayerComponent29.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style15
            Me.arcScaleBackgroundLayerComponent29.Size = New System.Drawing.SizeF(250F, 68F)
            Me.arcScaleBackgroundLayerComponent29.ZOrder = 1000
            ' 
            ' arcScaleComponent51
            ' 
            Me.arcScaleComponent51.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent51.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent51.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent51.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent51.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Script MT Bold", 10F)
            Me.arcScaleComponent51.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent51.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 210F)
            Me.arcScaleComponent51.EndAngle = -63F
            Me.arcScaleComponent51.MajorTickCount = 7
            Me.arcScaleComponent51.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent51.MajorTickmark.ShapeOffset = -7F
            Me.arcScaleComponent51.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_3
            Me.arcScaleComponent51.MajorTickmark.TextOffset = -18F
            Me.arcScaleComponent51.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent51.MaxValue = 60F
            Me.arcScaleComponent51.MinorTickCount = 4
            Me.arcScaleComponent51.MinorTickmark.ShapeOffset = -5F
            Me.arcScaleComponent51.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.6F)
            Me.arcScaleComponent51.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_4
            Me.arcScaleComponent51.Name = "scale1"
            Me.arcScaleComponent51.RadiusX = 200F
            Me.arcScaleComponent51.StartAngle = -117F
            ' 
            ' arcScaleNeedleComponent25
            ' 
            Me.arcScaleNeedleComponent25.ArcScale = Me.arcScaleComponent51
            Me.arcScaleNeedleComponent25.Name = "needle1"
            Me.arcScaleNeedleComponent25.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularWide_Style15
            Me.arcScaleNeedleComponent25.StartOffset = 130F
            Me.arcScaleNeedleComponent25.ZOrder = -50
            ' 
            ' gaugeControl30
            ' 
            Me.gaugeControl30.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge18})
            Me.gaugeControl30.Location = New System.Drawing.Point(492, 2)
            Me.gaugeControl30.Name = "gaugeControl30"
            Me.gaugeControl30.Size = New System.Drawing.Size(219, 220)
            Me.gaugeControl30.TabIndex = 4
            ' 
            ' circularGauge18
            ' 
            Me.circularGauge18.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent18})
            Me.circularGauge18.Bounds = New System.Drawing.Rectangle(6, 6, 207, 208)
            Me.circularGauge18.Name = "circularGauge18"
            Me.circularGauge18.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent18})
            Me.circularGauge18.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent35, Me.arcScaleComponent36})
            ' 
            ' arcScaleBackgroundLayerComponent18
            ' 
            Me.arcScaleBackgroundLayerComponent18.ArcScale = Me.arcScaleComponent35
            Me.arcScaleBackgroundLayerComponent18.Name = "bg"
            Me.arcScaleBackgroundLayerComponent18.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style15
            Me.arcScaleBackgroundLayerComponent18.ZOrder = 1000
            ' 
            ' arcScaleComponent35
            ' 
            Me.arcScaleComponent35.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent35.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent35.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent35.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent35.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Script MT Bold", 12F)
            Me.arcScaleComponent35.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent35.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent35.EndAngle = 60F
            Me.arcScaleComponent35.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent35.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_1
            Me.arcScaleComponent35.MajorTickmark.TextOffset = -12F
            Me.arcScaleComponent35.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent35.MaxValue = 100F
            Me.arcScaleComponent35.MinorTickCount = 4
            Me.arcScaleComponent35.MinorTickmark.ShapeOffset = -30F
            Me.arcScaleComponent35.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_2
            Me.arcScaleComponent35.Name = "scale1"
            Me.arcScaleComponent35.RadiusX = 107F
            Me.arcScaleComponent35.RadiusY = 107F
            Me.arcScaleComponent35.StartAngle = -240F
            Me.arcScaleComponent35.Value = 80F
            ' 
            ' arcScaleNeedleComponent18
            ' 
            Me.arcScaleNeedleComponent18.ArcScale = Me.arcScaleComponent35
            Me.arcScaleNeedleComponent18.EndOffset = -7.5F
            Me.arcScaleNeedleComponent18.Name = "needle"
            Me.arcScaleNeedleComponent18.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style15
            Me.arcScaleNeedleComponent18.StartOffset = -5F
            Me.arcScaleNeedleComponent18.ZOrder = -50
            ' 
            ' arcScaleComponent36
            ' 
            Me.arcScaleComponent36.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent36.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent36.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent36.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent36.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Script MT Bold", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleComponent36.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent36.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent36.EndAngle = 60F
            Me.arcScaleComponent36.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent36.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_3
            Me.arcScaleComponent36.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent36.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent36.MaxValue = 1000F
            Me.arcScaleComponent36.MinorTickCount = 4
            Me.arcScaleComponent36.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.4F, 0.4F)
            Me.arcScaleComponent36.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style15_4
            Me.arcScaleComponent36.Name = "scale2"
            Me.arcScaleComponent36.RadiusX = 65F
            Me.arcScaleComponent36.RadiusY = 65F
            Me.arcScaleComponent36.StartAngle = -240F
            Me.arcScaleComponent36.Value = 300F
            Me.arcScaleComponent36.ZOrder = -1
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
            ' GaugesNewStyles
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "GaugesNewStyles"
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
            CType((Me.arcScaleComponent21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent23), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent24), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent41), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent22), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent22), System.ComponentModel.ISupportInitialize).EndInit()
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
            CType((Me.arcScaleComponent17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge22), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent23), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent42), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent24), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent22), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent43), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent18), System.ComponentModel.ISupportInitialize).EndInit()
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
            CType((Me.arcScaleComponent25), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent28), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent27), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge23), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent25), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent44), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent26), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent23), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent45), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent26), System.ComponentModel.ISupportInitialize).EndInit()
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
            CType((Me.arcScaleComponent29), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent32), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent31), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge24), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent27), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent46), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent28), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent24), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent30), System.ComponentModel.ISupportInitialize).EndInit()
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
            CType((Me.linearScaleLevelComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent33), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent34), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent37), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent38), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent39), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent40), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge25), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent29), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent51), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent25), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent35), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent36), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem25), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem26), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem27), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem28), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem29), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem30), System.ComponentModel.ISupportInitialize).EndInit()
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

        Private gaugeControl6 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl5 As DevExpress.XtraGauges.Win.GaugeControl

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

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private gaugeControl7 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl8 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl9 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl10 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl11 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl12 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

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

        Private circularGauge2 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent21 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge3 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent23 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge4 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent24 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private circularGauge5 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent17 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge6 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent19 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge7 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent20 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge8 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent18 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge9 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent25 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge10 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent28 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge11 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent27 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge12 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent26 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge13 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent29 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge14 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent32 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge15 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent31 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge16 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent30 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge17 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent17 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent33 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent17 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent34 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge19 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent19 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent37 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent19 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent38 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge20 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent20 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent39 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent20 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent40 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge18 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent18 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent35 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent18 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent36 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge21 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent21 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent41 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleBackgroundLayerComponent22 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleNeedleComponent21 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private circularGauge22 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent23 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent42 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleBackgroundLayerComponent24 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleNeedleComponent22 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent43 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge23 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent25 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent44 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleBackgroundLayerComponent26 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleNeedleComponent23 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleComponent45 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private circularGauge24 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent27 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent46 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleBackgroundLayerComponent28 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleNeedleComponent24 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private circularGauge25 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent29 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent51 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent25 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private linearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleLevelComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private linearScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

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

        Private linearScaleLevelComponent5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private linearScaleComponent10 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private arcScaleComponent22 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    End Class
End Namespace
