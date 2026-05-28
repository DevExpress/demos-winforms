Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports DevExpress.Utils.Text
Imports DevExpress.Tutorials
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleLookUpEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitData()
            InitArrayData()
            InitLookUp()
            InitValues()
            AddHandler tabPane1.SelectedPageChanged, AddressOf SelectedPageChanged
        End Sub

        Protected Overrides Sub UnsubscribeOnEvents()
            MyBase.UnsubscribeOnEvents()
            RemoveHandler tabPane1.SelectedPageChanged, AddressOf SelectedPageChanged
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleLookUpEdit", "LookUpProperties"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "lookupedit"
            End Get
        End Property

        Protected Overrides ReadOnly Property AllowCenterControls As Boolean
            Get
                Return False
            End Get
        End Property

        Private Sub ModuleLookUpEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(lookUpEdit1)
            ControlUtils.CenterControlInParent(lookUpEdit2)
            ControlUtils.CenterControlInParent(lookUpEdit3)
            ControlUtils.CenterControlInParent(lookUpEdit4)
            notePanel1.Text = "This sample demonstrates how to use a DataView as a data source for a Lookup editor."
            notePanel2.Text = "This sample demonstrates how to bind a class inherited from Collection Base within a Lookup edit."
            notePanel3.Text = "This sample demonstrates how to use an ArrayList-based object as a data source within a Lookup editor."
            notePanel4.Text = "This sample illustrates how to use the Properties.GetNotInListValue event of the Lookup Edit. Use it to display virtual data within an unbound column of your control."
            notePanel1.Visible = True
        End Sub

        Private ReadOnly Property CurrentEdit As LookUpEdit
            Get
                Select Case tabPane1.SelectedPageIndex
                    Case 1
                        Return lookUpEdit2
                    Case 2
                        Return lookUpEdit3
                    Case 3
                        Return lookUpEdit4
                End Select

                Return lookUpEdit1
            End Get
        End Property

        Private Sub InitValues()
            properties.InitLookUp(CurrentEdit)
        End Sub

        '<lookUpEdit1>
        '<dataNavigator1>
        Private dvMain, dvProducts As DataView

        Private Sub InitData()
            Dim dvm As DataViewManager = New DataViewManager(NWindDataSet)
            dvMain = dvm.CreateDataView(NWindDataSet.Tables("Order Details"))
            dvProducts = dvm.CreateDataView(NWindDataSet.Tables("Products"))
        End Sub

        '</dataNavigator1>
        ' </lookUpEdit1>
        ' <lookUpEdit3>
        Private records As Record() = Nothing

        Private Sub InitArrayData()
            records = New Record(TutorialHelper.Countries.Length - 1) {}
            For i As Integer = 0 To TutorialHelper.Countries.Length - 1
                records(i) = New Record(StringPainter.Default.RemoveFormat(TutorialHelper.Countries(i)))
            Next
        End Sub

        ' </lookUpEdit3>
        Private Sub InitLookUp()
            'data binding
            ' <lookUpEdit1>
            If dvMain IsNot Nothing Then lookUpEdit1.DataBindings.Add("EditValue", dvMain, "ProductID")
            lookUpEdit1.Properties.DataSource = dvProducts
            ' </lookUpEdit1>
            '<dataNavigator1>
            dataNavigator1.DataSource = dvMain
            '</dataNavigator1>
            'simple binding
            ' <lookUpEdit2>
            lookUpEdit2.Properties.DataSource = ContactList.GetContacts()
            lookUpEdit2.EditValue = "2"
            ' </lookUpEdit2>
            'array list
            ' <lookUpEdit3>
            lookUpEdit3.Properties.ValueMember = "Country"
            lookUpEdit3.Properties.DisplayMember = "Country"
            lookUpEdit3.Properties.DataSource = records
            lookUpEdit3.Properties.PopulateColumns()
            lookUpEdit3.EditValue = records(0).Country
            ' </lookUpEdit3>
            'not in list
            ' <lookUpEdit4>
            lookUpEdit4.Properties.DataSource = records
            lookUpEdit4.EditValue = records(0).Country
            AddHandler lookUpEdit4.Properties.GetNotInListValue, New XtraEditors.Controls.GetNotInListValueEventHandler(AddressOf GetNotInListValue)
        ' </lookUpEdit4>
        End Sub

        ' <lookUpEdit4>
        Private Sub GetNotInListValue(ByVal sender As Object, ByVal e As XtraEditors.Controls.GetNotInListValueEventArgs)
            e.Value =(e.RecordIndex + 1).ToString() & "."
        End Sub

        ' </lookUpEdit4>
        Private Sub SelectedPageChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
            InitValues()
        End Sub
    End Class
End Namespace
