Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DevExpress.SalesDemo.Win.Modules
	Partial Public Class ucValuePresenter
		Inherits UserControl

		Private doubleValue As Double
'INSTANT VB NOTE: The field valueFormat was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private valueFormat_Renamed As String

		Public Property ValueTextColor() As Color
			Get
				Return labelValue.ForeColor
			End Get
			Set(ByVal value As Color)
				labelValue.ForeColor = value
			End Set
		End Property
		Public Property TitleText() As String
			Get
				Return labelTitle.Text
			End Get
			Set(ByVal value As String)
				labelTitle.Text = value
			End Set
		End Property
		Public Property ValueFormat() As String
			Get
				Return valueFormat_Renamed
			End Get
			Set(ByVal value As String)
				valueFormat_Renamed = value
				UpdateValueText()
			End Set
		End Property
		Public Property Value() As Double
			Get
				Return doubleValue
			End Get
			Set(ByVal value As Double)
				doubleValue = value
				UpdateValueText()
			End Set
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub UpdateValueText()
			If valueFormat_Renamed IsNot Nothing Then
				labelValue.Text = String.Format(valueFormat_Renamed, doubleValue)
			Else
				labelValue.Text = doubleValue.ToString()
			End If
		End Sub
	End Class
End Namespace
