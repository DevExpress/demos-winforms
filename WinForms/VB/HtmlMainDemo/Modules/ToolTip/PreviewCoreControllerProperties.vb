Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout.Utils
Imports System

Namespace DevExpress.HTML.Demos

    Public Partial Class PreviewCoreControllerProperties
        Inherits XtraUserControl

        Private controller As ToolTipController

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub SetVisibleProperties(ByVal autoPopDelay As Boolean, ByVal initialDelay As Boolean, ByVal iconSize As Boolean, ByVal location As Boolean, ByVal type As Boolean)
            liAutoPopDelay.Visibility = If(autoPopDelay, LayoutVisibility.Always, LayoutVisibility.Never)
            liInitialDelay.Visibility = If(initialDelay, LayoutVisibility.Always, LayoutVisibility.Never)
            liIconSize.Visibility = If(iconSize, LayoutVisibility.Always, LayoutVisibility.Never)
            liLocation.Visibility = If(location, LayoutVisibility.Always, LayoutVisibility.Never)
            liType.Visibility = If(type, LayoutVisibility.Always, LayoutVisibility.Never)
        End Sub

        Public Sub Initialize(ByVal controller As ToolTipController, ByVal type As ToolTipType)
            Me.controller = controller
            ttIconSize.Properties.Items.AddRange([Enum].GetValues(GetType(ToolTipIconSize)))
            ttLocation.Properties.Items.AddRange([Enum].GetValues(GetType(ToolTipLocation)))
            ttType.Properties.Items.AddRange(New ToolTipType() {ToolTipType.Default, ToolTipType.Html, type})
            UpdateValues()
            SubscribeEvents()
        End Sub

        Public Sub UpdateValues()
            ttAutoPopDelay.EditValue = controller.AutoPopDelay
            ttInitialDelay.EditValue = controller.InitialDelay
            ttIconSize.EditValue = controller.IconSize
            ttLocation.EditValue = controller.ToolTipLocation
            ttType.EditValue = controller.ToolTipType
        End Sub

        Private Sub SubscribeEvents()
            AddHandler ttAutoPopDelay.EditValueChanged, Sub()
                controller.AutoPopDelay = Convert.ToInt16(ttAutoPopDelay.EditValue)
                RaiseEvent PropertyChanged(Me, EventArgs.Empty)
            End Sub
            AddHandler ttInitialDelay.EditValueChanged, Sub()
                controller.InitialDelay = Convert.ToInt16(ttInitialDelay.EditValue)
                RaiseEvent PropertyChanged(Me, EventArgs.Empty)
            End Sub
            AddHandler ttIconSize.EditValueChanged, Sub()
                controller.IconSize = CType(ttIconSize.EditValue, ToolTipIconSize)
                RaiseEvent PropertyChanged(Me, EventArgs.Empty)
            End Sub
            AddHandler ttLocation.EditValueChanged, Sub()
                controller.ToolTipLocation = CType(ttLocation.EditValue, ToolTipLocation)
                RaiseEvent PropertyChanged(Me, EventArgs.Empty)
            End Sub
            AddHandler ttType.EditValueChanged, Sub()
                controller.ToolTipType = CType(ttType.EditValue, ToolTipType)
                RaiseEvent PropertyChanged(Me, EventArgs.Empty)
            End Sub
        End Sub

        Public Event PropertyChanged As EventHandler
    End Class
End Namespace
