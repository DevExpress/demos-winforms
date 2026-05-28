using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.Skins;
using DevExpress.XtraNavBar;
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraEditors;
using DevExpress.Utils.Design;

namespace DevExpress.ProductsDemo.Win.Controls {
    public partial class ucCalendar : XtraUserControl {
        SchedulerControl schedulerControl;
                
        public ucCalendar() {
            if (!DesignTimeTools.IsDesignMode)
                LookAndFeel.ActiveLookAndFeel.StyleChanged += new EventHandler(ActiveLookAndFeel_StyleChanged);
            InitializeComponent();
            this.treeResources.LayoutUpdated += treeResources_LayoutUpdated;
            Disposed += ucCalendar_Disposed;
        }

        void treeResources_LayoutUpdated(object sender, EventArgs e) {
            UpdateTreeListHeight();
        }
        public void InitDateNavigator(SchedulerControl schedulerControl) {
            this.schedulerControl = schedulerControl;
            this.dateNavigator1.SchedulerControl = schedulerControl;
        }
        public void InitResourcesTree(SchedulerStorage storage) {
            if (treeResources.Nodes.Count > 0)
                return;

            treeResources.BeginUnboundLoad();
            treeResources.AppendNode(new object[] { Properties.Resources.Work }, -1, CheckState.Checked);
            treeResources.AppendNode(new object[] { Properties.Resources.Personal }, -1, CheckState.Checked);

            foreach (Resource item in storage.Resources.Items) {
                int id = (int)item.Id;
                TreeListNode node = treeResources.AppendNode(new object[] { item.Caption }, CalculateResourceCategory(id), id);
                node.CheckState = CheckState.Checked;
            }
            treeResources.EndUnboundLoad();
            treeResources.ExpandAll();
        }
        protected int CalculateResourceCategory(int resourceId) {
            return resourceId < 3 ? 0 : 1;
        }
        private void treeResources_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e) {
            foreach (TreeListNode node in e.Node.Nodes) {
                node.CheckState = e.Node.CheckState;
            }
            if (e.Node.ParentNode != null) 
                e.Node.ParentNode.CheckState = GetParentNodeState(e.Node.ParentNode.Nodes);

            this.schedulerControl.ActiveView.LayoutChanged();
        }
        CheckState GetParentNodeState(TreeListNodes nodes) {
            CheckState state = nodes[0].CheckState;
            foreach (TreeListNode node in nodes)
                if (node.CheckState != state) return CheckState.Indeterminate;
            return state;
        }
        public List<int> GetSelectedResourceIds() {
            List<int> result = new List<int>();
            FillSelectedNodes(treeResources.Nodes[0], result);
            FillSelectedNodes(treeResources.Nodes[1], result);
            return result;
        }
        private void FillSelectedNodes(TreeListNode node, List<int> resourceIds) {
            foreach (TreeListNode item in node.Nodes)
                if (item.CheckState == CheckState.Checked)
                    resourceIds.Add((int)item.Tag);
        }

        private void treeResources_AfterCollapse(object sender, DevExpress.XtraTreeList.NodeEventArgs e) {
            EndCalcTreeListHeight();
        }

        private void treeResources_AfterExpand(object sender, DevExpress.XtraTreeList.NodeEventArgs e) {
            EndCalcTreeListHeight();
        }
        void StartCalcTreeListHeight() {
            treeResources.BeginUpdate();
        }
        void CalcTreeListHeight() {
            treeResources.Height = GetExpandedRowCount(treeResources.Nodes) * treeResources.ViewInfo.RowHeight + 2;
        }
        void EndCalcTreeListHeight() {
            CalcTreeListHeight();
            treeResources.EndUpdate();
        }
        public void UpdateTreeListHeight() {
            BeginInvoke(new MethodInvoker(CalcTreeListHeight));
        }
        int GetExpandedRowCount(TreeListNodes nodes) {
            int count = 0;
            foreach(TreeListNode node in nodes) {
                count++;
                if(node.Expanded)
                    count += GetExpandedRowCount(node.Nodes);
            }
            return count;
        }

        private void treeResources_BeforeCollapse(object sender, DevExpress.XtraTreeList.BeforeCollapseEventArgs e) {
            StartCalcTreeListHeight();
        }

        private void treeResources_BeforeExpand(object sender, DevExpress.XtraTreeList.BeforeExpandEventArgs e) {
            StartCalcTreeListHeight();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (!DesignTimeTools.IsDesignMode)
                LookAndFeelStyleChanged();
        }
        void ucCalendar_Disposed(object sender, EventArgs e) {
            if (!DesignTimeTools.IsDesignMode) {
                if (LookAndFeel != null && LookAndFeel.ActiveLookAndFeel != null)
                    LookAndFeel.ActiveLookAndFeel.StyleChanged -= new EventHandler(ActiveLookAndFeel_StyleChanged);
            }
        }
        void ActiveLookAndFeel_StyleChanged(object sender, EventArgs e) {
            LookAndFeelStyleChanged();
        }
        void LookAndFeelStyleChanged() {
            CalcTreeListHeight();
        }
    }
}
