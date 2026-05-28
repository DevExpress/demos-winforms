Imports System
Imports System.Collections.Generic
Imports System.Reflection
Imports DevExpress.Utils
Imports DevExpress.WindowsMailClient.Win.Utils

Namespace DevExpress.WindowsMailClient.Win.Services

    Public Enum PanelType
        Unknown
        Settings
        Folders
        Accounts
        FocusedOther
        Notifications
    End Enum

    Public Interface IPanelProviderService

        Sub ShowPanel(ByVal panelType As PanelType)

        Sub HidePanel(ByVal panelType As PanelType)

        Sub HideAllPanels()

    End Interface

    Friend NotInheritable Class PanelProviderService
        Implements IPanelProviderService

        Private ReadOnly panelsCache As IDictionary(Of PanelType, WeakReference)

        Public Sub New()
            panelsCache = New Dictionary(Of PanelType, WeakReference)()
            LoadPanels()
        End Sub

        Private Sub LoadPanels()
            panelsCache.Add(PanelType.Settings, New WeakReference(TryCast(GetFlyoutPanelInstance("flyoutPanelSettings"), FlyoutPanel)))
            panelsCache.Add(PanelType.FocusedOther, New WeakReference(TryCast(GetFlyoutPanelInstance("flyoutPanelFocuedInboxSettings"), FlyoutPanel)))
            panelsCache.Add(PanelType.Folders, New WeakReference(TryCast(GetFlyoutPanelInstance("flyoutPanelFolders"), FlyoutPanel)))
            panelsCache.Add(PanelType.Notifications, New WeakReference(TryCast(GetFlyoutPanelInstance("flyoutPanelNotifications"), FlyoutPanel)))
            panelsCache.Add(PanelType.Accounts, New WeakReference(TryCast(GetFlyoutPanelInstance("flyoutPanelAccounts"), FlyoutPanel)))
        End Sub

        Private Shared Function GetFlyoutPanelInstance(ByVal name As String) As Object
            Dim mainFormType = AppProvider.MainForm.GetType()
            Dim info As FieldInfo = mainFormType.GetField(name, BindingFlags.Public Or BindingFlags.NonPublic Or BindingFlags.Instance)
            If info IsNot Nothing Then Return info.GetValue(AppProvider.MainForm)
            Return Nothing
        End Function

        Public Sub ShowPanel(ByVal panelType As PanelType) Implements IPanelProviderService.ShowPanel
            Dim panelRef As WeakReference = Nothing
            If panelsCache.TryGetValue(panelType, panelRef) Then
                Dim panel As FlyoutPanel = TryCast(panelRef.Target, FlyoutPanel)
                If panel IsNot Nothing Then
                    If Not panel.Visible Then
                        panel.ShowPopup(True)
                    Else
                        panel.HidePopup(True)
                    End If
                End If
            End If
        End Sub

        Public Sub HidePanel(ByVal panelType As PanelType) Implements IPanelProviderService.HidePanel
            Dim panelRef As WeakReference = Nothing
            If panelsCache.TryGetValue(panelType, panelRef) Then
                Dim panel As FlyoutPanel = TryCast(panelRef.Target, FlyoutPanel)
                If panel IsNot Nothing AndAlso panel.Visible Then panel.HidePopup(True)
            End If
        End Sub

        Public Sub HideAllPanels() Implements IPanelProviderService.HideAllPanels
            For Each pref As WeakReference In panelsCache.Values
                Dim panel As FlyoutPanel = TryCast(pref.Target, FlyoutPanel)
                If panel IsNot Nothing AndAlso panel.Visible Then panel.HidePopup(True)
            Next
        End Sub
    End Class
End Namespace
