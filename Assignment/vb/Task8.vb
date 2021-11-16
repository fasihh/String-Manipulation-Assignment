Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String
        Dim thisChar As Char
        Dim count As Integer
        Dim replace1 As Char
        'Dim show As Integer

        'show = 0
        str1 = ""
        str2 = ""
        thisChar = ""
        replace1 = ""
        count = 0

        ' " ' " were used for analysis during creation. But are now commented 

        Console.Write("Enter your string: ")
        str1 = Console.ReadLine
        Console.Write("Enter the character to replace: ")
        replace1 = Console.ReadLine

        For count = 1 To Len(str1)
            thisChar = Mid(str1, count, 1)

            If thisChar = replace1 Then
                'show = count
                str2 = str2 & replace1
                count = count + 1
                Exit For
            Else
                str2 = str2 & thisChar
            End If
        Next

        'Console.WriteLine(show)

        For count = count To Len(str1)
            thisChar = Mid(str1, count, 1)
            If thisChar = replace1 Then
                str2 = str2 & "*"
            Else
                str2 = str2 & thisChar
            End If
        Next

        'Console.WriteLine(thisChar)
        'Console.WriteLine(count)

        Console.WriteLine("Processed string: " & str2)

        Console.ReadKey()

    End Sub

End Module
