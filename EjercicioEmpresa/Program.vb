Imports System

Module Program
    Sub Main(args As String())
        Dim empleado2 As Empleado = New Empleado(1, "text", 1, 1, 1)
        Dim empleados As List(Of Empleado) = New List(Of Empleado)()

        Dim usuario2 As Usuario = New Usuario(1, "text")
        Dim usuarios As List(Of Usuario) = New List(Of Usuario)()

        Dim id As Integer
        Dim contrasena As String

        Dim nombre As String
        Dim dpto As Integer
        Dim edad As Integer
        Dim anosTrabajados As Integer

        FileOpen(1, "Archivo Log", OpenMode.Output)

        WriteLine(1, "Contenido del Log")

        Console.WriteLine("====Identificación del Usuario====")
        Do
            Console.WriteLine(vbCrLf + "Introduce el ID de usuario:")

            id = Console.ReadLine

            If id = 0 Then
                Exit Do
            End If

            Console.WriteLine("Introduce la contraseña:")
            contrasena = Console.ReadLine

            usuario2 = New Usuario(id, contrasena)

            For x = 0 To usuarios.Count - 1
                If usuarios(x).id1 = id Then
                    If contrasena <> usuarios(x).Contrasena1 Then
                        Console.WriteLine("Contraseña incorrecta")
                    ElseIf contrasena = usuarios(x).Contrasena1 Then
                        Console.WriteLine(vbCrLf + $"Nombre completo: {empleados(x).Nombre1}")
                        Console.WriteLine($"Edad: {empleados(x).Edad1}")
                        Console.WriteLine($"Tiempo laborado: {empleados(x).AnosTrabajados1} años")
                        Console.WriteLine($"Días correspondientes de vacaciones: {empleados(x).DiasVacaciones()}")
                        Console.WriteLine($"Sueldo correspondiente: {empleados(x).CalcularSueldo()} euros")

                        WriteLine(1)
                        WriteLine(1, empleados(x).Nombre1)
                        WriteLine(1)
                        WriteLine(1, empleados(x).Edad1)
                        WriteLine(1)
                        WriteLine(1, empleados(x).AnosTrabajados1)
                        WriteLine(1)
                        WriteLine(1, empleados(x).DiasVacaciones())
                        WriteLine(1)
                        WriteLine(1, empleados(x).CalcularSueldo())
                        WriteLine(1)
                        Exit For
                    End If
                ElseIf x = usuarios.Count - 1 Then
                    Console.WriteLine(vbCrLf + "====Registro de un nuevo Usuario====")

                    Console.WriteLine(vbCrLf + "Introduce el nombre completo")
                    nombre = Console.ReadLine

                    Console.WriteLine("Introduce el departamento(1,2,3)")
                    dpto = Console.ReadLine

                    Console.WriteLine("Introduce tu edad")
                    edad = Console.ReadLine

                    Console.WriteLine("Introduce la cantidad de años trabajados en la empresa")
                    anosTrabajados = Console.ReadLine

                    empleado2 = New Empleado(id, nombre, dpto, edad, anosTrabajados)
                    usuario2 = New Usuario(id, contrasena)
                    empleados.Add(empleado2)
                    usuarios.Add(usuario2)
                End If
            Next

            If usuarios.Count = 0 Then
                Console.WriteLine(vbCrLf + "====Registro de un nuevo Usuario====")

                Console.WriteLine(vbCrLf + "Introduce el nombre completo")
                nombre = Console.ReadLine

                Console.WriteLine("Introduce el departamento(1,2,3)")
                dpto = Console.ReadLine

                Console.WriteLine("Introduce tu edad")
                edad = Console.ReadLine

                Console.WriteLine("Introduce la cantidad de años trabajados en la empresa")
                anosTrabajados = Console.ReadLine

                Console.WriteLine(vbCrLf + "Usuario Registrado")

                empleado2 = New Empleado(id, nombre, dpto, edad, anosTrabajados)
                usuario2 = New Usuario(id, contrasena)
                empleados.Add(empleado2)
                usuarios.Add(usuario2)
            End If
        Loop Until id = 0

        Dim resultado = (empleado2.CalcularMediaSueldo(empleados)).Result
        Console.WriteLine(vbCrLf + $"Media del salario: {resultado} euros")

        Dim resultado2 = (empleado2.CalcularMediaDiasVacaciones(empleados)).Result
        Console.WriteLine($"Media de días de vacaciones: {resultado2}")

        FileClose(1)
    End Sub
End Module