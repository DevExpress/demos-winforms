Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class BaseTutorialControl
        Inherits DevExpress.XtraLayout.Demos.TutorialControl

        Private defaultJSONName As String = "Default.json"

        Private fCustomization As Boolean = False

        Public Sub New()
            InitializeComponent()
            Customization = False
        End Sub

        Public Overrides ReadOnly Property ExportControl As LayoutControl
            Get
                Return BaseLayout
            End Get
        End Property

        Public Overridable ReadOnly Property BaseLayout As LayoutControl
            Get
                Return Nothing
            End Get
        End Property

        Protected Overridable ReadOnly Property FileMask As String
            Get
                Return "xtra"
            End Get
        End Property

        Private isInitializingPanels As Boolean = True

        Private Sub cbFiles_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not isInitializingPanels Then Restore()
        End Sub

        Protected Sub InitPanels()
            navigationPage1.Visible = BaseLayout IsNot Nothing
            If BaseLayout IsNot Nothing Then
                Dim jsonFileNames = FindingJsonFiles("Data\FormLayouts", FileMask)
                If jsonFileNames.Count = 0 Then navigationPage1.Visible = False
                cbFiles.Properties.Items.Clear()
                For Each _name As JSONFileName In jsonFileNames
                    cbFiles.Properties.Items.Add(New RadioGroupItem(_name, _name.Name))
                    If Equals(_name.Name, defaultJSONName) Then
                        cbFiles.SelectedIndex = cbFiles.Properties.Items.Count - 1
                    End If
                Next

                AddHandler BaseLayout.ShowCustomization, New EventHandler(AddressOf ShowCustomization)
                AddHandler BaseLayout.HideCustomization, New EventHandler(AddressOf HideCustomization)
                BaseLayout.OptionsView.AllowExpandAnimation = DevExpress.Utils.DefaultBoolean.True
                BaseLayout.OptionsView.AllowItemSkinning = True
                BaseLayout.OptionsCustomizationForm.ShowPropertyGrid = True
                BaseLayout.OptionsCustomizationForm.SnapMode = DevExpress.Utils.Controls.SnapMode.All
            End If

            isInitializingPanels = False
        End Sub

        <DefaultValue(False)>
        Public Property Customization As Boolean
            Get
                Return fCustomization
            End Get

            Set(ByVal value As Boolean)
                fCustomization = value
                sbCustomize.Text = If(fCustomization, "Hide Customization Form", "Show Customization Form")
            End Set
        End Property

        Private Sub ShowCustomization(ByVal sender As Object, ByVal e As EventArgs)
            Customization = True
        End Sub

        Private Sub HideCustomization(ByVal sender As Object, ByVal e As EventArgs)
            Customization = False
        End Sub

        '<cbFiles>
        Private ReadOnly Property CurrentJsonFileName As String
            Get
                Dim file As JSONFileName = TryCast(cbFiles.EditValue, JSONFileName)
                If file Is Nothing Then Return ""
                Return file.FullName
            End Get
        End Property

        Private Sub Restore()
            If BaseLayout Is Nothing OrElse String.IsNullOrEmpty(CurrentJsonFileName) Then Return
            Using jsonStream = File.OpenRead(CurrentJsonFileName)
                BaseLayout.RestoreLayoutFromJson(jsonStream)
            End Using

            '</cbFiles>
            BaseLayout.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            BaseLayout.Root.GroupBordersVisible = False
            tabTransitionAnimation_CheckedChanged(Nothing, Nothing)
            highlightGroupBordersCheckEdit_CheckedChanged(Nothing, Nothing)
            highlightTabHeadersCheckEdit_CheckedChanged(Nothing, Nothing)
            defaultJSONName = ""
        '<cbFiles>
        End Sub

        '</cbFiles>
#Region "Finding Xml Files"
        Friend Shared Function FindingJsonFiles(ByVal folder As String, ByVal mask As String) As List(Of JSONFileName)
            Dim rootFullPath As String = Path.GetFullPath(Application.StartupPath)
            Dim jsonFiles As List(Of JSONFileName) = New List(Of JSONFileName)()
            For i As Integer = 0 To 10
                Dim fullPath As String = Path.GetFullPath(Path.Combine(rootFullPath, folder))
                If Directory.Exists(fullPath) Then
                    Dim names As String() = Directory.GetFiles(fullPath, mask & "*.json")
                    For Each _name As String In names
                        Dim fInfo As FileInfo = New FileInfo(_name)
                        Dim fName As String = fInfo.Name
                        fName = fName.Replace(mask, "")
                        jsonFiles.Add(New JSONFileName(fName, fInfo.FullName))
                    Next

                    Return jsonFiles
                Else
                    rootFullPath += "\.."
                End If
            Next

            Return jsonFiles
        End Function

        Friend Class JSONFileName

            Private ReadOnly fName, fFullName As String

            Public Sub New(ByVal name As String, ByVal fullName As String)
                fName = name
                fFullName = fullName
            End Sub

            Public ReadOnly Property Name As String
                Get
                    Return fName
                End Get
            End Property

            Public ReadOnly Property FullName As String
                Get
                    Return fFullName
                End Get
            End Property

            Public Overrides Function ToString() As String
                Return Name
            End Function
        End Class

#End Region
        Protected Overrides Sub DoHide()
            If BaseLayout IsNot Nothing Then BaseLayout.HideCustomizationForm()
            lcTitle.HideCustomizationForm()
        End Sub

        '<sbCustomize>
        Private Sub sbCustomize_Click(ByVal sender As Object, ByVal e As EventArgs)
            If BaseLayout Is Nothing Then Return
            If Customization Then
                BaseLayout.HideCustomizationForm()
            Else
                BaseLayout.ShowCustomizationForm()
            End If
        End Sub

        '</sbCustomize>
        '<highlightFocusedItemCheckEdit>
        Private Sub highlightFocusedItemCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If BaseLayout Is Nothing Then Return
            BaseLayout.OptionsView.HighlightFocusedItem = highlightFocusedItemCheckEdit.Checked
        End Sub

        '</highlightFocusedItemCheckEdit>
        '<quickCustomizationCheckEdit>
        Private Sub quickCustomizationCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If BaseLayout Is Nothing Then Return
            If quickCustomizationCheckEdit.Checked = True Then
                BaseLayout.CustomizationMode = CustomizationModes.Quick
            Else
                BaseLayout.CustomizationMode = CustomizationModes.Default
            End If
        End Sub

        '</quickCustomizationCheckEdit>
        '<showAdornerLayerCheckEdit>
        Private Sub showAdornerLayerCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            BaseLayout.OptionsView.DrawAdornerLayer = If(showAdornerLayerCheckEdit.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
        End Sub

        '</showAdornerLayerCheckEdit>
        '<allowExpandAnimationCheckEdit>
        Private Sub allowExpandAnimationCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            BaseLayout.OptionsView.AllowExpandAnimation = If(allowExpandAnimationCheckEdit.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
        End Sub

        '</allowExpandAnimationCheckEdit>
        '<showPropertyGridCheckEdit>
        Private Sub showPropertyGridCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            BaseLayout.OptionsCustomizationForm.ShowPropertyGrid = showPropertyGridCheckEdit.Checked
        End Sub

        '</showPropertyGridCheckEdit>
        '<snapModeCheckEdit>
        Private Sub snapModeCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If snapModeCheckEdit.Checked Then
                BaseLayout.OptionsCustomizationForm.SnapMode = DevExpress.Utils.Controls.SnapMode.All
            Else
                BaseLayout.OptionsCustomizationForm.SnapMode = DevExpress.Utils.Controls.SnapMode.None
            End If
        End Sub

        '</snapModeCheckEdit>
        '<tabTransitionAnimationCheckEdit>
        Private Sub tabTransitionAnimation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetTransition(tabTransitionAnimationCheckEdit.Checked)
        End Sub

        Private Sub SetTransition(ByVal value As Boolean)
            For Each item In BaseLayout.Items
                Dim tcg As TabbedControlGroup = TryCast(item, TabbedControlGroup)
                If tcg Is Nothing Then Continue For
                tcg.Transition.AllowTransition = If(value, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
            Next
        End Sub

        '</tabTransitionAnimationCheckEdit>
        Private Sub snapModeLCI_CustomDraw(ByVal sender As Object, ByVal e As ItemCustomDrawEventArgs)
            e.DefaultDraw()
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(55, 127, 221, 134)), e.Bounds)
            e.Handled = True
        End Sub

        '<highlightGroupBordersCheckEdit> //<highlightTabHeadersCheckEdit>
        Private skinColors As List(Of Color) = New List(Of Color)() From {DXSkinColors.FillColors.Danger, DXSkinColors.FillColors.Primary, DXSkinColors.FillColors.Question, DXSkinColors.FillColors.Success, DXSkinColors.FillColors.Warning}

        '</highlightTabHeadersCheckEdit>
        Private Sub highlightGroupBordersCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim iterator As Integer = 0
            For Each item In BaseLayout.Items
                Dim lcg As LayoutControlGroup = TryCast(item, LayoutControlGroup)
                If lcg Is Nothing OrElse lcg Is BaseLayout.Root Then Continue For
                lcg.AppearanceGroup.BorderColor = If(highlightGroupBordersCheckEdit.Checked, skinColors(Math.Min(Threading.Interlocked.Increment(iterator), iterator - 1) Mod skinColors.Count), Color.Empty)
            Next
        End Sub

        '</highlightGroupBordersCheckEdit>
        '<highlightTabHeadersCheckEdit>
        Private Sub highlightTabHeadersCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim iterator As Integer = 0
            For Each item In BaseLayout.Items
                Dim lcg As LayoutControlGroup = TryCast(item, LayoutControlGroup)
                If lcg Is Nothing OrElse lcg Is BaseLayout.Root Then Continue For
                lcg.AppearanceTabPage.Header.BackColor = If(highlightTabHeadersCheckEdit.Checked, skinColors(Math.Min(Threading.Interlocked.Increment(iterator), iterator - 1) Mod skinColors.Count), Color.Empty)
            Next
        End Sub
    '</highlightTabHeadersCheckEdit>
    End Class
End Namespace
