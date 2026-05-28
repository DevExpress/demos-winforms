Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.XtraEditors.Demos

    Public Class DemosInfo
        Inherits ModulesInfo

        Public Shared Overloads Function ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal manager As RibbonMenuManager) As TutorialControl
            Dim item As ModuleInfo = GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim oldTutorial As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If Equals(Instance.CurrentModuleBase.Name, name) Then Return Nothing
                    oldTutorial = Instance.CurrentModuleBase.TModule
                End If

                Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
                tutorial.Bounds = group.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                group.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill
                Dim tc As TutorialControl = TryCast(item.TModule, TutorialControl)
                If tc IsNot Nothing Then
                    manager.AllowExport(tc.ExportView)
                End If

                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Visible = True
                item.WasShown = True
                If oldTutorial IsNot Nothing Then oldTutorial.Visible = False
                If tutorial.ContainsTabs Then tutorial.SelectTabByName(item.TabName)
                Dim ctcb As CodeTutorialControlBase = TryCast(item.TModule, CodeTutorialControlBase)
                If ctcb IsNot Nothing Then ctcb.SelectExampleByName(item.CodeExampleName)
            Finally
                Cursor.Current = currentCursor
            End Try

            Call RaiseModuleChanged()
            Return TryCast(item.TModule, TutorialControl)
        End Function
    End Class

    Public Class TutorialHelper

        Public Shared Countries As String() = New String() {"United States <image=#us;size=16,16>", "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua & Barbuda", "Argentina", "Armenia <image=#am;size=16,16>", "Aruba (neth.)", "Australia", "Austria", "Azerbaijan", "Azores (port.)", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia And Herzegovina", "Botswana", "Brazil", "British Virgin Islands", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada <image=#ca;size=16,16>", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Cook Islands", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Fiji", "Finland", "Fmr Yug Rep Macedonia", "France", "French Guiana", "French Polynesia", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guinea", "Guinea Bissau", "Guyana", "Haiti", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Iraq-Saudi Arabia Neutral Zone", "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea Dem.People's Rep.", "Korea, Republic Of", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya Arab Jamahiriy", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mexico", "Micronesia, Fed Stat", "Moldova, Republic Of", "Monaco", "Mongolia", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau Islands", "Panama", "Panama Canal Zone", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation <image=#ru;size=16,16>", "Rwanda", "Saint Lucia", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "St.Kitts & Nevis", "St.Vinct & Grenadine", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syrian Arab Rep.", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks And Caicos Islands", "Tuvalu", "U.S. Virgin Islands", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City (Holy See)", "Venezuela", "Vietnam", "Western Sahara", "Western Samoa", "Yemen", "Yugoslavia", "Zaire", "Zambia", "Zimbabwe"}

        Public Shared Function ConvertToInt(ByVal value As Decimal) As Integer
            If value > Integer.MaxValue Then Return Integer.MaxValue
            If value < Integer.MinValue Then Return Integer.MinValue
            Return CInt(value)
        End Function
    End Class
End Namespace
