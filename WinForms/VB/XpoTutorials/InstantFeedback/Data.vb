Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins

Namespace DevExpress.Xpo.Demos
	Public Class OutlookData
		Public Shared rnd As New Random()
		Friend Shared users() As String = {"Peter Dolan", "Ryan Fischer", "Richard Fisher", "Tom Hamlett", "Mark Hamilton", "Steve Lee", "Jimmy Lewis", "Jeffrey W McClain", "Andrew Miller", "Dave Murrel", "Bert Parkins", "Mike Roller", "Ray Shipman", "Paul Bailey", "Brad Barnes", "Carl Lucas", "Jerry Campbell"}
		Private Shared subject() As String = { "Integrating Developer Express MasterView control into an Accounting System.", "Web Edition: Data Entry Page. There is an issue with date validation.", "Payables Due Calculator is ready for testing.", "Web Edition: Search Page is ready for testing.", "Main Menu: Duplicate Items. Somebody has to review all menu items in the system.", "Receivables Calculator. Where can I find the complete specs?", "Ledger: Inconsistency. Please fix it.", "Receivables Printing module is ready for testing.", "Screen Redraw. Somebody has to look at it.", "Email System. What library are we going to use?", "Cannot add new vendor. This module doesn't work!", "History. Will we track sales history in our system?", "Main Menu: Add a File menu. File menu item is missing.", "Currency Mask. The current currency mask in completely unusable.", "Drag & Drop operations are not available in the scheduler module.", "Data Import. What database types will we support?", "Reports. The list of incomplete reports.", "Data Archiving. We still don't have this features in our application.", "Email Attachments. Is it possible to add multiple attachments? I haven't found a way to do this.", "Check Register. We are using different paths for different modules.", "Data Export. Our customers asked us for export to Microsoft Excel"}

		Private Shared Function GetImportance(ByVal num As Integer) As Integer
			Dim ret As Integer = rnd.Next(num)
			If ret > 2 Then
				ret = 1
			End If
			Return ret
		End Function

		Private Shared Function GetIcon() As Integer
			Dim ret As Integer = rnd.Next(10)
			ret = If(ret > 2, 1, 0)
			Return ret
		End Function

		Private Shared Function GetAttach() As Integer
			Dim ret As Integer = rnd.Next(10)
			ret = If(ret > 5, 1, 0)
			Return ret
		End Function

		Private Shared Function GetSent() As DateTime
			Dim ret As DateTime = DateTime.Now
			Dim r As Integer = rnd.Next(12)
			If r > 1 Then
				ret = ret.AddDays(-rnd.Next(50))
			End If
			ret = ret.AddMinutes(-rnd.Next(ret.Minute + ret.Hour * 60 + 360))
			Return ret
		End Function

		Private Shared Function GetReceived(ByVal sent As DateTime) As DateTime
			Dim dt As DateTime = sent.AddMinutes(10 + rnd.Next(120))
			If dt > DateTime.Now Then
				dt = DateTime.Now.AddMinutes(-1)
			End If
			Return dt
		End Function

		Private Shared Function GetSubject() As String
			Return subject(rnd.Next(subject.Length - 1))
		End Function

		Public Shared Function GetFrom() As String
			Return users(rnd.Next(users.Length - 2))
		End Function

		Private Shared Function GetTo() As String
			Return users(users.Length - 1)
		End Function

		Private Shared Function GetSentDate() As DateTime
			Dim ret As DateTime = DateTime.Today
			Dim r As Integer = rnd.Next(12)
			If r > 1 Then
				ret = ret.AddDays(-rnd.Next(50))
			End If
			Return ret
		End Function

		Private Shared Function GetSentDateWithTime() As DateTime
			Dim ret As DateTime = DateTime.Now.AddMinutes(-rnd.Next(60, 250000))
			Return ret
		End Function

		Public Shared Function GetDueDate() As DateTime
			Dim ret As DateTime = DateTime.Today
			ret = ret.AddDays(60 + rnd.Next(50))
			Return ret
		End Function

		Private Shared Function GetSize(ByVal largeData As Boolean) As Integer
			Return 1000 + (If(largeData, 20 * rnd.Next(10000), 30 * rnd.Next(100)))
		End Function
		Private Shared Function GetHasAttachment() As Boolean
			Return rnd.Next(10) > 5
		End Function

		Public Shared Function CreateDataTable() As DataTable
			Return CreateDataTable(7)
		End Function
		Public Shared Function CreateMailRow(ByVal num As Integer, ByVal realTime As Boolean) As Object()
			Dim sent As DateTime = GetSent()
			Return New Object() { GetImportance(num), GetAttach(),If(realTime, 0, GetIcon()), GetIcon(), GetSubject(), GetFrom(), GetTo(), sent,If(realTime, DateTime.Now, GetReceived(sent))}
		End Function
		Public Shared Function CreateDataTable(ByVal num As Integer) As DataTable
			Dim tbl As New DataTable("Outlook")
			tbl.Columns.Add("Priority", GetType(Integer))
			tbl.Columns.Add("Attachment", GetType(Integer))
			tbl.Columns.Add("Read", GetType(Integer))
			tbl.Columns.Add("Flag", GetType(Integer))
			tbl.Columns.Add("Subject", GetType(String))
			tbl.Columns.Add("From", GetType(String))
			tbl.Columns.Add("To", GetType(String))
			tbl.Columns.Add("Sent", GetType(DateTime))
			tbl.Columns.Add("Received", GetType(DateTime))
			For i As Integer = 0 To 79
				tbl.Rows.Add(CreateMailRow(num, False))
			Next i
			Return tbl
		End Function
		Public Shared Function CreateIssueList() As DataTable
			Dim tbl As New DataTable()
			tbl = New DataTable("IssueList")
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Subject", GetType(String))
			tbl.Columns.Add("Implemented", GetType(Integer))
			tbl.Columns.Add("Suspended", GetType(Boolean))
			For i As Integer = 1 To subject.Length
				tbl.Rows.Add(New Object() { i, subject.GetValue(i - 1), rnd.Next(100), rnd.Next(10) > 8 })
			Next i
			Return tbl
		End Function

		Public Shared Function CreateNewObject(ByVal uow As UnitOfWork) As ServerSideGridTest
			Dim obj As New ServerSideGridTest(uow)
			obj.Subject = GetSubject()
			obj.From = GetFrom()
			obj.Sent = GetSentDateWithTime()
			obj.HasAttachment = GetHasAttachment()
			obj.Size = GetSize(obj.HasAttachment)
			obj.Priority = GetImportance(4)
			Return obj
		End Function
	End Class
	Public Class GroupIntervalData
		Public Shared rnd As New Random()
		Private Shared Function GetCount() As Decimal
			Return rnd.Next(50) + 10
		End Function
		Private Shared Function GetDate(ByVal range As Boolean) As DateTime
			Dim ret As DateTime = DateTime.Now
			Dim r As Integer = rnd.Next(20)
			If range Then
				If r > 1 Then
					ret = ret.AddDays(rnd.Next(80) - 40)
				End If
				If r > 18 Then
					ret = ret.AddMonths(rnd.Next(18))
				End If
			Else
				ret = ret.AddDays(rnd.Next(r * 30) - r * 15)
			End If
			Return ret
		End Function
		Public Shared Function CreateDataTable(ByVal maxRows As Integer) As DataTable
			Return CreateDataTable(maxRows, True)
		End Function
		Public Shared Function CreateDataTable(ByVal maxRows As Integer, ByVal range As Boolean) As DataTable
			Dim tbl As DataTable = Nothing
			Dim DBFileName As String = String.Empty
			DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
			If DBFileName <> String.Empty Then
				Dim ds As New DataSet()
				Dim tblName As String = "Products"

				Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
				Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblName, con)
				oleDbDataAdapter.Fill(ds, tblName)

				Dim product As DataTable = ds.Tables(tblName)
				tbl = New DataTable("GroupInterval")
				tbl.Columns.Add("Product Name", GetType(String))
				tbl.Columns.Add("Category", GetType(Integer))
				tbl.Columns.Add("Unit Price", GetType(Decimal))
				tbl.Columns.Add("Count", GetType(Integer))
				tbl.Columns.Add("Order Date", GetType(DateTime))
				tbl.Columns.Add("Order Sum", GetType(Decimal), "[Unit Price] * [Count]")
				For i As Integer = 0 To maxRows - 1
					Dim row As DataRow = product.Rows(rnd.Next(product.Rows.Count - 1))
					tbl.Rows.Add(New Object() { row("ProductName"), row("CategoryID"), row("UnitPrice"), GetCount(), GetDate(range) })
				Next i
			End If
			Return tbl
		End Function
	End Class
	Public Class MailData
        Private _row As DataRow
        Public Sub New(ByVal row As DataRow)
            Me._row = row
        End Sub
        Public ReadOnly Property Row() As DataRow
            Get
                Return _row
            End Get
        End Property
        Public Property Priority() As Integer
            Get
                Return CInt(Fix(_row(NameOf(Priority))))
            End Get
            Set(ByVal value As Integer)
                _row(NameOf(Priority)) = value
            End Set
        End Property
        Public ReadOnly Property Attachment() As Integer
            Get
                Return CInt(Fix(_row(NameOf(Attachment))))
            End Get
        End Property
        Public Property Read() As Integer
            Get
                Return CInt(Fix(_row(NameOf(Read))))
            End Get
            Set(ByVal value As Integer)
                _row(NameOf(Read)) = value
            End Set
        End Property
        Public Property Flag() As Integer
            Get
                Return CInt(Fix(_row(NameOf(Flag))))
            End Get
            Set(ByVal value As Integer)
                _row(NameOf(Flag)) = value
            End Set
        End Property
        Public ReadOnly Property Subject() As String
            Get
                Return String.Format("{0}", _row(NameOf(Subject)))
            End Get
        End Property
        Public ReadOnly Property [From]() As String
            Get
                Return String.Format("{0}", _row("From"))
            End Get
        End Property
	End Class
	Public Class ColorsObject
		Private fforeColor, fbackColor As Color
		Public Sub New(ByVal fforeColor As Color, ByVal fbackColor As Color)
			Me.fforeColor = fforeColor
			Me.fbackColor = fbackColor
		End Sub
		Public Property ForeColor() As Color
			Get
				Return fforeColor
			End Get
			Set(ByVal value As Color)
				fforeColor = value
			End Set
		End Property
		Public Property BackColor() As Color
			Get
				Return fbackColor
			End Get
			Set(ByVal value As Color)
				fbackColor = value
			End Set
		End Property
	End Class
	Public Class ColorHelper
		Public Shared Sub UpdateColor(ByVal list As ImageList, ByVal lf As UserLookAndFeel)
			For i As Integer = 0 To list.Images.Count - 1
				list.Images(i) = SetColor(TryCast(list.Images(i), Bitmap), GetHeaderForeColor(lf))
			Next i
		End Sub
		Public Shared Function GetHeaderForeColor(ByVal lf As UserLookAndFeel) As Color
			Dim ret As Color = SystemColors.ControlText
			If lf.ActiveStyle <> ActiveLookAndFeelStyle.Skin Then
				Return ret
			End If
			Return GridSkins.GetSkin(lf)(GridSkins.SkinHeader).Color.GetForeColor()
		End Function
		Private Shared Function SetColor(ByVal bmp As Bitmap, ByVal color As Color) As Bitmap
			For i As Integer = 0 To bmp.Width - 1
				For j As Integer = 0 To bmp.Height - 1
					If bmp.GetPixel(i, j).Name <> "0" Then
						bmp.SetPixel(i, j, color)
					End If
				Next j
			Next i
			Return bmp
		End Function
	End Class
End Namespace
