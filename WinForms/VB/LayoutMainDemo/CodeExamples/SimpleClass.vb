Imports System
Imports DevExpress.XtraLayout
Imports DevExpress.Utils
Imports System.Globalization
Imports DevExpress.XtraEditors
Imports DevExpress.DXperience.Demos.CodeDemo
Imports System.Windows.Forms
Imports DevExpress.XtraLayout.Utils
Imports System.Drawing
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraDataLayout
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel
Imports DevExpress.XtraLayout.Customization
Imports DevExpress.XtraLayout.Customization.Controls
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraLayout.Registrator
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils.Design
Imports DevExpress.XtraEditors.ButtonsPanelControl
Imports DevExpress.XtraEditors.Controls
Imports System.Collections.Generic

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Create layout in code", "SimpleClass.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup", "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "LayoutType", "SizeType", "Size", "LayoutMode", "SizeConstraintsType")>
    Public Module CreateLayoutInCode

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim layoutControl As DevExpress.XtraLayout.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            layoutControl.Parent = sampleHost
            Return New Object() {layoutControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraLayout.LayoutControl).Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Horizontal arrangement")>
        Public Sub CreateHorzAlignedLayout(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' A layout consisting of two horizontally arranged items.
            layoutControl.Root.DefaultLayoutType = DevExpress.XtraLayout.Utils.LayoutType.Horizontal
            layoutControl.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Text = "Memo1", .Name = "Memo1"})
            layoutControl.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Text = "Memo2", .Name = "Memo2"})
            layoutControl.BestFit()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Vertical arrangement")>
        Public Sub CreateVertAlignedLayout(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' A layout consisting of two vertically arranged items.
            layoutControl.Root.DefaultLayoutType = DevExpress.XtraLayout.Utils.LayoutType.Vertical
            layoutControl.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Text = "Memo1", .Name = "Memo1"})
            layoutControl.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Text = "Memo2", .Name = "Memo2"})
            layoutControl.BestFit()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Visible and hidden items")>
        Public Sub CreateVisibleAndHiddenItems(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example creates a layout consisting of two items displaying two text boxes. 
            ' In addition, one hidden item (containing a memo editor) is also created. It can be accessed from the Customization Form.
            'Create a layout item and add it to the root group.    
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.Root.AddItem()
            ' Set the item's Control and caption.
            item1.Name = "Layout Item 1"
            Dim textEdit As DevExpress.XtraEditors.TextEdit = New DevExpress.XtraEditors.TextEdit()
            textEdit.Name = "TextBox1"
            item1.Control = textEdit
            item1.Text = "Name:"
            ' Create a new layout item.
            Dim item2 As DevExpress.XtraLayout.LayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            ' Add the item to the root group by setting its parent.
            item2.Parent = layoutControl.Root
            item2.Name = "Layout Item 2"
            Dim textBox2 As DevExpress.XtraEditors.TextEdit = New DevExpress.XtraEditors.TextEdit()
            textBox2.Name = "TextBox2"
            item2.Control = textBox2
            item2.Text = "E-mail:"
            ' Create a hidden layout item.
            Dim item3 As DevExpress.XtraLayout.LayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            item3.Name = "Layout Item 3"
            layoutControl.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {item3})
            Dim memo As DevExpress.XtraEditors.MemoEdit = New DevExpress.XtraEditors.MemoEdit()
            memo.Name = "memo1"
            item3.Control = memo
            item3.Text = "Notes:"
        'layoutControl.ShowCustomizationForm();
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Group with title and borders")>
        Public Sub CreateGroupWithTitleBorder(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example creates a layout containing a group of two items.
            ' The second item is positioned using the Move method, 
            ' which allows you to place an item at any of the four edges of another item.
            ' Create a new "Personal Info" group.
            Dim group1 As DevExpress.XtraLayout.LayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            group1.Name = "GroupPersonalInfo"
            group1.Text = "Personal Info"
            ' Create a layout item within the group.
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = group1.AddItem()
            ' Bind a control to the layout item.
            Dim textEdit As DevExpress.XtraEditors.TextEdit = New DevExpress.XtraEditors.TextEdit()
            textEdit.Name = "TextBox1"
            item1.Control = textEdit
            item1.Text = "Name"
            ' Create a layout item that will display a DateEdit control.
            Dim dtPicker As DevExpress.XtraEditors.DateEdit = New DevExpress.XtraEditors.DateEdit()
            dtPicker.Name = "dateEdit"
            Dim item2 As DevExpress.XtraLayout.LayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem(layoutControl, dtPicker)
            item2.Text = "Date"
            ' Position this item to the right of item1
            item2.Move(item1, DevExpress.XtraLayout.Utils.InsertType.Right)
            ' Add the created group to the root group.
            layoutControl.Root.Add(group1)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Tabbed group")>
        Public Sub CreateTabbedGroup(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example creates a layout containing a tabbed group that has two tabs (regular groups).
            ' Each tab displays a single control (PictureEdit and MemoEdit, respectively).
            ' Create a tabbed group within the root group.
            Dim tabbedGroup As DevExpress.XtraLayout.TabbedControlGroup = layoutControl.Root.AddTabbedGroup()
            tabbedGroup.Name = "TabbedGroup"
            ' Add a new group as a tab to the tabbed group.
            Dim group1 As DevExpress.XtraLayout.LayoutControlGroup = TryCast(tabbedGroup.AddTabPage(), DevExpress.XtraLayout.LayoutControlGroup)
            group1.Name = "LayoutControlGroup1"
            group1.Text = "Photo"
            ' Add a new layout item to the group that will display an image.
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = group1.AddItem()
            item1.Name = "LayoutControlItem1"
            item1.Control = New DevExpress.XtraEditors.PictureEdit() With {.Name = "PictureEdit"}
            ' Hide the item's text region.
            item1.TextVisible = False
            ' Add a new group to the tabbed group.
            Dim group2 As DevExpress.XtraLayout.LayoutControlGroup = TryCast(tabbedGroup.AddTabPage(), DevExpress.XtraLayout.LayoutControlGroup)
            group2.Name = "LayoutControlGroup2"
            group2.Text = "Notes"
            ' Add a new layout item to the group that will display an image.
            Dim item2 As DevExpress.XtraLayout.LayoutControlItem = group2.AddItem()
            item2.Name = "LayoutControlItem1"
            item2.Control = New DevExpress.XtraEditors.MemoEdit() With {.Name = "MemoEdit"}
            ' Hide the item's text region.
            item2.TextVisible = False
            ' Make the first tab page active.
            tabbedGroup.SelectedTabPage = group1
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("M rows x N columns layout")>
        Public Sub CreateMxNLayout(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' A layout consisting of a specified number of columns and rows.
            Dim rowCount As Integer = 4
            Dim columnCount As Integer = 4
            Dim group As DevExpress.XtraLayout.LayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            group.BeginUpdate()
            For i As Integer = 0 To rowCount - 1
                For j As Integer = 0 To columnCount - 1
                    Dim itemIndex As Integer = group.Items.Count + 1
                    Dim item As DevExpress.XtraLayout.LayoutControlItem = group.AddItem("Memo" & itemIndex, New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo" & itemIndex})
                    item.Location = New System.Drawing.Point(i * 100, j * 100)
                    item.Size = New System.Drawing.Size(100, 100)
                Next
            Next

            group.EndUpdate()
            layoutControl.Root = group
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Highlight Focused item")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DefaultBoolean")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("HighlightFocusedItem"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(162)>
        Public Sub HighLightFocusedItem(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' HighlightFocusedItem at the item's level
            'layoutControl.OptionsView.HighlightFocusedItem = true;
            Dim newItem1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Text = "Memo1", .Name = "Memo1"})
            newItem1.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
            Dim newItem2 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Text = "Memo2", .Name = "Memo2"})
            newItem2.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[False]
            Dim newItem3 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 3", New DevExpress.XtraEditors.MemoEdit() With {.Text = "Memo3", .Name = "Memo3"})
            newItem3.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[Default]
            layoutControl.BestFit()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Expand Animation")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DefaultBoolean")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AllowExpandAnimation"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(162)>
        Public Sub ExpandAnimation(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            layoutControl.OptionsView.AllowExpandAnimation = DevExpress.Utils.DefaultBoolean.[True]
            For i As Integer = 0 To 3 - 1
                Dim newGroup As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
                newGroup.ExpandButtonVisible = True
                newGroup.AddItem("Text 1 in newGroup " & i, New DevExpress.XtraEditors.TextEdit() With {.Text = "Text1" & i, .Name = "Text1" & i})
                newGroup.AddItem("Text 2 in newGroup " & i, New DevExpress.XtraEditors.TextEdit() With {.Text = "Text2" & i, .Name = "Text2" & i})
            Next

            layoutControl.AddItem(New DevExpress.XtraLayout.EmptySpaceItem())
            layoutControl.BestFit()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("HTML Text Formatting")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DefaultBoolean")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AllowHtmlStringInCaption"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(162)>
        Public Sub AllowHtmlString(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            Dim newItem1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("", New DevExpress.XtraEditors.MemoEdit() With {.Text = "Memo1", .Name = "Memo1"})
            newItem1.TextLocation = DevExpress.Utils.Locations.Top
            newItem1.Text = "<color=255, 0, 0>Memo Red</color> <u>Underline</u>"
            newItem1.AllowHtmlStringInCaption = True
            Dim addGroup As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            addGroup.Text = "<color=0, 0, 255>Layout Group</color> <b>Bold</b>"
            addGroup.AllowHtmlStringInCaption = True
            layoutControl.BestFit()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Word Wrap Text")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("LabelControl, WordWrap, LayoutType, LabelAutoSizeMode, LabelControl")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("WordWrap"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(162)>
        Public Sub WordWrapText(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            Dim STR_Laborum As String = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            layoutControl.Root.DefaultLayoutType = DevExpress.XtraLayout.Utils.LayoutType.Horizontal
            Dim labelControl1 As DevExpress.XtraEditors.LabelControl = New DevExpress.XtraEditors.LabelControl() With {.Text = STR_Laborum, .BackColor = System.Drawing.Color.LightGreen, .Name = "label1"}
            labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.Root.AddItem("", labelControl1)
            item1.TextVisible = False
            layoutControl.AddItem(New DevExpress.XtraLayout.SplitterItem())
            Dim labelControl2 As DevExpress.XtraEditors.LabelControl = New DevExpress.XtraEditors.LabelControl() With {.Text = STR_Laborum, .BackColor = System.Drawing.Color.LightSkyBlue, .Name = "label2"}
            labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Dim item2 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.Root.AddItem("", labelControl2)
            item2.TextVisible = False
            layoutControl.BestFit()
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Change layout in code", "SimpleClass.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup", "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SplitterItem", "LayoutType", "SizeType", "Size", "LayoutMode", "SizeConstraintsType")>
    Public Module ChangeLayout

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim layoutControl As DevExpress.XtraLayout.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            layoutControl.Parent = sampleHost
            Return New Object() {layoutControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraLayout.LayoutControl).Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom size constraints")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("SplitterItem", "Size")>
        Public Sub ChangeCustomSizeConstraints(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example applies size constraints to the first item 
            ' Resize the items using the splitter.
            ' The size constraints will not allow you to change the first item's height to a value beyond the range [50;200].
            layoutControl.Root.DefaultLayoutType = DevExpress.XtraLayout.Utils.LayoutType.Vertical
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo1"})
            item1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            item1.MinSize = New System.Drawing.Size(0, 50)
            item1.MaxSize = New System.Drawing.Size(0, 200)
            layoutControl.AddItem(New DevExpress.XtraLayout.SplitterItem())
            layoutControl.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo2"})
            layoutControl.BestFit()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Content alignment any control within its layout item")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("HorzAlignment", "VertAlignment"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ContentHorzAlignment", "ContentVertAlignment")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(192)>
        Public Sub ChangeContentAlignment(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' Center the control horizontally and vertically.
            Dim layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("TextEdit", New DevExpress.XtraEditors.TextEdit() With {.Name = "TextEdit"})
            layoutControlItem1.Control.MaximumSize = New System.Drawing.Size(100, 0)
            layoutControlItem1.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center
            'layoutControlItem1.ContentHorzAlignment = HorzAlignment.Far;
            layoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
        'layoutControlItem1.ContentVertAlignment = VertAlignment.Bottom;
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Content alignment of auto-sized SimpleButton")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("HorzAlignment", "VertAlignment", "SimpleButton"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ContentHorzAlignment", "ContentVertAlignment", "AutoSizeInLayoutControl")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(192)>
        Public Sub ChangeSimpleButtonContentAlignment(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' SimpleButton provides the AutoWidthInLayoutControl property, which enables the auto-sizing feature inside the Layout Control.
            ' This example shows how to custom align a SimpleButton when the auto-sizing feature is enabled.
            Dim btn As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Name = "SimpleButton", .Text = "button"}
            Dim layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Button", btn)
            btn.AutoWidthInLayoutControl = True
            layoutControlItem1.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center
            'layoutControlItem1.ContentHorzAlignment = HorzAlignment.Far;
            layoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
        'layoutControlItem1.ContentVertAlignment = VertAlignment.Bottom;
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Content alignment of auto-sized CheckEdit and RadioGroup")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("HorzAlignment", "VertAlignment", "CheckEdit", "RadioGroup", "RadioGroupItemsLayout"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ContentHorzAlignment", "ContentVertAlignment", "AutoSizeInLayoutControl")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(192)>
        Public Sub ChangeCheckEditAndRadioGroupContentAlignment(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' CheckEdit and RadioGroup provide the AutoSizeInLayoutControl property, which enables the auto-sizing feature inside the Layout Control.
            ' This example shows how to custom align these controls when the auto-sizing feature is enabled.
            Dim checkEdit1 As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit() With {.Name = "CheckEdit"}
            Dim layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Check box", checkEdit1)
            checkEdit1.AutoSizeInLayoutControl = True
            layoutControlItem1.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center
            'layoutControlItem1.ContentHorzAlignment = HorzAlignment.Far;
            Dim radioGroup1 As DevExpress.XtraEditors.RadioGroup = New DevExpress.XtraEditors.RadioGroup() With {.Name = "RadioGroup"}
            radioGroup1.Properties.Items.AddEnum(Of DevExpress.Utils.HorzAlignment)()
            Dim layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Radio Group", radioGroup1)
            layoutControlItem2.TextVisible = False
            radioGroup1.AutoSizeInLayoutControl = True
            radioGroup1.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Column
            radioGroup1.Properties.Columns = 1
            radioGroup1.MaximumSize = New System.Drawing.Size(200, 0)
            layoutControlItem2.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center
            'layoutControlItem2.ContentHorzAlignment = HorzAlignment.Far;
            layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
        'layoutControlItem2.ContentVertAlignment = VertAlignment.Bottom;     
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Text location")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("Locations", "SimpleButton", "ContentAlignment", "Font", "FontStyle")>
        Public Sub ChangeTextLocation(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example shows how to change an item's text location.
            Dim item As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo"})
            item.TextLocation = DevExpress.Utils.Locations.Right
            item.AppearanceItemCaption.Font = New System.Drawing.Font(item.AppearanceItemCaption.Font, System.Drawing.FontStyle.Bold)
            ' Optional code that creates a button allowing you to change the text location on a click.
            Dim textLocationArray As DevExpress.Utils.Locations() = New DevExpress.Utils.Locations() {DevExpress.Utils.Locations.Bottom, DevExpress.Utils.Locations.Left, DevExpress.Utils.Locations.Top, DevExpress.Utils.Locations.Right}
            Dim locationCounter As Integer = 0
            Dim btn As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Name = "Button", .Text = "Change text location"}
            Dim item2 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Button", btn)
            item2.TextVisible = False
            AddHandler btn.Click, Sub(s, e) item.TextLocation = textLocationArray((System.Math.Min(System.Threading.Interlocked.Increment(locationCounter), locationCounter - 1)) Mod 4)
            ' Center the button.
            btn.AutoWidthInLayoutControl = True
            item2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            item2.ControlAlignment = System.Drawing.ContentAlignment.TopCenter
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Auto Height Mode")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("AutoSizeMode", "AutoSize", "MemoEdit", "AutoHeightMode")>
        Public Sub AutoHeightMode(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            layoutControl.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Dim growOnlyME As DevExpress.XtraEditors.MemoEdit = New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo1", .LayoutControlAutoHeightMode = DevExpress.XtraEditors.MemoEditLayoutControlAutoHeightMode.GrowOnly, .Text = String.Join(System.Environment.NewLine, New String() {"Write some text", "to overflow height", "of the memo edit", "and it will expand", "but won't come back"})}
            Dim growAndShrinkME As DevExpress.XtraEditors.MemoEdit = New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo2", .LayoutControlAutoHeightMode = DevExpress.XtraEditors.MemoEditLayoutControlAutoHeightMode.GrowAndShrink, .Text = "This one will shrink to current content, or single line if empty some text"}
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 1", growOnlyME)
            Dim item2 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 2", growAndShrinkME)
            item2.OptionsTableLayoutItem.RowIndex = 1
            item2.OptionsTableLayoutItem.ColumnIndex = 1
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Save and restore layout")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("Locations", "SimpleButton", "ContentAlignment")>
        Public Sub ChangeSaveAndRestoreLayout(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example saves the current layout to an internal memory buffer, changes the layout and then restores the saved layout.
            ' NOTE: To correctly save and restore a layout, unique values must be assigned to the Name properties 
            ' of all layout items and controls displayed within layout items. 
            Dim item As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo"})
            item.Name = "itemMemo"
            ' Save the layout.
            layoutControl.SetDefaultLayout()
            ' Change the layout.
            item.TextLocation = DevExpress.Utils.Locations.Right
            '..
            ' Restore the saved layout.
            layoutControl.RestoreDefaultLayout()
            ' To save the layout to an XML file, stream or the system registry, use the SaveLayoutToXml, SaveLayoutToStream and SaveLayoutToRegistry methods, respectively.
            ' To restore the saved layouts, use RestoreLayoutFromXml, RestoreLayoutFromStream and RestoreLayoutFromRegistry methods
            ' Optional code that creates buttons allowing you to manually save, change and restore a layout.
            Dim buttonGroup As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            buttonGroup.Name = "buttonGroup"
            buttonGroup.Text = "Layout buttons"
            buttonGroup.DefaultLayoutType = DevExpress.XtraLayout.Utils.LayoutType.Horizontal
            Dim btnSaveLayout As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Name = "ButtonSave", .Text = "Save Layout"}
            Dim btnChangeLayout As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Name = "ButtonChange", .Text = "Change Text Location"}
            Dim btnRestoreLayout As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Name = "ButtonRestore", .Text = "Restore Layout"}
            Dim itemSaveLayout As DevExpress.XtraLayout.LayoutControlItem = buttonGroup.AddItem("Save Layout", btnSaveLayout)
            itemSaveLayout.TextVisible = False
            itemSaveLayout.Name = "itemSaveLayout"
            Dim itemChangeLayout As DevExpress.XtraLayout.LayoutControlItem = buttonGroup.AddItem("Change Layout", btnChangeLayout)
            itemChangeLayout.TextVisible = False
            itemChangeLayout.Name = "itemChangeLayout"
            Dim itemRestoreLayout As DevExpress.XtraLayout.LayoutControlItem = buttonGroup.AddItem("Restore Layout", btnRestoreLayout)
            itemRestoreLayout.TextVisible = False
            itemRestoreLayout.Name = "itemRestoreLayout"
            buttonGroup.BestFit()
            Dim locationCounter As Integer = 0
            AddHandler btnSaveLayout.Click, Sub(s, e) layoutControl.SetDefaultLayout()
            AddHandler btnChangeLayout.Click, Sub(s, e)
                Dim textLocationArray As DevExpress.Utils.Locations() = New DevExpress.Utils.Locations() {DevExpress.Utils.Locations.Bottom, DevExpress.Utils.Locations.Left, DevExpress.Utils.Locations.Top, DevExpress.Utils.Locations.Right}
                item.TextLocation = textLocationArray((System.Math.Min(System.Threading.Interlocked.Increment(locationCounter), locationCounter - 1)) Mod 4)
            End Sub
            AddHandler btnRestoreLayout.Click, Sub(s, e) layoutControl.RestoreDefaultLayout()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Swap controls")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DxImageAssemblyUtil", "SimpleButton", "PictureEdit", "ImageSize", "ImageType", "ContentAlignment", "Control")>
        Public Sub ChangeLayoutSwapControls(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example shows how to swap controls of two layout items.
            ' Click the button to perform swapping.
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo1", .Text = "Memo"})
            Dim item2 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Picture", New DevExpress.XtraEditors.PictureEdit() With {.Name = "Picture", .Image = DevExpress.Utils.DxImageAssemblyUtil.ImageProvider.GetImage("ColorMixer", DevExpress.Utils.Design.ImageSize.Size32x32, DevExpress.Utils.Design.ImageType.Colored)})
            layoutControl.BestFit()
            Dim btn As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Text = "Click Me to Swap Controls"}
            Dim itemButton As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("btnSwapControls", btn)
            itemButton.TextVisible = False
            AddHandler btn.Click, Sub(s, e)
                layoutControl.BeginUpdate()
                Dim ctrl1 As System.Windows.Forms.Control = item1.Control
                Dim ctrl2 As System.Windows.Forms.Control = item2.Control
                item1.Control = Nothing
                item2.Control = Nothing
                item1.Control = ctrl2
                item2.Control = ctrl1
                layoutControl.EndUpdate()
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Layout group border color blending")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("Color")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AllowBorderColorBlending")>
        Public Sub AllowBorderColorBlending(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            'This example showes how to highlight the group border.
            layoutControl.AddGroup()
            Dim group As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            group.AllowBorderColorBlending = True
            group.AppearanceGroup.BorderColor = System.Drawing.Color.YellowGreen
            layoutControl.BestFit()
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("LayoutControl events", "SimpleClass.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup", "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SizeType", "LayoutType", "Size", "LayoutMode", "SizeConstraintsType")>
    Public Module EventLayoutControl

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim layoutControl As DevExpress.XtraLayout.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            layoutControl.Parent = sampleHost
            Return New Object() {layoutControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraLayout.LayoutControl).Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Change group caption on expanding/collapsing")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("GroupExpandChanged")>
        Public Sub EventGroupExpandChanged(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example uses the GroupExpandChanged event to modify the group caption.
            Dim group As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            group.ExpandButtonVisible = True
            group.Text = "Group (Expanded)"
            group.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 1"})
            group.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 2"})
            group.BestFit()
            AddHandler layoutControl.GroupExpandChanged, Sub(s, e)
                If e.Group.Expanded Then
                    e.Group.Text = "Group (Expanded)"
                Else
                    e.Group.Text = "Group (Collapsed)"
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Toggle item visibility on click")>
        Public Sub EventLayoutItemClick(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example handles the LayoutItem.Click event to change a clicked item's visibility.
            Dim group As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            group.ExpandButtonVisible = True
            group.Text = "My Group"
            Dim memoLCI1 As DevExpress.XtraLayout.LayoutControlItem = group.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 1"})
            Dim memoLCI2 As DevExpress.XtraLayout.LayoutControlItem = group.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 2"})
            group.BestFit()
            AddHandler memoLCI1.Click, Sub(s, e)
                If TypeOf s Is DevExpress.XtraLayout.LayoutControlItem Then
                    Dim item As DevExpress.XtraLayout.LayoutControlItem = TryCast(s, DevExpress.XtraLayout.LayoutControlItem)
                    item.ContentVisible = Not item.ContentVisible
                End If
            End Sub
            AddHandler memoLCI2.Click, Sub(s, e)
                If TypeOf s Is DevExpress.XtraLayout.LayoutControlItem Then
                    Dim item As DevExpress.XtraLayout.LayoutControlItem = TryCast(s, DevExpress.XtraLayout.LayoutControlItem)
                    item.ContentVisible = Not item.ContentVisible
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Hyperlinks in item captions")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("HyperlinkClick"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(202)>
        Public Sub EventHyperlinkClick(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example uses HTML-inspired text formatting to add hyperlinks to item captions
            Dim memoLCI1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.Root.AddItem("<href='Memo 1'>Memo 1</href> sample", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 1"})
            memoLCI1.TextLocation = DevExpress.Utils.Locations.Top
            memoLCI1.AllowHtmlStringInCaption = True
            Dim memoLCI2 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.Root.AddItem("<href='Memo 2'>Memo 2</href> sample", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 2"})
            memoLCI2.TextLocation = DevExpress.Utils.Locations.Top
            memoLCI2.AllowHtmlStringInCaption = True
            layoutControl.Root.BestFit()
            ' The HyperlinkClick event is handled to perform actions when you click the links.
            AddHandler layoutControl.HyperlinkClick, Sub(s, e) Call DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("{0} clicked", e.Link))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Expand/collapse group from context menu")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DXMenuItem", "LayoutGroup")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("PopupMenuShowing")>
        Public Sub EventRightButtonPopupMenu(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example handles the PopupMenuShowing event to add a 'Collapse'/'Expand' command to a group's context menu.
            ' Right-click the group caption and select 'Collapse' or 'Expand'
            Dim group As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            group.Name = "My group"
            group.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 1"})
            group.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 2"})
            group.BestFit()
            AddHandler layoutControl.PopupMenuShowing, Sub(s, e)
                If e.HitInfo.Item.Parent IsNot Nothing AndAlso e.HitInfo.Item.IsGroup Then
                    Dim layoutGroup As DevExpress.XtraLayout.LayoutGroup = TryCast(e.HitInfo.Item, DevExpress.XtraLayout.LayoutGroup)
                    Dim menu As DevExpress.Utils.Menu.DXMenuItem = New DevExpress.Utils.Menu.DXMenuItem(If(group.Expanded, "Collapse", "Expand"), Sub(sender, eventArgs)
                        If TypeOf sender Is DevExpress.Utils.Menu.DXMenuItem Then
                            Dim groupToExpandCollapse As DevExpress.XtraLayout.LayoutGroup = TryCast(TryCast(sender, DevExpress.Utils.Menu.DXMenuItem).Tag, DevExpress.XtraLayout.LayoutGroup)
                            groupToExpandCollapse.Expanded = Not groupToExpandCollapse.Expanded
                        End If
                    End Sub)
                    menu.Tag = e.HitInfo.Item
                    e.Menu.Items.Add(menu)
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Expand/collapse group from Tree View's context menu")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DXMenuItem", "LayoutGroup")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("LayoutTreeViewPopupMenuShowing")>
        Public Sub EventLayoutTreeViewPopupMenuShowing(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example handles the LayoutTreeViewPopupMenuShowing event to add a 'Collapse'/'Expand' command to the context menu
            ' for groups in the 'Layout Tree View' tab in the Customization Form.
            Dim group As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            group.Name = "My Group"
            group.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 1"})
            group.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 2"})
            group.BestFit()
            AddHandler layoutControl.LayoutTreeViewPopupMenuShowing, Sub(s, e)
                If e.HitInfo.Item.Parent IsNot Nothing AndAlso e.HitInfo.Item.IsGroup Then
                    Dim layoutGroup As DevExpress.XtraLayout.LayoutGroup = TryCast(e.HitInfo.Item, DevExpress.XtraLayout.LayoutGroup)
                    Dim menu As DevExpress.Utils.Menu.DXMenuItem = New DevExpress.Utils.Menu.DXMenuItem(If(group.Expanded, "Collapse", "Expand"), Sub(sender, eventArgs)
                        If TypeOf sender Is DevExpress.Utils.Menu.DXMenuItem Then
                            Dim groupToExpandCollapse As DevExpress.XtraLayout.LayoutGroup = TryCast(TryCast(sender, DevExpress.Utils.Menu.DXMenuItem).Tag, DevExpress.XtraLayout.LayoutGroup)
                            groupToExpandCollapse.Expanded = Not groupToExpandCollapse.Expanded
                        End If
                    End Sub)
                    menu.Tag = e.HitInfo.Item
                    e.Menu.Items.Add(menu)
                End If
            End Sub
            layoutControl.ShowCustomizationForm()
            group.Selected = True
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Drag items only within their parent groups")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("EmptySpaceItem", "InsertType", "ILayoutControl")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ItemDragging")>
        Public Sub EventItemDragging(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            'This example handles the ItemDragging event to prevent items from being moved between groups.
            Dim group1 As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            group1.AddItem(New DevExpress.XtraLayout.EmptySpaceItem())
            group1.AddItem(New DevExpress.XtraLayout.EmptySpaceItem())
            Dim group2 As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup(group1, DevExpress.XtraLayout.Utils.InsertType.Right)
            group2.AddItem(New DevExpress.XtraLayout.EmptySpaceItem())
            group2.AddItem(New DevExpress.XtraLayout.EmptySpaceItem())
            layoutControl.BestFit()
            AddHandler layoutControl.ItemDragging, Sub(s, e)
                If e.DragController Is Nothing Then Return
                If e.DragController.DragItem Is Nothing OrElse e.DragController.Item Is Nothing Then Return
                If Not e.DragController.DragItem.Parent.Equals(e.DragController.Item.Parent) Then
                    e.AllowDrop = False
                End If
            End Sub
            CType(layoutControl, DevExpress.XtraLayout.ILayoutControl).EnableCustomizationMode = True
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom draw items")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("EmptySpaceItem", "Color", "SolidBrush", "MemoEdit")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDraw"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(162)>
        Public Sub CustomDraw(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            Dim group As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            Dim item As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Text = "Memo1", .Name = "Memo1"})
            Dim addTabbedGroup As DevExpress.XtraLayout.TabbedControlGroup = layoutControl.AddTabbedGroup()
            addTabbedGroup.AddTabPage()
            addTabbedGroup.AddTabPage()
            layoutControl.BestFit()
            'Custom draw LayoutControlGroup
            AddHandler group.CustomDraw, Sub(s, e)
                e.DefaultDraw()
                e.Graphics.FillRectangle(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(50, 0, 255, 0)), e.Bounds)
                e.Handled = True
            End Sub
            'Custom draw LayoutControlItem
            AddHandler item.CustomDraw, Sub(s, e)
                e.DefaultDraw()
                e.Graphics.FillRectangle(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(50, 255, 0, 0)), e.Bounds)
                e.Handled = True
            End Sub
            'Custom draw TabbedControlGroup
            AddHandler addTabbedGroup.CustomDraw, Sub(s, e)
                e.DefaultDraw()
                e.Graphics.FillRectangle(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 255)), e.Bounds)
                e.Handled = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomHeaderButtons In Group")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("EmptySpaceItem", "GroupBoxButton", "ButtonStyle", "MessageBox")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomButtonClick", "CustomButtonChecked", "CustomButtonUnchecked"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(162)>
        Public Sub CustomHeaderButtonsInGroup(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            Dim group As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            group.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            group.CustomHeaderButtons.Add(New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Push Button", "Find;Size16x16;Office2013", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, -1))
            group.CustomHeaderButtons.Add(New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Check Button", "Apply;Size16x16;Office2013", DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, -1))
            AddHandler group.CustomButtonClick, Sub(s, e) DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("{0} click", e.Button.Properties.Caption))
            AddHandler group.CustomButtonChecked, Sub(s, e) DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("{0} checked", e.Button.Properties.Caption))
            AddHandler group.CustomButtonUnchecked, Sub(s, e) DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("{0} Unchecked", e.Button.Properties.Caption))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomHeaderButtons In Tabbed Group")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("TabbedControlGroup", "CustomHeaderButton", "ButtonPredefines", "MessageBox", "Enum")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomHeaderButtonClick"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(162)>
        Public Sub CustomHeaderButtonsInTabbedGroup(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            Dim tGroup As DevExpress.XtraLayout.TabbedControlGroup = layoutControl.AddTabbedGroup()
            tGroup.AddTabPage()
            tGroup.AddTabPage()
            tGroup.CustomHeaderButtons.Add(New DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK))
            tGroup.CustomHeaderButtons.Add(New DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search))
            tGroup.CustomHeaderButtons.Add(New DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete))
            AddHandler tGroup.CustomHeaderButtonClick, Sub(s, e) DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("{0} click", System.[Enum].GetName(e.Button.Kind.[GetType](), e.Button.Kind)))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Flow layout", "SimpleClass.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup", "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SizeType", "LayoutType", "Size", "LayoutMode", "SizeConstraintsType")>
    Public Module FlowLayoutControl

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim layoutControl As DevExpress.XtraLayout.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            layoutControl.Parent = sampleHost
            Return New Object() {layoutControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraLayout.LayoutControl).Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Simple flow layout")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("Size")>
        Public Sub FlowSimpleLayout(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example creates a flow layout consisting of a few Memo editors.
            ' Resize the window to see the flow layout in action.
            Dim group As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            For i As Integer = 1 To 7
                Dim caption As String = "Memo " & i
                group.AddItem(caption, New DevExpress.XtraEditors.MemoEdit() With {.Name = caption})
            Next

            group.BestFit()
            group.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Flow
            For Each item As DevExpress.XtraLayout.LayoutControlItem In group.Items
                item.Size = New System.Drawing.Size(150, 80)
            Next
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Wrap the flow")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("Size")>
        Public Sub FlowWrap(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example creates a flow layout and forcibly wraps the flow after the 2nd item.
            Dim group As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            For i As Integer = 1 To 7
                Dim caption As String = "Memo " & i
                group.AddItem(caption, New DevExpress.XtraEditors.MemoEdit() With {.Name = caption})
            Next

            group.BestFit()
            group.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Flow
            For Each item As DevExpress.XtraLayout.LayoutControlItem In group.Items
                item.Size = New System.Drawing.Size(150, 80)
            Next

            group(CInt((2))).StartNewLine = True
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Change FlowDirection")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("Size", "ILayoutControl", "FlowDirection"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(162)>
        Public Sub FlowChangeFlowDirection(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            Dim group As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            group.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 1"})
            group.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 2"})
            group.AddItem("Memo 3", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 3"})
            group.AddItem("Memo 4", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 4"})
            group.BestFit()
            group.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Flow
            For Each item As DevExpress.XtraLayout.LayoutControlItem In group.Items
                item.Size = New System.Drawing.Size(200, 100)
            Next

            group.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
            'group.FlowDirection = FlowDirection.LeftToRight;
            'group.FlowDirection = FlowDirection.RightToLeft;
            'group.FlowDirection = FlowDirection.TopDown;
            ' Enable customization mode to see FlowDirection
            CType(layoutControl, DevExpress.XtraLayout.ILayoutControl).EnableCustomizationMode = True
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Rearrange items")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("Size", "InsertType")>
        Public Sub FlowRearrangeItems(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example shows how to use the Move method to place an item next to another item.
            Dim group As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            group.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 1"})
            group.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 2"})
            group.AddItem("Memo 3", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 3"})
            group.AddItem("Memo 4", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo 4"})
            group.BestFit()
            group.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Flow
            For Each item As DevExpress.XtraLayout.LayoutControlItem In group.Items
                item.Size = New System.Drawing.Size(200, 100)
            Next

            group(CInt((0))).Move(group(3), DevExpress.XtraLayout.Utils.InsertType.Right)
            group(CInt((2))).Move(group(1), DevExpress.XtraLayout.Utils.InsertType.Left)
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Advanced examples", "SimpleClass.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup", "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SizeType", "LayoutType", "Size", "LayoutMode", "SizeConstraintsType")>
    Public Module AdvancedExamplesLayoutControl

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim layoutControl As DevExpress.XtraLayout.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            layoutControl.Parent = sampleHost
            Return New Object() {layoutControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraLayout.LayoutControl).Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create custom 'fixed' item in Customization Form", New System.Type() {GetType(Examples.AdvancedExamplesLayoutControl.MyFixedLabelItem), GetType(Examples.AdvancedExamplesLayoutControl.MyFixedLabelPropertiesWrapper)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("Control", "MyFixedLabelItem", "LinkLabelLinkClickedEventArgs", "BasePropertyGridObjectWrapper", "IFixedLayoutControlItem", "ILayoutControl", "Image")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("LinkClicked")>
        Public Sub AdvExamplesCustomFixedItem(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example adds a custom link item to the Customization Form.
            ' You can add this item to the form using drag-and-drop, and change the link text in the Properties grid.
            layoutControl.OptionsCustomizationForm.ShowPropertyGrid = True
            layoutControl.RegisterCustomPropertyGridWrapper(GetType(Examples.AdvancedExamplesLayoutControl.MyFixedLabelItem), GetType(Examples.AdvancedExamplesLayoutControl.MyFixedLabelPropertiesWrapper))
            layoutControl.RegisterFixedItemType(GetType(Examples.AdvancedExamplesLayoutControl.MyFixedLabelItem))
            layoutControl.ShowCustomizationForm()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("The custom 'fixed' item")>
        Public Class MyFixedLabelItem
            Inherits DevExpress.XtraLayout.LayoutControlItem
            Implements DevExpress.XtraLayout.IFixedLayoutControlItem

            ' Must return the name of the item's type
            Public Overrides ReadOnly Property TypeName As String Implements Global.DevExpress.XtraLayout.IFixedLayoutControlItem.TypeName
                Get
                    Return "MyFixedLabelItem"
                End Get
            End Property

            Private linkCore As String

            Private controlCore As System.Windows.Forms.Control = Nothing

            <System.ComponentModel.DefaultValueAttribute("")>
            Public Property Link As String
                Get
                    Return Me.linkCore
                End Get

                Set(ByVal value As String)
                    If Equals(Me.Link, value) Then Return
                    Me.linkCore = value
                    Me.OnLinkChanged()
                End Set
            End Property

            Private Sub label_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
            '...
            End Sub

            <System.ComponentModel.DefaultValueAttribute("")>
            Public Overrides Property Text As String
                Get
                    Return Me.Link
                End Get

                Set(ByVal value As String)
                    Me.Link = value
                End Set
            End Property

            ' This method is called when the Link property is changed.
            ' It assigns the new link to the embedded LinkLabel control.
            Protected Sub OnLinkChanged()
                Me.controlCore.Text = Me.Link
            End Sub

            ' Initialize the item.
            Private Sub OnInitialize() Implements Global.DevExpress.XtraLayout.IFixedLayoutControlItem.OnInitialize
                Me.linkCore = "www.devexpress.com"
                Me.OnLinkChanged()
                Me.TextVisible = False
            End Sub

            ' Create and return the item's control.
            Private Function OnCreateControl() As Control Implements Global.DevExpress.XtraLayout.IFixedLayoutControlItem.OnCreateControl
                Me.controlCore = New System.Windows.Forms.LinkLabel()
                AddHandler CType(Me.controlCore, System.Windows.Forms.LinkLabel).LinkClicked, AddressOf Me.label_LinkClicked
                Return Me.controlCore
            End Function

            ' Destroy the item's control.
            Private Sub OnDestroy() Implements Global.DevExpress.XtraLayout.IFixedLayoutControlItem.OnDestroy
                If Me.controlCore IsNot Nothing Then
                    RemoveHandler CType(Me.controlCore, System.Windows.Forms.LinkLabel).LinkClicked, AddressOf Me.label_LinkClicked
                    Me.controlCore.Dispose()
                    Me.controlCore = Nothing
                End If
            End Sub

            Private ReadOnly Property CustomizationName As String Implements Global.DevExpress.XtraLayout.IFixedLayoutControlItem.CustomizationName
                Get
                    Return "DevExpress Link"
                End Get
            End Property

            Private ReadOnly Property CustomizationImage As Image Implements Global.DevExpress.XtraLayout.IFixedLayoutControlItem.CustomizationImage
                Get
                    Return Nothing
                End Get
            End Property

            Private ReadOnly Property AllowChangeTextLocation As Boolean Implements Global.DevExpress.XtraLayout.IFixedLayoutControlItem.AllowChangeTextLocation
                Get
                    Return False
                End Get
            End Property

            Private ReadOnly Property AllowChangeTextVisibility As Boolean Implements Global.DevExpress.XtraLayout.IFixedLayoutControlItem.AllowChangeTextVisibility
                Get
                    Return False
                End Get
            End Property

            Private ReadOnly Property AllowClipText As Boolean Implements Global.DevExpress.XtraLayout.IFixedLayoutControlItem.AllowClipText
                Get
                    Return False
                End Get
            End Property

            Private Property IFixedLayoutControlItem_Owner As ILayoutControl Implements Global.DevExpress.XtraLayout.IFixedLayoutControlItem.Owner
                Get
                    Return Me.Owner
                End Get

                Set(ByVal value As ILayoutControl)
                    Me.Owner = value
                End Set
            End Property
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("Specifies which properties to display in the Property Grid")>
        Public Class MyFixedLabelPropertiesWrapper
            Inherits DevExpress.XtraLayout.BasePropertyGridObjectWrapper

            Protected ReadOnly Property Label As MyFixedLabelItem
                Get
                    Return TryCast(Me.WrappedObject, Examples.AdvancedExamplesLayoutControl.MyFixedLabelItem)
                End Get
            End Property

            <System.ComponentModel.DescriptionAttribute("The link's text")>
            Public Property Link As String
                Get
                    Return Me.Label.Link
                End Get

                Set(ByVal value As String)
                    Me.Label.Link = value
                End Set
            End Property

            Public Overrides Function Clone() As BasePropertyGridObjectWrapper
                Return New Examples.AdvancedExamplesLayoutControl.MyFixedLabelPropertiesWrapper()
            End Function
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Provide custom Customization Form and override button actions", New System.Type() {GetType(Examples.AdvancedExamplesLayoutControl.MyCustomizationForm)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("MyCustomizationForm", "MyButtonsPanel", "ButtonsPanel", "MessageBox", "CustomizationForm", "EventArgs")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RegisterUserCustomizationForm"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(162)>
        Public Sub AdvExamplesCustomCustomizationForm(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example replaces the standard Customization Form with a custom one.
            ' Actions for the Customization Form's buttons are overridden to display message boxes.
            layoutControl.OptionsCustomizationForm.ShowPropertyGrid = True
            layoutControl.RegisterUserCustomizationForm(GetType(Examples.AdvancedExamplesLayoutControl.MyCustomizationForm))
            layoutControl.ShowCustomizationForm()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class MyCustomizationForm
            Inherits DevExpress.XtraLayout.Customization.CustomizationForm

            Protected Overrides Sub OnSaveLayoutButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
                DevExpress.XtraEditors.XtraMessageBox.Show("'Save Layout' button click")
                MyBase.OnSaveLayoutButtonClick(sender, e)
            End Sub

            Protected Overrides Sub OnLoadLayoutButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
                DevExpress.XtraEditors.XtraMessageBox.Show("'Load Layout' button click")
                MyBase.OnLoadLayoutButtonClick(sender, e)
            End Sub

            Protected Overrides Sub OnRedoButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
                DevExpress.XtraEditors.XtraMessageBox.Show("'Redo' button click")
                MyBase.OnRedoButtonClick(sender, e)
            End Sub

            Protected Overrides Sub OnUndoButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
                DevExpress.XtraEditors.XtraMessageBox.Show("'Undo' button click")
                MyBase.OnUndoButtonClick(sender, e)
            End Sub
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Display custom properties for items in Customization Form", New System.Type() {GetType(Examples.AdvancedExamplesLayoutControl.MyLayoutControlItemPropertyWrapper)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("LayoutControlItemWrapper", "MyLayoutControlItemPropertyWrapper", "AutoCompleteType", "Category", "DefaultValue", "MaskType", "BasePropertyGridObjectWrapper")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RegisterCustomPropertyGridWrapper")>
        Public Sub AdvExamplesCustomPropertiesInCustomizationForm(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example shows how to extend properties displayed in the Customization Form's Property Grid when an item is selected.
            ' A few mask-specific settings are added to the 'Mask' category.
            layoutControl.OptionsCustomizationForm.ShowPropertyGrid = True
            Dim textEdit1 As DevExpress.XtraEditors.TextEdit = New DevExpress.XtraEditors.TextEdit() With {.Name = "TextEdit"}
            Dim item As DevExpress.XtraLayout.LayoutControlItem = layoutControl.Root.AddItem("Text Edit", textEdit1)
            layoutControl.RegisterCustomPropertyGridWrapper(GetType(DevExpress.XtraLayout.LayoutControlItem), GetType(Examples.AdvancedExamplesLayoutControl.MyLayoutControlItemPropertyWrapper))
            layoutControl.ShowCustomizationForm()
            ' Select the created item.
            item.Selected = True
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class MyLayoutControlItemPropertyWrapper
            Inherits DevExpress.XtraLayout.LayoutControlItemWrapper

            Protected ReadOnly Property Editor As TextEdit
                Get
                    Return TryCast(Me.Item.Control, DevExpress.XtraEditors.TextEdit)
                End Get
            End Property

            <System.ComponentModel.CategoryAttribute("Mask")>
            <System.ComponentModel.DefaultValueAttribute(DevExpress.XtraEditors.Mask.AutoCompleteType.[Default])>
            Public Property AutoComplete As AutoCompleteType
                Get
                    If Me.Editor IsNot Nothing Then
                        Return Me.Editor.Properties.Mask.AutoComplete
                    Else
                        Return DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
                    End If
                End Get

                Set(ByVal value As AutoCompleteType)
                    If Me.Editor IsNot Nothing Then Me.Editor.Properties.Mask.AutoComplete = value
                End Set
            End Property

            <System.ComponentModel.CategoryAttribute("Mask")>
            <System.ComponentModel.DefaultValueAttribute(False)>
            Public Property BeepOnError As Boolean
                Get
                    If Me.Editor IsNot Nothing Then
                        Return Me.Editor.Properties.Mask.BeepOnError
                    Else
                        Return False
                    End If
                End Get

                Set(ByVal value As Boolean)
                    If Me.Editor IsNot Nothing Then Me.Editor.Properties.Mask.BeepOnError = value
                End Set
            End Property

            <System.ComponentModel.CategoryAttribute("Mask")>
            <System.ComponentModel.DefaultValueAttribute("")>
            Public Property EditMask As String
                Get
                    If Me.Editor IsNot Nothing Then
                        Return Me.Editor.Properties.Mask.EditMask
                    Else
                        Return String.Empty
                    End If
                End Get

                Set(ByVal value As String)
                    If Me.Editor IsNot Nothing Then Me.Editor.Properties.Mask.EditMask = value
                End Set
            End Property

            <System.ComponentModel.CategoryAttribute("Mask")>
            <System.ComponentModel.DefaultValueAttribute(True)>
            Public Property IgnoreMaskBlank As Boolean
                Get
                    If Me.Editor IsNot Nothing Then
                        Return Me.Editor.Properties.Mask.IgnoreMaskBlank
                    Else
                        Return True
                    End If
                End Get

                Set(ByVal value As Boolean)
                    If Me.Editor IsNot Nothing Then Me.Editor.Properties.Mask.IgnoreMaskBlank = True
                End Set
            End Property

            <System.ComponentModel.CategoryAttribute("Mask")>
            <System.ComponentModel.DefaultValueAttribute(DevExpress.XtraEditors.Mask.MaskType.None)>
            Public Property MaskType As MaskType
                Get
                    If Me.Editor IsNot Nothing Then
                        Return Me.Editor.Properties.Mask.MaskType
                    Else
                        Return DevExpress.XtraEditors.Mask.MaskType.None
                    End If
                End Get

                Set(ByVal value As MaskType)
                    If Me.Editor IsNot Nothing Then Me.Editor.Properties.Mask.MaskType = value
                End Set
            End Property

            <System.ComponentModel.CategoryAttribute("Mask")>
            <System.ComponentModel.DefaultValueAttribute(Global.Microsoft.VisualBasic.Strings.ChrW(0))>
            Public Property PlaceHolder As Char
                Get
                    If Me.Editor IsNot Nothing Then
                        Return Me.Editor.Properties.Mask.PlaceHolder
                    Else
                        Return Global.Microsoft.VisualBasic.Strings.ChrW(0)
                    End If
                End Get

                Set(ByVal value As Char)
                    If Me.Editor IsNot Nothing Then Me.Editor.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.Strings.ChrW(0)
                End Set
            End Property

            <System.ComponentModel.CategoryAttribute("Mask")>
            <System.ComponentModel.DefaultValueAttribute(True)>
            Public Property SaveLiteral As Boolean
                Get
                    If Me.Editor IsNot Nothing Then
                        Return Me.Editor.Properties.Mask.SaveLiteral
                    Else
                        Return True
                    End If
                End Get

                Set(ByVal value As Boolean)
                    If Me.Editor IsNot Nothing Then Me.Editor.Properties.Mask.SaveLiteral = value
                End Set
            End Property

            <System.ComponentModel.CategoryAttribute("Mask")>
            <System.ComponentModel.DefaultValueAttribute(True)>
            Public Property ShowPlaceHolders As Boolean
                Get
                    If Me.Editor IsNot Nothing Then
                        Return Me.Editor.Properties.Mask.ShowPlaceHolders
                    Else
                        Return True
                    End If
                End Get

                Set(ByVal value As Boolean)
                    If Me.Editor IsNot Nothing Then Me.Editor.Properties.Mask.ShowPlaceHolders = value
                End Set
            End Property

            <System.ComponentModel.CategoryAttribute("Mask")>
            <System.ComponentModel.DefaultValueAttribute(False)>
            Public Property UseMaskAsDisplayFormat As Boolean
                Get
                    If Me.Editor IsNot Nothing Then
                        Return Me.Editor.Properties.Mask.UseMaskAsDisplayFormat
                    Else
                        Return False
                    End If
                End Get

                Set(ByVal value As Boolean)
                    If Me.Editor IsNot Nothing Then Me.Editor.Properties.Mask.UseMaskAsDisplayFormat = value
                End Set
            End Property

            Public Overrides Function Clone() As BasePropertyGridObjectWrapper
                Return New Examples.AdvancedExamplesLayoutControl.MyLayoutControlItemPropertyWrapper()
            End Function
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom paint group captions", New System.Type() {GetType(Examples.AdvancedExamplesLayoutControl.MyLayoutControl), GetType(Examples.AdvancedExamplesLayoutControl.MyLayoutControlImplementor), GetType(Examples.AdvancedExamplesLayoutControl.MySkinGroupObjectPainter), GetType(Examples.AdvancedExamplesLayoutControl.MyLayoutSkinPaintStyle)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("MyLayoutControl", "MyLayoutControlImplementor", "MySkinGroupObjectPainter", "MyLayoutSkinPaintStyle", "LayoutControl", "ILayoutControlOwner", "DockStyle", "Color", "GroupObjectInfoArgs", "LayoutOffice2003PaintStyle", "ISupportLookAndFeel", "LayoutWindowsXPPaintStyle", "Style3DPaintStyle", "UltraFlatPaintStyle", "FlatPaintStyle", "GroupObjectPainter", "LayoutControlImplementor", "IPanelControlOwner", "ISkinProvider", "SkinGroupObjectPainter", "LayoutSkinPaintStyle")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RegisterCustomPropertyGridWrapper")>
        Public Sub AdvExamplesCustomPaintGroupCaptions(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example creates a LayoutControl descendant to override the group caption painting method.
            Dim sampleHost As DevExpress.XtraEditors.XtraUserControl = TryCast(layoutControl.Parent, DevExpress.XtraEditors.XtraUserControl)
            sampleHost.Controls.Clear()
            Dim myLayoutControl1 As Examples.AdvancedExamplesLayoutControl.MyLayoutControl = New Examples.AdvancedExamplesLayoutControl.MyLayoutControl()
            myLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            sampleHost.Controls.Add(myLayoutControl1)
            myLayoutControl1.Root.AddGroup("Group 1")
            myLayoutControl1.Root.AddGroup("Group 2")
            myLayoutControl1.BestFit()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class MySkinGroupObjectPainter
            Inherits DevExpress.Utils.Drawing.SkinGroupObjectPainter

            Public Sub New(ByVal owner As DevExpress.Utils.Drawing.IPanelControlOwner, ByVal provider As DevExpress.Skins.ISkinProvider)
                MyBase.New(owner, provider)
            End Sub

            Protected Overrides Sub DrawCaption(ByVal info As DevExpress.Utils.Drawing.GroupObjectInfoArgs)
                If info.CaptionBounds.IsEmpty Then Return
                info.Cache.FillRectangle(info.Cache.GetSolidBrush(System.Drawing.Color.PowderBlue), info.CaptionBounds)
                Me.DrawButton(info)
                Me.DrawVString(info.Cache, info.AppearanceCaption, info.Caption, info.TextBounds, Me.GetRotateAngle(info))
            End Sub
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class MyLayoutControlImplementor
            Inherits DevExpress.XtraLayout.LayoutControlImplementor

            Public Sub New(ByVal owner As DevExpress.XtraLayout.ILayoutControlOwner)
                MyBase.New(owner)
            End Sub

            Protected Overrides Sub InitializePaintStyles()
                Dim lookAndFeelOwner As DevExpress.LookAndFeel.ISupportLookAndFeel = Me.owner.GetISupportLookAndFeel()
                If lookAndFeelOwner IsNot Nothing Then
                    Me.PaintStyles.Add(New DevExpress.XtraLayout.Registrator.LayoutOffice2003PaintStyle(lookAndFeelOwner))
                    Me.PaintStyles.Add(New DevExpress.XtraLayout.Registrator.LayoutWindowsXPPaintStyle(lookAndFeelOwner))
                    '
                    ' TODO: Add your owner PaintStyle instead of PaintStyles.Add(new LayoutSkinPaintStyle(lookAndFeelOwner));
                    '
                    Me.PaintStyles.Add(New Examples.AdvancedExamplesLayoutControl.MyLayoutSkinPaintStyle(lookAndFeelOwner))
                    Me.PaintStyles.Add(New DevExpress.XtraLayout.Registrator.Style3DPaintStyle(lookAndFeelOwner))
                    Me.PaintStyles.Add(New DevExpress.XtraLayout.Registrator.UltraFlatPaintStyle(lookAndFeelOwner))
                    Me.PaintStyles.Add(New DevExpress.XtraLayout.Registrator.FlatPaintStyle(lookAndFeelOwner))
                End If

                lookAndFeelOwner = Nothing
            End Sub
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class MyLayoutSkinPaintStyle
            Inherits DevExpress.XtraLayout.Registrator.LayoutSkinPaintStyle

            Public Sub New(ByVal lookAndFeelOwner As DevExpress.LookAndFeel.ISupportLookAndFeel)
                MyBase.New(lookAndFeelOwner)
            End Sub

            Public Overrides Function CreateGroupPainter(ByVal owner As DevExpress.Utils.Drawing.IPanelControlOwner) As GroupObjectPainter
                Return New Examples.AdvancedExamplesLayoutControl.MySkinGroupObjectPainter(owner, Me.LookAndFeel)
            End Function
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class MyLayoutControl
            Inherits DevExpress.XtraLayout.LayoutControl

            Protected Overrides Function CreateILayoutControlImplementorCore() As LayoutControlImplementor
                Return New Examples.AdvancedExamplesLayoutControl.MyLayoutControlImplementor(Me)
            End Function
        End Class
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("DataLayoutControl", "SimpleClass.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup", "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SizeType", "LayoutType", "Size", "LayoutMode", "SizeConstraintsType")>
    Public Module DataLayoutControlExample

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim dataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
            dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            dataLayoutControl.Parent = sampleHost
            Return New Object() {dataLayoutControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraLayout.LayoutControl).Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class MyClassWithAttributes

            Public Enum GenderEnum
                Male
                Female
            End Enum

            'Do not generate a layout item (editor) for the ID field.
            <System.ComponentModel.DataAnnotations.DisplayAttribute(AutoGenerateField:=False)>
            Public Property ID As Integer

            ' Specify the display format for the Age field.
            <System.ComponentModel.DataAnnotations.DisplayFormatAttribute(DataFormatString:="d2", ApplyFormatInEditMode:=True)>
            Public Property Age As Integer

            ' Disable editing.
            <System.ComponentModel.DataAnnotations.EditableAttribute(False)>
            Public Property Employer As String

            ' Override the display name, specify the order and mark the field as required.
            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="First name", Order:=0), System.ComponentModel.DataAnnotations.RequiredAttribute>
            Public Property FirstName As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Full name", Order:=2)>
            Public ReadOnly Property FullName As String
                Get
                    Return Me.FirstName & " " & Me.LastName
                End Get
            End Property

            <System.ComponentModel.DataAnnotations.DisplayAttribute(ShortName:="Sex", Order:=3)>
            Public Property Gender As GenderEnum

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Last name", Order:=1), System.ComponentModel.DataAnnotations.RequiredAttribute>
            Public Property LastName As String

            ' The editor will be read-only.
            <System.ComponentModel.ReadOnlyAttribute(True)>
            Public Property SSN As String

            ' Specify the text displayed when the editor's value is null.
            <System.ComponentModel.DataAnnotations.DisplayFormatAttribute(NullDisplayText:="Department not set")>
            Public Property Department As String
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Simple attributes: names, visibility, order, display format, etc.", New System.Type() {GetType(Examples.DataLayoutControlExample.MyClassWithAttributes)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DisplayFormat", "MyClassWithAttributes", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RetrieveFields")>
        Public Sub DataAnnotationSimpleAttributesExample(ByVal dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl)
            ' In this example, the DataLayoutControl automatically builds a layout for editing a MyClassWithAttributes object
            ' taking into account the DataAnnotations attributes applied to the object's properties
            Dim source As System.Windows.Forms.BindingSource = New System.Windows.Forms.BindingSource()
            source.DataSource = New Examples.DataLayoutControlExample.MyClassWithAttributes()
            dataLayoutControl1.DataSource = source
            dataLayoutControl1.RetrieveFields()
            dataLayoutControl1.BestFit()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass()>
        Public Class MyClassWithDataTypeAttributes

            Public Enum GenderEnum
                Male
                Female
            End Enum

            Public Property BoolProperty As Boolean

            Public Property EnumProperty As GenderEnum

            Public Property StringProperty As String

            Public Property DateTimeProperty As DateTime

            <System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.Currency)>
            Public Property CurrencyProperty As Decimal

            <System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.MultilineText)>
            Public Property MultilineTextProperty As String

            <System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.Password)>
            Public Property PasswordProperty As String

            <System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.PhoneNumber)>
            Public Property PhoneNumberProperty As String
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Specify editors and their settings", New System.Type() {GetType(Examples.DataLayoutControlExample.MyClassWithDataTypeAttributes)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("MyClassWithDataTypeAttributes", "BindingSource", "GenderEnum", "DataType", "DateTime", "ReadOnlyAttribute", "Editable")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RetrieveFields")>
        Public Sub DataAnnotationDataTypeAttributeExample(ByVal dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl)
            ' In this example, the DataLayoutControl automatically builds a layout for editing a MyClassWithDataTypeAttributes object
            ' taking into account the DataAnnotation.DataType attributes applied to the object's properties.
            Dim source As System.Windows.Forms.BindingSource = New System.Windows.Forms.BindingSource()
            source.DataSource = New Examples.DataLayoutControlExample.MyClassWithDataTypeAttributes()
            dataLayoutControl1.DataSource = source
            dataLayoutControl1.RetrieveFields()
            dataLayoutControl1.BestFit()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class MyClassSimpleGroupedLayout

            Const JobGroup As String = "Job"

            Const ContactGroup As String = "Contact"

            Const AddressGroup As String = "Address"

            Const PersonalGroup As String = "Personal"

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.MyClassSimpleGroupedLayout.AddressGroup, ShortName:="", Order:=4)>
            Public Property AddressLine1 As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.MyClassSimpleGroupedLayout.AddressGroup, ShortName:="")>
            Public Property AddressLine2 As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.MyClassSimpleGroupedLayout.PersonalGroup, Name:="Birth date")>
            Public Property BirthDate As DateTime

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.MyClassSimpleGroupedLayout.ContactGroup)>
            Public Property Email As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="First name", Order:=0)>
            Public Property FirstName As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.MyClassSimpleGroupedLayout.PersonalGroup, Order:=5)>
            Public Property Gender As GenderEnum

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.MyClassSimpleGroupedLayout.JobGroup, Order:=2)>
            Public Property Group As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.MyClassSimpleGroupedLayout.JobGroup, Name:="Hire date")>
            Public Property HireDate As DateTime

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Last name", Order:=1)>
            Public Property LastName As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.MyClassSimpleGroupedLayout.ContactGroup, Order:=3), System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.PhoneNumber)>
            Public Property Phone As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.MyClassSimpleGroupedLayout.JobGroup), System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.Currency)>
            Public Property Salary As Decimal

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.MyClassSimpleGroupedLayout.JobGroup, Order:=21)>
            Public Property Title As String

            Public Enum GenderEnum
                Male
                Female
            End Enum
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Grouping and order", New System.Type() {GetType(Examples.DataLayoutControlExample.MyClassSimpleGroupedLayout)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("MyClassSimpleGroupedLayout", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RetrieveFields")>
        Public Sub DataAnnotationSimpleGroupingExample(ByVal dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl)
            ' In this example, the DataLayoutControl automatically builds a layout for editing a MyClassSimpleGroupedLayout object.
            ' A layout item with an editor is generated for each property of the MyClassSimpleGroupedLayout object.
            ' The layout items are placed into regular groups according to the DataAnnotation.Display attributes applied to the properties.
            Dim source As System.Windows.Forms.BindingSource = New System.Windows.Forms.BindingSource()
            source.DataSource = New Examples.DataLayoutControlExample.MyClassSimpleGroupedLayout()
            dataLayoutControl1.DataSource = source
            dataLayoutControl1.RetrieveFields()
            dataLayoutControl1.BestFit()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class MyClassTabsLayout

            ' The two items below will be displayed by DataLayoutControl  
            ' in a borderless Name group with no title. 
            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:="<Name|>", Name:="Last name")>
            Public Property LastName As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:="<Name|>", Name:="First name", Order:=0)>
            Public Property FirstName As String

            'The four items below will go to a Contact tab within tabbed Tabs group. 
            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:="{Tabs}/Contact", Order:=2), System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.PhoneNumber)>
            Public Property Phone As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:="{Tabs}/Contact", Order:=4), System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.EmailAddress)>
            Public Property Email As String

            'The two items below will go to the Address group within the Contact tab. 
            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:="{Tabs}/Contact/Address", ShortName:="")>
            Public Property AddressLine1 As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:="{Tabs}/Contact/Address", ShortName:="")>
            Public Property AddressLine2 As String

            'The two items below will go to horizontally oriented Personal group. 
            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:="Personal-", Name:="Birth date")>
            Public Property BirthDate As DateTime

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:="Personal-", Order:=3)>
            Public Property Gender As GenderEnum

            'The four items below will go to the Job tab of the tabbed Tabs group 
            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:="{Tabs}/Job", Order:=6)>
            Public Property Group As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:="{Tabs}/Job", Name:="Hire date")>
            Public Property HireDate As DateTime

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:="{Tabs}/Job"), System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.Currency)>
            Public Property Salary As Decimal

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:="{Tabs}/Job", Order:=7)>
            Public Property Title As String

            Public Enum GenderEnum
                Male
                Female
            End Enum
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Advanced grouping", New System.Type() {GetType(Examples.DataLayoutControlExample.MyClassTabsLayout)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("MyClassTabsLayout", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RetrieveFields")>
        Public Sub DataAnnotationAdvGroupingExample(ByVal dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl)
            ' In this example, the DataLayoutControl automatically builds a layout for editing a MyClassTabsLayout object.
            ' A layout item with an editor is generated for each property of the MyClassTabsLayout object.
            ' The layout items are placed into regular and tabbed groups according to the DataAnnotation.Display attributes applied to the properties.
            Dim source As System.Windows.Forms.BindingSource = New System.Windows.Forms.BindingSource()
            source.DataSource = New Examples.DataLayoutControlExample.MyClassTabsLayout()
            dataLayoutControl1.DataSource = source
            dataLayoutControl1.RetrieveFields()
            dataLayoutControl1.BestFit()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class Person

            Const GroupForName As String = "<groupForName->"

            Const GroupForPhone As String = "<groupForPhone->"

            Const GroupForBirthDate As String = "<groupForBD->"

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.Person.GroupForName)>
            Public Property FirstName As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.Person.GroupForName)>
            Public Property LastName As String

            Public ReadOnly Property FullName As String
                Get
                    Return Me.FirstName & " " & Me.LastName
                End Get
            End Property

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.Person.GroupForPhone)>
            Public Property Phone As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.Person.GroupForPhone)>
            Public Property Email As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.Person.GroupForBirthDate)>
            Public Property BirthDate As DateTime

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.Person.GroupForBirthDate)>
            Public Property Gender As GenderEnum

            Public Enum GenderEnum
                Male
                Female
            End Enum

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:="Address")>
            Public Property AddressInfo As AddressClass
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class AddressClass

            Const GroupForCity As String = "<groupForCity->"

            Const GroupForAddressLine As String = "<groupForAddressLine->"

            Const GroupForLocation As String = "<groupForLocation->"

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.AddressClass.GroupForCity)>
            Public Property City As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.AddressClass.GroupForCity)>
            Public Property State As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Address", GroupName:=Examples.DataLayoutControlExample.AddressClass.GroupForAddressLine)>
            Public Property Line As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.AddressClass.GroupForAddressLine)>
            Public Property ZipCode As String

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.AddressClass.GroupForLocation)>
            Public Property Latitude As Double

            <System.ComponentModel.DataAnnotations.DisplayAttribute(GroupName:=Examples.DataLayoutControlExample.AddressClass.GroupForLocation)>
            Public Property Longitude As Double
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Nested object example", New System.Type() {GetType(Examples.DataLayoutControlExample.Person), GetType(Examples.DataLayoutControlExample.AddressClass)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DefaultBoolean", "RetrieveFieldsParameters", "Person", "AddressClass", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RetrieveFields")>
        Public Sub DataLayoutBindToMultipleClass(ByVal dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl)
            ' In this example, the DataLayoutControl automatically builds a layout for editing the Person and nested Address objects.
            ' To edit the nested Address object's properties, a group of items is automatically generated.
            ' The RetrieveFields method is called with the DataSourceUpdateMode parameter set to 'OnPropertyChanged'.
            ' This causes data to be posted to the underlying object immediately on text entering.
            Dim source As System.Windows.Forms.BindingSource = New System.Windows.Forms.BindingSource()
            source.DataSource = New Examples.DataLayoutControlExample.Person()
            dataLayoutControl1.DataSource = source
            dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.[True]
            Dim parameters As DevExpress.XtraDataLayout.RetrieveFieldsParameters = New DevExpress.XtraDataLayout.RetrieveFieldsParameters()
            parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
            dataLayoutControl1.RetrieveFields(parameters)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Customize properties of auto-generated Layout items and controls", New System.Type() {GetType(Examples.DataLayoutControlExample.Person), GetType(Examples.DataLayoutControlExample.AddressClass)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("Color", "DefaultBoolean", "RetrieveFieldsParameters", "Person", "AddressClass", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("FieldRetrieved")>
        Public Sub DataLayoutControlFieldRetrieved(ByVal dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl)
            'In this example, the FieldRetrieved event is handled to customize auto-generated controls' properties.
            Dim source As System.Windows.Forms.BindingSource = New System.Windows.Forms.BindingSource()
            source.DataSource = New Examples.DataLayoutControlExample.Person()
            dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.[True]
            dataLayoutControl1.DataSource = source
            AddHandler dataLayoutControl1.FieldRetrieved, Sub(s, e)
                If Equals(e.FieldName, "FirstName") OrElse Equals(e.FieldName, "LastName") Then
                    e.Control.BackColor = System.Drawing.Color.GreenYellow
                End If
            End Sub
            dataLayoutControl1.RetrieveFields()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Customize binding info and editor type", New System.Type() {GetType(Examples.DataLayoutControlExample.Person), GetType(Examples.DataLayoutControlExample.AddressClass)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DataSourceUpdateMode", "ComboBoxEdit", "DefaultBoolean", "RetrieveFieldsParameters", "Person", "AddressClass", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("FieldRetrieving")>
        Public Sub DataLayoutControlFieldRetrieving(ByVal dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl)
            'In this example, the FieldRetrieving event is handled to customize the binding info and editor type.
            Dim source As System.Windows.Forms.BindingSource = New System.Windows.Forms.BindingSource()
            source.DataSource = New Examples.DataLayoutControlExample.Person()
            dataLayoutControl1.DataSource = source
            dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.[True]
            AddHandler dataLayoutControl1.FieldRetrieving, Sub(s, e)
                If Equals(e.FieldName, "AddressInfo.ZipCode") Then e.EditorType = GetType(DevExpress.XtraEditors.ComboBoxEdit)
                e.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
                e.Handled = True
            End Sub
            dataLayoutControl1.RetrieveFields()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class CollectionData

            Public Property Employees As List(Of Examples.DataLayoutControlExample.Person)

            Public Property BoolProperty As Boolean

            Public Property StringProperty As String
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Generate CollectionProperties", New System.Type() {GetType(Examples.DataLayoutControlExample.CollectionData), GetType(Examples.DataLayoutControlExample.Person), GetType(Examples.DataLayoutControlExample.AddressClass)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DisplayFormat", "CollectionData", "BindingSource", "Person", "List", "Display")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AllowGeneratingCollectionProperties"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(162)>
        Public Sub DataLayoutControlCollectionProperties(ByVal dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl)
            Dim source As System.Windows.Forms.BindingSource = New System.Windows.Forms.BindingSource()
            source.DataSource = New Examples.DataLayoutControlExample.CollectionData() With {.Employees = New System.Collections.Generic.List(Of Examples.DataLayoutControlExample.Person)() From {New Examples.DataLayoutControlExample.Person()}}
            dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.[True]
            dataLayoutControl1.DataSource = source
            dataLayoutControl1.RetrieveFields()
            dataLayoutControl1.BestFit()
        End Sub
    End Module
End Namespace
