Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Layout
Imports System.IO
Imports System.Reflection
Imports DevExpress.XtraGrid.Views.Layout.Events
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class NWindLayout
        Inherits BaseLayoutModule

        Private pathSingleRecordXML As String = "DevExpress.XtraGrid.Demos.ModulesLayoutView.SingleRecordLayout.xml"

        Private defaultXMLStream As Stream

        Private singleRecordXMLStream As Stream

        Private showCaptionImages As Boolean

        Private showFieldImages As Boolean

        Private showImagesInFocusedCardOnly As Boolean

        Private fieldNotesCustomVisibility As Boolean

        Private fieldPhotoCustomVisibility As Boolean

        Private contactInfoInFocusedCardOnly As Boolean

        Private thisAssembly As Assembly

        Public Sub New()
            thisAssembly = Assembly.GetExecutingAssembly()
            CreateWaitDialog()
            InitializeComponent()
            InitData()
            BorderStyle = BorderStyle.None
            gridControl1.ForceInitialize()
            CustomizationPageVisible = True
            For Each mode As CardsAlignment In [Enum].GetValues(GetType(CardsAlignment))
                cardAlignment.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of CardsAlignment).GetTitle(mode), mode, -1))
            Next

            cardAlignment.EditValue = CardsAlignment.Center
            '<imagesOnlyForFocused>
            '<imagesInCaptions>
            AddHandler layoutView.CustomCardCaptionImage, AddressOf OnCustomCardCaptionImage
            '</imagesInCaptions>
            '</imagesOnlyForFocused>
            '<imagesOnlyForFocused>
            '<imagesInFields>
            AddHandler layoutView.CustomFieldCaptionImage, AddressOf OnCustomFieldCaptionImage
            '</imagesInFields>
            '</imagesOnlyForFocused>
            '<photoVisibility>
            '<notesVisibility>
            '<visibilityOnlyForFocused>
            AddHandler layoutView.CustomCardLayout, AddressOf Me.OnCustomCardLayout
        '</notesVisibility>
        '</photoVisibility>
        '</visibilityOnlyForFocused>
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"NWindLayout"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "NWindLayout"
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            defaultXMLStream = New MemoryStream()
            layoutView.SaveLayoutToStream(defaultXMLStream)
        End Sub

        Private list As SvgImageCollection = Nothing

        Protected Sub LoadCustomImages()
            list = New SvgImageCollection()
            list.ImageSize = New Size(16, 16)
            list.Add("about", "image://svgimages/outlook inspired/about.svg")
            list.Add("actions_rating", "image://svgimages/icon builder/actions_rating.svg")
            list.Add("bo_address", "image://svgimages/business objects/bo_address.svg")
        End Sub

        '<photoVisibility>
        '<notesVisibility>
        '<visibilityOnlyForFocused>
        Private Sub OnCustomCardLayout(ByVal sender As Object, ByVal e As LayoutViewCustomCardLayoutEventArgs)
            If Not CustomEventsPageVisible Then Return
            Dim colNotesFieldName As String = layoutViewField_colNotes.Name
            Dim colPhotoFieldName As String = layoutViewField_colPhoto.Name
            Dim groupContactInfoName As String = "Group2"
            Dim differences As LayoutViewCardDifferences = e.CardDifferences
            If contactInfoInFocusedCardOnly Then
                differences.AddItemDifference(groupContactInfoName, LayoutItemDifferenceType.ItemVisibility, layoutView.FocusedRowHandle = e.RowHandle)
            Else
                differences.AddItemDifference(groupContactInfoName, LayoutItemDifferenceType.ItemVisibility, True)
            End If

            differences.AddItemDifference(colNotesFieldName, LayoutItemDifferenceType.ItemVisibility, fieldNotesCustomVisibility)
            differences.AddItemDifference(colPhotoFieldName, LayoutItemDifferenceType.ItemVisibility, fieldPhotoCustomVisibility)
        End Sub

        '</visibilityOnlyForFocused>
        '</notesVisibility>
        '</photoVisibility>
        '<imagesOnlyForFocused>
        '<imagesInFields>
        Private Sub OnCustomFieldCaptionImage(ByVal sender As Object, ByVal e As LayoutViewFieldCaptionImageEventArgs)
            If Not CustomEventsPageVisible OrElse Not showFieldImages Then Return
            If showImagesInFocusedCardOnly AndAlso layoutView.FocusedRowHandle <> e.RowHandle Then Return
            If e.Column Is colNotes Then
                e.Image = list.GetImage(0, list.ScaledImageSize)
                e.ImageAlignment = ContentAlignment.MiddleLeft
            End If
        End Sub

        '</imagesInFields>
        '</imagesOnlyForFocused>
        '<imagesOnlyForFocused>
        '<imagesInCaptions>
        Private Sub OnCustomCardCaptionImage(ByVal sender As Object, ByVal e As LayoutViewCardCaptionImageEventArgs)
            If Not CustomEventsPageVisible OrElse Not showCaptionImages Then Return
            If showImagesInFocusedCardOnly AndAlso layoutView.FocusedRowHandle <> e.RowHandle Then Return
            e.ImageList = list
            e.ImageIndex = 1
            e.CaptionImageLocation = GroupElementLocation.BeforeText
        End Sub

        '</imagesInCaptions>
        '</imagesOnlyForFocused>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If singleRecordXMLStream IsNot Nothing Then
                    singleRecordXMLStream.Close()
                    singleRecordXMLStream.Dispose()
                    singleRecordXMLStream = Nothing
                End If

                If defaultXMLStream IsNot Nothing Then
                    defaultXMLStream.Dispose()
                    defaultXMLStream.Close()
                    defaultXMLStream = Nothing
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

        Public Overrides ReadOnly Property ExportView As Views.Base.BaseView
            Get
                Return layoutView
            End Get
        End Property

        Protected Overridable Sub InitData()
            Dim dsNWind = NWindDataSet()
            gridControl1.DataSource = dsNWind.Tables("Employees")
            repositoryItemLookUpEdit1.DataSource = dsNWind.Tables("Employees")
            '
            singleRecordXMLStream = ResourceImageHelperCore.FindStream(pathSingleRecordXML, thisAssembly)
            LoadCustomImages()
        End Sub

        '<customizeBtn>
        Protected Sub customizeBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not layoutView.IsCustomizationMode Then
                layoutView.ShowCustomizationForm()
            Else
                layoutView.HideCustomizationForm()
            End If
        End Sub

        '</customizeBtn>
        '<allowRuntimeCustomization>
        Private Sub allowRuntimeCustomization_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            layoutView.OptionsBehavior.AllowRuntimeCustomization = CBool(allowRuntimeCustomization.EditValue)
            customizeBtn.Enabled = layoutView.OptionsBehavior.AllowRuntimeCustomization
        End Sub

        '</allowRuntimeCustomization>
        Private Sub navigationPane1_SelectedPageChanged(ByVal sender As Object, ByVal e As XtraBars.Navigation.SelectedPageChangedEventArgs)
            CustomizeCustomizationModePage()
            CustomizeSingleRecordModePage()
            CustomizeMultiRecordModePage()
            CustomizeCustomsEventPage()
            layoutView.Refresh()
        End Sub

        Protected Sub CustomizeSingleRecordModePage()
            If SingleRecordPageVisible Then
                LoadSingleRecordLayout()
                SetLayoutTabbedGroupCaptions(layoutView.TemplateCard.Items(5), New String() {Properties.Resources.Other, colNotes.Caption})
                layoutView.OptionsBehavior.AllowSwitchViewModes = False
                layoutView.OptionsBehavior.AllowExpandCollapse = False
                cardAlignment.Enabled = Not stretchWidth.Checked Xor Not stretchHeight.Checked
                Return
            End If
        End Sub

        Private Sub SetLayoutTabbedGroupCaptions(ByVal group As Object, ByVal captions As String())
            Dim tGroup As TabbedControlGroup = TryCast(group, TabbedControlGroup)
            If tGroup Is Nothing Then Return
            tGroup.TabPages(0).Text = captions(0)
            tGroup.TabPages(1).Text = captions(1)
        End Sub

        Private Sub ExpandAllCards()
            For i As Integer = 0 To layoutView.RecordCount - 1
                layoutView.ExpandCard(i)
            Next
        End Sub

        Protected Sub LoadSingleRecordLayout()
            If singleRecordXMLStream IsNot Nothing Then
                singleRecordXMLStream.Seek(0, SeekOrigin.Begin)
                ExpandAllCards()
                layoutView.RestoreLayoutFromStream(singleRecordXMLStream)
                layoutView.OptionsBehavior.AllowExpandCollapse = False
            End If

            gridControl1.UseEmbeddedNavigator = True
            isDefault = False
        End Sub

        Protected Sub CustomizeMultiRecordModePage()
            If MultiRecordPageVisible Then
                LoadDefaultLayout()
                layoutView.OptionsMultiRecordMode.StretchCardToViewHeight = stretchHeightM.Checked
                layoutView.OptionsMultiRecordMode.StretchCardToViewWidth = stretchWidthM.Checked
                multiSelect.EditValue = layoutView.OptionsSelection.MultiSelect
                Return
            End If
        End Sub

        Protected Sub CustomizeCustomizationModePage()
            If CustomizationPageVisible Then
                LoadDefaultLayout()
            End If
        End Sub

        Protected Sub CustomizeCustomsEventPage()
            If CustomEventsPageVisible Then
                isDefault = False
                LoadDefaultLayout()
                showCaptionImages = imagesInCaptions.Checked
                showFieldImages = imagesInFields.Checked
                showImagesInFocusedCardOnly = imagesOnlyForFocused.Checked
                fieldNotesCustomVisibility = notesVisibility.Checked
                fieldPhotoCustomVisibility = photoVisibility.Checked
                contactInfoInFocusedCardOnly = visibilityOnlyForFocused.Checked
                InitContactInfoGroupImage()
            End If
        End Sub

        Protected Sub InitContactInfoGroupImage()
            layoutView.TemplateCard.BeginUpdate()
            TryCast(layoutView, ILayoutControl).Images = list
            TryCast(layoutView.TemplateCard(2), LayoutGroup).CaptionImageIndex = 2
            TryCast(layoutView.TemplateCard(2), LayoutGroup).CaptionImageLocation = GroupElementLocation.BeforeText
            layoutView.TemplateCard.EndUpdate()
        End Sub

        Private isDefault As Boolean = False

        Private Sub LoadDefaultLayout()
            If isDefault Then Return
            layoutView.OptionsBehavior.AllowSwitchViewModes = True
            If defaultXMLStream IsNot Nothing Then
                defaultXMLStream.Seek(0, SeekOrigin.Begin)
                layoutView.RestoreLayoutFromStream(defaultXMLStream)
            End If

            layoutView.OptionsBehavior.AllowExpandCollapse = True
            layoutView.OptionsView.ShowCardCaption = True
            gridControl1.UseEmbeddedNavigator = False
            isDefault = True
        End Sub

        Protected Property CustomizationPageVisible As Boolean
            Get
                Return navigationPane1.SelectedPageIndex = 0
            End Get

            Set(ByVal value As Boolean)
                navigationPane1.SelectedPageIndex = 0
            End Set
        End Property

        Protected Property SingleRecordPageVisible As Boolean
            Get
                Return navigationPane1.SelectedPageIndex = 1
            End Get

            Set(ByVal value As Boolean)
                navigationPane1.SelectedPageIndex = 1
            End Set
        End Property

        Protected Property MultiRecordPageVisible As Boolean
            Get
                Return navigationPane1.SelectedPageIndex = 2
            End Get

            Set(ByVal value As Boolean)
                navigationPane1.SelectedPageIndex = 2
            End Set
        End Property

        Protected Property CustomEventsPageVisible As Boolean
            Get
                Return navigationPane1.SelectedPageIndex = 3
            End Get

            Set(ByVal value As Boolean)
                navigationPane1.SelectedPageIndex = 3
            End Set
        End Property

        '<stretchWidth>
        Private Sub stretchWidth_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            layoutView.OptionsSingleRecordMode.StretchCardToViewWidth = stretchWidth.Checked
            cardAlignment.Enabled = Not stretchWidth.Checked Xor Not stretchHeight.Checked
        End Sub

        '</stretchWidth>
        '<stretchHeight>
        Private Sub stretchHeight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            layoutView.OptionsSingleRecordMode.StretchCardToViewHeight = stretchHeight.Checked
            cardAlignment.Enabled = Not stretchWidth.Checked Xor Not stretchHeight.Checked
        End Sub

        '</stretchHeight>
        '<cardAlignment>
        Private Sub cardAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            layoutView.OptionsSingleRecordMode.CardAlignment = CType(cardAlignment.EditValue, CardsAlignment)
        End Sub

        '</cardAlignment>
        '<stretchHeightM>
        Private Sub stretchHeightM_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            layoutView.OptionsMultiRecordMode.StretchCardToViewHeight = stretchHeightM.Checked
        End Sub

        '</stretchHeightM>
        '<stretchWidthM>
        Private Sub stretchWidthM_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            layoutView.OptionsMultiRecordMode.StretchCardToViewWidth = stretchWidthM.Checked
        End Sub

        '</stretchWidthM>
        '<spinEdit1>
        Private Sub spinEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            layoutView.OptionsMultiRecordMode.MaxCardColumns = CInt(spinEdit1.Value)
            stretchWidthM.Enabled = layoutView.OptionsMultiRecordMode.MaxCardColumns = 0
        End Sub

        '</spinEdit1>
        '<spinEdit2>
        Private Sub spinEdit2_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            layoutView.OptionsMultiRecordMode.MaxCardRows = CInt(spinEdit2.Value)
            stretchHeightM.Enabled = layoutView.OptionsMultiRecordMode.MaxCardRows = 0
        End Sub

        '</spinEdit2>
        '<imagesInCaptions>
        Private Sub imagesInCaptions_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            showCaptionImages = imagesInCaptions.Checked
            layoutView.Refresh()
        End Sub

        '</imagesInCaptions>
        '<imagesInFields>
        Private Sub imagesInFields_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            showFieldImages = imagesInFields.Checked
            layoutView.Refresh()
        End Sub

        '</imagesInFields>
        '<imagesOnlyForFocused>
        Private Sub imagesOnlyForFocused_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            showImagesInFocusedCardOnly = imagesOnlyForFocused.Checked
            layoutView.Refresh()
        End Sub

        '</imagesOnlyForFocused>
        '<multiSelect>
        Private Sub multiSelect_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            layoutView.OptionsSelection.MultiSelect = multiSelect.Checked
            layoutView.OptionsPrint.PrintSelectedCardsOnly = multiSelect.Checked
        End Sub

        '</multiSelect>
        '<photoVisibility>
        Private Sub photoVisibility_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            fieldPhotoCustomVisibility = photoVisibility.Checked
            layoutView.Refresh()
        End Sub

        '</photoVisibility>
        '<notesVisibility>
        Private Sub notesVisibility_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            fieldNotesCustomVisibility = notesVisibility.Checked
            layoutView.Refresh()
        End Sub

        '</notesVisibility>
        '<visibilityOnlyForFocused>
        Private Sub visibilityOnlyForFocused_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            contactInfoInFocusedCardOnly = visibilityOnlyForFocused.Checked
            layoutView.Refresh()
        End Sub

        '</visibilityOnlyForFocused>
        Private Sub advancedCustomization_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim value As Boolean = advancedCustomization.Checked
            layoutView.OptionsCustomization.UseAdvancedRuntimeCustomization = value
            customizationOptions.Enabled = value
        End Sub

        '<customizationOptions>
        Private Sub customizationOptionsList_ItemCheck(ByVal sender As Object, ByVal e As XtraEditors.Controls.ItemCheckEventArgs)
            If customizationOptions.Items.Count = 0 Then Return
            layoutView.OptionsCustomization.ShowGroupLayoutTreeView =(customizationOptions.Items(0).CheckState = CheckState.Checked)
            layoutView.OptionsCustomization.ShowGroupHiddenItems =(customizationOptions.Items(1).CheckState = CheckState.Checked)
            layoutView.OptionsCustomization.ShowResetShrinkButtons =(customizationOptions.Items(2).CheckState = CheckState.Checked)
            layoutView.OptionsCustomization.ShowGroupCardIndents =(customizationOptions.Items(3).CheckState = CheckState.Checked)
            layoutView.OptionsCustomization.ShowGroupCardCaptions =(customizationOptions.Items(4).CheckState = CheckState.Checked)
            layoutView.OptionsCustomization.ShowSaveLoadLayoutButtons =(customizationOptions.Items(5).CheckState = CheckState.Checked)
            layoutView.OptionsCustomization.ShowGroupView =(customizationOptions.Items(6).CheckState = CheckState.Checked)
            layoutView.OptionsCustomization.ShowGroupLayout =(customizationOptions.Items(7).CheckState = CheckState.Checked)
            layoutView.OptionsCustomization.ShowGroupCards =(customizationOptions.Items(8).CheckState = CheckState.Checked)
            layoutView.OptionsCustomization.ShowGroupFields =(customizationOptions.Items(9).CheckState = CheckState.Checked)
        End Sub

        '</customizationOptions>
#Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property
#End Region
    End Class
End Namespace
