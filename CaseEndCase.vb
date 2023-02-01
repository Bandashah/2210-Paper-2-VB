Module Module1
    'To Input Temperature of 7 days, Output Msg accordingly, i.e. if temperature
    'is above 30 then output a msg, "it's hot.

    Sub Main()
        Dim temp As Integer
        For x = 1 To 7
            Console.Write("Enter Temperature : ")
            temp = Console.ReadLine()
            Select Case temp
                Case Is > 40 : Console.WriteLine(" Extremely Hot ")
                Case Is > 30 And temp < 40 : Console.WriteLine(" It's Hot ")
                Case Is > 20 And temp < 30 : Console.WriteLine(" It's Normal ")
                Case Is > 10 And temp < 20 : Console.WriteLine(" it's cold ")
                Case Is > 4 And temp < 10 : Console.WriteLine("It's Chilling ")
                Case Else : Console.WriteLine("It's Freezing")
            End Select
        Next
    End Sub

End Module
