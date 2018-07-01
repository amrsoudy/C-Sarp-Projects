Imports CommposontAssemply

Namespace ConversionTemp
    Class ClientVB

        Public Shared  Sub Main(ByVal args As String())

            Dim comp As New CompConversionemperature()
            Dim choise As Double
            Dim input As Double
            Dim output As Double
            Dim [next] As Boolean = True
            While [next]

                Console.WriteLine("choisir  une selection " & vbLf & "1- Convertier De F vers C click  1 " & vbLf & " 2- Convertier de C a F présser  2" & vbLf & "Quitter  Enter")
                [Double].TryParse(Console.ReadLine(), choise)

                If choise = 1 Then
                    Console.WriteLine("Donner la info in F ")

                    Double.TryParse(Console.ReadLine(), input)
                    output = comp.ConversionFahrToCels(input)
                    Console.WriteLine(output)


                ElseIf choise = 2 Then


                    Console.WriteLine("Donner la info in F ")

                    Double.TryParse(Console.ReadLine(), input)
                    output = comp.ConversionCelsiusToFahr(input)
                    Console.WriteLine(output)


                Else

                    [next] = False
                    Console.WriteLine("Rien a Faire")

                End If

            End While


        End Sub

    End Class



End Namespace

