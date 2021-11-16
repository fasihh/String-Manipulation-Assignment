Module Module1

    Sub Main()
        Dim str1 As String
        Dim count As Integer
        Dim thisChar As Char
        Dim str2 As String
        Dim replace1 As Char
        Dim char1 As Char

        replace1 = ""
        str2 = ""
        thisChar = ""
        count = 0
        str1 = ""
        char1 = ""

        Console.Write("Enter String: ")
        str1 = Console.ReadLine
        Console.Write("Enter character: ")
        replace1 = Console.ReadLine
        Console.Write("set as: ")
        char1 = Console.ReadLine

        For count = 1 To Len(str1)
            thisChar = Mid(str1, count, 1)
            If thisChar = replace1 Then
                str2 = str2 & char1
            Else
                str2 = str2 & thisChar
            End If
        Next

        Console.Write(str2)

        Console.ReadKey()

    End Sub

End Module
