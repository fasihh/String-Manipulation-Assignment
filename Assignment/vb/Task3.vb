Module Module1

    Sub Main()
        Dim str1 As String
        Dim thisChar As Char
        Dim alphabetsCount, numberCount, otherCount, count, ascval As Integer

        ascval = 0
        str1 = ""
        thisChar = ""
        alphabetsCount = 0
        numberCount = 0
        otherCount = 0
        count = 0

        Console.Write("Enter your string: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            thisChar = Mid(str1, count, 1)
            ascval = Asc(thisChar)
            If ascval >= 65 And ascval <= 90 Then
                alphabetsCount = alphabetsCount + 1
            ElseIf ascval >= 97 And ascval <= 122 Then
                alphabetsCount = alphabetsCount + 1
            ElseIf ascval >= 40 And ascval <= 57 Then
                numberCount = numberCount + 1
            Else
                otherCount = otherCount + 1
            End If
        Next

        Console.WriteLine("Total characters in your string: " & Len(str1))
        Console.WriteLine("Total alphabets in your string: " & alphabetsCount)
        Console.WriteLine("Total integers in your string: " & numberCount)
        Console.WriteLine("Total special characters in your string: " & otherCount)

        Console.ReadKey()


    End Sub

End Module
