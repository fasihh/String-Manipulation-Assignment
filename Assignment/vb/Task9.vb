Module Module1

    Sub Main()
        Dim str1, str2, strAfter, strBefore As String
        Dim count As Integer
        Dim thisChar As Char

        str1 = ""
        str2 = ""
        strAfter = ""
        strBefore = ""
        count = 0
        thisChar = ""

        Console.Write("Your first string: ")
        str1 = Console.ReadLine
        Console.Write("Your second string: ")
        str2 = Console.ReadLine

        strBefore = Left(str2, 2)
        strAfter = Left(str1, 2)

        For count = 3 To Len(str1)
            thisChar = Mid(str1, count, 1)
            strBefore = strBefore & thisChar
        Next

        count = 0
        thisChar = ""

        For count = 3 To Len(str2)
            thisChar = Mid(str2, count, 1)
            strAfter = strAfter & thisChar
        Next

        Console.WriteLine("Your processed string: " & strBefore & " " & strAfter)
        Console.ReadKey()
    End Sub

End Module
