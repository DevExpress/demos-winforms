using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
// <cbTransitionType>
using DevExpress.Utils.Animation;
// </cbTransitionType>
using System.Reflection;
// <cbEasingMode>
using DevExpress.Data.Utils;
// </cbEasingMode>

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleTransitionManager : TutorialControl {
        // <cbEasingFunction>
        string[] EasingFunction = new string[] { "BackEase", "ElasticEase", "PowerEase", "QuadraticEase", "SineEase", "ExponentialEase", "CircleEase", "BounceEase", "CubicEase" };
        // </cbEasingFunction>
        Timer delay;
        bool isLock;
        Dictionary<string, IEasingFunction> functions = new Dictionary<string, IEasingFunction>();
        public ModuleTransitionManager() {
            InitializeComponent();
            Init();
            InitTransitionParameters();
            InitEasyFunctions();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleTransitionManager" }; } }
        protected override string WhatsThisXMLFileName { get { return "transitionManager"; } }
        void Init() {
            // <cbEasingMode>
            cbEasingMode.Properties.Items.AddEnum(typeof(DevExpress.Data.Utils.EasingMode));
            cbEasingMode.SelectedIndex = 0;
            // </cbEasingMode>
            // <cbShowWaitIndicator>
            cbShowWaitIndicator.Properties.Items.AddEnum(typeof(DevExpress.Utils.DefaultBoolean));
            cbShowWaitIndicator.SelectedIndex = 2;
            // </cbShowWaitIndicator>
            // <cbTransitionType>
            cbTransitionType.Properties.Items.AddEnum(typeof(Transitions));
            cbTransitionType.SelectedIndex = 0;
            // </cbTransitionType>
            // <cbEasingFunction>
            cbEasingFunction.Properties.Items.AddRange(EasingFunction);
            cbEasingFunction.SelectedIndex = 0;
            // </cbEasingFunction>
            delay = new Timer();
            delay.Interval = 1000;
            delay.Tick += new EventHandler(delay_Tick);
            pictureEdit.Image = new Bitmap(pictureEdit.Width, pictureEdit.Height);
            pictureEdit.ImageChanged += new EventHandler(pictureEdit_ImageChanged);
            transitionManager.CustomTransition += new CustomTransitionEventHandler(transitionManager_CustomTransition);
        }
        // <cbEasingFunction>
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
        // </cbEasingFunction>
        void InitTransitionParameters() {
            isLock = true;
            // <checkVertical>
            checkVertical.Enabled = EnableParametrs("Vertical");
            // </checkVertical>
            // <checkInward>
            checkInward.Enabled = EnableParametrs("Inward");
            // </checkInward>
            // <checkUnCover>            
            checkUnCover.Enabled = EnableParametrs("UnCover");
            // </checkUnCover>       
            // <seStripeCount>
            seStripeCount.Enabled = EnableParametrs("StripeCount");
            // </seStripeCount>
            // <ceBackground>
            ceBackground.Enabled = EnableParametrs("Background");
            // </ceBackground>
            // <cbEffectOptions>
            cbEffectOptions.Enabled = EnableParametrs("EffectOptions");
            // </cbEffectOptions>
            ResetTransitionParameters();
            isLock = false;
        }
        void ResetTransitionParameters() {
            // <checkUnCover>            
            // <checkInward>
            // <checkVertical>
            checkVertical.Checked = checkInward.Checked = checkUnCover.Checked = false;
            // </checkUnCover>            
            // </checkInward>
            // </checkVertical>
            // <seFrameInterval>
            // <seFrameCount>
            // <seStripeCount>
            seStripeCount.Value = seFrameCount.Value = seFrameInterval.Value = 0;
            // </seFrameInterval>
            // </seFrameCount>
            // </seStripeCount>
            // <ceBackground>
            ceBackground.Color = Color.Empty;
            // </ceBackground>
            // <cbEffectOptions>
            cbEffectOptions.Properties.Items.Clear();
            PropertyInfo info = AnimationParameters.GetType().GetProperty("EffectOptions");
            if(info != null) {
                cbEffectOptions.Properties.Items.AddEnum(info.PropertyType);
                cbEffectOptions.SelectedIndex = 0;
            }
            // </cbEffectOptions>
        }
        IAnimationParameters AnimationParameters {
            get {
                if(Transition == null) return null;
                return Transition.TransitionType.Parameters;
            }
        }
        ITransition Transition { get { return transitionManager.Transitions[pictureEdit]; } }
        // <cbEasingFunction>
        void transitionManager_CustomTransition(ITransition transition, CustomTransitionEventArgs e) {
            if(transition.Control == pictureEdit)
                e.EasingFunction = functions[cbEasingFunction.Text];
        }
        // </cbEasingFunction>
        void delay_Tick(object sender, EventArgs e) {
            pictureEdit.Image = galleryControl.Gallery.GetCheckedItem().Image;
            delay.Stop();
        }
        void pictureEdit_ImageChanged(object sender, EventArgs e) {
            transitionManager.EndTransition();
        }
        private void galleryControlGallery_ItemCheckedChanged(object sender, XtraBars.Ribbon.GalleryItemEventArgs e) {
            if(!e.Item.Checked) return;
            transitionManager.StartTransition(pictureEdit);
            delay.Stop();
            delay.Interval = Transition.ShowWaitingIndicator != Utils.DefaultBoolean.False ? 1000 : 1;
            delay.Start();
        }
        // <checkUnCover>
        // <seFrameInterval>
        // <seFrameCount>
        // <cbEffectOptions>
        // <checkInward>
        // <checkVertical>
        // <seStripeCount>
        // <ceBackground>
        bool EnableParametrs(string propertyName) {
            PropertyInfo info = AnimationParameters.GetType().GetProperty(propertyName);
            return info != null;
        }
        // </ceBackground>
        // </seStripeCount>
        // </checkVertical>
        // </checkInward>
        // </cbEffectOptions>
        // </seFrameCount>
        // </seFrameInterval>
        // </checkUnCover>
        // <cbShowWaitIndicator>
        private void cbShowWaitIndicator_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(isLock) return;
            // </skip>
            Transition.ShowWaitingIndicator = (DevExpress.Utils.DefaultBoolean)cbShowWaitIndicator.SelectedIndex;
        }
        // </cbShowWaitIndicator>
        // <cbEasingMode>
        private void cbEasingMode_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(isLock) return;
            // </skip>
            Transition.EasingMode = (DevExpress.Data.Utils.EasingMode)cbEasingMode.SelectedIndex;
        }
        // </cbEasingMode>
        // <cbTransitionType>
        private void cbTransitionType_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(isLock) return;
            // </skip>
            Transition.TransitionType = CreateInstance((Transitions)cbTransitionType.SelectedIndex);
            InitTransitionParameters();
        }
        // </cbTransitionType>
        // <seFrameInterval>
        private void seFrameInterval_ValueChanged(object sender, EventArgs e) {
            TransitionParameterChange("FrameInterval", (int?)seFrameInterval.Value);
        }
        // </seFrameInterval>
        // <seFrameCount>
        private void seFrameCount_ValueChanged(object sender, EventArgs e) {
            TransitionParameterChange("FrameCount", (int?)seFrameCount.Value);
        }
        // </seFrameCount>
        // <cbEffectOptions>
        private void cbEffectOptions_SelectedIndexChanged(object sender, EventArgs e) {
            TransitionParameterChange("EffectOptions", cbEffectOptions.SelectedIndex);
        }
        // </cbEffectOptions>
        // <ceBackground>
        private void ceBackground_EditValueChanged(object sender, EventArgs e) {
            TransitionParameterChange("Background", ceBackground.Color);
        }
        // </ceBackground>
        // <seStripeCount>
        private void seStripeCount_ValueChanged(object sender, EventArgs e) {
            TransitionParameterChange("StripeCount", (int)seStripeCount.Value);
        }
        // </seStripeCount>
        // <checkVertical>
        private void checkVertical_CheckedChanged(object sender, EventArgs e) {
            TransitionParameterChange("Vertical", checkVertical.Checked);
        }
        // </checkVertical>
        // <checkInward>
        private void checkInward_CheckedChanged(object sender, EventArgs e) {
            TransitionParameterChange("Inward", checkInward.Checked);
        }
        // </checkInward>
        // <checkUnCover>
        private void checkUnCover_CheckedChanged(object sender, EventArgs e) {
            TransitionParameterChange("UnCover", checkUnCover.Checked);
        }
        // <seFrameInterval>
        // <seFrameCount>
        // <cbEffectOptions>
        // <checkInward>
        // <checkVertical>
        // <seStripeCount>
        // <ceBackground>
        void TransitionParameterChange(string paramName, object value) {
            SetTransitionParameter(AnimationParameters, paramName, value);
        }
        void SetTransitionParameter(IAnimationParameters parameters, string propertyName, object value) {
            // <skip>
            if(isLock || parameters == null) return;
            // </skip>
            PropertyInfo info = parameters.GetType().GetProperty(propertyName);
            if(info == null) return;
            info.SetValue(parameters, value, null);
        }
        // </ceBackground>
        // </seStripeCount>
        // </checkVertical>
        // </checkInward>
        // </cbEffectOptions>
        // </seFrameCount>
        // </seFrameInterval>
        // </checkUnCover>
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
    }
}
