using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using DevExpress.Data.Utils;
using DevExpress.XtraMap.Demos;

namespace DevExpress.Demos.FlagsGameCore {
    public enum GameLevel { Easy = 0, Middle = 1, High = 2, VeryHigh = 3 }
    public enum AnswerStatus { Win, Lose, WrongTry, ShowCountry }

    public class CountryDataEventArgs : EventArgs {
        public Image Flag { get; set; }
        public string Name { get; set; }
    }

    public class ChoiceAnswerEventArgs : EventArgs {
        public AnswerStatus Status { get; set; }
        public double ScoreDelta { get; set; }
        public string CountryName { get; set; }
    }

    public class ScoreChangedAnswerEventArgs : EventArgs {
        public double Score { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
    }

    public class GameOverEventArgs : EventArgs {
        public string Time { get; set; }
    }

    public class FlagsGameCore : IDisposable {
        static readonly NonCryptographicRandom rand = new NonCryptographicRandom(DateTime.Now.Millisecond);
        readonly List<string> actualCountries;
        List<string> unusedCountries;
        readonly Dictionary<string, Image> countriesFlags;
        GameLevel gameLevel = GameLevel.Easy;
        DateTime startGameTime;
        DateTime finishGameTime;
        string currentCountry;
        bool isGameActive;
        int wins;
        int losses;
        double score;

        long GamingTicks { get { return isGameActive ? (DateTime.Now - startGameTime).Ticks : (finishGameTime - startGameTime).Ticks; } }
        public bool IsGameActive { get { return isGameActive; } }
        public string CurrentCountryName { get { return currentCountry; } }

        public event EventHandler<GameOverEventArgs> GameOver;
        public event EventHandler<ScoreChangedAnswerEventArgs> ScoreChanged;
        public event EventHandler<CountryDataEventArgs> CountryChanged;
        public event EventHandler<ChoiceAnswerEventArgs> ChoiceAnswer;

        public FlagsGameCore(List<string> countriesList) {
            actualCountries = countriesList;
            countriesFlags = new Dictionary<string, Image>();
        }

        void RaiseEventGameOver() {
            if(GameOver != null) {
                GameOverEventArgs gameOverData = new GameOverEventArgs() { Time = GetGameTime() };
                GameOver(this, gameOverData);
            }
        }
        void RaiseEventScoreChanged() {
            if(ScoreChanged != null) {
                ScoreChangedAnswerEventArgs scoreData = new ScoreChangedAnswerEventArgs() { Score = score, Wins = wins, Losses = losses };
                ScoreChanged(this, scoreData);
            }
        }
        void RaiseEventCountryChanged(Image flag, string countryName) {
            if(CountryChanged != null) {
                CountryDataEventArgs countryData = new CountryDataEventArgs() { Flag = flag, Name = countryName };
                CountryChanged(this, countryData);
            }
        }
        void RaiseEventChoiceAnswer(AnswerStatus status, string countryName, double scoreDelta) {
            if(ChoiceAnswer != null) {
                ChoiceAnswerEventArgs answerData = new ChoiceAnswerEventArgs() { Status = status, CountryName = countryName, ScoreDelta = scoreDelta };
                ChoiceAnswer(this, answerData);
            }
        }
        void NextCountry() {
            if(unusedCountries.Count > 0) {
                int index = rand.Next(unusedCountries.Count);
                string countryName = unusedCountries[index];
                unusedCountries.Remove(countryName);
                currentCountry = countryName;
                RaiseEventCountryChanged(DemoUtils.GetCountryFlag(countriesFlags, countryName), countryName);
            }
            else {
                FinishGame();
            }
        }
        void RightChoice(string countryName) {
            int stepScore = GetScoreStep();
            wins++;
            score += stepScore;
            RaiseEventChoiceAnswer(AnswerStatus.Win, countryName, stepScore);
        }
        void WrongChoice(string countryName) {
            int stepScore = GetScoreStep();
            losses++;
            score -= stepScore;
            RaiseEventChoiceAnswer(AnswerStatus.Lose, countryName, -stepScore);
        }
        void WrongTry(string countryName) {
            int stepScore = 1;
            score -= stepScore;
            RaiseEventChoiceAnswer(AnswerStatus.WrongTry, countryName, -stepScore);
        }
        int GetScoreStep() {
            return 10 + 5 * (int)gameLevel;
        }
        string GetGameTime() {
            DateTime time = new DateTime(GamingTicks);
            bool isPrinting = false;
            string timeString = "";
            if(isPrinting || time.Hour > 0) {
                timeString += time.ToString("HH", CultureInfo.InvariantCulture) + "H ";
                isPrinting = true;
            }
            if(isPrinting || time.Minute > 0) {
                timeString += time.ToString("mm", CultureInfo.InvariantCulture) + "m ";
                isPrinting = true;
            }
            if(isPrinting || time.Second > 0) {
                timeString += time.ToString("ss", CultureInfo.InvariantCulture) + "s ";
                isPrinting = true;
            }
            timeString += time.ToString("ff", CultureInfo.InvariantCulture) + "ms ";
            return timeString;
        }

        public void StartGame(GameLevel level) {
            gameLevel = level;
            unusedCountries = new List<string>(actualCountries);
            currentCountry = "";
            wins = 0;
            losses = 0;
            score = 0;
            isGameActive = true;
            startGameTime = DateTime.Now;
            RaiseEventScoreChanged();
            NextCountry();
        }
        public void StartGame() {
            StartGame(GameLevel.Easy);
        }
        public void FinishGame() {
            finishGameTime = DateTime.Now;
            isGameActive = false;
            RaiseEventGameOver();
        }
        public bool TrySelectionCountry(string countryName) {
            if(!isGameActive)
                return false;
            bool isCorrectSelection = countryName == currentCountry;
            if(isCorrectSelection) {
                RightChoice(currentCountry);
                NextCountry();
            }
            else if(gameLevel != GameLevel.Easy) {
                WrongChoice(currentCountry);
                NextCountry();
            }
            else {
                WrongTry(countryName);
            }
            RaiseEventScoreChanged();
            return isCorrectSelection;
        }
        public void SkipCountry() {
            if(!isGameActive)
                return;
            WrongChoice(currentCountry);
            RaiseEventScoreChanged();
            NextCountry();
        }
        public void ShowCountry() {
            if(!isGameActive)
                return;
            double stepScore = 0.5;
            score -= stepScore;
            RaiseEventChoiceAnswer(AnswerStatus.ShowCountry, currentCountry, -stepScore);
            RaiseEventScoreChanged();
        }
        #region IDisposable implementation
        protected virtual void Dispose(bool disposing) {
            if(disposing) {
                IEnumerable<string> keysCollection = new List<string>(countriesFlags.Keys);
                foreach(string key in keysCollection) {
                    if(countriesFlags[key] != null) {
                        countriesFlags[key].Dispose();
                        countriesFlags[key] = null;
                    }
                }
            }
        }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~FlagsGameCore() {
            Dispose(false);
        }
        #endregion
    }
}
