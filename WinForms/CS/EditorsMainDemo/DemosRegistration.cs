using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.XtraEditors.Demos {
    public class DemosInfo : ModulesInfo {
        public static TutorialControl ShowModule(string name, GroupControl group, RibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name)
                        return null;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }
                TutorialControlBase tutorial = item.TModule as TutorialControlBase;
                tutorial.Bounds = group.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                group.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;
                TutorialControl tc = item.TModule as TutorialControl;
                if(tc != null) {
                    manager.AllowExport(tc.ExportView);
                }
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Visible = true;
                item.WasShown = true;
                if(oldTutorial != null)
                    oldTutorial.Visible = false;

                if(tutorial.ContainsTabs) 
                    tutorial.SelectTabByName(item.TabName);

                CodeTutorialControlBase ctcb = item.TModule as CodeTutorialControlBase;
                if(ctcb != null) ctcb.SelectExampleByName(item.CodeExampleName);
            }
            finally { Cursor.Current = currentCursor; }
            RaiseModuleChanged();
            return item.TModule as TutorialControl;
        }
    }

    public class TutorialHelper {
        public static string[] Countries = (new string[] {"United States <image=#us;size=16,16>", "Afghanistan", "Albania", "Algeria", "Andorra", "Angola",
            "Anguilla", "Antarctica", "Antigua & Barbuda", "Argentina", "Armenia <image=#am;size=16,16>", "Aruba (neth.)", "Australia", "Austria", "Azerbaijan", "Azores (port.)", "Bahamas",
            "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia And Herzegovina", "Botswana", "Brazil",
            "British Virgin Islands", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada <image=#ca;size=16,16>", "Cape Verde", "Cayman Islands", "Central African Republic",
            "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Cook Islands", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic",
            "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Fiji", "Finland", "Fmr Yug Rep Macedonia", "France", "French Guiana", "French Polynesia",
            "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guinea", "Guinea Bissau", "Guyana", "Haiti", "Honduras", "Hong Kong",
            "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Iraq-Saudi Arabia Neutral Zone", "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati",
            "Korea Dem.People's Rep.", "Korea, Republic Of", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya Arab Jamahiriy", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar",
            "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mexico", "Micronesia, Fed Stat", "Moldova, Republic Of", "Monaco", "Mongolia", "Morocco",
            "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau Islands",
            "Panama", "Panama Canal Zone", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation <image=#ru;size=16,16>", "Rwanda", "Saint Lucia", "San Marino",
            "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "St.Kitts & Nevis",
            "St.Vinct & Grenadine", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syrian Arab Rep.", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia",
            "Turkey", "Turkmenistan", "Turks And Caicos Islands", "Tuvalu", "U.S. Virgin Islands", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City (Holy See)",
            "Venezuela", "Vietnam", "Western Sahara", "Western Samoa", "Yemen", "Yugoslavia", "Zaire", "Zambia", "Zimbabwe"});
        public static int ConvertToInt(decimal value) {
            if(value > int.MaxValue) return int.MaxValue;
            if(value < int.MinValue) return int.MinValue;
            return (int)value;
        }
    }
}
