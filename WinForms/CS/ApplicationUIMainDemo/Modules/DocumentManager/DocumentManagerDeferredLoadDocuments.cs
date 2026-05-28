using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;

namespace DevExpress.ApplicationUI.Demos {
    public partial class DocumentManagerDeferredLoadDocuments : TutorialControlBase {
        public DocumentManagerDeferredLoadDocuments() {
            InitializeComponent();
            tabbedView.QueryControl += tabbedView_QueryControl;
        }
        int i = 0;
        void tabbedView_QueryControl(object sender, QueryControlEventArgs e) {
            Panel child = new Panel();
            child.Padding = new Padding(16);
            LabelControl label = new LabelControl();
            label.Text = GetText(i);
            label.AutoSizeMode = LabelAutoSizeMode.Vertical;
            child.Controls.Add(label);
            label.Dock = DockStyle.Fill;
            e.Control = child;
            i++;
        }
        string GetText(int i) {
            System.Threading.Thread.Sleep(1000);
            return string.Format("{0} {1}", texts[i % texts.Length], texts[(i + 2) % texts.Length]);
        }
        string[] texts = new string[]{ 
            "Vestibulum sem nunc, cursus sit amet placerat id, scelerisque at tortor. Nullam sit amet felis eros, ac imperdiet quam. Aliquam eu ipsum dui.",
            "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur sit amet sapien metus, eget pharetra velit.",
            "Duis sagittis iaculis nisl, sit amet ultricies lectus porttitor nec. Suspendisse id venenatis sem. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.",
            "Aliquam erat volutpat. Ut sit amet purus. Nullam a lectus. Duis in elit. Ut nonummy est pellentesque eros. Sed ultrices convallis nulla. Phasellus urna lorem, mattis a, luctus congue, dictum in, nunc."
        };
    }
}
