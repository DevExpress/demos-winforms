Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Collections
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraBars
Imports DevExpress.Utils.Menu
Imports System.Drawing
Imports DevExpress.VideoRent.Win.Modules
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraCharts

Namespace DevExpress.VideoRent.Win
	Public Delegate Sub CloseDetailForm(ByVal result As DialogResult, ByVal CurrentObject As Object)
	Public Class ModuleInfo
        Private fname As String
        Private fdescription As String
        Private fgroup As String
        Private type As Type
        Private imageName As String
        Private fwasShown As Boolean
        Private [module] As TutorialControlBase
        Private fproducts As DemoProducts = DemoProducts.None

        Public Sub New(ByVal name As String, ByVal type As Type, ByVal description As String, ByVal imageName As String, ByVal group As String, ByVal products As DemoProducts)
            If (Not type.IsSubclassOf(GetType(UserControl))) Then
                Throw New ArgumentException(ConstStrings.SubclassError)
            End If
            Me.fname = name
            Me.type = type
            Me.imageName = imageName
            Me.fdescription = description
            Me.fgroup = group
            Me.module = Nothing
            Me.fproducts = products
        End Sub
        Public ReadOnly Property Name() As String
            Get
                Return Me.fname
            End Get
        End Property
        Public ReadOnly Property SmallImage() As Image
            Get
                Return ElementHelper.GetImage(imageName, ImageSize.Small16)
            End Get
        End Property
        Public ReadOnly Property LargeImage() As Image
            Get
                Return ElementHelper.GetImage(imageName, ImageSize.Large32)
            End Get
        End Property
        Public ReadOnly Property Description() As String
            Get
                Return Me.fdescription
            End Get
        End Property
        Public ReadOnly Property Group() As String
            Get
                Return Me.fgroup
            End Get
        End Property
        Public ReadOnly Property Created() As Boolean
            Get
                Return ((Not Object.Equals(Me.module, Nothing)))
            End Get
        End Property
        Public Property WasShown() As Boolean
            Get
                Return fwasShown
            End Get
            Set(ByVal value As Boolean)
                fwasShown = value
            End Set
        End Property
        Public ReadOnly Property Products() As DemoProducts
            Get
                Return fproducts
            End Get
        End Property
        Public ReadOnly Property TypeName() As String
            Get
                If Created Then
                    Return TModule.GetType().Name
                End If
                Return String.Empty
            End Get
        End Property
        Public Sub ModuleDispose()
            If (Not Object.Equals(Me.module, Nothing)) AndAlso Me.module.AllowDispose Then
                Me.module.ResetPibbonPage()
                Me.module.Dispose()
                Me.module = Nothing
            End If
        End Sub
        Public ReadOnly Property TModule() As TutorialControlBase
            Get
                If Object.Equals(Me.module, Nothing) Then
                    Dim constructorInfoObj As ConstructorInfo = type.GetConstructor(Type.EmptyTypes)
                    If Object.Equals(constructorInfoObj, Nothing) Then
                        Throw New ApplicationException(String.Format(ConstStrings.PublicConstructorError, type.FullName))
                    End If
                    Me.module = TryCast(constructorInfoObj.Invoke(Nothing), TutorialControlBase)
                End If
                Return Me.module
            End Get
        End Property
    End Class
    Public Class ModuleInfoCollection
        Inherits CollectionBase
        Default Public ReadOnly Property Item(ByVal index As Integer) As ModuleInfo
            Get
                If List.Count > index Then
                    Return TryCast(List(index), ModuleInfo)
                End If
                Return Nothing
            End Get
        End Property
        Default Public ReadOnly Property Item(ByVal name As String) As ModuleInfo
            Get
                For Each info As ModuleInfo In Me
                    If info.Name.Equals(name) Then
                        Return info
                    End If
                Next info
                Return Nothing
            End Get
        End Property
        Public Sub Add(ByVal value As ModuleInfo)
            If (Not List.Contains(value)) Then
                List.Add(value)
            End If
        End Sub
        Public Sub Remove(ByVal value As ModuleInfo)
            If List.Contains(value) Then
                List.Remove(value)
            End If
        End Sub
    End Class
    Public Class ModulesInfo
        Public Event CurrentModuleChanged As EventHandler
        Private Shared finstance As ModulesInfo
        Private fcollection As ModuleInfoCollection
        Private fcurrentModule As ModuleInfo

        Public ReadOnly Property Collection() As ModuleInfoCollection
            Get
                Return fcollection
            End Get
        End Property
        Public Property CurrentModuleBase() As ModuleInfo
            Get
                Return fcurrentModule
            End Get
            Set(ByVal value As ModuleInfo)
                fcurrentModule = value
            End Set
        End Property

        Public Shared Sub Add(ByVal name As String, ByVal type As Type, ByVal description As String, ByVal imageName As String, ByVal group As String)
            Add(name, type, description, imageName, group, DemoProducts.None)
        End Sub
        Public Shared Sub Add(ByVal name As String, ByVal type As Type, ByVal description As String, ByVal imageName As String, ByVal group As String, ByVal product As DemoProducts)
            Dim item As New ModuleInfo(name, type, description, imageName, group, product)
            Instance.Collection.Add(item)
        End Sub
        Public Shared ReadOnly Property Count() As Integer
            Get
                Return finstance.Collection.Count
            End Get
        End Property
        Public Shared Function GetItem(ByVal index As Integer) As ModuleInfo
            Return finstance.Collection(index)
        End Function
        Public Shared Function GetItem(ByVal name As String) As ModuleInfo
            Return finstance.Collection(name)
        End Function
        Public Shared Sub RemoveItem(ByVal name As String)
            Dim info As ModuleInfo = GetItem(name)
            If (Not Object.Equals(info, Nothing)) Then
                finstance.Collection.Remove(info)
            End If
        End Sub
        Public Shared ReadOnly Property Instance() As ModulesInfo
            Get
                Return finstance
            End Get
        End Property
        Public Shared ReadOnly Property CurrentModuleInfo() As ModuleInfo
            Get
                Return finstance.fcurrentModule
            End Get
        End Property
        Public Shared ReadOnly Property CurrentModule() As TutorialControlBase
            Get
                If (Not Object.Equals(CurrentModuleInfo, Nothing)) Then
                    Return CurrentModuleInfo.TModule
                End If
                Return Nothing
            End Get
        End Property
        Shared Sub New()
            finstance = New ModulesInfo()
        End Sub
        Public Sub New()
            Me.fcollection = New ModuleInfoCollection()
            Me.fcurrentModule = Nothing
        End Sub
        Protected Shared Sub RaiseModuleChanged()
            If (Not Object.Equals(Instance.CurrentModuleChangedEvent, Nothing)) Then
                Instance.RaiseInstanceModuleChanged()
            End If
        End Sub

        Private Sub RaiseInstanceModuleChanged()
            RaiseEvent CurrentModuleChanged(Me, EventArgs.Empty)
        End Sub
        Public Shared Sub FillNavBar(ByVal navBar As NavBarControl)
            FillNavBar(navBar, NavBarGroupStyle.LargeIconsText, NavBarImage.Small)
        End Sub
        Public Shared Sub FillNavBar(ByVal navBar As NavBarControl, ByVal groupStyle As NavBarGroupStyle, ByVal groupCaptionImage As NavBarImage)
            If Object.Equals(navBar, Nothing) Then
                Return
            End If
            navBar.BeginUpdate()
            For i As Integer = 0 To Count - 1
                If GetItem(i).Group = ConstStrings.AboutGroup Then
                    Continue For
                End If
                Dim item As New NavBarItem()
                navBar.Items.Add(item)
                item.Caption = GetItem(i).Name
                item.SmallImage = GetItem(i).SmallImage
                item.LargeImage = GetItem(i).LargeImage
                item.Tag = GetItem(i)
                GetNavBarGroup(navBar, GetItem(i).Group, groupStyle, groupCaptionImage).ItemLinks.Add(New NavBarItemLink(item))
            Next i
            navBar.EndUpdate()
        End Sub
        Private Shared Function GetNavBarGroup(ByVal navBar As NavBarControl, ByVal groupName As String, ByVal groupStyle As NavBarGroupStyle, ByVal groupCaptionImage As NavBarImage) As NavBarGroup
            For Each group As NavBarGroup In navBar.Groups
                If group.Caption = groupName Then
                    Return group
                End If
            Next group
            Dim newGroup As NavBarGroup = navBar.Groups.Add()
            newGroup.Caption = groupName
            newGroup.Name = groupName
            newGroup.GroupStyle = groupStyle
            newGroup.GroupCaptionUseImage = groupCaptionImage
            Return newGroup
        End Function
    End Class
    Public Class DetailModulesCollection
        Inherits CollectionBase
        Private owner As TutorialControlBase
        Public Sub New(ByVal owner As TutorialControlBase)
            Me.owner = owner
        End Sub
        Default Public ReadOnly Property Item(ByVal index As Integer) As DetailBase
            Get
                If List.Count > index Then
                    Return TryCast(List(index), DetailBase)
                End If
                Return Nothing
            End Get
        End Property
        Private Function IsDetailExist(ByVal value As DetailBase) As DetailBase
            For Each detail As DetailBase In List
                If detail.ID = value.ID Then
                    Return detail
                End If
            Next detail
            Return Nothing
        End Function
        Public Function IsDetailExist(ByVal id As Guid) As Boolean
            For Each detail As DetailBase In List
                If detail.ID = id Then
                    owner.ActiveDetailControl = detail
                    Return True
                End If
            Next detail
            Return False
        End Function
        Public Function IsDirtyDetailExist() As Boolean
            For Each detail As DetailBase In List
                If detail.Dirty Then
                    Return True
                End If
            Next detail
            Return False
        End Function
        Public Sub Add(ByVal value As DetailBase)
            Dim existDetail As DetailBase = IsDetailExist(value)
            If Object.Equals(existDetail, Nothing) Then
                List.Add(value)
                owner.ActiveDetailControl = value
            Else
                value.Dispose()
                owner.ActiveDetailControl = existDetail
            End If
            owner.RibbonMenuController.CalcCloseAllDetails()
        End Sub
        Public Sub Remove(ByVal value As DetailBase)
            Dim index As Integer = List.IndexOf(value)

            If List.Contains(value) Then
                List.Remove(value)
            End If

            If index <> -1 AndAlso List.Count > 0 Then
                If index >= List.Count Then
                    index = List.Count - 1
                End If
                owner.ActiveDetailControl = CType(List(index), DetailBase)
            Else
                owner.ActiveDetailControl = Nothing
            End If

            If (Not Object.Equals(value, Nothing)) Then
                value.Dispose()
            End If
            owner.RibbonMenuController.CalcCloseAllDetails()
        End Sub
        Public Sub RemoveAll(ByVal closeEditing As Boolean)
            For i As Integer = List.Count - 1 To 0 Step -1
                Dim temp As DetailBase = Me(i)
                If temp.Dirty AndAlso (Not closeEditing) Then
                    Continue For
                End If
                List.RemoveAt(i)
                temp.Dispose()
            Next i
            owner.ActiveDetailControl = Nothing
            owner.RibbonMenuController.CalcCloseAllDetails()
        End Sub
        Friend Sub HideDetails()
            For Each detail As DetailBase In List
                detail.Hide()
            Next detail
        End Sub
    End Class
    <ToolboxItem(False)> _
    Public Class TutorialControlBase
        Inherits XtraUserControl
        Private ribbonPage As RibbonPage = Nothing
        Private _parent As frmMain = Nothing
        Private detailModuleCollection As DetailModulesCollection = Nothing
        Private _name As String = String.Empty
        Public Property ParentFormMain() As frmMain
            Get
                Return _parent
            End Get
            Set(ByVal value As frmMain)
                If (Not Object.Equals(_parent, Nothing)) Then
                    Return
                End If
                _parent = value
            End Set
        End Property
        Public ReadOnly Property RibbonMenuController() As RibbonMenuController
            Get
                If (Not Object.Equals(_parent, Nothing)) Then
                    Return _parent.RibbonMenuController
                End If
                Return Nothing
            End Get
        End Property
        Public ReadOnly Property LayoutManager() As FormLayoutManager
            Get
                If (Not Object.Equals(_parent, Nothing)) Then
                    Return _parent.LayoutManager
                End If
                Return Nothing
            End Get
        End Property
        Public ReadOnly Property MenuManager() As IDXMenuManager
            Get
                If Object.Equals(_parent, Nothing) Then
                    Return Nothing
                End If
                Return _parent.MenuManager
            End Get
        End Property
        Public Property ActiveRibbonPage() As RibbonPage
            Get
                Return ribbonPage
            End Get
            Set(ByVal value As RibbonPage)
                If (Not Object.Equals(ribbonPage, Nothing)) Then
                    Return
                End If
                ribbonPage = value
            End Set
        End Property
        Public ReadOnly Property DetailTypeName() As String
            Get
                If (Not Object.Equals(ActiveDetailControl, Nothing)) Then
                    Return ActiveDetailControl.GetType().Name
                End If
                Return Nothing
            End Get
        End Property
        Public ReadOnly Property TypeName() As String
            Get
                Return Me.GetType().Name
            End Get
        End Property
        Public Function IsSuitablePage(ByVal page As RibbonPage) As Boolean
            If Object.Equals(page.Tag, Nothing) Then
                Return False
            End If
            If (Not Object.Equals(detailModuleCollection, Nothing)) Then
                For Each detail As DetailBase In detailModuleCollection
                    If detail.ActiveRibbonPage Is page Then
                        Return True
                    End If
                Next detail
            End If
            Return Object.Equals(ActiveRibbonPage, page)
        End Function
        Public Sub New()
            SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            OnStyleChanged()
        End Sub

        Public Property TutorialName() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property
        Private factiveDetailControl As DetailBase = Nothing
        Public Property ActiveDetailControl() As DetailBase
            Get
                Return factiveDetailControl
            End Get
            Set(ByVal value As DetailBase)
                If factiveDetailControl Is value Then
                    UpdateActiveDetailControl()
                    Return
                End If
                factiveDetailControl = value
                If Object.Equals(ActiveDetailControl, Nothing) Then
                    If (Not Object.Equals(Me.ActiveRibbonPage, Nothing)) Then
                        Me.ActiveRibbonPage.Ribbon.SelectedPage = ActiveRibbonPage
                    End If
                    RemoveCloseDetailButton()
                Else
                    CreateDetailRibbon()
                    UpdateMenu()
                    ShowActiveDetailControlRibbonPage()
                    AddCloseDetailButton()
                End If
            End Set
        End Property
        Friend Sub DumpActiveDetailControl()
            factiveDetailControl = Nothing
            RemoveCloseDetailButton()
        End Sub
        Friend Sub AddCloseDetailButton()
            If Object.Equals(ActiveDetailControl, Nothing) Then
                Return
            End If
            If (Not RibbonPageHeaderItemLinkCollectionContainsBarItem(ParentFormMain.CloseButton, ParentFormMain.RibbonControl.PageHeaderItemLinks)) Then
                ParentFormMain.RibbonControl.PageHeaderItemLinks.Add(ParentFormMain.CloseButton)
            End If
        End Sub
        Friend Sub RemoveCloseDetailButton()
            ParentFormMain.RibbonControl.PageHeaderItemLinks.Remove(ParentFormMain.CloseButton)
        End Sub
        Private Shared Function RibbonPageHeaderItemLinkCollectionContainsBarItem(ByVal item As BarButtonItem, ByVal collection As RibbonPageHeaderItemLinkCollection) As Boolean
            For Each link As BarItemLink In collection
                If link.Item.Equals(item) Then
                    Return True
                End If
            Next link
            Return False
        End Function
        Private Sub UpdateActiveDetailControl()
            If (Not Object.Equals(ActiveDetailControl, Nothing)) Then
                ShowActiveDetailControlRibbonPage()
            End If
        End Sub
        Private Sub ShowActiveDetailControlRibbonPage()
            ActiveDetailControl.ActiveRibbonPage.Ribbon.SelectedPage = ActiveDetailControl.ActiveRibbonPage
        End Sub
        Private Sub CloseActiveDetailForm()
            DetailModulesCollection.Remove(ActiveDetailControl)
        End Sub
        Protected Overridable Sub CloseDetailForm(ByVal result As DialogResult, ByVal currentObject As Object)
            CloseActiveDetailForm()
        End Sub
        Protected Overridable Sub CloseDetailFormAndReload(ByVal result As DialogResult, ByVal currentObject As Object)
            CloseActiveDetailForm()
        End Sub
        Protected Overridable Sub UpdateMenu()
        End Sub
        Protected Overridable Sub CreateDetailRibbon()
        End Sub
        Public ReadOnly Property IsDetailsExist() As Boolean
            Get
                Return (Not Object.Equals(detailModuleCollection, Nothing)) AndAlso detailModuleCollection.Count > 0
            End Get
        End Property
        Public ReadOnly Property IsDirtyDetailsExist() As Boolean
            Get
                If Object.Equals(detailModuleCollection, Nothing) Then
                    Return False
                End If
                Return detailModuleCollection.IsDirtyDetailExist()
            End Get
        End Property
        Public ReadOnly Property DetailModulesCollection() As DetailModulesCollection
            Get
                If Object.Equals(detailModuleCollection, Nothing) Then
                    detailModuleCollection = New DetailModulesCollection(Me)
                End If
                Return detailModuleCollection
            End Get
        End Property
        Protected Friend Sub CloseAllDetails()
            If (Not Object.Equals(detailModuleCollection, Nothing)) Then
                detailModuleCollection.RemoveAll(IsDirtyDetailsExist AndAlso XtraMessageBox.Show(Me, ConstStrings.CloseCancelFormsWarning, ConstStrings.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes)
            End If
        End Sub
        Public Sub ShowModuleDialog(ByVal [module] As DetailBase)
            ShowModuleDialog([module], False)
        End Sub
        Public Sub ShowModuleDialog(ByVal [module] As DetailBase, ByVal [readOnly] As Boolean)
            [module].Bounds = Me.DisplayRectangle
            [module].Parent = Me.Parent
            [module].Dock = DockStyle.Fill
            DetailModulesCollection.Add(TryCast([module], DetailBase))
            [module].ReadOnly = [readOnly]
        End Sub
        Friend Function IsDetailExist(ByVal id As Guid) As Boolean
            If Object.Equals(detailModuleCollection, Nothing) Then
                Return False
            End If
            Return detailModuleCollection.IsDetailExist(id)
        End Function
        Protected Friend Overridable Sub DetailSave()
            If (Not Object.Equals(ActiveDetailControl, Nothing)) Then
                ActiveDetailControl.Save()
            End If
        End Sub
        Protected Friend Overridable Sub DetailClose()
            If (Not Object.Equals(ActiveDetailControl, Nothing)) Then
                ActiveDetailControl.Close()
            End If
        End Sub
        Protected Friend Overridable Sub DetailSaveAndClose()
            If (Not Object.Equals(ActiveDetailControl, Nothing)) Then
                ActiveDetailControl.SaveAndClose()
            End If
        End Sub
        Protected Overridable Sub OnSwitchStyle()
        End Sub
        Protected Overridable Overloads Sub OnStyleChanged()
        End Sub
        Protected Overrides Sub OnVisibleChanged(ByVal e As EventArgs)
            If DesignMode Then
                Return
            End If
            MyBase.OnVisibleChanged(e)
            If Me.Visible Then
                DoShow()
            Else
                DoHide()
            End If
        End Sub
        Protected Overridable Sub DoShow()
        End Sub
        Protected Overridable Sub DoHide()
        End Sub

        Private setManager As Boolean = False
        Protected Sub AddMenuManager(ByVal manager As IDXMenuManager)
            If setManager Then
                Return
            End If
            AddManager(Me.Controls, manager)
            setManager = True
        End Sub

        Private Sub AddManager(ByVal collection As ControlCollection, ByVal manager As IDXMenuManager)
            For Each ctrl As Control In collection
                SetControlManager(ctrl, manager)
                AddManager(ctrl.Controls, manager)
            Next ctrl
        End Sub
        Protected Overridable Sub LoadFormLayout()
        End Sub
        Protected Overridable Sub SaveFormLayout()
        End Sub
        Protected Overridable Sub SetControlManager(ByVal ctrl As Control, ByVal manager As IDXMenuManager)
        End Sub
        Protected Friend Overridable ReadOnly Property UseList() As Boolean
            Get
                Return True
            End Get
        End Property

        Friend Sub HideElements()
            Me.Hide()
            If (Not Object.Equals(detailModuleCollection, Nothing)) Then
                detailModuleCollection.HideDetails()
            End If
        End Sub
        Protected Overridable ReadOnly Property MainChart() As ChartControl
            Get
                Return Nothing
            End Get
        End Property
        Protected Overridable ReadOnly Property AlternateChart() As ChartControl
            Get
                Return Nothing
            End Get
        End Property
        Protected Overridable ReadOnly Property DisposeWhenHide() As Boolean
            Get
                Return False
            End Get
        End Property
        Friend ReadOnly Property AllowDispose() As Boolean
            Get
                Return DisposeWhenHide AndAlso Not IsDetailsExist
            End Get
        End Property
        Public ReadOnly Property CurrentRibbonPage() As RibbonPage
            Get
                For Each page As RibbonPage In ParentFormMain.Ribbon.TotalPageCategory.Pages
                    If page.Tag Is Me Then
                        Return page
                    End If
                Next page
                Return Nothing
            End Get
        End Property
        Friend Sub ResetPibbonPage()
            If (Not Object.Equals(CurrentRibbonPage, Nothing)) Then
                CurrentRibbonPage.Tag = Me.TypeName
            End If
        End Sub
        Public Sub CheckChartStyles(ByVal manager As ChartAppearanceManager)
            WinHelper.SetChartStyle(MainChart, manager)
            WinHelper.SetChartStyle(AlternateChart, manager)
        End Sub
        Friend Sub ShowMasterModule()
            ActiveDetailControl = Nothing
        End Sub
    End Class
End Namespace
