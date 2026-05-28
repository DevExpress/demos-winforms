Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraLayout

Namespace PhotoViewer

    Public Partial Class TrackBarFilterParams
        Inherits SimpleFilterParams

        Public Sub New()
            InitializeComponent()
            Dim trackBarItem As LayoutControlItem = New LayoutControlItem(Me.SimpleFilterParamsConvertedLayout, trackBarControl1)
            trackBarItem.Text = FilterText
            trackBarItem.SizeConstraintsType = SizeConstraintsType.Custom
            trackBarItem.MinSize = New Size(25, 50)
            trackBarItem.MaxSize = New Size(0, 50)
            trackBarItem.Move(applyButtonItem, DevExpress.XtraLayout.Utils.InsertType.Top)
        End Sub

        Public Overrides Function GetParams() As Object()
            Return New Object() {GetValue()}
        End Function

        Protected Overridable Sub OnBeforeShowTrackBarValueToolTip(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TrackBarValueToolTipEventArgs)
            e.ShowArgs.ToolTip = GetValue().ToString()
        End Sub

        Protected Overridable Function GetValue() As Single
            Return trackBarControl1.Value * 0.001F
        End Function

        Private Sub trackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdatePreview()
        End Sub

        Protected Overridable ReadOnly Property FilterText As String
            Get
                Return ""
            End Get
        End Property
    End Class

    Public Partial Class BrightnessFilterParams
        Inherits TrackBarFilterParams

        Protected Overrides ReadOnly Property FilterText As String
            Get
                Return "Brightness"
            End Get
        End Property

        Protected Overrides Function GetValue() As Single
            Return trackBarControl1.Value * 0.002F - 1.0F
        End Function
    End Class

    Public Partial Class ContrastFilterParams
        Inherits TrackBarFilterParams

        Protected Overrides ReadOnly Property FilterText As String
            Get
                Return "Contrast"
            End Get
        End Property

        Protected Overrides Function GetValue() As Single
            Return trackBarControl1.Value * 0.002F
        End Function
    End Class

    Public Partial Class SaturationFilterParams
        Inherits TrackBarFilterParams

        Protected Overrides ReadOnly Property FilterText As String
            Get
                Return "Saturation"
            End Get
        End Property

        Protected Overrides Function GetValue() As Single
            Return trackBarControl1.Value * 0.001F
        End Function
    End Class
End Namespace
