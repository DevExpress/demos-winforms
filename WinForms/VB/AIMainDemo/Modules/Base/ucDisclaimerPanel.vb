Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Colors
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Namespace DevExpress.AI.Demos

    Public Partial Class ucDisclaimerPanel
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            OnLookAndFeelChanged()
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            Dim color = DXSkinColorHelper.GetDXSkinColor(DXSkinColors.FillColors.Warning, 64, LookAndFeel)
            noteLayoutControl.BackColor = color
            noteLabelControl.ForeColor = DXSkinColors.ForeColors.ControlText
        End Sub

        Public ReadOnly Property RoundedPanelOffset As Integer
            Get
                Return roundedSkinPanel.DisplayRectangle.Y
            End Get
        End Property
    End Class
End Namespace
