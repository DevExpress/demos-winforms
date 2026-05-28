Imports System
Imports DevExpress.Data.Filtering

Namespace DevExpress.XtraPivotGrid.Demos

    Public Class IsBlackFridayFunction
        Implements ICustomFunctionDisplayAttributes

        Public Const FunctionName As String = "IsBlackFriday"

        Private Shared ReadOnly Instance As IsBlackFridayFunction = New IsBlackFridayFunction()

        Private Sub New()
        End Sub

        '
        Public Shared Sub Register()
            CriteriaOperator.RegisterCustomFunction(Instance)
        End Sub

        Public Shared Function Unregister() As Boolean
            Return CriteriaOperator.UnregisterCustomFunction(Instance)
        End Function

#Region "ICustomFunctionOperatorBrowsable Members"
        Public ReadOnly Property Category As FunctionCategory Implements ICustomFunctionOperatorBrowsable.Category
            Get
                Return FunctionCategory.DateTime
            End Get
        End Property

        Public ReadOnly Property Description As String Implements ICustomFunctionOperatorBrowsable.Description
            Get
                Return "Is the day after Thanksgiving Day"
            End Get
        End Property

        Public Function IsValidOperandCount(ByVal count As Integer) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandCount
            Return count = 1
        End Function

        Public Function IsValidOperandType(ByVal operandIndex As Integer, ByVal operandCount As Integer, ByVal type As Type) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandType
            Return type Is GetType(Date) OrElse type Is GetType(Date?)
        End Function

        Public ReadOnly Property MaxOperandCount As Integer Implements ICustomFunctionOperatorBrowsable.MaxOperandCount
            Get
                Return 1
            End Get
        End Property

        Public ReadOnly Property MinOperandCount As Integer Implements ICustomFunctionOperatorBrowsable.MinOperandCount
            Get
                Return 1
            End Get
        End Property

#End Region
#Region "ICustomFunctionDisplayAttributes"
        Public ReadOnly Property DisplayName As String Implements ICustomFunctionDisplayAttributes.DisplayName
            Get
                Return "Is Black Friday"
            End Get
        End Property

        Public ReadOnly Property Image As Object Implements ICustomFunctionDisplayAttributes.Image
            Get
                Return Properties.Resources.isBlackFridayDiscount
            End Get
        End Property

#End Region
#Region "ICustomFunctionOperator Members"
        Public Function Evaluate(ParamArray operands As Object()) As Object Implements ICustomFunctionOperator.Evaluate
            Dim [date] As Date = Convert.ToDateTime(operands(0))
            Return [date].Month = 11 AndAlso [date].Day >= 23 AndAlso [date].Day <= 29 AndAlso [date].DayOfWeek = DayOfWeek.Friday
        End Function

        Public ReadOnly Property Name As String Implements ICustomFunctionOperator.Name
            Get
                Return FunctionName
            End Get
        End Property

        Public Function ResultType(ParamArray operands As Type()) As Type Implements ICustomFunctionOperator.ResultType
            Return GetType(Boolean)
        End Function
#End Region
    End Class

    Public Class IsWeekendFunction
        Implements ICustomFunctionDisplayAttributes

        Public Const FunctionName As String = "IsWeekend"

        Private Shared ReadOnly Instance As IsWeekendFunction = New IsWeekendFunction()

        Private Sub New()
        End Sub

        '
        Public Shared Sub Register()
            CriteriaOperator.RegisterCustomFunction(Instance)
        End Sub

        Public Shared Function Unregister() As Boolean
            Return CriteriaOperator.UnregisterCustomFunction(Instance)
        End Function

#Region "ICustomFunctionOperatorBrowsable Members"
        Public ReadOnly Property Category As FunctionCategory Implements ICustomFunctionOperatorBrowsable.Category
            Get
                Return FunctionCategory.DateTime
            End Get
        End Property

        Public ReadOnly Property Description As String Implements ICustomFunctionOperatorBrowsable.Description
            Get
                Return "Is Saturday or Sunday."
            End Get
        End Property

        Public Function IsValidOperandCount(ByVal count As Integer) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandCount
            Return count = 1
        End Function

        Public Function IsValidOperandType(ByVal operandIndex As Integer, ByVal operandCount As Integer, ByVal type As Type) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandType
            Return type Is GetType(Date) OrElse type Is GetType(Date?)
        End Function

        Public ReadOnly Property MaxOperandCount As Integer Implements ICustomFunctionOperatorBrowsable.MaxOperandCount
            Get
                Return 1
            End Get
        End Property

        Public ReadOnly Property MinOperandCount As Integer Implements ICustomFunctionOperatorBrowsable.MinOperandCount
            Get
                Return 1
            End Get
        End Property

#End Region
#Region "ICustomFunctionDisplayAttributes"
        Public ReadOnly Property DisplayName As String Implements ICustomFunctionDisplayAttributes.DisplayName
            Get
                Return "Is Weekend"
            End Get
        End Property

        Public ReadOnly Property Image As Object Implements ICustomFunctionDisplayAttributes.Image
            Get
                Return Properties.Resources.Actions_Calendar
            End Get
        End Property

#End Region
#Region "ICustomFunctionOperator Members"
        Public Function Evaluate(ParamArray operands As Object()) As Object Implements ICustomFunctionOperator.Evaluate
            Dim [date] As Date = Convert.ToDateTime(operands(0))
            Return [date].DayOfWeek = DayOfWeek.Sunday OrElse [date].DayOfWeek = DayOfWeek.Saturday
        End Function

        Public ReadOnly Property Name As String Implements ICustomFunctionOperator.Name
            Get
                Return FunctionName
            End Get
        End Property

        Public Function ResultType(ParamArray operands As Type()) As Type Implements ICustomFunctionOperator.ResultType
            Return GetType(Boolean)
        End Function
#End Region
    End Class

    Public Class NotBeginsWithFunction
        Implements ICustomFunctionDisplayAttributes

        Public Const FunctionName As String = "NotBeginsWith"

        Private Shared ReadOnly Instance As NotBeginsWithFunction = New NotBeginsWithFunction()

        Private Sub New()
        End Sub

        '
        Public Shared Sub Register()
            CriteriaOperator.RegisterCustomFunction(Instance)
        End Sub

        Public Shared Function Unregister() As Boolean
            Return CriteriaOperator.UnregisterCustomFunction(Instance)
        End Function

#Region "ICustomFunctionOperatorBrowsable Members"
        Public ReadOnly Property Category As FunctionCategory Implements ICustomFunctionOperatorBrowsable.Category
            Get
                Return FunctionCategory.Text
            End Get
        End Property

        Public ReadOnly Property Description As String Implements ICustomFunctionOperatorBrowsable.Description
            Get
                Return "Selects items that do not start with the specified string."
            End Get
        End Property

        Public Function IsValidOperandCount(ByVal count As Integer) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandCount
            Return count = 2
        End Function

        Public Function IsValidOperandType(ByVal operandIndex As Integer, ByVal operandCount As Integer, ByVal type As Type) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandType
            Return type Is GetType(String)
        End Function

        Public ReadOnly Property MaxOperandCount As Integer Implements ICustomFunctionOperatorBrowsable.MaxOperandCount
            Get
                Return 2
            End Get
        End Property

        Public ReadOnly Property MinOperandCount As Integer Implements ICustomFunctionOperatorBrowsable.MinOperandCount
            Get
                Return 2
            End Get
        End Property

#End Region
#Region "ICustomFunctionDisplayAttributes"
        Public ReadOnly Property DisplayName As String Implements ICustomFunctionDisplayAttributes.DisplayName
            Get
                Return "Not Begins With"
            End Get
        End Property

        Public ReadOnly Property Image As Object Implements ICustomFunctionDisplayAttributes.Image
            Get
                Return Nothing
            End Get
        End Property

#End Region
#Region "ICustomFunctionOperator Members"
        Public Function Evaluate(ParamArray operands As Object()) As Object Implements ICustomFunctionOperator.Evaluate
            If operands(0) IsNot Nothing AndAlso operands(1) IsNot Nothing Then
                Dim str1 As String = operands(0).ToString()
                Dim str2 As String = operands(1).ToString()
                Return Not str1.StartsWith(str2, StringComparison.InvariantCultureIgnoreCase)
            End If

            Return False
        End Function

        Public ReadOnly Property Name As String Implements ICustomFunctionOperator.Name
            Get
                Return FunctionName
            End Get
        End Property

        Public Function ResultType(ParamArray operands As Type()) As Type Implements ICustomFunctionOperator.ResultType
            Return GetType(Boolean)
        End Function
#End Region
    End Class
End Namespace
