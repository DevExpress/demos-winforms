Imports Microsoft.VisualBasic
Imports DevExpress.Utils
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Frames
Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar
Imports DevExpress.DXperience.Demos
Imports DevExpress.Tutorials
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.Utils.About
Imports DevExpress.DemoData.Core
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.Xpo.Demos
    Partial Public Class frmMain
        Inherits RibbonMainForm
        Implements IWhatsThisProvider
        Public Const DemoNameConst As String = "Tutorial examples for the " & AssemblyInfo.SRAssemblyXpo
        Protected Overrides ReadOnly Property DemoName() As String
            Get
                Return DemoNameConst
            End Get
        End Property
        Protected fHintVisible As Boolean = True
        Private ftInfo As New FormTutorialInfo()
        Private fbbiWizard As ButtonBarItem
        Public ReadOnly Property bbiWizard() As ButtonBarItem
            Get
                Return fbbiWizard
            End Get
        End Property

        Public Sub New()
            ftInfo.SourceFileComment = "'"
            ftInfo.SourceFileType = SourceFileType.VB
        End Sub
        Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
            Dim mng As New RibbonMenuManager(Me)
            ReservGroup1.Text = "What's this?"
            fbbiWizard = New ButtonBarItem(Manager, String.Empty, New ItemClickEventHandler(AddressOf bbiWizard_Click))
            ReservGroup1.ItemLinks.Add(bbiWizard)
            SetWhatsThisButtonActive()
            AddHandler Resize, AddressOf MainTutorialForm_Resize
            Return mng
        End Function
        Protected Overrides Sub SetFormParam()
            accordionControl1.Parent.Width = 320
            Icon = Resources.AppIcon
        End Sub
        Protected Overloads Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel)
            TutorialsInfo.ShowModule(name, group, RibbonMenuManager)

        End Sub
        Protected Overrides Sub FillNavBar()
            MyBase.FillNavBar()
            TutorialRegistration.Register()
            For Each nbg As AccordionControlElement In accordionControl1.Elements
                'nbg.Hint = nbg.Text
                CheckAccordionControlElements(nbg)
            Next nbg
        End Sub
        Protected Sub CheckAccordionControlElements(ByVal elem As AccordionControlElement)
            For Each nbi As AccordionControlElement In elem.Elements
                If (nbi.Text = "Generating Persistent Classes for an Existing Database") Then
                    nbi.Visible = False
                    Continue For
                End If
                If (nbi.Text = "Stored Procedures") Then
                    nbi.Visible = False
                End If
            Next nbi
        End Sub

        Protected Overrides Sub ShowAbout()
            AboutHelper.Show(ProductKind.XPO)
        End Sub

        Public Sub EnableService(ByVal val As Boolean)
            accordionControl1.Enabled = val
            For Each item As BarItem In Manager.Items
                If (Not item.Equals(bbiWizard)) Then
                    item.Enabled = val
                End If
            Next item
            If val Then
                SetWhatsThisButtonActive()
            Else
                SetWhatsThisButtonNotActive()
            End If
        End Sub

        Protected Overrides ReadOnly Property AllowNavBarFilter() As Boolean
            Get
                Return False
            End Get
        End Property

        Private Sub SetWhatsThisButtonActive()
            bbiWizard.BeginUpdate()
            bbiWizard.Caption = "Show code..."
            bbiWizard.Glyph = Resources.Wizard_16x16
            bbiWizard.LargeGlyph = Resources.ShowCode_32x32
            bbiWizard.EndUpdate()
        End Sub

        Private Sub SetWhatsThisButtonNotActive()
            bbiWizard.BeginUpdate()
            bbiWizard.Caption = "Stop"
            bbiWizard.Glyph = Resources.Wizard_16x16
            bbiWizard.LargeGlyph = Resources.ShowCode_32x32
            bbiWizard.EndUpdate()
        End Sub

        Private Sub bbiWizard_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim tc As TutorialControl = TryCast(ModulesInfo.Instance.CurrentModuleBase?.TModule, TutorialControl)
            If tc IsNot Nothing Then
                tc.ShowWhatsThis()
            End If
        End Sub

        Private Sub MainTutorialForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim tc As TutorialControl = TryCast(ModulesInfo.Instance.CurrentModuleBase?.TModule, TutorialControl)
            If tc IsNot Nothing Then
                tc.DisableWhatsThis()
            End If
        End Sub

#Region "IWhatsThisProvider Members"

        Private ReadOnly Property CurrentModule() As UserControl Implements IWhatsThisProvider.CurrentModule
            Get
                Return CType(ModulesInfo.Instance.CurrentModuleBase.TModule, UserControl)
            End Get
        End Property

        Private Shadows ReadOnly Property CurrentShader() As ImageShaderBase Implements IWhatsThisProvider.CurrentShader
            Get
                Return New ImageShaderDisable()
            End Get
        End Property

        Private Shadows Property HintVisible() As Boolean Implements IWhatsThisProvider.HintVisible
            Get
                Return fHintVisible
            End Get
            Set(ByVal value As Boolean)
                fHintVisible = value
            End Set
        End Property

        Private ReadOnly Property IWhatsThisProvider_TutorialInfo() As FormTutorialInfo Implements IWhatsThisProvider.TutorialInfo
            Get
                Return ftInfo
            End Get
        End Property
#End Region

        Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
            WebDevServerHelper.CloseWebServers()
        End Sub
    End Class
End Namespace
