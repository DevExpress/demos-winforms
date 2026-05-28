Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports System.Data
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports DevExpress.XtraReports.Extensions
Imports DevExpress.Utils.Design
Imports System.ComponentModel

Namespace DevExpress.VideoRent.Reports
	Public Enum TimePeriod
		Custom
		Month
		ThreeMonths
		SixMonths
		Year
		TwoYears
		FiveYears
		TenYears
	End Enum
	Partial Public Class TimePeriodReportBase
		Inherits ReportBase
		#Region "inner classes"
		Private Class DateTimeCorrector
			Private months As Integer
			Private years As Integer

			Public Sub New(ByVal months As Integer, ByVal years As Integer)
				Me.months = months
				Me.years = years
			End Sub

			Public ReadOnly Property IsEmpty() As Boolean
				Get
					Return months = 0 AndAlso years = 0
				End Get
			End Property

			Public Function Correct(ByVal time As DateTime) As DateTime
				Return time.AddMonths(months).AddYears(years)
			End Function
		End Class
		Private Class TimePeriodDesignExtention
			Inherits ReportDesignExtension
			Public Overrides Sub AddParameterTypes(ByVal dictionary As IDictionary(Of Type, String))
				dictionary.Add(GetType(TimePeriod), "TimePeriod")
			End Sub
		End Class
		Private Class TimePeriodParametersExtention
			Inherits ParametersRequestExtension
			Private canUpdateEditors As Boolean = True
            Private Shared _FindParameterInfoName As String

            Private Shared Function FindParameterInfo(ByVal parametersInfo As IList(Of EditParameterInfo), ByVal name As String) As EditParameterInfo
                _FindParameterInfoName = name
                Return New List(Of EditParameterInfo)(parametersInfo).Find(AddressOf FindParameterInfoDelegate)
            End Function

            Private Shared Function FindParameterInfoDelegate(ByVal item As EditParameterInfo) As Boolean
                Return item.Parameter.Name = _FindParameterInfoName
            End Function

            Private Shared Function FindEditor(ByVal parametersInfo As IList(Of EditParameterInfo), ByVal name As String) As BaseEdit
				Dim info As EditParameterInfo = FindParameterInfo(parametersInfo, name)
                If Not Object.Equals(info, Nothing) Then
                    Return info.Editor
                Else
                    Return Nothing
                End If
			End Function
			Protected Overrides Sub OnBeforeShow(ByVal parametersInfo As IList(Of EditParameterInfo), ByVal report As XtraReport)
				Dim info As EditParameterInfo = FindParameterInfo(parametersInfo, periodParamName)
				If Object.Equals(info, Nothing) Then
					Return
				End If
				info.Editor = CreatePeriodEditor(New TimePeriod() { TimePeriod.Custom, TimePeriod.Month, TimePeriod.ThreeMonths, TimePeriod.SixMonths, TimePeriod.Year, TimePeriod.TwoYears, TimePeriod.FiveYears, TimePeriod.TenYears }, New String() { "(Custom)", "Month", "3 Months", "6 Months", "Year", "2 Years", "5 Years", "10 Years" })
                Dim _timePeriod As TimePeriod = CType(info.Parameter.Value, TimePeriod)
                If _timePeriod <> TimePeriod.Custom Then
                    Dim corrector As DateTimeCorrector = CreateCorrector(_timePeriod)
                    Dim endTime As DateTime = DateTime.Now
                    FindParameterInfo(parametersInfo, startDateParamName).Parameter.Value = CObj(corrector.Correct(endTime))
                    FindParameterInfo(parametersInfo, endDateParamName).Parameter.Value = CObj(endTime)
                End If
				Dim startDateEdit As DateEdit = CType(FindEditor(parametersInfo, startDateParamName), DateEdit)
				startDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
				Dim endDateEdit As DateEdit = CType(FindEditor(parametersInfo, endDateParamName), DateEdit)
				endDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
			End Sub
			Private Shared Function CreatePeriodEditor(ByVal values As Array, ByVal names() As String) As BaseEdit
				Dim result As New ImageComboBoxEdit()
				Dim i As Integer = 0
				Do While i < values.Length AndAlso i < names.Length
					result.Properties.Items.Add(New ImageComboBoxItem(names(i), values.GetValue(i)))
					i += 1
				Loop
				result.Properties.PopupFormMinSize = New System.Drawing.Size(result.Properties.PopupFormMinSize.Width, result.Properties.PopupFormMinSize.Height + 135)
				Return result
			End Function
			Protected Overrides Sub OnEditorValueChanged(ByVal parametersInfo As IList(Of EditParameterInfo), ByVal changedInstance As EditParameterInfo, ByVal report As XtraReport)
				Select Case changedInstance.Parameter.Name
					Case periodParamName
						OnPeriodEditValueChanged(parametersInfo)
					Case startDateParamName
						OnStartDateDateEditValueChanged(parametersInfo)
					Case endDateParamName
						OnEndDateEditValueChanged(parametersInfo)
					Case Else
						Throw New Exception("Invalid switch's branch.")
				End Select
			End Sub
			Private Sub OnStartDateDateEditValueChanged(ByVal parametersInfo As IList(Of EditParameterInfo))
				If (Not canUpdateEditors) Then
					Return
				End If
				Dim edit As DateEdit = CType(FindEditor(parametersInfo, startDateParamName), DateEdit)
				If Object.Equals(edit, Nothing) Then
					Return
				End If
				edit.DoValidate()
				SetValue(FindEditor(parametersInfo, periodParamName), TimePeriod.Custom)
			End Sub
			Private Sub OnEndDateEditValueChanged(ByVal parametersInfo As IList(Of EditParameterInfo))
				If (Not canUpdateEditors) Then
					Return
				End If
				Dim edit As DateEdit = CType(FindEditor(parametersInfo, endDateParamName), DateEdit)
				If Object.Equals(edit, Nothing) Then
					Return
				End If
				edit.DoValidate()
				SetValue(FindEditor(parametersInfo, periodParamName), TimePeriod.Custom)
			End Sub
			Private Sub OnPeriodEditValueChanged(ByVal parametersInfo As IList(Of EditParameterInfo))
				If (Not canUpdateEditors) Then
					Return
				End If
				Dim edit As BaseEdit = FindEditor(parametersInfo, periodParamName)
				If Object.Equals(edit, Nothing) Then
					Return
				End If
				edit.DoValidate()
				Dim corrector As DateTimeCorrector = CreateCorrector(CType(edit.EditValue, TimePeriod))
				If Object.Equals(corrector, Nothing) OrElse corrector.IsEmpty Then
					Return
				End If
				Dim endTime As DateTime = DateTime.Now
				SetValue(FindEditor(parametersInfo, startDateParamName), corrector.Correct(endTime))
				SetValue(FindEditor(parametersInfo, endDateParamName), endTime)
			End Sub
			Private Sub SetValue(ByVal editor As BaseEdit, ByVal value As Object)
				canUpdateEditors = False
				Try
					If (Not Object.Equals(editor, Nothing)) Then
						editor.EditValue = value
						editor.IsModified = True
						editor.DoValidate()
					End If
				Finally
					canUpdateEditors = True
				End Try
			End Sub
		End Class
		#End Region

		Protected Const startDateParamName As String = "paramStartDate"
		Protected Const endDateParamName As String = "paramEndDate"
		Protected Const periodParamName As String = "paramPeriod"
		Private Shared defaultTimePeriod As TimePeriod = TimePeriod.ThreeMonths

		Shared Sub New()
			ParametersRequestExtension.RegisterExtension(New TimePeriodParametersExtention(), "TimePeriodReport")
			ReportDesignExtension.RegisterExtension(New TimePeriodDesignExtention(), "TimePeriodReport")
		End Sub
		Private Shared Function CreateCorrector(ByVal timePeriod As TimePeriod) As DateTimeCorrector
			Select Case timePeriod
				Case TimePeriod.Month
					Return New DateTimeCorrector(-1, 0)
				Case TimePeriod.ThreeMonths
					Return New DateTimeCorrector(-3, 0)
				Case TimePeriod.SixMonths
					Return New DateTimeCorrector(-6, 0)
				Case TimePeriod.Year
					Return New DateTimeCorrector(0, -1)
				Case TimePeriod.TwoYears
					Return New DateTimeCorrector(0, -2)
				Case TimePeriod.FiveYears
					Return New DateTimeCorrector(0, -5)
				Case TimePeriod.TenYears
					Return New DateTimeCorrector(0, -10)
				Case Else
					Return New DateTimeCorrector(0, 0)
			End Select
		End Function

		Public Sub New()
			InitializeComponent()
			ParametersRequestExtension.AssociateReportWithExtension(Me, "TimePeriodReport")
			ReportDesignExtension.AssociateReportWithExtension(Me, "TimePeriodReport")

			Dim startDateParameter As Parameter = CreateParameter(startDateParamName, GetType(DateTime), "Start Date:", CreateCorrector(defaultTimePeriod).Correct(DateTime.Now))
			Dim endDateParameter As Parameter = CreateParameter(endDateParamName, GetType(DateTime), "End Date:", DateTime.Now)
			Dim periodParameter As Parameter = CreateParameter(periodParamName, GetType(TimePeriod), "Last Time Span:", defaultTimePeriod)
			Me.Parameters.AddRange(New Parameter() { startDateParameter, endDateParameter, periodParameter })
		End Sub
        Private Overloads Function CreateParameter(ByVal name As String, ByVal type As Type, ByVal description As String, ByVal value As Object) As Parameter
			Dim parameter As New Parameter()
			parameter.Name = name
			parameter.Type = type
			parameter.Description = description
			parameter.Value = value
			Return parameter
		End Function
	End Class
End Namespace
