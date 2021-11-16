Module Module1

    Sub Main()
        Dim str1 As String

        Console.Write("Enter your word: ")
        str1 = Console.ReadLine
        str1 = LCase(str1)

        If Len(str1) >= 3 Then
            If Right(str1, 3) = "ing" Then
                str1 = str1 & "ly"
            End If
            str1 = str1 & "ing"
        End If

        Console.WriteLine("Processed string: " & str1)

        Console.ReadKey()
    End Sub

End Module
