Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Windows.Forms
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.DevAV.Modules
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.DevAV.Presenters

    Public MustInherit Class FilterAccordionPresenter(Of TEntity As Class, TID, TUnitOfWork As {Class, IUnitOfWork})
        Inherits BasePresenter(Of FilterTreeViewModel(Of TEntity, TID, TUnitOfWork))

        Private ReadOnly staticFiltersHeader As String = FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).StaticFiltersName

        Private ReadOnly customFiltersHeader As String = FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).CustomFiltersName

        Private ReadOnly groupFiltersHeader As String = FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).GroupFiltersName

        Private accordionFilterElements As Dictionary(Of String, AccordionControlElement)

        Private accordionControlCore As AccordionControl

        Public Sub New(ByVal accordionControl As AccordionControl, ByVal viewModel As FilterTreeViewModel(Of TEntity, TID, TUnitOfWork))
            MyBase.New(viewModel)
            accordionControlCore = accordionControl
            If CollectionViewModel IsNot Nothing Then SubscribeCollectionViewModelEvents()
            SetupAccordion()
        End Sub

        Protected Overrides Sub OnDisposing()
            If CollectionViewModel IsNot Nothing Then UnsubscribeCollectionViewModelEvents()
            If accordionControlCore IsNot Nothing Then
                UnsubscribeEvents()
            End If

            accordionControlCore = Nothing
            MyBase.OnDisposing()
        End Sub

        Protected ReadOnly Property AccordionControl As AccordionControl
            Get
                Return accordionControlCore
            End Get
        End Property

        Public ReadOnly Property CollectionViewModel As CollectionViewModel(Of TEntity, TID, TUnitOfWork)
            Get
                Return ViewModel.CollectionViewModel
            End Get
        End Property

        Private Sub CreateHeaders()
            accordionControlCore.Elements.Clear()
            Dim childElements = ViewModel.GetChildren(ViewModel)
            Select Case childElements.Count
                Case 2
                    accordionFilterElements = New Dictionary(Of String, AccordionControlElement) From {{staticFiltersHeader, New AccordionControlElement() With {.Text = staticFiltersHeader}}, {customFiltersHeader, New AccordionControlElement() With {.Text = customFiltersHeader}}}
                Case 3
                    accordionFilterElements = New Dictionary(Of String, AccordionControlElement) From {{staticFiltersHeader, New AccordionControlElement() With {.Text = staticFiltersHeader}}, {customFiltersHeader, New AccordionControlElement() With {.Text = customFiltersHeader}}, {groupFiltersHeader, New AccordionControlElement() With {.Text = groupFiltersHeader}}}
            End Select
        End Sub

#Region "Event Subscription"
        Protected Overridable Sub SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.EntitiesCountChanged, AddressOf CollectionViewModel_EntitiesCountChanged
        End Sub

        Protected Overridable Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.EntitiesCountChanged, AddressOf CollectionViewModel_EntitiesCountChanged
        End Sub

        Private Sub SubscribeEvents()
            AddHandler ViewModel.SelectedItemChanged, AddressOf ViewModel_SelectedItemChanged
            AddHandler ViewModel.FilterAccordionChanged, AddressOf ViewModel_FilterAccordionChanged
            AddHandler AccordionControl.ElementClick, AddressOf AccordionControl_ElementClick
            AddHandler AccordionControl.SelectedElementChanged, AddressOf AccordionControl_SelectedElementChanged
            AddHandler AccordionControl.StartElementDragging, AddressOf AccordionControl_StartElementDragging
            AddHandler AccordionControl.ElementDragOver, AddressOf AccordionControl_ElementDragOver
            AddHandler AccordionControl.MouseDoubleClick, AddressOf AccordionControl_MouseDoubleClick
        End Sub

        Private Sub AccordionControl_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hitInfo As AccordionControlHitInfo = AccordionControl.CalcHitInfo(e.Location)
            If hitInfo.IsInElement AndAlso hitInfo.HitTest = AccordionControlHitTest.Group Then
                If hitInfo.ItemInfo.Element.Expanded Then
                    AccordionControl.CollapseElement(hitInfo.ItemInfo.Element, True)
                Else
                    AccordionControl.ExpandElement(hitInfo.ItemInfo.Element, True)
                End If
            End If
        End Sub

        Private Sub AccordionControl_ElementDragOver(ByVal sender As Object, ByVal e As AccordionElementDragOverEventArgs)
            If Not Equals(e.Element.OwnerElement, e.TargetOwner) Then e.CanDrop = False
        End Sub

        Private Sub AccordionControl_StartElementDragging(ByVal sender As Object, ByVal e As StartAccordionElementDraggingEventArgs)
            If e.Element.Style = ElementStyle.Group Then e.Cancel = True
        End Sub

        Private Sub UnsubscribeEvents()
            RemoveHandler ViewModel.SelectedItemChanged, AddressOf ViewModel_SelectedItemChanged
            RemoveHandler ViewModel.FilterAccordionChanged, AddressOf ViewModel_FilterAccordionChanged
            RemoveHandler AccordionControl.ElementClick, AddressOf AccordionControl_ElementClick
            RemoveHandler AccordionControl.SelectedElementChanged, AddressOf AccordionControl_SelectedElementChanged
            RemoveHandler AccordionControl.StartElementDragging, AddressOf AccordionControl_StartElementDragging
            RemoveHandler AccordionControl.ElementDragOver, AddressOf AccordionControl_ElementDragOver
            RemoveHandler AccordionControl.MouseDoubleClick, AddressOf AccordionControl_MouseDoubleClick
        End Sub

#End Region
#Region "Event Handlers"
        Protected Sub CollectionViewModel_CustomGroupFromSelection(ByVal sender As Object, ByVal e As GroupEventArgs(Of TEntity))
            ViewModel.NewGroupFromSelection(e.Entities)
        End Sub

        Protected Sub CollectionViewModel_CustomGroup(ByVal sender As Object, ByVal e As EventArgs)
            ViewModel.NewGroup()
        End Sub

        Protected Sub CollectionViewModel_CustomFilter(ByVal sender As Object, ByVal e As EventArgs)
            ViewModel.[New]()
        End Sub

        Private Sub CollectionViewModel_EntitiesCountChanged(ByVal sender As Object, ByVal e As EntitiesCountEventArgs)
            UpdateAccordion()
        End Sub

        Private Sub ViewModel_SelectedItemChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim helper = New FilterAccordionHelper(Of TEntity, TID, TUnitOfWork)(AccordionControl)
            AccordionControl.SelectedElement = helper.FindElementByTag(ViewModel.SelectedItem)
        End Sub

        Private Sub ViewModel_FilterAccordionChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateAccordion()
        End Sub

        Private Sub AccordionControl_ElementClick(ByVal sender As Object, ByVal e As ElementClickEventArgs)
            If e.MouseButton = MouseButtons.Right Then
                Dim clientPoint = accordionControlCore.PointToClient(Cursor.Position)
                Dim helper = New FilterAccordionHelper(Of TEntity, TID, TUnitOfWork)(AccordionControl)
                helper.PopulateMenu(e.Element, ViewModel)?.ShowPopup(accordionControlCore, clientPoint)
                e.Handled = True
            End If
        End Sub

        Private Sub AccordionControl_SelectedElementChanged(ByVal sender As Object, ByVal e As SelectedElementChangedEventArgs)
            ViewModel.SelectedItem = TryCast(e.Element?.Tag, FilterItemBase)
        End Sub

#End Region
        Private Sub UpdateAccordion()
            accordionControlCore.BeginUpdate()
            accordionControlCore.Clear()
            CreateHeaders()
            CreateBody()
            accordionControlCore.EndUpdate()
        End Sub

        Private Sub SetSelectedElement()
            Dim helper = New FilterAccordionHelper(Of TEntity, TID, TUnitOfWork)(AccordionControl)
            accordionControlCore.SelectedElement = helper.FindElementByTag(ViewModel.SelectedItem)
        End Sub

        Private Sub ExpandAccordion()
            accordionControlCore.ExpandAll()
        End Sub

        Private Sub CreateBody()
            For Each header In accordionFilterElements.Keys
                Dim currentElement As AccordionControlElement = accordionFilterElements(header)
                Dim filters = GetFilters(header)
                BindItems(currentElement, filters)
                accordionControlCore.Elements.Add(currentElement)
            Next

            SetSelectedElement()
            ExpandAccordion()
        End Sub

        Private Sub SetupAccordion()
            accordionControlCore.BeginUpdate()
            accordionControlCore.AllowElementDragging = True
            SubscribeEvents()
            CreateHeaders()
            CreateBody()
            accordionControlCore.EndUpdate()
        End Sub

        Private Sub BindItems(ByVal accordionElement As AccordionControlElement, ByVal filters As ObservableCollection(Of FilterItemBase))
            For Each filter In filters
                Dim element As AccordionControlElement = New AccordionControlElement() With {.Text = ViewModel.GetFilterName(filters, filter), .Tag = filter, .Style = ElementStyle.Item}
                accordionElement.Elements.Add(element)
            Next
        End Sub

        Private Function GetFilters(ByVal header As String) As ObservableCollection(Of FilterItemBase)
            If Equals(header, staticFiltersHeader) Then
                Return ViewModel.StaticFilters
            ElseIf Equals(header, customFiltersHeader) Then
                Return ViewModel.CustomFilters
            ElseIf Equals(header, groupFiltersHeader) Then
                Return ViewModel.Groups
            End If

            Return Nothing
        End Function
    End Class
End Namespace
