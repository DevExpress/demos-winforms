Imports DevExpress.DXperience.Demos
Imports System
Imports System.Collections

Namespace DevExpress.XtraVerticalGrid.Demos

    Public Class Contacts
        Inherits ArrayList

        Public Sub New()
            Add(New Contact(1, "John", "Doe", "Doe Enterprises", "123 Home Lane", "Homesville", "CA", "74561", "(555)956-15-47", True, Date.Parse("12/02/2001", Globalization.CultureInfo.InvariantCulture), "Programmer", 1, "Enjoys horseback riding and paints.", "M", "VS", 199.99, TutorialConstants.Now, 0, 4))
            Add(New Contact(2, "Karen", "Holmes", "Holmes World", "933 Heart St. Suite ", "Chicago", "IL", "55561", "(555)342-25-74", False, Date.Parse("11/11/2002", Globalization.CultureInfo.InvariantCulture), "Doctor", 2, "Has five children. Loves to travel.", "F", "AM", 78.25, TutorialConstants.Now, 1, 4))
            Add(New Contact(3, "Frank", "Frankson", "Frankson Media", "349 Graphic Design L", "Newman", "OK", "12458", "(555)155-05-02", True, Date.Parse("01/01/2002", Globalization.CultureInfo.InvariantCulture), "Retired", 0, "Retired. Enjoys travel and bungee jumping.", "M", "VS", 1299, TutorialConstants.Now, 0, 9))
            Add(New Contact(4, "Leticia", "Ford", "Ford Consulting", "93900 Carter Lane", "Cartersville", "GA", "19564", "(555)776-15-66", True, Date.Parse("10/07/2002", Globalization.CultureInfo.InvariantCulture), "Engineer", 1, "none", "F", "MS", 354.12, TutorialConstants.Now, 2, 3))
            Add(New Contact(5, "Henry", "McAllister", "McAllister Systems", "436 1st Ave.", "Cleveland", "OH", "99523", "(555)941-24-32", False, Date.Parse("09/08/2002", Globalization.CultureInfo.InvariantCulture), "Programmer", 0, "Enjoys fishing, skiing, and skydiving.", "M", "CS", 9.99, TutorialConstants.Now, 3, 1))
            Add(New Contact(6, "Roger", "Michelson", "Michelson Systems", "3920 Michelson Dr.", "Bridgeford", "CT", "74123", "(555)954-51-88", True, Date.Parse("06/04/2001", Globalization.CultureInfo.InvariantCulture), "Special agent", 2, "Archery, windsurfing and food.", "M", "VS", 520, TutorialConstants.Now, 4, 2))
        End Sub
    End Class

    Public Class Products
        Inherits ArrayList

        Public Sub New()
            Add(New Product(0, "XtraGrid", "The first and most comprehensive 100% native grid control suite for Visual Studio .NET!"))
            Add(New Product(1, "XtraEditors", "Like the XtraGrid, the XtraEditors Library is the first comprehensive suite of individual field editors - written from groud-up using the C# programming language."))
            Add(New Product(2, "XtraBars", "The XtraBars is our 100% native .NET component library which fully emulates the menu/toolbar and sidebar navigation systems introduced in MS Office(c) XP and the .NET IDE."))
            Add(New Product(3, "XtraTreeList", "The XtraTreeList Suite is our 100% native .NET component library which allows you to break passed the traditional limits of treeview controls and represent information - be it in bound or unbound mode - to your end users in an intuitive TreeList metaphor."))
            Add(New Product(4, "XtraPrinting", "The XtraPrinting Library is the perfect support library for those using the XtraGrid and XtraTreeList Suite."))
            Add(New Product(5, "XtraNavBar", "Bring the User Interface of Windows XP - MS Office - and Visual Studio .NET to your applications with the most advanced navigation bar available for .NET."))
            Add(New Product(6, "ASPxGrid", "An ultra-advanced Outlook(c) style WebForms Grid control engineered specifically for ASP.NET."))
        End Sub
    End Class

    Public Class Contact

        Private clientIDCore As Integer

        Private firstNameCore As String

        Private lastNameCore As String

        Private companyNameCore As String

        Private addressCore As String

        Private cityCore As String

        Private stateCore As String

        Private zipCodeCore As String

        Private phoneCore As String

        Private customerCore As Boolean

        Private dateOpenCore As Date

        Private occupationCore As String

        Private riskLevelCore As Integer

        Private interestCore As String

        Private genderCore As String

        Private paymentTypeCore As String

        Private paymentAmountCore As Double

        Private paymentDateCore As Date

        Private productIDCore As Integer

        Private copiesCore As Integer

        Public Sub New(ByVal clientID As Integer, ByVal firstName As String, ByVal lastName As String, ByVal companyName As String, ByVal address As String, ByVal city As String, ByVal state As String, ByVal zipCode As String, ByVal phone As String, ByVal customer As Boolean, ByVal dateOpen As Date, ByVal occupation As String, ByVal riskLevel As Integer, ByVal interest As String, ByVal gender As String, ByVal paymentType As String, ByVal paymentAmount As Double, ByVal paymentDate As Date, ByVal productID As Integer, ByVal copies As Integer)
            clientIDCore = clientID
            firstNameCore = firstName
            lastNameCore = lastName
            companyNameCore = companyName
            addressCore = address
            cityCore = city
            stateCore = state
            zipCodeCore = zipCode
            phoneCore = phone
            customerCore = customer
            dateOpenCore = dateOpen
            occupationCore = occupation
            riskLevelCore = riskLevel
            interestCore = interest
            genderCore = gender
            paymentTypeCore = paymentType
            paymentAmountCore = paymentAmount
            paymentDateCore = paymentDate
            productIDCore = productID
            copiesCore = copies
        End Sub

        Public ReadOnly Property ClientID As Integer
            Get
                Return clientIDCore
            End Get
        End Property

        Public Property FirstName As String
            Get
                Return firstNameCore
            End Get

            Set(ByVal value As String)
                firstNameCore = value
            End Set
        End Property

        Public Property LastName As String
            Get
                Return lastNameCore
            End Get

            Set(ByVal value As String)
                lastNameCore = value
            End Set
        End Property

        Public Property CompanyName As String
            Get
                Return companyNameCore
            End Get

            Set(ByVal value As String)
                companyNameCore = value
            End Set
        End Property

        Public Property Address As String
            Get
                Return addressCore
            End Get

            Set(ByVal value As String)
                addressCore = value
            End Set
        End Property

        Public Property City As String
            Get
                Return cityCore
            End Get

            Set(ByVal value As String)
                cityCore = value
            End Set
        End Property

        Public Property State As String
            Get
                Return stateCore
            End Get

            Set(ByVal value As String)
                stateCore = value
            End Set
        End Property

        Public Property ZipCode As String
            Get
                Return zipCodeCore
            End Get

            Set(ByVal value As String)
                zipCodeCore = value
            End Set
        End Property

        Public Property Phone As String
            Get
                Return phoneCore
            End Get

            Set(ByVal value As String)
                phoneCore = value
            End Set
        End Property

        Public Property Customer As Boolean
            Get
                Return customerCore
            End Get

            Set(ByVal value As Boolean)
                customerCore = value
            End Set
        End Property

        Public Property DateOpen As Date
            Get
                Return dateOpenCore
            End Get

            Set(ByVal value As Date)
                dateOpenCore = value
            End Set
        End Property

        Public Property Occupation As String
            Get
                Return occupationCore
            End Get

            Set(ByVal value As String)
                occupationCore = value
            End Set
        End Property

        Public Property RiskLevel As Integer
            Get
                Return riskLevelCore
            End Get

            Set(ByVal value As Integer)
                riskLevelCore = value
            End Set
        End Property

        Public Property Interest As String
            Get
                Return interestCore
            End Get

            Set(ByVal value As String)
                interestCore = value
            End Set
        End Property

        Public Property Gender As String
            Get
                Return genderCore
            End Get

            Set(ByVal value As String)
                genderCore = value
            End Set
        End Property

        Public Property PaymentType As String
            Get
                Return paymentTypeCore
            End Get

            Set(ByVal value As String)
                paymentTypeCore = value
            End Set
        End Property

        Public Property PaymentAmount As Double
            Get
                Return paymentAmountCore
            End Get

            Set(ByVal value As Double)
                paymentAmountCore = value
            End Set
        End Property

        Public Property PaymentDate As Date
            Get
                Return paymentDateCore
            End Get

            Set(ByVal value As Date)
                paymentDateCore = value
            End Set
        End Property

        Public Property ProductID As Integer
            Get
                Return productIDCore
            End Get

            Set(ByVal value As Integer)
                productIDCore = value
            End Set
        End Property

        Public Property Copies As Integer
            Get
                Return copiesCore
            End Get

            Set(ByVal value As Integer)
                copiesCore = value
            End Set
        End Property
    End Class

    Public Class Product

        Private idCore As Integer

        Private nameCore As String

        Private descriptionCore As String

        Public Sub New(ByVal id As Integer, ByVal name As String, ByVal description As String)
            idCore = id
            nameCore = name
            descriptionCore = description
        End Sub

        Public ReadOnly Property ID As Integer
            Get
                Return idCore
            End Get
        End Property

        Public ReadOnly Property Name As String
            Get
                Return nameCore
            End Get
        End Property

        Public ReadOnly Property Description As String
            Get
                Return descriptionCore
            End Get
        End Property
    End Class
End Namespace
