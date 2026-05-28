Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraTab

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class ColorPickerControl
        Inherits XtraUserControl

        Private item As RepositoryItemColorPickEdit

        Public Sub New()
            item = New RepositoryItemColorPickEdit()
            InitializeComponent()
            colorPickControl.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            TabStop = False
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitColorPicker()
            IniWebList()
            IniSystemList()
        End Sub

        Private Sub InitColorPicker()
            colorPickControl.Selectable = False
            colorPickControl.ThemeColors.AddColorRange(item.ThemeColors.ToList())
            colorPickControl.StandardColors.AddColorRange(item.StandardColors.ToList())
        End Sub

        Private Sub IniSystemList()
            systemColorListControl.Selectable = False
            systemColorListControl.Colors.AddColorRange(ColorListBoxViewInfo.SystemColors)
        End Sub

        Private Sub IniWebList()
            webColorListControl.Selectable = False
            webColorListControl.Colors.AddColorRange(ColorListBoxViewInfo.WebColors)
        End Sub

        Private Sub OnSelectedColorChanged(ByVal sender As Object, ByVal e As InnerColorPickControlSelectedColorChangedEventArgs)
            RaiseEvent ResultColorChanged(Me, e)
        End Sub

        Private color As Color = Color.Empty

        Public Sub SetColor(ByVal color As Color)
            Me.color = color
        End Sub

        Public Event ResultColorChanged As EventHandler(Of InnerColorPickControlSelectedColorChangedEventArgs)
    End Class

    <ToolboxItem(False)>
    Public Class NonFocusableTabControl
        Inherits XtraTabControl

        Protected Overrides ReadOnly Property AllowTabFocus As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
