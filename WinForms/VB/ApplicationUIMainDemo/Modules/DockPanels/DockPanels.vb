Imports System
Imports System.Data
Imports System.Linq
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking
Imports DevExpress.DXperience.Demos

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class DockPanels
        Inherits TutorialControlBase

        Private activeIndex As Integer = 0

        Private modules As BaseControl() = New BaseControl(4) {}

        Private modulesTypes As Type() = New Type() {GetType(SimpleDockPanel), GetType(CentralContainer), GetType(TabContainer), GetType(HorizontalContainer), GetType(VerticalContainer)}

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnStyleChanged()
            MyBase.OnStyleChanged()
            SetLayoutLabelBackColor()
        End Sub

        Private Sub OnDockPanelsLoad(ByVal sender As Object, ByVal e As EventArgs)
            InitDefaultContainer()
            SetLayoutLabelBackColor()
        End Sub

        Private Sub InitDefaultContainer()
            Dim layoutCheckButtons = toolbarPanel.Controls.OfType(Of CheckButton)().Where(Function(cb) cb.Name.StartsWith(cbLayoutType.Name))
            Dim checkedLayoutButton = layoutCheckButtons.FirstOrDefault(Function(b) b.Checked)
            Dim containerIndex As Integer = CInt(checkedLayoutButton.Tag)
            Dim superTipText As String = checkedLayoutButton.SuperTip.ToString()
            SelectContainer(containerIndex, superTipText)
        End Sub

        Private Sub SetLayoutLabelBackColor()
            layoutLabel.Appearance.BackColor = Color.FromArgb(10, DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary)
        End Sub

        Private Sub OnLayoutSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim checkButton = TryCast(sender, CheckButton)
            If checkButton.Tag Is Nothing Then Return
            Dim index As Integer = CInt(checkButton.Tag)
            Dim _text As String = checkButton.SuperTip.ToString()
            SelectContainer(index, _text)
        End Sub

        Private Sub SelectContainer(ByVal index As Integer, ByVal displayText As String)
            If index < 0 Then Return
            layoutLabel.Text = displayText
            If modules(index) Is Nothing Then
                Dim constructorInfoObj As ConstructorInfo = modulesTypes(index).GetConstructor(Type.EmptyTypes)
                If constructorInfoObj IsNot Nothing Then
                    modules(index) = TryCast(constructorInfoObj.Invoke(Nothing), BaseControl)
                    contentPanel.Controls.Add(modules(index))
                    modules(index).Dock = DockStyle.Fill
                Else
                    Return
                End If
            End If

            modules(index).BringToFront()
            If modules(activeIndex) IsNot Nothing AndAlso index <> activeIndex Then
                modules(activeIndex).Dispose()
                modules(activeIndex) = Nothing
            End If

            activeIndex = index
            SetEnableAddPanelButtons(True)
        End Sub

        Private maxPanelCount As Integer = 10

        Private Sub OnAddPanelButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim button = TryCast(sender, SimpleButton)
            Dim dockStyle = CType(button.Tag, DockingStyle)
            If modules(activeIndex) IsNot Nothing Then
                If modules(activeIndex).Manager.Count < maxPanelCount Then
                    modules(activeIndex).Manager.AddPanel(dockStyle)
                Else
                    SetEnableAddPanelButtons(False)
                End If
            End If
        End Sub

        Private Sub SetEnableAddPanelButtons(ByVal value As Boolean)
            buttonsLabel.Enabled = value
            Dim addPanelButtons = toolbarPanel.Controls.OfType(Of SimpleButton)().Where(Function(cb) cb.Name.StartsWith(sbAddPanel.Name))
            For Each addPanelButton In addPanelButtons
                addPanelButton.Enabled = value
            Next
        End Sub

        Protected Overrides ReadOnly Property AllowBorderRounding As Boolean?
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
