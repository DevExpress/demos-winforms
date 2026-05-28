namespace DevExpress.DentalClinic.Properties
{
    using DevExpress.XtraEditors;
    using System.ComponentModel;
    using System.Configuration;

    public sealed partial class Settings
    {
        protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
        {
            base.OnSettingsLoaded(sender, e);
            ApplySettings();
        }
        protected override void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(sender, e);
            if (e.PropertyName == nameof(Settings.DarkTheme) || e.PropertyName == nameof(Settings.CompactUI))
                ApplySettings();
        }
        static void ApplySettings()
        {
            var palette = Settings.Default.DarkTheme ?
                "Dark Palette" : "Light Palette";
            XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(LookAndFeel.SkinStyle.Bezier, palette);
            WindowsFormsSettings.CompactUIMode = Settings.Default.CompactUI ? Utils.DefaultBoolean.True : Utils.DefaultBoolean.False;
            //WindowsFormsSettings.DefaultFont =  new System.Drawing.Font("Segoe UI", Settings.Default.CompactUI ? 8.25f : 9.75f);
            WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", 8.25f);
        }
    }
}
