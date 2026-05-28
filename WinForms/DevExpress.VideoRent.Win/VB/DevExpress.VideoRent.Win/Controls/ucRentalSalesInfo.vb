Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Utils.Menu
Imports DevExpress.Data.Filtering

Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucRentalSalesInfo
		Inherits XtraUserControl
		Private categoryPrice As MovieCategoryPrice
		Private countInfo As MovieItem.CountInfo
		Private format As Nullable(Of MovieItemFormat)
		Public Sub New()
			MyBase.New()
			InitializeComponent()
		End Sub
		Public Sub New(ByVal categoryPrice As MovieCategoryPrice, ByVal countInfo As MovieItem.CountInfo, ByVal format As Nullable(Of MovieItemFormat), ByVal manager As IDXMenuManager)
			Me.New()
			Init(categoryPrice, countInfo, format, manager)
		End Sub
		Public Sub Init(ByVal categoryPrice As MovieCategoryPrice, ByVal countInfo As MovieItem.CountInfo, ByVal format As Nullable(Of MovieItemFormat), ByVal manager As IDXMenuManager)
			Me.categoryPrice = categoryPrice
			Me.countInfo = countInfo
			Me.format = format
			lcMain.MenuManager = manager
			InitData()
		End Sub
		Private Sub InitData()
			If Object.Equals(categoryPrice, Nothing) Then
				lciDefaultPrice.Visibility = XtraLayout.Utils.LayoutVisibility.Never
				lciDefaultDays.Visibility = XtraLayout.Utils.LayoutVisibility.Never
			Else
				teDefaultPrice.Text = categoryPrice.DefaultPrice.ToString()
				teDefaultDays.Text = categoryPrice.DefaultRentDays.ToString()
			End If
			If Object.Equals(format, Nothing) Then
				lbItemsCount.Text = String.Format(ConstStrings.ItemsCountHtmlCaption, countInfo.Total)
			Else
				Dim formatIndex As Integer = countInfo.FormatIndex(format.Value)
				lbItemsCount.Text = String.Format(ConstStrings.ItemsCountHtmlCaption, countInfo.WithFormat(formatIndex))
			End If
			lbItemsInfo.Text = GetCountInfoCaption(format, countInfo)
		End Sub
		Private Shared Function GetCountInfoCaption(ByVal format As Nullable(Of MovieItemFormat), ByVal countInfo As MovieItem.CountInfo) As String
			Dim formatIndex As Integer
			If Object.Equals(format, Nothing) Then
				formatIndex = -1
			Else
				formatIndex = countInfo.FormatIndex(format.Value)
			End If
			Dim ret As String
			If Object.Equals(format, Nothing) Then
				If Object.Equals(format, Nothing) Then
					If Object.Equals(format, Nothing) Then
						If Object.Equals(format, Nothing) Then
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						Else
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						End If
					Else
						If Object.Equals(format, Nothing) Then
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						Else
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						End If
					End If
				Else
					If Object.Equals(format, Nothing) Then
						If Object.Equals(format, Nothing) Then
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						Else
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						End If
					Else
						If Object.Equals(format, Nothing) Then
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						Else
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						End If
					End If
				End If
			Else
				If Object.Equals(format, Nothing) Then
					If Object.Equals(format, Nothing) Then
						If Object.Equals(format, Nothing) Then
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						Else
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						End If
					Else
						If Object.Equals(format, Nothing) Then
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						Else
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						End If
					End If
				Else
					If Object.Equals(format, Nothing) Then
						If Object.Equals(format, Nothing) Then
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						Else
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.ForSell,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						End If
					Else
						If Object.Equals(format, Nothing) Then
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						Else
							If Object.Equals(format, Nothing) Then
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							Else
								If Object.Equals(format, Nothing) Then
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithStatus(countInfo.StatusIndex(MovieItemStatus.Sold)))
								Else
									ret = String.Format(ConstStrings.ItemsCountDetailHtmlCaption,countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)),countInfo.WithFormatForSell(formatIndex),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)),countInfo.WithFormatAndStatus(formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)))
								End If
							End If
						End If
					End If
				End If
			End If
			Return ret
		End Function
	End Class
End Namespace
