Imports Microsoft.VisualBasic
Imports DevExpress.Xpo
Imports System.Drawing
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System
Namespace DevExpress.VideoRent
	Public Class Customer
		Inherits Person
		Implements IComparable
        Private fphoto As Image
        Private fmiddleName As String
        Private femail As String
        Private faddress As String
        Private fphone As String
        Private fcomments As String
        Private fdiscountLevel As CustomerDiscountLevel

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal selfId As Integer)
            Me.New(session)
            Me.SelfId = selfId
        End Sub
        Public Sub New(ByVal session As Session, ByVal selfId As Integer, ByVal firstName As String, ByVal middleName As String, ByVal lastName As String)
            Me.New(session, selfId)
            Me.FirstName = firstName
            Me.MiddleName = middleName
            Me.LastName = lastName
        End Sub
        Public Sub New(ByVal session As Session, ByVal firstName As String, ByVal middleName As String, ByVal lastName As String)
            Me.New(session)
            Me.FirstName = firstName
            Me.MiddleName = middleName
            Me.LastName = lastName
        End Sub
        Public Sub New(ByVal session As Session, ByVal firstName As String, ByVal lastName As String)
            Me.New(session, firstName, String.Empty, lastName)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
            fdiscountLevel = CustomerDiscountLevel.FirstTime
        End Sub
        <Persistent(), Indexed(Unique:=True)> _
        Public Property CustomerId() As Integer
            Get
                Return GetPropertyValue(Of Integer)("CustomerId")
            End Get
            Protected Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("CustomerId", value)
            End Set
        End Property
        Protected Overrides ReadOnly Property GeneratedIdType() As String
            Get
                Return "Customer"
            End Get
        End Property
        Public Property MiddleName() As String
            Get
                Return fmiddleName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("MiddleName", fmiddleName, value)
            End Set
        End Property
        Public Property Email() As String
            Get
                Return femail
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Email", femail, value)
            End Set
        End Property
        <Size(SizeAttribute.Unlimited)> _
        Public Property Address() As String
            Get
                Return faddress
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Address", faddress, value)
            End Set
        End Property
        Public Property Phone() As String
            Get
                Return fphone
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Phone", fphone, value)
            End Set
        End Property
        <Size(SizeAttribute.Unlimited)> _
        Public Property Comments() As String
            Get
                Return fcomments
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Comments", fcomments, value)
            End Set
        End Property
        <DevExpress.Xpo.ValueConverter(GetType(DevExpress.Xpo.Metadata.ImageValueConverter))> _
        Public Property Photo() As Image
            Get
                Return fphoto
            End Get
            Set(ByVal value As Image)
                SetPropertyValue(Of Image)("Photo", fphoto, value)
            End Set
        End Property
        Public ReadOnly Property PhotoExist() As Image
            Get
                If Object.Equals(fphoto, Nothing) Then
                    Return ReferenceImages.UnknownPerson
                End If
                Return fphoto
            End Get
        End Property
        <Association("Customer-Receipts")> _
        Public ReadOnly Property Receipts() As XPCollection(Of Receipt)
            Get
                Return GetCollection(Of Receipt)("Receipts")
            End Get
        End Property
        Public ReadOnly Property ActiveRents() As XPCollection(Of Rent)
            Get
                Return New XPCollection(Of Rent)(Session, CriteriaOperator.Parse("Customer = ? and Active = ?", Me, True))
            End Get
        End Property
        <Persistent()> _
        Public Property DiscountLevel() As CustomerDiscountLevel
            Get
                Return fdiscountLevel
            End Get
            Set(ByVal value As CustomerDiscountLevel)
                SetPropertyValue(Of CustomerDiscountLevel)("DiscountLevel", fdiscountLevel, value)
            End Set
        End Property
		Public Overrides ReadOnly Property AllowDelete() As Boolean
			Get
				Return Object.Equals(Session.FindObject(Of Receipt)(CriteriaOperator.Parse("Customer = ?", Me)), Nothing)
			End Get
		End Property
		Public Function OverdueTodayItemsExist() As Boolean
			For Each rent As Rent In ActiveRents
				If rent.ActiveType <> ActiveRentType.Active Then
					Return True
				End If
			Next rent
			Return False
		End Function
		Public ReadOnly Property Discount() As Decimal
			Get
				Return CDec(ReferenceData.CustomerDiscount.GetValue(CInt(Fix(DiscountLevel))))
			End Get
		End Property
		Public Overrides ReadOnly Property FullName() As String
			Get
				Return GetFullName(FirstName, MiddleName, LastName)
			End Get
		End Property
		Public ReadOnly Property FullNameLastSorting() As String
			Get
				Return GetFullName(LastName, FirstName, MiddleName)
			End Get
		End Property
		Public Shared Function GetFullName(ByVal first As String, ByVal second As String, ByVal third As String) As String
			Dim ret As String
			If Object.Equals(first, Nothing) Then
				ret = String.Empty
			Else
				ret = first.Trim()
			End If
			Dim secondTrim As String
			If Object.Equals(second, Nothing) Then
				secondTrim = String.Empty
			Else
				secondTrim = second.Trim()
			End If
			Dim thirdTrim As String
			If Object.Equals(third, Nothing) Then
				thirdTrim = String.Empty
			Else
				thirdTrim = third.Trim()
			End If
			If secondTrim.Length <> 0 Then
				If ret.Length = 0 Then
					ret &= (String.Empty) & secondTrim
				Else
					ret &= (" ") & secondTrim
				End If
			End If
			If thirdTrim.Length <> 0 Then
				If ret.Length = 0 Then
					ret &= (String.Empty) & thirdTrim
				Else
					ret &= (" ") & thirdTrim
				End If
			End If
			Return ret
		End Function
		Public Overridable ReadOnly Property FullNameAndCardNumber() As String
			Get
				Return String.Format("{0}({1:d6})", FullName, CustomerId)
			End Get
		End Property
		Public ReadOnly Property IsDebter() As Boolean
			Get
				Return ((Not Object.Equals(Session.FindObject(Of Rent)(CriteriaOperator.Parse("Customer = ? and Active = ? and ActiveType = ?", Me, True, ActiveRentType.Overdue)), Nothing)))
			End Get
		End Property
		Public Function DoRent(ByVal rentsInfo As ICollection(Of RentInfo)) As Receipt
			Dim receipt As Receipt = Nothing
			For Each rentInfo As RentInfo In rentsInfo
				Dim item As MovieItem = rentInfo.Item.RentItem
				If Object.Equals(item, Nothing) Then
					Continue For
				End If
				If Object.Equals(receipt, Nothing) Then
					receipt = New Receipt(Me, ReceiptType.Rentals)
				End If
				Dim TempRent As Rent = New Rent(receipt, item, rentInfo.Days)
			Next rentInfo
			If (Not Object.Equals(receipt, Nothing)) Then
				receipt.CalcPayment()
			End If
			Return receipt
		End Function
		Public Function Buy(ByVal rentsInfo As ICollection(Of RentInfo)) As Receipt
			Dim receipt As Receipt = Nothing
			For Each rentInfo As RentInfo In rentsInfo
				Dim item As MovieItem = rentInfo.Item.SellItem
				If Object.Equals(item, Nothing) Then
					Continue For
				End If
				If Object.Equals(receipt, Nothing) Then
					receipt = New Receipt(Me, ReceiptType.Purchases)
				End If
				Dim TempRent As Rent = New Rent(receipt, item, rentInfo.Days)
			Next rentInfo
			If (Not Object.Equals(receipt, Nothing)) Then
				receipt.CalcPayment()
			End If
			Return receipt
		End Function
		Public Function DoRent(ByVal rentInfo As RentInfo) As Receipt
			Return DoRent(New RentInfo() { rentInfo })
		End Function
		Public Function Buy(ByVal rentInfo As RentInfo) As Receipt
			Return Buy(New RentInfo() { rentInfo })
		End Function
		Public Function GetPaymentSum() As Decimal
			Dim ret As Decimal = 0
			For Each reciept As Receipt In Receipts
				ret += reciept.Payment
			Next reciept
			Return ret
		End Function
		Public Sub CalcDiscount()
			Dim paymentSum As Decimal = GetPaymentSum()
			DiscountLevel = GetDiscount(paymentSum)
		End Sub
		Public Function ReturnRents(ByVal rents As ICollection(Of Rent)) As Receipt
			Dim receipt As Receipt = Nothing
			For Each rent As Rent In rents
				If rent.Customer IsNot Me Then
					Continue For
				End If
				rent.Return()
				If (Not rent.IsOverdue) Then
					Continue For
				End If
				If Object.Equals(receipt, Nothing) Then
					receipt = New Receipt(Me, ReceiptType.LateFees)
				End If
				receipt.OverdueRents.Add(rent)
			Next rent
			If (Not Object.Equals(receipt, Nothing)) Then
				receipt.CalcPayment()
			End If
			Return receipt
		End Function
		Public Function ReturnRent(ByVal rent As Rent) As Receipt
			Return ReturnRents(New Rent() { rent })
		End Function
		Public Function GetCustomerInfoHtml() As String
			Dim ret As String = String.Format("<b>{0}</b>", FullName)
			ret &= String.Format(Constants.vbCrLf & "Card Number: <b>{0:d6}</b>", CustomerId)
			If (Not Object.Equals(BirthDate, Nothing)) AndAlso (Not Object.Equals(BirthDate, DateTime.MinValue)) Then
				ret &= String.Format(Constants.vbCrLf & "Birth Date: <b>{0:d}</b>", BirthDate)
			End If
			If (Not String.IsNullOrEmpty(Email)) Then
				ret &= String.Format(Constants.vbCrLf & "Email: <b>{0}</b>", Email)
			End If
			If (Not String.IsNullOrEmpty(Phone)) Then
				ret &= String.Format(Constants.vbCrLf & "Phone: <b>{0}</b>", Phone)
			End If
			If (Not String.IsNullOrEmpty(Address)) Then
				ret &= String.Format(Constants.vbCrLf & "Address: <b>{0}</b>", Address)
			End If
			ret &= String.Format(Constants.vbCrLf & "Discount Level: <b>{0}({1:p})</b>", DiscountLevel, Discount)
			If (Not String.IsNullOrEmpty(Comments)) Then
				ret &= String.Format(Constants.vbCrLf & "Comments: <i>{0}</i>", Comments)
			End If
			Return ret
		End Function
		Public Overrides Function ToString() As String
			Return FullName
		End Function
		Public Shared Function GetDiscount(ByVal paymentSum As Decimal) As CustomerDiscountLevel
			If paymentSum > ReferenceData.GetDiscountLevelPayment(CustomerDiscountLevel.Prodigious) Then
				Return CustomerDiscountLevel.Prodigious
			ElseIf paymentSum > ReferenceData.GetDiscountLevelPayment(CustomerDiscountLevel.Active) Then
				Return CustomerDiscountLevel.Active
			ElseIf paymentSum > ReferenceData.GetDiscountLevelPayment(CustomerDiscountLevel.Occasional) Then
				Return CustomerDiscountLevel.Occasional
			ElseIf paymentSum > ReferenceData.GetDiscountLevelPayment(CustomerDiscountLevel.Basic) Then
				Return CustomerDiscountLevel.Basic
			End If
			Return CustomerDiscountLevel.FirstTime
		End Function
		#Region "IComparable Members"
        Private Function CompareTo(ByVal obj As Object) As Integer
            Return String.Compare(FullName, String.Format("{0}", obj))
        End Function
		#End Region
#If DebugTest Then
		Public Sub SetDiscountLevel(ByVal level As CustomerDiscountLevel)
			DiscountLevel = level
		End Sub
#End If
	End Class
End Namespace
