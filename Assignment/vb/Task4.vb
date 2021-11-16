Module Module1

    Sub Main()
        Dim currentCount, nextCount, highest, occurence As Integer
        Dim currentChar, nextChar, mostChar As Char
        Dim str1 As String

        currentChar = ""
        currentCount = 0
        nextChar = ""
        nextCount = 0
        highest = 0
        occurence = 0
        str1 = ""
        mostChar = ""


        Console.Write("Enter your string: ")
        str1 = UCase(Console.ReadLine)

        For currentCount = 1 To Len(str1)
            currentChar = Mid(str1, currentCount, 1)
            occurence = 0
            For nextCount = 1 To Len(str1)
                nextChar = Mid(str1, nextCount, 1)
                If currentChar = nextChar Then
                    occurence = occurence + 1
                End If
            Next

            If occurence > highest Then
                mostChar = currentChar
                highest = occurence
            End If

        Next

        Console.WriteLine("Your most occuring character is: " & mostChar)
        Console.WriteLine("By this much: " & highest)

        Console.ReadKey()

    End Sub

End Module
