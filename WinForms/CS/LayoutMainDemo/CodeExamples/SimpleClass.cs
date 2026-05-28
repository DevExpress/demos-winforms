using System;
using DevExpress.XtraLayout;
using DevExpress.Utils;
using System.Globalization;
using DevExpress.XtraEditors;
using DevExpress.DXperience.Demos.CodeDemo;
using System.Windows.Forms;
using DevExpress.XtraLayout.Utils;
using System.Drawing;
using DevExpress.Utils.Menu;
using DevExpress.XtraDataLayout;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraLayout.Customization.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.Utils.Drawing;
using DevExpress.XtraLayout.Registrator;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Design;
using DevExpress.XtraEditors.ButtonsPanelControl;
using DevExpress.XtraEditors.Controls;
using System.Collections.Generic;

namespace Examples {
    [CodeExampleClass("Create layout in code", "SimpleClass.cs")]
    [CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup",
        "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "LayoutType", "SizeType", "Size", "LayoutMode", "SizeConstraintsType")]
    public static class CreateLayoutInCode {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            LayoutControl layoutControl = new LayoutControl();
            layoutControl.Dock = DockStyle.Fill;
            layoutControl.Parent = sampleHost;
            return new object[] { layoutControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as LayoutControl).Dispose();
        }
        [CodeExampleCase("Horizontal arrangement")]
        public static void CreateHorzAlignedLayout(LayoutControl layoutControl) {
            // A layout consisting of two horizontally arranged items.
            layoutControl.Root.DefaultLayoutType = LayoutType.Horizontal;
            layoutControl.AddItem("Memo 1", new MemoEdit() { Text = "Memo1", Name = "Memo1" });
            layoutControl.AddItem("Memo 2", new MemoEdit() { Text = "Memo2", Name = "Memo2" });
            layoutControl.BestFit();
        }
        [CodeExampleCase("Vertical arrangement")]
        public static void CreateVertAlignedLayout(LayoutControl layoutControl) {
            // A layout consisting of two vertically arranged items.
            layoutControl.Root.DefaultLayoutType = LayoutType.Vertical;
            layoutControl.AddItem("Memo 1", new MemoEdit() { Text = "Memo1", Name = "Memo1" });
            layoutControl.AddItem("Memo 2", new MemoEdit() { Text = "Memo2", Name = "Memo2" });
            layoutControl.BestFit();
        }
        [CodeExampleCase("Visible and hidden items")]
        public static void CreateVisibleAndHiddenItems(LayoutControl layoutControl) {
            // This example creates a layout consisting of two items displaying two text boxes. 
            // In addition, one hidden item (containing a memo editor) is also created. It can be accessed from the Customization Form.

            //Create a layout item and add it to the root group.    
            LayoutControlItem item1 = layoutControl.Root.AddItem();
            // Set the item's Control and caption.
            item1.Name = "Layout Item 1";
            TextEdit textEdit = new TextEdit();
            textEdit.Name = "TextBox1";
            item1.Control = textEdit;
            item1.Text = "Name:";

            // Create a new layout item.
            LayoutControlItem item2 = new LayoutControlItem();
            // Add the item to the root group by setting its parent.
            item2.Parent = layoutControl.Root;
            item2.Name = "Layout Item 2";
            TextEdit textBox2 = new TextEdit();
            textBox2.Name = "TextBox2";
            item2.Control = textBox2;
            item2.Text = "E-mail:";

            // Create a hidden layout item.
            LayoutControlItem item3 = new LayoutControlItem();
            item3.Name = "Layout Item 3";
            layoutControl.HiddenItems.AddRange(new BaseLayoutItem[] { item3 });
            MemoEdit memo = new MemoEdit();
            memo.Name = "memo1";
            item3.Control = memo;
            item3.Text = "Notes:";

            //layoutControl.ShowCustomizationForm();

        }
        [CodeExampleCase("Group with title and borders")]
        public static void CreateGroupWithTitleBorder(LayoutControl layoutControl) {
            // This example creates a layout containing a group of two items.
            // The second item is positioned using the Move method, 
            // which allows you to place an item at any of the four edges of another item.

            // Create a new "Personal Info" group.
            LayoutControlGroup group1 = new LayoutControlGroup();
            group1.Name = "GroupPersonalInfo";
            group1.Text = "Personal Info";
            // Create a layout item within the group.
            LayoutControlItem item1 = group1.AddItem();
            // Bind a control to the layout item.
            TextEdit textEdit = new TextEdit();
            textEdit.Name = "TextBox1";
            item1.Control = textEdit;
            item1.Text = "Name";

            // Create a layout item that will display a DateEdit control.
            DateEdit dtPicker = new DateEdit();
            dtPicker.Name = "dateEdit";
            LayoutControlItem item2 = new LayoutControlItem(layoutControl, dtPicker);
            item2.Text = "Date";
            // Position this item to the right of item1
            item2.Move(item1, InsertType.Right);
            // Add the created group to the root group.
            layoutControl.Root.Add(group1);


        }
        [CodeExampleCase("Tabbed group")]
        public static void CreateTabbedGroup(LayoutControl layoutControl) {
            // This example creates a layout containing a tabbed group that has two tabs (regular groups).
            // Each tab displays a single control (PictureEdit and MemoEdit, respectively).

            // Create a tabbed group within the root group.
            TabbedControlGroup tabbedGroup = layoutControl.Root.AddTabbedGroup();
            tabbedGroup.Name = "TabbedGroup";
            // Add a new group as a tab to the tabbed group.
            LayoutControlGroup group1 = tabbedGroup.AddTabPage() as LayoutControlGroup;
            group1.Name = "LayoutControlGroup1";
            group1.Text = "Photo";
            // Add a new layout item to the group that will display an image.
            LayoutControlItem item1 = group1.AddItem();
            item1.Name = "LayoutControlItem1";
            item1.Control = new PictureEdit() { Name = "PictureEdit" };
            // Hide the item's text region.
            item1.TextVisible = false;
            // Add a new group to the tabbed group.
            LayoutControlGroup group2 = tabbedGroup.AddTabPage() as LayoutControlGroup;
            group2.Name = "LayoutControlGroup2";
            group2.Text = "Notes";

            // Add a new layout item to the group that will display an image.
            LayoutControlItem item2 = group2.AddItem();
            item2.Name = "LayoutControlItem1";
            item2.Control = new MemoEdit() { Name = "MemoEdit" }; ;
            // Hide the item's text region.
            item2.TextVisible = false;

            // Make the first tab page active.
            tabbedGroup.SelectedTabPage = group1;

        }
        [CodeExampleCase("M rows x N columns layout")]
        public static void CreateMxNLayout(LayoutControl layoutControl) {
            // A layout consisting of a specified number of columns and rows.
            int rowCount = 4;
            int columnCount = 4;
            LayoutControlGroup group = new LayoutControlGroup();
            group.BeginUpdate();
            for(int i = 0; i < rowCount; i++)
                for(int j = 0; j < columnCount; j++) {
                    int itemIndex = group.Items.Count + 1;
                    LayoutControlItem item = group.AddItem("Memo" + itemIndex, new MemoEdit() { Name = "Memo" + itemIndex });
                    item.Location = new Point(i * 100, j * 100);
                    item.Size = new Size(100, 100);
                }

            group.EndUpdate();
            layoutControl.Root = group;
        }
        [CodeExampleCase("Highlight Focused item")]
        [CodeExampleHighlightTokens("DefaultBoolean")]
        [CodeExampleUnderlineTokens("HighlightFocusedItem"), CodeExampleVersionID(162)]
        public static void HighLightFocusedItem(LayoutControl layoutControl) {
            // HighlightFocusedItem at the item's level

            //layoutControl.OptionsView.HighlightFocusedItem = true;

            LayoutControlItem newItem1 = layoutControl.AddItem("Memo 1", new MemoEdit() { Text = "Memo1", Name = "Memo1" });
            newItem1.HighlightFocusedItem = DefaultBoolean.True;
            LayoutControlItem newItem2 = layoutControl.AddItem("Memo 2", new MemoEdit() { Text = "Memo2", Name = "Memo2" });
            newItem2.HighlightFocusedItem = DefaultBoolean.False;
            LayoutControlItem newItem3 = layoutControl.AddItem("Memo 3", new MemoEdit() { Text = "Memo3", Name = "Memo3" });
            newItem3.HighlightFocusedItem = DefaultBoolean.Default;
            layoutControl.BestFit();
        }

        [CodeExampleCase("Expand Animation")]
        [CodeExampleHighlightTokens("DefaultBoolean")]
        [CodeExampleUnderlineTokens("AllowExpandAnimation"), CodeExampleVersionID(162)]
        public static void ExpandAnimation(LayoutControl layoutControl) {
            layoutControl.OptionsView.AllowExpandAnimation = DefaultBoolean.True;

            for(int i = 0; i < 3; i++) {
                LayoutControlGroup newGroup = layoutControl.AddGroup();
                newGroup.ExpandButtonVisible = true;
                newGroup.AddItem("Text 1 in newGroup " + i, new TextEdit() { Text = "Text1" + i, Name = "Text1" + i });
                newGroup.AddItem("Text 2 in newGroup " + i, new TextEdit() { Text = "Text2" + i, Name = "Text2" + i });
            }
            layoutControl.AddItem(new EmptySpaceItem());
            layoutControl.BestFit();
        }

        [CodeExampleCase("HTML Text Formatting")]
        [CodeExampleHighlightTokens("DefaultBoolean")]
        [CodeExampleUnderlineTokens("AllowHtmlStringInCaption"), CodeExampleVersionID(162)]
        public static void AllowHtmlString(LayoutControl layoutControl) {
            LayoutControlItem newItem1 = layoutControl.AddItem("", new MemoEdit() { Text = "Memo1", Name = "Memo1" });
            newItem1.TextLocation = Locations.Top;
            newItem1.Text = "<color=255, 0, 0>Memo Red</color> <u>Underline</u>";
            newItem1.AllowHtmlStringInCaption = true;

            LayoutControlGroup addGroup = layoutControl.AddGroup();
            addGroup.Text = "<color=0, 0, 255>Layout Group</color> <b>Bold</b>";
            addGroup.AllowHtmlStringInCaption = true;

            layoutControl.BestFit();
        }

        [CodeExampleCase("Word Wrap Text")]
        [CodeExampleHighlightTokens("LabelControl, WordWrap, LayoutType, LabelAutoSizeMode, LabelControl")]
        [CodeExampleUnderlineTokens("WordWrap"), CodeExampleVersionID(162)]
        public static void WordWrapText(LayoutControl layoutControl) {
            string STR_Laborum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            layoutControl.Root.DefaultLayoutType = LayoutType.Horizontal;

            LabelControl labelControl1 = new LabelControl() { Text = STR_Laborum, BackColor = Color.LightGreen, Name = "label1" };
            labelControl1.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
            labelControl1.AutoSizeMode = LabelAutoSizeMode.Vertical;
            LayoutControlItem item1 = layoutControl.Root.AddItem("", labelControl1);
            item1.TextVisible = false;

            layoutControl.AddItem(new SplitterItem());

            LabelControl labelControl2 = new LabelControl() { Text = STR_Laborum, BackColor = Color.LightSkyBlue, Name = "label2" };
            labelControl2.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
            labelControl2.AutoSizeMode = LabelAutoSizeMode.Vertical;
            LayoutControlItem item2 = layoutControl.Root.AddItem("", labelControl2);
            item2.TextVisible = false;

            layoutControl.BestFit();
        }
    }
    [CodeExampleClass("Change layout in code", "SimpleClass.cs")]
    [CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup",
        "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SplitterItem", "LayoutType", "SizeType", "Size", "LayoutMode", "SizeConstraintsType")]
    public static class ChangeLayout {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            LayoutControl layoutControl = new LayoutControl();
            layoutControl.Dock = DockStyle.Fill;
            layoutControl.Parent = sampleHost;
            return new object[] { layoutControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as LayoutControl).Dispose();
        }
        [CodeExampleCase("Custom size constraints")]
        [CodeExampleHighlightTokens("SplitterItem", "Size")]
        public static void ChangeCustomSizeConstraints(LayoutControl layoutControl) {
            // This example applies size constraints to the first item 
            // Resize the items using the splitter.
            // The size constraints will not allow you to change the first item's height to a value beyond the range [50;200].
            layoutControl.Root.DefaultLayoutType = LayoutType.Vertical;
            LayoutControlItem item1 = layoutControl.AddItem("Memo 1", new MemoEdit() { Name = "Memo1" });
            item1.SizeConstraintsType = SizeConstraintsType.Custom;
            item1.MinSize = new Size(0, 50);
            item1.MaxSize = new Size(0, 200);
            layoutControl.AddItem(new SplitterItem());
            layoutControl.AddItem("Memo 2", new MemoEdit() { Name = "Memo2" });
            layoutControl.BestFit();
        }
        [CodeExampleCase("Content alignment any control within its layout item")]
        [CodeExampleHighlightTokens("HorzAlignment", "VertAlignment"), CodeExampleUnderlineTokens("ContentHorzAlignment", "ContentVertAlignment")]
        [CodeExampleVersionID(192)]
        public static void ChangeContentAlignment(LayoutControl layoutControl) {
            // Center the control horizontally and vertically.
            LayoutControlItem layoutControlItem1 = layoutControl.AddItem("TextEdit", new TextEdit() { Name = "TextEdit" });
            layoutControlItem1.Control.MaximumSize = new Size(100, 0);
            layoutControlItem1.ContentHorzAlignment = HorzAlignment.Center;
            //layoutControlItem1.ContentHorzAlignment = HorzAlignment.Far;
            layoutControlItem1.ContentVertAlignment = VertAlignment.Center;
            //layoutControlItem1.ContentVertAlignment = VertAlignment.Bottom;
        }
        [CodeExampleCase("Content alignment of auto-sized SimpleButton")]
        [CodeExampleHighlightTokens("HorzAlignment", "VertAlignment", "SimpleButton"), CodeExampleUnderlineTokens("ContentHorzAlignment", "ContentVertAlignment", "AutoSizeInLayoutControl")]
        [CodeExampleVersionID(192)]
        public static void ChangeSimpleButtonContentAlignment(LayoutControl layoutControl) {
            // SimpleButton provides the AutoWidthInLayoutControl property, which enables the auto-sizing feature inside the Layout Control.
            // This example shows how to custom align a SimpleButton when the auto-sizing feature is enabled.
            SimpleButton btn = new SimpleButton() { Name = "SimpleButton", Text = "button" };
            LayoutControlItem layoutControlItem1 = layoutControl.AddItem("Button", btn);
            btn.AutoWidthInLayoutControl = true;
            layoutControlItem1.ContentHorzAlignment = HorzAlignment.Center;
            //layoutControlItem1.ContentHorzAlignment = HorzAlignment.Far;
            layoutControlItem1.ContentVertAlignment = VertAlignment.Center;
            //layoutControlItem1.ContentVertAlignment = VertAlignment.Bottom;
        }
        [CodeExampleCase("Content alignment of auto-sized CheckEdit and RadioGroup")]
        [CodeExampleHighlightTokens("HorzAlignment", "VertAlignment", "CheckEdit", "RadioGroup", "RadioGroupItemsLayout"), CodeExampleUnderlineTokens("ContentHorzAlignment", "ContentVertAlignment", "AutoSizeInLayoutControl")]
        [CodeExampleVersionID(192)]
        public static void ChangeCheckEditAndRadioGroupContentAlignment(LayoutControl layoutControl) {
            // CheckEdit and RadioGroup provide the AutoSizeInLayoutControl property, which enables the auto-sizing feature inside the Layout Control.
            // This example shows how to custom align these controls when the auto-sizing feature is enabled.
            CheckEdit checkEdit1 = new CheckEdit() { Name = "CheckEdit" };
            LayoutControlItem layoutControlItem1 = layoutControl.AddItem("Check box", checkEdit1);
            checkEdit1.AutoSizeInLayoutControl = true;
            layoutControlItem1.ContentHorzAlignment = HorzAlignment.Center;
            //layoutControlItem1.ContentHorzAlignment = HorzAlignment.Far;

            RadioGroup radioGroup1 = new RadioGroup() { Name = "RadioGroup" };
            radioGroup1.Properties.Items.AddEnum<HorzAlignment>();
            LayoutControlItem layoutControlItem2 = layoutControl.AddItem("Radio Group", radioGroup1);
            layoutControlItem2.TextVisible = false;
            radioGroup1.AutoSizeInLayoutControl = true;
            radioGroup1.Properties.ItemsLayout = RadioGroupItemsLayout.Column;
            radioGroup1.Properties.Columns = 1;
            radioGroup1.MaximumSize = new Size(200, 0);
            layoutControlItem2.ContentHorzAlignment = HorzAlignment.Center;
            //layoutControlItem2.ContentHorzAlignment = HorzAlignment.Far;
            layoutControlItem2.ContentVertAlignment = VertAlignment.Center;
            //layoutControlItem2.ContentVertAlignment = VertAlignment.Bottom;     
        }
        [CodeExampleCase("Text location")]
        [CodeExampleHighlightTokens("Locations", "SimpleButton", "ContentAlignment", "Font", "FontStyle")]
        public static void ChangeTextLocation(LayoutControl layoutControl) {
            // This example shows how to change an item's text location.
            LayoutControlItem item = layoutControl.AddItem("Memo", new MemoEdit() { Name = "Memo" });
            item.TextLocation = Locations.Right;
            item.AppearanceItemCaption.Font = new Font(item.AppearanceItemCaption.Font, FontStyle.Bold);


            // Optional code that creates a button allowing you to change the text location on a click.
            Locations[] textLocationArray = new Locations[] { Locations.Bottom, Locations.Left, Locations.Top, Locations.Right };
            int locationCounter = 0;
            SimpleButton btn = new SimpleButton() { Name = "Button", Text = "Change text location" };
            LayoutControlItem item2 = layoutControl.AddItem("Button", btn);
            item2.TextVisible = false;
            btn.Click += (s, e) => {
                item.TextLocation = textLocationArray[(locationCounter++) % 4];
            };
            // Center the button.
            btn.AutoWidthInLayoutControl = true;
            item2.SizeConstraintsType = SizeConstraintsType.SupportHorzAlignment;
            item2.ControlAlignment = ContentAlignment.TopCenter;

        }
        [CodeExampleCase("Auto Height Mode")]
        [CodeExampleHighlightTokens("AutoSizeMode", "AutoSize", "MemoEdit", "AutoHeightMode")]
        public static void AutoHeightMode(LayoutControl layoutControl) {
            layoutControl.Root.LayoutMode = LayoutMode.Table;
            MemoEdit growOnlyME = new MemoEdit()
                { Name = "Memo1", LayoutControlAutoHeightMode = MemoEditLayoutControlAutoHeightMode.GrowOnly, Text = string.Join(Environment.NewLine, new string[] { "Write some text", "to overflow height", "of the memo edit", "and it will expand", "but won't come back"}) };
            MemoEdit growAndShrinkME = new MemoEdit() { Name = "Memo2", LayoutControlAutoHeightMode = MemoEditLayoutControlAutoHeightMode.GrowAndShrink, Text = "This one will shrink to current content, or single line if empty some text" };
            LayoutControlItem item1 = layoutControl.AddItem("Memo 1", growOnlyME);
            LayoutControlItem item2 = layoutControl.AddItem("Memo 2", growAndShrinkME);
            item2.OptionsTableLayoutItem.RowIndex = 1;
            item2.OptionsTableLayoutItem.ColumnIndex = 1;

        }
        [CodeExampleCase("Save and restore layout")]
        [CodeExampleHighlightTokens("Locations", "SimpleButton", "ContentAlignment")]
        public static void ChangeSaveAndRestoreLayout(LayoutControl layoutControl) {
            // This example saves the current layout to an internal memory buffer, changes the layout and then restores the saved layout.
            // NOTE: To correctly save and restore a layout, unique values must be assigned to the Name properties 
            // of all layout items and controls displayed within layout items. 
            LayoutControlItem item = layoutControl.AddItem("Memo", new MemoEdit() { Name = "Memo" });
            item.Name = "itemMemo";
            // Save the layout.
            layoutControl.SetDefaultLayout();
            // Change the layout.
            item.TextLocation = Locations.Right;
            //..
            // Restore the saved layout.
            layoutControl.RestoreDefaultLayout();
            // To save the layout to an XML file, stream or the system registry, use the SaveLayoutToXml, SaveLayoutToStream and SaveLayoutToRegistry methods, respectively.
            // To restore the saved layouts, use RestoreLayoutFromXml, RestoreLayoutFromStream and RestoreLayoutFromRegistry methods


            // Optional code that creates buttons allowing you to manually save, change and restore a layout.
            LayoutControlGroup buttonGroup = layoutControl.AddGroup();
            buttonGroup.Name = "buttonGroup";
            buttonGroup.Text = "Layout buttons";
            buttonGroup.DefaultLayoutType = LayoutType.Horizontal;
            SimpleButton btnSaveLayout = new SimpleButton() { Name = "ButtonSave", Text = "Save Layout" };
            SimpleButton btnChangeLayout = new SimpleButton() { Name = "ButtonChange", Text = "Change Text Location" };
            SimpleButton btnRestoreLayout = new SimpleButton() { Name = "ButtonRestore", Text = "Restore Layout" };

            LayoutControlItem itemSaveLayout = buttonGroup.AddItem("Save Layout", btnSaveLayout);
            itemSaveLayout.TextVisible = false;
            itemSaveLayout.Name = "itemSaveLayout";
            LayoutControlItem itemChangeLayout = buttonGroup.AddItem("Change Layout", btnChangeLayout);
            itemChangeLayout.TextVisible = false;
            itemChangeLayout.Name = "itemChangeLayout";
            LayoutControlItem itemRestoreLayout = buttonGroup.AddItem("Restore Layout", btnRestoreLayout);
            itemRestoreLayout.TextVisible = false;
            itemRestoreLayout.Name = "itemRestoreLayout";
            buttonGroup.BestFit();
            int locationCounter = 0;
            btnSaveLayout.Click += (s, e) => {
                layoutControl.SetDefaultLayout();
            };
            btnChangeLayout.Click += (s, e) => {
                Locations[] textLocationArray = new Locations[] { Locations.Bottom, Locations.Left, Locations.Top, Locations.Right };
                item.TextLocation = textLocationArray[(locationCounter++) % 4];
            };
            btnRestoreLayout.Click += (s, e) => {
                layoutControl.RestoreDefaultLayout();
            };
        }
        [CodeExampleCase("Swap controls")]
        [CodeExampleHighlightTokens("DxImageAssemblyUtil", "SimpleButton", "PictureEdit", "ImageSize", "ImageType", "ContentAlignment", "Control")]
        public static void ChangeLayoutSwapControls(LayoutControl layoutControl) {
            // This example shows how to swap controls of two layout items.
            // Click the button to perform swapping.
            LayoutControlItem item1 = layoutControl.AddItem("Memo", new MemoEdit() { Name = "Memo1", Text = "Memo" });
            LayoutControlItem item2 = layoutControl.AddItem("Picture", new PictureEdit() {
                Name = "Picture",
                Image = DxImageAssemblyUtil.ImageProvider.GetImage("ColorMixer", ImageSize.Size32x32, ImageType.Colored)
            });
            layoutControl.BestFit();

            SimpleButton btn = new SimpleButton() { Text = "Click Me to Swap Controls" };
            LayoutControlItem itemButton = layoutControl.AddItem("btnSwapControls", btn);
            itemButton.TextVisible = false;
            btn.Click += (s, e) => {
                layoutControl.BeginUpdate();
                Control ctrl1 = item1.Control;
                Control ctrl2 = item2.Control;
                item1.Control = null;
                item2.Control = null;
                item1.Control = ctrl2;
                item2.Control = ctrl1;
                layoutControl.EndUpdate();
            };

        }
        [CodeExampleCase("Layout group border color blending")]
        [CodeExampleHighlightTokens("Color")]
        [CodeExampleUnderlineTokens("AllowBorderColorBlending")]
        public static void AllowBorderColorBlending(LayoutControl layoutControl) {
            //This example showes how to highlight the group border.
            layoutControl.AddGroup();
            LayoutControlGroup group = layoutControl.AddGroup();
            group.AllowBorderColorBlending = true;
            group.AppearanceGroup.BorderColor = Color.YellowGreen;
            layoutControl.BestFit();
        }
    }
    [CodeExampleClass("LayoutControl events", "SimpleClass.cs")]
    [CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup",
        "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SizeType", "LayoutType", "Size", "LayoutMode", "SizeConstraintsType")]
    public static class EventLayoutControl {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            LayoutControl layoutControl = new LayoutControl();
            layoutControl.Dock = DockStyle.Fill;
            layoutControl.Parent = sampleHost;
            return new object[] { layoutControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as LayoutControl).Dispose();
        }
        [CodeExampleCase("Change group caption on expanding/collapsing")]
        [CodeExampleUnderlineTokens("GroupExpandChanged")]
        public static void EventGroupExpandChanged(LayoutControl layoutControl) {
            // This example uses the GroupExpandChanged event to modify the group caption.
            LayoutControlGroup group = layoutControl.AddGroup();
            group.ExpandButtonVisible = true;
            group.Text = "Group (Expanded)";
            group.AddItem("Memo 1", new MemoEdit() { Name = "Memo 1" });
            group.AddItem("Memo 2", new MemoEdit() { Name = "Memo 2" });
            group.BestFit();
            layoutControl.GroupExpandChanged += (s, e) => {
                if(e.Group.Expanded) e.Group.Text = "Group (Expanded)";
                else e.Group.Text = "Group (Collapsed)";
            };

        }
        [CodeExampleCase("Toggle item visibility on click")]
        public static void EventLayoutItemClick(LayoutControl layoutControl) {
            // This example handles the LayoutItem.Click event to change a clicked item's visibility.
            LayoutControlGroup group = layoutControl.AddGroup();
            group.ExpandButtonVisible = true;
            group.Text = "My Group";
            LayoutControlItem memoLCI1 = group.AddItem("Memo 1", new MemoEdit() { Name = "Memo 1" });
            LayoutControlItem memoLCI2 = group.AddItem("Memo 2", new MemoEdit() { Name = "Memo 2" });
            group.BestFit();
            memoLCI1.Click += (s, e) => {
                if(s is LayoutControlItem) {
                    LayoutControlItem item = s as LayoutControlItem;
                    item.ContentVisible = !item.ContentVisible;
                }
            };
            memoLCI2.Click += (s, e) => {
                if(s is LayoutControlItem) {
                    LayoutControlItem item = s as LayoutControlItem;
                    item.ContentVisible = !item.ContentVisible;
                }
            };
        }
        [CodeExampleCase("Hyperlinks in item captions")]
        [CodeExampleUnderlineTokens("HyperlinkClick"), CodeExampleVersionID(202)]
        public static void EventHyperlinkClick(LayoutControl layoutControl) {
            // This example uses HTML-inspired text formatting to add hyperlinks to item captions
            LayoutControlItem memoLCI1 = layoutControl.Root.AddItem("<href='Memo 1'>Memo 1</href> sample", new MemoEdit() { Name = "Memo 1" });
            memoLCI1.TextLocation = Locations.Top;
            memoLCI1.AllowHtmlStringInCaption = true;
            LayoutControlItem memoLCI2 = layoutControl.Root.AddItem("<href='Memo 2'>Memo 2</href> sample", new MemoEdit() { Name = "Memo 2" });
            memoLCI2.TextLocation = Locations.Top;
            memoLCI2.AllowHtmlStringInCaption = true;
            layoutControl.Root.BestFit();
            // The HyperlinkClick event is handled to perform actions when you click the links.
            layoutControl.HyperlinkClick += (s, e) => {
                XtraMessageBox.Show(string.Format("{0} clicked", e.Link));
            };
        }
        [CodeExampleCase("Expand/collapse group from context menu")]
        [CodeExampleHighlightTokens("DXMenuItem", "LayoutGroup")]
        [CodeExampleUnderlineTokens("PopupMenuShowing")]
        public static void EventRightButtonPopupMenu(LayoutControl layoutControl) {
            // This example handles the PopupMenuShowing event to add a 'Collapse'/'Expand' command to a group's context menu.
            // Right-click the group caption and select 'Collapse' or 'Expand'
            LayoutControlGroup group = layoutControl.AddGroup();
            group.Name = "My group";
            group.AddItem("Memo 1", new MemoEdit() { Name = "Memo 1" });
            group.AddItem("Memo 2", new MemoEdit() { Name = "Memo 2" });
            group.BestFit();
            layoutControl.PopupMenuShowing += (s, e) => {
                if(e.HitInfo.Item.Parent != null && e.HitInfo.Item.IsGroup) {
                    LayoutGroup layoutGroup = e.HitInfo.Item as LayoutGroup;
                    DXMenuItem menu = new DXMenuItem(group.Expanded ? "Collapse" : "Expand", (sender, eventArgs) => {
                        if(sender is DXMenuItem) {
                            LayoutGroup groupToExpandCollapse = (sender as DXMenuItem).Tag as LayoutGroup;
                            groupToExpandCollapse.Expanded = !groupToExpandCollapse.Expanded;
                        }
                    });
                    menu.Tag = e.HitInfo.Item;
                    e.Menu.Items.Add(menu);
                };
            };
        }
        [CodeExampleCase("Expand/collapse group from Tree View's context menu")]
        [CodeExampleHighlightTokens("DXMenuItem", "LayoutGroup")]
        [CodeExampleUnderlineTokens("LayoutTreeViewPopupMenuShowing")]
        public static void EventLayoutTreeViewPopupMenuShowing(LayoutControl layoutControl) {
            // This example handles the LayoutTreeViewPopupMenuShowing event to add a 'Collapse'/'Expand' command to the context menu
            // for groups in the 'Layout Tree View' tab in the Customization Form.
            LayoutControlGroup group = layoutControl.AddGroup();
            group.Name = "My Group";
            group.AddItem("Memo 1", new MemoEdit() { Name = "Memo 1" });
            group.AddItem("Memo 2", new MemoEdit() { Name = "Memo 2" });
            group.BestFit();
            layoutControl.LayoutTreeViewPopupMenuShowing += (s, e) => {
                if(e.HitInfo.Item.Parent != null && e.HitInfo.Item.IsGroup) {
                    LayoutGroup layoutGroup = e.HitInfo.Item as LayoutGroup;
                    DXMenuItem menu = new DXMenuItem(group.Expanded ? "Collapse" : "Expand", (sender, eventArgs) => {
                        if(sender is DXMenuItem) {
                            LayoutGroup groupToExpandCollapse = (sender as DXMenuItem).Tag as LayoutGroup;
                            groupToExpandCollapse.Expanded = !groupToExpandCollapse.Expanded;
                        }
                    });
                    menu.Tag = e.HitInfo.Item;
                    e.Menu.Items.Add(menu);
                };
            };
            layoutControl.ShowCustomizationForm();
            group.Selected = true;

        }
        [CodeExampleCase("Drag items only within their parent groups")]
        [CodeExampleHighlightTokens("EmptySpaceItem", "InsertType", "ILayoutControl")]
        [CodeExampleUnderlineTokens("ItemDragging")]
        public static void EventItemDragging(LayoutControl layoutControl) {
            //This example handles the ItemDragging event to prevent items from being moved between groups.
            LayoutControlGroup group1 = layoutControl.AddGroup();
            group1.AddItem(new EmptySpaceItem());
            group1.AddItem(new EmptySpaceItem());
            LayoutControlGroup group2 = layoutControl.AddGroup(group1, InsertType.Right);
            group2.AddItem(new EmptySpaceItem());
            group2.AddItem(new EmptySpaceItem());
            layoutControl.BestFit();
            layoutControl.ItemDragging += (s, e) => {
                if(e.DragController == null) return;
                if(e.DragController.DragItem == null || e.DragController.Item == null) return;
                if(!e.DragController.DragItem.Parent.Equals(e.DragController.Item.Parent)) {
                    e.AllowDrop = false;
                }
            };
            ((ILayoutControl)layoutControl).EnableCustomizationMode = true;
        }
        [CodeExampleCase("Custom draw items")]
        [CodeExampleHighlightTokens("EmptySpaceItem", "Color", "SolidBrush", "MemoEdit")]
        [CodeExampleUnderlineTokens("CustomDraw"), CodeExampleVersionID(162)]
        public static void CustomDraw(LayoutControl layoutControl) {
            LayoutControlGroup group = layoutControl.AddGroup();
            LayoutControlItem item = layoutControl.AddItem("Memo 1", new MemoEdit() { Text = "Memo1", Name = "Memo1" });
            TabbedControlGroup addTabbedGroup = layoutControl.AddTabbedGroup();
            addTabbedGroup.AddTabPage();
            addTabbedGroup.AddTabPage();
            layoutControl.BestFit();
            //Custom draw LayoutControlGroup
            group.CustomDraw += (s, e) => {
                e.DefaultDraw();
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 0, 255, 0)), e.Bounds);
                e.Handled = true;
            };
            //Custom draw LayoutControlItem
            item.CustomDraw += (s, e) => {
                e.DefaultDraw();
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 255, 0, 0)), e.Bounds);
                e.Handled = true;
            };
            //Custom draw TabbedControlGroup
            addTabbedGroup.CustomDraw += (s, e) => {
                e.DefaultDraw();
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 0, 0, 255)), e.Bounds);
                e.Handled = true;
            };
        }

        [CodeExampleCase("CustomHeaderButtons In Group")]
        [CodeExampleHighlightTokens("EmptySpaceItem", "GroupBoxButton", "ButtonStyle", "MessageBox")]
        [CodeExampleUnderlineTokens("CustomButtonClick", "CustomButtonChecked", "CustomButtonUnchecked"), CodeExampleVersionID(162)]
        public static void CustomHeaderButtonsInGroup(LayoutControl layoutControl) {
            LayoutControlGroup group = layoutControl.AddGroup();
            group.HeaderButtonsLocation = GroupElementLocation.AfterText;
            group.CustomHeaderButtons.Add(new GroupBoxButton("Push Button", "Find;Size16x16;Office2013", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, -1));
            group.CustomHeaderButtons.Add(new GroupBoxButton("Check Button", "Apply;Size16x16;Office2013", DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, -1));
            group.CustomButtonClick += (s, e) => {
                DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("{0} click", e.Button.Properties.Caption));
            };
            group.CustomButtonChecked += (s, e) => {
                DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("{0} checked", e.Button.Properties.Caption));
            };
            group.CustomButtonUnchecked += (s, e) => {
                DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("{0} Unchecked", e.Button.Properties.Caption));
            };
        }
        [CodeExampleCase("CustomHeaderButtons In Tabbed Group")]
        [CodeExampleHighlightTokens("TabbedControlGroup", "CustomHeaderButton", "ButtonPredefines", "MessageBox", "Enum")]
        [CodeExampleUnderlineTokens("CustomHeaderButtonClick"), CodeExampleVersionID(162)]
        public static void CustomHeaderButtonsInTabbedGroup(LayoutControl layoutControl) {
            TabbedControlGroup tGroup = layoutControl.AddTabbedGroup();
            tGroup.AddTabPage();
            tGroup.AddTabPage();
            tGroup.CustomHeaderButtons.Add(new DevExpress.XtraTab.Buttons.CustomHeaderButton(ButtonPredefines.OK));
            tGroup.CustomHeaderButtons.Add(new DevExpress.XtraTab.Buttons.CustomHeaderButton(ButtonPredefines.Search));
            tGroup.CustomHeaderButtons.Add(new DevExpress.XtraTab.Buttons.CustomHeaderButton(ButtonPredefines.Delete));
            tGroup.CustomHeaderButtonClick += (s, e) => {
                DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("{0} click", Enum.GetName(e.Button.Kind.GetType(), e.Button.Kind)));
            };
        }

    }
    [CodeExampleClass("Flow layout", "SimpleClass.cs")]
    [CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup",
        "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SizeType", "LayoutType", "Size", "LayoutMode", "SizeConstraintsType")]
    public static class FlowLayoutControl {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            LayoutControl layoutControl = new LayoutControl();
            layoutControl.Dock = DockStyle.Fill;
            layoutControl.Parent = sampleHost;
            return new object[] { layoutControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as LayoutControl).Dispose();
        }
        [CodeExampleCase("Simple flow layout")]
        [CodeExampleHighlightTokens("Size")]
        public static void FlowSimpleLayout(LayoutControl layoutControl) {
            // This example creates a flow layout consisting of a few Memo editors.
            // Resize the window to see the flow layout in action.
            LayoutControlGroup group = layoutControl.AddGroup();
            for(int i = 1; i <= 7; i++) {
                string caption = "Memo " + i;
                group.AddItem(caption, new MemoEdit() { Name = caption });
            }
            group.BestFit();
            group.LayoutMode = LayoutMode.Flow;
            foreach(LayoutControlItem item in group.Items) {
                item.Size = new Size(150, 80);
            }
        }
        [CodeExampleCase("Wrap the flow")]
        [CodeExampleHighlightTokens("Size")]
        public static void FlowWrap(LayoutControl layoutControl) {
            // This example creates a flow layout and forcibly wraps the flow after the 2nd item.
            LayoutControlGroup group = layoutControl.AddGroup();
            for(int i = 1; i <= 7; i++) {
                string caption = "Memo " + i;
                group.AddItem(caption, new MemoEdit() { Name = caption });
            }
            group.BestFit();
            group.LayoutMode = LayoutMode.Flow;
            foreach(LayoutControlItem item in group.Items) {
                item.Size = new Size(150, 80);
            }
            group[2].StartNewLine = true;
        }
        [CodeExampleCase("Change FlowDirection")]
        [CodeExampleHighlightTokens("Size", "ILayoutControl", "FlowDirection"), CodeExampleVersionID(162)]
        public static void FlowChangeFlowDirection(LayoutControl layoutControl) {
            LayoutControlGroup group = layoutControl.AddGroup();
            group.AddItem("Memo 1", new MemoEdit() { Name = "Memo 1" });
            group.AddItem("Memo 2", new MemoEdit() { Name = "Memo 2" });
            group.AddItem("Memo 3", new MemoEdit() { Name = "Memo 3" });
            group.AddItem("Memo 4", new MemoEdit() { Name = "Memo 4" });
            group.BestFit();
            group.LayoutMode = LayoutMode.Flow;
            foreach(LayoutControlItem item in group.Items) {
                item.Size = new Size(200, 100);
            }
            group.FlowDirection = FlowDirection.BottomUp;
            //group.FlowDirection = FlowDirection.LeftToRight;
            //group.FlowDirection = FlowDirection.RightToLeft;
            //group.FlowDirection = FlowDirection.TopDown;

            // Enable customization mode to see FlowDirection
            ((ILayoutControl)layoutControl).EnableCustomizationMode = true;
        }
        [CodeExampleCase("Rearrange items")]
        [CodeExampleHighlightTokens("Size", "InsertType")]
        public static void FlowRearrangeItems(LayoutControl layoutControl) {
            // This example shows how to use the Move method to place an item next to another item.
            LayoutControlGroup group = layoutControl.AddGroup();
            group.AddItem("Memo 1", new MemoEdit() { Name = "Memo 1" });
            group.AddItem("Memo 2", new MemoEdit() { Name = "Memo 2" });
            group.AddItem("Memo 3", new MemoEdit() { Name = "Memo 3" });
            group.AddItem("Memo 4", new MemoEdit() { Name = "Memo 4" });
            group.BestFit();
            group.LayoutMode = LayoutMode.Flow;
            foreach(LayoutControlItem item in group.Items) {
                item.Size = new Size(200, 100);
            }
            group[0].Move(group[3], InsertType.Right);
            group[2].Move(group[1], InsertType.Left);
        }
    }
    [CodeExampleClass("Advanced examples", "SimpleClass.cs")]
    [CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup",
        "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SizeType", "LayoutType", "Size", "LayoutMode", "SizeConstraintsType")]
    public static class AdvancedExamplesLayoutControl {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            LayoutControl layoutControl = new LayoutControl();
            layoutControl.Dock = DockStyle.Fill;
            layoutControl.Parent = sampleHost;
            return new object[] { layoutControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as LayoutControl).Dispose();
        }
        [CodeExampleCase("Create custom 'fixed' item in Customization Form", new Type[] { typeof(MyFixedLabelItem), typeof(MyFixedLabelPropertiesWrapper) })]
        [CodeExampleHighlightTokens("Control", "MyFixedLabelItem", "LinkLabelLinkClickedEventArgs", "BasePropertyGridObjectWrapper", "IFixedLayoutControlItem", "ILayoutControl", "Image")]
        [CodeExampleUnderlineTokens("LinkClicked")]
        public static void AdvExamplesCustomFixedItem(LayoutControl layoutControl) {
            // This example adds a custom link item to the Customization Form.
            // You can add this item to the form using drag-and-drop, and change the link text in the Properties grid.
            layoutControl.OptionsCustomizationForm.ShowPropertyGrid = true;
            layoutControl.RegisterCustomPropertyGridWrapper(typeof(MyFixedLabelItem),
                typeof(MyFixedLabelPropertiesWrapper));
            layoutControl.RegisterFixedItemType(typeof(MyFixedLabelItem));
            layoutControl.ShowCustomizationForm();
        }
        [CodeExampleNestedClass("The custom 'fixed' item")]
        public class MyFixedLabelItem : LayoutControlItem, IFixedLayoutControlItem {
            // Must return the name of the item's type
            public override string TypeName { get { return "MyFixedLabelItem"; } }
            string linkCore;
            Control controlCore = null;
            [DefaultValue("")]
            public string Link {
                get { return linkCore; }
                set {
                    if(Link == value) return;
                    this.linkCore = value;
                    OnLinkChanged();
                }
            }
            void label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
                //...
            }
            [DefaultValue("")]
            public override string Text {
                get { return Link; }
                set { Link = value; }
            }
            // This method is called when the Link property is changed.
            // It assigns the new link to the embedded LinkLabel control.
            protected void OnLinkChanged() {
                controlCore.Text = Link;
            }

            // Initialize the item.
            void IFixedLayoutControlItem.OnInitialize() {
                this.linkCore = "www.devexpress.com";
                OnLinkChanged();
                TextVisible = false;
            }
            // Create and return the item's control.
            Control IFixedLayoutControlItem.OnCreateControl() {
                this.controlCore = new LinkLabel();
                ((LinkLabel)controlCore).LinkClicked += label_LinkClicked;
                return controlCore;
            }
            // Destroy the item's control.
            void IFixedLayoutControlItem.OnDestroy() {
                if(controlCore != null) {
                    ((LinkLabel)controlCore).LinkClicked -= label_LinkClicked;
                    controlCore.Dispose();
                    controlCore = null;
                }
            }
            string IFixedLayoutControlItem.CustomizationName { get { return "DevExpress Link"; } }
            Image IFixedLayoutControlItem.CustomizationImage { get { return null; } }
            bool IFixedLayoutControlItem.AllowChangeTextLocation { get { return false; } }
            bool IFixedLayoutControlItem.AllowChangeTextVisibility { get { return false; } }
            bool IFixedLayoutControlItem.AllowClipText { get { return false; } }
            ILayoutControl IFixedLayoutControlItem.Owner { get { return base.Owner; } set { base.Owner = value; } }
        }
        [CodeExampleNestedClass("Specifies which properties to display in the Property Grid")]
        public class MyFixedLabelPropertiesWrapper : BasePropertyGridObjectWrapper {
            protected MyFixedLabelItem Label { get { return WrappedObject as MyFixedLabelItem; } }
            [Description("The link's text")]
            public string Link { get { return Label.Link; } set { Label.Link = value; } }
            public override BasePropertyGridObjectWrapper Clone() {
                return new MyFixedLabelPropertiesWrapper();
            }
        }
        [CodeExampleCase("Provide custom Customization Form and override button actions", new Type[] { typeof(MyCustomizationForm) })]
        [CodeExampleHighlightTokens("MyCustomizationForm", "MyButtonsPanel", "ButtonsPanel", "MessageBox", "CustomizationForm", "EventArgs")]
        [CodeExampleUnderlineTokens("RegisterUserCustomizationForm"), CodeExampleVersionID(162)]
        public static void AdvExamplesCustomCustomizationForm(LayoutControl layoutControl) {
            // This example replaces the standard Customization Form with a custom one.
            // Actions for the Customization Form's buttons are overridden to display message boxes.
            layoutControl.OptionsCustomizationForm.ShowPropertyGrid = true;
            layoutControl.RegisterUserCustomizationForm(typeof(MyCustomizationForm));
            layoutControl.ShowCustomizationForm();
        }
        [CodeExampleNestedClass("")]
        public class MyCustomizationForm : CustomizationForm {
            protected override void OnSaveLayoutButtonClick(object sender, EventArgs e) {
                DevExpress.XtraEditors.XtraMessageBox.Show("'Save Layout' button click");
                base.OnSaveLayoutButtonClick(sender, e);

            }
            protected override void OnLoadLayoutButtonClick(object sender, EventArgs e) {
                DevExpress.XtraEditors.XtraMessageBox.Show("'Load Layout' button click");
                base.OnLoadLayoutButtonClick(sender, e);
            }
            protected override void OnRedoButtonClick(object sender, EventArgs e) {
                DevExpress.XtraEditors.XtraMessageBox.Show("'Redo' button click");
                base.OnRedoButtonClick(sender, e);
            }
            protected override void OnUndoButtonClick(object sender, EventArgs e) {
                DevExpress.XtraEditors.XtraMessageBox.Show("'Undo' button click");
                base.OnUndoButtonClick(sender, e);
            }
        }
        [CodeExampleCase("Display custom properties for items in Customization Form", new Type[] { typeof(MyLayoutControlItemPropertyWrapper) })]
        [CodeExampleHighlightTokens("LayoutControlItemWrapper", "MyLayoutControlItemPropertyWrapper", "AutoCompleteType", "Category", "DefaultValue", "MaskType", "BasePropertyGridObjectWrapper")]
        [CodeExampleUnderlineTokens("RegisterCustomPropertyGridWrapper")]
        public static void AdvExamplesCustomPropertiesInCustomizationForm(LayoutControl layoutControl) {
            // This example shows how to extend properties displayed in the Customization Form's Property Grid when an item is selected.
            // A few mask-specific settings are added to the 'Mask' category.
            layoutControl.OptionsCustomizationForm.ShowPropertyGrid = true;
            TextEdit textEdit1 = new TextEdit() { Name = "TextEdit" };
            LayoutControlItem item = layoutControl.Root.AddItem("Text Edit", textEdit1);
            layoutControl.RegisterCustomPropertyGridWrapper(typeof(LayoutControlItem),
               typeof(MyLayoutControlItemPropertyWrapper));
            layoutControl.ShowCustomizationForm();
            // Select the created item.
            item.Selected = true;
        }
        [CodeExampleNestedClass("")]
        public class MyLayoutControlItemPropertyWrapper : LayoutControlItemWrapper {
            protected TextEdit Editor { get { return Item.Control as TextEdit; } }

            [Category("Mask")]
            [DefaultValue(AutoCompleteType.Default)]
            public AutoCompleteType AutoComplete {
                get {
                    if(Editor != null) return Editor.Properties.Mask.AutoComplete;
                    else return AutoCompleteType.Default;
                }
                set { if(Editor != null) Editor.Properties.Mask.AutoComplete = value; }
            }

            [Category("Mask")]
            [DefaultValue(false)]
            public bool BeepOnError {
                get {
                    if(Editor != null) return Editor.Properties.Mask.BeepOnError;
                    else return false;
                }
                set { if(Editor != null) Editor.Properties.Mask.BeepOnError = value; }
            }

            [Category("Mask")]
            [DefaultValue("")]
            public string EditMask {
                get {
                    if(Editor != null) return Editor.Properties.Mask.EditMask;
                    else return string.Empty;
                }
                set { if(Editor != null) Editor.Properties.Mask.EditMask = value; }
            }

            [Category("Mask")]
            [DefaultValue(true)]
            public bool IgnoreMaskBlank {
                get {
                    if(Editor != null) return Editor.Properties.Mask.IgnoreMaskBlank;
                    else return true;
                }
                set { if(Editor != null) Editor.Properties.Mask.IgnoreMaskBlank = true; }
            }

            [Category("Mask")]
            [DefaultValue(MaskType.None)]
            public MaskType MaskType {
                get {
                    if(Editor != null) return Editor.Properties.Mask.MaskType;
                    else return MaskType.None;
                }
                set { if(Editor != null) Editor.Properties.Mask.MaskType = value; }
            }

            [Category("Mask")]
            [DefaultValue('\0')]
            public char PlaceHolder {
                get {
                    if(Editor != null) return Editor.Properties.Mask.PlaceHolder;
                    else return '\0';
                }
                set { if(Editor != null) Editor.Properties.Mask.PlaceHolder = '\0'; }
            }

            [Category("Mask")]
            [DefaultValue(true)]
            public bool SaveLiteral {
                get {
                    if(Editor != null) return Editor.Properties.Mask.SaveLiteral;
                    else return true;
                }
                set { if(Editor != null) Editor.Properties.Mask.SaveLiteral = value; }
            }

            [Category("Mask")]
            [DefaultValue(true)]
            public bool ShowPlaceHolders {
                get {
                    if(Editor != null) return Editor.Properties.Mask.ShowPlaceHolders;
                    else return true;
                }
                set { if(Editor != null) Editor.Properties.Mask.ShowPlaceHolders = value; }
            }

            [Category("Mask")]
            [DefaultValue(false)]
            public bool UseMaskAsDisplayFormat {
                get {
                    if(Editor != null) return Editor.Properties.Mask.UseMaskAsDisplayFormat;
                    else return false;
                }
                set { if(Editor != null) Editor.Properties.Mask.UseMaskAsDisplayFormat = value; }
            }

            public override BasePropertyGridObjectWrapper Clone() {
                return new MyLayoutControlItemPropertyWrapper();
            }
        }
        [CodeExampleCase("Custom paint group captions", new Type[] { typeof(MyLayoutControl), typeof(MyLayoutControlImplementor), typeof(MySkinGroupObjectPainter), typeof(MyLayoutSkinPaintStyle), })]
        [CodeExampleHighlightTokens("MyLayoutControl", "MyLayoutControlImplementor", "MySkinGroupObjectPainter", "MyLayoutSkinPaintStyle",
            "LayoutControl", "ILayoutControlOwner", "DockStyle", "Color", "GroupObjectInfoArgs", "LayoutOffice2003PaintStyle", "ISupportLookAndFeel", "LayoutWindowsXPPaintStyle",
            "Style3DPaintStyle", "UltraFlatPaintStyle", "FlatPaintStyle", "GroupObjectPainter", "LayoutControlImplementor", "IPanelControlOwner", "ISkinProvider", "SkinGroupObjectPainter", "LayoutSkinPaintStyle")]
        [CodeExampleUnderlineTokens("RegisterCustomPropertyGridWrapper")]
        public static void AdvExamplesCustomPaintGroupCaptions(LayoutControl layoutControl) {
            // This example creates a LayoutControl descendant to override the group caption painting method.
            XtraUserControl sampleHost = layoutControl.Parent as XtraUserControl;
            sampleHost.Controls.Clear();
            MyLayoutControl myLayoutControl1 = new MyLayoutControl();
            myLayoutControl1.Dock = DockStyle.Fill;
            sampleHost.Controls.Add(myLayoutControl1);
            myLayoutControl1.Root.AddGroup("Group 1");
            myLayoutControl1.Root.AddGroup("Group 2");
            myLayoutControl1.BestFit();
        }
        [CodeExampleNestedClass("")]
        public class MySkinGroupObjectPainter : SkinGroupObjectPainter {
            public MySkinGroupObjectPainter(IPanelControlOwner owner, ISkinProvider provider) : base(owner, provider) { }
            protected override void DrawCaption(GroupObjectInfoArgs info) {
                if(info.CaptionBounds.IsEmpty) return;
                info.Cache.FillRectangle(info.Cache.GetSolidBrush(Color.PowderBlue), info.CaptionBounds);
                DrawButton(info);
                DrawVString(info.Cache, info.AppearanceCaption, info.Caption, info.TextBounds, GetRotateAngle(info));
            }

        }
        [CodeExampleNestedClass("")]
        public class MyLayoutControlImplementor : LayoutControlImplementor {
            public MyLayoutControlImplementor(ILayoutControlOwner owner) : base(owner) { }
            protected override void InitializePaintStyles() {
                ISupportLookAndFeel lookAndFeelOwner = owner.GetISupportLookAndFeel();
                if(lookAndFeelOwner != null) {
                    PaintStyles.Add(new LayoutOffice2003PaintStyle(lookAndFeelOwner));
                    PaintStyles.Add(new LayoutWindowsXPPaintStyle(lookAndFeelOwner));
                    //
                    // TODO: Add your owner PaintStyle instead of PaintStyles.Add(new LayoutSkinPaintStyle(lookAndFeelOwner));
                    //
                    PaintStyles.Add(new MyLayoutSkinPaintStyle(lookAndFeelOwner));

                    PaintStyles.Add(new Style3DPaintStyle(lookAndFeelOwner));
                    PaintStyles.Add(new UltraFlatPaintStyle(lookAndFeelOwner));
                    PaintStyles.Add(new FlatPaintStyle(lookAndFeelOwner));
                }
                lookAndFeelOwner = null;
            }
        }
        [CodeExampleNestedClass("")]
        public class MyLayoutSkinPaintStyle : LayoutSkinPaintStyle {
            public MyLayoutSkinPaintStyle(ISupportLookAndFeel lookAndFeelOwner) : base(lookAndFeelOwner) { }

            public override GroupObjectPainter CreateGroupPainter(IPanelControlOwner owner) {
                return new MySkinGroupObjectPainter(owner, LookAndFeel);
            }


        }
        [CodeExampleNestedClass("")]
        public class MyLayoutControl : LayoutControl {
            protected override LayoutControlImplementor CreateILayoutControlImplementorCore() {
                return new MyLayoutControlImplementor(this);
            }
        }


    }
    [CodeExampleClass("DataLayoutControl", "SimpleClass.cs")]
    [CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup",
        "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SizeType", "LayoutType", "Size", "LayoutMode", "SizeConstraintsType")]
    public static class DataLayoutControlExample {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            DataLayoutControl dataLayoutControl = new DataLayoutControl();
            dataLayoutControl.Dock = DockStyle.Fill;
            dataLayoutControl.Parent = sampleHost;
            return new object[] { dataLayoutControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as LayoutControl).Dispose();
        }
        [CodeExampleNestedClass("")]
        public class MyClassWithAttributes {
            public enum GenderEnum { Male, Female }
            //Do not generate a layout item (editor) for the ID field.
            [Display(AutoGenerateField = false)]
            public int ID { get; set; }

            // Specify the display format for the Age field.
            [DisplayFormat(DataFormatString = "d2", ApplyFormatInEditMode = true)]
            public int Age { get; set; }

            // Disable editing.
            [Editable(false)]
            public string Employer { get; set; }

            // Override the display name, specify the order and mark the field as required.
            [Display(Name = "First name", Order = 0), Required]
            public string FirstName { get; set; }

            [Display(Name = "Full name", Order = 2)]
            public string FullName { get { return FirstName + " " + LastName; } }
            [Display(ShortName = "Sex", Order = 3)]
            public GenderEnum Gender { get; set; }
            [Display(Name = "Last name", Order = 1), Required]
            public string LastName { get; set; }

            // The editor will be read-only.
            [ReadOnlyAttribute(true)]
            public string SSN { get; set; }

            // Specify the text displayed when the editor's value is null.
            [DisplayFormat(NullDisplayText = "Department not set")]
            public string Department { get; set; }
        }
        [CodeExampleCase("Simple attributes: names, visibility, order, display format, etc.", new Type[] { typeof(MyClassWithAttributes) })]
        [CodeExampleHighlightTokens("DisplayFormat", "MyClassWithAttributes", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable")]
        [CodeExampleUnderlineTokens("RetrieveFields")]
        public static void DataAnnotationSimpleAttributesExample(DataLayoutControl dataLayoutControl1) {
            // In this example, the DataLayoutControl automatically builds a layout for editing a MyClassWithAttributes object
            // taking into account the DataAnnotations attributes applied to the object's properties
            BindingSource source = new BindingSource();
            source.DataSource = new MyClassWithAttributes();
            dataLayoutControl1.DataSource = source;
            dataLayoutControl1.RetrieveFields();
            dataLayoutControl1.BestFit();
        }
        [CodeExampleNestedClass()]
        public class MyClassWithDataTypeAttributes {
            public enum GenderEnum { Male, Female }
            public bool BoolProperty { get; set; }
            public GenderEnum EnumProperty { get; set; }
            public string StringProperty { get; set; }
            public DateTime DateTimeProperty { get; set; }

            [DataType(DataType.Currency)]
            public decimal CurrencyProperty { get; set; }
            [DataType(DataType.MultilineText)]
            public string MultilineTextProperty { get; set; }
            [DataType(DataType.Password)]
            public string PasswordProperty { get; set; }
            [DataType(DataType.PhoneNumber)]
            public string PhoneNumberProperty { get; set; }
        }
        [CodeExampleCase("Specify editors and their settings", new Type[] { typeof(MyClassWithDataTypeAttributes) })]
        [CodeExampleHighlightTokens("MyClassWithDataTypeAttributes", "BindingSource", "GenderEnum", "DataType", "DateTime", "ReadOnlyAttribute", "Editable")]
        [CodeExampleUnderlineTokens("RetrieveFields")]
        public static void DataAnnotationDataTypeAttributeExample(DataLayoutControl dataLayoutControl1) {
            // In this example, the DataLayoutControl automatically builds a layout for editing a MyClassWithDataTypeAttributes object
            // taking into account the DataAnnotation.DataType attributes applied to the object's properties.
            BindingSource source = new BindingSource();
            source.DataSource = new MyClassWithDataTypeAttributes();
            dataLayoutControl1.DataSource = source;
            dataLayoutControl1.RetrieveFields();
            dataLayoutControl1.BestFit();
        }
        [CodeExampleNestedClass("")]
        public class MyClassSimpleGroupedLayout {
            const string JobGroup = "Job";
            const string ContactGroup = "Contact";
            const string AddressGroup = "Address";
            const string PersonalGroup = "Personal";

            [Display(GroupName = AddressGroup, ShortName = "", Order = 4)]
            public string AddressLine1 { get; set; }
            [Display(GroupName = AddressGroup, ShortName = "")]
            public string AddressLine2 { get; set; }
            [Display(GroupName = PersonalGroup, Name = "Birth date")]
            public DateTime BirthDate { get; set; }
            [Display(GroupName = ContactGroup)]
            public string Email { get; set; }
            [Display(Name = "First name", Order = 0)]
            public string FirstName { get; set; }
            [Display(GroupName = PersonalGroup, Order = 5)]
            public GenderEnum Gender { get; set; }
            [Display(GroupName = JobGroup, Order = 2)]
            public string Group { get; set; }
            [Display(GroupName = JobGroup, Name = "Hire date")]
            public DateTime HireDate { get; set; }
            [Display(Name = "Last name", Order = 1)]
            public string LastName { get; set; }
            [Display(GroupName = ContactGroup, Order = 3), DataType(DataType.PhoneNumber)]
            public string Phone { get; set; }
            [Display(GroupName = JobGroup), DataType(DataType.Currency)]
            public decimal Salary { get; set; }
            [Display(GroupName = JobGroup, Order = 21)]
            public string Title { get; set; }
            public enum GenderEnum { Male, Female }
        }
        [CodeExampleCase("Grouping and order", new Type[] { typeof(MyClassSimpleGroupedLayout) })]
        [CodeExampleHighlightTokens("MyClassSimpleGroupedLayout", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType")]
        [CodeExampleUnderlineTokens("RetrieveFields")]
        public static void DataAnnotationSimpleGroupingExample(DataLayoutControl dataLayoutControl1) {
            // In this example, the DataLayoutControl automatically builds a layout for editing a MyClassSimpleGroupedLayout object.
            // A layout item with an editor is generated for each property of the MyClassSimpleGroupedLayout object.
            // The layout items are placed into regular groups according to the DataAnnotation.Display attributes applied to the properties.
            BindingSource source = new BindingSource();
            source.DataSource = new MyClassSimpleGroupedLayout();
            dataLayoutControl1.DataSource = source;
            dataLayoutControl1.RetrieveFields();
            dataLayoutControl1.BestFit();
        }
        [CodeExampleNestedClass("")]
        public class MyClassTabsLayout {
            // The two items below will be displayed by DataLayoutControl  
            // in a borderless Name group with no title. 
            [Display(GroupName = "<Name|>", Name = "Last name")]
            public string LastName { get; set; }
            [Display(GroupName = "<Name|>", Name = "First name", Order = 0)]
            public string FirstName { get; set; }
            //The four items below will go to a Contact tab within tabbed Tabs group. 
            [Display(GroupName = "{Tabs}/Contact", Order = 2), DataType(DataType.PhoneNumber)]
            public string Phone { get; set; }
            [Display(GroupName = "{Tabs}/Contact", Order = 4), DataType(DataType.EmailAddress)]
            public string Email { get; set; }
            //The two items below will go to the Address group within the Contact tab. 
            [Display(GroupName = "{Tabs}/Contact/Address", ShortName = "")]
            public string AddressLine1 { get; set; }
            [Display(GroupName = "{Tabs}/Contact/Address", ShortName = "")]
            public string AddressLine2 { get; set; }
            //The two items below will go to horizontally oriented Personal group. 
            [Display(GroupName = "Personal-", Name = "Birth date")]
            public DateTime BirthDate { get; set; }
            [Display(GroupName = "Personal-", Order = 3)]
            public GenderEnum Gender { get; set; }
            //The four items below will go to the Job tab of the tabbed Tabs group 
            [Display(GroupName = "{Tabs}/Job", Order = 6)]
            public string Group { get; set; }
            [Display(GroupName = "{Tabs}/Job", Name = "Hire date")]
            public DateTime HireDate { get; set; }
            [Display(GroupName = "{Tabs}/Job"), DataType(DataType.Currency)]
            public decimal Salary { get; set; }
            [Display(GroupName = "{Tabs}/Job", Order = 7)]
            public string Title { get; set; }
            public enum GenderEnum { Male, Female }
        }
        [CodeExampleCase("Advanced grouping", new Type[] { typeof(MyClassTabsLayout) })]
        [CodeExampleHighlightTokens("MyClassTabsLayout", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType")]
        [CodeExampleUnderlineTokens("RetrieveFields")]
        public static void DataAnnotationAdvGroupingExample(DataLayoutControl dataLayoutControl1) {
            // In this example, the DataLayoutControl automatically builds a layout for editing a MyClassTabsLayout object.
            // A layout item with an editor is generated for each property of the MyClassTabsLayout object.
            // The layout items are placed into regular and tabbed groups according to the DataAnnotation.Display attributes applied to the properties.
            BindingSource source = new BindingSource();
            source.DataSource = new MyClassTabsLayout();
            dataLayoutControl1.DataSource = source;
            dataLayoutControl1.RetrieveFields();
            dataLayoutControl1.BestFit();
        }
        [CodeExampleNestedClass("")]
        public class Person {
            const string GroupForName = "<groupForName->";
            const string GroupForPhone = "<groupForPhone->";
            const string GroupForBirthDate = "<groupForBD->";
            [Display(GroupName = GroupForName)]
            public string FirstName { get; set; }
            [Display(GroupName = GroupForName)]
            public string LastName { get; set; }
            public string FullName { get { return FirstName + " " + LastName; } }
            [Display(GroupName = GroupForPhone)]
            public string Phone { get; set; }
            [Display(GroupName = GroupForPhone)]
            public string Email { get; set; }
            [Display(GroupName = GroupForBirthDate)]
            public DateTime BirthDate { get; set; }
            [Display(GroupName = GroupForBirthDate)]
            public GenderEnum Gender { get; set; }
            public enum GenderEnum { Male, Female }
            [Display(GroupName = "Address")]
            public AddressClass AddressInfo { get; set; }
        }
        [CodeExampleNestedClass("")]
        public class AddressClass {
            const string GroupForCity = "<groupForCity->";
            const string GroupForAddressLine = "<groupForAddressLine->";
            const string GroupForLocation = "<groupForLocation->";
            [Display(GroupName = GroupForCity)]
            public string City { get; set; }
            [Display(GroupName = GroupForCity)]
            public string State { get; set; }
            [Display(Name = "Address", GroupName = GroupForAddressLine)]
            public string Line { get; set; }
            [Display(GroupName = GroupForAddressLine)]
            public string ZipCode { get; set; }
            [Display(GroupName = GroupForLocation)]
            public double Latitude { get; set; }
            [Display(GroupName = GroupForLocation)]
            public double Longitude { get; set; }
        }
        [CodeExampleCase("Nested object example", new Type[] { typeof(Person), typeof(AddressClass) })]
        [CodeExampleHighlightTokens("DefaultBoolean", "RetrieveFieldsParameters", "Person", "AddressClass", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType")]
        [CodeExampleUnderlineTokens("RetrieveFields")]
        public static void DataLayoutBindToMultipleClass(DataLayoutControl dataLayoutControl1) {
            // In this example, the DataLayoutControl automatically builds a layout for editing the Person and nested Address objects.
            // To edit the nested Address object's properties, a group of items is automatically generated.
            // The RetrieveFields method is called with the DataSourceUpdateMode parameter set to 'OnPropertyChanged'.
            // This causes data to be posted to the underlying object immediately on text entering.
            BindingSource source = new BindingSource();
            source.DataSource = new Person();
            dataLayoutControl1.DataSource = source;
            dataLayoutControl1.AllowGeneratingNestedGroups = DefaultBoolean.True;
            RetrieveFieldsParameters parameters = new RetrieveFieldsParameters();
            parameters.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            dataLayoutControl1.RetrieveFields(parameters);
        }
        [CodeExampleCase("Customize properties of auto-generated Layout items and controls", new Type[] { typeof(Person), typeof(AddressClass) })]
        [CodeExampleHighlightTokens("Color", "DefaultBoolean", "RetrieveFieldsParameters", "Person", "AddressClass", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType")]
        [CodeExampleUnderlineTokens("FieldRetrieved")]
        public static void DataLayoutControlFieldRetrieved(DataLayoutControl dataLayoutControl1) {
            //In this example, the FieldRetrieved event is handled to customize auto-generated controls' properties.
            BindingSource source = new BindingSource();
            source.DataSource = new Person();
            dataLayoutControl1.AllowGeneratingNestedGroups = DefaultBoolean.True;
            dataLayoutControl1.DataSource = source;
            dataLayoutControl1.FieldRetrieved += (s, e) => {
                if(e.FieldName == "FirstName" || e.FieldName == "LastName") {
                    e.Control.BackColor = Color.GreenYellow;
                }
            };
            dataLayoutControl1.RetrieveFields();
        }
        [CodeExampleCase("Customize binding info and editor type", new Type[] { typeof(Person), typeof(AddressClass) })]
        [CodeExampleHighlightTokens("DataSourceUpdateMode", "ComboBoxEdit", "DefaultBoolean", "RetrieveFieldsParameters", "Person", "AddressClass", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType")]
        [CodeExampleUnderlineTokens("FieldRetrieving")]
        public static void DataLayoutControlFieldRetrieving(DataLayoutControl dataLayoutControl1) {
            //In this example, the FieldRetrieving event is handled to customize the binding info and editor type.
            BindingSource source = new BindingSource();
            source.DataSource = new Person();
            dataLayoutControl1.DataSource = source;
            dataLayoutControl1.AllowGeneratingNestedGroups = DefaultBoolean.True;
            dataLayoutControl1.FieldRetrieving += (s, e) => {
                if(e.FieldName == "AddressInfo.ZipCode") e.EditorType = typeof(ComboBoxEdit);
                e.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
                e.Handled = true;
            };
            dataLayoutControl1.RetrieveFields();
        }
        [CodeExampleNestedClass("")]
        public class CollectionData {
            public List<Person> Employees { get; set; }
            public bool BoolProperty { get; set; }
            public string StringProperty { get; set; }
        }
        [CodeExampleCase("Generate CollectionProperties", new Type[] { typeof(CollectionData), typeof(Person), typeof(AddressClass) })]
        [CodeExampleHighlightTokens("DisplayFormat", "CollectionData", "BindingSource", "Person", "List", "Display")]
        [CodeExampleUnderlineTokens("AllowGeneratingCollectionProperties"), CodeExampleVersionID(162)]
        public static void DataLayoutControlCollectionProperties(DataLayoutControl dataLayoutControl1) {
            BindingSource source = new BindingSource();
            source.DataSource = new CollectionData() { Employees = new List<Person>() { new Person() } };
            dataLayoutControl1.AllowGeneratingCollectionProperties = DefaultBoolean.True;
            dataLayoutControl1.DataSource = source;
            dataLayoutControl1.RetrieveFields();
            dataLayoutControl1.BestFit();
        }
    }
}
