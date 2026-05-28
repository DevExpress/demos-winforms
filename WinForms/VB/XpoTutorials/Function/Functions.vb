Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo.DB
Imports DevExpress.Data.Filtering
Imports System.Globalization

Namespace DevExpress.Xpo.Demos
    Partial Public Class Functions
        Inherits TutorialControl
        Public Overrides Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.SetNewWhatsThisPadding() = value
            End Set
        End Property

        Private session2 As New UnitOfWork(New SimpleDataLayer(New InMemoryDataStore()))
        Private firstShow() As Boolean = {True, True, True, True}

        Private sessionInMemory As UnitOfWork
        Private sessionDataBase As UnitOfWork

        Private dbConnection As IDbConnection

        Private DBFileName As String

        Public Sub New()
            '<gclCustomQuery>
            '<gclCustomInMemory>
            CriteriaOperator.RegisterCustomFunction(New CustomTanIntegralFormattable())
            '</gclCustomInMemory>
            '</gclCustomQuery>
            InitializeComponent()
            CreateConnectionString()
        End Sub

        Private Sub CreateConnectionString()
            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If (Not String.IsNullOrEmpty(DBFileName)) Then
                session1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
            End If
            ' A session will not automatically create the database or update database schema.
            session1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None
        End Sub
        Private Sub CreateSessionInMemory()
            'Dim customTanIntegral As New CustomTanIntegral()
            Dim inMemory As New InMemoryDataStore(AutoCreateOption.DatabaseAndSchema)
            sessionInMemory = New UnitOfWork(New SimpleDataLayer(inMemory))

            'inMemory.RegisterCustomFunctionOperator(customTanIntegral)
            'sessionInMemory.Dictionary.CustomFunctionOperators.Add(customTanIntegral)
        End Sub

        Private Sub CreateSessionDatabase()
            'Dim customTanIntegral As New CustomTanIntegralFormattable()
            Dim provider As AccessConnectionProvider = CType(AccessConnectionProvider.CreateProviderFromConnection(dbConnection, AutoCreateOption.None), AccessConnectionProvider)
            sessionDataBase = New UnitOfWork(New SimpleDataLayer(provider))

            'provider.RegisterCustomFunctionOperator(customTanIntegral)
            'sessionDataBase.Dictionary.CustomFunctionOperators.Add(customTanIntegral)
        End Sub

        Private Sub CopyDataFromDbToInMemory()
            'sessionInMemory.DataLayer.UpdateSchema(false, 
            '    sessionInMemory.DataLayer.Dictionary.GetClassInfo(typeof(XPObjectType)),
            '    sessionInMemory.DataLayer.Dictionary.GetClassInfo(typeof(CustomOrderDetails)));

            Dim ordersInDB As New XPCollection(Of OrderDetails)(sessionDataBase)
            For Each order As OrderDetails In ordersInDB
                Dim orderInMemory As New CustomOrderDetails(sessionInMemory)
                orderInMemory.Discount = order.Discount
                orderInMemory.Quantity = order.Quantity
                orderInMemory.UnitPrice = order.UnitPrice
                orderInMemory.Save()
            Next order
            sessionInMemory.CommitChanges()
        End Sub


        Private Sub PrepareCustomDataSource()
            Dim viewInMemory As New XPView(sessionInMemory, GetType(CustomOrderDetails))
            viewInMemory.AddProperty("X", "UnitPrice", True, True, SortDirection.Ascending)
            viewInMemory.AddProperty("C", "Quantity", True, True, SortDirection.Ascending)
            viewInMemory.AddProperty("Custom('Customtanintegral', X, C)", "Custom('CustomTanIntegral', UnitPrice, Quantity)")
            gclCustomInMemory.DataSource = viewInMemory

            Dim viewDataBase As New XPView(sessionDataBase, GetType(OrderDetails))
            viewDataBase.AddProperty("X", "UnitPrice", True, True, SortDirection.Ascending)
            viewDataBase.AddProperty("C", "Quantity", True, True, SortDirection.Ascending)
            viewDataBase.AddProperty("Custom('Customtanintegral', X, C)", "Custom('CustomTanIntegral', UnitPrice, Quantity)")
            gclCustomQuery.DataSource = viewDataBase
        End Sub

        '<gclGetYearGroup>
        <OptimisticLocking(False)> _
        Public Class Employees
            Inherits XPBaseObject
            Public Address As String
            Public BirthDate As DateTime
            Public City As String
            Public Country As String
            <Key()> _
            Public EmployeeID As Integer
            Public Extension As String
            Public FirstName As String
            Public HireDate As DateTime
            Public HomePhone As String
            Public LastName As String
            Public Notes As String
            Public Photo() As Byte
            Public PostalCode As String
            Public Region As String
            Public ReportsTo As Integer
            Public Title As String
            Public TitleOfCourtesy As String
            Public Sub New(ByVal session As Session)
                MyBase.New(session)
            End Sub
            <PersistentAlias("GetYear(" + NameOf(BirthDate) + ")")>
            Public ReadOnly Property BirthYear() As Integer
                Get
                    Return Convert.ToInt32(EvaluateAlias(NameOf(BirthYear)))
                End Get
            End Property
        End Class
        '</gclGetYearGroup>


        Public Class CustomOrderDetails
            Inherits XPBaseObject
            Public Sub New(ByVal session As Session)
                MyBase.New(session)
            End Sub
            <Key(True)> _
            Public Oid As Integer
            Public Discount As System.Single
            Public Quantity As Short
            Public UnitPrice As Decimal
        End Class


        '<gclMathematic>
        Public Class MathematicData
            Inherits XPBaseObject
            <Key(True)> _
            Public Oid As Integer
            Public X As Double
            Public Y As Double
            Public Z As Double
            Public Sub New(ByVal session As Session)
                MyBase.New(session)
            End Sub
        End Class
        '</gclMathematic>

        Private Sub xtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtraTabControl1.SelectedPageChanged
            If firstShow(xtraTabControl1.SelectedTabPageIndex) Then
                firstShow(xtraTabControl1.SelectedTabPageIndex) = False
                Select Case xtraTabControl1.SelectedTabPageIndex
                    Case 1
                        PrepareMathData()
                        PrepareMathDataSource()
                    Case 2
                        PrepareStringDataSource()
                    Case 3
                        dbConnection = session1.Connection
                        CreateSessionInMemory()
                        CreateSessionDatabase()
                        CopyDataFromDbToInMemory()
                        PrepareCustomDataSource()
                    Case Else
                End Select
            End If
        End Sub

        Private Sub PrepareMathData()
            For i As Integer = 0 To 29
                Dim data As New MathematicData(session2)
                data.X = (i + 1) / 30.0
                data.Y = i * 30.7 - 450.0
                data.Z = (30 - i) * 40.2
                data.Save()
            Next i
            session2.CommitChanges()
        End Sub

        '<gclMathematic>
        Private Sub PrepareMathDataSource()
            Dim view As New XPView(session2, GetType(MathematicData))
            view.AddProperty("X", "X")
            view.AddProperty("Cos(X)", "Cos(X)")
            view.AddProperty("ACos(X)", "Acos(X)")
            view.AddProperty("Tan(X)", "Tan(X)")
            view.AddProperty("Y", "Y")
            view.AddProperty("Round(Y)", "Round(Y)")
            view.AddProperty("Floor(Y)", "Floor(Y)")
            view.AddProperty("Sign(Y)", "Sign(Y)")
            view.AddProperty("Z", "Z")
            view.AddProperty("Power(Abs(Y), Z / 500)", "Power(Abs(Y), Z / 500)")
            view.AddProperty("Sqr(Z)", "Sqr(Z)")
            gclMathematic.DataSource = view
        End Sub
        '</gclMathematic>

        '<gclStrings>
        Private Sub PrepareStringDataSource()
            Dim view As New XPView(session1, GetType(Customers))
            view.AddProperty("CompanyName", "CompanyName")
            view.AddProperty("Substring(CompanyName, 2, 5)", "Substring(CompanyName, 2, 5)")
            view.AddProperty("Insert(CompanyName, 2, '#TestString#')", "Insert(CompanyName, 2, '#TestString#')")
            view.AddProperty("Country", "Country")
            view.AddProperty("Concat('#', Padleft(Country, 20))", "Concat('#', Padleft(Country, 20))")
            gclStrings.DataSource = view
        End Sub
        '</gclStrings>

        Private Sub splitContainerControl1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles xtraTabControl1.Resize
            splitContainerControl1.SplitterPosition = xtraTabControl1.Width \ 2
        End Sub

        Private inScroll As Boolean = False
        Private Sub gridView4_TopRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridView4.TopRowChanged
            If inScroll Then
                Return
            End If
            inScroll = True
            Try
                gridView5.TopRowIndex = gridView4.TopRowIndex
            Finally
                inScroll = False
            End Try
        End Sub

        Private Sub gridView5_TopRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridView5.TopRowChanged
            If inScroll Then
                Return
            End If
            inScroll = True
            Try
                gridView4.TopRowIndex = gridView5.TopRowIndex
            Finally
                inScroll = False
            End Try
        End Sub

    End Class

    '<gclCustomQuery>
    '<gclCustomInMemory>
    Public Class CustomTanIntegral
        Implements ICustomFunctionOperator
        Public Function Evaluate(ByVal ParamArray operands() As Object) As Object Implements ICustomFunctionOperator.Evaluate
            Dim x As Double = Convert.ToDouble(operands(0))
            Dim c As Double = Convert.ToDouble(operands(1))
            Return -Math.Log(Math.Abs(Math.Cos(x))) + c
        End Function
        Public ReadOnly Property Name() As String Implements ICustomFunctionOperator.Name
            Get
                Return "CustomTanIntegral"
            End Get
        End Property
        Public Function ResultType(ByVal ParamArray operands() As Type) As Type Implements ICustomFunctionOperator.ResultType
            Return GetType(Double)
        End Function
    End Class

    Public Class CustomTanIntegralFormattable
        Inherits CustomTanIntegral
        Implements ICustomFunctionOperatorFormattable
        Public Function Format(ByVal providerType As Type, ByVal ParamArray operands() As String) As String Implements ICustomFunctionOperatorFormattable.Format
            If providerType.Name = "AccessConnectionProvider" Then
                Return String.Format(CultureInfo.InvariantCulture, "-Log(Abs(Cos({0}))) + {1}", operands(0), operands(1))
            End If
            Throw New NotImplementedException(providerType.Name)
        End Function
    End Class
    '</gclCustomInMemory>
    '</gclCustomQuery>

End Namespace

