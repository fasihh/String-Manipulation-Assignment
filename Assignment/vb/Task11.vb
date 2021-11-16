Module Module1

    Sub Main()
        Dim str1, str2, str3, str4 As String
        Dim bad1, not1 As Integer

        str1 = ""
        not1 = 0
        bad1 = 0
        str2 = ""
        str3 = ""
        str4 = ""

        Console.Write("Enter your string please: ")
        str1 = LCase(Console.ReadLine)

        not1 = InStr(str1, "not")
        bad1 = InStr(str1, "bad")

        If InStr(str1, "not") <> 0 And InStr(str1, "bad") <> 0 Then
            str2 = Mid(str1, 1, Len(str1) - (Len(str1) - not1 + 1))
            str3 = Mid(str1, bad1 + 3, Len(str1) - bad1)
            str4 = str2 & "good" & str3
        End If

        Console.WriteLine("Processed string: " & str4)

        Console.ReadKey()

    End Sub

End Module
