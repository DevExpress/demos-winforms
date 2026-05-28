Namespace DevExpress.XtraGauges.Demos

    Partial Class NewPresets

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
                If Me.loadingTimer IsNot Nothing Then
                    Me.loadingTimer.[Stop]()
                    Me.loadingTimer.Dispose()
                    Me.loadingTimer = Nothing
                End If

                If Me.equalizerTimer IsNot Nothing Then
                    Me.equalizerTimer.[Stop]()
                    Me.equalizerTimer.Dispose()
                    Me.equalizerTimer = Nothing
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
            Dim scaleIndicatorState1 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState2 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleLabel1 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleIndicatorState3 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState4 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState5 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState6 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState7 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState8 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState9 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState10 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState11 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState12 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState13 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState14 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState15 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState16 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState17 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState18 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState19 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState20 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState21 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState22 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState23 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState24 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState25 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState26 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState27 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState28 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState29 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState30 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleLabel2 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim scaleIndicatorState31 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState32 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState33 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState34 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState35 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState36 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState37 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState38 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState39 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState40 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState41 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState42 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState43 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState44 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState45 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState46 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState47 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState48 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState49 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState50 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState51 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState52 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState53 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState54 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState55 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState56 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState57 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState58 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState59 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState60 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState61 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState62 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState63 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState64 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState65 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState66 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState67 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState68 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState69 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState70 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState71 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState72 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState73 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState74 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState75 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState76 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState77 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState78 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState79 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState80 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState81 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState82 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState83 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState84 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState85 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState86 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState87 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState88 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState89 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState90 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState91 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState92 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState93 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState94 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState95 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState96 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState97 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState98 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState99 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState100 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState101 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState102 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState103 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState104 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState105 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState106 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState107 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState108 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState109 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState110 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState111 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState112 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState113 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState114 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState115 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState116 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState117 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState118 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState119 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState120 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim linearScaleRange1 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange2 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange3 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange4 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange5 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange6 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange7 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange8 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange9 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim scaleIndicatorState121 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState122 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState123 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState124 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState125 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState126 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState127 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState128 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState129 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState130 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState131 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState132 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState133 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState134 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState135 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState136 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState137 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState138 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState139 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState140 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState141 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState142 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState143 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState144 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState145 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState146 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState147 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState148 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState149 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState150 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState151 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState152 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState153 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState154 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState155 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState156 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState157 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState158 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState159 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState160 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState161 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState162 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState163 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState164 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState165 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState166 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState167 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState168 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState169 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState170 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState171 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState172 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState173 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState174 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState175 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState176 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState177 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState178 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState179 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState180 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState181 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState182 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState183 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState184 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState185 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState186 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState187 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState188 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState189 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState190 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState191 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState192 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState193 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState194 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState195 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState196 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState197 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState198 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState199 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState200 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState201 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState202 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState203 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState204 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState205 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState206 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState207 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState208 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState209 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState210 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState211 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState212 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState213 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState214 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState215 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim scaleIndicatorState216 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim linearScaleRange10 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange11 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange12 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange13 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange14 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange15 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange16 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange17 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange18 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange19 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange20 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange21 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.rating1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge9 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleStateIndicatorComponent86 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleComponent21 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleStateIndicatorComponent87 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent88 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent89 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent90 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent91 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent92 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent93 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent94 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent95 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.ratingValue = New DevExpress.XtraEditors.RadioGroup()
            Me.progressValue = New DevExpress.XtraEditors.TrackBarControl()
            Me.equalizerLevel = New DevExpress.XtraEditors.TrackBarControl()
            Me.rating = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge8 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleStateIndicatorComponent81 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleComponent20 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleStateIndicatorComponent82 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent83 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent84 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent85 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.levelIndicator = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.linearScaleComponent17 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleStateIndicatorComponent36 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent37 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent38 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent39 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent40 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent41 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent42 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent43 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent44 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent45 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent46 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent47 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent48 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent49 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent50 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent51 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent52 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent53 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent54 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent55 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent56 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent57 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent58 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent59 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent60 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.progress2 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge7 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleStateIndicatorComponent71 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleComponent19 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleStateIndicatorComponent72 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent73 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent74 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent75 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent76 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent77 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent78 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent79 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent80 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.progress1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleStateIndicatorComponent61 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleComponent18 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleStateIndicatorComponent62 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent63 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent64 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent65 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent66 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent67 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent68 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent69 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent70 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.graph2 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.labelComponent9 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.labelComponent10 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.labelComponent11 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.labelComponent12 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.labelComponent13 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.labelComponent14 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.linearScaleMarkerComponent5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent()
            Me.linearScaleComponent10 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleMarkerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent()
            Me.linearScaleComponent12 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleMarkerComponent7 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent()
            Me.linearScaleComponent14 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleRangeBarComponent5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent()
            Me.linearScaleComponent9 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleRangeBarComponent6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent()
            Me.linearScaleComponent11 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleRangeBarComponent7 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent()
            Me.linearScaleComponent13 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.equalizer = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge3 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleStateIndicatorComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleComponent15 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleStateIndicatorComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent3 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent7 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent8 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent9 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleComponent16 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleStateIndicatorComponent10 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent11 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent12 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent13 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent14 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent15 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent16 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent17 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleComponent22 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleStateIndicatorComponent18 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent19 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent20 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent21 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent22 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent23 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent24 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent25 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleComponent23 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleStateIndicatorComponent26 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent27 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent28 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent29 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent30 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent31 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent32 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent33 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleComponent24 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleStateIndicatorComponent34 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent35 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent96 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent97 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent98 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent99 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent100 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent101 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleComponent25 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleStateIndicatorComponent102 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent103 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent104 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent105 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent106 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent107 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.linearScaleStateIndicatorComponent108 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
            Me.graph1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.labelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.labelComponent2 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.labelComponent3 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.labelComponent4 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.labelComponent5 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.labelComponent6 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.labelComponent7 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.labelComponent8 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.linearScaleMarkerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent()
            Me.linearScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleMarkerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent()
            Me.linearScaleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleMarkerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent()
            Me.linearScaleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleMarkerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent()
            Me.linearScaleComponent8 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent()
            Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleRangeBarComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent()
            Me.linearScaleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleRangeBarComponent3 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent()
            Me.linearScaleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleRangeBarComponent4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent()
            Me.linearScaleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem12 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem13 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.loadingTimer = New System.Windows.Forms.Timer(Me.components)
            Me.equalizerTimer = New System.Windows.Forms.Timer(Me.components)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.linearGauge9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent86), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent87), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent88), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent89), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent90), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent91), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent92), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent93), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent94), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent95), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ratingValue.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.progressValue), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.progressValue.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.equalizerLevel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.equalizerLevel.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearGauge8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent81), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent82), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent83), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent84), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent85), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearGauge5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleBackgroundLayerComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent36), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent37), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent38), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent39), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent40), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent41), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent42), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent43), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent44), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent45), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent46), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent47), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent48), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent49), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent50), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent51), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent52), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent53), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent54), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent55), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent56), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent57), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent58), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent59), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent60), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearGauge7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent71), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent72), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent73), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent74), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent75), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent76), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent77), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent78), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent79), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent80), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearGauge6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent61), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent62), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent63), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent64), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent65), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent66), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent67), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent68), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent69), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent70), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearGauge2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleMarkerComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleMarkerComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleMarkerComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleRangeBarComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleRangeBarComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleRangeBarComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearGauge3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent22), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent22), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent23), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent24), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent25), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent23), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent26), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent27), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent28), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent29), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent30), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent31), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent32), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent33), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent24), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent34), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent35), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent96), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent97), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent98), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent99), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent100), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent101), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent25), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent102), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent103), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent104), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent105), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent106), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent107), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleStateIndicatorComponent108), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleMarkerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleMarkerComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleMarkerComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleMarkerComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleRangeBarComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleRangeBarComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleRangeBarComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleRangeBarComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabbedControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.rating1)
            Me.layoutControl1.Controls.Add(Me.ratingValue)
            Me.layoutControl1.Controls.Add(Me.progressValue)
            Me.layoutControl1.Controls.Add(Me.equalizerLevel)
            Me.layoutControl1.Controls.Add(Me.rating)
            Me.layoutControl1.Controls.Add(Me.levelIndicator)
            Me.layoutControl1.Controls.Add(Me.progress2)
            Me.layoutControl1.Controls.Add(Me.progress1)
            Me.layoutControl1.Controls.Add(Me.graph2)
            Me.layoutControl1.Controls.Add(Me.equalizer)
            Me.layoutControl1.Controls.Add(Me.graph1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 8)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(813, 196, 650, 646)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(764, 497)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' rating1
            ' 
            Me.rating1.BackColor = System.Drawing.Color.Transparent
            Me.rating1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rating1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge9})
            Me.rating1.Location = New System.Drawing.Point(24, 63)
            Me.rating1.MaximumSize = New System.Drawing.Size(250, 400)
            Me.rating1.MinimumSize = New System.Drawing.Size(250, 400)
            Me.rating1.Name = "rating1"
            Me.rating1.Size = New System.Drawing.Size(250, 400)
            Me.rating1.TabIndex = 12
            ' 
            ' linearGauge9
            ' 
            Me.linearGauge9.Bounds = New System.Drawing.Rectangle(6, 6, 238, 388)
            Me.linearGauge9.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent() {Me.linearScaleStateIndicatorComponent86, Me.linearScaleStateIndicatorComponent87, Me.linearScaleStateIndicatorComponent88, Me.linearScaleStateIndicatorComponent89, Me.linearScaleStateIndicatorComponent90, Me.linearScaleStateIndicatorComponent91, Me.linearScaleStateIndicatorComponent92, Me.linearScaleStateIndicatorComponent93, Me.linearScaleStateIndicatorComponent94, Me.linearScaleStateIndicatorComponent95})
            Me.linearGauge9.Name = "linearGauge9"
            Me.linearGauge9.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent21})
            ' 
            ' linearScaleStateIndicatorComponent86
            ' 
            Me.linearScaleStateIndicatorComponent86.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(15F, 125F)
            Me.linearScaleStateIndicatorComponent86.IndicatorScale = Me.linearScaleComponent21
            Me.linearScaleStateIndicatorComponent86.Name = "Indicator0"
            Me.linearScaleStateIndicatorComponent86.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
            scaleIndicatorState1.IntervalLength = 100F
            scaleIndicatorState1.Name = "Colored"
            scaleIndicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
            scaleIndicatorState1.StartValue = 0.01F
            scaleIndicatorState2.IntervalLength = 0F
            scaleIndicatorState2.Name = "Empty"
            scaleIndicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
            Me.linearScaleStateIndicatorComponent86.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState1, scaleIndicatorState2})
            Me.linearScaleStateIndicatorComponent86.ZOrder = 100
            ' 
            ' linearScaleComponent21
            ' 
            Me.linearScaleComponent21.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent21.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent21.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent21.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent21.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent21.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 225F)
            scaleLabel1.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 14F)
            scaleLabel1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            scaleLabel1.FormatString = "{0} {2:P0}"
            scaleLabel1.Name = "Label0"
            scaleLabel1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 125F)
            scaleLabel1.Size = New System.Drawing.SizeF(60F, 30F)
            scaleLabel1.Text = ""
            Me.linearScaleComponent21.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {scaleLabel1})
            Me.linearScaleComponent21.MajorTickCount = 2
            Me.linearScaleComponent21.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent21.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent21.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScaleComponent21.MajorTickmark.ShowText = False
            Me.linearScaleComponent21.MajorTickmark.ShowTick = False
            Me.linearScaleComponent21.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent21.MaxValue = 100F
            Me.linearScaleComponent21.MinorTickCount = 0
            Me.linearScaleComponent21.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent21.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScaleComponent21.MinorTickmark.ShowTick = False
            Me.linearScaleComponent21.Name = "scale1"
            Me.linearScaleComponent21.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 25F)
            Me.linearScaleComponent21.Value = 65F
            ' 
            ' linearScaleStateIndicatorComponent87
            ' 
            Me.linearScaleStateIndicatorComponent87.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(22.05F, 95.61F)
            Me.linearScaleStateIndicatorComponent87.IndicatorScale = Me.linearScaleComponent21
            Me.linearScaleStateIndicatorComponent87.Name = "Indicator1"
            Me.linearScaleStateIndicatorComponent87.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
            scaleIndicatorState3.IntervalLength = 90F
            scaleIndicatorState3.Name = "Colored"
            scaleIndicatorState3.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
            scaleIndicatorState3.StartValue = 10F
            scaleIndicatorState4.IntervalLength = 10F
            scaleIndicatorState4.Name = "Empty"
            scaleIndicatorState4.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
            Me.linearScaleStateIndicatorComponent87.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState3, scaleIndicatorState4})
            Me.linearScaleStateIndicatorComponent87.ZOrder = 99
            ' 
            ' linearScaleStateIndicatorComponent88
            ' 
            Me.linearScaleStateIndicatorComponent88.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(47.05F, 77.45F)
            Me.linearScaleStateIndicatorComponent88.IndicatorScale = Me.linearScaleComponent21
            Me.linearScaleStateIndicatorComponent88.Name = "Indicator2"
            Me.linearScaleStateIndicatorComponent88.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
            scaleIndicatorState5.IntervalLength = 80F
            scaleIndicatorState5.Name = "Colored"
            scaleIndicatorState5.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
            scaleIndicatorState5.StartValue = 20F
            scaleIndicatorState6.IntervalLength = 20F
            scaleIndicatorState6.Name = "Empty"
            scaleIndicatorState6.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
            Me.linearScaleStateIndicatorComponent88.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState5, scaleIndicatorState6})
            Me.linearScaleStateIndicatorComponent88.ZOrder = 98
            ' 
            ' linearScaleStateIndicatorComponent89
            ' 
            Me.linearScaleStateIndicatorComponent89.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(77.95F, 77.45F)
            Me.linearScaleStateIndicatorComponent89.IndicatorScale = Me.linearScaleComponent21
            Me.linearScaleStateIndicatorComponent89.Name = "Indicator3"
            Me.linearScaleStateIndicatorComponent89.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
            scaleIndicatorState7.IntervalLength = 70F
            scaleIndicatorState7.Name = "Colored"
            scaleIndicatorState7.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
            scaleIndicatorState7.StartValue = 30F
            scaleIndicatorState8.IntervalLength = 30F
            scaleIndicatorState8.Name = "Empty"
            scaleIndicatorState8.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
            Me.linearScaleStateIndicatorComponent89.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState7, scaleIndicatorState8})
            Me.linearScaleStateIndicatorComponent89.ZOrder = 97
            ' 
            ' linearScaleStateIndicatorComponent90
            ' 
            Me.linearScaleStateIndicatorComponent90.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(102.95F, 95.61F)
            Me.linearScaleStateIndicatorComponent90.IndicatorScale = Me.linearScaleComponent21
            Me.linearScaleStateIndicatorComponent90.Name = "Indicator4"
            Me.linearScaleStateIndicatorComponent90.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
            scaleIndicatorState9.IntervalLength = 60F
            scaleIndicatorState9.Name = "Colored"
            scaleIndicatorState9.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
            scaleIndicatorState9.StartValue = 40F
            scaleIndicatorState10.IntervalLength = 40F
            scaleIndicatorState10.Name = "Empty"
            scaleIndicatorState10.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
            Me.linearScaleStateIndicatorComponent90.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState9, scaleIndicatorState10})
            Me.linearScaleStateIndicatorComponent90.ZOrder = 96
            ' 
            ' linearScaleStateIndicatorComponent91
            ' 
            Me.linearScaleStateIndicatorComponent91.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(110F, 125F)
            Me.linearScaleStateIndicatorComponent91.IndicatorScale = Me.linearScaleComponent21
            Me.linearScaleStateIndicatorComponent91.Name = "Indicator5"
            Me.linearScaleStateIndicatorComponent91.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
            scaleIndicatorState11.IntervalLength = 50F
            scaleIndicatorState11.Name = "Colored"
            scaleIndicatorState11.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
            scaleIndicatorState11.StartValue = 50F
            scaleIndicatorState12.IntervalLength = 50F
            scaleIndicatorState12.Name = "Empty"
            scaleIndicatorState12.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
            Me.linearScaleStateIndicatorComponent91.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState11, scaleIndicatorState12})
            Me.linearScaleStateIndicatorComponent91.ZOrder = 95
            ' 
            ' linearScaleStateIndicatorComponent92
            ' 
            Me.linearScaleStateIndicatorComponent92.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(102.92F, 154.39F)
            Me.linearScaleStateIndicatorComponent92.IndicatorScale = Me.linearScaleComponent21
            Me.linearScaleStateIndicatorComponent92.Name = "Indicator6"
            Me.linearScaleStateIndicatorComponent92.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
            scaleIndicatorState13.IntervalLength = 40F
            scaleIndicatorState13.Name = "Colored"
            scaleIndicatorState13.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
            scaleIndicatorState13.StartValue = 60F
            scaleIndicatorState14.IntervalLength = 60F
            scaleIndicatorState14.Name = "Empty"
            scaleIndicatorState14.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
            Me.linearScaleStateIndicatorComponent92.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState13, scaleIndicatorState14})
            Me.linearScaleStateIndicatorComponent92.ZOrder = 94
            ' 
            ' linearScaleStateIndicatorComponent93
            ' 
            Me.linearScaleStateIndicatorComponent93.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(77.95F, 172.55F)
            Me.linearScaleStateIndicatorComponent93.IndicatorScale = Me.linearScaleComponent21
            Me.linearScaleStateIndicatorComponent93.Name = "Indicator7"
            Me.linearScaleStateIndicatorComponent93.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
            scaleIndicatorState15.IntervalLength = 30F
            scaleIndicatorState15.Name = "Colored"
            scaleIndicatorState15.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
            scaleIndicatorState15.StartValue = 70F
            scaleIndicatorState16.IntervalLength = 70F
            scaleIndicatorState16.Name = "Empty"
            scaleIndicatorState16.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
            Me.linearScaleStateIndicatorComponent93.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState15, scaleIndicatorState16})
            Me.linearScaleStateIndicatorComponent93.ZOrder = 93
            ' 
            ' linearScaleStateIndicatorComponent94
            ' 
            Me.linearScaleStateIndicatorComponent94.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(47.05F, 172.55F)
            Me.linearScaleStateIndicatorComponent94.IndicatorScale = Me.linearScaleComponent21
            Me.linearScaleStateIndicatorComponent94.Name = "Indicator8"
            Me.linearScaleStateIndicatorComponent94.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
            scaleIndicatorState17.IntervalLength = 20F
            scaleIndicatorState17.Name = "Colored"
            scaleIndicatorState17.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
            scaleIndicatorState17.StartValue = 80F
            scaleIndicatorState18.IntervalLength = 80F
            scaleIndicatorState18.Name = "Empty"
            scaleIndicatorState18.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
            Me.linearScaleStateIndicatorComponent94.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState17, scaleIndicatorState18})
            Me.linearScaleStateIndicatorComponent94.ZOrder = 92
            ' 
            ' linearScaleStateIndicatorComponent95
            ' 
            Me.linearScaleStateIndicatorComponent95.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(22.05F, 154.39F)
            Me.linearScaleStateIndicatorComponent95.IndicatorScale = Me.linearScaleComponent21
            Me.linearScaleStateIndicatorComponent95.Name = "Indicator9"
            Me.linearScaleStateIndicatorComponent95.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
            scaleIndicatorState19.IntervalLength = 10F
            scaleIndicatorState19.Name = "Colored"
            scaleIndicatorState19.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
            scaleIndicatorState19.StartValue = 90F
            scaleIndicatorState20.IntervalLength = 90F
            scaleIndicatorState20.Name = "Empty"
            scaleIndicatorState20.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
            Me.linearScaleStateIndicatorComponent95.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState19, scaleIndicatorState20})
            Me.linearScaleStateIndicatorComponent95.ZOrder = 91
            ' 
            ' ratingValue
            ' 
            Me.ratingValue.AutoSizeInLayoutControl = True
            Me.ratingValue.EditValue = 30
            Me.ratingValue.Location = New System.Drawing.Point(271, 351)
            Me.ratingValue.Name = "ratingValue"
            Me.ratingValue.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.ratingValue.Properties.Appearance.Options.UseBackColor = True
            Me.ratingValue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.ratingValue.Properties.Columns = 6
            Me.ratingValue.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(-10, "0"), New DevExpress.XtraEditors.Controls.RadioGroupItem(10, "1"), New DevExpress.XtraEditors.Controls.RadioGroupItem(30, "2"), New DevExpress.XtraEditors.Controls.RadioGroupItem(50, "3"), New DevExpress.XtraEditors.Controls.RadioGroupItem(70, "4"), New DevExpress.XtraEditors.Controls.RadioGroupItem(90, "5")})
            Me.ratingValue.Size = New System.Drawing.Size(244, 32)
            Me.ratingValue.StyleController = Me.layoutControl1
            Me.ratingValue.TabIndex = 14
            AddHandler Me.ratingValue.SelectedIndexChanged, New System.EventHandler(AddressOf Me.OnRatingChanged)
            ' 
            ' progressValue
            ' 
            Me.progressValue.EditValue = Nothing
            Me.progressValue.Location = New System.Drawing.Point(211, 397)
            Me.progressValue.Name = "progressValue"
            Me.progressValue.Properties.Maximum = 100
            Me.progressValue.Properties.TickFrequency = 5
            Me.progressValue.Size = New System.Drawing.Size(304, 45)
            Me.progressValue.StyleController = Me.layoutControl1
            Me.progressValue.TabIndex = 13
            AddHandler Me.progressValue.EditValueChanged, New System.EventHandler(AddressOf Me.OnProgressValueChanged)
            ' 
            ' equalizerLevel
            ' 
            Me.equalizerLevel.EditValue = Nothing
            Me.equalizerLevel.Location = New System.Drawing.Point(24, 366)
            Me.equalizerLevel.MaximumSize = New System.Drawing.Size(350, 35)
            Me.equalizerLevel.MinimumSize = New System.Drawing.Size(350, 35)
            Me.equalizerLevel.Name = "equalizerLevel"
            Me.equalizerLevel.Properties.Maximum = 100
            Me.equalizerLevel.Properties.TickFrequency = 5
            Me.equalizerLevel.Size = New System.Drawing.Size(350, 35)
            Me.equalizerLevel.StyleController = Me.layoutControl1
            Me.equalizerLevel.TabIndex = 7
            AddHandler Me.equalizerLevel.EditValueChanged, New System.EventHandler(AddressOf Me.OnLevelIndicatorValueChanged)
            ' 
            ' rating
            ' 
            Me.rating.BackColor = System.Drawing.Color.Transparent
            Me.rating.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rating.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge8})
            Me.rating.Location = New System.Drawing.Point(157, 122)
            Me.rating.MaximumSize = New System.Drawing.Size(450, 225)
            Me.rating.MinimumSize = New System.Drawing.Size(450, 225)
            Me.rating.Name = "rating"
            Me.rating.Size = New System.Drawing.Size(450, 225)
            Me.rating.TabIndex = 11
            ' 
            ' linearGauge8
            ' 
            Me.linearGauge8.Bounds = New System.Drawing.Rectangle(6, 6, 438, 213)
            Me.linearGauge8.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent() {Me.linearScaleStateIndicatorComponent81, Me.linearScaleStateIndicatorComponent82, Me.linearScaleStateIndicatorComponent83, Me.linearScaleStateIndicatorComponent84, Me.linearScaleStateIndicatorComponent85})
            Me.linearGauge8.Name = "linearGauge8"
            Me.linearGauge8.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent20})
            ' 
            ' linearScaleStateIndicatorComponent81
            ' 
            Me.linearScaleStateIndicatorComponent81.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(-137.5F, 125F)
            Me.linearScaleStateIndicatorComponent81.IndicatorScale = Me.linearScaleComponent20
            Me.linearScaleStateIndicatorComponent81.Name = "Indicator0"
            Me.linearScaleStateIndicatorComponent81.Size = New System.Drawing.SizeF(100F, 100F)
            scaleIndicatorState21.IntervalLength = 100F
            scaleIndicatorState21.Name = "Colored"
            scaleIndicatorState21.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem11
            scaleIndicatorState21.StartValue = 0.01F
            scaleIndicatorState22.IntervalLength = 0F
            scaleIndicatorState22.Name = "Empty"
            scaleIndicatorState22.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem13
            Me.linearScaleStateIndicatorComponent81.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState21, scaleIndicatorState22})
            Me.linearScaleStateIndicatorComponent81.ZOrder = 100
            ' 
            ' linearScaleComponent20
            ' 
            Me.linearScaleComponent20.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent20.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent20.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent20.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent20.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent20.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 225F)
            Me.linearScaleComponent20.MajorTickCount = 2
            Me.linearScaleComponent20.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent20.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent20.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScaleComponent20.MajorTickmark.ShowText = False
            Me.linearScaleComponent20.MajorTickmark.ShowTick = False
            Me.linearScaleComponent20.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent20.MaxValue = 100F
            Me.linearScaleComponent20.MinorTickCount = 0
            Me.linearScaleComponent20.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent20.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScaleComponent20.MinorTickmark.ShowTick = False
            Me.linearScaleComponent20.Name = "Gauge0_Scale1"
            Me.linearScaleComponent20.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 25F)
            Me.linearScaleComponent20.Value = 35F
            ' 
            ' linearScaleStateIndicatorComponent82
            ' 
            Me.linearScaleStateIndicatorComponent82.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(-37.5F, 125F)
            Me.linearScaleStateIndicatorComponent82.IndicatorScale = Me.linearScaleComponent20
            Me.linearScaleStateIndicatorComponent82.Name = "Indicator1"
            Me.linearScaleStateIndicatorComponent82.Size = New System.Drawing.SizeF(100F, 100F)
            scaleIndicatorState23.IntervalLength = 80F
            scaleIndicatorState23.Name = "Colored"
            scaleIndicatorState23.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem11
            scaleIndicatorState23.StartValue = 20F
            scaleIndicatorState24.IntervalLength = 20F
            scaleIndicatorState24.Name = "Empty"
            scaleIndicatorState24.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem13
            Me.linearScaleStateIndicatorComponent82.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState23, scaleIndicatorState24})
            Me.linearScaleStateIndicatorComponent82.ZOrder = 99
            ' 
            ' linearScaleStateIndicatorComponent83
            ' 
            Me.linearScaleStateIndicatorComponent83.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 125F)
            Me.linearScaleStateIndicatorComponent83.IndicatorScale = Me.linearScaleComponent20
            Me.linearScaleStateIndicatorComponent83.Name = "Indicator2"
            Me.linearScaleStateIndicatorComponent83.Size = New System.Drawing.SizeF(100F, 100F)
            scaleIndicatorState25.IntervalLength = 60F
            scaleIndicatorState25.Name = "Colored"
            scaleIndicatorState25.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem11
            scaleIndicatorState25.StartValue = 40F
            scaleIndicatorState26.IntervalLength = 40F
            scaleIndicatorState26.Name = "Empty"
            scaleIndicatorState26.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem13
            Me.linearScaleStateIndicatorComponent83.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState25, scaleIndicatorState26})
            Me.linearScaleStateIndicatorComponent83.ZOrder = 98
            ' 
            ' linearScaleStateIndicatorComponent84
            ' 
            Me.linearScaleStateIndicatorComponent84.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(162.5F, 125F)
            Me.linearScaleStateIndicatorComponent84.IndicatorScale = Me.linearScaleComponent20
            Me.linearScaleStateIndicatorComponent84.Name = "Indicator3"
            Me.linearScaleStateIndicatorComponent84.Size = New System.Drawing.SizeF(100F, 100F)
            scaleIndicatorState27.IntervalLength = 40F
            scaleIndicatorState27.Name = "Colored"
            scaleIndicatorState27.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem11
            scaleIndicatorState27.StartValue = 60F
            scaleIndicatorState28.IntervalLength = 60F
            scaleIndicatorState28.Name = "Empty"
            scaleIndicatorState28.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem13
            Me.linearScaleStateIndicatorComponent84.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState27, scaleIndicatorState28})
            Me.linearScaleStateIndicatorComponent84.ZOrder = 97
            ' 
            ' linearScaleStateIndicatorComponent85
            ' 
            Me.linearScaleStateIndicatorComponent85.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(267.5F, 125F)
            Me.linearScaleStateIndicatorComponent85.IndicatorScale = Me.linearScaleComponent20
            Me.linearScaleStateIndicatorComponent85.Name = "Indicator4"
            Me.linearScaleStateIndicatorComponent85.Size = New System.Drawing.SizeF(100F, 100F)
            scaleIndicatorState29.IntervalLength = 20F
            scaleIndicatorState29.Name = "Colored"
            scaleIndicatorState29.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem11
            scaleIndicatorState29.StartValue = 80F
            scaleIndicatorState30.IntervalLength = 80F
            scaleIndicatorState30.Name = "Empty"
            scaleIndicatorState30.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem13
            Me.linearScaleStateIndicatorComponent85.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState29, scaleIndicatorState30})
            Me.linearScaleStateIndicatorComponent85.ZOrder = 96
            ' 
            ' levelIndicator
            ' 
            Me.levelIndicator.BackColor = System.Drawing.Color.Transparent
            Me.levelIndicator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.levelIndicator.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge5})
            Me.levelIndicator.Location = New System.Drawing.Point(24, 137)
            Me.levelIndicator.MaximumSize = New System.Drawing.Size(450, 225)
            Me.levelIndicator.MinimumSize = New System.Drawing.Size(450, 225)
            Me.levelIndicator.Name = "levelIndicator"
            Me.levelIndicator.Size = New System.Drawing.Size(450, 225)
            Me.levelIndicator.TabIndex = 8
            ' 
            ' linearGauge5
            ' 
            Me.linearGauge5.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent3})
            Me.linearGauge5.Bounds = New System.Drawing.Rectangle(6, 6, 438, 213)
            Me.linearGauge5.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent() {Me.linearScaleStateIndicatorComponent36, Me.linearScaleStateIndicatorComponent37, Me.linearScaleStateIndicatorComponent38, Me.linearScaleStateIndicatorComponent39, Me.linearScaleStateIndicatorComponent40, Me.linearScaleStateIndicatorComponent41, Me.linearScaleStateIndicatorComponent42, Me.linearScaleStateIndicatorComponent43, Me.linearScaleStateIndicatorComponent44, Me.linearScaleStateIndicatorComponent45, Me.linearScaleStateIndicatorComponent46, Me.linearScaleStateIndicatorComponent47, Me.linearScaleStateIndicatorComponent48, Me.linearScaleStateIndicatorComponent49, Me.linearScaleStateIndicatorComponent50, Me.linearScaleStateIndicatorComponent51, Me.linearScaleStateIndicatorComponent52, Me.linearScaleStateIndicatorComponent53, Me.linearScaleStateIndicatorComponent54, Me.linearScaleStateIndicatorComponent55, Me.linearScaleStateIndicatorComponent56, Me.linearScaleStateIndicatorComponent57, Me.linearScaleStateIndicatorComponent58, Me.linearScaleStateIndicatorComponent59, Me.linearScaleStateIndicatorComponent60})
            Me.linearGauge5.Name = "linearGauge5"
            Me.linearGauge5.Orientation = DevExpress.XtraGauges.Core.Model.ScaleOrientation.Horizontal
            Me.linearGauge5.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent17})
            ' 
            ' linearScaleBackgroundLayerComponent3
            ' 
            Me.linearScaleBackgroundLayerComponent3.LinearScale = Me.linearScaleComponent17
            Me.linearScaleBackgroundLayerComponent3.Name = "bg1"
            Me.linearScaleBackgroundLayerComponent3.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.1F)
            Me.linearScaleBackgroundLayerComponent3.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.9F)
            Me.linearScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style10
            Me.linearScaleBackgroundLayerComponent3.ZOrder = 1000
            ' 
            ' linearScaleComponent17
            ' 
            Me.linearScaleComponent17.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent17.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent17.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent17.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent17.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent17.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 225F)
            scaleLabel2.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            scaleLabel2.FormatString = "{0} {2:P0}"
            scaleLabel2.Name = "Label0"
            scaleLabel2.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(25F, 60F)
            scaleLabel2.Size = New System.Drawing.SizeF(150F, 30F)
            scaleLabel2.Text = "Level:"
            scaleLabel2.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop
            Me.linearScaleComponent17.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {scaleLabel2})
            Me.linearScaleComponent17.MajorTickCount = 2
            Me.linearScaleComponent17.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent17.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent17.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScaleComponent17.MajorTickmark.ShowText = False
            Me.linearScaleComponent17.MajorTickmark.ShowTick = False
            Me.linearScaleComponent17.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent17.MaxValue = 100F
            Me.linearScaleComponent17.MinorTickCount = 0
            Me.linearScaleComponent17.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent17.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScaleComponent17.MinorTickmark.ShowTick = False
            Me.linearScaleComponent17.Name = "scale1"
            Me.linearScaleComponent17.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 25F)
            Me.linearScaleComponent17.Value = 95F
            ' 
            ' linearScaleStateIndicatorComponent36
            ' 
            Me.linearScaleStateIndicatorComponent36.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(98.5F, 225F)
            Me.linearScaleStateIndicatorComponent36.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent36.Name = "Indicator0"
            Me.linearScaleStateIndicatorComponent36.Size = New System.Drawing.SizeF(12F, 5.865103F)
            scaleIndicatorState31.IntervalLength = 100F
            scaleIndicatorState31.Name = "Colored"
            scaleIndicatorState31.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer2
            scaleIndicatorState31.StartValue = 0.01F
            scaleIndicatorState32.IntervalLength = 0F
            scaleIndicatorState32.Name = "Empty"
            scaleIndicatorState32.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent36.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState31, scaleIndicatorState32})
            Me.linearScaleStateIndicatorComponent36.ZOrder = 100
            ' 
            ' linearScaleStateIndicatorComponent37
            ' 
            Me.linearScaleStateIndicatorComponent37.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(96.70569F, 216.6667F)
            Me.linearScaleStateIndicatorComponent37.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent37.Name = "Indicator1"
            Me.linearScaleStateIndicatorComponent37.Size = New System.Drawing.SizeF(14.36786F, 5.865103F)
            scaleIndicatorState33.IntervalLength = 96F
            scaleIndicatorState33.Name = "Colored"
            scaleIndicatorState33.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer2
            scaleIndicatorState33.StartValue = 4F
            scaleIndicatorState34.IntervalLength = 4F
            scaleIndicatorState34.Name = "Empty"
            scaleIndicatorState34.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent37.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState33, scaleIndicatorState34})
            Me.linearScaleStateIndicatorComponent37.ZOrder = 99
            ' 
            ' linearScaleStateIndicatorComponent38
            ' 
            Me.linearScaleStateIndicatorComponent38.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(93.85922F, 208.3333F)
            Me.linearScaleStateIndicatorComponent38.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent38.Name = "Indicator2"
            Me.linearScaleStateIndicatorComponent38.Size = New System.Drawing.SizeF(18.09888F, 5.865103F)
            scaleIndicatorState35.IntervalLength = 92F
            scaleIndicatorState35.Name = "Colored"
            scaleIndicatorState35.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer2
            scaleIndicatorState35.StartValue = 8F
            scaleIndicatorState36.IntervalLength = 8F
            scaleIndicatorState36.Name = "Empty"
            scaleIndicatorState36.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent38.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState35, scaleIndicatorState36})
            Me.linearScaleStateIndicatorComponent38.ZOrder = 98
            ' 
            ' linearScaleStateIndicatorComponent39
            ' 
            Me.linearScaleStateIndicatorComponent39.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(90.21272F, 200F)
            Me.linearScaleStateIndicatorComponent39.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent39.Name = "Indicator3"
            Me.linearScaleStateIndicatorComponent39.Size = New System.Drawing.SizeF(22.87111F, 5.865103F)
            scaleIndicatorState37.IntervalLength = 88F
            scaleIndicatorState37.Name = "Colored"
            scaleIndicatorState37.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer2
            scaleIndicatorState37.StartValue = 12F
            scaleIndicatorState38.IntervalLength = 12F
            scaleIndicatorState38.Name = "Empty"
            scaleIndicatorState38.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent39.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState37, scaleIndicatorState38})
            Me.linearScaleStateIndicatorComponent39.ZOrder = 97
            ' 
            ' linearScaleStateIndicatorComponent40
            ' 
            Me.linearScaleStateIndicatorComponent40.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(86.01827F, 191.6667F)
            Me.linearScaleStateIndicatorComponent40.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent40.Name = "Indicator4"
            Me.linearScaleStateIndicatorComponent40.Size = New System.Drawing.SizeF(28.36261F, 5.865103F)
            scaleIndicatorState39.IntervalLength = 84F
            scaleIndicatorState39.Name = "Colored"
            scaleIndicatorState39.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer2
            scaleIndicatorState39.StartValue = 16F
            scaleIndicatorState40.IntervalLength = 16F
            scaleIndicatorState40.Name = "Empty"
            scaleIndicatorState40.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent40.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState39, scaleIndicatorState40})
            Me.linearScaleStateIndicatorComponent40.ZOrder = 96
            ' 
            ' linearScaleStateIndicatorComponent41
            ' 
            Me.linearScaleStateIndicatorComponent41.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(81.52798F, 183.3333F)
            Me.linearScaleStateIndicatorComponent41.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent41.Name = "Indicator5"
            Me.linearScaleStateIndicatorComponent41.Size = New System.Drawing.SizeF(34.25138F, 5.865103F)
            scaleIndicatorState41.IntervalLength = 80F
            scaleIndicatorState41.Name = "Colored"
            scaleIndicatorState41.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer2
            scaleIndicatorState41.StartValue = 20F
            scaleIndicatorState42.IntervalLength = 20F
            scaleIndicatorState42.Name = "Empty"
            scaleIndicatorState42.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent41.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState41, scaleIndicatorState42})
            Me.linearScaleStateIndicatorComponent41.ZOrder = 95
            ' 
            ' linearScaleStateIndicatorComponent42
            ' 
            Me.linearScaleStateIndicatorComponent42.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(76.99394F, 175F)
            Me.linearScaleStateIndicatorComponent42.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent42.Name = "Indicator6"
            Me.linearScaleStateIndicatorComponent42.Size = New System.Drawing.SizeF(40.21549F, 5.865103F)
            scaleIndicatorState43.IntervalLength = 76F
            scaleIndicatorState43.Name = "Colored"
            scaleIndicatorState43.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer2
            scaleIndicatorState43.StartValue = 24F
            scaleIndicatorState44.IntervalLength = 24F
            scaleIndicatorState44.Name = "Empty"
            scaleIndicatorState44.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent42.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState43, scaleIndicatorState44})
            Me.linearScaleStateIndicatorComponent42.ZOrder = 94
            ' 
            ' linearScaleStateIndicatorComponent43
            ' 
            Me.linearScaleStateIndicatorComponent43.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(72.66829F, 166.6667F)
            Me.linearScaleStateIndicatorComponent43.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent43.Name = "Indicator7"
            Me.linearScaleStateIndicatorComponent43.Size = New System.Drawing.SizeF(45.93295F, 5.865103F)
            scaleIndicatorState45.IntervalLength = 72F
            scaleIndicatorState45.Name = "Colored"
            scaleIndicatorState45.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer3
            scaleIndicatorState45.StartValue = 28F
            scaleIndicatorState46.IntervalLength = 28F
            scaleIndicatorState46.Name = "Empty"
            scaleIndicatorState46.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent43.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState45, scaleIndicatorState46})
            Me.linearScaleStateIndicatorComponent43.ZOrder = 93
            ' 
            ' linearScaleStateIndicatorComponent44
            ' 
            Me.linearScaleStateIndicatorComponent44.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(68.80309F, 158.3333F)
            Me.linearScaleStateIndicatorComponent44.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent44.Name = "Indicator8"
            Me.linearScaleStateIndicatorComponent44.Size = New System.Drawing.SizeF(51.08183F, 5.865103F)
            scaleIndicatorState47.IntervalLength = 68F
            scaleIndicatorState47.Name = "Colored"
            scaleIndicatorState47.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer3
            scaleIndicatorState47.StartValue = 32F
            scaleIndicatorState48.IntervalLength = 32F
            scaleIndicatorState48.Name = "Empty"
            scaleIndicatorState48.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent44.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState47, scaleIndicatorState48})
            Me.linearScaleStateIndicatorComponent44.ZOrder = 92
            ' 
            ' linearScaleStateIndicatorComponent45
            ' 
            Me.linearScaleStateIndicatorComponent45.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(65.65045F, 150F)
            Me.linearScaleStateIndicatorComponent45.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent45.Name = "Indicator9"
            Me.linearScaleStateIndicatorComponent45.Size = New System.Drawing.SizeF(55.34014F, 5.865103F)
            scaleIndicatorState49.IntervalLength = 64F
            scaleIndicatorState49.Name = "Colored"
            scaleIndicatorState49.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer3
            scaleIndicatorState49.StartValue = 36F
            scaleIndicatorState50.IntervalLength = 36F
            scaleIndicatorState50.Name = "Empty"
            scaleIndicatorState50.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent45.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState49, scaleIndicatorState50})
            Me.linearScaleStateIndicatorComponent45.ZOrder = 91
            ' 
            ' linearScaleStateIndicatorComponent46
            ' 
            Me.linearScaleStateIndicatorComponent46.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(63.46249F, 141.6667F)
            Me.linearScaleStateIndicatorComponent46.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent46.Name = "Indicator10"
            Me.linearScaleStateIndicatorComponent46.Size = New System.Drawing.SizeF(58.38594F, 5.865103F)
            scaleIndicatorState51.IntervalLength = 60F
            scaleIndicatorState51.Name = "Colored"
            scaleIndicatorState51.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer3
            scaleIndicatorState51.StartValue = 40F
            scaleIndicatorState52.IntervalLength = 40F
            scaleIndicatorState52.Name = "Empty"
            scaleIndicatorState52.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent46.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState51, scaleIndicatorState52})
            Me.linearScaleStateIndicatorComponent46.ZOrder = 90
            ' 
            ' linearScaleStateIndicatorComponent47
            ' 
            Me.linearScaleStateIndicatorComponent47.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.49131F, 133.3333F)
            Me.linearScaleStateIndicatorComponent47.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent47.Name = "Indicator11"
            Me.linearScaleStateIndicatorComponent47.Size = New System.Drawing.SizeF(59.89725F, 5.865103F)
            scaleIndicatorState53.IntervalLength = 56F
            scaleIndicatorState53.Name = "Colored"
            scaleIndicatorState53.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer3
            scaleIndicatorState53.StartValue = 44F
            scaleIndicatorState54.IntervalLength = 44F
            scaleIndicatorState54.Name = "Empty"
            scaleIndicatorState54.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent47.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState53, scaleIndicatorState54})
            Me.linearScaleStateIndicatorComponent47.ZOrder = 89
            ' 
            ' linearScaleStateIndicatorComponent48
            ' 
            Me.linearScaleStateIndicatorComponent48.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.9277F, 125F)
            Me.linearScaleStateIndicatorComponent48.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent48.Name = "Indicator12"
            Me.linearScaleStateIndicatorComponent48.Size = New System.Drawing.SizeF(59.63482F, 5.865103F)
            scaleIndicatorState55.IntervalLength = 52F
            scaleIndicatorState55.Name = "Colored"
            scaleIndicatorState55.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer3
            scaleIndicatorState55.StartValue = 48F
            scaleIndicatorState56.IntervalLength = 48F
            scaleIndicatorState56.Name = "Empty"
            scaleIndicatorState56.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent48.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState55, scaleIndicatorState56})
            Me.linearScaleStateIndicatorComponent48.ZOrder = 88
            ' 
            ' linearScaleStateIndicatorComponent49
            ' 
            Me.linearScaleStateIndicatorComponent49.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(64.65696F, 116.6667F)
            Me.linearScaleStateIndicatorComponent49.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent49.Name = "Indicator13"
            Me.linearScaleStateIndicatorComponent49.Size = New System.Drawing.SizeF(57.82679F, 5.865103F)
            scaleIndicatorState57.IntervalLength = 48F
            scaleIndicatorState57.Name = "Colored"
            scaleIndicatorState57.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer3
            scaleIndicatorState57.StartValue = 52F
            scaleIndicatorState58.IntervalLength = 52F
            scaleIndicatorState58.Name = "Empty"
            scaleIndicatorState58.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent49.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState57, scaleIndicatorState58})
            Me.linearScaleStateIndicatorComponent49.ZOrder = 87
            ' 
            ' linearScaleStateIndicatorComponent50
            ' 
            Me.linearScaleStateIndicatorComponent50.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(67.47216F, 108.3333F)
            Me.linearScaleStateIndicatorComponent50.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent50.Name = "Indicator14"
            Me.linearScaleStateIndicatorComponent50.Size = New System.Drawing.SizeF(54.73531F, 5.865103F)
            scaleIndicatorState59.IntervalLength = 44F
            scaleIndicatorState59.Name = "Colored"
            scaleIndicatorState59.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer4
            scaleIndicatorState59.StartValue = 56F
            scaleIndicatorState60.IntervalLength = 56F
            scaleIndicatorState60.Name = "Empty"
            scaleIndicatorState60.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent50.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState59, scaleIndicatorState60})
            Me.linearScaleStateIndicatorComponent50.ZOrder = 86
            ' 
            ' linearScaleStateIndicatorComponent51
            ' 
            Me.linearScaleStateIndicatorComponent51.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(71.16035F, 100F)
            Me.linearScaleStateIndicatorComponent51.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent51.Name = "Indicator15"
            Me.linearScaleStateIndicatorComponent51.Size = New System.Drawing.SizeF(50.60934F, 5.865103F)
            scaleIndicatorState61.IntervalLength = 40F
            scaleIndicatorState61.Name = "Colored"
            scaleIndicatorState61.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer4
            scaleIndicatorState61.StartValue = 60F
            scaleIndicatorState62.IntervalLength = 60F
            scaleIndicatorState62.Name = "Empty"
            scaleIndicatorState62.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent51.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState61, scaleIndicatorState62})
            Me.linearScaleStateIndicatorComponent51.ZOrder = 85
            ' 
            ' linearScaleStateIndicatorComponent52
            ' 
            Me.linearScaleStateIndicatorComponent52.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75.50856F, 91.66667F)
            Me.linearScaleStateIndicatorComponent52.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent52.Name = "Indicator16"
            Me.linearScaleStateIndicatorComponent52.Size = New System.Drawing.SizeF(45.69779F, 5.865103F)
            scaleIndicatorState63.IntervalLength = 36F
            scaleIndicatorState63.Name = "Colored"
            scaleIndicatorState63.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer4
            scaleIndicatorState63.StartValue = 64F
            scaleIndicatorState64.IntervalLength = 64F
            scaleIndicatorState64.Name = "Empty"
            scaleIndicatorState64.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent52.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState63, scaleIndicatorState64})
            Me.linearScaleStateIndicatorComponent52.ZOrder = 84
            ' 
            ' linearScaleStateIndicatorComponent53
            ' 
            Me.linearScaleStateIndicatorComponent53.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(80.30384F, 83.33333F)
            Me.linearScaleStateIndicatorComponent53.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent53.Name = "Indicator17"
            Me.linearScaleStateIndicatorComponent53.Size = New System.Drawing.SizeF(40.24965F, 5.865103F)
            scaleIndicatorState65.IntervalLength = 32F
            scaleIndicatorState65.Name = "Colored"
            scaleIndicatorState65.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer4
            scaleIndicatorState65.StartValue = 68F
            scaleIndicatorState66.IntervalLength = 68F
            scaleIndicatorState66.Name = "Empty"
            scaleIndicatorState66.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent53.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState65, scaleIndicatorState66})
            Me.linearScaleStateIndicatorComponent53.ZOrder = 83
            ' 
            ' linearScaleStateIndicatorComponent54
            ' 
            Me.linearScaleStateIndicatorComponent54.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(85.33323F, 75F)
            Me.linearScaleStateIndicatorComponent54.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent54.Name = "Indicator18"
            Me.linearScaleStateIndicatorComponent54.Size = New System.Drawing.SizeF(34.51389F, 5.865103F)
            scaleIndicatorState67.IntervalLength = 28F
            scaleIndicatorState67.Name = "Colored"
            scaleIndicatorState67.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer4
            scaleIndicatorState67.StartValue = 72F
            scaleIndicatorState68.IntervalLength = 72F
            scaleIndicatorState68.Name = "Empty"
            scaleIndicatorState68.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent54.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState67, scaleIndicatorState68})
            Me.linearScaleStateIndicatorComponent54.ZOrder = 82
            ' 
            ' linearScaleStateIndicatorComponent55
            ' 
            Me.linearScaleStateIndicatorComponent55.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(90.38376F, 66.66666F)
            Me.linearScaleStateIndicatorComponent55.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent55.Name = "Indicator19"
            Me.linearScaleStateIndicatorComponent55.Size = New System.Drawing.SizeF(28.73941F, 5.865103F)
            scaleIndicatorState69.IntervalLength = 24F
            scaleIndicatorState69.Name = "Colored"
            scaleIndicatorState69.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer4
            scaleIndicatorState69.StartValue = 76F
            scaleIndicatorState70.IntervalLength = 76F
            scaleIndicatorState70.Name = "Empty"
            scaleIndicatorState70.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent55.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState69, scaleIndicatorState70})
            Me.linearScaleStateIndicatorComponent55.ZOrder = 81
            ' 
            ' linearScaleStateIndicatorComponent56
            ' 
            Me.linearScaleStateIndicatorComponent56.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(95.24248F, 58.33334F)
            Me.linearScaleStateIndicatorComponent56.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent56.Name = "Indicator20"
            Me.linearScaleStateIndicatorComponent56.Size = New System.Drawing.SizeF(23.17519F, 5.865103F)
            scaleIndicatorState71.IntervalLength = 20F
            scaleIndicatorState71.Name = "Colored"
            scaleIndicatorState71.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer4
            scaleIndicatorState71.StartValue = 80F
            scaleIndicatorState72.IntervalLength = 80F
            scaleIndicatorState72.Name = "Empty"
            scaleIndicatorState72.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent56.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState71, scaleIndicatorState72})
            Me.linearScaleStateIndicatorComponent56.ZOrder = 80
            ' 
            ' linearScaleStateIndicatorComponent57
            ' 
            Me.linearScaleStateIndicatorComponent57.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(99.69641F, 50F)
            Me.linearScaleStateIndicatorComponent57.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent57.Name = "Indicator21"
            Me.linearScaleStateIndicatorComponent57.Size = New System.Drawing.SizeF(18.07019F, 5.865103F)
            scaleIndicatorState73.IntervalLength = 16F
            scaleIndicatorState73.Name = "Colored"
            scaleIndicatorState73.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer4
            scaleIndicatorState73.StartValue = 84F
            scaleIndicatorState74.IntervalLength = 84F
            scaleIndicatorState74.Name = "Empty"
            scaleIndicatorState74.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent57.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState73, scaleIndicatorState74})
            Me.linearScaleStateIndicatorComponent57.ZOrder = 79
            ' 
            ' linearScaleStateIndicatorComponent58
            ' 
            Me.linearScaleStateIndicatorComponent58.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(103.5326F, 41.66667F)
            Me.linearScaleStateIndicatorComponent58.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent58.Name = "Indicator22"
            Me.linearScaleStateIndicatorComponent58.Size = New System.Drawing.SizeF(13.67336F, 5.865103F)
            scaleIndicatorState75.IntervalLength = 12F
            scaleIndicatorState75.Name = "Colored"
            scaleIndicatorState75.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer4
            scaleIndicatorState75.StartValue = 88F
            scaleIndicatorState76.IntervalLength = 88F
            scaleIndicatorState76.Name = "Empty"
            scaleIndicatorState76.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent58.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState75, scaleIndicatorState76})
            Me.linearScaleStateIndicatorComponent58.ZOrder = 78
            ' 
            ' linearScaleStateIndicatorComponent59
            ' 
            Me.linearScaleStateIndicatorComponent59.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(106.5381F, 33.33334F)
            Me.linearScaleStateIndicatorComponent59.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent59.Name = "Indicator23"
            Me.linearScaleStateIndicatorComponent59.Size = New System.Drawing.SizeF(10.23363F, 5.865103F)
            scaleIndicatorState77.IntervalLength = 7.999998F
            scaleIndicatorState77.Name = "Colored"
            scaleIndicatorState77.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer4
            scaleIndicatorState77.StartValue = 92F
            scaleIndicatorState78.IntervalLength = 92F
            scaleIndicatorState78.Name = "Empty"
            scaleIndicatorState78.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent59.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState77, scaleIndicatorState78})
            Me.linearScaleStateIndicatorComponent59.ZOrder = 77
            ' 
            ' linearScaleStateIndicatorComponent60
            ' 
            Me.linearScaleStateIndicatorComponent60.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(108.5F, 25F)
            Me.linearScaleStateIndicatorComponent60.IndicatorScale = Me.linearScaleComponent17
            Me.linearScaleStateIndicatorComponent60.Name = "Indicator24"
            Me.linearScaleStateIndicatorComponent60.Size = New System.Drawing.SizeF(7.999997F, 5.865103F)
            scaleIndicatorState79.IntervalLength = 4.000002F
            scaleIndicatorState79.Name = "Colored"
            scaleIndicatorState79.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer4
            scaleIndicatorState79.StartValue = 96F
            scaleIndicatorState80.IntervalLength = 96F
            scaleIndicatorState80.Name = "Empty"
            scaleIndicatorState80.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Equalizer0
            Me.linearScaleStateIndicatorComponent60.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState79, scaleIndicatorState80})
            Me.linearScaleStateIndicatorComponent60.ZOrder = 76
            ' 
            ' progress2
            ' 
            Me.progress2.BackColor = System.Drawing.Color.Transparent
            Me.progress2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.progress2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge7})
            Me.progress2.Location = New System.Drawing.Point(365, 93)
            Me.progress2.MaximumSize = New System.Drawing.Size(150, 300)
            Me.progress2.MinimumSize = New System.Drawing.Size(150, 300)
            Me.progress2.Name = "progress2"
            Me.progress2.Size = New System.Drawing.Size(150, 300)
            Me.progress2.TabIndex = 10
            ' 
            ' linearGauge7
            ' 
            Me.linearGauge7.Bounds = New System.Drawing.Rectangle(6, 6, 138, 288)
            Me.linearGauge7.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent() {Me.linearScaleStateIndicatorComponent71, Me.linearScaleStateIndicatorComponent72, Me.linearScaleStateIndicatorComponent73, Me.linearScaleStateIndicatorComponent74, Me.linearScaleStateIndicatorComponent75, Me.linearScaleStateIndicatorComponent76, Me.linearScaleStateIndicatorComponent77, Me.linearScaleStateIndicatorComponent78, Me.linearScaleStateIndicatorComponent79, Me.linearScaleStateIndicatorComponent80})
            Me.linearGauge7.Name = "linearGauge7"
            Me.linearGauge7.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent19})
            ' 
            ' linearScaleStateIndicatorComponent71
            ' 
            Me.linearScaleStateIndicatorComponent71.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(65F, 225F)
            Me.linearScaleStateIndicatorComponent71.IndicatorScale = Me.linearScaleComponent19
            Me.linearScaleStateIndicatorComponent71.Name = "Indicator0"
            Me.linearScaleStateIndicatorComponent71.Size = New System.Drawing.SizeF(15F, 22.22222F)
            scaleIndicatorState81.IntervalLength = 100F
            scaleIndicatorState81.Name = "Colored"
            scaleIndicatorState81.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem6
            scaleIndicatorState81.StartValue = 0.01F
            scaleIndicatorState82.IntervalLength = 0F
            scaleIndicatorState82.Name = "Empty"
            scaleIndicatorState82.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem7
            Me.linearScaleStateIndicatorComponent71.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState81, scaleIndicatorState82})
            Me.linearScaleStateIndicatorComponent71.ZOrder = 100
            ' 
            ' linearScaleComponent19
            ' 
            Me.linearScaleComponent19.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent19.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent19.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent19.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent19.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent19.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 225F)
            Me.linearScaleComponent19.MajorTickCount = 2
            Me.linearScaleComponent19.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent19.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent19.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScaleComponent19.MajorTickmark.ShowText = False
            Me.linearScaleComponent19.MajorTickmark.ShowTick = False
            Me.linearScaleComponent19.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent19.MaxValue = 100F
            Me.linearScaleComponent19.MinorTickCount = 0
            Me.linearScaleComponent19.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent19.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScaleComponent19.MinorTickmark.ShowTick = False
            Me.linearScaleComponent19.Name = "scale1"
            Me.linearScaleComponent19.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 25F)
            Me.linearScaleComponent19.Value = 42F
            ' 
            ' linearScaleStateIndicatorComponent72
            ' 
            Me.linearScaleStateIndicatorComponent72.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(64.55847F, 202.7778F)
            Me.linearScaleStateIndicatorComponent72.IndicatorScale = Me.linearScaleComponent19
            Me.linearScaleStateIndicatorComponent72.Name = "Indicator1"
            Me.linearScaleStateIndicatorComponent72.Size = New System.Drawing.SizeF(22.94753F, 22.22222F)
            scaleIndicatorState83.IntervalLength = 90F
            scaleIndicatorState83.Name = "Colored"
            scaleIndicatorState83.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem6
            scaleIndicatorState83.StartValue = 10F
            scaleIndicatorState84.IntervalLength = 10F
            scaleIndicatorState84.Name = "Empty"
            scaleIndicatorState84.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem7
            Me.linearScaleStateIndicatorComponent72.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState83, scaleIndicatorState84})
            Me.linearScaleStateIndicatorComponent72.ZOrder = 99
            ' 
            ' linearScaleStateIndicatorComponent73
            ' 
            Me.linearScaleStateIndicatorComponent73.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(63.82887F, 180.5556F)
            Me.linearScaleStateIndicatorComponent73.IndicatorScale = Me.linearScaleComponent19
            Me.linearScaleStateIndicatorComponent73.Name = "Indicator2"
            Me.linearScaleStateIndicatorComponent73.Size = New System.Drawing.SizeF(36.08025F, 22.22222F)
            scaleIndicatorState85.IntervalLength = 80F
            scaleIndicatorState85.Name = "Colored"
            scaleIndicatorState85.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem6
            scaleIndicatorState85.StartValue = 20F
            scaleIndicatorState86.IntervalLength = 20F
            scaleIndicatorState86.Name = "Empty"
            scaleIndicatorState86.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem7
            Me.linearScaleStateIndicatorComponent73.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState85, scaleIndicatorState86})
            Me.linearScaleStateIndicatorComponent73.ZOrder = 98
            ' 
            ' linearScaleStateIndicatorComponent74
            ' 
            Me.linearScaleStateIndicatorComponent74.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(63.07871F, 158.3333F)
            Me.linearScaleStateIndicatorComponent74.IndicatorScale = Me.linearScaleComponent19
            Me.linearScaleStateIndicatorComponent74.Name = "Indicator3"
            Me.linearScaleStateIndicatorComponent74.Size = New System.Drawing.SizeF(49.58334F, 22.22222F)
            scaleIndicatorState87.IntervalLength = 70F
            scaleIndicatorState87.Name = "Colored"
            scaleIndicatorState87.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem6
            scaleIndicatorState87.StartValue = 30F
            scaleIndicatorState88.IntervalLength = 30F
            scaleIndicatorState88.Name = "Empty"
            scaleIndicatorState88.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem7
            Me.linearScaleStateIndicatorComponent74.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState87, scaleIndicatorState88})
            Me.linearScaleStateIndicatorComponent74.ZOrder = 97
            ' 
            ' linearScaleStateIndicatorComponent75
            ' 
            Me.linearScaleStateIndicatorComponent75.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.57545F, 136.1111F)
            Me.linearScaleStateIndicatorComponent75.IndicatorScale = Me.linearScaleComponent19
            Me.linearScaleStateIndicatorComponent75.Name = "Indicator4"
            Me.linearScaleStateIndicatorComponent75.Size = New System.Drawing.SizeF(58.64198F, 22.22222F)
            scaleIndicatorState89.IntervalLength = 60F
            scaleIndicatorState89.Name = "Colored"
            scaleIndicatorState89.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem6
            scaleIndicatorState89.StartValue = 40F
            scaleIndicatorState90.IntervalLength = 40F
            scaleIndicatorState90.Name = "Empty"
            scaleIndicatorState90.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem7
            Me.linearScaleStateIndicatorComponent75.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState89, scaleIndicatorState90})
            Me.linearScaleStateIndicatorComponent75.ZOrder = 96
            ' 
            ' linearScaleStateIndicatorComponent76
            ' 
            Me.linearScaleStateIndicatorComponent76.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.57545F, 113.8889F)
            Me.linearScaleStateIndicatorComponent76.IndicatorScale = Me.linearScaleComponent19
            Me.linearScaleStateIndicatorComponent76.Name = "Indicator5"
            Me.linearScaleStateIndicatorComponent76.Size = New System.Drawing.SizeF(58.64198F, 22.22222F)
            scaleIndicatorState91.IntervalLength = 50F
            scaleIndicatorState91.Name = "Colored"
            scaleIndicatorState91.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem6
            scaleIndicatorState91.StartValue = 50F
            scaleIndicatorState92.IntervalLength = 50F
            scaleIndicatorState92.Name = "Empty"
            scaleIndicatorState92.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem7
            Me.linearScaleStateIndicatorComponent76.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState91, scaleIndicatorState92})
            Me.linearScaleStateIndicatorComponent76.ZOrder = 95
            ' 
            ' linearScaleStateIndicatorComponent77
            ' 
            Me.linearScaleStateIndicatorComponent77.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(63.07871F, 91.66667F)
            Me.linearScaleStateIndicatorComponent77.IndicatorScale = Me.linearScaleComponent19
            Me.linearScaleStateIndicatorComponent77.Name = "Indicator6"
            Me.linearScaleStateIndicatorComponent77.Size = New System.Drawing.SizeF(49.58334F, 22.22222F)
            scaleIndicatorState93.IntervalLength = 40F
            scaleIndicatorState93.Name = "Colored"
            scaleIndicatorState93.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem6
            scaleIndicatorState93.StartValue = 60F
            scaleIndicatorState94.IntervalLength = 60F
            scaleIndicatorState94.Name = "Empty"
            scaleIndicatorState94.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem7
            Me.linearScaleStateIndicatorComponent77.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState93, scaleIndicatorState94})
            Me.linearScaleStateIndicatorComponent77.ZOrder = 94
            ' 
            ' linearScaleStateIndicatorComponent78
            ' 
            Me.linearScaleStateIndicatorComponent78.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(63.82887F, 69.44446F)
            Me.linearScaleStateIndicatorComponent78.IndicatorScale = Me.linearScaleComponent19
            Me.linearScaleStateIndicatorComponent78.Name = "Indicator7"
            Me.linearScaleStateIndicatorComponent78.Size = New System.Drawing.SizeF(36.08025F, 22.22222F)
            scaleIndicatorState95.IntervalLength = 30F
            scaleIndicatorState95.Name = "Colored"
            scaleIndicatorState95.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem6
            scaleIndicatorState95.StartValue = 70F
            scaleIndicatorState96.IntervalLength = 70F
            scaleIndicatorState96.Name = "Empty"
            scaleIndicatorState96.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem7
            Me.linearScaleStateIndicatorComponent78.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState95, scaleIndicatorState96})
            Me.linearScaleStateIndicatorComponent78.ZOrder = 93
            ' 
            ' linearScaleStateIndicatorComponent79
            ' 
            Me.linearScaleStateIndicatorComponent79.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(64.55847F, 47.22224F)
            Me.linearScaleStateIndicatorComponent79.IndicatorScale = Me.linearScaleComponent19
            Me.linearScaleStateIndicatorComponent79.Name = "Indicator8"
            Me.linearScaleStateIndicatorComponent79.Size = New System.Drawing.SizeF(22.94754F, 22.22222F)
            scaleIndicatorState97.IntervalLength = 20F
            scaleIndicatorState97.Name = "Colored"
            scaleIndicatorState97.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem6
            scaleIndicatorState97.StartValue = 80F
            scaleIndicatorState98.IntervalLength = 80F
            scaleIndicatorState98.Name = "Empty"
            scaleIndicatorState98.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem7
            Me.linearScaleStateIndicatorComponent79.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState97, scaleIndicatorState98})
            Me.linearScaleStateIndicatorComponent79.ZOrder = 92
            ' 
            ' linearScaleStateIndicatorComponent80
            ' 
            Me.linearScaleStateIndicatorComponent80.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(65F, 25F)
            Me.linearScaleStateIndicatorComponent80.IndicatorScale = Me.linearScaleComponent19
            Me.linearScaleStateIndicatorComponent80.Name = "Indicator9"
            Me.linearScaleStateIndicatorComponent80.Size = New System.Drawing.SizeF(15F, 22.22222F)
            scaleIndicatorState99.IntervalLength = 10F
            scaleIndicatorState99.Name = "Colored"
            scaleIndicatorState99.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem6
            scaleIndicatorState99.StartValue = 90F
            scaleIndicatorState100.IntervalLength = 90F
            scaleIndicatorState100.Name = "Empty"
            scaleIndicatorState100.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem7
            Me.linearScaleStateIndicatorComponent80.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState99, scaleIndicatorState100})
            Me.linearScaleStateIndicatorComponent80.ZOrder = 91
            ' 
            ' progress1
            ' 
            Me.progress1.BackColor = System.Drawing.Color.Transparent
            Me.progress1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.progress1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge6})
            Me.progress1.Location = New System.Drawing.Point(211, 93)
            Me.progress1.MaximumSize = New System.Drawing.Size(150, 300)
            Me.progress1.MinimumSize = New System.Drawing.Size(150, 300)
            Me.progress1.Name = "progress1"
            Me.progress1.Size = New System.Drawing.Size(150, 300)
            Me.progress1.TabIndex = 9
            ' 
            ' linearGauge6
            ' 
            Me.linearGauge6.Bounds = New System.Drawing.Rectangle(6, 6, 138, 288)
            Me.linearGauge6.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent() {Me.linearScaleStateIndicatorComponent61, Me.linearScaleStateIndicatorComponent62, Me.linearScaleStateIndicatorComponent63, Me.linearScaleStateIndicatorComponent64, Me.linearScaleStateIndicatorComponent65, Me.linearScaleStateIndicatorComponent66, Me.linearScaleStateIndicatorComponent67, Me.linearScaleStateIndicatorComponent68, Me.linearScaleStateIndicatorComponent69, Me.linearScaleStateIndicatorComponent70})
            Me.linearGauge6.Name = "linearGauge6"
            Me.linearGauge6.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent18})
            ' 
            ' linearScaleStateIndicatorComponent61
            ' 
            Me.linearScaleStateIndicatorComponent61.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 225F)
            Me.linearScaleStateIndicatorComponent61.IndicatorScale = Me.linearScaleComponent18
            Me.linearScaleStateIndicatorComponent61.Name = "Indicator0"
            Me.linearScaleStateIndicatorComponent61.Size = New System.Drawing.SizeF(21.22528F, 21.22528F)
            scaleIndicatorState101.IntervalLength = 100F
            scaleIndicatorState101.Name = "Colored"
            scaleIndicatorState101.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            scaleIndicatorState101.StartValue = 0.01F
            scaleIndicatorState102.IntervalLength = 0F
            scaleIndicatorState102.Name = "Empty"
            scaleIndicatorState102.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent61.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState101, scaleIndicatorState102})
            Me.linearScaleStateIndicatorComponent61.ZOrder = 100
            ' 
            ' linearScaleComponent18
            ' 
            Me.linearScaleComponent18.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent18.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent18.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent18.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent18.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent18.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 225F)
            Me.linearScaleComponent18.MajorTickCount = 2
            Me.linearScaleComponent18.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent18.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent18.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScaleComponent18.MajorTickmark.ShowText = False
            Me.linearScaleComponent18.MajorTickmark.ShowTick = False
            Me.linearScaleComponent18.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent18.MaxValue = 100F
            Me.linearScaleComponent18.MinorTickCount = 0
            Me.linearScaleComponent18.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent18.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScaleComponent18.MinorTickmark.ShowTick = False
            Me.linearScaleComponent18.Name = "scale"
            Me.linearScaleComponent18.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 25F)
            Me.linearScaleComponent18.Value = 35F
            ' 
            ' linearScaleStateIndicatorComponent62
            ' 
            Me.linearScaleStateIndicatorComponent62.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 202.7778F)
            Me.linearScaleStateIndicatorComponent62.IndicatorScale = Me.linearScaleComponent18
            Me.linearScaleStateIndicatorComponent62.Name = "Indicator1"
            Me.linearScaleStateIndicatorComponent62.Size = New System.Drawing.SizeF(21.22528F, 21.22528F)
            scaleIndicatorState103.IntervalLength = 90F
            scaleIndicatorState103.Name = "Colored"
            scaleIndicatorState103.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            scaleIndicatorState103.StartValue = 10F
            scaleIndicatorState104.IntervalLength = 10F
            scaleIndicatorState104.Name = "Empty"
            scaleIndicatorState104.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent62.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState103, scaleIndicatorState104})
            Me.linearScaleStateIndicatorComponent62.ZOrder = 99
            ' 
            ' linearScaleStateIndicatorComponent63
            ' 
            Me.linearScaleStateIndicatorComponent63.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 180.5556F)
            Me.linearScaleStateIndicatorComponent63.IndicatorScale = Me.linearScaleComponent18
            Me.linearScaleStateIndicatorComponent63.Name = "Indicator2"
            Me.linearScaleStateIndicatorComponent63.Size = New System.Drawing.SizeF(21.22528F, 21.22528F)
            scaleIndicatorState105.IntervalLength = 80F
            scaleIndicatorState105.Name = "Colored"
            scaleIndicatorState105.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            scaleIndicatorState105.StartValue = 20F
            scaleIndicatorState106.IntervalLength = 20F
            scaleIndicatorState106.Name = "Empty"
            scaleIndicatorState106.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent63.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState105, scaleIndicatorState106})
            Me.linearScaleStateIndicatorComponent63.ZOrder = 98
            ' 
            ' linearScaleStateIndicatorComponent64
            ' 
            Me.linearScaleStateIndicatorComponent64.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 158.3333F)
            Me.linearScaleStateIndicatorComponent64.IndicatorScale = Me.linearScaleComponent18
            Me.linearScaleStateIndicatorComponent64.Name = "Indicator3"
            Me.linearScaleStateIndicatorComponent64.Size = New System.Drawing.SizeF(21.22528F, 21.22528F)
            scaleIndicatorState107.IntervalLength = 70F
            scaleIndicatorState107.Name = "Colored"
            scaleIndicatorState107.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            scaleIndicatorState107.StartValue = 30F
            scaleIndicatorState108.IntervalLength = 30F
            scaleIndicatorState108.Name = "Empty"
            scaleIndicatorState108.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent64.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState107, scaleIndicatorState108})
            Me.linearScaleStateIndicatorComponent64.ZOrder = 97
            ' 
            ' linearScaleStateIndicatorComponent65
            ' 
            Me.linearScaleStateIndicatorComponent65.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 136.1111F)
            Me.linearScaleStateIndicatorComponent65.IndicatorScale = Me.linearScaleComponent18
            Me.linearScaleStateIndicatorComponent65.Name = "Indicator4"
            Me.linearScaleStateIndicatorComponent65.Size = New System.Drawing.SizeF(21.22528F, 21.22528F)
            scaleIndicatorState109.IntervalLength = 60F
            scaleIndicatorState109.Name = "Colored"
            scaleIndicatorState109.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            scaleIndicatorState109.StartValue = 40F
            scaleIndicatorState110.IntervalLength = 40F
            scaleIndicatorState110.Name = "Empty"
            scaleIndicatorState110.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent65.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState109, scaleIndicatorState110})
            Me.linearScaleStateIndicatorComponent65.ZOrder = 96
            ' 
            ' linearScaleStateIndicatorComponent66
            ' 
            Me.linearScaleStateIndicatorComponent66.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 113.8889F)
            Me.linearScaleStateIndicatorComponent66.IndicatorScale = Me.linearScaleComponent18
            Me.linearScaleStateIndicatorComponent66.Name = "Indicator5"
            Me.linearScaleStateIndicatorComponent66.Size = New System.Drawing.SizeF(21.22528F, 21.22528F)
            scaleIndicatorState111.IntervalLength = 50F
            scaleIndicatorState111.Name = "Colored"
            scaleIndicatorState111.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            scaleIndicatorState111.StartValue = 50F
            scaleIndicatorState112.IntervalLength = 50F
            scaleIndicatorState112.Name = "Empty"
            scaleIndicatorState112.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent66.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState111, scaleIndicatorState112})
            Me.linearScaleStateIndicatorComponent66.ZOrder = 95
            ' 
            ' linearScaleStateIndicatorComponent67
            ' 
            Me.linearScaleStateIndicatorComponent67.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 91.66667F)
            Me.linearScaleStateIndicatorComponent67.IndicatorScale = Me.linearScaleComponent18
            Me.linearScaleStateIndicatorComponent67.Name = "Indicator6"
            Me.linearScaleStateIndicatorComponent67.Size = New System.Drawing.SizeF(21.22528F, 21.22528F)
            scaleIndicatorState113.IntervalLength = 40F
            scaleIndicatorState113.Name = "Colored"
            scaleIndicatorState113.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            scaleIndicatorState113.StartValue = 60F
            scaleIndicatorState114.IntervalLength = 60F
            scaleIndicatorState114.Name = "Empty"
            scaleIndicatorState114.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent67.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState113, scaleIndicatorState114})
            Me.linearScaleStateIndicatorComponent67.ZOrder = 94
            ' 
            ' linearScaleStateIndicatorComponent68
            ' 
            Me.linearScaleStateIndicatorComponent68.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 69.44446F)
            Me.linearScaleStateIndicatorComponent68.IndicatorScale = Me.linearScaleComponent18
            Me.linearScaleStateIndicatorComponent68.Name = "Indicator7"
            Me.linearScaleStateIndicatorComponent68.Size = New System.Drawing.SizeF(21.22528F, 21.22528F)
            scaleIndicatorState115.IntervalLength = 30F
            scaleIndicatorState115.Name = "Colored"
            scaleIndicatorState115.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            scaleIndicatorState115.StartValue = 70F
            scaleIndicatorState116.IntervalLength = 70F
            scaleIndicatorState116.Name = "Empty"
            scaleIndicatorState116.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent68.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState115, scaleIndicatorState116})
            Me.linearScaleStateIndicatorComponent68.ZOrder = 93
            ' 
            ' linearScaleStateIndicatorComponent69
            ' 
            Me.linearScaleStateIndicatorComponent69.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 47.22224F)
            Me.linearScaleStateIndicatorComponent69.IndicatorScale = Me.linearScaleComponent18
            Me.linearScaleStateIndicatorComponent69.Name = "Indicator8"
            Me.linearScaleStateIndicatorComponent69.Size = New System.Drawing.SizeF(21.22528F, 21.22528F)
            scaleIndicatorState117.IntervalLength = 20F
            scaleIndicatorState117.Name = "Colored"
            scaleIndicatorState117.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            scaleIndicatorState117.StartValue = 80F
            scaleIndicatorState118.IntervalLength = 80F
            scaleIndicatorState118.Name = "Empty"
            scaleIndicatorState118.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent69.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState117, scaleIndicatorState118})
            Me.linearScaleStateIndicatorComponent69.ZOrder = 92
            ' 
            ' linearScaleStateIndicatorComponent70
            ' 
            Me.linearScaleStateIndicatorComponent70.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 25F)
            Me.linearScaleStateIndicatorComponent70.IndicatorScale = Me.linearScaleComponent18
            Me.linearScaleStateIndicatorComponent70.Name = "Indicator9"
            Me.linearScaleStateIndicatorComponent70.Size = New System.Drawing.SizeF(21.22528F, 21.22528F)
            scaleIndicatorState119.IntervalLength = 10F
            scaleIndicatorState119.Name = "Colored"
            scaleIndicatorState119.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            scaleIndicatorState119.StartValue = 90F
            scaleIndicatorState120.IntervalLength = 90F
            scaleIndicatorState120.Name = "Empty"
            scaleIndicatorState120.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent70.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState119, scaleIndicatorState120})
            Me.linearScaleStateIndicatorComponent70.ZOrder = 91
            ' 
            ' graph2
            ' 
            Me.graph2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge2})
            Me.graph2.Location = New System.Drawing.Point(378, 47)
            Me.graph2.MaximumSize = New System.Drawing.Size(350, 350)
            Me.graph2.MinimumSize = New System.Drawing.Size(350, 350)
            Me.graph2.Name = "graph2"
            Me.graph2.Size = New System.Drawing.Size(350, 350)
            Me.graph2.TabIndex = 4
            ' 
            ' linearGauge2
            ' 
            Me.linearGauge2.AutoSize = DevExpress.Utils.DefaultBoolean.[False]
            Me.linearGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 338, 338)
            Me.linearGauge2.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() {Me.labelComponent9, Me.labelComponent10, Me.labelComponent11, Me.labelComponent12, Me.labelComponent13, Me.labelComponent14})
            Me.linearGauge2.Markers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent() {Me.linearScaleMarkerComponent5, Me.linearScaleMarkerComponent6, Me.linearScaleMarkerComponent7})
            Me.linearGauge2.Name = "linearGauge2"
            Me.linearGauge2.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent() {Me.linearScaleRangeBarComponent5, Me.linearScaleRangeBarComponent6, Me.linearScaleRangeBarComponent7})
            Me.linearGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent9, Me.linearScaleComponent10, Me.linearScaleComponent11, Me.linearScaleComponent12, Me.linearScaleComponent13, Me.linearScaleComponent14})
            ' 
            ' labelComponent9
            ' 
            Me.labelComponent9.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.labelComponent9.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent9.Name = "titleRevenue"
            Me.labelComponent9.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(0F, 12F)
            Me.labelComponent9.Size = New System.Drawing.SizeF(65F, 15F)
            Me.labelComponent9.Text = "Revenue"
            Me.labelComponent9.ZOrder = -1001
            ' 
            ' labelComponent10
            ' 
            Me.labelComponent10.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.labelComponent10.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent10.Name = "unitRevenue"
            Me.labelComponent10.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(0F, 23F)
            Me.labelComponent10.Size = New System.Drawing.SizeF(65F, 12F)
            Me.labelComponent10.Text = "U.S. $(1,000$)"
            Me.labelComponent10.ZOrder = -1001
            ' 
            ' labelComponent11
            ' 
            Me.labelComponent11.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.labelComponent11.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent11.Name = "titleProfit"
            Me.labelComponent11.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 12F)
            Me.labelComponent11.Size = New System.Drawing.SizeF(65F, 15F)
            Me.labelComponent11.Text = "Profit"
            Me.labelComponent11.ZOrder = -1001
            ' 
            ' labelComponent12
            ' 
            Me.labelComponent12.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.labelComponent12.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent12.Name = "unitProfit"
            Me.labelComponent12.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 23F)
            Me.labelComponent12.Size = New System.Drawing.SizeF(65F, 12F)
            Me.labelComponent12.Text = "%"
            Me.labelComponent12.ZOrder = -1001
            ' 
            ' labelComponent13
            ' 
            Me.labelComponent13.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.labelComponent13.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent13.Name = "titleNewCust"
            Me.labelComponent13.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(150F, 12F)
            Me.labelComponent13.Size = New System.Drawing.SizeF(65F, 15F)
            Me.labelComponent13.Text = "New Cust"
            Me.labelComponent13.ZOrder = -1001
            ' 
            ' labelComponent14
            ' 
            Me.labelComponent14.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.labelComponent14.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent14.Name = "unitNewCust"
            Me.labelComponent14.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(150F, 23F)
            Me.labelComponent14.Size = New System.Drawing.SizeF(65F, 12F)
            Me.labelComponent14.Text = "Count"
            Me.labelComponent14.ZOrder = -1001
            ' 
            ' linearScaleMarkerComponent5
            ' 
            Me.linearScaleMarkerComponent5.LinearScale = Me.linearScaleComponent10
            Me.linearScaleMarkerComponent5.Name = "revenueMarker"
            Me.linearScaleMarkerComponent5.Shader = New DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Black;Style2:]")
            Me.linearScaleMarkerComponent5.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.5F, 0.15F)
            Me.linearScaleMarkerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.MarkerPointerShapeType.Box
            Me.linearScaleMarkerComponent5.ZOrder = -150
            ' 
            ' linearScaleComponent10
            ' 
            Me.linearScaleComponent10.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent10.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent10.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent10.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent10.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.linearScaleComponent10.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent10.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(0F, 35F)
            Me.linearScaleComponent10.MajorTickCount = 7
            Me.linearScaleComponent10.MajorTickmark.ShapeOffset = 10F
            Me.linearScaleComponent10.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default1
            Me.linearScaleComponent10.MajorTickmark.ShowText = False
            Me.linearScaleComponent10.MaxValue = 300F
            Me.linearScaleComponent10.MinorTickCount = 0
            Me.linearScaleComponent10.Name = "revenueComparativeMeasure"
            Me.linearScaleComponent10.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(0F, 215F)
            Me.linearScaleComponent10.Value = 250F
            ' 
            ' linearScaleMarkerComponent6
            ' 
            Me.linearScaleMarkerComponent6.LinearScale = Me.linearScaleComponent12
            Me.linearScaleMarkerComponent6.Name = "profitMarker"
            Me.linearScaleMarkerComponent6.Shader = New DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Black;Style2:]")
            Me.linearScaleMarkerComponent6.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.5F, 0.15F)
            Me.linearScaleMarkerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.MarkerPointerShapeType.Box
            Me.linearScaleMarkerComponent6.ZOrder = -150
            ' 
            ' linearScaleComponent12
            ' 
            Me.linearScaleComponent12.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent12.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent12.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent12.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent12.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.linearScaleComponent12.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent12.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 35F)
            Me.linearScaleComponent12.MajorTickCount = 7
            Me.linearScaleComponent12.MajorTickmark.ShapeOffset = 10F
            Me.linearScaleComponent12.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default1
            Me.linearScaleComponent12.MajorTickmark.ShowText = False
            Me.linearScaleComponent12.MaxValue = 30F
            Me.linearScaleComponent12.MinorTickCount = 0
            Me.linearScaleComponent12.Name = "profitComparativeMeasure"
            Me.linearScaleComponent12.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 215F)
            Me.linearScaleComponent12.Value = 26F
            ' 
            ' linearScaleMarkerComponent7
            ' 
            Me.linearScaleMarkerComponent7.LinearScale = Me.linearScaleComponent14
            Me.linearScaleMarkerComponent7.Name = "newCustMarker"
            Me.linearScaleMarkerComponent7.Shader = New DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Black;Style2:]")
            Me.linearScaleMarkerComponent7.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.5F, 0.15F)
            Me.linearScaleMarkerComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.MarkerPointerShapeType.Box
            Me.linearScaleMarkerComponent7.ZOrder = -150
            ' 
            ' linearScaleComponent14
            ' 
            Me.linearScaleComponent14.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent14.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent14.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent14.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent14.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.linearScaleComponent14.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent14.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(150F, 35F)
            Me.linearScaleComponent14.MajorTickCount = 7
            Me.linearScaleComponent14.MajorTickmark.ShapeOffset = 10F
            Me.linearScaleComponent14.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default1
            Me.linearScaleComponent14.MajorTickmark.ShowText = False
            Me.linearScaleComponent14.MaxValue = 2500F
            Me.linearScaleComponent14.MinorTickCount = 0
            Me.linearScaleComponent14.Name = "newCustComparativeMeasure"
            Me.linearScaleComponent14.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(150F, 215F)
            Me.linearScaleComponent14.Value = 2100F
            ' 
            ' linearScaleRangeBarComponent5
            ' 
            Me.linearScaleRangeBarComponent5.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleRangeBarComponent5.EndOffset = 2F
            Me.linearScaleRangeBarComponent5.LinearScale = Me.linearScaleComponent9
            Me.linearScaleRangeBarComponent5.Name = "revenueRange"
            Me.linearScaleRangeBarComponent5.StartOffset = -2F
            Me.linearScaleRangeBarComponent5.ZOrder = -100
            ' 
            ' linearScaleComponent9
            ' 
            Me.linearScaleComponent9.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent9.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent9.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent9.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent9.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.linearScaleComponent9.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent9.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(0F, 35F)
            Me.linearScaleComponent9.MajorTickCount = 7
            Me.linearScaleComponent9.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent9.MajorTickmark.ShapeOffset = -15F
            Me.linearScaleComponent9.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.65F, 1F)
            Me.linearScaleComponent9.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default3
            Me.linearScaleComponent9.MaxValue = 300F
            Me.linearScaleComponent9.MinorTickCount = 0
            Me.linearScaleComponent9.Name = "revenue"
            linearScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E0E0E0")
            linearScaleRange1.EndThickness = 20F
            linearScaleRange1.EndValue = 300F
            linearScaleRange1.Name = "Range0"
            linearScaleRange1.ShapeOffset = -10F
            linearScaleRange1.StartThickness = 20F
            linearScaleRange1.StartValue = 225F
            linearScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            linearScaleRange2.EndThickness = 20F
            linearScaleRange2.EndValue = 225F
            linearScaleRange2.Name = "Range1"
            linearScaleRange2.ShapeOffset = -10F
            linearScaleRange2.StartThickness = 20F
            linearScaleRange2.StartValue = 150F
            linearScaleRange3.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
            linearScaleRange3.EndThickness = 20F
            linearScaleRange3.EndValue = 150F
            linearScaleRange3.Name = "Range2"
            linearScaleRange3.ShapeOffset = -10F
            linearScaleRange3.StartThickness = 20F
            Me.linearScaleComponent9.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {linearScaleRange1, linearScaleRange2, linearScaleRange3})
            Me.linearScaleComponent9.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(0F, 215F)
            Me.linearScaleComponent9.Value = 275F
            ' 
            ' linearScaleRangeBarComponent6
            ' 
            Me.linearScaleRangeBarComponent6.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleRangeBarComponent6.EndOffset = 2F
            Me.linearScaleRangeBarComponent6.LinearScale = Me.linearScaleComponent11
            Me.linearScaleRangeBarComponent6.Name = "profitRange"
            Me.linearScaleRangeBarComponent6.StartOffset = -2F
            Me.linearScaleRangeBarComponent6.ZOrder = -100
            ' 
            ' linearScaleComponent11
            ' 
            Me.linearScaleComponent11.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent11.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent11.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent11.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent11.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.linearScaleComponent11.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent11.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 35F)
            Me.linearScaleComponent11.MajorTickCount = 7
            Me.linearScaleComponent11.MajorTickmark.FormatString = "{0:F0}%"
            Me.linearScaleComponent11.MajorTickmark.ShapeOffset = -15F
            Me.linearScaleComponent11.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.65F, 1F)
            Me.linearScaleComponent11.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default3
            Me.linearScaleComponent11.MaxValue = 30F
            Me.linearScaleComponent11.MinorTickCount = 0
            Me.linearScaleComponent11.Name = "profit"
            linearScaleRange4.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E0E0E0")
            linearScaleRange4.EndThickness = 20F
            linearScaleRange4.EndValue = 30F
            linearScaleRange4.Name = "Range0"
            linearScaleRange4.ShapeOffset = -10F
            linearScaleRange4.StartThickness = 20F
            linearScaleRange4.StartValue = 25F
            linearScaleRange5.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            linearScaleRange5.EndThickness = 20F
            linearScaleRange5.EndValue = 25F
            linearScaleRange5.Name = "Range1"
            linearScaleRange5.ShapeOffset = -10F
            linearScaleRange5.StartThickness = 20F
            linearScaleRange5.StartValue = 20F
            linearScaleRange6.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
            linearScaleRange6.EndThickness = 20F
            linearScaleRange6.EndValue = 20F
            linearScaleRange6.Name = "Range2"
            linearScaleRange6.ShapeOffset = -10F
            linearScaleRange6.StartThickness = 20F
            Me.linearScaleComponent11.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {linearScaleRange4, linearScaleRange5, linearScaleRange6})
            Me.linearScaleComponent11.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 215F)
            Me.linearScaleComponent11.Value = 22F
            ' 
            ' linearScaleRangeBarComponent7
            ' 
            Me.linearScaleRangeBarComponent7.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleRangeBarComponent7.EndOffset = 2F
            Me.linearScaleRangeBarComponent7.LinearScale = Me.linearScaleComponent13
            Me.linearScaleRangeBarComponent7.Name = "newCustRange"
            Me.linearScaleRangeBarComponent7.StartOffset = -2F
            Me.linearScaleRangeBarComponent7.ZOrder = -100
            ' 
            ' linearScaleComponent13
            ' 
            Me.linearScaleComponent13.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent13.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent13.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent13.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent13.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.linearScaleComponent13.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent13.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(150F, 35F)
            Me.linearScaleComponent13.MajorTickCount = 6
            Me.linearScaleComponent13.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent13.MajorTickmark.ShapeOffset = -15F
            Me.linearScaleComponent13.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.65F, 1F)
            Me.linearScaleComponent13.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default3
            Me.linearScaleComponent13.MaxValue = 2500F
            Me.linearScaleComponent13.MinorTickCount = 0
            Me.linearScaleComponent13.Name = "newCust"
            linearScaleRange7.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E0E0E0")
            linearScaleRange7.EndThickness = 20F
            linearScaleRange7.EndValue = 2500F
            linearScaleRange7.Name = "Range0"
            linearScaleRange7.ShapeOffset = -10F
            linearScaleRange7.StartThickness = 20F
            linearScaleRange7.StartValue = 2000F
            linearScaleRange8.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            linearScaleRange8.EndThickness = 20F
            linearScaleRange8.EndValue = 2000F
            linearScaleRange8.Name = "Range1"
            linearScaleRange8.ShapeOffset = -10F
            linearScaleRange8.StartThickness = 20F
            linearScaleRange8.StartValue = 1450F
            linearScaleRange9.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
            linearScaleRange9.EndThickness = 20F
            linearScaleRange9.EndValue = 1450F
            linearScaleRange9.Name = "Range2"
            linearScaleRange9.ShapeOffset = -10F
            linearScaleRange9.StartThickness = 20F
            Me.linearScaleComponent13.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {linearScaleRange7, linearScaleRange8, linearScaleRange9})
            Me.linearScaleComponent13.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(150F, 215F)
            Me.linearScaleComponent13.Value = 2250F
            ' 
            ' equalizer
            ' 
            Me.equalizer.BackColor = System.Drawing.Color.Black
            Me.equalizer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.equalizer.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge3})
            Me.equalizer.Location = New System.Drawing.Point(122, 145)
            Me.equalizer.Name = "equalizer"
            Me.equalizer.Size = New System.Drawing.Size(520, 230)
            Me.equalizer.TabIndex = 15
            ' 
            ' linearGauge3
            ' 
            Me.linearGauge3.AutoSize = DevExpress.Utils.DefaultBoolean.[False]
            Me.linearGauge3.Bounds = New System.Drawing.Rectangle(6, 6, 508, 218)
            Me.linearGauge3.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent() {Me.linearScaleStateIndicatorComponent1, Me.linearScaleStateIndicatorComponent2, Me.linearScaleStateIndicatorComponent3, Me.linearScaleStateIndicatorComponent4, Me.linearScaleStateIndicatorComponent5, Me.linearScaleStateIndicatorComponent6, Me.linearScaleStateIndicatorComponent7, Me.linearScaleStateIndicatorComponent8, Me.linearScaleStateIndicatorComponent9, Me.linearScaleStateIndicatorComponent10, Me.linearScaleStateIndicatorComponent11, Me.linearScaleStateIndicatorComponent12, Me.linearScaleStateIndicatorComponent13, Me.linearScaleStateIndicatorComponent14, Me.linearScaleStateIndicatorComponent15, Me.linearScaleStateIndicatorComponent16, Me.linearScaleStateIndicatorComponent17, Me.linearScaleStateIndicatorComponent18, Me.linearScaleStateIndicatorComponent19, Me.linearScaleStateIndicatorComponent20, Me.linearScaleStateIndicatorComponent21, Me.linearScaleStateIndicatorComponent22, Me.linearScaleStateIndicatorComponent23, Me.linearScaleStateIndicatorComponent24, Me.linearScaleStateIndicatorComponent25, Me.linearScaleStateIndicatorComponent26, Me.linearScaleStateIndicatorComponent27, Me.linearScaleStateIndicatorComponent28, Me.linearScaleStateIndicatorComponent29, Me.linearScaleStateIndicatorComponent30, Me.linearScaleStateIndicatorComponent31, Me.linearScaleStateIndicatorComponent32, Me.linearScaleStateIndicatorComponent33, Me.linearScaleStateIndicatorComponent34, Me.linearScaleStateIndicatorComponent35, Me.linearScaleStateIndicatorComponent96, Me.linearScaleStateIndicatorComponent97, Me.linearScaleStateIndicatorComponent98, Me.linearScaleStateIndicatorComponent99, Me.linearScaleStateIndicatorComponent100, Me.linearScaleStateIndicatorComponent101, Me.linearScaleStateIndicatorComponent102, Me.linearScaleStateIndicatorComponent103, Me.linearScaleStateIndicatorComponent104, Me.linearScaleStateIndicatorComponent105, Me.linearScaleStateIndicatorComponent106, Me.linearScaleStateIndicatorComponent107, Me.linearScaleStateIndicatorComponent108})
            Me.linearGauge3.Name = "linearGauge3"
            Me.linearGauge3.ProportionalStretch = False
            Me.linearGauge3.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent15, Me.linearScaleComponent16, Me.linearScaleComponent22, Me.linearScaleComponent23, Me.linearScaleComponent24, Me.linearScaleComponent25})
            ' 
            ' linearScaleStateIndicatorComponent1
            ' 
            Me.linearScaleStateIndicatorComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(12.5F, 225F)
            Me.linearScaleStateIndicatorComponent1.IndicatorScale = Me.linearScaleComponent15
            Me.linearScaleStateIndicatorComponent1.Name = "Indicator0Gauge0_Scale1"
            Me.linearScaleStateIndicatorComponent1.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState121.IntervalLength = 100F
            scaleIndicatorState121.Name = "Colored"
            scaleIndicatorState121.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState121.StartValue = 0.01F
            scaleIndicatorState122.IntervalLength = 0F
            scaleIndicatorState122.Name = "Empty"
            scaleIndicatorState122.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent1.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState121, scaleIndicatorState122})
            Me.linearScaleStateIndicatorComponent1.ZOrder = 100
            ' 
            ' linearScaleComponent15
            ' 
            Me.linearScaleComponent15.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent15.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent15.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent15.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent15.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent15.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(12.5F, 225F)
            Me.linearScaleComponent15.MajorTickCount = 2
            Me.linearScaleComponent15.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent15.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent15.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScaleComponent15.MajorTickmark.ShowText = False
            Me.linearScaleComponent15.MajorTickmark.ShowTick = False
            Me.linearScaleComponent15.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent15.MaxValue = 100F
            Me.linearScaleComponent15.MinorTickCount = 0
            Me.linearScaleComponent15.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent15.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScaleComponent15.MinorTickmark.ShowTick = False
            Me.linearScaleComponent15.Name = "Gauge0_Scale1"
            Me.linearScaleComponent15.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(12.5F, 25F)
            Me.linearScaleComponent15.Value = 98F
            ' 
            ' linearScaleStateIndicatorComponent2
            ' 
            Me.linearScaleStateIndicatorComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(12.5F, 196.4286F)
            Me.linearScaleStateIndicatorComponent2.IndicatorScale = Me.linearScaleComponent15
            Me.linearScaleStateIndicatorComponent2.Name = "Indicator1Gauge0_Scale1"
            Me.linearScaleStateIndicatorComponent2.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState123.IntervalLength = 87.5F
            scaleIndicatorState123.Name = "Colored"
            scaleIndicatorState123.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState123.StartValue = 12.5F
            scaleIndicatorState124.IntervalLength = 12.5F
            scaleIndicatorState124.Name = "Empty"
            scaleIndicatorState124.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent2.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState123, scaleIndicatorState124})
            Me.linearScaleStateIndicatorComponent2.ZOrder = 99
            ' 
            ' linearScaleStateIndicatorComponent3
            ' 
            Me.linearScaleStateIndicatorComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(12.5F, 167.8571F)
            Me.linearScaleStateIndicatorComponent3.IndicatorScale = Me.linearScaleComponent15
            Me.linearScaleStateIndicatorComponent3.Name = "Indicator2Gauge0_Scale1"
            Me.linearScaleStateIndicatorComponent3.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState125.IntervalLength = 75F
            scaleIndicatorState125.Name = "Colored"
            scaleIndicatorState125.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState125.StartValue = 25F
            scaleIndicatorState126.IntervalLength = 25F
            scaleIndicatorState126.Name = "Empty"
            scaleIndicatorState126.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent3.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState125, scaleIndicatorState126})
            Me.linearScaleStateIndicatorComponent3.ZOrder = 98
            ' 
            ' linearScaleStateIndicatorComponent4
            ' 
            Me.linearScaleStateIndicatorComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(12.5F, 139.2857F)
            Me.linearScaleStateIndicatorComponent4.IndicatorScale = Me.linearScaleComponent15
            Me.linearScaleStateIndicatorComponent4.Name = "Indicator3Gauge0_Scale1"
            Me.linearScaleStateIndicatorComponent4.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState127.IntervalLength = 62.5F
            scaleIndicatorState127.Name = "Colored"
            scaleIndicatorState127.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState127.StartValue = 37.5F
            scaleIndicatorState128.IntervalLength = 37.5F
            scaleIndicatorState128.Name = "Empty"
            scaleIndicatorState128.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent4.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState127, scaleIndicatorState128})
            Me.linearScaleStateIndicatorComponent4.ZOrder = 97
            ' 
            ' linearScaleStateIndicatorComponent5
            ' 
            Me.linearScaleStateIndicatorComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(12.5F, 110.7143F)
            Me.linearScaleStateIndicatorComponent5.IndicatorScale = Me.linearScaleComponent15
            Me.linearScaleStateIndicatorComponent5.Name = "Indicator4Gauge0_Scale1"
            Me.linearScaleStateIndicatorComponent5.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState129.IntervalLength = 50F
            scaleIndicatorState129.Name = "Colored"
            scaleIndicatorState129.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState129.StartValue = 50F
            scaleIndicatorState130.IntervalLength = 50F
            scaleIndicatorState130.Name = "Empty"
            scaleIndicatorState130.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent5.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState129, scaleIndicatorState130})
            Me.linearScaleStateIndicatorComponent5.ZOrder = 96
            ' 
            ' linearScaleStateIndicatorComponent6
            ' 
            Me.linearScaleStateIndicatorComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(12.5F, 82.14286F)
            Me.linearScaleStateIndicatorComponent6.IndicatorScale = Me.linearScaleComponent15
            Me.linearScaleStateIndicatorComponent6.Name = "Indicator5Gauge0_Scale1"
            Me.linearScaleStateIndicatorComponent6.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState131.IntervalLength = 37.5F
            scaleIndicatorState131.Name = "Colored"
            scaleIndicatorState131.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState131.StartValue = 62.5F
            scaleIndicatorState132.IntervalLength = 62.5F
            scaleIndicatorState132.Name = "Empty"
            scaleIndicatorState132.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent6.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState131, scaleIndicatorState132})
            Me.linearScaleStateIndicatorComponent6.ZOrder = 95
            ' 
            ' linearScaleStateIndicatorComponent7
            ' 
            Me.linearScaleStateIndicatorComponent7.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(12.5F, 53.57143F)
            Me.linearScaleStateIndicatorComponent7.IndicatorScale = Me.linearScaleComponent15
            Me.linearScaleStateIndicatorComponent7.Name = "Indicator6Gauge0_Scale1"
            Me.linearScaleStateIndicatorComponent7.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState133.IntervalLength = 25F
            scaleIndicatorState133.Name = "Colored"
            scaleIndicatorState133.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState133.StartValue = 75F
            scaleIndicatorState134.IntervalLength = 75F
            scaleIndicatorState134.Name = "Empty"
            scaleIndicatorState134.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent7.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState133, scaleIndicatorState134})
            Me.linearScaleStateIndicatorComponent7.ZOrder = 94
            ' 
            ' linearScaleStateIndicatorComponent8
            ' 
            Me.linearScaleStateIndicatorComponent8.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(12.5F, 25F)
            Me.linearScaleStateIndicatorComponent8.IndicatorScale = Me.linearScaleComponent15
            Me.linearScaleStateIndicatorComponent8.Name = "Indicator7Gauge0_Scale1"
            Me.linearScaleStateIndicatorComponent8.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState135.IntervalLength = 12.5F
            scaleIndicatorState135.Name = "Colored"
            scaleIndicatorState135.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState135.StartValue = 87.5F
            scaleIndicatorState136.IntervalLength = 87.5F
            scaleIndicatorState136.Name = "Empty"
            scaleIndicatorState136.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent8.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState135, scaleIndicatorState136})
            Me.linearScaleStateIndicatorComponent8.ZOrder = 93
            ' 
            ' linearScaleStateIndicatorComponent9
            ' 
            Me.linearScaleStateIndicatorComponent9.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(32.5F, 225F)
            Me.linearScaleStateIndicatorComponent9.IndicatorScale = Me.linearScaleComponent16
            Me.linearScaleStateIndicatorComponent9.Name = "Indicator0Gauge0_Scale2"
            Me.linearScaleStateIndicatorComponent9.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState137.IntervalLength = 100F
            scaleIndicatorState137.Name = "Colored"
            scaleIndicatorState137.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState137.StartValue = 0.01F
            scaleIndicatorState138.IntervalLength = 0F
            scaleIndicatorState138.Name = "Empty"
            scaleIndicatorState138.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent9.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState137, scaleIndicatorState138})
            Me.linearScaleStateIndicatorComponent9.ZOrder = 100
            ' 
            ' linearScaleComponent16
            ' 
            Me.linearScaleComponent16.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent16.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent16.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent16.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent16.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent16.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(32.5F, 225F)
            Me.linearScaleComponent16.MajorTickCount = 2
            Me.linearScaleComponent16.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent16.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent16.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScaleComponent16.MajorTickmark.ShowText = False
            Me.linearScaleComponent16.MajorTickmark.ShowTick = False
            Me.linearScaleComponent16.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent16.MaxValue = 100F
            Me.linearScaleComponent16.MinorTickCount = 0
            Me.linearScaleComponent16.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent16.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScaleComponent16.MinorTickmark.ShowTick = False
            Me.linearScaleComponent16.Name = "Gauge0_Scale2"
            Me.linearScaleComponent16.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(32.5F, 25F)
            Me.linearScaleComponent16.Value = 98F
            ' 
            ' linearScaleStateIndicatorComponent10
            ' 
            Me.linearScaleStateIndicatorComponent10.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(32.5F, 196.4286F)
            Me.linearScaleStateIndicatorComponent10.IndicatorScale = Me.linearScaleComponent16
            Me.linearScaleStateIndicatorComponent10.Name = "Indicator1Gauge0_Scale2"
            Me.linearScaleStateIndicatorComponent10.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState139.IntervalLength = 87.5F
            scaleIndicatorState139.Name = "Colored"
            scaleIndicatorState139.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState139.StartValue = 12.5F
            scaleIndicatorState140.IntervalLength = 12.5F
            scaleIndicatorState140.Name = "Empty"
            scaleIndicatorState140.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent10.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState139, scaleIndicatorState140})
            Me.linearScaleStateIndicatorComponent10.ZOrder = 99
            ' 
            ' linearScaleStateIndicatorComponent11
            ' 
            Me.linearScaleStateIndicatorComponent11.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(32.5F, 167.8571F)
            Me.linearScaleStateIndicatorComponent11.IndicatorScale = Me.linearScaleComponent16
            Me.linearScaleStateIndicatorComponent11.Name = "Indicator2Gauge0_Scale2"
            Me.linearScaleStateIndicatorComponent11.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState141.IntervalLength = 75F
            scaleIndicatorState141.Name = "Colored"
            scaleIndicatorState141.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState141.StartValue = 25F
            scaleIndicatorState142.IntervalLength = 25F
            scaleIndicatorState142.Name = "Empty"
            scaleIndicatorState142.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent11.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState141, scaleIndicatorState142})
            Me.linearScaleStateIndicatorComponent11.ZOrder = 98
            ' 
            ' linearScaleStateIndicatorComponent12
            ' 
            Me.linearScaleStateIndicatorComponent12.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(32.5F, 139.2857F)
            Me.linearScaleStateIndicatorComponent12.IndicatorScale = Me.linearScaleComponent16
            Me.linearScaleStateIndicatorComponent12.Name = "Indicator3Gauge0_Scale2"
            Me.linearScaleStateIndicatorComponent12.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState143.IntervalLength = 62.5F
            scaleIndicatorState143.Name = "Colored"
            scaleIndicatorState143.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState143.StartValue = 37.5F
            scaleIndicatorState144.IntervalLength = 37.5F
            scaleIndicatorState144.Name = "Empty"
            scaleIndicatorState144.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent12.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState143, scaleIndicatorState144})
            Me.linearScaleStateIndicatorComponent12.ZOrder = 97
            ' 
            ' linearScaleStateIndicatorComponent13
            ' 
            Me.linearScaleStateIndicatorComponent13.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(32.5F, 110.7143F)
            Me.linearScaleStateIndicatorComponent13.IndicatorScale = Me.linearScaleComponent16
            Me.linearScaleStateIndicatorComponent13.Name = "Indicator4Gauge0_Scale2"
            Me.linearScaleStateIndicatorComponent13.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState145.IntervalLength = 50F
            scaleIndicatorState145.Name = "Colored"
            scaleIndicatorState145.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState145.StartValue = 50F
            scaleIndicatorState146.IntervalLength = 50F
            scaleIndicatorState146.Name = "Empty"
            scaleIndicatorState146.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent13.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState145, scaleIndicatorState146})
            Me.linearScaleStateIndicatorComponent13.ZOrder = 96
            ' 
            ' linearScaleStateIndicatorComponent14
            ' 
            Me.linearScaleStateIndicatorComponent14.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(32.5F, 82.14286F)
            Me.linearScaleStateIndicatorComponent14.IndicatorScale = Me.linearScaleComponent16
            Me.linearScaleStateIndicatorComponent14.Name = "Indicator5Gauge0_Scale2"
            Me.linearScaleStateIndicatorComponent14.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState147.IntervalLength = 37.5F
            scaleIndicatorState147.Name = "Colored"
            scaleIndicatorState147.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState147.StartValue = 62.5F
            scaleIndicatorState148.IntervalLength = 62.5F
            scaleIndicatorState148.Name = "Empty"
            scaleIndicatorState148.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent14.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState147, scaleIndicatorState148})
            Me.linearScaleStateIndicatorComponent14.ZOrder = 95
            ' 
            ' linearScaleStateIndicatorComponent15
            ' 
            Me.linearScaleStateIndicatorComponent15.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(32.5F, 53.57143F)
            Me.linearScaleStateIndicatorComponent15.IndicatorScale = Me.linearScaleComponent16
            Me.linearScaleStateIndicatorComponent15.Name = "Indicator6Gauge0_Scale2"
            Me.linearScaleStateIndicatorComponent15.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState149.IntervalLength = 25F
            scaleIndicatorState149.Name = "Colored"
            scaleIndicatorState149.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState149.StartValue = 75F
            scaleIndicatorState150.IntervalLength = 75F
            scaleIndicatorState150.Name = "Empty"
            scaleIndicatorState150.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent15.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState149, scaleIndicatorState150})
            Me.linearScaleStateIndicatorComponent15.ZOrder = 94
            ' 
            ' linearScaleStateIndicatorComponent16
            ' 
            Me.linearScaleStateIndicatorComponent16.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(32.5F, 25F)
            Me.linearScaleStateIndicatorComponent16.IndicatorScale = Me.linearScaleComponent16
            Me.linearScaleStateIndicatorComponent16.Name = "Indicator7Gauge0_Scale2"
            Me.linearScaleStateIndicatorComponent16.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState151.IntervalLength = 12.5F
            scaleIndicatorState151.Name = "Colored"
            scaleIndicatorState151.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState151.StartValue = 87.5F
            scaleIndicatorState152.IntervalLength = 87.5F
            scaleIndicatorState152.Name = "Empty"
            scaleIndicatorState152.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent16.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState151, scaleIndicatorState152})
            Me.linearScaleStateIndicatorComponent16.ZOrder = 93
            ' 
            ' linearScaleStateIndicatorComponent17
            ' 
            Me.linearScaleStateIndicatorComponent17.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(52.5F, 225F)
            Me.linearScaleStateIndicatorComponent17.IndicatorScale = Me.linearScaleComponent22
            Me.linearScaleStateIndicatorComponent17.Name = "Indicator0Gauge0_Scale3"
            Me.linearScaleStateIndicatorComponent17.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState153.IntervalLength = 100F
            scaleIndicatorState153.Name = "Colored"
            scaleIndicatorState153.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState153.StartValue = 0.01F
            scaleIndicatorState154.IntervalLength = 0F
            scaleIndicatorState154.Name = "Empty"
            scaleIndicatorState154.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent17.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState153, scaleIndicatorState154})
            Me.linearScaleStateIndicatorComponent17.ZOrder = 100
            ' 
            ' linearScaleComponent22
            ' 
            Me.linearScaleComponent22.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent22.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent22.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent22.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent22.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent22.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(52.5F, 225F)
            Me.linearScaleComponent22.MajorTickCount = 2
            Me.linearScaleComponent22.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent22.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent22.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScaleComponent22.MajorTickmark.ShowText = False
            Me.linearScaleComponent22.MajorTickmark.ShowTick = False
            Me.linearScaleComponent22.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent22.MaxValue = 100F
            Me.linearScaleComponent22.MinorTickCount = 0
            Me.linearScaleComponent22.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent22.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScaleComponent22.MinorTickmark.ShowTick = False
            Me.linearScaleComponent22.Name = "Gauge0_Scale3"
            Me.linearScaleComponent22.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(52.5F, 25F)
            Me.linearScaleComponent22.Value = 98F
            ' 
            ' linearScaleStateIndicatorComponent18
            ' 
            Me.linearScaleStateIndicatorComponent18.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(52.5F, 196.4286F)
            Me.linearScaleStateIndicatorComponent18.IndicatorScale = Me.linearScaleComponent22
            Me.linearScaleStateIndicatorComponent18.Name = "Indicator1Gauge0_Scale3"
            Me.linearScaleStateIndicatorComponent18.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState155.IntervalLength = 87.5F
            scaleIndicatorState155.Name = "Colored"
            scaleIndicatorState155.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState155.StartValue = 12.5F
            scaleIndicatorState156.IntervalLength = 12.5F
            scaleIndicatorState156.Name = "Empty"
            scaleIndicatorState156.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent18.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState155, scaleIndicatorState156})
            Me.linearScaleStateIndicatorComponent18.ZOrder = 99
            ' 
            ' linearScaleStateIndicatorComponent19
            ' 
            Me.linearScaleStateIndicatorComponent19.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(52.5F, 167.8571F)
            Me.linearScaleStateIndicatorComponent19.IndicatorScale = Me.linearScaleComponent22
            Me.linearScaleStateIndicatorComponent19.Name = "Indicator2Gauge0_Scale3"
            Me.linearScaleStateIndicatorComponent19.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState157.IntervalLength = 75F
            scaleIndicatorState157.Name = "Colored"
            scaleIndicatorState157.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState157.StartValue = 25F
            scaleIndicatorState158.IntervalLength = 25F
            scaleIndicatorState158.Name = "Empty"
            scaleIndicatorState158.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent19.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState157, scaleIndicatorState158})
            Me.linearScaleStateIndicatorComponent19.ZOrder = 98
            ' 
            ' linearScaleStateIndicatorComponent20
            ' 
            Me.linearScaleStateIndicatorComponent20.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(52.5F, 139.2857F)
            Me.linearScaleStateIndicatorComponent20.IndicatorScale = Me.linearScaleComponent22
            Me.linearScaleStateIndicatorComponent20.Name = "Indicator3Gauge0_Scale3"
            Me.linearScaleStateIndicatorComponent20.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState159.IntervalLength = 62.5F
            scaleIndicatorState159.Name = "Colored"
            scaleIndicatorState159.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState159.StartValue = 37.5F
            scaleIndicatorState160.IntervalLength = 37.5F
            scaleIndicatorState160.Name = "Empty"
            scaleIndicatorState160.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent20.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState159, scaleIndicatorState160})
            Me.linearScaleStateIndicatorComponent20.ZOrder = 97
            ' 
            ' linearScaleStateIndicatorComponent21
            ' 
            Me.linearScaleStateIndicatorComponent21.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(52.5F, 110.7143F)
            Me.linearScaleStateIndicatorComponent21.IndicatorScale = Me.linearScaleComponent22
            Me.linearScaleStateIndicatorComponent21.Name = "Indicator4Gauge0_Scale3"
            Me.linearScaleStateIndicatorComponent21.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState161.IntervalLength = 50F
            scaleIndicatorState161.Name = "Colored"
            scaleIndicatorState161.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState161.StartValue = 50F
            scaleIndicatorState162.IntervalLength = 50F
            scaleIndicatorState162.Name = "Empty"
            scaleIndicatorState162.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent21.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState161, scaleIndicatorState162})
            Me.linearScaleStateIndicatorComponent21.ZOrder = 96
            ' 
            ' linearScaleStateIndicatorComponent22
            ' 
            Me.linearScaleStateIndicatorComponent22.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(52.5F, 82.14286F)
            Me.linearScaleStateIndicatorComponent22.IndicatorScale = Me.linearScaleComponent22
            Me.linearScaleStateIndicatorComponent22.Name = "Indicator5Gauge0_Scale3"
            Me.linearScaleStateIndicatorComponent22.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState163.IntervalLength = 37.5F
            scaleIndicatorState163.Name = "Colored"
            scaleIndicatorState163.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState163.StartValue = 62.5F
            scaleIndicatorState164.IntervalLength = 62.5F
            scaleIndicatorState164.Name = "Empty"
            scaleIndicatorState164.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent22.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState163, scaleIndicatorState164})
            Me.linearScaleStateIndicatorComponent22.ZOrder = 95
            ' 
            ' linearScaleStateIndicatorComponent23
            ' 
            Me.linearScaleStateIndicatorComponent23.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(52.5F, 53.57143F)
            Me.linearScaleStateIndicatorComponent23.IndicatorScale = Me.linearScaleComponent22
            Me.linearScaleStateIndicatorComponent23.Name = "Indicator6Gauge0_Scale3"
            Me.linearScaleStateIndicatorComponent23.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState165.IntervalLength = 25F
            scaleIndicatorState165.Name = "Colored"
            scaleIndicatorState165.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState165.StartValue = 75F
            scaleIndicatorState166.IntervalLength = 75F
            scaleIndicatorState166.Name = "Empty"
            scaleIndicatorState166.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent23.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState165, scaleIndicatorState166})
            Me.linearScaleStateIndicatorComponent23.ZOrder = 94
            ' 
            ' linearScaleStateIndicatorComponent24
            ' 
            Me.linearScaleStateIndicatorComponent24.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(52.5F, 25F)
            Me.linearScaleStateIndicatorComponent24.IndicatorScale = Me.linearScaleComponent22
            Me.linearScaleStateIndicatorComponent24.Name = "Indicator7Gauge0_Scale3"
            Me.linearScaleStateIndicatorComponent24.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState167.IntervalLength = 12.5F
            scaleIndicatorState167.Name = "Colored"
            scaleIndicatorState167.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState167.StartValue = 87.5F
            scaleIndicatorState168.IntervalLength = 87.5F
            scaleIndicatorState168.Name = "Empty"
            scaleIndicatorState168.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent24.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState167, scaleIndicatorState168})
            Me.linearScaleStateIndicatorComponent24.ZOrder = 93
            ' 
            ' linearScaleStateIndicatorComponent25
            ' 
            Me.linearScaleStateIndicatorComponent25.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(72.5F, 225F)
            Me.linearScaleStateIndicatorComponent25.IndicatorScale = Me.linearScaleComponent23
            Me.linearScaleStateIndicatorComponent25.Name = "Indicator0Gauge0_Scale4"
            Me.linearScaleStateIndicatorComponent25.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState169.IntervalLength = 100F
            scaleIndicatorState169.Name = "Colored"
            scaleIndicatorState169.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState169.StartValue = 0.01F
            scaleIndicatorState170.IntervalLength = 0F
            scaleIndicatorState170.Name = "Empty"
            scaleIndicatorState170.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent25.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState169, scaleIndicatorState170})
            Me.linearScaleStateIndicatorComponent25.ZOrder = 100
            ' 
            ' linearScaleComponent23
            ' 
            Me.linearScaleComponent23.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent23.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent23.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent23.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent23.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent23.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(72.5F, 225F)
            Me.linearScaleComponent23.MajorTickCount = 2
            Me.linearScaleComponent23.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent23.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent23.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScaleComponent23.MajorTickmark.ShowText = False
            Me.linearScaleComponent23.MajorTickmark.ShowTick = False
            Me.linearScaleComponent23.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent23.MaxValue = 100F
            Me.linearScaleComponent23.MinorTickCount = 0
            Me.linearScaleComponent23.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent23.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScaleComponent23.MinorTickmark.ShowTick = False
            Me.linearScaleComponent23.Name = "Gauge0_Scale4"
            Me.linearScaleComponent23.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(72.5F, 25F)
            Me.linearScaleComponent23.Value = 98F
            ' 
            ' linearScaleStateIndicatorComponent26
            ' 
            Me.linearScaleStateIndicatorComponent26.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(72.5F, 196.4286F)
            Me.linearScaleStateIndicatorComponent26.IndicatorScale = Me.linearScaleComponent23
            Me.linearScaleStateIndicatorComponent26.Name = "Indicator1Gauge0_Scale4"
            Me.linearScaleStateIndicatorComponent26.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState171.IntervalLength = 87.5F
            scaleIndicatorState171.Name = "Colored"
            scaleIndicatorState171.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState171.StartValue = 12.5F
            scaleIndicatorState172.IntervalLength = 12.5F
            scaleIndicatorState172.Name = "Empty"
            scaleIndicatorState172.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent26.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState171, scaleIndicatorState172})
            Me.linearScaleStateIndicatorComponent26.ZOrder = 99
            ' 
            ' linearScaleStateIndicatorComponent27
            ' 
            Me.linearScaleStateIndicatorComponent27.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(72.5F, 167.8571F)
            Me.linearScaleStateIndicatorComponent27.IndicatorScale = Me.linearScaleComponent23
            Me.linearScaleStateIndicatorComponent27.Name = "Indicator2Gauge0_Scale4"
            Me.linearScaleStateIndicatorComponent27.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState173.IntervalLength = 75F
            scaleIndicatorState173.Name = "Colored"
            scaleIndicatorState173.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState173.StartValue = 25F
            scaleIndicatorState174.IntervalLength = 25F
            scaleIndicatorState174.Name = "Empty"
            scaleIndicatorState174.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent27.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState173, scaleIndicatorState174})
            Me.linearScaleStateIndicatorComponent27.ZOrder = 98
            ' 
            ' linearScaleStateIndicatorComponent28
            ' 
            Me.linearScaleStateIndicatorComponent28.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(72.5F, 139.2857F)
            Me.linearScaleStateIndicatorComponent28.IndicatorScale = Me.linearScaleComponent23
            Me.linearScaleStateIndicatorComponent28.Name = "Indicator3Gauge0_Scale4"
            Me.linearScaleStateIndicatorComponent28.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState175.IntervalLength = 62.5F
            scaleIndicatorState175.Name = "Colored"
            scaleIndicatorState175.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState175.StartValue = 37.5F
            scaleIndicatorState176.IntervalLength = 37.5F
            scaleIndicatorState176.Name = "Empty"
            scaleIndicatorState176.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent28.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState175, scaleIndicatorState176})
            Me.linearScaleStateIndicatorComponent28.ZOrder = 97
            ' 
            ' linearScaleStateIndicatorComponent29
            ' 
            Me.linearScaleStateIndicatorComponent29.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(72.5F, 110.7143F)
            Me.linearScaleStateIndicatorComponent29.IndicatorScale = Me.linearScaleComponent23
            Me.linearScaleStateIndicatorComponent29.Name = "Indicator4Gauge0_Scale4"
            Me.linearScaleStateIndicatorComponent29.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState177.IntervalLength = 50F
            scaleIndicatorState177.Name = "Colored"
            scaleIndicatorState177.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState177.StartValue = 50F
            scaleIndicatorState178.IntervalLength = 50F
            scaleIndicatorState178.Name = "Empty"
            scaleIndicatorState178.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent29.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState177, scaleIndicatorState178})
            Me.linearScaleStateIndicatorComponent29.ZOrder = 96
            ' 
            ' linearScaleStateIndicatorComponent30
            ' 
            Me.linearScaleStateIndicatorComponent30.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(72.5F, 82.14286F)
            Me.linearScaleStateIndicatorComponent30.IndicatorScale = Me.linearScaleComponent23
            Me.linearScaleStateIndicatorComponent30.Name = "Indicator5Gauge0_Scale4"
            Me.linearScaleStateIndicatorComponent30.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState179.IntervalLength = 37.5F
            scaleIndicatorState179.Name = "Colored"
            scaleIndicatorState179.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState179.StartValue = 62.5F
            scaleIndicatorState180.IntervalLength = 62.5F
            scaleIndicatorState180.Name = "Empty"
            scaleIndicatorState180.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent30.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState179, scaleIndicatorState180})
            Me.linearScaleStateIndicatorComponent30.ZOrder = 95
            ' 
            ' linearScaleStateIndicatorComponent31
            ' 
            Me.linearScaleStateIndicatorComponent31.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(72.5F, 53.57143F)
            Me.linearScaleStateIndicatorComponent31.IndicatorScale = Me.linearScaleComponent23
            Me.linearScaleStateIndicatorComponent31.Name = "Indicator6Gauge0_Scale4"
            Me.linearScaleStateIndicatorComponent31.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState181.IntervalLength = 25F
            scaleIndicatorState181.Name = "Colored"
            scaleIndicatorState181.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState181.StartValue = 75F
            scaleIndicatorState182.IntervalLength = 75F
            scaleIndicatorState182.Name = "Empty"
            scaleIndicatorState182.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent31.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState181, scaleIndicatorState182})
            Me.linearScaleStateIndicatorComponent31.ZOrder = 94
            ' 
            ' linearScaleStateIndicatorComponent32
            ' 
            Me.linearScaleStateIndicatorComponent32.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(72.5F, 25F)
            Me.linearScaleStateIndicatorComponent32.IndicatorScale = Me.linearScaleComponent23
            Me.linearScaleStateIndicatorComponent32.Name = "Indicator7Gauge0_Scale4"
            Me.linearScaleStateIndicatorComponent32.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState183.IntervalLength = 12.5F
            scaleIndicatorState183.Name = "Colored"
            scaleIndicatorState183.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState183.StartValue = 87.5F
            scaleIndicatorState184.IntervalLength = 87.5F
            scaleIndicatorState184.Name = "Empty"
            scaleIndicatorState184.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent32.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState183, scaleIndicatorState184})
            Me.linearScaleStateIndicatorComponent32.ZOrder = 93
            ' 
            ' linearScaleStateIndicatorComponent33
            ' 
            Me.linearScaleStateIndicatorComponent33.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(92.5F, 225F)
            Me.linearScaleStateIndicatorComponent33.IndicatorScale = Me.linearScaleComponent24
            Me.linearScaleStateIndicatorComponent33.Name = "Indicator0Gauge0_Scale5"
            Me.linearScaleStateIndicatorComponent33.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState185.IntervalLength = 100F
            scaleIndicatorState185.Name = "Colored"
            scaleIndicatorState185.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState185.StartValue = 0.01F
            scaleIndicatorState186.IntervalLength = 0F
            scaleIndicatorState186.Name = "Empty"
            scaleIndicatorState186.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent33.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState185, scaleIndicatorState186})
            Me.linearScaleStateIndicatorComponent33.ZOrder = 100
            ' 
            ' linearScaleComponent24
            ' 
            Me.linearScaleComponent24.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent24.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent24.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent24.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent24.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent24.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(92.5F, 225F)
            Me.linearScaleComponent24.MajorTickCount = 2
            Me.linearScaleComponent24.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent24.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent24.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScaleComponent24.MajorTickmark.ShowText = False
            Me.linearScaleComponent24.MajorTickmark.ShowTick = False
            Me.linearScaleComponent24.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent24.MaxValue = 100F
            Me.linearScaleComponent24.MinorTickCount = 0
            Me.linearScaleComponent24.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent24.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScaleComponent24.MinorTickmark.ShowTick = False
            Me.linearScaleComponent24.Name = "Gauge0_Scale5"
            Me.linearScaleComponent24.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(92.5F, 25F)
            Me.linearScaleComponent24.Value = 98F
            ' 
            ' linearScaleStateIndicatorComponent34
            ' 
            Me.linearScaleStateIndicatorComponent34.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(92.5F, 196.4286F)
            Me.linearScaleStateIndicatorComponent34.IndicatorScale = Me.linearScaleComponent24
            Me.linearScaleStateIndicatorComponent34.Name = "Indicator1Gauge0_Scale5"
            Me.linearScaleStateIndicatorComponent34.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState187.IntervalLength = 87.5F
            scaleIndicatorState187.Name = "Colored"
            scaleIndicatorState187.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState187.StartValue = 12.5F
            scaleIndicatorState188.IntervalLength = 12.5F
            scaleIndicatorState188.Name = "Empty"
            scaleIndicatorState188.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent34.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState187, scaleIndicatorState188})
            Me.linearScaleStateIndicatorComponent34.ZOrder = 99
            ' 
            ' linearScaleStateIndicatorComponent35
            ' 
            Me.linearScaleStateIndicatorComponent35.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(92.5F, 167.8571F)
            Me.linearScaleStateIndicatorComponent35.IndicatorScale = Me.linearScaleComponent24
            Me.linearScaleStateIndicatorComponent35.Name = "Indicator2Gauge0_Scale5"
            Me.linearScaleStateIndicatorComponent35.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState189.IntervalLength = 75F
            scaleIndicatorState189.Name = "Colored"
            scaleIndicatorState189.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState189.StartValue = 25F
            scaleIndicatorState190.IntervalLength = 25F
            scaleIndicatorState190.Name = "Empty"
            scaleIndicatorState190.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent35.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState189, scaleIndicatorState190})
            Me.linearScaleStateIndicatorComponent35.ZOrder = 98
            ' 
            ' linearScaleStateIndicatorComponent96
            ' 
            Me.linearScaleStateIndicatorComponent96.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(92.5F, 139.2857F)
            Me.linearScaleStateIndicatorComponent96.IndicatorScale = Me.linearScaleComponent24
            Me.linearScaleStateIndicatorComponent96.Name = "Indicator3Gauge0_Scale5"
            Me.linearScaleStateIndicatorComponent96.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState191.IntervalLength = 62.5F
            scaleIndicatorState191.Name = "Colored"
            scaleIndicatorState191.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState191.StartValue = 37.5F
            scaleIndicatorState192.IntervalLength = 37.5F
            scaleIndicatorState192.Name = "Empty"
            scaleIndicatorState192.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent96.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState191, scaleIndicatorState192})
            Me.linearScaleStateIndicatorComponent96.ZOrder = 97
            ' 
            ' linearScaleStateIndicatorComponent97
            ' 
            Me.linearScaleStateIndicatorComponent97.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(92.5F, 110.7143F)
            Me.linearScaleStateIndicatorComponent97.IndicatorScale = Me.linearScaleComponent24
            Me.linearScaleStateIndicatorComponent97.Name = "Indicator4Gauge0_Scale5"
            Me.linearScaleStateIndicatorComponent97.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState193.IntervalLength = 50F
            scaleIndicatorState193.Name = "Colored"
            scaleIndicatorState193.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState193.StartValue = 50F
            scaleIndicatorState194.IntervalLength = 50F
            scaleIndicatorState194.Name = "Empty"
            scaleIndicatorState194.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent97.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState193, scaleIndicatorState194})
            Me.linearScaleStateIndicatorComponent97.ZOrder = 96
            ' 
            ' linearScaleStateIndicatorComponent98
            ' 
            Me.linearScaleStateIndicatorComponent98.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(92.5F, 82.14286F)
            Me.linearScaleStateIndicatorComponent98.IndicatorScale = Me.linearScaleComponent24
            Me.linearScaleStateIndicatorComponent98.Name = "Indicator5Gauge0_Scale5"
            Me.linearScaleStateIndicatorComponent98.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState195.IntervalLength = 37.5F
            scaleIndicatorState195.Name = "Colored"
            scaleIndicatorState195.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState195.StartValue = 62.5F
            scaleIndicatorState196.IntervalLength = 62.5F
            scaleIndicatorState196.Name = "Empty"
            scaleIndicatorState196.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent98.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState195, scaleIndicatorState196})
            Me.linearScaleStateIndicatorComponent98.ZOrder = 95
            ' 
            ' linearScaleStateIndicatorComponent99
            ' 
            Me.linearScaleStateIndicatorComponent99.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(92.5F, 53.57143F)
            Me.linearScaleStateIndicatorComponent99.IndicatorScale = Me.linearScaleComponent24
            Me.linearScaleStateIndicatorComponent99.Name = "Indicator6Gauge0_Scale5"
            Me.linearScaleStateIndicatorComponent99.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState197.IntervalLength = 25F
            scaleIndicatorState197.Name = "Colored"
            scaleIndicatorState197.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState197.StartValue = 75F
            scaleIndicatorState198.IntervalLength = 75F
            scaleIndicatorState198.Name = "Empty"
            scaleIndicatorState198.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent99.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState197, scaleIndicatorState198})
            Me.linearScaleStateIndicatorComponent99.ZOrder = 94
            ' 
            ' linearScaleStateIndicatorComponent100
            ' 
            Me.linearScaleStateIndicatorComponent100.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(92.5F, 25F)
            Me.linearScaleStateIndicatorComponent100.IndicatorScale = Me.linearScaleComponent24
            Me.linearScaleStateIndicatorComponent100.Name = "Indicator7Gauge0_Scale5"
            Me.linearScaleStateIndicatorComponent100.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState199.IntervalLength = 12.5F
            scaleIndicatorState199.Name = "Colored"
            scaleIndicatorState199.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState199.StartValue = 87.5F
            scaleIndicatorState200.IntervalLength = 87.5F
            scaleIndicatorState200.Name = "Empty"
            scaleIndicatorState200.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent100.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState199, scaleIndicatorState200})
            Me.linearScaleStateIndicatorComponent100.ZOrder = 93
            ' 
            ' linearScaleStateIndicatorComponent101
            ' 
            Me.linearScaleStateIndicatorComponent101.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(112.5F, 225F)
            Me.linearScaleStateIndicatorComponent101.IndicatorScale = Me.linearScaleComponent25
            Me.linearScaleStateIndicatorComponent101.Name = "Indicator0Gauge0_Scale6"
            Me.linearScaleStateIndicatorComponent101.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState201.IntervalLength = 100F
            scaleIndicatorState201.Name = "Colored"
            scaleIndicatorState201.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState201.StartValue = 0.01F
            scaleIndicatorState202.IntervalLength = 0F
            scaleIndicatorState202.Name = "Empty"
            scaleIndicatorState202.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent101.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState201, scaleIndicatorState202})
            Me.linearScaleStateIndicatorComponent101.ZOrder = 100
            ' 
            ' linearScaleComponent25
            ' 
            Me.linearScaleComponent25.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent25.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent25.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent25.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent25.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent25.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(112.5F, 225F)
            Me.linearScaleComponent25.MajorTickCount = 2
            Me.linearScaleComponent25.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent25.MajorTickmark.ShapeOffset = -20F
            Me.linearScaleComponent25.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScaleComponent25.MajorTickmark.ShowText = False
            Me.linearScaleComponent25.MajorTickmark.ShowTick = False
            Me.linearScaleComponent25.MajorTickmark.TextOffset = -32F
            Me.linearScaleComponent25.MaxValue = 100F
            Me.linearScaleComponent25.MinorTickCount = 0
            Me.linearScaleComponent25.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent25.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScaleComponent25.MinorTickmark.ShowTick = False
            Me.linearScaleComponent25.Name = "Gauge0_Scale6"
            Me.linearScaleComponent25.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(112.5F, 25F)
            Me.linearScaleComponent25.Value = 98F
            ' 
            ' linearScaleStateIndicatorComponent102
            ' 
            Me.linearScaleStateIndicatorComponent102.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(112.5F, 196.4286F)
            Me.linearScaleStateIndicatorComponent102.IndicatorScale = Me.linearScaleComponent25
            Me.linearScaleStateIndicatorComponent102.Name = "Indicator1Gauge0_Scale6"
            Me.linearScaleStateIndicatorComponent102.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState203.IntervalLength = 87.5F
            scaleIndicatorState203.Name = "Colored"
            scaleIndicatorState203.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState203.StartValue = 12.5F
            scaleIndicatorState204.IntervalLength = 12.5F
            scaleIndicatorState204.Name = "Empty"
            scaleIndicatorState204.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent102.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState203, scaleIndicatorState204})
            Me.linearScaleStateIndicatorComponent102.ZOrder = 99
            ' 
            ' linearScaleStateIndicatorComponent103
            ' 
            Me.linearScaleStateIndicatorComponent103.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(112.5F, 167.8571F)
            Me.linearScaleStateIndicatorComponent103.IndicatorScale = Me.linearScaleComponent25
            Me.linearScaleStateIndicatorComponent103.Name = "Indicator2Gauge0_Scale6"
            Me.linearScaleStateIndicatorComponent103.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState205.IntervalLength = 75F
            scaleIndicatorState205.Name = "Colored"
            scaleIndicatorState205.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState205.StartValue = 25F
            scaleIndicatorState206.IntervalLength = 25F
            scaleIndicatorState206.Name = "Empty"
            scaleIndicatorState206.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent103.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState205, scaleIndicatorState206})
            Me.linearScaleStateIndicatorComponent103.ZOrder = 98
            ' 
            ' linearScaleStateIndicatorComponent104
            ' 
            Me.linearScaleStateIndicatorComponent104.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(112.5F, 139.2857F)
            Me.linearScaleStateIndicatorComponent104.IndicatorScale = Me.linearScaleComponent25
            Me.linearScaleStateIndicatorComponent104.Name = "Indicator3Gauge0_Scale6"
            Me.linearScaleStateIndicatorComponent104.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState207.IntervalLength = 62.5F
            scaleIndicatorState207.Name = "Colored"
            scaleIndicatorState207.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState207.StartValue = 37.5F
            scaleIndicatorState208.IntervalLength = 37.5F
            scaleIndicatorState208.Name = "Empty"
            scaleIndicatorState208.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent104.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState207, scaleIndicatorState208})
            Me.linearScaleStateIndicatorComponent104.ZOrder = 97
            ' 
            ' linearScaleStateIndicatorComponent105
            ' 
            Me.linearScaleStateIndicatorComponent105.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(112.5F, 110.7143F)
            Me.linearScaleStateIndicatorComponent105.IndicatorScale = Me.linearScaleComponent25
            Me.linearScaleStateIndicatorComponent105.Name = "Indicator4Gauge0_Scale6"
            Me.linearScaleStateIndicatorComponent105.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState209.IntervalLength = 50F
            scaleIndicatorState209.Name = "Colored"
            scaleIndicatorState209.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState209.StartValue = 50F
            scaleIndicatorState210.IntervalLength = 50F
            scaleIndicatorState210.Name = "Empty"
            scaleIndicatorState210.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent105.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState209, scaleIndicatorState210})
            Me.linearScaleStateIndicatorComponent105.ZOrder = 96
            ' 
            ' linearScaleStateIndicatorComponent106
            ' 
            Me.linearScaleStateIndicatorComponent106.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(112.5F, 82.14286F)
            Me.linearScaleStateIndicatorComponent106.IndicatorScale = Me.linearScaleComponent25
            Me.linearScaleStateIndicatorComponent106.Name = "Indicator5Gauge0_Scale6"
            Me.linearScaleStateIndicatorComponent106.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState211.IntervalLength = 37.5F
            scaleIndicatorState211.Name = "Colored"
            scaleIndicatorState211.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState211.StartValue = 62.5F
            scaleIndicatorState212.IntervalLength = 62.5F
            scaleIndicatorState212.Name = "Empty"
            scaleIndicatorState212.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent106.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState211, scaleIndicatorState212})
            Me.linearScaleStateIndicatorComponent106.ZOrder = 95
            ' 
            ' linearScaleStateIndicatorComponent107
            ' 
            Me.linearScaleStateIndicatorComponent107.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(112.5F, 53.57143F)
            Me.linearScaleStateIndicatorComponent107.IndicatorScale = Me.linearScaleComponent25
            Me.linearScaleStateIndicatorComponent107.Name = "Indicator6Gauge0_Scale6"
            Me.linearScaleStateIndicatorComponent107.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState213.IntervalLength = 25F
            scaleIndicatorState213.Name = "Colored"
            scaleIndicatorState213.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState213.StartValue = 75F
            scaleIndicatorState214.IntervalLength = 75F
            scaleIndicatorState214.Name = "Empty"
            scaleIndicatorState214.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent107.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState213, scaleIndicatorState214})
            Me.linearScaleStateIndicatorComponent107.ZOrder = 94
            ' 
            ' linearScaleStateIndicatorComponent108
            ' 
            Me.linearScaleStateIndicatorComponent108.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(112.5F, 25F)
            Me.linearScaleStateIndicatorComponent108.IndicatorScale = Me.linearScaleComponent25
            Me.linearScaleStateIndicatorComponent108.Name = "Indicator7Gauge0_Scale6"
            Me.linearScaleStateIndicatorComponent108.Size = New System.Drawing.SizeF(19.29571F, 27.01399F)
            scaleIndicatorState215.IntervalLength = 12.5F
            scaleIndicatorState215.Name = "Colored"
            scaleIndicatorState215.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
            scaleIndicatorState215.StartValue = 87.5F
            scaleIndicatorState216.IntervalLength = 87.5F
            scaleIndicatorState216.Name = "Empty"
            scaleIndicatorState216.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent108.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {scaleIndicatorState215, scaleIndicatorState216})
            Me.linearScaleStateIndicatorComponent108.ZOrder = 93
            ' 
            ' graph1
            ' 
            Me.graph1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge1})
            Me.graph1.Location = New System.Drawing.Point(24, 47)
            Me.graph1.MaximumSize = New System.Drawing.Size(350, 350)
            Me.graph1.MinimumSize = New System.Drawing.Size(350, 350)
            Me.graph1.Name = "graph1"
            Me.graph1.Size = New System.Drawing.Size(350, 350)
            Me.graph1.TabIndex = 0
            ' 
            ' linearGauge1
            ' 
            Me.linearGauge1.AutoSize = DevExpress.Utils.DefaultBoolean.[False]
            Me.linearGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 338, 338)
            Me.linearGauge1.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() {Me.labelComponent1, Me.labelComponent2, Me.labelComponent3, Me.labelComponent4, Me.labelComponent5, Me.labelComponent6, Me.labelComponent7, Me.labelComponent8})
            Me.linearGauge1.Markers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent() {Me.linearScaleMarkerComponent1, Me.linearScaleMarkerComponent2, Me.linearScaleMarkerComponent3, Me.linearScaleMarkerComponent4})
            Me.linearGauge1.Name = "linearGauge1"
            Me.linearGauge1.Orientation = DevExpress.XtraGauges.Core.Model.ScaleOrientation.Horizontal
            Me.linearGauge1.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent() {Me.linearScaleRangeBarComponent1, Me.linearScaleRangeBarComponent2, Me.linearScaleRangeBarComponent3, Me.linearScaleRangeBarComponent4})
            Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent1, Me.linearScaleComponent2, Me.linearScaleComponent3, Me.linearScaleComponent4, Me.linearScaleComponent5, Me.linearScaleComponent6, Me.linearScaleComponent7, Me.linearScaleComponent8})
            ' 
            ' labelComponent1
            ' 
            Me.labelComponent1.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.labelComponent1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent1.Name = "titleRevenue"
            Me.labelComponent1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(30F, -27F)
            Me.labelComponent1.Size = New System.Drawing.SizeF(65F, 15F)
            Me.labelComponent1.Text = "Revenue"
            Me.labelComponent1.ZOrder = -1001
            ' 
            ' labelComponent2
            ' 
            Me.labelComponent2.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.labelComponent2.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent2.Name = "unitRevenue"
            Me.labelComponent2.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(30F, -15F)
            Me.labelComponent2.Size = New System.Drawing.SizeF(65F, 12F)
            Me.labelComponent2.Text = "U.S. $(1,000$)"
            Me.labelComponent2.ZOrder = -1001
            ' 
            ' labelComponent3
            ' 
            Me.labelComponent3.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.labelComponent3.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent3.Name = "titleProfit"
            Me.labelComponent3.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(30F, 27F)
            Me.labelComponent3.Size = New System.Drawing.SizeF(65F, 15F)
            Me.labelComponent3.Text = "Profit"
            Me.labelComponent3.ZOrder = -1001
            ' 
            ' labelComponent4
            ' 
            Me.labelComponent4.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.labelComponent4.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent4.Name = "unitProfit"
            Me.labelComponent4.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(30F, 35F)
            Me.labelComponent4.Size = New System.Drawing.SizeF(65F, 12F)
            Me.labelComponent4.Text = "%"
            Me.labelComponent4.ZOrder = -1001
            ' 
            ' labelComponent5
            ' 
            Me.labelComponent5.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.labelComponent5.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent5.Name = "titleNewCust"
            Me.labelComponent5.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(30F, 123F)
            Me.labelComponent5.Size = New System.Drawing.SizeF(65F, 15F)
            Me.labelComponent5.Text = "New Cust"
            Me.labelComponent5.ZOrder = -1001
            ' 
            ' labelComponent6
            ' 
            Me.labelComponent6.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.labelComponent6.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent6.Name = "unitNewCust"
            Me.labelComponent6.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(30F, 135F)
            Me.labelComponent6.Size = New System.Drawing.SizeF(65F, 12F)
            Me.labelComponent6.Text = "Count"
            Me.labelComponent6.ZOrder = -1001
            ' 
            ' labelComponent7
            ' 
            Me.labelComponent7.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.labelComponent7.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent7.Name = "unitAvgOrder"
            Me.labelComponent7.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(30F, 85F)
            Me.labelComponent7.Size = New System.Drawing.SizeF(65F, 12F)
            Me.labelComponent7.Text = "U.S. $"
            Me.labelComponent7.ZOrder = -1001
            ' 
            ' labelComponent8
            ' 
            Me.labelComponent8.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.labelComponent8.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent8.Name = "titleAvgOrder"
            Me.labelComponent8.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(30F, 73F)
            Me.labelComponent8.Size = New System.Drawing.SizeF(65F, 15F)
            Me.labelComponent8.Text = "Avg Order"
            Me.labelComponent8.ZOrder = -1001
            ' 
            ' linearScaleMarkerComponent1
            ' 
            Me.linearScaleMarkerComponent1.LinearScale = Me.linearScaleComponent2
            Me.linearScaleMarkerComponent1.Name = "revenueMarker"
            Me.linearScaleMarkerComponent1.Shader = New DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Black;Style2:]")
            Me.linearScaleMarkerComponent1.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.5F, 0.15F)
            Me.linearScaleMarkerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.MarkerPointerShapeType.Box
            Me.linearScaleMarkerComponent1.ZOrder = -150
            ' 
            ' linearScaleComponent2
            ' 
            Me.linearScaleComponent2.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.linearScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent2.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(-25F, 10F)
            Me.linearScaleComponent2.MajorTickCount = 7
            Me.linearScaleComponent2.MajorTickmark.ShapeOffset = -12F
            Me.linearScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default1
            Me.linearScaleComponent2.MajorTickmark.ShowText = False
            Me.linearScaleComponent2.MaxValue = 300F
            Me.linearScaleComponent2.MinorTickCount = 0
            Me.linearScaleComponent2.Name = "revenueComparativeMeasure"
            Me.linearScaleComponent2.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(-25F, 190F)
            Me.linearScaleComponent2.Value = 250F
            ' 
            ' linearScaleMarkerComponent2
            ' 
            Me.linearScaleMarkerComponent2.LinearScale = Me.linearScaleComponent4
            Me.linearScaleMarkerComponent2.Name = "profitMarker"
            Me.linearScaleMarkerComponent2.Shader = New DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Black;Style2:]")
            Me.linearScaleMarkerComponent2.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.5F, 0.15F)
            Me.linearScaleMarkerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.MarkerPointerShapeType.Box
            Me.linearScaleMarkerComponent2.ZOrder = -150
            ' 
            ' linearScaleComponent4
            ' 
            Me.linearScaleComponent4.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent4.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent4.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent4.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent4.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.linearScaleComponent4.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent4.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(25F, 10F)
            Me.linearScaleComponent4.MajorTickCount = 7
            Me.linearScaleComponent4.MajorTickmark.ShapeOffset = -12F
            Me.linearScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default1
            Me.linearScaleComponent4.MajorTickmark.ShowText = False
            Me.linearScaleComponent4.MaxValue = 30F
            Me.linearScaleComponent4.MinorTickCount = 0
            Me.linearScaleComponent4.Name = "profitComparativeMeasure"
            Me.linearScaleComponent4.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(25F, 190F)
            Me.linearScaleComponent4.Value = 26F
            ' 
            ' linearScaleMarkerComponent3
            ' 
            Me.linearScaleMarkerComponent3.LinearScale = Me.linearScaleComponent6
            Me.linearScaleMarkerComponent3.Name = "newCustMarker"
            Me.linearScaleMarkerComponent3.Shader = New DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Black;Style2:]")
            Me.linearScaleMarkerComponent3.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.5F, 0.15F)
            Me.linearScaleMarkerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.MarkerPointerShapeType.Box
            Me.linearScaleMarkerComponent3.ZOrder = -150
            ' 
            ' linearScaleComponent6
            ' 
            Me.linearScaleComponent6.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent6.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent6.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent6.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent6.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.linearScaleComponent6.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent6.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 10F)
            Me.linearScaleComponent6.MajorTickCount = 6
            Me.linearScaleComponent6.MajorTickmark.ShapeOffset = -12F
            Me.linearScaleComponent6.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default1
            Me.linearScaleComponent6.MajorTickmark.ShowText = False
            Me.linearScaleComponent6.MaxValue = 2500F
            Me.linearScaleComponent6.MinorTickCount = 0
            Me.linearScaleComponent6.Name = "newCustComparativeMeasure"
            Me.linearScaleComponent6.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 190F)
            Me.linearScaleComponent6.Value = 2100F
            ' 
            ' linearScaleMarkerComponent4
            ' 
            Me.linearScaleMarkerComponent4.LinearScale = Me.linearScaleComponent8
            Me.linearScaleMarkerComponent4.Name = "avgOrderMarker"
            Me.linearScaleMarkerComponent4.Shader = New DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Black;Style2:]")
            Me.linearScaleMarkerComponent4.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.5F, 0.15F)
            Me.linearScaleMarkerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.MarkerPointerShapeType.Box
            Me.linearScaleMarkerComponent4.ZOrder = -150
            ' 
            ' linearScaleComponent8
            ' 
            Me.linearScaleComponent8.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent8.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent8.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent8.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent8.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.linearScaleComponent8.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent8.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 10F)
            Me.linearScaleComponent8.MajorTickCount = 7
            Me.linearScaleComponent8.MajorTickmark.ShapeOffset = -12F
            Me.linearScaleComponent8.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default1
            Me.linearScaleComponent8.MajorTickmark.ShowText = False
            Me.linearScaleComponent8.MaxValue = 600F
            Me.linearScaleComponent8.MinorTickCount = 0
            Me.linearScaleComponent8.Name = "avgOrderComparativeMeasure"
            Me.linearScaleComponent8.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 190F)
            Me.linearScaleComponent8.Value = 550F
            ' 
            ' linearScaleRangeBarComponent1
            ' 
            Me.linearScaleRangeBarComponent1.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleRangeBarComponent1.EndOffset = 2F
            Me.linearScaleRangeBarComponent1.LinearScale = Me.linearScaleComponent1
            Me.linearScaleRangeBarComponent1.Name = "revenueRange"
            Me.linearScaleRangeBarComponent1.StartOffset = -2F
            Me.linearScaleRangeBarComponent1.ZOrder = -100
            ' 
            ' linearScaleComponent1
            ' 
            Me.linearScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(-25F, 10F)
            Me.linearScaleComponent1.MajorTickCount = 7
            Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent1.MajorTickmark.ShapeOffset = 10F
            Me.linearScaleComponent1.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.65F, 1F)
            Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default3
            Me.linearScaleComponent1.MajorTickmark.TextOffset = 22F
            Me.linearScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop
            Me.linearScaleComponent1.MaxValue = 300F
            Me.linearScaleComponent1.MinorTickCount = 0
            Me.linearScaleComponent1.Name = "revenue"
            linearScaleRange10.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E0E0E0")
            linearScaleRange10.EndThickness = 20F
            linearScaleRange10.EndValue = 300F
            linearScaleRange10.Name = "Range0"
            linearScaleRange10.ShapeOffset = -10F
            linearScaleRange10.StartThickness = 20F
            linearScaleRange10.StartValue = 225F
            linearScaleRange11.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            linearScaleRange11.EndThickness = 20F
            linearScaleRange11.EndValue = 225F
            linearScaleRange11.Name = "Range1"
            linearScaleRange11.ShapeOffset = -10F
            linearScaleRange11.StartThickness = 20F
            linearScaleRange11.StartValue = 150F
            linearScaleRange12.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
            linearScaleRange12.EndThickness = 20F
            linearScaleRange12.EndValue = 150F
            linearScaleRange12.Name = "Range2"
            linearScaleRange12.ShapeOffset = -10F
            linearScaleRange12.StartThickness = 20F
            Me.linearScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {linearScaleRange10, linearScaleRange11, linearScaleRange12})
            Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(-25F, 190F)
            Me.linearScaleComponent1.Value = 275F
            ' 
            ' linearScaleRangeBarComponent2
            ' 
            Me.linearScaleRangeBarComponent2.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleRangeBarComponent2.EndOffset = 2F
            Me.linearScaleRangeBarComponent2.LinearScale = Me.linearScaleComponent3
            Me.linearScaleRangeBarComponent2.Name = "profitRange"
            Me.linearScaleRangeBarComponent2.StartOffset = -2F
            Me.linearScaleRangeBarComponent2.ZOrder = -100
            ' 
            ' linearScaleComponent3
            ' 
            Me.linearScaleComponent3.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent3.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent3.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent3.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent3.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.linearScaleComponent3.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent3.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(25F, 10F)
            Me.linearScaleComponent3.MajorTickCount = 7
            Me.linearScaleComponent3.MajorTickmark.FormatString = "{0:F0}%"
            Me.linearScaleComponent3.MajorTickmark.ShapeOffset = 10F
            Me.linearScaleComponent3.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.65F, 1F)
            Me.linearScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default3
            Me.linearScaleComponent3.MajorTickmark.TextOffset = 22F
            Me.linearScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop
            Me.linearScaleComponent3.MaxValue = 30F
            Me.linearScaleComponent3.MinorTickCount = 0
            Me.linearScaleComponent3.Name = "profit"
            linearScaleRange13.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E0E0E0")
            linearScaleRange13.EndThickness = 20F
            linearScaleRange13.EndValue = 30F
            linearScaleRange13.Name = "Range0"
            linearScaleRange13.ShapeOffset = -10F
            linearScaleRange13.StartThickness = 20F
            linearScaleRange13.StartValue = 25F
            linearScaleRange14.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            linearScaleRange14.EndThickness = 20F
            linearScaleRange14.EndValue = 25F
            linearScaleRange14.Name = "Range1"
            linearScaleRange14.ShapeOffset = -10F
            linearScaleRange14.StartThickness = 20F
            linearScaleRange14.StartValue = 20F
            linearScaleRange15.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
            linearScaleRange15.EndThickness = 20F
            linearScaleRange15.EndValue = 20F
            linearScaleRange15.Name = "Range2"
            linearScaleRange15.ShapeOffset = -10F
            linearScaleRange15.StartThickness = 20F
            Me.linearScaleComponent3.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {linearScaleRange13, linearScaleRange14, linearScaleRange15})
            Me.linearScaleComponent3.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(25F, 190F)
            Me.linearScaleComponent3.Value = 22F
            ' 
            ' linearScaleRangeBarComponent3
            ' 
            Me.linearScaleRangeBarComponent3.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleRangeBarComponent3.EndOffset = 2F
            Me.linearScaleRangeBarComponent3.LinearScale = Me.linearScaleComponent5
            Me.linearScaleRangeBarComponent3.Name = "newCustRange"
            Me.linearScaleRangeBarComponent3.StartOffset = -2F
            Me.linearScaleRangeBarComponent3.ZOrder = -100
            ' 
            ' linearScaleComponent5
            ' 
            Me.linearScaleComponent5.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent5.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent5.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent5.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent5.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.linearScaleComponent5.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent5.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 10F)
            Me.linearScaleComponent5.MajorTickCount = 6
            Me.linearScaleComponent5.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent5.MajorTickmark.ShapeOffset = 10F
            Me.linearScaleComponent5.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.65F, 1F)
            Me.linearScaleComponent5.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default3
            Me.linearScaleComponent5.MajorTickmark.TextOffset = 22F
            Me.linearScaleComponent5.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop
            Me.linearScaleComponent5.MaxValue = 2500F
            Me.linearScaleComponent5.MinorTickCount = 0
            Me.linearScaleComponent5.Name = "newCust"
            linearScaleRange16.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E0E0E0")
            linearScaleRange16.EndThickness = 20F
            linearScaleRange16.EndValue = 2500F
            linearScaleRange16.Name = "Range0"
            linearScaleRange16.ShapeOffset = -10F
            linearScaleRange16.StartThickness = 20F
            linearScaleRange16.StartValue = 2000F
            linearScaleRange17.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            linearScaleRange17.EndThickness = 20F
            linearScaleRange17.EndValue = 2000F
            linearScaleRange17.Name = "Range1"
            linearScaleRange17.ShapeOffset = -10F
            linearScaleRange17.StartThickness = 20F
            linearScaleRange17.StartValue = 1450F
            linearScaleRange18.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
            linearScaleRange18.EndThickness = 20F
            linearScaleRange18.EndValue = 1450F
            linearScaleRange18.Name = "Range2"
            linearScaleRange18.ShapeOffset = -10F
            linearScaleRange18.StartThickness = 20F
            Me.linearScaleComponent5.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {linearScaleRange16, linearScaleRange17, linearScaleRange18})
            Me.linearScaleComponent5.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 190F)
            Me.linearScaleComponent5.Value = 2250F
            ' 
            ' linearScaleRangeBarComponent4
            ' 
            Me.linearScaleRangeBarComponent4.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleRangeBarComponent4.EndOffset = 2F
            Me.linearScaleRangeBarComponent4.LinearScale = Me.linearScaleComponent7
            Me.linearScaleRangeBarComponent4.Name = "avgOrderRange"
            Me.linearScaleRangeBarComponent4.StartOffset = -2F
            Me.linearScaleRangeBarComponent4.ZOrder = -100
            ' 
            ' linearScaleComponent7
            ' 
            Me.linearScaleComponent7.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent7.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent7.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent7.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent7.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            Me.linearScaleComponent7.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent7.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 10F)
            Me.linearScaleComponent7.MajorTickCount = 7
            Me.linearScaleComponent7.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent7.MajorTickmark.ShapeOffset = 10F
            Me.linearScaleComponent7.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.65F, 1F)
            Me.linearScaleComponent7.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default3
            Me.linearScaleComponent7.MajorTickmark.TextOffset = 22F
            Me.linearScaleComponent7.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop
            Me.linearScaleComponent7.MaxValue = 600F
            Me.linearScaleComponent7.MinorTickCount = 0
            Me.linearScaleComponent7.Name = "avgOrder"
            linearScaleRange19.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E0E0E0")
            linearScaleRange19.EndThickness = 20F
            linearScaleRange19.EndValue = 600F
            linearScaleRange19.Name = "Range0"
            linearScaleRange19.ShapeOffset = -10F
            linearScaleRange19.StartThickness = 20F
            linearScaleRange19.StartValue = 500F
            linearScaleRange20.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            linearScaleRange20.EndThickness = 20F
            linearScaleRange20.EndValue = 500F
            linearScaleRange20.Name = "Range1"
            linearScaleRange20.ShapeOffset = -10F
            linearScaleRange20.StartThickness = 20F
            linearScaleRange20.StartValue = 360F
            linearScaleRange21.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
            linearScaleRange21.EndThickness = 20F
            linearScaleRange21.EndValue = 360F
            linearScaleRange21.Name = "Range2"
            linearScaleRange21.ShapeOffset = -10F
            linearScaleRange21.StartThickness = 20F
            Me.linearScaleComponent7.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {linearScaleRange19, linearScaleRange20, linearScaleRange21})
            Me.linearScaleComponent7.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(75F, 190F)
            Me.linearScaleComponent7.Value = 320F
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.tabbedControlGroup1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(764, 497)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' tabbedControlGroup1
            ' 
            Me.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1"
            Me.tabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
            Me.tabbedControlGroup1.SelectedTabPage = Me.layoutControlGroup5
            Me.tabbedControlGroup1.Size = New System.Drawing.Size(744, 477)
            Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup5, Me.layoutControlGroup3, Me.layoutControlGroup4, Me.layoutControlGroup6, Me.layoutControlGroup2, Me.layoutControlGroup7})
            ' 
            ' layoutControlGroup5
            ' 
            Me.layoutControlGroup5.CustomizationFormText = "Rating Control"
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem9, Me.layoutControlItem12, Me.emptySpaceItem8, Me.emptySpaceItem9, Me.emptySpaceItem12, Me.emptySpaceItem13})
            Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup5.Name = "layoutControlGroup5"
            Me.layoutControlGroup5.Size = New System.Drawing.Size(720, 430)
            Me.layoutControlGroup5.Text = "Rating Control"
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.rating
            Me.layoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem9.CustomizationFormText = "layoutControlItem9"
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 75)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(720, 229)
            Me.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.ratingValue
            Me.layoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem12.CustomizationFormText = "Rating:"
            Me.layoutControlItem12.Location = New System.Drawing.Point(247, 304)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(248, 36)
            Me.layoutControlItem12.Text = "Rating:"
            Me.layoutControlItem12.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem12.TextVisible = False
            ' 
            ' emptySpaceItem8
            ' 
            Me.emptySpaceItem8.CustomizationFormText = "emptySpaceItem8"
            Me.emptySpaceItem8.Location = New System.Drawing.Point(0, 340)
            Me.emptySpaceItem8.Name = "emptySpaceItem8"
            Me.emptySpaceItem8.Size = New System.Drawing.Size(720, 90)
            ' 
            ' emptySpaceItem9
            ' 
            Me.emptySpaceItem9.CustomizationFormText = "emptySpaceItem9"
            Me.emptySpaceItem9.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem9.Name = "emptySpaceItem9"
            Me.emptySpaceItem9.Size = New System.Drawing.Size(720, 75)
            ' 
            ' emptySpaceItem12
            ' 
            Me.emptySpaceItem12.Location = New System.Drawing.Point(495, 304)
            Me.emptySpaceItem12.Name = "emptySpaceItem12"
            Me.emptySpaceItem12.Size = New System.Drawing.Size(225, 36)
            ' 
            ' emptySpaceItem13
            ' 
            Me.emptySpaceItem13.Location = New System.Drawing.Point(0, 304)
            Me.emptySpaceItem13.Name = "emptySpaceItem13"
            Me.emptySpaceItem13.Size = New System.Drawing.Size(247, 36)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.CustomizationFormText = "Equalizers"
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6, Me.layoutControlItem5, Me.emptySpaceItem2, Me.emptySpaceItem3})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(720, 430)
            Me.layoutControlGroup3.Text = "Level Indicator"
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.levelIndicator
            Me.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 90)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(720, 229)
            Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.equalizerLevel
            Me.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem5.CustomizationFormText = "Level:"
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 319)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(720, 49)
            Me.layoutControlItem5.Text = "Level:"
            Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 368)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(720, 62)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(720, 90)
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.AppearanceGroup.Options.UseTextOptions = True
            Me.layoutControlGroup4.AppearanceGroup.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show
            Me.layoutControlGroup4.CustomizationFormText = "Rating Controls"
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem7, Me.layoutControlItem8, Me.layoutControlItem7, Me.layoutControlItem11, Me.emptySpaceItem4, Me.emptySpaceItem10, Me.emptySpaceItem11})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(720, 430)
            Me.layoutControlGroup4.Text = "ProgressBars"
            ' 
            ' emptySpaceItem7
            ' 
            Me.emptySpaceItem7.CustomizationFormText = "emptySpaceItem7"
            Me.emptySpaceItem7.Location = New System.Drawing.Point(495, 46)
            Me.emptySpaceItem7.Name = "emptySpaceItem7"
            Me.emptySpaceItem7.Size = New System.Drawing.Size(225, 353)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.progress2
            Me.layoutControlItem8.CustomizationFormText = "layoutControlItem8"
            Me.layoutControlItem8.Location = New System.Drawing.Point(341, 46)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(154, 304)
            Me.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.progress1
            Me.layoutControlItem7.CustomizationFormText = "layoutControlItem7"
            Me.layoutControlItem7.Location = New System.Drawing.Point(187, 46)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(154, 304)
            Me.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.progressValue
            Me.layoutControlItem11.CustomizationFormText = "Value:"
            Me.layoutControlItem11.Location = New System.Drawing.Point(187, 350)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(308, 49)
            Me.layoutControlItem11.Text = "Progress:"
            Me.layoutControlItem11.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4"
            Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 46)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(187, 353)
            ' 
            ' emptySpaceItem10
            ' 
            Me.emptySpaceItem10.CustomizationFormText = "emptySpaceItem10"
            Me.emptySpaceItem10.Location = New System.Drawing.Point(0, 399)
            Me.emptySpaceItem10.Name = "emptySpaceItem10"
            Me.emptySpaceItem10.Size = New System.Drawing.Size(720, 31)
            ' 
            ' emptySpaceItem11
            ' 
            Me.emptySpaceItem11.CustomizationFormText = "emptySpaceItem11"
            Me.emptySpaceItem11.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem11.Name = "emptySpaceItem11"
            Me.emptySpaceItem11.Size = New System.Drawing.Size(720, 46)
            ' 
            ' layoutControlGroup6
            ' 
            Me.layoutControlGroup6.CustomizationFormText = "Loading Panel"
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem10, Me.emptySpaceItem5, Me.emptySpaceItem6})
            Me.layoutControlGroup6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup6.Name = "layoutControlGroup6"
            Me.layoutControlGroup6.Size = New System.Drawing.Size(720, 430)
            Me.layoutControlGroup6.Text = "Loading Progress"
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.rating1
            Me.layoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem10.CustomizationFormText = "layoutControlItem10"
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 16)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(720, 404)
            Me.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' emptySpaceItem5
            ' 
            Me.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5"
            Me.emptySpaceItem5.Location = New System.Drawing.Point(0, 420)
            Me.emptySpaceItem5.Name = "emptySpaceItem5"
            Me.emptySpaceItem5.Size = New System.Drawing.Size(720, 10)
            ' 
            ' emptySpaceItem6
            ' 
            Me.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6"
            Me.emptySpaceItem6.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem6.Name = "emptySpaceItem6"
            Me.emptySpaceItem6.Size = New System.Drawing.Size(720, 16)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.CustomizationFormText = "Bullet Graphs"
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.emptySpaceItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(720, 430)
            Me.layoutControlGroup2.Text = "DashBoard Elements: Bullet Graphs"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.graph1
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopCenter
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(354, 430)
            Me.layoutControlItem1.Text = "1) Digits"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.graph2
            Me.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopCenter
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(354, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(354, 430)
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(708, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(12, 430)
            ' 
            ' layoutControlGroup7
            ' 
            Me.layoutControlGroup7.CustomizationFormText = "Equalizer"
            Me.layoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.layoutControlGroup7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup7.Name = "layoutControlGroup7"
            Me.layoutControlGroup7.Size = New System.Drawing.Size(720, 430)
            Me.layoutControlGroup7.Text = "Equalizer"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.equalizer
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(141, 61)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(100, 100, 100, 100)
            Me.layoutControlItem3.Size = New System.Drawing.Size(720, 430)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' loadingTimer
            ' 
            Me.loadingTimer.Interval = 500
            AddHandler Me.loadingTimer.Tick, New System.EventHandler(AddressOf Me.OnLoadingTimerTick)
            ' 
            ' equalizerTimer
            ' 
            AddHandler Me.equalizerTimer.Tick, New System.EventHandler(AddressOf Me.OnEqualizerTimerTick)
            ' 
            ' NewPresets
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "NewPresets"
            Me.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
            Me.Size = New System.Drawing.Size(764, 513)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.linearGauge9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent86), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent87), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent88), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent89), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent90), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent91), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent92), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent93), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent94), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent95), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ratingValue.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.progressValue.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.progressValue), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.equalizerLevel.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.equalizerLevel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearGauge8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent81), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent82), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent83), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent84), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent85), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearGauge5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleBackgroundLayerComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent36), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent37), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent38), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent39), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent40), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent41), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent42), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent43), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent44), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent45), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent46), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent47), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent48), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent49), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent50), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent51), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent52), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent53), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent54), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent55), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent56), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent57), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent58), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent59), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent60), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearGauge7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent71), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent72), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent73), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent74), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent75), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent76), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent77), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent78), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent79), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent80), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearGauge6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent61), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent62), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent63), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent64), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent65), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent66), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent67), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent68), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent69), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent70), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearGauge2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleMarkerComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleMarkerComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleMarkerComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleRangeBarComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleRangeBarComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleRangeBarComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearGauge3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent22), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent22), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent23), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent24), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent25), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent23), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent26), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent27), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent28), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent29), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent30), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent31), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent32), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent33), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent24), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent34), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent35), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent96), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent97), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent98), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent99), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent100), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent101), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent25), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent102), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent103), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent104), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent105), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent106), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent107), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleStateIndicatorComponent108), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleMarkerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleMarkerComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleMarkerComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleMarkerComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleRangeBarComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleRangeBarComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleRangeBarComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleRangeBarComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabbedControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private graph1 As DevExpress.XtraGauges.Win.GaugeControl

        Private graph2 As DevExpress.XtraGauges.Win.GaugeControl

        Private linearGauge2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private labelComponent9 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private labelComponent10 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private labelComponent11 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private labelComponent12 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private labelComponent13 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private labelComponent14 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private linearScaleMarkerComponent5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent

        Private linearScaleComponent10 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleMarkerComponent6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent

        Private linearScaleComponent12 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleMarkerComponent7 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent

        Private linearScaleComponent14 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleRangeBarComponent5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent

        Private linearScaleComponent9 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleRangeBarComponent6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent

        Private linearScaleComponent11 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleRangeBarComponent7 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent

        Private linearScaleComponent13 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private labelComponent1 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private labelComponent2 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private labelComponent3 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private labelComponent4 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private labelComponent5 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private labelComponent6 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private labelComponent7 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private labelComponent8 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private linearScaleMarkerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent

        Private linearScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleMarkerComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent

        Private linearScaleComponent4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleMarkerComponent3 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent

        Private linearScaleComponent6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleMarkerComponent4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent

        Private linearScaleComponent8 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent

        Private linearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleRangeBarComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent

        Private linearScaleComponent3 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleRangeBarComponent3 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent

        Private linearScaleComponent5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleRangeBarComponent4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent

        Private equalizerLevel As DevExpress.XtraEditors.TrackBarControl

        Private levelIndicator As DevExpress.XtraGauges.Win.GaugeControl

        Private linearGauge5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private linearScaleComponent17 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleStateIndicatorComponent36 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent37 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent38 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent39 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent40 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent41 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent42 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent43 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent44 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent45 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent46 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent47 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent48 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent49 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent50 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent51 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent52 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent53 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent54 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent55 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent56 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent57 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent58 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent59 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent60 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private rating1 As DevExpress.XtraGauges.Win.GaugeControl

        Private rating As DevExpress.XtraGauges.Win.GaugeControl

        Private linearGauge8 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleStateIndicatorComponent81 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleComponent20 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleStateIndicatorComponent82 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent83 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent84 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent85 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private progress2 As DevExpress.XtraGauges.Win.GaugeControl

        Private linearGauge7 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleStateIndicatorComponent71 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleComponent19 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleStateIndicatorComponent72 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent73 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent74 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent75 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent76 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent77 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent78 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent79 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent80 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private progress1 As DevExpress.XtraGauges.Win.GaugeControl

        Private linearGauge6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleStateIndicatorComponent61 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleComponent18 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleStateIndicatorComponent62 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent63 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent64 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent65 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent66 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent67 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent68 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent69 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent70 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private progressValue As DevExpress.XtraEditors.TrackBarControl

        Private ratingValue As DevExpress.XtraEditors.RadioGroup

        Private loadingTimer As System.Windows.Forms.Timer

        Private linearGauge9 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleStateIndicatorComponent86 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleComponent21 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleStateIndicatorComponent87 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent88 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent89 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent90 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent91 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent92 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent93 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent94 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent95 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private equalizer As DevExpress.XtraGauges.Win.GaugeControl

        Private linearGauge3 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleStateIndicatorComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleComponent15 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleStateIndicatorComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent3 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent7 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent8 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent9 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleComponent16 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleStateIndicatorComponent10 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent11 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent12 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent13 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent14 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent15 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent16 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent17 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleComponent22 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleStateIndicatorComponent18 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent19 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent20 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent21 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent22 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent23 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent24 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent25 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleComponent23 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleStateIndicatorComponent26 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent27 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent28 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent29 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent30 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent31 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent32 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent33 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleComponent24 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleStateIndicatorComponent34 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent35 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent96 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent97 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent98 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent99 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent100 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent101 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleComponent25 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleStateIndicatorComponent102 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent103 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent104 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent105 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent106 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent107 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private linearScaleStateIndicatorComponent108 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent

        Private tabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup

        Private layoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private equalizerTimer As System.Windows.Forms.Timer

        Private linearScaleComponent7 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem12 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem13 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
