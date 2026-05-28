using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using System.IO;

namespace DevExpress.Xpo.Demos {
    internal class XConsole : XtraScrollableControl {
        public XConsole() {
            this.Appearance.Options.UseBackColor = true;
            this.Enabled = true;
        }
        public new bool Enabled {
            get {
                return base.Enabled;
            }
            set {
                base.Enabled = value;
                if(base.Enabled)
                    this.Appearance.BackColor = Color.White;
                else
                    this.Appearance.BackColor = Color.Gray;
            }
        }
    }
    public class XtraConsole : XtraUserControl {
        private PaintWindow paintWin;
        private XConsole xtraScrollableControl1;

        public XtraConsole() {
            InitializeComponent();
            this.paintWin.Console = this;
            lines.Add(string.Empty);
            this.Appearance.ForeColor = Color.Black;
        }

        private void InitializeComponent() {
            this.xtraScrollableControl1 = new XConsole();
            this.paintWin = new PaintWindow();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 

            this.xtraScrollableControl1.Controls.Add(this.paintWin);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(438, 367);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // paintWin
            // 
            this.paintWin.Location = new System.Drawing.Point(3, 3);
            this.paintWin.Name = "paintWin";
            this.paintWin.Size = new System.Drawing.Size(30, 25);
            this.paintWin.TabIndex = 0;
            // 
            // XtraConsole
            // 
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "XtraConsole";
            this.Size = new System.Drawing.Size(438, 367);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        public new bool Enabled {
            get {
                return base.Enabled;
            }
            set {
                base.Enabled = value;
                xtraScrollableControl1.Enabled = value;
                this.Refresh();
            }
        }
        List<string> lines = new List<string>();
        int CalcStringWidth(string str) {
            GraphicsInfo ginfo = new GraphicsInfo();
            ginfo.AddGraphics(null);
            SizeF textSize = new AppearanceObject(Appearance, DefaultAppearance).CalcTextSize(ginfo.Cache, str, int.MaxValue);
            ginfo.ReleaseGraphics();
            return (int)Math.Ceiling(textSize.Width);
        }
        protected internal void DoPaint(PaintEventArgs e) {
            int startLine = e.ClipRectangle.Top / this.Font.Height;
            if(startLine >= lines.Count)
                return;
            int endLine = e.ClipRectangle.Bottom / this.Font.Height + 1;
            using(GraphicsCache cache = new GraphicsCache(e)) {
                AppearanceObject ao = new AppearanceObject(Appearance, DefaultAppearance);
                for(int i = startLine; i < lines.Count && i <= endLine; ++i) {
                    ao.DrawString(cache, lines[i], new Rectangle(0, i * ao.Font.Height, paintWin.Width, ao.Font.Height));
                }
            }
        }
        string buffer = string.Empty;
        readonly object SyncRoot = new object();
        void WriteBuffer(object sender, EventArgs e) {
            if(!this.IsHandleCreated || this.IsDisposed)
                return;
            string str;
            lock(SyncRoot) {
                str = buffer;
                if(str == null || str.Length == 0)
                    return;
                buffer = string.Empty;
            }
            str = str.Replace("\r\n", "\n");
            str = str.Replace("\n\r", "\n");
            str = str.Replace('\r', '\n');
            bool nonFirst = false;
            bool linesAdded = false;
            foreach(string line in str.Split('\n')) {
                if(nonFirst) {
                    lines.Add(string.Empty);
                    linesAdded = true;
                } else {
                    nonFirst = true;
                }
                int pos = lines.Count - 1;
                string newValue = lines[pos] + line;
                lines[pos] = newValue;
                int width = CalcStringWidth(newValue);
                if(width >= paintWin.Width)
                    paintWin.Width = width + 1;
            }
            if(linesAdded) {
                this.paintWin.Height = lines.Count * this.Font.Height;
                if(AutoScrollToEnd && paintWin.Height > this.xtraScrollableControl1.ClientRectangle.Height) {
                    this.xtraScrollableControl1.AutoScrollPosition = new Point(0, 2 + paintWin.Height - this.xtraScrollableControl1.ClientRectangle.Height);
                }
            }
            this.paintWin.Invalidate();
        }
        public bool AutoScrollToEnd = true;
        class PaintWindow : Control {
            public XtraConsole Console;
            protected override void OnPaint(PaintEventArgs e) {
                if(Console != null)
                    Console.DoPaint(e);
            }
        }
        public void Write(string chunk) {
            lock(SyncRoot) {
                this.buffer += chunk;
            }
            if(this.IsHandleCreated && !this.IsDisposed) {
                this.BeginInvoke(new EventHandler(WriteBuffer), this, EventArgs.Empty);
            }
        }

        internal void ClearText() {
            //lock(SyncRoot){
            buffer = string.Empty;
            //}
            lines.Clear();
            lines.Add(string.Empty);
            paintWin.Width = 0;
            paintWin.Height = 0;
            this.Refresh();
        }
    }
    public class LogWriter : TextWriter {
        bool enabled = true;
        public XtraConsole Console;
        public LogWriter() { }
        public LogWriter(XtraConsole console)
            : this() {
            this.Console = console;
        }
        Encoding enc = new UnicodeEncoding(false, false);
        public override Encoding Encoding {
            get { return enc; }
        }
        public override void Write(string value) {
            if(Console != null && Enabled) {
                Console.Write(value);
            }
        }
        public override void Write(char ch) {
            Write(ch.ToString());
        }
        public bool Enabled {
            get { return enabled; }
            set {
                enabled = value;
                if(Console != null)
                    Console.Enabled = enabled;
            }
        }
    }
}
