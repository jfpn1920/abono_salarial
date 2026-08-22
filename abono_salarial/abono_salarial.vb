Imports System
Module abono_salarial
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim empleados(9) As String
        Dim salariosBase(9) As Double
        Dim tiposAbono(9) As String
        Dim valoresAbono(9) As Double
        Dim salariosFinales(9) As Double
        Dim fechas(9) As String
        Dim estados(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '--------------------------------------//
        '--|menu_principal_de_abono_salarial|--//
        '--------------------------------------//
        Do
            Console.WriteLine("menu principal de abono salarial")
            Console.WriteLine("1) Registrar abono")
            Console.WriteLine("2) Editar abono")
            Console.WriteLine("3) Listar abonos")
            Console.WriteLine("4) Buscar abono")
            Console.WriteLine("5) Eliminar abono")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '---------------------//
                '--|registrar_abono|--//
                '---------------------//
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas abonos.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.WriteLine("registro de abono")
                        Console.Write("Empleado: ")
                        empleados(cantidad) = Console.ReadLine()
                        Console.Write("Salario base: ")
                        salariosBase(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Tipo de abono: ")
                        tiposAbono(cantidad) = Console.ReadLine()
                        Console.Write("Valor del abono: ")
                        valoresAbono(cantidad) = Convert.ToDouble(Console.ReadLine())
                        salariosFinales(cantidad) = salariosBase(cantidad) + valoresAbono(cantidad)
                        Console.Write("Fecha del abono: ")
                        fechas(cantidad) = Console.ReadLine()
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Abono registrado correctamente.")
                    End If
                '------------------//
                '--|editar_abono|--//
                '------------------//
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen abonos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Empleado: " & empleados(i) & " | Salario base: " & salariosBase(i) & " | Tipo: " & tiposAbono(i) & " | Abono: " & valoresAbono(i) & " | Salario final: " & salariosFinales(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID del abono a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo empleado: ")
                            empleados(posicion) = Console.ReadLine()
                            Console.Write("Nuevo salario base: ")
                            salariosBase(posicion) = Convert.ToDouble(Console.ReadLine())
                            Console.Write("Nuevo tipo de abono: ")
                            tiposAbono(posicion) = Console.ReadLine()
                            Console.Write("Nuevo valor del abono: ")
                            valoresAbono(posicion) = Convert.ToDouble(Console.ReadLine())
                            salariosFinales(posicion) = salariosBase(posicion) + valoresAbono(posicion)
                            Console.Write("Nueva fecha del abono: ")
                            fechas(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.WriteLine("Abono actualizado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-------------------//
                '--|listar_abonos|--//
                '-------------------//
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen abonos registrados.")
                    Else
                        Console.WriteLine("lista de abonos")
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Empleado: " & empleados(i) & " | Salario base: " & salariosBase(i) & " | Tipo: " & tiposAbono(i) & " | Abono: " & valoresAbono(i) & " | Salario final: " & salariosFinales(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i))
                        Next
                    End If
                '------------------//
                '--|buscar_abono|--//
                '------------------//
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen abonos registrados.")
                    Else
                        Console.Write("Ingrese el ID del abono a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("abono encontrado")
                            Console.WriteLine("ID: " & ids(posicion) & " | Empleado: " & empleados(posicion) & " | Salario base: " & salariosBase(posicion) & " | Tipo: " & tiposAbono(posicion) & " | Abono: " & valoresAbono(posicion) & " | Salario final: " & salariosFinales(posicion) & " | Fecha: " & fechas(posicion) & " | Estado: " & estados(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '--------------------//
                '--|eliminar_abono|--//
                '--------------------//
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen abonos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Empleado: " & empleados(i) & " | Salario base: " & salariosBase(i) & " | Tipo: " & tiposAbono(i) & " | Abono: " & valoresAbono(i) & " | Salario final: " & salariosFinales(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID del abono a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                empleados(i) = empleados(i + 1)
                                salariosBase(i) = salariosBase(i + 1)
                                tiposAbono(i) = tiposAbono(i + 1)
                                valoresAbono(i) = valoresAbono(i + 1)
                                salariosFinales(i) = salariosFinales(i + 1)
                                fechas(i) = fechas(i + 1)
                                estados(i) = estados(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Abono eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If

                '---------------------//
                '--|mostrar_resumen|--//
                '---------------------//
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen abonos registrados.")
                    Else
                        Dim totalAbonos As Double = 0
                        Dim mayorAbono As Double = valoresAbono(0)
                        Dim posicionMayor As Integer = 0
                        Dim pendientes As Integer = 0
                        Dim pagados As Integer = 0
                        Dim cancelados As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            totalAbonos += valoresAbono(i)
                            If valoresAbono(i) > mayorAbono Then
                                mayorAbono = valoresAbono(i)
                                posicionMayor = i
                            End If
                            If estados(i).ToLower() = "pendiente" Then
                                pendientes += 1
                            ElseIf estados(i).ToLower() = "pagado" Then
                                pagados += 1
                            ElseIf estados(i).ToLower() = "cancelado" Then
                                cancelados += 1
                            End If
                        Next
                        Dim promedioAbono As Double = totalAbonos / cantidad
                        Console.WriteLine("resumen de abono salarial")
                        Console.WriteLine("Abonos registrados: " & cantidad & " | Total de abonos: " & totalAbonos & " | Promedio de abono: " & promedioAbono & " | Empleado con mayor abono: " & empleados(posicionMayor) & " | Mayor abono: " & mayorAbono & " | Pendientes: " & pendientes & " | Pagados: " & pagados & " | Cancelados: " & cancelados)
                    End If
                '------------------------------//
                '--|salir_del_menu_principal|--//
                '------------------------------//
                Case 7
                    Console.WriteLine("Gracias por utilizar Abono Salarial.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module