Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPivotGrid

Namespace DevExpress.RealtorWorld.Win

    Public Class BaseModule
        Inherits XtraUserControl

        Friend FirstShowing As Boolean = True

        Public Overridable ReadOnly Property ModuleCaption As String
            Get
                Return String.Empty
            End Get
        End Property

        Public Overridable ReadOnly Property ModuleName As String
            Get
                Return ModuleCaption
            End Get
        End Property

        Friend Overridable Sub ShowModule(ByVal item As Object)
            FirstShowing = False
        End Sub

        Friend Overridable Sub HideModule()
        End Sub

        Friend Overridable Sub InitModule(ByVal manager As IDXMenuManager, ByVal data As Object)
            SetMenuManager(Me.Controls, manager)
        End Sub

        Private Sub SetMenuManager(ByVal controlCollection As ControlCollection, ByVal manager As IDXMenuManager)
            For Each ctrl As Control In controlCollection
                Dim grid As GridControl = TryCast(ctrl, GridControl)
                If grid IsNot Nothing Then
                    grid.MenuManager = manager
                    Exit For
                End If

                Dim pivot As PivotGridControl = TryCast(ctrl, PivotGridControl)
                If pivot IsNot Nothing Then
                    pivot.MenuManager = manager
                    Exit For
                End If

                Dim edit As BaseEdit = TryCast(ctrl, BaseEdit)
                If edit IsNot Nothing Then
                    edit.MenuManager = manager
                    Exit For
                End If

                SetMenuManager(ctrl.Controls, manager)
            Next
        End Sub

        Public Overridable ReadOnly Property AllowWaitDialog As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
