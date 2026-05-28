using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DevExpress.Utils;
using System.Reflection;

namespace DevExpress.MailDemo.Win {
    [Flags]
    public enum ContactGender { Male, Female }
    public enum DialogRole { New, Edit }
    public enum TaskStatus { NotStarted, InProgress, Completed, WaitingOnSomeoneElse, Deferred };
    public enum TaskCategory { HouseChores, Shopping, Office };
    public enum FlagStatus { Today, Tomorrow, ThisWeek, NextWeek, NoDate, Custom, Completed };
    public enum ContactTitle { None, Dr, Miss, Mr, Mrs, Ms, Prof };
    public class TagResources {
        public const string FlipLayout = "FlipLayout";
        public const string MenuSaveAs = "SaveAs";
        public const string MenuSaveAttachment = "SaveAttachment";
        public const string MenuSaveCalendar = "SaveCalendar";
        public const string TaskList = "TaskList";
        public const string TaskToDoList = "TaskToDoList";
        public const string TaskPrioritized = "TaskPrioritized";
        public const string TaskCompleted = "TaskCompleted";
        public const string TaskToday = "TaskToday";
        public const string TaskOverdue = "TaskOverdue";
        public const string TaskSimpleList = "TaskSimpleList";
        public const string TaskDeferred = "TaskDeferred";
        public const string TaskNew = "NewTask";
        public const string TaskEdit = "EditTask";
        public const string TaskDelete = "DeleteTask";
        public const string ContactList = "List";
        public const string ContactAlphabetical = "Alphabetical";
        public const string ContactByState = "ByState";
        public const string ContactCard = "Card";
        public const string ContactNew = "NewContact";
        public const string ContactEdit = "EditContact";
        public const string ContactDelete = "DeleteContact";
    }
    public class CollectionResources {
        public static List<string> HouseTasks = new List<string>() {
            "Set-up home theater (surround sound) system",
            "Install 3 overhead lights in bedroom",
            "Change light bulbs in backyard",
            "Install a programmable thermostat",
            "Install ceiling fan in John's bedroom",
            "Install LED lights in kitchen",
            "Check wiring in main electricity panel",
            "Replace master bedroom light switch with dimmer",
            "Install an new electric outlet in garage",
            "Install electric outlet and ethernet drop in closet",
            "Install chandelier in dining room",
            "Hook up DVD Player to TV for kids",
            "Clean the House top to bottom",
            "Light cleaning of the house",
            "Clean the entire house",
            "Clean and organize basement",
            "Pick up clothes for charity event",
            "Ironing, laundry and vacuuming",
            "Take kids to park and play baseball on Sunday",
            "Clean art studio",
            "Bake brownies and send them to neighbors",
            "Assemble Kitchen Cart",
            "Move piano",
            "Clean backyard",
            "Clean out garage",
            "Organize guest bedroom",
            "Clean out closet",
            "Preapre for yard sale",
            "Sorting clothing for give-away",
            "Organize Storage Room"};
        public static List<string> ShoppingTasks = new List<string>() {
            "Shopping at Macy's",
            "Return coffee machine",
            "Purchase plastic trash bins",
            "Shop for dinner ingredients at the store",
            "Buy new utensils for kitchen",
            "Send post card to Timothy",
            "Buy dining table and TV stand online",
            "Buy ingredients for Pasta Bolognese",
            "Size 3 diapers (3 cases)",
            "Order 3 pizzas",
            "Find out where to buy the new tablet",
            "Buy broccoli and tomatoes",
            "Buy bottle of Champagne",
            "Grocery shopping at Market Basket",
            "Find a bike at a store close to me",
            "Return jeans at JCrew",
            "Buy dog food for Fido",
            "Buy rigid foam insulation",
            "Purchase 3 24-packs of bottled Coke",
            "Purchase & deliver flowers to my home"};
        public static List<string> OfficeTasks = new List<string>() {
            "Input bank statement transactions into Excel spreadsheet",
            "Schedule appointments and pay bills",
            "Place new address stickers on envelopes",
            "Set up and arrange appointments",
            "Copy PDF file into Word",
            "Organize business expenses (last 6 months)",
            "Return samples to vendor",
            "Organize receipts and match them up with business expenses and trips ",
            "File papers and receipts",
            "Ship out CDs to customers",
            "Respond to e-mails until noon",
            "Enter expenses into an online accounting system",
            "Conduct inventory of all furniture in office",
            "Arrange travel to conference",
            "Staple flyers to gift bags",
            "File and shred mail",
            "Print copies of brochures",
            "Enter all receipts into an Excel spreadsheet",
            "Research possible vendors",
            "Sort through paper receipts",
            "Re-package products for retail sale",
            "Scan docs, and put in desktop folder",
            "Print registration stickers"};
    }
    public class FontResources {
        public static Font StrikeoutFont = new Font(AppearanceObject.DefaultFont, FontStyle.Strikeout);
        public static Font BoldFont = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
    }
}
