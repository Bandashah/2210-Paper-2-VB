Module Module1
    'To Input Temperature of 7 days, Output Msg accordingly, i.e. if temperature
    'is above 30 then output a msg, "it's hot.

    Sub Main()
        Dim temp As Integer
        For x = 1 To 7
            Console.Write("Enter Temperature : ")
            temp = Console.ReadLine()
            If temp > 40 Then
                Console.WriteLine(" Extremely Hot ")
            ElseIf temp > 30 And temp < 40 Then
                Console.WriteLine(" It's Hot ")
            ElseIf temp > 20 And temp < 30 Then
                Console.WriteLine(" It's Normal ")
            ElseIf temp > 10 And temp < 20 Then
                Console.WriteLine(" it's cold ")
            ElseIf temp > 4 And temp < 10 Then
                Console.WriteLine("It's Chilling ")
            Else
                Console.WriteLine("It's Freezing")
            End If
        Next
    End Sub

End Module
