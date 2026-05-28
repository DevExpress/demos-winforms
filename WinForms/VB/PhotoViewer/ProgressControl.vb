Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace PhotoViewer

    Public Partial Class ProgressControl
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        <DefaultValue(0)>
        Public Property Maximum As Integer
            Get
                Return progressBarControl1.Properties.Maximum
            End Get

            Set(ByVal value As Integer)
                progressBarControl1.Properties.Maximum = value
            End Set
        End Property

        <DefaultValue(0)>
        Public Property Value As Integer
            Get
                Return CInt(progressBarControl1.EditValue)
            End Get

            Set(ByVal value As Integer)
                progressBarControl1.EditValue = value
            End Set
        End Property

        <DefaultValue("")>
        Public Property ProgressText As String
            Get
                Return labelControl1.Text
            End Get

            Set(ByVal value As String)
                labelControl1.Text = value
            End Set
        End Property
    End Class
End Namespace
