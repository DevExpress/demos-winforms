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
Imports DevExpress.Xpo.DB.Helpers
Imports DevExpress.Xpo.Demos
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo.Metadata

Namespace DevExpress.Xpo.Demos
	Partial Public Class ModifiedProperties
		Inherits TutorialControl
        Public Overrides Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.SetNewWhatsThisPadding() = value
            End Set
        End Property
        Private messages() As String = {Resources.ModifiedPropertiesMessagesN1, Resources.ModifiedPropertiesMessagesN2, Resources.ModifiedPropertiesMessagesN3, Resources.ModifiedPropertiesMessagesN4, Resources.ModifiedPropertiesMessagesN5, Resources.ModifiedPropertiesMessagesN6}

        Private customer1 As Customer
        Private customer2 As Customer
        Private customerOid As Integer

        Private person1 As Person
        Private person2 As Person
        Private personOid As Integer

        Private olrb1 As OptimisticLockingReadBehavior
        Private olrb2 As OptimisticLockingReadBehavior

        Private generalData As New MPData()
        Private customData As New MPData()

        Private comboSource1() As String = System.Enum.GetNames(GetType(OptimisticLockingReadBehavior))
        Private comboSource2() As String = System.Enum.GetNames(GetType(OptimisticLockingReadBehavior))
		Public Sub New()
			InitializeComponent()
            AssignState(0)

            InitCustomDataObject()
            InitCustomTabPage()
            CreateCustomBinding()
            timer1.Start()
        End Sub
        Private _currentState As Integer
        Public ReadOnly Property CurrentState() As Integer
            Get
                Return _currentState
            End Get
        End Property
        Public Sub UpdateControls()
            UpdateEditor(teC1ContactTitle, customer1, "ContactTitle")
            UpdateEditor(teC1ContactName, customer1, "ContactName")
            UpdateEditor(teC1CompanyName, customer1, "CompanyName")
            UpdateEditor(teC1Country, customer1, "Country")
            UpdateEditor(teC1City, customer1, "City")
            UpdateEditor(teC1Phone, customer1, "Phone")

            UpdateEditor(teC2ContactTitle, customer2, "ContactTitle")
            UpdateEditor(teC2ContactName, customer2, "ContactName")
            UpdateEditor(teC2CompanyName, customer2, "CompanyName")
            UpdateEditor(teC2Country, customer2, "Country")
            UpdateEditor(teC2City, customer2, "City")
            UpdateEditor(teC2Phone, customer2, "Phone")

            sbNext.Enabled = CurrentState < (messages.Length - 1)
            CType(gcProgress.Gauges(0), ILinearGauge).Scales(0).Value = CurrentState * 20
            Dim message As String = If(CurrentState >= messages.Length, "", messages(CurrentState))
            If CurrentState = 0 Then
                pnlHint.Text = message
            Else
                pnlHint.Text = String.Format("Step #{0} - {1}", CurrentState, message)
            End If
        End Sub
        Public Sub UpdateEditor(ByVal textEdit As TextEdit, ByVal customer As Customer, ByVal propertyName As String)
            Dim member As XPMemberInfo = customer.ClassInfo.GetMember(propertyName)
            Dim memberValue As String
            If member.GetModified(customer) Then
                memberValue = String.Format("{0} (old value: {1})", member.GetValue(customer), member.GetOldValue(customer))
            Else
                memberValue = CStr(member.GetValue(customer))
            End If
            textEdit.Text = memberValue
            textEdit.Properties.ReadOnly = True
        End Sub

        Private Sub sbNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbNext.Click
            AssignState(CurrentState + 1)
        End Sub
        Private Sub sbReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbReset.Click
            AssignState(0)
        End Sub
        '<lcModifiedProperties>
        Private Sub AssignState(ByVal state As Integer)
            If state > 0 AndAlso (state < _currentState OrElse state - _currentState > 1 OrElse state >= messages.Length) Then
                Return
            End If
            _currentState = state
            Select Case state
                Case 0
                    generalData.DataLayer = New SimpleDataLayer(New InMemoryDataStore(AutoCreateOption.DatabaseAndSchema))
                    Using uow As New UnitOfWork(generalData.dataLayer)
                        Dim customer As New Customer(uow)
                        customer.ContactName = "Maria Anders"
                        customer.ContactTitle = "Sales Representative"
                        customer.CompanyName = "Alfreds Futterkiste"
                        customer.Country = "Germany"
                        customer.City = "Berlin"
                        customer.Phone = "030-0074321"
                        uow.CommitChanges()
                        customerOid = customer.Oid
                    End Using
                    generalData.Uow1 = New UnitOfWork(generalData.DataLayer)
                    generalData.Uow2 = New UnitOfWork(generalData.DataLayer)
                    customer1 = generalData.Uow1.GetObjectByKey(Of Customer)(customerOid)
                    customer2 = generalData.Uow2.GetObjectByKey(Of Customer)(customerOid)
                Case 1
                    customer1.CompanyName = "Frankenversand"
                    customer2.Phone = "030-0877310"
                Case 2
                    generalData.Uow2.CommitChanges()
                    customer1.Reload()
                Case 3
                    customer1.CompanyName = "Blauer See Delikatessen"
                    customer2.CompanyName = "Drachenblut Delikatessen"
                Case 4
                    generalData.Uow2.CommitChanges()
                    Try
                        customer1.Reload()
                    Catch ex As Exception
                        XtraMessageBox.Show(Me, ex.Message, frmMain.DemoNameConst)
                    End Try
                Case 5
                    Dim miCompanyName As XPMemberInfo = customer1.ClassInfo.GetMember("CompanyName")
                    miCompanyName.ResetModified(customer1)
                    customer1.Reload()
            End Select
            UpdateControls()
        End Sub
        '</lcModifiedProperties>        
        Private Sub InitCustomDataObject()
            customData.DataLayer = New SimpleDataLayer(New InMemoryDataStore(AutoCreateOption.DatabaseAndSchema))
            Using uow As New UnitOfWork(customData.DataLayer)
                Dim person As New Person(uow)
                person.ContactName = "Maria Anders"
                person.ContactTitle = "Sales Representative"
                person.CompanyName = "Alfreds Futterkiste"
                person.Country = "Germany"
                person.City = "Berlin"
                person.Phone = "030-0074321"
                uow.CommitChanges()
                personOid = person.Oid
            End Using
            customData.Uow1 = New UnitOfWork(customData.DataLayer)
            customData.Uow2 = New UnitOfWork(customData.DataLayer)
            customData.Uow1.TrackPropertiesModifications = True
            customData.Uow2.TrackPropertiesModifications = True
            person1 = customData.Uow1.GetObjectByKey(Of Person)(personOid)
            person2 = customData.Uow2.GetObjectByKey(Of Person)(personOid)
        End Sub
        Private Sub InitCustomTabPage()
            comboBoxEdit1.Properties.Items.AddRange(comboSource1)
            comboBoxEdit1.SelectedIndex = 0
            comboBoxEdit2.Properties.Items.AddRange(comboSource2)
            comboBoxEdit2.SelectedIndex = 0
        End Sub
        Private Sub CreateCustomBinding()
            buttonEdit1.DataBindings.Add("EditValue", person1, "ContactTitle")
            buttonEdit2.DataBindings.Add("EditValue", person1, "ContactName")
            buttonEdit3.DataBindings.Add("EditValue", person1, "CompanyName")
            buttonEdit4.DataBindings.Add("EditValue", person1, "Country")
            buttonEdit5.DataBindings.Add("EditValue", person1, "City")
            buttonEdit6.DataBindings.Add("EditValue", person1, "Phone")
            buttonEdit7.DataBindings.Add("EditValue", person2, "ContactTitle")
            buttonEdit8.DataBindings.Add("EditValue", person2, "ContactName")
            buttonEdit9.DataBindings.Add("EditValue", person2, "CompanyName")
            buttonEdit10.DataBindings.Add("EditValue", person2, "Country")
            buttonEdit11.DataBindings.Add("EditValue", person2, "City")
            buttonEdit12.DataBindings.Add("EditValue", person2, "Phone")
        End Sub
        Private Sub comboBoxEdit1_Properties_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit1.Properties.SelectedIndexChanged
            Dim currentEdit As ComboBoxEdit = TryCast(sender, ComboBoxEdit)
            olrb1 = CType(System.Enum.Parse(GetType(OptimisticLockingReadBehavior), CStr(currentEdit.SelectedItem), True), OptimisticLockingReadBehavior)
            customData.Uow1.OptimisticLockingReadBehavior = olrb1
        End Sub

        Private Sub comboBoxEdit2_Properties_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit2.Properties.SelectedIndexChanged
            Dim currentEdit As ComboBoxEdit = TryCast(sender, ComboBoxEdit)
            olrb2 = CType(System.Enum.Parse(GetType(OptimisticLockingReadBehavior), CStr(currentEdit.SelectedItem), True), OptimisticLockingReadBehavior)
            customData.Uow2.OptimisticLockingReadBehavior = olrb2
        End Sub

        Private Sub newUowButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            customData.Uow1 = New UnitOfWork(customData.DataLayer)
            customData.Uow1.OptimisticLockingReadBehavior = olrb1
        End Sub

        Private Sub newUowButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            customData.Uow2 = New UnitOfWork(customData.DataLayer)
            customData.Uow2.OptimisticLockingReadBehavior = olrb2
        End Sub

        Private Sub uow1CommitChangesButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles uow1CommitChangesButton.Click
            Try
                customData.Uow1.CommitChanges()
            Catch ex As Exception
                XtraMessageBox.Show(Me, ex.Message, frmMain.DemoNameConst)
            End Try
        End Sub

        Private Sub uow2CommitChangesButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles uow2CommitChangesButton.Click
            Try
                customData.Uow2.CommitChanges()
            Catch ex As Exception
                XtraMessageBox.Show(Me, ex.Message, frmMain.DemoNameConst)
            End Try
        End Sub

        Private Sub reloadButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles reloadButton1.Click
            Try
                person1.Reload()
            Catch ex As Exception
                XtraMessageBox.Show(Me, ex.Message, frmMain.DemoNameConst)
            End Try
        End Sub

        Private Sub reloadButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles reloadButton2.Click
            Try
                person2.Reload()
            Catch ex As Exception
                XtraMessageBox.Show(Me, ex.Message, frmMain.DemoNameConst)
            End Try
        End Sub
        Private Sub buttonEdit1_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit1.ButtonClick
            Dim miContactTitle As XPMemberInfo = person1.ClassInfo.GetMember("ContactTitle")
            If miContactTitle.GetOldValue(person1) IsNot Nothing Then
                miContactTitle.SetValue(person1, miContactTitle.GetOldValue(person1))
            End If
            miContactTitle.ResetModified(person1)
        End Sub

        Private Sub buttonEdit2_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit2.ButtonClick
            Dim miContactName As XPMemberInfo = person1.ClassInfo.GetMember("ContactName")
            If miContactName.GetOldValue(person1) IsNot Nothing Then
                miContactName.SetValue(person1, miContactName.GetOldValue(person1))
            End If
            miContactName.ResetModified(person1)
        End Sub

        Private Sub buttonEdit3_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit3.ButtonClick
            Dim miCompanyName As XPMemberInfo = person1.ClassInfo.GetMember("CompanyName")
            If miCompanyName.GetOldValue(person1) IsNot Nothing Then
                miCompanyName.SetValue(person1, miCompanyName.GetOldValue(person1))
            End If
            miCompanyName.ResetModified(person1)
        End Sub

        Private Sub buttonEdit4_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit4.ButtonClick
            Dim miCountry As XPMemberInfo = person1.ClassInfo.GetMember("Country")
            If miCountry.GetOldValue(person1) IsNot Nothing Then
                miCountry.SetValue(person1, miCountry.GetOldValue(person1))
            End If
            miCountry.ResetModified(person1)
        End Sub

        Private Sub buttonEdit5_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit5.ButtonClick
            Dim miCity As XPMemberInfo = person1.ClassInfo.GetMember("City")
            If miCity.GetOldValue(person1) IsNot Nothing Then
                miCity.SetValue(person1, miCity.GetOldValue(person1))
            End If
            miCity.ResetModified(person1)
        End Sub

        Private Sub buttonEdit6_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit6.ButtonClick
            Dim miPhone As XPMemberInfo = person1.ClassInfo.GetMember("Phone")
            If miPhone.GetOldValue(person1) IsNot Nothing Then
                miPhone.SetValue(person1, miPhone.GetOldValue(person1))
            End If
            miPhone.ResetModified(person1)
        End Sub

        Private Sub buttonEdit7_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit7.ButtonClick
            Dim miContactTitle As XPMemberInfo = person2.ClassInfo.GetMember("ContactTitle")
            If miContactTitle.GetOldValue(person2) IsNot Nothing Then
                miContactTitle.SetValue(person2, miContactTitle.GetOldValue(person2))
            End If
            miContactTitle.ResetModified(person2)
        End Sub

        Private Sub buttonEdit8_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit8.ButtonClick
            Dim miContactName As XPMemberInfo = person2.ClassInfo.GetMember("ContactName")
            If miContactName.GetOldValue(person2) IsNot Nothing Then
                miContactName.SetValue(person2, miContactName.GetOldValue(person2))
            End If
            miContactName.ResetModified(person2)
        End Sub

        Private Sub buttonEdit9_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit9.ButtonClick
            Dim miCompanyName As XPMemberInfo = person2.ClassInfo.GetMember("CompanyName")
            If miCompanyName.GetOldValue(person2) IsNot Nothing Then
                miCompanyName.SetValue(person2, miCompanyName.GetOldValue(person2))
            End If
            miCompanyName.ResetModified(person2)
        End Sub

        Private Sub buttonEdit10_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit10.ButtonClick
            Dim miCountry As XPMemberInfo = person2.ClassInfo.GetMember("Country")
            If miCountry.GetOldValue(person2) IsNot Nothing Then
                miCountry.SetValue(person2, miCountry.GetOldValue(person2))
            End If
            miCountry.ResetModified(person2)
        End Sub

        Private Sub buttonEdit11_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit11.ButtonClick
            Dim miCity As XPMemberInfo = person2.ClassInfo.GetMember("City")
            If miCity.GetOldValue(person2) IsNot Nothing Then
                miCity.SetValue(person2, miCity.GetOldValue(person2))
            End If
            miCity.ResetModified(person2)
        End Sub

        Private Sub buttonEdit12_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit12.ButtonClick
            Dim miPhone As XPMemberInfo = person2.ClassInfo.GetMember("Phone")
            If miPhone.GetOldValue(person2) IsNot Nothing Then
                miPhone.SetValue(person2, miPhone.GetOldValue(person2))
            End If
            miPhone.ResetModified(person2)
        End Sub
        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
            Dim currentPerson As Person = person1
            For Each member As XPMemberInfo In currentPerson.ClassInfo.PersistentProperties
                If member.GetModified(currentPerson) Then
                    Select Case member.Name
                        Case "ContactTitle"
                            labelControl1.Text = String.Format("Old value: {0}", member.GetOldValue(currentPerson))
                        Case "ContactName"
                            labelControl2.Text = String.Format("Old value: {0}", member.GetOldValue(currentPerson))
                        Case "CompanyName"
                            labelControl3.Text = String.Format("Old value: {0}", member.GetOldValue(currentPerson))
                        Case "Country"
                            labelControl4.Text = String.Format("Old value: {0}", member.GetOldValue(currentPerson))
                        Case "City"
                            labelControl5.Text = String.Format("Old value: {0}", member.GetOldValue(currentPerson))
                        Case "Phone"
                            labelControl6.Text = String.Format("Old value: {0}", member.GetOldValue(currentPerson))
                    End Select
                Else
                    Select Case member.Name
                        Case "ContactTitle"
                            labelControl1.Text = String.Empty
                        Case "ContactName"
                            labelControl2.Text = String.Empty
                        Case "CompanyName"
                            labelControl3.Text = String.Empty
                        Case "Country"
                            labelControl4.Text = String.Empty
                        Case "City"
                            labelControl5.Text = String.Empty
                        Case "Phone"
                            labelControl6.Text = String.Empty
                    End Select
                End If
            Next member
            currentPerson = person2
            For Each member As XPMemberInfo In currentPerson.ClassInfo.PersistentProperties
                If member.GetModified(currentPerson) Then
                    Select Case member.Name
                        Case "ContactTitle"
                            labelControl7.Text = String.Format("Old value: {0}", member.GetOldValue(currentPerson))
                        Case "ContactName"
                            labelControl8.Text = String.Format("Old value: {0}", member.GetOldValue(currentPerson))
                        Case "CompanyName"
                            labelControl9.Text = String.Format("Old value: {0}", member.GetOldValue(currentPerson))
                        Case "Country"
                            labelControl10.Text = String.Format("Old value: {0}", member.GetOldValue(currentPerson))
                        Case "City"
                            labelControl11.Text = String.Format("Old value: {0}", member.GetOldValue(currentPerson))
                        Case "Phone"
                            labelControl2.Text = String.Format("Old value: {0}", member.GetOldValue(currentPerson))
                    End Select
                Else
                    Select Case member.Name
                        Case "ContactTitle"
                            labelControl7.Text = String.Empty
                        Case "ContactName"
                            labelControl8.Text = String.Empty
                        Case "CompanyName"
                            labelControl9.Text = String.Empty
                        Case "Country"
                            labelControl10.Text = String.Empty
                        Case "City"
                            labelControl11.Text = String.Empty
                        Case "Phone"
                            labelControl12.Text = String.Empty
                    End Select
                End If
            Next member
        End Sub
        Private Class MPData
            Public DataLayer As IDataLayer
            Public Uow1 As UnitOfWork
            Public Uow2 As UnitOfWork
        End Class

		<OptimisticLockingReadBehavior(OptimisticLockingReadBehavior.MergeCollisionThrowException, True), OptimisticLocking(OptimisticLockingBehavior.LockAll)> _
		Public Class Customer
			Inherits XPObject
            Private _contactName As String
            Public Property ContactName() As String
                Get
                    Return _contactName
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(ContactName), _contactName, value)
                End Set
            End Property
            Private _contactTitle As String
            Public Property ContactTitle() As String
                Get
                    Return _contactTitle
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(ContactTitle), _contactTitle, value)
                End Set
            End Property
            Private _city As String
            Public Property City() As String
                Get
                    Return _city
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(City), _city, value)
                End Set
            End Property
            Private _companyName As String
            Public Property CompanyName() As String
                Get
                    Return _companyName
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(CompanyName), _companyName, value)
                End Set
            End Property
            Private _country As String
            Public Property Country() As String
                Get
                    Return _country
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(Country), _country, value)
                End Set
            End Property
            Private _phone As String
            Public Property Phone() As String
                Get
                    Return _phone
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(Phone), _phone, value)
                End Set
            End Property
			Public Sub New(ByVal session As Session)
				MyBase.New(session)
			End Sub
        End Class
        <OptimisticLocking(OptimisticLockingBehavior.LockAll)> _
  Public Class Person
            Inherits XPObject
            Private _contactName As String
            Public Property ContactName() As String
                Get
                    Return _contactName
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(ContactName), _contactName, value)
                End Set
            End Property
            Private _contactTitle As String
            Public Property ContactTitle() As String
                Get
                    Return _contactTitle
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(ContactTitle), _contactTitle, value)
                End Set
            End Property
            Private _city As String
            Public Property City() As String
                Get
                    Return _city
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(City), _city, value)
                End Set
            End Property
            Private _companyName As String
            Public Property CompanyName() As String
                Get
                    Return _companyName
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(CompanyName), _companyName, value)
                End Set
            End Property
            Private _country As String
            Public Property Country() As String
                Get
                    Return _country
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(Country), _country, value)
                End Set
            End Property
            Private _phone As String
            Public Property Phone() As String
                Get
                    Return _phone
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(Phone), _phone, value)
                End Set
            End Property
            Public Sub New(ByVal session As Session)
                MyBase.New(session)
            End Sub
        End Class
    End Class
End Namespace

