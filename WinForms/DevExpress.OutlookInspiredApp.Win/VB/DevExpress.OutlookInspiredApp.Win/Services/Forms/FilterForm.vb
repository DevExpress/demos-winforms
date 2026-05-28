Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu

Namespace DevExpress.DevAV

    Public Partial Class FilterForm
        Inherits XtraEditors.XtraForm
        Implements IDXMenuManagerProvider

        Public Sub New()
            InitializeComponent()
            IconOptions.SvgImage = AppIcon
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Bounds = PlacementHelper.Arrange(Size, Owner.Bounds, ContentAlignment.MiddleCenter)
        End Sub

        Protected Overrides Sub OnControlAdded(ByVal e As ControlEventArgs)
            MyBase.OnControlAdded(e)
            If TypeOf e.Control Is UserControl Then
                AcceptButton = Find(e.Control, Function(btn) Equals(btn.Text, "OK"))
                CancelButton = Find(e.Control, Function(btn) Equals(btn.Text, "Cancel"))
            End If
        End Sub

        Private Function Find(ByVal control As Control, ByVal predicate As Predicate(Of Control)) As IButtonControl
            For Each child As Control In control.Controls
                If TypeOf child Is IButtonControl AndAlso predicate(child) Then Return CType(child, IButtonControl)
                Dim nested As IButtonControl = Find(child, predicate)
                If nested IsNot Nothing Then Return nested
            Next

            Return Nothing
        End Function

        Private ReadOnly Property MenuManager As IDXMenuManager Implements IDXMenuManagerProvider.MenuManager
            Get
                Return AppHelper.MainForm.Ribbon.Manager
            End Get
        End Property
    End Class
End Namespace
