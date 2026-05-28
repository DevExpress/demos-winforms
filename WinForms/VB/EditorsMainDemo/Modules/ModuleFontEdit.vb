Imports System
Imports System.ComponentModel
Imports System.Drawing
' <ceShowCustomButtons>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleFontEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleFontEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "fontEdit"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private updateValues As Boolean = False

        Private Sub ModuleCalcEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(fontEditSample)
            InitValues()
            fontEditSample.EditValue = Font.FontFamily.GetName(0)
            cbFontSize.EditValue = fontEditSample.Properties.AppearanceDropDown.Font.Size.ToString()
        End Sub

        Private Sub InitValues()
            updateValues = True
            seRUItemCount.Value = fontEditSample.Properties.RecentlyUsedItemCount
            ceShowSymbolPreview.Checked = fontEditSample.Properties.ShowSymbolFontPreview
            updateValues = False
        End Sub

        '<seRUItemCount>
        Private Sub seRUItemCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            fontEditSample.Properties.RecentlyUsedItemCount = Convert.ToInt32(seRUItemCount.Value)
        End Sub

        '</seRUItemCount>
        '<ceShowSymbolPreview>
        Private Sub ceShowSymbolPreview_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            fontEditSample.Properties.ShowSymbolFontPreview = ceShowSymbolPreview.Checked
        End Sub

        Private Sub cbFontSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            fontEditSample.Properties.AppearanceDropDown.Font = New Font(DefaultFont.Name, Convert.ToInt32(cbFontSize.EditValue))
        End Sub
    '</ceShowSymbolPreview>
    End Class
End Namespace
