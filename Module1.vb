Module Module1

    Enum menu
        salir = 0
        Altaalumno = 1
        Listaalumnos = 2
        Altanotas = 3
        Resultados = 4

    End Enum

    Sub Main()


        Console.WriteLine(ValidarEntero(10))
        Console.WriteLine(ValidarEntero(999999999))
        Console.WriteLine(ValidarEntero(152))
        Console.WriteLine(ValidarEntero(654))

        'Console.WriteLine(ValidarCadena("hola"))
        'Console.WriteLine(ValidarCadena("hola como estas"))


        'Console.WriteLine(ValidarLetra("A"))
        'Console.WriteLine(ValidarLetra("B"))
        'Console.WriteLine(ValidarLetra("C"))
        'Console.WriteLine(ValidarLetra("D"))
        'Console.WriteLine(ValidarLetra("E"))
        'Console.WriteLine(ValidarLetra("fsfsdf"))

        Dim Alumnos As New Hashtable

        Dim notas As List(Of ArrayList)
        notas = New List(Of ArrayList)


        Dim op As Integer

        Do

            Console.WriteLine("Ingrese Opcion: ")
            Console.WriteLine(" 1 Alta de Alumnos   //  2 Listar alumnos")
            Console.WriteLine(" 3 Alta de Notas     //  4 Resultados ")
            Console.WriteLine(" 0 Salir ")
            op = Console.ReadLine

            Select Case op
                Case menu.Altaalumno
                    Console.WriteLine("Ingrese nombre de alumno")
                    Dim nombre As String = Console.ReadLine
                    If ValidarCadena(nombre) Then
                        Console.WriteLine("Ingrese Codigo de Alumno: ")
                        Dim codigo As Integer = Console.ReadLine
                        If ValidarEntero(codigo) Then
                            If ValidarCodigo(codigo, Alumnos) Then
                                Alumnos.Add(codigo, nombre)
                                Console.WriteLine("Nombre y Claves agregados: " & nombre & "  " & codigo)
                                Console.WriteLine("Pulse enter para volver al menu principal")
                                Console.ReadKey()

                            End If
                        End If

                    End If


                Case menu.Listaalumnos
                    Console.WriteLine()
                    Console.WriteLine("Listado de alumnoss")
                    Console.WriteLine("Codigo    //  Nombre   ")
                    For Each alumno In Alumnos
                        Console.WriteLine(alumno.key & "       " & alumno.value)
                    Next

                Case menu.Altanotas
                    Console.WriteLine("notas")

                Case menu.Resultados
                    Console.WriteLine("resultados")

            End Select


        Loop While (op <> menu.salir)


        Console.WriteLine("Hola guido")

        Console.ReadKey()
    End Sub

    Public Function ValidarEntero(value As Integer) As Boolean

        If value < 9999 And value > 100 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function ValidarCadena(value As String) As Boolean

        If Len(value) > 5 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function ValidarLetra(value As Char) As Boolean
        If value = "A" Or value = "B" Or value = "C" Or value = "D" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ValidarCodigo(value As Integer, lista As Hashtable) As Boolean

        If lista.Contains(value) = False Then
            Return True
        Else
            Return False
        End If

    End Function

End Module
