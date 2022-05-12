Module Module1

    Sub Main()

        'TASK 1

        'displaying the ticket options and the extra attractions available
        Console.WriteLine("Welcome to Wildlife Park")
        Console.WriteLine("Days : Mon | Wed | Fri | Sun")
        Console.WriteLine("Prices Of Booking Of One Day (Price in Dollars)")
        Console.WriteLine("An Adult : 20.00 | A Child : 12.00 | A Senior : 16.00")
        Console.WriteLine("Family Ticket( two seniors or adults, and three children) : 60.00")
        Console.WriteLine("Group Ticket (6 or more) per person : 15.00")
        Console.WriteLine("Lion Feeding : 2.50 | Penguin Feeding : 2.00")
        Console.WriteLine()
        Console.WriteLine("Prices of Booking for Two Days(Price in Dollars)")
        Console.WriteLine("An Adult : 30.00 | A Child : 18.00 | A Senior : 24.00")
        Console.WriteLine("Family Ticket( two seniors or adults, and three children) : 90.00")
        Console.WriteLine("Group Ticket (6 or more) per person : 22.50")
        Console.WriteLine("Lion Feeding : 2.50 | Penguin Feeding : 2.00 | Evening BBQ : 5.00")

        Console.WriteLine()
        Console.WriteLine("*******************")
        Console.WriteLine()


        'TASK 2

        'Decleration

        Dim adults(25) As Integer
        Dim seniors(25) As Integer
        Dim children(25) As Integer

        Dim total As Single
        Dim totalpersons As Integer
        Dim AttractionChoice As Char
        Dim DaysChoice As Integer
        Dim LionChoice, PengiunChoice, BBQChoice As Boolean
        Dim GroupTicket, familyticket As Char
        Dim choice As Char


        Dim TotalRecord(25) As Single
        Dim BookingNo(25) As Integer
        Dim counter As Integer

        'Initialization
        counter = 0
        total = 0
        LionChoice = False
        PengiunChoice = False
        BBQChoice = False

        'Repeat as required
        Console.WriteLine("Are there any more customers (press Y to continue)?")
        choice = Console.ReadLine()

        While choice = "Y" Or choice = "y"

            Console.Clear()
            Console.WriteLine("Are you booking tickets for one day or two days?")
            DaysChoice = Console.ReadLine()

            Console.WriteLine("Do you want to buy a group ticket? Y or N (there are 6 people in a group)")
            GroupTicket = Console.ReadLine()

            If GroupTicket <> "Y" Or GroupTicket <> "y" Then
                Console.WriteLine("Do you want to buy a family ticket? Y or N (2 adults or/and seniors, three children)")
                familyticket = Console.ReadLine()
            End If

            Console.WriteLine("Enter no of Adults (enter 0 for no data)")
            adults(counter) = Console.ReadLine()
            Console.WriteLine("Enter no of Seniors (enter 0 for no data)")
            seniors(counter) = Console.ReadLine()

            'Input With Validation
            Console.WriteLine("Enter no of Children (enter 0 for no data)")
            children(counter) = Console.ReadLine()
            While children(counter) > adults(counter) * 2
                Console.WriteLine("Error! an adult may bring upto two children, Try Aagain")
                Console.WriteLine("Enter no of Children (enter 0 for no data)")
                children(counter) = Console.ReadLine()
            End While


            totalpersons = adults(counter) + children(counter) + seniors(counter)

            'Total for day 1
            If DaysChoice = 1 Then
                If familyticket = "y" Or familyticket = "Y" Then
                    total = 60.0
                End If
                If GroupTicket = "Y" Or GroupTicket = "y" Then
                    total = totalpersons * 15
                Else
                    total = 20.0 * adults(counter) + 12.0 * children(counter) + 16.0 * seniors(counter)
                End If
            End If

            'Total for day 2
            If DaysChoice = 2 Then
                If familyticket = "y" Or familyticket = "Y" Then
                    total = 90.0
                End If
                If GroupTicket = "Y" Or GroupTicket = "y" Then
                    total = totalpersons * 22.5
                Else
                    total = 30.0 * adults(counter) + 18.0 * children(counter) + 24.0 * seniors(counter)
                End If
            End If

            'Extra Attraction Input
            Console.WriteLine("Are you interested in extra attractions (press Y for Yes and N for No)")
            AttractionChoice = Console.ReadLine()
            If AttractionChoice = "Y" Or AttractionChoice = "y" Then
                Console.WriteLine("Are you interested in lion feeding? (press Y for Yes and N for No)")
                AttractionChoice = Console.ReadLine()
                If AttractionChoice = "Y" Then
                    LionChoice = True
                End If
                Console.WriteLine("Are you interested in penguin feeding? (press Y for Yes and N for No)")
                AttractionChoice = Console.ReadLine()
                If AttractionChoice = "Y" Then
                    PengiunChoice = True
                End If
                If DaysChoice = 2 Then
                    Console.WriteLine("Are you interested in evening barbecue? (press Y for Yes and N for No)")
                    AttractionChoice = Console.ReadLine()
                    If AttractionChoice = "Y" Then
                        BBQChoice = True
                    End If
                End If
            End If

            'Extra attraction total
            If LionChoice = True Then
                total = total + 2.5 * totalpersons
            End If
            If PengiunChoice = True Then
                total = total + 2.0 * totalpersons
            End If
            If BBQChoice = True Then
                total = total + 5.0 * totalpersons
            End If

            TotalRecord(counter) = total
            BookingNo(counter) = BookingNo(counter) + 1

            Console.WriteLine("Booking No : " & BookingNo(counter) & " Total : " & TotalRecord(counter))

            Console.WriteLine("Are there any more customers (press Y to continue)?")
            choice = Console.ReadLine()
            counter = counter + 1
        End While

        'TASK 3

        Dim booking As Integer
        Dim TotalRecordFamilyDiscount(25) As Integer

        For booking = 1 To counter

            If GroupTicket = "Y" And children(booking) >= 6 Then
                Console.WriteLine(" you are eligible for 2 family tickets, do you want to avail this opportunity ? ")
                choice = Console.ReadLine
                If choice = "Y" Then
                    If DaysChoice = 1 Then
                        TotalRecordFamilyDiscount(booking) = 120.0
                    End If
                    If DaysChoice = 2 Then
                        TotalRecordFamilyDiscount(booking) = 180
                    End If
                End If
            End If

            Console.WriteLine("Total after two family tickets Discount ")
            Console.WriteLine("Booking No : " & BookingNo(booking) & " Total : " & TotalRecordFamilyDiscount(booking))


        Next


        Console.ReadKey()

    End Sub

End Module
