Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Diagnostics
' </hyperLinkEdit2>
' <icbWindowStyle>
' <icbAlignment>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleHyperLinkEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            hyperLinkImage = hyperLinkEditSample.Properties.ContextImageOptions.SvgImage
            If tabPane1 IsNot Nothing Then AddHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleHyperLinkEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "hyperlinkedit"
            End Get
        End Property

        Private hyperLinkImage As Utils.Svg.SvgImage = Nothing

        Private updateValues As Boolean = False

        Private Sub ModuleHyperLinkEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            Tutorials.ControlUtils.CenterControlInParent(hyperLinkEditSample)
            InitComboBoxes()
            InitValues()
        End Sub

        Protected Overrides Sub UnsubscribeOnEvents()
            MyBase.UnsubscribeOnEvents()
            If tabPane1 IsNot Nothing Then RemoveHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
        End Sub

        Private Sub OnSelectedPageChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
            CalcContentCore()
        End Sub

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
            CalcLayoutControlBounds(layoutControl2)
        End Sub

        Private Sub InitComboBoxes()
            ' <icbWindowStyle>
            icbWindowStyle.Properties.Items.AddEnum(GetType(ProcessWindowStyle))
            ' </icbWindowStyle>
            ' <icbAlignment>
            icbAlignment.Properties.Items.AddEnum(GetType(ContextImageAlignment))
        ' </icbAlignment>
        End Sub

        Private Sub InitValues()
            lbStartKey.Text = hyperLinkEditSample.Properties.StartKey.ToString()
            lbAddress.Text = hyperLinkEditSample.Text
            updateValues = True
            icbWindowStyle.EditValue = hyperLinkEditSample.Properties.BrowserWindowStyle
            ceSingleClick.Checked = hyperLinkEditSample.Properties.SingleClick
            teCaption.Text = hyperLinkEditSample.Properties.Caption
            icbAlignment.EditValue = hyperLinkEditSample.Properties.ContextImageOptions.Alignment
            colorEditLinkColor.Color = hyperLinkEditSample.Properties.LinkColor
            updateValues = False
        End Sub

        ' <icbWindowStyle>
        Private Sub icbWindowStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            hyperLinkEditSample.Properties.BrowserWindowStyle = CType(icbWindowStyle.EditValue, ProcessWindowStyle)
        End Sub

        ' </icbWindowStyle>
        ' <ceSingleClick>
        Private Sub ceSingleClick_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            hyperLinkEditSample.Properties.SingleClick = ceSingleClick.Checked
        End Sub

        ' </ceSingleClick>
        ' <teCaption>
        Private Sub teCaption_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            hyperLinkEditSample.Properties.Caption = teCaption.Text
        End Sub

        ' </teCaption>
        ' <sbImageSet>
        Private Sub sbImageSet_Click(ByVal sender As Object, ByVal e As EventArgs)
            hyperLinkEditSample.Properties.ContextImageOptions.SvgImage = hyperLinkImage
        End Sub

        ' </sbImageSet>
        ' <sbImageClear>
        Private Sub sbImageClear_Click(ByVal sender As Object, ByVal e As EventArgs)
            hyperLinkEditSample.Properties.ContextImageOptions.SvgImage = Nothing
        End Sub

        ' </sbImageClear>
        ' <icbAlignment>
        Private Sub icbAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            hyperLinkEditSample.Properties.ContextImageOptions.Alignment = CType(icbAlignment.EditValue, ContextImageAlignment)
        End Sub

        ' </icbAlignment>
        ' <colorEditLinkColor>
        Private Sub colorEditLinkColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            hyperLinkEditSample.Properties.LinkColor = colorEditLinkColor.Color
        End Sub

        ' </colorEditLinkColor>
        ' <hyperLinkEdit2>
        Private Sub hyperLinkEdit2_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            Dim editor As HyperLinkEdit = TryCast(sender, HyperLinkEdit)
            editor.ShowBrowser("https://www.devexpress.com/ClientCenter/Order/?group=.NET")
        End Sub

        ' </hyperLinkEdit2>
        ' <hyperLinkEdit1>
        Private Sub ShowEvent(ByVal eventString As String, ByVal data As String)
            meFiringEvents.Text = String.Format("{0}: {1}" & Microsoft.VisualBasic.Constants.vbCrLf, eventString, data) & meFiringEvents.Text
        End Sub

        Private Sub hyperLinkEdit_OpenLink(ByVal sender As Object, ByVal e As XtraEditors.Controls.OpenLinkEventArgs)
            ShowEvent("OpenLink", e.EditValue.ToString())
        End Sub
    ' </hyperLinkEdit1>
    End Class
End Namespace
