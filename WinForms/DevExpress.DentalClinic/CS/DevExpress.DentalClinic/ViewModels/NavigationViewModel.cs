namespace DevExpress.DentalClinic.ViewModel {
    using DevExpress.DentalClinic.Model;
    using DevExpress.DentalClinic.Services;
    using DevExpress.DentalClinic.View;
    using DevExpress.ExpressApp.Security;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;
    using DevExpress.Xpo;
    using DevExpress.XtraEditors;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class NavigationViewModel : IDisposable {
        NavigationTreeNode navigationRootNode;
        NavigationTreeNode currentNavigationNode;
        public NavigationViewModel() {
            NavigationBarVisible = true;
            Messenger.Default.Register<ReloadDataMessage>(this, OnReloadData);
        }
        public void Dispose() {
            Messenger.Default.Unregister<ReloadDataMessage>(this, OnReloadData);
            NavigationService.CurrentChanged -= OnNavigationServiceCurrentChanged;
            sessionCore?.Dispose();
        }
        void OnReloadData(ReloadDataMessage message) {
            if(SessionProvider == null) 
                return;
            sessionCore = null;
            ShowUserCollectionView = SessionProvider.Security.CanNavigate("UserCollection");
            UpdateCurrentNavigationNodeDisplayText();
        }
        UnitOfWork sessionCore;
        public UnitOfWork Session {
            get {
                if(sessionCore == null)
                    sessionCore = SessionProvider.CreateSession();
                return sessionCore;
            }
        }
        public virtual string CurrentViewType { 
            get; 
            set; 
        }
        public virtual string NavigationPath { 
            get; 
            set; 
        }
        public virtual bool NavigationBarVisible { 
            get; 
            set; 
        }
        public virtual BreadCrumbNode SelectedNode { 
            get; 
            set; 
        }
        public virtual bool OverlayFormTrigger { 
            get; 
            set; 
        }
        protected INavigationService NavigationService {
            get { return this.GetService<INavigationService>(); }
        }
        protected NavigationTreeNode CurrentNavigationNode { 
            get { return currentNavigationNode; }
            set { 
                currentNavigationNode = value;
                CurrentViewType = currentNavigationNode?.ViewType;
            }
        }
        public void Load(NavigationContext navigationContext) {
            navigationRootNode = NavigationTreeBuilder.Create()
                .AddRoute($@"{nameof(PatientCollectionView)}[Patients]\{nameof(PatientView)}[PersonName]")
                .AddRoute($@"{nameof(UserCollectionView)}[Employees]\{nameof(EmployeeView)}[PersonName]");
            navigationContext.Assign(navigationRootNode);
            CurrentNavigationNode = navigationRootNode;
            NavigationService.CurrentChanged += OnNavigationServiceCurrentChanged;
            NavigateTo(nameof(PatientCollectionView));
        }
        void OnNavigationServiceCurrentChanged(object sender, System.EventArgs e) {
            if(NavigationService.Current == null) 
                return;
            var document = NavigationService.Current as IDocument;
            var documentInfo = NavigationService.Current as IDocumentInfo;
            string viewType = documentInfo.DocumentType;
            UpdateCurrentNavigationNode(viewType);
            NavigationBarVisible = CurrentNavigationNode != navigationRootNode;
            NavigationPath = CurrentNavigationNode.GetRoute();
            if(NavigationBarVisible)
                UpdateCurrentNavigationNodeDisplayTextCore(viewType, document.Content);
        }
        void UpdateCurrentNavigationNodeDisplayText() {
            if(NavigationService.Current == null || SelectedNode == null) 
                return;
            var document = NavigationService.Current as IDocument;
            var documentInfo = NavigationService.Current as IDocumentInfo;
            string viewType = documentInfo.DocumentType;
            UpdateCurrentNavigationNodeDisplayTextCore(viewType, document.Content);
        }
        void UpdateCurrentNavigationNodeDisplayTextCore(string viewType, object viewModel) {
            if(SelectedNode == null || CurrentNavigationNode.DisplayText != "PersonName") 
                return;
            string actualName = string.Empty;
            if(viewType == nameof(PatientView)) {
                var patientViewModel = viewModel as PatientViewModel;
                var patient = Session.GetObjectByKey<Patient>(patientViewModel.PatientId);
                actualName = patient?.FullName ?? "New Patient";
            }
            if(viewType == nameof(EmployeeView)) {
                var employeeViewModel = viewModel as EmployeeViewModel;
                var patient = Session.GetObjectByKey<Employee>(employeeViewModel.EmployeeId);
                actualName = patient?.FullName ?? "Employee";
            }
            if(!string.IsNullOrEmpty(actualName))
                SelectedNode.Caption = actualName;
        }
        void UpdateCurrentNavigationNode(string viewType) {
            var nextNode = CurrentNavigationNode.GetNodeBy(viewType);
            if(nextNode != null)
                CurrentNavigationNode = nextNode;
            else if(CurrentNavigationNode.Parent != null && CurrentNavigationNode.Parent.ViewType == viewType)
                CurrentNavigationNode = CurrentNavigationNode.Parent;
            else {
                var node = navigationRootNode.GetNodeBy(viewType);
                CurrentNavigationNode = node ?? navigationRootNode;
            }
        }
        public void ChangeTheme() {
            OverlayFormTrigger = true;
            Properties.Settings.Default.DarkTheme = !Properties.Settings.Default.DarkTheme;
            Properties.Settings.Default.Save();
            OverlayFormTrigger = false;
        }
        HashSet<string> overlayFormHash = new HashSet<string>();
        public void OpenLoginView() {
            LoginService.Login(SessionProvider.Security.UserName);
        }
        public virtual bool ShowUserCollectionView { 
            get; 
            set; 
        }
        protected void OnShowUserCollectionViewChanged() {
            if(!ShowUserCollectionView && CurrentViewType == nameof(UserCollectionView)) {
                NavigateTo(nameof(PatientCollectionView));
            }
        }
        public bool CanNavigateTo(NavigateArgs args) {
            var source = NavigationService.Current as IDocument;
            IEditViewModel editViewModel = source.Content as IEditViewModel;
            var allow = (args.Path != NavigationPath) && (editViewModel == null || editViewModel.CanNavigateFrom());
            if(!allow)
                args.Cancel();
            return allow;
        }
        public void NavigateTo(NavigateArgs args) {
            bool allowShowOverlay = args.ShowOverlay && overlayFormHash.Add(args.Path);
            if(allowShowOverlay)
                OverlayFormTrigger = true;
            NavigateTo(args.Path);
            if(allowShowOverlay)
                OverlayFormTrigger = false;
        }
        void NavigateTo(string path) {
            string targetViewType = Path.GetFileName(path.TrimEnd(Path.DirectorySeparatorChar));
            var source = NavigationService.Current as IDocument;
            NavigationService.Navigate(targetViewType);
            if(source != null && source.Content is PatientViewModel) {
                NavigationService.ClearNavigationHistory();
                if(source != null)
                    source.Close(true);
            }
        }
        ISecuredObjectSpaceService SessionProvider {
            get { return this.GetService<ISecuredObjectSpaceService>(); }
        }
        ILoginService LoginService {
            get { return ServiceContainer.Default.GetService(typeof(ILoginService), "") as ILoginService; }
        }
    }
    public interface IEditViewModel {
        bool CanNavigateFrom();
    }
    //
    public class NavigationContext {
        readonly BreadCrumbNodeCollection nodes;
        public NavigationContext(BreadCrumbNodeCollection nodes) {
            this.nodes = nodes;
        }
        public void Assign(NavigationTreeNode root) {
            FillBreadCrumbNodes(nodes, root);
        }
        void FillBreadCrumbNodes(BreadCrumbNodeCollection collection, NavigationTreeNode root) {
            foreach(var node in root.Nodes) {
                var breadCrumbNode = new BreadCrumbNode(node.DisplayText, node.ViewType);
                collection.Add(breadCrumbNode);
                FillBreadCrumbNodes(breadCrumbNode.ChildNodes, node);
            }
        }
    }
    public class NavigationTreeNode {
        readonly List<NavigationTreeNode> nodes;
        public NavigationTreeNode() {
            nodes = new List<NavigationTreeNode>();
        }
        public string ViewType {
            get; 
            set;
        }
        public string DisplayText {
            get; 
            set;
        }
        public NavigationTreeNode Parent {
            get; 
            private set;
        }
        public IEnumerable<NavigationTreeNode> Nodes {
            get { return nodes; }
        }
        public void AddNode(NavigationTreeNode node) {
            nodes.Add(node);
            node.Parent = this;
        }
        public NavigationTreeNode GetNodeBy(string viewType) {
            return FindNode(n => n.ViewType == viewType, false);
        }
        NavigationTreeNode FindNode(Predicate<NavigationTreeNode> predicate, bool recursively) {
            foreach(var node in Nodes) {
                if(predicate(node)) 
                    return node;
                if(recursively) {
                    var result = node.FindNode(predicate, recursively);
                    if(result != null)
                        return result;
                }
            }
            return null;
        }
        public string GetRoute() {
            var stack = new Stack<string>();
            var node = this;
            while(node.Parent != null) {
                stack.Push(node.ViewType);
                node = node.Parent;
            }
            return string.Join(Path.DirectorySeparatorChar.ToString(), stack.ToArray());
        }
    }
    static class NavigationTreeBuilder {
        public static NavigationTreeNode Create() {
            return new NavigationTreeNode();
        }
        public static NavigationTreeNode AddRoute(this NavigationTreeNode root, string route) {
            var routeParts = route.Split(new[] { Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries);
            var currentNode = root;
            foreach(var part in routeParts) {
                int displayTextEnterCharIdx = part.IndexOf('[');
                int displayTextEndCharIdx = part.LastIndexOf(']');
                string displayText = part;
                string viewType = part;
                if(displayTextEndCharIdx >= 0 && displayTextEnterCharIdx >= 0) {
                    int displayTextLength = displayTextEndCharIdx - displayTextEnterCharIdx - 1;
                    viewType = part.Substring(0, displayTextEnterCharIdx);
                    displayText = displayTextLength > 0 ? part.Substring(displayTextEnterCharIdx + 1, displayTextLength) : viewType;
                }
                var matchedNode = currentNode.GetNodeBy(viewType);
                if(matchedNode == null) {
                    matchedNode = new NavigationTreeNode { ViewType = viewType, DisplayText = displayText };
                    currentNode.AddNode(matchedNode);
                }
                currentNode = matchedNode;
            }
            return root;
        }
    }
    public class NavigateArgs {
        readonly Action cancelAction;
        public NavigateArgs(string path, Action cancelAction, bool showOverlay) {
            this.cancelAction = cancelAction;
            Path = path;
            ShowOverlay = showOverlay;
        }
        public string Path {
            get;
            private set;
        }
        public bool ShowOverlay { 
            get;
            private set;
        }
        public void Cancel() {
            cancelAction();
        }
    }
}
