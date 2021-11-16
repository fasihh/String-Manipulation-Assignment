Module Module1

    Sub Main()
        Dim str1 As String
        Dim alphabets As String
        Dim thisChar As String
        Dim count As Integer
        Dim confirm As Boolean

        confirm = True
        count = 0
        thisChar = ""
        alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        str1 = ""

        Console.WriteLine("Write your string: ")
        str1 = Console.ReadLine()
        str1 = UCase(str1)

        'Flag method applied. can not find any other way for now

        For count = 1 To Len(str1)
            thisChar = Mid(alphabets, count, 1)

            If InStr(str1, thisChar) = 0 Then
                confirm = False
            End If
        Next

        If confirm = False Then
            Console.WriteLine("not")
        Else
            Console.WriteLine("is")
        End If

        Console.ReadLine()

    End Sub

End Module
