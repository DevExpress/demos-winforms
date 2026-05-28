Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout.Demos.Properties

Namespace DevExpress.XtraLayout.Demos.Modules.TechnoLayout

    Public Partial Class FacesUserControl
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            InitializeImageCollection()
            SetPicture()
        End Sub

        Private Sub InitializeImageCollection()
            imageCollection1.AddImage(Resources.Striper1_1_, "Striper1_1_")
            imageCollection1.AddImage(Resources.Striper10_1_, "Striper10_1_")
            imageCollection1.AddImage(Resources.Striper12_1_, "Striper12_1_")
            imageCollection1.AddImage(Resources.Striper13_1_, "Striper13_1_")
            imageCollection1.AddImage(Resources.Striper14_1_, "Striper14_1_")
            imageCollection1.AddImage(Resources.Striper15_1_, "Striper15_1_")
            imageCollection1.AddImage(Resources.Striper16_1_, "Striper16_1_")
            imageCollection1.AddImage(Resources.Striper18_1_, "Striper18_1_")
            imageCollection1.AddImage(Resources.Striper19_1_, "Striper19_1_")
            imageCollection1.AddImage(Resources.Striper2_1_, "Striper2_1_")
            imageCollection1.AddImage(Resources.Striper20_1_, "Striper20_1_")
            imageCollection1.AddImage(Resources.Striper21_1_, "Striper21_1_")
            imageCollection1.AddImage(Resources.Striper22_1_, "Striper22_1_")
            imageCollection1.AddImage(Resources.Striper24_1_, "Striper24_1_")
            imageCollection1.AddImage(Resources.Striper25_1_, "Striper25_1_")
            imageCollection1.AddImage(Resources.Striper26_1_, "Striper26_1_")
            imageCollection1.AddImage(Resources.Striper27_1_, "Striper27_1_")
            imageCollection1.AddImage(Resources.Striper28_1_, "Striper28_1_")
            imageCollection1.AddImage(Resources.Striper3_1_, "Striper3_1_")
            imageCollection1.AddImage(Resources.Striper4_1_, "Striper4_1_")
            imageCollection1.AddImage(Resources.Striper6_1_, "Striper6_1_")
            imageCollection1.AddImage(Resources.Striper7_1_, "Striper7_1_")
            imageCollection1.AddImage(Resources.Striper8_1_, "Striper8_1_")
            imageCollection1.AddImage(Resources.Striper9_1_, "Striper9_1_")
            imageCollection1.AddImage(Resources.Striper0_1_, "Striper0_1_")
        End Sub

        Private Sub SetPicture()
            Dim i As Integer = 0
            For Each lci As LayoutControlItem In lcgFaces.Items
                CType(lci.Control, PictureEdit).Image = imageCollection1.Images(i)
                i += 1
            Next
        End Sub
    End Class
End Namespace
