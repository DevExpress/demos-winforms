Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.LookAndFeel

Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucCustomerInfo
		Inherits XtraUserControl
		Public Event DoEdit As EventHandler
		Private tmr As Timer
        Private fcustomer As Customer

        Public Sub New()
            InitializeComponent()
            If (Not Object.Equals(Me.FindForm(), Nothing)) Then
                AddHandler FindForm().SizeChanged, AddressOf ucCustomerInfo_SizeChanged
            End If
        End Sub
        Public ReadOnly Property Customer() As Customer
            Get
                Return fcustomer
            End Get
        End Property
        Private ReadOnly Property PictureTimer() As Timer
            Get
                If Object.Equals(tmr, Nothing) Then
                    tmr = New Timer()
                    tmr.Interval = 100
                    tmr.Enabled = False
                    AddHandler tmr.Tick, AddressOf tmr_Tick
                End If
                Return tmr
            End Get
        End Property
        Private Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
            SizePhoto()
            PictureTimer.Stop()
        End Sub
        Public Sub Init(ByVal customer As Customer, ByVal hint As String)
            Init(customer, hint, Nothing)
        End Sub
        Public Sub Init(ByVal customer As Customer, ByVal hint As String, ByVal toolTip As String)
            If (Not Object.Equals(customer, Nothing)) Then
                If Object.Equals(customer.Photo, Nothing) Then
                    pePhoto.Image = ReferenceImages.UnknownPerson
                Else
                    pePhoto.Image = customer.Photo
                    pePhoto.Image = pePhoto.Image
                End If
            Else
                pePhoto.Image = Nothing
            End If
            If Object.Equals(customer, Nothing) Then
                lciInfo.Visibility = LayoutVisibility.Never
            Else
                lciInfo.Visibility = LayoutVisibility.Always
            End If
            If (Not Object.Equals(customer, Nothing)) Then
                lciHint.Visibility = LayoutVisibility.Never
            Else
                lciHint.Visibility = LayoutVisibility.Always
            End If
            lcInfo.Text = GetCustomerInfo(customer)
            SizePhoto()
            npMain.Text = hint
            If (Not String.IsNullOrEmpty(toolTip)) Then
                pePhoto.ToolTip = toolTip
                pePhoto.Cursor = Cursors.Hand
            Else
                pePhoto.Cursor = Cursors.Default
            End If
            Me.fcustomer = customer
            Me.Refresh()
        End Sub
		Private lockResize As Boolean = False
		Private Sub SizePhoto()
			If lockResize Then
				Return
			End If
			lockResize = True
			Dim img As Image = pePhoto.Image
			Try
				If Object.Equals(img, Nothing) Then
					lciPhoto.Visibility = LayoutVisibility.Never
					Return
				Else
					lciPhoto.Visibility = LayoutVisibility.Always
				End If
				lciPhoto.Height = Math.Min(lciPhoto.Width * img.Height \ img.Width, img.Height)
			Finally
				lockResize = False
			End Try
		End Sub
		Private Sub pePhoto_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles pePhoto.Resize
            PictureTimer.Start()
		End Sub
		Private Sub ucCustomerInfo_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            PictureTimer.Start()
		End Sub
		Private Function GetCustomerInfo(ByVal customer As Customer) As String
			If Object.Equals(customer, Nothing) Then
				Return String.Empty
			End If
			Return customer.GetCustomerInfoHtml()
		End Function
		Private Sub RaiseDoEdit()
			If (Not Object.Equals(DoEditEvent, Nothing)) Then
                RaiseEvent DoEdit(Me, EventArgs.Empty)
			End If
		End Sub
		Private Sub pePhoto_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles pePhoto.DoubleClick
			RaiseDoEdit()
		End Sub

		Private Sub lcInfo_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lcInfo.DoubleClick
			RaiseDoEdit()
		End Sub
	End Class
End Namespace
