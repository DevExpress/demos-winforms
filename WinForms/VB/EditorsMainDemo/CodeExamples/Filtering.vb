Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.Utils.Filtering
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.XtraEditors.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Filtering UI Editors", "Filtering.cs")>
    Public Module FilteringUIEditors

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim memo As DevExpress.XtraEditors.MemoEdit = New DevExpress.XtraEditors.MemoEdit()
            memo.Dock = System.Windows.Forms.DockStyle.Bottom
            memo.[ReadOnly] = True
            memo.Height = 60
            Dim accordion As DevExpress.XtraBars.Navigation.AccordionControl = New DevExpress.XtraBars.Navigation.AccordionControl()
            accordion.Dock = System.Windows.Forms.DockStyle.Fill
            accordion.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
            Dim context As DevExpress.Utils.Filtering.FilteringUIContext = New DevExpress.Utils.Filtering.FilteringUIContext()
            context.Control = accordion
            accordion.Parent = sampleHost
            memo.Parent = sampleHost
            sampleHost.Tag = context
            Return New Object() {context, accordion, memo}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim context As DevExpress.Utils.Filtering.FilteringUIContext = TryCast(sampleHost.Tag, DevExpress.Utils.Filtering.FilteringUIContext)
            If context IsNot Nothing Then context.Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Range", New System.Type() {GetType(DevExpress.XtraEditors.Demos.CodeExamples.FilteringUIEditors.FilteringModel_Range)})>
        Public Sub RangeEditors(ByVal context As DevExpress.Utils.Filtering.FilteringUIContext, ByVal accordion As DevExpress.XtraBars.Navigation.AccordionControl, ByVal memo As DevExpress.XtraEditors.MemoEdit)
            ' Setup filtering model
            context.ModelType = GetType(DevExpress.XtraEditors.Demos.CodeExamples.FilteringUIEditors.FilteringModel_Range)
            ' Retrieve the UI editors
            context.RetrieveFields()
            ' Setup FilterCriteria displaying
            AddHandler context.FilterCriteriaChanged, Sub(s, e) memo.Text = If(Not System.[Object].ReferenceEquals(e.FilterCriteria, Nothing), e.FilterCriteria.ToString(), Nothing)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Lookup", New System.Type() {GetType(DevExpress.XtraEditors.Demos.CodeExamples.FilteringUIEditors.FilteringModel_Lookup), GetType(DevExpress.XtraEditors.Demos.CodeExamples.FilteringUIEditors.Category)})>
        Public Sub LookupEditors(ByVal context As DevExpress.Utils.Filtering.FilteringUIContext, ByVal accordion As DevExpress.XtraBars.Navigation.AccordionControl, ByVal memo As DevExpress.XtraEditors.MemoEdit)
            ' Setup filtering model
            context.ModelType = GetType(DevExpress.XtraEditors.Demos.CodeExamples.FilteringUIEditors.FilteringModel_Lookup)
            ' Setup data for Lookups
            Dim categories = New System.Collections.Generic.List(Of DevExpress.XtraEditors.Demos.CodeExamples.FilteringUIEditors.Category)()
            For i As Integer = 0 To 18 - 1
                categories.Add(New DevExpress.XtraEditors.Demos.CodeExamples.FilteringUIEditors.Category() With {.Id = i, .Name = "Category " & i.ToString()})
            Next

            ' Setup events for providing data
            AddHandler context.QueryLookupData, Sub(s, e) e.Result.DataSource = categories
            ' Retrieve the UI editors
            context.RetrieveFields()
            ' Setup FilterCriteria displaying
            AddHandler context.FilterCriteriaChanged, Sub(s, e) memo.Text = If(Not System.[Object].ReferenceEquals(e.FilterCriteria, Nothing), e.FilterCriteria.ToString(), Nothing)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Boolean Choice", New System.Type() {GetType(DevExpress.XtraEditors.Demos.CodeExamples.FilteringUIEditors.FilteringModel_BooleanChoice)})>
        Public Sub BooleanChoiceEditors(ByVal context As DevExpress.Utils.Filtering.FilteringUIContext, ByVal accordion As DevExpress.XtraBars.Navigation.AccordionControl, ByVal memo As DevExpress.XtraEditors.MemoEdit)
            ' Setup filtering model
            context.ModelType = GetType(DevExpress.XtraEditors.Demos.CodeExamples.FilteringUIEditors.FilteringModel_BooleanChoice)
            ' Retrieve the UI editors
            context.RetrieveFields()
            ' Setup FilterCriteria displaying
            AddHandler context.FilterCriteriaChanged, Sub(s, e) memo.Text = If(Not System.[Object].ReferenceEquals(e.FilterCriteria, Nothing), e.FilterCriteria.ToString(), Nothing)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Enum Choice", New System.Type() {GetType(DevExpress.XtraEditors.Demos.CodeExamples.FilteringUIEditors.FilteringModel_EnumChoice)})>
        Public Sub EnumChoiceEditors(ByVal context As DevExpress.Utils.Filtering.FilteringUIContext, ByVal accordion As DevExpress.XtraBars.Navigation.AccordionControl, ByVal memo As DevExpress.XtraEditors.MemoEdit)
            ' Setup filtering model
            context.ModelType = GetType(DevExpress.XtraEditors.Demos.CodeExamples.FilteringUIEditors.FilteringModel_EnumChoice)
            ' Retrieve the UI editors
            context.RetrieveFields()
            ' Setup FilterCriteria displaying
            AddHandler context.FilterCriteriaChanged, Sub(s, e) memo.Text = If(Not System.[Object].ReferenceEquals(e.FilterCriteria, Nothing), e.FilterCriteria.ToString(), Nothing)
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class FilteringModel_Range

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Price (Default Editor)"), System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.Currency)>
            <DevExpress.Utils.Filtering.FilterRangeAttribute(0, 1000)>
            Public Property Price As Decimal

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Weight (Range Editor)")>
            <DevExpress.Utils.Filtering.FilterRangeAttribute(100.0, 250.0, 160.0, EditorType:=DevExpress.Utils.Filtering.RangeUIEditorType.Range)>
            Public Property Weight As Double

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Capacity (Spin Editor)")>
            <DevExpress.Utils.Filtering.FilterRangeAttribute(200, 6800, EditorType:=DevExpress.Utils.Filtering.RangeUIEditorType.Spin)>
            Public Property Capacity As Integer

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Performance (Text Editor)")>
            <DevExpress.Utils.Filtering.FilterRangeAttribute(100F, Nothing)>
            Public Property Performance As Single
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class FilteringModel_Lookup

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Category (Default Editor)")>
            <DevExpress.Utils.Filtering.FilterLookupAttribute(10, ValueMember:="Id", DisplayMember:="Name")>
            Public Property CategoryId1 As Integer

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Category (DropDown Editor)")>
            <DevExpress.Utils.Filtering.FilterLookupAttribute(ValueMember:="Id", DisplayMember:="Name", EditorType:=DevExpress.Utils.Filtering.LookupUIEditorType.DropDown)>
            Public Property CategoryId2 As Integer

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Category (Token Editor)")>
            <DevExpress.Utils.Filtering.FilterLookupAttribute(ValueMember:="Id", DisplayMember:="Name", EditorType:=DevExpress.Utils.Filtering.LookupUIEditorType.TokenBox)>
            Public Property CategoryId3 As Integer
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class Category

            Public Property Id As Integer

            Public Property Name As String
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class FilteringModel_BooleanChoice

            <System.ComponentModel.DataAnnotations.DisplayAttribute(ShortName:="Modern (Default Editor)", Name:="Modern")>
            Public Property Modern As Boolean

            <System.ComponentModel.DataAnnotations.DisplayAttribute(ShortName:="Impressive (Toggle Editor)", Name:="Impressive")>
            <DevExpress.Utils.Filtering.FilterBooleanChoiceAttribute(False, EditorType:=DevExpress.Utils.Filtering.BooleanUIEditorType.Toggle)>
            Public Property Impressive As Boolean

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Good (DropDown Editor)")>
            <DevExpress.Utils.Filtering.FilterBooleanChoiceAttribute(EditorType:=DevExpress.Utils.Filtering.BooleanUIEditorType.DropDown)>
            Public Property Good As Boolean

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Bad (List Editor)")>
            <DevExpress.Utils.Filtering.FilterBooleanChoiceAttribute(EditorType:=DevExpress.Utils.Filtering.BooleanUIEditorType.List)>
            Public Property Bad As Boolean
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class FilteringModel_EnumChoice

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Value (Default Editor)")>
            <DevExpress.Utils.Filtering.FilterEnumChoiceAttribute(UseSelectAll:=True)>
            Public Property Value As SomeEnum

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Flags (Default Editor)")>
            <DevExpress.Utils.Filtering.FilterEnumChoiceAttribute>
            Public Property Flags As SomeFlagEnum

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Count (DropDown Editor)"), System.ComponentModel.DataAnnotations.EnumDataTypeAttribute(GetType(DevExpress.XtraEditors.Demos.CodeExamples.FilteringUIEditors.FilteringModel_EnumChoice.SomeEnum))>
            <DevExpress.Utils.Filtering.FilterEnumChoiceAttribute(EditorType:=DevExpress.Utils.Filtering.LookupUIEditorType.DropDown)>
            Public Property Count As Integer

            <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Bits (Token Editor)"), System.ComponentModel.DataAnnotations.EnumDataTypeAttribute(GetType(DevExpress.XtraEditors.Demos.CodeExamples.FilteringUIEditors.FilteringModel_EnumChoice.SomeFlagEnum))>
            <DevExpress.Utils.Filtering.FilterEnumChoiceAttribute(EditorType:=DevExpress.Utils.Filtering.LookupUIEditorType.TokenBox)>
            Public Property Bits As Integer

            Public Enum SomeEnum
                Zero
                One
                Two
                Three
                Four
                Five
            End Enum

            <System.FlagsAttribute>
            Public Enum SomeFlagEnum
                FirstBit = &H01
                SecondBit = &H02
                ThirdBit = &H04
            End Enum
        End Class
    End Module
End Namespace
