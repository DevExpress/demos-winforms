Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Drawing
Imports DevExpress.Utils
Imports System.Reflection

Namespace DevExpress.MailDemo.Win
	<Flags>
	Public Enum ContactGender
		Male
		Female
	End Enum
	Public Enum DialogRole
		[New]
		Edit
	End Enum
	Public Enum TaskStatus
		NotStarted
		InProgress
		Completed
		WaitingOnSomeoneElse
		Deferred
	End Enum
	Public Enum TaskCategory
		HouseChores
		Shopping
		Office
	End Enum
	Public Enum FlagStatus
		Today
		Tomorrow
		ThisWeek
		NextWeek
		NoDate
		Custom
		Completed
	End Enum
	Public Enum ContactTitle
		None
		Dr
		Miss
		Mr
		Mrs
		Ms
		Prof
	End Enum
	Public Class TagResources
		Public Const FlipLayout As String = "FlipLayout"
		Public Const MenuSaveAs As String = "SaveAs"
		Public Const MenuSaveAttachment As String = "SaveAttachment"
		Public Const MenuSaveCalendar As String = "SaveCalendar"
		Public Const TaskList As String = "TaskList"
		Public Const TaskToDoList As String = "TaskToDoList"
		Public Const TaskPrioritized As String = "TaskPrioritized"
		Public Const TaskCompleted As String = "TaskCompleted"
		Public Const TaskToday As String = "TaskToday"
		Public Const TaskOverdue As String = "TaskOverdue"
		Public Const TaskSimpleList As String = "TaskSimpleList"
		Public Const TaskDeferred As String = "TaskDeferred"
		Public Const TaskNew As String = "NewTask"
		Public Const TaskEdit As String = "EditTask"
		Public Const TaskDelete As String = "DeleteTask"
		Public Const ContactList As String = "List"
		Public Const ContactAlphabetical As String = "Alphabetical"
		Public Const ContactByState As String = "ByState"
		Public Const ContactCard As String = "Card"
		Public Const ContactNew As String = "NewContact"
		Public Const ContactEdit As String = "EditContact"
		Public Const ContactDelete As String = "DeleteContact"
	End Class
	Public Class CollectionResources
		Public Shared HouseTasks As New List(Of String)() From {"Set-up home theater (surround sound) system", "Install 3 overhead lights in bedroom", "Change light bulbs in backyard", "Install a programmable thermostat", "Install ceiling fan in John's bedroom", "Install LED lights in kitchen", "Check wiring in main electricity panel", "Replace master bedroom light switch with dimmer", "Install an new electric outlet in garage", "Install electric outlet and ethernet drop in closet", "Install chandelier in dining room", "Hook up DVD Player to TV for kids", "Clean the House top to bottom", "Light cleaning of the house", "Clean the entire house", "Clean and organize basement", "Pick up clothes for charity event", "Ironing, laundry and vacuuming", "Take kids to park and play baseball on Sunday", "Clean art studio", "Bake brownies and send them to neighbors", "Assemble Kitchen Cart", "Move piano", "Clean backyard", "Clean out garage", "Organize guest bedroom", "Clean out closet", "Preapre for yard sale", "Sorting clothing for give-away", "Organize Storage Room"}
		Public Shared ShoppingTasks As New List(Of String)() From {"Shopping at Macy's", "Return coffee machine", "Purchase plastic trash bins", "Shop for dinner ingredients at the store", "Buy new utensils for kitchen", "Send post card to Timothy", "Buy dining table and TV stand online", "Buy ingredients for Pasta Bolognese", "Size 3 diapers (3 cases)", "Order 3 pizzas", "Find out where to buy the new tablet", "Buy broccoli and tomatoes", "Buy bottle of Champagne", "Grocery shopping at Market Basket", "Find a bike at a store close to me", "Return jeans at JCrew", "Buy dog food for Fido", "Buy rigid foam insulation", "Purchase 3 24-packs of bottled Coke", "Purchase & deliver flowers to my home"}
		Public Shared OfficeTasks As New List(Of String)() From {"Input bank statement transactions into Excel spreadsheet", "Schedule appointments and pay bills", "Place new address stickers on envelopes", "Set up and arrange appointments", "Copy PDF file into Word", "Organize business expenses (last 6 months)", "Return samples to vendor", "Organize receipts and match them up with business expenses and trips ", "File papers and receipts", "Ship out CDs to customers", "Respond to e-mails until noon", "Enter expenses into an online accounting system", "Conduct inventory of all furniture in office", "Arrange travel to conference", "Staple flyers to gift bags", "File and shred mail", "Print copies of brochures", "Enter all receipts into an Excel spreadsheet", "Research possible vendors", "Sort through paper receipts", "Re-package products for retail sale", "Scan docs, and put in desktop folder", "Print registration stickers"}
	End Class
	Public Class FontResources
		Public Shared StrikeoutFont As New Font(AppearanceObject.DefaultFont, FontStyle.Strikeout)
		Public Shared BoldFont As New Font(AppearanceObject.DefaultFont, FontStyle.Bold)
	End Class
End Namespace
