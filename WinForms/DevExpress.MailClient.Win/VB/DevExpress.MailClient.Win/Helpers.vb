Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports System.Drawing
Imports DevExpress.LookAndFeel
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Skins
Imports System.Diagnostics
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.Helpers
Imports DevExpress.Utils
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraSpellChecker
Imports System.IO
Imports DevExpress.Utils.Zip
Imports System.Globalization
Imports DevExpress.XtraRichEdit
Imports System.Text.RegularExpressions
Imports DevExpress.Utils.Drawing
Imports DevExpress.DevAV
Imports System.ComponentModel

Namespace DevExpress.MailClient.Win
    Public Class MyGridView
        Inherits GridView

        Protected Overrides ReadOnly Property IsAllowPixelScrollingPreview() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
    Public Class GridHelper
        Public Shared Sub GetChildDataRowHandles(ByVal view As GridView, ByVal rowHandle As Integer, ByVal list As List(Of Message))
            For i As Integer = 0 To view.GetChildRowCount(rowHandle) - 1
                Dim row As Integer = view.GetChildRowHandle(rowHandle, i)
                If row >= 0 Then
                    list.Add(TryCast(view.GetRow(row), Message))
                Else
                    GetChildDataRowHandles(view, row, list)
                End If
            Next i
        End Sub
        Public Shared Sub SetFindControlImages(ByVal grid As GridControl)
            Dim fControl As FindControl = Nothing
            For Each ctrl As Control In grid.Controls
                fControl = TryCast(ctrl, FindControl)
                If fControl IsNot Nothing Then
                    Exit For
                End If
            Next ctrl
            If fControl IsNot Nothing Then
                fControl.FindButton.Image = My.Resources.Search
                fControl.ClearButton.Image = My.Resources.Delete_16x16
                fControl.CalcButtonsBestFit()
            End If
        End Sub
        Public Shared Sub GridViewFocusObject(ByVal cView As ColumnView, ByVal obj As Object)
            If obj Is Nothing Then
                Return
            End If
            Dim oldFocusedRowHandle As Integer = cView.FocusedRowHandle
            For i As Integer = 0 To cView.DataRowCount - 1
                Dim rowObj As Object = TryCast(cView.GetRow(i), Object)
                If rowObj Is Nothing Then
                    Continue For
                End If
                If ReferenceEquals(obj, rowObj) Then
                    If i = oldFocusedRowHandle Then
                        cView.FocusedRowHandle = GridControl.InvalidRowHandle
                    End If
                    cView.FocusedRowHandle = i
                    Exit For
                End If
            Next i
        End Sub
    End Class
    Public Class ImageHelper
        Public Shared Function GetScaleImage(ByVal image As Image, ByVal size As Size) As Bitmap
            Return New Bitmap(image, size.Width, size.Height)
        End Function
        Public Shared Function GetFaviconIconPath(ByVal link As String) As String
            link = ObjectHelper.GetCorrectUrl(link)
            Dim links() As String = link.Split("/"c)
            If links.Length > 1 Then
                Return String.Format("http://{0}/favicon.ico", links(2))
            End If
            Return Nothing
        End Function
        Public Shared Function CreateSenderImage(ByVal sender As String, ByVal size As Size, ByVal ulf As DevExpress.LookAndFeel.UserLookAndFeel) As Bitmap
            Dim imageSize As Size = New System.Drawing.Size(size.Width, size.Height)
            Dim parsedText() As String = sender.Split(" "c)
            Dim result As String = String.Empty
            Dim count As Integer = 0
            For i As Integer = 0 To parsedText.Length - 1
                If parsedText(i).Length > 0 Then
                    result &= parsedText(i).Chars(0)
                    count += 1
                    If count = 2 Then
                        Exit For
                    End If
                End If
            Next i
            Return GlyphPainter.CreateRoundedStubGlyph(ulf, imageSize, result)
        End Function
    End Class
    Public Class ColorHelper
        Public Shared Sub UpdateColor(ByVal list As ImageList, ByVal lf As UserLookAndFeel)
            For i As Integer = 0 To list.Images.Count - 1
                list.Images(i) = SetColor(TryCast(list.Images(i), Bitmap), GetHeaderForeColor(lf))
            Next i
        End Sub
        Public Shared Function GetHeaderForeColor(ByVal lf As UserLookAndFeel) As Color
            Dim ret As Color = SystemColors.ControlText
            If lf.ActiveStyle <> ActiveLookAndFeelStyle.Skin Then
                Return ret
            End If
            Return GridSkins.GetSkin(lf)(GridSkins.SkinHeader).Color.GetForeColor()
        End Function
        Private Shared Function SetColor(ByVal bmp As Bitmap, ByVal color As Color) As Bitmap
            For i As Integer = 0 To bmp.Width - 1
                For j As Integer = 0 To bmp.Height - 1
                    If bmp.GetPixel(i, j).Name <> "0" Then
                        bmp.SetPixel(i, j, color)
                    End If
                Next j
            Next i
            Return bmp
        End Function
        Public Shared ReadOnly Property HtmlHyperLinkTextColor() As String
            Get
                Dim color As Color = EditorsSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("HyperLinkTextColor")
                Return GetRGBColor(color)
            End Get
        End Property
        Public Shared ReadOnly Property HtmlHighlightTextColor() As String
            Get
                Dim color As Color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("HighlightText")
                Return GetRGBColor(color)
            End Get
        End Property
        Public Shared ReadOnly Property HtmlControlTextColor() As String
            Get
                Dim color As Color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("ControlText")
                Return GetRGBColor(color)
            End Get
        End Property
        Public Shared ReadOnly Property HtmlControlTextColor2() As String
            Get
                Dim color As Color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("WindowText")
                Return GetRGBColor(color)
            End Get
        End Property
        Public Shared ReadOnly Property HtmlQuestionColor() As String
            Get
                Dim color As Color = CommonColors.GetQuestionColor(DevExpress.LookAndFeel.UserLookAndFeel.Default)
                Return GetRGBColor(color)
            End Get
        End Property
        Public Shared ReadOnly Property HtmlWarningColor() As String
            Get
                Dim color As Color = CommonColors.GetWarningColor(DevExpress.LookAndFeel.UserLookAndFeel.Default)
                Return GetRGBColor(color)
            End Get
        End Property
        Public Shared ReadOnly Property DisabledTextColor() As Color
            Get
                Return CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("DisabledText")
            End Get
        End Property
        Public Shared ReadOnly Property CriticalColor() As Color
            Get
                Return CommonColors.GetCriticalColor(DevExpress.LookAndFeel.UserLookAndFeel.Default)
            End Get
        End Property
        Public Shared ReadOnly Property WarningColor() As Color
            Get
                Return CommonColors.GetWarningColor(DevExpress.LookAndFeel.UserLookAndFeel.Default)
            End Get
        End Property
        Private Shared Function GetRGBColor(ByVal color As Color) As String
            Return String.Format("{0},{1},{2}", color.R, color.G, color.B)
        End Function
    End Class
    Public Class ObjectHelper
        Private Shared rich As New RichEditDocumentServer()
        Public Shared Function GetPlainTextFromMHT(ByVal mhtText As String) As String
            rich.MhtText = mhtText
            Return rich.Text.TrimStart()
        End Function
        Public Shared Function GetMHTTextFromHTML(ByVal htmlText As String) As String
            rich.HtmlText = htmlText
            Return rich.MhtText
        End Function
        Public Shared Sub ShowWebSite(ByVal url As String)
            If url Is Nothing Then
                Return
            End If
            Dim processName As String = GetCorrectUrl(url)
            If processName.Length = 0 Then
                Return
            End If
            StartProcess(processName)
        End Sub
        Public Shared Function GetCorrectUrl(ByVal url As String) As String
            Dim ret As String = url.Replace(" ", String.Empty)
            If ret.Length = 0 Then
                Return String.Empty
            End If
            Const protocol As String = "http://"
            Const protocol2 As String = "https://"
            If ret.IndexOf(protocol) <> 0 AndAlso ret.IndexOf(protocol2) <> 0 Then
                ret = protocol & ret
            End If
            Return ret
        End Function
        Public Shared Sub StartProcess(ByVal processName As String)
            If (Data.Utils.SafeProcess.Start(processName) Is Nothing) Then
                XtraMessageBox.Show("", My.Resources._Error, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub
    End Class
    Public Class NavBarHelper
        Public Shared Sub DeleteEmptyGroup(ByVal nb As NavBarControl)
            For i As Integer = nb.Groups.Count - 1 To 0 Step -1
                If nb.Groups(i).ItemLinks.Count = 0 Then
                    nb.Groups.RemoveAt(i)
                End If
            Next i
        End Sub
        Public Shared Function GetFirstItem(ByVal nb As NavBarControl) As NavBarItemLink
            For Each group As NavBarGroup In nb.Groups
                For Each link As NavBarItemLink In group.ItemLinks
                    Return link
                Next link
            Next group
            Return Nothing
        End Function
        Public Shared Function GetGroupByName(ByVal groupName As String, ByVal navBar As NavBarControl) As NavBarGroup
            Dim group As NavBarGroup = Nothing
            For Each fGroup As NavBarGroup In navBar.Groups
                If fGroup.Name.Equals(groupName) Then
                    group = fGroup
                End If
            Next fGroup
            If group Is Nothing Then
                group = New NavBarGroup(groupName)
                group.Name = groupName
                navBar.Groups.Add(group)
            End If
            Return group
        End Function
        Public Shared Sub SetNavBarItemImage(ByVal item As NavBarItem, ByVal link As String)
            Dim pe As New PictureEdit()
            pe.LoadAsync(ImageHelper.GetFaviconIconPath(link))
            pe.Tag = item
            AddHandler pe.LoadCompleted, AddressOf pe_LoadCompleted

        End Sub
        Private Shared Sub pe_LoadCompleted(ByVal sender As Object, ByVal e As EventArgs)
            Dim pe As RepositoryItemPictureEdit = TryCast(sender, RepositoryItemPictureEdit)
            Dim item As NavBarItem = TryCast(pe.OwnerEdit.Tag, NavBarItem)
            item.SmallImage = ImageHelper.GetScaleImage(CType(pe.OwnerEdit, PictureEdit).Image, New Size(16, 16))
            pe.OwnerEdit.Dispose()
            pe.Dispose()
        End Sub
        Public Shared Function GetGroupNames(ByVal navBar As NavBarControl) As Object()
            Dim ret As New List(Of String)()
            For Each group As NavBarGroup In navBar.Groups
                ret.Add(group.Caption)
            Next group
            Return ret.ToArray()
        End Function
        Public Shared Function GetItemNames(ByVal navBar As NavBarControl) As List(Of String)
            Dim ret As New List(Of String)()
            For Each item As NavBarItem In navBar.Items
                ret.Add(item.Caption)
            Next item
            Return ret
        End Function

        Public Shared Function GetUniqueItemName(ByVal name As String, ByVal navBar As NavBarControl) As String
            Dim names As List(Of String) = GetItemNames(navBar)
            For i As Integer = 1 To 9998
                Dim ret As String = String.Format("{0}{1}", name, i)
                If Not names.Contains(ret) Then
                    Return ret
                End If
            Next i
            Return String.Empty

        End Function
    End Class
    Public Class UniqueNameValidationRule
        Inherits ValidationRule

        Private values As List(Of String)
        Public Sub New(ByVal values As List(Of String))
            Me.values = values
        End Sub
        Public Overrides Function Validate(ByVal control As Control, ByVal value As Object) As Boolean
            Dim str As String = DirectCast(value, String)
            For Each val As String In values
                If Not ValidationHelper.Validate(str, ConditionOperator.NotEquals, val, Nothing, Nothing, False) Then
                    Return False
                End If
            Next val
            Return True
        End Function
    End Class
    Public Class ValidationRulesHelper
        Private Shared ruleIsNotBlank_Field As ConditionValidationRule = Nothing
        Public Shared ReadOnly Property RuleIsNotBlank() As ConditionValidationRule
            Get
                If ruleIsNotBlank_Field Is Nothing Then
                    ruleIsNotBlank_Field = New ConditionValidationRule()
                    ruleIsNotBlank_Field.ConditionOperator = ConditionOperator.IsNotBlank
                    ruleIsNotBlank_Field.ErrorText = My.Resources.RuleIsNotBlankWarning
                    ruleIsNotBlank_Field.ErrorType = ErrorType.Critical
                End If
                Return ruleIsNotBlank_Field
            End Get
        End Property
    End Class
    Public Class EditorHelper
        Public Shared Function CreateTaskStatusImageComboBox(ByVal edit As RepositoryItemImageComboBox) As RepositoryItemImageComboBox
            Dim arr As Array = System.Enum.GetValues(GetType(TaskStatus))
            edit.Items.Clear()
            For Each status As TaskStatus In arr
                edit.Items.Add(New ImageComboBoxItem(GetStringByTaskStatus(status), status, CInt(status)))
            Next status
            Return edit
        End Function
        Private Shared Function GetStringByTaskStatus(ByVal status As TaskStatus) As String
            Select Case status
                Case TaskStatus.Completed
                    Return My.Resources.TaskStatusCompleted
                Case TaskStatus.Deferred
                    Return My.Resources.TaskStatusDeferred
                Case TaskStatus.InProgress
                    Return My.Resources.TaskStatusInProgress
                Case TaskStatus.WaitingOnSomeoneElse
                    Return My.Resources.TaskStatusWaitingOnSomeoneElse
            End Select
            Return My.Resources.TaskStatusNotStarted
        End Function
        Public Shared Function CreateTaskCategoryImageComboBox(ByVal edit As RepositoryItemImageComboBox) As RepositoryItemImageComboBox
            edit.Items.Clear()
            edit.Items.Add(New ImageComboBoxItem(My.Resources.TaskCategoryHouseChores, TaskCategory.HouseChores, 0))
            edit.Items.Add(New ImageComboBoxItem(My.Resources.TaskCategoryShopping, TaskCategory.Shopping, 1))
            edit.Items.Add(New ImageComboBoxItem(My.Resources.TaskCategoryOffice, TaskCategory.Office, 2))
            Return edit
        End Function
        Public Shared Function CreateFlagStatusImageComboBox(ByVal edit As RepositoryItemImageComboBox) As RepositoryItemImageComboBox
            edit.Items.Clear()
            edit.SmallImages = CreateFlagStatusImageCollection()
            edit.GlyphAlignment = HorzAlignment.Center
            edit.Items.Add(New ImageComboBoxItem(My.Resources.Today, FlagStatus.Today, CInt(FlagStatus.Today)))
            edit.Items.Add(New ImageComboBoxItem(My.Resources.Tomorrow, FlagStatus.Tomorrow, CInt(FlagStatus.Tomorrow)))
            edit.Items.Add(New ImageComboBoxItem(My.Resources.ThisWeek, FlagStatus.ThisWeek, CInt(FlagStatus.ThisWeek)))
            edit.Items.Add(New ImageComboBoxItem(My.Resources.NextWeek, FlagStatus.NextWeek, CInt(FlagStatus.NextWeek)))
            edit.Items.Add(New ImageComboBoxItem(My.Resources.NoDate, FlagStatus.NoDate, CInt(FlagStatus.NoDate)))
            edit.Items.Add(New ImageComboBoxItem(My.Resources.Custom, FlagStatus.Custom, CInt(FlagStatus.Custom)))
            edit.Items.Add(New ImageComboBoxItem(My.Resources.Completed, FlagStatus.Completed, CInt(FlagStatus.Completed)))
            Return edit
        End Function
        Public Shared Sub InitPriorityComboBox(ByVal edit As RepositoryItemImageComboBox)
            edit.Items.Clear()
            edit.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(My.Resources.PriorityLow, 0, 0),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(My.Resources.PriorityMedium, 1, -1),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(My.Resources.PriorityHigh, 2, 1)
            })
        End Sub
        Public Shared Sub InitTitleComboBox(ByVal edit As RepositoryItemImageComboBox)
            Dim iCollection As New ImageCollection()
            iCollection.AddImage(My.Resources.Doctor)
            iCollection.AddImage(My.Resources.Miss)
            iCollection.AddImage(My.Resources.Mr)
            iCollection.AddImage(My.Resources.Mrs)
            iCollection.AddImage(My.Resources.Ms)
            iCollection.AddImage(My.Resources.Professor)
            edit.Items.Add(New ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Dr), PersonPrefix.Dr, 0))
            edit.Items.Add(New ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Miss), PersonPrefix.Miss, 1))
            edit.Items.Add(New ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Mr), PersonPrefix.Mr, 2))
            edit.Items.Add(New ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Mrs), PersonPrefix.Mrs, 3))
            edit.Items.Add(New ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Ms), PersonPrefix.Ms, 4))
            edit.SmallImages = iCollection
        End Sub
        Public Shared Function GetTitleNameByContactTitle(ByVal title As PersonPrefix) As String
            Select Case title
                Case PersonPrefix.Dr
                    Return My.Resources.ContactTitleDr
                Case PersonPrefix.Miss
                    Return My.Resources.ContactTitleMiss
                Case PersonPrefix.Mr
                    Return My.Resources.ContactTitleMr
                Case PersonPrefix.Mrs
                    Return My.Resources.ContactTitleMrs
                Case PersonPrefix.Ms
                    Return My.Resources.ContactTitleMs
            End Select
            Return String.Empty
        End Function
        Private Shared Function CreateFlagStatusImageCollection() As ImageCollection
            Dim ret As New ImageCollection()
            ret.AddImage(My.Resources.Today_Flag)
            ret.AddImage(My.Resources.Tomorrow_Flag)
            ret.AddImage(My.Resources.ThisWeek_Flag)
            ret.AddImage(My.Resources.NextWeek_Flag)
            ret.AddImage(My.Resources.NoDate_Flag)
            ret.AddImage(My.Resources.Custom_Flag)
            ret.AddImage(My.Resources.Completed_16x16)
            Return ret
        End Function

        Friend Shared Function GetCities() As List(Of String)
            Dim cities As IEnumerable = (
                From contact In DataHelper.Contacts
                Select contact.City).OrderBy(Function(s) s).Distinct()
            Return cities.Cast(Of String)().ToList()
        End Function
        Friend Shared Function GetStates() As List(Of String)
            Dim states As IEnumerable = (
                From contact In DataHelper.Contacts
                Select contact.State).OrderBy(Function(s) s).Distinct()
            Return states.Cast(Of String)().ToList()
        End Function
    End Class
    Public Class TokenEditHelper
        Public Shared Sub Initialize(ByVal tokenEdit As TokenEdit)
            For Each contact As Contact In DataHelper.Contacts.OrderBy(Function(p) p.EmployeeName)
                Dim item As New TokenEditToken(contact.EmployeeName, contact)
                tokenEdit.Properties.Tokens.Add(item)
            Next contact
        End Sub
        Public Shared Function ParseFromField(ByVal fromField As String) As IList(Of Contact)
            Dim contactList As New BindingList(Of Contact)()
            If String.IsNullOrEmpty(fromField) Then
                Return contactList
            End If
            For Each from As String In SplitFromField(fromField)
                Dim contact As Contact = DataHelper.FindByName([from])
                If contact Is Nothing Then
                    contact = New UnknownContact(FormatEmail([from]))
                End If
                contactList.Add(contact)
            Next from
            Return contactList
        End Function
        Public Shared Function FormatContactList(ByVal contactList As IList(Of Contact)) As String
            Return String.Join(", ", contactList)
        End Function
        Public Shared Function ValidateEmail(ByVal email As String) As Boolean
            Return EmailRegex.IsMatch(email)
        End Function
        Private Shared Iterator Function SplitFromField(ByVal fromField As String) As IEnumerable(Of String)
            Dim parts() As String = fromField.Split(PossibleSeparators)
            For n As Integer = 0 To parts.Length - 1
                Yield parts(n).Trim()
            Next n
        End Function
        Private Shared ReadOnly PossibleSeparators() As Char = { ","c }

        Private Shared Function FormatEmail(ByVal [from] As String) As String
            If ValidateEmail([from]) Then
                Return [from]
            End If
            Return FormatEmailCore([from])
        End Function
        Private Shared Function FormatEmailCore(ByVal value As String) As String
            Dim builder As New StringBuilder(value)
            builder.Replace(" (", "_")
            builder.Replace(")"c, "_"c)
            builder.Replace(" "c, "_"c)
            builder.Replace("-"c, "_"c)
            builder.Append("@dxmail.net")
            Return builder.ToString()
        End Function
        Private Shared EmailRegex As New Regex("\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.Compiled)
    End Class
End Namespace
