Module Module1

    Sub Main()
        Try
            Dim number1 As Integer
            Dim number2 As Integer
            Dim answerSqare As Double
            Dim answerCube As Double

            Console.WriteLine("Enter first Number")
            number1 = Integer.Parse(Console.ReadLine())
            While number1 <= 0 Or IsNothing(number1) Or IsNumeric(number1) = False
                Console.WriteLine("Invalid Number Format")
                number1 = Console.ReadLine()
            End While

            Console.WriteLine("Enter second Number")
            number2 = Integer.Parse(Console.ReadLine())
            While number2 <= 0 Or IsNothing(number1) Or IsNumeric(number1) = False
                Console.WriteLine("Invalid Number Format")
                number2 = Console.ReadLine()
            End While

            If number1 >= number2 Then
                answerSqare = number1 * number1
                answerCube = number1 * number1 * number1
                Console.WriteLine($"The Square of {number1} is " & answerSqare)
                Console.WriteLine($"The Cube of {number1} is " & answerCube)
            ElseIf number2 > number1 Then
                answerSqare = number2 * number2
                answerCube = number2 * number2 * number2
                Console.WriteLine($"The Square of {number2} is " & answerSqare)
                Console.WriteLine($"The Cube of {number2} is " & answerCube)
            ElseIf number1 = number2 Then
                Console.WriteLine($"The two Numbers {number1} and {number2} are equal")
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

End Module
