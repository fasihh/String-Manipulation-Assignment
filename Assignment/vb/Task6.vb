Module Module1

    Sub Main()
        Dim donutCount, count As Integer

        donutCount = 0
        count = 0

        Console.Write("Number of donuts: ")
        donutCount = Console.ReadLine

        If donutCount >= 10 Then
            Console.WriteLine("Number of Donuts: many")
        Else
            Console.WriteLine("Number of Donuts: " & donutCount)
        End If

        Console.ReadKey()
    End Sub

End Module
