Module Module1
    'Input Temperature for 7 days of week (Validate temperature in bw 0 and 50)
    'Store temperature in one dimensional array.
    Sub Main()

        'Declare Weekly_Temp[1..7] : Integer
        Dim weekly_temp(7) As String
        'Declare temp : Integer
        Dim temp As Integer
        'For Counter <-- 1 to 7
        For counter = 1 To 7
            'OUTPUT ("Enter temp for the day ")
            Console.Write("Enter temperature for the day : ")
            'Input Temp
            temp = Console.ReadLine()
            'While temp < 0 OR temp > 50
            While temp < 0 Or temp > 50
                'OUTPUT ("Error, Input again")
                Console.WriteLine("error, input data again")
                'Input Temp
                temp = Console.ReadLine()
                'EndWhile
            End While
            'Weekly_Temp(counter) <-- temp
            weekly_temp(counter) = temp
            'NEXT
        Next
    End Sub

End Module
