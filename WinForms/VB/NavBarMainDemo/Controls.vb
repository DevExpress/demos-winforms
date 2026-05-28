Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraNavBar.Demos.VehiclesData

Namespace DevExpress.XtraNavBar.Demos

    Public Class TutorialControl
        Inherits TutorialControlBase

        Protected contentPanel1 As PanelControl

        Public Sub New()
            contentPanel1 = CreateContentPanel()
            OnAddContentPanel()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            UpdateContentLocation()
            AddHandler SizeChanged, Sub(sender, ee) UpdateContentLocation()
        End Sub

        Protected Overridable Sub OnAddContentPanel()
            Controls.Add(ContentPanel)
            ContentPanel.Dock = DockStyle.Fill
            If Not AllowContentBorders Then ContentPanel.BorderStyle = BorderStyles.NoBorder
        End Sub

        Private Sub UpdateContentLocation()
            If DesignMode Then Return
            Dim outerBounds As Rectangle = CalcOuterBounds()
            If outerBounds.IsEmpty Then Return
            Dim xoffset As Integer = ContentPanel.Width \ 2 - outerBounds.Left - outerBounds.Width \ 2
            Dim yoffset As Integer = ContentPanel.Height \ 2 - outerBounds.Top - outerBounds.Height \ 2
            For Each control As Control In GetContentControls()
                Dim pt As Point = control.Location
                pt.Offset(xoffset, yoffset)
                control.Location = pt
            Next
        End Sub

        Private Function CalcOuterBounds() As Rectangle
            Dim _controls = GetContentControls()
            If _controls.Count() = 0 Then Return Rectangle.Empty
            Dim _left As Integer = Integer.MaxValue, _right As Integer = 0, _top As Integer = Integer.MaxValue, _bottom As Integer = 0
            For Each control As Control In _controls
                If control.Left < _left Then _left = control.Left
                If control.Right > _right Then _right = control.Right
                If control.Top < _top Then _top = control.Top
                If control.Bottom > _bottom Then _bottom = control.Bottom
            Next

            Return Rectangle.FromLTRB(_left, _top, _right, _bottom)
        End Function

        Private Function GetContentControls() As IEnumerable(Of Control)
            Dim list As List(Of Control) = New List(Of Control)()
            For Each control As Control In ContentPanel.Controls
                If TypeOf control Is BarDockControl Then Continue For
                list.Add(control)
            Next

            Return list
        End Function

        Protected Overridable ReadOnly Property AllowContentBorders As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overridable Function CreateContentPanel() As PanelControl
            Return New PanelControl()
        End Function

        Protected ReadOnly Property ContentPanel As PanelControl
            Get
                Return contentPanel1
            End Get
        End Property

        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
            Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
            If be IsNot Nothing Then be.MenuManager = manager
        End Sub

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return False
            End Get
        End Property
    End Class

    Public Module LicenseInfo

        Public Sub SetToolTipController(ByVal [module] As TutorialControl, ByVal grid As GridControl)
            grid.ToolTipController = [module].LicenseToolTipController
            AddHandler [module].LicenseToolTipController.OnLicenseChanged, Sub(s, e) e.Info = GetLicenseInfo(e.Row)
        End Sub

        Private Function GetLicenseInfo(ByVal obj As Object) As String
            Dim model = TryCast(obj, Model)
            If model IsNot Nothing Then Return model.LicenseInfo
            Return Nothing
        End Function
    End Module
End Namespace
