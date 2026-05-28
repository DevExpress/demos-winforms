Imports DevExpress.XtraBars
Imports DevExpress.LookAndFeel
Imports System.ComponentModel
Imports DevExpress.Skins

Namespace DevExpress.XtraScheduler.Demos.Reporting

    <ToolboxItem(False), DesignTimeVisible(False)>
    Public Class BarLookAndFeelItem
        Inherits BarButtonItem

        Public Sub New(ByVal manager As BarManager, ByVal privateItem As Boolean)
            MyBase.New()
            fIsPrivateItem = privateItem
            Me.Manager = manager
            ButtonStyle = BarButtonStyle.Check
        End Sub

        Public Overridable Sub UpdateState(ByVal lookAndFeel As UserLookAndFeel)
        End Sub

        Public Overridable Sub ApplyChanges(ByVal lookAndFeel As UserLookAndFeel)
        End Sub
    End Class

    Public Class BarLookAndFeelStyleItem
        Inherits BarLookAndFeelItem

        Private activeStyle As ActiveLookAndFeelStyle

        Private style As LookAndFeelStyle

        Public Sub New(ByVal manager As BarManager, ByVal privateItem As Boolean, ByVal activeStyle As ActiveLookAndFeelStyle, ByVal style As LookAndFeelStyle)
            MyBase.New(manager, privateItem)
            Me.style = style
            Me.activeStyle = activeStyle
        End Sub

        Public Overrides Sub UpdateState(ByVal lookAndFeel As UserLookAndFeel)
            Down = lookAndFeel.ActiveStyle.Equals(activeStyle)
        End Sub

        Public Overrides Sub ApplyChanges(ByVal lookAndFeel As UserLookAndFeel)
            lookAndFeel.UseWindowsXPTheme = False
            lookAndFeel.Style = style
        End Sub
    End Class

    Public Class BarLookAndFeelSkinNameItem
        Inherits BarLookAndFeelItem

        Private skinName As String

        Public Sub New(ByVal manager As BarManager, ByVal privateItem As Boolean, ByVal skinName As String)
            MyBase.New(manager, privateItem)
            Me.skinName = skinName
        End Sub

        Public Overrides Sub UpdateState(ByVal lookAndFeel As UserLookAndFeel)
            Down = lookAndFeel.ActiveStyle.Equals(ActiveLookAndFeelStyle.Skin) AndAlso Equals(lookAndFeel.SkinName, skinName)
        End Sub

        Public Overrides Sub ApplyChanges(ByVal lookAndFeel As UserLookAndFeel)
            lookAndFeel.UseWindowsXPTheme = False
            lookAndFeel.Style = LookAndFeelStyle.Skin
            lookAndFeel.SkinName = skinName
        End Sub
    End Class

    Public Class BarLookAndFeelUseWindowsXPThemeItem
        Inherits BarLookAndFeelItem

        Public Sub New(ByVal manager As BarManager, ByVal privateItem As Boolean)
            MyBase.New(manager, privateItem)
        End Sub

        Public Overrides Sub UpdateState(ByVal lookAndFeel As UserLookAndFeel)
            Down = lookAndFeel.ActiveStyle.Equals(ActiveLookAndFeelStyle.WindowsXP)
            Enabled = DevExpress.Utils.WXPaint.Painter.ThemesEnabled
        End Sub

        Public Overrides Sub ApplyChanges(ByVal lookAndFeel As UserLookAndFeel)
            lookAndFeel.UseWindowsXPTheme = True
        End Sub
    End Class

    Public Class BarLookAndFeelListItem
        Inherits BarLinkContainerItem

        Private lookAndFeel As UserLookAndFeel

        Private skinSubMenuItem As BarSubItem

        Public Sub New(ByVal lookAndFeel As UserLookAndFeel)
            Me.lookAndFeel = lookAndFeel
            skinSubMenuItem = New BarSubItem()
            skinSubMenuItem.Caption = "Skin"
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(False)>
        Public Overrides Property LinksPersistInfo As LinksInfo
            Get
                Return Nothing
            End Get

            Set(ByVal value As LinksInfo)
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(False)>
        Public Overrides ReadOnly Property ItemLinks As BarItemLinkCollection
            Get
                Return MyBase.ItemLinks
            End Get
        End Property

        Protected Overrides Sub OnManagerChanged()
            MyBase.OnManagerChanged()
            If Manager Is Nothing Then Return
            BeginUpdate()
            ClearLinks()
            Try
                skinSubMenuItem.ClearLinks()
                AddBarLookAndFeelItem(Me, New BarLookAndFeelUseWindowsXPThemeItem(Manager, True), "Use WindowsXP Theme")
                AddBarLookAndFeelItem(Me, New BarLookAndFeelStyleItem(Manager, True, ActiveLookAndFeelStyle.Flat, LookAndFeelStyle.Flat), "Flat Style")
                AddBarLookAndFeelItem(Me, New BarLookAndFeelStyleItem(Manager, True, ActiveLookAndFeelStyle.Office2003, LookAndFeelStyle.Office2003), "Office2003 Style")
                AddBarLookAndFeelItem(Me, New BarLookAndFeelStyleItem(Manager, True, ActiveLookAndFeelStyle.Style3D, LookAndFeelStyle.Style3D), "Style3D")
                AddBarLookAndFeelItem(Me, New BarLookAndFeelStyleItem(Manager, True, ActiveLookAndFeelStyle.UltraFlat, LookAndFeelStyle.UltraFlat), "UltraFlat Style")
                AddItem(skinSubMenuItem)
                For Each skin As SkinContainer In SkinManager.Default.Skins
                    AddBarLookAndFeelItem(skinSubMenuItem, New BarLookAndFeelSkinNameItem(Manager, True, skin.SkinName), skin.SkinName)
                Next
            Finally
                CancelUpdate()
            End Try
        End Sub

        Protected Overrides Sub OnGetItemData()
            UpdateLookAndFeelItemsState(Me)
            MyBase.OnGetItemData()
        End Sub

        Private Sub UpdateLookAndFeelItemsState(ByVal holder As BarLinksHolder)
            For Each link As BarItemLink In holder.ItemLinks
                If TypeOf link.Item Is BarLookAndFeelItem Then CType(link.Item, BarLookAndFeelItem).UpdateState(lookAndFeel)
                If TypeOf link.Item Is BarLinksHolder Then UpdateLookAndFeelItemsState(TryCast(link.Item, BarLinksHolder))
            Next
        End Sub

        Private Sub AddBarLookAndFeelItem(ByVal holder As BarLinksHolder, ByVal item As BarLookAndFeelItem, ByVal caption As String)
            item.Caption = caption
            AddHandler item.ItemClick, New ItemClickEventHandler(AddressOf OnItemClick)
            item.UpdateState(lookAndFeel)
            holder.AddItem(item)
        End Sub

        Private Sub OnItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim item As BarLookAndFeelItem = TryCast(e.Item, BarLookAndFeelItem)
            If item IsNot Nothing Then item.ApplyChanges(lookAndFeel)
        End Sub
    End Class
End Namespace
