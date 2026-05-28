Imports System
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Summary

Namespace DevExpress.XtraGrid.Demos

    ' Integer
    Public Class IsBlackFridayDiscountFunction
        Implements ICustomFunctionDisplayAttributes

        Public Const FunctionName As String = "IsBlackFridayDiscount"

        Private Shared ReadOnly Instance As IsBlackFridayDiscountFunction = New IsBlackFridayDiscountFunction()

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
                Return FunctionCategory.Math
            End Get
        End Property

        Public ReadOnly Property Description As String Implements ICustomFunctionOperatorBrowsable.Description
            Get
                Return "The discount amount is 15% or more."
            End Get
        End Property

        Public Function IsValidOperandCount(ByVal count As Integer) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandCount
            Return count = 1
        End Function

        Public Function IsValidOperandType(ByVal operandIndex As Integer, ByVal operandCount As Integer, ByVal type As Type) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandType
            Return SummaryItemTypeHelper.IsNumericalType(type)
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
                Return "Is Black Friday Discount"
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
            Dim discount As Double = Convert.ToDouble(operands(0))
            Return discount >= 0.15
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

    ' DateTime & Mixed
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
                Return "Determines if a day falls on a weekend."
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

    Public Class DaysBeforeOrAfterTodayFunction
        Implements ICustomFunctionDisplayAttributesEx

        Public Const FunctionName As String = "DaysBeforeOrAfterToday"

        Private Shared ReadOnly Instance As DaysBeforeOrAfterTodayFunction = New DaysBeforeOrAfterTodayFunction()

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
                Return "Shows items that within X days before or after today."
            End Get
        End Property

        Public Function IsValidOperandCount(ByVal count As Integer) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandCount
            Return count = 2
        End Function

        Public Function IsValidOperandType(ByVal operandIndex As Integer, ByVal operandCount As Integer, ByVal type As Type) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandType
            Return operandIndex = 0 AndAlso type Is GetType(Date) OrElse operandIndex = 1 AndAlso type Is GetType(Integer)
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
                Return "Days before or after today"
            End Get
        End Property

        Public ReadOnly Property Image As Object Implements ICustomFunctionDisplayAttributes.Image
            Get
                Return "SwitchTimeScalesTo;Size16x16;Colored"
            End Get
        End Property

#End Region
#Region "ICustomFunctionOperator Members"
        Public Function Evaluate(ParamArray operands As Object()) As Object Implements ICustomFunctionOperator.Evaluate
            Dim dt As Date = Convert.ToDateTime(operands(0))
            Dim days As Integer = Convert.ToInt32(operands(1))
            Dim start As Date = Date.Today.AddDays(-days)
            Dim [end] As Date = Date.Today.AddDays(days)
            Return dt >= start AndAlso dt <= [end]
        End Function

        Public ReadOnly Property Name As String Implements ICustomFunctionOperator.Name
            Get
                Return FunctionName
            End Get
        End Property

        Public Function ResultType(ParamArray operands As Type()) As Type Implements ICustomFunctionOperator.ResultType
            Return GetType(Boolean)
        End Function

        Public Function GetOperandDisplayValue(ByVal value As Object, ByVal displayText As String) As String Implements ICustomFunctionDisplayAttributesEx.GetOperandDisplayValue
            If TypeOf value Is Integer Then Return String.Format("{0} days", value)
            Return value?.ToString()
        End Function
#End Region
    End Class

    ' String
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
