Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports DevExpress.Docs.Text
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Functions

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class CustomFunctionModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Public Sub New()
            InitializeComponent()
            RegisterCustomFunction()
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("NumberInWords_template.xlsx"))
            spreadsheetControl1.Options.Behavior.Selection.MoveActiveCellMode = MoveActiveCellModeOnEnterPress.None
            AddHandler spreadsheetControl1.CellValueChanged, AddressOf SpreadsheetControl1_CellValueChanged
        End Sub

        Private Sub RegisterCustomFunction()
            Dim customFunction As NumberInWordsFunction = New NumberInWordsFunction()
            If Not spreadsheetControl1.Document.GlobalCustomFunctions.Contains(CType(customFunction, ICustomFunction).Name) Then spreadsheetControl1.Document.GlobalCustomFunctions.Add(customFunction)
        End Sub

        Private Sub SpreadsheetControl1_CellValueChanged(ByVal sender As Object, ByVal e As SpreadsheetCellEventArgs)
            Dim sheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
            If Equals(e.SheetName, sheet.Name) AndAlso e.RowIndex = 3 AndAlso e.ColumnIndex = 2 Then
                sheet.Columns(2).AutoFit()
                sheet.Columns(4).AutoFit()
            End If
        End Sub
    End Class

    Public Class NumberInWordsFunction
        Implements ICustomFunction

        Const functionName As String = "SPELLNUMBER"

        Private ReadOnly functionParameters As ParameterInfo()

        Private Shared ReadOnly cultureInfoParamTable As List(Of CultureInfo) = CreateCultureInfoParamTable()

        Public Sub New()
            functionParameters = New ParameterInfo() {New ParameterInfo(ParameterType.Value), New ParameterInfo(ParameterType.Value), New ParameterInfo(ParameterType.Value, ParameterAttributes.Optional)}
        End Sub

        Private ReadOnly Property Name As String Implements IFunction.Name
            Get
                Return functionName
            End Get
        End Property

        Private ReadOnly Property Parameters As ParameterInfo() Implements IFunction.Parameters
            Get
                Return functionParameters
            End Get
        End Property

        Private ReadOnly Property ReturnType As ParameterType Implements IFunction.ReturnType
            Get
                Return ParameterType.Value
            End Get
        End Property

        Private ReadOnly Property Volatile As Boolean Implements IFunction.Volatile
            Get
                Return True
            End Get
        End Property

        Private Function Evaluate(ByVal parameters As IList(Of ParameterValue), ByVal context As EvaluationContext) As ParameterValue Implements IFunction.Evaluate
            Dim isOrdinal As Boolean = False
            Dim numberValue As ParameterValue = parameters(0)
            If numberValue.IsError Then Return numberValue
            Dim cultureValue As ParameterValue = parameters(1)
            If cultureValue.IsError Then Return cultureValue
            If cultureValue.NumericValue < 1 OrElse cultureValue.NumericValue > cultureInfoParamTable.Count Then Return ParameterValue.ErrorNumber
            If parameters.Count = 3 Then
                Dim ordinalValue As ParameterValue = parameters(1)
                If ordinalValue.IsError Then Return ordinalValue
                isOrdinal = ordinalValue.BooleanValue
            End If

            If numberValue.IsText Then Return ParameterValue.ErrorInvalidValueInFunction
            Dim number As Double = numberValue.NumericValue
            Dim culture As CultureInfo = cultureInfoParamTable(CInt(cultureValue.NumericValue) - 1)
            If number < 0 OrElse number > Long.MaxValue Then Return ParameterValue.ErrorNumber
            If isOrdinal Then
                Return NumberInWords.Ordinal.ConvertToText(CLng(Math.Round(number)), culture)
            Else
                Return NumberInWords.Cardinal.ConvertToText(CLng(Math.Round(number)), culture)
            End If
        End Function

        Private Function GetName(ByVal culture As CultureInfo) As String Implements IFunction.GetName
            Return functionName
        End Function

        Private Shared Function CreateCultureInfoParamTable() As List(Of CultureInfo)
            Return New List(Of CultureInfo) From {CultureInfo.GetCultureInfo("en-US"), CultureInfo.GetCultureInfo("en-GB"), CultureInfo.GetCultureInfo("fr-FR"), CultureInfo.GetCultureInfo("de-DE"), CultureInfo.GetCultureInfo("el-GR"), CultureInfo.GetCultureInfo("hi-IN"), CultureInfo.GetCultureInfo("it-IT"), CultureInfo.GetCultureInfo("pt-PT"), CultureInfo.GetCultureInfo("ru-RU"), CultureInfo.GetCultureInfo("es-ES"), CultureInfo.GetCultureInfo("sv-SE"), CultureInfo.GetCultureInfo("th-TH"), CultureInfo.GetCultureInfo("tr-TR"), CultureInfo.GetCultureInfo("uk-UA")}
        End Function
    End Class
End Namespace
