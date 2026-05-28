using DevExpress.Data;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LipsumDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.LipsumDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Paging", "Paging.cs")]
    public static class Paging {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var gridControl = new DevExpress.XtraGrid.GridControl();
            var gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = new BindingList<LipsumObject>();
            gridView.PopulateColumns();
            return new object[] { gridControl, gridView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as DevExpress.XtraGrid.GridControl).Dispose();
        }
        #region Unbound Columns
        [CodeExampleCase("Virtual Paging", new Type[] { typeof(VirtualPagerHelper) }), LipsumDataSourceFile]
        [CodeExampleHighlightTokens("VirtualServerModeSource", "VirtualServerModeConfigurationInfo", "VirtualServerModeRowsEventArgs", 
            "CancellationToken", "LipsumObject", "Task", "HtmlPagerHelper", "ICollection", "IEnumerable", "Func", "LoremIpsum")]
        [CodeExampleUnderlineTokens("ConfigurationChanged", "MoreRows"), CodeExampleVersionID(202)]
        public static void VirtualPaging(GridControl gridControl, GridView gridView) {
            // Creating the VirtualSource
            var virtualSource = new VirtualServerModeSource();
            virtualSource.RowType = typeof(LipsumObject);
            // Creating the Pager (LabelControl with Html formatting)
            var htmlPager = new LabelControl();
            htmlPager.AllowHtmlString = true;
            htmlPager.Dock = System.Windows.Forms.DockStyle.Bottom;
            htmlPager.Padding = new System.Windows.Forms.Padding(10);
            htmlPager.Parent = gridControl.Parent;
            htmlPager.SendToBack();
            // Creating the paging tasks
            const int TotalRowsCount = 1234, RowsPerPage = 10;
            var rowsTask = new Func<VirtualServerModeConfigurationInfo, int, int, CancellationToken, Task<ICollection>>(
                async (config, pageSize, pageToFetch, cancellation) => {
                    await System.Threading.Tasks.Task.Delay(333, cancellation);
                    return LipsumObject.GetRows(TotalRowsCount, config.Filter, config.SortInfo)
                        .Skip(pageSize * pageToFetch)
                        .Take(pageSize)
                        .ToArray();
                });
            var rowCountTask = new Func<VirtualServerModeConfigurationInfo, CancellationToken, Task<int>>(
                async (config, cancellation) => {
                    await System.Threading.Tasks.Task.Delay(5555, cancellation);
                    return LipsumObject.GetRows(TotalRowsCount, config.Filter, config.SortInfo).Count();
                });
            // Handling the paging
            new VirtualPagerHelper(RowsPerPage, virtualSource, htmlPager, rowsTask, rowCountTask);
            gridControl.DataSource = virtualSource;
        }
        #endregion
        [CodeExampleNestedClass]
        public class VirtualPagerHelper : IDisposable {
            public static class HtmlPagerHelper {
                public static IEnumerable<string> GenerateHtmlPagerElements(int currentPage, int pages, int visibleRadius, string lastPageTextOverride) {
                    for(int pg = 0; pg < pages; ++pg) {
                        if(pg == visibleRadius + 1 && pg < currentPage - visibleRadius - 1) {
                            pg = currentPage - visibleRadius;
                            yield return "…";
                        }
                        if(pg == currentPage + visibleRadius + 1 && pg < pages - visibleRadius - 2) {
                            pg = pages - visibleRadius - 1;
                            yield return "…";
                        }
                        var pageDispText = (lastPageTextOverride != null && pg != currentPage && pg == pages - 1) ? lastPageTextOverride : (pg + 1).ToString(CultureInfo.InvariantCulture);
                        if(pg == currentPage)
                            yield return "<b>" + pageDispText + "</b>";
                        else
                            yield return "<href=" + pg + ">" + pageDispText + "</href>";
                    }
                }
                public static string GenerateHtmlPager(int currentPage, int pages, int visibleRadius, string lastPageTextOverride) {
                    return string.Join(" ", GenerateHtmlPagerElements(currentPage, pages, visibleRadius, lastPageTextOverride));
                }
                public static int DefaultVisibleRadius = 4;
                public static string GenerateHtmlPager(int currentPage, int pages) {
                    return string.Join(" ", GenerateHtmlPagerElements(currentPage, pages, DefaultVisibleRadius, null));
                }
                public const string MoreButtonText = "→";
                public static string GenerateHtmlPager(int currentPage, int pages, string lastPageTextOverride) {
                    return string.Join(" ", GenerateHtmlPagerElements(currentPage, pages, DefaultVisibleRadius, lastPageTextOverride));
                }
            }
            int pageSize;
            int currentPage;
            int pagesCount;
            bool pagesCountKnownExactly;
            CancellationTokenSource pagesCountCancellation;
            VirtualServerModeSource virtualSource;
            LabelControl htmlPager;
            Func<VirtualServerModeConfigurationInfo, int, int, CancellationToken, Task<ICollection>> rowsTask;
            Func<VirtualServerModeConfigurationInfo, CancellationToken, Task<int>> rowCountTask;
            public VirtualPagerHelper(int initialPageSize, VirtualServerModeSource virtualSource,
                LabelControl htmlPager,
                Func<VirtualServerModeConfigurationInfo, int, int, CancellationToken, Task<ICollection>> rowsTask,
                Func<VirtualServerModeConfigurationInfo, CancellationToken, Task<int>> rowCountTask) {
                pageSize = initialPageSize;
                this.virtualSource = virtualSource;
                this.htmlPager = htmlPager;
                this.rowsTask = rowsTask;
                this.rowCountTask = rowCountTask;
                //
                pagesCount = 1;
                pagesCountKnownExactly = false;
                currentPage = 0;
                //
                htmlPager.HyperlinkClick += HtmlPager_HyperlinkClick;
                virtualSource.ConfigurationChanged += src_ConfigurationChanged;
                virtualSource.MoreRows += src_MoreRows;
                //
                UpdatePager();
            }
            public void Dispose() {
                if(htmlPager != null)
                    htmlPager.HyperlinkClick -= HtmlPager_HyperlinkClick;
                htmlPager = null;
                if(virtualSource != null) {
                    virtualSource.ConfigurationChanged -= src_ConfigurationChanged;
                    virtualSource.MoreRows -= src_MoreRows;
                    htmlPager = null;
                }
                CancelPagesTask();
            }
            void CancelPagesTask() {
                if(pagesCountCancellation == null)
                    return;
                var c = pagesCountCancellation;
                pagesCountCancellation = null;
                c.Cancel();
                c.Dispose();
            }
            async Task<VirtualServerModeRowsTaskResult> GetRowsPageAsync(VirtualServerModeRowsEventArgs e) {
                var userTask = rowsTask(e.ConfigurationInfo, this.pageSize, this.currentPage, e.CancellationToken);
                var userRv = await userTask;
                OnPageLoaded(userRv.Count);
                return new VirtualServerModeRowsTaskResult(userRv);
            }
            void src_MoreRows(object sender, VirtualServerModeRowsEventArgs e) {
                e.RowsTask = GetRowsPageAsync(e);
            }
            void src_ConfigurationChanged(object sender, VirtualServerModeRowsEventArgs e) {
                if(inPageClick != 0)    // pager navigation, not real reconfiguration
                    return;
                CancelPagesTask();
                currentPage = 0;
                pagesCount = 1;
                pagesCountKnownExactly = false;
                UpdatePager();
                var pagesTask = GoPagesCount(e);
            }
            async System.Threading.Tasks.Task GoPagesCount(VirtualServerModeRowsEventArgs e) {
                if(rowCountTask == null)
                    return;
                var cancellationSource = new CancellationTokenSource();
                this.pagesCountCancellation = cancellationSource;
                int rowCount = await rowCountTask(e.ConfigurationInfo, cancellationSource.Token);
                CancelPagesTask();
                if(rowCount >= 0) {
                    pagesCountKnownExactly = true;
                    pagesCount = (rowCount + pageSize - 1) / pageSize;
                    UpdatePager();
                }
            }
            void HtmlPager_HyperlinkClick(object sender, HyperlinkClickEventArgs e) {
                OnPageClick(int.Parse(e.Link, CultureInfo.InvariantCulture));
            }
            int inPageClick;
            void OnPageClick(int page) {
                ++inPageClick;
                try {
                    currentPage = page;
                    UpdatePager();
                    virtualSource.Refresh();
                }
                finally { --inPageClick; }
            }
            public void SetPageSize(int newPageSize) {
                pageSize = newPageSize;
                currentPage = 0;
                virtualSource.Refresh();
            }
            void OnPageLoaded(int rows) {
                if(!pagesCountKnownExactly) {
                    if(currentPage == pagesCount - 1) {
                        if(rows < pageSize) {
                            CancelPagesTask();
                            pagesCountKnownExactly = true;
                            if(rows == 0)
                                pagesCount--;
                        }
                        else pagesCount++;
                    }
                }
                UpdatePager();
            }
            void UpdatePager() {
                if(pagesCountKnownExactly)
                    this.htmlPager.Text = HtmlPagerHelper.GenerateHtmlPager(currentPage, Math.Max(pagesCount, currentPage + 1));
                else
                    this.htmlPager.Text = HtmlPagerHelper.GenerateHtmlPager(currentPage, pagesCount, HtmlPagerHelper.MoreButtonText);
            }
        }
    }
}
