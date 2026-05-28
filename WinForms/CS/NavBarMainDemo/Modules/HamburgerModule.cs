using System;
using System.Drawing;
using DevExpress.Data.Filtering;
using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Colors;
using DevExpress.Utils.VisualEffects;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.XtraNavBar.Demos {
    public partial class HamburgerModule : TutorialControl {

        Badge calendarBadge = new Badge();
        Badge emailsBadge = new Badge();
        Badge emailItemBadge = new Badge();

        public HamburgerModule() {
            InitializeComponent();
            ((ITileControl)this.tileViewMail.GetViewInfo()).AnimateArrival = false;
            gridControlMail.DataSource = DataHelper.Messages;
            gridControlPeople.DataSource = DataHelper.Employees;
            dataLayoutControl1.DataSource = gridControlPeople.DataSource;
            this.colDate.SortOrder = Data.ColumnSortOrder.Descending;
            tileViewMail.FocusedRowHandle = 2;
            this.gridControlMail.SizeChanged += (s, e) => { CompactTemplate = gridControlMail.Width <= ScaleDPI.ScaleHorizontal(300); };
            AssignPeopleFilter();
            filterMailElement = allElement;
            UpdateColors();
            InitializeAdorners();
            this.accordionControl1.StateChanged += (s, e) => UpdateAdorners();
        }

        private void InitializeAdorners() {
            adornerUIManager1.Elements.Clear();

            calendarBadge.TargetElement = calendarElement;
            calendarBadge.Properties.Location = ContentAlignment.TopRight;
            calendarBadge.Properties.Offset = new Point(-10, 15);
            calendarBadge.Properties.PaintStyle = BadgePaintStyle.Warning;

            emailsBadge.TargetElement = mailElement;
            emailsBadge.Properties.Location = ContentAlignment.TopRight;
            emailsBadge.Properties.Offset = new Point(-10, 15);

            emailItemBadge.TargetElement = accordionControlElement4;

            adornerUIManager1.Elements.Add(calendarBadge);
            adornerUIManager1.Elements.Add(emailsBadge);
            adornerUIManager1.Elements.Add(emailItemBadge);

            UpdateAdorners();
        }
        private void UpdateAdorners() {
            emailItemBadge.Properties.Offset = new Point(accordionControl1.OptionsMinimizing.State == AccordionControlState.Minimized  ? 0 : - 25, 0);
            emailItemBadge.Properties.Location = accordionControl1.OptionsMinimizing.State == AccordionControlState.Minimized  ? ContentAlignment.TopRight : ContentAlignment.MiddleRight;
            emailsBadge.Properties.Text = "3"; // Set the actual number of unread emails
            emailItemBadge.Properties.Text = "3"; // Set the actual number of unread emails
        }

        private void accordionControl1_CustomDrawElement(object sender, CustomDrawElementEventArgs e) {
            if(e.ObjectInfo.Element == filterPeopleElement || e.ObjectInfo.Element == filterMailElement) {
                e.Handled = true;
                e.DrawHeaderBackground();
                e.DrawText();
                e.Cache.FillRectangle(e.ObjectInfo.PaintAppearance.ForeColor, new Rectangle(e.ObjectInfo.HeaderBounds.Location, new Size(ScaleHelper.ScaleHorizontal(3), e.ObjectInfo.HeaderBounds.Height)));
            }
        }

        private void accordionControlElementSetting_Click(object sender, EventArgs e) {
            flyoutPanel1.ShowPopup();
        }

        private void footerElement_Click(object sender, EventArgs e) {
            navigationFrame1.SelectedPageIndex = accordionControl1.Elements.IndexOf(sender as AccordionControlElement);
        }

        private void tileViewMail_CustomItemTemplate(object sender, XtraGrid.Views.Tile.TileViewCustomItemTemplateEventArgs e) {
            if(CompactTemplate)
                e.Template = e.Templates["smallsize"];
        }

        protected override void OnStyleChanged() {
            base.OnStyleChanged();
            UpdateColors();
        }
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            if(!IsHandleCreated || IsDisposed) return;
            if(Width < ScaleHelper.ScaleHorizontal(850)) {
                accordionControl1.OptionsHamburgerMenu.DisplayMode = AccordionControlDisplayMode.Overlay;
            }
            else {
                accordionControl1.OptionsHamburgerMenu.DisplayMode = AccordionControlDisplayMode.Inline;
            }
        }

        #region Mail
        private void tileViewMail_ContextButtonCustomize(object sender, XtraGrid.Views.Tile.TileViewContextButtonCustomizeEventArgs e) {
            if(e.Item.Name == "cbExclamation") {
                bool priority = (int)tileViewMail.GetRowCellValue(e.RowHandle, colPriority) == 2;
                e.Item.Visibility = priority ? ContextItemVisibility.Visible : ContextItemVisibility.Hidden;
            }
        }
        Color UnreadTextColor;
        void UpdateColors() {
            UnreadTextColor = DXSkinColorHelper.GetDXSkinColor(DXSkinColors.FillColors.Primary, LookAndFeel);
            this.tileViewMail.Appearance.ItemFocused.BackColor = Color.FromArgb(40, UnreadTextColor);
            this.tileViewMail.Appearance.ItemHovered.BackColor = Color.FromArgb(40, UnreadTextColor);
        }
        bool compactTemplateCore = false;
        bool CompactTemplate {
            get { return compactTemplateCore; }
            set {
                if(compactTemplateCore == value) return;
                compactTemplateCore = value;
                tileViewMail.RefreshData();
            }
        }

        private void tileView1_ItemCustomize(object sender, XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e) {
            bool isRead = (int)tileViewMail.GetRowCellValue(e.RowHandle, colRead) == 1;
            if(!isRead) {
                e.Item["Read"].Appearance.Normal.BackColor = UnreadTextColor;
            }
        }
        AccordionControlElement filterMailElement = null;
        private void aceMailFilter_Click(object sender, EventArgs e) {
            filterMailElement = sender as AccordionControlElement;
            if(sender == allElement) {
                this.tileViewMail.ClearColumnsFilter();
            }
            else if(sender == this.readElement) {
                this.tileViewMail.ActiveFilterCriteria = new BinaryOperator("Read", 0, BinaryOperatorType.Equal);
            }
            else if(sender == this.todayElement) {
                this.tileViewMail.ActiveFilterCriteria = new BetweenOperator("Date", TutorialConstants.Today.Date, TutorialConstants.Today.Date.AddHours(24));
            }
            else if(sender == this.yesterdayElement) {
                this.tileViewMail.ActiveFilterCriteria = new BetweenOperator("Date", TutorialConstants.Today.Date.AddHours(-24), TutorialConstants.Today.Date);
            }
            else if(sender == this.importanceElement) {
                this.tileViewMail.ActiveFilterCriteria = new BinaryOperator("Priority", 2, BinaryOperatorType.Equal);
            }
        }
        private void tileViewMail_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            if(tileViewMail.FocusedRowHandle >= 0)
                CurrentMessage = tileViewMail.GetFocusedRow() as Message;
            else {
                CurrentMessage = null;
            }
        }
        Message currentMessageCore;
        Message CurrentMessage {
            get { return currentMessageCore; }
            set {
                if(currentMessageCore == value) return;
                currentMessageCore = value;
                office365MailViewer.ShowMessage(CurrentMessage);
            }
        }
        #endregion

        #region People
        private void contactItemsClick(object sender, EventArgs e) {
            AccordionControlElement element = sender as AccordionControlElement;
            if(element != null && element.ContextButtons.Count == 1) {
                AccordionCheckContextButton checkButton = element.ContextButtons[0] as AccordionCheckContextButton;
                if(checkButton != null)
                    checkButton.Checked = !checkButton.Checked;
            }
        }
        void ContextButtonCustomize(object sender, AccordionControlContextButtonCustomizeEventArgs e) {
            AccordionControlViewInfo viewInfo = (AccordionControlViewInfo)accordionControl1.GetViewInfo();
            Color _foreColor = viewInfo.GetElementInfo(e.Element).PaintAppearance.ForeColor;
            e.ContextItem.AppearanceNormal.ForeColor = e.ContextItem.AppearanceHover.ForeColor = _foreColor;
        }
        AccordionControlElement filterPeopleElement = null;
        void aceFilterContact_Click(object sender, EventArgs e) {
            filterPeopleElement = sender as AccordionControlElement;
            if(filterPeopleElement == aceAllFilterContact) 
                this.tileViewPeople.ClearColumnsFilter();            
            else
                this.tileViewPeople.ActiveFilterCriteria = new BinaryOperator("Department", filterPeopleElement.Tag, BinaryOperatorType.Equal);
        }
        private void AssignPeopleFilter() {
            filterPeopleElement = aceAllFilterContact;
            aceSalesFilterContact.Tag = DevAV.EmployeeDepartment.Sales;
            aceSupportFilterContact.Tag = DevAV.EmployeeDepartment.Support;
            aceShippingFilterContact.Tag = DevAV.EmployeeDepartment.Shipping;
            aceEngineeringFilterContact.Tag = DevAV.EmployeeDepartment.Engineering;
            aceHRFilterContact.Tag = DevAV.EmployeeDepartment.HumanResources;
            aceManagementFilterContact.Tag = DevAV.EmployeeDepartment.Management;
            aceITFilterContact.Tag = DevAV.EmployeeDepartment.IT;
        }
        #endregion
    }
}
