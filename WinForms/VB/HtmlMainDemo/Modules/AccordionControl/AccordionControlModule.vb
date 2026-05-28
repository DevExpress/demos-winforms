Imports DevExpress.DXperience.Demos
Imports DevExpress.HTML.Demos.Modules.AccordionControl
Imports DevExpress.HTML.Demos.Modules.AccordionControl.Controls
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Drawing.Helpers
Imports DevExpress.XtraBars.Navigation
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.HTML.Demos

    Public Partial Class AccordionControlModule
        Inherits TutorialControlBase

        Public Sub New()
            InitializeComponent()
            accordionControlTemplateCodeViewer1.Fill(accordionControl1, Nothing)
            comboBoxEdit1.HtmlTemplate = htmlTemplate1
            comboBoxEdit1.Properties.HtmlImages = svgImageCollection1
            htmlButtonPanel1.HtmlImages = svgImageCollection1
            htmlCheckBox.HtmlImages = svgImageCollection1
            deliveryControl2.HtmlImages = svgImageCollection1
            SubscribeOnEvents()
            CreateDataSource()
            UpdateBackground()
            SetDataSource()
            InitModules()
            InitDefaultAddresses()
        End Sub

        Private Sub InitDefaultAddresses()
            Dim item1 = New AddressDataObject()
            item1.City = "Tacoma"
            item1.Address1 = "908 W. Capital Way"
            item1.Address2 = "-"
            item1.Code = "98401"
            item1.State = "WA"
            item1.Phone = "(206) 555-9482"
            item1.SetName("Home")
            Dim item2 = New AddressDataObject()
            item2.City = "Seattle"
            item2.Address1 = "507 - 20th Ave. E."
            item2.Address2 = "Apt. 2A"
            item2.Code = "98122"
            item2.State = "WA"
            item2.Phone = "(206) 555-9857"
            item2.SetName("Work")
            comboBoxEdit1.Properties.Items.Add(item1)
            comboBoxEdit1.Properties.Items.Add(item2)
        End Sub

        Private Sub SetDataSource()
            informationControl1.DataSource = dataSource
            shippingControl1.DataSource = dataSource.GetShippingData()
            billingControl1.DataSource = dataSource.GetBillingData()
            paymentControl1.DataSource = dataSource
            deliveryControl2.DataSource = dataSource
            orderSummaryControl1.DataSource = dataSource
            htmlButtonPanel1.DataSource = dataSource
        End Sub

        Private Sub InitModules()
            For i As Integer = 0 To accordionControl1.Elements.Count - 1
                Dim element = accordionControl1.Elements(i)
                Dim info = New AccordionElementData()
                If i = 0 Then info.IsActive = True
                element.Tag = info
            Next

            SetDescription(informationElement, "Fill out this form to enter your personal data.")
            SetDescription(shippingElement, "Tell us where we need to ship your order.")
            SetDescription(paymentElement, "You can pay with credit or debit card, cash, or a PayPal account.")
            SetDescription(billingElement, "Choose a delivery option.")
            SetDescription(deliveryElement, "Select a way you want we send your order.")
            SetDescription(summaryElement, "Review your order summary and click ""Place Order"" to complete your purchase.")
            informationElement.Expanded = True
        End Sub

        Private Sub SetDescription(ByVal element As AccordionControlElement, ByVal description As String)
            CType(element.Tag, AccordionElementData).Description = description
        End Sub

        Private dataSource As AccordionDataObject

        Private Sub CreateDataSource()
            Dim images = svgImageCollection1
            dataSource = New AccordionDataObject()
            dataSource.Price = 119.99
            dataSource.DeliveryTypes.Add(New DeliveryType() With {.Id = "fedex", .Text = "FedEx", .Price = 15.50, .Time = "3 weeks"})
            dataSource.DeliveryTypes.Add(New DeliveryType() With {.Id = "dhl", .Text = "DHL", .Price = 28.35, .Time = "2 weeks"})
            dataSource.DeliveryTypes.Add(New DeliveryType() With {.Id = "expost", .Text = "Express Post", .Price = 56.95R, .Time = "3 days"})
            dataSource.PaymentTypes.Add(New PaymentInfo() With {.Id = "card", .Type = PaymentType.CreditCard, .Image = images("card"), .IsChecked = True})
            dataSource.PaymentTypes.Add(New PaymentInfo() With {.Id = "cash", .Type = PaymentType.Cash, .Image = images("cash")})
            dataSource.PaymentTypes.Add(New PaymentInfo() With {.Id = "paypal", .Type = PaymentType.PayPal, .Image = images("paypal")})
            dataSource.SelectedDelivery = dataSource.DeliveryTypes(0)
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdateBackground()
        End Sub

        Private Sub UpdateBackground()
            Dim bg As Color = LookAndFeelHelper.GetSystemColor(UserLookAndFeel.Default, SystemColors.Control)
            accordionControl1.Appearance.AccordionControl.BackColor = bg
            BackColor = bg
        End Sub

        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            UpdateElementContainerHeight(informationElement)
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Message)
            MyBase.WndProc(m)
            If m.Msg = MSG.WM_DPICHANGED_AFTERPARENT Then
                Dim elements = accordionControl1.Elements
                For i As Integer = 0 To elements.Count - 1
                    Dim element = elements(i)
                    If element.Expanded Then
                        UpdateElementContainerHeight(element)
                    End If
                Next
            End If
        End Sub

        Private Sub accordionControl1_ExpandStateChanging(ByVal sender As Object, ByVal e As ExpandStateChangingEventArgs)
            If e.Element.Expanded Then Return
            UpdateElementContainerHeight(e.Element)
        End Sub

        Private Sub SubscribeOnEvents()
            AddHandler htmlCheckBox.CheckedChanged, AddressOf HtmlCheckBox_CheckedChanged
            AddHandler billingControl1.SaveButtonClick, AddressOf BillingControl1_SaveButtonClick
            AddHandler shippingControl1.SaveButtonClick, AddressOf ShippingControl1_SaveButtonClick
            AddHandler comboBoxEdit1.EditValueChanged, AddressOf ComboBoxEdit1_EditValueChanged
            AddHandler informationControl1.NextButtonClick, AddressOf OnNextButtonClick
            AddHandler shippingControl1.NextButtonClick, AddressOf OnNextButtonClick
            AddHandler paymentControl1.NextButtonClick, AddressOf OnNextButtonClick
            AddHandler billingControl1.NextButtonClick, AddressOf OnNextButtonClick
            AddHandler orderSummaryControl1.NextButtonClick, AddressOf OnNextButtonClick
            AddHandler deliveryControl2.NextButtonClick, AddressOf OnNextButtonClick
        End Sub

        Private Sub ComboBoxEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit = CType(sender, HtmlComboBoxEdit)
            Dim value = TryCast(edit.EditValue, AddressDataObject)
            If value Is Nothing Then Return
            dataSource.GetShippingData().Assign(value)
            shippingControl1.Refresh()
        End Sub

        Private cachedBillingData As AddressDataObject

        Private Sub HtmlCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim checkBox = CType(sender, HtmlCheckBoxControl)
            If checkBox.Checked Then
                Dim data = dataSource.GetBillingData()
                If cachedBillingData Is Nothing Then cachedBillingData = New AddressDataObject()
                cachedBillingData.Assign(data)
                data.Assign(dataSource.GetShippingData())
                billingControl1.Enabled = False
                billingControl1.Refresh()
            ElseIf cachedBillingData IsNot Nothing Then
                Dim shippingData = dataSource.GetShippingData()
                Dim billingData = dataSource.GetBillingData()
                billingControl1.Enabled = True
                If Equals(shippingData, billingData) Then
                    billingData.Assign(cachedBillingData)
                    billingControl1.Refresh()
                End If
            End If
        End Sub

        Private Sub ShippingControl1_SaveButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            SaveAddressCore(CType(sender, ShippingControl))
        End Sub

        Private Sub BillingControl1_SaveButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            SaveAddressCore(CType(sender, ShippingControl))
        End Sub

        Private Sub SaveAddressCore(ByVal sender As ShippingControl)
            Dim data = TryCast(sender.DataSource, AddressDataObject)
            If data Is Nothing Then Return
            Dim item = data.Clone()
            Dim items = comboBoxEdit1.Properties.Items
            Dim description = String.Format("Address{0}", items.Count + 1)
            item.SetName(description)
            comboBoxEdit1.Properties.Items.Add(item)
        End Sub

        Private Sub UpdateElementContainerHeight(ByVal element As AccordionControlElement)
            Dim container = element?.ContentContainer
            If container Is Nothing OrElse container.Controls.Count = 0 Then Return
            Dim provider = TryCast(container.Controls(0), IHtmlContentControlProvider)
            Dim controlInfo = TryCast(element.AccordionControl?.GetViewInfo(), AccordionControlViewInfo)
            If provider Is Nothing OrElse controlInfo Is Nothing Then Return
            Dim elementInfo = controlInfo.GetElementInfo(element)
            Dim elementWidth = If(elementInfo Is Nothing, element.AccordionControl.Width, elementInfo.HeaderBounds.Width)
            Dim padding = container.Padding
            If Not container.IsHandleCreated Then
                container.Location = New Point(-10000, -10000)
                container.Visible = True
                CType(provider, Control).CreateControl()
            End If

            Dim bestSize As Size = provider.CalcBestSize(elementWidth - padding.Horizontal)
            container.Height = padding.Vertical + bestSize.Height
        End Sub

        Private Sub OnNextButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim activeElement = GetElementByContainer(CType(sender, Control).Parent)
            If activeElement Is Nothing Then Return
            Dim elements = accordionControl1.Elements
            Dim activeIndex = elements.IndexOf(activeElement)
            If activeIndex >= elements.Count - 1 Then Return
            Dim newActiveElement = accordionControl1.Elements(activeIndex + 1)
            Dim moduleInfo = TryCast(newActiveElement.Tag, AccordionElementData)
            If moduleInfo IsNot Nothing Then moduleInfo.IsActive = True
            accordionControl1.ExpandElement(newActiveElement, True)
        End Sub

        Private Function GetElementByContainer(ByVal container As Control) As AccordionControlElement
            If container Is Nothing Then Return Nothing
            For Each element In accordionControl1.Elements
                If Equals(element.ContentContainer, container) Then Return element
            Next

            Return Nothing
        End Function

        Private Sub accordionControl1_QueryHtmlElementData(ByVal sender As Object, ByVal e As QueryAccordionHtmlElementDataEventArgs)
            Dim info = TryCast(e.Element?.Tag, AccordionElementData)
            If info Is Nothing Then Return
            Select Case e.FieldName
                Case "Description"
                    e.Value = info.Description
                    Return
                Case "IsActive"
                    e.Value = info.IsActive
                    Return
                Case "Expanded"
                    e.Value = e.Element.Expanded
                    Return
            End Select
        End Sub
    End Class

    Public Class AccordionElementData

        Public Property IsActive As Boolean

        Public Property Description As String
    End Class

    Public Interface IHtmlContentControlProvider

        Function CalcBestSize(ByVal width As Integer) As Size

    End Interface

    Public Class AccordionDataObject

        Public Sub New()
            shippingData = New AddressDataObject()
            billingData = New AddressDataObject()
            DeliveryTypes = New List(Of DeliveryType)()
            PaymentTypes = New List(Of PaymentInfo)()
        End Sub

        Private shippingData, billingData As AddressDataObject

        Public Property FirstName As String

        Public Property LastName As String

        Public Property Birthday As String

        Public Property Email As String

        Public Property ShippingAddress1 As String
            Get
                Return shippingData.Address1
            End Get

            Set(ByVal value As String)
                shippingData.Address1 = value
            End Set
        End Property

        Public Property ShippingAddress2 As String
            Get
                Return shippingData.Address2
            End Get

            Set(ByVal value As String)
                shippingData.Address2 = value
            End Set
        End Property

        Public Property ShippingCity As String
            Get
                Return shippingData.City
            End Get

            Set(ByVal value As String)
                shippingData.City = value
            End Set
        End Property

        Public Property ShippingState As String
            Get
                Return shippingData.State
            End Get

            Set(ByVal value As String)
                shippingData.State = value
            End Set
        End Property

        Public Property ShippingCode As String
            Get
                Return shippingData.Code
            End Get

            Set(ByVal value As String)
                shippingData.Code = value
            End Set
        End Property

        Public Property ShippingPhone As String
            Get
                Return shippingData.Phone
            End Get

            Set(ByVal value As String)
                shippingData.Phone = value
            End Set
        End Property

        Public Property BillingAddress1 As String
            Get
                Return billingData.Address1
            End Get

            Set(ByVal value As String)
                billingData.Address1 = value
            End Set
        End Property

        Public Property BillingAddress2 As String
            Get
                Return billingData.Address2
            End Get

            Set(ByVal value As String)
                billingData.Address2 = value
            End Set
        End Property

        Public Property BillingCity As String
            Get
                Return billingData.City
            End Get

            Set(ByVal value As String)
                billingData.City = value
            End Set
        End Property

        Public Property BillingState As String
            Get
                Return billingData.State
            End Get

            Set(ByVal value As String)
                billingData.State = value
            End Set
        End Property

        Public Property BillingCode As String
            Get
                Return billingData.Code
            End Get

            Set(ByVal value As String)
                billingData.Code = value
            End Set
        End Property

        Public Property BillingPhone As String
            Get
                Return billingData.Phone
            End Get

            Set(ByVal value As String)
                billingData.Phone = value
            End Set
        End Property

        Public Property CardNumber As Object

        Public Property CardHolder As String

        Public Property CardThru As String

        Public Property CardCVC As String

        Public Property Price As Double

        Public ReadOnly Property TotalPrice As Double
            Get
                Dim price = Me.Price
                price += SelectedDelivery.Price
                Return price
            End Get
        End Property

        Public ReadOnly Property CardLastNumbers As Object
            Get
                Dim value As Long = 0
                If TypeOf CardNumber Is Integer Then
                    value = CInt(CardNumber)
                ElseIf TypeOf CardNumber Is String Then
                    Dim strValue = CStr(CardNumber)
                    If strValue.Length < 4 Then Return Nothing
                    Long.TryParse(strValue.Substring(strValue.Length - 4, 4), value)
                End If

                If value > 0 Then Return value Mod 10000
                Return Nothing
            End Get
        End Property

        Private selectedDeliveryField As DeliveryType

        Public Property SelectedDelivery As DeliveryType
            Get
                Return selectedDeliveryField
            End Get

            Set(ByVal value As DeliveryType)
                selectedDeliveryField = value
                DeliveryTypes.ForEach(Sub(x) x.IsChecked = x Is selectedDeliveryField)
            End Set
        End Property

        Public ReadOnly Property DeliveryTypes As List(Of DeliveryType)

        Private selectedPaymentTypeField As PaymentInfo

        Public Property SelectedPaymentType As PaymentInfo
            Get
                Return selectedPaymentTypeField
            End Get

            Set(ByVal value As PaymentInfo)
                selectedPaymentTypeField = value
                PaymentTypes.ForEach(Sub(x) x.IsChecked = x Is selectedPaymentTypeField)
            End Set
        End Property

        Public ReadOnly Property PaymentTypes As List(Of PaymentInfo)

        Public ReadOnly Property DeliveryValue As String
            Get
                Return SelectedDelivery?.Text
            End Get
        End Property

        Public Function GetBillingData() As AddressDataObject
            Return billingData
        End Function

        Public Function GetShippingData() As AddressDataObject
            Return shippingData
        End Function

        Public ReadOnly Property PaymentInfo As PaymentInfo
    End Class

    Public Class PaymentInfo

        Public Property IsChecked As Boolean

        Public Property Type As PaymentType

        Public Property Id As String

        Public Property Image As Object
    End Class

    Public Enum PaymentType
        CreditCard
        PayPal
        Cash
    End Enum

    Public Class DeliveryType

        Public Property Id As String

        Public Property Text As String

        Public Property Time As String

        Public Property Price As Double

        Public Property IsChecked As Boolean
    End Class

    Public Class AddressDataObject

        Public Property Address1 As String

        Public Property Address2 As String

        Public Property City As String

        Public Property State As String

        Public Property Code As String

        Public Property Phone As String

        Private name As String = String.Empty

        Public Sub SetName(ByVal value As String)
            name = value
        End Sub

        Public Sub Assign(ByVal obj As AddressDataObject)
            Address1 = obj.Address1
            Address2 = obj.Address2
            City = obj.City
            State = obj.State
            Code = obj.Code
            Phone = obj.Phone
        End Sub

        Public Function Clone() As AddressDataObject
            Dim res = New AddressDataObject()
            res.Address1 = Address1
            res.Address2 = Address2
            res.City = City
            res.State = State
            res.Code = Code
            res.Phone = Phone
            Return res
        End Function

        Public Overrides Function ToString() As String
            Return name
        End Function

        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            Dim src As AddressDataObject = TryCast(obj, AddressDataObject)
            If src Is Nothing Then Return False
            Return Equals(Address1, src.Address1) AndAlso Equals(Address2, src.Address2) AndAlso Equals(City, src.City) AndAlso Equals(State, src.State) AndAlso Equals(Code, src.Code) AndAlso Equals(Phone, src.Phone)
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode()
        End Function
    End Class
End Namespace
