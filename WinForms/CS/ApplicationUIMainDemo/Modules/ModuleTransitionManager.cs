using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using DevExpress.Data.Utils;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Animation;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.ApplicationUI.Demos {
    public partial class ModuleTransitionManager : TutorialControl {
        string[] EasingFunction = new string[] { 
            "BackEase", 
            "ElasticEase", 
            "PowerEase", 
            "QuadraticEase", 
            "SineEase", 
            "ExponentialEase", 
            "CircleEase", 
            "BounceEase", 
            "CubicEase" 
        };
        string[] Images = new string[]{
            "TransitionManagerData\\(Athens)-Academy-of-Athens.jpg",
            "TransitionManagerData\\(Barcelona)-Camp-Nou.jpg",
            "TransitionManagerData\\(Berlin)-Brandenburg-Gate.jpg",
            "TransitionManagerData\\(Cairo)-Cairo-Citadel.jpg",
            "TransitionManagerData\\(Los-Angeles)-Downtown.jpg",
            "TransitionManagerData\\(London)-St-Paul's-Cathedral.jpg",
            "TransitionManagerData\\(Los-Angeles)-Downtown.jpg",
            "TransitionManagerData\\(Moscow)-Bolshoi-Theatre.jpg",
            "TransitionManagerData\\(New-York)-Brooklyn-Bridge.jpg",
            "TransitionManagerData\\(Paris)-Arc-de-Triomphe.jpg"
        };
        Timer switchTimer;
        Timer delayTimer;
        bool Locked;
        bool isTransition;
        Dictionary<string, IEasingFunction> functions = new Dictionary<string, IEasingFunction>();
        public ModuleTransitionManager() {
            InitializeComponent();
            Init();
            isTransition = false;
            switchTimer = new Timer();
            delayTimer = new Timer();
            switchTimer.Interval = 1000;
            delayTimer.Interval = 1000;
            switchTimer.Tick += OnSwitchTimerTick;
            delayTimer.Tick += OnDelayTimerTick;
            pictureEdit.PopupMenuShowing += OnPopupMenuShowing;
            transitionManager.AfterTransitionEnds += transitionManager_AfterTransitionEnds;
            InitImages();
            InitEasyFunctions();
            pictureEdit.Image = galleryControl1.Gallery.GetAllItems()[0].Image;
            galleryControl1.Gallery.ItemCheckedChanged += galleryControl1_Gallery_ItemCheckedChanged;
            switchTimer.Start();
        }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            var form = FindForm();
            if(form != null){
                form.Deactivate += OnDeactivate;
                form.Activated += OnActivated;
            }
        }
        protected override void OnHandleDestroyed(EventArgs e) {
            base.OnHandleDestroyed(e);
            var form = FindForm();
            if(form != null) {
                form.Deactivate -= OnDeactivate;
                form.Activated -= OnActivated;
            }
        }
        bool isDeactivated = false;
        void OnDeactivate(object sender, EventArgs e) {
            if(!isDeactivated)
                switchTimer.Stop();
            isDeactivated = true;
        }
        void OnActivated(object sender, EventArgs e) {
            if(isDeactivated && Visible)
                switchTimer.Start();
            isDeactivated = false;
        }
        void OnPopupMenuShowing(object sender, XtraEditors.Events.PopupMenuShowingEventArgs e) { 
            e.Cancel = true; 
        }
        void InitImages() {
            var galleryGroup = galleryControl1.Gallery.Groups[0];
            for(int count = 0; count < Images.Count(); count++) {
                string path = DataLoader.GetRelativePath(Images[count]);
                Image image = null;
                if(!string.IsNullOrEmpty(path)) {
                    image = Image.FromFile(path);
                    NormalizeImageAlpha((Bitmap)image);
                }
                galleryGroup.Items.Add(new GalleryItem(image, string.Empty, string.Empty));
            }
            galleryGroup.Items[0].Checked = true;
        }
        [SecuritySafeCritical]
        static void NormalizeImageAlpha(Bitmap bitmap) {
            var rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb);
            try {
                NormalizeBitmapDataAlpha(rect, bmpData);
            } finally { bitmap.UnlockBits(bmpData); }
        }

        static void NormalizeBitmapDataAlpha(Rectangle rect, BitmapData bmpData) {
            int offset = 0;
            int length = rect.Width * rect.Height;
            int intSize = 4;// sizeof(int);
            for(int i = 0; i < length; i++) {
                NormalizeAlpha(bmpData, offset);
                offset += intSize;
            }
        }

        [SecuritySafeCritical]
        static void NormalizeAlpha(BitmapData bmpData, int offset) {
            int argb = System.Runtime.InteropServices.Marshal.ReadInt32(bmpData.Scan0, offset);
            Color color = Color.FromArgb(argb);
            if(color.A < 255) {
                color = Color.FromArgb(255, color);
                System.Runtime.InteropServices.Marshal.WriteInt32(bmpData.Scan0, offset, color.ToArgb());
            }
        }
        void transitionManager_AfterTransitionEnds(ITransition transition, EventArgs e) {
            isTransition = false;
        }
        void OnDelayTimerTick(object sender, EventArgs e) {
            if(DemoHelper.IsTesting) return;
            pictureEdit.Image = galleryControl1.Gallery.GetCheckedItem().Image;
            delayTimer.Stop();
            if(isTransition) {
                transitionManager.EndTransition();
            }
            if(Visible && !isDeactivated && !customIndicatorActive)
                switchTimer.Start();
        }
        void Init() {
            cbEasingMode.Properties.Items.AddEnum(typeof(DevExpress.Data.Utils.EasingMode));
            cbEasingMode.SelectedIndex = 0;
            cbShowWaitIndicator.Properties.Items.AddEnum(typeof(DevExpress.Utils.DefaultBoolean));
            cbShowWaitIndicator.SelectedIndex = 2;
            cbTransitionType.Properties.Items.AddEnum(typeof(Transitions));
            cbTransitionType.SelectedIndex = 0;
            cbEasingFunction.Properties.Items.AddRange(EasingFunction);
            cbEasingFunction.SelectedIndex = 0;
            cbWaitingIndicatorType.Properties.Items.AddEnum(typeof(WaitingAnimatorType));
            cbWaitingIndicatorType.SelectedIndex = 0;
        }
        void InitEasyFunctions() {
            functions.Add("BackEase", new BackEase());
            functions.Add("ElasticEase", new ElasticEase());
            functions.Add("PowerEase", new PowerEase(1));
            functions.Add("QuadraticEase", new QuadraticEase());
            functions.Add("QuinticEase", new QuinticEase());
            functions.Add("SineEase", new SineEase());
            functions.Add("ExponentialEase", new ExponentialEase());
            functions.Add("CircleEase", new CircleEase());
            functions.Add("BounceEase", new BounceEase());
            functions.Add("CubicEase", new CubicEase());
        }
        void transitionManager_CustomTransition(ITransition transition, CustomTransitionEventArgs e) {
            if(transition.Control == pictureEdit)
                e.EasingFunction = functions[cbEasingFunction.Text];
        }
        void OnSwitchTimerTick(object sender, EventArgs e) {
            if(DemoHelper.IsTesting) return;
            switchTimer.Interval = 4000;
            if(!isTransition) {
                List<GalleryItem> galleryItems = galleryControl1.Gallery.GetAllItems();
                int currentIndex = galleryItems.IndexOf(galleryControl1.Gallery.GetCheckedItem());
                int nextIndex = currentIndex == (galleryItems.Count - 1) ? 0 : currentIndex + 1;
                galleryControl1.Gallery.SetItemCheck(galleryItems[nextIndex], true);
            }
        }
        void galleryControl1_Gallery_ItemCheckedChanged(object sender, XtraBars.Ribbon.GalleryItemEventArgs e) {
            switchTimer.Stop();
            transitionManager.StartTransition(pictureEdit);
            isTransition = true;
            delayTimer.Start();
        }
        void InitTransitionParameters() {
            Locked = true;
            checkVertical.Enabled = EnableParametrs("Vertical");
            checkInward.Enabled = EnableParametrs("Inward");        
            checkUnCover.Enabled = EnableParametrs("UnCover");
            seStripeCount.Enabled = EnableParametrs("StripeCount");
            ceBackground.Enabled = EnableParametrs("Background");
            cbEffectOptions.Enabled = EnableParametrs("EffectOptions");
            ResetTransitionParameters();
            Locked = false;
        }
        void ResetTransitionParameters() {
            checkVertical.Checked = checkInward.Checked = checkUnCover.Checked = false;
            seStripeCount.Value = seFrameCount.Value = seFrameInterval.Value = 0;
            ceBackground.Color = Color.Empty;
            cbEffectOptions.Properties.Items.Clear();
            PropertyInfo info = AnimationParameters.GetType().GetProperty("EffectOptions");
            if(info != null) {
                cbEffectOptions.Properties.Items.AddEnum(info.PropertyType);
                cbEffectOptions.SelectedIndex = 0;
            }
        }
        bool EnableParametrs(string propertyName) {
            PropertyInfo info = AnimationParameters.GetType().GetProperty(propertyName);
            return info != null;
        }
        IAnimationParameters AnimationParameters {
            get {
                if(Transition == null) 
                    return null;
                return Transition.TransitionType.Parameters;
            }
        }
        ITransition Transition {
            get { return transitionManager.Transitions[pictureEdit]; }
        }
        void cbShowWaitIndicator_SelectedIndexChanged(object sender, EventArgs e) {
            if(Locked) 
                return;
            Transition.ShowWaitingIndicator = (DevExpress.Utils.DefaultBoolean)cbShowWaitIndicator.SelectedIndex;
            if(delayTimer != null) {
                if((DevExpress.Utils.DefaultBoolean)cbShowWaitIndicator.SelectedIndex == Utils.DefaultBoolean.False)
                    delayTimer.Interval = 1;
                else
                    delayTimer.Interval = 1000;
            }
        }
        void cbEasingMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(Locked) 
                return;
            Transition.EasingMode = (DevExpress.Data.Utils.EasingMode)cbEasingMode.SelectedIndex;
        }
        void cbTransitionType_SelectedIndexChanged(object sender, EventArgs e) {
            if(Locked) 
                return;
            Transition.TransitionType = CreateInstance((Transitions)cbTransitionType.SelectedIndex);
            InitTransitionParameters();
        }
        void seFrameInterval_ValueChanged(object sender, EventArgs e) {
            TransitionParameterChange("FrameInterval", (int?)seFrameInterval.Value);
        }
        void seFrameCount_ValueChanged(object sender, EventArgs e) {
            TransitionParameterChange("FrameCount", (int?)seFrameCount.Value);
        }
        void cbEffectOptions_SelectedIndexChanged(object sender, EventArgs e) {
            TransitionParameterChange("EffectOptions", cbEffectOptions.SelectedIndex);
        }
        void ceBackground_EditValueChanged(object sender, EventArgs e) {
            TransitionParameterChange("Background", ceBackground.Color);
        }
        void seStripeCount_ValueChanged(object sender, EventArgs e) {
            TransitionParameterChange("StripeCount", (int)seStripeCount.Value);
        }
        void checkVertical_CheckedChanged(object sender, EventArgs e) {
            TransitionParameterChange("Vertical", checkVertical.Checked);
        }
        void checkInward_CheckedChanged(object sender, EventArgs e) {
            TransitionParameterChange("Inward", checkInward.Checked);
        }
        void checkUnCover_CheckedChanged(object sender, EventArgs e) {
            TransitionParameterChange("UnCover", checkUnCover.Checked);
        }
        void TransitionParameterChange(string paramName, object value) {
            SetTransitionParameter(AnimationParameters, paramName, value);
        }
        void SetTransitionParameter(IAnimationParameters parameters, string propertyName, object value) {
            if(Locked || parameters == null) 
                return;
            PropertyInfo info = parameters.GetType().GetProperty(propertyName);
            if(info == null) 
                return;
            info.SetValue(parameters, value, null);
        }
        BaseTransition CreateInstance(Transitions transition) {
            switch(transition) {
                case Transitions.Dissolve: return new DissolveTransition();
                case Transitions.Fade: return new FadeTransition();
                case Transitions.Shape: return new ShapeTransition();
                case Transitions.Clock: return new ClockTransition();
                case Transitions.SlideFade: return new SlideFadeTransition();
                case Transitions.Cover: return new CoverTransition();
                case Transitions.Comb: return new CombTransition();
                default: return new PushTransition();
            }
        }
        protected override void OnVisibleChanged(EventArgs e) {
            base.OnVisibleChanged(e);
            if(!Visible) {
                switchTimer.Stop();
                if(customIndicatorActive) {
                    StopWaitingIndicator();
                }
            }
            else switchTimer.Start();
        }
        bool customIndicatorActive = false;
        void btnCustomIndicator_Click(object sender, EventArgs e) {
            if(!customIndicatorActive) {
                switchTimer.Stop();
                if(isTransition)
                    transitionManager.EndTransition();
                StartWaitingIndicator();
            }
            else {
                switchTimer.Start();
                StopWaitingIndicator();
            }
        }
        void StopWaitingIndicator() {
            transitionManager.StopWaitingIndicator();
            galleryControl1.Enabled = true;
            customIndicatorActive = false;
            btnWaitingIndicator.Text = "Show waiting indicator";
        }
        void StartWaitingIndicator() {
            StartAnimator(cbWaitingIndicatorType.Text);
            galleryControl1.Enabled = false;
            customIndicatorActive = true;
            btnWaitingIndicator.Text = "Hide waiting indicator";
        }
        void cbCustomIndicatorType_SelectedIndexChanged(object sender, EventArgs e) {
            if(customIndicatorActive) {
                transitionManager.StopWaitingIndicator();
                StartAnimator(cbWaitingIndicatorType.Text);
            }
            Transition.WaitingAnimatorType = GetAnimatorType();
            if(Transition.WaitingAnimatorType == WaitingAnimatorType.Line)
                Transition.LineWaitingIndicatorProperties.ContentAlignment = ContentAlignment.TopCenter;
            if(Transition.WaitingAnimatorType == WaitingAnimatorType.Ring)
                Transition.RingWaitingIndicatorProperties.ContentAlignment = ContentAlignment.MiddleCenter;
        }
        WaitingAnimatorType GetAnimatorType() {
            return (WaitingAnimatorType)cbWaitingIndicatorType.EditValue;
        }
        void StartAnimator(string typeString) {
            switch((WaitingAnimatorType)cbWaitingIndicatorType.EditValue) {
                case WaitingAnimatorType.Line:
                    transitionManager.StartWaitingIndicator(pictureEdit, new LineWaitingIndicatorProperties() { ContentAlignment = ContentAlignment.TopCenter, Caption = "", Description = "" });
                    break;
                case WaitingAnimatorType.Ring:
                    transitionManager.StartWaitingIndicator(pictureEdit, new RingWaitingIndicatorProperties() { ContentAlignment = ContentAlignment.MiddleCenter, Caption = "", Description = "" });
                    break;
                default:
                    transitionManager.StartWaitingIndicator(pictureEdit, new WaitingIndicatorProperties() { Caption = "", Description = "" });
                    break;
            }
        }
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            switchTimer.Tick -= OnSwitchTimerTick;
            delayTimer.Tick -= OnDelayTimerTick;
            pictureEdit.PopupMenuShowing -= OnPopupMenuShowing;
            transitionManager.AfterTransitionEnds -= transitionManager_AfterTransitionEnds;
            base.Dispose(disposing);
        }
    }
}
