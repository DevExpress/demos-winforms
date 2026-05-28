Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.Utils.Filtering
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.XtraEditors.Demos.CodeExamples
    <CodeExampleClass("Filtering UI Editors", "Filtering.cs")>
    Public Module FilteringUIEditors
        <CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim memo As MemoEdit = New MemoEdit()
            memo.Dock = DockStyle.Bottom
            memo.[ReadOnly] = True
            memo.Height = 60
            Dim accordion As AccordionControl = New AccordionControl()
            accordion.Dock = DockStyle.Fill
            accordion.ScrollBarMode = ScrollBarMode.Touch
            Dim context As FilteringUIContext = New FilteringUIContext()
            context.Control = accordion
            accordion.Parent = sampleHost
            memo.Parent = sampleHost
            sampleHost.Tag = context
            Return New Object() {context, accordion, memo}
        End Function

        <CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context As FilteringUIContext = TryCast(sampleHost.Tag, FilteringUIContext)
            If context IsNot Nothing Then context.Dispose()
        End Sub

        <CodeExampleCase("Range", New Type() {GetType(FilteringModel_Range)})>
        Public Sub RangeEditors(ByVal context As FilteringUIContext, ByVal accordion As AccordionControl, ByVal memo As MemoEdit)
            ' Setup filtering model
            context.ModelType = GetType(FilteringModel_Range)
            ' Retrieve the UI editors
            context.RetrieveFields()
            ' Setup FilterCriteria displaying
            context.FilterCriteriaChanged += Function(s, e)
                                                 memo.Text = If(Not ReferenceEquals(e.FilterCriteria, Nothing), e.FilterCriteria.ToString(), Nothing)
                                             End Function
        End Sub

        <CodeExampleCase("Lookup", New Type() {GetType(FilteringModel_Lookup), GetType(Category)})>
        Public Sub LookupEditors(ByVal context As FilteringUIContext, ByVal accordion As AccordionControl, ByVal memo As MemoEdit)
            ' Setup filtering model
            context.ModelType = GetType(FilteringModel_Lookup)
            ' Setup data for Lookups
            Dim categories = New System.Collections.Generic.List(Of Category)()

            For i As Integer = 0 To 18 - 1
                categories.Add(New Category() With {
                    .Id = i,
                    .Name = "Category " & i.ToString()
                })
            Next

            ' Setup events for providing data
            context.QueryLookupData += Function(s, e)
                                           e.Result.DataSource = categories
                                       End Function

            ' Retrieve the UI editors
            context.RetrieveFields()
            ' Setup FilterCriteria displaying
            context.FilterCriteriaChanged += Function(s, e)
                                                 memo.Text = If(Not ReferenceEquals(e.FilterCriteria, Nothing), e.FilterCriteria.ToString(), Nothing)
                                             End Function
        End Sub

        <CodeExampleCase("Boolean Choice", New Type() {GetType(FilteringModel_BooleanChoice)})>
        Public Sub BooleanChoiceEditors(ByVal context As FilteringUIContext, ByVal accordion As AccordionControl, ByVal memo As MemoEdit)
            ' Setup filtering model
            context.ModelType = GetType(FilteringModel_BooleanChoice)
            ' Retrieve the UI editors
            context.RetrieveFields()
            ' Setup FilterCriteria displaying
            context.FilterCriteriaChanged += Function(s, e)
                                                 memo.Text = If(Not ReferenceEquals(e.FilterCriteria, Nothing), e.FilterCriteria.ToString(), Nothing)
                                             End Function
        End Sub

        <CodeExampleCase("Enum Choice", New Type() {GetType(FilteringModel_EnumChoice)})>
        Public Sub EnumChoiceEditors(ByVal context As FilteringUIContext, ByVal accordion As AccordionControl, ByVal memo As MemoEdit)
            ' Setup filtering model
            context.ModelType = GetType(FilteringModel_EnumChoice)
            ' Retrieve the UI editors
            context.RetrieveFields()
            ' Setup FilterCriteria displaying
            context.FilterCriteriaChanged += Function(s, e)
                                                 memo.Text = If(Not ReferenceEquals(e.FilterCriteria, Nothing), e.FilterCriteria.ToString(), Nothing)
                                             End Function
        End Sub

        '
        <CodeExampleNestedClass>
        Public Class FilteringModel_Range
            <Display(Name:="Price (Default Editor)"), DataType(DataType.Currency)>
            <FilterRange(0, 1000)>
            Public Property Price As Decimal
            <Display(Name:="Weight (Range Editor)")>
            <FilterRange(100.0, 250.0, 160.0, EditorType:=RangeUIEditorType.Range)>
            Public Property Weight As Double
            <Display(Name:="Capacity (Spin Editor)")>
            <FilterRange(200, 6800, EditorType:=RangeUIEditorType.Spin)>
            Public Property Capacity As Integer
            <Display(Name:="Performance (Text Editor)")>
            <FilterRange(100F, Nothing)>
            Public Property Performance As Single
        End Class

        <CodeExampleNestedClass>
        Public Class FilteringModel_Lookup
            <Display(Name:="Category (Default Editor)")>
            <FilterLookup(10, ValueMember:="Id", DisplayMember:="Name")>
            Public Property CategoryId1 As Integer
            <Display(Name:="Category (DropDown Editor)")>
            <FilterLookup(ValueMember:="Id", DisplayMember:="Name", EditorType:=LookupUIEditorType.DropDown)>
            Public Property CategoryId2 As Integer
            <Display(Name:="Category (Token Editor)")>
            <FilterLookup(ValueMember:="Id", DisplayMember:="Name", EditorType:=LookupUIEditorType.TokenBox)>
            Public Property CategoryId3 As Integer
        End Class

        <CodeExampleNestedClass>
        Public Class Category
            Public Property Id As Integer
            Public Property Name As String
        End Class

        <CodeExampleNestedClass>
        Public Class FilteringModel_BooleanChoice
            <Display(ShortName:="Modern (Default Editor)", Name:="Modern")>
            Public Property Modern As Boolean
            <Display(ShortName:="Impressive (Toggle Editor)", Name:="Impressive")>
            <FilterBooleanChoice(False, EditorType:=BooleanUIEditorType.Toggle)>
            Public Property Impressive As Boolean
            <Display(Name:="Good (DropDown Editor)")>
            <FilterBooleanChoice(EditorType:=BooleanUIEditorType.DropDown)>
            Public Property Good As Boolean
            <Display(Name:="Bad (List Editor)")>
            <FilterBooleanChoice(EditorType:=BooleanUIEditorType.List)>
            Public Property Bad As Boolean
        End Class

        <CodeExampleNestedClass>
        Public Class FilteringModel_EnumChoice
            <Display(Name:="Value (Default Editor)")>
            <FilterEnumChoice(UseSelectAll:=True)>
            Public Property Value As SomeEnum
            <Display(Name:="Flags (Default Editor)")>
            <FilterEnumChoice>
            Public Property Flags As SomeFlagEnum
            <Display(Name:="Count (DropDown Editor)"), EnumDataType(GetType(SomeEnum))>
            <FilterEnumChoice(EditorType:=LookupUIEditorType.DropDown)>
            Public Property Count As Integer
            <Display(Name:="Bits (Token Editor)"), EnumDataType(GetType(SomeFlagEnum))>
            <FilterEnumChoice(EditorType:=LookupUIEditorType.TokenBox)>
            Public Property Bits As Integer

            Public Enum SomeEnum
                Zero
                One
                Two
                Three
                Four
                Five
            End Enum

            <Flags>
            Public Enum SomeFlagEnum
                FirstBit = &H01
                SecondBit = &H02
                ThirdBit = &H04
            End Enum
        End Class
    End Module
End Namespace
