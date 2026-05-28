Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Navigation
Imports System.ComponentModel
Imports System.Drawing

Namespace DevExpress.HTML.Demos

    Public Partial Class HamburgerMenuModule
        Inherits TutorialControlBase

        Public Sub New()
            InitializeComponent()
            accordionControlTemplateCodeViewer1.Fill(accordionControl1, Nothing)
            UpdateBackground()
            InitCategories()
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdateBackground()
        End Sub

        Private Sub UpdateBackground()
            Dim bg As Color = LookAndFeelHelper.GetSystemColor(LookAndFeel.ActiveLookAndFeel, SystemColors.Control)
            accordionControl1.Appearance.AccordionControl.BackColor = bg
            BackColor = bg
        End Sub

        Private Sub InitCategories()
            acEmployees.Tag = New HamburgerElementDataSource(New HamburgerMenuCategory() {New HamburgerMenuCategory("Salaried"), New HamburgerMenuCategory("Commission"), New HamburgerMenuCategory("Contract")}, New HamburgerMenuCategory() {New HamburgerMenuCategory("Terminated"), New HamburgerMenuCategory("On Leave")})
            acCustomers.Tag = New HamburgerElementDataSource(New HamburgerMenuCategory() {New HamburgerMenuCategory("Stores > 10"), New HamburgerMenuCategory("Revenue > 100 Billion")}, New HamburgerMenuCategory() {New HamburgerMenuCategory("Employees > 10000")})
            acVendors.Tag = New HamburgerElementDataSource(New HamburgerMenuCategory() {New HamburgerMenuCategory("Active"), New HamburgerMenuCategory("Suspended")}, Nothing)
            acMonitors.Tag = New HamburgerElementDataSource(New HamburgerMenuCategory() {New HamburgerMenuCategory("Available")}, New HamburgerMenuCategory() {New HamburgerMenuCategory("Discounted")})
            acProjectors.Tag = New HamburgerElementDataSource(New HamburgerMenuCategory() {New HamburgerMenuCategory("Available")}, New HamburgerMenuCategory() {New HamburgerMenuCategory("Discounted")})
            acTelevisions.Tag = New HamburgerElementDataSource(New HamburgerMenuCategory() {New HamburgerMenuCategory("Available")}, New HamburgerMenuCategory() {New HamburgerMenuCategory("Discounted")})
            acVideoPlayers.Tag = New HamburgerElementDataSource(New HamburgerMenuCategory() {New HamburgerMenuCategory("Available")}, New HamburgerMenuCategory() {New HamburgerMenuCategory("Discounted")})
            acMonitors2.Tag = New HamburgerElementDataSource(New HamburgerMenuCategory() {New HamburgerMenuCategory("Today"), New HamburgerMenuCategory("Yesterday"), New HamburgerMenuCategory("This Month")}, New HamburgerMenuCategory() {New HamburgerMenuCategory("This Year"), New HamburgerMenuCategory("Unpaid Orders")})
            acProjectors2.Tag = New HamburgerElementDataSource(New HamburgerMenuCategory() {New HamburgerMenuCategory("Today"), New HamburgerMenuCategory("Yesterday"), New HamburgerMenuCategory("This Month")}, New HamburgerMenuCategory() {New HamburgerMenuCategory("This Year"), New HamburgerMenuCategory("Unpaid Orders")})
            acTelevisions2.Tag = New HamburgerElementDataSource(New HamburgerMenuCategory() {New HamburgerMenuCategory("Today"), New HamburgerMenuCategory("Yesterday"), New HamburgerMenuCategory("This Month")}, New HamburgerMenuCategory() {New HamburgerMenuCategory("This Year"), New HamburgerMenuCategory("Unpaid Orders")})
            acVideoPlayers2.Tag = New HamburgerElementDataSource(New HamburgerMenuCategory() {New HamburgerMenuCategory("Today"), New HamburgerMenuCategory("Yesterday"), New HamburgerMenuCategory("This Month")}, New HamburgerMenuCategory() {New HamburgerMenuCategory("This Year"), New HamburgerMenuCategory("Unpaid Orders")})
        End Sub

        Private Sub accordionControl1_QueryHtmlElementData(ByVal sender As Object, ByVal e As QueryAccordionHtmlElementDataEventArgs)
            If Equals(e.FieldName, "IsControlExpanded") Then
                e.Value = CType(sender, AccordionControl).OptionsMinimizing.State = AccordionControlState.Normal
                Return
            End If

            If e.Element Is Nothing Then Return
            If Equals(e.FieldName, "Categories1") Then
                Dim data = TryCast(e.Element.Tag, HamburgerElementDataSource)
                e.Value = data?.Categories1
                Return
            End If

            If Equals(e.FieldName, "Categories2") Then
                Dim data = TryCast(e.Element.Tag, HamburgerElementDataSource)
                e.Value = data?.Categories2
                Return
            End If

            If Equals(e.FieldName, "IsFirst") Then
                Dim elements = e.Element.OwnerElement?.Elements
                e.Value = elements IsNot Nothing AndAlso elements.IndexOf(e.Element) = 0
            End If

            If Equals(e.FieldName, "IsLast") Then
                Dim elements = e.Element.OwnerElement?.Elements
                e.Value = elements IsNot Nothing AndAlso elements.IndexOf(e.Element) = elements.Count - 1
            End If
        End Sub

        Private Sub accordionControl1_HtmlElementMouseClick(ByVal sender As Object, ByVal e As AccordionHtmlElementEventArgs)
            If e.HasId("searchbutton") Then
                Dim accordion = CType(sender, AccordionControl)
                If accordion.ShowFilterControl = ShowFilterControl.Never Then
                    accordion.ShowFilterControl = ShowFilterControl.Always
                Else
                    accordion.ShowFilterControl = ShowFilterControl.Never
                End If
            End If
        End Sub
    End Class

    Friend Class HamburgerElementDataSource

        Public Sub New(ByVal categories1 As HamburgerMenuCategory(), ByVal categories2 As HamburgerMenuCategory())
            Me.Categories1 = categories1
            Me.Categories2 = categories2
        End Sub

        Public Property Categories1 As HamburgerMenuCategory()

        Public Property Categories2 As HamburgerMenuCategory()
    End Class

    Friend Class HamburgerMenuCategory

        Public Sub New(ByVal name As String)
            Me.Name = name
        End Sub

        Public Property Name As String
    End Class
End Namespace
