Imports System.Console
Module Module1

    Sub Main()
        ForegroundColor = ConsoleColor.Green
        WriteLine("{{{{ Kampus Creator @wifi.id }}}}" & vbNewLine)
a:

        Try
            Dim result As String
            Dim Nim, tahun, tanggal_lahir As Integer
            ForegroundColor = ConsoleColor.Gray
            Write("Input Nim => ")
            Nim = ReadLine()
            Write("Input Tahun => ")
            tahun = ReadLine()
            Write("Input Tanggal Lahir => ")
            tanggal_lahir = ReadLine()

            result = ("Username : " & Nim & "@ut.ac.id" & vbNewLine _
                & "Password : " & tahun & tanggal_lahir)
            Write("========== Result ==========" & vbNewLine _
                     & result & vbNewLine &
                      "============================")
        Catch ex As Exception
            ForegroundColor = ConsoleColor.Red
            Write("Failed!, Type Data String Ditolak!")
        End Try
        ReadKey()
        WriteLine()
        GoTo a
    End Sub

End Module