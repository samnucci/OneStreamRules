Imports System.Data
Imports System.Text

Module Utils
    Private Function LogDataBuffer(dt As DataTable, Optional maxRows As Integer = -1) As String
        Dim sb As New StringBuilder()

        For Each col As DataColumn In dt.Columns
            sb.Append(col.ColumnName & vbTab)
        Next
        sb.AppendLine()

        Dim rowCount As Integer = 0

        For Each row As DataRow In dt.Rows
            If maxRows > -1 AndAlso rowCount >= maxRows Then Exit For

            For Each item In row.ItemArray
                sb.Append(If(item IsNot Nothing, item.ToString(), "NULL") & vbTab)
            Next
            sb.AppendLine()

            rowCount += 1
        Next

        If maxRows > -1 AndAlso dt.Rows.Count > maxRows Then
            sb.AppendLine($"... ({dt.Rows.Count - maxRows} more rows not shown)")
        End If

        Return sb.ToString()
    End Function

End Module