Imports System
Imports System.ComponentModel
Imports System.Drawing
' <icbScrollBars>
Imports DevExpress.XtraEditors.Controls
' </icbScrollBars>
Imports System.Windows.Forms
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleMemoExEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleMemoExEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "memoeditex"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private updateValues As Boolean = False

        Private Sub ModuleMemoExEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(memoExEditSample)
            memoExEditSample.Text = "This control allows end users to edit memo data within the dropdown window. This control is the best choice when you need to save form space or when you want to provide convenient memo editing in container controls like the XtraGrid. The MemoExEdit control combines the features found in the MemoEdit control and the BLOBEditor."
            InitComboBoxes()
            InitValues()
        End Sub

        Private Sub InitComboBoxes()
            ' <icbScrollBars>
            icbScrollBars.Properties.Items.AddEnum(GetType(ScrollBars))
            icbScrollBars.EditValue = memoExEditSample.Properties.ScrollBars
        ' </icbScrollBars>
        End Sub

        Private Sub InitValues()
            updateValues = True
            icbScrollBars.EditValue = memoExEditSample.Properties.ScrollBars
            ceIcon.Checked = memoExEditSample.Properties.ShowIcon
            cePopupSizeable.Checked = memoExEditSample.Properties.PopupSizeable
            ceWordWrap.Checked = memoExEditSample.Properties.WordWrap
            ceCustomIcons.Enabled = memoExEditSample.Properties.ShowIcon
            ceAutoHideScrollBars.Checked = memoExEditSample.Properties.AutoHideScrollBars = Utils.DefaultBoolean.True
            updateValues = False
        End Sub

        ' <icbScrollBars>
        Private Sub icbScrollBars_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            memoExEditSample.Properties.ScrollBars = CType(icbScrollBars.EditValue, ScrollBars)
        End Sub

        ' </icbScrollBars>
        ' <ceIcon>
        Private Sub ceIcon_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            memoExEditSample.Properties.ShowIcon = ceIcon.Checked
            ' <ceCustomIcons>
            ceCustomIcons.Enabled = memoExEditSample.Properties.ShowIcon
        ' </ceCustomIcons>
        End Sub

        ' </ceIcon>
        ' <cePopupSizeable>
        Private Sub cePopupSizeable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            memoExEditSample.Properties.PopupSizeable = cePopupSizeable.Checked
        End Sub

        ' </cePopupSizeable>
        ' <ceWordWrap>
        Private Sub ceWordWrap_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            memoExEditSample.Properties.WordWrap = ceWordWrap.Checked
        End Sub

        ' </ceWordWrap>
        ' <ceAutoHideScrollBars>
        Private Sub ceAutoHideScrollBars_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            memoExEditSample.Properties.AutoHideScrollBars = If(ceAutoHideScrollBars.Checked, Utils.DefaultBoolean.True, Utils.DefaultBoolean.False)
            ' <skip>
            If ceAutoHideScrollBars.Checked AndAlso memoExEditSample.Properties.ScrollBars = ScrollBars.None Then icbScrollBars.EditValue = ScrollBars.Vertical
        ' </skip>
        End Sub

        ' </ceAutoHideScrollBars>
        ' <ceCustomIcons>
        Private Sub ceCustomIcons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            memoExEditSample.Properties.Images = If(ceCustomIcons.Checked, imageCollection1, Nothing)
        End Sub
    ' </ceCustomIcons>
    End Class
End Namespace
