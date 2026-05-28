using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.ActiveDemos;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.Data;
using DevExpress.Utils;
using System.Globalization;

namespace DevExpress.XtraGrid.Demos {
    public partial class Grid100000Records: TutorialControl {
        public Grid100000Records() {
            // This call is required by the Windows Form Designer.
            CreateWaitDialog();
            InitializeComponent();
            //sidePanel1.Visible = false;
            CreateData();
        }
        int startTickCount, endTickCount;
        public override bool HasActiveDemo { get { return true; } }
        protected override ActiveDemo CreateActiveDemo() {
            return new ActiveGridDemo(gridControl1);
        }
        protected override void RunGridActiveDemo(ActiveGridDemo activeDemo) {
            object oldDataSource = this.gridControl1.DataSource;
            this.gridControl1.DataSource = null;
            this.gridView1.SortInfo.Clear();
            this.startTickCount = System.Environment.TickCount;
            this.gridControl1.DataSource = oldDataSource;
            this.endTickCount = System.Environment.TickCount;
            ActiveDemoResults.Add(string.Format(Properties.Resources.ActiveGrid_100kRecords_DataReloading, OperationSeconds));

            if(activeDemo.Actions.Canceled)
                return;
            this.gridView1.StartSorting += new EventHandler(StartGroupingSorting);
            activeDemo.ClickGridColumn(this.colclnCurrency);
            this.endTickCount = System.Environment.TickCount;
            ActiveDemoResults.Add(string.Format(Properties.Resources.ActiveGrid_100kRecords_CurrencySorting, OperationSeconds));
            this.gridView1.StartSorting -= new EventHandler(StartGroupingSorting);

            if(activeDemo.Actions.Canceled)
                return;
            this.gridView1.StartSorting += new EventHandler(StartGroupingSorting);
            activeDemo.GroupByColumn(this.colclnWord);
            this.gridView1.StartSorting -= new EventHandler(StartGroupingSorting);
            this.endTickCount = System.Environment.TickCount;
            ActiveDemoResults.Add(string.Format(Properties.Resources.ActiveGrid_100kRecords_TextGrouping, OperationSeconds));

            if(activeDemo.Actions.Canceled)
                return;
            this.gridView1.StartSorting += new EventHandler(StartGroupingSorting);
            activeDemo.GroupByColumn(this.colclnDate);
            this.gridView1.StartSorting -= new EventHandler(StartGroupingSorting);
            this.endTickCount = System.Environment.TickCount;
            ActiveDemoResults.Add(string.Format(Properties.Resources.ActiveGrid_100kRecords_DateGrouping, OperationSeconds));

            activeDemo.ExpandCollapseRow(this.gridView1, 3);
            if(activeDemo.Actions.Canceled)
                return;
            ActiveActions.Delay(1000);
            activeDemo.ExpandCollapseRow(this.gridView1, 2);
            if(activeDemo.Actions.Canceled)
                return;
            ActiveActions.Delay(1000);

            if(activeDemo.Actions.Canceled)
                return;
            startTickCount = System.Environment.TickCount;
            this.gridView1.SortInfo.Clear();
            endTickCount = System.Environment.TickCount;
            ActiveDemoResults.Add(string.Format(Properties.Resources.ActiveGrid_100kRecords_ClearGrouping, OperationSeconds));
        }
        double OperationSeconds {
            get {
                return (double)(endTickCount - startTickCount) / 1000;
            }
        }
        void StartGroupingSorting(object sender, EventArgs e) {
            this.startTickCount = System.Environment.TickCount;
        }
        public class Record {
            public int Id { get; set; }
            public string Text { get; set; }
            public bool? Bool { get; set; }
            public DateTime? Date { get; set; }
            public decimal? Currency { get; set; }
        }
        int RowCount {
            get {
                if(ceRecord1.Checked)
                    return 100000;
                if(ceRecord2.Checked)
                    return 500000;
                if(ceRecord3.Checked)
                    return 1000000;
                return (int)seCustomRecordsCount.Value;
            }
        }
        void CreateData() {
            SetWaitDialogCaption(Properties.Resources.CreatingData);
            this.DataSeed = HashCodeHelper.Calculate(RowCount);
            this.unboundSource.SetRowCount(RowCount);
        }

        private void sbGenerate_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            try {
                sbGenerate.Enabled = false;
                CreateData();
            } finally {
                Cursor = Cursors.Default;
            }
        }

        private void seCustomRecordsCount_EditValueChanged(object sender, EventArgs e) {
            sbGenerate.Enabled = ceCustom.Checked;
        }

        private void ceRecord_CheckedChanged(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            try {
                CheckEdit ce = sender as CheckEdit;
                if(!ce.Checked)
                    return;
                if(ce != ceCustom) {
                    sbGenerate.Enabled = false;
                    CreateData();
                } else {
                    //this.bindingSource1.DataSource = null;
                    sbGenerate.Enabled = true;
                };
            } finally {
                Cursor = Cursors.Default;
            }
        }

        private void seCustomRecordsCount_Enter(object sender, EventArgs e) {
            ceCustom.Checked = true;
        }
        int DataSeed = 42;
        void unboundSource_ValueNeeded(object sender, UnboundSourceValueNeededEventArgs e) {
            switch(e.PropertyIndex) {
                case 0:
                    e.SetValue(e.RowIndex + 1);
                    break;
                case 1:
                    e.SetValue(LoremIpsum.GetWord(e.RowIndex, DataSeed));
                    break;
                case 2:
                    e.SetValue(LoremIpsum.GetText(e.RowIndex, DataSeed ^ 4));
                    break;
                case 3:
                    e.SetValue(TutorialConstants.Today.AddDays((HashCodeHelper.Combine(DataSeed ^ 1, e.RowIndex) & 255) - 200));
                    break;
                case 4:
                    Int64 pseudoRandom = HashCodeHelper.Combine(DataSeed ^ 2, e.RowIndex) - (Int64)int.MinValue;
                    e.SetValue((pseudoRandom >> 14) * 0.05m);
                    break;
                case 5:
                    e.SetValue((HashCodeHelper.Combine(DataSeed ^ 3, e.RowIndex) & 3) == 0);
                    break;
            }
        }
    }
    public static class LoremIpsum {
        public const string Explanation = "\"Lorem ipsum...\" is a dummy text used to replace text in some areas just for the purpose of an example. The words \"Lorem ipsum...\" make no sense.";
        const int CommonEntriesCount = 15;
        public static readonly string[] StaticGenerated = new[] {
            // common lipsum
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
            "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
            "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            "Curabitur pretium tincidunt lacus. Nulla gravida orci a odio.",
            "Nullam varius, turpis et commodo pharetra, est eros bibendum elit, nec luctus magna felis sollicitudin mauris.",
            "Integer in mauris eu nibh euismod gravida.",
            "Duis ac tellus et risus vulputate vehicula. Donec lobortis risus a elit. Etiam tempor.",
            "Ut ullamcorper, ligula eu tempor congue, eros est euismod turpis, id tincidunt sapien risus a quam. Maecenas fermentum consequat mi.",
            "Donec fermentum. Pellentesque malesuada nulla a mi.",
            "Duis sapien sem, aliquet nec, commodo eget, consequat quis, neque.",
            "Aliquam faucibus, elit ut dictum aliquet, felis nisl adipiscing sapien, sed malesuada diam lacus eget erat.",
            "Cras mollis scelerisque nunc. Nullam arcu.",
            "Aliquam consequat. Curabitur augue lorem, dapibus quis, laoreet et, pretium ac, nisi.",
            "Aenean magna nisl, mollis quis, molestie eu, feugiat in, orci. In hac habitasse platea dictumst.",
            // generated lipsum
            "Duis rutrum, dui ut tempor dignissim, lectus eros scelerisque sapien, ac tincidunt est risus vel sem.",
            "Praesent tempor sodales volutpat. Ut consectetur, orci nec fermentum rutrum, odio orci convallis ipsum, vel ultricies nisl nisi et orci.",
            "Aliquam turpis lectus, fermentum et eros ut, accumsan dictum mauris.",
            "Suspendisse ut lectus eu diam dignissim elementum ut sed purus. Integer lacinia fringilla metus ac maximus.",
            "Nullam nec libero maximus, rhoncus mi eget, convallis tellus. Morbi cursus tellus ligula, ac sollicitudin risus semper sit amet.",
            "Suspendisse commodo, lorem ac dictum gravida, mauris sem aliquam nunc, eu imperdiet augue lorem sit amet nibh.",
            "Donec hendrerit leo et fringilla condimentum. Nullam ultricies faucibus iaculis.",
            "Proin aliquam turpis erat, ac luctus elit aliquet at. Nullam porta, erat vel egestas feugiat, nisi metus hendrerit enim, non bibendum odio enim eu lacus.",
            "Aenean fringilla euismod est, a fringilla tellus luctus at. Maecenas suscipit libero ornare blandit lobortis.",
            "Suspendisse ultricies sagittis lorem, a rutrum massa pharetra in.",
            "Vivamus tincidunt ante mauris, non semper nisl consectetur et. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.",
            "Donec vitae augue id felis bibendum aliquam. Donec blandit magna vitae nunc sollicitudin hendrerit.",
            "Morbi consectetur consequat pellentesque. Proin et erat in risus rutrum euismod.",
            "Fusce et nisi euismod, aliquam lorem sit amet, ornare orci. Sed diam augue, porta efficitur sollicitudin a, placerat aliquet quam.",
            "Aliquam nec leo sed magna condimentum tempus quis eget sem. Sed cursus dolor felis, a consequat massa pretium et.",
            "Vestibulum id ante sem.",
            "In auctor, lorem quis iaculis dictum, enim mi pharetra mi, non porttitor risus metus ut risus.",
            "Praesent sed ex quis metus malesuada egestas. Donec sit amet purus pellentesque lectus maximus hendrerit eu nec ante.",
            "Morbi tempor risus vel enim porttitor, a tempor quam rhoncus. Duis pharetra iaculis sem, quis elementum ipsum bibendum a.",
            "Cras volutpat efficitur ipsum vitae pharetra. Nunc eget tortor commodo, hendrerit nisi ac, congue felis.",
            "Nunc ut venenatis dui. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nunc a consequat magna.",
            "Phasellus nec lacus elit. Phasellus eget aliquam justo. Proin vel laoreet augue.",
            "Aliquam erat volutpat. Donec a nibh feugiat, efficitur augue ut, consectetur nisl.",
            "Phasellus fermentum nibh metus, ut cursus turpis consequat ac. Vestibulum at iaculis diam.",
            "Integer eget turpis euismod, hendrerit libero quis, sodales erat.",
            "Morbi faucibus purus eu enim feugiat blandit.",
            "In vel dui turpis. Proin fermentum rutrum dapibus.",
            "Phasellus velit eros, molestie eu tempor quis, mattis ac nisi.",
            "Maecenas a orci vulputate, molestie lorem sed, hendrerit mi. Aliquam sed lacus tincidunt, malesuada sem a, semper tortor.",
            "Aliquam id risus sit amet dui tempus tincidunt sed eget massa. Ut non sem massa.",
            "Nunc auctor nunc efficitur mattis fringilla. Suspendisse a nisi sed nisi porttitor suscipit et ac massa.",
            "Donec porttitor augue interdum augue vehicula, id aliquam nibh tempor.",
            "Praesent non sollicitudin sem, sed tincidunt eros. Quisque sed maximus metus.",
            "Phasellus quis ex ultricies, vestibulum quam in, finibus lorem. Duis hendrerit porta lobortis.",
            "Aenean laoreet porttitor neque ut luctus. In viverra interdum risus, quis volutpat nibh auctor sed.",
            "Praesent et interdum felis. Suspendisse sit amet dui quis libero pretium dignissim quis et mi.",
            "Etiam sed tincidunt sapien, ac mollis purus. Sed ac sodales nisi, vitae molestie urna.",
            "Maecenas eget nisl a lectus tristique porttitor at quis diam. Vestibulum aliquam convallis arcu eget convallis.",
            "Donec eros mauris, ornare a tortor a, tempus maximus risus. Integer fermentum consequat sapien, ut facilisis lacus posuere vitae.",
            "Donec ante eros, semper nec tempus sit amet, iaculis blandit sem.",
            "Nullam vel massa vel ligula gravida molestie. Phasellus ac erat malesuada, varius ipsum vel, pulvinar dui.",
            "Nunc sagittis lacus sed leo gravida gravida. Mauris pellentesque tellus est, in ultrices mauris pulvinar vel.",
            "Etiam luctus odio eu aliquam posuere. Aliquam ut velit vitae velit interdum interdum.",
            "Vivamus euismod laoreet urna gravida dictum. Praesent accumsan pellentesque est, a pellentesque ante placerat vel.",
            "Nunc sagittis tincidunt mauris, eget molestie orci pellentesque eget.",
            "Maecenas volutpat consequat sem, et commodo erat vulputate eget.",
            "In a lectus in sapien vehicula ullamcorper in vitae tortor. Aliquam venenatis placerat finibus.",
            "Proin pulvinar elit a lorem congue rhoncus. Integer hendrerit, mi et lacinia sagittis, erat nisi dignissim nisi, a elementum quam augue sit amet leo.",
            "Sed eu ullamcorper leo. Sed a felis mollis, lacinia sapien at, suscipit ipsum.",
            "Suspendisse rhoncus orci ut urna laoreet, quis ultricies justo fermentum.",
            "Donec ultrices velit quis nulla aliquet condimentum. Etiam a ultrices felis.",
            "Nam lorem nisl, varius eu fermentum a, molestie vel turpis. Pellentesque vel ex non arcu volutpat laoreet quis non est.",
            "Proin non massa nec felis fringilla tristique at et mauris. Integer ut porta metus, at finibus sem.",
            "Cras pretium viverra ex eu molestie. Vestibulum malesuada felis vitae rhoncus tempus.",
            "Suspendisse at odio non purus scelerisque lobortis. Suspendisse eget tortor neque.",
            "Vestibulum volutpat felis ac lorem tristique eleifend. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
            "Phasellus imperdiet nibh eu odio suscipit, eget vestibulum ligula condimentum.",
            "Sed volutpat ac metus vel sagittis. Etiam condimentum facilisis mi a imperdiet.",
            "Aliquam tempus justo in dictum aliquet. Nulla bibendum tempus est ac vehicula.",
            "Donec eget tincidunt massa. Donec nulla erat, venenatis nec magna non, tempus efficitur augue.",
            "Vestibulum posuere arcu et metus molestie tincidunt. Nulla metus nisi, vehicula nec posuere ac, posuere ac purus.",
            "Duis quam tellus, viverra semper nisl ut, varius bibendum sem. Sed eu pulvinar sapien.",
            "Sed euismod, nisi eget venenatis malesuada, odio tortor laoreet elit, nec rhoncus tortor purus vel arcu.",
            "Duis rutrum tellus ligula, imperdiet maximus metus gravida a. Nunc commodo velit at diam imperdiet sodales.",
            "In ex felis, aliquam ac rutrum eget, tempus vel eros. Pellentesque gravida vehicula posuere.",
            "In rutrum, lorem a gravida lobortis, felis risus suscipit nibh, faucibus rhoncus dolor ligula vitae arcu.",
            "Donec mollis eros in dui semper, eget ultrices ipsum vulputate. Ut id cursus ex.",
            "Pellentesque in ante id odio maximus volutpat. Sed diam dolor, maximus ac aliquam vel, lobortis cursus massa.",
            "Etiam quis nisl at nulla sagittis sagittis sed et quam. Aenean pharetra nisl sed elit tempus, id dapibus felis viverra.",
            "Aliquam ante lorem, consectetur at magna sed, facilisis pretium tellus.",
            "Cras a egestas tortor. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
            "Nulla vulputate enim eu libero eleifend posuere. Cras laoreet ut ex at condimentum.",
            "Vivamus eget mauris tincidunt diam bibendum suscipit. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.",
            "Mauris interdum sapien id purus gravida, non malesuada dolor blandit.",
            "Sed fringilla maximus varius. Morbi finibus accumsan elit, ac molestie elit bibendum ac.",
            "Donec euismod bibendum tellus id volutpat. Duis nec tellus augue.",
            "Integer consectetur ut quam eget interdum. Quisque et urna vel nisl volutpat gravida sit amet at nulla.",
            "Aliquam iaculis viverra turpis, nec finibus nulla convallis quis.",
            "Vivamus pretium, sapien ac molestie condimentum, mi arcu vehicula nunc, id varius eros sem quis ante.",
            "Curabitur vehicula nisl odio, eu congue erat venenatis et. Etiam at rhoncus sapien.",
            "Donec luctus ante quam. Aliquam consectetur urna vitae hendrerit efficitur.",
            "Maecenas non neque interdum, semper nulla ac, ultricies nunc. Vivamus mattis dolor egestas augue gravida, et mattis lectus consequat.",
            "Vivamus sed auctor nulla. Nulla aliquet fermentum enim vitae hendrerit.",
            "Suspendisse ipsum odio, accumsan at fringilla non, semper quis dolor.",
            "In non mollis libero, pretium suscipit ex. Duis sed purus leo. In non mauris magna.",
            "Fusce leo sapien, maximus ut finibus eget, facilisis nec erat. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.",
            "Suspendisse cursus venenatis nisi. Fusce interdum lacinia porttitor.",
            "Aliquam elementum lobortis ex ut luctus. Curabitur gravida nisi justo, non ullamcorper nibh tempor sit amet.",
            "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
            "Cras a rhoncus ipsum.",
            "Vivamus eget mi est. Fusce fermentum vehicula magna at feugiat.",
            "Proin porta ullamcorper ipsum laoreet blandit. Morbi posuere, est a posuere viverra, tellus tellus consequat nulla, quis eleifend mauris est nec arcu.",
            "Morbi id massa nec nisl eleifend rhoncus aliquet et tellus. Donec sit amet luctus diam.",
            "Donec quis nibh et massa mattis convallis sed at nibh. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
            "Nunc ut massa et tortor lobortis sodales. Fusce elementum sapien at purus aliquam, vitae lobortis lacus condimentum.",
            "Sed non molestie ante.",
            "Pellentesque venenatis magna eu mauris tempor viverra.",
            "Ut venenatis magna mattis, tristique quam quis, aliquet ante. Curabitur aliquam sed nibh facilisis imperdiet.",
            "Vivamus sed ante dignissim, scelerisque arcu vel, finibus ipsum.",
            "In tempor sagittis augue vel lacinia. Aliquam imperdiet ipsum quis turpis sodales, ut iaculis ligula convallis.",
            "Nam tempor porta mi mattis viverra. Cras convallis aliquet diam eget euismod.",
            "Curabitur id lacinia magna, eget euismod tortor. Aenean rhoncus metus at nisl posuere ullamcorper.",
            "Donec rutrum nisi at enim pharetra lobortis vel at elit. Nullam eu nisi semper ipsum commodo convallis quis eu ante.",
            "Nunc sapien elit, interdum vitae urna et, aliquam luctus diam. Mauris rutrum vitae lorem quis rutrum.",
            "Interdum et malesuada fames ac ante ipsum primis in faucibus.",
            "Aliquam auctor magna eget dui commodo, ac cursus lectus feugiat.",
            "Morbi finibus consequat nibh eget placerat. Pellentesque sagittis sit amet turpis eget congue.",
            "Integer varius consequat efficitur. Sed gravida vestibulum ultricies.",
            "Duis facilisis, massa in aliquet elementum, ante tortor facilisis arcu, ut gravida augue metus sed nisl.",
            "Mauris et urna id lacus interdum congue. Pellentesque et viverra leo.",
            "Proin tempus semper laoreet. Cras lacinia lectus non metus rhoncus, sed fringilla justo tincidunt.",
            "Maecenas quis sapien sit amet augue facilisis sollicitudin. Suspendisse potenti.",
            "Aliquam at ex vitae est lobortis vestibulum vel sed ante. In condimentum est quis congue ornare.",
            "Nam ut ultricies justo. Pellentesque imperdiet blandit sodales. Suspendisse quis lacinia leo.",
            "Suspendisse commodo, nisl sed euismod congue, orci purus elementum urna, at commodo diam sem ac ante.",
            "Nullam gravida enim non nibh varius, sed vestibulum elit gravida.",
            "Praesent pretium urna tortor, vel sagittis mauris volutpat sit amet.",
            "Maecenas magna diam, suscipit ac blandit et, vulputate vel augue.",
            "Nullam nunc odio, aliquam vitae enim eget, posuere suscipit eros.",
            "Vivamus quis maximus diam, a facilisis dui. Pellentesque eu nisl blandit, gravida tellus vitae, mollis dolor.",
            "Sed vel mollis nisl. Sed sollicitudin orci urna. Sed consequat, dolor a eleifend euismod, est diam fringilla ex, ac dictum magna dui id sapien.",
            "In dapibus elit ipsum, non sollicitudin metus rutrum efficitur. Phasellus tincidunt, velit nec tincidunt mattis, felis odio dictum ante, eget facilisis leo erat vel est.",
            "Praesent luctus eleifend nulla. Vestibulum nibh eros, feugiat id pulvinar ut, tristique ut purus.",
            "Nam vel gravida sem. Suspendisse consequat augue urna, sed tempus massa suscipit vitae.",
            "Pellentesque efficitur, ipsum at bibendum cursus, arcu tortor pellentesque est, id eleifend lorem augue vel mauris.",
            "Sed in tincidunt purus. Sed commodo pharetra libero, nec rhoncus turpis mollis vel.",
            "Fusce sed massa malesuada dolor convallis eleifend vel ac nisi. Morbi bibendum nisi sed turpis porta, eget condimentum massa tristique.",
            "Mauris dictum dui sit amet felis pulvinar, sit amet ornare velit pretium.",
            "Quisque ac ante eros. Pellentesque dapibus vestibulum eros, nec pharetra neque vulputate gravida.",
            "Ut vitae augue scelerisque orci lacinia bibendum sed vitae augue.",
            "Mauris placerat bibendum dui, id varius sapien viverra a. Sed lectus odio, placerat et blandit mattis, viverra sit amet metus.",
                };
        public static string GetText(int rowIndex, int seed = 42) {
            if(rowIndex <= CommonEntriesCount) {
                if(rowIndex == 0)
                    return Explanation;
                else
                    return StaticGenerated[rowIndex - 1];
            } else {
                return StaticGenerated[(HashCodeHelper.Combine(seed, rowIndex) & int.MaxValue) % StaticGenerated.Length];
            }
        }
        static string[] _Words;
        public static string[] Words {
            get {
                if(_Words == null) {
                    _Words = StaticGenerated.SelectMany(s => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(s).Split(' ', '\t', '.', ',', ';', '!', '?', '&')).Where(s => s.Length > 1).Distinct().ToArray();
                }
                return _Words;
            }
        }
        public static string GetWord(int rowIndex, int seed = -42) {
            var localWords = Words;
            return localWords[(HashCodeHelper.Combine(seed, rowIndex) & int.MaxValue) % localWords.Length];
        }
    }
}

