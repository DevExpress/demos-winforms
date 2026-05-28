using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Drawing;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using System.Linq;

namespace DevExpress.DevAV.Common.Utils {
    static class FluentIconHelper {
        static ReadOnlyDictionary<string, string> IconNameMap = new ReadOnlyDictionary<string, string>(CreateIconNameMap());

        private static Dictionary<string, string> CreateIconNameMap() {
            return new Dictionary<string, string> {
                #region Common
                { "resource://DevExpress.DevAV.Resources.About.svg", "resource://DevExpress.DevAV.Resources.Fluent.Common.Home.info-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.GettingStarted.svg", "resource://DevExpress.DevAV.Resources.Fluent.Common.Home.numbers-circle-fluent-light-black-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Support.svg", "resource://DevExpress.DevAV.Resources.Fluent.Common.Home.person-support-fluent-light-green-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Buy.svg", "resource://DevExpress.DevAV.Resources.Fluent.Common.Home.cart-fluent-light-black-16.svg" },
                { "resource://DevExpress.DevAV.Resources.icon-reading-bottom-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.panel-left-eye-fluent-light-blue-16.svg"},
                { "resource://DevExpress.DevAV.Resources.icon-normal-bottom-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Common.View.panel-left-fill-fluent-light-blue-16.svg"},

                { "resource://DevExpress.DevAV.Resources.Navigation.svg", "resource://DevExpress.DevAV.Resources.Fluent.Common.View.compass-fluent-light-red-16.svg" },
                { "resource://DevExpress.DevAV.Resources.FolderPanel2.svg", "resource://DevExpress.DevAV.Resources.Fluent.Common.View.panel-branch-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.panel-left-fill-dx_desktop-regular-blue-16.svg", "resource://DevExpress.DevAV.Resources.Fluent.Common.View.panel-left-fill-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.panel-left-eye-off-dx_desktop-regular-black-16.svg", "resource://DevExpress.DevAV.Resources.Fluent.Common.View.panel-left-eye-off-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.panel-left-minimized-fill-dx_desktop-regular-blue-16.svg", "resource://DevExpress.DevAV.Resources.Fluent.Common.View.panel-left-minimized-fill-fluent-light-blue-16.svg" },
                #endregion
                #region Navigation Accordion
                { "business%20objects/bo_position;Size16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Accordion.people-community-fluent-light-blue-32.svg"},
                { "business%20objects/bo_position" , "resource://DevExpress.DevAV.Resources.Fluent.Accordion.people-community-fluent-light-blue-32.svg"},
                { "business%20objects/bo_customer;Size16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Accordion.person-case-fluent-light-green-32.svg"},
                { "business%20objects/bo_customer" , "resource://DevExpress.DevAV.Resources.Fluent.Accordion.person-case-fluent-light-green-32.svg"},
                { "business%20objects/bo_sale;Size16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Accordion.cart-coins-fluent-light-yellow-32.svg"},
                { "business%20objects/bo_sale" , "resource://DevExpress.DevAV.Resources.Fluent.Accordion.cart-coins-fluent-light-yellow-32.svg"},
                { "business%20objects/bo_opportunity;Size16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Accordion.arrow-tranding-up-fluent-light-green-32.svg"},
                { "business%20objects/bo_opportunity" , "resource://DevExpress.DevAV.Resources.Fluent.Accordion.arrow-tranding-up-fluent-light-green-32.svg"},
                { "business%20objects/bo_product;Size16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Accordion.box-fluent-light-black-32.svg"},
                { "business%20objects/bo_product" , "resource://DevExpress.DevAV.Resources.Fluent.Accordion.box-fluent-light-black-32.svg"},
                #endregion 
                #region Controls
                { "resource://DevExpress.DevAV.Resources.icon-print-42x40.png", "resource://DevExpress.DevAV.Resources.Fluent.Controls.print-fluent-light-black-32.svg" },
                { "resource://DevExpress.DevAV.Resources.icon-export-40.png", "resource://DevExpress.DevAV.Resources.Fluent.Controls.save-export-fluent-light-green-32.svg" },

                { "resource://DevExpress.DevAV.Resources.SortDesc.svg", "resource://DevExpress.DevAV.Resources.Fluent.Controls.arrow-sort-down-lines-fluent-light-blue-32.svg" },
                { "resource://DevExpress.DevAV.Resources.SortAsc.svg", "resource://DevExpress.DevAV.Resources.Fluent.Controls.arrow-sort-up-lines-fluent-light-blue-32.svg" },

                { "resource://DevExpress.DevAV.Resources.PrintIncludeEvaluations.svg", "resource://DevExpress.DevAV.Resources.Fluent.Controls.document-page-lines-columns-fluent-light-blue-32.svg" },
                { "resource://DevExpress.DevAV.Resources.PrintExcludeEvaluations.svg", "resource://DevExpress.DevAV.Resources.Fluent.Controls.document-page-lines-fluent-light-black-32.svg" },

                { "resource://DevExpress.DevAV.Resources.ShowProduct.svg", "resource://DevExpress.DevAV.Resources.Fluent.Controls.list-items-fluent-light-blue-32.svg" },
                { "resource://DevExpress.DevAV.Resources.HideProduct.svg", "resource://DevExpress.DevAV.Resources.Fluent.Controls.list-items-fluent-light-black-32.svg" },

                { "resource://DevExpress.DevAV.Resources.SortByOrderDate.svg", "resource://DevExpress.DevAV.Resources.Fluent.Controls.calendar-sort-arrow-down-fluent-light-mixed_color-32.svg" },
                { "resource://DevExpress.DevAV.Resources.SortByInvoice.svg", "resource://DevExpress.DevAV.Resources.Fluent.Controls.arrow-sort-down-invoice-fluent-light-blue-32.svg" },

                { "resource://DevExpress.DevAV.Resources.ShowDueDate.svg", "resource://DevExpress.DevAV.Resources.Fluent.Controls.calendar-due-date-fluent-light-red-32.svg" },
                { "resource://DevExpress.DevAV.Resources.ShowStartDate.svg", "resource://DevExpress.DevAV.Resources.Fluent.Controls.calendar-timer-fluent-light-red-32.svg" },


                #endregion
                #region Employees
                { "resource://DevExpress.DevAV.Resources.icon-prefix-16.png", "resource://DevExpress.DevAV.Resources.Fluent.Employees.people-fluent-light-black-16.svg" },
                { "resource://DevExpress.DevAV.Resources.NewEmploye.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.person-add-fluent-light-mixed_color-16.svg" },
                { "resource://DevExpress.DevAV.Resources.NewEmploye.svg?Size=16x16", "resource://DevExpress.DevAV.Resources.Fluent.Employees.person-add-fluent-light-mixed_color-16.svg" },
                { "resource://DevExpress.DevAV.Resources.NewGroup.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.people-fluent-light-black-16.svg" },
                { "resource://DevExpress.DevAV.Resources.NewGroup.svg?Size=16x16", "resource://DevExpress.DevAV.Resources.Fluent.Employees.people-fluent-light-black-16.svg" },
                { "resource://DevExpress.DevAV.Resources.NewItem.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.person-more-fluent-light-yellow-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Delete.svg", "resource:/DevExpress.DevAV.Resources.Fluent.dismiss-fluent-light-red-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Edit.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.edit-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Print.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.print-fluent-light-black-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Meeting.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.calendar-person-fluent-light-mixed_color-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Task.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.clipboard-task-list-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.MailMerge.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.mail-merge-fluent-light-yellow-16.svg" },
                { "business%20objects/bo_document", "resource://DevExpress.DevAV.Resources.Fluent.document-data-lightning-fluent-light-mixed_color-16.svg" },
                { "resource://DevExpress.DevAV.Resources.List.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.list-items-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Card.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.contact-card-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Mapit.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.location-fluent-light-red-16.svg" },

                { "resource://DevExpress.DevAV.Resources.ChangeView.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.arrow-sync-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Filter.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.filter-funnel-fluent-light-yellow-16.svg" },
                { "resource://DevExpress.DevAV.Resources.List.svg?Size=32x32", "resource://DevExpress.DevAV.Resources.Fluent.Employees.list-items-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Card.svg?Size=32x32", "resource://DevExpress.DevAV.Resources.Fluent.Employees.contact-card-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.ViewSetting.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.settings-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.ResetView.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.arrow-counterclockwise-fluent-light-green-16.svg" },
                { "resource://DevExpress.DevAV.Resources.DataPanel.svg", "resource://DevExpress.DevAV.Resources.Fluent.Common.View.panel-data-text-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.PanelRight.svg?Size=16x16", "resource://DevExpress.DevAV.Resources.Fluent.Common.View.panel-right-fill-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.PanelBottom.svg?Size=16x16", "resource://DevExpress.DevAV.Resources.Fluent.Common.View.panel-bottom-fill-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.PanelOff.svg?Size=16x16", "resource://DevExpress.DevAV.Resources.Fluent.Common.View.panel-right-eye-off-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.ReversSort.svg?Size=16x16", "resource://DevExpress.DevAV.Resources.Fluent.Employees.arrow-sort-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.AddColumn.svg?Size=16x16", "resource://DevExpress.DevAV.Resources.Fluent.Employees.table-column-insert-fluent-light-mixed_color-16.svg" },
                { "resource://DevExpress.DevAV.Resources.ExpandCollapse.svg?Size=16x16", "resource://DevExpress.DevAV.Resources.Fluent.Employees.circle-minus-plus-fluent-light-mixed_color-16.svg" },

                { "DevExpress.DevAV.Resources.signal-bar-1-dx_desktop-regular-blue-16.svg", "DevExpress.DevAV.Resources.Fluent.Employees.Priority.signal-bar-1-fluent-light-blue-16.svg" },
                { "DevExpress.DevAV.Resources.signal-bar-2-dx_desktop-regular-blue-16.svg", "DevExpress.DevAV.Resources.Fluent.Employees.Priority.signal-bar-2-fluent-light-blue-16.svg" },
                { "DevExpress.DevAV.Resources.signal-bar-3-dx_desktop-regular-blue-16.svg", "DevExpress.DevAV.Resources.Fluent.Employees.Priority.signal-bar-3-fluent-light-blue-16.svg" },
                { "DevExpress.DevAV.Resources.signal-bar-dx_desktop-regular-blue-16.svg", "DevExpress.DevAV.Resources.Fluent.Employees.Priority.signal-bar-fluent-light-blue-16.svg" },

                { "DevExpress.DevAV.Resources.Tasks.PriorityLow.svg",  "DevExpress.DevAV.Resources.Fluent.Employees.Priority.flag-fluent-light-green-20.svg" },
                { "DevExpress.DevAV.Resources.Tasks.PriorityNormal.svg",  "DevExpress.DevAV.Resources.Fluent.Employees.Priority.flag-fluent-light-mixed_color-20.svg" },
                { "DevExpress.DevAV.Resources.Tasks.PriorityHigh.svg",  "DevExpress.DevAV.Resources.Fluent.Employees.Priority.flag-fluent-light-yellow-20.svg" },
                { "DevExpress.DevAV.Resources.Tasks.PriorityUrgent.svg",  "DevExpress.DevAV.Resources.Fluent.Employees.Priority.flag-fluent-light-red-20.svg" },

                { "resource://DevExpress.DevAV.Resources.EmployeeCard.svg?Size=16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Employees.PrintItems.document-page-lines-person-fluent-light-blue-16.svg"},
                { "resource://DevExpress.DevAV.Resources.Summary.svg?Size=16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Employees.PrintItems.document-data-fluent-light-blue-16.svg"},
                { "resource://DevExpress.DevAV.Resources.EmployeeDirectory.svg?Size=16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Employees.PrintItems.folder-fluent-light-yellow-16.svg"},
                { "resource://DevExpress.DevAV.Resources.TaskList.svg?Size=16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Employees.PrintItems.task-list-square-fluent-light-blue-16.svg"},
                { "resource://DevExpress.DevAV.Resources.Save.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.save-fluent-light-black-16.svg" },
                { "resource://DevExpress.DevAV.Resources.SaveAndClose.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.save-dismiss-fluent-light-red-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Close.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.dismiss-circle-fluent-light-red-16.svg" },
                { "resource://DevExpress.DevAV.Resources.icon-reset-changes-16.png", "resource://DevExpress.DevAV.Resources.Fluent.Employees.arrow-reset-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.MobilePhone.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.phone-fluent-light-black-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Mail.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.Buttons.mail-fluent-light-black-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Skype.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.logo-skype-fluent-light-static_color-16.svg" },
                { "icon%20builder/business_phone;Size16x16", "resource://DevExpress.DevAV.Resources.Fluent.Employees.Buttons.call-fluent-light-black-16.svg" },

                { "DevExpress.DevAV.Resources.PersonPrefix.Doctor.svg", "DevExpress.DevAV.Resources.Fluent.Employees.PersonPrefix.man-fluent-light-black-16.svg" },
                { "DevExpress.DevAV.Resources.PersonPrefix.Mr.svg", "DevExpress.DevAV.Resources.Fluent.Employees.PersonPrefix.man-fluent-light-blue-16.svg" },
                { "DevExpress.DevAV.Resources.PersonPrefix.Ms.svg", "DevExpress.DevAV.Resources.Fluent.Employees.PersonPrefix.woman-fluent-light-black-16.svg" },
                { "DevExpress.DevAV.Resources.PersonPrefix.Miss.svg", "DevExpress.DevAV.Resources.Fluent.Employees.PersonPrefix.woman-fluent-light-red-16.svg" },
                { "DevExpress.DevAV.Resources.PersonPrefix.Mrs.svg", "DevExpress.DevAV.Resources.Fluent.Employees.PersonPrefix.woman-fluent-light-green-16.svg" },

                { "icon_employee_quick_welcome_16" , "DevExpress.DevAV.Resources.Fluent.Employees.QuickLetters.handshake-fluent-light-black-16.svg"},
                { "icon_employee_quick_probation_notice_16" , "DevExpress.DevAV.Resources.Fluent.Employees.QuickLetters.timer-fluent-light-red-16.svg"},
                { "icon_employee_quick_excellence_16" , "DevExpress.DevAV.Resources.Fluent.Employees.QuickLetters.award-fluent-light-yellow-16.svg"},
                { "icon_employee_quick_award_16" , "DevExpress.DevAV.Resources.Fluent.Employees.QuickLetters.trophy-fluent-light-yellow-16.svg"},
                { "icon_employee_quick_thank_16" , "DevExpress.DevAV.Resources.Fluent.Employees.QuickLetters.thumb-like-fluent-light-yellow-16.svg"},

                { "resource://DevExpress.DevAV.Resources.PrintItems.icon-employee-profile-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Employees.PrintItems.document-page-lines-person-fluent-light-blue-16.svg"},
                { "resource://DevExpress.DevAV.Resources.PrintItems.icon-employee-summary-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Employees.PrintItems.document-data-fluent-light-blue-16.svg"},
                { "resource://DevExpress.DevAV.Resources.PrintItems.icon-employee-directory-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Employees.PrintItems.folder-fluent-light-yellow-16.svg"},
                { "resource://DevExpress.DevAV.Resources.PrintItems.icon-employee-task-list-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Employees.PrintItems.task-list-square-fluent-light-blue-16.svg"},

                { "resource://DevExpress.DevAV.Resources.QuickItems.icon-employee-quick-thank-16.png", "resource://DevExpress.DevAV.Resources.Fluent.Employees.QuickLetters.thumb-like-fluent-light-yellow-16.svg" },
                { "resource://DevExpress.DevAV.Resources.QuickItems.icon-employee-quick-award-16.png", "resource://DevExpress.DevAV.Resources.Fluent.Employees.QuickLetters.trophy-fluent-light-yellow-16.svg" },
                { "resource://DevExpress.DevAV.Resources.QuickItems.icon-employee-quick-exellece-16.png", "resource://DevExpress.DevAV.Resources.Fluent.Employees.QuickLetters.award-fluent-light-yellow-16.svg" },
                { "resource://DevExpress.DevAV.Resources.QuickItems.icon-employee-quick-probation-notice-16.png", "resource://DevExpress.DevAV.Resources.Fluent.Employees.QuickLetters.timer-fluent-light-red-16.svg" },
                { "resource://DevExpress.DevAV.Resources.QuickItems.icon-employee-quick-welcome-16.png", "resource://DevExpress.DevAV.Resources.Fluent.Employees.QuickLetters.handshake-fluent-light-black-16.svg" },

                { "DevExpress.DevAV.Resources.EvaluationYes.svg" , "DevExpress.DevAV.Resources.Fluent.checkmark-fluent-light-green-16.svg"},
                { "DevExpress.DevAV.Resources.EvaluationNo.svg" , "DevExpress.DevAV.Resources.Fluent.dismiss-fluent-light-red-16.svg"},

                { "image://svgimages/outlook inspired/glyph_message.svg","resource://DevExpress.DevAV.Resources.Fluent.Employees.Buttons.chat-fluent-light-black-16.svg" },
                { "image://svgimages/outlook inspired/glyph_phone.svg", "resource://DevExpress.DevAV.Resources.Fluent.Employees.Buttons.call-fluent-light-black-16.svg" },
                { "image://svgimages/icon builder/electronics_video.svg",  "resource://DevExpress.DevAV.Resources.Fluent.Employees.Buttons.video-fluent-light-black-16.svg"},
                { "image://svgimages/outlook inspired/glyph_mail.svg",  "resource://DevExpress.DevAV.Resources.Fluent.Employees.Buttons.mail-fluent-light-black-16.svg" },

                { "resource://DevExpress.DevAV.Resources.Driving.svg",  "resource://DevExpress.DevAV.Resources.Fluent.Map.vehicle-car-front-fluent-light-red-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Walking.svg",  "resource://DevExpress.DevAV.Resources.Fluent.Map.person-walking-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.MapItem.icon-A-24.png",  "resource://DevExpress.DevAV.Resources.Fluent.Map.letter-a-circle-fluent-regular-green-16.svg" },
                { "DevExpress.DevAV.Resources.MapItem.icon-A-24.png",  "DevExpress.DevAV.Resources.Fluent.Map.letter-a-circle-fluent-regular-green-16.svg" },
                { "resource://DevExpress.DevAV.Resources.MapItem.icon-B-24.png",  "resource://DevExpress.DevAV.Resources.Fluent.Map.letter-b-circle-fluent-light-red-16.svg" },
                { "resource://DevExpress.DevAV.Resources.High.svg",  "resource://DevExpress.DevAV.Resources.Fluent.Map.arrow-tranding-up-fluent-light-red-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Medium.svg",  "resource://DevExpress.DevAV.Resources.Fluent.Map.arrow-tranding-up-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Low.svg",  "resource://DevExpress.DevAV.Resources.Fluent.Map.arrow-tranding-up-fluent-light-yellow-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Unlike.svg",  "resource://DevExpress.DevAV.Resources.Fluent.Map.arrow-tranding-down-fluent-light-black-16.svg" },
                { "icon_A_32",  "DevExpress.DevAV.Resources.Fluent.Map.letter-a-circle-fluent-light-green-32.svg" },
                { "icon_B_32",  "DevExpress.DevAV.Resources.Fluent.Map.letter-b-circle-fluent-light-red-32.svg" },
                { "icon_arrow_left_32",  "DevExpress.DevAV.Resources.Fluent.Map.arrow-turn-left-fluent-light-black-32.svg" },
                { "icon_arrow_right_32",  "DevExpress.DevAV.Resources.Fluent.Map.arrow-turn-right-fluent-light-black-32.svg" },
                { "icon_arrow_uturn_32",  "DevExpress.DevAV.Resources.Fluent.Employees.arrow-sort-fluent-light-blue-16.svg"},
                { "icon_arrow_bear_left_32",  "DevExpress.DevAV.Resources.Fluent.Map.arrow-turn-up-left-fluent-light-black-32.svg" },
                { "icon_arrow_bear_right_32",  "DevExpress.DevAV.Resources.Fluent.Map.arrow-turn-up-right-fluent-light-black-32.svg" },
                { "icon_arrow_forward_32",  "DevExpress.DevAV.Resources.Fluent.Map.arrow-forward-fluent-light-black-32.svg" },

                #endregion
                #region Customers
                { "resource://DevExpress.DevAV.Resources.NewCustomer.svg" , "resource://DevExpress.DevAV.Resources.Fluent.Customers.person-add-fluent-light-green-16.svg"},
                { "resource://DevExpress.DevAV.Resources.NewCustomer.svg?Size=16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Customers.person-add-fluent-light-green-16.svg"},
                { "resource://DevExpress.DevAV.Resources.ProfileReport.svg?Size=16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Customers.PrintItems.document-lines-case-fluent-light-green-16.svg.svg"},
                { "resource://DevExpress.DevAV.Resources.SalesSummary2.svg?Size=16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Customers.PrintItems.data-cart-fluent-light-red-16.svg"},
                { "resource://DevExpress.DevAV.Resources.SalesInvoise2.svg?Size=16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Customers.PrintItems.document-cart-fluent-light-red-16.svg"},
                { "resource://DevExpress.DevAV.Resources.Mapit.svg?Size=16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Employees.location-fluent-light-red-16.svg"},
                { "resource://DevExpress.DevAV.Resources.SalesSummary.svg?Size=16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Common.Home.cart-fluent-light-black-16.svg"},
                { "resource://DevExpress.DevAV.Resources.SalesAnalysis.svg" , "resource://DevExpress.DevAV.Resources.Fluent.Customers.diagram-sale-fluent-light-blue-16.svg"},
                { "resource://DevExpress.DevAV.Resources.icon-customer-quick-employees-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Customers.PrintItems.people-community-fluent-light-blue-16.svg.svg"},
                { "resource://DevExpress.DevAV.Resources.PrintPreview.svg", "resource://DevExpress.DevAV.Resources.Fluent.Sales.document-page-lines-search-fluent-light-blue-16.svg"},
                { "resource://DevExpress.DevAV.Resources.Export.svg", "resource://DevExpress.DevAV.Resources.Fluent.Map.save-export-fluent-light-green-16.svg"},
                { "resource://DevExpress.DevAV.Resources.SalesPeriodMonth.svg", "resource://DevExpress.DevAV.Resources.Fluent.Map.calendar-cart-fluent-light-red-16.svg"},
                { "resource://DevExpress.DevAV.Resources.SalesPeriodYear.svg", "resource://DevExpress.DevAV.Resources.Fluent.Map.double-calendar-cart-fluent-light-red-16.svg"},
                { "resource://DevExpress.DevAV.Resources.SalesPeriodLifetime.svg", "resource://DevExpress.DevAV.Resources.Fluent.Map.calendar-timer-fluent-light-red-16.svg"},
                { "resource://DevExpress.DevAV.Resources.icon-brand-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Customers.star-circle-fluent-light-yellow-16.svg"},
                #endregion
                #region Products
                { "resource://DevExpress.DevAV.Resources.NewProduct.svg" , "resource://DevExpress.DevAV.Resources.Fluent.Products.box-add-fluent-light-green-16.svg"},
                { "resource://DevExpress.DevAV.Resources.icon-carousel-32.png" , "resource://DevExpress.DevAV.Resources.Fluent.Products.carousel-fluent-light-blue-32.svg"},
                { "resource://DevExpress.DevAV.Resources.icon-new-products-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Products.box-add-fluent-light-green-16.svg"},
                { "resource://DevExpress.DevAV.Resources.box-multiple-dx_desktop-regular-yellow-16.svg" , "resource://DevExpress.DevAV.Resources.Fluent.Products.box-multiple-fluent-light-yellow-16.svg"},
                { "resource://DevExpress.DevAV.Resources.box-more-dx_desktop-regular-mixed_color-16.svg" , "resource://DevExpress.DevAV.Resources.Fluent.Products.box-more-fluent-light-yellow-16.svg"},
                { "resource://DevExpress.DevAV.Resources.icon-product-order-detail-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Products.PrintItems.document-lines-box-fluent-light-green-16.svg"},
                { "resource://DevExpress.DevAV.Resources.icon-product-sales-summary-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Customers.PrintItems.data-cart-fluent-light-red-16.svg"},
                { "resource://DevExpress.DevAV.Resources.icon-product-specification-summary-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Products.PrintItems.page-multiple-lines-fluent-light-blue-16.svg.svg"},
                { "resource://DevExpress.DevAV.Resources.QuickItems.icon-product-quick-sales-report-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Products.QuickReports.document-data-cart-fluent-light-mixed_color-16.svg"},
                { "resource://DevExpress.DevAV.Resources.QuickItems.icon-product-quick-shippments-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Sales.truck-fluent-light-blue-16.svg"},
                { "resource://DevExpress.DevAV.Resources.QuickItems.icon-product-quick-comparisons-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Products.QuickReports.arrow-swap-fluent-light-blue-16.svg"},
                { "resource://DevExpress.DevAV.Resources.QuickItems.icon-product-quick-top-salesperson-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Products.QuickReports.person-star-fluent-light-yellow-16.svg"},
                { "resource://DevExpress.DevAV.Resources.icon-card-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Employees.contact-card-fluent-light-blue-16.svg"},
                { "resource://DevExpress.DevAV.Resources.icon-carousel-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Products.carousel-fluent-light-blue-16.svg"},
                { "resource://DevExpress.DevAV.Resources.Carousel.svg" , "resource://DevExpress.DevAV.Resources.Fluent.Products.carousel-fluent-light-blue-16.svg"},
                #endregion
                #region Sales
                { "resource://DevExpress.DevAV.Resources.NewOrder.svg" , "resource://DevExpress.DevAV.Resources.Fluent.Sales.cart-add-fluent-light-green-16.svg"},
                { "resource://DevExpress.DevAV.Resources.QuickItems.icon-sales-quick-thankyou-16.png", "resource://DevExpress.DevAV.Resources.Fluent.Employees.QuickLetters.thumb-like-fluent-light-yellow-16.svg" },
                { "resource://DevExpress.DevAV.Resources.PrintItems.icon-sales-by-store-16.png", "resource://DevExpress.DevAV.Resources.Fluent.Sales.PrintItems.store-cart-fluent-light-red-16.svg" },
                { "resource://DevExpress.DevAV.Resources.PrintItems.icon-sales-invoice-16.png", "resource://DevExpress.DevAV.Resources.Fluent.Sales.PrintItems.document-sale-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.PrintItems.icon-sales-report-16.png", "resource://DevExpress.DevAV.Resources.Fluent.Employees.PrintItems.document-data-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.QuickItems.icon-sales-quick-report-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Sales.QuickReports.coin-arrow-up-fluent-light-mixed_color-16.svg"},
                { "resource://DevExpress.DevAV.Resources.QuickItems.icon-sales-quick-summary-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Sales.QuickReports.data-coins-fluent-light-yellow-16.svg"},
                { "ExportToDOC;Size16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Sales.document-doc-fluent-light-blue-16.svg"},
                { "ExportToXLS;Size16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Sales.document-xls-fluent-light-green-16.svg"},
                { "ExportToPDF;Size16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Sales.document-pdf-fluent-light-red-16.svg"},
                { "DevExpress.DevAV.Resources.Orders.Payment.svg", "resource://DevExpress.DevAV.Resources.Fluent.Sales.Payment.wallet-fluent-light-red-16.svg" },
                { "DevExpress.DevAV.Resources.Orders.Shipment.svg", "resource://DevExpress.DevAV.Resources.Fluent.Sales.truck-fluent-light-blue-16.svg" },
                { "DevExpress.DevAV.Resources.Orders.PaymentUnpaid.svg", "DevExpress.DevAV.Resources.Fluent.Sales.Payment.circle-off-fluent-light-red-16.svg" },
                { "DevExpress.DevAV.Resources.Orders.PaymentPaid.svg", "DevExpress.DevAV.Resources.Fluent.checkmark-fluent-light-green-16.svg" },
                { "DevExpress.DevAV.Resources.Orders.PaymentRefund.svg", "DevExpress.DevAV.Resources.Fluent.Sales.Payment.arrow-undo-fluent-light-blue-16.svg" },
                { "DevExpress.DevAV.Resources.Orders.ShipmentAwaiting.svg", "DevExpress.DevAV.Resources.Fluent.Sales.Shipment.clock-all-day-fluent-light-green-16.svg" },
                { "DevExpress.DevAV.Resources.Orders.ShipmentTransit.svg", "DevExpress.DevAV.Resources.Fluent.Sales.truck-fluent-light-blue-16.svg" },
                { "DevExpress.DevAV.Resources.Orders.ShipmentReceived.svg", "DevExpress.DevAV.Resources.Fluent.Sales.Shipment.box-fluent-light-black-16.svg" },
                { "resource://DevExpress.DevAV.Resources.Detailed.svg", "resource://DevExpress.DevAV.Resources.Fluent.Sales.document-page-lines-search-fluent-light-blue-16.svg" },
                #endregion
                #region Opportunities
                { "resource://DevExpress.DevAV.Resources.NewOpportunities.svg" , "resource://DevExpress.DevAV.Resources.Fluent.Opportunities.trand-add-fluent-light-mixed_color-16.svg"},
                { "resource://DevExpress.DevAV.Resources.NewOpportunities.svg?Size=16x16" , "resource://DevExpress.DevAV.Resources.Fluent.Opportunities.trand-add-fluent-light-mixed_color-16.svg"},
                { "resource://DevExpress.DevAV.Resources.arrow-tranding-up-more-dx_desktop-regular-green-16.svg" , "resource://DevExpress.DevAV.Resources.Fluent.Opportunities.arrow-tranding-up-more-fluent-light-yellow-16.svg"},
                { "resource://DevExpress.DevAV.Resources.group-dx_desktop-regular-green-16.svg" , "resource://DevExpress.DevAV.Resources.Fluent.Opportunities.group-fluent-light-black-16.svg"},
                { "resource://DevExpress.DevAV.Resources.icon-data-panel-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Common.View.panel-data-text-fluent-light-blue-16.svg" },
                { "resource://DevExpress.DevAV.Resources.icon-list-16.png" , "resource://DevExpress.DevAV.Resources.Fluent.Employees.list-items-fluent-light-blue-16.svg" },
                #endregion
            };
        }
        internal static string GetFluentIconName(string oldIconName) {
            if(IconNameMap.ContainsKey(oldIconName))
                return IconNameMap[oldIconName];
            return oldIconName;
        }

        static object GetPropertyValue(object obj, string propertyName) {
            var type = obj.GetType();
            PropertyInfo prop = null;
            try {

                prop = type.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
                if(prop == null) {
                    prop = type.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public);
                }
            }
            catch(AmbiguousMatchException) {
                var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                var currentType = type;
                while(currentType != null) {
                    prop = properties.FirstOrDefault(p => p.Name == propertyName && p.DeclaringType == currentType);
                    if(prop != null) {
                        break;
                    }
                    currentType = currentType.BaseType;
                }
            }
            return prop?.GetValue(obj, null);
        }

        static void TrySwapImageUri(object obj) {
            object imageOptions = GetPropertyValue(obj, "ImageOptions");
            if(imageOptions == null)
                return;
            ImageOptions validImageOptions = imageOptions as ImageOptions;
            if(validImageOptions != null && validImageOptions.ImageUri != null) {
                string oldUri = validImageOptions.ImageUri.Uri;
                string newUri;
                if(!string.IsNullOrEmpty(oldUri) && IconNameMap.TryGetValue(oldUri, out newUri)) {
                    validImageOptions.ImageUri.Uri = newUri;
                }
            }
        }

        public static void SwapFluentIcons(object parent) {
            TrySwapImageUri(parent);
            SwapChildren(parent);
        }

        static void SwapChildren(object parent) {
            RibbonControl ribbon = parent as RibbonControl;
            if(ribbon != null) {
                foreach(object item in ribbon.Items) {
                    SwapFluentIcons(item);
                }
                return;
            }
            RibbonGalleryBarItem ribbonGalleryBarItem = parent as RibbonGalleryBarItem;
            if(ribbonGalleryBarItem != null && ribbonGalleryBarItem.Gallery != null && ribbonGalleryBarItem.Gallery.Groups != null) {
                foreach(object galleryGroup in ribbonGalleryBarItem.Gallery.Groups) {
                    SwapFluentIcons(galleryGroup);
                }
                return;
            }
            GalleryItemGroup group = parent as GalleryItemGroup;
            if(group != null) {
                foreach(object item in group.Items) {
                    SwapFluentIcons(item);
                }
                return;
            }
            ButtonEdit buttonEdit = parent as ButtonEdit;
            if(buttonEdit != null) {
                foreach(object button in buttonEdit.Properties.Buttons) {
                    SwapFluentIcons(button);
                }
                return;
            }
            if(parent is LayoutControlItem layoutItem) {
                if(layoutItem.Control != null)
                    SwapFluentIcons(layoutItem.Control);
            }
            LayoutControl layoutControl = parent as LayoutControl;
            if(layoutControl?.Root?.Items != null) {
                foreach(object item in layoutControl.Root.Items) {
                    SwapFluentIcons(item);
                }
                return;
            }
            Control ctrl = parent as Control;
            if(ctrl != null) {
                foreach(object control in ctrl.Controls) {
                    SwapFluentIcons(control);
                }
                return;
            }
        }
    }
}
