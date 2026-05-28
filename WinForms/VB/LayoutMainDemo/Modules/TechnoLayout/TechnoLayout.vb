Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing.Animation
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class TechnoLayout
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            CType(facesUserControl1.layoutControl1, ILayoutControl).EnableCustomizationMode = True
            rgFlowDirection.Properties.Items.AddEnum(GetType(FlowDirection))
            rgFlowDirection.SelectedIndex = 0
        End Sub

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "TechnoLayout"
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"TechnoLayout"}
            End Get
        End Property

        '<ztbcSize>
        Private Sub ztbcSize_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            facesUserControl1.layoutControl1.BeginUpdate()
            Try
                For Each item As LayoutControlItem In facesUserControl1.lcgFaces.Items
                    item.Size = New Size(CInt(Math.Round(ztbcSize.Value * Skins.DpiProvider.Default.DpiScaleFactor)), CInt(Math.Round(ztbcSize.Value * Skins.DpiProvider.Default.DpiScaleFactor)))
                Next
            Finally
                facesUserControl1.layoutControl1.EndUpdate()
            End Try
        End Sub

        '</ztbcSize>
        '<ztbcSpacing>
        Private Sub ztbcSpacing_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            facesUserControl1.layoutControl1.BeginUpdate()
            Try
                For Each item As LayoutControlItem In facesUserControl1.lcgFaces.Items
                    item.Spacing = New Utils.Padding(CInt(Math.Round(ztbcSpacing.Value * Skins.DpiProvider.Default.DpiScaleFactor)))
                Next
            Finally
                facesUserControl1.layoutControl1.EndUpdate()
            End Try
        End Sub

        '</ztbcSpacing>
        Private Sub cheCustomizationMode_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            CType(facesUserControl1.layoutControl1, ILayoutControl).EnableCustomizationMode = cheCustomizationMode.Checked
        End Sub

        '<rgFlowDirection>
        Private Sub rgFlowDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            facesUserControl1.lcgFaces.FlowDirection = CType(rgFlowDirection.Properties.Items(rgFlowDirection.SelectedIndex).Value, FlowDirection)
        End Sub
    '</rgFlowDirection>
    End Class
End Namespace
