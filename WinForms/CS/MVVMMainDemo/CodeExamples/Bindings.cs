using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.MVVM.Demos.CodeExamples {
    [CodeExampleClass("Bindable Properties", "Bindings.cs")]
    [CodeExampleHighlightTokens("MVVMContext", "ViewModelSource")]
    [CodeExampleUnderlineTokens("SetBinding", "RaisePropertyChanged")]
    public static class BindindableProperties {
        static BindindableProperties() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            TextEdit editor = new TextEdit();
            editor.Dock = DockStyle.Top;
            editor.Properties.NullValuePrompt = "Please, enter some text...";

            LabelControl label = new LabelControl();
            label.AutoSizeMode = LabelAutoSizeMode.None;
            label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            label.Dock = DockStyle.Fill;

            label.Parent = sampleHost;
            editor.Parent = sampleHost;
            return new object[] { mvvmContext, editor, label };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Two-way and One-way binding", new Type[] { typeof(ViewModel) }, typeof(ViewModel))]
        public static void SetBinding(MVVMContext mvvmContext, TextEdit editor, LabelControl label) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(ViewModel);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModel>();
            // Two-way binding for the Text property for editor (editing allowed)
            fluent.SetBinding(editor, ed => ed.EditValue, x => x.Text);
            // One-way binding for the Title property for label
            fluent.SetBinding(label, lbl => lbl.Text, x => x.Title);
        }
        [CodeExampleCase("Two-way and One-way binding to nested objects", new Type[] { typeof(ViewModelWithChild), typeof(ViewModel) }, typeof(ViewModelWithChild))]
        public static void SetBindingToNestedObjects(MVVMContext mvvmContext, TextEdit editor, LabelControl label) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(ViewModelWithChild);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModelWithChild>();
            // Two-way binding for the Child.Text property for editor (editing allowed)
            fluent.SetBinding(editor, ed => ed.EditValue, x => x.Child.Text);
            // One-way binding for the Child.Title property for label
            fluent.SetBinding(label, lbl => lbl.Text, x => x.Child.Title);
        }
        [CodeExampleCase("Two-way and One-way binding to lecagy view-models", new Type[] { typeof(ObjectWithTextAndTitle) }, typeof(ObjectWithTextAndTitle))]
        public static void SetBindingToLecacyViewModels(MVVMContext mvvmContext, TextEdit editor, LabelControl label) {
            var legacyViewModel = new ObjectWithTextAndTitle("I'm Legacy ViewModel");
            // Initialize the MVVMContext with the specific ViewModel's instance
            mvvmContext.SetViewModel(typeof(ObjectWithTextAndTitle), legacyViewModel);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ObjectWithTextAndTitle>();
            // Two-way binding for the Text property for editor (editing allowed)
            fluent.SetBinding(editor, ed => ed.EditValue, x => x.Text);
            // One-way binding for the Title property for label
            fluent.SetBinding(label, lbl => lbl.Text, x => x.Title);
        }
        [CodeExampleNestedClass("POCO View Model provides out-of-the-box support of the INotifyPropertyChanged.")]
        public class ViewModel {
            // Bindable property will be created from this property(public, virtual and auto-implemented) 
            // The PropertyChanged event notification be fired automatically on changes
            public virtual string Text {
                get;
                set;
            }
            // Changed callback (called automatically for bindable property)
            protected void OnTextChanged() {
                // force updating binding targets for the Title property
                this.RaisePropertyChanged(x => x.Title);
            }
            // Simple property (without auto-notify and callbacks)
            public string Title {
                get {
                    if(Text == null)
                        return "Title: (Null)";
                    if(Text.Length == 0)
                        return "Title: (Empty)";
                    if(string.IsNullOrWhiteSpace(Text))
                        return "Title: (Whitespace)";
                    return "Title: " + Text;
                }
            }
        }
        [CodeExampleNestedClass]
        public class ViewModelWithChild {
            public ViewModelWithChild() {
                // Create Nested ViewModel as POCO-ViewModel
                Child = ViewModelSource.Create<ViewModel>();
            }
            // Nested ViewModel
            public ViewModel Child {
                get;
                private set;
            }
        }
        [CodeExampleNestedClass]
        public class ObjectWithTextAndTitle {
            string textCore;
            public ObjectWithTextAndTitle(string title) {
                this.textCore = title;
            }
            public string Text {
                get { return textCore; }
                set {
                    if(textCore == value) return;
                    textCore = value;
                    OnTextChanged();
                }
            }
            protected virtual void OnTextChanged() {
                RaiseTextChanged();
                RaiseTitleChanged();
            }
            public string Title {
                get {
                    if(Text == null)
                        return "Title: (Null)";
                    if(Text.Length == 0)
                        return "Title: (Empty)";
                    if(string.IsNullOrWhiteSpace(Text))
                        return "Title: (Whitespace)";
                    return "Title: " + Text;
                }
            }
            public event EventHandler TextChanged;
            protected void RaiseTextChanged() {
                var handler = TextChanged;
                if(handler != null) handler(this, EventArgs.Empty);
            }
            public event EventHandler TitleChanged;
            protected void RaiseTitleChanged() {
                var handler = TitleChanged;
                if(handler != null) handler(this, EventArgs.Empty);
            }
        }
    }

    [CodeExampleClass("Bindable Properties and Dependencies", "Bindings.cs")]
    [CodeExampleHighlightTokens("BindableProperty", "DependsOnProperties")]
    [CodeExampleUnderlineTokens("SetBinding", "RaisePropertyChanged")]
    public static class BindindablePropertiesDependencies {
        static BindindablePropertiesDependencies() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            TextEdit editor1 = new TextEdit();
            editor1.Dock = DockStyle.Top;
            editor1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            editor1.Properties.Mask.EditMask = "n0";
            editor1.Properties.Mask.UseMaskAsDisplayFormat = true;

            TextEdit editor2 = new TextEdit();
            editor2.Dock = DockStyle.Top;
            editor2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            editor2.Properties.Mask.EditMask = "n0";
            editor2.Properties.Mask.UseMaskAsDisplayFormat = true;

            LabelControl resultLabel = new LabelControl();
            resultLabel.AutoSizeMode = LabelAutoSizeMode.None;
            resultLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resultLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resultLabel.Dock = DockStyle.Fill;

            resultLabel.Parent = sampleHost;
            editor1.Parent = sampleHost;
            editor2.Parent = sampleHost;
            return new object[] { mvvmContext, editor1, editor2, resultLabel };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Conventional dependencies", new Type[] { typeof(MultViewModel) }, typeof(MultViewModel))]
        public static void ConventionalDependencies(MVVMContext mvvmContext, TextEdit editor1, TextEdit editor2, LabelControl resultLabel) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(MultViewModel);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<MultViewModel>();
            // Two-way bindings for the operands (editing allowed)
            fluent.SetBinding(editor1, e => e.EditValue, x => x.Operand1);
            fluent.SetBinding(editor2, e => e.EditValue, x => x.Operand2);
            // One-way binding for the ResultText
            fluent.SetBinding(resultLabel, l => l.Text, x => x.ResultText);
        }
        [CodeExampleCase("Declarative dependencies (DependsOn)", new Type[] { typeof(MultViewModel_DependsOn) }, typeof(MultViewModel_DependsOn))]
        public static void DeclarativeDependencies(MVVMContext mvvmContext, TextEdit editor1, TextEdit editor2, LabelControl resultLabel) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(MultViewModel_DependsOn);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<MultViewModel_DependsOn>();
            // Two-way bindings for the operands (editing allowed)
            fluent.SetBinding(editor1, e => e.EditValue, x => x.Operand1);
            fluent.SetBinding(editor2, e => e.EditValue, x => x.Operand2);
            // One-way binding for the ResultText
            fluent.SetBinding(resultLabel, l => l.Text, x => x.ResultText);
        }
        [CodeExampleCase("Attributes-driven dependencies", new Type[] { typeof(SumViewModel) }, typeof(SumViewModel))]
        public static void AttributesDrivenDependencies(MVVMContext mvvmContext, TextEdit editor1, TextEdit editor2, LabelControl resultLabel) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(SumViewModel);
            // initialize the Fluent API
            var fluent = mvvmContext.OfType<SumViewModel>();
            // Two-way bindings for the operands (editing allowed)
            fluent.SetBinding(editor1, e => e.EditValue, x => x.Operand1);
            fluent.SetBinding(editor2, e => e.EditValue, x => x.Operand2);
            // One-way binding for the ResultText
            fluent.SetBinding(resultLabel, l => l.Text, x => x.ResultText);
        }
        [CodeExampleCase("Metadata-driven dependencies", new Type[] { typeof(SumViewModel_MetaPOCO) }, typeof(SumViewModel_MetaPOCO))]
        public static void MetadataDrivenDependencies(MVVMContext mvvmContext, TextEdit editor1, TextEdit editor2, LabelControl resultLabel) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(SumViewModel_MetaPOCO);
            // initialize the Fluent API
            var fluent = mvvmContext.OfType<SumViewModel_MetaPOCO>();
            // Two-way bindings for the operands (editing allowed)
            fluent.SetBinding(editor1, e => e.EditValue, x => x.Operand1);
            fluent.SetBinding(editor2, e => e.EditValue, x => x.Operand2);
            // One-way binding for the ResultText
            fluent.SetBinding(resultLabel, l => l.Text, x => x.ResultText);
        }
        [CodeExampleNestedClass("POCO View Model provides out-of-the-box support of the OnXXXChanging/OnXXXChanged callbacks.")]
        public class MultViewModel {
            public MultViewModel() {
                Operand1 = 2;
                Operand2 = 3;
            }
            public virtual int Operand1 { get; set; }
            public virtual int Operand2 { get; set; }
            public virtual int Result { get; set; }
            public virtual string ResultText { get; set; }
            // OnChanged callback will be created for the Operand1 property from this method.
            protected void OnOperand1Changed() {
                // The Result depends on Operand1
                UpdateResult();
            }
            // OnChanged callback will be created for the Operand2 property from this method.
            protected void OnOperand2Changed() {
                // The Result depends on Operand2
                UpdateResult();
            }
            // OnChanged callback will be created for the Result property from this method.
            protected void OnResultChanged() {
                // The ResultText depends on Result
                UpdateResultText();
            }
            void UpdateResult() {
                Result = Operand1 * Operand2;
            }
            void UpdateResultText() {
                ResultText = string.Format("The result of operands multiplication is: {0:n0}", Result);
            }
        }
        [CodeExampleNestedClass("POCO View Model supports the DependsOnProperties attribute.")]
        public class MultViewModel_DependsOn {
            public MultViewModel_DependsOn() {
                Operand1 = 2;
                Operand2 = 3;
            }
            public virtual int Operand1 { get; set; }
            public virtual int Operand2 { get; set; }
            // using the DependsOnProperties attribute to setup dependencies
            [DependsOnProperties("Operand1", "Operand2")]
            public string ResultText {
                get { return string.Format("The result of operands multiplication is: {0:n0}", Operand1 * Operand2); }
            }
        }
        [CodeExampleNestedClass("POCO View Model supports attributes and extension-methods for different purposes.")]
        public class SumViewModel {
            public SumViewModel() {
                Operand1 = 2;
                Operand2 = 2;
            }
            // using the BindableProperty attribute to setup dependency
            [BindableProperty(OnPropertyChangedMethodName = "NotifyResultAndResultTextChanged")]
            public virtual int Operand1 { get; set; }
            // using the BindableProperty attribute to setup dependency
            [BindableProperty(OnPropertyChangedMethodName = "NotifyResultAndResultTextChanged")]
            public virtual int Operand2 { get; set; }
            // We will raise change-notification for this property manually
            public int Result {
                get { return Operand1 + Operand2; }
            }
            // We will raise change-notification for this property manually
            public string ResultText {
                get { return string.Format("The result of operands summarization is: {0:n0}", Result); }
            }
            protected void NotifyResultAndResultTextChanged() {
                this.RaisePropertyChanged(x => x.Result); // change-notification for the Result
                this.RaisePropertyChanged(x => x.ResultText); // change-notification for the ResultText
            }
        }
        [CodeExampleNestedClass("POCO View Model properties supports Fluent Meta-declarations via Metadata-types.")]
        [System.ComponentModel.DataAnnotations.MetadataType(typeof(Metadata))]
        public class SumViewModel_MetaPOCO {
            public SumViewModel_MetaPOCO() {
                Operand1 = 2;
                Operand2 = 2;
                Result = 4;
            }
            // This property will be declared as Non-Bindable property via Fluent API
            public virtual int Result { get; set; }
            // This property will be declared as Bindable property via Fluent API
            public virtual int Operand1 { get; set; }
            // This property will be declared as Bindable property via Fluent API
            public virtual int Operand2 { get; set; }
            // We will raise change-notification for this property manually
            public string ResultText {
                get { return string.Format("The result of operands summarization is: {0:n0}", Result); }
            }
            // We will declare this method as OnChanged callback for the Operand1 and the Operand2 properties
            protected void NotifyResultAndResultTextChanged() {
                Result = Operand1 + Operand2;
                this.RaisePropertyChanged(x => x.Result); // change-notification for the Result
                this.RaisePropertyChanged(x => x.ResultText); // change-notification for the ResultText
            }
            // Metadata class for the SumViewModel_MetaPOCO
            public class Metadata : IMetadataProvider<SumViewModel_MetaPOCO> {
                void IMetadataProvider<SumViewModel_MetaPOCO>.BuildMetadata(MetadataBuilder<SumViewModel_MetaPOCO> builder) {
                    builder.Property(x => x.Result)
                        .DoNotMakeBindable();
                    builder.Property(x => x.Operand1).
                        OnPropertyChangedCall(x => x.NotifyResultAndResultTextChanged());
                    builder.Property(x => x.Operand2).
                        OnPropertyChangedCall(x => x.NotifyResultAndResultTextChanged());
                }
            }
        }
    }

    [CodeExampleClass("Bindable Properties and Triggers", "Bindings.cs")]
    [CodeExampleUnderlineTokens("SetTrigger")]
    public static class BindindablePropertiesTriggers {
        static BindindablePropertiesTriggers() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;
            mvvmContext.ViewModelType = typeof(ViewModel);

            CheckEdit checkEdit = new CheckEdit();
            checkEdit.Dock = DockStyle.Top;
            checkEdit.Text = "IsActive";

            LabelControl label = new LabelControl();
            label.Text = "Current state (Active or Inactive)";
            label.AutoSizeMode = LabelAutoSizeMode.None;
            label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            label.Dock = DockStyle.Fill;

            label.Parent = sampleHost;
            checkEdit.Parent = sampleHost;
            return new object[] { mvvmContext, checkEdit, label };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Using triggers for updating UI", new Type[] { typeof(ViewModel) })]
        public static void SetTrigger(MVVMContext mvvmContext, CheckEdit checkEdit, LabelControl label) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModel>();
            // Two-way binding for the IsActive property (editing allowed)
            fluent.SetBinding(checkEdit, c => c.Checked, x => x.IsActive);
            // Property-change trigger for the IsActive property
            fluent.SetTrigger(x => x.IsActive, (active) => {
                if(active)
                    label.Appearance.BackColor = Color.LightPink;
                else
                    label.Appearance.BackColor = Color.Empty;
            });
        }
        [CodeExampleNestedClass("We will track the IsActive property changing in UI")]
        public class ViewModel {
            public virtual bool IsActive { get; set; }
        }
    }

    [CodeExampleClass("Entity Bindings", "Bindings.cs")]
    [CodeExampleHighlightTokens("Entity", "Binding")]
    [CodeExampleUnderlineTokens("SetObjectDataSourceBinding", "DataBindings")]
    public static class EntityBindings {
        static EntityBindings() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;
            mvvmContext.ViewModelType = typeof(ViewModel);

            SimpleButton createBtn = new SimpleButton();
            createBtn.Text = "Create a new Entity";
            createBtn.Dock = DockStyle.Top;
            createBtn.Parent = sampleHost;

            TextEdit textEditor = new TextEdit();
            textEditor.Dock = DockStyle.Top;
            textEditor.Parent = sampleHost;

            TextEdit idEditor = new TextEdit();
            idEditor.ReadOnly = true;
            idEditor.Dock = DockStyle.Top;
            idEditor.Parent = sampleHost;

            return new object[] { mvvmContext, idEditor, textEditor, createBtn };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        //
        [CodeExampleNestedClass]
        public class Entity {
            public Entity(int id) {
                this.ID = id;
                this.Text = "Entity " + id.ToString();
            }
            public int ID { get; private set; }
            public string Text { get; set; }
        }
        //
        [CodeExampleCase("Data-Binding of Entity properties", new Type[] { typeof(ViewModel), typeof(Entity) })]
        public static void ObjectDataSourceBinding(MVVMContext mvvmContext, TextEdit idEditor, TextEdit textEditor, SimpleButton createBtn) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModel>();
            // Creating the BindingSource
            BindingSource entityBindingSource = new BindingSource();
            entityBindingSource.DataSource = typeof(Entity);
            // Creating the Data-bindings for editors
            idEditor.DataBindings.Add(new Binding("EditValue", entityBindingSource, "ID"));
            textEditor.DataBindings.Add(new Binding("EditValue", entityBindingSource, "Text", true, DataSourceUpdateMode.OnPropertyChanged));
            // Two-way binding of the Entity property onto the BindingSource.DataSource
            fluent.SetObjectDataSourceBinding(entityBindingSource, x => x.Entity, x => x.Update);
            // Bind the Create command which creates a new Entity
            fluent.BindCommand(createBtn, x => x.Create);
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            static int id = 0;
            public ViewModel() {
                Create();
            }
            public virtual Entity Entity {
                get;
                set;
            }
            // Create a new entity
            public void Create() {
                Entity = new Entity(id++);
            }
            // Update command
            public void Update() {
                var msgService = this.GetService<IMessageBoxService>();
                msgService.ShowMessage("Entity was updated from the UI!");
            }
        }
    }

    [CodeExampleClass("Collection Bindings", "Bindings.cs")]
    [CodeExampleHighlightTokens("Entity")]
    [CodeExampleUnderlineTokens("SetItemsSourceBinding")]
    public static class CollectionBindings {
        static CollectionBindings() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;
            mvvmContext.ViewModelType = typeof(ViewModel);

            ImageListBoxControl itemsListBox = new ImageListBoxControl();
            itemsListBox.Dock = DockStyle.Top;
            itemsListBox.Parent = sampleHost;

            SimpleButton removeButton = new SimpleButton();
            removeButton.Dock = DockStyle.Top;
            removeButton.Text = "Remove";
            removeButton.Parent = sampleHost;

            SimpleButton addButton = new SimpleButton();
            addButton.Dock = DockStyle.Top;
            addButton.Text = "Add";
            addButton.Parent = sampleHost;

            return new object[] { mvvmContext, addButton, removeButton, itemsListBox };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Binding of Items collection", new Type[] { typeof(ViewModel), typeof(Entity) })]
        public static void CollectionDataBinding(MVVMContext mvvmContext, SimpleButton addButton, SimpleButton removeButton, ImageListBoxControl listBox) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModel>();
            // Populating the ListBox with items, generated from the Entites collection
            fluent.SetItemsSourceBinding(
                listBox,            // Target
                lb => lb.Items,     // Items Selector 
                x => x.Entities,    // Source Selector  
                (item, entity) => object.Equals(item.Value, entity),    // Match Expression - checks whether or not this item matches the current entity
                entity => new ImageListBoxItem(entity),                 // Create Expression - creates a new item based on the current entity
                null,                                                   // Dispose Expression - disposes of a target element when its related source collection record is removed
                (item, entity) => {                                     // Change Expression - modifies existing items
                    ((ImageListBoxItem)item).Description = entity.Text;
                });
            // Binding the SelectedValue property to the currently selected entity
            fluent.SetBinding(listBox, lb => lb.SelectedValue, x => x.SelectedEntity);
            // Command bindings
            fluent.BindCommand(addButton, x => x.Add);
            fluent.BindCommand(removeButton, x => x.Remove);
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            public ViewModel() {
                Entities = new ObservableCollection<Entity>() {
                    new Entity(0),
                    new Entity(1)
                };
            }
            public virtual Entity SelectedEntity {
                get;
                set;
            }
            public virtual ObservableCollection<Entity> Entities {
                get;
                set;
            }
            protected void OnSelectedEntityChanged() {
                this.RaiseCanExecuteChanged(x => x.Remove());
            }
            protected void OnEntitiesChanged() {
                SelectedEntity = Entities.FirstOrDefault();
            }
            // Add a new item
            public void Add() {
                Entities.Add(new Entity(Entities.Count));
            }
            // Remove the selected item
            public void Remove() {
                Entities.Remove(SelectedEntity);
            }
            public bool CanRemove() {
                return SelectedEntity != null;
            }
        }
        [CodeExampleNestedClass]
        public class Entity {
            public Entity(int id) {
                this.ID = id;
                this.Text = "Entity " + id.ToString();
            }
            public int ID { get; private set; }
            public string Text { get; set; }
        }
    }

    [CodeExampleClass("Binding Capabilities (Formatting)", "Bindings.cs"), CodeExampleVersionID(162)]
    [CodeExampleUnderlineTokens("SetBinding")]
    public static class BindingFeatures_Formatting {
        static BindingFeatures_Formatting() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;
            mvvmContext.ViewModelType = typeof(ViewModel);

            LabelControl label = new LabelControl();
            label.Dock = DockStyle.Top;

            SpinEdit editor = new SpinEdit();
            editor.Properties.IsFloatValue = false;
            editor.Dock = DockStyle.Top;

            SimpleButton resetBtn = new SimpleButton();
            resetBtn.Dock = DockStyle.Top;
            resetBtn.Text = "Reset Price";

            resetBtn.Parent = sampleHost;
            editor.Parent = sampleHost;
            label.Parent = sampleHost;
            return new object[] { mvvmContext, label, editor, resetBtn };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Binding with Formatting", new Type[] { typeof(ViewModel) })]
        public static void FormatBinding(MVVMContext mvvmContext, LabelControl label, SpinEdit editor, SimpleButton resetBtn) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModel>();
            // One-way binding for the Price property with formatting (display as currency)
            fluent.SetBinding(label, l => l.Text, x => x.Price, "Price: {0:C}");
            // Two-way binding for the Price property (editing allowed)
            fluent.SetBinding(editor, e => e.EditValue, x => x.Price);
            // Binding for the Reset command
            fluent.BindCommand(resetBtn, x => x.Reset);
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            public ViewModel() {
                Reset();
            }
            public virtual int Price { get; set; }
            public void Reset() {
                Price = 175;
            }
        }
    }

    [CodeExampleClass("Binding Capabilities (Converters)", "Bindings.cs")]
    [CodeExampleUnderlineTokens("SetBinding")]
    public static class BindingFeatures_Converters {
        static BindingFeatures_Converters() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;
            mvvmContext.ViewModelType = typeof(ViewModel);

            TrackBarControl trackBar = new TrackBarControl();
            trackBar.Dock = DockStyle.Top;
            trackBar.Properties.Minimum = 0;
            trackBar.Properties.Maximum = 100;

            TextEdit editor = new TextEdit();
            editor.Dock = DockStyle.Top;
            editor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            editor.Properties.Mask.EditMask = "##0";
            editor.Properties.Mask.UseMaskAsDisplayFormat = true;

            editor.Parent = sampleHost;
            trackBar.Parent = sampleHost;
            return new object[] { mvvmContext, trackBar, editor };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Binding via Default Converters", new Type[] { typeof(ViewModel) })]
        public static void ConvertBindingFluentAPI_DefaultConverter(MVVMContext mvvmContext, TrackBarControl trackBar, TextEdit editor) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModel>();
            // Two-way binding for two integer properties 'Value' and 'Progress'. 
            // No conversion needed (editing allowed).
            fluent.SetBinding(trackBar, t => t.Value, x => x.Progress);
            // Two-way binding for the string 'Text' property to the integer 'Progress'. 
            // Values are automatically converted to/from an appropriate type (editing allowed).
            fluent.SetBinding(editor, e => e.Text, x => x.Progress);
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            public virtual int Progress { get; set; }
        }
    }

    [CodeExampleClass("Binding Capabilities (Converters)", "Bindings.cs")]
    [CodeExampleHighlightTokens("State", "CheckState")]
    [CodeExampleUnderlineTokens("SetBinding")]
    public static class BindingFeatures_BackConverter {
        static BindingFeatures_BackConverter() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;
            mvvmContext.ViewModelType = typeof(ViewModel);

            CheckEdit check = new CheckEdit();
            check.Dock = DockStyle.Top;
            check.Properties.AllowGrayed = true;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Dock = DockStyle.Top;
            commandButton.Text = "Report the ModelState property value";

            check.Parent = sampleHost;
            commandButton.Parent = sampleHost;
            return new object[] { mvvmContext, check, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Binding with Custom Converters", new Type[] { typeof(ViewModel) })]
        public static void BindingWithCustomConverters(MVVMContext mvvmContext, CheckEdit check, SimpleButton commandButton) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModel>();
            // Two-way binding for the 'CheckState' property and the 'ModelState' property. 
            // Values are converted to/from each other in custom manner (editing allowed).
            fluent.SetBinding(check, e => e.CheckState, x => x.ModelState,
                modelState => {
                    // Convert the ViewModel.State to CheckState
                    switch(modelState) {
                        case ViewModel.State.Active:
                            return CheckState.Checked;
                        case ViewModel.State.Inactive:
                            return CheckState.Unchecked;
                        default:
                            return CheckState.Indeterminate;
                    }
                },
                checkState => {
                    // Convert back from CheckState to the ViewModel.State
                    switch(checkState) {
                        case CheckState.Checked:
                            return ViewModel.State.Active;
                        case CheckState.Unchecked:
                            return ViewModel.State.Inactive;
                        default:
                            return ViewModel.State.Suspended;
                    }
                });
            // One-way binding for the 'Text' property.
            // The ModelState value is converted to string in custom manner.
            const string format = "Click to change the current ViewModel state from {0} to {1}";
            fluent.SetBinding(check, e => e.Text, x => x.ModelState, modelState =>
                string.Format(format, modelState, (ViewModel.State)((1 + (int)modelState) % 3)));
            // Binding for the Report command
            fluent.BindCommand(commandButton, x => x.ReportState);
        }
        [CodeExampleCase("Binding with Custom Converter Objects", new Type[] { typeof(ViewModel), typeof(StateToCheckStateConverter) }), CodeExampleVersionID(212)]
        public static void BindingWithCustomConverterObjecs(MVVMContext mvvmContext, CheckEdit check, SimpleButton commandButton) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModel>();
            // Two-way binding for the 'CheckState' property and the 'ModelState' property. 
            // Values are converted to/from each other in custom manner (editing allowed).
            fluent.SetBinding(check, e => e.CheckState, x => x.ModelState, StateToCheckStateConverter.Default);
            // One-way binding for the 'Text' property.
            // The ModelState value is converted to string in custom manner.
            const string format = "Click to change the current ViewModel state from {0} to {1}";
            fluent.SetBinding(check, e => e.Text, x => x.ModelState, modelState =>
                string.Format(format, modelState, (ViewModel.State)((1 + (int)modelState) % 3)));
            // Binding for the Report command
            fluent.BindCommand(commandButton, x => x.ReportState);
        }

        [CodeExampleNestedClass]
        public class ViewModel {
            public virtual State ModelState {
                get;
                set;
            }
            public enum State {
                Suspended = 0,
                Inactive = 1,
                Active = 2
            }
            public void ReportState() {
                var messageBoxService = this.GetService<IMessageBoxService>();
                messageBoxService.ShowMessage(ModelState.ToString());
            }
        }
        [CodeExampleNestedClass]
        public class StateToCheckStateConverter : IBindingConverter<ViewModel.State, CheckState> {
            public static readonly IBindingConverter<ViewModel.State, CheckState> Default = new StateToCheckStateConverter();
            //
            public CheckState Convert(ViewModel.State value) {
                // Convert the ViewModel.State to CheckState
                switch(value) {
                    case ViewModel.State.Active:
                        return CheckState.Checked;
                    case ViewModel.State.Inactive:
                        return CheckState.Unchecked;
                    default:
                        return CheckState.Indeterminate;
                }
            }
            public ViewModel.State ConvertBack(CheckState destValue) {
                // Convert back from CheckState to the ViewModel.State
                switch(destValue) {
                    case CheckState.Checked:
                        return ViewModel.State.Active;
                    case CheckState.Unchecked:
                        return ViewModel.State.Inactive;
                    default:
                        return ViewModel.State.Suspended;
                }
            }
        }
    }

    [CodeExampleClass("Binding Capabilities (Events)", "Bindings.cs"), CodeExampleVersionID(162)]
    [CodeExampleUnderlineTokens("SetBinding")]
    public static class BindingFeatures_Events {
        static BindingFeatures_Events() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;
            mvvmContext.ViewModelType = typeof(ViewModel);

            TextEdit editor = new TextEdit();
            editor.Dock = DockStyle.Top;
            editor.CausesValidation = false;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Dock = DockStyle.Top;

            commandButton.Parent = sampleHost;
            editor.Parent = sampleHost;
            return new object[] { mvvmContext, editor, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Binding with custom conversion handling", new Type[] { typeof(ViewModel) })]
        public static void BindingConvert(MVVMContext mvvmContext, TextEdit editor, SimpleButton commandButton) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModel>();
            // Binding Convert handling
            mvvmContext.BindingConvert += (s, e) => {
                string strValue = e.Value as string;
                if(strValue != null) {
                    int intValue;
                    if(int.TryParse(strValue, out intValue))
                        e.Value = intValue;
                    else
                        e.Value = null;
                }
                if(e.Value == null)
                    e.Value = 0;
            };
            // Two-way binding for the Value property (editing allowed)
            fluent.SetBinding(editor, e => e.EditValue, x => x.Value);
            // Binding for the Reset command
            fluent.BindCommand(commandButton, x => x.Reset);
            // One-way binding for the button Text property (with formatting)
            fluent.SetBinding(commandButton, b => b.Text, x => x.Value, "Reset Value ({0})");
        }
        [CodeExampleCase("Binding with custom error handling", new Type[] { typeof(ViewModel) })]
        public static void BindingError(MVVMContext mvvmContext, TextEdit editor, SimpleButton commandButton) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModel>();
            // Binding Error handling
            mvvmContext.BindingError += (s, e) => {
                var errorText = e.Error.Message;
                if(e.Error is System.FormatException)
                    errorText = "Only digits are allowed.";
                editor.ErrorText = errorText;
            };
            // When Errors changed
            mvvmContext.BindingBehavior.Errors.PropertyChanged += (s, e) => {
                var errors = ((System.ComponentModel.IDataErrorInfo)s);
                if(errors.Error == null)
                    editor.ErrorText = null;
            };
            // Two-way binding for the Value property (editing allowed)
            fluent.SetBinding(editor, e => e.EditValue, x => x.Value);
            // Binding for the Reset command
            fluent.BindCommand(commandButton, x => x.Reset);
            // One-way binding for the button Text property (with formatting)
            fluent.SetBinding(commandButton, b => b.Text, x => x.Value, "Reset Value ({0})");
        }
        [CodeExampleCase("Binding with user input validation", new Type[] { typeof(ViewModel) }), CodeExampleVersionID(212)]
        public static void BindingValidating(MVVMContext mvvmContext, TextEdit editor, SimpleButton commandButton) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModel>();
            // Input validating
            mvvmContext.BindingValidating += (s, e) => {
                if(e.TargetPropertyName == "Value") {
                    e.IsValid = (int)e.Value >= 0;
                    editor.ErrorText = !e.IsValid ? "Negative value is not allowed!" : null;
                }
            };
            // Two-way binding for the Value property (editing allowed)
            fluent.SetBinding(editor, e => e.EditValue, x => x.Value);
            // Binding for the Reset command
            fluent.BindCommand(commandButton, x => x.Reset);
            // One-way binding for the button Text property (with formatting)
            fluent.SetBinding(commandButton, b => b.Text, x => x.Value, "Reset Value ({0})");
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            public ViewModel() {
                Reset();
            }
            public virtual int Value {
                get;
                set;
            }
            protected void OnValueChanged() {
                this.RaiseCanExecuteChanged(x => x.Reset());
            }
            const int DefaultValue = 42;
            public void Reset() {
                if(Value == DefaultValue) {
                    // force value propagation to bound editor when latter is out-of-sync because error
                    this.RaisePropertyChanged(x => x.Value);
                }
                else Value = DefaultValue;
            }
        }
    }

    [CodeExampleClass("Binding Capabilities (MultiBinding)", "Bindings.cs"), CodeExampleVersionID(162)]
    [CodeExampleUnderlineTokens("SetMultiBinding")]
    public static class BindingFeatures_MultiBinding {
        static BindingFeatures_MultiBinding() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;
            mvvmContext.ViewModelType = typeof(ViewModel);

            TextEdit editForFirstName = new TextEdit();
            editForFirstName.Dock = DockStyle.Top;
            TextEdit editForLastName = new TextEdit();
            editForLastName.Dock = DockStyle.Top;
            TextEdit editForFullName = new TextEdit();
            editForFullName.Dock = DockStyle.Top;

            editForFullName.Parent = sampleHost;
            editForLastName.Parent = sampleHost;
            editForFirstName.Parent = sampleHost;
            return new object[] { mvvmContext, editForFirstName, editForLastName, editForFullName };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Binding for Multiple properties at once(via formatting)", new Type[] { typeof(ViewModel) })]
        public static void FormatBinding(MVVMContext mvvmContext, TextEdit editForFirstName, TextEdit editForLastName, TextEdit editForFullName) {
            editForFullName.ReadOnly = true;
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModel>();
            // Two-way bindings for the FirstName and Last Name properties (editing allowed)
            fluent.SetBinding(editForFirstName, e => e.EditValue, x => x.FirstName);
            fluent.SetBinding(editForLastName, e => e.EditValue, x => x.LastName);
            // One-way multi-binding for dispaying FullName
            mvvmContext.SetMultiBinding(editForFullName, e => e.Text, new string[] { "FirstName", "LastName" }, "{1}, {0}");
        }
        [CodeExampleCase("Binding for Multiple properties at once(via converters)", new Type[] { typeof(ViewModel) })]
        public static void ConvertBinding(MVVMContext mvvmContext, TextEdit editForFirstName, TextEdit editForLastName, TextEdit editForFullName) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModel>();
            // Two-way bindings for the FirstName and Last Name properties (editing allowed)
            fluent.SetBinding(editForFirstName, e => e.EditValue, x => x.FirstName);
            fluent.SetBinding(editForLastName, e => e.EditValue, x => x.LastName);
            // Two-way multi-binding for editing FullName (editing allowed)
            mvvmContext.SetMultiBinding(editForFullName, e => e.EditValue, new string[] { "FirstName", "LastName" },
                values => string.Join(",", values), value => ((string)value).Split(','));
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            public ViewModel() {
                FirstName = "John";
                LastName = "Smith";
            }
            public virtual string FirstName { 
                get; 
                set; 
            }
            public virtual string LastName { 
                get; 
                set; 
            }
        }
    }
}
