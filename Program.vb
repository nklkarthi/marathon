Imports System


Module Program
    Dim childName(20) as String
    Dim childAge(20) as Integer

    Dim menuChoice as Char
    
    Sub Main(args As String())
        While true
            Console.WriteLine("For Registration, enter 1")
            Console.WriteLine("For EventDetails, enter 2")
            Console.WriteLine("For CalculateAwards, enter 3")
            Console.WriteLine("To quit, enter q")
            menuChoice = Console.ReadLine()
            Select Case menuchoice
                Case "1"
                    Registration()
                Case "2"
                    EventDetails()
                Case "3"
                    CalculateAwards()
                Case "q"
                    Exit Sub
            End Select
        End While
    End Sub
    
    Sub Registration()
        Console.WriteLine("Registration")
    End Sub    
    
    Sub EventDetails()
        Console.WriteLine("EventDetails")
    End Sub
    
    Sub CalculateAwards()
        Console.WriteLine("CalculateAwards")
    End Sub   
End Module
