Module Module1

    Sub Main()

        Dim str1 As String

        str1 = ""

        Console.WriteLine("Enter your String: ")
        str1 = Console.ReadLine

        If Len(str1) > 2 Then

            Console.WriteLine(Left(str1, 2) & Right(str1, 2))
        Else
            Console.WriteLine("Text too short: " & str1)
        End If

        Console.ReadKey()

    End Sub

End Module
