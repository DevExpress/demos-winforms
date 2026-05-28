Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraTreeList
Imports System
Imports System.Drawing

Namespace DevExpress.HTML.Demos

    Public Partial Class frmMain
        Inherits DXperience.Demos.RibbonMainForm

        Private ReadOnly wxiSkinExtraSize As Size = New Size(30, 75)

        '
        Private defaultWidthChanged As Boolean

        Private defaultHeightChanged As Boolean

        Private extraWidthAdded As Boolean

        Private extraHeightAdded As Boolean

        Private lastSize As Size

        Private lastScale As SizeF

        Private lastActiveSkinName As String

        Public Sub New()
            MyBase.New()
            Call Helpers.DataHelper.LoadMessagesAsync()
            lastActiveSkinName = LookAndFeel.ActiveSkinName
            Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(GetType(GridControl).TypeHandle)
            Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(GetType(TreeList).TypeHandle)
        End Sub

        Protected Overrides Sub SetFormParam()
            Icon = Utils.ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.HTML.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides Sub OnResizeBegin(ByVal e As EventArgs)
            MyBase.OnResizeBegin(e)
            lastSize = Size
            lastScale = ScaleDPI.ScaleFactor
        End Sub

        Protected Overrides Sub OnResizeEnd(ByVal e As EventArgs)
            MyBase.OnResizeEnd(e)
            If lastSize.Width <> Width AndAlso lastScale.Width = ScaleDPI.ScaleFactor.Width Then defaultWidthChanged = True
            If lastSize.Height <> Height AndAlso lastScale.Height = ScaleDPI.ScaleFactor.Height Then defaultHeightChanged = True
        End Sub

        Protected Overrides Sub OnLookAndFeelChangedCore()
            MyBase.OnLookAndFeelChangedCore()
            AdjustSizeIfNecessary()
        End Sub

        Private Sub AdjustSizeIfNecessary()
            If Not Equals(lastActiveSkinName, LookAndFeel.ActiveSkinName) Then
                If Equals(LookAndFeel.ActiveSkinName, "WXI") Then
                    If Not defaultWidthChanged AndAlso Not extraWidthAdded Then
                        Width += ScaleDPI.ScaleHorizontal(wxiSkinExtraSize.Width)
                        extraWidthAdded = True
                    End If

                    If Not defaultHeightChanged AndAlso Not extraHeightAdded Then
                        Height += ScaleDPI.ScaleVertical(wxiSkinExtraSize.Height)
                        extraHeightAdded = True
                    End If
                Else
                    If Not defaultWidthChanged AndAlso extraWidthAdded Then
                        Width -= ScaleDPI.ScaleHorizontal(wxiSkinExtraSize.Width)
                        extraWidthAdded = False
                    End If

                    If Not defaultHeightChanged AndAlso extraHeightAdded Then
                        Height -= ScaleDPI.ScaleVertical(wxiSkinExtraSize.Height)
                        extraHeightAdded = False
                    End If
                End If
            End If

            lastActiveSkinName = LookAndFeel.ActiveSkinName
        End Sub

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "HTML"
            End Get
        End Property

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms HTML & CSS Templates"
            End Get
        End Property

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As LookAndFeel.DefaultLookAndFeel)
            DemosInfo.ShowModule(name, group, RibbonMenuManager)
        End Sub

        Protected Overrides Sub FillNavBar()
            DXperience.Demos.ModulesInfo.FillAccordionControl(accordionControl1, XtraNavBar.NavBarGroupStyle.SmallIconsList, True, XtraNavBar.NavBarImage.Large)
        End Sub

        Protected Overrides Function CanUseEmptyRootPadding(ByVal name As String) As Boolean
            Return True
        End Function

        Protected Overrides Sub ShowAbout()
            Call BaseEdit.About()
        End Sub

        Protected Overrides ReadOnly Property AllowHtmlDebugger As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
