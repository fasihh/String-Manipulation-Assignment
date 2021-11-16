Module Module1

    Sub Main()
        Dim str1 As String
        Dim thisChar As Char
        Dim aCount, eCount, iCount, oCount, uCount, count As Integer

        str1 = ""
        thisChar = ""
        aCount = 0
        eCount = 0
        iCount = 0
        oCount = 0
        uCount = 0
        count = 0

        Console.Write("Enter your string here: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            thisChar = UCase(Mid(str1, count, 1))

            Select Case thisChar
                Case "A"
                    aCount = aCount + 1
                Case "E"
                    eCount = eCount + 1
                Case "I"
                    iCount = iCount + 1
                Case "O"
                    oCount = oCount + 1
                Case "U"
                    uCount = uCount + 1
            End Select
        Next

        Console.WriteLine("Your string had this many As, Es, Is, Os and Us in your string: {0}, {1}, {2}, {3} and {4}", aCount, eCount, iCount, oCount, uCount)

        Console.ReadKey()

    End Sub

End Module
