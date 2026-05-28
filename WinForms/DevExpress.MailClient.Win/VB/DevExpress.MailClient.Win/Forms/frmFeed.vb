Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraEditors.DXErrorProvider

Namespace DevExpress.MailClient.Win.Forms
    Partial Public Class frmFeed
        Inherits XtraForm

        Private role As DialogRole = DialogRole.[New]
        Private navBar As NavBarControl
        Private uniqueNames As List(Of String)
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub InitValidation()
            Dim rule As New UniqueNameValidationRule(uniqueNames)
            rule.ErrorType = ErrorType.Critical
            rule.ErrorText = My.Resources.RuleUniqueNamesWarning
            dxValidationProvider1.SetValidationRule(teCaption, rule)
            dxValidationProvider1.SetValidationRule(cbeGroup, ValidationRulesHelper.RuleIsNotBlank)
            dxValidationProvider1.SetValidationRule(heLink, ValidationRulesHelper.RuleIsNotBlank)
            AddHandler cbeGroup.EditValueChanged, AddressOf edit_EditValueChanged
            AddHandler teCaption.EditValueChanged, AddressOf edit_EditValueChanged
            AddHandler heLink.EditValueChanged, AddressOf edit_EditValueChanged
        End Sub
        Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            sbOK.Enabled = Not String.IsNullOrEmpty(heLink.Text)
        End Sub
        Public ReadOnly Property CurrentItem() As NavBarItem
            Get
                Return navBar.SelectedLink.Item
            End Get
        End Property
        Private ReadOnly Property CurrentGroup() As NavBarGroup
            Get
                Return navBar.SelectedLink.Group
            End Get
        End Property
        Public Sub New(ByVal role As DialogRole, ByVal navBar As NavBarControl)
            InitializeComponent()
            Me.role = role
            Me.navBar = navBar
            cbeGroup.Properties.Items.AddRange(NavBarHelper.GetGroupNames(navBar))
            sbOK.Text = If(role = DialogRole.[New], My.Resources.Add, My.Resources.OK)
            Text = (If(role = DialogRole.[New], My.Resources.NewFeedDescription, My.Resources.EditFeedDescription)).Replace(".", String.Empty)
            uniqueNames = NavBarHelper.GetItemNames(navBar)
            uniqueNames.Add(String.Empty)
            If role = DialogRole.[New] Then
                teCaption.Text = NavBarHelper.GetUniqueItemName(My.Resources.TempFeedName, navBar)
                cbeGroup.Text = My.Resources.TempGroupName
                sbOK.Enabled = False
            Else
                uniqueNames.Remove(CurrentItem.Caption)
                teCaption.Text = CurrentItem.Caption
                cbeGroup.Text = CurrentGroup.Caption
                heLink.Text = String.Format("{0}", CurrentItem.Tag)
            End If
            InitValidation()
        End Sub
        Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
            MyBase.OnClosing(e)
            If DialogResult = DialogResult.OK Then
                If role = DialogRole.[New] Then
                    navBar.BeginUpdate()
                    Dim group As NavBarGroup = NavBarHelper.GetGroupByName(cbeGroup.Text, navBar)
                    Dim item As New NavBarItem(teCaption.Text)
                    Dim link As NavBarItemLink = group.ItemLinks.Add(item)
                    group.Expanded = True
                    item.Tag = ObjectHelper.GetCorrectUrl(heLink.Text)
                    navBar.SelectedLink = link
                    navBar.EndUpdate()
                Else
                    CurrentItem.Caption = teCaption.Text
                    CurrentItem.Tag = ObjectHelper.GetCorrectUrl(heLink.Text)
                    If CurrentGroup.Caption <> cbeGroup.Text Then
                        navBar.BeginUpdate()
                        Dim group As NavBarGroup = NavBarHelper.GetGroupByName(cbeGroup.Text, navBar)
                        group.Expanded = True
                        Dim link As NavBarItemLink = group.ItemLinks.Add(CurrentItem)
                        CurrentGroup.ItemLinks.Remove(navBar.SelectedLink)
                        navBar.SelectedLink = link
                        NavBarHelper.DeleteEmptyGroup(navBar)
                        navBar.EndUpdate()
                    End If
                End If
            End If
        End Sub
    End Class
End Namespace
