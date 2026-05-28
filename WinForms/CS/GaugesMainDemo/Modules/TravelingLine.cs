using System;

namespace DevExpress.XtraGauges.Demos {
    public partial class TravelingLine : TutorialControl {
        static char[] specChars = new char[] { '.', '\'', ',' };
        int visibleSymbolsCount = 0;
        int substringStartIndex = 0;
        string fullTextToShow = string.Empty;
        public TravelingLine() {
            InitializeComponent();
            Init();
        }
        int lockTimerCounter;
        void OnTimerTick(object sender, EventArgs e) {
            if(lockTimerCounter != 0) return;
            lockTimerCounter++;
            UpdateText();
            lockTimerCounter--;
        }
        void OnDirectionChanged(object sender, EventArgs e) {
            Init();
        }
        void OnTravelingTextChanged(object sender, EventArgs e) {
            Init();
        }
        void OnTravelingSpeedChanged(object sender, EventArgs e) {
            Init();
        }
        bool IsSpecialCharacter(char character) {
            return Array.IndexOf(specChars, character) != -1;
        }
        void Init() {
            if(digitalGauge1.DigitCount < 0)
                return;
            timer.Stop();
            timer.Interval = 500 / (travelingSpeed.Value + 1);
            timer.Start();
            fullTextToShow = new string(' ', digitalGauge1.DigitCount) + travelingText.Text + new string(' ', digitalGauge1.DigitCount);
            visibleSymbolsCount = digitalGauge1.DigitCount;
            substringStartIndex = cbDirection.SelectedIndex == 0 ? 0 : fullTextToShow.Length - visibleSymbolsCount;
        }
        void UpdateText() {
            int additionalSymbolsCount = Array.FindAll(fullTextToShow.Substring(substringStartIndex, visibleSymbolsCount).ToCharArray(), IsSpecialCharacter).Length;
            digitalGauge1.Text = fullTextToShow.Substring(substringStartIndex, visibleSymbolsCount + additionalSymbolsCount);
            substringStartIndex += cbDirection.SelectedIndex == 0 ? 1 : -1;
            if(substringStartIndex < 0)
                substringStartIndex = fullTextToShow.Length - visibleSymbolsCount;
            else if(substringStartIndex > fullTextToShow.Length - visibleSymbolsCount) {
                substringStartIndex = 0;
            }
            if(IsSpecialCharacter(fullTextToShow[substringStartIndex]))
                substringStartIndex += cbDirection.SelectedIndex == 0 ? 1 : -1;
        }
        protected override bool? AllowBorderRounding {
            get { return false; }
        }
    }
}
