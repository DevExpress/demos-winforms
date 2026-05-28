namespace DevExpress.DevAV.Presenters {
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows.Forms;
    using DevExpress.DevAV.Common.ViewModel;
    using DevExpress.DevAV.Modules;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm.DataModel;
    using DevExpress.XtraBars.Navigation;

    public abstract class FilterAccordionPresenter<TEntity, TID, TUnitOfWork> :
        BasePresenter<FilterTreeViewModel<TEntity, TID, TUnitOfWork>>
        where TEntity : class
        where TUnitOfWork : class, IUnitOfWork {
        readonly string staticFiltersHeader = FilterTreeViewModel<TEntity, TID, TUnitOfWork>.StaticFiltersName;
        readonly string customFiltersHeader = FilterTreeViewModel<TEntity, TID, TUnitOfWork>.CustomFiltersName;
        readonly string groupFiltersHeader = FilterTreeViewModel<TEntity, TID, TUnitOfWork>.GroupFiltersName;
        Dictionary<string, AccordionControlElement> accordionFilterElements;
        AccordionControl accordionControlCore;

        public FilterAccordionPresenter(AccordionControl accordionControl, FilterTreeViewModel<TEntity, TID, TUnitOfWork> viewModel)
            : base(viewModel) {
            this.accordionControlCore = accordionControl;
            if(CollectionViewModel != null)
                SubscribeCollectionViewModelEvents();
            SetupAccordion();
        }

        protected override void OnDisposing() {
            if(CollectionViewModel != null)
                UnsubscribeCollectionViewModelEvents();
            if(accordionControlCore != null) {
                UnsubscribeEvents();
            }
            this.accordionControlCore = null;
            base.OnDisposing();
        }

        protected AccordionControl AccordionControl {
            get { return accordionControlCore; }
        }
        public CollectionViewModel<TEntity, TID, TUnitOfWork> CollectionViewModel {
            get { return ViewModel.CollectionViewModel; }
        }
        void CreateHeaders() {
            accordionControlCore.Elements.Clear();
            var childElements = ViewModel.GetChildren(ViewModel);
            switch(childElements.Count) {
                case 2:
                    accordionFilterElements = new Dictionary<string, AccordionControlElement> {
                        { staticFiltersHeader, new AccordionControlElement() { Text = staticFiltersHeader } },
                        { customFiltersHeader, new AccordionControlElement() { Text = customFiltersHeader } }
                    };
                    break;
                case 3:
                    accordionFilterElements = new Dictionary<string, AccordionControlElement> {
                        { staticFiltersHeader, new AccordionControlElement() { Text = staticFiltersHeader } },
                        { customFiltersHeader, new AccordionControlElement() { Text = customFiltersHeader } },
                        { groupFiltersHeader, new AccordionControlElement() { Text = groupFiltersHeader} }
                    };
                    break;
            }
        }
        #region Event Subscription
        protected virtual void SubscribeCollectionViewModelEvents() {
            CollectionViewModel.EntitiesCountChanged += CollectionViewModel_EntitiesCountChanged;
        }
        protected virtual void UnsubscribeCollectionViewModelEvents() {
            CollectionViewModel.EntitiesCountChanged -= CollectionViewModel_EntitiesCountChanged;
        }
        void SubscribeEvents() {
            ViewModel.SelectedItemChanged += ViewModel_SelectedItemChanged;
            ViewModel.FilterAccordionChanged += ViewModel_FilterAccordionChanged;
            AccordionControl.ElementClick += AccordionControl_ElementClick;
            AccordionControl.SelectedElementChanged += AccordionControl_SelectedElementChanged;
            AccordionControl.StartElementDragging += AccordionControl_StartElementDragging;
            AccordionControl.ElementDragOver += AccordionControl_ElementDragOver;
            AccordionControl.MouseDoubleClick += AccordionControl_MouseDoubleClick;
        }

         void AccordionControl_MouseDoubleClick(object sender, MouseEventArgs e) {
            AccordionControlHitInfo hitInfo = AccordionControl.CalcHitInfo(e.Location);
            if(hitInfo.IsInElement && hitInfo.HitTest == AccordionControlHitTest.Group) {
                if(hitInfo.ItemInfo.Element.Expanded)
                    AccordionControl.CollapseElement(hitInfo.ItemInfo.Element, true);
                else
                    AccordionControl.ExpandElement(hitInfo.ItemInfo.Element, true);
            }
        }

         void AccordionControl_ElementDragOver(object sender, AccordionElementDragOverEventArgs e) {
            if(!object.Equals(e.Element.OwnerElement, e.TargetOwner))
                e.CanDrop = false;
        }

         void AccordionControl_StartElementDragging(object sender, StartAccordionElementDraggingEventArgs e) {
            if(e.Element.Style == ElementStyle.Group)
                e.Cancel = true;
        }

        void UnsubscribeEvents() {
            ViewModel.SelectedItemChanged -= ViewModel_SelectedItemChanged;
            ViewModel.FilterAccordionChanged -= ViewModel_FilterAccordionChanged;
            AccordionControl.ElementClick -= AccordionControl_ElementClick;
            AccordionControl.SelectedElementChanged -= AccordionControl_SelectedElementChanged;
            AccordionControl.StartElementDragging -= AccordionControl_StartElementDragging;
            AccordionControl.ElementDragOver -= AccordionControl_ElementDragOver;
            AccordionControl.MouseDoubleClick -= AccordionControl_MouseDoubleClick;
        }
        #endregion

        #region Event Handlers
        protected void CollectionViewModel_CustomGroupFromSelection(object sender, GroupEventArgs<TEntity> e) {
            ViewModel.NewGroupFromSelection(e.Entities);
        }
        protected void CollectionViewModel_CustomGroup(object sender, EventArgs e) {
            ViewModel.NewGroup();
        }
        protected void CollectionViewModel_CustomFilter(object sender, EventArgs e) {
            ViewModel.New();
        }
        void CollectionViewModel_EntitiesCountChanged(object sender, EntitiesCountEventArgs e) {
            UpdateAccordion();
        }
        void ViewModel_SelectedItemChanged(object sender, EventArgs e) {
            var helper = new FilterAccordionHelper<TEntity, TID, TUnitOfWork>(AccordionControl);
            AccordionControl.SelectedElement = helper.FindElementByTag(ViewModel.SelectedItem);
        }
        void ViewModel_FilterAccordionChanged(object sender, EventArgs e) {
            UpdateAccordion();
        }
        void AccordionControl_ElementClick(object sender, ElementClickEventArgs e) {
            if(e.MouseButton == MouseButtons.Right) {
                var clientPoint = accordionControlCore.PointToClient(Cursor.Position);

                var helper = new FilterAccordionHelper<TEntity, TID, TUnitOfWork>(AccordionControl);
                helper.PopulateMenu(e.Element, ViewModel)?.ShowPopup(accordionControlCore, clientPoint);
                e.Handled = true;
            }
        }
        void AccordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e) {
            ViewModel.SelectedItem = e.Element?.Tag as FilterItemBase;
        }
        #endregion

        void UpdateAccordion() {
            accordionControlCore.BeginUpdate();
            accordionControlCore.Clear();
            CreateHeaders();
            CreateBody();
            accordionControlCore.EndUpdate();
        }
        void SetSelectedElement() {
            var helper = new FilterAccordionHelper<TEntity, TID, TUnitOfWork>(AccordionControl);
            accordionControlCore.SelectedElement = helper.FindElementByTag(ViewModel.SelectedItem);
        }
        void ExpandAccordion() {
            accordionControlCore.ExpandAll();
        }
        void CreateBody() {
            foreach(var header in accordionFilterElements.Keys) {
                AccordionControlElement currentElement = accordionFilterElements[header];
                var filters = GetFilters(header);
                BindItems(currentElement, filters);
                accordionControlCore.Elements.Add(currentElement);
            }
            SetSelectedElement();
            ExpandAccordion();

        }
        void SetupAccordion() {
            accordionControlCore.BeginUpdate();
            accordionControlCore.AllowElementDragging = true;
            SubscribeEvents();
            CreateHeaders();
            CreateBody();
            accordionControlCore.EndUpdate();
        }
        void BindItems(AccordionControlElement accordionElement, ObservableCollection<FilterItemBase> filters) {
            foreach(var filter in filters) {
                AccordionControlElement element = new AccordionControlElement() {
                    Text = ViewModel.GetFilterName(filters, filter),
                    Tag = filter,
                    Style = ElementStyle.Item
                };
                accordionElement.Elements.Add(element);
            }
        }
        ObservableCollection<FilterItemBase> GetFilters(string header) {
            if(header == staticFiltersHeader) {
                return ViewModel.StaticFilters;
            }
            else if(header == customFiltersHeader) {
                return ViewModel.CustomFilters;
            }
            else if(header == groupFiltersHeader) {
                return ViewModel.Groups;
            }
            return null;
        }
    }
}
