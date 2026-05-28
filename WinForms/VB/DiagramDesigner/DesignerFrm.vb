Imports System
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Diagram.Core
Imports DevExpress.DXperience.Demos
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.About
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraDiagram.Designer
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class DesignerFrm
        Inherits DiagramDesignerForm

        Public Sub New()
            InitializeComponent()
            UserSkins.BonusSkins.Register()
            Enumerable.Last(Ribbon.Pages).Groups.Add(rpgAppearance)
            Call MainFormHelper.RegisterRibbonDefaultBonusSkin()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitializeForm()
            SetupAppearanceGroup()
        End Sub

        Protected Sub InitializeForm()
            Icon = LoadDefaultIcon()
            WindowState = FormWindowState.Maximized
            AddSingleShape()
        End Sub

        Protected Sub AddSingleShape()
            Dim [single] As DiagramShape = New DiagramShape(BasicShapes.Rectangle, 20, 20, 200, 100)
            Diagram.Items.Add([single])
            Diagram.SelectItem([single])
        End Sub

        Protected Overrides Function LoadDefaultIcon() As Icon
            Dim assembly = GetType(DesignerFrm).Assembly
            Return ResourceImageHelperCore.CreateIconFromResources(assembly.GetManifestResourceNames().First(Function(x) x.Contains("DemoIcon.ico")), assembly)
        End Function

        Private Sub OnRoundedModeCheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim ci As BarCheckItem = TryCast(sender, BarCheckItem)
            WindowsFormsSettings.AllowRoundedWindowCorners = If(ci.Checked, DefaultBoolean.True, DefaultBoolean.Default)
        End Sub

        Private Sub RpgAppearance_CaptionButtonClick(ByVal sender As Object, ByVal e As RibbonPageGroupEventArgs)
            pmAppearance.ShowPopup(MousePosition)
        End Sub

        Private Sub SetupAppearanceGroup()
            Call SkinHelper.InitSkinPopupMenu(pmAppearance)
            For Each group As GalleryItemGroup In skinDropDownButtonItem1.DropDownGallery.Gallery.Groups
                group.Visible = NeedCheckGroup(group)
            Next
        End Sub

        Private Function NeedCheckGroup(ByVal group As GalleryItemGroup) As Boolean
            If Not group.HasVisibleItems() Then Return False
            Return group.Items.[Select](Function(x) CStr(x.Tag)).All(Function(y) SkinCollectionHelper.IsStandardSkins(y))
        End Function
    End Class
End Namespace
