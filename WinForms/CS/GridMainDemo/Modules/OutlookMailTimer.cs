using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Alerter;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Demos.Properties;
using DevExpress.Utils.Svg;
using DevExpress.Skins;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    public class MailTimer {
        IList<Message> list;
        AlertControl control;
        Form form;
        int delay = 30000;
        Timer timer;
        readonly Data.Utils.NonCryptographicRandom rnd;
        public MailTimer(IList<Message> list, AlertControl control, Form form) {
            this.list = list;
            this.control = control;
            this.form = form;
            timer = new Timer();
            timer.Interval = 10000;
            if(MainFormHelper.TakeScreens)
                rnd = new Data.Utils.NonCryptographicRandom(1);
            else {
                timer.Tick += new EventHandler(timer_Tick);
                rnd = Data.Utils.NonCryptographicRandom.Default;
            }
        }

        SvgBitmap svgMailWithAttach = new SvgBitmap(Resources.MailWithAttach);
        SvgBitmap svgMail = new SvgBitmap(Resources.Mail);
        Image GetMailImage(int data, ISkinProvider skinProvider) {
            if(0.Equals(data)) return svgMail.Render(SvgPaletteHelper.GetElementSvgPalette(skinProvider, "Normal" ,SkinProductId.Bars, BarSkins.SkinAlertWindow));
            return svgMailWithAttach.Render(SvgPaletteHelper.GetElementSvgPalette(skinProvider, "Normal", SkinProductId.Bars, BarSkins.SkinAlertWindow));
        }
        void timer_Tick(object sender, EventArgs e) {
            Timer timer = sender as Timer;
            if(list.Count > 0) {
                Message message = list[rnd.Next(list.Count - 1)];
                ShowAlert(message);
            }
            if(timer.Interval < delay) timer.Interval = delay;
        }

        public void ShowAlert(Message message) {
            InitButtonsStyle(message);
            control.Show(form, message.From, message.Subject, null, GetMailImage(message.Attachment, control.LookAndFeel), message);
        }

        void InitButtonsStyle(Message message) {
            control.Buttons["Read"].Down = 1.Equals(message.Read);
            control.Buttons["Attachment"].Visible = 1.Equals(message.Attachment);
        }

        internal void Start() {
            timer.Start();
        }

        internal void Stop() {
            timer.Stop();
        }
    }
}
