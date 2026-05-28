Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Menu

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class EditFormOptions
        Inherits XtraForm

        Private view As GridView

        Public Sub New(ByVal view As GridView, ByVal menuManager As IDXMenuManager)
            InitializeComponent()
            Me.view = view
            InitEditors(menuManager)
            InitData()
        End Sub

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitData()
            icbEditingMode.EditValue = view.OptionsBehavior.EditingMode
            icbActionOnModifiedRowChange.EditValue = view.OptionsEditForm.ActionOnModifiedRowChange
            icbBindingMode.EditValue = view.OptionsEditForm.BindingMode
            icbShowOnDoubleClick.EditValue = view.OptionsEditForm.ShowOnDoubleClick
            icbShowOnEnterKey.EditValue = view.OptionsEditForm.ShowOnEnterKey
            icbShowOnF2Key.EditValue = view.OptionsEditForm.ShowOnF2Key
            icbShowUpdateCancelPanel.EditValue = view.OptionsEditForm.ShowUpdateCancelPanel
            teFormCaptionFormat.Text = view.OptionsEditForm.FormCaptionFormat
            sePopupEditFormWidth.Value = view.OptionsEditForm.PopupEditFormWidth
        End Sub

        Private Sub InitEditors(ByVal menuManager As IDXMenuManager)
            For Each val As DefaultBoolean In [Enum].GetValues(GetType(DefaultBoolean))
                icbShowOnDoubleClick.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of DefaultBoolean).GetTitle(val), val, -1))
                icbShowOnEnterKey.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of DefaultBoolean).GetTitle(val), val, -1))
                icbShowOnF2Key.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of DefaultBoolean).GetTitle(val), val, -1))
                icbShowUpdateCancelPanel.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of DefaultBoolean).GetTitle(val), val, -1))
            Next

            For Each mode As GridEditingMode In [Enum].GetValues(GetType(GridEditingMode))
                If mode <> GridEditingMode.Default AndAlso mode <> GridEditingMode.Inplace Then icbEditingMode.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of GridEditingMode).GetTitle(mode), mode, -1))
            Next

            For Each action As EditFormModifiedAction In [Enum].GetValues(GetType(EditFormModifiedAction))
                icbActionOnModifiedRowChange.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of EditFormModifiedAction).GetTitle(action), action, -1))
            Next

            For Each mode As EditFormBindingMode In [Enum].GetValues(GetType(EditFormBindingMode))
                icbBindingMode.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of EditFormBindingMode).GetTitle(mode), mode, -1))
            Next

            For Each ctrl As Control In layoutControl1.Controls
                Dim edit As BaseEdit = TryCast(ctrl, BaseEdit)
                If edit IsNot Nothing Then edit.MenuManager = menuManager
            Next
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            view.OptionsBehavior.EditingMode = CType(icbEditingMode.EditValue, GridEditingMode)
            view.OptionsEditForm.ActionOnModifiedRowChange = CType(icbActionOnModifiedRowChange.EditValue, EditFormModifiedAction)
            view.OptionsEditForm.BindingMode = CType(icbBindingMode.EditValue, EditFormBindingMode)
            view.OptionsEditForm.ShowOnDoubleClick = CType(icbShowOnDoubleClick.EditValue, DefaultBoolean)
            view.OptionsEditForm.ShowOnEnterKey = CType(icbShowOnEnterKey.EditValue, DefaultBoolean)
            view.OptionsEditForm.ShowOnF2Key = CType(icbShowOnF2Key.EditValue, DefaultBoolean)
            view.OptionsEditForm.ShowUpdateCancelPanel = CType(icbShowUpdateCancelPanel.EditValue, DefaultBoolean)
            view.OptionsEditForm.FormCaptionFormat = teFormCaptionFormat.Text
            view.OptionsEditForm.PopupEditFormWidth = CInt(sePopupEditFormWidth.Value)
        End Sub
    End Class
End Namespace
