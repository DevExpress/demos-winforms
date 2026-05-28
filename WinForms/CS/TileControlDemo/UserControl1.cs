using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.TileControlDemo.Properties;

namespace DevExpress.XtraBars.Demos.TileControlDemo {
    public partial class UserControl1 : UserControl {
        public UserControl1() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            SetBackground();
            InitTileItems();
        }
        void InitTileItems() {
            itemCalendar.Elements[0].Text = DateTime.Now.Day.ToString();
            itemCalendar.Elements[1].Text = DateTime.Now.DayOfWeek.ToString();
            Image deskThumbnail = GetDesktopThumbnail();
            if(deskThumbnail != null)
                itemDesktop.Image = deskThumbnail;
        }
        string UserProfileThemesPath {
            get { return Environment.GetEnvironmentVariable("USERPROFILE") + "\\AppData\\Roaming\\Microsoft\\Windows\\Themes\\"; }
        }
        Image GetDesktopThumbnail() {
            try {
                string[] files = Directory.GetFiles(UserProfileThemesPath, "TranscodedWallpaper*");
                if(files.Length != 0)
                    return Image.FromFile(files[0]);
            }
            catch {
                return null;
            }
            return null;
        }
        void SetBackground() {
            tileControl1.BackgroundImage = TileControlBackgroundImage;
        }
        void OnTileControlKeyUp(object sender, KeyEventArgs e) {
            if(e.KeyData == Keys.Escape)
                Application.Exit();
        }
        Image tileControlBackground = null;
        Image TileControlBackgroundImage {
            get {
                if(tileControlBackground == null)
                    tileControlBackground = CreateBackgroundImage();
                return tileControlBackground;
            }
        }
        Image CreateBackgroundImage() {
            Rectangle screenBounds = Screen.FromControl(this).Bounds;
            Image bottomImg = GetBottomImage();
            Bitmap img = new Bitmap(screenBounds.Width, screenBounds.Height);
            using(Graphics graphics = Graphics.FromImage(img)) {
                using(SolidBrush br = new SolidBrush(Color.FromArgb(36, 0, 64))) {
                    graphics.FillRectangle(br, new Rectangle(Point.Empty, img.Size));
                }
                graphics.DrawImage(bottomImg, 0, screenBounds.Bottom - bottomImg.Height);
            }
            return img;
        }
        Image GetBottomImage() { return Resources.Background; }

        public event EventHandler OnDesktopClick;

        private void itemDesktop_ItemClick(object sender, TileItemEventArgs e) {
            OnDesktopClick.Invoke(this, new EventArgs());
        }
    }
}
