Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository
Imports System

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleTimeSpanEdit
        Inherits TutorialControl

        Private ReadOnly Property TimeSpanEdit As TimeSpanEdit
            Get
                Return timeSpanEdit1
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleTimeSpanEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "timespanedit"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Public Sub New()
            InitializeComponent()
            TimeSpanEdit.EditValue = New TimeSpan(75, 15, 30, 15, 400)
            TimeSpanEdit.Properties.MaskSettings.ShowAdvancedSettings = True
            TimeSpanEdit.Properties.MaskSettings.UseMaskAsDisplayFormat = True
            cbEditStyle.Properties.Items.AddEnum(GetType(TimeEditStyle))
            cbEditStyle.EditValue = TimeSpanEdit.Properties.TimeEditStyle
            cbEditStyle.SelectedItem = TimeSpanEdit.Properties.TimeEditStyle
            tseMinValue.EditValue = TimeSpanEdit.Properties.MinValue
            tseMaxValue.EditValue = TimeSpanEdit.Properties.MaxValue
            SubscribeEvents()
        End Sub

        Private Sub SubscribeEvents()
            AddHandler ceAllowNegativeValue.CheckStateChanged, AddressOf Me.OnMaskSettingCheckStateChanged
            AddHandler ceUseAdvancingCaret.CheckStateChanged, AddressOf Me.OnMaskSettingCheckStateChanged
            AddHandler cbDisplayFormat.SelectedIndexChanged, AddressOf OnDisplayFormatChanged
            AddHandler tseMinValue.EditValueChanged, AddressOf OnTouchUIMinValueChanged
            AddHandler tseMaxValue.EditValueChanged, AddressOf OnTouchUIMaxValueChanged
            AddHandler cbEditStyle.EditValueChanged, AddressOf OnEditStyleEditValueChanged
        End Sub

        Private Sub OnEditStyleEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            TimeSpanEdit.Properties.TimeEditStyle = CType(cbEditStyle.EditValue, TimeEditStyle)
        End Sub

        Private Sub OnTouchUIMinValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            tseMaxValue.Properties.MinValue = CType(tseMinValue.EditValue, TimeSpan?)
            TimeSpanEdit.Properties.MinValue = CType(tseMinValue.EditValue, TimeSpan?)
        End Sub

        Private Sub OnTouchUIMaxValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            tseMinValue.Properties.MaxValue = CType(tseMaxValue.EditValue, TimeSpan?)
            TimeSpanEdit.Properties.MaxValue = CType(tseMaxValue.EditValue, TimeSpan?)
        End Sub

        Private Sub OnMaskSettingCheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim timeSpanSettings = TimeSpanEdit.Properties.MaskSettings.Configure(Of MaskSettings.TimeSpan)()
            timeSpanSettings.AllowNegativeValues = ceAllowNegativeValue.Checked
            timeSpanSettings.UseAdvancingCaret = ceUseAdvancingCaret.Checked
        End Sub

        Private Sub OnModuleLoad(ByVal sender As Object, ByVal e As EventArgs)
            SetDisplayFormat()
            ShowValue()
        End Sub

        Private Sub SetDisplayFormat()
            cbDisplayFormat.Properties.Items.Add(New ImageComboBoxItem("Duration", "[d.]hh:mm:ss[.fff]"))
            cbDisplayFormat.Properties.Items.Add(New ImageComboBoxItem("Constant pattern(c)", "c"))
            cbDisplayFormat.Properties.Items.Add(New ImageComboBoxItem("General short pattern", "g"))
            cbDisplayFormat.Properties.Items.Add(New ImageComboBoxItem("General long pattern", "G"))
            cbDisplayFormat.Properties.Items.Add(New ImageComboBoxItem("Timer", "dd DD hh HH mm MM"))
            cbDisplayFormat.Properties.Items.Add(New ImageComboBoxItem("Countdown Timer", "dd DD 'left'"))
            cbDisplayFormat.SelectedIndex = 0
        End Sub

        Private Sub ShowValue()
            Dim result As String = String.Empty
            If TimeSpanEdit.EditValue IsNot Nothing Then result = TimeSpanEdit.EditValue.ToString()
            lbValue.Text = result
        End Sub

        Private Sub OnTimeSpanEditEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ShowValue()
        End Sub

        Private Sub OnDisplayFormatChanged(ByVal sender As Object, ByVal e As EventArgs)
            TimeSpanEdit.Properties.MaskSettings.MaskExpression = CType(cbDisplayFormat.SelectedItem, ImageComboBoxItem).Value.ToString()
            teDisplayFormatString.Text = TimeSpanEdit.Properties.MaskSettings.MaskExpression
        End Sub
    End Class
End Namespace
