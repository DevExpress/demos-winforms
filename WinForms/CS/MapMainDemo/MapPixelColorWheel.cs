using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ColorWheel;

namespace DevExpress.XtraMap.Demos {
    public class ColorPickerForm : XtraForm {
        private readonly System.ComponentModel.IContainer components = null;
        PixelMapColorWheelControl colorWheel1;
        SimpleButton buttonOk;
        SimpleButton buttonCancel;

        public event ColorChangedEventHandler ColorChanged;

        public ColorWheelControl ColorWheel { get { return colorWheel1; } }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        public ColorPickerForm(int pointDensity) {
            InitializeComponent();
            colorWheel1.Prepare(pointDensity);
        }

        void InitializeComponent() {
            buttonOk = new DevExpress.XtraEditors.SimpleButton();
            buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            colorWheel1 = new DevExpress.XtraMap.Demos.PixelMapColorWheelControl();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new System.Drawing.Point(40, 235);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new System.Drawing.Size(60, 20);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "OK";
            buttonOk.Click += new System.EventHandler(ButtonOk_Click);
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(140, 235);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(60, 20);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.Click += new System.EventHandler(ButtonCancel_Click);
            // 
            // colorWheel1
            // 
            colorWheel1.BackColor = System.Drawing.Color.Transparent;
            colorWheel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            colorWheel1.Color = System.Drawing.Color.FromArgb(255, 255, 255);
            colorWheel1.Location = new System.Drawing.Point(20, 20);
            colorWheel1.Name = "colorWheel1";
            colorWheel1.Size = new System.Drawing.Size(195, 195);
            colorWheel1.TabIndex = 0;
            colorWheel1.Text = "button1";
            colorWheel1.ColorChanged += new System.EventHandler(OnColorChanged);
            // 
            // ColorWheelForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(240, 270);
            Controls.Add(colorWheel1);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "ColorWheelForm";
            Text = "Pixel Map Color Wheel";
            ResumeLayout(false);

        }

        private void ButtonCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void ButtonOk_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }
        void OnColorChanged(object sender, EventArgs e) {
            if(ColorChanged != null)
                ColorChanged(this, new ColorChangedEventArgs(colorWheel1.Color));
        }

        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public delegate void ColorChangedEventHandler(object sender, ColorChangedEventArgs args);
        public class ColorChangedEventArgs : EventArgs {
            readonly Color color;

            public Color Color { get { return color; } }

            public ColorChangedEventArgs(Color color) {
                this.color = color;
            }
        }
    }
    public class PixelMapColorWheelControl : ColorWheelControl {
        const double intervalKoef = 2.3;
        bool supressRaiseColorChanged;
        Timer timer;

        readonly EventHandler _colorChanged = null;
        public new event EventHandler ColorChanged {
            add { Events.AddHandler(_colorChanged, value); }
            remove { Events.RemoveHandler(_colorChanged, value); }
        }

        void Timer_Tick(object sender, EventArgs e) {
            supressRaiseColorChanged = false;
        }

        protected override void OnMouseMove(MouseEventArgs e) {
            base.OnMouseMove(e);
            supressRaiseColorChanged = true;
        }
        protected override void OnMouseDown(MouseEventArgs e) {
            timer.Start();
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e) {
            supressRaiseColorChanged = false;
            timer.Stop();
            base.OnMouseUp(e);
        }
        protected override void RaiseOnColorChanged() {
            if(!supressRaiseColorChanged) {
                EventHandler handler = Events[_colorChanged] as EventHandler;
                if(handler != null) {
                    handler(this, EventArgs.Empty);
                }
            }
        }

        public void Prepare(int pointsDensity) {
            timer = new Timer() { Interval = (int)(pointsDensity * intervalKoef) };
            timer.Tick += Timer_Tick;
        }
    }
}
