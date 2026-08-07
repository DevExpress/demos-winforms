using System;
using System.Collections.Generic;
using System.Reflection;
using DevExpress.Utils;
using DevExpress.WindowsMailClient.Win.Utils;

namespace DevExpress.WindowsMailClient.Win.Services {
    public enum PanelType {
        Unknown,
        Settings,
        Folders,
        Accounts,
        FocusedOther,
        Notifications
    }
    public interface IPanelProviderService {
        void ShowPanel(PanelType panelType);
        void HidePanel(PanelType panelType);
        void HideAllPanels();
    }
    
    sealed class PanelProviderService : IPanelProviderService {
        readonly IDictionary<PanelType, WeakReference> panelsCache;
        public PanelProviderService() {
            this.panelsCache = new Dictionary<PanelType, WeakReference>();
            LoadPanels();
        }
        void LoadPanels() {
            panelsCache.Add(PanelType.Settings, new WeakReference(GetFlyoutPanelInstance("flyoutPanelSettings") as FlyoutPanel));
            panelsCache.Add(PanelType.FocusedOther, new WeakReference(GetFlyoutPanelInstance("flyoutPanelFocuedInboxSettings") as FlyoutPanel));
            panelsCache.Add(PanelType.Folders, new WeakReference(GetFlyoutPanelInstance("flyoutPanelFolders") as FlyoutPanel));
            panelsCache.Add(PanelType.Notifications, new WeakReference(GetFlyoutPanelInstance("flyoutPanelNotifications") as FlyoutPanel));
            panelsCache.Add(PanelType.Accounts, new WeakReference(GetFlyoutPanelInstance("flyoutPanelAccounts") as FlyoutPanel));
        }
        static object GetFlyoutPanelInstance(string name) {
            var mainFormType = AppProvider.MainForm.GetType();
            FieldInfo info = mainFormType.GetField(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if(info != null)
                return info.GetValue(AppProvider.MainForm);
            return null;
        }
        public void ShowPanel(PanelType panelType) {
            WeakReference panelRef = null;
            if(panelsCache.TryGetValue(panelType, out panelRef)) {
                FlyoutPanel panel = panelRef.Target as FlyoutPanel;
                if(panel != null) {
                    if(!panel.Visible) {
                        panel.ShowPopup(true);
                        
                    }
                    else panel.HidePopup(true);
                }
            }
        }
        public void HidePanel(PanelType panelType) {
            WeakReference panelRef = null;
            if(panelsCache.TryGetValue(panelType, out panelRef)) {
                FlyoutPanel panel = panelRef.Target as FlyoutPanel;
                if(panel != null && panel.Visible) panel.HidePopup(true);
            }
        }
        public void HideAllPanels() {
            foreach(WeakReference pref in panelsCache.Values) {
                FlyoutPanel panel = pref.Target as FlyoutPanel;
                if(panel != null && panel.Visible) panel.HidePopup(true);
            }
        }
    }
}
