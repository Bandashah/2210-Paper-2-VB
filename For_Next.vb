'write down a visual basic program to INPUT temperature for a week,
'OUTOUT Heightest and Lowest Temperature
'OUTPUT Average Temperature
'OUTOUT Number of days having temperature below 20
'OUTPUT a Message "ITS COLD" If temperature is below 10

Module Module1

    Sub Main()
        Dim heightest, lowest As Integer
        Dim avg As Single
        Dim count As Integer
        Dim temp As Integer

        For days = 1 To 7
            Console.Write("Enter temperature for the day : ")
            temp = Console.ReadLine()
            If temp > heightest Then heightest = temp
            'lowest
            If temp > 20 Then count = count + 1
            If temp < 5 Then Console.WriteLine(" ITS COLD ")
            'total
        Next
        'avg
        Console.WriteLine(" the highest temprature is : " & heightest)
        'write lowest
        Console.WriteLine(" Number of days temperature below 20 : " & count)
        'write avg
    End Sub

End Module
