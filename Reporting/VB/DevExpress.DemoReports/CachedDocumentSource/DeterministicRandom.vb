Imports System
Imports System.Collections.Generic

Namespace XtraReportsDemos.CachedDocumentSourceReport

    Friend Class DeterministicRandom

        Const randomCount As Integer = 10000

        '
        Private Shared ReadOnly deterministicRandomNumbers As Integer()

        Private Shared ReadOnly time As Date

        Shared Sub New()
            time = Date.Now.AddDays(-62)
            Dim currentRandom As DevExpress.Data.Utils.NonCryptographicRandom = New DevExpress.Data.Utils.NonCryptographicRandom(randomCount)
            deterministicRandomNumbers = New Integer(9999) {}
            For i As Integer = 0 To randomCount - 1
                deterministicRandomNumbers(i) = currentRandom.Next(randomCount)
            Next
        End Sub

        '
        Public Sub New(ByVal i As Integer)
            rnd = i + (i >> 10) + (i >> 20)
        End Sub

        Private rnd As Integer

        Private ReadOnly Property [Next] As Integer
            Get
                Return CSharpImpl.__Assign(rnd, deterministicRandomNumbers(rnd Mod randomCount))
            End Get
        End Property

        Public ReadOnly Property RandomChar As Char
            Get
                Return Microsoft.VisualBasic.ChrW(Microsoft.VisualBasic.AscW("A"c) + Random(0, 26))
            End Get
        End Property

        Public Function RandomList(ByVal count As Integer, ByVal [to] As Integer) As Integer()
            Dim res As Integer() = New Integer(count - 1) {}
            For i As Integer = 0 To Math.Min(count, [to]) - 1
                res(i) = i
            Next

            For i As Integer = [to] To count - 1
                res(i) = Random([to])
            Next

            For i As Integer = 0 To count - 1
                Dim ind As Integer = Random(count)
                Dim temp As Integer = res(ind)
                res(ind) = res(i)
                res(i) = temp
            Next

            Return res
        End Function

        Public Function Random(ByVal [to] As Integer) As Integer
            Return Random(0, [to])
        End Function

        Public Function Random(ByVal from As Integer, ByVal [to] As Integer) As Integer
            Return [Next] Mod Math.Max(1, [to] - from) + from
        End Function

        Public Function GetRandomItem(Of T)(ByVal list As IList(Of T)) As T
            Return list([Next] Mod list.Count)
        End Function

        Public Function RandomTime() As Date
            Return RandomTime(time, 0, 30 * 24)
        End Function

        Public Function RandomTime(ByVal from As Date, ByVal fromHours As Integer, ByVal toHours As Integer) As Date
            Return from.AddHours([Next] Mod (toHours - fromHours) + fromHours)
        End Function

        Private Class CSharpImpl

            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
