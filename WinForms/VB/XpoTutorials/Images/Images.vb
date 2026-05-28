Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Xpo.DB
Imports System.IO

Namespace DevExpress.Xpo.Demos
    Partial Public Class Images
        Inherits TutorialControl
        Private originDBFileName As String
        Private xpoDBFileName As String
        Private inMemory As InMemoryDataStore
        Public Sub New()
            inMemory = New InMemoryDataStore(AutoCreateOption.DatabaseAndSchema)
            Dim dl As IDataLayer = New SimpleDataLayer(inMemory)
            XpoDefault.DataLayer = dl
            originDBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Vehicles.xml")
            If (Not String.IsNullOrEmpty(originDBFileName)) Then
                xpoDBFileName = Path.Combine(Path.GetDirectoryName(originDBFileName), Path.GetFileNameWithoutExtension(originDBFileName) & "Xpo.xml")
                If File.Exists(xpoDBFileName) Then
                    inMemory.ReadXml(xpoDBFileName)
                Else
                    inMemory.ReadXml(originDBFileName)
                End If
            End If
            InitializeComponent()
            unitOfWork1.Connect(dl)
        End Sub
        Public Overrides Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.SetNewWhatsThisPadding = value
            End Set
        End Property
        Private Sub Images_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            xpCars.LoadingEnabled = True
            xpCars.Reload()
        End Sub

        Private Sub bSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bSave.Click
            SaveChanges(unitOfWork1)
            If (Not String.IsNullOrEmpty(xpoDBFileName)) Then
                inMemory.WriteXml(xpoDBFileName)
            End If
        End Sub

        Public Overrides Sub ReloadData()
            xpCars.Reload()
        End Sub
    End Class
End Namespace
