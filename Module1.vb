'Brayden Peck
'RCET0265
'Spring 2021
'Say My Name
'https://github.com/PeckBray/SayMyName
Option Strict On
Option Explicit On
Module Module1

    Sub Main()
        Dim name As String

        Console.WriteLine("Please type your name.")
        name = Console.ReadLine()
        If name = "Emily" Then
            Console.WriteLine($"Hello, " & name & "! Have a great day!")
            Console.ReadLine()
        ElseIf name = "Joe" Then
            Console.WriteLine($"Hello, " & name & "! Have a great day!")
            Console.ReadLine()
        ElseIf name = "Brayden" Then
            Console.WriteLine($"Hello, " & name & "! Have fun programing today!")
            Console.ReadLine()
        Else
            Console.WriteLine("Sorry, This user is not permitted")
            Console.ReadLine()
        End If
    End Sub

End Module
