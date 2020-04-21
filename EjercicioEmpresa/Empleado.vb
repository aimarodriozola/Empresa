Public Structure Empleado
    Private id As Integer
    Private nombre As String
    Private dpto As String
    Private edad As Integer
    Private anosTrabajados As Integer
    Private sueldo As Double
    Private vacaciones As Integer

    Public Sub New(id As Integer, nombre As String, dpto As String, edad As Integer, anosTrabajados As Integer)
        Me.id = id
        Me.nombre = nombre
        Me.dpto = dpto
        Me.edad = edad
        Me.anosTrabajados = anosTrabajados
    End Sub

    Public Property id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Dpto1 As String
        Get
            Return dpto
        End Get
        Set(value As String)
            dpto = value
        End Set
    End Property

    Public Property Edad1 As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = value
        End Set
    End Property

    Public Property AnosTrabajados1 As Integer
        Get
            Return anosTrabajados
        End Get
        Set(value As Integer)
            anosTrabajados = value
        End Set
    End Property

    Public Function CalcularSueldo()
        CalcularSueldo = 1500
        If edad < 18 Then
            Console.WriteLine($"{nombre} no tiene la edad suficiente para trabajar")
            CalcularSueldo = 0
        ElseIf edad >= 18 And edad <= 50 Then
            CalcularSueldo *= 1.05
        ElseIf edad >= 51 And edad <= 60 Then
            CalcularSueldo *= 1.1
        ElseIf edad > 60 Then
            CalcularSueldo *= 1.15
        End If
        sueldo = CalcularSueldo
    End Function

    Public Function DiasVacaciones()
        DiasVacaciones = 0
        If dpto = 1 And anosTrabajados >= 2 And anosTrabajados <= 6 Then
            DiasVacaciones = 15
        ElseIf dpto = 1 And anosTrabajados >= 7 Then
            DiasVacaciones = 20
        ElseIf dpto = 2 And anosTrabajados >= 2 And anosTrabajados <= 6 Then
            DiasVacaciones = 15
        ElseIf dpto = 2 And anosTrabajados >= 7 Then
            DiasVacaciones = 25
        ElseIf dpto = 3 And anosTrabajados >= 2 And anosTrabajados <= 6 Then
            DiasVacaciones = 15
        ElseIf dpto = 3 And anosTrabajados >= 7 Then
            DiasVacaciones = 30
        End If
    End Function

    Async Function CalcularMediaSueldo(arrayEmpleado As List(Of Empleado)) As Task(Of Double)
        Await Task.Delay(2)

        Dim MediaSueldo As Double

        For x = 0 To arrayEmpleado.Count - 1
            MediaSueldo += arrayEmpleado(x).CalcularSueldo()
        Next

        MediaSueldo /= arrayEmpleado.Count

        Return MediaSueldo
    End Function

    Async Function CalcularMediaDiasVacaciones(arrayEmpleado2 As List(Of Empleado)) As Task(Of Integer)
        Await Task.Delay(2)

        Dim MediaVacaciones As Integer

        For x = 0 To arrayEmpleado2.Count - 1
            MediaVacaciones += arrayEmpleado2(x).DiasVacaciones()
        Next

        MediaVacaciones /= arrayEmpleado2.Count

        Return MediaVacaciones
    End Function
End Structure
