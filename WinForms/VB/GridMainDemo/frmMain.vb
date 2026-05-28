Imports System.Drawing.Drawing2D
Imports DevExpress.Data.Filtering
Imports DevExpress.DXperience.Demos
Imports DevExpress.Tutorials
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Layout

Namespace DevExpress.XtraGrid.Demos

    Public Class frmMain
        Inherits DXperience.Demos.RibbonMainForm

        Private showOutdated As Boolean = False

        Public Sub New(ByVal arguments As String())
            MyBase.New(arguments)
            GetStartedLink = AssemblyInfo.DXLinkGetStartedWinGrid
            ToolTipController.DefaultController.ToolTipType = ToolTipType.SuperTip
            ToolTipController.DefaultController.Appearance.TextOptions.VAlignment = VertAlignment.Center
            Call DataHelper.LoadMessagesAsync()
        End Sub

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraGrid"
            End Get
        End Property

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return Properties.Resources.DemoName
            End Get
        End Property

        Protected Overrides ReadOnly Property FileType As SourceFileType
            Get
                Return DXperience.Demos.DemoHelper.GetSourceFileType()
            End Get
        End Property

        Protected Overrides Sub ShowAbout()
            Call GridControl.About()
        End Sub

        Protected Overrides Sub SetFormParam()
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraGrid.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
            Return New GridRibbonMenuManager(Me)
        End Function

        Public Overrides ReadOnly Property UseEmptyRootPadding As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As LookAndFeel.DefaultLookAndFeel)
            Call DemosInfo.ShowModule(name, group, TryCast(RibbonMenuManager, GridRibbonMenuManager))
        End Sub

        Protected Overrides ReadOnly Property NotTranslatedModuleTypes As String
            Get
                Return MyBase.NotTranslatedModuleTypes
            End Get
        End Property

        Protected Overrides Sub FillNavBar()
            ModulesInfo.FillAccordionControl(accordionControl1, XtraNavBar.NavBarGroupStyle.SmallIconsText, showOutdated)
        End Sub

        Protected Overrides Sub RegisterEnumTitles()
            MyBase.RegisterEnumTitles()
            EnumTitlesKeeper(Of FindMode).RegisterTitle(FindMode.Default, Properties.Resources.FindModeDefault)
            EnumTitlesKeeper(Of FindMode).RegisterTitle(FindMode.Always, Properties.Resources.FindModeAlways)
            EnumTitlesKeeper(Of FindMode).RegisterTitle(FindMode.FindClick, Properties.Resources.FindModeFindClick)
            EnumTitlesKeeper(Of WaitAnimationOptions).RegisterTitle(WaitAnimationOptions.Default, Properties.Resources.WaitAnimationOptionsDefault)
            EnumTitlesKeeper(Of WaitAnimationOptions).RegisterTitle(WaitAnimationOptions.Indicator, Properties.Resources.WaitAnimationOptionsIndicator)
            EnumTitlesKeeper(Of WaitAnimationOptions).RegisterTitle(WaitAnimationOptions.Panel, Properties.Resources.WaitAnimationOptionsPanel)
            Call EnumTitlesKeeper(Of TextEditStyles).RegisterTitle(TextEditStyles.Standard, Properties.Resources.TextEditStylesStandard)
            Call EnumTitlesKeeper(Of TextEditStyles).RegisterTitle(TextEditStyles.DisableTextEditor, Properties.Resources.TextEditStylesDisableTextEditor)
            Call EnumTitlesKeeper(Of TextEditStyles).RegisterTitle(TextEditStyles.HideTextEditor, Properties.Resources.TextEditStylesHideTextEditor)
            EnumTitlesKeeper(Of PopupFilterMode).RegisterTitle(PopupFilterMode.Default, Properties.Resources.PopupFilterModeDefault)
            EnumTitlesKeeper(Of PopupFilterMode).RegisterTitle(PopupFilterMode.Contains, Properties.Resources.PopupFilterModeContains)
            EnumTitlesKeeper(Of PopupFilterMode).RegisterTitle(PopupFilterMode.StartsWith, Properties.Resources.PopupFilterModeStartsWith)
            EnumTitlesKeeper(Of GroupFooterShowMode).RegisterTitle(GroupFooterShowMode.VisibleAlways, Properties.Resources.GroupFooterShowModeVisibleAlways)
            EnumTitlesKeeper(Of GroupFooterShowMode).RegisterTitle(GroupFooterShowMode.VisibleIfExpanded, Properties.Resources.GroupFooterShowModeVisibleIfExpanded)
            EnumTitlesKeeper(Of GroupFooterShowMode).RegisterTitle(GroupFooterShowMode.Hidden, Properties.Resources.GroupFooterShowModeHidden)
            EnumTitlesKeeper(Of GridMultiSelectMode).RegisterTitle(GridMultiSelectMode.CellSelect, Properties.Resources.CellSelect)
            EnumTitlesKeeper(Of GridMultiSelectMode).RegisterTitle(GridMultiSelectMode.RowSelect, Properties.Resources.RowSelect)
            EnumTitlesKeeper(Of GridMultiSelectMode).RegisterTitle(GridMultiSelectMode.CheckBoxRowSelect, "Check Box Row Select")
            EnumTitlesKeeper(Of GridAnimationType).RegisterTitle(GridAnimationType.Default, Properties.Resources.GridAnimationTypeDefault)
            EnumTitlesKeeper(Of GridAnimationType).RegisterTitle(GridAnimationType.AnimateAllContent, Properties.Resources.GridAnimationTypeAnimateAllContent)
            EnumTitlesKeeper(Of GridAnimationType).RegisterTitle(GridAnimationType.AnimateFocusedItem, Properties.Resources.GridAnimationTypeAnimateFocusedItem)
            EnumTitlesKeeper(Of GridAnimationType).RegisterTitle(GridAnimationType.NeverAnimate, Properties.Resources.GridAnimationTypeNeverAnimate)
            Call EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.Default, Properties.Resources.InterpolationModeDefault)
            Call EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.Low, Properties.Resources.InterpolationModeLow)
            Call EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.High, Properties.Resources.InterpolationModeHigh)
            Call EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.Bicubic, Properties.Resources.InterpolationModeBicubic)
            Call EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.Bilinear, Properties.Resources.InterpolationModeBilinear)
            Call EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.NearestNeighbor, Properties.Resources.InterpolationModeNearestNeighbor)
            Call EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.HighQualityBicubic, Properties.Resources.InterpolationModeHighQualityBicubic)
            Call EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.HighQualityBilinear, Properties.Resources.InterpolationModeHighQualityBilinear)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.Between, Properties.Resources.FormatConditionEnumBetween)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.Equal, Properties.Resources.FormatConditionEnumEqual)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.Greater, Properties.Resources.FormatConditionEnumGreater)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.GreaterOrEqual, Properties.Resources.FormatConditionEnumGreaterOrEqual)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.Less, Properties.Resources.FormatConditionEnumLess)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.LessOrEqual, Properties.Resources.FormatConditionEnumLessOrEqual)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.None, Properties.Resources.FormatConditionEnumNone)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.NotBetween, Properties.Resources.FormatConditionEnumNotBetween)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.NotEqual, Properties.Resources.FormatConditionEnumNotEqual)
            EnumTitlesKeeper(Of GroupDrawMode).RegisterTitle(GroupDrawMode.Default, Properties.Resources.GroupDrawModeDefault)
            EnumTitlesKeeper(Of GroupDrawMode).RegisterTitle(GroupDrawMode.Office2003, Properties.Resources.GroupDrawModeOffice2003)
            EnumTitlesKeeper(Of GroupDrawMode).RegisterTitle(GroupDrawMode.Standard, Properties.Resources.GroupDrawModeStandard)
            EnumTitlesKeeper(Of DefaultBoolean).RegisterTitle(DefaultBoolean.Default, Properties.Resources.DefaultBooleanDefault)
            EnumTitlesKeeper(Of DefaultBoolean).RegisterTitle(DefaultBoolean.False, Properties.Resources.DefaultBooleanFalse)
            EnumTitlesKeeper(Of DefaultBoolean).RegisterTitle(DefaultBoolean.True, Properties.Resources.DefaultBooleanTrue)
            EnumTitlesKeeper(Of FindPanelParserKind).RegisterTitle(FindPanelParserKind.And, "And")
            EnumTitlesKeeper(Of FindPanelParserKind).RegisterTitle(FindPanelParserKind.Default, "Default")
            EnumTitlesKeeper(Of FindPanelParserKind).RegisterTitle(FindPanelParserKind.Exact, "Exact")
            EnumTitlesKeeper(Of FindPanelParserKind).RegisterTitle(FindPanelParserKind.Mixed, "Mixed")
            EnumTitlesKeeper(Of FindPanelParserKind).RegisterTitle(FindPanelParserKind.Or, "Or")
            EnumTitlesKeeper(Of FilterCondition).RegisterTitle(FilterCondition.Contains, "Contains")
            EnumTitlesKeeper(Of FilterCondition).RegisterTitle(FilterCondition.Default, "Default")
            EnumTitlesKeeper(Of FilterCondition).RegisterTitle(FilterCondition.Equals, "Equals")
            EnumTitlesKeeper(Of FilterCondition).RegisterTitle(FilterCondition.Like, "Like")
            EnumTitlesKeeper(Of FilterCondition).RegisterTitle(FilterCondition.StartsWith, "StartsWith")
            ResourcesKeeper.RegisterTitle("AllowCellMerge", Properties.Resources.AllowCellMerge)
            ResourcesKeeper.RegisterTitle("AllowHtmlDrawGroups", Properties.Resources.AllowHtmlDrawGroups)
            ResourcesKeeper.RegisterTitle("AllowHtmlDrawHeaders", Properties.Resources.AllowHtmlDrawHeaders)
            ResourcesKeeper.RegisterTitle("AllowHtmlDrawDetailTabs", Properties.Resources.AllowHtmlDrawDetailTabs)
            ResourcesKeeper.RegisterTitle("AutoCalcPreviewLineCount", Properties.Resources.AutoCalcPreviewLineCount)
            ResourcesKeeper.RegisterTitle("ColumnAutoWidth", Properties.Resources.ColumnAutoWidth)
            ResourcesKeeper.RegisterTitle("EnableAppearanceEvenRow", Properties.Resources.EnableAppearanceEvenRow)
            ResourcesKeeper.RegisterTitle("EnableAppearanceOddRow", Properties.Resources.EnableAppearanceOddRow)
            ResourcesKeeper.RegisterTitle("RowAutoHeight", Properties.Resources.RowAutoHeight)
            ResourcesKeeper.RegisterTitle("ShowAutoFilterRow", Properties.Resources.ShowAutoFilterRow)
            ResourcesKeeper.RegisterTitle("ShowChildrenInGroupPanel", Properties.Resources.ShowChildrenInGroupPanel)
            ResourcesKeeper.RegisterTitle("ShowColumnHeaders", Properties.Resources.ShowColumnHeaders)
            ResourcesKeeper.RegisterTitle("ShowDetailButtons", Properties.Resources.ShowDetailButtons)
            ResourcesKeeper.RegisterTitle("ShowFooter", Properties.Resources.ShowFooter)
            ResourcesKeeper.RegisterTitle("ShowGroupedColumns", Properties.Resources.ShowGroupedColumns)
            ResourcesKeeper.RegisterTitle("ShowGroupExpandCollapseButtons", Properties.Resources.ShowGroupExpandCollapseButtons)
            ResourcesKeeper.RegisterTitle("ShowGroupPanel", Properties.Resources.ShowGroupPanel)
            ResourcesKeeper.RegisterTitle("ShowIndicator", Properties.Resources.ShowIndicator)
            ResourcesKeeper.RegisterTitle("ShowPreview", Properties.Resources.ShowPreview)
            ResourcesKeeper.RegisterTitle("ShowViewCaption", Properties.Resources.ShowViewCaption)
            ResourcesKeeper.RegisterTitle("ShowBands", Properties.Resources.ShowBands)
            ResourcesKeeper.RegisterTitle("ShowCardCaption", Properties.Resources.ShowCardCaption)
            ResourcesKeeper.RegisterTitle("ShowCardExpandButton", Properties.Resources.ShowCardExpandButton)
            ResourcesKeeper.RegisterTitle("ShowEmptyFields", Properties.Resources.ShowEmptyFields)
            ResourcesKeeper.RegisterTitle("ShowFieldCaptions", Properties.Resources.ShowFieldCaptions)
            ResourcesKeeper.RegisterTitle("ShowFieldHints", Properties.Resources.ShowFieldHints)
            ResourcesKeeper.RegisterTitle("ShowHorzScrollBar", Properties.Resources.ShowHorzScrollBar)
            ResourcesKeeper.RegisterTitle("ShowLines", Properties.Resources.ShowLines)
            ResourcesKeeper.RegisterTitle("ShowQuickCustomizeButton", Properties.Resources.ShowQuickCustomizeButton)
            ResourcesKeeper.RegisterTitle("EnableAppearanceFocusedCell", Properties.Resources.EnableAppearanceFocusedCell)
            ResourcesKeeper.RegisterTitle("EnableAppearanceFocusedRow", Properties.Resources.EnableAppearanceFocusedRow)
            ResourcesKeeper.RegisterTitle("EnableAppearanceHideSelection", Properties.Resources.EnableAppearanceHideSelection)
            ResourcesKeeper.RegisterTitle("InvertSelection", Properties.Resources.InvertSelection)
            ResourcesKeeper.RegisterTitle("MultiSelect", Properties.Resources.MultiSelect)
            ResourcesKeeper.RegisterTitle("AllowGlyphSkinning", "Allow Glyph Skinning")
            ResourcesKeeper.RegisterTitle("ShowGroupPanelColumnsAsSingleRow", "Show Group Panel Columns As Single Row")
            ResourcesKeeper.RegisterTitle("ResetSelectionClickOutsideCheckboxSelector", "Reset Selection Click Outside Checkbox Selector")
            ResourcesKeeper.RegisterTitle("UseIndicatorForSelection", Properties.Resources.UseIndicatorForSelection)
            Call EnumTitlesKeeper(Of CardsAlignment).RegisterTitle(CardsAlignment.Center, Properties.Resources.CardsAlignmentCenter)
            Call EnumTitlesKeeper(Of CardsAlignment).RegisterTitle(CardsAlignment.Near, Properties.Resources.CardsAlignmentNear)
            Call EnumTitlesKeeper(Of CardsAlignment).RegisterTitle(CardsAlignment.Far, Properties.Resources.CardsAlignmentFar)
            EnumTitlesKeeper(Of FixedStyle).RegisterTitle(FixedStyle.None, Properties.Resources.NotFixed)
            EnumTitlesKeeper(Of FixedStyle).RegisterTitle(FixedStyle.Left, Properties.Resources.FixedLeft)
            EnumTitlesKeeper(Of FixedStyle).RegisterTitle(FixedStyle.Right, Properties.Resources.FixedRight)
            EnumTitlesKeeper(Of FixedStyle).RegisterTitle(FixedStyle.MiddleLeft, Properties.Resources.MiddleLeft)
            EnumTitlesKeeper(Of GridEditingMode).RegisterTitle(GridEditingMode.EditFormInplace, "Edit Form Inplace")
            EnumTitlesKeeper(Of GridEditingMode).RegisterTitle(GridEditingMode.EditFormInplaceHideCurrentRow, "Edit Form Inplace Hide Current Row")
            EnumTitlesKeeper(Of GridEditingMode).RegisterTitle(GridEditingMode.EditForm, "Edit Form")
            EnumTitlesKeeper(Of EditFormModifiedAction).RegisterTitle(EditFormModifiedAction.Default, "Default")
            EnumTitlesKeeper(Of EditFormModifiedAction).RegisterTitle(EditFormModifiedAction.Cancel, "Cancel")
            EnumTitlesKeeper(Of EditFormModifiedAction).RegisterTitle(EditFormModifiedAction.Nothing, "Nothing")
            EnumTitlesKeeper(Of EditFormModifiedAction).RegisterTitle(EditFormModifiedAction.Save, "Save")
            EnumTitlesKeeper(Of EditFormBindingMode).RegisterTitle(EditFormBindingMode.Default, "Default")
            EnumTitlesKeeper(Of EditFormBindingMode).RegisterTitle(EditFormBindingMode.Cached, "Cached")
            EnumTitlesKeeper(Of EditFormBindingMode).RegisterTitle(EditFormBindingMode.Direct, "Direct")
            EnumTitlesKeeper(Of FilterEditorViewMode).RegisterTitle(FilterEditorViewMode.Text, "Text")
            EnumTitlesKeeper(Of FilterEditorViewMode).RegisterTitle(FilterEditorViewMode.TextAndVisual, "Text And Visual")
            EnumTitlesKeeper(Of FilterEditorViewMode).RegisterTitle(FilterEditorViewMode.Visual, "Visual")
            EnumTitlesKeeper(Of FilterEditorViewMode).RegisterTitle(FilterEditorViewMode.VisualAndText, "Visual And Text")
        End Sub
    End Class
End Namespace
