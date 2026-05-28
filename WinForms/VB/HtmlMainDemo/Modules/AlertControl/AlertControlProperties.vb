Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraLayout

Namespace DevExpress.HTML.Demos

    Public Partial Class AlertControlProperties
        Inherits XtraUserControl

        Private aControl As AlertControl

        Private _initValues As Boolean = False

        Public Sub New()
            InitializeComponent()
            InitProperties()
        End Sub

        Private Sub InitProperties()
            icbFormDisplaySpeed.Properties.Items.AddEnum(GetType(AlertFormDisplaySpeed))
            icbFormLocation.Properties.Items.AddEnum(GetType(AlertFormLocation))
            icbShowingEffect.Properties.Items.AddEnum(GetType(AlertFormShowingEffect))
        End Sub

        Public Sub Init(ByVal control As AlertControl)
            _initValues = True
            aControl = control
            seAutoFormDelay.EditValue = aControl.AutoFormDelay
            icbFormDisplaySpeed.EditValue = aControl.FormDisplaySpeed
            icbFormLocation.EditValue = aControl.FormLocation
            icbShowingEffect.EditValue = aControl.FormShowingEffect
            seFormMaxCount.Value = aControl.FormMaxCount
            _initValues = False
        End Sub

        '<seAutoFormDelay>
        Private Sub seAutoFormDelay_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues OrElse aControl Is Nothing Then Return
            aControl.AutoFormDelay = Convert.ToInt32(seAutoFormDelay.Value)
        End Sub

        '</seAutoFormDelay>
        '<icbFormDisplaySpeed>
        Private Sub icbFormDisplaySpeed_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.FormDisplaySpeed = CType(icbFormDisplaySpeed.EditValue, AlertFormDisplaySpeed)
        End Sub

        '</icbFormDisplaySpeed>
        '<icbFormLocation>
        Private Sub icbFormLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.FormLocation = CType(icbFormLocation.EditValue, AlertFormLocation)
        End Sub

        '</icbFormLocation>
        Private Sub icbShowingEffect_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.FormShowingEffect = CType(icbShowingEffect.EditValue, AlertFormShowingEffect)
        End Sub

        Private Sub seFormMaxCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.FormMaxCount = CInt(seFormMaxCount.Value)
        End Sub

        Public Function GetBestHeight() As Integer
            Dim bottom As Integer = 0
            For Each item As BaseLayoutItem In Root.Items
                If TypeOf item Is LayoutControlItem Then bottom = Math.Max(CType(item, LayoutControlItem).Control.Bounds.Bottom, bottom)
            Next

            Return bottom + Root.Padding.Height + layoutControl1.Padding.Vertical + layoutControl1.Margin.Vertical + Padding.Vertical + Margin.Vertical
        End Function
    'public void ApplyProperties(AlertControl ac) {
    '    ac.AutoFormDelay = Convert.ToInt32(seAutoFormDelay.Value);
    '    ac.FormMaxCount = (int)seFormMaxCount.Value;
    '    ac.FormShowingEffect = (AlertFormShowingEffect)icbShowingEffect.EditValue;
    '    ac.FormLocation = (AlertFormLocation)icbFormLocation.EditValue;
    '    ac.FormDisplaySpeed = (AlertFormDisplaySpeed)icbFormDisplaySpeed.EditValue;
    '    ac.FormDisplaySpeed = (AlertFormDisplaySpeed)icbFormDisplaySpeed.EditValue;
    '}
    End Class
End Namespace
