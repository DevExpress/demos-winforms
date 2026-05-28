Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Data.Mask
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Mask.Design
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleMaskBox
        Inherits TutorialControl

        Shared Sub New()
            ' <DateRangeMaskManager>
            Call DateRangeMaskManager.Register()
            ' </DateRangeMaskManager>
            Call RegisterSpecificCaseMaskManagerPreview()
        End Sub

        Public Sub New()
            InitializeComponent()
            If Not DesignMode Then
                tabPane.Pages.BeginUpdate()
                For Each info In GetMaskManagers()
                    Dim maskTypePageControl = New MaskTypePage(info.Item1, info.Item2)
                    Dim page = tabPane.AddPage(maskTypePageControl)
                    page.Caption = MaskManager.GetName(Nothing, info.Item1)
                Next

                tabPane.Pages.EndUpdate()
                settingsPanel.ViewModel = AdvancedSettingsEditorViewModelSimple.Create(GetMaskSettings(tabPane.SelectedPage))
            End If
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleMaskBox"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "maskbox"
            End Get
        End Property

        Protected Overrides ReadOnly Property AllowCenterControls As Boolean
            Get
                Return False
            End Get
        End Property

        Protected ReadOnly Property SettingsViewModel As AdvancedSettingsEditorViewModelSimple
            Get
                Return CType(settingsPanel.ViewModel, AdvancedSettingsEditorViewModelSimple)
            End Get
        End Property

        Private Function GetMaskSettings(ByVal tabPage As TabNavigationPage) As MaskSettings
            If tabPage Is Nothing OrElse tabPage.Controls.Count = 0 Then Return Nothing
            Dim page = TryCast(tabPage.Controls(0), MaskTypePage)
            Return If(page IsNot Nothing, page.MaskSettings, Nothing)
        End Function

        Private Sub OnSelectedPageChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
            If e.Page Is Nothing OrElse settingsPanel.ViewModel Is Nothing Then Return
            SettingsViewModel.SetMaskSettings(GetMaskSettings(TryCast(e.Page, TabNavigationPage)))
        End Sub

        Private Iterator Function GetMaskManagers() As IEnumerable(Of Tuple(Of Type, Object))
            Yield New Tuple(Of Type, Object)(GetType(NumericMaskManager), 12345.67890D)
            Yield New Tuple(Of Type, Object)(GetType(DateTimeMaskManager), Date.Now)
            Yield New Tuple(Of Type, Object)(GetType(DateTimeOffsetMaskManager), DateTimeOffset.Now)
            Yield New Tuple(Of Type, Object)(GetType(DevExpress.Data.Mask.TimeSpanMaskManager), New TimeSpan(12, 23, 34, 45, 789))
            Yield New Tuple(Of Type, Object)(GetType(SimpleMaskManager), Nothing)
            Yield New Tuple(Of Type, Object)(GetType(RegularMaskManager), Nothing)
            Yield New Tuple(Of Type, Object)(GetType(RegExpMaskManager), Nothing)
            Yield New Tuple(Of Type, Object)(GetType(DateRangeMaskManager), New DateRange With {.From = Date.Now.AddDays(-5), .[To] = Date.Now.AddDays(5)})
            Yield New Tuple(Of Type, Object)(GetType(SpecificCaseMaskManager), "Lorem ipsum sit amet")
        End Function

        Protected Overrides Sub DoShow()
            If Parent IsNot Nothing Then Parent.Padding = Padding.Empty
            MyBase.DoShow()
        End Sub

#Region "Show Code"
        Private Sub ConfigureNumericMaskManager(ByVal textEdit As TextEdit)
            ' <NumericMaskManager>
            Dim numericSettings = textEdit.Properties.MaskSettings.Configure(Of MaskSettings.Numeric)()
            numericSettings.MaskExpression = "c2"
            numericSettings.AutoHideDecimalSeparator = True
            numericSettings.HideInsignificantZeros = True
            numericSettings.ValueAfterDelete = NumericMaskManager.ValueAfterDelete.Null
            numericSettings.ValueType = GetType(Decimal)
        ' </NumericMaskManager>
        End Sub

        Private Sub ConfigureDateTimeMaskManager(ByVal textEdit As TextEdit)
            ' <DateTimeMaskManager>
            Dim dateTimeSettings = textEdit.Properties.MaskSettings.Configure(Of MaskSettings.DateTime)()
            dateTimeSettings.MaskExpression = "g"
            dateTimeSettings.SpinWithCarry = True
            dateTimeSettings.UseAdvancingCaret = True
        ' </DateTimeMaskManager>
        End Sub

        Private Sub ConfigureDateTimeOffsetMaskManager(ByVal textEdit As TextEdit)
            ' <DateTimeOffsetMaskManager>
            Dim dateTimeOffsetSettings = textEdit.Properties.MaskSettings.Configure(Of MaskSettings.DateTimeOffset)()
            dateTimeOffsetSettings.MaskExpression = "c"
            dateTimeOffsetSettings.SpinWithCarry = True
            dateTimeOffsetSettings.UseAdvancingCaret = True
        ' </DateTimeOffsetMaskManager>
        End Sub

        Private Sub ConfigureTimeSpanMaskManager(ByVal textEdit As TextEdit)
            ' <TimeSpanMaskManager>
            Dim timeSpanSettings = textEdit.Properties.MaskSettings.Configure(Of MaskSettings.TimeSpan)()
            timeSpanSettings.MaskExpression = "t"
            timeSpanSettings.InputMode = TimeSpanMaskInputMode.NotRestrictedLargestUnit
            timeSpanSettings.AllowNegativeValues = False
            timeSpanSettings.EnableMnemonics = True
            timeSpanSettings.HideInsignificantPartsOnly = True
            timeSpanSettings.DefaultPart = TimeSpanMaskPart.Days
            timeSpanSettings.ResetPartsOnSelectAllInput = True
            timeSpanSettings.SpinWithCarry = True
            timeSpanSettings.UseAdvancingCaret = True
        ' </TimeSpanMaskManager>
        End Sub

        Private Sub ConfigureSimpleMaskManager(ByVal textEdit As TextEdit)
            ' <SimpleMaskManager>
            Dim simpleSettings = textEdit.Properties.MaskSettings.Configure(Of MaskSettings.Simple)()
            simpleSettings.MaskExpression = "(000)000-00-00"
            simpleSettings.Placeholder = "_"c
            simpleSettings.IgnoreBlank = True
            simpleSettings.SaveLiterals = False
        ' </SimpleMaskManager>
        End Sub

        Private Sub ConfigureRegularMaskManager(ByVal textEdit As TextEdit)
            ' <RegularMaskManager>
            Dim regularSettings = textEdit.Properties.MaskSettings.Configure(Of MaskSettings.Regular)()
            regularSettings.MaskExpression = "[0-9A-Z]{10}"
            regularSettings.Placeholder = "_"c
            regularSettings.IgnoreBlank = True
            regularSettings.SaveLiterals = False
        ' </RegularMaskManager>
        End Sub

        Private Sub ConfigureRegExpMaskManager(ByVal textEdit As TextEdit)
            ' <RegExpMaskManager>
            Dim regularSettings = textEdit.Properties.MaskSettings.Configure(Of MaskSettings.RegExp)()
            regularSettings.MaskExpression = "\d+(\R.\d{0,2})?"
            regularSettings.Placeholder = "_"c
            regularSettings.ShowPlaceholders = False
            regularSettings.IsAutoComplete = True
        ' </RegExpMaskManager>
        End Sub

        Private Sub ConfigureDateRangeMaskManager(ByVal textEdit As TextEdit)
            ' <DateRangeMaskManager>
            Dim dateRangeSettings = textEdit.Properties.MaskSettings.Configure(Of CustomMaskSettings.DateRange)()
            dateRangeSettings.MaskExpression = "d"
        ' </DateRangeMaskManager>
        End Sub

        Private Sub ConfigureSpecificCaseMaskManager(ByVal textEdit As TextEdit)
            ' <SpecificCaseMaskManager>
            Dim titleCaseSettings = textEdit.Properties.MaskSettings.Configure(Of CustomMaskSettings.SpecificCase)()
            titleCaseSettings.Case = SpecificCaseMaskManager.Case.Title
        ' </SpecificCaseMaskManager>
        End Sub

#End Region  ' Show Code
        ' <DateRangeMaskManager>
        Public MustInherit Partial Class CustomMaskSettings
            Inherits MaskSettings.User

            Public Class DateRange
                Inherits DevExpress.Data.Mask.Internal.MaskSettings(Of Global.DevExpress.XtraEditors.Mask.MaskType).MaskSettingsWithCulture

                Protected Overrides Function GetMaskManagerType() As Type
                    Return GetType(DateRangeMaskManager)
                End Function
            End Class
        End Class

        ' </DateRangeMaskManager>
        ' <SpecificCaseMaskManager>
        Public Partial Class CustomMaskSettings

            Public Class SpecificCase
                Inherits DevExpress.Data.Mask.Internal.MaskSettings(Of Global.DevExpress.XtraEditors.Mask.MaskType).MaskSettingsWithCulture

                Protected Overrides Function GetMaskManagerType() As Type
                    Return GetType(SpecificCaseMaskManager)
                End Function

                Public Property [Case] As SpecificCaseMaskManager.Case
                    Get
                        Return GetValue("case", SpecificCaseMaskManager.Case.Title)
                    End Get

                    Set(ByVal value As SpecificCaseMaskManager.Case)
                        SetValue("case", value)
                    End Set
                End Property
            End Class
        End Class

        ' </SpecificCaseMaskManager>
        Private Shared Sub RegisterSpecificCaseMaskManagerPreview()
            Call MaskManager.RegisterMaskManagerType(GetType(SpecificCaseMaskManager))
            Call MaskManager.RegisterMaskManagerInfo(GetType(SpecificCaseMaskManager), Nothing, description:="Custom mask with a specific text input processing")
            Call MaskManager.RegisterMaskManagerInfo(GetType(SpecificCaseMaskManager), standardMaskSpecifiers:=New MaskManager.ManagerInfo.StandardMaskSpecifier() {New MaskManager.ManagerInfo.StandardMaskSpecifier(Nothing, "Custom text input processing", String.Empty, "Lorem ipsum sit amet")}, customPlaceholders:=Nothing, helpLink:=Nothing, standardHelpLink:=Nothing, customHelpLink:=Nothing, advancedSettingsLink:=Nothing)
        End Sub
    End Class

    ' <DateRangeMaskManager>
    Public Structure DateRange

        Public Property From As Date?

        Public Property [To] As Date?

        Public Overrides Function ToString() As String
            If Not From.HasValue AndAlso Not [To].HasValue Then Return "(Empty)"
            If Not From.HasValue Then Return [To].Value.ToShortDateString()
            If Not [To].HasValue Then Return From.Value.ToShortDateString()
            Return From.Value.ToShortDateString() & DateRangeMaskManager.Separator & [To].Value.ToShortDateString()
        End Function
    End Structure

    <MaskManager.Compatible(GetType(DateTimeMaskManager))>
    Public Class DateRangeMaskManager
        Inherits MaskManager

        Public Shared Sub Register()
            Call RegisterMaskManagerType(GetType(DateRangeMaskManager))
            Call RegisterMaskManagerInfo(GetType(DateRangeMaskManager), Nothing, description:="Mask to enter date ranges")
            Call RegisterMaskManagerInfo(GetType(DateRangeMaskManager), standardMaskSpecifiers:=New ManagerInfo.StandardMaskSpecifier() {New ManagerInfo.StandardMaskSpecifier(Nothing, "Short date format", "d", Date.Now.ToShortDateString() & Separator & Date.Now.AddDays(5).ToShortDateString()), New ManagerInfo.StandardMaskSpecifier(Nothing, "Month/day format", "m", Date.Now.ToString("m") & Separator & Date.Now.AddDays(35).ToString("m"))}, customPlaceholders:=Nothing, helpLink:=Nothing, standardHelpLink:=Nothing, customHelpLink:=Nothing, advancedSettingsLink:=Nothing)
        End Sub

        <Parameters("EditorsMainDemo, DevExpress.XtraEditors.Demos.DateRangeMaskManager", "Date Ranges (Custom Mask)")>
        Public Sub New(<Parameter("mask", "Mask Expression")> ByVal mask As String, <Parameter("cultureInfo")> <Parameter("culture", GetType(CultureInfoConverter), "Culture (name)", Visibility:=ParameterVisibility.Advanced)> ByVal cultureInfo As CultureInfo)
            NestedManagers = InitializeNestedManagers(mask, cultureInfo)
        End Sub

        ' </DateRangeMaskManager>
        Private Function InitializeNestedManagers(ByVal mask As String, ByVal cultureInfo As CultureInfo) As MaskManager()
            Dim nestedManagers = New MaskManager() {New DateTimeMaskManager(mask, True, cultureInfo, True, True), New DateTimeMaskManager(mask, True, cultureInfo, True, True)}
            For Each nested As MaskManager In nestedManagers
                AddHandler nested.EditTextChanging, AddressOf Nested_EditTextChanging
                AddHandler nested.EditTextChanged, AddressOf Nested_EditTextChanged
                AddHandler nested.LocalEditAction, AddressOf Nested_LocalEditAction
            Next

            Return nestedManagers
        End Function

        Private Sub Nested_LocalEditAction(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = Not RaiseModifyWithoutEditValueChange()
        End Sub

        Private Sub Nested_EditTextChanging(ByVal sender As Object, ByVal e As MaskChangingEventArgs)
            e.Cancel = Not RaiseEditTextChanging(e.NewValue)
        End Sub

        Private Sub Nested_EditTextChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEditTextChanged()
        End Sub

        Public Const Separator As String = " - "

        Protected ReadOnly NestedManagers As MaskManager()

        Protected Index As Integer

        Protected ReadOnly Property ActiveManager As MaskManager
            Get
                Return NestedManagers(Index)
            End Get
        End Property

        Public Overrides ReadOnly Property DisplayText As String
            Get
                Return String.Join(Separator, NestedManagers.[Select](Function(m) m.DisplayText))
            End Get
        End Property

        Protected ReadOnly Property ActiveDisplayOffset As Integer
            Get
                Return Enumerable.Range(0, Index).Sum(Function(i) NestedManagers(i).DisplayText.Length + Separator.Length)
            End Get
        End Property

        Public Overrides ReadOnly Property DisplayCursorPosition As Integer
            Get
                Return ActiveDisplayOffset + ActiveManager.DisplayCursorPosition
            End Get
        End Property

        Public Overrides ReadOnly Property DisplaySelectionAnchor As Integer
            Get
                Return ActiveDisplayOffset + ActiveManager.DisplaySelectionAnchor
            End Get
        End Property

        Public Overrides ReadOnly Property CanUndo As Boolean
            Get
                Return ActiveManager.CanUndo
            End Get
        End Property

        Public Overrides Function Backspace() As Boolean
            Return ActiveManager.Backspace()
        End Function

        Public Overrides Function CursorEnd(ByVal forceSelection As Boolean) As Boolean
            If Index = NestedManagers.Length - 1 AndAlso ActiveManager.DisplaySelectionLength = ActiveManager.DisplayText.Length Then Return False
            ActiveManager.FlushPendingEditActions()
            Index = NestedManagers.Length - 1
            ActiveManager.SelectAll()
            Return True
        End Function

        Public Overrides Function CursorHome(ByVal forceSelection As Boolean) As Boolean
            If Index = 0 AndAlso ActiveManager.DisplaySelectionLength = ActiveManager.DisplayText.Length Then Return False
            ActiveManager.FlushPendingEditActions()
            Index = NestedManagers.Length - 1
            ActiveManager.SelectAll()
            Return True
        End Function

        Public Overrides Function CursorMoveNear(ByVal forceSelection As Boolean, ByVal isNeededKeyCheck As Boolean) As Boolean
            If ActiveManager.DisplaySelectionLength <> ActiveManager.DisplayText.Length Then
                Dim nr As Boolean = ActiveManager.CursorLeft(forceSelection, isNeededKeyCheck)
                If nr OrElse forceSelection Then Return nr
            End If

            If Index = 0 Then Return False
            If isNeededKeyCheck Then Return True
            ActiveManager.FlushPendingEditActions()
            Threading.Interlocked.Decrement(Index)
            ActiveManager.SelectAll()
            Return True
        End Function

        Public Overrides Function CursorMoveFar(ByVal forceSelection As Boolean, ByVal isNeededKeyCheck As Boolean) As Boolean
            If ActiveManager.DisplaySelectionLength <> ActiveManager.DisplayText.Length Then
                Dim nr As Boolean = ActiveManager.CursorRight(forceSelection, isNeededKeyCheck)
                If nr OrElse forceSelection Then Return nr
            End If

            If Index = NestedManagers.Length - 1 Then Return False
            If isNeededKeyCheck Then Return True
            ActiveManager.FlushPendingEditActions()
            Threading.Interlocked.Increment(Index)
            ActiveManager.SelectAll()
            Return True
        End Function

        Public Overrides Function CursorToDisplayPosition(ByVal newPosition As Integer, ByVal forceSelection As Boolean) As Boolean
            Dim runningoffset As Integer = 0, i As Integer = 0
            Do
                runningoffset += NestedManagers(i).DisplayText.Length + Separator.Length
                Threading.Interlocked.Increment(i)
            Loop While newPosition >= runningoffset - Separator.Length \ 2

            Dim toEditorIndex As Integer = i - 1
            If toEditorIndex = Index Then Return ActiveManager.CursorToDisplayPosition(newPosition - ActiveDisplayOffset, forceSelection)
            If forceSelection Then
                Return False
            Else
                ActiveManager.FlushPendingEditActions()
                Index = toEditorIndex
                ActiveManager.CursorToDisplayPosition(newPosition - ActiveDisplayOffset, forceSelection)
                Return True
            End If
        End Function

        Public Overrides Function Delete() As Boolean
            Return ActiveManager.Delete()
        End Function

        Public Overrides Function GetCurrentEditText() As String
            Throw New NotImplementedException()
        End Function

        Public Overrides Function GetCurrentEditValue() As Object
            Return New DateRange With {.From = CType(NestedManagers(0).GetCurrentEditValue(), Date?), .[To] = CType(NestedManagers(1).GetCurrentEditValue(), Date?)}
        End Function

        Public Overrides Function Insert(ByVal insertion As String) As Boolean
            Return ActiveManager.Insert(insertion)
        End Function

        Public Overrides Sub SelectAll()
            ActiveManager.SelectAll()
        End Sub

        Public Overrides Sub SetInitialEditText(ByVal initialEditText As String)
            Throw New NotImplementedException()
        End Sub

        Public Overrides Sub SetInitialEditValue(ByVal initialEditValue As Object)
            If Not(TypeOf initialEditValue Is DateRange) Then
                For Each m In NestedManagers
                    m.SetInitialEditValue(Nothing)
                Next
            Else
                Dim range = CType(initialEditValue, DateRange)
                NestedManagers(0).SetInitialEditValue(range.From)
                NestedManagers(0).SelectAll()
                NestedManagers(1).SetInitialEditValue(range.To)
                NestedManagers(1).SelectAll()
            End If

            Index = 0
        End Sub

        Public Overrides Function FlushPendingEditActions() As Boolean
            Dim result As Boolean = False
            Dim i As Integer = 0
            While i < NestedManagers.Length
                result = result Or NestedManagers(i).FlushPendingEditActions()
                Threading.Interlocked.Increment(i)
            End While

            Return result
        End Function

        Public Overrides Function SpinDown() As Boolean
            Return ActiveManager.SpinDown()
        End Function

        Public Overrides Function SpinUp() As Boolean
            Return ActiveManager.SpinUp()
        End Function

        Public Overrides Function Undo() As Boolean
            Return ActiveManager.Undo()
        End Function
    End Class

    ' <SpecificCaseMaskManager>
    Public Class SpecificCaseMaskManager
        Inherits CustomTextMaskManager

        Public Enum [Case]
            Title
            Upper
            Lower
        End Enum

        Private ReadOnly caseField As [Case]

        <Parameters("EditorsMainDemo, DevExpress.XtraEditors.Demos.SpecificCaseMaskManager", "Specific Case (Custom Mask)")>
        Public Sub New(<Parameter("case", "Specific Case")> ByVal Optional [case] As [Case] = [Case].Title, <Parameter("tag", "Tag", Visibility:=ParameterVisibility.Hidden)> ByVal Optional tag As Object = Nothing)
            MyBase.New(tag)
            caseField = [case]
        End Sub

        Protected Overrides Sub ProcessCustomTextMaskInput(ByVal ea As CustomTextMaskInputArgs)
            If ea.IsCanceled Then Return
            Dim textInfo = CultureInfo.InvariantCulture.TextInfo
            Select Case caseField
                Case [Case].Title
                    ea.SetResult(textInfo.ToTitleCase(ea.ResultEditText), ea.ResultCursorPosition, ea.ResultSelectionAnchor)
                Case [Case].Upper
                    ea.SetResult(textInfo.ToUpper(ea.ResultEditText), ea.ResultCursorPosition, ea.ResultSelectionAnchor)
                Case [Case].Lower
                    ea.SetResult(textInfo.ToLower(ea.ResultEditText), ea.ResultCursorPosition, ea.ResultSelectionAnchor)
            End Select
        End Sub
    End Class

    ' </SpecificCaseMaskManager>
    '
#Region "Infrastructural Code"
    Public Partial Class MaskTypePage
        Inherits MaskSettingsForm.PropertyEditorBase

        Private ReadOnly settingsSource As RepositoryItemTextEdit = New RepositoryItemTextEdit()

        Friend Sub New(ByVal maskManagerType As Type, ByVal editValue As Object)
            settingsSource.MaskSettings.MaskManagerType = maskManagerType
            settingsSource.UseMaskAsDisplayFormat = True
            InitializeComponent(maskManagerType, editValue)
            ScrollBarBase.ApplyFluent(scrollableContainer)
            EnsureAutoScaleMode()
        End Sub

        Private Sub EnsureAutoScaleMode()
            If Utils.DPI.DpiAwarenessHelper.Default.IsPerMonitor() Then AutoScaleMode = AutoScaleMode.Inherit 'PM2
        End Sub

        Public ReadOnly Property MaskSettings As MaskSettings
            Get
                Return settingsSource.MaskSettings
            End Get
        End Property

#Region "Component Designer generated code"
        Private Sub InitializeComponent(ByVal maskManagerType As Type, ByVal editValue As Object)
            rootPanel = New Utils.Layout.TablePanel()
            masksPreview = New XtraEditors.Mask.Design.MasksPreview()
            scrollableContainer = New XtraScrollableControl()
            CType(rootPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            rootPanel.SuspendLayout()
            scrollableContainer.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' rootPanel
            ' 
            rootPanel.AutoSize = True
            rootPanel.Columns.AddRange(New Utils.Layout.TablePanelColumn() {New Utils.Layout.TablePanelColumn(Utils.Layout.TablePanelEntityStyle.Relative, 1F), New Utils.Layout.TablePanelColumn(Utils.Layout.TablePanelEntityStyle.Absolute, 400F), New Utils.Layout.TablePanelColumn(Utils.Layout.TablePanelEntityStyle.Relative, 1F)})
            rootPanel.Controls.Add(masksPreview)
            rootPanel.Dock = DockStyle.Top
            rootPanel.Location = New System.Drawing.Point(0, 0)
            rootPanel.Margin = New Padding(0)
            rootPanel.Name = "rootPanel"
            rootPanel.Rows.AddRange(New Utils.Layout.TablePanelRow() {New Utils.Layout.TablePanelRow(Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            rootPanel.Size = New System.Drawing.Size(600, 600)
            rootPanel.TabIndex = 0
            ' 
            ' masksPreview
            ' 
            masksPreview.AutoSize = True
            rootPanel.SetColumn(masksPreview, 1)
            masksPreview.Dock = DockStyle.Fill
            masksPreview.Location = New System.Drawing.Point(100, 0)
            masksPreview.Margin = New Padding(0, 40, 0, 40)
            masksPreview.Name = maskManagerType.Name
            rootPanel.SetRow(masksPreview, 0)
            masksPreview.ViewModel = XtraEditors.Mask.Design.MasksPreviewViewModel.Create(maskManagerType, editValue, settingsSource)
            ' 
            ' scrollableContainer
            ' 
            scrollableContainer.Controls.Add(rootPanel)
            scrollableContainer.Dock = DockStyle.Fill
            scrollableContainer.Location = New System.Drawing.Point(0, 0)
            scrollableContainer.Margin = New Padding(0)
            scrollableContainer.Name = "scrollableContainer"
            scrollableContainer.Size = New System.Drawing.Size(600, 600)
            ' 
            ' MaskTypePage
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(scrollableContainer)
            Margin = New Padding(0)
            Name = "MaskTypePage"
            Padding = New Padding(0)
            Size = New System.Drawing.Size(600, 600)
            CType(rootPanel, System.ComponentModel.ISupportInitialize).EndInit()
            rootPanel.ResumeLayout(False)
            rootPanel.PerformLayout()
            scrollableContainer.ResumeLayout(False)
            scrollableContainer.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private rootPanel As Utils.Layout.TablePanel

        Private masksPreview As XtraEditors.Mask.Design.MasksPreview

        Private scrollableContainer As XtraScrollableControl
    End Class
#End Region  ' Infrastructural Code
End Namespace
