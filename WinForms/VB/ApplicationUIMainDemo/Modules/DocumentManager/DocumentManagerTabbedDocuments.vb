Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class DocumentManagerTabbedDocuments
        Inherits TabbedViewTutorialControl

        Public Sub New()
            AutoMergeRibbon = True
            InitializeComponent()
            InitOptions()
            AddHandler tabbedView.OrientationChanged, AddressOf tabbedView_OrientationChanged
        End Sub

        Private Sub InitOptions()
            repositoryItemImageComboBox1.Items.AddEnum(GetType(TabHeaderLocation))
            repositoryItemImageComboBox2.Items.AddEnum(GetType(TabOrientation))
            repositoryItemImageComboBox3.Items.AddEnum(GetType(Orientation))
            repositoryItemImageComboBox4.Items.AddEnum(GetType(ClosePageButtonShowMode))
            repositoryItemImageComboBox5.Items.AddEnum(GetType(PinPageButtonShowMode))
            beiHeadeLocation.EditValue = tabbedView.DocumentGroupProperties.HeaderLocation
            beiHeaderOrientation.EditValue = tabbedView.DocumentGroupProperties.HeaderOrientation
            beiClosePageButton.EditValue = tabbedView.DocumentGroupProperties.ClosePageButtonShowMode
            beiOrientation.EditValue = tabbedView.Orientation
            beiShowPinTab.EditValue = tabbedView.DocumentGroupProperties.PinPageButtonShowMode
        End Sub

        Private Sub tabbedView_OrientationChanged(ByVal sender As Object, ByVal e As EventArgs)
            beiOrientation.EditValue = tabbedView.Orientation
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            AddDocument()
            AddDocument()
            AddDocument()
            AddDocument()
            AddDocument()
            tabbedView.Controller.CreateNewDocumentGroup(TryCast(tabbedView.Documents(3), Document))
            tabbedView.Controller.MoveToDocumentGroup(TryCast(tabbedView.Documents(4), Document), True)
        End Sub

        Private Sub biAddDocumentClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            AddDocument()
        End Sub

        Private i As Integer = 0

        Private Sub AddDocument()
            Dim child As XtraUserControl = New XtraUserControl()
            Dim settings As DocumentSettings = New DocumentSettings()
            settings.Caption = "Document" & Math.Min(Threading.Interlocked.Increment(i), i - 1).ToString()
            settings.Image = svgImageCollection1.GetImage(i Mod (svgImageCollection1.Count - 1))
            Utils.Base.BasePropertiesProvider.Attach(child, settings)
            child.Padding = New Padding(16)
            Dim label As LabelControl = New LabelControl()
            label.Text = DemosInfo.GetLoremIpsumText(i)
            label.AutoSizeMode = LabelAutoSizeMode.Vertical
            label.Parent = child
            label.Dock = DockStyle.Fill
            tabbedView.AddDocument(child)
            EnableColoredTabs()
        End Sub

        Private Sub EnableColoredTabs()
            If bciColoredTabs.Checked Then CType(tabbedView.Documents(tabbedView.Documents.Count - 1), Document).Appearance.Header.BackColor = TabColors((i - 1) Mod 6)
        End Sub

        Private Sub headerLocationChanged(ByVal sender As Object, ByVal e As EventArgs)
            tabbedView.DocumentGroupProperties.HeaderLocation = CType(beiHeadeLocation.EditValue, TabHeaderLocation)
        End Sub

        Private Sub headerOrientationChanged(ByVal sender As Object, ByVal e As EventArgs)
            tabbedView.DocumentGroupProperties.HeaderOrientation = CType(beiHeaderOrientation.EditValue, TabOrientation)
        End Sub

        Private Sub viewOrientationChanged(ByVal sender As Object, ByVal e As EventArgs)
            tabbedView.Orientation = CType(beiOrientation.EditValue, Orientation)
        End Sub

        Private Sub closePageButtonModeChanged(ByVal sender As Object, ByVal e As EventArgs)
            tabbedView.DocumentGroupProperties.ClosePageButtonShowMode = CType(beiClosePageButton.EditValue, ClosePageButtonShowMode)
        End Sub

        Private Sub showPinTabChanged(ByVal sender As Object, ByVal e As EventArgs)
            tabbedView.DocumentGroupProperties.PinPageButtonShowMode = CType(beiShowPinTab.EditValue, PinPageButtonShowMode)
        End Sub

        Private TabColors As Color() = New Color() {Color.FromArgb(35, 83, 194), Color.FromArgb(64, 168, 19), Color.FromArgb(245, 121, 10), Color.FromArgb(141, 62, 168), Color.FromArgb(70, 155, 183), Color.FromArgb(196, 19, 19)}

        Private Sub bciColoredTabs_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim isChecked As Boolean = CType(sender, BarCheckItem).Checked
            Dim j As Integer = 0
            For Each document As Document In tabbedView.Documents
                Dim tabColor As Color = Color.Empty
                If isChecked Then tabColor = TabColors(j Mod 6)
                document.Appearance.Header.BackColor = tabColor
                j += 1
            Next
        End Sub

        Private Sub bciDockGuides_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim isChecked As Boolean = CType(sender, BarCheckItem).Checked
            tabbedView.ShowDockGuidesOnPressingShift = If(isChecked, Utils.DefaultBoolean.True, Utils.DefaultBoolean.False)
        End Sub
    End Class
End Namespace
