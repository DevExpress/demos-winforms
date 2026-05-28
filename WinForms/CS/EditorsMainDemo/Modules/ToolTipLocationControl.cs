using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.LookAndFeel;
using DevExpress.LookAndFeel.Helpers;
using DevExpress.XtraEditors;

namespace EditorsTutorials.Modules {
	public class ToolTipLocationControl : XtraUserControl {
		private System.ComponentModel.Container components = null;
		ToolTipController fController = null;
		public event EventHandler ToolTipLocationChanged;

		public ToolTipLocationControl() {
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.TabStop = true;
		}

		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		[DefaultValue(null)]
		public ToolTipController Controller {
			get { return fController; }
			set { fController = value; 
				Info.CalcLocation();
			}
		}
        
		ToolTipLocationControlViewInfo fInfo;
		public ToolTipLocationControlViewInfo Info {
			get {
				if(fInfo == null) fInfo = new ToolTipLocationControlViewInfo(this);
				return fInfo;
			}
		}

		protected override void OnPaint(PaintEventArgs e) {
			Info.Draw(new GraphicsCache(e), LookAndFeel);
		}
		protected override void OnResize(EventArgs e) {
			base.OnResize(e);
			Info.CalcBounds();
		}
		protected override void OnMouseMove(MouseEventArgs e) {
			base.OnMouseMove(e);
			Info.CalcHotTrack(e);
		}
		protected override void OnMouseLeave(EventArgs e) {
			base.OnMouseLeave(e);
			Info.HotTrackIndex = -1;
		}
		protected override void OnMouseDown(MouseEventArgs e) {
			base.OnMouseDown(e);
			Info.CalcPressed(e);
		}
		public void RaiseToolTipLocationChanged(ToolTipLocation location) {
			if(Controller == null) return;
			Controller.ToolTipLocation = location;
			if(ToolTipLocationChanged != null)
				ToolTipLocationChanged(this, EventArgs.Empty);
		}
		public string ToolTipLocationName {
			get {
				if(Controller == null) return "<none>";
				return Controller.ToolTipLocation.ToString();
			}
		}
		public class ToolTipLocationControlViewInfo {
			ToolTipLocationControl control;
			ArrayList args = new ArrayList();
			int fHotTrackIndex = -1;
			ToolTipLocation[] locations = new ToolTipLocation[] { ToolTipLocation.TopLeft, ToolTipLocation.TopCenter, ToolTipLocation.TopRight, ToolTipLocation.LeftTop, ToolTipLocation.LeftCenter, ToolTipLocation.LeftBottom, ToolTipLocation.RightTop, ToolTipLocation.RightCenter, ToolTipLocation.RightBottom, ToolTipLocation.BottomLeft, ToolTipLocation.BottomCenter, ToolTipLocation.BottomRight};
			
			public ToolTipLocationControlViewInfo(ToolTipLocationControl control) {
				this.control = control;
				for(int i = 0; i < 12; i++) 
					args.Add(new StyleObjectInfoArgs());
				CalcBounds();
				CalcLocation();
			}

			StyleObjectInfoArgs ObjectInfoByID(int index) {
				return args[index] as StyleObjectInfoArgs;
			}

			public void Draw(GraphicsCache cache, UserLookAndFeel lookAndFeel) {
				for(int i = 0; i < args.Count; i++) {
					ObjectInfoByID(i).Cache = cache;
					lookAndFeel.Painter.Button.DrawObject(ObjectInfoByID(i));
				}
			}

			int dx = 8;
			int ElementWidht { get { return (control.Width - dx * 2) / 3; }}
			int ElementHeight { get { return control.Height / 5; }}
			public void CalcBounds() {
				for(int i = 0; i < 3; i++) {
					ObjectInfoByID(i).Bounds = new Rectangle(dx + ElementWidht * i, 0, ElementWidht, ElementHeight);
					ObjectInfoByID(3 + i).Bounds = new Rectangle(0, ElementHeight * (i + 1), ElementWidht, ElementHeight);
					ObjectInfoByID(6 + i).Bounds = new Rectangle(dx * 2 + ElementWidht * 2, ElementHeight * (i + 1), ElementWidht, ElementHeight);
					ObjectInfoByID(9 + i).Bounds = new Rectangle(dx + ElementWidht * i, ElementHeight * 4, ElementWidht, ElementHeight);
				}
				control.Refresh();
			}
			int LocationIndex {
				get {
					if(control == null || control.Controller == null) return -1;
					for(int i = 0; i < locations.Length; i++)
						if(control.Controller.ToolTipLocation.Equals(locations[i])) return i;
					return -1;
				}
			}
			public void CalcLocation() {
				int index = LocationIndex;
				for(int i = 0; i < args.Count; i++) 
					ObjectInfoByID(i).State = index == i ? ObjectState.Pressed : ObjectState.Normal; 
				if(HotTrackIndex > -1 && HotTrackIndex != index) ObjectInfoByID(HotTrackIndex).State = ObjectState.Hot;
				if(control == null || control.Controller == null)
					for(int i = 0; i < args.Count; i++) ObjectInfoByID(i).State = ObjectState.Disabled;
				control.Refresh();
			}
			public int HotTrackIndex {
				get { return fHotTrackIndex; }
				set {
					if(fHotTrackIndex == value) return;
					fHotTrackIndex = value;
					CalcLocation();
				}
			}
			int IndexByPoint(Point p) {
				for(int i = 0; i < args.Count; i++)
					if(ObjectInfoByID(i).Bounds.Contains(p)) return i;
				return -1;
			}
			public void CalcHotTrack(MouseEventArgs e) {
				Point p = new Point(e.X, e.Y);
				HotTrackIndex = IndexByPoint(p);
			}
			public void CalcPressed(MouseEventArgs e) {
				Point p = new Point(e.X, e.Y);
				int i = IndexByPoint(p);
				if(i > -1) {
					control.RaiseToolTipLocationChanged(locations[i]);
					CalcLocation();
				}
			}
		}

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // ToolTipLocationControl
            // 
            this.Name = "ToolTipLocationControl";
            this.ResumeLayout(false);

        }
    }
}
