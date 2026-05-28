using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.DentalClinic.Model;
using DevExpress.DentalClinic.ViewModel;
using DevExpress.DentalClinic.Views.Patients;
using DevExpress.LookAndFeel;
using DevExpress.Mvvm.Native;
using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Tile;

namespace DevExpress.DentalClinic.View {
    public partial class ProcedureCollectionView : XtraUserControl {
        public ProcedureCollectionView() {
            InitializeComponent();
        }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            InitializeBindings();
            svgImageBoxTeeth.SelectionChanging += OnSvgImageBoxSelectionChanging;
            svgImageBoxTeeth.ItemEnter += OnSvgImageBoxItemEnter;
            svgImageBoxTeeth.ItemLeave += OnSvgImageBoxItemLeave;
            svgImageBoxTeeth.QueryHoveredItem += OnSvgImageBoxQueryHoveredItem;
            proceduresTabPane.SelectedPageChanging += OnProceduresTabPaneSelectedPageChanging;
            tbProcedureGroups.SelectedItem = tbiDiagnosis;
            tvAddedProcedures.CustomDrawEmptyForeground += OnCustomDrawAddedProceduresListEmptyForeground;
            gcAllProcedures.Load += OnProcedureGridLoad;
            gcGeneralProcedures.Load += OnProcedureGridLoad;
            gcToothProcedures.Load += OnProcedureGridLoad;
        }
        void InitializeBindings() {
            InitializeTileBarColors();
            InitializeTileViewColors();
            var fluentAPI = mvvmContext1.OfType<ProcedureCollectionViewModel>();
            fluentAPI.WithEvent<EventArgs>(this, nameof(Load)).EventToCommand(x => x.UpdateEnabledGroups());
            fluentAPI.WithEvent<TileItemEventArgs>(tbProcedureGroups, nameof(tbProcedureGroups.SelectedItemChanged)).SetBinding(x => x.SelectedGroup, ea => (ProcedureGroup)ea.Item.Tag);
            fluentAPI.WithEvent<ContextItemClickEventArgs>(tvAddedProcedures, nameof(tvAddedProcedures.ContextButtonClick)).EventToCommand(x => x.RemoveProcedure, (ContextItemClickEventArgs ea) => tvAddedProcedures.GetRow((ea.DataItem as TileViewItem).RowHandle) as AddedProcedureInfo);
            fluentAPI.WithEvent<TileViewItemClickEventArgs>(tvAllProcedures, nameof(tvAllProcedures.ItemClick)).EventToCommand(x => x.AddProcedure, ea => (Procedure)tvAllProcedures.GetRow(ea.Item.RowHandle));
            fluentAPI.WithEvent<TileViewItemClickEventArgs>(tvGeneralProcedures, nameof(tvGeneralProcedures.ItemClick)).EventToCommand(x => x.AddProcedure, ea => (Procedure)tvGeneralProcedures.GetRow(ea.Item.RowHandle));
            fluentAPI.WithEvent<TileViewItemClickEventArgs>(tvToothProcedures, nameof(tvToothProcedures.ItemClick)).EventToCommand(x => x.AddProcedure, ea => (Procedure)tvToothProcedures.GetRow(ea.Item.RowHandle));
            fluentAPI.WithEvent<EventArgs>(svgImageBoxTeeth, nameof(svgImageBoxTeeth.SelectionChanged))
              .SetBinding(x => x.Selection, ea => GetSelectedTooth());
            fluentAPI.WithCommand(x => x.AddProcedures)
                .Bind(sbAddProcedure)
                .After(ResetSelection);
            fluentAPI.SetTrigger(x => x.EnabledTypes, ts => {
                tbNavPageAllProcedures.PageEnabled  = ts.Contains(ProcedureType.Tooth) && ts.Contains(ProcedureType.General);
                tbNavPageGeneralProcedures.PageEnabled = ts.Contains(ProcedureType.General);
                tbNavPageToothProcedures.PageEnabled = ts.Contains(ProcedureType.Tooth);
                if(proceduresTabPane.SelectedPage == null || !proceduresTabPane.SelectedPage.PageEnabled)
                    proceduresTabPane.SelectedPage = proceduresTabPane.Pages.FirstOrDefault(x => x.PageEnabled) as TabNavigationPage;
            });
            fluentAPI.SetTrigger(x => x.EnabledGroups, gs => { 
                tbProcedureGroups.Groups
                .SelectMany(x => x.Items)
                .ForEach(x => x.Enabled = gs.Any(g => (ProcedureGroup)x.Tag == g));
                if(!tbProcedureGroups.SelectedItem.Enabled)
                    tbProcedureGroups.SelectedItem = tbProcedureGroups.Groups.SelectMany(x => x.Items).FirstOrDefault(x => x.Enabled) as TileItem;
            });
            fluentAPI.SetTrigger(x => x.SelectedGroup, g => {
                ApplyProcedureGroupFilter(tvcProcedureGroup1);
                ApplyProcedureGroupFilter(tvcProcedureGroup2);
                ApplyProcedureGroupFilter(tvcProcedureGroup3);
            });
            fluentAPI.SetBinding(sliTotalCostValue, x => x.Text, x => x.AddedProceduresCost);
            fluentAPI.SetBinding(xpBindingSource1, x => x.DataSource, x => x.Procedures);
            fluentAPI.SetBinding(gcAddedProcedures, x => x.DataSource, x => x.AddedProcedures);
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            ApplyProcedures();
        }
        void OnProcedureGridLoad(object sender, EventArgs e) {
            var procedureGroupColumn = ((sender as GridControl).MainView as TileView).Columns[nameof(Procedure.Group)];
            ApplyProcedureGroupFilter(procedureGroupColumn);
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            InitializeTileBarColors();
            InitializeTileViewColors();
        }
        void InitializeTileBarColors() {
            tbProcedureGroups.AppearanceItem.Normal.BackColor = LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.Window);
            tbProcedureGroups.AppearanceItem.Normal.ForeColor = DXSkinColors.ForeColors.ControlText;
            tbProcedureGroups.AppearanceItem.Normal.BorderColor = DevExpress.Utils.Colors.DXSkinColorHelper.GetDXSkinColor(DXSkinColors.ForeColors.DisabledText, 150, UserLookAndFeel.Default);
            tbProcedureGroups.AppearanceItem.Selected.BorderColor = DevExpress.Utils.Colors.DXSkinColorHelper.GetDXSkinColor(DXSkinColors.FillColors.Primary, UserLookAndFeel.Default);
            tbProcedureGroups.AppearanceItem.Disabled.BorderColor = DevExpress.Utils.Colors.DXSkinColorHelper.GetDXSkinColor(DXSkinColors.ForeColors.DisabledText, 150, UserLookAndFeel.Default);
            tbProcedureGroups.AppearanceItem.Disabled.BackColor = LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.Window);
            tbProcedureGroups.AppearanceItem.Disabled.ForeColor = DXSkinColors.ForeColors.DisabledText;
            tbProcedureGroups.Refresh();
        }
        void InitializeTileViewColors() {
            XtraGrid.Views.Tile.ViewInfo.TileViewInfoCore.HoverAnimationLength = 1;
            Color foreColor = Properties.Settings.Default.DarkTheme ? Color.Empty : DXSkinColors.IconColors.White;

            tvAllProcedures.Appearance.ItemHovered.BackColor = DXSkinColors.FillColors.Primary;
            tvAllProcedures.Appearance.ItemHovered.ForeColor = foreColor;
            tvAllProcedures.Appearance.ItemPressed.BackColor = DXSkinColors.FillColors.Primary;
            tvAllProcedures.Appearance.ItemPressed.ForeColor = foreColor;

            tvGeneralProcedures.Appearance.ItemHovered.BackColor = DXSkinColors.FillColors.Primary;
            tvGeneralProcedures.Appearance.ItemHovered.ForeColor = foreColor;
            tvGeneralProcedures.Appearance.ItemPressed.BackColor = DXSkinColors.FillColors.Primary;
            tvGeneralProcedures.Appearance.ItemPressed.ForeColor = foreColor;

            tvToothProcedures.Appearance.ItemHovered.BackColor = DXSkinColors.FillColors.Primary;
            tvToothProcedures.Appearance.ItemHovered.ForeColor = foreColor;
            tvToothProcedures.Appearance.ItemPressed.BackColor = DXSkinColors.FillColors.Primary;
            tvToothProcedures.Appearance.ItemPressed.ForeColor = foreColor;
        }
        void OnCustomDrawAddedProceduresListEmptyForeground(object sender, XtraGrid.Views.Base.CustomDrawEventArgs e) {
            e.Appearance.ForeColor = DXSkinColors.ForeColors.DisabledText;
            e.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            e.Appearance.TextOptions.VAlignment = VertAlignment.Center;
            Size textSize = e.Appearance.CalcTextSizeInt(e.Cache, DentalClinicStringId.AddedProceduresListPlaceholderText, e.Bounds.Width);
            Rectangle textBounds = PlacementHelper.Arrange(textSize, e.Bounds, ContentAlignment.MiddleCenter);
            e.Appearance.DrawString(e.Cache, DentalClinicStringId.AddedProceduresListPlaceholderText, textBounds);
        }
        void OnProceduresTabPaneSelectedPageChanging(object sender, SelectedPageChangingEventArgs e) {
            if(e.Page == null) return;
            e.Cancel = !e.Page.PageEnabled;
        }
        void OnAddedProceduresCustomColumnDisplayText(object sender, XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e) {
            if(e.Column.FieldName == nameof(Procedure) + "." + nameof(Procedure.Type) && !Object.Equals(e.Value, ProcedureType.General)) {
                int toothNumber = (int)tvAddedProcedures.GetRowCellValue(e.ListSourceRowIndex, nameof(ProcedureItem.ToothNumber));
                e.DisplayText = $"{e.DisplayText} {toothNumber}";
            }
            if(e.Column.FieldName == nameof(ProcedureItem.ToothNumber))
                e.DisplayText = Object.Equals(e.Value, -1) ? string.Empty : e.DisplayText;
        }
        void ApplyProcedureGroupFilter(GridColumn column) {
            column.FilterInfo = new ColumnFilterInfo(new BinaryOperator(nameof(Procedure.Group), (ProcedureGroup)tbProcedureGroups.SelectedItem.Tag));
        }
        void ApplyProcedures() {
            var viewModel = mvvmContext1.GetViewModel<ProcedureCollectionViewModel>();
            svgImageBoxTeeth.BeginUpdate();
            svgImageBoxTeeth.RootItems
                .ForEach(x => {
                    ToothLayoutHelper.UpdateTag(x);
                    ToothLayoutHelper.ApplyCompletedProcedures(x, viewModel.CompletedProcedures);
                    ToothLayoutHelper.ApplyOpenedProcedures(x, viewModel.OpenedProcedures);
                });
            svgImageBoxTeeth.EndUpdate();
        }
        void ResetSelection() {
            svgImageBoxTeeth.Selection.Clear();
            ApplyProcedures();
        }
        IEnumerable<int> GetSelectedTooth() {
            return svgImageBoxTeeth.Selection.Select(x => (int)x.Tag);
        }
        void OnSvgImageBoxSelectionChanging(object sender, SvgImageSelectionChangingEventArgs ea) {
            if(ea.Action == SvgImageSelectionChangeAction.Clear) {
                svgImageBoxTeeth.BeginUpdate();
                foreach(var item in svgImageBoxTeeth.Selection) 
                    ToothLayoutHelper.SetToothBadgeBackgroundVisibility(item, false);
                svgImageBoxTeeth.EndUpdate();
            }
            if(ea.Action == SvgImageSelectionChangeAction.Select) {
                ToothLayoutHelper.SetToothBadgeBackgroundVisibility(ea.Item, true);
            }
            if(ea.Action == SvgImageSelectionChangeAction.Unselect) {
                ToothLayoutHelper.SetToothBadgeBackgroundVisibility(ea.Item, false);
            }
        }
        void OnSvgImageBoxQueryHoveredItem(object sender, SvgImageQueryHoveredItemEventArgs e) {
            e.HoveredItem = ToothLayoutHelper.GetToothItem(e.HoveredItem);
        }
        void OnSvgImageBoxItemEnter(object sender, SvgImageItemEventArgs ea) {
            if(!svgImageBoxTeeth.Selection.Contains(ea.Item))
                ToothLayoutHelper.SetToothHoveredState(svgImageBoxTeeth, ea.Item, true);
            else
                ToothLayoutHelper.SetToothBackgroundVisibility(ea.Item, true);
        }
        void OnSvgImageBoxItemLeave(object sender, SvgImageItemEventArgs ea) {
            if(!svgImageBoxTeeth.Selection.Contains(ea.Item))
                ToothLayoutHelper.SetToothHoveredState(svgImageBoxTeeth, ea.Item, false);
            else
                ToothLayoutHelper.SetToothBackgroundVisibility(ea.Item, false);
        }
        public static class ToothLayoutHelper {
            public static SvgImageItem GetToothItem(SvgImageItem childItem) {
                SvgImageItem SvgShapeItem = childItem;
                do {
                    if(SvgShapeItem.Id != null && SvgShapeItem.Id.StartsWith("tooth"))
                        return SvgShapeItem;
                    SvgShapeItem = SvgShapeItem.Parent;
                } while(SvgShapeItem != null);
                return null;
            }
            public static void SetToothHoveredState(SvgImageBox imageBox, SvgImageItem toothItem, bool value) {
                imageBox.BeginUpdate();
                SetToothBackgroundVisibility(toothItem, value);
                SetToothBadgeBackgroundVisibility(toothItem, value);
                imageBox.EndUpdate();
            }
            public static void UpdateTag(SvgImageItem toothItem) {
                toothItem.Tag = Int32.Parse(toothItem.Id.Split('_')[1]);
            }
            public static void SetToothBadgeBackgroundVisibility(SvgImageItem toothItem, bool value) {
                var badgeItem = GetItem(toothItem, "badge");
                var badgeBackground = GetItem(badgeItem, "badgebackground");
                badgeBackground.Visible = value;
            }
            public static void SetToothBackgroundVisibility(SvgImageItem toothItem, bool value) {
                var backgroundItem = GetItem(toothItem, "hoverbackground");
                backgroundItem.Visible = value;
            }
            static void SetToothRootVisibility(SvgImageItem toothItem, bool value) {
                SvgImageItem toothRoot = GetItem(toothItem, "root");
                toothRoot.Visible = value;
            }
            static void SetProcedureVisibility(SvgImageItem toothItem, ProcedureGroup procedure, bool visibility) {
                SvgImageItem svgImageProcedureItem = GetProcedureItem(toothItem, procedure);
                svgImageProcedureItem.Visible = visibility;
            }
            public static void ApplyCompletedProcedures(SvgImageItem toothItem, IEnumerable<ProcedureItem> procedures) {
                procedures = procedures.Where(x => x.ToothNumber == (int)toothItem.Tag);
                foreach(var procedureItem in procedures) {
                    ProcedureGroup flag = procedureItem.Procedure.Group;
                    if((flag & ProcedureGroup.RootCanal) != 0) {
                        SetToothRootVisibility(toothItem, true);
                        SetProcedureVisibility(toothItem, ProcedureGroup.RootCanal, true);
                        HightlightProcedure(toothItem, flag, DXSkinColors.IconColors.Green);
                        continue;
                    }
                    if((flag & ProcedureGroup.Implantation) != 0) {
                        SetToothRootVisibility(toothItem, false);
                        SetProcedureVisibility(toothItem, ProcedureGroup.Implantation, true);
                        HightlightProcedure(toothItem, flag, DXSkinColors.IconColors.Green);
                        continue;
                    }

                    if((flag & ProcedureGroup.Whitening) != 0) {
                        SetProcedureVisibility(toothItem, ProcedureGroup.Whitening, true);
                        HightlightProcedure(toothItem, flag, DXSkinColors.IconColors.Green);
                        continue;
                    }
                    if((flag & ProcedureGroup.Surgery) != 0) {
                        SetProcedureVisibility(toothItem, ProcedureGroup.Surgery, true);
                        HightlightProcedure(toothItem, flag, DXSkinColors.IconColors.Green);
                        continue;
                    }
                    if((flag & ProcedureGroup.Prosthetics) != 0) {
                        SetProcedureVisibility(toothItem, ProcedureGroup.Prosthetics, true);
                        HightlightProcedure(toothItem, flag, DXSkinColors.IconColors.Green);
                        continue;
                    }
                }
            }
            public static void ApplyOpenedProcedures(SvgImageItem toothItem, IEnumerable<ProcedureItem> procedures) {
                procedures = procedures.Where(x => x.ToothNumber == (int)toothItem.Tag);
                foreach(var procedureItem in procedures) {
                    ProcedureGroup flag = procedureItem.Procedure.Group;
                    if((flag & ProcedureGroup.RootCanal) != 0) {
                        SetToothRootVisibility(toothItem, true);
                        SetProcedureVisibility(toothItem, ProcedureGroup.RootCanal, true);
                        HightlightProcedure(toothItem, flag, DXSkinColors.IconColors.Red);
                    }
                    if((flag & ProcedureGroup.Implantation) != 0) {
                        SetToothRootVisibility(toothItem, false);
                        SetProcedureVisibility(toothItem, ProcedureGroup.Implantation, true);
                        HightlightProcedure(toothItem, flag, DXSkinColors.IconColors.Red);
                    }
                    if((flag & ProcedureGroup.Whitening) != 0) {
                        SetProcedureVisibility(toothItem, ProcedureGroup.Whitening, true);
                        HightlightProcedure(toothItem, flag, DXSkinColors.IconColors.Red);
                    }
                    if((flag & ProcedureGroup.Surgery) != 0) {
                        SetProcedureVisibility(toothItem, ProcedureGroup.Surgery, true);
                        HightlightProcedure(toothItem, flag, DXSkinColors.IconColors.Red);
                    }
                    if((flag & ProcedureGroup.Prosthetics) != 0) {
                        SetProcedureVisibility(toothItem, ProcedureGroup.Prosthetics, true);
                        HightlightProcedure(toothItem, flag, DXSkinColors.IconColors.Red);
                    }
                }
            }
            static void HightlightProcedure(SvgImageItem toothItem, ProcedureGroup procedure, Color color, SvgImageItem item = null) {
                if(item == null)
                    item = GetProcedureItem(toothItem, procedure);
                item.Appearance.Normal.FillColor = color;
                item.Appearance.Hovered.FillColor = color;
                item.Appearance.Selected.FillColor = color;
            }
            static SvgImageItem GetProcedureItem(SvgImageItem toothItem, ProcedureGroup procedure) {
                return GetItem(toothItem, procedure.ToString());
            }
            static SvgImageItem GetItem(SvgImageItem SvgShapeItem, string tag) {
                return SvgShapeItem.Items.FirstOrDefault(x => x.Id != null && x.Id.StartsWith(tag, StringComparison.OrdinalIgnoreCase));
            }
        }
        void OnToolTipControllerGetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e) {
            if(e.Info == null) return;
            var toothItem = e.Info.Object as SvgImageItem;
            Rectangle itemBounds = Utils.Extensions.RectangleFExtensions.ToRectangle(toothItem.Bounds);
            e.Info.ToolTipType = ToolTipType.Flyout;
            e.Info.ToolTipPosition = svgImageBoxTeeth.PointToScreen(new Point(itemBounds.Right, itemBounds.Top + itemBounds.Height / 2));
            var toothFlyoutView = new ToothFlyoutView();
            toothFlyoutView.SetToothInfo(GetToothInfo(toothItem));
            e.Info.FlyoutControl = toothFlyoutView;
        }
        ToothInfo GetToothInfo(SvgImageItem toothItem) {
            var viewModel = mvvmContext1.GetViewModel<ProcedureCollectionViewModel>();
            int targetToothNumber = (int)toothItem.Tag;
            var completedProcedures = viewModel.CompletedProcedures.Where(x => x.ToothNumber == targetToothNumber).ToList();
            var openedProcedures = viewModel.OpenedProcedures.Where(x => x.ToothNumber == targetToothNumber).ToList();
            var toothInfo = new ToothInfo();
            toothInfo.Title = $"Tooth {targetToothNumber}";
            var openedProceduresTextBuilder = new StringBuilder();
            foreach(var openedProcedure in openedProcedures)
                openedProceduresTextBuilder.AppendLine($"• {openedProcedure.Procedure.Name}");
            var completedProceduresTextBuilder = new StringBuilder();
            foreach(var completedProcedure in completedProcedures)
                completedProceduresTextBuilder.AppendLine($"• {completedProcedure.Procedure.Name}");
            toothInfo.OpenedProcedures = openedProceduresTextBuilder.ToString();
            toothInfo.CompletedProcedures = completedProceduresTextBuilder.ToString();
            return toothInfo;
        }
    }
}
