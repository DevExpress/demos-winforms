Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraDiagram.Demos

    Public Class OptionsPanelGroupControl
        Inherits GroupControl

        Protected Shared ReadOnly OptionsPagePadding As Integer = 12

        Public Sub New()
            Dock = DockStyle.Top
        End Sub

        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            Padding = ScalePadding(Padding, ScaleDPI.ScaleFactor.Width)
            UpdateGroupHeight()
        End Sub

        Protected Overridable Sub UpdateGroupHeight()
            Size = New Size(Size.Width, CInt(Size.Height * ScaleDPI.ScaleFactor.Width))
        End Sub

        Private Function ScalePadding(ByVal padding As Padding, ByVal value As Double) As Padding
            Return New Padding(CInt(padding.Left * value), CInt(padding.Top * value), CInt(padding.Right * value), CInt(padding.Bottom * value))
        End Function
    End Class

    Public Class OptionsPanelTitleGroupControl
        Inherits OptionsPanelGroupControl

        Public Sub New()
            CaptionLocation = Locations.Top
            GroupStyle = GroupStyle.Title
            Padding = New Padding(OptionsPagePadding)
        End Sub

        Protected Overrides Sub UpdateGroupHeight()
            Size = New Size(Size.Width, ViewInfo.CaptionBounds.Height + GetClientHeight() + Padding.Vertical)
        End Sub

        Protected Overridable Function GetClientHeight() As Integer
            Return 0
        End Function
    End Class

    Public Class GroupControlWithRadioGroup
        Inherits OptionsPanelTitleGroupControl

        Private _RadioGroup As RadioGroup

        Public Sub New()
            RadioGroup = New RadioGroup()
            RadioGroup.Properties.Appearance.BackColor = Color.Transparent
            RadioGroup.Properties.Appearance.Options.UseBackColor = True
            RadioGroup.Properties.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            RadioGroup.Properties.Columns = 1
            RadioGroup.AutoSize = True
            RadioGroup.Dock = DockStyle.Top
            RadioGroup.Properties.Padding = New Padding(0)
            AddHandler RadioGroup.SizeChanged, AddressOf RadioGroup_SizeChanged
            Controls.Add(RadioGroup)
        End Sub

        Protected Overrides Function GetClientHeight() As Integer
            Return RadioGroup.Size.Height
        End Function

        Private Sub RadioGroup_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateGroupHeight()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Property RadioGroup As RadioGroup
            Get
                Return _RadioGroup
            End Get

            Private Set(ByVal value As RadioGroup)
                _RadioGroup = value
            End Set
        End Property

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            MyBase.Dispose(disposing)
            If RadioGroup IsNot Nothing Then RemoveHandler RadioGroup.SizeChanged, AddressOf RadioGroup_SizeChanged
        End Sub
    End Class

    Public Class GroupControlWithTrackBar
        Inherits OptionsPanelTitleGroupControl

        Public Sub New()
            trackBar = New OptionsPanelTrackBar()
            trackBar.Dock = DockStyle.Fill
            Controls.Add(trackBar)
            AddHandler trackBar.OnInitialized, AddressOf TrackBar_OnInitialized
        End Sub

        Public Overrides Sub EndInit()
            MyBase.EndInit()
            trackBar.ApplySettings(TrackBarSettings, New EventHandler(AddressOf InvokeTrackBarValueChanged))
        End Sub

        Private Sub InvokeTrackBarValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEvent TrackBarValueChanged(sender, e)
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public ReadOnly Property TrackBarSettings As TrackBarSettings
            Get
                If trackBarSettingsField Is Nothing Then trackBarSettingsField = New TrackBarSettings()
                Return trackBarSettingsField
            End Get
        End Property

        Public Event TrackBarValueChanged As EventHandler

        Protected Overrides Function GetClientHeight() As Integer
            Return CInt((trackBar.GetBestHeight() * trackBarInGroupHeightCoef))
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            MyBase.Dispose(disposing)
            If trackBar IsNot Nothing Then RemoveHandler trackBar.OnInitialized, AddressOf TrackBar_OnInitialized
        End Sub

        Private Shared ReadOnly trackBarInGroupHeightCoef As Double = 0.8

        Private trackBarSettingsField As TrackBarSettings

        Private trackBar As OptionsPanelTrackBar

        Private Sub TrackBar_OnInitialized(ByVal sender As Object, ByVal e As EventArgs)
            UpdateGroupHeight()
        End Sub
    End Class

    Public Class GroupControlWithTrackBars
        Inherits OptionsPanelTitleGroupControl

        Private _TrackBarsSettings As List(Of DevExpress.XtraDiagram.Demos.TrackBarSettings)

        Public Sub New()
            TrackBarsSettings = New List(Of TrackBarSettings)()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Property TrackBarsSettings As List(Of TrackBarSettings)
            Get
                Return _TrackBarsSettings
            End Get

            Private Set(ByVal value As List(Of TrackBarSettings))
                _TrackBarsSettings = value
            End Set
        End Property

        Public Overrides Sub EndInit()
            MyBase.EndInit()
            AddTrackBars(TrackBarsSettings)
        End Sub

        Public Event TrackBarsValueChanged As EventHandler

        Protected Overrides Function GetClientHeight() As Integer
            Return clientHeight
        End Function

        Private clientHeight As Integer

        Private trackBars As TrackBarControl()

        Private trackBarCaptionSuffix As String = ":"

        Private Sub AddTrackBars(ByVal trackBarsSettings As List(Of TrackBarSettings))
            Dim layoutControl As LayoutControl = New LayoutControl()
            Dim layoutControlGroup As LayoutControlGroup = New LayoutControlGroup()
            layoutControl.Root = layoutControlGroup
            layoutControl.Dock = DockStyle.Fill
            layoutControl.Margin = New Padding(0)
            layoutControlGroup.GroupBordersVisible = False
            layoutControlGroup.Padding = New XtraLayout.Utils.Padding(0)
            trackBars = New TrackBarControl(trackBarsSettings.Count - 1) {}
            Dim trackBarCaptionWidth As Integer = Enumerable.Select(Of TrackBarSettings, Global.System.Int32)(trackBarsSettings, CType(Function(x) CInt(CalcTextWidth(CStr(x.Caption))), Func(Of TrackBarSettings, Integer))).Max()
            For i As Integer = 0 To trackBarsSettings.Count - 1
                Dim group = New LayoutGroupWithTrackBar(trackBarsSettings(i), trackBarCaptionWidth, trackBarCaptionSuffix, AddressOf InvokeTrackBarValueChanged)
                trackBars(i) = group.TrackBar
                layoutControlGroup.Items.AddRange({group})
            Next

            Dim trackBarHeight As Integer = TryCast(layoutControlGroup.Items(0), LayoutGroupWithTrackBar).TrackBarBestHeight
            clientHeight = trackBarHeight * trackBarsSettings.Count
            UpdateGroupHeight()
            layoutControl.Controls.AddRange(trackBars)
            Controls.Add(layoutControl)
        End Sub

        Private Function CalcTextWidth(ByVal text As String) As Integer
            Dim label As LabelControl = New LabelControl()
            label.Text = text & trackBarCaptionSuffix & " "
            Return label.CalcBestSize().Width
        End Function

        Private Sub InvokeTrackBarValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEvent TrackBarsValueChanged(sender, e)
        End Sub
    End Class

    Public Class GroupControlWithSpinEdit
        Inherits OptionsPanelTitleGroupControl

        Private _SpinEdit As SpinEdit

        Public Sub New()
            SpinEdit = New SpinEdit()
            SpinEdit.Dock = DockStyle.Fill
            SpinEdit.Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
            UpdateGroupHeight()
            Controls.Add(SpinEdit)
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Property SpinEdit As SpinEdit
            Get
                Return _SpinEdit
            End Get

            Private Set(ByVal value As SpinEdit)
                _SpinEdit = value
            End Set
        End Property

        Protected Overrides Function GetClientHeight() As Integer
            Return SpinEdit.Size.Height
        End Function
    End Class

    Public Class TrackBarSettings

        Public Sub New()
        End Sub

        Public Property Min As Integer

        Public Property Max As Integer

        Public Property Caption As String

        Public Property Binding As Binding

        Public Property SmallChange As Integer

        Public Property LargeChange As Integer
    End Class

    Friend Class OptionsPanelTrackBar
        Inherits TrackBarControl

        Public Sub New()
            Properties.ShowValueToolTip = True
            Properties.ShowLabels = True
            Margin = New Padding(0)
        End Sub

        Public Function GetBestHeight() As Integer
            Return CInt((CalcMinHeight() * bestHeightCoef))
        End Function

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property MinValue As Integer
            Get
                Return If(min.HasValue, min.Value, 0)
            End Get

            Set(ByVal value As Integer)
                min = value
                If max.HasValue Then Initialize()
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property MaxValue As Integer
            Get
                Return If(max.HasValue, max.Value, 0)
            End Get

            Set(ByVal value As Integer)
                max = value
                If min.HasValue Then Initialize()
            End Set
        End Property

        Public Event OnInitialized As EventHandler

        Public Sub ApplySettings(ByVal settings As TrackBarSettings, ByVal valueChanged As EventHandler)
            MinValue = settings.Min
            MaxValue = settings.Max
            DataBindings.Add(settings.Binding)
            Properties.SmallChange = settings.SmallChange
            Properties.LargeChange = settings.LargeChange
            AddHandler ValueChanged, valueChanged
        End Sub

        Private min, max As Integer?

        Private Sub Initialize()
            Properties.Maximum = max.Value
            Properties.Minimum = min.Value
            Properties.TickFrequency =(max.Value - min.Value) \ 2
            Properties.Labels.AddRange({min.Value, (min.Value + max.Value) \ 2, max.Value}.[Select](Function(x) New Repository.TrackBarLabel(x.ToString(), x)).ToArray())
            RaiseEvent OnInitialized(Me, New EventArgs())
        End Sub

        Private Shared ReadOnly bestHeightCoef As Double = 0.76
    End Class

    Friend Class LayoutGroupWithTrackBar
        Inherits LayoutControlGroup

        Private _TrackBarBestHeight As Integer

        Public Sub New(ByVal settings As TrackBarSettings, ByVal captionWidth As Integer, ByVal captionSuffix As String, ByVal trackBarValueChanged As EventHandler)
            GroupBordersVisible = False
            Padding = New XtraLayout.Utils.Padding(0)
            Dim label As LabelControl = New LabelControl()
            label.Text = settings.Caption & captionSuffix
            label.MinimumSize = New Size(captionWidth, 0)
            trackBarField = New OptionsPanelTrackBar()
            trackBarField.ApplySettings(settings, trackBarValueChanged)
            TrackBarBestHeight = trackBarField.GetBestHeight()
            trackBarField.MaximumSize = New Size(Integer.MaxValue, TrackBarBestHeight)
            Dim labelLayoutItem As LayoutControlItem = New LayoutControlItem()
            labelLayoutItem.Control = label
            labelLayoutItem.TextVisible = False
            labelLayoutItem.Padding = New XtraLayout.Utils.Padding(0, 0, 2, 0)
            Dim trackLayoutBarItem As LayoutControlItem = New LayoutControlItem()
            trackLayoutBarItem.Control = trackBarField
            trackLayoutBarItem.SizeConstraintsType = SizeConstraintsType.Custom
            trackLayoutBarItem.MaxSize = New Size(Integer.MaxValue, TrackBarBestHeight)
            trackLayoutBarItem.MinSize = New Size(0, TrackBarBestHeight)
            trackLayoutBarItem.TextVisible = False
            trackLayoutBarItem.Padding = New XtraLayout.Utils.Padding(0)
            trackLayoutBarItem.Location = New Point(captionWidth, 0)
            Items.AddRange({labelLayoutItem, trackLayoutBarItem})
        End Sub

        Private trackBarField As OptionsPanelTrackBar

        Public ReadOnly Property TrackBar As TrackBarControl
            Get
                Return trackBarField
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property TrackBarBestHeight As Integer
            Get
                Return _TrackBarBestHeight
            End Get

            Private Set(ByVal value As Integer)
                _TrackBarBestHeight = value
            End Set
        End Property
    End Class
End Namespace
