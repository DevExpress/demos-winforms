Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports DevExpress.Utils
Imports System.Collections

Namespace DevExpress.VideoRent
	<Flags> _
	Public Enum MovieGenre
		None = 0
		Action = &H1
		Adventure = &H2
		Animation = &H4
		Biography = &H8
		Comedy = &H10
		Crime = &H20
		Documentary = &H40
		Drama = &H80
		Family = &H100
		Fantasy = &H200
		History = &H400
		Horror = &H800
		Music = &H1000
		Musical = &H2000
		Mystery = &H4000
		Romance = &H8000
		SciFi = &H10000
		Sport = &H20000
		Thriller = &H40000
		War = &H80000
		Western = &H100000
	End Enum
	Public Enum MovieRating
		G
		PG
		PG13
		R
		NC17
	End Enum
	Public Enum MovieItemStatus
		Active
		Rented
		Sold
		Damaged
		Lost
	End Enum
	Public Enum MovieItemFormat
		DVD = 1
		BlueRay = 2
		VideoCD = 3
	End Enum
	Public Enum EmployeeRole
		Administrator
		[Operator]
	End Enum
	Public Enum PersonGender
		Male
		Female
	End Enum
	Public Enum ReceiptType
		Rentals
		Purchases
		LateFees
	End Enum
	Public Enum CustomerDiscountLevel
		FirstTime
		Basic
		Occasional
		Active
		Prodigious
	End Enum
	Public Enum ActiveRentType
		None
		Overdue
		Today
		Active
	End Enum
	Public Class ReferenceData
		Public Const ShelvesCount As Integer = 12
		Public Const DirectorString As String = "Director"
		Public Const AdministratorString As String = "Administrator"
		Public Shared CompanyTypes() As String = { "Production", "Distributor", "Special Effects", "Others" }
		Public Shared MovieLanguages() As String = { "English", "French", "Spanish", "Russian", "Arabic", "Chinese", "German", "Japanese", "Portuguese", "Somali", "Italian" }
		Public Shared CustomerDiscount() As Decimal = { 0, 0.03D, 0.05D, 0.1D, 0.2D }
		Public Shared CustomerDiscountLevel() As Decimal = { 0, 500, 800, 1000, 5000 }
		Public Shared Function GetDiscountLevelPayment(ByVal level As CustomerDiscountLevel) As Decimal
			Return CustomerDiscountLevel(CInt(Fix(level)))
		End Function
		Public Shared Function GetDiscount(ByVal level As CustomerDiscountLevel) As Decimal
			Return CustomerDiscount(CInt(Fix(level)))
		End Function
	End Class
	Public Class StringHelper
		Public Shared Function GetStringByArrayList(ByVal array As ArrayList) As String
			Dim ret As String = String.Empty
			If Object.Equals(array, Nothing) Then
				Return ret
			End If
			array.Sort()
			For i As Integer = 0 To array.Count - 1
				If i = array.Count - 1 Then
					ret &= String.Format("{0}{1}", array(i),String.Empty)
				Else
					ret &= String.Format("{0}{1}", array(i),", ")
				End If
			Next i
			Return ret
		End Function
	End Class
	Public Class ReferenceImages
		Private Shared person As Image = Nothing, person_small As Image = Nothing, movie As Image = Nothing
		Public Shared ReadOnly Property UnknownPerson() As Image
			Get
				If Object.Equals(person, Nothing) Then
                    person = ResourceImageHelper.CreateImageFromResources("Unknown-user.png", GetType(Customer).Assembly)
				End If
				Return person
			End Get
		End Property
		Public Shared ReadOnly Property UnknownPerson_Small() As Image
			Get
				If Object.Equals(person_small, Nothing) Then
                    person_small = ResourceImageHelper.CreateImageFromResources("Unknown-user-small.png", GetType(Customer).Assembly)
				End If
				Return person_small
			End Get
		End Property
		Public Shared ReadOnly Property UnknownMovie() As Image
			Get
				If Object.Equals(movie, Nothing) Then
                    movie = ResourceImageHelper.CreateImageFromResources("Unknown-movie.png", GetType(Movie).Assembly)
				End If
				Return movie
			End Get
		End Property
	End Class
End Namespace
