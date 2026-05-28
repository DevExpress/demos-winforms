Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports DevExpress.Data
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Columns

Namespace DevExpress.WindowsMailClient.Win.Utils

    Public Class SortInfo

        Public Property Column As GridColumn

        Public Property Order As ColumnSortOrder
    End Class

    Public Module Utils

        Public MessageFrom As String = "maildemo@dx-mail.com"

        Private _startMhtText As String = Nothing

        Private DefaultTextResourceName As String = "StartMhtText.txt"

        Public Property StartMhtText As String
            Get
                If String.IsNullOrEmpty(_startMhtText) Then
                    Dim assembly = Reflection.Assembly.GetExecutingAssembly()
                    Using stream As Stream = assembly.GetManifestResourceStream(Assembly.GetExecutingAssembly().GetName().Name & ".Data." & DefaultTextResourceName)
                        Using sr As StreamReader = New StreamReader(stream)
                            _startMhtText = sr.ReadToEnd()
                        End Using
                    End Using
                End If

                Return _startMhtText
            End Get

            Set(ByVal value As String)
                _startMhtText = value
            End Set
        End Property

        Private _useAsEmailSignature As Boolean = True

        Public Property UseAsEmailSignature As Boolean
            Get
                Return _useAsEmailSignature
            End Get

            Set(ByVal value As Boolean)
                _useAsEmailSignature = value
            End Set
        End Property

        Private _showNotifications As Boolean = True

        Public Property ShowNotifications As Boolean
            Get
                Return _showNotifications
            End Get

            Set(ByVal value As Boolean)
                _showNotifications = value
            End Set
        End Property
    End Module

    Friend Module ColorProvider

        Public Function GetControlColor(ByVal provider As LookAndFeel.UserLookAndFeel) As Color
            Return LookAndFeel.LookAndFeelHelper.GetSystemColor(provider, SystemColors.Control)
        End Function

        Public ReadOnly Property TextColor As Color
            Get
                Return CommonSkins.GetSkin(LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.ControlText)
            End Get
        End Property

        Public ReadOnly Property WindowColor As Color
            Get
                Return CommonSkins.GetSkin(LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.Window)
            End Get
        End Property

        Public ReadOnly Property WindowTextColor As Color
            Get
                Return CommonSkins.GetSkin(LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.WindowText)
            End Get
        End Property

        Public ReadOnly Property DisabledTextColor As Color
            Get
                Return CommonSkins.GetSkin(LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.DisabledText)
            End Get
        End Property

        Public ReadOnly Property CriticalColor As Color
            Get
                Return CommonColors.GetCriticalColor(LookAndFeel.UserLookAndFeel.Default)
            End Get
        End Property

        Public ReadOnly Property WarningColor As Color
            Get
                Return CommonColors.GetWarningColor(LookAndFeel.UserLookAndFeel.Default)
            End Get
        End Property

        Public ReadOnly Property QuestionColor As Color
            Get
                Return CommonColors.GetQuestionColor(LookAndFeel.UserLookAndFeel.Default)
            End Get
        End Property

        Public ReadOnly Property InformationColor As Color
            Get
                Return CommonColors.GetInformationColor(LookAndFeel.UserLookAndFeel.Default)
            End Get
        End Property
    End Module

    Friend Module FontProvider

        Private cache As IDictionary(Of String, Font)

        Sub New()
            cache = New Dictionary(Of String, Font)()
        End Sub

        Public Function GetSegoeUIFont(ByVal fontStyle As FontStyle) As Font
            Dim defaultSize As Single = DevExpress.Utils.AppearanceObject.DefaultFont.Size
            Return GetFont("Segoe UI", defaultSize, fontStyle)
        End Function

        Public Function GetSegoeUIFont(ByVal Optional sizeGrow As Single = 0) As Font
            Dim defaultSize As Single = DevExpress.Utils.AppearanceObject.DefaultFont.Size
            Return GetFont("Segoe UI", defaultSize + sizeGrow)
        End Function

        Public Function GetSegoeUILightFont(ByVal Optional sizeGrow As Single = 0) As Font
            Dim defaultSize As Single = DevExpress.Utils.AppearanceObject.DefaultFont.Size
            Return GetFont("Segoe UI Light", defaultSize + sizeGrow)
        End Function

        Public Function GetFont(ByVal familyName As String, ByVal size As Single, ByVal Optional style As FontStyle = FontStyle.Regular) As Font
            Dim key As String = familyName & "#" & size
            If style <> FontStyle.Regular Then key += "#" & style
            Dim result As Font = Nothing
            If Not cache.TryGetValue(key, result) Then
                Try
                    Dim family = FindFontFamily(familyName)
                    result = New Font(If(family, FontFamily.GenericSansSerif), size, style)
                Catch __unusedArgumentException1__ As ArgumentException
                    result = DevExpress.Utils.AppearanceObject.DefaultFont
                End Try

                cache.Add(key, result)
            End If

            Return result
        End Function

        Private Function FindFontFamily(ByVal familyName As String) As FontFamily
            Return Array.Find(FontFamily.Families, Function(f) Equals(f.Name, familyName))
        End Function
    End Module
End Namespace
