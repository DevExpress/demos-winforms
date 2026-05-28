using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.Utils.Filtering;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;

namespace DevExpress.XtraEditors.Demos.CodeExamples {
    [CodeExampleClass("Filtering UI Editors", "Filtering.cs")]
    public static class FilteringUIEditors {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MemoEdit memo = new MemoEdit();
            memo.Dock = DockStyle.Bottom;
            memo.ReadOnly = true;
            memo.Height = 60;

            AccordionControl accordion = new AccordionControl();
            accordion.Dock = DockStyle.Fill;
            accordion.ScrollBarMode = ScrollBarMode.Touch;

            FilteringUIContext context = new FilteringUIContext();
            context.Control = accordion;

            accordion.Parent = sampleHost;
            memo.Parent = sampleHost;
            sampleHost.Tag = context;
            return new object[] { context, accordion, memo };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            FilteringUIContext context = sampleHost.Tag as FilteringUIContext;
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Range", new Type[] { typeof(FilteringModel_Range) })]
        public static void RangeEditors(FilteringUIContext context, AccordionControl accordion, MemoEdit memo) {
            // Setup filtering model
            context.ModelType = typeof(FilteringModel_Range);
            // Retrieve the UI editors
            context.RetrieveFields();
            // Setup FilterCriteria displaying
            context.FilterCriteriaChanged += (s, e) =>
            {
                memo.Text = !ReferenceEquals(e.FilterCriteria, null) ? e.FilterCriteria.ToString() : null;
            };
        }
        [CodeExampleCase("Lookup", new Type[] { typeof(FilteringModel_Lookup), typeof(Category) })]
        public static void LookupEditors(FilteringUIContext context, AccordionControl accordion, MemoEdit memo) {
            // Setup filtering model
            context.ModelType = typeof(FilteringModel_Lookup);
            // Setup data for Lookups
            var categories = new System.Collections.Generic.List<Category>();
            for(int i = 0; i < 18; i++)
                categories.Add(new Category() { Id = i, Name = "Category " + i.ToString() });
            // Setup events for providing data
            context.QueryLookupData += (s, e) =>
            {
                e.Result.DataSource = categories;
            };
            // Retrieve the UI editors
            context.RetrieveFields();
            // Setup FilterCriteria displaying
            context.FilterCriteriaChanged += (s, e) =>
            {
                memo.Text = !ReferenceEquals(e.FilterCriteria, null) ? e.FilterCriteria.ToString() : null;
            };
        }
        [CodeExampleCase("Boolean Choice", new Type[] { typeof(FilteringModel_BooleanChoice) })]
        public static void BooleanChoiceEditors(FilteringUIContext context, AccordionControl accordion, MemoEdit memo) {
            // Setup filtering model
            context.ModelType = typeof(FilteringModel_BooleanChoice);
            // Retrieve the UI editors
            context.RetrieveFields();
            // Setup FilterCriteria displaying
            context.FilterCriteriaChanged += (s, e) =>
            {
                memo.Text = !ReferenceEquals(e.FilterCriteria, null) ? e.FilterCriteria.ToString() : null;
            };
        }
        [CodeExampleCase("Enum Choice", new Type[] { typeof(FilteringModel_EnumChoice) })]
        public static void EnumChoiceEditors(FilteringUIContext context, AccordionControl accordion, MemoEdit memo) {
            // Setup filtering model
            context.ModelType = typeof(FilteringModel_EnumChoice);
            // Retrieve the UI editors
            context.RetrieveFields();
            // Setup FilterCriteria displaying
            context.FilterCriteriaChanged += (s, e) =>
            {
                memo.Text = !ReferenceEquals(e.FilterCriteria, null) ? e.FilterCriteria.ToString() : null;
            };
        }
        //
        [CodeExampleNestedClass]
        public class FilteringModel_Range {
            [Display(Name = "Price (Default Editor)"), DataType(DataType.Currency)]
            [FilterRange(0, 1000)]
            public decimal Price { get; set; }

            [Display(Name = "Weight (Range Editor)")]
            [FilterRange(100.0, 250.0, 160.0, EditorType = RangeUIEditorType.Range)]
            public double Weight { get; set; }

            [Display(Name = "Capacity (Spin Editor)")]
            [FilterRange(200, 6800, EditorType = RangeUIEditorType.Spin)]
            public int Capacity { get; set; }

            [Display(Name = "Performance (Text Editor)")]
            [FilterRange(100f, null)]
            public float Performance { get; set; }
        }

        [CodeExampleNestedClass]
        public class FilteringModel_Lookup {
            [Display(Name = "Category (Default Editor)")]
            [FilterLookup(10, ValueMember = "Id", DisplayMember = "Name")]
            public int CategoryId1 { get; set; }

            [Display(Name = "Category (DropDown Editor)")]
            [FilterLookup(ValueMember = "Id", DisplayMember = "Name", EditorType = LookupUIEditorType.DropDown)]
            public int CategoryId2 { get; set; }

            [Display(Name = "Category (Token Editor)")]
            [FilterLookup(ValueMember = "Id", DisplayMember = "Name", EditorType = LookupUIEditorType.TokenBox)]
            public int CategoryId3 { get; set; }
        }
        [CodeExampleNestedClass]
        public class Category {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        [CodeExampleNestedClass]
        public class FilteringModel_BooleanChoice {
            [Display(ShortName = "Modern (Default Editor)", Name = "Modern")]
            public bool Modern { get; set; }

            [Display(ShortName = "Impressive (Toggle Editor)", Name = "Impressive")]
            [FilterBooleanChoice(false, EditorType = BooleanUIEditorType.Toggle)]
            public bool Impressive { get; set; }

            [Display(Name = "Good (DropDown Editor)")]
            [FilterBooleanChoice(EditorType = BooleanUIEditorType.DropDown)]
            public bool Good { get; set; }

            [Display(Name = "Bad (List Editor)")]
            [FilterBooleanChoice(EditorType = BooleanUIEditorType.List)]
            public bool Bad { get; set; }
        }

        [CodeExampleNestedClass]
        public class FilteringModel_EnumChoice {
            [Display(Name = "Value (Default Editor)")]
            [FilterEnumChoice(UseSelectAll = true)]
            public SomeEnum Value { get; set; }

            [Display(Name = "Flags (Default Editor)")]
            [FilterEnumChoice]
            public SomeFlagEnum Flags { get; set; }

            [Display(Name = "Count (DropDown Editor)"), EnumDataType(typeof(SomeEnum))]
            [FilterEnumChoice(EditorType = LookupUIEditorType.DropDown)]
            public int Count { get; set; }

            [Display(Name = "Bits (Token Editor)"), EnumDataType(typeof(SomeFlagEnum))]
            [FilterEnumChoice(EditorType = LookupUIEditorType.TokenBox)]
            public int Bits { get; set; }

            public enum SomeEnum {
                Zero, One, Two, Three, Four, Five
            }
            [Flags]
            public enum SomeFlagEnum {
                FirstBit = 0x01,
                SecondBit = 0x02,
                ThirdBit = 0x04,
            }
        }
    }
}
