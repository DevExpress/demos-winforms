Namespace XtraReportsDemos.CachedDocumentSourceReport

    Public Structure Term

        Public Shared ReadOnly Terms As Term() = New Term() {New Term("Payment seven days after invoice date"), New Term("Payment ten days after invoice date"), New Term("End of month"), New Term("21st of the month following invoice date")}

        Private ReadOnly currentName As String

        Public ReadOnly Property Name As String
            Get
                Return currentName
            End Get
        End Property

        Public Sub New(ByVal currentName As String)
            Me.currentName = currentName
        End Sub
    End Structure
End Namespace
