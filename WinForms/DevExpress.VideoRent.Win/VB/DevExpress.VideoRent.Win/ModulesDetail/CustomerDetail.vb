Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors

Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class CustomerDetail
		Inherits DetailBase
		Public Sub New(ByVal parent As Form, ByVal session As UnitOfWork, ByVal customer As Customer, ByVal manager As IDXMenuManager, ByVal closeForm As CloseDetailForm)
			MyBase.New(parent, session, customer, manager, closeForm)
			InitializeComponent()
			If (Not Object.Equals(customer, Nothing)) Then
				Text =customer.FullName
			Else
				Text =ConstStrings.NewCustomer
			End If
		End Sub
		Protected Overrides ReadOnly Property HomeButtonCaption() As String
			Get
				Return ConstStrings.CustomerList
			End Get
		End Property
		Public ReadOnly Property Customer() As Customer
			Get
				Return TryCast(editObject, Customer)
			End Get
		End Property
		Protected Overrides Sub InitData()
			MyBase.InitData()
			InitEditors()
			If Object.Equals(Customer, Nothing) Then
				Return
			End If
			teFirstName.Text = Customer.FirstName
			teLastName.Text = Customer.LastName
			teMiddleName.Text = Customer.MiddleName
			icbGender.EditValue = Customer.Gender
			If (Not Object.Equals(Customer.BirthDate, Nothing)) Then
				deBirthDate.DateTime = Customer.BirthDate.Value
			End If
			tePhone.Text = Customer.Phone
			beEmail.Text = Customer.Email
			meAddress.Text = Customer.Address
			meComments.Text = Customer.Comments
			pePhoto.Image = Customer.Photo
			icbDiscountLevel.EditValue = Customer.DiscountLevel
			teDiscount.EditValue = Customer.Discount
			ucPictureEditBar1.Init(pePhoto, LayoutManager)
		End Sub
		Protected Overrides Sub InitValidation()
			ValidationProvider.SetValidationRule(teFirstName, ValidationRulesHelper.RuleIsNotBlank)
			ValidationProvider.SetValidationRule(teLastName, ValidationRulesHelper.RuleIsNotBlank)
		End Sub
		Private Sub InitEditors()
			EditorHelper.CreateGenderImageComboBox(icbGender.Properties, Nothing)
			EditorHelper.CreateDiscountLevelImageComboBox(icbDiscountLevel.Properties, Nothing)
			EditorHelper.CreateDiscountTextEdit(teDiscount.Properties)
			pePhoto.Properties.NullText = ConstStrings.NoImageData
			npDiscount.Text = ConstStrings.DiscountNote
		End Sub
		Protected Overrides Sub UpdateReadOnlyData()
			MyBase.UpdateReadOnlyData()
			If [ReadOnly] Then
				lciBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			Else
				lciBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
			End If
		End Sub
		Protected Overrides Sub SaveData()
			MyBase.SaveData()
			Customer.FirstName = teFirstName.Text
			Customer.LastName = teLastName.Text
			Customer.MiddleName = teMiddleName.Text
			Customer.Gender = CType(icbGender.EditValue, PersonGender)
			Customer.BirthDate = deBirthDate.DateTime
            If Object.Equals(Customer.BirthDate, DateTime.MinValue) Then
                Customer.BirthDate = Nothing
            End If
			Customer.Phone = tePhone.Text
			Customer.Email = beEmail.Text
			Customer.Address = meAddress.Text
			Customer.Comments = meComments.Text
			Customer.Photo = pePhoto.Image
			CommitSession()
		End Sub
		Protected Overrides Function CreateNewObject() As VideoRentBaseObject
			MyBase.CreateNewObject()
			Return New Customer(Session)
		End Function

		Private Sub beEmail_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beEmail.ButtonClick
            If (Data.Utils.SafeProcess.Start(String.Format("MailTo:{0}", beEmail.Text)) Is Nothing) Then
                XtraMessageBox.Show("", ConstStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub
		Private Sub beEmail_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles beEmail.TextChanged
			beEmail.Properties.Buttons(0).Enabled = Not String.IsNullOrEmpty(beEmail.Text.Trim())
		End Sub
		Protected Friend Overrides Sub LoadPicture()
			MyBase.LoadPicture()
			ucPictureEditBar1.LoadPicture()
		End Sub
		Protected Friend Overrides Sub ClearPicture()
			MyBase.ClearPicture()
			ucPictureEditBar1.ClearPicture()
		End Sub
	End Class
End Namespace
