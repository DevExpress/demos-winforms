Imports DevExpress.Tutorials

Namespace DevExpress.XtraRichEdit.Demos

    Public Class DemoUtils

        Public Shared Function GetRelativePath(ByVal name As String) As String
            Dim path As String = System.IO.Path.Combine("Data", name)
            Return FilePathUtils.FindFilePath(path, False)
        End Function

        Public Shared Sub SetConnectionString(ByVal oleDbConnection As System.Data.OleDb.OleDbConnection, ByVal path As String)
            oleDbConnection.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path)
        End Sub
    End Class
End Namespace
