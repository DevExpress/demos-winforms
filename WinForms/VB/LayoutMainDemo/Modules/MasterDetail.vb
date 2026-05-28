Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.Internal

Namespace DevExpress.XtraLayout.Demos

    ''' <summary>
    ''' Summary description for Employees.
    ''' </summary>
    Public Partial Class MasterDetail
        Inherits BaseTutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            layoutControl1.SetDefaultLayout()
            InitPanels()
            InitData()
            pictureEdit1.DataBindings.Add(New Binding("EditValue", dsCategories1, "Categories.Picture"))
        ' TODO: Add any initialization after the InitForm call
        End Sub

        Public Overrides ReadOnly Property BaseLayout As LayoutControl
            Get
                Return layoutControl1
            End Get
        End Property

        Protected Overrides ReadOnly Property FileMask As String
            Get
                Return "md_"
            End Get
        End Property

        Private Sub InitData()
            Dim DBFileName As String = DataDirectoryHelper.GetDataFile("nwind.xml")
            If Not Equals(DBFileName, "") Then dsCategories1.ReadXml(DBFileName, XmlReadMode.InferSchema)
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            layoutControl1.BeginUpdate()
            spinEdit3.Enabled = Not checkEdit1.Checked
            spinEdit2.Enabled = spinEdit3.Enabled
            spinEdit1.Enabled = spinEdit2.Enabled
            calcEdit1.Enabled = spinEdit1.Enabled
            lookUpEdit1.Enabled = calcEdit1.Enabled
            textEdit4.Enabled = lookUpEdit1.Enabled
            textEdit2.Enabled = textEdit4.Enabled
            layoutControl1.EndUpdate()
        End Sub

        Private Sub Detail_Validated(ByVal sender As Object, ByVal e As EventArgs)
            CType(BindingContext(dataNavigator3.DataSource, dataNavigator3.DataMember), CurrencyManager).EndCurrentEdit()
        End Sub
    End Class
End Namespace
