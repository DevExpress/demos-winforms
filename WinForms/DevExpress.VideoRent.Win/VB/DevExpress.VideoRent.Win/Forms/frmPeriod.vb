Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmPeriod
		Inherits XtraForm

		Public Sub New()
			Me.New(PeriodType.All)
		End Sub
		Public Sub New(ByVal type As PeriodType)
			InitializeComponent()
			InitData(type)
		End Sub
		Private ReadOnly Property CurrentReceiptPeriod() As Period
			Get
				Return PeriodManager.ReceiptPeriod
			End Get
		End Property
		Private ReadOnly Property CurrentKPIPeriod() As Period
			Get
				Return PeriodManager.KPIPeriod
			End Get
		End Property
        Private Sub InitData(ByVal type As PeriodType)
            emptySpaceItem1.Visibility = LayoutVisibility.Never
            ucPeriodKPI.InitData(CurrentKPIPeriod.StartDate, CurrentKPIPeriod.EndDate)
            ucPeriodReport.InitData(CurrentReceiptPeriod.StartDate, CurrentReceiptPeriod.EndDate)

            If type <> PeriodType.All Then
                tgcMain.Ungroup()
            End If

            If (Not Object.Equals(type, PeriodType.KPI)) Then
                lcgReceipt.Visibility = LayoutVisibility.Always
            Else
                lcgReceipt.Visibility = LayoutVisibility.Never
            End If
            If (Not Object.Equals(type, PeriodType.Receipt)) Then
                lcgKPI.Visibility = LayoutVisibility.Always
            Else
                lcgKPI.Visibility = LayoutVisibility.Never
            End If

            lcgKPI.Height = lcMain.Height
            lcgReceipt.Height = lcgKPI.Height
        End Sub

		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			MyBase.OnClosing(e)
			If Me.DialogResult = System.Windows.Forms.DialogResult.OK Then
				e.Cancel = Not SaveData()
			End If
		End Sub

		Private Function SaveData() As Boolean
			Dim ret As Boolean = ucPeriodKPI.ValidateDates()
			If ret Then
				CurrentKPIPeriod.StartDate = ucPeriodKPI.StartDate
				CurrentKPIPeriod.EndDate = ucPeriodKPI.EndDate
				ret = ucPeriodReport.ValidateDates()
			Else
				lcMain.FocusHelper.PlaceItemIntoView(lcgKPI)
				Return ret
			End If
			If ret Then
				CurrentReceiptPeriod.StartDate = ucPeriodReport.StartDate
				CurrentReceiptPeriod.EndDate = ucPeriodReport.EndDate
			Else
				lcMain.FocusHelper.PlaceItemIntoView(lcgReceipt)
			End If
			Return ret
		End Function
	End Class
End Namespace
