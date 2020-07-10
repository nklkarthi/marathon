Module Program
    Dim childID(20) as String
    Dim childName(20) as String
    Dim childAge(20) as Integer
    Dim childPersonalBest(20) as Double
    Dim childRuns(20) as Integer
    Dim eventCount as Integer = 0

    Dim menuChoice as Char
    
    Sub Main(args As String())
        While true
            Console.WriteLine("For Registration, enter 1")
            Console.WriteLine("For Event Details, enter 2")
            Console.WriteLine("For Event Awards, enter 3")
            Console.WriteLine("For Marathon Awards, enter 4")
            Console.WriteLine("To quit, enter q")
            menuChoice = Console.ReadLine()
            Select Case menuChoice
                Case "1"
                    Registration()
                Case "2"
                    EventDetails()
                Case "3"
                    EventAwards()
                Case "4"
                    MarathonAwards()
                Case "q"
                    Exit Sub
            End Select
        End While
    End Sub
    
    Sub Registration()
        Console.WriteLine("Welcome to Registration")
        Console.WriteLine("=======================")
        For index As Integer = 1 To 3
            Console.WriteLine("Please enter the name of the child " & index)
            childName(index) = Console.ReadLine()
            Console.WriteLine("Please enter the age of the child " & index)
            childAge(index) = Console.ReadLine()
            Console.WriteLine("The ID of the Student is " & "STU"&index)
            childID(index) = "SGP"&index
            childPersonalBest(index) = 0.00
            childRuns(index) = 0
        Next      
    End Sub    
    
    Sub EventDetails()
        Dim startTime as Double
        Dim finishTime as Double
        Dim timeTaken as Double
        Console.WriteLine("Welcome to Event Details")
        Console.WriteLine("=======================")
        eventCount = eventCount + 1
        For index As Integer = 1 To 3
            Console.WriteLine("Enter the start time (mins) of "& childName(index))
            startTime = Console.ReadLine()
            Console.WriteLine("Enter the finish time (mins) of "& childName(index))
            finishTime = Console.ReadLine()
            timeTaken = finishTime - startTime
            If timeTaken = 0.00 Then
                Console.WriteLine(childName(index) & " did not participate ")
            Else
                Console.WriteLine(childName(index) & " taken " & timeTaken & " minutes to complete" )
                If childPersonalBest(index) = 0.00 Then
                    childPersonalBest(index) = timeTaken
                Else If timeTaken < childPersonalBest(index) Then
                    childPersonalBest(index) = timeTaken
                End If
                childRuns(index) = childRuns(index) + 1
            End If
            Console.WriteLine("The personal best time taken by " & childName(index) & " is " & childPersonalBest(index))
        Next
    End Sub
    
    Sub EventAwards()
        Console.WriteLine("Welcome to Event Awards for the " & eventCount & " event ")
        Console.WriteLine("===========================================================")
        Dim personalBest4To6 = 0.00
        Dim personalBest7To10 = 0.00
        Dim personalBest11To14 = 0.00 
        Dim award4To6 as Integer 
        Dim award7To10 as Integer
        Dim award11To14 as Integer

        If eventCount = 0 Then
            Console.WriteLine("Sorry! Not ready for the Event Awards")
        Else 
            For index As Integer = 1 To 3
                Dim childsAge = childAge(index)
                Dim childsPersonal = childPersonalBest(index)
                If childsAge >= 4 AND childsAge <= 6 Then
                    award4To6 = index
                    If eventCount = 1 Then
                        personalBest4To6 = childsPersonal
                    Else If childsPersonal < personalBest4To6 Then
                        personalBest4To6 = childsPersonal
                        award4To6 = index
                    End If
                Else If childsAge >= 7 AND childsAge <= 10 Then
                    award7To10 = index
                    If eventCount = 1 Then
                        personalBest7To10 = childsPersonal
                    Else If childsPersonal < personalBest7To10 Then
                        personalBest7To10 = childsPersonal
                        award7To10 = index
                    End If
                Else If childsAge >= 11 AND childsAge <= 14 Then
                    award11To14 = index
                    If eventCount = 1 Then
                        personalBest11To14 = childsPersonal
                    Else If childsPersonal < personalBest11To14 Then
                        personalBest11To14 = childsPersonal
                        award11To14 = index
                    End If
                End If
            Next
            Console.WriteLine("Congrats! Age 4 to 6 group winner in this event is " & childName(award4To6) & " with personal best as " &personalBest4To6)
            Console.WriteLine("Congrats! Age 7 to 10 group winner in this event is " & childName(award7To10) & " with personal best as " &personalBest7To10)
            Console.WriteLine("Congrats! Age 11 to 14 group winner in this event is " & childName(award11To14) & " with personal best as " &personalBest11To14)
        End If

    End Sub

    Sub MarathonAwards()
        Console.WriteLine("Welcome to Marathon Awards ")
        Console.WriteLine("============================")
        If eventCount < 11 Then
            Console.WriteLine("Sorry! Not enough Events for the Marathon Awards")
        Else
            For index As Integer = 1 To 3
                If childRuns(index) >= 22 Then
                    Console.WriteLine("Congrats! Full marathon award to " & childName(index))
                Else If childRuns(index) >= 11 Then
                    Console.WriteLine("Congrats! Half marathon award to " & childName(index))
                Else
                    Console.WriteLine(childName(index) & " is not eligible for awards yet. Go more runs !!")
                End If
            Next
        End If
    End Sub
End Module
