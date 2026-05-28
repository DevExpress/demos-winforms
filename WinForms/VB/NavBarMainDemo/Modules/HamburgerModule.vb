Imports System
Imports System.Drawing
Imports DevExpress.Data.Filtering
Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.Utils.Colors
Imports DevExpress.Utils.VisualEffects
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.XtraNavBar.Demos

    Public Partial Class HamburgerModule
        Inherits TutorialControl

        Private calendarBadge As Badge = New Badge()

        Private emailsBadge As Badge = New Badge()

        Private emailItemBadge As Badge = New Badge()

        Public Sub New()
            InitializeComponent()
            CType(tileViewMail.GetViewInfo(), ITileControl).AnimateArrival = False
            gridControlMail.DataSource = DataHelper.Messages
            gridControlPeople.DataSource = DataHelper.Employees
            dataLayoutControl1.DataSource = gridControlPeople.DataSource
            colDate.SortOrder = Data.ColumnSortOrder.Descending
            tileViewMail.FocusedRowHandle = 2
            AddHandler gridControlMail.SizeChanged, Sub(s, e) CompactTemplate = gridControlMail.Width <= ScaleDPI.ScaleHorizontal(300)
            AssignPeopleFilter()
            filterMailElement = allElement
            UpdateColors()
            InitializeAdorners()
            AddHandler accordionControl1.StateChanged, Sub(s, e) UpdateAdorners()
        End Sub

        Private Sub InitializeAdorners()
            adornerUIManager1.Elements.Clear()
            calendarBadge.TargetElement = calendarElement
            calendarBadge.Properties.Location = ContentAlignment.TopRight
            calendarBadge.Properties.Offset = New Point(-10, 15)
            calendarBadge.Properties.PaintStyle = BadgePaintStyle.Warning
            emailsBadge.TargetElement = mailElement
            emailsBadge.Properties.Location = ContentAlignment.TopRight
            emailsBadge.Properties.Offset = New Point(-10, 15)
            emailItemBadge.TargetElement = accordionControlElement4
            adornerUIManager1.Elements.Add(calendarBadge)
            adornerUIManager1.Elements.Add(emailsBadge)
            adornerUIManager1.Elements.Add(emailItemBadge)
            UpdateAdorners()
        End Sub

        Private Sub UpdateAdorners()
            emailItemBadge.Properties.Offset = New Point(If(accordionControl1.OptionsMinimizing.State = AccordionControlState.Minimized, 0, -25), 0)
            emailItemBadge.Properties.Location = If(accordionControl1.OptionsMinimizing.State = AccordionControlState.Minimized, ContentAlignment.TopRight, ContentAlignment.MiddleRight)
            emailsBadge.Properties.Text = "3" ' Set the actual number of unread emails
            emailItemBadge.Properties.Text = "3" ' Set the actual number of unread emails
        End Sub

        Private Sub accordionControl1_CustomDrawElement(ByVal sender As Object, ByVal e As CustomDrawElementEventArgs)
            If e.ObjectInfo.Element Is filterPeopleElement OrElse e.ObjectInfo.Element Is filterMailElement Then
                e.Handled = True
                e.DrawHeaderBackground()
                e.DrawText()
                e.Cache.FillRectangle(e.ObjectInfo.PaintAppearance.ForeColor, New Rectangle(e.ObjectInfo.HeaderBounds.Location, New Size(ScaleHelper.ScaleHorizontal(3), e.ObjectInfo.HeaderBounds.Height)))
            End If
        End Sub

        Private Sub accordionControlElementSetting_Click(ByVal sender As Object, ByVal e As EventArgs)
            flyoutPanel1.ShowPopup()
        End Sub

        Private Sub footerElement_Click(ByVal sender As Object, ByVal e As EventArgs)
            navigationFrame1.SelectedPageIndex = accordionControl1.Elements.IndexOf(TryCast(sender, AccordionControlElement))
        End Sub

        Private Sub tileViewMail_CustomItemTemplate(ByVal sender As Object, ByVal e As XtraGrid.Views.Tile.TileViewCustomItemTemplateEventArgs)
            If CompactTemplate Then e.Template = e.Templates("smallsize")
        End Sub

        Protected Overrides Sub OnStyleChanged()
            MyBase.OnStyleChanged()
            UpdateColors()
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)
            If Not IsHandleCreated OrElse IsDisposed Then Return
            If Width < ScaleHelper.ScaleHorizontal(850) Then
                accordionControl1.OptionsHamburgerMenu.DisplayMode = AccordionControlDisplayMode.Overlay
            Else
                accordionControl1.OptionsHamburgerMenu.DisplayMode = AccordionControlDisplayMode.Inline
            End If
        End Sub

#Region "Mail"
        Private Sub tileViewMail_ContextButtonCustomize(ByVal sender As Object, ByVal e As XtraGrid.Views.Tile.TileViewContextButtonCustomizeEventArgs)
            If Equals(e.Item.Name, "cbExclamation") Then
                Dim priority As Boolean = CInt(tileViewMail.GetRowCellValue(e.RowHandle, colPriority)) = 2
                e.Item.Visibility = If(priority, ContextItemVisibility.Visible, ContextItemVisibility.Hidden)
            End If
        End Sub

        Private UnreadTextColor As Color

        Private Sub UpdateColors()
            UnreadTextColor = DXSkinColorHelper.GetDXSkinColor(DXSkinColors.FillColors.Primary, LookAndFeel)
            tileViewMail.Appearance.ItemFocused.BackColor = Color.FromArgb(40, UnreadTextColor)
            tileViewMail.Appearance.ItemHovered.BackColor = Color.FromArgb(40, UnreadTextColor)
        End Sub

        Private compactTemplateCore As Boolean = False

        Private Property CompactTemplate As Boolean
            Get
                Return compactTemplateCore
            End Get

            Set(ByVal value As Boolean)
                If compactTemplateCore = value Then Return
                compactTemplateCore = value
                tileViewMail.RefreshData()
            End Set
        End Property

        Private Sub tileView1_ItemCustomize(ByVal sender As Object, ByVal e As XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs)
            Dim isRead As Boolean = CInt(tileViewMail.GetRowCellValue(e.RowHandle, colRead)) = 1
            If Not isRead Then
                e.Item("Read").Appearance.Normal.BackColor = UnreadTextColor
            End If
        End Sub

        Private filterMailElement As AccordionControlElement = Nothing

        Private Sub aceMailFilter_Click(ByVal sender As Object, ByVal e As EventArgs)
            filterMailElement = TryCast(sender, AccordionControlElement)
            If sender Is allElement Then
                tileViewMail.ClearColumnsFilter()
            ElseIf sender Is readElement Then
                tileViewMail.ActiveFilterCriteria = New BinaryOperator("Read", 0, BinaryOperatorType.Equal)
            ElseIf sender Is todayElement Then
                tileViewMail.ActiveFilterCriteria = New BetweenOperator("Date", TutorialConstants.Today.Date, TutorialConstants.Today.Date.AddHours(24))
            ElseIf sender Is yesterdayElement Then
                tileViewMail.ActiveFilterCriteria = New BetweenOperator("Date", TutorialConstants.Today.Date.AddHours(-24), TutorialConstants.Today.Date)
            ElseIf sender Is importanceElement Then
                tileViewMail.ActiveFilterCriteria = New BinaryOperator("Priority", 2, BinaryOperatorType.Equal)
            End If
        End Sub

        Private Sub tileViewMail_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs)
            If tileViewMail.FocusedRowHandle >= 0 Then
                CurrentMessage = TryCast(tileViewMail.GetFocusedRow(), Message)
            Else
                CurrentMessage = Nothing
            End If
        End Sub

        Private currentMessageCore As Message

        Private Property CurrentMessage As Message
            Get
                Return currentMessageCore
            End Get

            Set(ByVal value As Message)
                If currentMessageCore Is value Then Return
                currentMessageCore = value
                office365MailViewer.ShowMessage(CurrentMessage)
            End Set
        End Property

#End Region
#Region "People"
        Private Sub contactItemsClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim element As AccordionControlElement = TryCast(sender, AccordionControlElement)
            If element IsNot Nothing AndAlso element.ContextButtons.Count = 1 Then
                Dim checkButton As AccordionCheckContextButton = TryCast(element.ContextButtons(0), AccordionCheckContextButton)
                If checkButton IsNot Nothing Then checkButton.Checked = Not checkButton.Checked
            End If
        End Sub

        Private Sub ContextButtonCustomize(ByVal sender As Object, ByVal e As AccordionControlContextButtonCustomizeEventArgs)
            Dim viewInfo As AccordionControlViewInfo = CType(accordionControl1.GetViewInfo(), AccordionControlViewInfo)
            Dim _foreColor As Color = viewInfo.GetElementInfo(e.Element).PaintAppearance.ForeColor
            e.ContextItem.AppearanceHover.ForeColor = _foreColor
            e.ContextItem.AppearanceNormal.ForeColor = e.ContextItem.AppearanceHover.ForeColor
        End Sub

        Private filterPeopleElement As AccordionControlElement = Nothing

        Private Sub aceFilterContact_Click(ByVal sender As Object, ByVal e As EventArgs)
            filterPeopleElement = TryCast(sender, AccordionControlElement)
            If filterPeopleElement Is aceAllFilterContact Then
                tileViewPeople.ClearColumnsFilter()
            Else
                tileViewPeople.ActiveFilterCriteria = New BinaryOperator("Department", filterPeopleElement.Tag, BinaryOperatorType.Equal)
            End If
        End Sub

        Private Sub AssignPeopleFilter()
            filterPeopleElement = aceAllFilterContact
            aceSalesFilterContact.Tag = DevAV.EmployeeDepartment.Sales
            aceSupportFilterContact.Tag = DevAV.EmployeeDepartment.Support
            aceShippingFilterContact.Tag = DevAV.EmployeeDepartment.Shipping
            aceEngineeringFilterContact.Tag = DevAV.EmployeeDepartment.Engineering
            aceHRFilterContact.Tag = DevAV.EmployeeDepartment.HumanResources
            aceManagementFilterContact.Tag = DevAV.EmployeeDepartment.Management
            aceITFilterContact.Tag = DevAV.EmployeeDepartment.IT
        End Sub
#End Region
    End Class
End Namespace
