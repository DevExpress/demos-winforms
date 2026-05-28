Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Data.Filtering
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports System
Imports DevExpress.Data
Imports DevExpress.Utils.Colors
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class Office365UI
        Inherits TutorialControl

        Private UnreadTextColor As Color

        Public Sub New()
            InitializeComponent()
            gridControl1.DataSource = DataHelper.Messages
            colDate.SortOrder = ColumnSortOrder.Descending
            tileView1.FocusedRowHandle = 2
            biSortDate.Tag = "Date"
            biSortFrom.Tag = "From"
            biSortRead.Tag = "Read"
            biSortSubject.Tag = "SubjectDisplayText"
            biSortImportance.Tag = "Priority"
            AddHandler gridControl1.SizeChanged, Sub(s, e) CompactTemplate = gridControl1.Width <= 300
            If MainFormHelper.TakeScreens Then tileView1.AnimateArrival = False
            UpdateColors()
        End Sub

        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides Sub OnStyleChanged()
            MyBase.OnStyleChanged()
            UpdateColors()
        End Sub

        Private Sub UpdateColors()
            UnreadTextColor = DXSkinColorHelper.GetDXSkinColor(DXSkinColors.FillColors.Primary, LookAndFeel)
            tileView1.Appearance.GroupText.ForeColor = UnreadTextColor
            tileView1.Appearance.ItemFocused.BackColor = Color.FromArgb(40, UnreadTextColor)
            tileView1.Appearance.ItemHovered.BackColor = Color.FromArgb(40, UnreadTextColor)
            labelControl1.AppearanceDropDownPressed.ForeColor = UnreadTextColor
            labelControl1.AppearanceDropDownHovered.ForeColor = labelControl1.AppearanceDropDownPressed.ForeColor
            labelControl1.AppearanceDropDown.ForeColor = labelControl1.AppearanceDropDownHovered.ForeColor
            labelControl1.AppearancePressed.ForeColor = labelControl1.AppearanceDropDown.ForeColor
            labelControl1.AppearanceHovered.ForeColor = labelControl1.AppearancePressed.ForeColor
            labelControl1.Appearance.ForeColor = labelControl1.AppearanceHovered.ForeColor
        End Sub

        Private compact_Template As Boolean = False

        Private Property CompactTemplate As Boolean
            Get
                Return compact_Template
            End Get

            Set(ByVal value As Boolean)
                If compact_Template = value Then Return
                compact_Template = value
                tileView1.RefreshData()
            End Set
        End Property

        Private Sub tileView1_ItemCustomize(ByVal sender As Object, ByVal e As Views.Tile.TileViewItemCustomizeEventArgs)
            Dim msg As Message = TryCast(tileView1.GetRow(e.RowHandle), Message)
            If msg IsNot Nothing Then
                If msg.Read <> 1 Then
                    e.Item("Read").Appearance.Normal.BackColor = UnreadTextColor
                    e.Item("Date").Appearance.Normal.ForeColor = UnreadTextColor
                    e.Item("SubjectDisplayText").Appearance.Normal.ForeColor = UnreadTextColor
                    e.Item("SubjectDisplayText").Appearance.Normal.FontStyleDelta = FontStyle.Bold
                End If
            End If
        End Sub

        Private Sub tileView1_ContextButtonCustomize(ByVal sender As Object, ByVal e As Views.Tile.TileViewContextButtonCustomizeEventArgs)
            Dim msg As Message = TryCast(tileView1.GetRow(e.RowHandle), Message)
            If msg IsNot Nothing Then
                If Equals(e.Item.Name, "cbExclamation") Then
                    e.Item.AllowGlyphSkinning = DefaultBoolean.False
                    e.Item.Visibility = If(msg.Priority = 2, ContextItemVisibility.Visible, ContextItemVisibility.Hidden)
                Else
                    e.Item.AllowGlyphSkinning = DefaultBoolean.True
                    e.Item.AppearanceNormal.ForeColor = CType(tileView1.GetViewInfo(), ITileControl).ViewInfo.AppearanceText.ForeColor
                    e.Item.AppearanceHover.ForeColor = e.Item.AppearanceNormal.ForeColor
                End If
            Else
                e.Item.Visibility = ContextItemVisibility.Hidden
            End If
        End Sub

        Private Sub tileView1_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs)
            If tileView1.FocusedRowHandle >= 0 Then
                CurrentMessage = TryCast(tileView1.GetFocusedRow(), Message)
            Else
                CurrentMessage = Nothing
            End If
        End Sub

        Private current_Message As Message

        Private Property CurrentMessage As Message
            Get
                Return current_Message
            End Get

            Set(ByVal value As Message)
                If current_Message Is value Then Return
                current_Message = value
                office365MailViewer.ShowMessage(CurrentMessage)
            End Set
        End Property

        Private Sub OnFilterItemCheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If Not CType(e.Item, BarCheckItem).Checked Then Return
            CType(tileView1.GetViewInfo(), ITileControl).AnimateArrival = True
            If e.Item Is bcFilterAll Then
                tileView1.ClearColumnsFilter()
            ElseIf e.Item Is bcFilterUnread Then
                tileView1.ActiveFilterCriteria = New BinaryOperator("Read", 0, BinaryOperatorType.Equal)
            ElseIf e.Item Is bcFilterToday Then
                tileView1.ActiveFilterCriteria = New BetweenOperator("Date", TutorialConstants.Today.Date, Date.Today.Date.AddHours(24))
            ElseIf e.Item Is bcFilterYesterday Then
                tileView1.ActiveFilterCriteria = New BetweenOperator("Date", TutorialConstants.Today.Date.AddHours(-24), Date.Today.Date)
            ElseIf e.Item Is bcFilterImportance Then
                tileView1.ActiveFilterCriteria = New BinaryOperator("Priority", 2, BinaryOperatorType.Equal)
            End If
        End Sub

        Private Sub SortBy(ByVal fieldName As String, ByVal sort As ColumnSortOrder)
            CType(tileView1.GetViewInfo(), ITileControl).AnimateArrival = True
            tileView1.SortInfo.Clear()
            tileView1.SortInfo.Add(New Columns.GridColumnSortInfo(tileView1.Columns(fieldName), sort))
        End Sub

        Private Sub OnSortItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            popupMenu1.BeginUpdate()
            Try
                If e.Item.ImageIndex = -1 Then
                    biSortDate.ImageIndex = -1
                    biSortFrom.ImageIndex = -1
                    biSortRead.ImageIndex = -1
                    biSortSubject.ImageIndex = -1
                    biSortImportance.ImageIndex = -1
                    e.Item.ImageIndex = 0
                Else
                    e.Item.ImageIndex = If(e.Item.ImageIndex = 1, 0, 1)
                End If

                SortBy(CStr(e.Item.Tag), If(e.Item.ImageIndex = 1, ColumnSortOrder.Ascending, ColumnSortOrder.Descending))
            Finally
                popupMenu1.EndUpdate()
            End Try
        End Sub

        Private Sub tileView1_CustomItemTemplate(ByVal sender As Object, ByVal e As Views.Tile.TileViewCustomItemTemplateEventArgs)
            If CompactTemplate Then e.Template = e.Templates("smallsize")
        End Sub

        Private Sub toggleAutoHeight_Toggled(ByVal sender As Object, ByVal e As EventArgs)
            Dim elementPlainText = tileView1.TileTemplate(2)
            If toggleAutoHeight.IsOn Then
                tileView1.TileRows(0).AutoHeight = True
                tileView1.TileRows(1).AutoHeight = True
                tileView1.TileRows(2).AutoHeight = True
                elementPlainText.Appearance.Normal.TextOptions.WordWrap = WordWrap.Wrap
            Else
                tileView1.TileRows(0).AutoHeight = False
                tileView1.TileRows(1).AutoHeight = False
                tileView1.TileRows(2).AutoHeight = False
                elementPlainText.Appearance.Normal.TextOptions.WordWrap = WordWrap.NoWrap
            End If
        End Sub
    End Class
End Namespace
