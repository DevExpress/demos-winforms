// Assembly {TutorialsAssembly}
namespace DevExpress.DXperience.Demos.CodeDemo.Data {
    using DevExpress.Dialogs.Core.Items;
    using DevExpress.Utils.Svg;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Base.Controls.Preview;
    using DevExpress.XtraEditors.Controls;
    using System.Windows.Forms;

    public class SvgPreviewHandler : WinPreviewHandlerBase {
        SvgImage svgImage;

        public override bool Load(string file, ShellItem shellItem) {
            base.Load(file, shellItem);
            bool loaded = false;
            if(shellItem.Extension.ToLower() == ".svg") {
                try {
                    this.svgImage = SvgImage.FromFile(file);
                    loaded = true;
                }
                catch { }
            }
            return loaded;
        }
        public override Control CreatePreviewControl() {
            var picEdit = new PictureEdit();
            picEdit.SvgImage = svgImage;
            picEdit.Enabled = false;
            picEdit.BorderStyle = BorderStyles.NoBorder;
            picEdit.Properties.SizeMode = PictureSizeMode.Squeeze;
            picEdit.Properties.UseDisabledStatePainter = false;
            return picEdit;
        }
    }
}
