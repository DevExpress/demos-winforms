Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.Tutorials
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.Xpo.Demos
	Friend Class WhatsThis
		Private whatsThisController As WhatsThisController
        Private _whatsThisEnabled As Boolean
        Private whatsThisModule As ModuleWhatsThis
        Private disableWhatsThisOnMove As Boolean
        Private form As frmMain
        Private [module] As UserControl
        Public ReadOnly Property WhatsThisEnabled() As Boolean
            Get
                Return _whatsThisEnabled
            End Get
        End Property

        Public Sub New(ByVal Form As frmMain, ByVal demoName As String)
            Dim ctrl As Control
            Dim toolTip1 As New ToolTip()
            toolTip1.IsBalloon = True
            toolTip1.AutoPopDelay = 0
            toolTip1.InitialDelay = 0
            Me.form = Form
            [module] = (CType(Me.form, IWhatsThisProvider)).CurrentModule

            Dim moduleInfo As TutorialRegistration = TutorialRegistration.GetInfo(demoName)
            If moduleInfo Is Nothing Then
                Throw New Exception("Tutorial not registered!")
            End If
            whatsThisController = New WhatsThisController(Me.form)
            whatsThisController.UpdateWhatsThisInfo(moduleInfo.XmlInfoFile, moduleInfo.CodeInfoFile)
            For Each item As WhatsThisControlEntry In whatsThisController.Collection
                ctrl = GetAllTypedControls([module], item.ControlName)
                If ctrl IsNot Nothing Then
                    toolTip1.SetToolTip(ctrl, item.PopupInfo.Caption)
                End If
            Next item

            whatsThisModule = New ModuleWhatsThis(whatsThisController)
            _whatsThisEnabled = False
            disableWhatsThisOnMove = True
            whatsThisModule.Parent = [module].Parent
            whatsThisModule.Dock = DockStyle.Fill
            whatsThisModule.Visible = False
        End Sub

        Private Function GetAllTypedControls(ByVal ctrl As Control, ByVal name As String) As Control
            Dim retCtrl As Control
            If ctrl.Name = name Then
                Return ctrl
            End If
            For Each ctrlChild As Control In ctrl.Controls
                retCtrl = GetAllTypedControls(ctrlChild, name)
                If retCtrl IsNot Nothing Then
                    Return retCtrl
                End If
            Next ctrlChild
            Return Nothing
        End Function

        Protected Sub NotifyModuleWhatsThisStateChange(ByVal whatsThisStarted As Boolean)
            If ModulesInfo.Instance.CurrentModuleBase.TModule Is Nothing Then
                Return
            End If
            If whatsThisStarted Then
                [module].Padding = New Padding(8)
                [module].Refresh()
            Else
                [module].Padding = New Padding(0)
            End If
            form.EnableService((Not whatsThisStarted))
        End Sub

        Public Sub ClickWhatsThis()
            _whatsThisEnabled = Not _whatsThisEnabled
            NotifyModuleWhatsThisStateChange(_whatsThisEnabled)
            disableWhatsThisOnMove = _whatsThisEnabled
            whatsThisController.UpdateRegisteredVisibleControls()
            If _whatsThisEnabled Then
                whatsThisController.UpdateWhatsThisBitmaps()
                [module].Hide()
                whatsThisModule.Show()
            Else
                whatsThisModule.Visible = False
                [module].Show()
            End If
        End Sub

        Public Sub DisableWhatsThis()
            If (Not _whatsThisEnabled) Then
                Return
            End If
            NotifyModuleWhatsThisStateChange(False)
            _whatsThisEnabled = False
            HideWhatsThisModule()
            form.EnableService((Not _whatsThisEnabled))
        End Sub

		Private Sub HideWhatsThisModule()
			whatsThisModule.Visible = False
			[module].Show()
		End Sub

	End Class
End Namespace
